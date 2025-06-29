using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FTraceQueryTestResultsInnerMost
{
	private static bool SingleHit_IsValid;

	private static int SingleHit_Offset;

	[UProperty(Flags = (PropFlags)4504219176402949uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost:SingleHit")]
	public FHitResult SingleHit;

	private static bool SingleNames_IsValid;

	private static int SingleNames_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost:SingleNames")]
	public FTraceQueryTestNames SingleNames;

	private static bool SingleResult_IsValid;

	private static FFieldAddress SingleResult_PropertyAddress;

	private static int SingleResult_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost:bSingleResult")]
	public bool SingleResult;

	private static bool MultiHits_IsValid;

	private static FFieldAddress MultiHits_PropertyAddress;

	private static int MultiHits_Offset;

	[UProperty(Flags = (PropFlags)4504149383184901uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost:MultiHits")]
	public List<FHitResult> MultiHits;

	private static bool MultiNames_IsValid;

	private static FFieldAddress MultiNames_PropertyAddress;

	private static int MultiNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost:MultiNames")]
	public List<FTraceQueryTestNames> MultiNames;

	private static bool MultiResult_IsValid;

	private static FFieldAddress MultiResult_PropertyAddress;

	private static int MultiResult_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost:bMultiResult")]
	public bool MultiResult;

	private static bool FTraceQueryTestResultsInnerMost_IsValid;

	private static int FTraceQueryTestResultsInnerMost_StructSize;

	public FTraceQueryTestResultsInnerMost Copy()
	{
		FTraceQueryTestResultsInnerMost result = this;
		if (MultiHits != null)
		{
			result.MultiHits = new List<FHitResult>(MultiHits);
		}
		if (MultiNames != null)
		{
			result.MultiNames = new List<FTraceQueryTestNames>(MultiNames);
		}
		return result;
	}

	public static FTraceQueryTestResultsInnerMost FromNative(IntPtr nativeBuffer)
	{
		return new FTraceQueryTestResultsInnerMost(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTraceQueryTestResultsInnerMost value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTraceQueryTestResultsInnerMost FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTraceQueryTestResultsInnerMost(nativeBuffer + arrayIndex * FTraceQueryTestResultsInnerMost_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTraceQueryTestResultsInnerMost value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTraceQueryTestResultsInnerMost_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTraceQueryTestResultsInnerMost_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost");
			return;
		}
		FHitResult.ToNative(IntPtr.Add(nativeStruct, SingleHit_Offset), SingleHit);
		FTraceQueryTestNames.ToNative(IntPtr.Add(nativeStruct, SingleNames_Offset), SingleNames);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SingleResult_Offset), 0, SingleResult_PropertyAddress.Address, SingleResult);
		new TArrayCopyMarshaler<FHitResult>(1, MultiHits_PropertyAddress, CachedMarshalingDelegates<FHitResult, FHitResult>.FromNative, CachedMarshalingDelegates<FHitResult, FHitResult>.ToNative).ToNative(IntPtr.Add(nativeStruct, MultiHits_Offset), MultiHits);
		new TArrayCopyMarshaler<FTraceQueryTestNames>(1, MultiNames_PropertyAddress, CachedMarshalingDelegates<FTraceQueryTestNames, FTraceQueryTestNames>.FromNative, CachedMarshalingDelegates<FTraceQueryTestNames, FTraceQueryTestNames>.ToNative).ToNative(IntPtr.Add(nativeStruct, MultiNames_Offset), MultiNames);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MultiResult_Offset), 0, MultiResult_PropertyAddress.Address, MultiResult);
	}

	public FTraceQueryTestResultsInnerMost(IntPtr nativeStruct)
	{
		if (!FTraceQueryTestResultsInnerMost_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost");
			SingleHit = default(FHitResult);
			SingleNames = default(FTraceQueryTestNames);
			SingleResult = false;
			MultiHits = null;
			MultiNames = null;
			MultiResult = false;
		}
		else
		{
			SingleHit = FHitResult.FromNative(IntPtr.Add(nativeStruct, SingleHit_Offset));
			SingleNames = FTraceQueryTestNames.FromNative(IntPtr.Add(nativeStruct, SingleNames_Offset));
			SingleResult = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SingleResult_Offset), 0, SingleResult_PropertyAddress.Address);
			MultiHits = new TArrayCopyMarshaler<FHitResult>(1, MultiHits_PropertyAddress, CachedMarshalingDelegates<FHitResult, FHitResult>.FromNative, CachedMarshalingDelegates<FHitResult, FHitResult>.ToNative).FromNative(IntPtr.Add(nativeStruct, MultiHits_Offset));
			MultiNames = new TArrayCopyMarshaler<FTraceQueryTestNames>(1, MultiNames_PropertyAddress, CachedMarshalingDelegates<FTraceQueryTestNames, FTraceQueryTestNames>.FromNative, CachedMarshalingDelegates<FTraceQueryTestNames, FTraceQueryTestNames>.ToNative).FromNative(IntPtr.Add(nativeStruct, MultiNames_Offset));
			MultiResult = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MultiResult_Offset), 0, MultiResult_PropertyAddress.Address);
		}
	}

	static FTraceQueryTestResultsInnerMost()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTraceQueryTestResultsInnerMost)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTraceQueryTestResultsInnerMost));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost");
		FTraceQueryTestResultsInnerMost_StructSize = NativeReflection.GetStructSize(intPtr);
		SingleHit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SingleHit");
		SingleHit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SingleHit", Classes.FStructProperty);
		SingleNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SingleNames");
		SingleNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SingleNames", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SingleResult_PropertyAddress, intPtr, "bSingleResult");
		SingleResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSingleResult");
		SingleResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSingleResult", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiHits_PropertyAddress, intPtr, "MultiHits");
		MultiHits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MultiHits");
		MultiHits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MultiHits", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiNames_PropertyAddress, intPtr, "MultiNames");
		MultiNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MultiNames");
		MultiNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MultiNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiResult_PropertyAddress, intPtr, "bMultiResult");
		MultiResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMultiResult");
		MultiResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMultiResult", Classes.FBoolProperty);
		FTraceQueryTestResultsInnerMost_IsValid = intPtr != IntPtr.Zero && SingleHit_IsValid && SingleNames_IsValid && SingleResult_IsValid && MultiHits_IsValid && MultiNames_IsValid && MultiResult_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.TraceQueryTestResultsInnerMost", FTraceQueryTestResultsInnerMost_IsValid);
	}
}
