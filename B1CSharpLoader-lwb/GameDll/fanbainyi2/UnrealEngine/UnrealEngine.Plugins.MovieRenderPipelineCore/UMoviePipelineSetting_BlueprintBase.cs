using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineSetting_BlueprintBase : UMoviePipelineSetting
{
	private static bool ReceiveTeardownForPipelineImpl_IsValid;

	private IntPtr ReceiveTeardownForPipelineImpl_InstanceFunctionAddress;

	private static IntPtr ReceiveTeardownForPipelineImpl_FunctionAddress;

	private static int ReceiveTeardownForPipelineImpl_ParamsSize;

	private static bool ReceiveTeardownForPipelineImpl_InPipeline_IsValid;

	private static FFieldAddress ReceiveTeardownForPipelineImpl_InPipeline_PropertyAddress;

	private static int ReceiveTeardownForPipelineImpl_InPipeline_Offset;

	private static bool ReceiveSetupForPipelineImpl_IsValid;

	private IntPtr ReceiveSetupForPipelineImpl_InstanceFunctionAddress;

	private static IntPtr ReceiveSetupForPipelineImpl_FunctionAddress;

	private static int ReceiveSetupForPipelineImpl_ParamsSize;

	private static bool ReceiveSetupForPipelineImpl_InPipeline_IsValid;

	private static FFieldAddress ReceiveSetupForPipelineImpl_InPipeline_PropertyAddress;

	private static int ReceiveSetupForPipelineImpl_InPipeline_Offset;

	private static bool ReceiveGetFormatArguments_IsValid;

	private IntPtr ReceiveGetFormatArguments_InstanceFunctionAddress;

	private static IntPtr ReceiveGetFormatArguments_FunctionAddress;

	private static int ReceiveGetFormatArguments_ParamsSize;

	private static bool ReceiveGetFormatArguments_InOutFormatArgs_IsValid;

	private static FFieldAddress ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress;

	private static int ReceiveGetFormatArguments_InOutFormatArgs_Offset;

	private static bool ReceiveGetFormatArguments_ReturnValue_IsValid;

	private static FFieldAddress ReceiveGetFormatArguments_ReturnValue_PropertyAddress;

	private static int ReceiveGetFormatArguments_ReturnValue_Offset;

	private static bool ReceiveGetFooterText_IsValid;

	private IntPtr ReceiveGetFooterText_InstanceFunctionAddress;

	private static IntPtr ReceiveGetFooterText_FunctionAddress;

	private static int ReceiveGetFooterText_ParamsSize;

	private static bool ReceiveGetFooterText_InJob_IsValid;

	private static FFieldAddress ReceiveGetFooterText_InJob_PropertyAddress;

	private static int ReceiveGetFooterText_InJob_Offset;

	private static bool ReceiveGetFooterText_ReturnValue_IsValid;

	private static FFieldAddress ReceiveGetFooterText_ReturnValue_PropertyAddress;

	private static int ReceiveGetFooterText_ReturnValue_Offset;

	private static bool OnEngineTickBeginFrame_IsValid;

	private IntPtr OnEngineTickBeginFrame_InstanceFunctionAddress;

	private static IntPtr OnEngineTickBeginFrame_FunctionAddress;

	private static int OnEngineTickBeginFrame_ParamsSize;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveTeardownForPipelineImpl")]
	public unsafe void ReceiveTeardownForPipelineImpl(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!ReceiveTeardownForPipelineImpl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveTeardownForPipelineImpl");
			return;
		}
		if (ReceiveTeardownForPipelineImpl_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveTeardownForPipelineImpl_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveTeardownForPipelineImpl");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTeardownForPipelineImpl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTeardownForPipelineImpl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, ReceiveTeardownForPipelineImpl_InPipeline_Offset), 0, ReceiveTeardownForPipelineImpl_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTeardownForPipelineImpl_InstanceFunctionAddress, intPtr, ReceiveTeardownForPipelineImpl_ParamsSize);
	}

	protected unsafe virtual void ReceiveTeardownForPipelineImpl_Implementation(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!ReceiveTeardownForPipelineImpl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveTeardownForPipelineImpl");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTeardownForPipelineImpl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTeardownForPipelineImpl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, ReceiveTeardownForPipelineImpl_InPipeline_Offset), 0, ReceiveTeardownForPipelineImpl_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTeardownForPipelineImpl_FunctionAddress, intPtr, ReceiveTeardownForPipelineImpl_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveSetupForPipelineImpl")]
	public unsafe void ReceiveSetupForPipelineImpl(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!ReceiveSetupForPipelineImpl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveSetupForPipelineImpl");
			return;
		}
		if (ReceiveSetupForPipelineImpl_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveSetupForPipelineImpl_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveSetupForPipelineImpl");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveSetupForPipelineImpl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveSetupForPipelineImpl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, ReceiveSetupForPipelineImpl_InPipeline_Offset), 0, ReceiveSetupForPipelineImpl_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveSetupForPipelineImpl_InstanceFunctionAddress, intPtr, ReceiveSetupForPipelineImpl_ParamsSize);
	}

	protected unsafe virtual void ReceiveSetupForPipelineImpl_Implementation(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!ReceiveSetupForPipelineImpl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveSetupForPipelineImpl");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveSetupForPipelineImpl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveSetupForPipelineImpl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, ReceiveSetupForPipelineImpl_InPipeline_Offset), 0, ReceiveSetupForPipelineImpl_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveSetupForPipelineImpl_FunctionAddress, intPtr, ReceiveSetupForPipelineImpl_ParamsSize);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveGetFormatArguments")]
	public unsafe FMoviePipelineFormatArgs ReceiveGetFormatArguments(ref FMoviePipelineFormatArgs InOutFormatArgs)
	{
		CheckDestroyed();
		if (!ReceiveGetFormatArguments_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveGetFormatArguments");
			return default(FMoviePipelineFormatArgs);
		}
		if (ReceiveGetFormatArguments_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveGetFormatArguments_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveGetFormatArguments");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveGetFormatArguments_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveGetFormatArguments_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress.Address, intPtr);
		FMoviePipelineFormatArgs.ToNative(IntPtr.Add(intPtr, ReceiveGetFormatArguments_InOutFormatArgs_Offset), 0, ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress.Address, InOutFormatArgs);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveGetFormatArguments_InstanceFunctionAddress, intPtr, ReceiveGetFormatArguments_ParamsSize);
		InOutFormatArgs = FMoviePipelineFormatArgs.FromNative(IntPtr.Add(intPtr, ReceiveGetFormatArguments_InOutFormatArgs_Offset), 0, ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress.Address, intPtr);
		FMoviePipelineFormatArgs result = FMoviePipelineFormatArgs.FromNative(IntPtr.Add(intPtr, ReceiveGetFormatArguments_ReturnValue_Offset), 0, ReceiveGetFormatArguments_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ReceiveGetFormatArguments_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FMoviePipelineFormatArgs ReceiveGetFormatArguments_Implementation(ref FMoviePipelineFormatArgs InOutFormatArgs)
	{
		CheckDestroyed();
		if (!ReceiveGetFormatArguments_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveGetFormatArguments");
			return default(FMoviePipelineFormatArgs);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveGetFormatArguments_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveGetFormatArguments_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress.Address, intPtr);
		FMoviePipelineFormatArgs.ToNative(IntPtr.Add(intPtr, ReceiveGetFormatArguments_InOutFormatArgs_Offset), 0, ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress.Address, InOutFormatArgs);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveGetFormatArguments_FunctionAddress, intPtr, ReceiveGetFormatArguments_ParamsSize);
		InOutFormatArgs = FMoviePipelineFormatArgs.FromNative(IntPtr.Add(intPtr, ReceiveGetFormatArguments_InOutFormatArgs_Offset), 0, ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress.Address, intPtr);
		FMoviePipelineFormatArgs result = FMoviePipelineFormatArgs.FromNative(IntPtr.Add(intPtr, ReceiveGetFormatArguments_ReturnValue_Offset), 0, ReceiveGetFormatArguments_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ReceiveGetFormatArguments_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1744963584u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveGetFooterText")]
	public unsafe string ReceiveGetFooterText(UMoviePipelineExecutorJob InJob)
	{
		CheckDestroyed();
		if (!ReceiveGetFooterText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveGetFooterText");
			return FStringMarshaler.DefaultString;
		}
		if (ReceiveGetFooterText_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveGetFooterText_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveGetFooterText");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveGetFooterText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveGetFooterText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, ReceiveGetFooterText_InJob_Offset), 0, ReceiveGetFooterText_InJob_PropertyAddress.Address, InJob);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveGetFooterText_InstanceFunctionAddress, intPtr, ReceiveGetFooterText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, ReceiveGetFooterText_ReturnValue_Offset), 0, ReceiveGetFooterText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(ReceiveGetFooterText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string ReceiveGetFooterText_Implementation(UMoviePipelineExecutorJob InJob)
	{
		CheckDestroyed();
		if (!ReceiveGetFooterText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveGetFooterText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveGetFooterText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveGetFooterText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, ReceiveGetFooterText_InJob_Offset), 0, ReceiveGetFooterText_InJob_PropertyAddress.Address, InJob);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveGetFooterText_FunctionAddress, intPtr, ReceiveGetFooterText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, ReceiveGetFooterText_ReturnValue_Offset), 0, ReceiveGetFooterText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(ReceiveGetFooterText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:OnEngineTickBeginFrame")]
	public unsafe void OnEngineTickBeginFrame()
	{
		CheckDestroyed();
		if (!OnEngineTickBeginFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:OnEngineTickBeginFrame");
			return;
		}
		if (OnEngineTickBeginFrame_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEngineTickBeginFrame_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnEngineTickBeginFrame");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEngineTickBeginFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEngineTickBeginFrame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnEngineTickBeginFrame_InstanceFunctionAddress, argsSize: OnEngineTickBeginFrame_ParamsSize);
	}

	protected unsafe virtual void OnEngineTickBeginFrame_Implementation()
	{
		CheckDestroyed();
		if (!OnEngineTickBeginFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:OnEngineTickBeginFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEngineTickBeginFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEngineTickBeginFrame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnEngineTickBeginFrame_FunctionAddress, argsSize: OnEngineTickBeginFrame_ParamsSize);
	}

	static UMoviePipelineSetting_BlueprintBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineSetting_BlueprintBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineSetting_BlueprintBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase");
		ReceiveTeardownForPipelineImpl_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveTeardownForPipelineImpl");
		ReceiveTeardownForPipelineImpl_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTeardownForPipelineImpl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTeardownForPipelineImpl_InPipeline_PropertyAddress, ReceiveTeardownForPipelineImpl_FunctionAddress, "InPipeline");
		ReceiveTeardownForPipelineImpl_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTeardownForPipelineImpl_FunctionAddress, "InPipeline");
		ReceiveTeardownForPipelineImpl_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTeardownForPipelineImpl_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		ReceiveTeardownForPipelineImpl_IsValid = ReceiveTeardownForPipelineImpl_FunctionAddress != IntPtr.Zero && ReceiveTeardownForPipelineImpl_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveTeardownForPipelineImpl", ReceiveTeardownForPipelineImpl_IsValid);
		ReceiveSetupForPipelineImpl_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveSetupForPipelineImpl");
		ReceiveSetupForPipelineImpl_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveSetupForPipelineImpl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveSetupForPipelineImpl_InPipeline_PropertyAddress, ReceiveSetupForPipelineImpl_FunctionAddress, "InPipeline");
		ReceiveSetupForPipelineImpl_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveSetupForPipelineImpl_FunctionAddress, "InPipeline");
		ReceiveSetupForPipelineImpl_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveSetupForPipelineImpl_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		ReceiveSetupForPipelineImpl_IsValid = ReceiveSetupForPipelineImpl_FunctionAddress != IntPtr.Zero && ReceiveSetupForPipelineImpl_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveSetupForPipelineImpl", ReceiveSetupForPipelineImpl_IsValid);
		ReceiveGetFormatArguments_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveGetFormatArguments");
		ReceiveGetFormatArguments_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveGetFormatArguments_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveGetFormatArguments_InOutFormatArgs_PropertyAddress, ReceiveGetFormatArguments_FunctionAddress, "InOutFormatArgs");
		ReceiveGetFormatArguments_InOutFormatArgs_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveGetFormatArguments_FunctionAddress, "InOutFormatArgs");
		ReceiveGetFormatArguments_InOutFormatArgs_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveGetFormatArguments_FunctionAddress, "InOutFormatArgs", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveGetFormatArguments_ReturnValue_PropertyAddress, ReceiveGetFormatArguments_FunctionAddress, "ReturnValue");
		ReceiveGetFormatArguments_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveGetFormatArguments_FunctionAddress, "ReturnValue");
		ReceiveGetFormatArguments_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveGetFormatArguments_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ReceiveGetFormatArguments_IsValid = ReceiveGetFormatArguments_FunctionAddress != IntPtr.Zero && ReceiveGetFormatArguments_InOutFormatArgs_IsValid && ReceiveGetFormatArguments_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveGetFormatArguments", ReceiveGetFormatArguments_IsValid);
		ReceiveGetFooterText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveGetFooterText");
		ReceiveGetFooterText_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveGetFooterText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveGetFooterText_InJob_PropertyAddress, ReceiveGetFooterText_FunctionAddress, "InJob");
		ReceiveGetFooterText_InJob_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveGetFooterText_FunctionAddress, "InJob");
		ReceiveGetFooterText_InJob_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveGetFooterText_FunctionAddress, "InJob", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveGetFooterText_ReturnValue_PropertyAddress, ReceiveGetFooterText_FunctionAddress, "ReturnValue");
		ReceiveGetFooterText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveGetFooterText_FunctionAddress, "ReturnValue");
		ReceiveGetFooterText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveGetFooterText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		ReceiveGetFooterText_IsValid = ReceiveGetFooterText_FunctionAddress != IntPtr.Zero && ReceiveGetFooterText_InJob_IsValid && ReceiveGetFooterText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:ReceiveGetFooterText", ReceiveGetFooterText_IsValid);
		OnEngineTickBeginFrame_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnEngineTickBeginFrame");
		OnEngineTickBeginFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEngineTickBeginFrame_FunctionAddress);
		OnEngineTickBeginFrame_IsValid = OnEngineTickBeginFrame_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineSetting_BlueprintBase:OnEngineTickBeginFrame", OnEngineTickBeginFrame_IsValid);
	}
}
