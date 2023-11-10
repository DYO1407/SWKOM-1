using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IDocmentTypeLogic
    {

        DocumentType CreateDocumentType(DocumentType newDocumentType);
        bool DeleteDocumentType(int id);

        ICollection<DocumentType> GetDocumentTypes();
        DocumentType UpdateDocumentType(int id, DocumentType documentType);









    }
}
