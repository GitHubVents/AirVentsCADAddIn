using DataBaseDomian;
using System.Windows.Forms;

namespace ControlsLibrary.FlapBuilder
{
    partial class FlapBuilderControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frameNameLbl = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxFlapType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFlapMaterial = new System.Windows.Forms.ComboBox();
            this.pictureFrame = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelForUserToWait = new System.Windows.Forms.Label();
            this.comboBoxThickness = new System.Windows.Forms.ComboBox();
            this.labelThickness = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBoxCoatClass = new System.Windows.Forms.ComboBox();
            this.comboBoxCoatType = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(2, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(5, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Высота";
            // 
            // frameNameLbl
            // 
            this.frameNameLbl.AutoSize = true;
            this.frameNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameNameLbl.Location = new System.Drawing.Point(3, 0);
            this.frameNameLbl.Name = "frameNameLbl";
            this.frameNameLbl.Size = new System.Drawing.Size(107, 25);
            this.frameNameLbl.TabIndex = 5;
            this.frameNameLbl.Text = "Заслонка";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(85, 105);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(192, 20);
            this.textBoxWidth.TabIndex = 6;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(85, 140);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(192, 20);
            this.textBoxHeight.TabIndex = 7;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.checkBox1.Location = new System.Drawing.Point(85, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Наружная";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // comboBoxFlapType
            // 
            this.comboBoxFlapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlapType.FormattingEnabled = true;
            this.comboBoxFlapType.Location = new System.Drawing.Point(85, 65);
            this.comboBoxFlapType.Name = "comboBoxFlapType";
            this.comboBoxFlapType.Size = new System.Drawing.Size(192, 21);
            this.comboBoxFlapType.TabIndex = 9;
            this.comboBoxFlapType.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(5, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Материал";
            // 
            // comboBoxFlapMaterial
            // 
            this.comboBoxFlapMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlapMaterial.FormattingEnabled = true;
            this.comboBoxFlapMaterial.Location = new System.Drawing.Point(85, 179);
            this.comboBoxFlapMaterial.Name = "comboBoxFlapMaterial";
            this.comboBoxFlapMaterial.Size = new System.Drawing.Size(192, 21);
            this.comboBoxFlapMaterial.TabIndex = 11;
            this.comboBoxFlapMaterial.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // pictureFrame
            // 
            this.pictureFrame.Location = new System.Drawing.Point(28, 467);
            this.pictureFrame.Name = "pictureFrame";
            this.pictureFrame.Size = new System.Drawing.Size(249, 183);
            this.pictureFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFrame.TabIndex = 19;
            this.pictureFrame.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelForUserToWait
            // 
            this.labelForUserToWait.AutoSize = true;
            this.labelForUserToWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelForUserToWait.Location = new System.Drawing.Point(5, 315);
            this.labelForUserToWait.Name = "labelForUserToWait";
            this.labelForUserToWait.Size = new System.Drawing.Size(0, 16);
            this.labelForUserToWait.TabIndex = 21;
            // 
            // comboBoxThickness
            // 
            this.comboBoxThickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThickness.FormattingEnabled = true;
            this.comboBoxThickness.Location = new System.Drawing.Point(85, 222);
            this.comboBoxThickness.Name = "comboBoxThickness";
            this.comboBoxThickness.Size = new System.Drawing.Size(192, 21);
            this.comboBoxThickness.TabIndex = 23;
            this.comboBoxThickness.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelThickness.Location = new System.Drawing.Point(5, 222);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(66, 16);
            this.labelThickness.TabIndex = 22;
            this.labelThickness.Text = "Толщина";
            // 
            // button_Search
            // 
            this.button_Search.Enabled = false;
            this.button_Search.Location = new System.Drawing.Point(167, 419);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(110, 32);
            this.button_Search.TabIndex = 24;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Visible = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(72, 386);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "TEST_CASE";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // comboBoxCoatClass
            // 
            this.comboBoxCoatClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoatClass.Location = new System.Drawing.Point(112, 323);
            this.comboBoxCoatClass.Name = "comboBoxCoatClass";
            this.comboBoxCoatClass.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCoatClass.TabIndex = 27;
            // 
            // comboBoxCoatType
            // 
            this.comboBoxCoatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoatType.Location = new System.Drawing.Point(112, 291);
            this.comboBoxCoatType.Name = "comboBoxCoatType";
            this.comboBoxCoatType.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCoatType.TabIndex = 28;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.Location = new System.Drawing.Point(112, 258);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(165, 21);
            this.comboBoxColor.TabIndex = 26;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxColor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Класс:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Тип покрытия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Цвет:";
            // 
            // FlapBuilderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCoatClass);
            this.Controls.Add(this.comboBoxCoatType);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.comboBoxThickness);
            this.Controls.Add(this.labelThickness);
            this.Controls.Add(this.labelForUserToWait);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureFrame);
            this.Controls.Add(this.comboBoxFlapMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFlapType);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.frameNameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FlapBuilderControl";
            this.Size = new System.Drawing.Size(280, 713);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label frameNameLbl;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxFlapType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFlapMaterial;
        private System.Windows.Forms.PictureBox pictureFrame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelForUserToWait;
        private System.Windows.Forms.ComboBox comboBoxThickness;
        private System.Windows.Forms.Label labelThickness;
        private Button button_Search;
        private CheckBox checkBox2;
        private ComboBox comboBoxCoatClass;
        private ComboBox comboBoxCoatType;
        private ComboBox comboBoxColor;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}
