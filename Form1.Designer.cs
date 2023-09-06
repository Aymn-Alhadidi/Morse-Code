namespace Test_in_C__Windows_framework_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMorse = new System.Windows.Forms.TextBox();
            this.timerOneMessage = new System.Windows.Forms.Timer(this.components);
            this.lbShowMessage = new System.Windows.Forms.Label();
            this.timer_ofMessage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Test_in_C__Windows_framework_.Properties.Resources.photo_2023_09_04_01_55_39__2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtEnglish
            // 
            this.txtEnglish.BackColor = System.Drawing.Color.Teal;
            this.txtEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglish.Location = new System.Drawing.Point(388, 133);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(354, 172);
            this.txtEnglish.TabIndex = 1;
            this.txtEnglish.TextChanged += new System.EventHandler(this.txtEnglish_TextChanged);
            // 
            // txtMorse
            // 
            this.txtMorse.BackColor = System.Drawing.Color.Teal;
            this.txtMorse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorse.Location = new System.Drawing.Point(388, 318);
            this.txtMorse.Multiline = true;
            this.txtMorse.Name = "txtMorse";
            this.txtMorse.Size = new System.Drawing.Size(354, 172);
            this.txtMorse.TabIndex = 2;
            this.txtMorse.TextChanged += new System.EventHandler(this.txtMorse_TextChanged);
            // 
            // timerOneMessage
            // 
            this.timerOneMessage.Interval = 10;
            this.timerOneMessage.Tick += new System.EventHandler(this.timerOneMessage_Tick);
            // 
            // lbShowMessage
            // 
            this.lbShowMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowMessage.Location = new System.Drawing.Point(807, 15);
            this.lbShowMessage.Name = "lbShowMessage";
            this.lbShowMessage.Size = new System.Drawing.Size(243, 560);
            this.lbShowMessage.TabIndex = 3;
            // 
            // timer_ofMessage
            // 
            this.timer_ofMessage.Interval = 12000;
            this.timer_ofMessage.Tick += new System.EventHandler(this.timer_ofMessage_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1078, 584);
            this.Controls.Add(this.lbShowMessage);
            this.Controls.Add(this.txtMorse);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Morse Code";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMorse;
        private System.Windows.Forms.Timer timerOneMessage;
        private System.Windows.Forms.Label lbShowMessage;
        private System.Windows.Forms.Timer timer_ofMessage;
    }
}

