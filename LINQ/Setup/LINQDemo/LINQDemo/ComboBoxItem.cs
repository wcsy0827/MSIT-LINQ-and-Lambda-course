using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQDemo
{
    class ComboBoxItem
    {
        public string Uri;
        public string Description;

        public ComboBoxItem(string t, string v)
        {
            Description = t;
            Uri = v;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
