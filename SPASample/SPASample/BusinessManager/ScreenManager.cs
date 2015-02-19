using SPASample.DAO;
using SPASample.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPASample.BusinessManager
{
    public class ScreenManager : IScreenManager
    {
        private readonly IScreenDAO _screenDAO;

        public ScreenManager()
            : this(new ScreenDAO())
        {

        }
        public ScreenManager(IScreenDAO screenDAO)
        {
            _screenDAO = screenDAO;
        }

        public List<ScreenDto> GetScreens()
        {
            return _screenDAO.Get().Select(x => new ScreenDto { ID = x.ID, Name = x.Name, System = ((ScreenSystem)x.System).ToString(), Title = x.Title, }).ToList();
        }

        public ScreenDto GetScreen(int id)
        {
            var dbScreen = _screenDAO.Get(id);
            ScreenDto screen = new ScreenDto
            {
                ID = dbScreen.ID,
                Name = dbScreen.Name,
                System = ((ScreenSystem)dbScreen.System).ToString(),
                Title = dbScreen.Title,
                Fields = dbScreen.Field.Select(f => new FieldDto { ID = f.ID, Name = f.Name, Caption = f.Caption, Status = ((FieldStatus)f.Status).ToString(), Tooltip = f.Tooltip }).ToList()
            };

            return screen;
        }
    }
}