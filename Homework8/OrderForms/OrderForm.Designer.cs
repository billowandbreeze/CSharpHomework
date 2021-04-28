
namespace OrderForms
{
    partial class OrderForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingSourceOrder = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.buttonSearch);
            this.panel.Controls.Add(this.buttonChange);
            this.panel.Controls.Add(this.buttonDelete);
            this.panel.Controls.Add(this.buttonAdd);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(782, 100);
            this.panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "点击订单所在行查看详细信息！";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.Location = new System.Drawing.Point(586, 48);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 30);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "查询订单";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonChange.Location = new System.Drawing.Point(413, 48);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(100, 30);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "修改订单";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDelete.Location = new System.Drawing.Point(248, 48);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "删除订单";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Location = new System.Drawing.Point(87, 48);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "增加订单";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.totalPrizeDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.bindingSourceOrder;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 100);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 27;
            this.orderDataGridView.Size = new System.Drawing.Size(782, 253);
            this.orderDataGridView.TabIndex = 1;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // bindingSourceOrder
            // 
            this.bindingSourceOrder.DataMember = "Orders";
            this.bindingSourceOrder.DataSource = typeof(OrderManageSystem.OrderService);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "客户";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPrizeDataGridViewTextBoxColumn
            // 
            this.totalPrizeDataGridViewTextBoxColumn.DataPropertyName = "TotalPrize";
            this.totalPrizeDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalPrizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPrizeDataGridViewTextBoxColumn.Name = "totalPrizeDataGridViewTextBoxColumn";
            this.totalPrizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.panel);
            this.Name = "OrderForm";
            this.Text = "Order Service";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource bindingSourceOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrizeDataGridViewTextBoxColumn;
    }
}

