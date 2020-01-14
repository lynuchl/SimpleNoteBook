using NoteBook.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteBook.logic
{
    class LogicText
    {
        DBOperation dBOperation=new DBOperation();

        public void save(string title,string context)
        {
            dBOperation.Save(title, context);
        }

        public DataTable query(string subTitle)
        {
          DataTable dataTable=  dBOperation.query(subTitle);

            return dataTable;
        }

    }
}
