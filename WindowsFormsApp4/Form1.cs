using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        System.IO.FileInfo fi;
        OpenFileDialog Fd = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();

            Fd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //saveOpenFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }


        void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> text1 = Mas();

            string []text = text1.ToArray();
            Array.Sort(text);

            if (text.Length == 0)
            {
                MessageBox.Show("Файл пуст");
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    listBox1.Items.Add(text[i]);
                }
                MessageBox.Show("Файл открыт");
            }


        }

        public List<string> Mas()
        {
            List<string> text = new List<string>();
            if (Fd.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            // получаем выбранный файл
            string filename = Fd.FileName;
            // читаем файл в строку
            string[] fileText = System.IO.File.ReadAllLines(filename, Encoding.GetEncoding(1251));
            for (int i = 0; i <fileText.Length; i++)
            {
                text.Add(fileText[i]); 
            }
            return text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] text;
            text = new string[listBox1.Items.Count];
            
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                text[i] = listBox1.Items[i].ToString();
            }
            string main = text[0];
            string tmp;
            int o = 0;
            int c = 0;
            char jk;
            int jj = 0;
            string[] text1 = new string[3];
            int p = 0;
            int rez = 0;
            string word;
                for (int l = 1; l < listBox1.Items.Count; l++)
                {
                    tmp = text[1];
                    string tmp1 = text[1];
                    while (tmp.Length != 0)
                    {
                        rez = main.IndexOf(tmp);
                        if (rez >= 0)
                        {
                        
                        if ((rez - main.Length) * (-1) == tmp.Length )
                            {
                                p = tmp.Length;
                                tmp1 = tmp1.Substring(p);
                                word = main + tmp1;
                                MessageBox.Show(word);
                                break;
                            }
                            else
                            {
                            tmp = tmp.Substring(0, tmp.Length - 1);
                            MessageBox.Show(tmp.Length.ToString());
                            }
                        }
                        else if (rez == -1 && tmp.Length == 1)
                        {

                        word = main + tmp1;
                        MessageBox.Show(word);
                        break;
                        //MessageBox.Show(rez.ToString());
                        }
                        else if (rez == -1)
                        {
                           
                             tmp = tmp.Substring(0, tmp.Length-1);
                             word = ("no");
                            MessageBox.Show(tmp.Length.ToString());
                        }
                        
                }
                
                }
            



        }
    }
}
