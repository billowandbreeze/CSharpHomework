﻿
namespace OrderForms
{
    partial class ChangeForm
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
            this.textChangeID = new System.Windows.Forms.TextBox();
            this.labelChangeID = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textCilent = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textNum = new System.Windows.Forms.TextBox();
            this.textPrize = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelPrize = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textChangeID
            // 
            this.textChangeID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textChangeID.Location = new System.Drawing.Point(400, 34);
            this.textChangeID.Name = "textChangeID";
            this.textChangeID.Size = new System.Drawing.Size(100, 25);
            this.textChangeID.TabIndex = 0;
            // 
            // labelChangeID
            // 
            this.labelChangeID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelChangeID.AutoSize = true;
            this.labelChangeID.Location = new System.Drawing.Point(288, 37);
            this.labelChangeID.Name = "labelChangeID";
            this.labelChangeID.Size = new System.Drawing.Size(38, 15);
            this.labelChangeID.TabIndex = 1;
            this.labelChangeID.Text = "原ID";
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonChange.Location = new System.Drawing.Point(357, 260);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(100, 30);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "修改订单";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelChangeID);
            this.panel1.Controls.Add(this.textChangeID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 350);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonChange);
            this.panel3.Controls.Add(this.textCilent);
            this.panel3.Controls.Add(this.textID);
            this.panel3.Controls.Add(this.labelClient);
            this.panel3.Controls.Add(this.labelI);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 350);
            this.panel3.TabIndex = 0;
            // 
            // textCilent
            // 
            this.textCilent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textCilent.Location = new System.Drawing.Point(401, 163);
            this.textCilent.Name = "textCilent";
            this.textCilent.Size = new System.Drawing.Size(100, 25);
            this.textCilent.TabIndex = 3;
            // 
            // textID
            // 
            this.textID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textID.Location = new System.Drawing.Point(401, 62);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 25);
            this.textID.TabIndex = 2;
            // 
            // labelClient
            // 
            this.labelClient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(288, 166);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(67, 15);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "修改客户";
            // 
            // labelI
            // 
            this.labelI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelI.AutoSize = true;
            this.labelI.Location = new System.Drawing.Point(288, 65);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(53, 15);
            this.labelI.TabIndex = 0;
            this.labelI.Text = "修改ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonFinish);
            this.panel4.Controls.Add(this.buttonAdd);
            this.panel4.Controls.Add(this.textNum);
            this.panel4.Controls.Add(this.textPrize);
            this.panel4.Controls.Add(this.textName);
            this.panel4.Controls.Add(this.labelNum);
            this.panel4.Controls.Add(this.labelPrize);
            this.panel4.Controls.Add(this.labelName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 350);
            this.panel4.TabIndex = 1;
            this.panel4.Visible = false;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFinish.Location = new System.Drawing.Point(326, 308);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(150, 30);
            this.buttonFinish.TabIndex = 7;
            this.buttonFinish.Text = "完成修改";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Location = new System.Drawing.Point(326, 260);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 30);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "增加订单详细";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textNum
            // 
            this.textNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textNum.Location = new System.Drawing.Point(401, 204);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(100, 25);
            this.textNum.TabIndex = 5;
            // 
            // textPrize
            // 
            this.textPrize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textPrize.Location = new System.Drawing.Point(401, 122);
            this.textPrize.Name = "textPrize";
            this.textPrize.Size = new System.Drawing.Size(100, 25);
            this.textPrize.TabIndex = 4;
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textName.Location = new System.Drawing.Point(401, 40);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 25);
            this.textName.TabIndex = 3;
            // 
            // labelNum
            // 
            this.labelNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(272, 214);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(67, 15);
            this.labelNum.TabIndex = 2;
            this.labelNum.Text = "商品数量";
            // 
            // labelPrize
            // 
            this.labelPrize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPrize.AutoSize = true;
            this.labelPrize.Location = new System.Drawing.Point(272, 132);
            this.labelPrize.Name = "labelPrize";
            this.labelPrize.Size = new System.Drawing.Size(67, 15);
            this.labelPrize.TabIndex = 1;
            this.labelPrize.Text = "商品单价";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(272, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "商品名";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textChangeID;
        private System.Windows.Forms.Label labelChangeID;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textCilent;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.TextBox textPrize;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelPrize;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Panel panel5;
    }
}