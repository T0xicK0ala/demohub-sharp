//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DemoHub.Domain.Entities
//{
//    /// <Summary>
//    /// 1. Required properties for Subscription/Redemption/Switch orders and order confirmations.
//    /// 2. Switch order, if values are the same for redemption and subscription legs, then they will be provided at the parent level, if they are different then they are provided at child level.
//    /// 3. The relationship with CTNTransaction is 1:1.
//    /// </Summary>
//    public class CTNInvestmentAccountDetail
//    {
//        public string AccountID { get; set; }
//        public string AccountDesignation { get; set; }
//        public string AgentCode { get; set; }
//    }
//}
