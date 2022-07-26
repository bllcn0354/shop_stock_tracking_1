using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_stock_tracking.Formlar
{
    public partial class frm_stok : Form
    {
        public frm_stok()
        {
            InitializeComponent();
        }

        private void frm_stok_Load(object sender, EventArgs e)
        {
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }
    }
}
