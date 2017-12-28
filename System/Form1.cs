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

namespace System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class User
        {
            private string _name;
            private string _password;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Password
            {
                get { return _password; }
                set { _password = value; }
            }
        }

        
        StreamReader sr = new StreamReader("user.txt", Encoding.Default);
        

        private void Login_Click(object sender, EventArgs e)
        {
            if (tBUserName.Text == "")
            {
                MessageBox.Show("请输入用户名称", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tBUserPWD.Text == "")
            {
                MessageBox.Show("请输入密码", "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                    User _user = new User();
                    _user.Name = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        //if (_user.Name != "")
                        //{
                        _user.Password = sr.ReadLine();
                        if (tBUserName.Text == _user.Name && tBUserPWD.Text == _user.Password)
                        {
                            this.Hide();
                            Form2 frm2 = new Form2();
                            frm2.Tag = tBUserName.Text;
                            frm2.Show();
                        }
                        else if (tBUserName.Text != _user.Name)
                        {
                            MessageBox.Show("用户名错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tBUserName.Focus();
                        }
                        else if (tBUserPWD.Text != _user.Password)
                        {
                            MessageBox.Show("密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tBUserPWD.Focus();
                        }
                        else
                        {
                            MessageBox.Show("用户名及密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tBUserName.Focus();
                        }
                        //}
                    }
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            tBUserName.Text = "";
            tBUserPWD.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click(null, null);
            }
        }
    }
}
