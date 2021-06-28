
namespace FractalTest1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zoomInBtn = new System.Windows.Forms.Button();
            this.zoomOutBtn = new System.Windows.Forms.Button();
            this.moveUpBtn = new System.Windows.Forms.Button();
            this.moveDownBtn = new System.Windows.Forms.Button();
            this.moveLeftBtn = new System.Windows.Forms.Button();
            this.moveRightBtn = new System.Windows.Forms.Button();
            this.mandelbrotBtn = new System.Windows.Forms.Button();
            this.burningShipBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 720);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Location = new System.Drawing.Point(739, 13);
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Size = new System.Drawing.Size(80, 23);
            this.zoomInBtn.TabIndex = 1;
            this.zoomInBtn.Text = "Zoom In";
            this.zoomInBtn.UseMnemonic = false;
            this.zoomInBtn.UseVisualStyleBackColor = true;
            this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.Location = new System.Drawing.Point(739, 43);
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Size = new System.Drawing.Size(80, 23);
            this.zoomOutBtn.TabIndex = 2;
            this.zoomOutBtn.Text = "Zoom Out";
            this.zoomOutBtn.UseVisualStyleBackColor = true;
            this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
            // 
            // moveUpBtn
            // 
            this.moveUpBtn.Location = new System.Drawing.Point(769, 114);
            this.moveUpBtn.Name = "moveUpBtn";
            this.moveUpBtn.Size = new System.Drawing.Size(24, 24);
            this.moveUpBtn.TabIndex = 3;
            this.moveUpBtn.Text = "↑";
            this.moveUpBtn.UseVisualStyleBackColor = true;
            this.moveUpBtn.Click += new System.EventHandler(this.moveUpBtn_Click);
            // 
            // moveDownBtn
            // 
            this.moveDownBtn.Location = new System.Drawing.Point(769, 174);
            this.moveDownBtn.Name = "moveDownBtn";
            this.moveDownBtn.Size = new System.Drawing.Size(24, 24);
            this.moveDownBtn.TabIndex = 4;
            this.moveDownBtn.Text = "↓";
            this.moveDownBtn.UseVisualStyleBackColor = true;
            this.moveDownBtn.Click += new System.EventHandler(this.moveDownBtn_Click);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.Location = new System.Drawing.Point(739, 144);
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(24, 24);
            this.moveLeftBtn.TabIndex = 5;
            this.moveLeftBtn.Text = "←";
            this.moveLeftBtn.UseVisualStyleBackColor = true;
            this.moveLeftBtn.Click += new System.EventHandler(this.moveLeftBtn_Click);
            // 
            // moveRightBtn
            // 
            this.moveRightBtn.Location = new System.Drawing.Point(795, 144);
            this.moveRightBtn.Name = "moveRightBtn";
            this.moveRightBtn.Size = new System.Drawing.Size(24, 24);
            this.moveRightBtn.TabIndex = 6;
            this.moveRightBtn.Text = "→";
            this.moveRightBtn.UseVisualStyleBackColor = true;
            this.moveRightBtn.Click += new System.EventHandler(this.moveRightBtn_Click);
            // 
            // mandelbrotBtn
            // 
            this.mandelbrotBtn.Location = new System.Drawing.Point(739, 707);
            this.mandelbrotBtn.Name = "mandelbrotBtn";
            this.mandelbrotBtn.Size = new System.Drawing.Size(80, 23);
            this.mandelbrotBtn.TabIndex = 7;
            this.mandelbrotBtn.Text = "Mandelbrot";
            this.mandelbrotBtn.UseVisualStyleBackColor = true;
            this.mandelbrotBtn.Click += new System.EventHandler(this.mandelbrotBtn_Click);
            // 
            // burningShipBtn
            // 
            this.burningShipBtn.Location = new System.Drawing.Point(739, 678);
            this.burningShipBtn.Name = "burningShipBtn";
            this.burningShipBtn.Size = new System.Drawing.Size(80, 23);
            this.burningShipBtn.TabIndex = 8;
            this.burningShipBtn.Text = "Ship";
            this.burningShipBtn.UseVisualStyleBackColor = true;
            this.burningShipBtn.Click += new System.EventHandler(this.burningShipBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 742);
            this.Controls.Add(this.burningShipBtn);
            this.Controls.Add(this.mandelbrotBtn);
            this.Controls.Add(this.moveRightBtn);
            this.Controls.Add(this.moveLeftBtn);
            this.Controls.Add(this.moveDownBtn);
            this.Controls.Add(this.moveUpBtn);
            this.Controls.Add(this.zoomOutBtn);
            this.Controls.Add(this.zoomInBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractal Test #1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button zoomInBtn;
        private System.Windows.Forms.Button zoomOutBtn;
        private System.Windows.Forms.Button moveUpBtn;
        private System.Windows.Forms.Button moveDownBtn;
        private System.Windows.Forms.Button moveLeftBtn;
        private System.Windows.Forms.Button moveRightBtn;
        private System.Windows.Forms.Button mandelbrotBtn;
        private System.Windows.Forms.Button burningShipBtn;
    }
}

