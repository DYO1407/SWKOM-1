using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Entities
{
    public class Document
    {
        public Int32 Id { get; set; }
        public Correspondents Correspondent { get; set; }
        public  DocumentType DocumentType { get; set; }
        public Int32? StoragePath { get; set; }

        public string? Title { get; set; }
        public string? Content { get; set; }
        public List<string> Tags { get; set; } = new List<string>();

        public DateTime Created { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Added { get; set; }
        public string? ArchiveSerialNumber { get; set; }

        public string? OriginalFileName { get; set; }

        public string? ArchivedFileName { get; set; }










    }
}
