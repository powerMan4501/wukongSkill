using System.Reflection;
using System.Reflection.Emit;

namespace System.Dynamic.Utils;

internal static class TypeExtensions
{
	private static readonly CacheDict<MethodBase, ParameterInfo[]> _ParamInfoCache = new CacheDict<MethodBase, ParameterInfo[]>(75);

	internal static Delegate CreateDelegate(this MethodInfo methodInfo, Type delegateType, object target)
	{
		DynamicMethod dynamicMethod = methodInfo as DynamicMethod;
		if (dynamicMethod != null)
		{
			return dynamicMethod.CreateDelegate(delegateType, target);
		}
		return Delegate.CreateDelegate(delegateType, target, methodInfo);
	}

	internal static Type GetReturnType(this MethodBase mi)
	{
		if (!mi.IsConstructor)
		{
			return ((MethodInfo)mi).ReturnType;
		}
		return mi.DeclaringType;
	}

	internal static ParameterInfo[] GetParametersCached(this MethodBase method)
	{
		CacheDict<MethodBase, ParameterInfo[]> paramInfoCache = _ParamInfoCache;
		if (!paramInfoCache.TryGetValue(method, out var value))
		{
			value = method.GetParameters();
			Type declaringType = method.DeclaringType;
			if (declaringType != null && declaringType.CanCache())
			{
				paramInfoCache[method] = value;
			}
		}
		return value;
	}

	internal static bool IsByRefParameter(this ParameterInfo pi)
	{
		if (pi.ParameterType.IsByRef)
		{
			return true;
		}
		return (pi.Attributes & ParameterAttributes.Out) == ParameterAttributes.Out;
	}

	internal static MethodInfo GetMethodValidated(this Type type, string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		MethodInfo method = type.GetMethod(name, bindingAttr, binder, types, modifiers);
		if (!method.MatchesArgumentTypes(types))
		{
			return null;
		}
		return method;
	}

	private static bool MatchesArgumentTypes(this MethodInfo mi, Type[] argTypes)
	{
		if (mi == null || argTypes == null)
		{
			return false;
		}
		ParameterInfo[] parameters = mi.GetParameters();
		if (parameters.Length != argTypes.Length)
		{
			return false;
		}
		for (int i = 0; i < parameters.Length; i++)
		{
			if (!TypeUtils.AreReferenceAssignable(parameters[i].ParameterType, argTypes[i]))
			{
				return false;
			}
		}
		return true;
	}
}
