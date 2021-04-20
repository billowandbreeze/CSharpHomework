
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
            this.textID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textID.Location = new System.Drawing.Point(433, 161);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 25);
            this.textID.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(247, 164);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 15);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonChange.Location = new System.Drawing.Point(360, 312);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textID);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonChange;
    }
}