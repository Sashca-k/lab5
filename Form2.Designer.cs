namespace suspliers
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label company_NameLabel;
            System.Windows.Forms.Label postal_CodeLabel;
            System.Windows.Forms.Label cityLabel;
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.company_NameTextBox = new System.Windows.Forms.TextBox();
            this.postal_CodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.suppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            company_NameLabel = new System.Windows.Forms.Label();
            postal_CodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(125, 32);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(156, 29);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDTextBox.TabIndex = 2;
            // 
            // company_NameLabel
            // 
            company_NameLabel.AutoSize = true;
            company_NameLabel.Location = new System.Drawing.Point(38, 60);
            company_NameLabel.Name = "company_NameLabel";
            company_NameLabel.Size = new System.Drawing.Size(112, 17);
            company_NameLabel.TabIndex = 3;
            company_NameLabel.Text = "Company Name:";
            // 
            // company_NameTextBox
            // 
            this.company_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppBindingSource, "Company_Name", true));
            this.company_NameTextBox.Location = new System.Drawing.Point(156, 57);
            this.company_NameTextBox.Name = "company_NameTextBox";
            this.company_NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.company_NameTextBox.TabIndex = 4;
            // 
            // postal_CodeLabel
            // 
            postal_CodeLabel.AutoSize = true;
            postal_CodeLabel.Location = new System.Drawing.Point(62, 88);
            postal_CodeLabel.Name = "postal_CodeLabel";
            postal_CodeLabel.Size = new System.Drawing.Size(88, 17);
            postal_CodeLabel.TabIndex = 5;
            postal_CodeLabel.Text = "Postal Code:";
            // 
            // postal_CodeTextBox
            // 
            this.postal_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppBindingSource, "Postal_Code", true));
            this.postal_CodeTextBox.Location = new System.Drawing.Point(156, 85);
            this.postal_CodeTextBox.Name = "postal_CodeTextBox";
            this.postal_CodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.postal_CodeTextBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(115, 116);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(156, 113);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // suppBindingSource
            // 
            this.suppBindingSource.DataSource = typeof(suspliers.supp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(postal_CodeLabel);
            this.Controls.Add(this.postal_CodeTextBox);
            this.Controls.Add(company_NameLabel);
            this.Controls.Add(this.company_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource suppBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox company_NameTextBox;
        private System.Windows.Forms.TextBox postal_CodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}