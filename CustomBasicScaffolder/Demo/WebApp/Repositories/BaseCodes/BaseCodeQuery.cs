﻿
 
                    
      
     
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

using Repository.Pattern.Repositories;
using Repository.Pattern.Ef6;
using WebApp.Models;

namespace WebApp.Repositories
{
   public class BaseCodeQuery:QueryObject<BaseCode>
    {
        public BaseCodeQuery WithAnySearch(string search)
        {
            if (!string.IsNullOrEmpty(search))
                And( x =>  x.Id.ToString().Contains(search) || x.CodeType.Contains(search) || x.Description.Contains(search) );
            return this;
        }
    }
}



