namespace ECF
{
    partial class frmTesteECF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteECF));
            this.btnReducaoZ = new System.Windows.Forms.Button();
            this.btnLeituraX = new System.Windows.Forms.Button();
            this.btnSuprimento = new System.Windows.Forms.Button();
            this.btnSangria = new System.Windows.Forms.Button();
            this.btnFecharCupom = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnAbrirCupom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReducaoZ
            // 
            this.btnReducaoZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReducaoZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReducaoZ.Location = new System.Drawing.Point(295, 219);
            this.btnReducaoZ.Name = "btnReducaoZ";
            this.btnReducaoZ.Size = new System.Drawing.Size(96, 38);
            this.btnReducaoZ.TabIndex = 1;
            this.btnReducaoZ.Text = "Redução Z";
            this.btnReducaoZ.UseVisualStyleBackColor = true;
            this.btnReducaoZ.Click += new System.EventHandler(this.btnReducaoZ_Click);
            // 
            // btnLeituraX
            // 
            this.btnLeituraX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeituraX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeituraX.Location = new System.Drawing.Point(12, 219);
            this.btnLeituraX.Name = "btnLeituraX";
            this.btnLeituraX.Size = new System.Drawing.Size(96, 38);
            this.btnLeituraX.TabIndex = 1;
            this.btnLeituraX.Text = "Leitura X";
            this.btnLeituraX.UseVisualStyleBackColor = true;
            this.btnLeituraX.Click += new System.EventHandler(this.btnLeituraX_Click);
            // 
            // btnSuprimento
            // 
            this.btnSuprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimento.Image = global::ECF.Properties.Resources.suprimento;
            this.btnSuprimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuprimento.Location = new System.Drawing.Point(225, 100);
            this.btnSuprimento.Name = "btnSuprimento";
            this.btnSuprimento.Size = new System.Drawing.Size(83, 47);
            this.btnSuprimento.TabIndex = 2;
            this.btnSuprimento.Text = "Suprimento";
            this.btnSuprimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuprimento.UseVisualStyleBackColor = true;
            this.btnSuprimento.Click += new System.EventHandler(this.btnSuprimento_Click);
            // 
            // btnSangria
            // 
            this.btnSangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSangria.Image = global::ECF.Properties.Resources.retirada;
            this.btnSangria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSangria.Location = new System.Drawing.Point(86, 100);
            this.btnSangria.Name = "btnSangria";
            this.btnSangria.Size = new System.Drawing.Size(83, 47);
            this.btnSangria.TabIndex = 2;
            this.btnSangria.Text = "Sangria";
            this.btnSangria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSangria.UseVisualStyleBackColor = true;
            this.btnSangria.Click += new System.EventHandler(this.btnSangria_Click);
            // 
            // btnFecharCupom
            // 
            this.btnFecharCupom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCupom.Image = global::ECF.Properties.Resources.file_complete_icon;
            this.btnFecharCupom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFecharCupom.Location = new System.Drawing.Point(286, 12);
            this.btnFecharCupom.Name = "btnFecharCupom";
            this.btnFecharCupom.Size = new System.Drawing.Size(105, 54);
            this.btnFecharCupom.TabIndex = 1;
            this.btnFecharCupom.Text = "Fechar Cupom";
            this.btnFecharCupom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFecharCupom.UseVisualStyleBackColor = true;
            this.btnFecharCupom.Click += new System.EventHandler(this.btnFecharCupom_Click);
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Image = global::ECF.Properties.Resources.shopping_basket_icon;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVender.Location = new System.Drawing.Point(149, 12);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(105, 54);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Vender";
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnAbrirCupom
            // 
            this.btnAbrirCupom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCupom.Image = global::ECF.Properties.Resources.Actions_go_next_icon;
            this.btnAbrirCupom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrirCupom.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirCupom.Name = "btnAbrirCupom";
            this.btnAbrirCupom.Size = new System.Drawing.Size(105, 54);
            this.btnAbrirCupom.TabIndex = 0;
            this.btnAbrirCupom.Text = "Abrir Cupom";
            this.btnAbrirCupom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirCupom.UseVisualStyleBackColor = true;
            this.btnAbrirCupom.Click += new System.EventHandler(this.btnAbrirCupom_Click);
            // 
            // frmTesteECF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 269);
            this.Controls.Add(this.btnSuprimento);
            this.Controls.Add(this.btnSangria);
            this.Controls.Add(this.btnReducaoZ);
            this.Controls.Add(this.btnLeituraX);
            this.Controls.Add(this.btnFecharCupom);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnAbrirCupom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTesteECF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste ECF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirCupom;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnFecharCupom;
        private System.Windows.Forms.Button btnLeituraX;
        private System.Windows.Forms.Button btnReducaoZ;
        private System.Windows.Forms.Button btnSangria;
        private System.Windows.Forms.Button btnSuprimento;
    }
}

