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
    
    public partial class CustomerForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerForm()
        {
            this.RentalForm = new HashSet<RentalForm>();
        }
    
        public int CustomerFormId { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> CustomerBirthday { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string CustomerFatherName { get; set; }
        public string CustomerMotherName { get; set; }
        public string CustomerJob { get; set; }
        public string CustomerDrivingLicenceType { get; set; }
        public Nullable<int> AppUserFormId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual AppUserForm AppUserForm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentalForm> RentalForm { get; set; }
    }
}
