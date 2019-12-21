using BLL;
using DAL;
using FiltersEdgeDetection.PrensentationLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FiltersEdgeDetection
{
    static class App
    {
        public static Bitmap originaleImage;
        public static MainForm mainForm;

        public static void ApplyFilters()
        {
            if (originaleImage != null)
            {
                ComboBox comboBoxEdge = mainForm.GetComboBoxEdge();
                ComboBox comboBoxFilters = mainForm.GetComboBoxFilters();
                Toolbox.SetFormControlsEnabled(mainForm, false);
                Bitmap resultBitmap = new Bitmap(originaleImage);

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

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
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
