using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCafe.DAO
{
    internal class menuDAO
    {
        private static menuDAO instance;
        public static menuDAO Instance
        {
            get { if (instance == null) instance = new menuDAO(); return instance; }
            private set { instance = value; }
        }
        public DataTable menus ()
        {
            string query = "select idMenu, nameMenu,price, img from Menu, imageTable where Menu.idMenu = imageTable.id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;

        }
    }
}
