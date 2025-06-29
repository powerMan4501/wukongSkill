namespace System.Reflection.Internal;

internal static class LightUpHelper
{
	internal static MethodInfo GetMethod(Type type, string name, params Type[] parameterTypes)
	{
		try
		{
			return type.GetRuntimeMethod(name, parameterTypes);
		}
		catch (AmbiguousMatchException)
		{
			return null;
		}
	}
}
