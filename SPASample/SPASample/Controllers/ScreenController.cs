using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SPASample.DAO;
using SPASample.DAO.Entities;
using SPASample.BusinessManager;
using SPASample.Dto;

namespace SPASample.Controllers
{
    public class ScreenController : ApiController
    {
        private readonly IScreenManager _screenManager;

        public ScreenController()
            : this(new ScreenManager())
        {

        }

        public ScreenController(IScreenManager screenManager)
        {
            _screenManager = screenManager;
        }

        // GET: api/Screen
        public List<ScreenDto> GetScreen()
        {
            return _screenManager.GetScreens();
        }

        // GET: api/Screen/1
        [ResponseType(typeof(ScreenDto))]
        public IHttpActionResult GetScreen(int id)
        {
            ScreenDto screen = _screenManager.GetScreen(id);
            if (screen == null)
            {
                return NotFound();
            }

            return Ok(screen);
        }
    }
}