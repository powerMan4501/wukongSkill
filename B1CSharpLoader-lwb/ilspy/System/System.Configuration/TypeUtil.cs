using System.Security.Permissions;

namespace System.Configuration;

internal static class TypeUtil
{
	[ReflectionPermission(SecurityAction.Assert, Flags = ReflectionPermissionFlag.MemberAccess)]
	internal static object CreateInstanceWithReflectionPermission(string typeString)
	{
		Type type = Type.GetType(typeString, throwOnError: true);
		return Activator.CreateInstance(type, nonPublic: true);
	}
}
