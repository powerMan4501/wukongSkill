using System.Security;

namespace System.Runtime.Remoting.Messaging;

internal class SmuggledObjRef
{
	[SecurityCritical]
	private ObjRef _objRef;

	public ObjRef ObjRef
	{
		[SecurityCritical]
		get
		{
			return _objRef;
		}
	}

	[SecurityCritical]
	public SmuggledObjRef(ObjRef objRef)
	{
		_objRef = objRef;
	}
}
