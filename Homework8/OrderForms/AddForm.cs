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
    public partial class AddForm : Form
    {
        private OrderService orderService = new OrderService();

        private Client client = new Client();
        private Order order = new Order();

        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(OrderService orderService)
        {
            this.orderService = orderService;

            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            textID.DataBindings.Add("Text", order, "ID");
            textClient.DataBindings.Add("Text", client, "Name");
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                order.Client = client;
                orderService.AddOrder(order);

                panelDetail.Visible = true;
                buttonCreate.Visible = false;
                MessageBox.Show("Add successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Good good = new Good();
                OrderDetails orderDetails = new OrderDetails();

                textName.DataBindings.Add("Text", good, "Name");
                textPrize.DataBindings.Add("Text", good, "Prize");
                textNum.DataBindings.Add("Text", orderDetails, "Num");

                orderDetails.Goods = good;
                order.AddDetails(orderDetails);

                textName.DataBindings.Clear();
                textPrize.DataBindings.Clear();
                textNum.DataBindings.Clear();
                MessageBox.Show("Add successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
