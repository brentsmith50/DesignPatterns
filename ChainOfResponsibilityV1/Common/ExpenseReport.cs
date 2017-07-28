using System;

namespace ChainOfResponsibilityV1.Common
{
    public class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(Decimal total)
        {
            Total = total;
        }

        public Decimal Total { get; private set; }
    }
}
