
namespace OrderForms
{
    partial class DeleteForm
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
            this.labelID = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(260, 148);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 15);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDelete.Location = new System.Drawing.Point(323, 286);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "删除订单";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textID
            // 
            this.textID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textID.Location = new System.Drawing.Point(389, 145);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 25);
            this.textID.TabIndex = 2;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelID);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textID;
    }
}