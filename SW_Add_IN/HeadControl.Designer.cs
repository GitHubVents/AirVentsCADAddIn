namespace SW_Add_IN
{
    partial class HeadControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.buildRoofBtn = new System.Windows.Forms.Button();
            this.buildSpigot = new System.Windows.Forms.Button();
            this.buildMountage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(3, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Заслонка";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buildFlapBtn_Click);
            // 
            // buildRoofBtn
            // 
            this.buildRoofBtn.BackColor = System.Drawing.Color.White;
            this.buildRoofBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildRoofBtn.Location = new System.Drawing.Point(3, 55);
            this.buildRoofBtn.Name = "buildRoofBtn";
            this.buildRoofBtn.Size = new System.Drawing.Size(274, 30);
            this.buildRoofBtn.TabIndex = 9;
            this.buildRoofBtn.Text = "Крыша";
            this.buildRoofBtn.UseVisualStyleBackColor = false;
            this.buildRoofBtn.Click += new System.EventHandler(this.buildRoofBtn_Click);
            // 
            // buildSpigot
            // 
            this.buildSpigot.BackColor = System.Drawing.Color.White;
            this.buildSpigot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildSpigot.Location = new System.Drawing.Point(3, 92);
            this.buildSpigot.Name = "buildSpigot";
            this.buildSpigot.Size = new System.Drawing.Size(274, 30);
            this.buildSpigot.TabIndex = 8;
            this.buildSpigot.Text = "Вибровставка";
            this.buildSpigot.UseVisualStyleBackColor = false;
            this.buildSpigot.Click += new System.EventHandler(this.buildSpigot_Click);
            // 
            // buildMountage
            // 
            this.buildMountage.BackColor = System.Drawing.Color.White;
            this.buildMountage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildMountage.Location = new System.Drawing.Point(3, 18);
            this.buildMountage.Name = "buildMountage";
            this.buildMountage.Size = new System.Drawing.Size(274, 30);
            this.buildMountage.TabIndex = 7;
            this.buildMountage.Text = "Рама монтажная";
            this.buildMountage.UseVisualStyleBackColor = false;
            this.buildMountage.Click += new System.EventHandler(this.buildMountage_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(0, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Панели";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.White;
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainMenu.Location = new System.Drawing.Point(0, 220);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(274, 30);
            this.MainMenu.TabIndex = 12;
            this.MainMenu.Text = "Главное меню";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // HeadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buildRoofBtn);
            this.Controls.Add(this.buildSpigot);
            this.Controls.Add(this.buildMountage);
            this.Name = "HeadControl";
            this.Size = new System.Drawing.Size(283, 262);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buildRoofBtn;
        private System.Windows.Forms.Button buildSpigot;
        private System.Windows.Forms.Button buildMountage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MainMenu;
    }
}
