﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalProject.Models
{
    public class BankAccountTransactionModel
    {
        public int BankAccountId { get; set; }
        public int TransactionId { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}