using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject", "UnrealExtent", UnrealModuleType.Game)]
public class UBGUAsyncLineTraceObject : UObject
{
	private static IntPtr classAddress;

	private static bool IgnoreActors_IsValid;

	private static FFieldAddress IgnoreActors_PropertyAddress;

	private static int IgnoreActors_Offset;

	private TArrayReadWriteMarshaler<AActor> IgnoreActors_MarshalerCached;

	private static bool RequestAsyncLineTraceByObjectTypeSingleStatic_IsValid;

	private static IntPtr RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingleStatic_ParamsSize;

	private static bool RequestAsyncLineTraceByObjectTypeSingleStatic_InLineTraceObject_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingleStatic_InLineTraceObject_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingleStatic_InLineTraceObject_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingleStatic_ReqID_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingleStatic_ReqID_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingleStatic_ReqID_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingleStatic_Start_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingleStatic_Start_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingleStatic_Start_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingleStatic_End_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingleStatic_End_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingleStatic_End_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingleStatic_bTraceComplex_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingleStatic_bTraceComplex_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingleStatic_bTraceComplex_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingleStatic_bDebug_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingleStatic_bDebug_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingleStatic_bDebug_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_Batch_IsValid;

	private static IntPtr RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_Batch_ParamsSize;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_Batch_bTraceComplex_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_Batch_bTraceComplex_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_Batch_bTraceComplex_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_Batch_bDebug_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_Batch_bDebug_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_Batch_bDebug_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_IsValid;

	private static IntPtr RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_ParamsSize;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_ReqID_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_ReqID_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_ReqID_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_Start_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_Start_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_Start_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_End_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_End_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_End_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_bTraceComplex_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_bTraceComplex_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_bTraceComplex_Offset;

	private static bool RequestAsyncLineTraceByObjectTypeSingle_bDebug_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByObjectTypeSingle_bDebug_PropertyAddress;

	private static int RequestAsyncLineTraceByObjectTypeSingle_bDebug_Offset;

	private static bool RequestAsyncLineTraceByChannelSingleStatic_IsValid;

	private static IntPtr RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress;

	private static int RequestAsyncLineTraceByChannelSingleStatic_ParamsSize;

	private static bool RequestAsyncLineTraceByChannelSingleStatic_InLineTraceObject_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingleStatic_InLineTraceObject_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingleStatic_InLineTraceObject_Offset;

	private static bool RequestAsyncLineTraceByChannelSingleStatic_ReqID_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingleStatic_ReqID_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingleStatic_ReqID_Offset;

	private static bool RequestAsyncLineTraceByChannelSingleStatic_Start_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingleStatic_Start_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingleStatic_Start_Offset;

	private static bool RequestAsyncLineTraceByChannelSingleStatic_End_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingleStatic_End_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingleStatic_End_Offset;

	private static bool RequestAsyncLineTraceByChannelSingleStatic_TraceChannel_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingleStatic_TraceChannel_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingleStatic_TraceChannel_Offset;

	private static bool RequestAsyncLineTraceByChannelSingleStatic_bTraceComplex_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingleStatic_bTraceComplex_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingleStatic_bTraceComplex_Offset;

	private static bool RequestAsyncLineTraceByChannelSingleStatic_bDebug_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingleStatic_bDebug_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingleStatic_bDebug_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_Batch_IsValid;

	private static IntPtr RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress;

	private static int RequestAsyncLineTraceByChannelSingle_Batch_ParamsSize;

	private static bool RequestAsyncLineTraceByChannelSingle_Batch_ReqList_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_Batch_ReqList_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_Batch_ReqList_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_Batch_TraceChannel_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_Batch_TraceChannel_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_Batch_TraceChannel_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_Batch_bTraceComplex_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_Batch_bTraceComplex_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_Batch_bTraceComplex_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_Batch_bDebug_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_Batch_bDebug_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_Batch_bDebug_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_IsValid;

	private static IntPtr RequestAsyncLineTraceByChannelSingle_FunctionAddress;

	private static int RequestAsyncLineTraceByChannelSingle_ParamsSize;

	private static bool RequestAsyncLineTraceByChannelSingle_ReqID_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_ReqID_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_ReqID_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_Start_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_Start_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_Start_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_End_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_End_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_End_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_TraceChannel_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_TraceChannel_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_TraceChannel_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_bTraceComplex_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_bTraceComplex_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_bTraceComplex_Offset;

	private static bool RequestAsyncLineTraceByChannelSingle_bDebug_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelSingle_bDebug_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelSingle_bDebug_Offset;

	private static bool RequestAsyncLineTraceByChannelOnlyCheck_IsValid;

	private static IntPtr RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress;

	private static int RequestAsyncLineTraceByChannelOnlyCheck_ParamsSize;

	private static bool RequestAsyncLineTraceByChannelOnlyCheck_ReqID_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelOnlyCheck_ReqID_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelOnlyCheck_ReqID_Offset;

	private static bool RequestAsyncLineTraceByChannelOnlyCheck_Start_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelOnlyCheck_Start_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelOnlyCheck_Start_Offset;

	private static bool RequestAsyncLineTraceByChannelOnlyCheck_End_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelOnlyCheck_End_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelOnlyCheck_End_Offset;

	private static bool RequestAsyncLineTraceByChannelOnlyCheck_TraceChannel_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelOnlyCheck_TraceChannel_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelOnlyCheck_TraceChannel_Offset;

	private static bool RequestAsyncLineTraceByChannelOnlyCheck_bTraceComplex_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelOnlyCheck_bTraceComplex_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelOnlyCheck_bTraceComplex_Offset;

	private static bool RequestAsyncLineTraceByChannelOnlyCheck_bDebug_IsValid;

	private static FFieldAddress RequestAsyncLineTraceByChannelOnlyCheck_bDebug_PropertyAddress;

	private static int RequestAsyncLineTraceByChannelOnlyCheck_bDebug_Offset;

	private static bool GetAndCleanLineTraceResults_IsValid;

	private static IntPtr GetAndCleanLineTraceResults_FunctionAddress;

	private static int GetAndCleanLineTraceResults_ParamsSize;

	private static bool GetAndCleanLineTraceResults_OutAsyncLineTraceResults_IsValid;

	private static FFieldAddress GetAndCleanLineTraceResults_OutAsyncLineTraceResults_PropertyAddress;

	private static int GetAndCleanLineTraceResults_OutAsyncLineTraceResults_Offset;

	private static bool GetAndCleanLineTraceResults_ReturnValue_IsValid;

	private static FFieldAddress GetAndCleanLineTraceResults_ReturnValue_PropertyAddress;

	private static int GetAndCleanLineTraceResults_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject:IgnoreActors")]
	public TArrayReadWrite<AActor> IgnoreActors
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.BGUAsyncLineTraceObject:IgnoreActors");
				return null;
			}
			if (IgnoreActors_MarshalerCached == null)
			{
				IgnoreActors_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, IgnoreActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return IgnoreActors_MarshalerCached.FromNative(IntPtr.Add(base.Address, IgnoreActors_Offset));
		}
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByObjectTypeSingleStatic")]
	public unsafe static void RequestAsyncLineTraceByObjectTypeSingleStatic(UBGUAsyncLineTraceObject InLineTraceObject, int ReqID, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, bool bDebug = false)
	{
		if (!RequestAsyncLineTraceByObjectTypeSingleStatic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByObjectTypeSingleStatic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestAsyncLineTraceByObjectTypeSingleStatic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestAsyncLineTraceByObjectTypeSingleStatic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBGUAsyncLineTraceObject>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingleStatic_InLineTraceObject_Offset), 0, RequestAsyncLineTraceByObjectTypeSingleStatic_InLineTraceObject_PropertyAddress.Address, InLineTraceObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingleStatic_ReqID_Offset), 0, RequestAsyncLineTraceByObjectTypeSingleStatic_ReqID_PropertyAddress.Address, ReqID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingleStatic_Start_Offset), 0, RequestAsyncLineTraceByObjectTypeSingleStatic_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingleStatic_End_Offset), 0, RequestAsyncLineTraceByObjectTypeSingleStatic_End_PropertyAddress.Address, End);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingleStatic_bTraceComplex_Offset), 0, RequestAsyncLineTraceByObjectTypeSingleStatic_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingleStatic_bDebug_Offset), 0, RequestAsyncLineTraceByObjectTypeSingleStatic_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, intPtr, RequestAsyncLineTraceByObjectTypeSingleStatic_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByObjectTypeSingle_Batch")]
	public unsafe void RequestAsyncLineTraceByObjectTypeSingle_Batch(List<FAsyncLineTraceReq> ReqList, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, bool bDebug = false)
	{
		CheckDestroyed();
		if (!RequestAsyncLineTraceByObjectTypeSingle_Batch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByObjectTypeSingle_Batch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestAsyncLineTraceByObjectTypeSingle_Batch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestAsyncLineTraceByObjectTypeSingle_Batch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAsyncLineTraceReq>(1, RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_PropertyAddress, CachedMarshalingDelegates<FAsyncLineTraceReq, FAsyncLineTraceReq>.FromNative, CachedMarshalingDelegates<FAsyncLineTraceReq, FAsyncLineTraceReq>.ToNative).ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_Offset), ReqList);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_Batch_bTraceComplex_Offset), 0, RequestAsyncLineTraceByObjectTypeSingle_Batch_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_Batch_bDebug_Offset), 0, RequestAsyncLineTraceByObjectTypeSingle_Batch_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, intPtr, RequestAsyncLineTraceByObjectTypeSingle_Batch_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByObjectTypeSingle")]
	public unsafe void RequestAsyncLineTraceByObjectTypeSingle(int ReqID, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, bool bDebug = false)
	{
		CheckDestroyed();
		if (!RequestAsyncLineTraceByObjectTypeSingle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByObjectTypeSingle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestAsyncLineTraceByObjectTypeSingle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestAsyncLineTraceByObjectTypeSingle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_ReqID_Offset), 0, RequestAsyncLineTraceByObjectTypeSingle_ReqID_PropertyAddress.Address, ReqID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_Start_Offset), 0, RequestAsyncLineTraceByObjectTypeSingle_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_End_Offset), 0, RequestAsyncLineTraceByObjectTypeSingle_End_PropertyAddress.Address, End);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_bTraceComplex_Offset), 0, RequestAsyncLineTraceByObjectTypeSingle_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByObjectTypeSingle_bDebug_Offset), 0, RequestAsyncLineTraceByObjectTypeSingle_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, intPtr, RequestAsyncLineTraceByObjectTypeSingle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelSingleStatic")]
	public unsafe static void RequestAsyncLineTraceByChannelSingleStatic(UBGUAsyncLineTraceObject InLineTraceObject, int ReqID, FVector Start, FVector End, ECollisionChannel TraceChannel, bool bTraceComplex, bool bDebug = false)
	{
		if (!RequestAsyncLineTraceByChannelSingleStatic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelSingleStatic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestAsyncLineTraceByChannelSingleStatic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestAsyncLineTraceByChannelSingleStatic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBGUAsyncLineTraceObject>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingleStatic_InLineTraceObject_Offset), 0, RequestAsyncLineTraceByChannelSingleStatic_InLineTraceObject_PropertyAddress.Address, InLineTraceObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingleStatic_ReqID_Offset), 0, RequestAsyncLineTraceByChannelSingleStatic_ReqID_PropertyAddress.Address, ReqID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingleStatic_Start_Offset), 0, RequestAsyncLineTraceByChannelSingleStatic_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingleStatic_End_Offset), 0, RequestAsyncLineTraceByChannelSingleStatic_End_PropertyAddress.Address, End);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingleStatic_TraceChannel_Offset), 0, RequestAsyncLineTraceByChannelSingleStatic_TraceChannel_PropertyAddress.Address, TraceChannel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingleStatic_bTraceComplex_Offset), 0, RequestAsyncLineTraceByChannelSingleStatic_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingleStatic_bDebug_Offset), 0, RequestAsyncLineTraceByChannelSingleStatic_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, intPtr, RequestAsyncLineTraceByChannelSingleStatic_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelSingle_Batch")]
	public unsafe void RequestAsyncLineTraceByChannelSingle_Batch(List<FAsyncLineTraceReq> ReqList, ECollisionChannel TraceChannel, bool bTraceComplex, bool bDebug = false)
	{
		CheckDestroyed();
		if (!RequestAsyncLineTraceByChannelSingle_Batch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelSingle_Batch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestAsyncLineTraceByChannelSingle_Batch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestAsyncLineTraceByChannelSingle_Batch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAsyncLineTraceReq>(1, RequestAsyncLineTraceByChannelSingle_Batch_ReqList_PropertyAddress, CachedMarshalingDelegates<FAsyncLineTraceReq, FAsyncLineTraceReq>.FromNative, CachedMarshalingDelegates<FAsyncLineTraceReq, FAsyncLineTraceReq>.ToNative).ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_Batch_ReqList_Offset), ReqList);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_Batch_TraceChannel_Offset), 0, RequestAsyncLineTraceByChannelSingle_Batch_TraceChannel_PropertyAddress.Address, TraceChannel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_Batch_bTraceComplex_Offset), 0, RequestAsyncLineTraceByChannelSingle_Batch_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_Batch_bDebug_Offset), 0, RequestAsyncLineTraceByChannelSingle_Batch_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, intPtr, RequestAsyncLineTraceByChannelSingle_Batch_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestAsyncLineTraceByChannelSingle_Batch_ReqList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelSingle")]
	public unsafe void RequestAsyncLineTraceByChannelSingle(int ReqID, FVector Start, FVector End, ECollisionChannel TraceChannel, bool bTraceComplex, bool bDebug = false)
	{
		CheckDestroyed();
		if (!RequestAsyncLineTraceByChannelSingle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelSingle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestAsyncLineTraceByChannelSingle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestAsyncLineTraceByChannelSingle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_ReqID_Offset), 0, RequestAsyncLineTraceByChannelSingle_ReqID_PropertyAddress.Address, ReqID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_Start_Offset), 0, RequestAsyncLineTraceByChannelSingle_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_End_Offset), 0, RequestAsyncLineTraceByChannelSingle_End_PropertyAddress.Address, End);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_TraceChannel_Offset), 0, RequestAsyncLineTraceByChannelSingle_TraceChannel_PropertyAddress.Address, TraceChannel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_bTraceComplex_Offset), 0, RequestAsyncLineTraceByChannelSingle_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelSingle_bDebug_Offset), 0, RequestAsyncLineTraceByChannelSingle_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequestAsyncLineTraceByChannelSingle_FunctionAddress, intPtr, RequestAsyncLineTraceByChannelSingle_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelOnlyCheck")]
	public unsafe void RequestAsyncLineTraceByChannelOnlyCheck(int ReqID, FVector Start, FVector End, ECollisionChannel TraceChannel, bool bTraceComplex, bool bDebug = false)
	{
		CheckDestroyed();
		if (!RequestAsyncLineTraceByChannelOnlyCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelOnlyCheck");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestAsyncLineTraceByChannelOnlyCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestAsyncLineTraceByChannelOnlyCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelOnlyCheck_ReqID_Offset), 0, RequestAsyncLineTraceByChannelOnlyCheck_ReqID_PropertyAddress.Address, ReqID);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelOnlyCheck_Start_Offset), 0, RequestAsyncLineTraceByChannelOnlyCheck_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelOnlyCheck_End_Offset), 0, RequestAsyncLineTraceByChannelOnlyCheck_End_PropertyAddress.Address, End);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelOnlyCheck_TraceChannel_Offset), 0, RequestAsyncLineTraceByChannelOnlyCheck_TraceChannel_PropertyAddress.Address, TraceChannel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelOnlyCheck_bTraceComplex_Offset), 0, RequestAsyncLineTraceByChannelOnlyCheck_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestAsyncLineTraceByChannelOnlyCheck_bDebug_Offset), 0, RequestAsyncLineTraceByChannelOnlyCheck_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, intPtr, RequestAsyncLineTraceByChannelOnlyCheck_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UnrealExtent.BGUAsyncLineTraceObject:GetAndCleanLineTraceResults")]
	public unsafe int GetAndCleanLineTraceResults(out List<FAsyncLineTraceSingleResult> OutAsyncLineTraceResults)
	{
		CheckDestroyed();
		if (!GetAndCleanLineTraceResults_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.BGUAsyncLineTraceObject:GetAndCleanLineTraceResults");
			OutAsyncLineTraceResults = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAndCleanLineTraceResults_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAndCleanLineTraceResults_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAndCleanLineTraceResults_FunctionAddress, intPtr, GetAndCleanLineTraceResults_ParamsSize);
		OutAsyncLineTraceResults = new TArrayCopyMarshaler<FAsyncLineTraceSingleResult>(1, GetAndCleanLineTraceResults_OutAsyncLineTraceResults_PropertyAddress, CachedMarshalingDelegates<FAsyncLineTraceSingleResult, FAsyncLineTraceSingleResult>.FromNative, CachedMarshalingDelegates<FAsyncLineTraceSingleResult, FAsyncLineTraceSingleResult>.ToNative).FromNative(IntPtr.Add(intPtr, GetAndCleanLineTraceResults_OutAsyncLineTraceResults_Offset));
		NativeReflection.DestroyValue_InContainer(GetAndCleanLineTraceResults_OutAsyncLineTraceResults_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAndCleanLineTraceResults_ReturnValue_Offset), 0, GetAndCleanLineTraceResults_ReturnValue_PropertyAddress.Address);
	}

	static UBGUAsyncLineTraceObject()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUAsyncLineTraceObject)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUAsyncLineTraceObject));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.BGUAsyncLineTraceObject");
		NativeReflectionCached.GetPropertyRef(ref IgnoreActors_PropertyAddress, classAddress, "IgnoreActors");
		IgnoreActors_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "IgnoreActors");
		IgnoreActors_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "IgnoreActors", Classes.FArrayProperty);
		RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestAsyncLineTraceByObjectTypeSingleStatic");
		RequestAsyncLineTraceByObjectTypeSingleStatic_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingleStatic_InLineTraceObject_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "InLineTraceObject");
		RequestAsyncLineTraceByObjectTypeSingleStatic_InLineTraceObject_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "InLineTraceObject");
		RequestAsyncLineTraceByObjectTypeSingleStatic_InLineTraceObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "InLineTraceObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingleStatic_ReqID_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByObjectTypeSingleStatic_ReqID_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByObjectTypeSingleStatic_ReqID_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "ReqID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingleStatic_Start_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "Start");
		RequestAsyncLineTraceByObjectTypeSingleStatic_Start_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "Start");
		RequestAsyncLineTraceByObjectTypeSingleStatic_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingleStatic_End_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "End");
		RequestAsyncLineTraceByObjectTypeSingleStatic_End_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "End");
		RequestAsyncLineTraceByObjectTypeSingleStatic_End_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "ObjectTypes");
		RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "ObjectTypes");
		RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingleStatic_bTraceComplex_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByObjectTypeSingleStatic_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByObjectTypeSingleStatic_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingleStatic_bDebug_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByObjectTypeSingleStatic_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByObjectTypeSingleStatic_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress, "bDebug", Classes.FBoolProperty);
		RequestAsyncLineTraceByObjectTypeSingleStatic_IsValid = RequestAsyncLineTraceByObjectTypeSingleStatic_FunctionAddress != IntPtr.Zero && RequestAsyncLineTraceByObjectTypeSingleStatic_InLineTraceObject_IsValid && RequestAsyncLineTraceByObjectTypeSingleStatic_ReqID_IsValid && RequestAsyncLineTraceByObjectTypeSingleStatic_Start_IsValid && RequestAsyncLineTraceByObjectTypeSingleStatic_End_IsValid && RequestAsyncLineTraceByObjectTypeSingleStatic_ObjectTypes_IsValid && RequestAsyncLineTraceByObjectTypeSingleStatic_bTraceComplex_IsValid && RequestAsyncLineTraceByObjectTypeSingleStatic_bDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByObjectTypeSingleStatic", RequestAsyncLineTraceByObjectTypeSingleStatic_IsValid);
		RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestAsyncLineTraceByObjectTypeSingle_Batch");
		RequestAsyncLineTraceByObjectTypeSingle_Batch_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "ReqList");
		RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "ReqList");
		RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "ReqList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "ObjectTypes");
		RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "ObjectTypes");
		RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_Batch_bTraceComplex_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByObjectTypeSingle_Batch_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByObjectTypeSingle_Batch_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_Batch_bDebug_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByObjectTypeSingle_Batch_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByObjectTypeSingle_Batch_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress, "bDebug", Classes.FBoolProperty);
		RequestAsyncLineTraceByObjectTypeSingle_Batch_IsValid = RequestAsyncLineTraceByObjectTypeSingle_Batch_FunctionAddress != IntPtr.Zero && RequestAsyncLineTraceByObjectTypeSingle_Batch_ReqList_IsValid && RequestAsyncLineTraceByObjectTypeSingle_Batch_ObjectTypes_IsValid && RequestAsyncLineTraceByObjectTypeSingle_Batch_bTraceComplex_IsValid && RequestAsyncLineTraceByObjectTypeSingle_Batch_bDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByObjectTypeSingle_Batch", RequestAsyncLineTraceByObjectTypeSingle_Batch_IsValid);
		RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestAsyncLineTraceByObjectTypeSingle");
		RequestAsyncLineTraceByObjectTypeSingle_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_ReqID_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByObjectTypeSingle_ReqID_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByObjectTypeSingle_ReqID_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "ReqID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_Start_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "Start");
		RequestAsyncLineTraceByObjectTypeSingle_Start_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "Start");
		RequestAsyncLineTraceByObjectTypeSingle_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_End_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "End");
		RequestAsyncLineTraceByObjectTypeSingle_End_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "End");
		RequestAsyncLineTraceByObjectTypeSingle_End_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "ObjectTypes");
		RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "ObjectTypes");
		RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_bTraceComplex_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByObjectTypeSingle_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByObjectTypeSingle_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByObjectTypeSingle_bDebug_PropertyAddress, RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByObjectTypeSingle_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByObjectTypeSingle_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress, "bDebug", Classes.FBoolProperty);
		RequestAsyncLineTraceByObjectTypeSingle_IsValid = RequestAsyncLineTraceByObjectTypeSingle_FunctionAddress != IntPtr.Zero && RequestAsyncLineTraceByObjectTypeSingle_ReqID_IsValid && RequestAsyncLineTraceByObjectTypeSingle_Start_IsValid && RequestAsyncLineTraceByObjectTypeSingle_End_IsValid && RequestAsyncLineTraceByObjectTypeSingle_ObjectTypes_IsValid && RequestAsyncLineTraceByObjectTypeSingle_bTraceComplex_IsValid && RequestAsyncLineTraceByObjectTypeSingle_bDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByObjectTypeSingle", RequestAsyncLineTraceByObjectTypeSingle_IsValid);
		RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestAsyncLineTraceByChannelSingleStatic");
		RequestAsyncLineTraceByChannelSingleStatic_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingleStatic_InLineTraceObject_PropertyAddress, RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "InLineTraceObject");
		RequestAsyncLineTraceByChannelSingleStatic_InLineTraceObject_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "InLineTraceObject");
		RequestAsyncLineTraceByChannelSingleStatic_InLineTraceObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "InLineTraceObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingleStatic_ReqID_PropertyAddress, RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByChannelSingleStatic_ReqID_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByChannelSingleStatic_ReqID_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "ReqID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingleStatic_Start_PropertyAddress, RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "Start");
		RequestAsyncLineTraceByChannelSingleStatic_Start_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "Start");
		RequestAsyncLineTraceByChannelSingleStatic_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingleStatic_End_PropertyAddress, RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "End");
		RequestAsyncLineTraceByChannelSingleStatic_End_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "End");
		RequestAsyncLineTraceByChannelSingleStatic_End_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingleStatic_TraceChannel_PropertyAddress, RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "TraceChannel");
		RequestAsyncLineTraceByChannelSingleStatic_TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "TraceChannel");
		RequestAsyncLineTraceByChannelSingleStatic_TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingleStatic_bTraceComplex_PropertyAddress, RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByChannelSingleStatic_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByChannelSingleStatic_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingleStatic_bDebug_PropertyAddress, RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByChannelSingleStatic_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByChannelSingleStatic_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress, "bDebug", Classes.FBoolProperty);
		RequestAsyncLineTraceByChannelSingleStatic_IsValid = RequestAsyncLineTraceByChannelSingleStatic_FunctionAddress != IntPtr.Zero && RequestAsyncLineTraceByChannelSingleStatic_InLineTraceObject_IsValid && RequestAsyncLineTraceByChannelSingleStatic_ReqID_IsValid && RequestAsyncLineTraceByChannelSingleStatic_Start_IsValid && RequestAsyncLineTraceByChannelSingleStatic_End_IsValid && RequestAsyncLineTraceByChannelSingleStatic_TraceChannel_IsValid && RequestAsyncLineTraceByChannelSingleStatic_bTraceComplex_IsValid && RequestAsyncLineTraceByChannelSingleStatic_bDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelSingleStatic", RequestAsyncLineTraceByChannelSingleStatic_IsValid);
		RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestAsyncLineTraceByChannelSingle_Batch");
		RequestAsyncLineTraceByChannelSingle_Batch_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_Batch_ReqList_PropertyAddress, RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "ReqList");
		RequestAsyncLineTraceByChannelSingle_Batch_ReqList_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "ReqList");
		RequestAsyncLineTraceByChannelSingle_Batch_ReqList_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "ReqList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_Batch_TraceChannel_PropertyAddress, RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "TraceChannel");
		RequestAsyncLineTraceByChannelSingle_Batch_TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "TraceChannel");
		RequestAsyncLineTraceByChannelSingle_Batch_TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_Batch_bTraceComplex_PropertyAddress, RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByChannelSingle_Batch_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByChannelSingle_Batch_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_Batch_bDebug_PropertyAddress, RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByChannelSingle_Batch_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByChannelSingle_Batch_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress, "bDebug", Classes.FBoolProperty);
		RequestAsyncLineTraceByChannelSingle_Batch_IsValid = RequestAsyncLineTraceByChannelSingle_Batch_FunctionAddress != IntPtr.Zero && RequestAsyncLineTraceByChannelSingle_Batch_ReqList_IsValid && RequestAsyncLineTraceByChannelSingle_Batch_TraceChannel_IsValid && RequestAsyncLineTraceByChannelSingle_Batch_bTraceComplex_IsValid && RequestAsyncLineTraceByChannelSingle_Batch_bDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelSingle_Batch", RequestAsyncLineTraceByChannelSingle_Batch_IsValid);
		RequestAsyncLineTraceByChannelSingle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestAsyncLineTraceByChannelSingle");
		RequestAsyncLineTraceByChannelSingle_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestAsyncLineTraceByChannelSingle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_ReqID_PropertyAddress, RequestAsyncLineTraceByChannelSingle_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByChannelSingle_ReqID_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByChannelSingle_ReqID_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "ReqID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_Start_PropertyAddress, RequestAsyncLineTraceByChannelSingle_FunctionAddress, "Start");
		RequestAsyncLineTraceByChannelSingle_Start_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "Start");
		RequestAsyncLineTraceByChannelSingle_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_End_PropertyAddress, RequestAsyncLineTraceByChannelSingle_FunctionAddress, "End");
		RequestAsyncLineTraceByChannelSingle_End_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "End");
		RequestAsyncLineTraceByChannelSingle_End_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_TraceChannel_PropertyAddress, RequestAsyncLineTraceByChannelSingle_FunctionAddress, "TraceChannel");
		RequestAsyncLineTraceByChannelSingle_TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "TraceChannel");
		RequestAsyncLineTraceByChannelSingle_TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_bTraceComplex_PropertyAddress, RequestAsyncLineTraceByChannelSingle_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByChannelSingle_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByChannelSingle_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelSingle_bDebug_PropertyAddress, RequestAsyncLineTraceByChannelSingle_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByChannelSingle_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByChannelSingle_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelSingle_FunctionAddress, "bDebug", Classes.FBoolProperty);
		RequestAsyncLineTraceByChannelSingle_IsValid = RequestAsyncLineTraceByChannelSingle_FunctionAddress != IntPtr.Zero && RequestAsyncLineTraceByChannelSingle_ReqID_IsValid && RequestAsyncLineTraceByChannelSingle_Start_IsValid && RequestAsyncLineTraceByChannelSingle_End_IsValid && RequestAsyncLineTraceByChannelSingle_TraceChannel_IsValid && RequestAsyncLineTraceByChannelSingle_bTraceComplex_IsValid && RequestAsyncLineTraceByChannelSingle_bDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelSingle", RequestAsyncLineTraceByChannelSingle_IsValid);
		RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestAsyncLineTraceByChannelOnlyCheck");
		RequestAsyncLineTraceByChannelOnlyCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelOnlyCheck_ReqID_PropertyAddress, RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByChannelOnlyCheck_ReqID_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "ReqID");
		RequestAsyncLineTraceByChannelOnlyCheck_ReqID_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "ReqID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelOnlyCheck_Start_PropertyAddress, RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "Start");
		RequestAsyncLineTraceByChannelOnlyCheck_Start_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "Start");
		RequestAsyncLineTraceByChannelOnlyCheck_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelOnlyCheck_End_PropertyAddress, RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "End");
		RequestAsyncLineTraceByChannelOnlyCheck_End_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "End");
		RequestAsyncLineTraceByChannelOnlyCheck_End_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelOnlyCheck_TraceChannel_PropertyAddress, RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "TraceChannel");
		RequestAsyncLineTraceByChannelOnlyCheck_TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "TraceChannel");
		RequestAsyncLineTraceByChannelOnlyCheck_TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelOnlyCheck_bTraceComplex_PropertyAddress, RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByChannelOnlyCheck_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "bTraceComplex");
		RequestAsyncLineTraceByChannelOnlyCheck_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestAsyncLineTraceByChannelOnlyCheck_bDebug_PropertyAddress, RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByChannelOnlyCheck_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "bDebug");
		RequestAsyncLineTraceByChannelOnlyCheck_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress, "bDebug", Classes.FBoolProperty);
		RequestAsyncLineTraceByChannelOnlyCheck_IsValid = RequestAsyncLineTraceByChannelOnlyCheck_FunctionAddress != IntPtr.Zero && RequestAsyncLineTraceByChannelOnlyCheck_ReqID_IsValid && RequestAsyncLineTraceByChannelOnlyCheck_Start_IsValid && RequestAsyncLineTraceByChannelOnlyCheck_End_IsValid && RequestAsyncLineTraceByChannelOnlyCheck_TraceChannel_IsValid && RequestAsyncLineTraceByChannelOnlyCheck_bTraceComplex_IsValid && RequestAsyncLineTraceByChannelOnlyCheck_bDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUAsyncLineTraceObject:RequestAsyncLineTraceByChannelOnlyCheck", RequestAsyncLineTraceByChannelOnlyCheck_IsValid);
		GetAndCleanLineTraceResults_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAndCleanLineTraceResults");
		GetAndCleanLineTraceResults_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAndCleanLineTraceResults_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAndCleanLineTraceResults_OutAsyncLineTraceResults_PropertyAddress, GetAndCleanLineTraceResults_FunctionAddress, "OutAsyncLineTraceResults");
		GetAndCleanLineTraceResults_OutAsyncLineTraceResults_Offset = NativeReflectionCached.GetPropertyOffset(GetAndCleanLineTraceResults_FunctionAddress, "OutAsyncLineTraceResults");
		GetAndCleanLineTraceResults_OutAsyncLineTraceResults_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAndCleanLineTraceResults_FunctionAddress, "OutAsyncLineTraceResults", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAndCleanLineTraceResults_ReturnValue_PropertyAddress, GetAndCleanLineTraceResults_FunctionAddress, "ReturnValue");
		GetAndCleanLineTraceResults_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAndCleanLineTraceResults_FunctionAddress, "ReturnValue");
		GetAndCleanLineTraceResults_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAndCleanLineTraceResults_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAndCleanLineTraceResults_IsValid = GetAndCleanLineTraceResults_FunctionAddress != IntPtr.Zero && GetAndCleanLineTraceResults_OutAsyncLineTraceResults_IsValid && GetAndCleanLineTraceResults_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.BGUAsyncLineTraceObject:GetAndCleanLineTraceResults", GetAndCleanLineTraceResults_IsValid);
	}
}
