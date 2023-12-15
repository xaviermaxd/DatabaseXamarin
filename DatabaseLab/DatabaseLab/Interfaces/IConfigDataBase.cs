using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseLab.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
