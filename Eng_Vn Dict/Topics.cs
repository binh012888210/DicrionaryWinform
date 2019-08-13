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
using System.Runtime.InteropServices;

namespace Eng_Vn_Dict
{
    public partial class Topics : Form
    {
        List<User_Dict> uDict_list = new List<User_Dict>();
        char[] fMeaning = new char[5000];
        User_Dict oldUD = new User_Dict();

        int rtbHeight;
        int panelHeight;
        bool Hidden, IsShown, IsFinished;
        bool IsIncreased, IsDone;

        string oldFile;

        int TVIndex;
        public Topics()
        {
            InitializeComponent();
            //Cập nhật topic 
            updateTopic(tList);
            updateTopic(tName_Box);
            //Thêm Tooltip cho các nút
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(tAdd_Button, "Add");
            tp1.AutoPopDelay = 750;

            ToolTip tp2 = new ToolTip();
            tp2.SetToolTip(tEdit_Button, "Update");
            tp2.AutoPopDelay = 750;

            ToolTip tp3 = new ToolTip();
            tp3.SetToolTip(tRemove_Button, "Remove");
            tp3.AutoPopDelay = 750;

            ToolTip tp4 = new ToolTip();
            tp4.SetToolTip(tButton, "Control");
            tp4.AutoPopDelay = 750;
            //Khởi tao giá trị ban đầu cho các biến
            TVIndex = -1;
            panelHeight = OPanel.Height;
            rtbHeight = tMeaning.Height;
            oldFile = string.Empty;
            Hidden = true;
            IsFinished = false;
            IsShown = false;
            IsIncreased = true;
            IsDone = false;
        }
        //Sử dụng Double-buffer
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        //Load form
        private void Topics_Load(object sender, EventArgs e)
        {
            runTime.Start();
        }
        //Sự kiện cập nhật form theo thời gian
        private void runTime_Tick(object sender, EventArgs e)
        {
            tAdd_Button.Enabled = !tEdit_Button.Enabled;

            if (TVIndex != -1)
            {
                tName_Update.Visible = true;

                tName_Box.Enabled = false;
                tName_Box.Visible = false;
            }
            else
            {
                tName_Update.Enabled = false;
                tName_Update.Visible = false;

                tName_Box.Enabled = true;
                tName_Box.Visible = true;

                tWord_Box.Enabled = true;
                tMeaning.Enabled = true;
            }
        }
        //tList - Event khi thay đổi vị trí trong box
        private void tList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tWrdList.Nodes.Clear();
            uDict_list.Clear();
            tMeaning.Clear();
            //Load file và nạp vào tWrdList và tList
            updateTreeView(tList);
        }
        //tWrd_List - Event khi chọn node   
        private void tWrdList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tWrdList.SelectedNode = e.Node;
            TVIndex = e.Node.Index;
            //Xuất nghĩa
            for (int i = 0; i <= uDict_list.Count() - 1; i++)
            {
                if (e.Node.Text == uDict_list[i].Word)
                {

                    tMeaning.Text = uDict_list[i].getfMeaning(uDict_list[i].Meaning);
                }
            }
            //Kích hoạt nút Edit và Remove
            if (tWrdList.SelectedNode != null)
            {
                tEdit_Button.Enabled = true;
                tRemove_Button.Enabled = true;
            }
            //Kiểm tra cái mà người dùng muốn update
            if (tEdit_Button.Enabled && tRemove_Button.Enabled)
            {
                if (checkChild(tWrdList.SelectedNode) && checkParent(tWrdList.SelectedNode) && (TVIndex == 0))
                {
                    tName_Update.Text = e.Node.Text;
                    oldFile = e.Node.Text;
                    tName_Update.Enabled = true;
                    tWord_Box.Enabled = false;
                    tMeaning.Enabled = false;
                }
                else
                {
                    tWord_Box.Text = e.Node.Text;
                    oldUD.Word = e.Node.Text;
                    oldUD.Meaning = tMeaning.Text;
                    tName_Update.Enabled = false;
                    tWord_Box.Enabled = true;
                    tMeaning.Enabled = true;
                }
            }
            else
            {
                tName_Box.Enabled = true;
                tName_Box.Enabled = false;

                tWord_Box.Enabled = true;
                tMeaning.Enabled = true;
            }
        }
        //Hàm cập nhật TreeView
        private void updateTreeView(ComboBox combo)
        {
            tWrdList.Nodes.Clear();
            uDict_list.Clear();

            string fileName = combo.Text + ".txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Topics\", fileName);
            //Thêm Root
            TreeNode root = new TreeNode() { Text = combo.Text };
            tWrdList.Nodes.Add(root);

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split('\t');
                User_Dict new_uDict = new User_Dict();
                new_uDict.Word = entries[0];
                new_uDict.Meaning = entries[1];
                uDict_list.Add(new_uDict);
            }
            //Thêm nodes cho root
            for (int i = 0; i < uDict_list.Count; i++)
            {
                TreeNode node = new TreeNode { Text = uDict_list[i].Word };
                root.Nodes.Add(node);
            }
            //TreeView tự động sổ ra
            tWrdList.ExpandAll();
        }
        //Hàm cập nhật danh sách topic
        private void updateTopic(ComboBox combo)
        {
            combo.Items.Clear();
            //Lấy file "*.txt" trong thư mục ra
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Topics\");
            DirectoryInfo d = new DirectoryInfo(filePath);
            FileInfo[] Files = d.GetFiles("*.txt");
            //Lấy tên file và bỏ phần đuôi .txt rồi thêm vào ComboBox
            string str = string.Empty;
            foreach (FileInfo file in Files)
            {
                str = file.Name;
                string f = str.Substring(0, str.Length - 4);
                combo.Items.Add(f);
            }
        }
        //Kiểm tra node đang chọn có node con
        private bool checkChild(TreeNode e)
        {
            if (e.Nodes.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Kiểm tra node đang chọn có phải là node cha
        private bool checkParent(TreeNode e)
        {
            if (e.Parent == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Rút các ký tự xuống dòng
        private void breakNewLine(string str)
        {
            fMeaning = str.ToCharArray();
            for (int ctr = 0; ctr < fMeaning.Length; ctr++)
            {
                if (fMeaning[ctr] == '\n')
                {
                    fMeaning[ctr] = '@';
                }
            }
        }

        #region:Add
        //Thêm Topic
        private void addTopic(string str)
        {
            string fileName = str + ".txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Topics\", fileName);
            //Kiểm tra file có tồn tại hay không - tạo nếu không có
            if (!File.Exists(filePath))
            {
                var myFile = File.Create(filePath);
                updateTopic(tList);
                updateTopic(tName_Box);
                myFile.Close();
            }
            else
            {
                const string message = "Chủ đề này đã tồn tại";
                const string caption = "Thông báo";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tName_Box.Focus();
                return;
            }
        }
        //Thêm từ và nghĩa
        private void addWord_Meaning()
        {
            string fileName = tName_Box.Text + ".txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Topics\", fileName);
            StreamWriter sw = File.AppendText(filePath);

            string input = tWord_Box.Text + "\t" + new string(fMeaning);
            sw.WriteLine(input);
            sw.Close();
        }
        //Kiểm tra topic đã có hay chưa
        private bool checkExistedTopic()
        {
            int count = 0;
            for (int i = 0; i < tName_Box.Items.Count; i++)
            {
                string value = tName_Box.GetItemText(tName_Box.Items[i]);
                if (tName_Box.Text == value)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                return true;
            }
            else return false;
        }
        //Kiểm tra từ đã có chưa
        private bool checkExistedWord()
        {
            int count = 0;
            for (int i = 0; i < uDict_list.Count; i++)
            {
                string value = uDict_list[i].Word;
                if (tWord_Box.Text == value)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                return true;
            }
            else return false;
        }
        //Chức năng nút Add
        private void tAdd_Button_Click(object sender, EventArgs e)
        {
            if (tName_Box.Text != string.Empty)
            {
                if (checkExistedTopic())
                {
                    if (tWord_Box.Text != string.Empty)
                    {
                        if (!checkExistedWord())
                        {
                            if (tMeaning.Text != string.Empty)
                            {
                                breakNewLine(tMeaning.Text);
                                addWord_Meaning();
                                updateTreeView(tName_Box);
                                updateTopic(tName_Box);
                                updateTopic(tList);
                                tList.Text = tName_Box.Text; // Xuất lại tên topic vừa được thay đổi
                                tWord_Box.Clear();
                                tMeaning.Clear();
                            }
                            else
                            {
                                const string message = "Bạn cần nhập nghĩa của từ";
                                const string caption = "Thông báo";
                                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tMeaning.Focus();
                                return;
                            }
                        }
                        else
                        {
                            const string message = "Từ này đã tồn tại";
                            const string caption = "Thông báo";
                            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tWord_Box.Focus();
                            return;
                        }
                    }
                    else
                    {
                        const string message = "Ban cần nhập từ";
                        const string caption = "Thông báo";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tWord_Box.Focus();
                        return;
                    }
                }
                else
                {
                    if (tWord_Box.Text != string.Empty)
                    {
                        if (tMeaning.Text != string.Empty)
                        {
                            fMeaning = tMeaning.Text.ToCharArray();
                            for (int ctr = 0; ctr < fMeaning.Length; ctr++)
                            {
                                if (fMeaning[ctr] == '\n')
                                {
                                    fMeaning[ctr] = '@';
                                }
                            }
                            addTopic(tName_Box.Text);
                            addWord_Meaning();
                            updateTreeView(tName_Box);
                            updateTopic(tName_Box);
                            updateTopic(tList);
                            tList.Text = tName_Box.Text; // Xuất lại tên topic vừa được thay đổi
                            tWord_Box.Clear();
                            tMeaning.Clear();
                        }
                        else
                        {
                            const string message = "Bạn cần nhập nghĩa của từ";
                            const string caption = "Thông báo";
                            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tMeaning.Focus();
                            return;
                        }
                    }
                    else
                    {
                        const string message = "Ban cần nhập từ";
                        const string caption = "Thông báo";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tWord_Box.Focus();
                        return;
                    }
                }
            }
            else
            {
                const string message = "Ban cần nhập chủ đề";
                const string caption = "Thông báo";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tName_Box.Focus();
                return;
            }
        }

        #endregion

        #region:Edit(Update)
        //Hàm cập nhật TreeView sau khi chỉnh sửa
        private void editTreeView()
        {
            tWrdList.Nodes.Clear();
            uDict_list.Clear();

            string fileName = tName_Update.Text + ".txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Topics\", fileName);
            //Thêm Root
            TreeNode root = new TreeNode() { Text = tName_Update.Text };
            tWrdList.Nodes.Add(root);

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split('\t');
                User_Dict new_uDict = new User_Dict();
                new_uDict.Word = entries[0];
                new_uDict.Meaning = entries[1];
                uDict_list.Add(new_uDict);
            }
            //Thêm nodes cho root
            for (int i = 0; i < uDict_list.Count; i++)
            {
                TreeNode node = new TreeNode { Text = uDict_list[i].Word };
                root.Nodes.Add(node);
            }
            //TreeView tự động sổ ra
            tWrdList.ExpandAll();
        }
        //Hàm chức năng của nút Update
        private void tEdit_Button_Click(object sender, EventArgs e)
        {
            if (tWrdList.SelectedNode != null)
            {
                if (tName_Update.Enabled)
                {
                    editTopic(oldFile, tName_Update.Text);
                    editTreeView();
                    updateTopic(tList);
                    updateTopic(tName_Box);
                    tName_Update.Clear();
                }
                else
                {
                    editWordMeaning(oldUD, tWord_Box.Text, tMeaning.Text);
                    updateTreeView(tList);
                    tWord_Box.Clear();
                    tMeaning.Clear();
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn từ hay chủ đề");
            }
        }
        //Hàm chỉnh sửa cho topic
        private void editTopic(string o_str, string n_str)
        {
            try
            {
                string oldFileName = o_str + ".txt";
                string newFileName = n_str + ".txt";
                string oldFilePath = Path.Combine(Environment.CurrentDirectory, @"Topics\", oldFileName);
                string newFilePath = Path.Combine(Environment.CurrentDirectory, @"Topics\", newFileName);

                if (File.Exists(newFilePath))
                {
                    const string message = "File này đã tồn tại";
                    const string caption = "Lỗi";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tName_Update.Focus();
                    return;
                }
                File.Move(oldFilePath, newFilePath);
                tList.Text = tName_Update.Text;
            }
            catch
            {

            }
        }
        //Hàm chỉnh sửa cho từ và nghĩa
        private void editWordMeaning(User_Dict o_UD, string n_word, string n_meaning)
        {
            uDict_list.Clear();
            breakNewLine(n_meaning);

            string linetowrite = string.Format("{0}\t{1}", n_word, n_meaning);
            string fileName = tList.Text + ".txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Topics\", fileName);

            List<string> lines = File.ReadAllLines(filePath).ToList();
            string[] arrLine = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                string[] entries = line.Split('\t');
                User_Dict new_uDict = new User_Dict();
                new_uDict.Word = entries[0];
                new_uDict.Meaning = entries[1];
                uDict_list.Add(new_uDict);
            }

            if (!checkExistedWord())
            {
                for (int i = 1; i <= uDict_list.Count; i++)
                {
                    if (o_UD.Word == uDict_list[i - 1].Word && o_UD.Meaning == uDict_list[i - 1].Meaning)
                    {
                        arrLine[i - 1] = linetowrite;
                        File.WriteAllLines(filePath, arrLine, Encoding.UTF8);
                    }
                }
            }
            else
            {
                const string message = "Từ này đã tồn tại";
                const string caption = "Thông báo";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tWord_Box.Focus();
                return;
            }

        }
        #endregion

        #region:Remove
        private void tRemove_Button_Click(object sender, EventArgs e)
        {
            if (tWrdList.SelectedNode != null)
            {
                if (tName_Update.Enabled)
                {
                    removeTopic();
                    updateTopic(tList);
                    updateTopic(tName_Box);
                    tName_Update.Clear();
                }
                else
                {
                    removeWordMeaning();
                    updateTreeView(tList);
                    tWord_Box.Clear();
                    tMeaning.Clear();
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn từ hay chủ đề");
            }
        }
        //Xóa chủ đề
        private void removeTopic()
        {
            string fileName = tWrdList.SelectedNode.Text + ".txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Topics\", fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                tWrdList.SelectedNode.Remove();
            }
            else
            {
                const string message = "Không thể thực hiện";
                const string caption = "Lỗi";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        //Xóa từ và nghĩa
        private void removeWordMeaning()
        {
            uDict_list.Clear();

            string fileName = tList.Text + ".txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"Topics\", fileName);

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split('\t');
                User_Dict new_uDict = new User_Dict();
                new_uDict.Word = entries[0];
                new_uDict.Meaning = entries[1];
                uDict_list.Add(new_uDict);
            }

            for (int i = 1; i <= lines.Count; i++)
            {
                User_Dict ud = new User_Dict();
                ud.Word = uDict_list[i - 1].Word;
                if (tWrdList.SelectedNode.Text == ud.Word)
                {
                    tWrdList.SelectedNode.Remove();
                    lines.RemoveAt(i - 1);
                    File.WriteAllLines(filePath, lines, Encoding.UTF8);
                }
            }

        }
        #endregion

        #region:MouseDown_Event
        //Kiểm tra các tình huống để kích hoạt các nút chức năng
        //tList - ComboBox topic
        private void tList_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }
        //tMeaning - Khung nghĩa
        private void tMeaning_MouseDown(object sender, MouseEventArgs e)
        {
            if (tMeaning.ReadOnly == true)
            {
                TVIndex = -1;
                tWrdList.SelectedNode = null;
                tEdit_Button.Enabled = false;
                tRemove_Button.Enabled = false;
            }
        }
        //tAdd_Button - Nút Add
        private void tAdd_Button_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tWrdList.SelectedNode = null;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }
        //WPanel - Panel của khung từ 
        private void WPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tWrdList.SelectedNode = null;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }
        //OPanel - Panel chính của các nút chức năng
        private void OPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tWrdList.SelectedNode = null;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }
        //MPanel - Panel của khung nghĩa
        private void MPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tWrdList.SelectedNode = null;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }
        //OpPanel - Panel của các nút chức năng
        private void OpPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tWrdList.SelectedNode = null;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }
        //SPanel - Panel của vùng thực hiện chức năng
        private void SPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tWrdList.SelectedNode = null;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }
        //EPanel - Panel của nút kích hoạt trượt
        private void EPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tWrdList.SelectedNode = null;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }
        //label1 - Topic Name
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tWrdList.SelectedNode = null;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }
        //label2 - Word
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            TVIndex = -1;
            tWrdList.SelectedNode = null;
            tEdit_Button.Enabled = false;
            tRemove_Button.Enabled = false;
        }



        #endregion

        #region:Sliding
        //Kích hoạt slide panel
        private void tButton_Click(object sender, EventArgs e)
        {
            Timer1.Start();
            Timer2.Start();
            tButton.Enabled = false;

            if (TVIndex == -1)
            {
                tWord_Box.Clear();
                tMeaning.Clear();
            }
            else
            {
                tWord_Box.Clear();
            }


            if (tMeaning.ReadOnly != !tMeaning.ReadOnly)
            {
                tMeaning.ReadOnly = !tMeaning.ReadOnly;
            }
        }
        //Event tick của panel chứa các nút chức năng
        private void Timer2_Tick(object sender, EventArgs e)
        {
            //OpPanel_Sliding
            if (IsShown)
            {
                if (IsFinished)
                {
                    OpPanel.Width -= 10;
                    if (OpPanel.Width <= 0)
                    {
                        Timer2.Stop();
                        IsShown = false;
                        IsFinished = false;
                        this.Update();
                        tButton.Enabled = true;
                    }
                }
            }
            else
            {
                IsFinished = false;
                OpPanel.Width += 10;
                if (OpPanel.Width >= (OPanel.Width - EPanel.Width))
                {
                    Timer2.Stop();
                    IsShown = true;
                    IsFinished = true;
                    this.Update();
                }
            }
        }
        //Event tick của panel chứa control thao tác dữ liệu
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //SPanel_Sliding
            IsDone = false;
            if (Hidden)
            {
                if (IsFinished)
                {
                    IsIncreased = true;
                    IsDone = true;
                    SPanel.Height += 10;
                    if (SPanel.Height >= panelHeight * 2)
                    {
                        Timer1.Stop();
                        Hidden = false;
                        this.Update();
                        IsFinished = false;
                        tButton.Enabled = true;
                    }
                }
            }
            else
            {
                IsIncreased = false;
                IsDone = true;
                SPanel.Height -= 10;
                if (SPanel.Height <= 0)
                {
                    Timer1.Stop();
                    Hidden = true;
                    this.Update();
                    IsFinished = true;
                }
            }
            //MPanel_Sliding
            if (IsDone)
            {
                if (IsIncreased)
                {
                    tMeaning.Height -= 10;
                    if (tMeaning.Height >= ((rtbHeight - panelHeight * 2)))
                    {
                        this.Update();
                    }
                }
                else
                {
                    tMeaning.Height += 10;
                    if (tMeaning.Height <= rtbHeight)
                    {
                        this.Update();
                    }
                }
            }
        }
        #endregion
    }
}

