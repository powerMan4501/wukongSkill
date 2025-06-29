using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipeline : UObject
{
	private static bool OnMoviePipelineFinishedDelegate_IsValid;

	private static int OnMoviePipelineFinishedDelegate_Offset;

	private FMoviePipelineFinished OnMoviePipelineFinishedDelegate_DelegateCached;

	private static bool OnMoviePipelineWorkFinishedDelegate_IsValid;

	private static int OnMoviePipelineWorkFinishedDelegate_Offset;

	private FMoviePipelineWorkFinished OnMoviePipelineWorkFinishedDelegate_DelegateCached;

	private static bool OnMoviePipelineShotWorkFinishedDelegate_IsValid;

	private static int OnMoviePipelineShotWorkFinishedDelegate_Offset;

	private FMoviePipelineWorkFinished OnMoviePipelineShotWorkFinishedDelegate_DelegateCached;

	private static bool Shutdown_IsValid;

	private static IntPtr Shutdown_FunctionAddress;

	private static int Shutdown_ParamsSize;

	private static bool Shutdown_bError_IsValid;

	private static FFieldAddress Shutdown_bError_PropertyAddress;

	private static int Shutdown_bError_Offset;

	private static bool SetInitializationTime_IsValid;

	private static IntPtr SetInitializationTime_FunctionAddress;

	private static int SetInitializationTime_ParamsSize;

	private static bool SetInitializationTime_InDateTime_IsValid;

	private static FFieldAddress SetInitializationTime_InDateTime_PropertyAddress;

	private static int SetInitializationTime_InDateTime_Offset;

	private static bool RequestShutdown_IsValid;

	private static IntPtr RequestShutdown_FunctionAddress;

	private static int RequestShutdown_ParamsSize;

	private static bool RequestShutdown_bIsError_IsValid;

	private static FFieldAddress RequestShutdown_bIsError_PropertyAddress;

	private static int RequestShutdown_bIsError_Offset;

	private static bool OnMoviePipelineFinishedImpl_IsValid;

	private static IntPtr OnMoviePipelineFinishedImpl_FunctionAddress;

	private static int OnMoviePipelineFinishedImpl_ParamsSize;

	private static bool IsShutdownRequested_IsValid;

	private static IntPtr IsShutdownRequested_FunctionAddress;

	private static int IsShutdownRequested_ParamsSize;

	private static bool IsShutdownRequested_ReturnValue_IsValid;

	private static FFieldAddress IsShutdownRequested_ReturnValue_PropertyAddress;

	private static int IsShutdownRequested_ReturnValue_Offset;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool Initialize_InJob_IsValid;

	private static FFieldAddress Initialize_InJob_PropertyAddress;

	private static int Initialize_InJob_Offset;

	private static bool GetPreviewTexture_IsValid;

	private static IntPtr GetPreviewTexture_FunctionAddress;

	private static int GetPreviewTexture_ParamsSize;

	private static bool GetPreviewTexture_ReturnValue_IsValid;

	private static FFieldAddress GetPreviewTexture_ReturnValue_PropertyAddress;

	private static int GetPreviewTexture_ReturnValue_Offset;

	private static bool GetPipelineMasterConfig_IsValid;

	private static IntPtr GetPipelineMasterConfig_FunctionAddress;

	private static int GetPipelineMasterConfig_ParamsSize;

	private static bool GetPipelineMasterConfig_ReturnValue_IsValid;

	private static FFieldAddress GetPipelineMasterConfig_ReturnValue_PropertyAddress;

	private static int GetPipelineMasterConfig_ReturnValue_Offset;

	private static bool GetInitializationTime_IsValid;

	private static IntPtr GetInitializationTime_FunctionAddress;

	private static int GetInitializationTime_ParamsSize;

	private static bool GetInitializationTime_ReturnValue_IsValid;

	private static FFieldAddress GetInitializationTime_ReturnValue_PropertyAddress;

	private static int GetInitializationTime_ReturnValue_Offset;

	private static bool GetCurrentJob_IsValid;

	private static IntPtr GetCurrentJob_FunctionAddress;

	private static int GetCurrentJob_ParamsSize;

	private static bool GetCurrentJob_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentJob_ReturnValue_PropertyAddress;

	private static int GetCurrentJob_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:OnMoviePipelineFinishedDelegate")]
	public FMoviePipelineFinished OnMoviePipelineFinishedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnMoviePipelineFinishedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:OnMoviePipelineFinishedDelegate");
				return new FMoviePipelineFinished();
			}
			if (OnMoviePipelineFinishedDelegate_DelegateCached == null)
			{
				OnMoviePipelineFinishedDelegate_DelegateCached = new FMoviePipelineFinished();
				OnMoviePipelineFinishedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMoviePipelineFinishedDelegate_Offset));
			}
			return OnMoviePipelineFinishedDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:OnMoviePipelineWorkFinishedDelegate")]
	public FMoviePipelineWorkFinished OnMoviePipelineWorkFinishedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnMoviePipelineWorkFinishedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:OnMoviePipelineWorkFinishedDelegate");
				return new FMoviePipelineWorkFinished();
			}
			if (OnMoviePipelineWorkFinishedDelegate_DelegateCached == null)
			{
				OnMoviePipelineWorkFinishedDelegate_DelegateCached = new FMoviePipelineWorkFinished();
				OnMoviePipelineWorkFinishedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMoviePipelineWorkFinishedDelegate_Offset));
			}
			return OnMoviePipelineWorkFinishedDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:OnMoviePipelineShotWorkFinishedDelegate")]
	public FMoviePipelineWorkFinished OnMoviePipelineShotWorkFinishedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnMoviePipelineShotWorkFinishedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:OnMoviePipelineShotWorkFinishedDelegate");
				return new FMoviePipelineWorkFinished();
			}
			if (OnMoviePipelineShotWorkFinishedDelegate_DelegateCached == null)
			{
				OnMoviePipelineShotWorkFinishedDelegate_DelegateCached = new FMoviePipelineWorkFinished();
				OnMoviePipelineShotWorkFinishedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMoviePipelineShotWorkFinishedDelegate_Offset));
			}
			return OnMoviePipelineShotWorkFinishedDelegate_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:Shutdown")]
	public unsafe void Shutdown(bool bError = false)
	{
		CheckDestroyed();
		if (!Shutdown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:Shutdown");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Shutdown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Shutdown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Shutdown_bError_Offset), 0, Shutdown_bError_PropertyAddress.Address, bError);
		NativeReflection.InvokeFunctionOptimized(base.Address, Shutdown_FunctionAddress, intPtr, Shutdown_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:SetInitializationTime")]
	public unsafe void SetInitializationTime(FDateTime InDateTime)
	{
		CheckDestroyed();
		if (!SetInitializationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:SetInitializationTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInitializationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInitializationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, SetInitializationTime_InDateTime_Offset), 0, SetInitializationTime_InDateTime_PropertyAddress.Address, InDateTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInitializationTime_FunctionAddress, intPtr, SetInitializationTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:RequestShutdown")]
	public unsafe void RequestShutdown(bool bIsError = false)
	{
		CheckDestroyed();
		if (!RequestShutdown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:RequestShutdown");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestShutdown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestShutdown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestShutdown_bIsError_Offset), 0, RequestShutdown_bIsError_PropertyAddress.Address, bIsError);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequestShutdown_FunctionAddress, intPtr, RequestShutdown_ParamsSize);
	}

	[UFunction(Flags = 67634176u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:OnMoviePipelineFinishedImpl")]
	protected unsafe void OnMoviePipelineFinishedImpl()
	{
		CheckDestroyed();
		if (!OnMoviePipelineFinishedImpl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:OnMoviePipelineFinishedImpl");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMoviePipelineFinishedImpl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMoviePipelineFinishedImpl_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnMoviePipelineFinishedImpl_FunctionAddress, argsSize: OnMoviePipelineFinishedImpl_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:IsShutdownRequested")]
	public unsafe bool IsShutdownRequested()
	{
		CheckDestroyed();
		if (!IsShutdownRequested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:IsShutdownRequested");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsShutdownRequested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsShutdownRequested_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsShutdownRequested_FunctionAddress, intPtr, IsShutdownRequested_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsShutdownRequested_ReturnValue_Offset), 0, IsShutdownRequested_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:Initialize")]
	public unsafe void Initialize(UMoviePipelineExecutorJob InJob)
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:Initialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(intPtr, Initialize_InJob_Offset), 0, Initialize_InJob_PropertyAddress.Address, InJob);
		NativeReflection.InvokeFunctionOptimized(base.Address, Initialize_FunctionAddress, intPtr, Initialize_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:GetPreviewTexture")]
	public unsafe UTexture GetPreviewTexture()
	{
		CheckDestroyed();
		if (!GetPreviewTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:GetPreviewTexture");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviewTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviewTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviewTexture_FunctionAddress, intPtr, GetPreviewTexture_ParamsSize);
		return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(intPtr, GetPreviewTexture_ReturnValue_Offset), 0, GetPreviewTexture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:GetPipelineMasterConfig")]
	public unsafe UMoviePipelineMasterConfig GetPipelineMasterConfig()
	{
		CheckDestroyed();
		if (!GetPipelineMasterConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:GetPipelineMasterConfig");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPipelineMasterConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPipelineMasterConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPipelineMasterConfig_FunctionAddress, intPtr, GetPipelineMasterConfig_ParamsSize);
		return UObjectMarshaler<UMoviePipelineMasterConfig>.FromNative(IntPtr.Add(intPtr, GetPipelineMasterConfig_ReturnValue_Offset), 0, GetPipelineMasterConfig_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:GetInitializationTime")]
	public unsafe FDateTime GetInitializationTime()
	{
		CheckDestroyed();
		if (!GetInitializationTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:GetInitializationTime");
			return default(FDateTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInitializationTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInitializationTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInitializationTime_FunctionAddress, intPtr, GetInitializationTime_ParamsSize);
		return FDateTime.FromNative(IntPtr.Add(intPtr, GetInitializationTime_ReturnValue_Offset), 0, GetInitializationTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipeline:GetCurrentJob")]
	public unsafe UMoviePipelineExecutorJob GetCurrentJob()
	{
		CheckDestroyed();
		if (!GetCurrentJob_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipeline:GetCurrentJob");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentJob_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentJob_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentJob_FunctionAddress, intPtr, GetCurrentJob_ParamsSize);
		return UObjectMarshaler<UMoviePipelineExecutorJob>.FromNative(IntPtr.Add(intPtr, GetCurrentJob_ReturnValue_Offset), 0, GetCurrentJob_ReturnValue_PropertyAddress.Address);
	}

	static UMoviePipeline()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipeline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipeline));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipeline");
		OnMoviePipelineFinishedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMoviePipelineFinishedDelegate");
		OnMoviePipelineFinishedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMoviePipelineFinishedDelegate", Classes.FMulticastDelegateProperty);
		OnMoviePipelineWorkFinishedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMoviePipelineWorkFinishedDelegate");
		OnMoviePipelineWorkFinishedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMoviePipelineWorkFinishedDelegate", Classes.FMulticastDelegateProperty);
		OnMoviePipelineShotWorkFinishedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMoviePipelineShotWorkFinishedDelegate");
		OnMoviePipelineShotWorkFinishedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMoviePipelineShotWorkFinishedDelegate", Classes.FMulticastDelegateProperty);
		Shutdown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Shutdown");
		Shutdown_ParamsSize = NativeReflection.GetFunctionParamsSize(Shutdown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Shutdown_bError_PropertyAddress, Shutdown_FunctionAddress, "bError");
		Shutdown_bError_Offset = NativeReflectionCached.GetPropertyOffset(Shutdown_FunctionAddress, "bError");
		Shutdown_bError_IsValid = NativeReflectionCached.ValidatePropertyClass(Shutdown_FunctionAddress, "bError", Classes.FBoolProperty);
		Shutdown_IsValid = Shutdown_FunctionAddress != IntPtr.Zero && Shutdown_bError_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:Shutdown", Shutdown_IsValid);
		SetInitializationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInitializationTime");
		SetInitializationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInitializationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInitializationTime_InDateTime_PropertyAddress, SetInitializationTime_FunctionAddress, "InDateTime");
		SetInitializationTime_InDateTime_Offset = NativeReflectionCached.GetPropertyOffset(SetInitializationTime_FunctionAddress, "InDateTime");
		SetInitializationTime_InDateTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitializationTime_FunctionAddress, "InDateTime", Classes.FStructProperty);
		SetInitializationTime_IsValid = SetInitializationTime_FunctionAddress != IntPtr.Zero && SetInitializationTime_InDateTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:SetInitializationTime", SetInitializationTime_IsValid);
		RequestShutdown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RequestShutdown");
		RequestShutdown_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestShutdown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestShutdown_bIsError_PropertyAddress, RequestShutdown_FunctionAddress, "bIsError");
		RequestShutdown_bIsError_Offset = NativeReflectionCached.GetPropertyOffset(RequestShutdown_FunctionAddress, "bIsError");
		RequestShutdown_bIsError_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestShutdown_FunctionAddress, "bIsError", Classes.FBoolProperty);
		RequestShutdown_IsValid = RequestShutdown_FunctionAddress != IntPtr.Zero && RequestShutdown_bIsError_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:RequestShutdown", RequestShutdown_IsValid);
		OnMoviePipelineFinishedImpl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMoviePipelineFinishedImpl");
		OnMoviePipelineFinishedImpl_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMoviePipelineFinishedImpl_FunctionAddress);
		OnMoviePipelineFinishedImpl_IsValid = OnMoviePipelineFinishedImpl_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:OnMoviePipelineFinishedImpl", OnMoviePipelineFinishedImpl_IsValid);
		IsShutdownRequested_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsShutdownRequested");
		IsShutdownRequested_ParamsSize = NativeReflection.GetFunctionParamsSize(IsShutdownRequested_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsShutdownRequested_ReturnValue_PropertyAddress, IsShutdownRequested_FunctionAddress, "ReturnValue");
		IsShutdownRequested_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsShutdownRequested_FunctionAddress, "ReturnValue");
		IsShutdownRequested_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsShutdownRequested_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsShutdownRequested_IsValid = IsShutdownRequested_FunctionAddress != IntPtr.Zero && IsShutdownRequested_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:IsShutdownRequested", IsShutdownRequested_IsValid);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InJob_PropertyAddress, Initialize_FunctionAddress, "InJob");
		Initialize_InJob_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InJob");
		Initialize_InJob_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InJob", Classes.FObjectProperty);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero && Initialize_InJob_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:Initialize", Initialize_IsValid);
		GetPreviewTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPreviewTexture");
		GetPreviewTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviewTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewTexture_ReturnValue_PropertyAddress, GetPreviewTexture_FunctionAddress, "ReturnValue");
		GetPreviewTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewTexture_FunctionAddress, "ReturnValue");
		GetPreviewTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewTexture_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPreviewTexture_IsValid = GetPreviewTexture_FunctionAddress != IntPtr.Zero && GetPreviewTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:GetPreviewTexture", GetPreviewTexture_IsValid);
		GetPipelineMasterConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPipelineMasterConfig");
		GetPipelineMasterConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPipelineMasterConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPipelineMasterConfig_ReturnValue_PropertyAddress, GetPipelineMasterConfig_FunctionAddress, "ReturnValue");
		GetPipelineMasterConfig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPipelineMasterConfig_FunctionAddress, "ReturnValue");
		GetPipelineMasterConfig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPipelineMasterConfig_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPipelineMasterConfig_IsValid = GetPipelineMasterConfig_FunctionAddress != IntPtr.Zero && GetPipelineMasterConfig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:GetPipelineMasterConfig", GetPipelineMasterConfig_IsValid);
		GetInitializationTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInitializationTime");
		GetInitializationTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInitializationTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInitializationTime_ReturnValue_PropertyAddress, GetInitializationTime_FunctionAddress, "ReturnValue");
		GetInitializationTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInitializationTime_FunctionAddress, "ReturnValue");
		GetInitializationTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInitializationTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInitializationTime_IsValid = GetInitializationTime_FunctionAddress != IntPtr.Zero && GetInitializationTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:GetInitializationTime", GetInitializationTime_IsValid);
		GetCurrentJob_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentJob");
		GetCurrentJob_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentJob_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentJob_ReturnValue_PropertyAddress, GetCurrentJob_FunctionAddress, "ReturnValue");
		GetCurrentJob_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentJob_FunctionAddress, "ReturnValue");
		GetCurrentJob_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentJob_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentJob_IsValid = GetCurrentJob_FunctionAddress != IntPtr.Zero && GetCurrentJob_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipeline:GetCurrentJob", GetCurrentJob_IsValid);
	}
}
