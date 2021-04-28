
namespace OrderForms
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textClient = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.buttonFinished = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textNum = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.textPrize = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelPrize = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.textClient);
            this.panel1.Controls.Add(this.textID);
            this.panel1.Controls.Add(this.labelClient);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCreate.Location = new System.Drawing.Point(332, 300);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 30);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "创建订单";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textClient
            // 
            this.textClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textClient.Location = new System.Drawing.Point(421, 191);
            this.textClient.Name = "textClient";
            this.textClient.Size = new System.Drawing.Size(100, 25);
            this.textClient.TabIndex = 3;
            // 
            // textID
            // 
            this.textID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textID.Location = new System.Drawing.Point(421, 104);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 25);
            this.textID.TabIndex = 2;
            // 
            // labelClient
            // 
            this.labelClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(260, 194);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(37, 15);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "客户";
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(260, 107);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 15);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.buttonFinished);
            this.panelDetail.Controls.Add(this.buttonAdd);
            this.panelDetail.Controls.Add(this.textNum);
            this.panelDetail.Controls.Add(this.labelNum);
            this.panelDetail.Controls.Add(this.textPrize);
            this.panelDetail.Controls.Add(this.textName);
            this.panelDetail.Controls.Add(this.labelPrize);
            this.panelDetail.Controls.Add(this.labelName);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(800, 450);
            this.panelDetail.TabIndex = 1;
            this.panelDetail.Visible = false;
            // 
            // buttonFinished
            // 
            this.buttonFinished.Location = new System.Drawing.Point(322, 372);
            this.buttonFinished.Name = "buttonFinished";
            this.buttonFinished.Size = new System.Drawing.Size(150, 30);
            this.buttonFinished.TabIndex = 12;
            this.buttonFinished.Text = "完成添加";
            this.buttonFinished.UseVisualStyleBackColor = true;
            this.buttonFinished.Click += new System.EventHandler(this.buttonFinished_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Location = new System.Drawing.Point(322, 318);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 30);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "增加订单详细";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textNum
            // 
            this.textNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textNum.Location = new System.Drawing.Point(430, 256);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(100, 25);
            this.textNum.TabIndex = 10;
            // 
            // labelNum
            // 
            this.labelNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(284, 259);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(67, 15);
            this.labelNum.TabIndex = 8;
            this.labelNum.Text = "商品数量";
            // 
            // textPrize
            // 
            this.textPrize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textPrize.Location = new System.Drawing.Point(430, 160);
            this.textPrize.Name = "textPrize";
            this.textPrize.Size = new System.Drawing.Size(100, 25);
            this.textPrize.TabIndex = 7;
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textName.Location = new System.Drawing.Point(430, 73);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 25);
            this.textName.TabIndex = 6;
            // 
            // labelPrize
            // 
            this.labelPrize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPrize.AutoSize = true;
            this.labelPrize.Location = new System.Drawing.Point(284, 163);
            this.labelPrize.Name = "labelPrize";
            this.labelPrize.Size = new System.Drawing.Size(67, 15);
            this.labelPrize.TabIndex = 5;
            this.labelPrize.Text = "商品单价";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(284, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "商品信息";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDetail);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textClient;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textPrize;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelPrize;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonFinished;
        private System.Windows.Forms.Panel panelDetail;
    }
}