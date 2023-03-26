namespace Examen_II_LP3_KSGG
{
    partial class ClienteForm
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
            this.components = new System.ComponentModel.Container();
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EstaActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.FNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DireccionCTextBox = new System.Windows.Forms.TextBox();
            this.CorreoClienteTextBox = new System.Windows.Forms.TextBox();
            this.NTelefonoTextBox = new System.Windows.Forms.TextBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDataGridView.Location = new System.Drawing.Point(87, 286);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.Size = new System.Drawing.Size(719, 174);
            this.ClientesDataGridView.TabIndex = 39;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(708, 243);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(98, 27);
            this.CancelarButton.TabIndex = 38;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(562, 243);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(98, 27);
            this.EliminarButton.TabIndex = 37;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Location = new System.Drawing.Point(404, 243);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(98, 27);
            this.GuardarButton.TabIndex = 36;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(240, 243);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(98, 27);
            this.ModificarButton.TabIndex = 35;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(93, 243);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(98, 27);
            this.NuevoButton.TabIndex = 34;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // EstaActivoCheckBox
            // 
            this.EstaActivoCheckBox.AutoSize = true;
            this.EstaActivoCheckBox.Enabled = false;
            this.EstaActivoCheckBox.Location = new System.Drawing.Point(240, 204);
            this.EstaActivoCheckBox.Name = "EstaActivoCheckBox";
            this.EstaActivoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivoCheckBox.TabIndex = 33;
            this.EstaActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // FNacimientoDateTimePicker
            // 
            this.FNacimientoDateTimePicker.Enabled = false;
            this.FNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FNacimientoDateTimePicker.Location = new System.Drawing.Point(240, 158);
            this.FNacimientoDateTimePicker.Name = "FNacimientoDateTimePicker";
            this.FNacimientoDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.FNacimientoDateTimePicker.TabIndex = 32;
            // 
            // DireccionCTextBox
            // 
            this.DireccionCTextBox.Enabled = false;
            this.DireccionCTextBox.Location = new System.Drawing.Point(240, 113);
            this.DireccionCTextBox.Name = "DireccionCTextBox";
            this.DireccionCTextBox.Size = new System.Drawing.Size(201, 22);
            this.DireccionCTextBox.TabIndex = 31;
            // 
            // CorreoClienteTextBox
            // 
            this.CorreoClienteTextBox.Enabled = false;
            this.CorreoClienteTextBox.Location = new System.Drawing.Point(605, 72);
            this.CorreoClienteTextBox.Name = "CorreoClienteTextBox";
            this.CorreoClienteTextBox.Size = new System.Drawing.Size(201, 22);
            this.CorreoClienteTextBox.TabIndex = 30;
            // 
            // NTelefonoTextBox
            // 
            this.NTelefonoTextBox.Enabled = false;
            this.NTelefonoTextBox.Location = new System.Drawing.Point(240, 72);
            this.NTelefonoTextBox.Name = "NTelefonoTextBox";
            this.NTelefonoTextBox.Size = new System.Drawing.Size(201, 22);
            this.NTelefonoTextBox.TabIndex = 29;
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Enabled = false;
            this.NombreClienteTextBox.Location = new System.Drawing.Point(605, 29);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(201, 22);
            this.NombreClienteTextBox.TabIndex = 28;
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Enabled = false;
            this.IdentidadTextBox.Location = new System.Drawing.Point(240, 29);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(201, 22);
            this.IdentidadTextBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Dirección;";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Esta Activo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "No. de Identidad:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(893, 489);
            this.Controls.Add(this.ClientesDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EstaActivoCheckBox);
            this.Controls.Add(this.FNacimientoDateTimePicker);
            this.Controls.Add(this.DireccionCTextBox);
            this.Controls.Add(this.CorreoClienteTextBox);
            this.Controls.Add(this.NTelefonoTextBox);
            this.Controls.Add(this.NombreClienteTextBox);
            this.Controls.Add(this.IdentidadTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientesDataGridView;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.CheckBox EstaActivoCheckBox;
        private System.Windows.Forms.DateTimePicker FNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox DireccionCTextBox;
        private System.Windows.Forms.TextBox CorreoClienteTextBox;
        private System.Windows.Forms.TextBox NTelefonoTextBox;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}