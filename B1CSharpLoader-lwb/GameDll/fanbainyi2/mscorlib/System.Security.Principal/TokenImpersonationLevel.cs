using System.Runtime.InteropServices;

namespace System.Security.Principal;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum TokenImpersonationLevel
{
	[__DynamicallyInvokable]
	None,
	[__DynamicallyInvokable]
	Anonymous,
	[__DynamicallyInvokable]
	Identification,
	[__DynamicallyInvokable]
	Impersonation,
	[__DynamicallyInvokable]
	Delegation
}
