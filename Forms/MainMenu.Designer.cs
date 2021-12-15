namespace Algorithms_Project
{
    partial class mainMenu
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
            this.openImage = new System.Windows.Forms.Button();
            this.medianFilter = new System.Windows.Forms.Button();
            this.meanFilter = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maxWindow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openImage
            // 
            this.openImage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openImage.Location = new System.Drawing.Point(39, 612);
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(155, 68);
            this.openImage.TabIndex = 0;
            this.openImage.Text = "Open image";
            this.openImage.UseVisualStyleBackColor = true;
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // medianFilter
            // 
            this.medianFilter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.medianFilter.Location = new System.Drawing.Point(39, 31);
            this.medianFilter.Name = "medianFilter";
            this.medianFilter.Size = new System.Drawing.Size(155, 68);
            this.medianFilter.TabIndex = 1;
            this.medianFilter.Text = "Apply adaptive median filter";
            this.medianFilter.UseVisualStyleBackColor = true;
            this.medianFilter.Click += new System.EventHandler(this.medianFilter_Click);
            // 
            // meanFilter
            // 
            this.meanFilter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.meanFilter.Location = new System.Drawing.Point(32, 210);
            this.meanFilter.Name = "meanFilter";
            this.meanFilter.Size = new System.Drawing.Size(155, 68);
            this.meanFilter.TabIndex = 2;
            this.meanFilter.Text = "Apply alpha trim mean filter";
            this.meanFilter.UseVisualStyleBackColor = true;
            // 
            // graph
            // 
            this.graph.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.graph.Location = new System.Drawing.Point(39, 423);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(155, 68);
            this.graph.TabIndex = 3;
            this.graph.Text = "Plot graph";
            this.graph.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(410, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 640);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // maxWindow
            // 
            this.maxWindow.AccessibleName = "";
            this.maxWindow.Location = new System.Drawing.Point(221, 125);
            this.maxWindow.Name = "maxWindow";
            this.maxWindow.Size = new System.Drawing.Size(115, 22);
            this.maxWindow.TabIndex = 5;
            this.maxWindow.Tag = "max window size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max window size :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(221, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Counting sort";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(39, 168);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Quick sort";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox4.Location = new System.Drawing.Point(39, 376);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(170, 24);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Selecting Kth elements";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Window size :";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.Location = new System.Drawing.Point(221, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Tag = "max window size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Trim value :";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "";
            this.textBox2.Location = new System.Drawing.Point(221, 338);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.Tag = "max window size";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox3.Location = new System.Drawing.Point(221, 376);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(115, 24);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Counting sort";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Max window size for median filter :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Max window size for mean filter :";
            // 
            // textBox3
            // 
            this.textBox3.AccessibleName = "";
            this.textBox3.Location = new System.Drawing.Point(321, 511);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(62, 22);
            this.textBox3.TabIndex = 18;
            this.textBox3.Tag = "max window size";
            // 
            // textBox4
            // 
            this.textBox4.AccessibleName = "";
            this.textBox4.Location = new System.Drawing.Point(321, 556);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(62, 22);
            this.textBox4.TabIndex = 19;
            this.textBox4.Tag = "max window size";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 711);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxWindow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.meanFilter);
            this.Controls.Add(this.medianFilter);
            this.Controls.Add(this.openImage);
            this.Name = "mainMenu";
            this.Text = "Image Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openImage;
        private System.Windows.Forms.Button medianFilter;
        private System.Windows.Forms.Button meanFilter;
        private System.Windows.Forms.Button graph;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox maxWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

