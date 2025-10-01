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
        public static void LoadChildForm(Form childForm, Form parentForm)
        {
            foreach (Form currentForm in parentForm.MdiChildren)
            {
                if (currentForm.GetType() == parentForm.GetType())
                {
                    currentForm.Focus();
                    return;
                }
            }

            childForm.MdiParent = parentForm;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }
    }
}
