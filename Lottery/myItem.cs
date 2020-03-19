using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class myItem
    {
        private string _Text;
        public myItem(string text)
        {
            this._Text = text;
        }
        public string Text
        {
            set { _Text = value; }
            get { return _Text; }
        }
    }
}
