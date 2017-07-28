using System;

namespace ChainOfResponsibilityV1.Common
{
    public class Employee : IExpenseApprover
    {
        private readonly Decimal approvalLimitLocal;

        public Employee(string name, Decimal approvalLimit)
        {
            this.Name = name;
            approvalLimitLocal = approvalLimit;
        }

        public string Name { get; private set; }

        public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > approvalLimitLocal 
                ? ApprovalResponse.BeyondApprovalLimit 
                : ApprovalResponse.Approved;
        }
    }
}
