using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.B1DBC_ExtraSetting")]
public struct B1DBC_ExtraSetting
{
	[DisplayName("特效位置类型")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.B1DBC_ExtraSetting:TransformType")]
	public EDBCTransformType TransformType;

	private static int B1DBC_ExtraSetting_StructSize;

	private static int B1DBC_ExtraSetting_IsValid;

	private static bool TransformType_IsValid;

	private static int TransformType_Offset;

	private static FFieldAddress TransformType_PropertyAddress;

	public B1DBC_ExtraSetting Copy()
	{
		return this;
	}

	public static B1DBC_ExtraSetting FromNative(IntPtr nativeBuffer)
	{
		return new B1DBC_ExtraSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, B1DBC_ExtraSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static B1DBC_ExtraSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new B1DBC_ExtraSetting(IntPtr.Add(nativeBuffer, arrayIndex * B1DBC_ExtraSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, B1DBC_ExtraSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * B1DBC_ExtraSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (B1DBC_ExtraSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.B1DBC_ExtraSetting");
		}
		else
		{
			EnumMarshaler<EDBCTransformType>.ToNative(IntPtr.Add(nativeStruct, TransformType_Offset), 0, TransformType_PropertyAddress.Address, TransformType);
		}
	}

	public B1DBC_ExtraSetting(IntPtr nativeStruct)
	{
		if (B1DBC_ExtraSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.B1DBC_ExtraSetting");
			TransformType = EDBCTransformType.SweepCheck;
		}
		else
		{
			TransformType = EnumMarshaler<EDBCTransformType>.FromNative(IntPtr.Add(nativeStruct, TransformType_Offset), 0, TransformType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.B1DBC_ExtraSetting");
		B1DBC_ExtraSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref TransformType_PropertyAddress, intPtr, "TransformType");
		TransformType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransformType");
		TransformType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransformType", Classes.FEnumProperty);
		B1DBC_ExtraSetting_IsValid = ((intPtr != IntPtr.Zero && TransformType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.B1DBC_ExtraSetting", (byte)B1DBC_ExtraSetting_IsValid != 0);
	}

	static B1DBC_ExtraSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(B1DBC_ExtraSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(B1DBC_ExtraSetting));
	}
}
