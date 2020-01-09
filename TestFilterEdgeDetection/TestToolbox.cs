using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PL;

namespace TestToolbox
{
    [TestClass]
    public class TestToolbox
    {

        [TestMethod]
        public void TestSetFormControlsEnabled()
        {
            MainForm form = new MainForm();
            Toolbox.SetFormControlsEnabled(form, false);
            Assert.AreEqual(false, form.buttonLoadDisk.Enabled);
        }

    }
}
