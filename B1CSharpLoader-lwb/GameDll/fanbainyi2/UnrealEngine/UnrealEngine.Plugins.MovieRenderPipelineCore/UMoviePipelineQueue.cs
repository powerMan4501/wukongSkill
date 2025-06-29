using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueue", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineQueue : UObject
{
	private static bool SetJobIndex_IsValid;

	private static IntPtr SetJobIndex_FunctionAddress;

	private static int SetJobIndex_ParamsSize;

	private static bool SetJobIndex_InJob_IsValid;

	private static FFieldAddress SetJobIndex_InJob_PropertyAddress;

	private static int SetJobIndex_InJob_Offset;

	private static bool SetJobIndex_Index_IsValid;

	private static FFieldAddress SetJobIndex_Index_PropertyAddress;

	private static int SetJobIndex_Index_Offset;

	private static bool GetJobs_IsValid;

	private static IntPtr GetJobs_FunctionAddress;

	private static int GetJobs_ParamsSize;

	private static bool GetJobs_ReturnValue_IsValid;

	private static FFieldAddress GetJobs_ReturnValue_PropertyAddress;

	private static int GetJobs_ReturnValue_Offset;

	private static bool DuplicateJob_IsValid;

	private static IntPtr DuplicateJob_FunctionAddress;

	private static int DuplicateJob_ParamsSize;

	private static bool DuplicateJob_InJob_IsValid;

	private static FFieldAddress DuplicateJob_InJob_PropertyAddress;

	private static int DuplicateJob_InJob_Offset;

	private static bool DuplicateJob_ReturnValue_IsValid;

	private static FFieldAddress DuplicateJob_ReturnValue_PropertyAddress;

	private static int DuplicateJob_ReturnValue_Offset;

	private static bool DeleteJob_IsValid;

	private static IntPtr DeleteJob_FunctionAddress;

	private static int DeleteJob_ParamsSize;

	private static bool DeleteJob_InJob_IsValid;

	private static FFieldAddress DeleteJob_InJob_PropertyAddress;

	private static int DeleteJob_InJob_Offset;

	private static bool DeleteAllJobs_IsValid;

	private static IntPtr DeleteAllJobs_FunctionAddress;

	private static int DeleteAllJobs_ParamsSize;

	private static bool CopyFrom_IsValid;

	private static IntPtr CopyFrom_FunctionAddress;

	private static int CopyFrom_ParamsSize;

	private static bool CopyFrom_InQueue_IsValid;

	private static FFieldAddress CopyFrom_InQueue_PropertyAddress;

	private static int CopyFrom_InQueue_Offset;

	private static bool AllocateNewJob_IsValid;

	private static IntPtr AllocateNewJob_FunctionAddress;

	private static int AllocateNewJob_ParamsSize;

	private static bool AllocateNewJob_InJobType_IsValid;

	private static FFieldAddress AllocateNewJob_InJobType_PropertyAddress;

	private static int AllocateNewJob_InJobType_Offset;

	private static bool AllocateNewJob_ReturnValue_IsValid;

	private static FFieldAddress AllocateNewJob_ReturnValue_PropertyAddress;

	private static int AllocateNewJob_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueue:SetJobIndex")]
	public unsafe void SetJobIndex(UMoviePipelineExecutorJob InJob, int Index)
	{
		CheckDestroyed();
		if (!SetJobIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueue:SetJobIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetJobIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetJobIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, SetJobIndex_InJob_Offset), 0, SetJobIndex_InJob_PropertyAddress.Address, InJob);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetJobIndex_Index_Offset), 0, SetJobIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetJobIndex_FunctionAddress, intPtr, SetJobIndex_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueue:GetJobs")]
	public unsafe List<UMoviePipelineExecutorJob> GetJobs()
	{
		CheckDestroyed();
		if (!GetJobs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueue:GetJobs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetJobs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetJobs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetJobs_FunctionAddress, intPtr, GetJobs_ParamsSize);
		List<UMoviePipelineExecutorJob> result = new TArrayCopyMarshaler<UMoviePipelineExecutorJob>(1, GetJobs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMoviePipelineExecutorJob, UObjectMarshaler<UMoviePipelineExecutorJob>>.FromNative, CachedMarshalingDelegates<UMoviePipelineExecutorJob, UObjectMarshaler<UMoviePipelineExecutorJob>>.ToNative).FromNative(IntPtr.Add(intPtr, GetJobs_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetJobs_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueue:DuplicateJob")]
	public unsafe UMoviePipelineExecutorJob DuplicateJob(UMoviePipelineExecutorJob InJob)
	{
		CheckDestroyed();
		if (!DuplicateJob_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueue:DuplicateJob");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateJob_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateJob_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, DuplicateJob_InJob_Offset), 0, DuplicateJob_InJob_PropertyAddress.Address, InJob);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateJob_FunctionAddress, intPtr, DuplicateJob_ParamsSize);
		return UObjectMarshaler<UMoviePipelineExecutorJob>.FromNative(IntPtr.Add(intPtr, DuplicateJob_ReturnValue_Offset), 0, DuplicateJob_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueue:DeleteJob")]
	public unsafe void DeleteJob(UMoviePipelineExecutorJob InJob)
	{
		CheckDestroyed();
		if (!DeleteJob_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueue:DeleteJob");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteJob_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteJob_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, DeleteJob_InJob_Offset), 0, DeleteJob_InJob_PropertyAddress.Address, InJob);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeleteJob_FunctionAddress, intPtr, DeleteJob_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueue:DeleteAllJobs")]
	public unsafe void DeleteAllJobs()
	{
		CheckDestroyed();
		if (!DeleteAllJobs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueue:DeleteAllJobs");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteAllJobs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteAllJobs_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DeleteAllJobs_FunctionAddress, argsSize: DeleteAllJobs_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueue:CopyFrom")]
	public unsafe void CopyFrom(UMoviePipelineQueue InQueue)
	{
		CheckDestroyed();
		if (!CopyFrom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueue:CopyFrom");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyFrom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyFrom_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineQueue>.ToNative(IntPtr.Add(intPtr, CopyFrom_InQueue_Offset), 0, CopyFrom_InQueue_PropertyAddress.Address, InQueue);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyFrom_FunctionAddress, intPtr, CopyFrom_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueue:AllocateNewJob")]
	public unsafe UMoviePipelineExecutorJob AllocateNewJob(TSubclassOf<UMoviePipelineExecutorJob> InJobType)
	{
		CheckDestroyed();
		if (!AllocateNewJob_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueue:AllocateNewJob");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AllocateNewJob_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AllocateNewJob_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, AllocateNewJob_InJobType_Offset), 0, AllocateNewJob_InJobType_PropertyAddress.Address, InJobType);
		NativeReflection.InvokeFunctionOptimized(base.Address, AllocateNewJob_FunctionAddress, intPtr, AllocateNewJob_ParamsSize);
		return UObjectMarshaler<UMoviePipelineExecutorJob>.FromNative(IntPtr.Add(intPtr, AllocateNewJob_ReturnValue_Offset), 0, AllocateNewJob_ReturnValue_PropertyAddress.Address);
	}

	static UMoviePipelineQueue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineQueue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineQueue));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineQueue");
		SetJobIndex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetJobIndex");
		SetJobIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetJobIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetJobIndex_InJob_PropertyAddress, SetJobIndex_FunctionAddress, "InJob");
		SetJobIndex_InJob_Offset = NativeReflectionCached.GetPropertyOffset(SetJobIndex_FunctionAddress, "InJob");
		SetJobIndex_InJob_IsValid = NativeReflectionCached.ValidatePropertyClass(SetJobIndex_FunctionAddress, "InJob", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetJobIndex_Index_PropertyAddress, SetJobIndex_FunctionAddress, "Index");
		SetJobIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetJobIndex_FunctionAddress, "Index");
		SetJobIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetJobIndex_FunctionAddress, "Index", Classes.FIntProperty);
		SetJobIndex_IsValid = SetJobIndex_FunctionAddress != IntPtr.Zero && SetJobIndex_InJob_IsValid && SetJobIndex_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueue:SetJobIndex", SetJobIndex_IsValid);
		GetJobs_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetJobs");
		GetJobs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJobs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetJobs_ReturnValue_PropertyAddress, GetJobs_FunctionAddress, "ReturnValue");
		GetJobs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetJobs_FunctionAddress, "ReturnValue");
		GetJobs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetJobs_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetJobs_IsValid = GetJobs_FunctionAddress != IntPtr.Zero && GetJobs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueue:GetJobs", GetJobs_IsValid);
		DuplicateJob_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DuplicateJob");
		DuplicateJob_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateJob_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateJob_InJob_PropertyAddress, DuplicateJob_FunctionAddress, "InJob");
		DuplicateJob_InJob_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateJob_FunctionAddress, "InJob");
		DuplicateJob_InJob_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateJob_FunctionAddress, "InJob", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateJob_ReturnValue_PropertyAddress, DuplicateJob_FunctionAddress, "ReturnValue");
		DuplicateJob_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateJob_FunctionAddress, "ReturnValue");
		DuplicateJob_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateJob_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateJob_IsValid = DuplicateJob_FunctionAddress != IntPtr.Zero && DuplicateJob_InJob_IsValid && DuplicateJob_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueue:DuplicateJob", DuplicateJob_IsValid);
		DeleteJob_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteJob");
		DeleteJob_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteJob_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteJob_InJob_PropertyAddress, DeleteJob_FunctionAddress, "InJob");
		DeleteJob_InJob_Offset = NativeReflectionCached.GetPropertyOffset(DeleteJob_FunctionAddress, "InJob");
		DeleteJob_InJob_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteJob_FunctionAddress, "InJob", Classes.FObjectProperty);
		DeleteJob_IsValid = DeleteJob_FunctionAddress != IntPtr.Zero && DeleteJob_InJob_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueue:DeleteJob", DeleteJob_IsValid);
		DeleteAllJobs_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeleteAllJobs");
		DeleteAllJobs_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteAllJobs_FunctionAddress);
		DeleteAllJobs_IsValid = DeleteAllJobs_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueue:DeleteAllJobs", DeleteAllJobs_IsValid);
		CopyFrom_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CopyFrom");
		CopyFrom_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyFrom_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyFrom_InQueue_PropertyAddress, CopyFrom_FunctionAddress, "InQueue");
		CopyFrom_InQueue_Offset = NativeReflectionCached.GetPropertyOffset(CopyFrom_FunctionAddress, "InQueue");
		CopyFrom_InQueue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyFrom_FunctionAddress, "InQueue", Classes.FObjectProperty);
		CopyFrom_IsValid = CopyFrom_FunctionAddress != IntPtr.Zero && CopyFrom_InQueue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueue:CopyFrom", CopyFrom_IsValid);
		AllocateNewJob_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AllocateNewJob");
		AllocateNewJob_ParamsSize = NativeReflection.GetFunctionParamsSize(AllocateNewJob_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AllocateNewJob_InJobType_PropertyAddress, AllocateNewJob_FunctionAddress, "InJobType");
		AllocateNewJob_InJobType_Offset = NativeReflectionCached.GetPropertyOffset(AllocateNewJob_FunctionAddress, "InJobType");
		AllocateNewJob_InJobType_IsValid = NativeReflectionCached.ValidatePropertyClass(AllocateNewJob_FunctionAddress, "InJobType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AllocateNewJob_ReturnValue_PropertyAddress, AllocateNewJob_FunctionAddress, "ReturnValue");
		AllocateNewJob_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AllocateNewJob_FunctionAddress, "ReturnValue");
		AllocateNewJob_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AllocateNewJob_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AllocateNewJob_IsValid = AllocateNewJob_FunctionAddress != IntPtr.Zero && AllocateNewJob_InJobType_IsValid && AllocateNewJob_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueue:AllocateNewJob", AllocateNewJob_IsValid);
	}
}
