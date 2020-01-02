using BLL;
using DAL;
using PL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FiltersEdgeDetection
{
    static class App
    {
        private static Bitmap originalBitmap, resultBitmap;
        public static MainForm mainForm;
        public static ImageManagement imageManagement = new ImageManagement();


        public static Bitmap GetOriginalBitmap()
        {
            return originalBitmap;
        }
        public static Bitmap GetResultBitmap()
        {
            return resultBitmap;
        }

        public static void SetOriginalBitmap(Bitmap newOriginalBitmap)
        {
            originalBitmap = newOriginalBitmap;
        }
        public static void SetResultBitmap(Bitmap newResultBitmap)
        {
            resultBitmap = newResultBitmap;
        }

        public static void ApplyFilters()
        {
            if (originalBitmap != null)
            {
                ComboBox comboBoxEdge = mainForm.GetComboBoxEdge();
                ComboBox comboBoxFilters = mainForm.GetComboBoxFilters();
                Toolbox.SetFormControlsEnabled(mainForm, false);
                resultBitmap = new Bitmap(originalBitmap);

                // First apply filter
                if (comboBoxFilters.SelectedItem != null)
                {
                    string selectedFilter = comboBoxFilters.SelectedItem.ToString();
                    switch (selectedFilter)
                    {
                        case "Black and White":
                            resultBitmap = ImageFilters.ApplyBlackWhite(resultBitmap);
                            break;
                        case "Crazy Filter":
                            resultBitmap = ImageFilters.ApplyFilterCrazy(resultBitmap);
                            break;
                        case "Magic Mosaic":
                            resultBitmap = ImageFilters.ApplyFilterMagicMosaic(resultBitmap);
                            break;
                        default:
                            break;
                    }
                }
                // Then apply Edge detection
                if (comboBoxEdge.SelectedItem != null)
                {
                    string selectedEdgeDetection = comboBoxEdge.SelectedItem.ToString();
                    switch (selectedEdgeDetection)
                    {
                        case "Laplacian 3x3":
                            resultBitmap = ExtBitmap.LaplacianFilter(resultBitmap, Matrix.Laplacian3x3);
                            break;
                        case "Prewitt":
                            resultBitmap = ExtBitmap.DoubleMatrixFilter(resultBitmap, Matrix.Prewitt3x3Horizontal, Matrix.Prewitt3x3Vertical);
                            break;
                        case "Kirsch":
                            resultBitmap = ExtBitmap.DoubleMatrixFilter(resultBitmap, Matrix.Kirsch3x3Horizontal, Matrix.Kirsch3x3Vertical);
                            break;
                        default:
                            break;
                    }
                }

                //finaly generate preview
                MainFormBitmapManager mainFormBitmapManager = mainForm.GetMainFormBitmapManager();
                mainFormBitmapManager.SetBitmap(resultBitmap);
                Toolbox.SetFormControlsEnabled(mainForm, true);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
