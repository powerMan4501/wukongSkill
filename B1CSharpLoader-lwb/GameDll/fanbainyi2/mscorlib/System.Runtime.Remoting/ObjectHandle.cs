using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;
using System.Security;

namespace System.Runtime.Remoting;

[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
public class ObjectHandle : MarshalByRefObject, IObjectHandle
{
	private object WrappedObject;

	private ObjectHandle()
	{
	}

	public ObjectHandle(object o)
	{
		WrappedObject = o;
	}

	public object Unwrap()
	{
		return WrappedObject;
	}

	[SecurityCritical]
	public override object InitializeLifetimeService()
	{
		if (WrappedObject is MarshalByRefObject marshalByRefObject)
		{
			object obj = marshalByRefObject.InitializeLifetimeService();
			if (obj == null)
			{
				return null;
			}
		}
		return (ILease)base.InitializeLifetimeService();
	}
}
