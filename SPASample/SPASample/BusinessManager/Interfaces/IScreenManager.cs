using SPASample.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPASample.BusinessManager
{
    public interface IScreenManager
    {
        List<ScreenDto> GetScreens();
        ScreenDto GetScreen(int id);
    }
}
