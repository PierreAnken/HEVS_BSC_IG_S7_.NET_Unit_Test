using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersEdgeDetection.Classes
{
    public static class Toolbox
    {
        public static void SetFormControlsEnabled(Form form, bool enabled) {
            foreach (Control control in form.Controls)
                control.Enabled = enabled;
        }
    }
}
