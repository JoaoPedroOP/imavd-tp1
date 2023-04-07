using System.Windows.Forms;

namespace IMAVD_TP1.Helpers
{
    public static class Logger
    {
        public static void WarnToLoadImage()
        {
            MessageBox.Show("Please load an image first!", "Need Image First");
        }

        public static void WarnToSelectArea()
        {
            MessageBox.Show("Please select area first!", "Crop Area");
        }
    }
}
