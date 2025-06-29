using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security.Principal;

[Serializable]
[ComVisible(false)]
public sealed class IdentityNotMappedException : SystemException
{
	private IdentityReferenceCollection unmappedIdentities;

	public IdentityReferenceCollection UnmappedIdentities
	{
		get
		{
			if (unmappedIdentities == null)
			{
				unmappedIdentities = new IdentityReferenceCollection();
			}
			return unmappedIdentities;
		}
	}

	public IdentityNotMappedException()
		: base(Environment.GetResourceString("IdentityReference_IdentityNotMapped"))
	{
	}

	public IdentityNotMappedException(string message)
		: base(message)
	{
	}

	public IdentityNotMappedException(string message, Exception inner)
		: base(message, inner)
	{
	}

	internal IdentityNotMappedException(string message, IdentityReferenceCollection unmappedIdentities)
		: this(message)
	{
		this.unmappedIdentities = unmappedIdentities;
	}

	internal IdentityNotMappedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		base.GetObjectData(serializationInfo, streamingContext);
	}
}
