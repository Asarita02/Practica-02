namespace Cedula
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbnombres = new System.Windows.Forms.Label();
            this.lbfechanacimiento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblugarnacimiento = new System.Windows.Forms.Label();
            this.cblugardenacimiento = new System.Windows.Forms.ComboBox();
            this.lbgruposanguineo = new System.Windows.Forms.Label();
            this.clbgruposanguineo = new System.Windows.Forms.CheckedListBox();
            this.cbestadocivil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.lbcelular = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lbocupacion = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbsexo = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lbnombres
            // 
            this.lbnombres.AutoSize = true;
            this.lbnombres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbnombres.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombres.Location = new System.Drawing.Point(12, 18);
            this.lbnombres.Name = "lbnombres";
            this.lbnombres.Size = new System.Drawing.Size(103, 24);
            this.lbnombres.TabIndex = 0;
            this.lbnombres.Text = "Nombres";
            // 
            // lbfechanacimiento
            // 
            this.lbfechanacimiento.AutoSize = true;
            this.lbfechanacimiento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbfechanacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfechanacimiento.Location = new System.Drawing.Point(518, 18);
            this.lbfechanacimiento.Name = "lbfechanacimiento";
            this.lbfechanacimiento.Size = new System.Drawing.Size(223, 24);
            this.lbfechanacimiento.TabIndex = 1;
            this.lbfechanacimiento.Text = "Fecha de Nacimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(262, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellidos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Nombres";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(257, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Apellidos";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(515, 55);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(226, 20);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblugarnacimiento
            // 
            this.lblugarnacimiento.AutoSize = true;
            this.lblugarnacimiento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblugarnacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblugarnacimiento.Location = new System.Drawing.Point(12, 120);
            this.lblugarnacimiento.Name = "lblugarnacimiento";
            this.lblugarnacimiento.Size = new System.Drawing.Size(221, 24);
            this.lblugarnacimiento.TabIndex = 6;
            this.lblugarnacimiento.Text = "Lugar de Nacimiento";
            // 
            // cblugardenacimiento
            // 
            this.cblugardenacimiento.FormattingEnabled = true;
            this.cblugardenacimiento.Items.AddRange(new object[] {
            "Puerto Plata",
            "Santo Domingo",
            "Santiago de Los Caballeros",
            "Azua",
            "Samaná",
            "Elias Piña",
            "San Juan",
            "Salcedo",
            "Monte Cristi",
            "Pedernales",
            "La Romana",
            "Bahoruco ",
            "Peravia ",
            "Duarte",
            "La Vega",
            "San José de Ocoa"});
            this.cblugardenacimiento.Location = new System.Drawing.Point(16, 176);
            this.cblugardenacimiento.Name = "cblugardenacimiento";
            this.cblugardenacimiento.Size = new System.Drawing.Size(222, 21);
            this.cblugardenacimiento.TabIndex = 7;
            this.cblugardenacimiento.Text = "Por favor selecciona una opción";
            // 
            // lbgruposanguineo
            // 
            this.lbgruposanguineo.AutoSize = true;
            this.lbgruposanguineo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbgruposanguineo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgruposanguineo.Location = new System.Drawing.Point(262, 120);
            this.lbgruposanguineo.Name = "lbgruposanguineo";
            this.lbgruposanguineo.Size = new System.Drawing.Size(189, 24);
            this.lbgruposanguineo.TabIndex = 8;
            this.lbgruposanguineo.Text = "Grupo Sanguineo";
            // 
            // clbgruposanguineo
            // 
            this.clbgruposanguineo.FormattingEnabled = true;
            this.clbgruposanguineo.Items.AddRange(new object[] {
            "A +",
            "A-",
            "O+",
            "O-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.clbgruposanguineo.Location = new System.Drawing.Point(257, 176);
            this.clbgruposanguineo.Name = "clbgruposanguineo";
            this.clbgruposanguineo.Size = new System.Drawing.Size(226, 49);
            this.clbgruposanguineo.TabIndex = 9;
            // 
            // cbestadocivil
            // 
            this.cbestadocivil.FormattingEnabled = true;
            this.cbestadocivil.Items.AddRange(new object[] {
            "Casado",
            "Viudo",
            "Soltero",
            "Divorciado",
            "Comprometido"});
            this.cbestadocivil.Location = new System.Drawing.Point(515, 176);
            this.cbestadocivil.Name = "cbestadocivil";
            this.cbestadocivil.Size = new System.Drawing.Size(226, 21);
            this.cbestadocivil.TabIndex = 10;
            this.cbestadocivil.Text = "Por favor selecciona una opción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado Civil";
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbdireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdireccion.Location = new System.Drawing.Point(12, 255);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(114, 24);
            this.lbdireccion.TabIndex = 12;
            this.lbdireccion.Text = "Dirección ";
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(12, 296);
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(729, 20);
            this.tbdireccion.TabIndex = 13;
            this.tbdireccion.Text = "Calle Lucia Mendez No.54, Ensanche Quisqueya, Distrito Nacional, Santo Domingo, R" +
    "epublica Dominicana";
            // 
            // lbcelular
            // 
            this.lbcelular.AutoSize = true;
            this.lbcelular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbcelular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcelular.Location = new System.Drawing.Point(12, 347);
            this.lbcelular.Name = "lbcelular";
            this.lbcelular.Size = new System.Drawing.Size(84, 24);
            this.lbcelular.TabIndex = 14;
            this.lbcelular.Text = "Celular";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(16, 397);
            this.maskedTextBox2.Mask = "000-000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(222, 20);
            this.maskedTextBox2.TabIndex = 15;
            // 
            // lbocupacion
            // 
            this.lbocupacion.AutoSize = true;
            this.lbocupacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbocupacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbocupacion.Location = new System.Drawing.Point(266, 347);
            this.lbocupacion.Name = "lbocupacion";
            this.lbocupacion.Size = new System.Drawing.Size(121, 24);
            this.lbocupacion.TabIndex = 16;
            this.lbocupacion.Text = "Ocupación";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ingeniero Civil",
            "Contador",
            "Arquicteto",
            "Telemarket",
            "Diseñador Grafico",
            "Ingeniero en Sistema",
            "Ingenieor Industrial",
            "Telematico",
            "Programador",
            "Negociador",
            "Empresario",
            "Vendedor"});
            this.comboBox1.Location = new System.Drawing.Point(257, 397);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Por favor Seleccione una opción";
            // 
            // lbsexo
            // 
            this.lbsexo.AutoSize = true;
            this.lbsexo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbsexo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsexo.Location = new System.Drawing.Point(518, 337);
            this.lbsexo.Name = "lbsexo";
            this.lbsexo.Size = new System.Drawing.Size(60, 24);
            this.lbsexo.TabIndex = 18;
            this.lbsexo.Text = "Sexo";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Prefiero No decirlo"});
            this.checkedListBox1.Location = new System.Drawing.Point(515, 378);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(226, 49);
            this.checkedListBox1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbsexo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbocupacion);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lbcelular);
            this.Controls.Add(this.tbdireccion);
            this.Controls.Add(this.lbdireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbestadocivil);
            this.Controls.Add(this.clbgruposanguineo);
            this.Controls.Add(this.lbgruposanguineo);
            this.Controls.Add(this.cblugardenacimiento);
            this.Controls.Add(this.lblugarnacimiento);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbfechanacimiento);
            this.Controls.Add(this.lbnombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombres;
        private System.Windows.Forms.Label lbfechanacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblugarnacimiento;
        private System.Windows.Forms.ComboBox cblugardenacimiento;
        private System.Windows.Forms.Label lbgruposanguineo;
        private System.Windows.Forms.CheckedListBox clbgruposanguineo;
        private System.Windows.Forms.ComboBox cbestadocivil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.TextBox tbdireccion;
        private System.Windows.Forms.Label lbcelular;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lbocupacion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbsexo;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

