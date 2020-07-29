using System;
using System.Collections.Generic;
using System.Text;

namespace Finance.Infra.Data2.ClassLibraryCore
{
    public static class ConnectionString
    {
     
        //sql server
        public const string GetConnectionString = "Server=DESKTOP-LBTN8H4;Database=PaymentDetailDB;Trusted_Connection=True;";

        //Note: this is the command run in Package manager console
        //Scaffold-DbContext "Server=DESKTOP-LBTN8H4;Database=PaymentDetailDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir DBModels
    }
}
