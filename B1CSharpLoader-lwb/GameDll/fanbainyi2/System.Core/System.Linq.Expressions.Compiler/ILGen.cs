using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Linq.Expressions.Compiler;

internal static class ILGen
{
	internal static void Emit(this ILGenerator il, OpCode opcode, MethodBase methodBase)
	{
		if (methodBase.MemberType == MemberTypes.Constructor)
		{
			il.Emit(opcode, (ConstructorInfo)methodBase);
		}
		else
		{
			il.Emit(opcode, (MethodInfo)methodBase);
		}
	}

	internal static void EmitLoadArg(this ILGenerator il, int index)
	{
		switch (index)
		{
		case 0:
			il.Emit(OpCodes.Ldarg_0);
			return;
		case 1:
			il.Emit(OpCodes.Ldarg_1);
			return;
		case 2:
			il.Emit(OpCodes.Ldarg_2);
			return;
		case 3:
			il.Emit(OpCodes.Ldarg_3);
			return;
		}
		if (index <= 255)
		{
			il.Emit(OpCodes.Ldarg_S, (byte)index);
		}
		else
		{
			il.Emit(OpCodes.Ldarg, index);
		}
	}

	internal static void EmitLoadArgAddress(this ILGenerator il, int index)
	{
		if (index <= 255)
		{
			il.Emit(OpCodes.Ldarga_S, (byte)index);
		}
		else
		{
			il.Emit(OpCodes.Ldarga, index);
		}
	}

	internal static void EmitStoreArg(this ILGenerator il, int index)
	{
		if (index <= 255)
		{
			il.Emit(OpCodes.Starg_S, (byte)index);
		}
		else
		{
			il.Emit(OpCodes.Starg, index);
		}
	}

	internal static void EmitLoadValueIndirect(this ILGenerator il, Type type)
	{
		ContractUtils.RequiresNotNull(type, "type");
		if (type.IsValueType)
		{
			if (type == typeof(int))
			{
				il.Emit(OpCodes.Ldind_I4);
			}
			else if (type == typeof(uint))
			{
				il.Emit(OpCodes.Ldind_U4);
			}
			else if (type == typeof(short))
			{
				il.Emit(OpCodes.Ldind_I2);
			}
			else if (type == typeof(ushort))
			{
				il.Emit(OpCodes.Ldind_U2);
			}
			else if (type == typeof(long) || type == typeof(ulong))
			{
				il.Emit(OpCodes.Ldind_I8);
			}
			else if (type == typeof(char))
			{
				il.Emit(OpCodes.Ldind_I2);
			}
			else if (type == typeof(bool))
			{
				il.Emit(OpCodes.Ldind_I1);
			}
			else if (type == typeof(float))
			{
				il.Emit(OpCodes.Ldind_R4);
			}
			else if (type == typeof(double))
			{
				il.Emit(OpCodes.Ldind_R8);
			}
			else
			{
				il.Emit(OpCodes.Ldobj, type);
			}
		}
		else
		{
			il.Emit(OpCodes.Ldind_Ref);
		}
	}

	internal static void EmitStoreValueIndirect(this ILGenerator il, Type type)
	{
		ContractUtils.RequiresNotNull(type, "type");
		if (type.IsValueType)
		{
			if (type == typeof(int))
			{
				il.Emit(OpCodes.Stind_I4);
			}
			else if (type == typeof(short))
			{
				il.Emit(OpCodes.Stind_I2);
			}
			else if (type == typeof(long) || type == typeof(ulong))
			{
				il.Emit(OpCodes.Stind_I8);
			}
			else if (type == typeof(char))
			{
				il.Emit(OpCodes.Stind_I2);
			}
			else if (type == typeof(bool))
			{
				il.Emit(OpCodes.Stind_I1);
			}
			else if (type == typeof(float))
			{
				il.Emit(OpCodes.Stind_R4);
			}
			else if (type == typeof(double))
			{
				il.Emit(OpCodes.Stind_R8);
			}
			else
			{
				il.Emit(OpCodes.Stobj, type);
			}
		}
		else
		{
			il.Emit(OpCodes.Stind_Ref);
		}
	}

	internal static void EmitLoadElement(this ILGenerator il, Type type)
	{
		ContractUtils.RequiresNotNull(type, "type");
		if (!type.IsValueType)
		{
			il.Emit(OpCodes.Ldelem_Ref);
			return;
		}
		if (type.IsEnum)
		{
			il.Emit(OpCodes.Ldelem, type);
			return;
		}
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.Boolean:
		case TypeCode.SByte:
			il.Emit(OpCodes.Ldelem_I1);
			break;
		case TypeCode.Byte:
			il.Emit(OpCodes.Ldelem_U1);
			break;
		case TypeCode.Int16:
			il.Emit(OpCodes.Ldelem_I2);
			break;
		case TypeCode.Char:
		case TypeCode.UInt16:
			il.Emit(OpCodes.Ldelem_U2);
			break;
		case TypeCode.Int32:
			il.Emit(OpCodes.Ldelem_I4);
			break;
		case TypeCode.UInt32:
			il.Emit(OpCodes.Ldelem_U4);
			break;
		case TypeCode.Int64:
		case TypeCode.UInt64:
			il.Emit(OpCodes.Ldelem_I8);
			break;
		case TypeCode.Single:
			il.Emit(OpCodes.Ldelem_R4);
			break;
		case TypeCode.Double:
			il.Emit(OpCodes.Ldelem_R8);
			break;
		default:
			il.Emit(OpCodes.Ldelem, type);
			break;
		}
	}

	internal static void EmitStoreElement(this ILGenerator il, Type type)
	{
		ContractUtils.RequiresNotNull(type, "type");
		if (type.IsEnum)
		{
			il.Emit(OpCodes.Stelem, type);
			return;
		}
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.Boolean:
		case TypeCode.SByte:
		case TypeCode.Byte:
			il.Emit(OpCodes.Stelem_I1);
			return;
		case TypeCode.Char:
		case TypeCode.Int16:
		case TypeCode.UInt16:
			il.Emit(OpCodes.Stelem_I2);
			return;
		case TypeCode.Int32:
		case TypeCode.UInt32:
			il.Emit(OpCodes.Stelem_I4);
			return;
		case TypeCode.Int64:
		case TypeCode.UInt64:
			il.Emit(OpCodes.Stelem_I8);
			return;
		case TypeCode.Single:
			il.Emit(OpCodes.Stelem_R4);
			return;
		case TypeCode.Double:
			il.Emit(OpCodes.Stelem_R8);
			return;
		}
		if (type.IsValueType)
		{
			il.Emit(OpCodes.Stelem, type);
		}
		else
		{
			il.Emit(OpCodes.Stelem_Ref);
		}
	}

	internal static void EmitType(this ILGenerator il, Type type)
	{
		ContractUtils.RequiresNotNull(type, "type");
		il.Emit(OpCodes.Ldtoken, type);
		il.Emit(OpCodes.Call, typeof(Type).GetMethod("GetTypeFromHandle"));
	}

	internal static void EmitFieldAddress(this ILGenerator il, FieldInfo fi)
	{
		ContractUtils.RequiresNotNull(fi, "fi");
		if (fi.IsStatic)
		{
			il.Emit(OpCodes.Ldsflda, fi);
		}
		else
		{
			il.Emit(OpCodes.Ldflda, fi);
		}
	}

	internal static void EmitFieldGet(this ILGenerator il, FieldInfo fi)
	{
		ContractUtils.RequiresNotNull(fi, "fi");
		if (fi.IsStatic)
		{
			il.Emit(OpCodes.Ldsfld, fi);
		}
		else
		{
			il.Emit(OpCodes.Ldfld, fi);
		}
	}

	internal static void EmitFieldSet(this ILGenerator il, FieldInfo fi)
	{
		ContractUtils.RequiresNotNull(fi, "fi");
		if (fi.IsStatic)
		{
			il.Emit(OpCodes.Stsfld, fi);
		}
		else
		{
			il.Emit(OpCodes.Stfld, fi);
		}
	}

	internal static void EmitNew(this ILGenerator il, ConstructorInfo ci)
	{
		ContractUtils.RequiresNotNull(ci, "ci");
		if (ci.DeclaringType.ContainsGenericParameters)
		{
			throw Error.IllegalNewGenericParams(ci.DeclaringType);
		}
		il.Emit(OpCodes.Newobj, ci);
	}

	internal static void EmitNew(this ILGenerator il, Type type, Type[] paramTypes)
	{
		ContractUtils.RequiresNotNull(type, "type");
		ContractUtils.RequiresNotNull(paramTypes, "paramTypes");
		ConstructorInfo constructor = type.GetConstructor(paramTypes);
		if (constructor == null)
		{
			throw Error.TypeDoesNotHaveConstructorForTheSignature();
		}
		il.EmitNew(constructor);
	}

	internal static void EmitNull(this ILGenerator il)
	{
		il.Emit(OpCodes.Ldnull);
	}

	internal static void EmitString(this ILGenerator il, string value)
	{
		ContractUtils.RequiresNotNull(value, "value");
		il.Emit(OpCodes.Ldstr, value);
	}

	internal static void EmitBoolean(this ILGenerator il, bool value)
	{
		if (value)
		{
			il.Emit(OpCodes.Ldc_I4_1);
		}
		else
		{
			il.Emit(OpCodes.Ldc_I4_0);
		}
	}

	internal static void EmitChar(this ILGenerator il, char value)
	{
		il.EmitInt(value);
		il.Emit(OpCodes.Conv_U2);
	}

	internal static void EmitByte(this ILGenerator il, byte value)
	{
		il.EmitInt(value);
		il.Emit(OpCodes.Conv_U1);
	}

	internal static void EmitSByte(this ILGenerator il, sbyte value)
	{
		il.EmitInt(value);
		il.Emit(OpCodes.Conv_I1);
	}

	internal static void EmitShort(this ILGenerator il, short value)
	{
		il.EmitInt(value);
		il.Emit(OpCodes.Conv_I2);
	}

	internal static void EmitUShort(this ILGenerator il, ushort value)
	{
		il.EmitInt(value);
		il.Emit(OpCodes.Conv_U2);
	}

	internal static void EmitInt(this ILGenerator il, int value)
	{
		OpCode opcode;
		switch (value)
		{
		case -1:
			opcode = OpCodes.Ldc_I4_M1;
			break;
		case 0:
			opcode = OpCodes.Ldc_I4_0;
			break;
		case 1:
			opcode = OpCodes.Ldc_I4_1;
			break;
		case 2:
			opcode = OpCodes.Ldc_I4_2;
			break;
		case 3:
			opcode = OpCodes.Ldc_I4_3;
			break;
		case 4:
			opcode = OpCodes.Ldc_I4_4;
			break;
		case 5:
			opcode = OpCodes.Ldc_I4_5;
			break;
		case 6:
			opcode = OpCodes.Ldc_I4_6;
			break;
		case 7:
			opcode = OpCodes.Ldc_I4_7;
			break;
		case 8:
			opcode = OpCodes.Ldc_I4_8;
			break;
		default:
			if (value >= -128 && value <= 127)
			{
				il.Emit(OpCodes.Ldc_I4_S, (sbyte)value);
			}
			else
			{
				il.Emit(OpCodes.Ldc_I4, value);
			}
			return;
		}
		il.Emit(opcode);
	}

	internal static void EmitUInt(this ILGenerator il, uint value)
	{
		il.EmitInt((int)value);
		il.Emit(OpCodes.Conv_U4);
	}

	internal static void EmitLong(this ILGenerator il, long value)
	{
		il.Emit(OpCodes.Ldc_I8, value);
		il.Emit(OpCodes.Conv_I8);
	}

	internal static void EmitULong(this ILGenerator il, ulong value)
	{
		il.Emit(OpCodes.Ldc_I8, (long)value);
		il.Emit(OpCodes.Conv_U8);
	}

	internal static void EmitDouble(this ILGenerator il, double value)
	{
		il.Emit(OpCodes.Ldc_R8, value);
	}

	internal static void EmitSingle(this ILGenerator il, float value)
	{
		il.Emit(OpCodes.Ldc_R4, value);
	}

	internal static bool CanEmitConstant(object value, Type type)
	{
		if (value == null || CanEmitILConstant(type))
		{
			return true;
		}
		Type type2 = value as Type;
		if (type2 != null && ShouldLdtoken(type2))
		{
			return true;
		}
		MethodBase methodBase = value as MethodBase;
		if (methodBase != null && ShouldLdtoken(methodBase))
		{
			return true;
		}
		return false;
	}

	private static bool CanEmitILConstant(Type type)
	{
		TypeCode typeCode = Type.GetTypeCode(type);
		if ((uint)(typeCode - 3) <= 12u || typeCode == TypeCode.String)
		{
			return true;
		}
		return false;
	}

	internal static void EmitConstant(this ILGenerator il, object value)
	{
		il.EmitConstant(value, value.GetType());
	}

	internal static void EmitConstant(this ILGenerator il, object value, Type type)
	{
		if (value == null)
		{
			il.EmitDefault(type);
		}
		else
		{
			if (il.TryEmitILConstant(value, type))
			{
				return;
			}
			Type type2 = value as Type;
			if (type2 != null && ShouldLdtoken(type2))
			{
				il.EmitType(type2);
				if (type != typeof(Type))
				{
					il.Emit(OpCodes.Castclass, type);
				}
				return;
			}
			MethodBase methodBase = value as MethodBase;
			if (!(methodBase != null) || !ShouldLdtoken(methodBase))
			{
				throw ContractUtils.Unreachable;
			}
			il.Emit(OpCodes.Ldtoken, methodBase);
			Type declaringType = methodBase.DeclaringType;
			if (declaringType != null && declaringType.IsGenericType)
			{
				il.Emit(OpCodes.Ldtoken, declaringType);
				il.Emit(OpCodes.Call, typeof(MethodBase).GetMethod("GetMethodFromHandle", new Type[2]
				{
					typeof(RuntimeMethodHandle),
					typeof(RuntimeTypeHandle)
				}));
			}
			else
			{
				il.Emit(OpCodes.Call, typeof(MethodBase).GetMethod("GetMethodFromHandle", new Type[1] { typeof(RuntimeMethodHandle) }));
			}
			if (type != typeof(MethodBase))
			{
				il.Emit(OpCodes.Castclass, type);
			}
		}
	}

	internal static bool ShouldLdtoken(Type t)
	{
		if (!(t is TypeBuilder) && !t.IsGenericParameter)
		{
			return t.IsVisible;
		}
		return true;
	}

	internal static bool ShouldLdtoken(MethodBase mb)
	{
		if (mb is DynamicMethod)
		{
			return false;
		}
		Type declaringType = mb.DeclaringType;
		if (!(declaringType == null))
		{
			return ShouldLdtoken(declaringType);
		}
		return true;
	}

	private static bool TryEmitILConstant(this ILGenerator il, object value, Type type)
	{
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.Boolean:
			il.EmitBoolean((bool)value);
			return true;
		case TypeCode.SByte:
			il.EmitSByte((sbyte)value);
			return true;
		case TypeCode.Int16:
			il.EmitShort((short)value);
			return true;
		case TypeCode.Int32:
			il.EmitInt((int)value);
			return true;
		case TypeCode.Int64:
			il.EmitLong((long)value);
			return true;
		case TypeCode.Single:
			il.EmitSingle((float)value);
			return true;
		case TypeCode.Double:
			il.EmitDouble((double)value);
			return true;
		case TypeCode.Char:
			il.EmitChar((char)value);
			return true;
		case TypeCode.Byte:
			il.EmitByte((byte)value);
			return true;
		case TypeCode.UInt16:
			il.EmitUShort((ushort)value);
			return true;
		case TypeCode.UInt32:
			il.EmitUInt((uint)value);
			return true;
		case TypeCode.UInt64:
			il.EmitULong((ulong)value);
			return true;
		case TypeCode.Decimal:
			il.EmitDecimal((decimal)value);
			return true;
		case TypeCode.String:
			il.EmitString((string)value);
			return true;
		default:
			return false;
		}
	}

	internal static void EmitConvertToType(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked)
	{
		if (!TypeUtils.AreEquivalent(typeFrom, typeTo))
		{
			if (typeFrom == typeof(void) || typeTo == typeof(void))
			{
				throw ContractUtils.Unreachable;
			}
			bool flag = typeFrom.IsNullableType();
			bool flag2 = typeTo.IsNullableType();
			Type nonNullableType = typeFrom.GetNonNullableType();
			Type nonNullableType2 = typeTo.GetNonNullableType();
			if (typeFrom.IsInterface || typeTo.IsInterface || typeFrom == typeof(object) || typeTo == typeof(object) || typeFrom == typeof(Enum) || typeFrom == typeof(ValueType) || TypeUtils.IsLegalExplicitVariantDelegateConversion(typeFrom, typeTo))
			{
				il.EmitCastToType(typeFrom, typeTo);
			}
			else if (flag || flag2)
			{
				il.EmitNullableConversion(typeFrom, typeTo, isChecked);
			}
			else if ((!TypeUtils.IsConvertible(typeFrom) || !TypeUtils.IsConvertible(typeTo)) && (nonNullableType.IsAssignableFrom(nonNullableType2) || nonNullableType2.IsAssignableFrom(nonNullableType)))
			{
				il.EmitCastToType(typeFrom, typeTo);
			}
			else if (typeFrom.IsArray && typeTo.IsArray)
			{
				il.EmitCastToType(typeFrom, typeTo);
			}
			else
			{
				il.EmitNumericConversion(typeFrom, typeTo, isChecked);
			}
		}
	}

	private static void EmitCastToType(this ILGenerator il, Type typeFrom, Type typeTo)
	{
		if (!typeFrom.IsValueType && typeTo.IsValueType)
		{
			il.Emit(OpCodes.Unbox_Any, typeTo);
		}
		else if (typeFrom.IsValueType && !typeTo.IsValueType)
		{
			il.Emit(OpCodes.Box, typeFrom);
			if (typeTo != typeof(object))
			{
				il.Emit(OpCodes.Castclass, typeTo);
			}
		}
		else
		{
			if (typeFrom.IsValueType || typeTo.IsValueType)
			{
				throw Error.InvalidCast(typeFrom, typeTo);
			}
			il.Emit(OpCodes.Castclass, typeTo);
		}
	}

	private static void EmitNumericConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked)
	{
		bool flag = TypeUtils.IsUnsigned(typeFrom);
		bool flag2 = TypeUtils.IsFloatingPoint(typeFrom);
		if (typeTo == typeof(float))
		{
			if (flag)
			{
				il.Emit(OpCodes.Conv_R_Un);
			}
			il.Emit(OpCodes.Conv_R4);
			return;
		}
		if (typeTo == typeof(double))
		{
			if (flag)
			{
				il.Emit(OpCodes.Conv_R_Un);
			}
			il.Emit(OpCodes.Conv_R8);
			return;
		}
		TypeCode typeCode = Type.GetTypeCode(typeTo);
		if (isChecked)
		{
			if (flag)
			{
				switch (typeCode)
				{
				case TypeCode.SByte:
					il.Emit(OpCodes.Conv_Ovf_I1_Un);
					break;
				case TypeCode.Int16:
					il.Emit(OpCodes.Conv_Ovf_I2_Un);
					break;
				case TypeCode.Int32:
					il.Emit(OpCodes.Conv_Ovf_I4_Un);
					break;
				case TypeCode.Int64:
					il.Emit(OpCodes.Conv_Ovf_I8_Un);
					break;
				case TypeCode.Byte:
					il.Emit(OpCodes.Conv_Ovf_U1_Un);
					break;
				case TypeCode.Char:
				case TypeCode.UInt16:
					il.Emit(OpCodes.Conv_Ovf_U2_Un);
					break;
				case TypeCode.UInt32:
					il.Emit(OpCodes.Conv_Ovf_U4_Un);
					break;
				case TypeCode.UInt64:
					il.Emit(OpCodes.Conv_Ovf_U8_Un);
					break;
				default:
					throw Error.UnhandledConvert(typeTo);
				}
			}
			else
			{
				switch (typeCode)
				{
				case TypeCode.SByte:
					il.Emit(OpCodes.Conv_Ovf_I1);
					break;
				case TypeCode.Int16:
					il.Emit(OpCodes.Conv_Ovf_I2);
					break;
				case TypeCode.Int32:
					il.Emit(OpCodes.Conv_Ovf_I4);
					break;
				case TypeCode.Int64:
					il.Emit(OpCodes.Conv_Ovf_I8);
					break;
				case TypeCode.Byte:
					il.Emit(OpCodes.Conv_Ovf_U1);
					break;
				case TypeCode.Char:
				case TypeCode.UInt16:
					il.Emit(OpCodes.Conv_Ovf_U2);
					break;
				case TypeCode.UInt32:
					il.Emit(OpCodes.Conv_Ovf_U4);
					break;
				case TypeCode.UInt64:
					il.Emit(OpCodes.Conv_Ovf_U8);
					break;
				default:
					throw Error.UnhandledConvert(typeTo);
				}
			}
			return;
		}
		switch (typeCode)
		{
		case TypeCode.SByte:
			il.Emit(OpCodes.Conv_I1);
			break;
		case TypeCode.Byte:
			il.Emit(OpCodes.Conv_U1);
			break;
		case TypeCode.Int16:
			il.Emit(OpCodes.Conv_I2);
			break;
		case TypeCode.Char:
		case TypeCode.UInt16:
			il.Emit(OpCodes.Conv_U2);
			break;
		case TypeCode.Int32:
			il.Emit(OpCodes.Conv_I4);
			break;
		case TypeCode.UInt32:
			il.Emit(OpCodes.Conv_U4);
			break;
		case TypeCode.Int64:
			if (flag)
			{
				il.Emit(OpCodes.Conv_U8);
			}
			else
			{
				il.Emit(OpCodes.Conv_I8);
			}
			break;
		case TypeCode.UInt64:
			if (flag || flag2)
			{
				il.Emit(OpCodes.Conv_U8);
			}
			else
			{
				il.Emit(OpCodes.Conv_I8);
			}
			break;
		default:
			throw Error.UnhandledConvert(typeTo);
		}
	}

	private static void EmitNullableToNullableConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked)
	{
		Label label = default(Label);
		Label label2 = default(Label);
		LocalBuilder localBuilder = null;
		LocalBuilder localBuilder2 = null;
		localBuilder = il.DeclareLocal(typeFrom);
		il.Emit(OpCodes.Stloc, localBuilder);
		localBuilder2 = il.DeclareLocal(typeTo);
		il.Emit(OpCodes.Ldloca, localBuilder);
		il.EmitHasValue(typeFrom);
		label = il.DefineLabel();
		il.Emit(OpCodes.Brfalse_S, label);
		il.Emit(OpCodes.Ldloca, localBuilder);
		il.EmitGetValueOrDefault(typeFrom);
		Type nonNullableType = typeFrom.GetNonNullableType();
		Type nonNullableType2 = typeTo.GetNonNullableType();
		il.EmitConvertToType(nonNullableType, nonNullableType2, isChecked);
		ConstructorInfo constructor = typeTo.GetConstructor(new Type[1] { nonNullableType2 });
		il.Emit(OpCodes.Newobj, constructor);
		il.Emit(OpCodes.Stloc, localBuilder2);
		label2 = il.DefineLabel();
		il.Emit(OpCodes.Br_S, label2);
		il.MarkLabel(label);
		il.Emit(OpCodes.Ldloca, localBuilder2);
		il.Emit(OpCodes.Initobj, typeTo);
		il.MarkLabel(label2);
		il.Emit(OpCodes.Ldloc, localBuilder2);
	}

	private static void EmitNonNullableToNullableConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked)
	{
		LocalBuilder localBuilder = null;
		localBuilder = il.DeclareLocal(typeTo);
		Type nonNullableType = typeTo.GetNonNullableType();
		il.EmitConvertToType(typeFrom, nonNullableType, isChecked);
		ConstructorInfo constructor = typeTo.GetConstructor(new Type[1] { nonNullableType });
		il.Emit(OpCodes.Newobj, constructor);
		il.Emit(OpCodes.Stloc, localBuilder);
		il.Emit(OpCodes.Ldloc, localBuilder);
	}

	private static void EmitNullableToNonNullableConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked)
	{
		if (typeTo.IsValueType)
		{
			il.EmitNullableToNonNullableStructConversion(typeFrom, typeTo, isChecked);
		}
		else
		{
			il.EmitNullableToReferenceConversion(typeFrom);
		}
	}

	private static void EmitNullableToNonNullableStructConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked)
	{
		LocalBuilder localBuilder = null;
		localBuilder = il.DeclareLocal(typeFrom);
		il.Emit(OpCodes.Stloc, localBuilder);
		il.Emit(OpCodes.Ldloca, localBuilder);
		il.EmitGetValue(typeFrom);
		Type nonNullableType = typeFrom.GetNonNullableType();
		il.EmitConvertToType(nonNullableType, typeTo, isChecked);
	}

	private static void EmitNullableToReferenceConversion(this ILGenerator il, Type typeFrom)
	{
		il.Emit(OpCodes.Box, typeFrom);
	}

	private static void EmitNullableConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked)
	{
		bool flag = typeFrom.IsNullableType();
		bool flag2 = typeTo.IsNullableType();
		if (flag && flag2)
		{
			il.EmitNullableToNullableConversion(typeFrom, typeTo, isChecked);
		}
		else if (flag)
		{
			il.EmitNullableToNonNullableConversion(typeFrom, typeTo, isChecked);
		}
		else
		{
			il.EmitNonNullableToNullableConversion(typeFrom, typeTo, isChecked);
		}
	}

	internal static void EmitHasValue(this ILGenerator il, Type nullableType)
	{
		MethodInfo method = nullableType.GetMethod("get_HasValue", BindingFlags.Instance | BindingFlags.Public);
		il.Emit(OpCodes.Call, method);
	}

	internal static void EmitGetValue(this ILGenerator il, Type nullableType)
	{
		MethodInfo method = nullableType.GetMethod("get_Value", BindingFlags.Instance | BindingFlags.Public);
		il.Emit(OpCodes.Call, method);
	}

	internal static void EmitGetValueOrDefault(this ILGenerator il, Type nullableType)
	{
		MethodInfo method = nullableType.GetMethod("GetValueOrDefault", Type.EmptyTypes);
		il.Emit(OpCodes.Call, method);
	}

	internal static void EmitArray<T>(this ILGenerator il, IList<T> items)
	{
		ContractUtils.RequiresNotNull(items, "items");
		il.EmitInt(items.Count);
		il.Emit(OpCodes.Newarr, typeof(T));
		for (int i = 0; i < items.Count; i++)
		{
			il.Emit(OpCodes.Dup);
			il.EmitInt(i);
			il.EmitConstant(items[i], typeof(T));
			il.EmitStoreElement(typeof(T));
		}
	}

	internal static void EmitArray(this ILGenerator il, Type elementType, int count, Action<int> emit)
	{
		ContractUtils.RequiresNotNull(elementType, "elementType");
		ContractUtils.RequiresNotNull(emit, "emit");
		if (count < 0)
		{
			throw Error.CountCannotBeNegative();
		}
		il.EmitInt(count);
		il.Emit(OpCodes.Newarr, elementType);
		for (int i = 0; i < count; i++)
		{
			il.Emit(OpCodes.Dup);
			il.EmitInt(i);
			emit(i);
			il.EmitStoreElement(elementType);
		}
	}

	internal static void EmitArray(this ILGenerator il, Type arrayType)
	{
		ContractUtils.RequiresNotNull(arrayType, "arrayType");
		if (!arrayType.IsArray)
		{
			throw Error.ArrayTypeMustBeArray();
		}
		int arrayRank = arrayType.GetArrayRank();
		if (arrayRank == 1)
		{
			il.Emit(OpCodes.Newarr, arrayType.GetElementType());
			return;
		}
		Type[] array = new Type[arrayRank];
		for (int i = 0; i < arrayRank; i++)
		{
			array[i] = typeof(int);
		}
		il.EmitNew(arrayType, array);
	}

	internal static void EmitDecimal(this ILGenerator il, decimal value)
	{
		if (decimal.Truncate(value) == value)
		{
			if (-2147483648m <= value && value <= 2147483647m)
			{
				int value2 = decimal.ToInt32(value);
				il.EmitInt(value2);
				il.EmitNew(typeof(decimal).GetConstructor(new Type[1] { typeof(int) }));
			}
			else if (-9223372036854775808m <= value && value <= 9223372036854775807m)
			{
				long value3 = decimal.ToInt64(value);
				il.EmitLong(value3);
				il.EmitNew(typeof(decimal).GetConstructor(new Type[1] { typeof(long) }));
			}
			else
			{
				il.EmitDecimalBits(value);
			}
		}
		else
		{
			il.EmitDecimalBits(value);
		}
	}

	private static void EmitDecimalBits(this ILGenerator il, decimal value)
	{
		int[] bits = decimal.GetBits(value);
		il.EmitInt(bits[0]);
		il.EmitInt(bits[1]);
		il.EmitInt(bits[2]);
		il.EmitBoolean((bits[3] & 0x80000000u) != 0);
		il.EmitByte((byte)(bits[3] >> 16));
		il.EmitNew(typeof(decimal).GetConstructor(new Type[5]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}));
	}

	internal static void EmitDefault(this ILGenerator il, Type type)
	{
		switch (Type.GetTypeCode(type))
		{
		case TypeCode.Object:
		case TypeCode.DateTime:
			if (type.IsValueType)
			{
				LocalBuilder local = il.DeclareLocal(type);
				il.Emit(OpCodes.Ldloca, local);
				il.Emit(OpCodes.Initobj, type);
				il.Emit(OpCodes.Ldloc, local);
			}
			else
			{
				il.Emit(OpCodes.Ldnull);
			}
			break;
		case TypeCode.Empty:
		case TypeCode.DBNull:
		case TypeCode.String:
			il.Emit(OpCodes.Ldnull);
			break;
		case TypeCode.Boolean:
		case TypeCode.Char:
		case TypeCode.SByte:
		case TypeCode.Byte:
		case TypeCode.Int16:
		case TypeCode.UInt16:
		case TypeCode.Int32:
		case TypeCode.UInt32:
			il.Emit(OpCodes.Ldc_I4_0);
			break;
		case TypeCode.Int64:
		case TypeCode.UInt64:
			il.Emit(OpCodes.Ldc_I4_0);
			il.Emit(OpCodes.Conv_I8);
			break;
		case TypeCode.Single:
			il.Emit(OpCodes.Ldc_R4, 0f);
			break;
		case TypeCode.Double:
			il.Emit(OpCodes.Ldc_R8, 0.0);
			break;
		case TypeCode.Decimal:
			il.Emit(OpCodes.Ldc_I4_0);
			il.Emit(OpCodes.Newobj, typeof(decimal).GetConstructor(new Type[1] { typeof(int) }));
			break;
		default:
			throw ContractUtils.Unreachable;
		}
	}
}
