namespace Kino_work02
{
    partial class User_choose
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
            next_btn = new Button();
            tickets_btn = new Button();
            afisha_pb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)afisha_pb).BeginInit();
            SuspendLayout();
            // 
            // next_btn
            // 
            next_btn.Location = new Point(89, 59);
            next_btn.Name = "next_btn";
            next_btn.Size = new Size(152, 68);
            next_btn.TabIndex = 0;
            next_btn.Text = "Next film";
            next_btn.UseVisualStyleBackColor = true;
            // 
            // tickets_btn
            // 
            tickets_btn.Location = new Point(89, 281);
            tickets_btn.Name = "tickets_btn";
            tickets_btn.Size = new Size(152, 68);
            tickets_btn.TabIndex = 1;
            tickets_btn.Text = "Buy tickets";
            tickets_btn.UseVisualStyleBackColor = true;
            // 
            // afisha_pb
            // 
            afisha_pb.Location = new Point(409, 59);
            afisha_pb.Name = "afisha_pb";
            afisha_pb.Size = new Size(269, 290);
            afisha_pb.TabIndex = 2;
            afisha_pb.TabStop = false;
            // 
            // User_choose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(afisha_pb);
            Controls.Add(tickets_btn);
            Controls.Add(next_btn);
            Name = "User_choose";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)afisha_pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button next_btn;
        private Button tickets_btn;
        private PictureBox afisha_pb;
    }
}
