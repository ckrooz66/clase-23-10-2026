namespace Clase_23_10_2026
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
            groupBox1 = new GroupBox();
            btnCrear = new Button();
            fechaAlta = new DateTimePicker();
            txtDescripcionAlta = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtIdTareaModificar = new TextBox();
            label6 = new Label();
            btnModificar = new Button();
            fechaModificacion = new DateTimePicker();
            label4 = new Label();
            txtDescripcionModificar = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            txtIdEliminar = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(495, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(383, 211);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(fechaAlta);
            groupBox1.Controls.Add(txtDescripcionAlta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 149);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(91, 120);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(138, 23);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // fechaAlta
            // 
            fechaAlta.Location = new Point(80, 74);
            fechaAlta.Name = "fechaAlta";
            fechaAlta.Size = new Size(211, 23);
            fechaAlta.TabIndex = 7;
            // 
            // txtDescripcionAlta
            // 
            txtDescripcionAlta.Location = new Point(80, 31);
            txtDescripcionAlta.Name = "txtDescripcionAlta";
            txtDescripcionAlta.Size = new Size(211, 23);
            txtDescripcionAlta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripcion";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIdTareaModificar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(fechaModificacion);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDescripcionModificar);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 206);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar";
            // 
            // txtIdTareaModificar
            // 
            txtIdTareaModificar.Location = new Point(89, 34);
            txtIdTareaModificar.Name = "txtIdTareaModificar";
            txtIdTareaModificar.Size = new Size(211, 23);
            txtIdTareaModificar.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 37);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 11;
            label6.Text = "Id de tarea";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(74, 162);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(138, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // fechaModificacion
            // 
            fechaModificacion.Location = new Point(89, 109);
            fechaModificacion.Name = "fechaModificacion";
            fechaModificacion.Size = new Size(211, 23);
            fechaModificacion.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 111);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "Fecha";
            // 
            // txtDescripcionModificar
            // 
            txtDescripcionModificar.AccessibleRole = AccessibleRole.WhiteSpace;
            txtDescripcionModificar.Location = new Point(89, 73);
            txtDescripcionModificar.Name = "txtDescripcionModificar";
            txtDescripcionModificar.Size = new Size(211, 23);
            txtDescripcionModificar.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "Descripcion";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(txtIdEliminar);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(573, 274);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 115);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(29, 77);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(93, 36);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(74, 23);
            txtIdEliminar.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 39);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 8;
            label5.Text = "Id de tarea";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker fechaAlta;
        private TextBox txtDescripcionAlta;
        private Label label2;
        private Label label1;
        private DateTimePicker fechaModificacion;
        private Label label4;
        private TextBox txtDescripcionModificar;
        private Label label3;
        private TextBox txtIdEliminar;
        private Label label5;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtIdTareaModificar;
        private Label label6;
    }
}
