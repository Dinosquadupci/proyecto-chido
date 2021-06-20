
namespace proyecto_chido
{
    partial class Lista_con_pacientes
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Nombre", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_con_pacientes));
            this.listpatient = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NSS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BLOOD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sintomas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Enfermedad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Escala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAct = new System.Windows.Forms.Button();
            this.Delatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listpatient
            // 
            this.listpatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.NSS,
            this.BLOOD,
            this.Sintomas,
            this.Enfermedad,
            this.Escala});
            listViewGroup1.Header = "Nombre";
            listViewGroup1.Name = "listViewGroup1";
            this.listpatient.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listpatient.HideSelection = false;
            this.listpatient.Location = new System.Drawing.Point(12, 83);
            this.listpatient.Name = "listpatient";
            this.listpatient.Size = new System.Drawing.Size(991, 374);
            this.listpatient.TabIndex = 1;
            this.listpatient.UseCompatibleStateImageBehavior = false;
            this.listpatient.View = System.Windows.Forms.View.Details;
            this.listpatient.SelectedIndexChanged += new System.EventHandler(this.listpatient_SelectedIndexChanged);
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 139;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido ";
            this.Apellido.Width = 147;
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            // 
            // NSS
            // 
            this.NSS.Text = "NSS";
            // 
            // BLOOD
            // 
            this.BLOOD.Text = "Tipo de sangre";
            this.BLOOD.Width = 88;
            // 
            // Sintomas
            // 
            this.Sintomas.Text = "Sintomas";
            this.Sintomas.Width = 324;
            // 
            // Enfermedad
            // 
            this.Enfermedad.Text = "Enfermedad crónica";
            this.Enfermedad.Width = 109;
            // 
            // Escala
            // 
            this.Escala.Text = "Triaje";
            this.Escala.Width = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacientes en la sala de Urgencias";
            // 
            // BtnAct
            // 
            this.BtnAct.Location = new System.Drawing.Point(489, 36);
            this.BtnAct.Name = "BtnAct";
            this.BtnAct.Size = new System.Drawing.Size(235, 41);
            this.BtnAct.TabIndex = 2;
            this.BtnAct.Text = "Actualizar Pacientes";
            this.BtnAct.UseVisualStyleBackColor = true;
            this.BtnAct.Click += new System.EventHandler(this.BtnAct_Click);
            // 
            // Delatebtn
            // 
            this.Delatebtn.Location = new System.Drawing.Point(759, 36);
            this.Delatebtn.Name = "Delatebtn";
            this.Delatebtn.Size = new System.Drawing.Size(231, 41);
            this.Delatebtn.TabIndex = 3;
            this.Delatebtn.Text = "Eliminar";
            this.Delatebtn.UseVisualStyleBackColor = true;
            this.Delatebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lista_con_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 469);
            this.Controls.Add(this.Delatebtn);
            this.Controls.Add(this.BtnAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listpatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lista_con_pacientes";
            this.Text = "Lista_con_pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listpatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Edad;
        private System.Windows.Forms.ColumnHeader NSS;
        private System.Windows.Forms.ColumnHeader BLOOD;
        private System.Windows.Forms.ColumnHeader Sintomas;
        private System.Windows.Forms.ColumnHeader Enfermedad;
        private System.Windows.Forms.ColumnHeader Escala;
        private System.Windows.Forms.Button BtnAct;
        private System.Windows.Forms.Button Delatebtn;
    }
}