using System.Windows.Forms;

namespace Budget_Alex
{
    public static class BindingSourceExtensions
    {
       

        public static string BudgetName(this BindingSource sender)
        {
            return ((DataEntity.Budget)sender.Current).Name;
        }

        public static double BudgetSumme(this BindingSource sender)
        {
            return ((DataEntity.Budget)sender.Current).Summe;
        }

        public static int BudgetId(this BindingSource sender)
        {
            return ((DataEntity.Budget)sender.Current).Id;
        }




    }
}
