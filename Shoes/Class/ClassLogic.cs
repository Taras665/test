using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes
{
    internal class ClassLogic
    {
        
        ShoesDBDataSet.UserDataTable userDataTable;
        ShoesDBDataSetTableAdapters.UserTableAdapter userTableAdapter = new ShoesDBDataSetTableAdapters.UserTableAdapter();

        public ShoesDBDataSet.UserRow UserRowFilter(string Email, string Password)
        {
            userDataTable = userTableAdapter.GetData();
            var filterUser = userDataTable.FirstOrDefault(x => x.Email == Email && x.Password == Password);
            Program.param.userRow = filterUser; 
            return filterUser;
        }
    }
}
