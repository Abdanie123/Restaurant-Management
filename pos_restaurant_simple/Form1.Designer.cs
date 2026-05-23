using System;
using System.Windows.Forms;

namespace pos_restaurant_simple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Menu = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderDetails = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ManageMenu = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.TabControl1.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.OrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.ManageMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Menu);
            this.TabControl1.Controls.Add(this.OrderDetails);
            this.TabControl1.Controls.Add(this.ManageMenu);
            this.TabControl1.Location = new System.Drawing.Point(12, 28);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(843, 508);
            this.TabControl1.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu.BackgroundImage")));
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.button2);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.dataGridView2);
            this.Menu.Controls.Add(this.dataGridView1);
            this.Menu.Location = new System.Drawing.Point(4, 29);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3);
            this.Menu.Size = new System.Drawing.Size(835, 475);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(445, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(346, 208);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(380, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OrderDetails
            // 
            this.OrderDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderDetails.BackgroundImage")));
            this.OrderDetails.Controls.Add(this.button4);
            this.OrderDetails.Controls.Add(this.dataGridView3);
            this.OrderDetails.Location = new System.Drawing.Point(4, 29);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.OrderDetails.Size = new System.Drawing.Size(835, 475);
            this.OrderDetails.TabIndex = 1;
            this.OrderDetails.Text = "Order Details";
            this.OrderDetails.UseVisualStyleBackColor = true;
            this.OrderDetails.Click += new System.EventHandler(this.OrderDetails_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(489, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 587);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(145, 48);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(535, 265);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // ManageMenu
            // 
            this.ManageMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ManageMenu.BackgroundImage")));
            this.ManageMenu.Controls.Add(this.label5);
            this.ManageMenu.Controls.Add(this.textBox3);
            this.ManageMenu.Controls.Add(this.label4);
            this.ManageMenu.Controls.Add(this.label3);
            this.ManageMenu.Controls.Add(this.label2);
            this.ManageMenu.Controls.Add(this.textBox2);
            this.ManageMenu.Controls.Add(this.textBox1);
            this.ManageMenu.Controls.Add(this.comboBox1);
            this.ManageMenu.Controls.Add(this.button7);
            this.ManageMenu.Controls.Add(this.button6);
            this.ManageMenu.Controls.Add(this.button5);
            this.ManageMenu.Controls.Add(this.dataGridView5);
            this.ManageMenu.Location = new System.Drawing.Point(4, 29);
            this.ManageMenu.Name = "ManageMenu";
            this.ManageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.ManageMenu.Size = new System.Drawing.Size(835, 475);
            this.ManageMenu.TabIndex = 2;
            this.ManageMenu.Text = "Manage Menu";
            this.ManageMenu.UseVisualStyleBackColor = true;
            this.ManageMenu.Click += new System.EventHandler(this.ManageMenu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Item ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 328);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Item Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(340, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(481, 324);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(634, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 33);
            this.button7.TabIndex = 3;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(634, 120);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 33);
            this.button6.TabIndex = 2;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(634, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 33);
            this.button5.TabIndex = 1;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(45, 38);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 62;
            this.dataGridView5.RowTemplate.Height = 28;
            this.dataGridView5.Size = new System.Drawing.Size(557, 247);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1173, 658);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl1.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.OrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ManageMenu.ResumeLayout(false);
            this.ManageMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.TabPage OrderDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage ManageMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}

