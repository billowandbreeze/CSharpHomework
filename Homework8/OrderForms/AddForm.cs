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
        public ToMainDelegate addToMainDelegate;

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

                panelDetail.Visible = true;
                panel1.Visible = false;
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

                good.Name = textName.Text;
                good.Prize = Double.Parse(textPrize.Text);
                orderDetails.Num = int.Parse(textNum.Text);

                orderDetails.Goods = good;
                order.AddDetails(orderDetails);

                //Console.WriteLine(orderService);

                MessageBox.Show("添加订单明细成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFinished_Click(object sender, EventArgs e)
        {
            try
            {
                orderService.AddOrder(order);

                //Console.WriteLine(orderService);

                addToMainDelegate.Invoke(this.orderService);

                MessageBox.Show("添加订单成功!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
