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

        Correspondent Create(Correspondent correspondent);

        bool Delete(int id);

        ICollection<Correspondent> GetAll();

        Correspondent Update(int id, Correspondent correspondent);

    }
}