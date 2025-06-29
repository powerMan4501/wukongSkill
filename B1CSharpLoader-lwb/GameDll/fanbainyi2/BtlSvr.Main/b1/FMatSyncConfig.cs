using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MatSyncConfig")]
public struct FMatSyncConfig
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MatSyncConfig:Name")]
	public FName Name;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MatSyncConfig:MatType")]
	public EMatType MatType;

	private static int MatSyncConfig_StructSize;

	private static int MatSyncConfig_IsValid;

	private static bool Name_IsValid;

	private static int Name_Offset;

	private static bool MatType_IsValid;

	private static int MatType_Offset;

	private static FFieldAddress MatType_PropertyAddress;

	public FMatSyncConfig Copy()
	{
		return this;
	}

	public static FMatSyncConfig FromNative(IntPtr nativeBuffer)
	{
		return new FMatSyncConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMatSyncConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMatSyncConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMatSyncConfig(IntPtr.Add(nativeBuffer, arrayIndex * MatSyncConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMatSyncConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MatSyncConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MatSyncConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatSyncConfig");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		EnumMarshaler<EMatType>.ToNative(IntPtr.Add(nativeStruct, MatType_Offset), 0, MatType_PropertyAddress.Address, MatType);
	}

	public FMatSyncConfig(IntPtr nativeStruct)
	{
		if (MatSyncConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatSyncConfig");
			Name = default(FName);
			MatType = EMatType.Scale;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			MatType = EnumMarshaler<EMatType>.FromNative(IntPtr.Add(nativeStruct, MatType_Offset), 0, MatType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MatSyncConfig");
		MatSyncConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflection.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref MatType_PropertyAddress, intPtr, "MatType");
		MatType_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatType");
		MatType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatType", Classes.FEnumProperty);
		MatSyncConfig_IsValid = ((intPtr != IntPtr.Zero && Name_IsValid && MatType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MatSyncConfig", (byte)MatSyncConfig_IsValid != 0);
	}

	static FMatSyncConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMatSyncConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMatSyncConfig));
	}
}
