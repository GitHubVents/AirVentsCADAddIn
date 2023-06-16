using DataBaseDomian;
using System;

namespace ControlsLibrary.MountingFrame
{
    partial class MountingFrame
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
            this.frameNameLbl = new System.Windows.Forms.Label();
            this.frameTypeLbl = new System.Windows.Forms.Label();
            this.frameDisplacementLbl = new System.Windows.Forms.Label();
            this.frameWidthLbl = new System.Windows.Forms.Label();
            this.frameLenthLbl = new System.Windows.Forms.Label();
            this.frameMaterialLbl = new System.Windows.Forms.Label();
            this.frameThicknessLbl = new System.Windows.Forms.Label();
            this.comboBoxFrameType = new System.Windows.Forms.ComboBox();
            this.textBoxDisplacement = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxLenth = new System.Windows.Forms.TextBox();
            this.comboBoxFrameMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxThickness = new System.Windows.Forms.ComboBox();
            this.btnFrameBuild = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureFrame = new System.Windows.Forms.PictureBox();
            this.labelForUserToWait = new System.Windows.Forms.Label();
            this.comboBoxCoatClass = new System.Windows.Forms.ComboBox();
            this.comboBoxCoatType = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // frameNameLbl
            // 
            this.frameNameLbl.AutoSize = true;
            this.frameNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameNameLbl.Location = new System.Drawing.Point(3, 0);
            this.frameNameLbl.Name = "frameNameLbl";
            this.frameNameLbl.Size = new System.Drawing.Size(183, 25);
            this.frameNameLbl.TabIndex = 0;
            this.frameNameLbl.Text = "Монтажная рама";
            // 
            // frameTypeLbl
            // 
            this.frameTypeLbl.AutoSize = true;
            this.frameTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameTypeLbl.Location = new System.Drawing.Point(41, 221);
            this.frameTypeLbl.Name = "frameTypeLbl";
            this.frameTypeLbl.Size = new System.Drawing.Size(73, 16);
            this.frameTypeLbl.TabIndex = 1;
            this.frameTypeLbl.Text = "Тип рамы:";
            // 
            // frameDisplacementLbl
            // 
            this.frameDisplacementLbl.AutoSize = true;
            this.frameDisplacementLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameDisplacementLbl.Location = new System.Drawing.Point(12, 189);
            this.frameDisplacementLbl.Name = "frameDisplacementLbl";
            this.frameDisplacementLbl.Size = new System.Drawing.Size(102, 16);
            this.frameDisplacementLbl.TabIndex = 2;
            this.frameDisplacementLbl.Text = "Смещение, мм:";
            // 
            // frameWidthLbl
            // 
            this.frameWidthLbl.AutoSize = true;
            this.frameWidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameWidthLbl.Location = new System.Drawing.Point(28, 125);
            this.frameWidthLbl.Name = "frameWidthLbl";
            this.frameWidthLbl.Size = new System.Drawing.Size(86, 16);
            this.frameWidthLbl.TabIndex = 3;
            this.frameWidthLbl.Text = "Ширина, мм:";
            // 
            // frameLenthLbl
            // 
            this.frameLenthLbl.AutoSize = true;
            this.frameLenthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameLenthLbl.Location = new System.Drawing.Point(38, 157);
            this.frameLenthLbl.Name = "frameLenthLbl";
            this.frameLenthLbl.Size = new System.Drawing.Size(76, 16);
            this.frameLenthLbl.TabIndex = 4;
            this.frameLenthLbl.Text = "Длина, мм:";
            // 
            // frameMaterialLbl
            // 
            this.frameMaterialLbl.AutoSize = true;
            this.frameMaterialLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameMaterialLbl.Location = new System.Drawing.Point(37, 253);
            this.frameMaterialLbl.Name = "frameMaterialLbl";
            this.frameMaterialLbl.Size = new System.Drawing.Size(77, 16);
            this.frameMaterialLbl.TabIndex = 5;
            this.frameMaterialLbl.Text = "Материал:";
            // 
            // frameThicknessLbl
            // 
            this.frameThicknessLbl.AutoSize = true;
            this.frameThicknessLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frameThicknessLbl.Location = new System.Drawing.Point(21, 285);
            this.frameThicknessLbl.Name = "frameThicknessLbl";
            this.frameThicknessLbl.Size = new System.Drawing.Size(93, 16);
            this.frameThicknessLbl.TabIndex = 6;
            this.frameThicknessLbl.Text = "Толщина, мм:";
            // 
            // comboBoxFrameType
            // 
            this.comboBoxFrameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrameType.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBoxFrameType.Location = new System.Drawing.Point(120, 217);
            this.comboBoxFrameType.Name = "comboBoxFrameType";
            this.comboBoxFrameType.Size = new System.Drawing.Size(137, 21);
            this.comboBoxFrameType.TabIndex = 10;
            this.comboBoxFrameType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrameType_SelectedIndexChanged);
            this.comboBoxFrameType.SelectedValueChanged += new System.EventHandler(this.Value_TextChanged);
            this.comboBoxFrameType.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // textBoxDisplacement
            // 
            this.textBoxDisplacement.Location = new System.Drawing.Point(120, 186);
            this.textBoxDisplacement.Name = "textBoxDisplacement";
            this.textBoxDisplacement.Size = new System.Drawing.Size(137, 20);
            this.textBoxDisplacement.TabIndex = 4;
            this.textBoxDisplacement.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.textBoxDisplacement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON_KeyPress);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(120, 124);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(137, 20);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON_KeyPress);
            // 
            // textBoxLenth
            // 
            this.textBoxLenth.Location = new System.Drawing.Point(120, 155);
            this.textBoxLenth.Name = "textBoxLenth";
            this.textBoxLenth.Size = new System.Drawing.Size(137, 20);
            this.textBoxLenth.TabIndex = 3;
            this.textBoxLenth.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.textBoxLenth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ON_KeyPress);
            // 
            // comboBoxFrameMaterial
            // 
            this.comboBoxFrameMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrameMaterial.Location = new System.Drawing.Point(120, 249);
            this.comboBoxFrameMaterial.Name = "comboBoxFrameMaterial";
            this.comboBoxFrameMaterial.Size = new System.Drawing.Size(137, 21);
            this.comboBoxFrameMaterial.TabIndex = 9;
            this.comboBoxFrameMaterial.SelectedValueChanged += new System.EventHandler(this.Value_TextChanged);
            this.comboBoxFrameMaterial.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // comboBoxThickness
            // 
            this.comboBoxThickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThickness.FormattingEnabled = true;
            this.comboBoxThickness.Location = new System.Drawing.Point(120, 281);
            this.comboBoxThickness.Name = "comboBoxThickness";
            this.comboBoxThickness.Size = new System.Drawing.Size(137, 21);
            this.comboBoxThickness.TabIndex = 8;
            this.comboBoxThickness.SelectedIndexChanged += new System.EventHandler(this.comboBoxThickness_SelectedIndexChanged);
            this.comboBoxThickness.SelectedValueChanged += new System.EventHandler(this.Value_TextChanged);
            this.comboBoxThickness.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // btnFrameBuild
            // 
            this.btnFrameBuild.Location = new System.Drawing.Point(136, 414);
            this.btnFrameBuild.Name = "btnFrameBuild";
            this.btnFrameBuild.Size = new System.Drawing.Size(110, 32);
            this.btnFrameBuild.TabIndex = 12;
            this.btnFrameBuild.Text = "Построить";
            this.btnFrameBuild.UseVisualStyleBackColor = true;
            this.btnFrameBuild.Click += new System.EventHandler(this.btnFrameBuild_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(33, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(197, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Безкаркасная установка (-20 мм)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.TextChanged += new System.EventHandler(this.Value_TextChanged);
            this.checkBox1.Click += new System.EventHandler(this.Value_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(120, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Типоразмер:";
            // 
            // pictureFrame
            // 
            this.pictureFrame.Location = new System.Drawing.Point(8, 498);
            this.pictureFrame.Name = "pictureFrame";
            this.pictureFrame.Size = new System.Drawing.Size(249, 183);
            this.pictureFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFrame.TabIndex = 18;
            this.pictureFrame.TabStop = false;
            // 
            // labelForUserToWait
            // 
            this.labelForUserToWait.AutoSize = true;
            this.labelForUserToWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForUserToWait.Location = new System.Drawing.Point(5, 420);
            this.labelForUserToWait.Name = "labelForUserToWait";
            this.labelForUserToWait.Size = new System.Drawing.Size(0, 18);
            this.labelForUserToWait.TabIndex = 19;
            // 
            // comboBoxCoatClass
            // 
            this.comboBoxCoatClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoatClass.Location = new System.Drawing.Point(120, 380);
            this.comboBoxCoatClass.Name = "comboBoxCoatClass";
            this.comboBoxCoatClass.Size = new System.Drawing.Size(137, 21);
            this.comboBoxCoatClass.TabIndex = 6;
            this.comboBoxCoatClass.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // comboBoxCoatType
            // 
            this.comboBoxCoatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoatType.Location = new System.Drawing.Point(120, 348);
            this.comboBoxCoatType.Name = "comboBoxCoatType";
            this.comboBoxCoatType.Size = new System.Drawing.Size(137, 21);
            this.comboBoxCoatType.TabIndex = 7;
            this.comboBoxCoatType.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.Location = new System.Drawing.Point(120, 316);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(137, 21);
            this.comboBoxColor.TabIndex = 5;
            this.comboBoxColor.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(65, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Класс:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Тип покрытия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Цвет:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 44;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MountingFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCoatClass);
            this.Controls.Add(this.comboBoxCoatType);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelForUserToWait);
            this.Controls.Add(this.pictureFrame);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnFrameBuild);
            this.Controls.Add(this.comboBoxThickness);
            this.Controls.Add(this.comboBoxFrameMaterial);
            this.Controls.Add(this.textBoxLenth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxDisplacement);
            this.Controls.Add(this.comboBoxFrameType);
            this.Controls.Add(this.frameThicknessLbl);
            this.Controls.Add(this.frameMaterialLbl);
            this.Controls.Add(this.frameLenthLbl);
            this.Controls.Add(this.frameWidthLbl);
            this.Controls.Add(this.frameDisplacementLbl);
            this.Controls.Add(this.frameTypeLbl);
            this.Controls.Add(this.frameNameLbl);
            this.Name = "MountingFrame";
            this.Size = new System.Drawing.Size(280, 723);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frameNameLbl;
        private System.Windows.Forms.Label frameTypeLbl;
        private System.Windows.Forms.Label frameDisplacementLbl;
        private System.Windows.Forms.Label frameWidthLbl;
        private System.Windows.Forms.Label frameLenthLbl;
        private System.Windows.Forms.Label frameMaterialLbl;
        private System.Windows.Forms.Label frameThicknessLbl;
        private System.Windows.Forms.ComboBox comboBoxFrameType;
        private System.Windows.Forms.TextBox textBoxDisplacement;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxLenth;
        private System.Windows.Forms.ComboBox comboBoxFrameMaterial;
        private System.Windows.Forms.ComboBox comboBoxThickness;
        private System.Windows.Forms.Button btnFrameBuild;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureFrame;
        private System.Windows.Forms.Label labelForUserToWait;
        private System.Windows.Forms.ComboBox comboBoxCoatClass;
        private System.Windows.Forms.ComboBox comboBoxCoatType;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
