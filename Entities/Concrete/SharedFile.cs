using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SharedFile : IEntity
    {
        public int Id { get; set; }
        public string RecordNo { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public bool ShareState { get; set; }
    }
}
