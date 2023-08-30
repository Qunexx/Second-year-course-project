namespace DrawFigure
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMoveAll = new System.Windows.Forms.Button();
            this.buttonDrawAll = new System.Windows.Forms.Button();
            this.buttonInitAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericDY = new System.Windows.Forms.NumericUpDown();
            this.numericDX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericY3 = new System.Windows.Forms.NumericUpDown();
            this.numericX3 = new System.Windows.Forms.NumericUpDown();
            this.numericY2 = new System.Windows.Forms.NumericUpDown();
            this.numericX2 = new System.Windows.Forms.NumericUpDown();
            this.numericY1 = new System.Windows.Forms.NumericUpDown();
            this.numericX1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonEnvelope = new System.Windows.Forms.RadioButton();
            this.radioButtonPoint = new System.Windows.Forms.RadioButton();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.buttonMoveFigure = new System.Windows.Forms.Button();
            this.buttonDrawFigure = new System.Windows.Forms.Button();
            this.buttonInitFigure = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDX)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericY3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelDraw.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMoveAll);
            this.groupBox1.Controls.Add(this.buttonDrawAll);
            this.groupBox1.Controls.Add(this.buttonInitAll);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опыт №1";
            // 
            // buttonMoveAll
            // 
            this.buttonMoveAll.Location = new System.Drawing.Point(155, 20);
            this.buttonMoveAll.Name = "buttonMoveAll";
            this.buttonMoveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveAll.TabIndex = 2;
            this.buttonMoveAll.Text = "Move  all";
            this.buttonMoveAll.UseVisualStyleBackColor = true;
            this.buttonMoveAll.Click += new System.EventHandler(this.buttonMoveAll_Click);
            // 
            // buttonDrawAll
            // 
            this.buttonDrawAll.Location = new System.Drawing.Point(80, 20);
            this.buttonDrawAll.Name = "buttonDrawAll";
            this.buttonDrawAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawAll.TabIndex = 1;
            this.buttonDrawAll.Text = "Draw all";
            this.buttonDrawAll.UseVisualStyleBackColor = true;
            this.buttonDrawAll.Click += new System.EventHandler(this.buttonDrawAll_Click);
            // 
            // buttonInitAll
            // 
            this.buttonInitAll.Location = new System.Drawing.Point(5, 20);
            this.buttonInitAll.Name = "buttonInitAll";
            this.buttonInitAll.Size = new System.Drawing.Size(72, 23);
            this.buttonInitAll.TabIndex = 0;
            this.buttonInitAll.Text = "Init all";
            this.buttonInitAll.UseVisualStyleBackColor = true;
            this.buttonInitAll.Click += new System.EventHandler(this.buttonInitAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.buttonMoveFigure);
            this.groupBox2.Controls.Add(this.buttonDrawFigure);
            this.groupBox2.Controls.Add(this.buttonInitFigure);
            this.groupBox2.Location = new System.Drawing.Point(6, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 310);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Опыт №2";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericDY);
            this.groupBox5.Controls.Add(this.numericDX);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(117, 208);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(110, 85);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Переместить на";
            // 
            // numericDY
            // 
            this.numericDY.Location = new System.Drawing.Point(38, 48);
            this.numericDY.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericDY.Name = "numericDY";
            this.numericDY.Size = new System.Drawing.Size(63, 20);
            this.numericDY.TabIndex = 23;
            // 
            // numericDX
            // 
            this.numericDX.Location = new System.Drawing.Point(38, 22);
            this.numericDX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericDX.Name = "numericDX";
            this.numericDX.Size = new System.Drawing.Size(63, 20);
            this.numericDX.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "DY:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "DX:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericY3);
            this.groupBox4.Controls.Add(this.numericX3);
            this.groupBox4.Controls.Add(this.numericY2);
            this.groupBox4.Controls.Add(this.numericX2);
            this.groupBox4.Controls.Add(this.numericY1);
            this.groupBox4.Controls.Add(this.numericX1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(124, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 183);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Координаты:";
            // 
            // numericY3
            // 
            this.numericY3.Location = new System.Drawing.Point(42, 149);
            this.numericY3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericY3.Name = "numericY3";
            this.numericY3.Size = new System.Drawing.Size(63, 20);
            this.numericY3.TabIndex = 13;
            // 
            // numericX3
            // 
            this.numericX3.Location = new System.Drawing.Point(42, 122);
            this.numericX3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericX3.Name = "numericX3";
            this.numericX3.Size = new System.Drawing.Size(63, 20);
            this.numericX3.TabIndex = 12;
            // 
            // numericY2
            // 
            this.numericY2.Location = new System.Drawing.Point(42, 94);
            this.numericY2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericY2.Name = "numericY2";
            this.numericY2.Size = new System.Drawing.Size(63, 20);
            this.numericY2.TabIndex = 11;
            // 
            // numericX2
            // 
            this.numericX2.Location = new System.Drawing.Point(42, 68);
            this.numericX2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericX2.Name = "numericX2";
            this.numericX2.Size = new System.Drawing.Size(63, 20);
            this.numericX2.TabIndex = 10;
            // 
            // numericY1
            // 
            this.numericY1.Location = new System.Drawing.Point(42, 42);
            this.numericY1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericY1.Name = "numericY1";
            this.numericY1.Size = new System.Drawing.Size(63, 20);
            this.numericY1.TabIndex = 9;
            // 
            // numericX1
            // 
            this.numericX1.Location = new System.Drawing.Point(42, 17);
            this.numericX1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericX1.Name = "numericX1";
            this.numericX1.Size = new System.Drawing.Size(63, 20);
            this.numericX1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Y3:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "X3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonEnvelope);
            this.groupBox3.Controls.Add(this.radioButtonPoint);
            this.groupBox3.Controls.Add(this.radioButtonCircle);
            this.groupBox3.Controls.Add(this.radioButtonEllipse);
            this.groupBox3.Controls.Add(this.radioButtonLine);
            this.groupBox3.Controls.Add(this.radioButtonTriangle);
            this.groupBox3.Controls.Add(this.radioButtonRectangle);
            this.groupBox3.Location = new System.Drawing.Point(8, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 183);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор фигуры:";
            // 
            // radioButtonEnvelope
            // 
            this.radioButtonEnvelope.AutoSize = true;
            this.radioButtonEnvelope.Location = new System.Drawing.Point(6, 157);
            this.radioButtonEnvelope.Name = "radioButtonEnvelope";
            this.radioButtonEnvelope.Size = new System.Drawing.Size(99, 17);
            this.radioButtonEnvelope.TabIndex = 6;
            this.radioButtonEnvelope.TabStop = true;
            this.radioButtonEnvelope.Text = "КругВПрямоуг";
            this.radioButtonEnvelope.UseVisualStyleBackColor = true;
            // 
            // radioButtonPoint
            // 
            this.radioButtonPoint.AutoSize = true;
            this.radioButtonPoint.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPoint.Name = "radioButtonPoint";
            this.radioButtonPoint.Size = new System.Drawing.Size(55, 17);
            this.radioButtonPoint.TabIndex = 0;
            this.radioButtonPoint.TabStop = true;
            this.radioButtonPoint.Text = "Точка";
            this.radioButtonPoint.UseVisualStyleBackColor = true;
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(48, 17);
            this.radioButtonCircle.TabIndex = 1;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Круг";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(6, 65);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEllipse.TabIndex = 2;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Эллипс";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(6, 88);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(57, 17);
            this.radioButtonLine.TabIndex = 3;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Линия";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(6, 111);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(90, 17);
            this.radioButtonTriangle.TabIndex = 4;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "Треугольник";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(6, 134);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(105, 17);
            this.radioButtonRectangle.TabIndex = 5;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Прямоугольник";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // buttonMoveFigure
            // 
            this.buttonMoveFigure.Location = new System.Drawing.Point(15, 270);
            this.buttonMoveFigure.Name = "buttonMoveFigure";
            this.buttonMoveFigure.Size = new System.Drawing.Size(93, 23);
            this.buttonMoveFigure.TabIndex = 12;
            this.buttonMoveFigure.Text = "Move  figure";
            this.buttonMoveFigure.UseVisualStyleBackColor = true;
            this.buttonMoveFigure.Click += new System.EventHandler(this.buttonMoveFigure_Click);
            // 
            // buttonDrawFigure
            // 
            this.buttonDrawFigure.Location = new System.Drawing.Point(14, 241);
            this.buttonDrawFigure.Name = "buttonDrawFigure";
            this.buttonDrawFigure.Size = new System.Drawing.Size(94, 23);
            this.buttonDrawFigure.TabIndex = 11;
            this.buttonDrawFigure.Text = "Draw figure";
            this.buttonDrawFigure.UseVisualStyleBackColor = true;
            this.buttonDrawFigure.Click += new System.EventHandler(this.buttonDrawFigure_Click);
            // 
            // buttonInitFigure
            // 
            this.buttonInitFigure.Location = new System.Drawing.Point(15, 211);
            this.buttonInitFigure.Name = "buttonInitFigure";
            this.buttonInitFigure.Size = new System.Drawing.Size(93, 23);
            this.buttonInitFigure.TabIndex = 10;
            this.buttonInitFigure.Text = "Init figure";
            this.buttonInitFigure.UseVisualStyleBackColor = true;
            this.buttonInitFigure.Click += new System.EventHandler(this.buttonInitFigure_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(820, 389);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(252, 389);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelDraw
            // 
            this.panelDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDraw.Controls.Add(this.statusStrip1);
            this.panelDraw.Location = new System.Drawing.Point(252, 12);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(643, 371);
            this.panelDraw.TabIndex = 5;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(641, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 485);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Работа с классами графических объектов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericY3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericX1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelDraw.ResumeLayout(false);
            this.panelDraw.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMoveAll;
        private System.Windows.Forms.Button buttonDrawAll;
        private System.Windows.Forms.Button buttonInitAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericY3;
        private System.Windows.Forms.NumericUpDown numericX3;
        private System.Windows.Forms.NumericUpDown numericY2;
        private System.Windows.Forms.NumericUpDown numericX2;
        private System.Windows.Forms.NumericUpDown numericY1;
        private System.Windows.Forms.NumericUpDown numericX1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonPoint;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericDY;
        private System.Windows.Forms.NumericUpDown numericDX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonMoveFigure;
        private System.Windows.Forms.Button buttonDrawFigure;
        private System.Windows.Forms.Button buttonInitFigure;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.RadioButton radioButtonEnvelope;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

