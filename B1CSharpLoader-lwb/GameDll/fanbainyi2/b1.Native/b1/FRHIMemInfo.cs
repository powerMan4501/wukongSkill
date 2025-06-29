using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.RHIMemInfo", "b1", UnrealModuleType.Game)]
public struct FRHIMemInfo
{
	private static bool TotalVRAM_IsValid;

	private static int TotalVRAM_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.RHIMemInfo:TotalVRAM")]
	public float TotalVRAM;

	private static bool SummaryInfo_IsValid;

	private static FFieldAddress SummaryInfo_PropertyAddress;

	private static int SummaryInfo_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/b1.RHIMemInfo:SummaryInfo")]
	public Dictionary<string, FRHIResourceSummaryInfo> SummaryInfo;

	private static bool FRHIMemInfo_IsValid;

	private static int FRHIMemInfo_StructSize;

	public FRHIMemInfo Copy()
	{
		FRHIMemInfo result = this;
		if (SummaryInfo != null)
		{
			result.SummaryInfo = new Dictionary<string, FRHIResourceSummaryInfo>(SummaryInfo);
		}
		return result;
	}

	public static FRHIMemInfo FromNative(IntPtr nativeBuffer)
	{
		return new FRHIMemInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRHIMemInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRHIMemInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRHIMemInfo(nativeBuffer + arrayIndex * FRHIMemInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRHIMemInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRHIMemInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRHIMemInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.RHIMemInfo");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TotalVRAM_Offset), TotalVRAM);
		new TMapCopyMarshaler<string, FRHIResourceSummaryInfo>(1, SummaryInfo_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FRHIResourceSummaryInfo, FRHIResourceSummaryInfo>.FromNative, CachedMarshalingDelegates<FRHIResourceSummaryInfo, FRHIResourceSummaryInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, SummaryInfo_Offset), SummaryInfo);
	}

	public FRHIMemInfo(IntPtr nativeStruct)
	{
		if (!FRHIMemInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.RHIMemInfo");
			TotalVRAM = 0f;
			SummaryInfo = null;
		}
		else
		{
			TotalVRAM = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TotalVRAM_Offset));
			SummaryInfo = new TMapCopyMarshaler<string, FRHIResourceSummaryInfo>(1, SummaryInfo_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FRHIResourceSummaryInfo, FRHIResourceSummaryInfo>.FromNative, CachedMarshalingDelegates<FRHIResourceSummaryInfo, FRHIResourceSummaryInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, SummaryInfo_Offset));
		}
	}

	static FRHIMemInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRHIMemInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRHIMemInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.RHIMemInfo");
		FRHIMemInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		TotalVRAM_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalVRAM");
		TotalVRAM_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalVRAM", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SummaryInfo_PropertyAddress, intPtr, "SummaryInfo");
		SummaryInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SummaryInfo");
		SummaryInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SummaryInfo", Classes.FMapProperty);
		FRHIMemInfo_IsValid = intPtr != IntPtr.Zero && TotalVRAM_IsValid && SummaryInfo_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.RHIMemInfo", FRHIMemInfo_IsValid);
	}
}
