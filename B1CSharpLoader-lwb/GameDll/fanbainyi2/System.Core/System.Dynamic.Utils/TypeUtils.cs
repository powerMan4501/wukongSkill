using System.Linq.Expressions;
using System.Reflection;

namespace System.Dynamic.Utils;

internal static class TypeUtils
{
	private const BindingFlags AnyStatic = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

	internal const MethodAttributes PublicStatic = MethodAttributes.Public | MethodAttributes.Static;

	private static readonly Assembly _mscorlib = typeof(object).Assembly;

	private static readonly Assembly _systemCore = typeof(Expression).Assembly;

	internal static Type GetNonNullableType(this Type type)
	{
		if (type.IsNullableType())
		{
			return type.GetGenericArguments()[0];
		}
		return type;
	}

	internal static Type GetNullableType(Type type)
	{
		if (type.IsValueType && !type.IsNullableType())
		{
			return typeof(Nullable<>).MakeGenericType(type);
		}
		return type;
	}

	internal static bool IsNullableType(this Type type)
	{
		if (type.IsGenericType)
		{
			return type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}
		return false;
	}

	internal static bool IsBool(Type type)
	{
		return type.GetNonNullableType() == typeof(bool);
	}

	internal static bool IsNumeric(Type type)
	{
		type = type.GetNonNullableType();
		if (!type.IsEnum)
		{
			TypeCode typeCode = Type.GetTypeCode(type);
			if ((uint)(typeCode - 4) <= 10u)
			{
				return true;
			}
		}
		return false;
	}

	internal static bool IsInteger(Type type)
	{
		type = type.GetNonNullableType();
		if (type.IsEnum)
		{
			return false;
		}
		TypeCode typeCode = Type.GetTypeCode(type);
		if ((uint)(typeCode - 5) <= 7u)
		{
			return true;
		}
		return false;
	}

	internal static bool IsArithmetic(Type type)
	{
		type = type.GetNonNullableType();
		if (!type.IsEnum)
		{
			TypeCode typeCode = Type.GetTypeCode(type);
			if ((uint)(typeCode - 7) <= 7u)
			{
				return true;
			}
		}
		return false;
	}

	internal static bool IsUnsignedInt(Type type)
	{
		type = type.GetNonNullableType();
		if (!type.IsEnum)
		{
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.UInt16:
			case TypeCode.UInt32:
			case TypeCode.UInt64:
				return true;
			}
		}
		return false;
	}

	internal static bool IsIntegerOrBool(Type type)
	{
		type = type.GetNonNullableType();
		if (!type.IsEnum)
		{
			TypeCode typeCode = Type.GetTypeCode(type);
			if (typeCode == TypeCode.Boolean || (uint)(typeCode - 5) <= 7u)
			{
				return true;
			}
		}
		return false;
	}

	internal static bool AreEquivalent(Type t1, Type t2)
	{
		if (!(t1 == t2))
		{
			return t1.IsEquivalentTo(t2);
		}
		return true;
	}

	internal static bool AreReferenceAssignable(Type dest, Type src)
	{
		if (AreEquivalent(dest, src))
		{
			return true;
		}
		if (!dest.IsValueType && !src.IsValueType && dest.IsAssignableFrom(src))
		{
			return true;
		}
		return false;
	}

	internal static bool IsValidInstanceType(MemberInfo member, Type instanceType)
	{
		Type declaringType = member.DeclaringType;
		if (AreReferenceAssignable(declaringType, instanceType))
		{
			return true;
		}
		if (instanceType.IsValueType)
		{
			if (AreReferenceAssignable(declaringType, typeof(object)))
			{
				return true;
			}
			if (AreReferenceAssignable(declaringType, typeof(ValueType)))
			{
				return true;
			}
			if (instanceType.IsEnum && AreReferenceAssignable(declaringType, typeof(Enum)))
			{
				return true;
			}
			if (declaringType.IsInterface)
			{
				Type[] interfaces = instanceType.GetInterfaces();
				foreach (Type src in interfaces)
				{
					if (AreReferenceAssignable(declaringType, src))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	internal static bool HasIdentityPrimitiveOrNullableConversion(Type source, Type dest)
	{
		if (AreEquivalent(source, dest))
		{
			return true;
		}
		if (source.IsNullableType() && AreEquivalent(dest, source.GetNonNullableType()))
		{
			return true;
		}
		if (dest.IsNullableType() && AreEquivalent(source, dest.GetNonNullableType()))
		{
			return true;
		}
		if (IsConvertible(source) && IsConvertible(dest) && dest.GetNonNullableType() != typeof(bool))
		{
			return true;
		}
		return false;
	}

	internal static bool HasReferenceConversion(Type source, Type dest)
	{
		if (source == typeof(void) || dest == typeof(void))
		{
			return false;
		}
		Type nonNullableType = source.GetNonNullableType();
		Type nonNullableType2 = dest.GetNonNullableType();
		if (nonNullableType.IsAssignableFrom(nonNullableType2))
		{
			return true;
		}
		if (nonNullableType2.IsAssignableFrom(nonNullableType))
		{
			return true;
		}
		if (source.IsInterface || dest.IsInterface)
		{
			return true;
		}
		if (IsLegalExplicitVariantDelegateConversion(source, dest))
		{
			return true;
		}
		if (source == typeof(object) || dest == typeof(object))
		{
			return true;
		}
		return false;
	}

	private static bool IsCovariant(Type t)
	{
		return (t.GenericParameterAttributes & GenericParameterAttributes.Covariant) != 0;
	}

	private static bool IsContravariant(Type t)
	{
		return (t.GenericParameterAttributes & GenericParameterAttributes.Contravariant) != 0;
	}

	private static bool IsInvariant(Type t)
	{
		return (t.GenericParameterAttributes & GenericParameterAttributes.VarianceMask) == 0;
	}

	private static bool IsDelegate(Type t)
	{
		return t.IsSubclassOf(typeof(MulticastDelegate));
	}

	internal static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest)
	{
		if (!IsDelegate(source) || !IsDelegate(dest) || !source.IsGenericType || !dest.IsGenericType)
		{
			return false;
		}
		Type genericTypeDefinition = source.GetGenericTypeDefinition();
		if (dest.GetGenericTypeDefinition() != genericTypeDefinition)
		{
			return false;
		}
		Type[] genericArguments = genericTypeDefinition.GetGenericArguments();
		Type[] genericArguments2 = source.GetGenericArguments();
		Type[] genericArguments3 = dest.GetGenericArguments();
		for (int i = 0; i < genericArguments.Length; i++)
		{
			Type type = genericArguments2[i];
			Type type2 = genericArguments3[i];
			if (AreEquivalent(type, type2))
			{
				continue;
			}
			Type t = genericArguments[i];
			if (IsInvariant(t))
			{
				return false;
			}
			if (IsCovariant(t))
			{
				if (!HasReferenceConversion(type, type2))
				{
					return false;
				}
			}
			else if (IsContravariant(t) && (type.IsValueType || type2.IsValueType))
			{
				return false;
			}
		}
		return true;
	}

	internal static bool IsConvertible(Type type)
	{
		type = type.GetNonNullableType();
		if (type.IsEnum)
		{
			return true;
		}
		TypeCode typeCode = Type.GetTypeCode(type);
		if ((uint)(typeCode - 3) <= 11u)
		{
			return true;
		}
		return false;
	}

	internal static bool HasReferenceEquality(Type left, Type right)
	{
		if (left.IsValueType || right.IsValueType)
		{
			return false;
		}
		if (!left.IsInterface && !right.IsInterface && !AreReferenceAssignable(left, right))
		{
			return AreReferenceAssignable(right, left);
		}
		return true;
	}

	internal static bool HasBuiltInEqualityOperator(Type left, Type right)
	{
		if (left.IsInterface && !right.IsValueType)
		{
			return true;
		}
		if (right.IsInterface && !left.IsValueType)
		{
			return true;
		}
		if (!left.IsValueType && !right.IsValueType && (AreReferenceAssignable(left, right) || AreReferenceAssignable(right, left)))
		{
			return true;
		}
		if (!AreEquivalent(left, right))
		{
			return false;
		}
		Type nonNullableType = left.GetNonNullableType();
		if (nonNullableType == typeof(bool) || IsNumeric(nonNullableType) || nonNullableType.IsEnum)
		{
			return true;
		}
		return false;
	}

	internal static bool IsImplicitlyConvertible(Type source, Type destination)
	{
		if (!AreEquivalent(source, destination) && !IsImplicitNumericConversion(source, destination) && !IsImplicitReferenceConversion(source, destination) && !IsImplicitBoxingConversion(source, destination))
		{
			return IsImplicitNullableConversion(source, destination);
		}
		return true;
	}

	internal static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType, bool implicitOnly)
	{
		Type nonNullableType = convertFrom.GetNonNullableType();
		Type nonNullableType2 = convertToType.GetNonNullableType();
		MethodInfo[] methods = nonNullableType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		MethodInfo methodInfo = FindConversionOperator(methods, convertFrom, convertToType, implicitOnly);
		if (methodInfo != null)
		{
			return methodInfo;
		}
		MethodInfo[] methods2 = nonNullableType2.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		methodInfo = FindConversionOperator(methods2, convertFrom, convertToType, implicitOnly);
		if (methodInfo != null)
		{
			return methodInfo;
		}
		if (!AreEquivalent(nonNullableType, convertFrom) || !AreEquivalent(nonNullableType2, convertToType))
		{
			methodInfo = FindConversionOperator(methods, nonNullableType, nonNullableType2, implicitOnly);
			if (methodInfo == null)
			{
				methodInfo = FindConversionOperator(methods2, nonNullableType, nonNullableType2, implicitOnly);
			}
			if (methodInfo != null)
			{
				return methodInfo;
			}
		}
		return null;
	}

	internal static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo, bool implicitOnly)
	{
		foreach (MethodInfo methodInfo in methods)
		{
			if ((!(methodInfo.Name != "op_Implicit") || (!implicitOnly && !(methodInfo.Name != "op_Explicit"))) && AreEquivalent(methodInfo.ReturnType, typeTo))
			{
				ParameterInfo[] parametersCached = methodInfo.GetParametersCached();
				if (AreEquivalent(parametersCached[0].ParameterType, typeFrom))
				{
					return methodInfo;
				}
			}
		}
		return null;
	}

	private static bool IsImplicitNumericConversion(Type source, Type destination)
	{
		TypeCode typeCode = Type.GetTypeCode(source);
		TypeCode typeCode2 = Type.GetTypeCode(destination);
		switch (typeCode)
		{
		case TypeCode.SByte:
			switch (typeCode2)
			{
			case TypeCode.Int16:
			case TypeCode.Int32:
			case TypeCode.Int64:
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			default:
				return false;
			}
		case TypeCode.Byte:
			if ((uint)(typeCode2 - 7) <= 8u)
			{
				return true;
			}
			return false;
		case TypeCode.Int16:
			switch (typeCode2)
			{
			case TypeCode.Int32:
			case TypeCode.Int64:
			case TypeCode.Single:
			case TypeCode.Double:
			case TypeCode.Decimal:
				return true;
			default:
				return false;
			}
		case TypeCode.UInt16:
			if ((uint)(typeCode2 - 9) <= 6u)
			{
				return true;
			}
			return false;
		case TypeCode.Int32:
			if (typeCode2 == TypeCode.Int64 || (uint)(typeCode2 - 13) <= 2u)
			{
				return true;
			}
			return false;
		case TypeCode.UInt32:
			if (typeCode2 == TypeCode.UInt32 || (uint)(typeCode2 - 12) <= 3u)
			{
				return true;
			}
			return false;
		case TypeCode.Int64:
		case TypeCode.UInt64:
			if ((uint)(typeCode2 - 13) <= 2u)
			{
				return true;
			}
			return false;
		case TypeCode.Char:
			if ((uint)(typeCode2 - 8) <= 7u)
			{
				return true;
			}
			return false;
		case TypeCode.Single:
			return typeCode2 == TypeCode.Double;
		default:
			return false;
		}
	}

	private static bool IsImplicitReferenceConversion(Type source, Type destination)
	{
		return destination.IsAssignableFrom(source);
	}

	private static bool IsImplicitBoxingConversion(Type source, Type destination)
	{
		if (source.IsValueType && (destination == typeof(object) || destination == typeof(ValueType)))
		{
			return true;
		}
		if (source.IsEnum && destination == typeof(Enum))
		{
			return true;
		}
		return false;
	}

	private static bool IsImplicitNullableConversion(Type source, Type destination)
	{
		if (destination.IsNullableType())
		{
			return IsImplicitlyConvertible(source.GetNonNullableType(), destination.GetNonNullableType());
		}
		return false;
	}

	internal static bool IsSameOrSubclass(Type type, Type subType)
	{
		if (!AreEquivalent(type, subType))
		{
			return subType.IsSubclassOf(type);
		}
		return true;
	}

	internal static void ValidateType(Type type)
	{
		if (type.IsGenericTypeDefinition)
		{
			throw Error.TypeIsGeneric(type);
		}
		if (type.ContainsGenericParameters)
		{
			throw Error.TypeContainsGenericParameters(type);
		}
	}

	internal static Type FindGenericType(Type definition, Type type)
	{
		while (type != null && type != typeof(object))
		{
			if (type.IsGenericType && AreEquivalent(type.GetGenericTypeDefinition(), definition))
			{
				return type;
			}
			if (definition.IsInterface)
			{
				Type[] interfaces = type.GetInterfaces();
				foreach (Type type2 in interfaces)
				{
					Type type3 = FindGenericType(definition, type2);
					if (type3 != null)
					{
						return type3;
					}
				}
			}
			type = type.BaseType;
		}
		return null;
	}

	internal static bool IsUnsigned(Type type)
	{
		type = type.GetNonNullableType();
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.Char:
		case TypeCode.Byte:
		case TypeCode.UInt16:
		case TypeCode.UInt32:
		case TypeCode.UInt64:
			return true;
		default:
			return false;
		}
	}

	internal static bool IsFloatingPoint(Type type)
	{
		type = type.GetNonNullableType();
		TypeCode typeCode = Type.GetTypeCode(type);
		if ((uint)(typeCode - 13) <= 1u)
		{
			return true;
		}
		return false;
	}

	internal static MethodInfo GetBooleanOperator(Type type, string name)
	{
		do
		{
			MethodInfo methodValidated = type.GetMethodValidated(name, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { type }, null);
			if (methodValidated != null && methodValidated.IsSpecialName && !methodValidated.ContainsGenericParameters)
			{
				return methodValidated;
			}
			type = type.BaseType;
		}
		while (type != null);
		return null;
	}

	internal static Type GetNonRefType(this Type type)
	{
		if (!type.IsByRef)
		{
			return type;
		}
		return type.GetElementType();
	}

	internal static bool CanCache(this Type t)
	{
		Assembly assembly = t.Assembly;
		if (assembly != _mscorlib && assembly != _systemCore)
		{
			return false;
		}
		if (t.IsGenericType)
		{
			Type[] genericArguments = t.GetGenericArguments();
			foreach (Type t2 in genericArguments)
			{
				if (!t2.CanCache())
				{
					return false;
				}
			}
		}
		return true;
	}
}
