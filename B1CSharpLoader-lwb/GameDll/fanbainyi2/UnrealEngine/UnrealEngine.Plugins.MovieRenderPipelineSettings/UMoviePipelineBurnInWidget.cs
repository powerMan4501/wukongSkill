using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace UnrealEngine.Plugins.MovieRenderPipelineSettings;

[Abstract]
[UClass(Flags = (ClassFlags)821039265uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInWidget", "MovieRenderPipelineSettings", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineBurnInWidget : UUserWidget
{
	private static bool OnOutputFrameStarted_IsValid;

	private IntPtr OnOutputFrameStarted_InstanceFunctionAddress;

	private static IntPtr OnOutputFrameStarted_FunctionAddress;

	private static int OnOutputFrameStarted_ParamsSize;

	private static bool OnOutputFrameStarted_ForPipeline_IsValid;

	private static FFieldAddress OnOutputFrameStarted_ForPipeline_PropertyAddress;

	private static int OnOutputFrameStarted_ForPipeline_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInWidget:OnOutputFrameStarted")]
	public unsafe void OnOutputFrameStarted(UMoviePipeline ForPipeline)
	{
		CheckDestroyed();
		if (!OnOutputFrameStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInWidget:OnOutputFrameStarted");
			return;
		}
		if (OnOutputFrameStarted_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnOutputFrameStarted_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnOutputFrameStarted");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnOutputFrameStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnOutputFrameStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, OnOutputFrameStarted_ForPipeline_Offset), 0, OnOutputFrameStarted_ForPipeline_PropertyAddress.Address, ForPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnOutputFrameStarted_InstanceFunctionAddress, intPtr, OnOutputFrameStarted_ParamsSize);
	}

	protected unsafe virtual void OnOutputFrameStarted_Implementation(UMoviePipeline ForPipeline)
	{
		CheckDestroyed();
		if (!OnOutputFrameStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInWidget:OnOutputFrameStarted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnOutputFrameStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnOutputFrameStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, OnOutputFrameStarted_ForPipeline_Offset), 0, OnOutputFrameStarted_ForPipeline_PropertyAddress.Address, ForPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnOutputFrameStarted_FunctionAddress, intPtr, OnOutputFrameStarted_ParamsSize);
	}

	static UMoviePipelineBurnInWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineBurnInWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineBurnInWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInWidget");
		OnOutputFrameStarted_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnOutputFrameStarted");
		OnOutputFrameStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnOutputFrameStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnOutputFrameStarted_ForPipeline_PropertyAddress, OnOutputFrameStarted_FunctionAddress, "ForPipeline");
		OnOutputFrameStarted_ForPipeline_Offset = NativeReflectionCached.GetPropertyOffset(OnOutputFrameStarted_FunctionAddress, "ForPipeline");
		OnOutputFrameStarted_ForPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(OnOutputFrameStarted_FunctionAddress, "ForPipeline", Classes.FObjectProperty);
		OnOutputFrameStarted_IsValid = OnOutputFrameStarted_FunctionAddress != IntPtr.Zero && OnOutputFrameStarted_ForPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineSettings.MoviePipelineBurnInWidget:OnOutputFrameStarted", OnOutputFrameStarted_IsValid);
	}
}
