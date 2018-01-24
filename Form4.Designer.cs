namespace Verkauf
{
    partial class Form4
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
            this.btRd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btE = new System.Windows.Forms.Button();
            this.txtG = new System.Windows.Forms.TextBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRd
            // 
            this.btRd.Location = new System.Drawing.Point(135, 318);
            this.btRd.Name = "btRd";
            this.btRd.Size = new System.Drawing.Size(207, 53);
            this.btRd.TabIndex = 15;
            this.btRd.Text = "Rechnung drucken";
            this.btRd.UseVisualStyleBackColor = true;
            this.btRd.Click += new System.EventHandler(this.btRd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gesamtpreis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Menge";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(12, 55);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ProduktID";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(12, 12);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(100, 20);
            this.txtPID.TabIndex = 9;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Location = new System.Drawing.Point(15, 96);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(327, 158);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProduktID";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Preis";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bezeichnung";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Menge";
            // 
            // btE
            // 
            this.btE.Location = new System.Drawing.Point(251, 15);
            this.btE.Name = "btE";
            this.btE.Size = new System.Drawing.Size(91, 56);
            this.btE.TabIndex = 18;
            this.btE.Text = "Eingabe";
            this.btE.UseVisualStyleBackColor = true;
            this.btE.Click += new System.EventHandler(this.btE_Click);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(290, 272);
            this.txtG.Name = "txtG";
            this.txtG.ReadOnly = true;
            this.txtG.Size = new System.Drawing.Size(52, 20);
            this.txtG.TabIndex = 19;
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(12, 318);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(84, 53);
            this.LogOut.TabIndex = 20;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 383);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.btE);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btRd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPID);
            this.Name = "Form4";
            this.Text = "Kassa";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btE;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Button LogOut;
    }
}