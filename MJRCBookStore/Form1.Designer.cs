
namespace MJRCBookStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbEnglish = new System.Windows.Forms.CheckBox();
            this.cbMath = new System.Windows.Forms.CheckBox();
            this.cbScience = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEnglish = new System.Windows.Forms.ComboBox();
            this.comboBoxMath = new System.Windows.Forms.ComboBox();
            this.comboBoxScience = new System.Windows.Forms.ComboBox();
            this.tbQtyEnglish = new System.Windows.Forms.TextBox();
            this.tbQtyMath = new System.Windows.Forms.TextBox();
            this.tbQtyScience = new System.Windows.Forms.TextBox();
            this.tbStEnglish = new System.Windows.Forms.TextBox();
            this.tbStMath = new System.Windows.Forms.TextBox();
            this.tbStScience = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblSummaryOrders = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // cbEnglish
            // 
            this.cbEnglish.AutoSize = true;
            this.cbEnglish.Location = new System.Drawing.Point(37, 80);
            this.cbEnglish.Name = "cbEnglish";
            this.cbEnglish.Size = new System.Drawing.Size(114, 19);
            this.cbEnglish.TabIndex = 0;
            this.cbEnglish.Text = "Everyday English";
            this.cbEnglish.UseVisualStyleBackColor = true;
            this.cbEnglish.CheckedChanged += new System.EventHandler(this.cbEnglish_CheckedChanged);
            // 
            // cbMath
            // 
            this.cbMath.AutoSize = true;
            this.cbMath.Location = new System.Drawing.Point(37, 109);
            this.cbMath.Name = "cbMath";
            this.cbMath.Size = new System.Drawing.Size(152, 19);
            this.cbMath.TabIndex = 1;
            this.cbMath.Text = "Integrated Mathematics";
            this.cbMath.UseVisualStyleBackColor = true;
            this.cbMath.CheckedChanged += new System.EventHandler(this.cbMath_CheckedChanged);
            // 
            // cbScience
            // 
            this.cbScience.AutoSize = true;
            this.cbScience.Location = new System.Drawing.Point(37, 140);
            this.cbScience.Name = "cbScience";
            this.cbScience.Size = new System.Drawing.Size(130, 19);
            this.cbScience.TabIndex = 2;
            this.cbScience.Text = "Wonders of Science";
            this.cbScience.UseVisualStyleBackColor = true;
            this.cbScience.CheckedChanged += new System.EventHandler(this.cbScience_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.Location = new System.Drawing.Point(276, 55);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(37, 15);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(416, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(546, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sub-Total";
            // 
            // comboBoxEnglish
            // 
            this.comboBoxEnglish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnglish.Enabled = false;
            this.comboBoxEnglish.FormattingEnabled = true;
            this.comboBoxEnglish.Items.AddRange(new object[] {
            "NURSERY",
            "KINDER ",
            "PREP"});
            this.comboBoxEnglish.Location = new System.Drawing.Point(241, 78);
            this.comboBoxEnglish.Name = "comboBoxEnglish";
            this.comboBoxEnglish.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEnglish.TabIndex = 7;
            this.comboBoxEnglish.SelectedIndexChanged += new System.EventHandler(this.comboBoxEnglish_SelectedIndexChanged);
            // 
            // comboBoxMath
            // 
            this.comboBoxMath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMath.Enabled = false;
            this.comboBoxMath.FormattingEnabled = true;
            this.comboBoxMath.Items.AddRange(new object[] {
            "NURSERY",
            "KINDER ",
            "PREP"});
            this.comboBoxMath.Location = new System.Drawing.Point(241, 107);
            this.comboBoxMath.Name = "comboBoxMath";
            this.comboBoxMath.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMath.TabIndex = 8;
            this.comboBoxMath.SelectedIndexChanged += new System.EventHandler(this.comboBoxMath_SelectedIndexChanged);
            // 
            // comboBoxScience
            // 
            this.comboBoxScience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScience.Enabled = false;
            this.comboBoxScience.FormattingEnabled = true;
            this.comboBoxScience.Items.AddRange(new object[] {
            "NURSERY",
            "KINDER ",
            "PREP"});
            this.comboBoxScience.Location = new System.Drawing.Point(241, 138);
            this.comboBoxScience.Name = "comboBoxScience";
            this.comboBoxScience.Size = new System.Drawing.Size(121, 23);
            this.comboBoxScience.TabIndex = 9;
            this.comboBoxScience.SelectedIndexChanged += new System.EventHandler(this.comboBoxScience_SelectedIndexChanged);
            // 
            // tbQtyEnglish
            // 
            this.tbQtyEnglish.Enabled = false;
            this.tbQtyEnglish.Location = new System.Drawing.Point(394, 78);
            this.tbQtyEnglish.Name = "tbQtyEnglish";
            this.tbQtyEnglish.Size = new System.Drawing.Size(100, 23);
            this.tbQtyEnglish.TabIndex = 10;
            this.tbQtyEnglish.TextChanged += new System.EventHandler(this.tbQtyEnglish_TextChanged);
            // 
            // tbQtyMath
            // 
            this.tbQtyMath.Enabled = false;
            this.tbQtyMath.Location = new System.Drawing.Point(394, 107);
            this.tbQtyMath.Name = "tbQtyMath";
            this.tbQtyMath.Size = new System.Drawing.Size(100, 23);
            this.tbQtyMath.TabIndex = 11;
            // 
            // tbQtyScience
            // 
            this.tbQtyScience.Enabled = false;
            this.tbQtyScience.Location = new System.Drawing.Point(394, 137);
            this.tbQtyScience.Name = "tbQtyScience";
            this.tbQtyScience.Size = new System.Drawing.Size(100, 23);
            this.tbQtyScience.TabIndex = 12;
            this.tbQtyScience.TextChanged += new System.EventHandler(this.tbQtyScience_TextChanged);
            // 
            // tbStEnglish
            // 
            this.tbStEnglish.Enabled = false;
            this.tbStEnglish.Location = new System.Drawing.Point(527, 78);
            this.tbStEnglish.Name = "tbStEnglish";
            this.tbStEnglish.Size = new System.Drawing.Size(100, 23);
            this.tbStEnglish.TabIndex = 13;
            // 
            // tbStMath
            // 
            this.tbStMath.Enabled = false;
            this.tbStMath.Location = new System.Drawing.Point(527, 107);
            this.tbStMath.Name = "tbStMath";
            this.tbStMath.Size = new System.Drawing.Size(100, 23);
            this.tbStMath.TabIndex = 14;
            // 
            // tbStScience
            // 
            this.tbStScience.Enabled = false;
            this.tbStScience.Location = new System.Drawing.Point(527, 137);
            this.tbStScience.Name = "tbStScience";
            this.tbStScience.Size = new System.Drawing.Size(100, 23);
            this.tbStScience.TabIndex = 15;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.Location = new System.Drawing.Point(429, 199);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(85, 15);
            this.lblTotalAmount.TabIndex = 16;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Enabled = false;
            this.tbAmount.Location = new System.Drawing.Point(527, 196);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 23);
            this.tbAmount.TabIndex = 17;
            this.tbAmount.TextChanged += new System.EventHandler(this.tbAmount_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "btn-&COMPUTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "btn-CLEA&R";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 40);
            this.button3.TabIndex = 20;
            this.button3.Text = "btn-CLO&SE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblSummaryOrders
            // 
            this.lblSummaryOrders.AutoSize = true;
            this.lblSummaryOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSummaryOrders.Location = new System.Drawing.Point(97, 310);
            this.lblSummaryOrders.Name = "lblSummaryOrders";
            this.lblSummaryOrders.Size = new System.Drawing.Size(132, 15);
            this.lblSummaryOrders.TabIndex = 21;
            this.lblSummaryOrders.Text = "SUMMARY OF ORDERS:";
            this.lblSummaryOrders.Click += new System.EventHandler(this.lblSummaryOrders_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(136, 349);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(453, 150);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book Title";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Level";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 548);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblSummaryOrders);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.tbStScience);
            this.Controls.Add(this.tbStMath);
            this.Controls.Add(this.tbStEnglish);
            this.Controls.Add(this.tbQtyScience);
            this.Controls.Add(this.tbQtyMath);
            this.Controls.Add(this.tbQtyEnglish);
            this.Controls.Add(this.comboBoxScience);
            this.Controls.Add(this.comboBoxMath);
            this.Controls.Add(this.comboBoxEnglish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbScience);
            this.Controls.Add(this.cbMath);
            this.Controls.Add(this.cbEnglish);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MJRC Book Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbEnglish;
        private System.Windows.Forms.CheckBox cbMath;
        private System.Windows.Forms.CheckBox cbScience;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEnglish;
        private System.Windows.Forms.ComboBox comboBoxMath;
        private System.Windows.Forms.ComboBox comboBoxScience;
        private System.Windows.Forms.TextBox tbQtyEnglish;
        private System.Windows.Forms.TextBox tbQtyMath;
        private System.Windows.Forms.TextBox tbQtyScience;
        private System.Windows.Forms.TextBox tbStEnglish;
        private System.Windows.Forms.TextBox tbStMath;
        private System.Windows.Forms.TextBox tbStScience;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblSummaryOrders;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

