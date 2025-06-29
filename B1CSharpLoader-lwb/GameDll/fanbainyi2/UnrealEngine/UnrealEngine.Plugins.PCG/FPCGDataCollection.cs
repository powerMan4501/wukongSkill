using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDataCollection", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGDataCollection
{
	private static bool TaggedData_IsValid;

	private static FFieldAddress TaggedData_PropertyAddress;

	private static int TaggedData_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGDataCollection:TaggedData")]
	public List<FPCGTaggedData> TaggedData;

	private static bool CancelExecutionOnEmpty_IsValid;

	private static FFieldAddress CancelExecutionOnEmpty_PropertyAddress;

	private static int CancelExecutionOnEmpty_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDataCollection:bCancelExecutionOnEmpty")]
	public bool CancelExecutionOnEmpty;

	private static bool FPCGDataCollection_IsValid;

	private static int FPCGDataCollection_StructSize;

	public FPCGDataCollection Copy()
	{
		FPCGDataCollection result = this;
		if (TaggedData != null)
		{
			result.TaggedData = new List<FPCGTaggedData>(TaggedData);
		}
		return result;
	}

	public static FPCGDataCollection FromNative(IntPtr nativeBuffer)
	{
		return new FPCGDataCollection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGDataCollection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGDataCollection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGDataCollection(nativeBuffer + arrayIndex * FPCGDataCollection_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGDataCollection value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGDataCollection_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGDataCollection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGDataCollection");
			return;
		}
		new TArrayCopyMarshaler<FPCGTaggedData>(1, TaggedData_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).ToNative(IntPtr.Add(nativeStruct, TaggedData_Offset), TaggedData);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CancelExecutionOnEmpty_Offset), 0, CancelExecutionOnEmpty_PropertyAddress.Address, CancelExecutionOnEmpty);
	}

	public FPCGDataCollection(IntPtr nativeStruct)
	{
		if (!FPCGDataCollection_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGDataCollection");
			TaggedData = null;
			CancelExecutionOnEmpty = false;
		}
		else
		{
			TaggedData = new TArrayCopyMarshaler<FPCGTaggedData>(1, TaggedData_PropertyAddress, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.FromNative, CachedMarshalingDelegates<FPCGTaggedData, FPCGTaggedData>.ToNative).FromNative(IntPtr.Add(nativeStruct, TaggedData_Offset));
			CancelExecutionOnEmpty = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CancelExecutionOnEmpty_Offset), 0, CancelExecutionOnEmpty_PropertyAddress.Address);
		}
	}

	static FPCGDataCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGDataCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGDataCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGDataCollection");
		FPCGDataCollection_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref TaggedData_PropertyAddress, intPtr, "TaggedData");
		TaggedData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TaggedData");
		TaggedData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TaggedData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CancelExecutionOnEmpty_PropertyAddress, intPtr, "bCancelExecutionOnEmpty");
		CancelExecutionOnEmpty_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCancelExecutionOnEmpty");
		CancelExecutionOnEmpty_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCancelExecutionOnEmpty", Classes.FBoolProperty);
		FPCGDataCollection_IsValid = intPtr != IntPtr.Zero && TaggedData_IsValid && CancelExecutionOnEmpty_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGDataCollection", FPCGDataCollection_IsValid);
	}
}
