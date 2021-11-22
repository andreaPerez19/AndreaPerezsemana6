using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AndreaPerezsemana6
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
    }
}
