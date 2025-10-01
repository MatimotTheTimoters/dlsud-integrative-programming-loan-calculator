using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator.ChildFormLoader
{
    class ChildFormLoaderHelper
    {
        public static void LoadNewUserChildForm(Form childForm)
        {
            foreach (Form currentForm in FormNewUser.ActiveForm.MdiChildren)
            {
                if (currentForm.GetType() == childForm.GetType())
                {
                    currentForm.Focus();
                    return;
                }
            }

            childForm.MdiParent = FormNewUser.ActiveForm;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }
    }
}
