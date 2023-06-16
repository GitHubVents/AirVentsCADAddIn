namespace ControlsLibrary
{
    partial class Search
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
            this.textBoxPathASM = new System.Windows.Forms.TextBox();
            this.buttonOpenASM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPathASM
            // 
            this.textBoxPathASM.BackColor = System.Drawing.Color.Azure;
            this.textBoxPathASM.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathASM.Location = new System.Drawing.Point(12, 25);
            this.textBoxPathASM.Multiline = true;
            this.textBoxPathASM.Name = "textBoxPathASM";
            this.textBoxPathASM.Size = new System.Drawing.Size(771, 62);
            this.textBoxPathASM.TabIndex = 0;
            // 
            // buttonOpenASM
            // 
            this.buttonOpenASM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOpenASM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOpenASM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenASM.Location = new System.Drawing.Point(304, 128);
            this.buttonOpenASM.Name = "buttonOpenASM";
            this.buttonOpenASM.Size = new System.Drawing.Size(130, 42);
            this.buttonOpenASM.TabIndex = 1;
            this.buttonOpenASM.Text = "Открыть";
            this.buttonOpenASM.UseVisualStyleBackColor = true;
            this.buttonOpenASM.Click += new System.EventHandler(this.buttonOpenASM_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(795, 206);
            this.Controls.Add(this.buttonOpenASM);
            this.Controls.Add(this.textBoxPathASM);
            this.MaximumSize = new System.Drawing.Size(811, 245);
            this.Name = "Search";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPathASM;
        private System.Windows.Forms.Button buttonOpenASM;
    }
}