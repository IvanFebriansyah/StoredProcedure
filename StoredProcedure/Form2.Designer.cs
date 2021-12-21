
namespace StoredProcedure
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txttgl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidcust = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbomenu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtidmenu = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Transaksi";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(130, 64);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(141, 20);
            this.txtno.TabIndex = 1;
            // 
            // txttgl
            // 
            this.txttgl.Location = new System.Drawing.Point(130, 90);
            this.txttgl.Name = "txttgl";
            this.txttgl.Size = new System.Drawing.Size(141, 20);
            this.txttgl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal";
            // 
            // txtidcust
            // 
            this.txtidcust.Location = new System.Drawing.Point(130, 116);
            this.txtidcust.Name = "txtidcust";
            this.txtidcust.Size = new System.Drawing.Size(141, 20);
            this.txtidcust.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nama Menu";
            // 
            // cbomenu
            // 
            this.cbomenu.FormattingEnabled = true;
            this.cbomenu.Location = new System.Drawing.Point(130, 232);
            this.cbomenu.Name = "cbomenu";
            this.cbomenu.Size = new System.Drawing.Size(141, 21);
            this.cbomenu.TabIndex = 7;
            this.cbomenu.SelectedIndexChanged += new System.EventHandler(this.cbomenu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga";
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(130, 265);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(141, 20);
            this.txtharga.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::StoredProcedure.Properties.Resources.shell32_295;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(268, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtidmenu
            // 
            this.txtidmenu.Location = new System.Drawing.Point(278, 232);
            this.txtidmenu.Name = "txtidmenu";
            this.txtidmenu.Size = new System.Drawing.Size(60, 20);
            this.txtidmenu.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(375, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Tanggal";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 434);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtidmenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbomenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidcust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttgl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contoh Trigger";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txttgl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidcust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbomenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtidmenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}