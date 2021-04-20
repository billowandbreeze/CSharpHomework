using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManageSystem;

namespace OrderForms
{
    public partial class DetailForm : Form
    {
        Order order = new Order();
        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(Order order)
        {
            InitializeComponent();

            this.order = order;
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            bindingSourceDetail.DataSource = order;
        }
    }
}
