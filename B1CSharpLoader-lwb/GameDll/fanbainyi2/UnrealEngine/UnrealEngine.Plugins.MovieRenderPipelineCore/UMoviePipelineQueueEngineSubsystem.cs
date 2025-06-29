using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineQueueEngineSubsystem : UEngineSubsystem
{
	private static bool RenderQueueWithExecutorInstance_IsValid;

	private static IntPtr RenderQueueWithExecutorInstance_FunctionAddress;

	private static int RenderQueueWithExecutorInstance_ParamsSize;

	private static bool RenderQueueWithExecutorInstance_InExecutor_IsValid;

	private static FFieldAddress RenderQueueWithExecutorInstance_InExecutor_PropertyAddress;

	private static int RenderQueueWithExecutorInstance_InExecutor_Offset;

	private static bool RenderQueueWithExecutor_IsValid;

	private static IntPtr RenderQueueWithExecutor_FunctionAddress;

	private static int RenderQueueWithExecutor_ParamsSize;

	private static bool RenderQueueWithExecutor_InExecutorType_IsValid;

	private static FFieldAddress RenderQueueWithExecutor_InExecutorType_PropertyAddress;

	private static int RenderQueueWithExecutor_InExecutorType_Offset;

	private static bool RenderQueueWithExecutor_ReturnValue_IsValid;

	private static FFieldAddress RenderQueueWithExecutor_ReturnValue_PropertyAddress;

	private static int RenderQueueWithExecutor_ReturnValue_Offset;

	private static bool IsRendering_IsValid;

	private static IntPtr IsRendering_FunctionAddress;

	private static int IsRendering_ParamsSize;

	private static bool IsRendering_ReturnValue_IsValid;

	private static FFieldAddress IsRendering_ReturnValue_PropertyAddress;

	private static int IsRendering_ReturnValue_Offset;

	private static bool GetQueue_IsValid;

	private static IntPtr GetQueue_FunctionAddress;

	private static int GetQueue_ParamsSize;

	private static bool GetQueue_ReturnValue_IsValid;

	private static FFieldAddress GetQueue_ReturnValue_PropertyAddress;

	private static int GetQueue_ReturnValue_Offset;

	private static bool GetActiveExecutor_IsValid;

	private static IntPtr GetActiveExecutor_FunctionAddress;

	private static int GetActiveExecutor_ParamsSize;

	private static bool GetActiveExecutor_ReturnValue_IsValid;

	private static FFieldAddress GetActiveExecutor_ReturnValue_PropertyAddress;

	private static int GetActiveExecutor_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:RenderQueueWithExecutorInstance")]
	public unsafe void RenderQueueWithExecutorInstance(UMoviePipelineExecutorBase InExecutor)
	{
		CheckDestroyed();
		if (!RenderQueueWithExecutorInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:RenderQueueWithExecutorInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenderQueueWithExecutorInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenderQueueWithExecutorInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineExecutorBase>.ToNative(IntPtr.Add(intPtr, RenderQueueWithExecutorInstance_InExecutor_Offset), 0, RenderQueueWithExecutorInstance_InExecutor_PropertyAddress.Address, InExecutor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenderQueueWithExecutorInstance_FunctionAddress, intPtr, RenderQueueWithExecutorInstance_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:RenderQueueWithExecutor")]
	public unsafe UMoviePipelineExecutorBase RenderQueueWithExecutor(TSubclassOf<UMoviePipelineExecutorBase> InExecutorType)
	{
		CheckDestroyed();
		if (!RenderQueueWithExecutor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:RenderQueueWithExecutor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenderQueueWithExecutor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenderQueueWithExecutor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UMoviePipelineExecutorBase>.ToNative(IntPtr.Add(intPtr, RenderQueueWithExecutor_InExecutorType_Offset), 0, RenderQueueWithExecutor_InExecutorType_PropertyAddress.Address, InExecutorType);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenderQueueWithExecutor_FunctionAddress, intPtr, RenderQueueWithExecutor_ParamsSize);
		return UObjectMarshaler<UMoviePipelineExecutorBase>.FromNative(IntPtr.Add(intPtr, RenderQueueWithExecutor_ReturnValue_Offset), 0, RenderQueueWithExecutor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:IsRendering")]
	public unsafe bool IsRendering()
	{
		CheckDestroyed();
		if (!IsRendering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:IsRendering");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRendering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRendering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRendering_FunctionAddress, intPtr, IsRendering_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRendering_ReturnValue_Offset), 0, IsRendering_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:GetQueue")]
	public unsafe UMoviePipelineQueue GetQueue()
	{
		CheckDestroyed();
		if (!GetQueue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:GetQueue");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQueue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQueue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetQueue_FunctionAddress, intPtr, GetQueue_ParamsSize);
		return UObjectMarshaler<UMoviePipelineQueue>.FromNative(IntPtr.Add(intPtr, GetQueue_ReturnValue_Offset), 0, GetQueue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:GetActiveExecutor")]
	public unsafe UMoviePipelineExecutorBase GetActiveExecutor()
	{
		CheckDestroyed();
		if (!GetActiveExecutor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:GetActiveExecutor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActiveExecutor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActiveExecutor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActiveExecutor_FunctionAddress, intPtr, GetActiveExecutor_ParamsSize);
		return UObjectMarshaler<UMoviePipelineExecutorBase>.FromNative(IntPtr.Add(intPtr, GetActiveExecutor_ReturnValue_Offset), 0, GetActiveExecutor_ReturnValue_PropertyAddress.Address);
	}

	static UMoviePipelineQueueEngineSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineQueueEngineSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineQueueEngineSubsystem));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem");
		RenderQueueWithExecutorInstance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RenderQueueWithExecutorInstance");
		RenderQueueWithExecutorInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(RenderQueueWithExecutorInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenderQueueWithExecutorInstance_InExecutor_PropertyAddress, RenderQueueWithExecutorInstance_FunctionAddress, "InExecutor");
		RenderQueueWithExecutorInstance_InExecutor_Offset = NativeReflectionCached.GetPropertyOffset(RenderQueueWithExecutorInstance_FunctionAddress, "InExecutor");
		RenderQueueWithExecutorInstance_InExecutor_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderQueueWithExecutorInstance_FunctionAddress, "InExecutor", Classes.FObjectProperty);
		RenderQueueWithExecutorInstance_IsValid = RenderQueueWithExecutorInstance_FunctionAddress != IntPtr.Zero && RenderQueueWithExecutorInstance_InExecutor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:RenderQueueWithExecutorInstance", RenderQueueWithExecutorInstance_IsValid);
		RenderQueueWithExecutor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RenderQueueWithExecutor");
		RenderQueueWithExecutor_ParamsSize = NativeReflection.GetFunctionParamsSize(RenderQueueWithExecutor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenderQueueWithExecutor_InExecutorType_PropertyAddress, RenderQueueWithExecutor_FunctionAddress, "InExecutorType");
		RenderQueueWithExecutor_InExecutorType_Offset = NativeReflectionCached.GetPropertyOffset(RenderQueueWithExecutor_FunctionAddress, "InExecutorType");
		RenderQueueWithExecutor_InExecutorType_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderQueueWithExecutor_FunctionAddress, "InExecutorType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderQueueWithExecutor_ReturnValue_PropertyAddress, RenderQueueWithExecutor_FunctionAddress, "ReturnValue");
		RenderQueueWithExecutor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenderQueueWithExecutor_FunctionAddress, "ReturnValue");
		RenderQueueWithExecutor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenderQueueWithExecutor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		RenderQueueWithExecutor_IsValid = RenderQueueWithExecutor_FunctionAddress != IntPtr.Zero && RenderQueueWithExecutor_InExecutorType_IsValid && RenderQueueWithExecutor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:RenderQueueWithExecutor", RenderQueueWithExecutor_IsValid);
		IsRendering_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsRendering");
		IsRendering_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRendering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRendering_ReturnValue_PropertyAddress, IsRendering_FunctionAddress, "ReturnValue");
		IsRendering_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRendering_FunctionAddress, "ReturnValue");
		IsRendering_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRendering_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRendering_IsValid = IsRendering_FunctionAddress != IntPtr.Zero && IsRendering_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:IsRendering", IsRendering_IsValid);
		GetQueue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetQueue");
		GetQueue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQueue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQueue_ReturnValue_PropertyAddress, GetQueue_FunctionAddress, "ReturnValue");
		GetQueue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQueue_FunctionAddress, "ReturnValue");
		GetQueue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueue_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetQueue_IsValid = GetQueue_FunctionAddress != IntPtr.Zero && GetQueue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:GetQueue", GetQueue_IsValid);
		GetActiveExecutor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActiveExecutor");
		GetActiveExecutor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActiveExecutor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActiveExecutor_ReturnValue_PropertyAddress, GetActiveExecutor_FunctionAddress, "ReturnValue");
		GetActiveExecutor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActiveExecutor_FunctionAddress, "ReturnValue");
		GetActiveExecutor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActiveExecutor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActiveExecutor_IsValid = GetActiveExecutor_FunctionAddress != IntPtr.Zero && GetActiveExecutor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineQueueEngineSubsystem:GetActiveExecutor", GetActiveExecutor_IsValid);
	}
}
