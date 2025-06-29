using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 757771)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.PrimaryAssetType", "CoreUObject", UnrealModuleType.Engine)]
public struct FPrimaryAssetType
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.PrimaryAssetType:Name")]
	public FName Name;

	private static bool FPrimaryAssetType_IsValid;

	private static int FPrimaryAssetType_StructSize;

	public FPrimaryAssetType Copy()
	{
		return this;
	}

	public static FPrimaryAssetType FromNative(IntPtr nativeBuffer)
	{
		return new FPrimaryAssetType(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPrimaryAssetType value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPrimaryAssetType FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPrimaryAssetType(nativeBuffer + arrayIndex * FPrimaryAssetType_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPrimaryAssetType value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPrimaryAssetType_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPrimaryAssetType_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.PrimaryAssetType");
		}
		else
		{
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		}
	}

	public FPrimaryAssetType(IntPtr nativeStruct)
	{
		if (!FPrimaryAssetType_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.PrimaryAssetType");
			Name = default(FName);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
		}
	}

	static FPrimaryAssetType()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPrimaryAssetType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPrimaryAssetType));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.PrimaryAssetType");
		FPrimaryAssetType_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		FPrimaryAssetType_IsValid = intPtr != IntPtr.Zero && Name_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.PrimaryAssetType", FPrimaryAssetType_IsValid);
	}
}
