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
            this.medianMaxWindowSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medianCountingSort = new System.Windows.Forms.CheckBox();
            this.medianQuickSort = new System.Windows.Forms.CheckBox();
            this.meanSelectingKthElement = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.meanWindowSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.meanTrimValue = new System.Windows.Forms.TextBox();
            this.meanCountingSort = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.medianWindowGraph = new System.Windows.Forms.TextBox();
            this.meanWindowGraph = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openImage
            // 
            this.openImage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openImage.Location = new System.Drawing.Point(74, 612);
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
            this.medianFilter.Location = new System.Drawing.Point(74, 110);
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
            this.meanFilter.Location = new System.Drawing.Point(74, 340);
            this.meanFilter.Name = "meanFilter";
            this.meanFilter.Size = new System.Drawing.Size(155, 68);
            this.meanFilter.TabIndex = 2;
            this.meanFilter.Text = "Apply alpha trim mean filter";
            this.meanFilter.UseVisualStyleBackColor = true;
            this.meanFilter.Click += new System.EventHandler(this.meanFilter_Click);
            // 
            // graph
            // 
            this.graph.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.graph.Location = new System.Drawing.Point(74, 510);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(155, 68);
            this.graph.TabIndex = 3;
            this.graph.Text = "Plot graph";
            this.graph.UseVisualStyleBackColor = true;
            this.graph.Click += new System.EventHandler(this.graph_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(410, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 649);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // medianMaxWindowSize
            // 
            this.medianMaxWindowSize.AccessibleName = "";
            this.medianMaxWindowSize.Location = new System.Drawing.Point(200, 31);
            this.medianMaxWindowSize.Name = "medianMaxWindowSize";
            this.medianMaxWindowSize.Size = new System.Drawing.Size(115, 22);
            this.medianMaxWindowSize.TabIndex = 5;
            this.medianMaxWindowSize.Tag = "max window size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max window size :";
            // 
            // medianCountingSort
            // 
            this.medianCountingSort.AutoSize = true;
            this.medianCountingSort.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.medianCountingSort.Location = new System.Drawing.Point(200, 70);
            this.medianCountingSort.Name = "medianCountingSort";
            this.medianCountingSort.Size = new System.Drawing.Size(115, 24);
            this.medianCountingSort.TabIndex = 7;
            this.medianCountingSort.Text = "Counting sort";
            this.medianCountingSort.UseVisualStyleBackColor = true;
            // 
            // medianQuickSort
            // 
            this.medianQuickSort.AutoSize = true;
            this.medianQuickSort.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medianQuickSort.Location = new System.Drawing.Point(32, 70);
            this.medianQuickSort.Name = "medianQuickSort";
            this.medianQuickSort.Size = new System.Drawing.Size(94, 24);
            this.medianQuickSort.TabIndex = 8;
            this.medianQuickSort.Text = "Quick sort";
            this.medianQuickSort.UseVisualStyleBackColor = true;
            // 
            // meanSelectingKthElement
            // 
            this.meanSelectingKthElement.AutoSize = true;
            this.meanSelectingKthElement.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.meanSelectingKthElement.Location = new System.Drawing.Point(32, 298);
            this.meanSelectingKthElement.Name = "meanSelectingKthElement";
            this.meanSelectingKthElement.Size = new System.Drawing.Size(170, 24);
            this.meanSelectingKthElement.TabIndex = 11;
            this.meanSelectingKthElement.Text = "Selecting Kth elements";
            this.meanSelectingKthElement.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Window size :";
            // 
            // meanWindowSize
            // 
            this.meanWindowSize.AccessibleName = "";
            this.meanWindowSize.Location = new System.Drawing.Point(200, 209);
            this.meanWindowSize.Name = "meanWindowSize";
            this.meanWindowSize.Size = new System.Drawing.Size(115, 22);
            this.meanWindowSize.TabIndex = 9;
            this.meanWindowSize.Tag = "max window size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Trim value :";
            // 
            // meanTrimValue
            // 
            this.meanTrimValue.AccessibleName = "";
            this.meanTrimValue.Location = new System.Drawing.Point(200, 253);
            this.meanTrimValue.Name = "meanTrimValue";
            this.meanTrimValue.Size = new System.Drawing.Size(115, 22);
            this.meanTrimValue.TabIndex = 14;
            this.meanTrimValue.Tag = "max window size";
            // 
            // meanCountingSort
            // 
            this.meanCountingSort.AutoSize = true;
            this.meanCountingSort.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.meanCountingSort.Location = new System.Drawing.Point(208, 298);
            this.meanCountingSort.Name = "meanCountingSort";
            this.meanCountingSort.Size = new System.Drawing.Size(115, 24);
            this.meanCountingSort.TabIndex = 15;
            this.meanCountingSort.Text = "Counting sort";
            this.meanCountingSort.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Max window size for median filter :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Max window size for mean filter :";
            // 
            // medianWindowGraph
            // 
            this.medianWindowGraph.AccessibleName = "";
            this.medianWindowGraph.Location = new System.Drawing.Point(321, 432);
            this.medianWindowGraph.Name = "medianWindowGraph";
            this.medianWindowGraph.Size = new System.Drawing.Size(62, 22);
            this.medianWindowGraph.TabIndex = 18;
            this.medianWindowGraph.Tag = "max window size";
            // 
            // meanWindowGraph
            // 
            this.meanWindowGraph.AccessibleName = "";
            this.meanWindowGraph.Location = new System.Drawing.Point(321, 477);
            this.meanWindowGraph.Name = "meanWindowGraph";
            this.meanWindowGraph.Size = new System.Drawing.Size(62, 22);
            this.meanWindowGraph.TabIndex = 19;
            this.meanWindowGraph.Tag = "max window size";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 711);
            this.Controls.Add(this.meanWindowGraph);
            this.Controls.Add(this.medianWindowGraph);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.meanCountingSort);
            this.Controls.Add(this.meanTrimValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.meanSelectingKthElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.meanWindowSize);
            this.Controls.Add(this.medianQuickSort);
            this.Controls.Add(this.medianCountingSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medianMaxWindowSize);
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
        private System.Windows.Forms.TextBox medianMaxWindowSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox medianCountingSort;
        private System.Windows.Forms.CheckBox medianQuickSort;
        private System.Windows.Forms.CheckBox meanSelectingKthElement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meanWindowSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox meanTrimValue;
        private System.Windows.Forms.CheckBox meanCountingSort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox medianWindowGraph;
        private System.Windows.Forms.TextBox meanWindowGraph;
    }
}

