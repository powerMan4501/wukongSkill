using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct CustomAttributeTypedArgument
{
	private object m_value;

	private Type m_argumentType;

	[__DynamicallyInvokable]
	public Type ArgumentType
	{
		[__DynamicallyInvokable]
		get
		{
			return m_argumentType;
		}
	}

	[__DynamicallyInvokable]
	public object Value
	{
		[__DynamicallyInvokable]
		get
		{
			return m_value;
		}
	}

	public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
	{
		return !left.Equals(right);
	}

	private static Type CustomAttributeEncodingToType(CustomAttributeEncoding encodedType)
	{
		return encodedType switch
		{
			CustomAttributeEncoding.Enum => typeof(Enum), 
			CustomAttributeEncoding.Int32 => typeof(int), 
			CustomAttributeEncoding.String => typeof(string), 
			CustomAttributeEncoding.Type => typeof(Type), 
			CustomAttributeEncoding.Array => typeof(Array), 
			CustomAttributeEncoding.Char => typeof(char), 
			CustomAttributeEncoding.Boolean => typeof(bool), 
			CustomAttributeEncoding.SByte => typeof(sbyte), 
			CustomAttributeEncoding.Byte => typeof(byte), 
			CustomAttributeEncoding.Int16 => typeof(short), 
			CustomAttributeEncoding.UInt16 => typeof(ushort), 
			CustomAttributeEncoding.UInt32 => typeof(uint), 
			CustomAttributeEncoding.Int64 => typeof(long), 
			CustomAttributeEncoding.UInt64 => typeof(ulong), 
			CustomAttributeEncoding.Float => typeof(float), 
			CustomAttributeEncoding.Double => typeof(double), 
			CustomAttributeEncoding.Object => typeof(object), 
			_ => throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)encodedType), "encodedType"), 
		};
	}

	[SecuritySafeCritical]
	private unsafe static object EncodedValueToRawValue(long val, CustomAttributeEncoding encodedType)
	{
		return encodedType switch
		{
			CustomAttributeEncoding.Boolean => (byte)val != 0, 
			CustomAttributeEncoding.Char => (char)val, 
			CustomAttributeEncoding.Byte => (byte)val, 
			CustomAttributeEncoding.SByte => (sbyte)val, 
			CustomAttributeEncoding.Int16 => (short)val, 
			CustomAttributeEncoding.UInt16 => (ushort)val, 
			CustomAttributeEncoding.Int32 => (int)val, 
			CustomAttributeEncoding.UInt32 => (uint)val, 
			CustomAttributeEncoding.Int64 => val, 
			CustomAttributeEncoding.UInt64 => (ulong)val, 
			CustomAttributeEncoding.Float => *(float*)(&val), 
			CustomAttributeEncoding.Double => *(double*)(&val), 
			_ => throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)val), "val"), 
		};
	}

	private static RuntimeType ResolveType(RuntimeModule scope, string typeName)
	{
		RuntimeType typeByNameUsingCARules = RuntimeTypeHandle.GetTypeByNameUsingCARules(typeName, scope);
		if (typeByNameUsingCARules == null)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentUICulture, Environment.GetResourceString("Arg_CATypeResolutionFailed"), typeName));
		}
		return typeByNameUsingCARules;
	}

	public CustomAttributeTypedArgument(Type argumentType, object value)
	{
		if (argumentType == null)
		{
			throw new ArgumentNullException("argumentType");
		}
		m_value = ((value == null) ? null : CanonicalizeValue(value));
		m_argumentType = argumentType;
	}

	public CustomAttributeTypedArgument(object value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		m_value = CanonicalizeValue(value);
		m_argumentType = value.GetType();
	}

	private static object CanonicalizeValue(object value)
	{
		if (value.GetType().IsEnum)
		{
			return ((Enum)value).GetValue();
		}
		return value;
	}

	internal CustomAttributeTypedArgument(RuntimeModule scope, CustomAttributeEncodedArgument encodedArg)
	{
		CustomAttributeEncoding encodedType = encodedArg.CustomAttributeType.EncodedType;
		switch (encodedType)
		{
		case CustomAttributeEncoding.Undefined:
			throw new ArgumentException("encodedArg");
		case CustomAttributeEncoding.Enum:
			m_argumentType = ResolveType(scope, encodedArg.CustomAttributeType.EnumName);
			m_value = EncodedValueToRawValue(encodedArg.PrimitiveValue, encodedArg.CustomAttributeType.EncodedEnumType);
			break;
		case CustomAttributeEncoding.String:
			m_argumentType = typeof(string);
			m_value = encodedArg.StringValue;
			break;
		case CustomAttributeEncoding.Type:
			m_argumentType = typeof(Type);
			m_value = null;
			if (encodedArg.StringValue != null)
			{
				m_value = ResolveType(scope, encodedArg.StringValue);
			}
			break;
		case CustomAttributeEncoding.Array:
		{
			encodedType = encodedArg.CustomAttributeType.EncodedArrayType;
			Type type = ((encodedType != CustomAttributeEncoding.Enum) ? CustomAttributeEncodingToType(encodedType) : ResolveType(scope, encodedArg.CustomAttributeType.EnumName));
			m_argumentType = type.MakeArrayType();
			if (encodedArg.ArrayValue == null)
			{
				m_value = null;
				break;
			}
			CustomAttributeTypedArgument[] array = new CustomAttributeTypedArgument[encodedArg.ArrayValue.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new CustomAttributeTypedArgument(scope, encodedArg.ArrayValue[i]);
			}
			m_value = Array.AsReadOnly(array);
			break;
		}
		default:
			m_argumentType = CustomAttributeEncodingToType(encodedType);
			m_value = EncodedValueToRawValue(encodedArg.PrimitiveValue, encodedType);
			break;
		}
	}

	public override string ToString()
	{
		return ToString(typed: false);
	}

	internal string ToString(bool typed)
	{
		if (m_argumentType == null)
		{
			return base.ToString();
		}
		if (ArgumentType.IsEnum)
		{
			return string.Format(CultureInfo.CurrentCulture, typed ? "{0}" : "({1}){0}", Value, ArgumentType.FullName);
		}
		if (Value == null)
		{
			return string.Format(CultureInfo.CurrentCulture, typed ? "null" : "({0})null", ArgumentType.Name);
		}
		if (ArgumentType == typeof(string))
		{
			return string.Format(CultureInfo.CurrentCulture, "\"{0}\"", Value);
		}
		if (ArgumentType == typeof(char))
		{
			return string.Format(CultureInfo.CurrentCulture, "'{0}'", Value);
		}
		if (ArgumentType == typeof(Type))
		{
			return string.Format(CultureInfo.CurrentCulture, "typeof({0})", ((Type)Value).FullName);
		}
		if (ArgumentType.IsArray)
		{
			string text = null;
			IList<CustomAttributeTypedArgument> list = Value as IList<CustomAttributeTypedArgument>;
			Type elementType = ArgumentType.GetElementType();
			text = string.Format(CultureInfo.CurrentCulture, "new {0}[{1}] {{ ", elementType.IsEnum ? elementType.FullName : elementType.Name, list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				text += string.Format(CultureInfo.CurrentCulture, (i == 0) ? "{0}" : ", {0}", list[i].ToString(elementType != typeof(object)));
			}
			return text += " }";
		}
		return string.Format(CultureInfo.CurrentCulture, typed ? "{0}" : "({1}){0}", Value, ArgumentType.Name);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		return obj == (object)this;
	}
}
