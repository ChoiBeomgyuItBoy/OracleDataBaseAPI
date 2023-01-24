
namespace OracleAccessTest.Screens
{
    partial class Form1
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
            this.ItemsView = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ItemIDText = new System.Windows.Forms.TextBox();
            this.itemNameText = new System.Windows.Forms.TextBox();
            this.itemAmountText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NameSizeButton = new System.Windows.Forms.Button();
            this.ItemLookupText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemLookupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsView
            // 
            this.ItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsView.Location = new System.Drawing.Point(28, 87);
            this.ItemsView.Name = "ItemsView";
            this.ItemsView.Size = new System.Drawing.Size(357, 236);
            this.ItemsView.TabIndex = 1;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(55, 36);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update Table";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ItemIDText
            // 
            this.ItemIDText.Location = new System.Drawing.Point(96, 401);
            this.ItemIDText.Name = "ItemIDText";
            this.ItemIDText.Size = new System.Drawing.Size(163, 20);
            this.ItemIDText.TabIndex = 3;
            // 
            // itemNameText
            // 
            this.itemNameText.Location = new System.Drawing.Point(96, 447);
            this.itemNameText.Name = "itemNameText";
            this.itemNameText.Size = new System.Drawing.Size(163, 20);
            this.itemNameText.TabIndex = 4;
            // 
            // itemAmountText
            // 
            this.itemAmountText.Location = new System.Drawing.Point(96, 496);
            this.itemAmountText.Name = "itemAmountText";
            this.itemAmountText.Size = new System.Drawing.Size(163, 20);
            this.itemAmountText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount";
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(133, 547);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddItemButton.TabIndex = 9;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Create Item";
            // 
            // NameSizeButton
            // 
            this.NameSizeButton.Location = new System.Drawing.Point(310, 357);
            this.NameSizeButton.Name = "NameSizeButton";
            this.NameSizeButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NameSizeButton.Size = new System.Drawing.Size(75, 23);
            this.NameSizeButton.TabIndex = 12;
            this.NameSizeButton.Text = "Get Sizes";
            this.NameSizeButton.UseVisualStyleBackColor = true;
            this.NameSizeButton.Click += new System.EventHandler(this.NameSizeButton_Click);
            // 
            // ItemLookupText
            // 
            this.ItemLookupText.Location = new System.Drawing.Point(511, 394);
            this.ItemLookupText.Name = "ItemLookupText";
            this.ItemLookupText.Size = new System.Drawing.Size(163, 20);
            this.ItemLookupText.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // ItemLookupButton
            // 
            this.ItemLookupButton.Location = new System.Drawing.Point(526, 437);
            this.ItemLookupButton.Name = "ItemLookupButton";
            this.ItemLookupButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ItemLookupButton.Size = new System.Drawing.Size(127, 23);
            this.ItemLookupButton.TabIndex = 15;
            this.ItemLookupButton.Text = "Get Item with ID";
            this.ItemLookupButton.UseVisualStyleBackColor = true;
            this.ItemLookupButton.Click += new System.EventHandler(this.ItemLookupButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 691);
            this.Controls.Add(this.ItemLookupButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ItemLookupText);
            this.Controls.Add(this.NameSizeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemAmountText);
            this.Controls.Add(this.itemNameText);
            this.Controls.Add(this.ItemIDText);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ItemsView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ItemsView;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox ItemIDText;
        private System.Windows.Forms.TextBox itemNameText;
        private System.Windows.Forms.TextBox itemAmountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NameSizeButton;
        private System.Windows.Forms.TextBox ItemLookupText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ItemLookupButton;
    }
}

