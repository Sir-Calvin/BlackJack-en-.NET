namespace BJ_Cliente
{
    partial class Form1
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
			this.btnOtra = new System.Windows.Forms.Button();
			this.btnPlantarse = new System.Windows.Forms.Button();
			this.timerListen = new System.Windows.Forms.Timer(this.components);
			this.txtCartaRecibida = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblPuntos = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOtra
			// 
			this.btnOtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOtra.Location = new System.Drawing.Point(222, 343);
			this.btnOtra.Margin = new System.Windows.Forms.Padding(2);
			this.btnOtra.Name = "btnOtra";
			this.btnOtra.Size = new System.Drawing.Size(130, 58);
			this.btnOtra.TabIndex = 0;
			this.btnOtra.Text = "Pedir Otra";
			this.btnOtra.UseVisualStyleBackColor = true;
			this.btnOtra.Click += new System.EventHandler(this.btnOtra_Click);
			// 
			// btnPlantarse
			// 
			this.btnPlantarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlantarse.Location = new System.Drawing.Point(380, 343);
			this.btnPlantarse.Margin = new System.Windows.Forms.Padding(2);
			this.btnPlantarse.Name = "btnPlantarse";
			this.btnPlantarse.Size = new System.Drawing.Size(130, 58);
			this.btnPlantarse.TabIndex = 1;
			this.btnPlantarse.Text = "Plantarse";
			this.btnPlantarse.UseVisualStyleBackColor = true;
			this.btnPlantarse.Click += new System.EventHandler(this.btnPlantarse_Click);
			// 
			// timerListen
			// 
			this.timerListen.Interval = 1000;
			this.timerListen.Tick += new System.EventHandler(this.timerListen_Tick);
			// 
			// txtCartaRecibida
			// 
			this.txtCartaRecibida.Location = new System.Drawing.Point(222, 319);
			this.txtCartaRecibida.Margin = new System.Windows.Forms.Padding(2);
			this.txtCartaRecibida.Name = "txtCartaRecibida";
			this.txtCartaRecibida.Size = new System.Drawing.Size(290, 20);
			this.txtCartaRecibida.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(219, 303);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Carta recibida";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(84, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Puntos:";
			// 
			// lblPuntos
			// 
			this.lblPuntos.AutoSize = true;
			this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPuntos.Location = new System.Drawing.Point(153, 23);
			this.lblPuntos.Name = "lblPuntos";
			this.lblPuntos.Size = new System.Drawing.Size(18, 20);
			this.lblPuntos.TabIndex = 5;
			this.lblPuntos.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 412);
			this.Controls.Add(this.lblPuntos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCartaRecibida);
			this.Controls.Add(this.btnPlantarse);
			this.Controls.Add(this.btnOtra);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtra;
        private System.Windows.Forms.Button btnPlantarse;
        private System.Windows.Forms.Timer timerListen;
        private System.Windows.Forms.TextBox txtCartaRecibida;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblPuntos;
	}
}

