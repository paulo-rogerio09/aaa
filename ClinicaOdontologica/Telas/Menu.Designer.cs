namespace ClinicaOdontologica.Telas
{
    partial class Menu
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
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_agendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(12, 146);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(120, 29);
            this.bt_cadastrar.TabIndex = 0;
            this.bt_cadastrar.Text = "Cadastro de Cliente";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // bt_agendar
            // 
            this.bt_agendar.Location = new System.Drawing.Point(165, 146);
            this.bt_agendar.Name = "bt_agendar";
            this.bt_agendar.Size = new System.Drawing.Size(104, 29);
            this.bt_agendar.TabIndex = 1;
            this.bt_agendar.Text = "Agendamento";
            this.bt_agendar.UseVisualStyleBackColor = true;
            this.bt_agendar.Click += new System.EventHandler(this.bt_agendar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sorrilândia: Terra do Sorriso";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaOdontologica.Properties.Resources.menu;
            this.ClientSize = new System.Drawing.Size(300, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_agendar);
            this.Controls.Add(this.bt_cadastrar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_agendar;
        private System.Windows.Forms.Label label1;
    }
}