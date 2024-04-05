namespace SistemasVentas.VISTA.VentaVistas
{
    partial class VentaInterfazVendedor
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
            label2 = new Label();
            textBox3 = new TextBox();
            button6 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            button5 = new Button();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 20);
            label2.Name = "label2";
            label2.Size = new Size(74, 27);
            label2.TabIndex = 168;
            label2.Text = "TOTAL";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(28, 65);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 27);
            textBox3.TabIndex = 167;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Image = Properties.Resources.Checkmark__1_;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(235, 144);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(156, 31);
            button6.TabIndex = 166;
            button6.Text = "SELECCIONAR";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(28, 157);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 165;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 112);
            label1.Name = "label1";
            label1.Size = new Size(76, 27);
            label1.TabIndex = 164;
            label1.Text = "FECHA";
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = Properties.Resources.Checkmark__1_;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(235, 63);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(156, 31);
            button5.TabIndex = 163;
            button5.Text = "SELECCIONAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(42, 112);
            label9.Name = "label9";
            label9.Size = new Size(149, 27);
            label9.TabIndex = 162;
            label9.Text = "ID VENDEDOR";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 148);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 27);
            textBox2.TabIndex = 161;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(42, 20);
            label8.Name = "label8";
            label8.Size = new Size(117, 27);
            label8.TabIndex = 160;
            label8.Text = "ID CLIENTE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 65);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 159;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.Add;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(200, 631);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(164, 36);
            button3.TabIndex = 154;
            button3.Text = "INSERTAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.DialogResult = DialogResult.OK;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.Broom;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(402, 631);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(164, 36);
            button2.TabIndex = 152;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Peru;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 408);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(810, 179);
            dataGridView1.TabIndex = 150;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 133);
            panel1.TabIndex = 169;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Menu;
            label7.Location = new Point(360, 39);
            label7.Name = "label7";
            label7.Size = new Size(148, 47);
            label7.TabIndex = 0;
            label7.Text = "VENTA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(533, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 210);
            panel2.TabIndex = 170;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Peru;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(button5);
            panel3.Location = new Point(24, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 210);
            panel3.TabIndex = 171;
            // 
            // VentaInterfazVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 35, 37);
            ClientSize = new Size(867, 692);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VentaInterfazVendedor";
            Text = "VentaInterfazVendedor";
            Load += VentaInterfazVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox textBox3;
        private Button button6;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button button5;
        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Panel panel3;
    }
}