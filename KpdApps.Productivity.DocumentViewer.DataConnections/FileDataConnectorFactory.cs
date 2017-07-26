using KpdApps.Productivity.DocumentViewer.DataConnections.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KpdApps.Productivity.DocumentViewer.DataConnections
{
    public static class FileDataConnectorFactory
    {
        public static IFileDataConnector GetConnector(FileDataConnectorTypes type)
        {
            switch (type)
            {
                case (int)FileDataConnectorTypes.Dummy:
                    return new DummyFileDataConnector();
            }

            return new DummyFileDataConnector();
        }
    }
}
