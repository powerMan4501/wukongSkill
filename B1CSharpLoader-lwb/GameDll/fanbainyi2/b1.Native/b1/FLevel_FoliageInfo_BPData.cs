using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Foliage;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.Level_FoliageInfo_BPData", "FuncLibEditor", UnrealModuleType.Game)]
public struct FLevel_FoliageInfo_BPData
{
	private static bool Level_IsValid;

	private static int Level_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.Level_FoliageInfo_BPData:Level")]
	public ULevel Level;

	private static bool Instance_IsValid;

	private static FFieldAddress Instance_PropertyAddress;

	private static int Instance_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/FuncLibEditor.Level_FoliageInfo_BPData:Instance")]
	public Dictionary<UFoliageType, FFoliageInstanceDataArray> Instance;

	private static bool FLevel_FoliageInfo_BPData_IsValid;

	private static int FLevel_FoliageInfo_BPData_StructSize;

	public FLevel_FoliageInfo_BPData Copy()
	{
		FLevel_FoliageInfo_BPData result = this;
		if (Instance != null)
		{
			result.Instance = new Dictionary<UFoliageType, FFoliageInstanceDataArray>(Instance);
		}
		return result;
	}

	public static FLevel_FoliageInfo_BPData FromNative(IntPtr nativeBuffer)
	{
		return new FLevel_FoliageInfo_BPData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLevel_FoliageInfo_BPData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLevel_FoliageInfo_BPData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLevel_FoliageInfo_BPData(nativeBuffer + arrayIndex * FLevel_FoliageInfo_BPData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLevel_FoliageInfo_BPData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLevel_FoliageInfo_BPData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLevel_FoliageInfo_BPData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.Level_FoliageInfo_BPData");
			return;
		}
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(nativeStruct, Level_Offset), Level);
		new TMapCopyMarshaler<UFoliageType, FFoliageInstanceDataArray>(1, Instance_PropertyAddress, CachedMarshalingDelegates<UFoliageType, UObjectMarshaler<UFoliageType>>.FromNative, CachedMarshalingDelegates<UFoliageType, UObjectMarshaler<UFoliageType>>.ToNative, CachedMarshalingDelegates<FFoliageInstanceDataArray, FFoliageInstanceDataArray>.FromNative, CachedMarshalingDelegates<FFoliageInstanceDataArray, FFoliageInstanceDataArray>.ToNative).ToNative(IntPtr.Add(nativeStruct, Instance_Offset), Instance);
	}

	public FLevel_FoliageInfo_BPData(IntPtr nativeStruct)
	{
		if (!FLevel_FoliageInfo_BPData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.Level_FoliageInfo_BPData");
			Level = null;
			Instance = null;
		}
		else
		{
			Level = UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(nativeStruct, Level_Offset));
			Instance = new TMapCopyMarshaler<UFoliageType, FFoliageInstanceDataArray>(1, Instance_PropertyAddress, CachedMarshalingDelegates<UFoliageType, UObjectMarshaler<UFoliageType>>.FromNative, CachedMarshalingDelegates<UFoliageType, UObjectMarshaler<UFoliageType>>.ToNative, CachedMarshalingDelegates<FFoliageInstanceDataArray, FFoliageInstanceDataArray>.FromNative, CachedMarshalingDelegates<FFoliageInstanceDataArray, FFoliageInstanceDataArray>.ToNative).FromNative(IntPtr.Add(nativeStruct, Instance_Offset));
		}
	}

	static FLevel_FoliageInfo_BPData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLevel_FoliageInfo_BPData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLevel_FoliageInfo_BPData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.Level_FoliageInfo_BPData");
		FLevel_FoliageInfo_BPData_StructSize = NativeReflection.GetStructSize(intPtr);
		Level_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Level");
		Level_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Instance_PropertyAddress, intPtr, "Instance");
		Instance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Instance");
		Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Instance", Classes.FMapProperty);
		FLevel_FoliageInfo_BPData_IsValid = intPtr != IntPtr.Zero && Level_IsValid && Instance_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.Level_FoliageInfo_BPData", FLevel_FoliageInfo_BPData_IsValid);
	}
}
