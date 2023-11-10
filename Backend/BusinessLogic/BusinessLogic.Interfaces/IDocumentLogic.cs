using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IDocumentLogic
    {

        void CreateDocument(Document doc);
        Document GetDocument(int id);

        void UpdateDocument(Document doc);
        bool DeleteDocument(int id);

        void UploadDocument(string title);
    }
}
