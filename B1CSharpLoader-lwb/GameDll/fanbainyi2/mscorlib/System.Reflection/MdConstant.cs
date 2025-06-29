using System.Security;

namespace System.Reflection;

internal static class MdConstant
{
	[SecurityCritical]
	public unsafe static object GetValue(MetadataImport scope, int token, RuntimeTypeHandle fieldTypeHandle, bool raw)
	{
		CorElementType corElementType = CorElementType.End;
		long value = 0L;
		int length;
		string defaultValue = scope.GetDefaultValue(token, out value, out length, out corElementType);
		RuntimeType runtimeType = fieldTypeHandle.GetRuntimeType();
		if (runtimeType.IsEnum && !raw)
		{
			long num = 0L;
			switch (corElementType)
			{
			case CorElementType.Void:
				return DBNull.Value;
			case CorElementType.Char:
				num = *(ushort*)(&value);
				break;
			case CorElementType.I1:
				num = *(sbyte*)(&value);
				break;
			case CorElementType.U1:
				num = *(byte*)(&value);
				break;
			case CorElementType.I2:
				num = *(short*)(&value);
				break;
			case CorElementType.U2:
				num = *(ushort*)(&value);
				break;
			case CorElementType.I4:
				num = *(int*)(&value);
				break;
			case CorElementType.U4:
				num = (uint)(*(int*)(&value));
				break;
			case CorElementType.I8:
				num = value;
				break;
			case CorElementType.U8:
				num = value;
				break;
			default:
				throw new FormatException(Environment.GetResourceString("Arg_BadLiteralFormat"));
			}
			return RuntimeType.CreateEnum(runtimeType, num);
		}
		if (runtimeType == typeof(DateTime))
		{
			long num2 = 0L;
			switch (corElementType)
			{
			case CorElementType.Void:
				return DBNull.Value;
			case CorElementType.I8:
				num2 = value;
				break;
			case CorElementType.U8:
				num2 = value;
				break;
			default:
				throw new FormatException(Environment.GetResourceString("Arg_BadLiteralFormat"));
			}
			return new DateTime(num2);
		}
		switch (corElementType)
		{
		case CorElementType.Void:
			return DBNull.Value;
		case CorElementType.Char:
			return *(char*)(&value);
		case CorElementType.I1:
			return *(sbyte*)(&value);
		case CorElementType.U1:
			return *(byte*)(&value);
		case CorElementType.I2:
			return *(short*)(&value);
		case CorElementType.U2:
			return *(ushort*)(&value);
		case CorElementType.I4:
			return *(int*)(&value);
		case CorElementType.U4:
			return *(uint*)(&value);
		case CorElementType.I8:
			return value;
		case CorElementType.U8:
			return (ulong)value;
		case CorElementType.Boolean:
			return *(int*)(&value) != 0;
		case CorElementType.R4:
			return *(float*)(&value);
		case CorElementType.R8:
			return *(double*)(&value);
		case CorElementType.String:
			if (defaultValue != null)
			{
				return defaultValue;
			}
			return string.Empty;
		case CorElementType.Class:
			return null;
		default:
			throw new FormatException(Environment.GetResourceString("Arg_BadLiteralFormat"));
		}
	}
}
