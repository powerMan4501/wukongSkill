using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.AsyncLineTraceReqArray", "UnrealExtent", UnrealModuleType.Game)]
public struct FAsyncLineTraceReqArray
{
	private static bool ReqArr_IsValid;

	private static FFieldAddress ReqArr_PropertyAddress;

	private static int ReqArr_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/UnrealExtent.AsyncLineTraceReqArray:ReqArr")]
	public List<FAsyncLineTraceReq> ReqArr;

	private static bool FAsyncLineTraceReqArray_IsValid;

	private static int FAsyncLineTraceReqArray_StructSize;

	public FAsyncLineTraceReqArray Copy()
	{
		FAsyncLineTraceReqArray result = this;
		if (ReqArr != null)
		{
			result.ReqArr = new List<FAsyncLineTraceReq>(ReqArr);
		}
		return result;
	}

	public static FAsyncLineTraceReqArray FromNative(IntPtr nativeBuffer)
	{
		return new FAsyncLineTraceReqArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAsyncLineTraceReqArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAsyncLineTraceReqArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAsyncLineTraceReqArray(nativeBuffer + arrayIndex * FAsyncLineTraceReqArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAsyncLineTraceReqArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAsyncLineTraceReqArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAsyncLineTraceReqArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AsyncLineTraceReqArray");
		}
		else
		{
			new TArrayCopyMarshaler<FAsyncLineTraceReq>(1, ReqArr_PropertyAddress, CachedMarshalingDelegates<FAsyncLineTraceReq, FAsyncLineTraceReq>.FromNative, CachedMarshalingDelegates<FAsyncLineTraceReq, FAsyncLineTraceReq>.ToNative).ToNative(IntPtr.Add(nativeStruct, ReqArr_Offset), ReqArr);
		}
	}

	public FAsyncLineTraceReqArray(IntPtr nativeStruct)
	{
		if (!FAsyncLineTraceReqArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AsyncLineTraceReqArray");
			ReqArr = null;
		}
		else
		{
			ReqArr = new TArrayCopyMarshaler<FAsyncLineTraceReq>(1, ReqArr_PropertyAddress, CachedMarshalingDelegates<FAsyncLineTraceReq, FAsyncLineTraceReq>.FromNative, CachedMarshalingDelegates<FAsyncLineTraceReq, FAsyncLineTraceReq>.ToNative).FromNative(IntPtr.Add(nativeStruct, ReqArr_Offset));
		}
	}

	static FAsyncLineTraceReqArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAsyncLineTraceReqArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAsyncLineTraceReqArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.AsyncLineTraceReqArray");
		FAsyncLineTraceReqArray_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ReqArr_PropertyAddress, intPtr, "ReqArr");
		ReqArr_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReqArr");
		ReqArr_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReqArr", Classes.FArrayProperty);
		FAsyncLineTraceReqArray_IsValid = intPtr != IntPtr.Zero && ReqArr_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.AsyncLineTraceReqArray", FAsyncLineTraceReqArray_IsValid);
	}
}
