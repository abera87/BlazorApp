using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASM.Shared.Model
{
    public class DatabaseTableVM
    {
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public IList<TableColumn> Columns { get; set; }
        public string RowsJSONString { get; set; }

    }
    public class TableColumn
    {
        public string Name { get; set; }
        public string TypeName { get; set; }
    }

    public enum DBTableName
    {
        Employee = 6,
        Department,
        Assets
    }
}
