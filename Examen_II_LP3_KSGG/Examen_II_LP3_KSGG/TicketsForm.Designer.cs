namespace Examen_II_LP3_KSGG
{
    partial class TicketsForm
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
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SubTotaltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TiposoportecomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DescripcionrespuestaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescripcionsolicitudTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.BuscarClienteButton = new System.Windows.Forms.Button();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(358, 450);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(104, 38);
            this.CancelarButton.TabIndex = 35;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(233, 450);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(104, 38);
            this.GuardarButton.TabIndex = 34;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(612, 482);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 21);
            this.TotalTextBox.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(499, 482);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Total a Pagar:";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(77, 479);
            this.DescuentoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.ReadOnly = true;
            this.DescuentoTextBox.Size = new System.Drawing.Size(100, 21);
            this.DescuentoTextBox.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 482);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Descuento:";
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Location = new System.Drawing.Point(612, 447);
            this.ISVTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.ReadOnly = true;
            this.ISVTextBox.Size = new System.Drawing.Size(100, 21);
            this.ISVTextBox.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 450);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "ISV:";
            // 
            // SubTotaltextBox
            // 
            this.SubTotaltextBox.Location = new System.Drawing.Point(77, 447);
            this.SubTotaltextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SubTotaltextBox.Name = "SubTotaltextBox";
            this.SubTotaltextBox.ReadOnly = true;
            this.SubTotaltextBox.Size = new System.Drawing.Size(100, 21);
            this.SubTotaltextBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 450);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sub Total:";
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(13, 310);
            this.DetalleDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(699, 119);
            this.DetalleDataGridView.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TiposoportecomboBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.PrecioTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.DescripcionrespuestaTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DescripcionsolicitudTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 173);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(699, 122);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Producto";
            // 
            // TiposoportecomboBox
            // 
            this.TiposoportecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TiposoportecomboBox.FormattingEnabled = true;
            this.TiposoportecomboBox.Items.AddRange(new object[] {
            "Equipo de Computo",
            "Celular"});
            this.TiposoportecomboBox.Location = new System.Drawing.Point(147, 33);
            this.TiposoportecomboBox.Name = "TiposoportecomboBox";
            this.TiposoportecomboBox.Size = new System.Drawing.Size(154, 23);
            this.TiposoportecomboBox.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tipo de Solicitud:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(537, 87);
            this.PrecioTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(82, 21);
            this.PrecioTextBox.TabIndex = 11;
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio:";
            // 
            // DescripcionrespuestaTextBox
            // 
            this.DescripcionrespuestaTextBox.Location = new System.Drawing.Point(147, 90);
            this.DescripcionrespuestaTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DescripcionrespuestaTextBox.Name = "DescripcionrespuestaTextBox";
            this.DescripcionrespuestaTextBox.Size = new System.Drawing.Size(229, 21);
            this.DescripcionrespuestaTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descripcion de Respuesta:";
            // 
            // DescripcionsolicitudTextBox
            // 
            this.DescripcionsolicitudTextBox.Location = new System.Drawing.Point(147, 63);
            this.DescripcionsolicitudTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DescripcionsolicitudTextBox.Name = "DescripcionsolicitudTextBox";
            this.DescripcionsolicitudTextBox.Size = new System.Drawing.Size(229, 21);
            this.DescripcionsolicitudTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descripcion de Solicitud:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreClienteTextBox);
            this.groupBox2.Controls.Add(this.BuscarClienteButton);
            this.groupBox2.Controls.Add(this.IdentidadTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(699, 77);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(430, 38);
            this.NombreClienteTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.ReadOnly = true;
            this.NombreClienteTextBox.Size = new System.Drawing.Size(257, 21);
            this.NombreClienteTextBox.TabIndex = 6;
            // 
            // BuscarClienteButton
            // 
            this.BuscarClienteButton.Location = new System.Drawing.Point(355, 38);
            this.BuscarClienteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuscarClienteButton.Name = "BuscarClienteButton";
            this.BuscarClienteButton.Size = new System.Drawing.Size(58, 27);
            this.BuscarClienteButton.TabIndex = 5;
            this.BuscarClienteButton.Text = ".....";
            this.BuscarClienteButton.UseVisualStyleBackColor = true;
            this.BuscarClienteButton.Click += new System.EventHandler(this.BuscarClienteButton_Click);
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Location = new System.Drawing.Point(118, 38);
            this.IdentidadTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(229, 21);
            this.IdentidadTextBox.TabIndex = 4;
            this.IdentidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Identidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsuarioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(687, 59);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(489, 25);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(130, 21);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(118, 25);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(229, 21);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tickets";
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(723, 509);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ISVTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SubTotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TicketsForm";
            this.Text = "TicketsForm";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ISVTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SubTotaltextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DescripcionrespuestaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescripcionsolicitudTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.Button BuscarClienteButton;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TiposoportecomboBox;
        private System.Windows.Forms.Label label12;
    }
}