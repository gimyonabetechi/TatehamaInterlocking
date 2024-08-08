﻿namespace TatehamaInterlocking
{
    partial class MainWindow
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ButtonPushError = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("ＭＳ ゴシック", 18F, FontStyle.Bold);
            button1.Location = new Point(20, 20);
            button1.Name = "button1";
            button1.Size = new Size(130, 60);
            button1.TabIndex = 0;
            button1.Text = "館　浜";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("ＭＳ ゴシック", 18F, FontStyle.Bold);
            button2.Location = new Point(160, 20);
            button2.Name = "button2";
            button2.Size = new Size(130, 60);
            button2.TabIndex = 1;
            button2.Text = "駒　野";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("ＭＳ ゴシック", 18F, FontStyle.Bold);
            button3.Location = new Point(20, 120);
            button3.Name = "button3";
            button3.Size = new Size(130, 60);
            button3.TabIndex = 2;
            button3.Text = "津　崎";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Font = new Font("ＭＳ ゴシック", 18F, FontStyle.Bold);
            button4.Location = new Point(160, 120);
            button4.Name = "button4";
            button4.Size = new Size(130, 60);
            button4.TabIndex = 3;
            button4.Text = "浜　園";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSkyBlue;
            button5.Font = new Font("ＭＳ ゴシック", 18F, FontStyle.Bold);
            button5.Location = new Point(300, 120);
            button5.Name = "button5";
            button5.Size = new Size(130, 60);
            button5.TabIndex = 4;
            button5.Text = "新野崎";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSalmon;
            button6.Font = new Font("ＭＳ ゴシック", 18F, FontStyle.Bold);
            button6.Location = new Point(20, 220);
            button6.Name = "button6";
            button6.Size = new Size(130, 60);
            button6.TabIndex = 5;
            button6.Text = "江ノ原信";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSalmon;
            button7.Font = new Font("ＭＳ ゴシック", 18F, FontStyle.Bold);
            button7.Location = new Point(160, 220);
            button7.Name = "button7";
            button7.Size = new Size(130, 60);
            button7.TabIndex = 6;
            button7.Text = "大道寺";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // ButtonPushError
            // 
            ButtonPushError.AutoSize = true;
            ButtonPushError.Location = new Point(10, 380);
            ButtonPushError.Name = "ButtonPushError";
            ButtonPushError.Size = new Size(207, 16);
            ButtonPushError.TabIndex = 7;
            ButtonPushError.Text = "Ver0.4.1　CodeName:青木町";
            ButtonPushError.Click += ButtonPushError_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkGray;
            button8.Font = new Font("ＭＳ ゴシック", 18F, FontStyle.Bold);
            button8.Location = new Point(300, 320);
            button8.Name = "button8";
            button8.Size = new Size(130, 60);
            button8.TabIndex = 8;
            button8.Text = "全線TID";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(444, 401);
            Controls.Add(button8);
            Controls.Add(ButtonPushError);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("ＭＳ ゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "指令卓選択 | 館浜電鉄　ダイヤ運転";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label ButtonPushError;
        private Button button8;
    }
}
