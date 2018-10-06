namespace WindowsFormsApp1
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manh = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(70, 70);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(200, 20);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // manh
            // 
            this.manh.Location = new System.Drawing.Point(425, 66);
            this.manh.Name = "manh";
            this.manh.Size = new System.Drawing.Size(75, 23);
            this.manh.TabIndex = 2;
            this.manh.Text = "an vao dmm";
            this.manh.UseVisualStyleBackColor = true;
            this.manh.Click += new System.EventHandler(this.manh_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(70, 130);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(200, 20);
            this.txt2.TabIndex = 3;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "manh",
            "pro ",
            "vip",
            "123"});
            this.cb1.Location = new System.Drawing.Point(127, 197);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 4;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(470, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Checked = true;
            this.cc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cc.Location = new System.Drawing.Point(338, 220);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(38, 17);
            this.cc.TabIndex = 6;
            this.cc.Text = "cc";
            this.cc.UseVisualStyleBackColor = true;
            this.cc.CheckedChanged += new System.EventHandler(this.cc_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.manh);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button manh;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cc;
    }
}

