﻿using Template.DAL.Repositories.Core;
using Template.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.DAL.Repositories.Abstract
{
   public interface ITemplateRepository : IBaseEntityRepository<DefaultEntitiy>
    {
        DefaultEntitiy GetSingleByName(string name);
    }
}
