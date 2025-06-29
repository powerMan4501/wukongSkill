using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[SecurityCritical]
[CLSCompliant(false)]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
{
	public override IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			lock (this)
			{
				if (InternalProperties == null)
				{
					InternalProperties = new Hashtable();
				}
				if (ExternalProperties == null)
				{
					ExternalProperties = new CRMDictionary(this, InternalProperties);
				}
				return ExternalProperties;
			}
		}
	}

	public ConstructionResponse(Header[] h, IMethodCallMessage mcm)
		: base(h, mcm)
	{
	}

	internal ConstructionResponse(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
