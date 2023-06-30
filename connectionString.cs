using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace project_TelegraphicTransfer
{
    public static class connectionString
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source=DINIL-PC;Initial Catalog=db_TTProject;Integrated Security=True;";
            }


            //"Data Source=DINIL-PC;Initial Catalog=db_TTProject;Integrated Security=True;"
            //"Data Source=192.168.100.70; Initial Catalog=db_TTProject; User Id=sa; Password=cpt@109"
            //"Data Source=DESKTOP-8S284IC;Initial Catalog=db_TTProject;User ID=sa;Password=BSvu6ZDj;"
        }
    }
}
