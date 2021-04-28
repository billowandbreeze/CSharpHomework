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
    public partial class ChangeForm : Form
    {
        public ToMainDelegate changeToMainDelegate;

        private OrderService orderService = new OrderService();

        private Order oldOrder = new Order();
        private Order newOrder = new Order();

        public ChangeForm()
        {
            InitializeComponent();
        }

        public ChangeForm(OrderService orderService)
        {
            this.orderService = orderService;

            InitializeComponent();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                oldOrder = orderService.FindOrder(textChangeID.Text);

                Client client = new Client();

                newOrder.ID = textID.Text;
                client.Name = textCilent.Text;

                newOrder.Client = client;

                panel4.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;

                MessageBox.Show("修改订单号和客户成功!");
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
                OrderDetails orderDetails = new OrderDetails();
                Good good = new Good();

                good.Name = textName.Text;
                good.Prize = Double.Parse(textPrize.Text);
                orderDetails.Num = int.Parse(textNum.Text);

                orderDetails.Goods = good;

                newOrder.AddDetails(orderDetails);

                MessageBox.Show("向新订单中加入订单明细成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            try
            {
                orderService.ChangeOrder(oldOrder, newOrder);

                changeToMainDelegate.Invoke(orderService);

                MessageBox.Show("修改成功!");

                panel4.Visible = false;
                panel1.Visible = true;
                panel3.Visible = true;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
