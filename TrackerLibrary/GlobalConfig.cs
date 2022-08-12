﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if(database)
            {
                //TODO - Set up SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                //TODO - Set up Text Connector properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
