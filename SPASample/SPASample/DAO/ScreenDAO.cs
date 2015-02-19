using SPASample.DAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPASample.DAO
{
    public class ScreenDAO : IScreenDAO
    {
        private readonly SPASampleDbContext _dbContext;

        public ScreenDAO()
        {
            this._dbContext = new SPASampleDbContext();
        }
        public IQueryable<Screen> Get()
        {
            return _dbContext.Screen;
        }

        public Screen Get(int id)
        {
            return _dbContext.Screen.Find(id);
        }
    }
}