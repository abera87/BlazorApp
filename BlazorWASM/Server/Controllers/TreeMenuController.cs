using BlazorWASM.Shared.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWASM.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TreeMenuController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TreeMenu> Get()
        {
            IList<TreeMenu> menus = new List<TreeMenu>() {
            new TreeMenu{Id=0,Name="Home",NavigationPath="/"},
            new TreeMenu{Id=1,Name="Database",ParentId=0},
            new TreeMenu{Id=2,Name="DB-1",ParentId=1},
            new TreeMenu{Id=3,Name="DB-2",ParentId=1},
            new TreeMenu{Id=4,Name="Tables",ParentId=2},
            new TreeMenu{Id=5,Name="Tables",ParentId=3},
            new TreeMenu{Id=6,Name="Employee",ParentId=4,NavigationPath="/showtabledata"},
            new TreeMenu{Id=7,Name="Department",ParentId=4,NavigationPath="/showtabledata"},
            new TreeMenu{Id=8,Name="Assets",ParentId=5,NavigationPath="/showtabledata"},
            new TreeMenu{Id=9,Name="Privilage",ParentId=0,NavigationPath="/privilage"},
            };

            return menus;
        }
    }
}
