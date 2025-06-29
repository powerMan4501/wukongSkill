using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[CLSCompliant(false)]
[ComVisible(true)]
[NonVersionable]
public struct TypedReference
{
	private IntPtr Value;

	private IntPtr Type;

	internal bool IsNull
	{
		get
		{
			if (Value.IsNull())
			{
				return Type.IsNull();
			}
			return false;
		}
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	public unsafe static TypedReference MakeTypedReference(object target, FieldInfo[] flds)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (flds == null)
		{
			throw new ArgumentNullException("flds");
		}
		if (flds.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ArrayZeroError"));
		}
		IntPtr[] array = new IntPtr[flds.Length];
		RuntimeType runtimeType = (RuntimeType)target.GetType();
		for (int i = 0; i < flds.Length; i++)
		{
			RuntimeFieldInfo runtimeFieldInfo = flds[i] as RuntimeFieldInfo;
			if (runtimeFieldInfo == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_MustBeRuntimeFieldInfo"));
			}
			if (runtimeFieldInfo.IsInitOnly || runtimeFieldInfo.IsStatic)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_TypedReferenceInvalidField"));
			}
			if (runtimeType != runtimeFieldInfo.GetDeclaringTypeInternal() && !runtimeType.IsSubclassOf(runtimeFieldInfo.GetDeclaringTypeInternal()))
			{
				throw new MissingMemberException(Environment.GetResourceString("MissingMemberTypeRef"));
			}
			RuntimeType runtimeType2 = (RuntimeType)runtimeFieldInfo.FieldType;
			if (runtimeType2.IsPrimitive)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_TypeRefPrimitve"));
			}
			if (i < flds.Length - 1 && !runtimeType2.IsValueType)
			{
				throw new MissingMemberException(Environment.GetResourceString("MissingMemberNestErr"));
			}
			array[i] = runtimeFieldInfo.FieldHandle.Value;
			runtimeType = runtimeType2;
		}
		TypedReference result = default(TypedReference);
		InternalMakeTypedReference(&result, target, array, runtimeType);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType);

	public override int GetHashCode()
	{
		if (Type == IntPtr.Zero)
		{
			return 0;
		}
		return __reftype(this).GetHashCode();
	}

	public override bool Equals(object o)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_NYI"));
	}

	[SecuritySafeCritical]
	public unsafe static object ToObject(TypedReference value)
	{
		return InternalToObject(&value);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern object InternalToObject(void* value);

	public static Type GetTargetType(TypedReference value)
	{
		return __reftype(value);
	}

	public static RuntimeTypeHandle TargetTypeToken(TypedReference value)
	{
		return __reftype(value).TypeHandle;
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	public unsafe static void SetTypedReference(TypedReference target, object value)
	{
		InternalSetTypedReference(&target, value);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern void InternalSetTypedReference(void* target, object value);
}
