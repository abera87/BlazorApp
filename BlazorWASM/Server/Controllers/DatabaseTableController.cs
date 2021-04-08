using BlazorWASM.Shared.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWASM.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DatabaseTableController : ControllerBase
    {
        [HttpGet]
        [Route("{id:int}")]
        public DatabaseTableVM Get(int id)
        {
            DatabaseTableVM dbVM = new();
            dbVM.DatabaseName = "Sample Database";
            dbVM.TableName = Enum.GetName(typeof(DBTableName), id);
            DataTable dt = GetData((DBTableName)id);
            var s = JsonConvert.SerializeObject(dt);
            dbVM.RowsJSONString = s;
            dbVM.Columns = dt.Columns.Cast<DataColumn>().Select(x => new TableColumn { Name = x.ColumnName, TypeName = x.DataType.Name }).ToList();
            return dbVM;

        }

        private DataTable GetData(DBTableName tableName)
        {
            DataTable dt=default;
            switch (tableName)
            {
                case DBTableName.Employee:
                    dt = new DataTable();
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Designation", typeof(string));
                    dt.Rows.Add(1, "Name-1", "Developer");
                    dt.Rows.Add(2, "Name-2", "Developer");
                    dt.Rows.Add(3, "Name-3", "Sr. Developer");
                    dt.Rows.Add(4, "Name-4", "Sr. Developer");
                    break;

                case DBTableName.Department:
                    dt = new DataTable();
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Rows.Add(1, "Dept-1");
                    dt.Rows.Add(2, "Dept-2");
                    dt.Rows.Add(3, "Dept-3");
                    dt.Rows.Add(4, "Dept-4");
                    break;

                case DBTableName.Assets:
                    dt = new DataTable();
                    dt.Columns.Add("Id", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("ManufacturingDate", typeof(DateTime));
                    dt.Rows.Add(1, "Asset-1",DateTime.Today);
                    dt.Rows.Add(2, "Asset-2", DateTime.Today);
                    dt.Rows.Add(3, "Asset-3", DateTime.Today);
                    dt.Rows.Add(4, "Asset-4", DateTime.Today);
                    break;
            }         

            return dt;
        }       
    }
}
