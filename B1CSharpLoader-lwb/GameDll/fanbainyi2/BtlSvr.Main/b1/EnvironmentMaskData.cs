using System;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.EnvironmentMaskData")]
public struct EnvironmentMaskData
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.EnvironmentMaskData:SurfaceType")]
	public ESceneItemSurfaceType SurfaceType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("本次notify应用的增量")]
	[UMeta(MDProp.ClampMin, "-1.0f")]
	[UProperty]
	[UMeta(MDProp.ClampMax, "1.0f")]
	[USharpPath("/Script/b1-Managed.EnvironmentMaskData:Increment")]
	public float Increment;

	private static int EnvironmentMaskData_StructSize;

	private static int EnvironmentMaskData_IsValid;

	private static bool SurfaceType_IsValid;

	private static int SurfaceType_Offset;

	private static FFieldAddress SurfaceType_PropertyAddress;

	private static bool Increment_IsValid;

	private static int Increment_Offset;

	public EnvironmentMaskData Copy()
	{
		return this;
	}

	public static EnvironmentMaskData FromNative(IntPtr nativeBuffer)
	{
		return new EnvironmentMaskData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, EnvironmentMaskData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static EnvironmentMaskData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new EnvironmentMaskData(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentMaskData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, EnvironmentMaskData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EnvironmentMaskData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EnvironmentMaskData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentMaskData");
			return;
		}
		EnumMarshaler<ESceneItemSurfaceType>.ToNative(IntPtr.Add(nativeStruct, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address, SurfaceType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Increment_Offset), Increment);
	}

	public EnvironmentMaskData(IntPtr nativeStruct)
	{
		if (EnvironmentMaskData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvironmentMaskData");
			SurfaceType = ESceneItemSurfaceType.DefaultSurface;
			Increment = 0f;
		}
		else
		{
			SurfaceType = EnumMarshaler<ESceneItemSurfaceType>.FromNative(IntPtr.Add(nativeStruct, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address);
			Increment = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Increment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EnvironmentMaskData");
		EnvironmentMaskData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SurfaceType_PropertyAddress, intPtr, "SurfaceType");
		SurfaceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SurfaceType");
		SurfaceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SurfaceType", Classes.FEnumProperty);
		Increment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Increment");
		Increment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Increment", Classes.FFloatProperty);
		EnvironmentMaskData_IsValid = ((intPtr != IntPtr.Zero && SurfaceType_IsValid && Increment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EnvironmentMaskData", (byte)EnvironmentMaskData_IsValid != 0);
	}

	static EnvironmentMaskData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(EnvironmentMaskData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(EnvironmentMaskData));
	}
}
