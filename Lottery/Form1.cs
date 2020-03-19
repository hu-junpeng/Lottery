using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string _num;
        public string Num
        {
            get { return _num; }
            set { _num = value; }
        }
        private string _judge;
        public string Judge
        {
            get { return _judge; }
            set { _judge = value; }
        }
        private void numButton()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && ((Button)c).Name.Contains("btnNum"))
                {
                    ((Button)c).BackColor = Color.Blue;
                }
            }
        }
        private void chbJOFalse()
        {
            rbJ.Enabled = false;
            rbO.Enabled = false;
            rbJ.Checked = true;
            rbO.Checked = false;
        }
        private void chbZHFalse()
        {
            rbZ.Enabled = false;
            rbH.Enabled = false;
            rbZ.Checked = true;
            rbH.Checked = false;
        }
        private void chbC3False()
        {
            chbC30.Enabled = false;
            chbC31.Enabled = false;
            chbC32.Enabled = false;
            chbC30.Checked = false;
            chbC31.Checked = false;
            chbC32.Checked = false;
        }
        private void chbC4False()
        {
            chbC40.Enabled = false;
            chbC41.Enabled = false;
            chbC42.Enabled = false;
            chbC43.Enabled = false;
            chbC40.Checked = false;
            chbC41.Checked = false;
            chbC42.Checked = false;
            chbC43.Checked = false;
        }
        private void chbC5False()
        {
            chbC50.Enabled = false;
            chbC51.Enabled = false;
            chbC52.Enabled = false;
            chbC53.Enabled = false;
            chbC54.Enabled = false;
            chbC50.Checked = false;
            chbC51.Checked = false;
            chbC52.Checked = false;
            chbC53.Checked = false;
            chbC54.Checked = false;
        }
        private void controlEnable()
        {
            chbJOFalse();
            chbZHFalse();
            chbC3False();
            chbC4False();
            chbC5False();
        }
        private void AC()
        {
            btnNum0.Visible = false;
            btnNum1.Visible = true;
            btnNum1.Location = new Point(20, 6);
            btnNum2.Visible = true;
            btnNum2.Location = new Point(60, 6);
            btnNum3.Visible = true;
            btnNum3.Location = new Point(100, 6);
            btnNum4.Visible = false;
            btnNum5.Visible = false;
            btnNum6.Visible = false;
            btnNum7.Visible = false;
            btnNum8.Visible = false;
            btnNum9.Visible = false;
            btnNum10.Visible = false;
            btnNum11.Visible = false;
            btnNum12.Visible = false;
            btnNum13.Visible = false;
            btnNum14.Visible = false;
            btnNum15.Visible = false;
            btnNum16.Visible = false;
        }
        private void SpaceValue()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && ((Button)c).Name.Contains("btnNum"))
                {
                    ((Button)c).Visible = true;
                }
            }
            btnNum0.Location = new Point(15, 6);
            btnNum1.Location = new Point(44, 6);
            btnNum2.Location = new Point(73, 6);
            btnNum3.Location = new Point(102, 6);
            btnNum4.Location = new Point(131, 6);
            btnNum5.Location = new Point(160, 6);
            btnNum6.Location = new Point(189, 6);
            btnNum7.Location = new Point(218, 6);
            btnNum8.Location = new Point(247, 6);
            btnNum9.Location = new Point(276, 6);
            btnNum10.Location = new Point(305, 6);
            btnNum11.Location = new Point(337, 6);
            btnNum12.Location = new Point(369, 6);
            btnNum13.Location = new Point(401, 6);
            btnNum14.Location = new Point(433, 6);
            btnNum15.Location = new Point(465, 6);
            btnNum16.Location = new Point(497, 6);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                btnNum10.Visible = false;
                btnNum11.Visible = false;
                btnNum12.Visible = false;
                btnNum13.Visible = false;
                btnNum14.Visible = false;
                btnNum15.Visible = false;
                btnNum16.Visible = false;
                if (Judge == "AC")
                {
                    AC();
                }
                if (Judge == "SpaceValue")
                {
                    SpaceValue();
                }
                numButton();
                controlEnable();
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
        }
        private void bb(object sender)
        {
            try
            {
                if (((Button)sender).BackColor == Color.Red)
                {
                    ((Button)sender).BackColor = Color.Blue;
                    this.Num = this.Num.Replace(((Button)sender).Text + "", "");
                    this.Num = this.Num.Replace(((Button)sender).Text, "");
                }
                else
                {
                    ((Button)sender).BackColor = Color.Red;
                    this.Num += ((Button)sender).Text + "";
                }
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            bb(btnNum0);
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            bb(btnNum1);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            bb(btnNum2);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            bb(btnNum3);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            bb(btnNum4);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            bb(btnNum5);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            bb(btnNum6);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            bb(btnNum7);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            bb(btnNum8);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            bb(btnNum9);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                controlEnable();
                numButton();
                this.Num = "";
                chbJO.Checked = false;
                chbZH.Checked = false;
                chbC3.Checked = false;
                chbC30.Checked = false;
                chbC31.Checked = false;
                chbC32.Checked = false;

                chbC4.Checked = false;
                chbC40.Checked = false;
                chbC41.Checked = false;
                chbC42.Checked = false;
                chbC43.Checked = false;

                chbC5.Checked = false;
                chbC50.Checked = false;
                chbC51.Checked = false;
                chbC52.Checked = false;
                chbC53.Checked = false;
                chbC54.Checked = false;
                rbJ.Checked = true;
                rbO.Checked = false;
                rbZ.Checked = true;
                rbH.Checked = false;
                chbRange.Checked = false;
                nudMin.Value = 0;
                nudMax.Value = 0;

            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button && ((Button)c).Name.Contains("btnNum") && ((Button)c).Visible == true)
                    {
                        ((Button)c).BackColor = Color.Red;
                        this.Num += ((Button)c).Text + "";
                    }
                }
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in Controls)
                {
                    if (c is Button && ((Button)c).Name.Contains("btnNum"))
                    {
                        ((Button)c).BackColor = Color.Blue;
                        if (this.Num.Trim().Length > 0 || this.Num != null)
                        {
                            this.Num = this.Num.Replace(((Button)c).Text + "", " ");
                            this.Num = this.Num.Replace(((Button)c).Text, " ");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string EndStr = "";
                if (this.Num.Trim().Length > 0)
                {
                    string[] eds = this.Num.Split(',');
                    for (int i = 0; i < 17; i++)
                    {
                        for (int j = 0; j < eds.Length; j++)
                        {
                            if (i.ToString() == eds[j].ToString())
                            {
                                EndStr += i.ToString() + " ";
                            }
                        }
                    }
                    if (EndStr.Trim().Length > 0)
                    {
                        this.Num = EndStr.Substring(0, EndStr.Length - 1);
                    }
                }
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                string strnum = "0,1,2,3,4,5,6,7,8,9";
                if (Judge == "AC")
                {
                    strnum = "1,2,3";
                }
                if (Judge == "SpaceValue")
                {
                    strnum = "0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16";
                }
                common com = new common();
                if (chbJO.Checked)
                {
                    if (rbJ.Checked)
                    {
                        string str1 = "1,3,5,7,9";
                        if (Judge == "AC")
                        {
                            str1 = "1,3";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str1 = "1,3,5,7,9,11,13,15";
                        }
                        strnum = com.getpublic(str1, strnum);
                    }
                    else
                    {
                        string str1 = "0,2,4,6,8";
                        if (Judge == "AC")
                        {
                            str1 = "2";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str1 = "0,2,4,6,8,10,12,14,16";
                        }
                        strnum = com.getpublic(str1, strnum);
                    }
                }
                if (chbZH.Checked)
                {
                    if (rbZ.Checked)
                    {
                        string str1 = "1,2,3,5,7";
                        if (Judge == "AC")
                        {
                            str1 = "1,2,3";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str1 = "1,2,3,5,7,11,13";
                        }
                        strnum = com.getpublic(str1, strnum);
                    }
                    else
                    {
                        string str1 = "0,4,6,8,9";
                        if (Judge == "AC")
                        {
                            str1 = "";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str1 = "0,4,6,8,9,10,12,14,15,16";
                        }
                        strnum = com.getpublic(str1, strnum);
                    }
                }
                if(chbC3.Checked)
                {
                    string str1 = "";
                    if(chbC30.Checked)
                    {
                        string str2 = "0,3,6,9";
                        if(Judge=="AC")
                        {
                            str2 = "0,3";
                        }
                        if(Judge=="SpaceValue")
                        {
                            str2 = "0,3,6,9,12,15";
                        }
                        if(str1.Trim().Length>0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    if (chbC31.Checked)
                    {
                        string str2 = "1,4,7";
                        if (Judge == "AC")
                        {
                            str2 = "1";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "1,4,7,10,13,16";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    if (chbC32.Checked)
                    {
                        string str2 = "2,5,8";
                        if (Judge == "AC")
                        {
                            str2 = "2";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "2,5,8,11,14";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    strnum = com.getpublic(str1, strnum);
                }
                if (chbC4.Checked)
                {
                    string str1 = "";
                    if (chbC40.Checked)
                    {
                        string str2 = "0,4,8";
                        if (Judge == "AC")
                        {
                            str2 = "0";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "0,4,8,12,16";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    if (chbC41.Checked)
                    {
                        string str2 = "1,5,9";
                        if (Judge == "AC")
                        {
                            str2 = "1";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "1,5,9,13";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    if (chbC42.Checked)
                    {
                        string str2 = "2,6";
                        if (Judge == "AC")
                        {
                            str2 = "2";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "2,6,10,14";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    if (chbC43.Checked)
                    {
                        string str2 = "3,7";
                        if (Judge == "AC")
                        {
                            str2 = "3";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "3,7,11,15";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    strnum = com.getpublic(str1, strnum);
                }
                if (chbC5.Checked)
                {
                    string str1 = "";
                    if (chbC50.Checked)
                    {
                        string str2 = "0,5";
                        if (Judge == "AC")
                        {
                            str2 = "0";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "0,5,10,15";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    if (chbC51.Checked)
                    {
                        string str2 = "1,6";
                        if (Judge == "AC")
                        {
                            str2 = "1";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "1,6,11,16";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    if (chbC52.Checked)
                    {
                        string str2 = "2,7";
                        if (Judge == "AC")
                        {
                            str2 = "2";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "2,7,12";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    if (chbC53.Checked)
                    {
                        string str2 = "3,8";
                        if (Judge == "AC")
                        {
                            str2 = "3";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "3,8,13";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    if (chbC54.Checked)
                    {
                        string str2 = "4,9";
                        if (Judge == "AC")
                        {
                            str2 = "";
                        }
                        if (Judge == "SpaceValue")
                        {
                            str2 = "4,9,14";
                        }
                        if (str1.Trim().Length > 0)
                        {
                            str1 += "," + str2;
                        }
                        else
                        {
                            str1 += str2;
                        }
                    }
                    strnum = com.getpublic(str1, strnum);
                }
                if(chbRange.Checked)
                {
                    string str1 = "";
                    if(nudMax.Value<=nudMin.Value)
                    {
                        for (int i = (int)nudMax.Value; i < nudMin.Value; i++)
                        {
                            str1 += i.ToString() + ",";
                        }
                    }
                    strnum = com.getpublic(str1, strnum);
                }
                numButton();
                strnum = strnum.Replace(",,", ",");
                string[] vibtn = strnum.Split(',');
                for (int vi = 0; vi < vibtn.Length; vi++)
                {
                    if(vibtn[vi].ToString()=="0")
                    {
                        btnNum0.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "1")
                    {
                        btnNum1.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "2")
                    {
                        btnNum2.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "3")
                    {
                        btnNum3.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "4")
                    {
                        btnNum4.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "5")
                    {
                        btnNum5.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "6")
                    {
                        btnNum6.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "7")
                    {
                        btnNum7.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "8")
                    {
                        btnNum8.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "9")
                    {
                        btnNum9.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "10")
                    {
                        btnNum10.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "11")
                    {
                        btnNum11.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "12")
                    {
                        btnNum12.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "13")
                    {
                        btnNum13.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "14")
                    {
                        btnNum14.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "15")
                    {
                        btnNum15.BackColor = Color.Red;
                    }
                    if (vibtn[vi].ToString() == "16")
                    {
                        btnNum16.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }
        }
    }
}
