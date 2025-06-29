using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.GSWCGridSetting", "FuncLibEditor", UnrealModuleType.Game)]
public struct FGSWCGridSetting
{
	private static bool GridSize_IsValid;

	private static int GridSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCGridSetting:GridSize")]
	public int GridSize;

	private static bool TileStreamingDistance_IsValid;

	private static int TileStreamingDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCGridSetting:TileStreamingDistance")]
	public int TileStreamingDistance;

	private static bool LODStreamingSettings_IsValid;

	private static FFieldAddress LODStreamingSettings_PropertyAddress;

	private static int LODStreamingSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCGridSetting:LODStreamingSettings")]
	public List<FGSWCLODStreamingSetting> LODStreamingSettings;

	private static bool GridLabel_IsValid;

	private static int GridLabel_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/FuncLibEditor.GSWCGridSetting:GridLabel")]
	public string GridLabel;

	private static bool FGSWCGridSetting_IsValid;

	private static int FGSWCGridSetting_StructSize;

	public FGSWCGridSetting Copy()
	{
		FGSWCGridSetting result = this;
		if (LODStreamingSettings != null)
		{
			result.LODStreamingSettings = new List<FGSWCLODStreamingSetting>(LODStreamingSettings);
		}
		return result;
	}

	public static FGSWCGridSetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSWCGridSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSWCGridSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSWCGridSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSWCGridSetting(nativeBuffer + arrayIndex * FGSWCGridSetting_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSWCGridSetting value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSWCGridSetting_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSWCGridSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSWCGridSetting");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GridSize_Offset), GridSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TileStreamingDistance_Offset), TileStreamingDistance);
		new TArrayCopyMarshaler<FGSWCLODStreamingSetting>(1, LODStreamingSettings_PropertyAddress, CachedMarshalingDelegates<FGSWCLODStreamingSetting, BlittableTypeMarshaler<FGSWCLODStreamingSetting>>.FromNative, CachedMarshalingDelegates<FGSWCLODStreamingSetting, BlittableTypeMarshaler<FGSWCLODStreamingSetting>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LODStreamingSettings_Offset), LODStreamingSettings);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, GridLabel_Offset), GridLabel);
	}

	public FGSWCGridSetting(IntPtr nativeStruct)
	{
		if (!FGSWCGridSetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.GSWCGridSetting");
			GridSize = 0;
			TileStreamingDistance = 0;
			LODStreamingSettings = null;
			GridLabel = FStringMarshaler.DefaultString;
		}
		else
		{
			GridSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GridSize_Offset));
			TileStreamingDistance = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TileStreamingDistance_Offset));
			LODStreamingSettings = new TArrayCopyMarshaler<FGSWCLODStreamingSetting>(1, LODStreamingSettings_PropertyAddress, CachedMarshalingDelegates<FGSWCLODStreamingSetting, BlittableTypeMarshaler<FGSWCLODStreamingSetting>>.FromNative, CachedMarshalingDelegates<FGSWCLODStreamingSetting, BlittableTypeMarshaler<FGSWCLODStreamingSetting>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LODStreamingSettings_Offset));
			GridLabel = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, GridLabel_Offset));
		}
	}

	static FGSWCGridSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSWCGridSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSWCGridSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.GSWCGridSetting");
		FGSWCGridSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		GridSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GridSize");
		GridSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GridSize", Classes.FIntProperty);
		TileStreamingDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TileStreamingDistance");
		TileStreamingDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TileStreamingDistance", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LODStreamingSettings_PropertyAddress, intPtr, "LODStreamingSettings");
		LODStreamingSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODStreamingSettings");
		LODStreamingSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODStreamingSettings", Classes.FArrayProperty);
		GridLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GridLabel");
		GridLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GridLabel", Classes.FStrProperty);
		FGSWCGridSetting_IsValid = intPtr != IntPtr.Zero && GridSize_IsValid && TileStreamingDistance_IsValid && LODStreamingSettings_IsValid && GridLabel_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.GSWCGridSetting", FGSWCGridSetting_IsValid);
	}
}
