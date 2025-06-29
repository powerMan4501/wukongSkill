using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security;

namespace System.Runtime.Remoting.Activation;

internal class RemotePropertyHolderAttribute : IContextAttribute
{
	private IList _cp;

	internal RemotePropertyHolderAttribute(IList cp)
	{
		_cp = cp;
	}

	[SecurityCritical]
	[ComVisible(true)]
	public virtual bool IsContextOK(Context ctx, IConstructionCallMessage msg)
	{
		return false;
	}

	[SecurityCritical]
	[ComVisible(true)]
	public virtual void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
	{
		for (int i = 0; i < _cp.Count; i++)
		{
			ctorMsg.ContextProperties.Add(_cp[i]);
		}
	}
}
