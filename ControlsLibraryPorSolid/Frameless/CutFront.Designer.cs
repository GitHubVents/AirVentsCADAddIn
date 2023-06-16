namespace ControlsLibrary.Frameless
{
    partial class CutFront
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
            this.textBoxFrontWindowHeight = new System.Windows.Forms.TextBox();
            this.textBoxFrontWindowWidth = new System.Windows.Forms.TextBox();
            this.textBoxFrontWindowOff_X = new System.Windows.Forms.TextBox();
            this.textBoxFrontWindowOff_Y = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.cmbBoxFrontFlange = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.frontWindow = new System.Windows.Forms.CheckBox();
            this.groupBoxFrontP = new System.Windows.Forms.GroupBox();
            this.offsetFrontMaxY = new System.Windows.Forms.Label();
            this.offsetFrontMaxX = new System.Windows.Forms.Label();
            this.groupBoxFrontP.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFrontWindowHeight
            // 
            this.textBoxFrontWindowHeight.Location = new System.Drawing.Point(67, 67);
            this.textBoxFrontWindowHeight.Name = "textBoxFrontWindowHeight";
            this.textBoxFrontWindowHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrontWindowHeight.TabIndex = 3;
            this.textBoxFrontWindowHeight.TextChanged += new System.EventHandler(this.textBoxFrontWindowHeight_TextChanged);
            // 
            // textBoxFrontWindowWidth
            // 
            this.textBoxFrontWindowWidth.Location = new System.Drawing.Point(67, 42);
            this.textBoxFrontWindowWidth.Name = "textBoxFrontWindowWidth";
            this.textBoxFrontWindowWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrontWindowWidth.TabIndex = 2;
            this.textBoxFrontWindowWidth.TextChanged += new System.EventHandler(this.textBoxFrontWindowWidth_TextChanged);
            // 
            // textBoxFrontWindowOff_X
            // 
            this.textBoxFrontWindowOff_X.Location = new System.Drawing.Point(67, 93);
            this.textBoxFrontWindowOff_X.Name = "textBoxFrontWindowOff_X";
            this.textBoxFrontWindowOff_X.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrontWindowOff_X.TabIndex = 4;
            this.textBoxFrontWindowOff_X.TextChanged += new System.EventHandler(this.textBoxFrontWindowOff_X_TextChanged);
            // 
            // textBoxFrontWindowOff_Y
            // 
            this.textBoxFrontWindowOff_Y.Location = new System.Drawing.Point(67, 118);
            this.textBoxFrontWindowOff_Y.Name = "textBoxFrontWindowOff_Y";
            this.textBoxFrontWindowOff_Y.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrontWindowOff_Y.TabIndex = 5;
            this.textBoxFrontWindowOff_Y.TextChanged += new System.EventHandler(this.textBoxFrontWindowOff_Y_TextChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 151);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(51, 13);
            this.label44.TabIndex = 60;
            this.label44.Text = "Фланец:";
            // 
            // cmbBoxFrontFlange
            // 
            this.cmbBoxFrontFlange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFrontFlange.FormattingEnabled = true;
            this.cmbBoxFrontFlange.Location = new System.Drawing.Point(67, 148);
            this.cmbBoxFrontFlange.Name = "cmbBoxFrontFlange";
            this.cmbBoxFrontFlange.Size = new System.Drawing.Size(113, 21);
            this.cmbBoxFrontFlange.TabIndex = 6;
            this.cmbBoxFrontFlange.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFrontFlange_SelectedIndexChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(4, 73);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(48, 13);
            this.label43.TabIndex = 62;
            this.label43.Text = "Высота:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(4, 45);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(49, 13);
            this.label42.TabIndex = 63;
            this.label42.Text = "Ширина:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(4, 99);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(17, 13);
            this.label41.TabIndex = 64;
            this.label41.Text = "X:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(4, 125);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(17, 13);
            this.label40.TabIndex = 65;
            this.label40.Text = "Y:";
            // 
            // frontWindow
            // 
            this.frontWindow.AutoSize = true;
            this.frontWindow.Location = new System.Drawing.Point(6, 19);
            this.frontWindow.Name = "frontWindow";
            this.frontWindow.Size = new System.Drawing.Size(72, 17);
            this.frontWindow.TabIndex = 1;
            this.frontWindow.Text = "На входе";
            this.frontWindow.UseVisualStyleBackColor = true;
            this.frontWindow.CheckedChanged += new System.EventHandler(this.frontWindow_CheckedChanged);
            // 
            // groupBoxFrontP
            // 
            this.groupBoxFrontP.Controls.Add(this.offsetFrontMaxY);
            this.groupBoxFrontP.Controls.Add(this.offsetFrontMaxX);
            this.groupBoxFrontP.Controls.Add(this.frontWindow);
            this.groupBoxFrontP.Controls.Add(this.label40);
            this.groupBoxFrontP.Controls.Add(this.label41);
            this.groupBoxFrontP.Controls.Add(this.label42);
            this.groupBoxFrontP.Controls.Add(this.label43);
            this.groupBoxFrontP.Controls.Add(this.cmbBoxFrontFlange);
            this.groupBoxFrontP.Controls.Add(this.label44);
            this.groupBoxFrontP.Controls.Add(this.textBoxFrontWindowOff_Y);
            this.groupBoxFrontP.Controls.Add(this.textBoxFrontWindowOff_X);
            this.groupBoxFrontP.Controls.Add(this.textBoxFrontWindowWidth);
            this.groupBoxFrontP.Controls.Add(this.textBoxFrontWindowHeight);
            this.groupBoxFrontP.Location = new System.Drawing.Point(3, 12);
            this.groupBoxFrontP.Name = "groupBoxFrontP";
            this.groupBoxFrontP.Size = new System.Drawing.Size(260, 180);
            this.groupBoxFrontP.TabIndex = 67;
            this.groupBoxFrontP.TabStop = false;
            // 
            // offsetFrontMaxY
            // 
            this.offsetFrontMaxY.AutoSize = true;
            this.offsetFrontMaxY.Location = new System.Drawing.Point(173, 121);
            this.offsetFrontMaxY.Name = "offsetFrontMaxY";
            this.offsetFrontMaxY.Size = new System.Drawing.Size(19, 13);
            this.offsetFrontMaxY.TabIndex = 71;
            this.offsetFrontMaxY.Text = " < ";
            // 
            // offsetFrontMaxX
            // 
            this.offsetFrontMaxX.AutoSize = true;
            this.offsetFrontMaxX.Location = new System.Drawing.Point(173, 96);
            this.offsetFrontMaxX.Name = "offsetFrontMaxX";
            this.offsetFrontMaxX.Size = new System.Drawing.Size(19, 13);
            this.offsetFrontMaxX.TabIndex = 70;
            this.offsetFrontMaxX.Text = " < ";
            this.offsetFrontMaxX.Click += new System.EventHandler(this.offsetFrontMaxX_Click);
            // 
            // CutFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxFrontP);
            this.Name = "CutFront";
            this.Size = new System.Drawing.Size(280, 195);
            this.groupBoxFrontP.ResumeLayout(false);
            this.groupBoxFrontP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFrontWindowHeight;
        private System.Windows.Forms.TextBox textBoxFrontWindowWidth;
        private System.Windows.Forms.TextBox textBoxFrontWindowOff_X;
        private System.Windows.Forms.TextBox textBoxFrontWindowOff_Y;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox cmbBoxFrontFlange;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.CheckBox frontWindow;
        private System.Windows.Forms.GroupBox groupBoxFrontP;
        private System.Windows.Forms.Label offsetFrontMaxY;
        private System.Windows.Forms.Label offsetFrontMaxX;
    }
}
