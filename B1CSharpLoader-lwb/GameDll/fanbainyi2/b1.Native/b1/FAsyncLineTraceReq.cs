using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.AsyncLineTraceReq", "UnrealExtent", UnrealModuleType.Game)]
public struct FAsyncLineTraceReq
{
	private static bool ReqID_IsValid;

	private static int ReqID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.AsyncLineTraceReq:ReqID")]
	public int ReqID;

	private static bool TraceStart_IsValid;

	private static int TraceStart_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.AsyncLineTraceReq:TraceStart")]
	public FVector TraceStart;

	private static bool TraceEnd_IsValid;

	private static int TraceEnd_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.AsyncLineTraceReq:TraceEnd")]
	public FVector TraceEnd;

	private static bool FAsyncLineTraceReq_IsValid;

	private static int FAsyncLineTraceReq_StructSize;

	public FAsyncLineTraceReq Copy()
	{
		return this;
	}

	public static FAsyncLineTraceReq FromNative(IntPtr nativeBuffer)
	{
		return new FAsyncLineTraceReq(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAsyncLineTraceReq value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAsyncLineTraceReq FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAsyncLineTraceReq(nativeBuffer + arrayIndex * FAsyncLineTraceReq_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAsyncLineTraceReq value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAsyncLineTraceReq_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAsyncLineTraceReq_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AsyncLineTraceReq");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ReqID_Offset), ReqID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, TraceStart_Offset), TraceStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, TraceEnd_Offset), TraceEnd);
	}

	public FAsyncLineTraceReq(IntPtr nativeStruct)
	{
		if (!FAsyncLineTraceReq_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AsyncLineTraceReq");
			ReqID = 0;
			TraceStart = default(FVector);
			TraceEnd = default(FVector);
		}
		else
		{
			ReqID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ReqID_Offset));
			TraceStart = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, TraceStart_Offset));
			TraceEnd = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, TraceEnd_Offset));
		}
	}

	static FAsyncLineTraceReq()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAsyncLineTraceReq)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAsyncLineTraceReq));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.AsyncLineTraceReq");
		FAsyncLineTraceReq_StructSize = NativeReflection.GetStructSize(intPtr);
		ReqID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReqID");
		ReqID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReqID", Classes.FIntProperty);
		TraceStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TraceStart");
		TraceStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TraceStart", Classes.FStructProperty);
		TraceEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TraceEnd");
		TraceEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TraceEnd", Classes.FStructProperty);
		FAsyncLineTraceReq_IsValid = intPtr != IntPtr.Zero && ReqID_IsValid && TraceStart_IsValid && TraceEnd_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.AsyncLineTraceReq", FAsyncLineTraceReq_IsValid);
	}
}
