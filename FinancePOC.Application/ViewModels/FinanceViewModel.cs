﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancePOC.Application.ViewModels
{
    public class FinanceViewModel
    {
        [Key]
        public int PMId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string LoanHolderName { get; set; }
        [Required]
        [Column(TypeName = "varchar(16)")]
        public string LoanType { get; set; }
        [Required]
        [Column(TypeName = "varchar(8)")]
        public string LoanDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(8)")]
        public string InsuranceDate { get; set; }
    }
}
