
namespace OrderForms
{
    partial class SearchForm
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
            this.labelKey = new System.Windows.Forms.Label();
            this.textKey = new System.Windows.Forms.TextBox();
            this.buttonID = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonPrize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(245, 147);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(79, 15);
            this.labelKey.TabIndex = 0;
            this.labelKey.Text = "Key Words";
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(413, 144);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(100, 25);
            this.textKey.TabIndex = 1;
            // 
            // buttonID
            // 
            this.buttonID.Location = new System.Drawing.Point(145, 247);
            this.buttonID.Name = "buttonID";
            this.buttonID.Size = new System.Drawing.Size(92, 23);
            this.buttonID.TabIndex = 2;
            this.buttonID.Text = "BY ID";
            this.buttonID.UseVisualStyleBackColor = true;
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(332, 247);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(104, 23);
            this.buttonClient.TabIndex = 3;
            this.buttonClient.Text = "By Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            // 
            // buttonPrize
            // 
            this.buttonPrize.Location = new System.Drawing.Point(526, 247);
            this.buttonPrize.Name = "buttonPrize";
            this.buttonPrize.Size = new System.Drawing.Size(97, 23);
            this.buttonPrize.TabIndex = 4;
            this.buttonPrize.Text = "By Prize";
            this.buttonPrize.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search BY...";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrize);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonID);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.labelKey);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Button buttonID;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonPrize;
        private System.Windows.Forms.Label label1;
    }
}