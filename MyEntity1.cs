using System;

namespace TomEfSample.Web.Core.Data
{
    public class MyEntity1 : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
