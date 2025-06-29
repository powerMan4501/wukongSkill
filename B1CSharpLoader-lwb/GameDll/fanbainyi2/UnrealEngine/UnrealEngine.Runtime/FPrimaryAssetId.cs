using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 757771)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.PrimaryAssetId", "CoreUObject", UnrealModuleType.Engine)]
public struct FPrimaryAssetId
{
	private static bool PrimaryAssetType_IsValid;

	private static int PrimaryAssetType_Offset;

	[UProperty(Flags = (PropFlags)6755468177310213uL)]
	[UMetaPath("/Script/CoreUObject.PrimaryAssetId:PrimaryAssetType")]
	public FPrimaryAssetType PrimaryAssetType;

	private static bool PrimaryAssetName_IsValid;

	private static int PrimaryAssetName_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.PrimaryAssetId:PrimaryAssetName")]
	public FName PrimaryAssetName;

	private static bool FPrimaryAssetId_IsValid;

	private static int FPrimaryAssetId_StructSize;

	public FPrimaryAssetId Copy()
	{
		return this;
	}

	public static FPrimaryAssetId FromNative(IntPtr nativeBuffer)
	{
		return new FPrimaryAssetId(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPrimaryAssetId value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPrimaryAssetId FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPrimaryAssetId(nativeBuffer + arrayIndex * FPrimaryAssetId_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPrimaryAssetId value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPrimaryAssetId_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPrimaryAssetId_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.PrimaryAssetId");
			return;
		}
		FPrimaryAssetType.ToNative(IntPtr.Add(nativeStruct, PrimaryAssetType_Offset), PrimaryAssetType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PrimaryAssetName_Offset), PrimaryAssetName);
	}

	public FPrimaryAssetId(IntPtr nativeStruct)
	{
		if (!FPrimaryAssetId_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.PrimaryAssetId");
			PrimaryAssetType = default(FPrimaryAssetType);
			PrimaryAssetName = default(FName);
		}
		else
		{
			PrimaryAssetType = FPrimaryAssetType.FromNative(IntPtr.Add(nativeStruct, PrimaryAssetType_Offset));
			PrimaryAssetName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PrimaryAssetName_Offset));
		}
	}

	static FPrimaryAssetId()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPrimaryAssetId)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPrimaryAssetId));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.PrimaryAssetId");
		FPrimaryAssetId_StructSize = NativeReflection.GetStructSize(intPtr);
		PrimaryAssetType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PrimaryAssetType");
		PrimaryAssetType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PrimaryAssetType", Classes.FStructProperty);
		PrimaryAssetName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PrimaryAssetName");
		PrimaryAssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PrimaryAssetName", Classes.FNameProperty);
		FPrimaryAssetId_IsValid = intPtr != IntPtr.Zero && PrimaryAssetType_IsValid && PrimaryAssetName_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.PrimaryAssetId", FPrimaryAssetId_IsValid);
	}
}
