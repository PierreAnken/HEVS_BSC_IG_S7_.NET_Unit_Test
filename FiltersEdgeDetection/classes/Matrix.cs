
namespace ImageEdgeDetection
{
    public static class Matrix
    {
        public static double[,] Laplacian3x3
        {
            get
            {
                return new double[,]  
                { { -1, -1, -1,  }, 
                  { -1,  8, -1,  }, 
                  { -1, -1, -1,  }, };
            }
        }

        public static double[,] Prewitt3x3Horizontal
        {
            get
            {
                return new double[,] 
                { { -1,  0,  1, }, 
                  { -1,  0,  1, }, 
                  { -1,  0,  1, }, };
            }
        }

        public static double[,] Prewitt3x3Vertical
        {
            get
            {
                return new double[,] 
                { {  1,  1,  1, }, 
                  {  0,  0,  0, }, 
                  { -1, -1, -1, }, };
            }
        }


        public static double[,] Kirsch3x3Horizontal
        {
            get
            {
                return new double[,] 
                { {  5,  5,  5, }, 
                  { -3,  0, -3, }, 
                  { -3, -3, -3, }, };
            }
        }

        public static double[,] Kirsch3x3Vertical
        {
            get
            {
                return new double[,] 
                { {  5, -3, -3, }, 
                  {  5,  0, -3, }, 
                  {  5, -3, -3, }, };
            }
        }
    }
}
