﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities
{
    public partial class SchedulerManagerView
    {
        public int Id { get; set; }
        public string SchedulerName { get; set; }
        public string SubscriptionName { get; set; }
        public string PurchaserEmail { get; set; }
        public Guid AMPSubscriptionId { get; set; }
        public string PlanId { get; set; }
        public string Dimension { get; set; }
        public string Frequency { get; set; }
        public double Quantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? NextRunTime { get; set; }
    }
}

