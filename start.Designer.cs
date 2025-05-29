namespace dndTextGame
{
    partial class start
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
            pictureBox1 = new PictureBox();
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dnd;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkGoldenrod;
            btnStart.Location = new Point(21, 216);
            btnStart.Margin = new Padding(2, 2, 2, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(201, 30);
            btnStart.TabIndex = 1;
            btnStart.Text = "Click here to start you adventure";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(560, 270);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "d&d";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnStart;
    }
}