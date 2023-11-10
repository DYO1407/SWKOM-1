using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using BusinessLogic.Entities;

namespace BusinessLogic.Interfaces
{
    public interface ICorrespondentLogic

    {

        Correspondents Create(Correspondents correspondent);

        bool Delete(int id);

        ICollection<Correspondents> GetAll();

        Correspondents Update(int id, Correspondents correspondent);

    }
}