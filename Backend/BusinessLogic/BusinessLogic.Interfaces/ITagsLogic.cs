using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogic.Entities;


namespace BusinessLogic.Interfaces
{
    public interface ITagsLogic
    {
        DocumentTag CreateTag(DocumentTag newTag);
        bool DeleteTag(int id);
        ICollection<DocumentTag> GetTags();
        DocumentTag UpdateTag(int id, DocumentTag tag);




    }
}
