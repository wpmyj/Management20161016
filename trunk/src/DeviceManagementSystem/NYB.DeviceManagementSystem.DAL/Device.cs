//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NYB.DeviceManagementSystem.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Device
    {
        public Device()
        {
            this.RepairRecord = new HashSet<RepairRecord>();
            this.MaintainRecord = new HashSet<MaintainRecord>();
        }
    
        public string ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string DeviceTypeID { get; set; }
        public string ManufacturerID { get; set; }
        public string SupplierID { get; set; }
        public Nullable<System.DateTime> ProductDate { get; set; }
        public Nullable<System.DateTime> MaintainDate { get; set; }
        public string ProjectID { get; set; }
        public bool IsValid { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateUserID { get; set; }
    
        public virtual DeviceType DeviceType { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<RepairRecord> RepairRecord { get; set; }
        public virtual ICollection<MaintainRecord> MaintainRecord { get; set; }
    }
}
