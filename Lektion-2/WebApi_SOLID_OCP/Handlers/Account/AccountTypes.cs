using WebApi_SOLID_OCP.Models.Account;

namespace WebApi_SOLID_OCP.Handlers.Account
{
    public static class AccountTypes
    {
        public static IAccountModel CreateAccountModel(int accountTypeId)
        {
            IAccountModel account;

            switch (accountTypeId)
            {
                case 1:
                    account = new AdminAccountModel();
                    break;

                case 2:
                    account = new ProgramManagerAccountModel();
                    break;

                default:
                    account = new UserAccountModel();
                    break;
            }

            return account;
        }

    }
}
