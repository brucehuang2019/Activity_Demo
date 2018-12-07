using Activity_Demo_Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Demo_Repositories.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private IDatabaseHelper _databaseHelper;

        public ActivityRepository(IDatabaseHelper databaseHelper)
        {
            this._databaseHelper = databaseHelper;
        }


    }
}
