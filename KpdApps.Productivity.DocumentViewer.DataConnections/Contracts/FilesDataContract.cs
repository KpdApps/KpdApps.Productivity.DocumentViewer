using System;
using System.Collections.Generic;
using System.Text;

namespace KpdApps.Productivity.DocumentViewer.DataConnections.Contracts
{
    public class FilesDataContract : List<FileDataContract>
    {
        public FilesDataContract()
            : base()
        {

        }

        public FilesDataContract(IEnumerable<FileDataContract> fileData)
            : base(fileData)
        {

        }
    }
}
