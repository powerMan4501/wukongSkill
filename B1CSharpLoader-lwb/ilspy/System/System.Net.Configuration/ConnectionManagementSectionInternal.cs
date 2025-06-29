using System.Collections;
using System.Configuration;
using System.Threading;

namespace System.Net.Configuration;

internal sealed class ConnectionManagementSectionInternal
{
	private Hashtable connectionManagement;

	private static object classSyncObject;

	internal Hashtable ConnectionManagement
	{
		get
		{
			Hashtable hashtable = connectionManagement;
			if (hashtable == null)
			{
				hashtable = new Hashtable();
			}
			return hashtable;
		}
	}

	internal static object ClassSyncObject
	{
		get
		{
			if (classSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref classSyncObject, value, null);
			}
			return classSyncObject;
		}
	}

	internal ConnectionManagementSectionInternal(ConnectionManagementSection section)
	{
		if (section.ConnectionManagement.Count <= 0)
		{
			return;
		}
		connectionManagement = new Hashtable(section.ConnectionManagement.Count);
		foreach (ConnectionManagementElement item in section.ConnectionManagement)
		{
			connectionManagement[item.Address] = item.MaxConnection;
		}
	}

	internal static ConnectionManagementSectionInternal GetSection()
	{
		lock (ClassSyncObject)
		{
			if (!(System.Configuration.PrivilegedConfigurationManager.GetSection(ConfigurationStrings.ConnectionManagementSectionPath) is ConnectionManagementSection section))
			{
				return null;
			}
			return new ConnectionManagementSectionInternal(section);
		}
	}
}
