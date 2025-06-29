using System;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_CheckSurfaceType")]
public struct FDetectCondition_CheckSurfaceType
{
	[EditAnywhere]
	[DisplayName("地面物理材质")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_CheckSurfaceType:SurfaceType")]
	public ESceneItemSurfaceType SurfaceType;

	private static int DetectCondition_CheckSurfaceType_StructSize;

	private static int DetectCondition_CheckSurfaceType_IsValid;

	private static bool SurfaceType_IsValid;

	private static int SurfaceType_Offset;

	private static FFieldAddress SurfaceType_PropertyAddress;

	public FDetectCondition_CheckSurfaceType Copy()
	{
		return this;
	}

	public static FDetectCondition_CheckSurfaceType FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_CheckSurfaceType(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_CheckSurfaceType value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_CheckSurfaceType FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_CheckSurfaceType(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_CheckSurfaceType_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_CheckSurfaceType value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_CheckSurfaceType_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_CheckSurfaceType_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_CheckSurfaceType");
		}
		else
		{
			EnumMarshaler<ESceneItemSurfaceType>.ToNative(IntPtr.Add(nativeStruct, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address, SurfaceType);
		}
	}

	public FDetectCondition_CheckSurfaceType(IntPtr nativeStruct)
	{
		if (DetectCondition_CheckSurfaceType_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_CheckSurfaceType");
			SurfaceType = ESceneItemSurfaceType.DefaultSurface;
		}
		else
		{
			SurfaceType = EnumMarshaler<ESceneItemSurfaceType>.FromNative(IntPtr.Add(nativeStruct, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_CheckSurfaceType");
		DetectCondition_CheckSurfaceType_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SurfaceType_PropertyAddress, intPtr, "SurfaceType");
		SurfaceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SurfaceType");
		SurfaceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SurfaceType", Classes.FEnumProperty);
		DetectCondition_CheckSurfaceType_IsValid = ((intPtr != IntPtr.Zero && SurfaceType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_CheckSurfaceType", (byte)DetectCondition_CheckSurfaceType_IsValid != 0);
	}

	static FDetectCondition_CheckSurfaceType()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_CheckSurfaceType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_CheckSurfaceType));
	}
}
