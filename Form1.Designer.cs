namespace dndTextGame
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
            rtbGameOutput = new RichTextBox();
            txtPlayInput = new TextBox();
            pbGameImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbGameImage).BeginInit();
            SuspendLayout();
            // 
            // rtbGameOutput
            // 
            rtbGameOutput.BackColor = SystemColors.ActiveCaptionText;
            rtbGameOutput.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbGameOutput.ForeColor = Color.White;
            rtbGameOutput.Location = new Point(0, 0);
            rtbGameOutput.Margin = new Padding(4, 5, 4, 5);
            rtbGameOutput.Name = "rtbGameOutput";
            rtbGameOutput.ReadOnly = true;
            rtbGameOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbGameOutput.Size = new Size(553, 411);
            rtbGameOutput.TabIndex = 0;
            rtbGameOutput.Text = "";
            // 
            // txtPlayInput
            // 
            txtPlayInput.BackColor = Color.Yellow;
            txtPlayInput.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlayInput.Location = new Point(17, 423);
            txtPlayInput.Margin = new Padding(4, 5, 4, 5);
            txtPlayInput.Multiline = true;
            txtPlayInput.Name = "txtPlayInput";
            txtPlayInput.Size = new Size(535, 96);
            txtPlayInput.TabIndex = 1;
            txtPlayInput.KeyDown += txtPlayInput_KeyDown;
            // 
            // pbGameImage
            // 
            pbGameImage.Location = new Point(563, 0);
            pbGameImage.Margin = new Padding(4, 5, 4, 5);
            pbGameImage.Name = "pbGameImage";
            pbGameImage.Size = new Size(493, 522);
            pbGameImage.TabIndex = 3;
            pbGameImage.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1073, 538);
            Controls.Add(pbGameImage);
            Controls.Add(txtPlayInput);
            Controls.Add(rtbGameOutput);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "d&d";
            Load += Form1_Load;
            Closing += Form1_Closing;
            ((System.ComponentModel.ISupportInitialize)pbGameImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbGameOutput;
        private TextBox txtPlayInput;
        private PictureBox pbGameImage;
    }
}
