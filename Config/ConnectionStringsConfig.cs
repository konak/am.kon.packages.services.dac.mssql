using System;
namespace am.kon.packages.services.dac.mssql.Config
{
	/// <summary>
	/// Class to be used to get settings for available connection strings of databases
	/// </summary>
	public class ConnectionStringsConfig : Dictionary<string, string>
	{
        /// <summary>
        /// Default section name in configuration file
        /// </summary>
        public const string SectionDefaultName = "ConnectionStrings";
	}
}

