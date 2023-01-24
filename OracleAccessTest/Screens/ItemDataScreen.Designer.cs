
namespace OracleAccessTest.Screens
{
    partial class ItemDataScreen
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
            this.itemIDText = new System.Windows.Forms.TextBox();
            this.itemNameText = new System.Windows.Forms.TextBox();
            this.itemAmountText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.ApplyChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemIDText
            // 
            this.itemIDText.Enabled = false;
            this.itemIDText.Location = new System.Drawing.Point(260, 150);
            this.itemIDText.Name = "itemIDText";
            this.itemIDText.Size = new System.Drawing.Size(159, 20);
            this.itemIDText.TabIndex = 0;
            // 
            // itemNameText
            // 
            this.itemNameText.Enabled = false;
            this.itemNameText.Location = new System.Drawing.Point(260, 196);
            this.itemNameText.Name = "itemNameText";
            this.itemNameText.Size = new System.Drawing.Size(159, 20);
            this.itemNameText.TabIndex = 1;
            // 
            // itemAmountText
            // 
            this.itemAmountText.Enabled = false;
            this.itemAmountText.Location = new System.Drawing.Point(260, 239);
            this.itemAmountText.Name = "itemAmountText";
            this.itemAmountText.Size = new System.Drawing.Size(159, 20);
            this.itemAmountText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ITEM DATA";
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(532, 217);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(114, 23);
            this.ModifyButton.TabIndex = 8;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // ApplyChangesButton
            // 
            this.ApplyChangesButton.Location = new System.Drawing.Point(532, 167);
            this.ApplyChangesButton.Name = "ApplyChangesButton";
            this.ApplyChangesButton.Size = new System.Drawing.Size(114, 23);
            this.ApplyChangesButton.TabIndex = 9;
            this.ApplyChangesButton.Text = "Apply Changes";
            this.ApplyChangesButton.UseVisualStyleBackColor = true;
            this.ApplyChangesButton.Visible = false;
            this.ApplyChangesButton.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // ItemDataScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApplyChangesButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemAmountText);
            this.Controls.Add(this.itemNameText);
            this.Controls.Add(this.itemIDText);
            this.Name = "ItemDataScreen";
            this.Text = "ItemDataScreen";
            this.Load += new System.EventHandler(this.ItemDataScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemIDText;
        private System.Windows.Forms.TextBox itemNameText;
        private System.Windows.Forms.TextBox itemAmountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button ApplyChangesButton;
    }
}