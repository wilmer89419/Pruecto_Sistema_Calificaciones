namespace Sol_SistemaCalificaciones.Presentacion
{
    partial class FRM_Asignaturas
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
            this.Tbp_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgv_principal = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Retomar_Asg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Guardar_Asg = new System.Windows.Forms.Button();
            this.Btn_Cancelar_Asg = new System.Windows.Forms.Button();
            this.Txt_Asignatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Tbp_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbp_principal
            // 
            this.Tbp_principal.Controls.Add(this.tabPage1);
            this.Tbp_principal.Controls.Add(this.tabPage2);
            this.Tbp_principal.Location = new System.Drawing.Point(16, 26);
            this.Tbp_principal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbp_principal.Name = "Tbp_principal";
            this.Tbp_principal.SelectedIndex = 0;
            this.Tbp_principal.Size = new System.Drawing.Size(1013, 410);
            this.Tbp_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgv_principal);
            this.tabPage1.Controls.Add(this.Btn_Buscar);
            this.tabPage1.Controls.Add(this.Txt_Buscar);
            this.tabPage1.Controls.Add(this.lbl_Buscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1005, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dgv_principal
            // 
            this.Dgv_principal.AllowUserToAddRows = false;
            this.Dgv_principal.AllowUserToDeleteRows = false;
            this.Dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_principal.Location = new System.Drawing.Point(39, 82);
            this.Dgv_principal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_principal.Name = "Dgv_principal";
            this.Dgv_principal.ReadOnly = true;
            this.Dgv_principal.RowHeadersWidth = 62;
            this.Dgv_principal.Size = new System.Drawing.Size(760, 254);
            this.Dgv_principal.TabIndex = 3;
            this.Dgv_principal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_principal_CellContentClick);
            this.Dgv_principal.DoubleClick += new System.EventHandler(this.Dgv_principal_DoubleClick);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Buscar.Location = new System.Drawing.Point(489, 25);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(144, 39);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(128, 34);
            this.Txt_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(352, 22);
            this.Txt_Buscar.TabIndex = 1;
            this.Txt_Buscar.TextChanged += new System.EventHandler(this.Txt_Buscar_TextChanged);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(35, 34);
            this.lbl_Buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(86, 23);
            this.lbl_Buscar.TabIndex = 0;
            this.lbl_Buscar.Text = "Buscar:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_Retomar_Asg);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Btn_Guardar_Asg);
            this.tabPage2.Controls.Add(this.Btn_Cancelar_Asg);
            this.tabPage2.Controls.Add(this.Txt_Asignatura);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1005, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_Retomar_Asg
            // 
            this.Btn_Retomar_Asg.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Retomar_Asg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Retomar_Asg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.Btn_Retomar_Asg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Retomar_Asg.Location = new System.Drawing.Point(445, 153);
            this.Btn_Retomar_Asg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Retomar_Asg.Name = "Btn_Retomar_Asg";
            this.Btn_Retomar_Asg.Size = new System.Drawing.Size(144, 39);
            this.Btn_Retomar_Asg.TabIndex = 5;
            this.Btn_Retomar_Asg.Text = "Retomar";
            this.Btn_Retomar_Asg.UseVisualStyleBackColor = false;
            this.Btn_Retomar_Asg.Click += new System.EventHandler(this.Btn_Retomar_Asg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(163, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "(*)";
            // 
            // Btn_Guardar_Asg
            // 
            this.Btn_Guardar_Asg.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Guardar_Asg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar_Asg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.Btn_Guardar_Asg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Guardar_Asg.Location = new System.Drawing.Point(259, 153);
            this.Btn_Guardar_Asg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Guardar_Asg.Name = "Btn_Guardar_Asg";
            this.Btn_Guardar_Asg.Size = new System.Drawing.Size(144, 39);
            this.Btn_Guardar_Asg.TabIndex = 3;
            this.Btn_Guardar_Asg.Text = "Guardar";
            this.Btn_Guardar_Asg.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Asg.Click += new System.EventHandler(this.Btn_Guardar_Asg_Click);
            // 
            // Btn_Cancelar_Asg
            // 
            this.Btn_Cancelar_Asg.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Cancelar_Asg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar_Asg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar_Asg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Cancelar_Asg.Location = new System.Drawing.Point(71, 153);
            this.Btn_Cancelar_Asg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Cancelar_Asg.Name = "Btn_Cancelar_Asg";
            this.Btn_Cancelar_Asg.Size = new System.Drawing.Size(144, 39);
            this.Btn_Cancelar_Asg.TabIndex = 2;
            this.Btn_Cancelar_Asg.Text = "Cancelar";
            this.Btn_Cancelar_Asg.UseVisualStyleBackColor = false;
            this.Btn_Cancelar_Asg.Click += new System.EventHandler(this.Btn_Cancelar_Asg_Click);
            // 
            // Txt_Asignatura
            // 
            this.Txt_Asignatura.Location = new System.Drawing.Point(206, 48);
            this.Txt_Asignatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Asignatura.Name = "Txt_Asignatura";
            this.Txt_Asignatura.ReadOnly = true;
            this.Txt_Asignatura.Size = new System.Drawing.Size(356, 22);
            this.Txt_Asignatura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Asignatura:";
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Nuevo.Location = new System.Drawing.Point(76, 462);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(144, 39);
            this.Btn_Nuevo.TabIndex = 4;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Actualizar.Location = new System.Drawing.Point(263, 462);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(144, 39);
            this.Btn_Actualizar.TabIndex = 5;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Eliminar.Location = new System.Drawing.Point(450, 462);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(144, 39);
            this.Btn_Eliminar.TabIndex = 6;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Reporte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Reporte.Location = new System.Drawing.Point(632, 462);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(144, 39);
            this.Btn_Reporte.TabIndex = 7;
            this.Btn_Reporte.Text = "Reporte";
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Salir.Location = new System.Drawing.Point(939, 6);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(85, 39);
            this.Btn_Salir.TabIndex = 8;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // FRM_Asignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Tbp_principal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRM_Asignaturas";
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.FRM_Asignaturas_Load);
            this.Tbp_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbp_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Dgv_principal;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.TextBox Txt_Asignatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Guardar_Asg;
        private System.Windows.Forms.Button Btn_Cancelar_Asg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Retomar_Asg;
    }
}