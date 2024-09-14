namespace lecture2_fateh_motaher_abdoh_saleh
{
    partial class calculatore
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
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbresult = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(157, 42);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(100, 24);
            this.txtb1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(12, 31);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(100, 24);
            this.txtb2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "العدد الاول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "العدد الثاني";
            // 
            // txtbresult
            // 
            this.txtbresult.Location = new System.Drawing.Point(129, 102);
            this.txtbresult.Name = "txtbresult";
            this.txtbresult.Size = new System.Drawing.Size(100, 24);
            this.txtbresult.TabIndex = 5;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(173, 82);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(38, 17);
            this.lb3.TabIndex = 6;
            this.lb3.Text = "الناتج";
            // 
            // calculatore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.txtbresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.Name = "calculatore";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbresult;
        private System.Windows.Forms.Label lb3;
    }
}

