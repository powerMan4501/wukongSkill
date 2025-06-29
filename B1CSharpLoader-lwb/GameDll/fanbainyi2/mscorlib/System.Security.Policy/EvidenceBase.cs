using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

namespace System.Security.Policy;

[Serializable]
[ComVisible(true)]
[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
public abstract class EvidenceBase
{
	protected EvidenceBase()
	{
		if (!GetType().IsSerializable)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Policy_EvidenceMustBeSerializable"));
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Assert, SerializationFormatter = true)]
	[PermissionSet(SecurityAction.InheritanceDemand, Unrestricted = true)]
	public virtual EvidenceBase Clone()
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.Serialize(memoryStream, this);
		memoryStream.Position = 0L;
		return binaryFormatter.Deserialize(memoryStream) as EvidenceBase;
	}
}
