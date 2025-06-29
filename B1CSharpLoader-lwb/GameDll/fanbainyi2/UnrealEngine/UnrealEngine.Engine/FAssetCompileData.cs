using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.AssetCompileData", "Engine", UnrealModuleType.Engine)]
public struct FAssetCompileData
{
	private static bool Asset_IsValid;

	private static int Asset_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/Engine.AssetCompileData:Asset")]
	public TWeakObject<UObject> Asset;

	private static bool FAssetCompileData_IsValid;

	private static int FAssetCompileData_StructSize;

	public FAssetCompileData Copy()
	{
		return this;
	}

	public static FAssetCompileData FromNative(IntPtr nativeBuffer)
	{
		return new FAssetCompileData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAssetCompileData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAssetCompileData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAssetCompileData(nativeBuffer + arrayIndex * FAssetCompileData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAssetCompileData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAssetCompileData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAssetCompileData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AssetCompileData");
		}
		else
		{
			TWeakObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, Asset_Offset), Asset);
		}
	}

	public FAssetCompileData(IntPtr nativeStruct)
	{
		if (!FAssetCompileData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AssetCompileData");
			Asset = default(TWeakObject<UObject>);
		}
		else
		{
			Asset = TWeakObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, Asset_Offset));
		}
	}

	static FAssetCompileData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAssetCompileData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAssetCompileData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AssetCompileData");
		FAssetCompileData_StructSize = NativeReflection.GetStructSize(intPtr);
		Asset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Asset");
		Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Asset", Classes.FWeakObjectProperty);
		FAssetCompileData_IsValid = intPtr != IntPtr.Zero && Asset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AssetCompileData", FAssetCompileData_IsValid);
	}
}
