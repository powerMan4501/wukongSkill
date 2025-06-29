using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSStreamingLevelLoadSetting", "b1", UnrealModuleType.Game)]
public struct FGSStreamingLevelLoadSetting
{
	private static bool ShouldBeLoaded_IsValid;

	private static FFieldAddress ShouldBeLoaded_PropertyAddress;

	private static int ShouldBeLoaded_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.GSStreamingLevelLoadSetting:bShouldBeLoaded")]
	public bool ShouldBeLoaded;

	private static bool ShouldBeVisible_IsValid;

	private static FFieldAddress ShouldBeVisible_PropertyAddress;

	private static int ShouldBeVisible_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.GSStreamingLevelLoadSetting:bShouldBeVisible")]
	public bool ShouldBeVisible;

	private static bool ShouldBlockOnLoad_IsValid;

	private static FFieldAddress ShouldBlockOnLoad_PropertyAddress;

	private static int ShouldBlockOnLoad_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/b1.GSStreamingLevelLoadSetting:bShouldBlockOnLoad")]
	public bool ShouldBlockOnLoad;

	private static bool FGSStreamingLevelLoadSetting_IsValid;

	private static int FGSStreamingLevelLoadSetting_StructSize;

	public FGSStreamingLevelLoadSetting Copy()
	{
		return this;
	}

	public static FGSStreamingLevelLoadSetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSStreamingLevelLoadSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSStreamingLevelLoadSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSStreamingLevelLoadSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSStreamingLevelLoadSetting(nativeBuffer + arrayIndex * FGSStreamingLevelLoadSetting_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSStreamingLevelLoadSetting value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSStreamingLevelLoadSetting_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSStreamingLevelLoadSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSStreamingLevelLoadSetting");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShouldBeLoaded_Offset), 0, ShouldBeLoaded_PropertyAddress.Address, ShouldBeLoaded);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShouldBeVisible_Offset), 0, ShouldBeVisible_PropertyAddress.Address, ShouldBeVisible);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShouldBlockOnLoad_Offset), 0, ShouldBlockOnLoad_PropertyAddress.Address, ShouldBlockOnLoad);
	}

	public FGSStreamingLevelLoadSetting(IntPtr nativeStruct)
	{
		if (!FGSStreamingLevelLoadSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSStreamingLevelLoadSetting");
			ShouldBeLoaded = false;
			ShouldBeVisible = false;
			ShouldBlockOnLoad = false;
		}
		else
		{
			ShouldBeLoaded = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShouldBeLoaded_Offset), 0, ShouldBeLoaded_PropertyAddress.Address);
			ShouldBeVisible = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShouldBeVisible_Offset), 0, ShouldBeVisible_PropertyAddress.Address);
			ShouldBlockOnLoad = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShouldBlockOnLoad_Offset), 0, ShouldBlockOnLoad_PropertyAddress.Address);
		}
	}

	static FGSStreamingLevelLoadSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSStreamingLevelLoadSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSStreamingLevelLoadSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSStreamingLevelLoadSetting");
		FGSStreamingLevelLoadSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ShouldBeLoaded_PropertyAddress, intPtr, "bShouldBeLoaded");
		ShouldBeLoaded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldBeLoaded");
		ShouldBeLoaded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldBeLoaded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldBeVisible_PropertyAddress, intPtr, "bShouldBeVisible");
		ShouldBeVisible_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldBeVisible");
		ShouldBeVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldBeVisible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldBlockOnLoad_PropertyAddress, intPtr, "bShouldBlockOnLoad");
		ShouldBlockOnLoad_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldBlockOnLoad");
		ShouldBlockOnLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldBlockOnLoad", Classes.FBoolProperty);
		FGSStreamingLevelLoadSetting_IsValid = intPtr != IntPtr.Zero && ShouldBeLoaded_IsValid && ShouldBeVisible_IsValid && ShouldBlockOnLoad_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSStreamingLevelLoadSetting", FGSStreamingLevelLoadSetting_IsValid);
	}
}
