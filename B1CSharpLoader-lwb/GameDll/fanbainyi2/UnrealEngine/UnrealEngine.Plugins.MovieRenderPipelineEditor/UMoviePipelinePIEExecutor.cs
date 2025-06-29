using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineEditor;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutor", "MovieRenderPipelineEditor", UnrealModuleType.EnginePlugin)]
public class UMoviePipelinePIEExecutor : UMoviePipelineLinearExecutorBase
{
	private static bool SetInitializationTime_IsValid;

	private static IntPtr SetInitializationTime_FunctionAddress;

	private static int SetInitializationTime_ParamsSize;

	private static bool SetInitializationTime_InInitializationTime_IsValid;

	private static FFieldAddress SetInitializationTime_InInitializationTime_PropertyAddress;

	private static int SetInitializationTime_InInitializationTime_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutor:SetInitializationTime")]
	public unsafe void SetInitializationTime(FDateTime InInitializationTime)
	{
		CheckDestroyed();
		if (!SetInitializationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutor:SetInitializationTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInitializationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInitializationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, SetInitializationTime_InInitializationTime_Offset), 0, SetInitializationTime_InInitializationTime_PropertyAddress.Address, InInitializationTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInitializationTime_FunctionAddress, intPtr, SetInitializationTime_ParamsSize);
	}

	static UMoviePipelinePIEExecutor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelinePIEExecutor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelinePIEExecutor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutor");
		SetInitializationTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetInitializationTime");
		SetInitializationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInitializationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInitializationTime_InInitializationTime_PropertyAddress, SetInitializationTime_FunctionAddress, "InInitializationTime");
		SetInitializationTime_InInitializationTime_Offset = NativeReflectionCached.GetPropertyOffset(SetInitializationTime_FunctionAddress, "InInitializationTime");
		SetInitializationTime_InInitializationTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitializationTime_FunctionAddress, "InInitializationTime", Classes.FStructProperty);
		SetInitializationTime_IsValid = SetInitializationTime_FunctionAddress != IntPtr.Zero && SetInitializationTime_InInitializationTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutor:SetInitializationTime", SetInitializationTime_IsValid);
	}
}
