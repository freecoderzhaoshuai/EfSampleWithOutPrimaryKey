using System;
using System.Collections.Generic;

namespace efsample
{
    public partial class OrderPoolDmsSo
    {
        public decimal? SoId { get; set; }
        public string DmsorderId { get; set; }
        public string CustomerId { get; set; }
        public string CustName { get; set; }
        public decimal? DistributorId { get; set; }
        public string DistName { get; set; }
        public string RxCustomer { get; set; }
        public int? Sph { get; set; }
        public int? Cyl { get; set; }
        public int? Eye { get; set; }
        public string MdsIndex { get; set; }
        public string MdsBrand { get; set; }
        public string MdsProductName { get; set; }
        public string RxProduct { get; set; }
        public string LogisticCode { get; set; }
        public string SkuBarcode { get; set; }
        public byte? IsNeedPurchase { get; set; }
        public DateTime? OutboundTime { get; set; }
        public int Id { get; set; }
    }
}
