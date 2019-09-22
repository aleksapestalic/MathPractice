namespace Vežbanje_matematike
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
            this.lZad = new System.Windows.Forms.Label();
            this.tbOdgovor = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sabiranjeOduzimanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oduzimanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbOd = new System.Windows.Forms.TextBox();
            this.tbDo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bEnter = new System.Windows.Forms.Button();
            this.bEnterOduz = new System.Windows.Forms.Button();
            this.bEnterMnoz = new System.Windows.Forms.Button();
            this.množenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lNapomena = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lZad
            // 
            this.lZad.AutoSize = true;
            this.lZad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZad.Location = new System.Drawing.Point(259, 94);
            this.lZad.Name = "lZad";
            this.lZad.Size = new System.Drawing.Size(152, 25);
            this.lZad.TabIndex = 0;
            this.lZad.Text = "Izabrati oblast!";
            // 
            // tbOdgovor
            // 
            this.tbOdgovor.Location = new System.Drawing.Point(281, 146);
            this.tbOdgovor.Name = "tbOdgovor";
            this.tbOdgovor.Size = new System.Drawing.Size(100, 20);
            this.tbOdgovor.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sabiranjeOduzimanjeToolStripMenuItem,
            this.oduzimanjeToolStripMenuItem,
            this.množenjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sabiranjeOduzimanjeToolStripMenuItem
            // 
            this.sabiranjeOduzimanjeToolStripMenuItem.Name = "sabiranjeOduzimanjeToolStripMenuItem";
            this.sabiranjeOduzimanjeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.sabiranjeOduzimanjeToolStripMenuItem.Text = "Sabiranje";
            this.sabiranjeOduzimanjeToolStripMenuItem.Click += new System.EventHandler(this.sabiranjeOduzimanjeToolStripMenuItem_Click);
            // 
            // oduzimanjeToolStripMenuItem
            // 
            this.oduzimanjeToolStripMenuItem.Name = "oduzimanjeToolStripMenuItem";
            this.oduzimanjeToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.oduzimanjeToolStripMenuItem.Text = "Oduzimanje";
            this.oduzimanjeToolStripMenuItem.Click += new System.EventHandler(this.oduzimanjeToolStripMenuItem_Click);
            // 
            // tbOd
            // 
            this.tbOd.Location = new System.Drawing.Point(69, 91);
            this.tbOd.Name = "tbOd";
            this.tbOd.Size = new System.Drawing.Size(29, 26);
            this.tbOd.TabIndex = 3;
            // 
            // tbDo
            // 
            this.tbDo.Location = new System.Drawing.Point(158, 91);
            this.tbDo.Name = "tbDo";
            this.tbDo.Size = new System.Drawing.Size(29, 26);
            this.tbDo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "do:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbOd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(201, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raspon brojevnih vrednosti:";
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(293, 172);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(75, 23);
            this.bEnter.TabIndex = 8;
            this.bEnter.Text = "Potvrda";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // bEnterOduz
            // 
            this.bEnterOduz.Location = new System.Drawing.Point(293, 172);
            this.bEnterOduz.Name = "bEnterOduz";
            this.bEnterOduz.Size = new System.Drawing.Size(75, 23);
            this.bEnterOduz.TabIndex = 9;
            this.bEnterOduz.Text = "Potvrda";
            this.bEnterOduz.UseVisualStyleBackColor = true;
            this.bEnterOduz.Click += new System.EventHandler(this.bEnterOduz_Click);
            // 
            // bEnterMnoz
            // 
            this.bEnterMnoz.Location = new System.Drawing.Point(293, 172);
            this.bEnterMnoz.Name = "bEnterMnoz";
            this.bEnterMnoz.Size = new System.Drawing.Size(75, 23);
            this.bEnterMnoz.TabIndex = 10;
            this.bEnterMnoz.Text = "Potvrda";
            this.bEnterMnoz.UseVisualStyleBackColor = true;
            this.bEnterMnoz.Click += new System.EventHandler(this.bEnterMnoz_Click);
            // 
            // množenjeToolStripMenuItem
            // 
            this.množenjeToolStripMenuItem.Name = "množenjeToolStripMenuItem";
            this.množenjeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.množenjeToolStripMenuItem.Text = "Množenje";
            this.množenjeToolStripMenuItem.Click += new System.EventHandler(this.množenjeToolStripMenuItem_Click);
            // 
            // lNapomena
            // 
            this.lNapomena.AutoSize = true;
            this.lNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNapomena.Location = new System.Drawing.Point(125, 222);
            this.lNapomena.Name = "lNapomena";
            this.lNapomena.Size = new System.Drawing.Size(404, 20);
            this.lNapomena.TabIndex = 11;
            this.lNapomena.Text = "Napomena: uneti raspon brojeva u celobrojnom formatu!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 470);
            this.Controls.Add(this.lNapomena);
            this.Controls.Add(this.bEnterMnoz);
            this.Controls.Add(this.bEnterOduz);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbOdgovor);
            this.Controls.Add(this.lZad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lZad;
        private System.Windows.Forms.TextBox tbOdgovor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sabiranjeOduzimanjeToolStripMenuItem;
        private System.Windows.Forms.TextBox tbOd;
        private System.Windows.Forms.TextBox tbDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.ToolStripMenuItem oduzimanjeToolStripMenuItem;
        private System.Windows.Forms.Button bEnterOduz;
        private System.Windows.Forms.Button bEnterMnoz;
        private System.Windows.Forms.ToolStripMenuItem množenjeToolStripMenuItem;
        private System.Windows.Forms.Label lNapomena;
    }
}

