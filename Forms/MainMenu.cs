using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using System.Windows.Forms;
using Algorithms_Project.Filters;
using Algorithms_Project.graph;
using Algorithms_Project.Forms;

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
        byte[,] imageMatrix;
        private void openImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string OpenedFilePath = openFileDialog1.FileName;
                imageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(imageMatrix, pictureBox2);
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
                int maxWindowSize = int.Parse(medianMaxWindowSize.Text);
                if (pictureBox2.Image == null)
                {
                    MessageBox.Show("Please insert image!");
                }
                else if (maxWindowSize < 3)
                {
                    MessageBox.Show("Please enter valid window size!");
                }
                else
                {
                    ImageOperations.DisplayImage(imageMatrix = Filters.AdaptiveMedianFilter.ImageFiltering(maxWindowSize, medianCountingSort.Checked, imageMatrix), pictureBox1);
                }
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
                if (pictureBox2.Image == null)
                {
                    MessageBox.Show("Please insert image!");
                }
                else if (windowSize < 3)
                {
                    MessageBox.Show("Please enter valid window size!");
                }
                else if ((trimValue * 2) >= (windowSize * windowSize))
                {
                    MessageBox.Show("Please enter valid trim value!");
                }
                else
                {
                    ImageOperations.DisplayImage(imageMatrix = Filters.AlphaTrimMeanFilter.ImageFiltering(windowSize, trimValue, meanCountingSort.Checked, imageMatrix), pictureBox1);
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void meanWindowSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void medianGraph_Click(object sender, EventArgs e)
        {
            if (medianMaxWindowSize.Text.Length == 0){
                MessageBox.Show("Please enter the window size!");
            }
            else {
                int maxWindowSize = int.Parse(medianMaxWindowSize.Text);
                if (pictureBox2.Image == null)
                {
                    MessageBox.Show("Please insert image!");
                }
                else if (maxWindowSize < 3)
                {
                    MessageBox.Show("Please enter valid window size!");
                }
                else
                {
                    byte[,] imageMatrix1 = imageMatrix;
                    byte[,] imageMatrix2 = imageMatrix;
                    double[] windowSizes = Algorithms_Project.Filters.ImageOperations.constructingArrayOfWindowSizes(maxWindowSize);

                    ZGraph ZGF = new ZGraph("Adaptive Median filter Graph", "Window Size", "Time in ms");
                    ZGF.add_curve("Time of Quick Sort", windowSizes, Filters.AdaptiveMedianFilter.getTimeForGraph(maxWindowSize, false, imageMatrix1), Color.Red);
                    ZGF.add_curve("Time of Counting Sort", windowSizes, Filters.AdaptiveMedianFilter.getTimeForGraph(maxWindowSize, true, imageMatrix2), Color.Blue);
                    ZGF.Show();
                }
            }
            
        }

        private void meanGraph_Click(object sender, EventArgs e)
        {
            if (meanWindowSize.Text.Length == 0)
            {
                MessageBox.Show("Please enter the window size!");
            }
            else if (meanTrimValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter the trim value!");
            }
            else
            {
                int maxWindowSize = int.Parse(meanWindowSize.Text);
                int trimValue = int.Parse(meanTrimValue.Text);
                int width = Algorithms_Project.Filters.ImageOperations.GetWidth(imageMatrix);
                int height = Algorithms_Project.Filters.ImageOperations.GetHeight(imageMatrix);

                if (pictureBox2.Image == null)
                {
                    MessageBox.Show("Please insert image!");
                }
                else if (maxWindowSize < 3 || maxWindowSize > Math.Min(height,width))
                {
                    MessageBox.Show("Please enter valid window size!");
                }
                else if ((trimValue * 2) >= (maxWindowSize * maxWindowSize))
                {
                    MessageBox.Show("Please enter valid trim value!");
                }
                else
                {
                    byte[,] imageMatrix1 = imageMatrix;
                    byte[,] imageMatrix2 = imageMatrix;
                    double[] windowSizes = Algorithms_Project.Filters.ImageOperations.constructingArrayOfWindowSizes(maxWindowSize);

                    ZGraph ZGF = new ZGraph("Alpha-Trim Mean filter Graph", "Window Size", "Time in ms");
                    ZGF.add_curve("Time of Selecting Kth Elements", windowSizes, Algorithms_Project.Filters.AlphaTrimMeanFilter.getTimeForGraph(maxWindowSize, trimValue, false, imageMatrix1), Color.Red);
                    ZGF.add_curve("Time of Counting Sort", windowSizes, Algorithms_Project.Filters.AlphaTrimMeanFilter.getTimeForGraph(maxWindowSize, trimValue, true, imageMatrix2), Color.Blue);
                    ZGF.Show();
                }
            }
            
        }
    }
}
