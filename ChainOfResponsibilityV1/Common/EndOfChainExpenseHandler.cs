using System;

namespace ChainOfResponsibilityV1.Common
{
    public class EndOfChainExpenseHandler : IExpenseHandler
    {
        // ALSO following Sinlgeton Pattern
        private static readonly EndOfChainExpenseHandler instance = new EndOfChainExpenseHandler();

        public EndOfChainExpenseHandler()
        {
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            return ApprovalResponse.Denied;
        }

        public static EndOfChainExpenseHandler Instance
        {
            get { return instance; }
        }

        public void RegisterNext(IExpenseHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }
    }
}
