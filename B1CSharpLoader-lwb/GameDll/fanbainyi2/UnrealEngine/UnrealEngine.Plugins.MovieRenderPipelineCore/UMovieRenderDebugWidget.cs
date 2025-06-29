using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[Abstract]
[UClass(Flags = (ClassFlags)819990689uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MovieRenderDebugWidget", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMovieRenderDebugWidget : UUserWidget
{
	private static bool OnInitializedForPipeline_IsValid;

	private IntPtr OnInitializedForPipeline_InstanceFunctionAddress;

	private static IntPtr OnInitializedForPipeline_FunctionAddress;

	private static int OnInitializedForPipeline_ParamsSize;

	private static bool OnInitializedForPipeline_ForPipeline_IsValid;

	private static FFieldAddress OnInitializedForPipeline_ForPipeline_PropertyAddress;

	private static int OnInitializedForPipeline_ForPipeline_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MovieRenderDebugWidget:OnInitializedForPipeline")]
	public unsafe void OnInitializedForPipeline(UMoviePipeline ForPipeline)
	{
		CheckDestroyed();
		if (!OnInitializedForPipeline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MovieRenderDebugWidget:OnInitializedForPipeline");
			return;
		}
		if (OnInitializedForPipeline_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInitializedForPipeline_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInitializedForPipeline");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInitializedForPipeline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInitializedForPipeline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, OnInitializedForPipeline_ForPipeline_Offset), 0, OnInitializedForPipeline_ForPipeline_PropertyAddress.Address, ForPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInitializedForPipeline_InstanceFunctionAddress, intPtr, OnInitializedForPipeline_ParamsSize);
	}

	protected unsafe virtual void OnInitializedForPipeline_Implementation(UMoviePipeline ForPipeline)
	{
		CheckDestroyed();
		if (!OnInitializedForPipeline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MovieRenderDebugWidget:OnInitializedForPipeline");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInitializedForPipeline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInitializedForPipeline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, OnInitializedForPipeline_ForPipeline_Offset), 0, OnInitializedForPipeline_ForPipeline_PropertyAddress.Address, ForPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnInitializedForPipeline_FunctionAddress, intPtr, OnInitializedForPipeline_ParamsSize);
	}

	static UMovieRenderDebugWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieRenderDebugWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieRenderDebugWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MovieRenderDebugWidget");
		OnInitializedForPipeline_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnInitializedForPipeline");
		OnInitializedForPipeline_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInitializedForPipeline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnInitializedForPipeline_ForPipeline_PropertyAddress, OnInitializedForPipeline_FunctionAddress, "ForPipeline");
		OnInitializedForPipeline_ForPipeline_Offset = NativeReflectionCached.GetPropertyOffset(OnInitializedForPipeline_FunctionAddress, "ForPipeline");
		OnInitializedForPipeline_ForPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInitializedForPipeline_FunctionAddress, "ForPipeline", Classes.FObjectProperty);
		OnInitializedForPipeline_IsValid = OnInitializedForPipeline_FunctionAddress != IntPtr.Zero && OnInitializedForPipeline_ForPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MovieRenderDebugWidget:OnInitializedForPipeline", OnInitializedForPipeline_IsValid);
	}
}
