using System.Windows.Forms;

namespace BLL
{
    public static class Toolbox
    {
        public static void SetFormControlsEnabled(Form form, bool enabled) {
            foreach (Control control in form.Controls)
                control.Enabled = enabled;
        }
    }
}
