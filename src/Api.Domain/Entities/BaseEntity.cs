using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        private DateTime? _CreateAt;
        public DateTime? CreateAt
        {
            get { return _CreateAt; }
            set { _CreateAt = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime? UpdateAt { get; set; }

    }
}