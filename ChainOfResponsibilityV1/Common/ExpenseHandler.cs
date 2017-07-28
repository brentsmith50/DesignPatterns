using System;

namespace ChainOfResponsibilityV1.Common
{
    public class ExpenseHandler : IExpenseHandler
    {
        private IExpenseApprover approver;
        private IExpenseHandler next;

        public ExpenseHandler(IExpenseApprover approver)
        {
            this.approver = approver;
            this.next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            ApprovalResponse response = this.approver.ApproveExpense(expenseReport);

            if (response == ApprovalResponse.BeyondApprovalLimit)
            {
                return this.next.Approve(expenseReport);
            }

            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            this.next = next;
        }
    }
}
