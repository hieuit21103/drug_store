using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drug_store.Component
{
    internal class Item : ListViewItem
    {
        string text { get; set; }
        string id { get; set; }
        string image { get; set; }
    }
}
