//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACarForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarsForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarsForm()
        {
            this.RentalForm = new HashSet<RentalForm>();
        }
    
        public int CarsFormId { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public Nullable<int> CarYear { get; set; }
        public Nullable<int> CarKm { get; set; }
        public string CarDamagedParts { get; set; }
        public Nullable<int> AppUserFormId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual AppUserForm AppUserForm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentalForm> RentalForm { get; set; }
    }
}
