using KpdApps.Productivity.DocumentViewer.DataConnections.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KpdApps.Productivity.DocumentViewer.DataConnections.Interfaces
{
    public interface IFileDataConnector
    {
        FilesDataContract GetFiles();
    }
}
