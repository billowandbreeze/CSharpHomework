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
    public partial class SearchForm : Form
    {
        OrderService orderService = new OrderService();

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(OrderService orderService)
        {
            this.orderService = orderService;

            InitializeComponent();
        }

        private void buttonID_Click(object sender, EventArgs e)
        {
            try
            {
                OrderService searchService = new OrderService();
                searchService.Orders = orderService.FindOrderById(textKey.Text);

                bindingSource.DataSource = searchService;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            try
            {
                OrderService searchService = new OrderService();

                searchService.Orders = orderService.FindOrderByClient(textKey.Text);

                bindingSource.DataSource = searchService;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrize_Click(object sender, EventArgs e)
        {
            try
            {
                OrderService searchService = new OrderService();
                searchService.Orders = orderService.FindOrderByPrize(int.Parse(textKey.Text));

                bindingSource.DataSource = searchService;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
