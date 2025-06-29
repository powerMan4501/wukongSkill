using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Other;
using ILRuntime.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.CLR.Utils;

public static class Extensions
{
	[Flags]
	public enum TypeFlags
	{
		Default = 0,
		IsPrimitive = 1,
		IsByRef = 2,
		IsEnum = 4,
		IsDelegate = 8,
		IsValueType = 0x10
	}

	public static List<IType> EmptyParamList = new List<IType>();

	private static readonly Dictionary<Type, TypeFlags> typeFlags = new Dictionary<Type, TypeFlags>(new ByReferenceKeyComparer<Type>());

	public static List<IType> GetParamList(this MethodReference def, ILRuntime.Runtime.Enviorment.AppDomain appdomain, IType contextType, IMethod contextMethod, IType[] genericArguments)
	{
		if (def.HasParameters)
		{
			List<IType> list = new List<IType>();
			IType type = appdomain.GetType(def.DeclaringType, contextType, contextMethod);
			{
				foreach (ParameterDefinition parameter in def.Parameters)
				{
					IType type2 = null;
					type2 = appdomain.GetType(parameter.ParameterType, type, null);
					if ((type2 == null && def.IsGenericInstance) || (type2 != null && type2.HasGenericParameter))
					{
						GenericInstanceMethod genericInstanceMethod = (GenericInstanceMethod)def;
						string text = (parameter.ParameterType.IsByReference ? ((ByReferenceType)parameter.ParameterType).ElementType.FullName : parameter.ParameterType.FullName);
						for (int i = 0; i < genericInstanceMethod.GenericArguments.Count; i++)
						{
							GenericParameter genericParameter = genericInstanceMethod.ElementMethod.GenericParameters[i];
							TypeReference token = genericInstanceMethod.GenericArguments[i];
							if (text == genericParameter.Name)
							{
								type2 = appdomain.GetType(token, contextType, contextMethod);
								if (type2 == null && genericArguments != null)
								{
									type2 = genericArguments[i];
								}
								break;
							}
							if (text.Contains(genericParameter.Name))
							{
								type2 = appdomain.GetType(token, contextType, contextMethod);
								if (type2 == null && genericArguments != null)
								{
									type2 = genericArguments[i];
								}
								text = ((!(text == genericParameter.Name + "[]")) ? ReplaceGenericArgument(text, genericParameter.Name, type2.FullName) : (type2.FullName + "[]"));
								type2 = null;
							}
						}
						if (type.GenericArguments != null)
						{
							KeyValuePair<string, IType>[] genericArguments2 = type.GenericArguments;
							for (int j = 0; j < genericArguments2.Length; j++)
							{
								KeyValuePair<string, IType> keyValuePair = genericArguments2[j];
								if (text.Contains(keyValuePair.Key))
								{
									text = ReplaceGenericArgument(text, keyValuePair.Key, keyValuePair.Value.FullName);
								}
							}
						}
						if (type2 == null)
						{
							type2 = appdomain.GetType(text);
						}
						if (type2 != null && parameter.ParameterType.IsByReference)
						{
							type2 = type2.MakeByRefType();
						}
					}
					list.Add(type2);
				}
				return list;
			}
		}
		return EmptyParamList;
	}

	private static string ReplaceGenericArgument(string typename, string argumentName, string argumentType, bool isGA = false)
	{
		StringBuilder stringBuilder = new StringBuilder();
		ILRuntime.Runtime.Enviorment.AppDomain.ParseGenericType(typename, out var baseType, out var genericParams, out var isArray, out var rank);
		string value = null;
		bool flag = genericParams != null && genericParams.Count > 0;
		if (baseType == argumentName)
		{
			bool flag2 = Enumerable.Contains(argumentName, '=') || Enumerable.Contains(argumentType, '=');
			if (isGA && flag2)
			{
				stringBuilder.Append('[');
			}
			stringBuilder.Append(argumentType);
			if (isGA && flag2)
			{
				stringBuilder.Append(']');
			}
		}
		else
		{
			if (baseType.Contains("["))
			{
				baseType = ReplaceGenericArgument(baseType, argumentName, argumentType, isGA);
			}
			bool flag3 = Enumerable.Contains(baseType, '=');
			if (isGA && !flag && flag3)
			{
				stringBuilder.Append('[');
			}
			else if (flag3)
			{
				stringBuilder.Append('[');
				value = baseType.Substring(baseType.IndexOf(','));
				baseType = baseType.Substring(0, baseType.IndexOf(','));
			}
			stringBuilder.Append(baseType);
			if (isGA && !flag && flag3)
			{
				stringBuilder.Append(']');
			}
		}
		if (flag)
		{
			stringBuilder.Append("[");
			bool flag4 = true;
			foreach (string item in genericParams)
			{
				if (flag4)
				{
					flag4 = false;
				}
				else
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(ReplaceGenericArgument(item, argumentName, argumentType, isGA: true));
			}
			stringBuilder.Append("]");
		}
		if (!string.IsNullOrEmpty(value))
		{
			stringBuilder.Append(value);
			stringBuilder.Append(']');
		}
		if (isArray)
		{
			stringBuilder.Append("[");
			for (int i = 0; i < rank - 1; i++)
			{
				stringBuilder.Append(",");
			}
			stringBuilder.Append("]");
		}
		return stringBuilder.ToString();
	}

	public static bool FastIsEnum(this Type pt)
	{
		return (pt.GetTypeFlags() & TypeFlags.IsEnum) != 0;
	}

	public static bool FastIsByRef(this Type pt)
	{
		return (pt.GetTypeFlags() & TypeFlags.IsByRef) != 0;
	}

	public static bool FastIsPrimitive(this Type pt)
	{
		return (pt.GetTypeFlags() & TypeFlags.IsPrimitive) != 0;
	}

	public static bool FastIsValueType(this Type pt)
	{
		return (pt.GetTypeFlags() & TypeFlags.IsValueType) != 0;
	}

	public static TypeFlags GetTypeFlagsRecursive(this Type pt)
	{
		TypeFlags typeFlagsRecursive = pt.GetTypeFlags();
		if ((typeFlagsRecursive & TypeFlags.IsByRef) == TypeFlags.IsByRef)
		{
			typeFlagsRecursive = pt.GetElementType().GetTypeFlagsRecursive();
		}
		return typeFlagsRecursive;
	}

	public static TypeFlags GetTypeFlags(this Type pt)
	{
		TypeFlags value = TypeFlags.Default;
		if (pt is ILRuntimeWrapperType)
		{
			pt = ((ILRuntimeWrapperType)pt).RealType;
		}
		if (!typeFlags.TryGetValue(pt, out value))
		{
			if (pt.IsPrimitive && pt != typeof(IntPtr))
			{
				value |= TypeFlags.IsPrimitive;
			}
			if (pt == typeof(Delegate) || pt.IsSubclassOf(typeof(Delegate)))
			{
				value |= TypeFlags.IsDelegate;
			}
			if (pt.IsByRef)
			{
				value |= TypeFlags.IsByRef;
			}
			if (pt.IsEnum)
			{
				value |= TypeFlags.IsEnum;
			}
			if (pt.IsValueType)
			{
				value |= TypeFlags.IsValueType;
			}
			typeFlags[pt] = value;
		}
		return value;
	}

	public static object CheckCLRTypes(this Type pt, object obj)
	{
		TypeFlags typeFlags = pt.GetTypeFlags();
		return pt.CheckCLRTypes(obj, typeFlags);
	}

	public static object CheckCLRTypes(this Type pt, object obj, TypeFlags typeFlags)
	{
		if (obj == null)
		{
			return null;
		}
		if ((typeFlags & TypeFlags.IsPrimitive) != TypeFlags.Default)
		{
			if (pt == typeof(int))
			{
				return obj;
			}
			if (pt == typeof(bool) && !(obj is bool))
			{
				obj = (int)obj == 1;
			}
			else if (pt == typeof(byte) && !(obj is byte))
			{
				obj = (byte)(int)obj;
			}
			else if (pt == typeof(short) && !(obj is short))
			{
				obj = (short)(int)obj;
			}
			else if (pt == typeof(char) && !(obj is char))
			{
				obj = (char)(int)obj;
			}
			else if (pt == typeof(ushort) && !(obj is ushort))
			{
				obj = (ushort)(int)obj;
			}
			else if (pt == typeof(uint) && !(obj is uint))
			{
				obj = (uint)(int)obj;
			}
			else if (pt == typeof(sbyte) && !(obj is sbyte))
			{
				obj = (sbyte)(int)obj;
			}
			else if (pt == typeof(ulong) && !(obj is ulong))
			{
				obj = (ulong)(long)obj;
			}
		}
		else if (obj is ILRuntimeWrapperType)
		{
			obj = ((ILRuntimeWrapperType)obj).RealType;
		}
		else
		{
			if ((typeFlags & TypeFlags.IsDelegate) != TypeFlags.Default)
			{
				if (obj is Delegate)
				{
					return obj;
				}
				if (pt == typeof(Delegate))
				{
					return ((IDelegateAdapter)obj).Delegate;
				}
				return ((IDelegateAdapter)obj).GetConvertor(pt);
			}
			if ((typeFlags & TypeFlags.IsByRef) != TypeFlags.Default)
			{
				return pt.GetElementType().CheckCLRTypes(obj);
			}
			if ((typeFlags & TypeFlags.IsEnum) != TypeFlags.Default)
			{
				return Enum.ToObject(pt, obj);
			}
			if (obj is ILTypeInstance)
			{
				if (obj is IDelegateAdapter delegateAdapter && pt != typeof(ILTypeInstance))
				{
					return delegateAdapter.Delegate;
				}
				if (!(obj is ILEnumTypeInstance))
				{
					return ((ILTypeInstance)obj).CLRInstance;
				}
			}
		}
		return obj;
	}

	public static bool CheckMethodParams(this MethodInfo m, Type[] args)
	{
		ParameterInfo[] parameters = m.GetParameters();
		if (parameters.Length != args.Length)
		{
			return false;
		}
		for (int i = 0; i < args.Length; i++)
		{
			Type parameterType = parameters[i].ParameterType;
			Type type = args[i];
			if (parameterType != type || parameterType.IsByRef != type.IsByRef)
			{
				return false;
			}
		}
		return true;
	}

	public static bool CheckMethodParams(this MethodInfo m, ParameterInfo[] args)
	{
		ParameterInfo[] parameters = m.GetParameters();
		if (parameters.Length != args.Length)
		{
			return false;
		}
		for (int i = 0; i < args.Length; i++)
		{
			Type parameterType = parameters[i].ParameterType;
			Type parameterType2 = args[i].ParameterType;
			if (parameterType != parameterType2 || parameterType.IsByRef != parameterType2.IsByRef)
			{
				return false;
			}
		}
		return true;
	}

	public static Type UnWrapper(this Type type)
	{
		if (type is ILRuntimeWrapperType)
		{
			return (type as ILRuntimeWrapperType).RealType;
		}
		return type;
	}
}
