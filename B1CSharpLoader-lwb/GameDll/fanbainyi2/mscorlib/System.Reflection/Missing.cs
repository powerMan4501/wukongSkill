using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class Missing : ISerializable
{
	[__DynamicallyInvokable]
	public static readonly Missing Value = new Missing();

	private Missing()
	{
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		UnitySerializationHolder.GetUnitySerializationInfo(info, this);
	}
}
