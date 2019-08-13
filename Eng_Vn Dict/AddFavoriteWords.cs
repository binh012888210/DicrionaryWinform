using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Eng_Vn_Dict
{
    public partial class AddFavoriteWords : Form
    {
        string Word2;
        int selectedItem = 0;
        public delegate void GetWordFromFavoriteList(string word);
        public GetWordFromFavoriteList getWordFromFavoriteList;
        public AddFavoriteWords()
        {
            InitializeComponent();
            try
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, @"AddFavoriteWords\FavoriteWords.txt");
                DirectoryInfo d = new DirectoryInfo(filePath);

                List<string> lines = File.ReadAllLines(filePath).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    listMeaning.Items.Add(lines[i].ToString());
                }
                if (listMeaning.Items.Count > 0)
                {
                    listMeaning.SelectedIndex = 0;
                }
            }
            catch
            {
                MessageBox.Show("Không thể mở file FavoriteWords.txt ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void listMeaning_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = listMeaning.SelectedIndex;
        }
        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (listMeaning.Items.Count > 0)//neu listmeaing co du lieu moi co the thuc hien viec xoa
            {
                Remove_word(listMeaning.SelectedItem.ToString());
                listMeaning.Items.RemoveAt(selectedItem);
                this.listMeaning.Focus();
                this.listMeaning.ClearSelected();
                if (listMeaning.Items.Count > 0)//neu listmeaing co du lieu moi co the auto gan cho SelectedIndex = 0
                    listMeaning.SelectedIndex = 0;
            }
        }
        public void Remove_word(string word)
        {
            if (word != null)
            {
                string filePath = Path.Combine(Environment.CurrentDirectory, @"AddFavoriteWords\FavoriteWords.txt");
                List<string> lines = File.ReadAllLines(filePath).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].ToString() == word)
                        lines.Remove(word);
                }
                File.WriteAllLines(filePath, lines);
            }
        }
        private void Remove_All_Click(object sender, EventArgs e)
        {
            if (listMeaning.Items.Count > 0)
            {
                listMeaning.Items.Clear();
                string filePath = Path.Combine(Environment.CurrentDirectory, @"AddFavoriteWords\FavoriteWords.txt");
                List<string> lines = File.ReadAllLines(filePath).ToList();

                lines.RemoveRange(0, lines.Count);
                File.WriteAllLines(filePath, lines);
            }
        }
        private void Search_And_Close_Click(object sender, EventArgs e)
        {
            if (listMeaning.Items.Count > 0)
            {
                getWordFromFavoriteList(listMeaning.SelectedItem.ToString());
                Close();
            }
        }
    }
}