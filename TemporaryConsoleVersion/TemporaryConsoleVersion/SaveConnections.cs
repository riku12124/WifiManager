using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TemporaryConsoleVersion
{
	 class SaveConnections
	 {
		  /*
		   * Save features required:
		   *		 Save SSID
		   *		 Save Mac address
		   *		 Save if key required
		   *			  if required, save Key (encrypt first)
		   *		 Save salt somehow. (make the Mac address the salt?)
		   *		 
		   *	Open features required:
		   *		 Load all saved connections
		   */

		  //Constants for the save location and directory
		  private const string directoryName = @"data";
		  private const string logPath = @"data\\log.log";
		  private const string connectionPath = @"data\\connectionData.dat";
		  private const string connectionBackupPath = @"data\\connectionData.bak";

		  private bool connectionPathExists; //If the file exists

		  private List<string> savedConnections;

		  public SaveConnections()
		  {
				savedConnections = new List<string>();
				connectionPathExists = false;

				createDirectoriesAndFiles();
				loadConnectionData();
		  }

		  /// <summary>
		  /// Create the data directory, and create all files.
		  /// Files created include: log.log, connectionData.dat, connectionData.bak
		  /// </summary>
		  private void createDirectoriesAndFiles()
		  {
				try
				{
					 //Check if directory exists, if not create it.
					 if(!Directory.Exists(directoryName))
					 {
						  DirectoryInfo di = Directory.CreateDirectory(directoryName);
					 }

					 //Check if log.log exists, if not create it.
					 if(!File.Exists(logPath))
					 {
						  File.Create(logPath).Dispose();
						  using(StreamWriter log = File.AppendText(logPath))
						  {
								log.WriteLine("{0}: Log did not exist. Log now created.", DateTime.Now);
						  }
					 }

					 //Check if connectionData.dat exists, if not create it.
					 if(!File.Exists(connectionPath))
					 {
						  File.Create(connectionPath).Dispose();
						  using(StreamWriter log = File.AppendText(logPath))
						  {
								log.WriteLine("{0}: connectionData.dat did not exist. connectionData.dat now created.", DateTime.Now);
						  }
						  connectionPathExists = false;
					 } else
					 {
						  connectionPathExists = true;
					 }

					 //Check if connectionData.bak exists, if not create it.
					 if(!File.Exists(connectionBackupPath))
					 {
						  File.Create(connectionBackupPath).Dispose();
						  using(StreamWriter log = File.AppendText(logPath))
						  {
								log.WriteLine("{0}: connectionData.bak did not exist. connectionData.bak now created.", DateTime.Now);
						  }
					 }

				} catch (Exception ex)
				{
					 //TODO: write proper exception handling.
					 Console.WriteLine("Unhandled Exception.\n{0}", ex.Message);
				}
		  }

		  /// <summary>
		  /// Load data into a list. Information about the contents are provided in \data\log.log when the application is run.
		  /// </summary>
		  private void loadConnectionData()
		  {
				int count = 0;
				foreach(string record in File.ReadLines(connectionPath))
				{
					 savedConnections.Add(record);
					 count++;
				}
				using(StreamWriter log = File.AppendText(logPath))
				{
					 log.WriteLine("{0}: {1} connection's logged within connectionData.dat",DateTime.Now, count);
				}
				foreach(string record in savedConnections)
				{
					 Console.WriteLine(record);
				}
				Console.WriteLine("Done writing");
		  }
	 }
}
