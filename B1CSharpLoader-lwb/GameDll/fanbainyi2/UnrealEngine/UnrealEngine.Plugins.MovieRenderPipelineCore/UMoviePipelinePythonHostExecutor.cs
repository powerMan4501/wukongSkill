using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelinePythonHostExecutor : UMoviePipelineExecutorBase
{
	private static bool ExecutorClass_IsValid;

	private static int ExecutorClass_Offset;

	private static bool PipelineQueue_IsValid;

	private static int PipelineQueue_Offset;

	private static bool OnMapLoad_IsValid;

	private IntPtr OnMapLoad_InstanceFunctionAddress;

	private static IntPtr OnMapLoad_FunctionAddress;

	private static int OnMapLoad_ParamsSize;

	private static bool OnMapLoad_InWorld_IsValid;

	private static FFieldAddress OnMapLoad_InWorld_PropertyAddress;

	private static int OnMapLoad_InWorld_Offset;

	private static bool GetLastLoadedWorld_IsValid;

	private static IntPtr GetLastLoadedWorld_FunctionAddress;

	private static int GetLastLoadedWorld_ParamsSize;

	private static bool GetLastLoadedWorld_ReturnValue_IsValid;

	private static FFieldAddress GetLastLoadedWorld_ReturnValue_PropertyAddress;

	private static int GetLastLoadedWorld_ReturnValue_Offset;

	private static bool ExecuteDelayed_IsValid;

	private IntPtr ExecuteDelayed_InstanceFunctionAddress;

	private static IntPtr ExecuteDelayed_FunctionAddress;

	private static int ExecuteDelayed_ParamsSize;

	private static bool ExecuteDelayed_InPipelineQueue_IsValid;

	private static FFieldAddress ExecuteDelayed_InPipelineQueue_PropertyAddress;

	private static int ExecuteDelayed_InPipelineQueue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:ExecutorClass")]
	public TSubclassOf<UMoviePipelinePythonHostExecutor> ExecutorClass
	{
		get
		{
			CheckDestroyed();
			if (!ExecutorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:ExecutorClass");
				return default(TSubclassOf<UMoviePipelinePythonHostExecutor>);
			}
			return TSubclassOfMarshaler<UMoviePipelinePythonHostExecutor>.FromNative(IntPtr.Add(base.Address, ExecutorClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExecutorClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:ExecutorClass");
			}
			else
			{
				TSubclassOfMarshaler<UMoviePipelinePythonHostExecutor>.ToNative(IntPtr.Add(base.Address, ExecutorClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283012uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:PipelineQueue")]
	public UMoviePipelineQueue PipelineQueue
	{
		get
		{
			CheckDestroyed();
			if (!PipelineQueue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:PipelineQueue");
				return null;
			}
			return UObjectMarshaler<UMoviePipelineQueue>.FromNative(IntPtr.Add(base.Address, PipelineQueue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PipelineQueue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:PipelineQueue");
			}
			else
			{
				UObjectMarshaler<UMoviePipelineQueue>.ToNative(IntPtr.Add(base.Address, PipelineQueue_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:OnMapLoad")]
	public unsafe void OnMapLoad(UWorld InWorld)
	{
		CheckDestroyed();
		if (!OnMapLoad_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:OnMapLoad");
			return;
		}
		if (OnMapLoad_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMapLoad_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMapLoad");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMapLoad_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMapLoad_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnMapLoad_InWorld_Offset), 0, OnMapLoad_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMapLoad_InstanceFunctionAddress, intPtr, OnMapLoad_ParamsSize);
	}

	protected unsafe virtual void OnMapLoad_Implementation(UWorld InWorld)
	{
		CheckDestroyed();
		if (!OnMapLoad_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:OnMapLoad");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMapLoad_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMapLoad_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, OnMapLoad_InWorld_Offset), 0, OnMapLoad_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMapLoad_FunctionAddress, intPtr, OnMapLoad_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:GetLastLoadedWorld")]
	public unsafe UWorld GetLastLoadedWorld()
	{
		CheckDestroyed();
		if (!GetLastLoadedWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:GetLastLoadedWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastLoadedWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastLoadedWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastLoadedWorld_FunctionAddress, intPtr, GetLastLoadedWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetLastLoadedWorld_ReturnValue_Offset), 0, GetLastLoadedWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:ExecuteDelayed")]
	public unsafe void ExecuteDelayed(UMoviePipelineQueue InPipelineQueue)
	{
		CheckDestroyed();
		if (!ExecuteDelayed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:ExecuteDelayed");
			return;
		}
		if (ExecuteDelayed_InstanceFunctionAddress == IntPtr.Zero)
		{
			ExecuteDelayed_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ExecuteDelayed");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteDelayed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteDelayed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineQueue>.ToNative(IntPtr.Add(intPtr, ExecuteDelayed_InPipelineQueue_Offset), 0, ExecuteDelayed_InPipelineQueue_PropertyAddress.Address, InPipelineQueue);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecuteDelayed_InstanceFunctionAddress, intPtr, ExecuteDelayed_ParamsSize);
	}

	protected unsafe virtual void ExecuteDelayed_Implementation(UMoviePipelineQueue InPipelineQueue)
	{
		CheckDestroyed();
		if (!ExecuteDelayed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:ExecuteDelayed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteDelayed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteDelayed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineQueue>.ToNative(IntPtr.Add(intPtr, ExecuteDelayed_InPipelineQueue_Offset), 0, ExecuteDelayed_InPipelineQueue_PropertyAddress.Address, InPipelineQueue);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecuteDelayed_FunctionAddress, intPtr, ExecuteDelayed_ParamsSize);
	}

	static UMoviePipelinePythonHostExecutor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelinePythonHostExecutor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelinePythonHostExecutor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor");
		ExecutorClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExecutorClass");
		ExecutorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExecutorClass", Classes.FClassProperty);
		PipelineQueue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PipelineQueue");
		PipelineQueue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PipelineQueue", Classes.FObjectProperty);
		OnMapLoad_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMapLoad");
		OnMapLoad_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMapLoad_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMapLoad_InWorld_PropertyAddress, OnMapLoad_FunctionAddress, "InWorld");
		OnMapLoad_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(OnMapLoad_FunctionAddress, "InWorld");
		OnMapLoad_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMapLoad_FunctionAddress, "InWorld", Classes.FObjectProperty);
		OnMapLoad_IsValid = OnMapLoad_FunctionAddress != IntPtr.Zero && OnMapLoad_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:OnMapLoad", OnMapLoad_IsValid);
		GetLastLoadedWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLastLoadedWorld");
		GetLastLoadedWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastLoadedWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastLoadedWorld_ReturnValue_PropertyAddress, GetLastLoadedWorld_FunctionAddress, "ReturnValue");
		GetLastLoadedWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastLoadedWorld_FunctionAddress, "ReturnValue");
		GetLastLoadedWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastLoadedWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLastLoadedWorld_IsValid = GetLastLoadedWorld_FunctionAddress != IntPtr.Zero && GetLastLoadedWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:GetLastLoadedWorld", GetLastLoadedWorld_IsValid);
		ExecuteDelayed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExecuteDelayed");
		ExecuteDelayed_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteDelayed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecuteDelayed_InPipelineQueue_PropertyAddress, ExecuteDelayed_FunctionAddress, "InPipelineQueue");
		ExecuteDelayed_InPipelineQueue_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteDelayed_FunctionAddress, "InPipelineQueue");
		ExecuteDelayed_InPipelineQueue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteDelayed_FunctionAddress, "InPipelineQueue", Classes.FObjectProperty);
		ExecuteDelayed_IsValid = ExecuteDelayed_FunctionAddress != IntPtr.Zero && ExecuteDelayed_InPipelineQueue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelinePythonHostExecutor:ExecuteDelayed", ExecuteDelayed_IsValid);
	}
}
