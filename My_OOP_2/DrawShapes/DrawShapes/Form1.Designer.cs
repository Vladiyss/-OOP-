namespace DrawShapes
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPlaceToDraw = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxShapeColor = new System.Windows.Forms.PictureBox();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaceToDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShapeColor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPlaceToDraw
            // 
            this.pictureBoxPlaceToDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPlaceToDraw.Location = new System.Drawing.Point(11, 8);
            this.pictureBoxPlaceToDraw.Name = "pictureBoxPlaceToDraw";
            this.pictureBoxPlaceToDraw.Size = new System.Drawing.Size(1077, 535);
            this.pictureBoxPlaceToDraw.TabIndex = 0;
            this.pictureBoxPlaceToDraw.TabStop = false;
            this.pictureBoxPlaceToDraw.Click += new System.EventHandler(this.pictureBoxPlaceToDraw_Click);
            this.pictureBoxPlaceToDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPlaceToDraw_Paint);
            this.pictureBoxPlaceToDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPlaceToDraw_MouseDown);
            this.pictureBoxPlaceToDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPlaceToDraw_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ЦВЕТ ЗАЛИВКИ";
            // 
            // pictureBoxShapeColor
            // 
            this.pictureBoxShapeColor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBoxShapeColor.Location = new System.Drawing.Point(130, 3);
            this.pictureBoxShapeColor.Name = "pictureBoxShapeColor";
            this.pictureBoxShapeColor.Size = new System.Drawing.Size(109, 32);
            this.pictureBoxShapeColor.TabIndex = 2;
            this.pictureBoxShapeColor.TabStop = false;
            this.pictureBoxShapeColor.Click += new System.EventHandler(this.pictureBoxShapeColor_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(0, 42);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(114, 30);
            this.buttonLine.TabIndex = 3;
            this.buttonLine.Tag = "1";
            this.buttonLine.Text = "Линия";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(0, 78);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(114, 30);
            this.buttonCircle.TabIndex = 4;
            this.buttonCircle.Tag = "2";
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(0, 114);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(114, 30);
            this.buttonEllipse.TabIndex = 5;
            this.buttonEllipse.Tag = "3";
            this.buttonEllipse.Text = "Эллипс";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(120, 41);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(119, 30);
            this.buttonSquare.TabIndex = 6;
            this.buttonSquare.Tag = "4";
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(120, 78);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(119, 30);
            this.buttonRectangle.TabIndex = 7;
            this.buttonRectangle.Tag = "5";
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(120, 114);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(119, 30);
            this.buttonTriangle.TabIndex = 8;
            this.buttonTriangle.Tag = "6";
            this.buttonTriangle.Text = "Треугольник";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTriangle);
            this.panel1.Controls.Add(this.buttonEllipse);
            this.panel1.Controls.Add(this.buttonRectangle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSquare);
            this.panel1.Controls.Add(this.buttonCircle);
            this.panel1.Controls.Add(this.pictureBoxShapeColor);
            this.panel1.Controls.Add(this.buttonLine);
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 152);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxPlaceToDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaceToDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShapeColor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlaceToDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxShapeColor;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panel1;
    }
}

