using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.GSInputBlendPose", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public struct FGSInputBlendPose
{
	private static bool BranchFilters_IsValid;

	private static FFieldAddress BranchFilters_PropertyAddress;

	private static int BranchFilters_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/GSEngineExtent.GSInputBlendPose:BranchFilters")]
	public List<FGSBranchFilter> BranchFilters;

	private static bool FGSInputBlendPose_IsValid;

	private static int FGSInputBlendPose_StructSize;

	public FGSInputBlendPose Copy()
	{
		FGSInputBlendPose result = this;
		if (BranchFilters != null)
		{
			result.BranchFilters = new List<FGSBranchFilter>(BranchFilters);
		}
		return result;
	}

	public static FGSInputBlendPose FromNative(IntPtr nativeBuffer)
	{
		return new FGSInputBlendPose(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSInputBlendPose value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSInputBlendPose FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSInputBlendPose(nativeBuffer + arrayIndex * FGSInputBlendPose_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSInputBlendPose value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSInputBlendPose_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSInputBlendPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.GSInputBlendPose");
		}
		else
		{
			new TArrayCopyMarshaler<FGSBranchFilter>(1, BranchFilters_PropertyAddress, CachedMarshalingDelegates<FGSBranchFilter, FGSBranchFilter>.FromNative, CachedMarshalingDelegates<FGSBranchFilter, FGSBranchFilter>.ToNative).ToNative(IntPtr.Add(nativeStruct, BranchFilters_Offset), BranchFilters);
		}
	}

	public FGSInputBlendPose(IntPtr nativeStruct)
	{
		if (!FGSInputBlendPose_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.GSInputBlendPose");
			BranchFilters = null;
		}
		else
		{
			BranchFilters = new TArrayCopyMarshaler<FGSBranchFilter>(1, BranchFilters_PropertyAddress, CachedMarshalingDelegates<FGSBranchFilter, FGSBranchFilter>.FromNative, CachedMarshalingDelegates<FGSBranchFilter, FGSBranchFilter>.ToNative).FromNative(IntPtr.Add(nativeStruct, BranchFilters_Offset));
		}
	}

	static FGSInputBlendPose()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSInputBlendPose)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSInputBlendPose));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEngineExtent.GSInputBlendPose");
		FGSInputBlendPose_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BranchFilters_PropertyAddress, intPtr, "BranchFilters");
		BranchFilters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BranchFilters");
		BranchFilters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BranchFilters", Classes.FArrayProperty);
		FGSInputBlendPose_IsValid = intPtr != IntPtr.Zero && BranchFilters_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEngineExtent.GSInputBlendPose", FGSInputBlendPose_IsValid);
	}
}
