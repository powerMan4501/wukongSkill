using System.Runtime.InteropServices;

namespace System.Security.Principal;

[Serializable]
[ComVisible(true)]
public enum PrincipalPolicy
{
	UnauthenticatedPrincipal,
	NoPrincipal,
	WindowsPrincipal
}
