﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_TelegraphicTransfer
{
    public static class connectionString
    {
        public static string ConnectionString
        {
            get
            {
                //Data Source=DESKTOP-8S284IC;Initial Catalog=aviationprojectDB;Integrated Security=True
                //Data Source=DESKTOP-KHI8921;Initial Catalog=aviationProjectDB;Integrated Security=True
                //randi

                return "Data Source=DESKTOP-8S284IC;Initial Catalog=cpcProjectDB;Integrated Security=True";
            }
        }
    }
}
