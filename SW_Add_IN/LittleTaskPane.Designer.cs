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
            this.buildSpigot = new System.Windows.Forms.Button();
            this.buildRoofBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // buildSpigot
            // 
            this.buildSpigot.BackColor = System.Drawing.Color.White;
            this.buildSpigot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildSpigot.Location = new System.Drawing.Point(3, 89);
            this.buildSpigot.Name = "buildSpigot";
            this.buildSpigot.Size = new System.Drawing.Size(171, 31);
            this.buildSpigot.TabIndex = 3;
            this.buildSpigot.Text = "Вибровставка";
            this.buildSpigot.UseVisualStyleBackColor = false;
            this.buildSpigot.Click += new System.EventHandler(this.buildSpigot_Click);
            // 
            // buildRoofBtn
            // 
            this.buildRoofBtn.BackColor = System.Drawing.Color.White;
            this.buildRoofBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildRoofBtn.Location = new System.Drawing.Point(3, 52);
            this.buildRoofBtn.Name = "buildRoofBtn";
            this.buildRoofBtn.Size = new System.Drawing.Size(171, 31);
            this.buildRoofBtn.TabIndex = 4;
            this.buildRoofBtn.Text = "Крыша";
            this.buildRoofBtn.UseVisualStyleBackColor = false;
            this.buildRoofBtn.Click += new System.EventHandler(this.buildRoofBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Заслонка";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buildFlapBtn_Click);
            // 
            // LittleTaskPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(187)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buildRoofBtn);
            this.Controls.Add(this.buildSpigot);
            this.Controls.Add(this.buildMountage);
            this.Name = "LittleTaskPane";
            this.Size = new System.Drawing.Size(180, 306);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buildMountage;
        private System.Windows.Forms.Button buildSpigot;
        private System.Windows.Forms.Button buildRoofBtn;
        private System.Windows.Forms.Button button1;
    }
}
