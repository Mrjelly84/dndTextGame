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
            SuspendLayout();
            // 
            // rtbGameOutput
            // 
            rtbGameOutput.BackColor = SystemColors.ActiveCaptionText;
            rtbGameOutput.Dock = DockStyle.Top;
            rtbGameOutput.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbGameOutput.ForeColor = Color.White;
            rtbGameOutput.Location = new Point(0, 0);
            rtbGameOutput.Name = "rtbGameOutput";
            rtbGameOutput.ReadOnly = true;
            rtbGameOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbGameOutput.Size = new Size(892, 420);
            rtbGameOutput.TabIndex = 0;
            rtbGameOutput.Text = "";
            // 
            // txtPlayInput
            // 
            txtPlayInput.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlayInput.Location = new Point(12, 426);
            txtPlayInput.Multiline = true;
            txtPlayInput.Name = "txtPlayInput";
            txtPlayInput.Size = new Size(868, 80);
            txtPlayInput.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(388, 512);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 567);
            Controls.Add(btnSubmit);
            Controls.Add(txtPlayInput);
            Controls.Add(rtbGameOutput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbGameOutput;
        private TextBox txtPlayInput;
        private Button btnSubmit;
    }
}
