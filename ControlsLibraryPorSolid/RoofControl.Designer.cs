namespace ControlsLibrary.Roof
{
    partial class RoofControl
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.frameLenthLbl = new System.Windows.Forms.Label();
            this.frameWidthLbl = new System.Windows.Forms.Label();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.txtBoxWidth = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureRoof = new System.Windows.Forms.PictureBox();
            this.labelForUserToWait = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxCoatType = new System.Windows.Forms.ComboBox();
            this.comboBoxCoatClass = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoof)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(69, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 7;
            this.button1.Tag = "";
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frameLenthLbl
            // 
            this.frameLenthLbl.AutoSize = true;
            this.frameLenthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameLenthLbl.Location = new System.Drawing.Point(22, 144);
            this.frameLenthLbl.Name = "frameLenthLbl";
            this.frameLenthLbl.Size = new System.Drawing.Size(83, 16);
            this.frameLenthLbl.TabIndex = 26;
            this.frameLenthLbl.Text = "Высота, мм:";
            // 
            // frameWidthLbl
            // 
            this.frameWidthLbl.AutoSize = true;
            this.frameWidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameWidthLbl.Location = new System.Drawing.Point(19, 113);
            this.frameWidthLbl.Name = "frameWidthLbl";
            this.frameWidthLbl.Size = new System.Drawing.Size(86, 16);
            this.frameWidthLbl.TabIndex = 25;
            this.frameWidthLbl.Text = "Ширина, мм:";
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(121, 141);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(144, 20);
            this.txtBoxHeight.TabIndex = 3;
            this.txtBoxHeight.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.txtBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON_KeyPress);
            // 
            // txtBoxWidth
            // 
            this.txtBoxWidth.Location = new System.Drawing.Point(121, 110);
            this.txtBoxWidth.Name = "txtBoxWidth";
            this.txtBoxWidth.Size = new System.Drawing.Size(144, 20);
            this.txtBoxWidth.TabIndex = 2;
            this.txtBoxWidth.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.txtBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON_KeyPress);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxType.Location = new System.Drawing.Point(122, 46);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(142, 21);
            this.comboBoxType.TabIndex = 0;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxType.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Крыша";
            // 
            // pictureRoof
            // 
            this.pictureRoof.Location = new System.Drawing.Point(8, 399);
            this.pictureRoof.Name = "pictureRoof";
            this.pictureRoof.Size = new System.Drawing.Size(257, 172);
            this.pictureRoof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRoof.TabIndex = 20;
            this.pictureRoof.TabStop = false;
            // 
            // labelForUserToWait
            // 
            this.labelForUserToWait.AutoSize = true;
            this.labelForUserToWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForUserToWait.Location = new System.Drawing.Point(5, 366);
            this.labelForUserToWait.Name = "labelForUserToWait";
            this.labelForUserToWait.Size = new System.Drawing.Size(0, 18);
            this.labelForUserToWait.TabIndex = 29;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.Location = new System.Drawing.Point(122, 78);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(142, 21);
            this.comboBoxMaterial.TabIndex = 1;
            this.comboBoxMaterial.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(28, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Материал:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(62, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Цвет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Тип покрытия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(57, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Класс:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.Location = new System.Drawing.Point(122, 172);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(142, 21);
            this.comboBoxColor.TabIndex = 4;
            this.comboBoxColor.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // comboBoxCoatType
            // 
            this.comboBoxCoatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoatType.Location = new System.Drawing.Point(123, 204);
            this.comboBoxCoatType.Name = "comboBoxCoatType";
            this.comboBoxCoatType.Size = new System.Drawing.Size(142, 21);
            this.comboBoxCoatType.TabIndex = 5;
            this.comboBoxCoatType.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // comboBoxCoatClass
            // 
            this.comboBoxCoatClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoatClass.Location = new System.Drawing.Point(123, 236);
            this.comboBoxCoatClass.Name = "comboBoxCoatClass";
            this.comboBoxCoatClass.Size = new System.Drawing.Size(142, 21);
            this.comboBoxCoatClass.TabIndex = 6;
            this.comboBoxCoatClass.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(154, 313);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(110, 32);
            this.button_Search.TabIndex = 38;
            this.button_Search.Tag = "";
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // RoofControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.comboBoxCoatClass);
            this.Controls.Add(this.comboBoxCoatType);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelForUserToWait);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.frameLenthLbl);
            this.Controls.Add(this.frameWidthLbl);
            this.Controls.Add(this.txtBoxHeight);
            this.Controls.Add(this.txtBoxWidth);
            this.Controls.Add(this.pictureRoof);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "RoofControl";
            this.Size = new System.Drawing.Size(280, 631);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureRoof;
        private System.Windows.Forms.Label frameLenthLbl;
        private System.Windows.Forms.Label frameWidthLbl;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.TextBox txtBoxWidth;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelForUserToWait;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxCoatType;
        private System.Windows.Forms.ComboBox comboBoxCoatClass;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_Search;
    }
}
