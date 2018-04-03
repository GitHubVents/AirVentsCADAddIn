namespace SW_Add_IN
{
    partial class LittleTaskPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buildMountage = new System.Windows.Forms.Button();
            this.buildRoof = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildMountage
            // 
            this.buildMountage.BackColor = System.Drawing.Color.White;
            this.buildMountage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildMountage.Location = new System.Drawing.Point(3, 15);
            this.buildMountage.Name = "buildMountage";
            this.buildMountage.Size = new System.Drawing.Size(171, 31);
            this.buildMountage.TabIndex = 2;
            this.buildMountage.Text = "Рама монтажная";
            this.buildMountage.UseVisualStyleBackColor = false;
            this.buildMountage.Click += new System.EventHandler(this.buildMountage_Click);
            // 
            // buildRoof
            // 
            this.buildRoof.BackColor = System.Drawing.Color.White;
            this.buildRoof.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildRoof.Location = new System.Drawing.Point(3, 52);
            this.buildRoof.Name = "buildRoof";
            this.buildRoof.Size = new System.Drawing.Size(171, 31);
            this.buildRoof.TabIndex = 3;
            this.buildRoof.Text = "Крыша";
            this.buildRoof.UseVisualStyleBackColor = false;
            // 
            // LittleTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(187)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.buildRoof);
            this.Controls.Add(this.buildMountage);
            this.Name = "LittleTaskPane";
            this.Size = new System.Drawing.Size(180, 306);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buildMountage;
        private System.Windows.Forms.Button buildRoof;
    }
}
