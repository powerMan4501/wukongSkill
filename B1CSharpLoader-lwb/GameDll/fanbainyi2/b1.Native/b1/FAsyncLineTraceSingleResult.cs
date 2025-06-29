using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.AsyncLineTraceSingleResult", "UnrealExtent", UnrealModuleType.Game)]
public struct FAsyncLineTraceSingleResult
{
	private static bool ReqID_IsValid;

	private static int ReqID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.AsyncLineTraceSingleResult:ReqID")]
	public int ReqID;

	private static bool HitResults_IsValid;

	private static FFieldAddress HitResults_PropertyAddress;

	private static int HitResults_Offset;

	[UProperty(Flags = (PropFlags)4504149383184900uL)]
	[UMetaPath("/Script/UnrealExtent.AsyncLineTraceSingleResult:HitResults")]
	public List<FHitResult> HitResults;

	private static bool FAsyncLineTraceSingleResult_IsValid;

	private static int FAsyncLineTraceSingleResult_StructSize;

	public FAsyncLineTraceSingleResult Copy()
	{
		FAsyncLineTraceSingleResult result = this;
		if (HitResults != null)
		{
			result.HitResults = new List<FHitResult>(HitResults);
		}
		return result;
	}

	public static FAsyncLineTraceSingleResult FromNative(IntPtr nativeBuffer)
	{
		return new FAsyncLineTraceSingleResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAsyncLineTraceSingleResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAsyncLineTraceSingleResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAsyncLineTraceSingleResult(nativeBuffer + arrayIndex * FAsyncLineTraceSingleResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAsyncLineTraceSingleResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAsyncLineTraceSingleResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAsyncLineTraceSingleResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AsyncLineTraceSingleResult");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ReqID_Offset), ReqID);
		new TArrayCopyMarshaler<FHitResult>(1, HitResults_PropertyAddress, CachedMarshalingDelegates<FHitResult, FHitResult>.FromNative, CachedMarshalingDelegates<FHitResult, FHitResult>.ToNative).ToNative(IntPtr.Add(nativeStruct, HitResults_Offset), HitResults);
	}

	public FAsyncLineTraceSingleResult(IntPtr nativeStruct)
	{
		if (!FAsyncLineTraceSingleResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AsyncLineTraceSingleResult");
			ReqID = 0;
			HitResults = null;
		}
		else
		{
			ReqID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ReqID_Offset));
			HitResults = new TArrayCopyMarshaler<FHitResult>(1, HitResults_PropertyAddress, CachedMarshalingDelegates<FHitResult, FHitResult>.FromNative, CachedMarshalingDelegates<FHitResult, FHitResult>.ToNative).FromNative(IntPtr.Add(nativeStruct, HitResults_Offset));
		}
	}

	static FAsyncLineTraceSingleResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAsyncLineTraceSingleResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAsyncLineTraceSingleResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.AsyncLineTraceSingleResult");
		FAsyncLineTraceSingleResult_StructSize = NativeReflection.GetStructSize(intPtr);
		ReqID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReqID");
		ReqID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReqID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HitResults_PropertyAddress, intPtr, "HitResults");
		HitResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitResults");
		HitResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitResults", Classes.FArrayProperty);
		FAsyncLineTraceSingleResult_IsValid = intPtr != IntPtr.Zero && ReqID_IsValid && HitResults_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.AsyncLineTraceSingleResult", FAsyncLineTraceSingleResult_IsValid);
	}
}
