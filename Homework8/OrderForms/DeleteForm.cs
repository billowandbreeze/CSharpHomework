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
    public partial class DeleteForm : Form
    {
        private OrderService orderService = new OrderService();

        private Order order = new Order();

        public DeleteForm()
        {
            InitializeComponent();
        }

        public DeleteForm(OrderService orderService)
        {
            this.orderService = orderService;

            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                order = orderService.FindOrder(textID.Text);

                orderService.RemoveOrder(order);

                MessageBox.Show("Delete successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
