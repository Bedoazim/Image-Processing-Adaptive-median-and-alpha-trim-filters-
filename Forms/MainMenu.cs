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
                int maxWindowSize=int.Parse(medianMaxWindowSize.Text);
                ImageOperations.DisplayImage(imageMatrix = Filters.AdaptiveMedianFilter.ImageFiltering(maxWindowSize, medianCountingSort.Checked, imageMatrix)
, pictureBox1);
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
                ImageOperations.DisplayImage(imageMatrix = Filters.AlphaTrimMeanFilter.ImageFiltering(windowSize, trimValue, meanCountingSort.Checked, imageMatrix), pictureBox1);
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
            int maxWindowSize = int.Parse(medianMaxWindowSize.Text);
            int size = ((maxWindowSize - 3) / 2) + 2;
            double[] windowSizes = new double[size];
            double[] quickSortTime = new double[size];
            double[] countSortTime = new double[size];
            int index = 1;
            windowSizes[0] = quickSortTime[0] = countSortTime[0] = 0;
            for (int i = 3; i <= maxWindowSize; i += 2)
            {
                windowSizes[index] = i;
                double timeBefore = System.Environment.TickCount;
                byte[,] test = Filters.AdaptiveMedianFilter.ImageFiltering(maxWindowSize, true, imageMatrix);
                double totalTime = (System.Environment.TickCount - timeBefore);
                countSortTime[index] = totalTime;
                timeBefore = System.Environment.TickCount;
                test = Filters.AdaptiveMedianFilter.ImageFiltering(maxWindowSize, false, imageMatrix);
                totalTime = (System.Environment.TickCount - timeBefore);
                quickSortTime[index] = totalTime;
                index++;
            }

            ZGraph ZGF = new ZGraph("Adaptive Median filter Graph", "Window Size", "Time in ms");
            ZGF.add_curve("Time of Quick Sort", windowSizes, quickSortTime, Color.Red);
            ZGF.add_curve("Time of Counting Sort", windowSizes, countSortTime, Color.Blue);
            ZGF.Show();
        }

        private void meanGraph_Click(object sender, EventArgs e)
        {
            int maxWindowSize = int.Parse(meanWindowSize.Text);
            int trimValue= int.Parse(meanTrimValue.Text);
            int size = ((maxWindowSize - 3) / 2) + 2;
            double[] windowSizes = new double[size];
            double[] selectingKthElementTime = new double[size];
            double[] countSortTime = new double[size];
            int index = 1;
            windowSizes[0] = selectingKthElementTime[0] = countSortTime[0] = 0;
            double timeBefore, totalTime;
            for (int i = 3; i <= maxWindowSize; i += 2)
            {
                windowSizes[index] = i;
                timeBefore = System.Environment.TickCount;
                Filters.AlphaTrimMeanFilter.ImageFiltering(maxWindowSize, trimValue, true, imageMatrix);
                totalTime = (System.Environment.TickCount - timeBefore);
                countSortTime[index] = totalTime;
                timeBefore = System.Environment.TickCount;
                Filters.AlphaTrimMeanFilter.ImageFiltering(maxWindowSize,trimValue, false, imageMatrix);
                totalTime = (System.Environment.TickCount - timeBefore);
                selectingKthElementTime[index] = totalTime;
                index++;
            }


            ZGraph ZGF = new ZGraph("Alpha-Trim Mean filter Graph", "Window Size", "Time in ms");
            ZGF.add_curve("Time of Selecting Kth Elements", windowSizes, selectingKthElementTime, Color.Red);
            ZGF.add_curve("Time of Counting Sort", windowSizes, countSortTime, Color.Blue);
            ZGF.Show();
        }
    }
}
