﻿using System;
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
    public partial class OrderForm : Form
    {
        private OrderService orderService;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //----------------------商品----------------------
            Good good1 = new Good("Sport Shoes", 200);
            Good good2 = new Good("Water", 2);
            Good good3 = new Good("Dress", 300);
            Good good4 = new Good("Book", 39);
            Good good5 = new Good("Smart Phone", 6000);
            Good good6 = new Good("Computer", 10000);


            //----------------------顾客----------------------
            Client client1 = new Client("John");
            Client client2 = new Client("Sherlock");
            Client client3 = new Client("Molly");


            //----------------------订单明细----------------------
            OrderDetails orderDetails1 = new OrderDetails(good1, 1);
            OrderDetails orderDetails2 = new OrderDetails(good2, 10);
            OrderDetails orderDetails3 = new OrderDetails(good3, 2);
            OrderDetails orderDetails4 = new OrderDetails(good4, 3);
            OrderDetails orderDetails5 = new OrderDetails(good5, 1);


            //----------------------订单----------------------
            Order order1 = new Order("0001", client1);
            Order order2 = new Order("0002", client2);
            Order order3 = new Order("0003", client3);
            Order order4 = new Order("0004", client1);


            //----------------------订单管理----------------------
            orderService = new OrderService();


            //----------------------添加订单明细----------------------
            order1.AddDetails(orderDetails1);
            order1.AddDetails(orderDetails2);

            order2.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails4);
            order2.AddDetails(orderDetails5);

            order3.AddDetails(orderDetails1);
            order3.AddDetails(orderDetails3);
            order3.AddDetails(orderDetails5);

            order4.AddDetails(orderDetails2);
            order4.AddDetails(orderDetails4);


            //----------------------添加订单----------------------
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            bindingSourceOrder.DataSource = orderService;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(); ;
            deleteForm.Show();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ChangeForm changeForm = new ChangeForm();
            changeForm.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1 || e.RowIndex == -1)
                {
                    return;
                }

                DataGridViewCell cell = this.orderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell == null || cell.Value.ToString() == "" || cell.Value.ToString() == "0")
                {
                    return;
                }

                Order clickOrder = new Order();

                string id = this.orderDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                clickOrder = orderService.FindOrder(id);

                DetailForm detailForm = new DetailForm(clickOrder);
                detailForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
