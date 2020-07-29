using System;
using System.Collections.Generic;

namespace Finance.Infra.Data2.ClassLibraryCore.DBModels
{
    public partial class Finances
    {
        public int Pmid { get; set; }
        public string LoanHolderName { get; set; }
        public string LoanType { get; set; }
        public string LoanDate { get; set; }
        public string InsuranceDate { get; set; }
    }
}
