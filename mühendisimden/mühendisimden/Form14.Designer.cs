
namespace mühendisimden
{
    partial class Form14
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ARA = new System.Windows.Forms.Button();
            this.LİSTELE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Red;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(594, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // ARA
            // 
            this.ARA.BackColor = System.Drawing.Color.Red;
            this.ARA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ARA.Location = new System.Drawing.Point(350, 449);
            this.ARA.Name = "ARA";
            this.ARA.Size = new System.Drawing.Size(178, 48);
            this.ARA.TabIndex = 1;
            this.ARA.Text = "ARA";
            this.ARA.UseVisualStyleBackColor = false;
            this.ARA.Click += new System.EventHandler(this.ARA_Click);
            // 
            // LİSTELE
            // 
            this.LİSTELE.BackColor = System.Drawing.Color.Red;
            this.LİSTELE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LİSTELE.Location = new System.Drawing.Point(554, 449);
            this.LİSTELE.Name = "LİSTELE";
            this.LİSTELE.Size = new System.Drawing.Size(178, 48);
            this.LİSTELE.TabIndex = 2;
            this.LİSTELE.Text = "LİSTELE";
            this.LİSTELE.UseVisualStyleBackColor = false;
            this.LİSTELE.Click += new System.EventHandler(this.LİSTELE_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(438, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(356, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "PLAKA";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LİSTELE);
            this.Controls.Add(this.ARA);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form14";
            this.Text = "SERVİS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ARA;
        private System.Windows.Forms.Button LİSTELE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}