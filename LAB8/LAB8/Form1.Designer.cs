namespace LAB8
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.addMenuCT1 = new LAB8.AddMenuCT();
            this.mainMenuCT1 = new LAB8.MainMenuCT();
            this.customAddCT1 = new LAB8.CustomAddCT();
            this.SuspendLayout();
            // 
            // addMenuCT1
            // 
            this.addMenuCT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMenuCT1.Location = new System.Drawing.Point(0, 0);
            this.addMenuCT1.Name = "addMenuCT1";
            this.addMenuCT1.Size = new System.Drawing.Size(774, 388);
            this.addMenuCT1.TabIndex = 1;
            // 
            // mainMenuCT1
            // 
            this.mainMenuCT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuCT1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuCT1.Name = "mainMenuCT1";
            this.mainMenuCT1.Size = new System.Drawing.Size(774, 388);
            this.mainMenuCT1.TabIndex = 0;
            // 
            // customAddCT1
            // 
            this.customAddCT1.Location = new System.Drawing.Point(0, 0);
            this.customAddCT1.Name = "customAddCT1";
            this.customAddCT1.Size = new System.Drawing.Size(774, 388);
            this.customAddCT1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 388);
            this.Controls.Add(this.customAddCT1);
            this.Controls.Add(this.addMenuCT1);
            this.Controls.Add(this.mainMenuCT1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MainMenuCT mainMenuCT1;
        private AddMenuCT addMenuCT1;
        private CustomAddCT customAddCT1;
    }
}

