using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lottery
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void btnEnable()
        {
            btnMax.Enabled = false;
            btnMid.Enabled = false;
            btnMin.Enabled = false;
            btnAC.Enabled = false;
            btnID.Enabled = false;
            btnSpaceValue.Enabled = false;
            btnSpan.Enabled = false;
            btnAve.Enabled = false;
            btnBS.Enabled = false;
            btnBG.Enabled = false;
            btnSG.Enabled = false;
        }
        private void dataGridViews()
        {
            if (dataGridView1.ColumnCount > 0)
            {
                dataGridView1.Columns[0].HeaderText = "号码";
                dataGridView1.Columns[0].Width = 180;
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                ArrayList al = new ArrayList();
                al.Add(new myItem(""));
                btnEnable();
                lblNum.Text = "投注：0注";
                lblSum.Text = "投注金额：0元";
                dataGridView1.DataSource = al;
                dataGridViews();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString()); ;
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font, rectangle, dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        //单选投注
        private string showDX(string[] str1, string[] str2, string[] str3)
        {
            string str = "";
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    for (int k = 0; k < str3.Length; k++)
                    {
                        str += str1[i].ToString() + str2[j].ToString() + str3[k].ToString() + ",";
                    }
                }
            }
            if(str.Length>0)
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str;
        }
        //组选投注
        private string showZX(string [] str1 ,string[]str2,string [] str3)
        {
            string str = "";
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = i; j < str2.Length; j++)
                {
                    for (int k = j; k < str3.Length; k++)
                    {
                        str += str1[i].ToString() + str2[j].ToString() + str3[k].ToString() + ",";
                    }
                }
            }
            if (str.Length > 0)
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str;
        }
        //组选3
        private string showZX3(string[] str1,string[] str2,string[] str3)
        {
            string str = "";
            for (int i = 0; i <str1.Length; i++)
            {
                for (int k = i+1; k < str3.Length; k++)
                {
                    str += str1[i].ToString() + str2[i].ToString() + str3[k].ToString();
                    str += str1[k].ToString() + str2[i].ToString() + str3[i].ToString();
                }
            }
            if(str.Length>0)
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str;
        }
        //组选6
        private string showZX6(string [] str1,string[]str2,string[]str3)
        {
            string str = "";
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = i+1; j < str2.Length; j++)
                {
                    for (int k = j+1; k < str3.Length; k++)
                    {
                        str += str1[i].ToString() + str2[j].ToString() + str3[k].ToString()+",";
                    }
                }
            }
            if(str.Length>0)
            {
                str = str.Substring(0, str.Length - 1);
            }
            return str;
        }
        private string touzhu()
        {
            string str = "";
            string[] str1 = tbB.Text.Trim().Replace(" ", " ").Split(' ');
            string[] str2 = tbS.Text.Trim().Replace(" ", " ").Split(' ');
            string[] str3 = tbG.Text.Trim().Replace(" ", " ").Split(' ');
            if(rbtnDX.Checked)
            {
                str = showDX(str1, str2, str3);
            }
            if (rbtnZX.Checked)
            {
                str = showZX(str1, str2, str3);
            }
            if (rbtnZX3.Checked)
            {
                str = showZX3(str1, str2, str3);
            }
            if (rbtnZX6.Checked)
            {
                str = showZX6(str1, str2, str3);
            }
            return str;
        }
        private void btnTake_Click(object sender, EventArgs e)
        {
            try
            {
                string type = touzhu();
                common num = new common();
                if(cbMax.Checked)
                {
                    type = num.containMax(type, tbMax.Text.Trim());
                    if(type.Length>0)
                    {
                        type = type.Substring(0, type.Length - 1);
                    }
                }
                if (cbMin.Checked)
                {
                    type = num.containMin(type, tbMin.Text.Trim());
                    if (type.Length > 0)
                    {
                        type = type.Substring(0, type.Length - 1);
                    }
                }
                if (cbMid.Checked)
                {
                    type = num.containMid(type, tbMid.Text.Trim());
                    if (type.Length > 0)
                    {
                        type = type.Substring(0, type.Length - 1);
                    }
                }
                if(cbAC.Checked)
                {
                    type = num.containAC(type, tbAC.Text.Trim());
                    if(type.Length>0)
                    {
                        type = type.Substring(0, type.Length - 1);
                    }
                }
                if(cbSpaceValue.Checked)
                {
                    type = num.containSpaceValue(type, tbSpaceValue.Text.Trim());
                }
                if(cbID.Checked)
                {
                    type = num.containID(type, tbID.Text.Trim());
                }
                if (cbSpan.Checked)
                {
                    type = num.containSpan(type, tbSpan.Text.Trim());
                }
                if (cbAve.Checked)
                {
                    type = num.containAve(type, tbAve.Text.Trim());
                }
                if (cbBS.Checked)
                {
                    type = num.containbs(type, tbBS.Text.Trim());
                }
                if (cbBG.Checked)
                {
                    type = num.containbg(type, tbBG.Text.Trim());
                }
                if (cbSG.Checked)
                {
                    type = num.containsg(type, tbSG.Text.Trim());
                }
                if(type.Trim().Length>0)
                {
                    string[] text = type.Split(',');
                    ArrayList al = new ArrayList();
                    al.Clear();
                    for (int j = 0; j < text.Length; j++)
                    {
                        al.Add(new myItem(text[j].ToString()));
                    }
                    dataGridView1.DataSource = al;
                    lblNum.Text = "投注："+Convert.ToString(text.Length)+"注";
                    lblSum.Text = "投注金额：" + Convert.ToString(2 * text.Length) + "元";
                }
                else
                {
                    ArrayList al = new ArrayList();
                    al.Clear();
                    dataGridView1.DataSource = al;
                    lblNum.Text = "投注：0注";
                    lblSum.Text = "投注金额：0元";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void tbClear()
        {
            tbMax.Text = null;
            tbMid.Text = null;
            tbMin.Text = null;
            tbAC.Text = null;
            tbID.Text = null;
            tbSpaceValue.Text = null;
            tbSpan.Text = null;
            tbAve.Text = null;
            tbBS.Text = null;
            tbBG.Text = null;
            tbSG.Text = null;
        }
        string str = "0,1,2,3,4,5,6,7,8,9";
        private void head()
        {

            tbB.Text = str;
            tbS.Text = str;
            tbG.Text = str;
            rbtnDX.Checked = true;
            rbtnZX.Checked = false;
            rbtnZX3.Checked = false;
            rbtnZX6.Checked = false;

        }
        private void chbFalse()
        {
            cbMax.Checked = false;
            cbMid.Checked = false;
            cbMin.Checked = false;
            cbAC.Checked = false;
            cbID.Checked = false;
            cbSpaceValue.Checked = false;
            cbSpan.Checked = false;
            cbAve.Checked = false;
            cbBS.Checked = false;
            cbBG.Checked = false;
            cbSG.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                btnEnable();
                tbClear();
                head();
                chbFalse();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "B";
                DialogResult result = form1.ShowDialog();
                if(result==DialogResult.OK)
                {
                    tbB.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "S";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbS.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "G";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbG.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "Max";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbMax.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "Mid";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbMid.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "Min";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbMin.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "AC";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbAC.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "ID";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbID.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSpaceValue_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "SpaceValue";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbSpaceValue.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSpan_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "Span";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbSpan.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAve_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "Ave";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbAve.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "BS";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbBS.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "BG";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbBG.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSG_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Num = "";
                form1.Judge = "BG";
                DialogResult result = form1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tbSG.Text = form1.Num;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
