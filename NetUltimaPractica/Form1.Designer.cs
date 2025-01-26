namespace NetUltimaPractica
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbDptos = new ComboBox();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            btnInsertar = new Button();
            lstEmpleados = new ListBox();
            txtSalario = new TextBox();
            txtOficio = new TextBox();
            txtApellido = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnUpdate = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 46);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 175);
            label2.Name = "label2";
            label2.Size = new Size(47, 41);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 291);
            label3.Name = "label3";
            label3.Size = new Size(128, 41);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 432);
            label4.Name = "label4";
            label4.Size = new Size(144, 41);
            label4.TabIndex = 3;
            label4.Text = "Localidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 46);
            label5.Name = "label5";
            label5.Size = new Size(164, 41);
            label5.TabIndex = 4;
            label5.Text = "Empleados";
            // 
            // cmbDptos
            // 
            cmbDptos.FormattingEnabled = true;
            cmbDptos.Location = new Point(60, 102);
            cmbDptos.Name = "cmbDptos";
            cmbDptos.Size = new Size(302, 49);
            cmbDptos.TabIndex = 5;
            cmbDptos.SelectedIndexChanged += cmbDptos_SelectedIndexChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(60, 231);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 47);
            txtId.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 370);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 47);
            txtNombre.TabIndex = 7;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(60, 503);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(250, 47);
            txtLocalidad.TabIndex = 8;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(60, 607);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(250, 68);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "Insertar Dpto";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(467, 130);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(477, 537);
            lstEmpleados.TabIndex = 10;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(1025, 418);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(250, 47);
            txtSalario.TabIndex = 16;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(1025, 285);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(250, 47);
            txtOficio.TabIndex = 15;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(1025, 146);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 47);
            txtApellido.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1025, 347);
            label6.Name = "label6";
            label6.Size = new Size(106, 41);
            label6.TabIndex = 13;
            label6.Text = "Salario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1025, 206);
            label7.Name = "label7";
            label7.Size = new Size(96, 41);
            label7.TabIndex = 12;
            label7.Text = "Oficio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1025, 90);
            label8.Name = "label8";
            label8.Size = new Size(128, 41);
            label8.TabIndex = 11;
            label8.Text = "Apellido";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1025, 527);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(250, 108);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update empleado";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(622, 713);
            button1.Name = "button1";
            button1.Size = new Size(188, 95);
            button1.TabIndex = 18;
            button1.Text = "Delete empleado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 852);
            Controls.Add(button1);
            Controls.Add(btnUpdate);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(txtApellido);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(lstEmpleados);
            Controls.Add(btnInsertar);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(cmbDptos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbDptos;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Button btnInsertar;
        private ListBox lstEmpleados;
        private TextBox txtSalario;
        private TextBox txtOficio;
        private TextBox txtApellido;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnUpdate;
        private Button button1;
    }
}
