namespace ControlsLibrary.Spigot
{
    partial class SpigotControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSpigotType = new System.Windows.Forms.ComboBox();
            this.txtBoxWidth = new System.Windows.Forms.TextBox();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.btnBuildSpigot = new System.Windows.Forms.Button();
            this.frameLenthLbl = new System.Windows.Forms.Label();
            this.frameWidthLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureSpigot = new System.Windows.Forms.PictureBox();
            this.labelForUserToWait = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpigot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вибровставка";
            // 
            // comboBoxSpigotType
            // 
            this.comboBoxSpigotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpigotType.FormattingEnabled = true;
            this.comboBoxSpigotType.Items.AddRange(new object[] {
            "20",
            "30"});
            this.comboBoxSpigotType.Location = new System.Drawing.Point(118, 57);
            this.comboBoxSpigotType.Name = "comboBoxSpigotType";
            this.comboBoxSpigotType.Size = new System.Drawing.Size(141, 21);
            this.comboBoxSpigotType.TabIndex = 1;
            this.comboBoxSpigotType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpigotType_SelectedIndexChanged);
            this.comboBoxSpigotType.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // txtBoxWidth
            // 
            this.txtBoxWidth.Location = new System.Drawing.Point(118, 84);
            this.txtBoxWidth.Name = "txtBoxWidth";
            this.txtBoxWidth.Size = new System.Drawing.Size(141, 20);
            this.txtBoxWidth.TabIndex = 2;
            this.txtBoxWidth.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.txtBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON_KeyPress);
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(118, 110);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(141, 20);
            this.txtBoxHeight.TabIndex = 3;
            this.txtBoxHeight.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.txtBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON_KeyPress);
            // 
            // btnBuildSpigot
            // 
            this.btnBuildSpigot.Location = new System.Drawing.Point(118, 152);
            this.btnBuildSpigot.Name = "btnBuildSpigot";
            this.btnBuildSpigot.Size = new System.Drawing.Size(141, 32);
            this.btnBuildSpigot.TabIndex = 4;
            this.btnBuildSpigot.Text = "Построить";
            this.btnBuildSpigot.UseVisualStyleBackColor = true;
            this.btnBuildSpigot.Click += new System.EventHandler(this.Build);
            // 
            // frameLenthLbl
            // 
            this.frameLenthLbl.AutoSize = true;
            this.frameLenthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameLenthLbl.Location = new System.Drawing.Point(19, 114);
            this.frameLenthLbl.Name = "frameLenthLbl";
            this.frameLenthLbl.Size = new System.Drawing.Size(83, 16);
            this.frameLenthLbl.TabIndex = 6;
            this.frameLenthLbl.Text = "Высота, мм:";
            // 
            // frameWidthLbl
            // 
            this.frameWidthLbl.AutoSize = true;
            this.frameWidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameWidthLbl.Location = new System.Drawing.Point(16, 88);
            this.frameWidthLbl.Name = "frameWidthLbl";
            this.frameWidthLbl.Size = new System.Drawing.Size(86, 16);
            this.frameWidthLbl.TabIndex = 5;
            this.frameWidthLbl.Text = "Ширина, мм:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип профиля:";
            // 
            // pictureSpigot
            // 
            this.pictureSpigot.Location = new System.Drawing.Point(56, 233);
            this.pictureSpigot.Name = "pictureSpigot";
            this.pictureSpigot.Size = new System.Drawing.Size(203, 172);
            this.pictureSpigot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSpigot.TabIndex = 19;
            this.pictureSpigot.TabStop = false;
            // 
            // labelForUserToWait
            // 
            this.labelForUserToWait.AutoSize = true;
            this.labelForUserToWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.labelForUserToWait.Location = new System.Drawing.Point(5, 158);
            this.labelForUserToWait.Name = "labelForUserToWait";
            this.labelForUserToWait.Size = new System.Drawing.Size(0, 18);
            this.labelForUserToWait.TabIndex = 20;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(118, 190);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(141, 32);
            this.button_Search.TabIndex = 21;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // SpigotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.labelForUserToWait);
            this.Controls.Add(this.pictureSpigot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frameLenthLbl);
            this.Controls.Add(this.frameWidthLbl);
            this.Controls.Add(this.btnBuildSpigot);
            this.Controls.Add(this.txtBoxHeight);
            this.Controls.Add(this.txtBoxWidth);
            this.Controls.Add(this.comboBoxSpigotType);
            this.Controls.Add(this.label1);
            this.Name = "SpigotControl";
            this.Size = new System.Drawing.Size(300, 471);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpigot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSpigotType;
        private System.Windows.Forms.TextBox txtBoxWidth;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.Button btnBuildSpigot;
        private System.Windows.Forms.Label frameLenthLbl;
        private System.Windows.Forms.Label frameWidthLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureSpigot;
        private System.Windows.Forms.Label labelForUserToWait;
        private System.Windows.Forms.Button button_Search;
    }
}
