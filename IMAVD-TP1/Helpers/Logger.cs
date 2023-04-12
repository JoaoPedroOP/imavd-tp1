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

        public static void AlreadyInChromaKey()
        {
            MessageBox.Show("You already are in chroma key selection!", "Chroma Key");
        }

        public static void NoChromaKeySelected()
        {
            MessageBox.Show("You need to use eyedropper first!", "Chroma Key");
        }
    }
}
