using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

namespace System.ComponentModel.Design;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class DesigntimeLicenseContextSerializer
{
	private DesigntimeLicenseContextSerializer()
	{
	}

	public static void Serialize(Stream o, string cryptoKey, DesigntimeLicenseContext context)
	{
		IFormatter formatter = new BinaryFormatter();
		formatter.Serialize(o, new object[2] { cryptoKey, context.savedLicenseKeys });
	}

	internal static void Deserialize(Stream o, string cryptoKey, RuntimeLicenseContext context)
	{
		IFormatter formatter = new BinaryFormatter();
		object obj = formatter.Deserialize(o);
		if (obj is object[])
		{
			object[] array = (object[])obj;
			if (array[0] is string && (string)array[0] == cryptoKey)
			{
				context.savedLicenseKeys = (Hashtable)array[1];
			}
		}
	}
}
