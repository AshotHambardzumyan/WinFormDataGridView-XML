
namespace WinFormDataGridView_XML
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetXml = new System.Windows.Forms.Button();
            this.btnWriteXml = new System.Windows.Forms.Button();
            this.ClearXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGetXml
            // 
            this.btnGetXml.Location = new System.Drawing.Point(28, 74);
            this.btnGetXml.Name = "btnGetXml";
            this.btnGetXml.Size = new System.Drawing.Size(75, 23);
            this.btnGetXml.TabIndex = 1;
            this.btnGetXml.Text = "Read XML";
            this.btnGetXml.UseVisualStyleBackColor = true;
            this.btnGetXml.Click += new System.EventHandler(this.btnGetXml_Click);
            // 
            // btnWriteXml
            // 
            this.btnWriteXml.Location = new System.Drawing.Point(362, 74);
            this.btnWriteXml.Name = "btnWriteXml";
            this.btnWriteXml.Size = new System.Drawing.Size(75, 23);
            this.btnWriteXml.TabIndex = 2;
            this.btnWriteXml.Text = "Write XML";
            this.btnWriteXml.UseVisualStyleBackColor = true;
            this.btnWriteXml.Click += new System.EventHandler(this.btnWriteXml_Click);
            // 
            // ClearXml
            // 
            this.ClearXml.Location = new System.Drawing.Point(677, 74);
            this.ClearXml.Name = "ClearXml";
            this.ClearXml.Size = new System.Drawing.Size(75, 23);
            this.ClearXml.TabIndex = 3;
            this.ClearXml.Text = "Clear XML";
            this.ClearXml.UseVisualStyleBackColor = true;
            this.ClearXml.Click += new System.EventHandler(this.ClearXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearXml);
            this.Controls.Add(this.btnWriteXml);
            this.Controls.Add(this.btnGetXml);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetXml;
        private System.Windows.Forms.Button btnWriteXml;
        private System.Windows.Forms.Button ClearXml;
    }
}

