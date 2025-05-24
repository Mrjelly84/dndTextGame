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
            btnSubmit = new Button();
            picBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // rtbGameOutput
            // 
            rtbGameOutput.BackColor = SystemColors.ActiveCaptionText;
            rtbGameOutput.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbGameOutput.ForeColor = Color.White;
            rtbGameOutput.Location = new Point(0, 0);
            rtbGameOutput.Name = "rtbGameOutput";
            rtbGameOutput.ReadOnly = true;
            rtbGameOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbGameOutput.Size = new Size(388, 248);
            rtbGameOutput.TabIndex = 0;
            rtbGameOutput.Text = "";
            // 
            // txtPlayInput
            // 
            txtPlayInput.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlayInput.Location = new Point(12, 254);
            txtPlayInput.Multiline = true;
            txtPlayInput.Name = "txtPlayInput";
            txtPlayInput.Size = new Size(376, 59);
            txtPlayInput.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(138, 319);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // picBox
            // 
            picBox.Location = new Point(394, 0);
            picBox.Name = "picBox";
            picBox.Size = new Size(345, 313);
            picBox.TabIndex = 3;
            picBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 350);
            Controls.Add(picBox);
            Controls.Add(btnSubmit);
            Controls.Add(txtPlayInput);
            Controls.Add(rtbGameOutput);
            Name = "Form1";
            Text = "d&d";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbGameOutput;
        private TextBox txtPlayInput;
        private Button btnSubmit;
        private PictureBox picBox;
    }
}
