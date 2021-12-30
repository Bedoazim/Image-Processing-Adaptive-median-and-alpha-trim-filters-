using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms_Project.Filters;

namespace Algorithms_Project
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        byte[,] ImageMatrix;
        private void openImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, pictureBox2);
            }
        }

        private void medianFilter_Click(object sender, EventArgs e)
        {

            if (medianMaxWindowSize.Text.Length == 0)
            {
                MessageBox.Show("Please enter the max window size!");
            }
            else if (medianCountingSort.Checked.Equals(medianQuickSort.Checked))
            {
                MessageBox.Show("Please select one sorting algorithm!");
            }
            else
            {
                int maxWindowSize=int.Parse(medianMaxWindowSize.Text);
                ImageOperations.DisplayImage(Filters.AdaptiveMedianFilter.ImageFiltering(maxWindowSize,medianCountingSort.Checked,ImageMatrix), pictureBox1);
            }

        }

        private void meanFilter_Click(object sender, EventArgs e)
        {
            if (meanWindowSize.Text.Length == 0)
            {
                MessageBox.Show("Please enter the window size!");
            }
            else if (meanTrimValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter the trim value!");
            }
            else if (meanCountingSort.Checked.Equals(meanSelectingKthElement.Checked))
            {
                MessageBox.Show("Please select one algorithm!");
            }
            else
            {
                int windowSize = int.Parse(meanWindowSize.Text);
                int trimValue = int.Parse(meanTrimValue.Text);
                byte[,] filteredImageMatrix = ImageMatrix;
                ImageOperations.DisplayImage(Filters.AlphaTrimMeanFilter.ImageFiltering(windowSize, trimValue, meanCountingSort.Checked, ImageMatrix), pictureBox1);
            }

        }

        private void graph_Click(object sender, EventArgs e)
        {
            if (medianWindowGraph.Text.Length == 0)
            {
                MessageBox.Show("Please enter the max window size for median filter!");
            }
            else if (meanWindowGraph.Text.Length == 0)
            {
                MessageBox.Show("Please enter the max window size for mean filter!");
            }
            else
            {

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
