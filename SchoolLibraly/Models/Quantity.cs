using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraly.Models
{
    internal class Quantity
    {
        private static Quantity _Instance = new Quantity();
        public static Quantity GetInstance() => _Instance;

        private Quantity() { }
        public Action<string> Show { get; set; }

        public string Text { get; set; } = "";

        public void Close()
        {
            Text = "";
        }
    }
}
