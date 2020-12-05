﻿using HelpBox.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Core.Repositories
{
    public interface IProductionRequestRepository:IRepository<ProductionRequest>
    {
        Task<ProductionRequest> GetWithProductionRequestByIdAsync(int ProductionRequestId);
    }
}
