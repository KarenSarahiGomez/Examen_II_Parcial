namespace Examen_II_LP3_KSGG
{
    partial class BuscarclienteForm
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
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.ClientedataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(133, 46);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(380, 20);
            this.NombretextBox.TabIndex = 0;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Location = new System.Drawing.Point(323, 89);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(86, 41);
            this.Aceptarbutton.TabIndex = 2;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(427, 89);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(86, 41);
            this.Cancelarbutton.TabIndex = 3;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // ClientedataGridView
            // 
            this.ClientedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientedataGridView.Location = new System.Drawing.Point(0, 145);
            this.ClientedataGridView.Name = "ClientedataGridView";
            this.ClientedataGridView.Size = new System.Drawing.Size(567, 240);
            this.ClientedataGridView.TabIndex = 4;
            // 
            // BuscarclienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(568, 385);
            this.Controls.Add(this.ClientedataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombretextBox);
            this.Name = "BuscarclienteForm";
            this.Text = "BuscarclienteForm";
            this.Load += new System.EventHandler(this.BuscarclienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.DataGridView ClientedataGridView;
    }
}