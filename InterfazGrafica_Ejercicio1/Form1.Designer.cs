namespace datos_alumno
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
            txt_matricula = new TextBox();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_edad = new TextBox();
            txt_carrera = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_pasar = new Button();
            txt_limpiar = new Button();
            txt_cerrar = new Button();
            lbl_matricula = new Label();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            lbl_edad = new Label();
            lbl_carrera = new Label();
            SuspendLayout();
            // 
            // txt_matricula
            // 
            txt_matricula.Location = new Point(287, 110);
            txt_matricula.Margin = new Padding(4, 5, 4, 5);
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(141, 31);
            txt_matricula.TabIndex = 0;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(287, 187);
            txt_nombre.Margin = new Padding(4, 5, 4, 5);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(141, 31);
            txt_nombre.TabIndex = 1;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(287, 273);
            txt_apellido.Margin = new Padding(4, 5, 4, 5);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(141, 31);
            txt_apellido.TabIndex = 2;
            // 
            // txt_edad
            // 
            txt_edad.Location = new Point(287, 351);
            txt_edad.Margin = new Padding(4, 5, 4, 5);
            txt_edad.Name = "txt_edad";
            txt_edad.Size = new Size(141, 31);
            txt_edad.TabIndex = 3;
            // 
            // txt_carrera
            // 
            txt_carrera.Location = new Point(287, 449);
            txt_carrera.Margin = new Padding(4, 5, 4, 5);
            txt_carrera.Name = "txt_carrera";
            txt_carrera.Size = new Size(141, 31);
            txt_carrera.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(136, 112);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 29);
            label1.TabIndex = 5;
            label1.Text = "Matricula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(136, 203);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 29);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(136, 290);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 29);
            label3.TabIndex = 7;
            label3.Text = "Apelllido";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(136, 378);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 29);
            label4.TabIndex = 8;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(136, 467);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 29);
            label5.TabIndex = 9;
            label5.Text = "Carrera";
            label5.Click += label5_Click;
            // 
            // txt_pasar
            // 
            txt_pasar.BackColor = Color.Fuchsia;
            txt_pasar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_pasar.Location = new Point(261, 518);
            txt_pasar.Margin = new Padding(4, 5, 4, 5);
            txt_pasar.Name = "txt_pasar";
            txt_pasar.Size = new Size(136, 43);
            txt_pasar.TabIndex = 10;
            txt_pasar.Text = "Imprimir";
            txt_pasar.UseVisualStyleBackColor = false;
            txt_pasar.Click += txt_pasar_Click;
            // 
            // txt_limpiar
            // 
            txt_limpiar.BackColor = Color.Fuchsia;
            txt_limpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_limpiar.Location = new Point(434, 520);
            txt_limpiar.Margin = new Padding(4, 5, 4, 5);
            txt_limpiar.Name = "txt_limpiar";
            txt_limpiar.Size = new Size(107, 38);
            txt_limpiar.TabIndex = 11;
            txt_limpiar.Text = "Limpiar";
            txt_limpiar.UseVisualStyleBackColor = false;
            txt_limpiar.Click += txt_limpiar_Click;
            // 
            // txt_cerrar
            // 
            txt_cerrar.BackColor = Color.Fuchsia;
            txt_cerrar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_cerrar.Location = new Point(594, 523);
            txt_cerrar.Margin = new Padding(4, 5, 4, 5);
            txt_cerrar.Name = "txt_cerrar";
            txt_cerrar.Size = new Size(107, 38);
            txt_cerrar.TabIndex = 12;
            txt_cerrar.Text = "Cerrar";
            txt_cerrar.UseVisualStyleBackColor = false;
            txt_cerrar.Click += txt_cerrar_Click;
            // 
            // lbl_matricula
            // 
            lbl_matricula.AutoSize = true;
            lbl_matricula.Location = new Point(554, 98);
            lbl_matricula.Margin = new Padding(4, 0, 4, 0);
            lbl_matricula.Name = "lbl_matricula";
            lbl_matricula.Size = new Size(0, 25);
            lbl_matricula.TabIndex = 13;
            lbl_matricula.Click += lbl_matricula_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(554, 187);
            lbl_nombre.Margin = new Padding(4, 0, 4, 0);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(0, 25);
            lbl_nombre.TabIndex = 14;
            lbl_nombre.Click += lbl_nombre_Click;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(554, 273);
            lbl_apellido.Margin = new Padding(4, 0, 4, 0);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(0, 25);
            lbl_apellido.TabIndex = 15;
            lbl_apellido.Click += lbl_apellido_Click;
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Location = new Point(554, 378);
            lbl_edad.Margin = new Padding(4, 0, 4, 0);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(0, 25);
            lbl_edad.TabIndex = 16;
            lbl_edad.Click += lbl_edad_Click;
            // 
            // lbl_carrera
            // 
            lbl_carrera.AutoSize = true;
            lbl_carrera.Location = new Point(554, 467);
            lbl_carrera.Margin = new Padding(4, 0, 4, 0);
            lbl_carrera.Name = "lbl_carrera";
            lbl_carrera.Size = new Size(0, 25);
            lbl_carrera.TabIndex = 17;
            lbl_carrera.Click += lbl_carrera_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(921, 579);
            Controls.Add(lbl_carrera);
            Controls.Add(lbl_edad);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_matricula);
            Controls.Add(txt_cerrar);
            Controls.Add(txt_limpiar);
            Controls.Add(txt_pasar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_carrera);
            Controls.Add(txt_edad);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(txt_matricula);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Registro Alumnos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_matricula;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_edad;
        private TextBox txt_carrera;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button txt_pasar;
        private Button txt_limpiar;
        private Button txt_cerrar;
        private Label lbl_matricula;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_edad;
        private Label lbl_carrera;
    }
}