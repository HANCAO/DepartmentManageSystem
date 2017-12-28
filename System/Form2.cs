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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        class Department
        {
            private string _depshort;
            private string _depname;
            private string _depmanger;
            private string _mangertel;
            private string _depbuild;
            public string DepShort
            {
                get { return _depshort; }
                set { _depshort = value; }
            }
            public string DepName
            {
                get { return _depname; }
                set { _depname = value; }
            }
            public string DepManager
            {
                get { return _depmanger; }
                set { _depmanger = value; }
            }
            public string MangerTel
            {
                get { return _mangertel; }
                set { _mangertel = value; }
            }
            public string DepBuild
            {
                get { return _depbuild; }
                set { _depbuild = value; }
            }
        }

        List<Department> DepInfo = new List<Department>();

        void FillType()
        {
            ComboType.Items.Clear();
            StreamReader sr = new StreamReader("dept.txt", Encoding.Default);
            try
            {
                while(!sr.EndOfStream)
                {
                    string Item = sr.ReadLine();
                    if(Item!="")
                    {
                        ComboType.Items.Add(Item);
                    }
                }
                ComboType.Text = ComboType.Items[0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "出错", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                sr.Close();
            }
        }

        void GetData()
        {
            DepInfo.Clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
