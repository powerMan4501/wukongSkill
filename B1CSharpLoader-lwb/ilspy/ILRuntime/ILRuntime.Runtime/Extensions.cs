using System;
using System.Reflection;
using System.Text;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime;

public static class Extensions
{
	public static bool GetJITFlags(this CustomAttribute attribute, ILRuntime.Runtime.Enviorment.AppDomain appdomain, out int flags)
	{
		IType type = appdomain.GetType(attribute.AttributeType, null, null);
		flags = 0;
		if (type == appdomain.JITAttributeType)
		{
			if (attribute.HasConstructorArguments)
			{
				flags = (int)attribute.ConstructorArguments[0].Value;
			}
			else
			{
				flags = 1;
			}
			return true;
		}
		return false;
	}

	public static void GetClassName(this Type type, out string clsName, out string realClsName, out bool isByRef, bool simpleClassName = false)
	{
		isByRef = type.IsByRef;
		int num = 1;
		if (isByRef)
		{
			type = type.GetElementType();
		}
		bool isArray = type.IsArray;
		if (isArray)
		{
			num = type.GetArrayRank();
			type = type.GetElementType();
			if (type.IsArray)
			{
				type.GetClassName(out clsName, out realClsName, out isByRef, simpleClassName);
				clsName += "_Array";
				if (!simpleClassName)
				{
					clsName += "_Binding";
				}
				if (num > 1)
				{
					clsName += num;
				}
				if (num <= 1)
				{
					realClsName += "[]";
					return;
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(realClsName);
				stringBuilder.Append('[');
				for (int i = 0; i < num - 1; i++)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(']');
				realClsName = stringBuilder.ToString();
				return;
			}
		}
		string text = null;
		bool flag = false;
		if (type.IsNested)
		{
			Type type2 = type.ReflectedType;
			if (type2.IsGenericType && type2.IsGenericTypeDefinition && type.IsGenericType)
			{
				type2 = type2.MakeGenericType(type.GetGenericArguments());
				flag = true;
			}
			type2.GetClassName(out var clsName2, out var realClsName2, out var _);
			clsName = clsName2 + "_";
			text = realClsName2 + ".";
		}
		else
		{
			clsName = (simpleClassName ? "" : ((!string.IsNullOrEmpty(type.Namespace)) ? (type.Namespace.Replace(".", "_") + "_") : ""));
			if (string.IsNullOrEmpty(type.Namespace))
			{
				if (type.IsArray)
				{
					Type elementType = type.GetElementType();
					text = ((!elementType.IsNested || !(elementType.DeclaringType != null)) ? (elementType.Namespace + ".") : (elementType.Namespace + "." + elementType.DeclaringType.Name + "."));
				}
				else
				{
					text = "global::";
				}
			}
			else
			{
				text = type.Namespace + ".";
			}
		}
		clsName += type.Name.Replace(".", "_").Replace("`", "_").Replace("<", "_")
			.Replace(">", "_");
		bool flag2 = false;
		string text2 = null;
		if (type.IsGenericType && !flag)
		{
			flag2 = true;
			clsName += "_";
			text2 = "<";
			Type[] genericArguments = type.GetGenericArguments();
			bool flag3 = true;
			Type[] array = genericArguments;
			foreach (Type type3 in array)
			{
				if (flag3)
				{
					flag3 = false;
				}
				else
				{
					clsName += "_";
					text2 += ", ";
				}
				type3.GetClassName(out var clsName3, out var realClsName3, out var _, simpleClassName: true);
				clsName += clsName3;
				text2 += realClsName3;
			}
			text2 += ">";
		}
		if (isArray)
		{
			clsName += "_Array";
			if (num > 1)
			{
				clsName += num;
			}
		}
		if (!simpleClassName)
		{
			clsName += "_Binding";
		}
		realClsName = text;
		if (flag2)
		{
			int num2 = type.Name.IndexOf("`");
			if (num2 > 0)
			{
				realClsName += type.Name.Substring(0, num2);
				realClsName += text2;
			}
			else
			{
				realClsName += type.Name;
			}
		}
		else
		{
			realClsName += type.Name;
		}
		if (!isArray)
		{
			return;
		}
		if (num <= 1)
		{
			realClsName += "[]";
			return;
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder2.Append(realClsName);
		stringBuilder2.Append('[');
		for (int k = 0; k < num - 1; k++)
		{
			stringBuilder2.Append(',');
		}
		stringBuilder2.Append(']');
		realClsName = stringBuilder2.ToString();
	}

	public static int ToInt32(this object obj)
	{
		if (obj is int)
		{
			return (int)obj;
		}
		if (obj is float)
		{
			return (int)(float)obj;
		}
		if (obj is long)
		{
			return (int)(long)obj;
		}
		if (obj is short)
		{
			return (short)obj;
		}
		if (obj is double)
		{
			return (int)(double)obj;
		}
		if (obj is byte)
		{
			return (byte)obj;
		}
		if (obj is ILEnumTypeInstance)
		{
			return (int)((ILEnumTypeInstance)obj)[0];
		}
		if (obj is uint)
		{
			return (int)(uint)obj;
		}
		if (obj is ushort)
		{
			return (ushort)obj;
		}
		if (obj is sbyte)
		{
			return (sbyte)obj;
		}
		return Convert.ToInt32(obj);
	}

	public static long ToInt64(this object obj)
	{
		if (obj is long)
		{
			return (long)obj;
		}
		if (obj is int)
		{
			return (int)obj;
		}
		if (obj is float)
		{
			return (long)(float)obj;
		}
		if (obj is short)
		{
			return (short)obj;
		}
		if (obj is double)
		{
			return (long)(double)obj;
		}
		if (obj is byte)
		{
			return (byte)obj;
		}
		if (obj is uint)
		{
			return (uint)obj;
		}
		if (obj is ushort)
		{
			return (ushort)obj;
		}
		if (obj is sbyte)
		{
			return (sbyte)obj;
		}
		throw new InvalidCastException();
	}

	public static short ToInt16(this object obj)
	{
		if (obj is short)
		{
			return (short)obj;
		}
		if (obj is long)
		{
			return (short)(long)obj;
		}
		if (obj is int)
		{
			return (short)(int)obj;
		}
		if (obj is float)
		{
			return (short)(float)obj;
		}
		if (obj is double)
		{
			return (short)(double)obj;
		}
		if (obj is byte)
		{
			return (byte)obj;
		}
		if (obj is uint)
		{
			return (short)(uint)obj;
		}
		if (obj is ushort)
		{
			return (short)(ushort)obj;
		}
		if (obj is sbyte)
		{
			return (sbyte)obj;
		}
		throw new InvalidCastException();
	}

	public static float ToFloat(this object obj)
	{
		if (obj is float)
		{
			return (float)obj;
		}
		if (obj is int)
		{
			return (int)obj;
		}
		if (obj is long)
		{
			return (long)obj;
		}
		if (obj is short)
		{
			return (short)obj;
		}
		if (obj is double)
		{
			return (float)(double)obj;
		}
		if (obj is byte)
		{
			return (int)(byte)obj;
		}
		if (obj is uint)
		{
			return (uint)obj;
		}
		if (obj is ushort)
		{
			return (int)(ushort)obj;
		}
		if (obj is sbyte)
		{
			return (sbyte)obj;
		}
		throw new InvalidCastException();
	}

	public static double ToDouble(this object obj)
	{
		if (obj is double)
		{
			return (double)obj;
		}
		if (obj is float)
		{
			return (float)obj;
		}
		if (obj is int)
		{
			return (int)obj;
		}
		if (obj is long)
		{
			return (long)obj;
		}
		if (obj is short)
		{
			return (short)obj;
		}
		if (obj is byte)
		{
			return (int)(byte)obj;
		}
		if (obj is uint)
		{
			return (uint)obj;
		}
		if (obj is ushort)
		{
			return (int)(ushort)obj;
		}
		if (obj is sbyte)
		{
			return (sbyte)obj;
		}
		throw new InvalidCastException();
	}

	public static Type GetActualType(this object value)
	{
		if (value is CrossBindingAdaptorType)
		{
			return ((CrossBindingAdaptorType)value).ILInstance.Type.ReflectionType;
		}
		if (value is ILTypeInstance)
		{
			return ((ILTypeInstance)value).Type.ReflectionType;
		}
		return value.GetType();
	}

	public static bool MatchGenericParameters(this MethodInfo m, Type[] genericArguments, Type returnType, params Type[] parameters)
	{
		ParameterInfo[] parameters2 = m.GetParameters();
		if (parameters2.Length == parameters.Length)
		{
			Type[] genericArguments2 = m.GetGenericArguments();
			if (genericArguments2.Length != genericArguments.Length)
			{
				return false;
			}
			if (genericArguments2.MatchGenericParameters(m.ReturnType, returnType, genericArguments))
			{
				for (int i = 0; i < parameters2.Length; i++)
				{
					if (!genericArguments2.MatchGenericParameters(parameters2[i].ParameterType, parameters[i], genericArguments))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static bool MatchGenericParameters(this Type[] args, Type type, Type q, Type[] genericArguments)
	{
		if (type.IsGenericParameter)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] == type)
				{
					return q == genericArguments[i];
				}
			}
			throw new NotSupportedException();
		}
		if (type.IsArray)
		{
			if (q.IsArray)
			{
				return args.MatchGenericParameters(type.GetElementType(), q.GetElementType(), genericArguments);
			}
			return false;
		}
		if (type.IsByRef)
		{
			if (q.IsByRef)
			{
				return args.MatchGenericParameters(type.GetElementType(), q.GetElementType(), genericArguments);
			}
			return false;
		}
		if (type.IsGenericType)
		{
			if (q.IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				Type genericTypeDefinition2 = type.GetGenericTypeDefinition();
				if (genericTypeDefinition == genericTypeDefinition2)
				{
					Type[] genericArguments2 = type.GetGenericArguments();
					Type[] genericArguments3 = q.GetGenericArguments();
					if (genericArguments2.Length == genericArguments3.Length)
					{
						for (int j = 0; j < genericArguments2.Length; j++)
						{
							if (!args.MatchGenericParameters(genericArguments2[j], genericArguments3[j], genericArguments))
							{
								return false;
							}
						}
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
		}
		return type == q;
	}
}
