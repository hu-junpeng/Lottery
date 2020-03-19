using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class common
    {
        //取两字符串的公共部分
        public string getpublic(string str1,string str2)
        {
            string result = "";
            string[] aa = str1.Split(',');
            string[] bb = str2.Split(',');
            for (int i = 0; i < aa.Length; i++)
            {
                for (int j = 0; j < bb.Length; j++)
                {
                    if(aa[i].ToString()==bb[j].ToString())
                    {
                        result += aa[i].ToString()+",";
                    }
                }
            }
            if(result.Length>0)
            {
                //去掉最后一个逗号
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }
        //取最大值
        public string getMax(string str)
        {
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            return System.Math.Max(t1, System.Math.Max(t2, t3)).ToString();
        }
        //取最小值
        public string getMin(string str)
        {
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            return System.Math.Min(t1, System.Math.Min(t2, t3)).ToString();
        }
        //取中间值
        public string getMid(string str)
        {
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            int tt;
            if(System.Math.Max(t1,t2)>System.Math.Max(t2,t3))
            {
                tt = System.Math.Max(t2, t3);
            }
            else
            {
                tt = System.Math.Max(t1, t2);
            }
            if(System.Math.Max(t1,t2)==System.Math.Max(t2,t3))
            {
                tt = System.Math.Max(t1, t3);
            }
            return tt.ToString();
        }
        //取最大值为指定数的投注值
        public string containMax(string str,string definedvalue)
        {
            string returnStr = "";
            if(str.Length>0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if(definedvalue.IndexOf(getMax(str1[i].ToString()))!=-1)
                    {
                        returnStr += str1[i].ToString() + ",";
                    }
                }
                if (returnStr.Length > 0)
                {
                    returnStr = returnStr.Substring(0, returnStr.Length - 1);
                }
            }
            return returnStr;
        }
        //取最小值为指定数的投注值
        public string containMin(string str, string definedvalue)
        {
            string returnStr = "";
            if (str.Length > 0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if (definedvalue.IndexOf(getMin(str1[i].ToString())) != -1)
                    {
                        returnStr += str1[i].ToString() + ",";
                    }
                }
                if (returnStr.Length > 0)
                {
                    returnStr = returnStr.Substring(0, returnStr.Length - 1);
                }
            }
            return returnStr;
        }
        //取中间值为指定数的投注值
        public string containMid(string str, string definedvalue)
        {
            string returnStr = "";
            if (str.Length > 0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if (definedvalue.IndexOf(getMid(str1[i].ToString())) != -1)
                    {
                        returnStr += str1[i].ToString() + ",";
                    }
                }
                if (returnStr.Length > 0)
                {
                    returnStr = returnStr.Substring(0, returnStr.Length - 1);
                }
            }
            return returnStr;
        }
        //取AC值
        public int GetAC(string str)
        {
            int returnint = 0;
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            int ch1 = System.Math.Abs(t1 - t2);
            int ch2 = System.Math.Abs(t1 - t3);
            int ch3 = System.Math.Abs(t3 - t2);
            if(ch1==ch2&&ch2==ch3&&ch1==ch3)
            {
                returnint = 1;
            }
            else
            {
                if(ch1!=ch2&&ch1!=ch3&&ch2!=ch3)
                { returnint = 3; }
                else { returnint = 2; }
            }
            return returnint;
        }
        //返回AC值为指定数的投注值
        public string containAC(string str,string definedvalue)
        {
            string returnstr = "";
            if(str.Length>0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if(definedvalue.IndexOf(GetAC(str1[i].ToString()).ToString())!=-1)
                    {
                        returnstr += str1[i].ToString() + ",";
                    }
                }
                if (returnstr.Length > 0)
                {
                    returnstr = returnstr.Substring(0, returnstr.Length - 1);
                }
            }
            return returnstr;
        }
        //求ID值
        public int GetID(string str)
        {
            int returnint = -1;
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            returnint = System.Math.Abs(System.Math.Abs(t1 - t2) - System.Math.Abs(t2 - t3));
            return returnint;
        }
        //返回ID值为指定数投注值
        public string containID(string str,string definedvalue)
        {
            string returnstr = "";
            if (str.Length > 0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if (definedvalue.IndexOf(GetID(str1[i].ToString()).ToString()) != -1)
                    {
                        returnstr += str1[i].ToString() + ",";
                    }
                }
                if (returnstr.Length > 0)
                {
                    returnstr = returnstr.Substring(0, returnstr.Length - 1);
                }
            }
            return returnstr;
        }
        //取码距值
        public int getSpaceValue(string str)
        {
            int returnint = -1;
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            int aa = 0, bb = 0;
            if(t1!=0||t1!=1)
            {
                aa = System.Math.Abs(t1 - 1);
            }
            if(t3!=9||t3!=8)
            {
                bb = System.Math.Abs(t3 - 8);
            }
            int a = aa + bb;
            int b=0;
            if(t1!=t2)
            {
                b = System.Math.Abs(t1 - t2 - 1);
            }
            int c=0;
            if (t2 != t3)
            {
                c = System.Math.Abs(t2 - t3 - 1);
            }
            returnint = System.Math.Max(System.Math.Max(a, b), c);
            return returnint;
        }
        //返回码距值为指定的投注值
        public string containSpaceValue(string str,string definedvalue)
        {
            string returnstr = "";
            if(str.Length>0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    string[] ss = definedvalue.Split(',');
                    for (int j = 0; j < ss.Length; j++)
                    {
                        if (ss[j] == Convert.ToString(getSpaceValue(str1[i].ToString())))
                        {
                            returnstr += str1[i].ToString() + ",";
                        }                   
                    }
                    if (returnstr.Length > 0)
                    {
                        returnstr = returnstr.Substring(0, returnstr.Length - 1);
                    }
                }
            }
            if(returnstr.Length>0)
            {
                returnstr = returnstr.Substring(0, returnstr.Length - 1);
            }
            return returnstr;
        }
        //取跨度值
        public int getSpan(string str)
        {
            int returnint = -1;
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            int a = System.Math.Max(System.Math.Max(t1, t2), t3);
            int b = System.Math.Min(System.Math.Min(t1, t2), t3);
            returnint = System.Math.Abs(a - b);
            return returnint;
        }
        //返回跨度之值为指定数的投注值
        public string containSpan(string str, string definedvalue)
        {
            string returnStr = "";
            if (str.Length > 0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if (definedvalue.IndexOf(getSpan(str1[i].ToString()).ToString()) != -1)
                    {
                        returnStr += str1[i].ToString() + ",";
                    }
                }
                if (returnStr.Length > 0)
                {
                    returnStr = returnStr.Substring(0, returnStr.Length - 1);
                }
            }
            return returnStr;
        }
        //取平均数
        public int getAve(string str)
        {
            int returnint = -1;
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            returnint = (int)System.Math.Round((float)(t1 + t2 + t3) / 3);
            return returnint;
        }
        //取平均数为指定的投注值
        public string containAve(string str, string definedvalue)
        {
            string returnStr = "";
            if (str.Length > 0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if (definedvalue.IndexOf(getAve(str1[i].ToString()).ToString()) != -1)
                    {
                        returnStr += str1[i].ToString() + ",";
                    }
                }
                if(returnStr.Length>0)
                {
                    returnStr = returnStr.Substring(0, returnStr.Length - 1);
                }
            }
            return returnStr;
        }
        //取百十的绝对值
        public int getbs(string str)
        {
            int returnint = -1;
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            returnint = System.Math.Abs(t1 - t2);
            return returnint;
        }
        //取百十的绝对值为指定数的投注值
        public string containbs(string str,string definedvalue)
        {
            string returnStr = "";
            if (str.Length > 0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if (definedvalue.IndexOf(getbs(str1[i].ToString()).ToString()) != -1)
                    {
                        returnStr += str1[i].ToString() + ",";
                    }
                }
                if (returnStr.Length > 0)
                {
                    returnStr = returnStr.Substring(0, returnStr.Length - 1);
                }
            }
            return returnStr;
        }
        //取百个的绝对值
        public int getbg(string str)
        {
            int returnint = -1;
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            returnint = System.Math.Abs(t1 - t3);
            return returnint;
        }
        //取百个的绝对值为指定数的投注值
        public string containbg(string str, string definedvalue)
        {
            string returnStr = "";
            if (str.Length > 0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if (definedvalue.IndexOf(getbg(str1[i].ToString()).ToString()) != -1)
                    {
                        returnStr += str1[i].ToString() + ",";
                    }
                }
                if (returnStr.Length > 0)
                {
                    returnStr = returnStr.Substring(0, returnStr.Length - 1);
                }
            }
            return returnStr;
        }
        //取十个的绝对值
        public int getsg(string str)
        {
            int returnint = -1;
            int t1 = int.Parse(str.Substring(0, 1));
            int t2 = int.Parse(str.Substring(1, 1));
            int t3 = int.Parse(str.Substring(2, 1));
            returnint = System.Math.Abs(t2 - t3);
            return returnint;
        }
        //取十个的绝对值为指定数的投注值
        public string containsg(string str, string definedvalue)
        {
            string returnStr = "";
            if (str.Length > 0)
            {
                string[] str1 = str.Split(',');
                for (int i = 0; i < str1.Length; i++)
                {
                    if (definedvalue.IndexOf(getsg(str1[i].ToString()).ToString()) != -1)
                    {
                        returnStr += str1[i].ToString() + ",";
                    }
                }
                if (returnStr.Length > 0)
                {
                    returnStr = returnStr.Substring(0, returnStr.Length - 1);
                }
            }
            return returnStr;
        }
    }
}
