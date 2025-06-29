using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomCacheImportSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FGroomCacheImportSettings
{
	private static bool ImportGroomCache_IsValid;

	private static FFieldAddress ImportGroomCache_PropertyAddress;

	private static int ImportGroomCache_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCacheImportSettings:bImportGroomCache")]
	public bool ImportGroomCache;

	private static bool FrameStart_IsValid;

	private static int FrameStart_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCacheImportSettings:FrameStart")]
	public int FrameStart;

	private static bool FrameEnd_IsValid;

	private static int FrameEnd_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCacheImportSettings:FrameEnd")]
	public int FrameEnd;

	private static bool SkipEmptyFrames_IsValid;

	private static FFieldAddress SkipEmptyFrames_PropertyAddress;

	private static int SkipEmptyFrames_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCacheImportSettings:bSkipEmptyFrames")]
	public bool SkipEmptyFrames;

	private static bool ImportGroomAsset_IsValid;

	private static FFieldAddress ImportGroomAsset_PropertyAddress;

	private static int ImportGroomAsset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCacheImportSettings:bImportGroomAsset")]
	public bool ImportGroomAsset;

	private static bool GroomAsset_IsValid;

	private static int GroomAsset_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCacheImportSettings:GroomAsset")]
	public FSoftObjectPath GroomAsset;

	private static bool FGroomCacheImportSettings_IsValid;

	private static int FGroomCacheImportSettings_StructSize;

	public FGroomCacheImportSettings Copy()
	{
		return this;
	}

	public static FGroomCacheImportSettings FromNative(IntPtr nativeBuffer)
	{
		return new FGroomCacheImportSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGroomCacheImportSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGroomCacheImportSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGroomCacheImportSettings(nativeBuffer + arrayIndex * FGroomCacheImportSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGroomCacheImportSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGroomCacheImportSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGroomCacheImportSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GroomCacheImportSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ImportGroomCache_Offset), 0, ImportGroomCache_PropertyAddress.Address, ImportGroomCache);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameStart_Offset), FrameStart);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FrameEnd_Offset), FrameEnd);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipEmptyFrames_Offset), 0, SkipEmptyFrames_PropertyAddress.Address, SkipEmptyFrames);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ImportGroomAsset_Offset), 0, ImportGroomAsset_PropertyAddress.Address, ImportGroomAsset);
		FSoftObjectPath.ToNative(IntPtr.Add(nativeStruct, GroomAsset_Offset), GroomAsset);
	}

	public FGroomCacheImportSettings(IntPtr nativeStruct)
	{
		if (!FGroomCacheImportSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GroomCacheImportSettings");
			ImportGroomCache = false;
			FrameStart = 0;
			FrameEnd = 0;
			SkipEmptyFrames = false;
			ImportGroomAsset = false;
			GroomAsset = default(FSoftObjectPath);
		}
		else
		{
			ImportGroomCache = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ImportGroomCache_Offset), 0, ImportGroomCache_PropertyAddress.Address);
			FrameStart = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameStart_Offset));
			FrameEnd = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FrameEnd_Offset));
			SkipEmptyFrames = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipEmptyFrames_Offset), 0, SkipEmptyFrames_PropertyAddress.Address);
			ImportGroomAsset = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ImportGroomAsset_Offset), 0, ImportGroomAsset_PropertyAddress.Address);
			GroomAsset = FSoftObjectPath.FromNative(IntPtr.Add(nativeStruct, GroomAsset_Offset));
		}
	}

	static FGroomCacheImportSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGroomCacheImportSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGroomCacheImportSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.GroomCacheImportSettings");
		FGroomCacheImportSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ImportGroomCache_PropertyAddress, intPtr, "bImportGroomCache");
		ImportGroomCache_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImportGroomCache");
		ImportGroomCache_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImportGroomCache", Classes.FBoolProperty);
		FrameStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameStart");
		FrameStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameStart", Classes.FIntProperty);
		FrameEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameEnd");
		FrameEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameEnd", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipEmptyFrames_PropertyAddress, intPtr, "bSkipEmptyFrames");
		SkipEmptyFrames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipEmptyFrames");
		SkipEmptyFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipEmptyFrames", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportGroomAsset_PropertyAddress, intPtr, "bImportGroomAsset");
		ImportGroomAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImportGroomAsset");
		ImportGroomAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImportGroomAsset", Classes.FBoolProperty);
		GroomAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroomAsset");
		GroomAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroomAsset", Classes.FStructProperty);
		FGroomCacheImportSettings_IsValid = intPtr != IntPtr.Zero && ImportGroomCache_IsValid && FrameStart_IsValid && FrameEnd_IsValid && SkipEmptyFrames_IsValid && ImportGroomAsset_IsValid && GroomAsset_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.GroomCacheImportSettings", FGroomCacheImportSettings_IsValid);
	}
}
