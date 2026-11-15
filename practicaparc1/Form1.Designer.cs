namespace practicaparc1
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
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            textBox_dni = new TextBox();
            textBox_importe = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button_agregar = new Button();
            button_modificar = new Button();
            button_eliminar = new Button();
            textBox_eliminar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(410, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 385);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(59, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBox_dni
            // 
            textBox_dni.Location = new Point(59, 98);
            textBox_dni.Name = "textBox_dni";
            textBox_dni.Size = new Size(100, 23);
            textBox_dni.TabIndex = 2;
            // 
            // textBox_importe
            // 
            textBox_importe.Location = new Point(59, 143);
            textBox_importe.Name = "textBox_importe";
            textBox_importe.Size = new Size(100, 23);
            textBox_importe.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(59, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // button_agregar
            // 
            button_agregar.Location = new Point(48, 242);
            button_agregar.Name = "button_agregar";
            button_agregar.Size = new Size(132, 23);
            button_agregar.TabIndex = 5;
            button_agregar.Text = "guardar";
            button_agregar.UseVisualStyleBackColor = true;
            button_agregar.Click += button_agregar_Click;
            // 
            // button_modificar
            // 
            button_modificar.Location = new Point(281, 76);
            button_modificar.Name = "button_modificar";
            button_modificar.Size = new Size(75, 61);
            button_modificar.TabIndex = 6;
            button_modificar.Text = "modificar";
            button_modificar.UseVisualStyleBackColor = true;
            button_modificar.Click += button_modificar_Click;
            // 
            // button_eliminar
            // 
            button_eliminar.Location = new Point(281, 391);
            button_eliminar.Name = "button_eliminar";
            button_eliminar.Size = new Size(75, 23);
            button_eliminar.TabIndex = 7;
            button_eliminar.Text = "eliminar";
            button_eliminar.UseVisualStyleBackColor = true;
            button_eliminar.Click += button_eliminar_Click;
            // 
            // textBox_eliminar
            // 
            textBox_eliminar.Location = new Point(59, 391);
            textBox_eliminar.Name = "textBox_eliminar";
            textBox_eliminar.Size = new Size(100, 23);
            textBox_eliminar.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_eliminar);
            Controls.Add(button_eliminar);
            Controls.Add(button_modificar);
            Controls.Add(button_agregar);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox_importe);
            Controls.Add(textBox_dni);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox textBox_dni;
        private TextBox textBox_importe;
        private DateTimePicker dateTimePicker1;
        private Button button_agregar;
        private Button button_modificar;
        private Button button_eliminar;
        private TextBox textBox_eliminar;
    }
}
