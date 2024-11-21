
namespace Serene;

public static partial class MVC
{
    public static partial class Views
    {
        public static partial class Common
        {
            public static partial class Dashboard
            {
                public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
            }
        }

        public static partial class CommonDue
        {
            public static partial class DashboardDue
            {
                public const string DashboardDueIndex = "~/Modules/CommonDue/DashboardDue/DashboardDueIndex.cshtml";
            }
        }

        public static partial class Errors
        {
            public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
            public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
        }

        public static partial class Membership
        {
            public static partial class Account
            {
                public static partial class Login
                {
                    public const string LoginPage = "~/Modules/Membership/Account/Login/LoginPage.cshtml";
                }

                public static partial class SignUp
                {
                    public const string ActivateEmail = "~/Modules/Membership/Account/SignUp/ActivateEmail.cshtml";
                    public const string SignUpPage = "~/Modules/Membership/Account/SignUp/SignUpPage.cshtml";
                }
            }
        }

        public static partial class Shared
        {
            public const string _Layout = "~/Views/Shared/_Layout.cshtml";
            public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
            public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
            public const string _Sidebar = "~/Views/Shared/_Sidebar.cshtml";
            public const string Error = "~/Views/Shared/Error.cshtml";
        }

        // Modifica: Antonio Manzara -> 21/11
        // Modificata la classe ABC in Statistiche, con relativo routing
        public static partial class Statistiche
        {
            public static partial class RisultatiAnalisi
            {
                public const string RisultatiIndex = "~/Modules/Statistiche/RisultatiAnalisi/RisultatiIndex.cshtml";
            }

            public static partial class StatisticheTabelle
            {
                public const string TabellaIndex = "~/Modules/Statistiche/StatisticheTabelle/TabellaIndex.cshtml";
            }
        }
    }
}