namespace WinFormsProgramacion2
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
            this.btn_progreso = new System.Windows.Forms.Button();
            this.pb_progreso = new System.Windows.Forms.ProgressBar();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_progreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_progreso
            // 
            this.btn_progreso.Location = new System.Drawing.Point(50, 12);
            this.btn_progreso.Name = "btn_progreso";
            this.btn_progreso.Size = new System.Drawing.Size(133, 43);
            this.btn_progreso.TabIndex = 3;
            this.btn_progreso.Text = "Progreso";
            this.btn_progreso.UseVisualStyleBackColor = true;
            this.btn_progreso.Click += new System.EventHandler(this.btn_progreso_Click);
            // 
            // pb_progreso
            // 
            this.pb_progreso.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pb_progreso.Location = new System.Drawing.Point(50, 80);
            this.pb_progreso.Name = "pb_progreso";
            this.pb_progreso.Size = new System.Drawing.Size(695, 23);
            this.pb_progreso.TabIndex = 4;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(189, 12);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(94, 43);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_salir.Location = new System.Drawing.Point(317, 177);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(129, 44);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir Sistema";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_progreso
            // 
            this.lbl_progreso.AutoSize = true;
            this.lbl_progreso.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_progreso.Location = new System.Drawing.Point(361, 106);
            this.lbl_progreso.Name = "lbl_progreso";
            this.lbl_progreso.Size = new System.Drawing.Size(43, 30);
            this.lbl_progreso.TabIndex = 7;
            this.lbl_progreso.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.lbl_progreso);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.pb_progreso);
            this.Controls.Add(this.btn_progreso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_progreso;
        private ProgressBar pb_progreso;
        private Button btn_limpiar;
        private Button btn_salir;
        private Label lbl_progreso;
    }
}