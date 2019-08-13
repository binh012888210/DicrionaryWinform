using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Speech.Synthesis;
using System.IO;

namespace Eng_Vn_Dict
{
    public partial class EngtoVnDict : Form
    {
        List<Dict> dictionary = new List<Dict>();
        string Word; // Dùng để lấy từ đang tìm kiếm trong wordsearch ra;
        int tempIndex = 0;//vi tri cua tu da search
        int[] tempSearch = new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };//day chi là 20 gia tri khoi tao tam thoi khong co gia tri su dung
        //Initial
        public EngtoVnDict()
        {
            InitializeComponent();
            createWordList();
        }
        //Read data from file
        private void createWordList()
        {
            string fileName = "anhviet109K.index";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"EV\", fileName);

            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split('\t');
                Dict newDict = new Dict();
                newDict.word = entries[0].ToLower();
                newDict.offset = entries[1];
                newDict.range = entries[2];
                dictionary.Add(newDict);
            }
            wordList.MouseWheel += new MouseEventHandler(mouseWheelIsMoved);
            addWordToWordList(tempIndex);
        }
        //Add word 
        public void addWordToWordList(int initNum)
        {
            wordList.Items.Clear();
            for (int i = initNum; i < initNum + 31; i++)
            {
                if (i < dictionary.Count)
                    wordList.Items.Add(dictionary[i].word);
                else
                    break;
            }

        }
        //Load item - Lazy load
        private void mouseWheelIsMoved(object sender, MouseEventArgs e)
        {
            int numberOfTextLinesToMove = (e.Delta * SystemInformation.MouseWheelScrollLines / 120);
            int a = tempIndex - numberOfTextLinesToMove;//lan len num la so duong lan xuong num la so am
            if (a >= 0)
            {
                tempIndex = a;
                addWordToWordList(tempIndex);
            }
        }
        //Search by type
        private void wordSearch_TextChanged(object sender, EventArgs e)
        {

            wordSearch.Select(wordSearch.TextLength, 0);
            wordSearch.Text = wordSearch.Text.Trim().ToLower();
            if (wordSearch.Text.Count() > 2 && wordSearch.Text[0] != 'a')
            {
                if (wordSearch.Text[0] == wordSearch.Text[1] && wordSearch.Text[1] == wordSearch.Text[2])
                {
                    MessageBox.Show("Vui lòng không spam đứng máy", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    wordSearch.Clear();
                }
            }
            if (wordSearch.Text.Count() == 0)
            {
                tempIndex = 0;
                tempSearch[0] = 0;
            }
            if (wordSearch.Text.Count() == 1)// chay truoc de tang toc ham tim kiem chinh 
            {
                int i = 0;
                while (i < dictionary.Count())
                {
                    if (wordSearch.Text.ToString() == dictionary[i].word.Substring(0, 1))
                    {
                        tempSearch[0] = i;
                        break;
                    }
                    else
                        i++;
                }

            }
            if (wordSearch.Text.Count() < 20 && wordSearch.Text.Count() > 0)
            {
                int i = tempSearch[wordSearch.Text.Count() - 1];
                {
                    while (i < dictionary.Count())
                    {
                        if (wordSearch.Text.Count() < dictionary[i].word.Count())//wrs<dict
                        {
                            if (wordSearch.Text.ToString() == dictionary[i].word.Substring(0, wordSearch.Text.Count()))
                            {
                                tempIndex = i;
                                break;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        else
                        {
                            if (wordSearch.Text.Count() == dictionary[i].word.Count())//wrs==dict
                            {
                                if (wordSearch.Text.ToString() == dictionary[i].word)
                                {
                                    tempIndex = i;
                                    break;
                                }
                                else
                                {
                                    i++;
                                }
                            }
                            else//wrs>dict
                            {
                                i++;
                            }
                        }

                    }
                }
                tempSearch[wordSearch.Text.Count()] = i;
            }
            addWordToWordList(tempIndex);
            wordList.SelectedIndex = 0;

            int initiator = getDecValue(dictionary[tempIndex].offset);
            int finisher = getDecValue(dictionary[tempIndex].range);
            wordMeaning.Text = dictionary[tempIndex].getMeaning(initiator, finisher);

            Word = wordList.SelectedItem.ToString();//bien word dung de add favorite
        }
        //Search by select item
        private void wordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = getPositionInDict(wordList.SelectedItem.ToString());
            int initiator = getDecValue(dictionary[pos].offset);
            int finisher = getDecValue(dictionary[pos].range);
            wordMeaning.Text = dictionary[pos].getMeaning(initiator, finisher);
            Word = wordList.SelectedItem.ToString();
            ChangeFavoriteStarIcon(favoriteStarCheckFunction());
        }
        private int getPositionInDict(string str)
        {
            int i = 0;
            while (str != dictionary[i].word)
                i++;
            return i;
        }
        //Decoding code function
        private int getDecValue(string str)
        {
            char[] chars = str.ToCharArray();
            int decValue = 0, charValue = 0;
            string g64bValue = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
            int len = chars.Length;
            for (int i = 0; i < len; i++)
            {
                // Get based 64 value
                charValue = g64bValue.IndexOf(chars[i]);
                // Calculate power value
                decValue += (int)Math.Pow(64, len - i - 1) * charValue;
            }
            return decValue;
        }//ham chuyen ma thap phan de doc nghia cua tu trong file .dict

        //View image click
        private void viewImageButton_Click(object sender, EventArgs e)
        {
            Image img;
            string fileName = Word + ".jpg";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Picture\", fileName);
            if (File.Exists(filePath))
            {
                img = Image.FromFile(filePath);
                pictureBox.Image = img;
            }
            else
            {
                MessageBox.Show("File image is not found.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                pictureBox.Image = null;
            }
        }
        //Speech click
        private void speakButton_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.Rate = 5;
            voice.Volume = 100;
            if (Word == null)
            {
                voice.Speak("U I T");
            }
            else voice.Speak(Word);
        }// ham doc tu
        //Menu strip close
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Menu strip speech to text
        private void Speech2Text_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["SpeechtoText"] as SpeechtoText) != null)
            {
                return;
            }
            else
            {
                var newForm = new SpeechtoText();
                newForm.ShowDialog();
            }
        }
        //Add topic
        private void addTopics_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Topics"] as Topics) != null)
            {
                return;
            }
            else
            {
                var tp = new Topics();
                tp.ShowDialog();
            }
        }


        //Add favorite word
        //Menu strip Favorite Words
        private void favoriteWordsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddFavoriteWords"] as AddFavoriteWords) != null)
            {
                return;
            }
            else
            {
                AddFavoriteWords addfavoriteWord = new AddFavoriteWords();
                addfavoriteWord.getWordFromFavoriteList = new AddFavoriteWords.GetWordFromFavoriteList(getWordFromFavoriteForm);//cấp quyền cho getWordFromFavoriteList
                addfavoriteWord.ShowDialog();
            }
        }
        public void getWordFromFavoriteForm(string word)
        {
            int pos = getPositionInDict(word);
            int initiator = getDecValue(dictionary[pos].offset);
            int finisher = getDecValue(dictionary[pos].range);
            wordMeaning.Text = dictionary[pos].getMeaning(initiator, finisher);
            wordSearch.Text = word;
            Word = word;
            ChangeFavoriteStarIcon(favoriteStarCheckFunction());
        }
        //Cac ham con cua add favorite
        private void addFavortiteWord_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, @"AddFavoriteWords\FavoriteWords.txt");
                
                if (favoriteStarCheckFunction() == false)
                {
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    lines.Add(Word);
                    File.WriteAllLines(filePath, lines);
                }
                else
                {
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (lines[i].ToString() == Word)
                            lines.Remove(Word);
                    }
                    File.WriteAllLines(filePath, lines);
                }
            }
            catch
            {
                MessageBox.Show("Không thể mở file FavoriteWords.txt ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void addFavortiteWord_MouseEnter(object sender, EventArgs e)
        {
            if (favoriteStarCheckFunction() == false)
            {
                //Load a yellow star icon from the debug file.
                string filePath = Path.Combine(Environment.CurrentDirectory, @"FavouriteIcon\Oxygen-Icons.org-Oxygen-Actions-rating.ico");
                Bitmap bmpYellowStar = new Bitmap(filePath);
                addFavortiteWords.BackgroundImage = bmpYellowStar;
            }
        }
        private void addFavortiteWord_MouseLeave(object sender, EventArgs e)
        {
            if (favoriteStarCheckFunction() == false)
            {
                //load a white star icon from the debug file.
                string filePath = Path.Combine(Environment.CurrentDirectory, @"FavouriteIcon\Icojam-Onebit-Star-0.ico");
                Bitmap bmpWhiteStar = new Bitmap(filePath);
                addFavortiteWords.BackgroundImage = bmpWhiteStar;
            }
        }
        private bool favoriteStarCheckFunction()
        {
            try
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, @"AddFavoriteWords\FavoriteWords.txt");
                List<string> lines = File.ReadAllLines(filePath).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].ToString() == Word)
                    {
                        return true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể mở file FavoriteWords.txt ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }
        public void ChangeFavoriteStarIcon(bool favStarCheck1)//favStarCheck1 chi la bien cua ham nay, favStarCheck la bien toan cuc
        {
            if (favStarCheck1 == true)
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, @"FavouriteIcon\Oxygen-Icons.org-Oxygen-Actions-rating.ico");
                Bitmap bmpYellowStar = new Bitmap(filePath);
                addFavortiteWords.BackgroundImage = bmpYellowStar;
            }
            else
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, @"FavouriteIcon\Icojam-Onebit-Star-0.ico");
                Bitmap bmpWhiteStar = new Bitmap(filePath);
                addFavortiteWords.BackgroundImage = bmpWhiteStar;
            }
        }
        
    }
}
// cập nhat ham view image