﻿using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Application.Contract.CustomerDiscount
{
   public interface ICustomerDiscountApplication
   {
       OperationResult Define(DefineCustomerDiscount command);
       OperationResult Edit(EditCustomerDiscount command);
       List<CustomerDiscountViewModel> Search(CustomerDiscountSearchModel command);
       EditCustomerDiscount GetDetails(long id);
   }
}
