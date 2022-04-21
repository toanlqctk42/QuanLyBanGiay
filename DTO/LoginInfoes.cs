namespace DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoginInfoes
    {
        public string RoleName { get; set; }

        [Key]
        public string Id { get; set; }
    }
}
