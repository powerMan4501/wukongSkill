using System.Dynamic;
using System.Reflection;

namespace System.Runtime.CompilerServices;

[global::__DynamicallyInvokable]
public static class CallSiteHelpers
{
	private static Type _knownNonDynamicMethodType = typeof(object).GetMethod("ToString").GetType();

	[global::__DynamicallyInvokable]
	public static bool IsInternalFrame(MethodBase mb)
	{
		if (mb.Name == "CallSite.Target" && mb.GetType() != _knownNonDynamicMethodType)
		{
			return true;
		}
		if (mb.DeclaringType == typeof(UpdateDelegates))
		{
			return true;
		}
		return false;
	}
}
