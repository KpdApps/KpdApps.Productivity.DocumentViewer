using KpdApps.Productivity.DocumentViewer.DataConnections.Contracts;
using KpdApps.Productivity.DocumentViewer.DataConnections.Interfaces;
using System;

namespace KpdApps.Productivity.DocumentViewer.DataConnections
{
    public class DummyFileDataConnector : IFileDataConnector
    {
        public FilesDataContract GetFiles()
        {
            FilesDataContract files = new FilesDataContract();

            FileDataContract file1 = new FileDataContract();
            file1.Name = "test.docx";

            FileDataContract file2 = new FileDataContract();
            file2.Name = "test.pdf";

            FileDataContract file3 = new FileDataContract();
            file3.Name = "test.doc";

            files.Add(file1);
            files.Add(file2);
            files.Add(file3);

            return files;
        }
    }
}
