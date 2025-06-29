using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices;

[ComVisible(true)]
public sealed class ExtensibleClassFactory
{
	private ExtensibleClassFactory()
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	public static extern void RegisterObjectCreationCallback(ObjectCreationDelegate callback);
}
