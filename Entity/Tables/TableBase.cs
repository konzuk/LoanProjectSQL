using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using MainEntity.Tables.User;

namespace MainEntity.Tables
{
    public abstract class TableBase
    {
        
        private DateTime _createdUtcDateTime = DateTime.UtcNow;
        private DateTime _modifiedUtcDateTime = DateTime.UtcNow;
        public DateTime CreatedUtcDateTime {
            get { return _createdUtcDateTime; }
            set { _createdUtcDateTime = value; }
        }
        public DateTime ModefiedUtcDateTime {
            get { return _modifiedUtcDateTime; }
            set { _modifiedUtcDateTime = value; }
        }
        [NotMapped]
        public DateTime CreatedDateTime {
            get { return _createdUtcDateTime.ToLocalTime(); }
            set { _createdUtcDateTime = value.ToUniversalTime(); }
        }
        [NotMapped]
        public DateTime ModefiedDateTime {
            get { return _modifiedUtcDateTime.ToLocalTime() ; }
            set { _modifiedUtcDateTime = value.ToUniversalTime(); }
        }

        public int? CreatedById { get; set; }
        [ForeignKey("CreatedById"), InverseProperty("CreatedTables")]
        public abstract UserTable CreatedBy { get; set; }
        public int? ModefiedById { get; set; }
        [ForeignKey("ModefiedById"), InverseProperty("ModefiedTables")]
        public abstract UserTable ModefiedBy { get; set; }

        private const bool CanDelete = true;
        private bool _isDeleteAbleDefaultValue = CanDelete;
        [DefaultValue(CanDelete)]
        public bool IsDeleteAble {
            get { return _isDeleteAbleDefaultValue; }
            set { _isDeleteAbleDefaultValue = value; }
        }
        private const bool CanEdit = true;
        private bool _isEditAbleDefaultValue = CanEdit;
        [DefaultValue(CanEdit)]
        public bool IsEditAble {
            get { return _isEditAbleDefaultValue; }
            set { _isEditAbleDefaultValue = value; }
        }
        public bool IsHidden { get; set; }

        public virtual TableBase Clone()
        {
            return this.MemberwiseClone() as TableBase; 
        }
    }
}
