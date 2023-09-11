using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace معلومات
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // label3.Visible = true;
          //  pictureBox1.Visible = true;
            listBox1.Items.Clear();
           listBox1.Items.Add("الاسم الاول :"+textBox1.Text);
            listBox1.Items.Add("القبيلة :" + textBox2.Text);
            listBox1.Items.Add("===============");
          
           
             if(textBox1.Text!="" & textBox2.Text == "")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("الاسم الاول :" + textBox1.Text);
                listBox1.Items.Add("===============");
            }
            if (textBox1.Text == "" & textBox2.Text != "")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("القبيلة :" + textBox2.Text);
                listBox1.Items.Add("===============");
            }
            if (textBox1.Text=="" & textBox2.Text == "")
            {
                listBox1.Items.Clear();
            }
                {
                    if (Radiobutton1.Checked == true)
                    {
                        
                        listBox1.Items.Add("الحنس:"+Radiobutton1.Text);
                        listBox1.Items.Add("===============");
                    }
                    else if (RadioButtn2.Checked == true)
                    {

                        
                        listBox1.Items.Add("الجنس:"+RadioButtn2.Text);
                        listBox1.Items.Add("===============");
                    }
                }
                {
                    if (RadioButtn3.Checked == true)
                    {
                        
                        listBox1.Items.Add("الجنسية:"+RadioButtn3.Text);
                        listBox1.Items.Add("===============");
                    }
                    else if (RadioButtn4.Checked == true)
                    {
                        
                        listBox1.Items.Add("الجنسية:"+RadioButtn4.Text);
                        listBox1.Items.Add("===============");

                    }
                    else if (RadioButtn5.Checked == true)
                    {
                       
                        listBox1.Items.Add("الجنسية"+textBox4.Text);
                        listBox1.Items.Add("===============");

                    }
                }
            

            if (checkBox1.Checked==true & checkBox2.Checked==true & checkBox3.Checked == true)
            {
                listBox1.Items.Add("الهوايات:");
                listBox1.Items.Add(checkBox1.Text);
                listBox1.Items.Add(checkBox2.Text);
                listBox1.Items.Add(textBox3.Text);
            }
            if (checkBox1.Checked == true & checkBox2.Checked == true & checkBox3.Checked == false)
            {
                listBox1.Items.Add(":الهوايات");
                listBox1.Items.Add(checkBox1.Text);
                listBox1.Items.Add(checkBox2.Text);
              
            }
            if (checkBox1.Checked == true & checkBox2.Checked == false & checkBox3.Checked == true)
            {
                listBox1.Items.Add(":الهوايات");
                listBox1.Items.Add(checkBox1.Text);
                listBox1.Items.Add(textBox3.Text);

            }
            if (checkBox1.Checked == true & checkBox2.Checked == false & checkBox3.Checked == false) { 
                listBox1.Items.Add(":الهوايات");
            listBox1.Items.Add(checkBox1.Text);
               
            }
            if (checkBox1.Checked == false & checkBox2.Checked == true & checkBox3.Checked == true)
            {
                listBox1.Items.Add(":الهوايات");
                listBox1.Items.Add(checkBox2.Text);
                listBox1.Items.Add(textBox3.Text);
            }
            
            if (checkBox1.Checked == false & checkBox2.Checked == true & checkBox3.Checked == false)
            {
                listBox1.Items.Add(":الهوايات");
                listBox1.Items.Add(checkBox2.Text);

            }
            if (checkBox1.Checked == false & checkBox2.Checked == false & checkBox3.Checked == true)
            {
                listBox1.Items.Add(":الهوايات");
                listBox1.Items.Add(textBox3.Text);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void existProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هل تريد الخروج من البرنامج", "المعلومات الشخصية", MessageBoxButtons.YesNo);
            Close();
        }

        private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void geenYellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.GreenYellow;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void lightYellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightYellow;
        }

        private void lightGoldenrodYellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightGoldenrodYellow;
        }

        private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        private void salmonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Salmon;
        }

        private void beigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Beige;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void lightPinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Lime;
        }

        private void lighToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Snow;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void إلغاءتفعيلالقوائمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Enabled == true)
            {
                menuStrip1.Enabled = false;
                context1.Text = "تفعيل القوائم";
            }
            else
            {
                menuStrip1.Enabled = true;
                context1.Text = "إلغاء تفعيل القوائم";
            }
        }

        private void ترتيبالقراءةمناليسارإلىاليمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true && label3.Visible==true)
            {
                pictureBox1.Visible = false;
                label3.Visible = false;
                context2.Text = "إظهار الصورة الشخصية";

            }
            else
            {
                pictureBox1.Visible = true;
                label3.Visible = true;
                context2.Text = "إخفاء الصورة الشخصية";
               
            }
        }

        private void ترتيبالقراءةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void restToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Empty;
            pictureBox1.Visible = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("أدخل معلوماتك الشخصية أدناة ثم اضغط على عرض المعلومات لعرضها");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void yellowToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void blueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void moreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Brown;
        }

        private void cccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.OrangeRed;
        }

        private void ccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Salmon;
        }

        private void ddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.BlueViolet;
        }

        private void ssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Tomato;
        }

        private void xxxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Goldenrod;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void ddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkSlateBlue;
        }

        private void xxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void zzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.BurlyWood;
        }

        private void restToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.Empty;
            pictureBox1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("أدخل المعلومات الشحصية أدناة ثم إضغط على عرض المعلومات لعرضها");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (menuStrip1.Enabled == true)
            {
                menuStrip1.Enabled = false;
                t2.Text = "تفعيل القوائم";
            }
            else
            {
                menuStrip1.Enabled = true;
                t2.Text = "إلغاء تفعيل القوائم";
            }
        }

        private void v1_Click(object sender, EventArgs e)
        {

            if (button1.Enabled == true)
            {
                button1.Enabled = false;
                v1.Text = " تفعيل أيقونة عرض المعلومات";
            }
            else
            {
                button1.Enabled = true;
                v1.Text = "إلغاء تفعيل أيقونة عرض المعلومات";
            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
            {
                button1.Enabled = false;
                t3.Text = " تفعيل أيقونة عرض المعلومات";
            }
            else
            {
                button1.Enabled = true;
                t3.Text = "إلغاء تفعيل أيقونة عرض المعلومات";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButtn5_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtn5.Checked == true)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("هل تريد الخروج من البرنامج ", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                this.Close();
        }
    }
}
