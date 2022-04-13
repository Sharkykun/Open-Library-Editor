using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.Clases
{
    public class CCBoxItem
    {
        private int value;
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private object item;
        public object Item
        {
            get { return item; }
            set { item = value; }
        }

        public CCBoxItem()
        {
        }

        public CCBoxItem(string name, int value, object item)
        {
            this.name = name;
            this.value = value;
        }

        public override string ToString()
        {
            return string.Format("name: '{0}', item: {1}", name, value);
        }
    }
}
