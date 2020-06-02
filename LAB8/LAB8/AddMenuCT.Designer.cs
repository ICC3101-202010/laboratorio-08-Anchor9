namespace LAB8
{
    partial class AddMenuCT
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnCinema = new System.Windows.Forms.Button();
            this.btnRestaurant = new System.Windows.Forms.Button();
            this.btnRecreational = new System.Windows.Forms.Button();
            this.labelPowered = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LAB8.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStore.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnStore.FlatAppearance.BorderSize = 2;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Location = new System.Drawing.Point(282, 113);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(179, 33);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnCinema
            // 
            this.btnCinema.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCinema.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnCinema.FlatAppearance.BorderSize = 2;
            this.btnCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCinema.Location = new System.Drawing.Point(282, 172);
            this.btnCinema.Name = "btnCinema";
            this.btnCinema.Size = new System.Drawing.Size(179, 33);
            this.btnCinema.TabIndex = 2;
            this.btnCinema.Text = "Cinema";
            this.btnCinema.UseVisualStyleBackColor = false;
            this.btnCinema.Click += new System.EventHandler(this.btnCinema_Click);
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestaurant.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnRestaurant.FlatAppearance.BorderSize = 2;
            this.btnRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurant.Location = new System.Drawing.Point(282, 231);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.Size = new System.Drawing.Size(179, 33);
            this.btnRestaurant.TabIndex = 3;
            this.btnRestaurant.Text = "Restaurant";
            this.btnRestaurant.UseVisualStyleBackColor = false;
            this.btnRestaurant.Click += new System.EventHandler(this.btnRestaurant_Click);
            // 
            // btnRecreational
            // 
            this.btnRecreational.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecreational.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnRecreational.FlatAppearance.BorderSize = 2;
            this.btnRecreational.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecreational.Location = new System.Drawing.Point(282, 290);
            this.btnRecreational.Name = "btnRecreational";
            this.btnRecreational.Size = new System.Drawing.Size(179, 33);
            this.btnRecreational.TabIndex = 4;
            this.btnRecreational.Text = "Recrational";
            this.btnRecreational.UseVisualStyleBackColor = false;
            this.btnRecreational.Click += new System.EventHandler(this.btnRecreational_Click);
            // 
            // labelPowered
            // 
            this.labelPowered.AutoSize = true;
            this.labelPowered.BackColor = System.Drawing.Color.Transparent;
            this.labelPowered.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPowered.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPowered.Location = new System.Drawing.Point(691, 366);
            this.labelPowered.Name = "labelPowered";
            this.labelPowered.Size = new System.Drawing.Size(80, 13);
            this.labelPowered.TabIndex = 11;
            this.labelPowered.Text = "A n c h o r . c o";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(263, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(218, 48);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Shopnizer";
            // 
            // AddMenuCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelPowered);
            this.Controls.Add(this.btnRecreational);
            this.Controls.Add(this.btnRestaurant);
            this.Controls.Add(this.btnCinema);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddMenuCT";
            this.Size = new System.Drawing.Size(774, 388);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnCinema;
        private System.Windows.Forms.Button btnRestaurant;
        private System.Windows.Forms.Button btnRecreational;
        private System.Windows.Forms.Label labelPowered;
        private System.Windows.Forms.Label labelTitle;
    }
}
