using SPASample.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPASample.DAO
{
    public interface IScreenDAO
    {
        IQueryable<Screen> Get();
        Screen Get(int id);
    }
}
