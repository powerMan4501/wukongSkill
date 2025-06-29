using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[Abstract]
[UClass(Flags = (ClassFlags)810550433uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol", "MovieSceneCapture", UnrealModuleType.Engine)]
public class UUserDefinedCaptureProtocol : UMovieSceneImageCaptureProtocolBase
{
	private static bool World_IsValid;

	private static int World_Offset;

	private static bool StopCapturingFinalPixels_IsValid;

	private static IntPtr StopCapturingFinalPixels_FunctionAddress;

	private static int StopCapturingFinalPixels_ParamsSize;

	private static bool StartCapturingFinalPixels_IsValid;

	private static IntPtr StartCapturingFinalPixels_FunctionAddress;

	private static int StartCapturingFinalPixels_ParamsSize;

	private static bool StartCapturingFinalPixels_StreamID_IsValid;

	private static FFieldAddress StartCapturingFinalPixels_StreamID_PropertyAddress;

	private static int StartCapturingFinalPixels_StreamID_Offset;

	private static bool ResolveBuffer_IsValid;

	private static IntPtr ResolveBuffer_FunctionAddress;

	private static int ResolveBuffer_ParamsSize;

	private static bool ResolveBuffer_Buffer_IsValid;

	private static FFieldAddress ResolveBuffer_Buffer_PropertyAddress;

	private static int ResolveBuffer_Buffer_Offset;

	private static bool ResolveBuffer_BufferID_IsValid;

	private static FFieldAddress ResolveBuffer_BufferID_PropertyAddress;

	private static int ResolveBuffer_BufferID_Offset;

	private static bool OnWarmUp_IsValid;

	private IntPtr OnWarmUp_InstanceFunctionAddress;

	private static IntPtr OnWarmUp_FunctionAddress;

	private static int OnWarmUp_ParamsSize;

	private static bool OnTick_IsValid;

	private IntPtr OnTick_InstanceFunctionAddress;

	private static IntPtr OnTick_FunctionAddress;

	private static int OnTick_ParamsSize;

	private static bool OnStartCapture_IsValid;

	private IntPtr OnStartCapture_InstanceFunctionAddress;

	private static IntPtr OnStartCapture_FunctionAddress;

	private static int OnStartCapture_ParamsSize;

	private static bool OnSetup_IsValid;

	private IntPtr OnSetup_InstanceFunctionAddress;

	private static IntPtr OnSetup_FunctionAddress;

	private static int OnSetup_ParamsSize;

	private static bool OnSetup_ReturnValue_IsValid;

	private static FFieldAddress OnSetup_ReturnValue_PropertyAddress;

	private static int OnSetup_ReturnValue_Offset;

	private static bool OnPreTick_IsValid;

	private IntPtr OnPreTick_InstanceFunctionAddress;

	private static IntPtr OnPreTick_FunctionAddress;

	private static int OnPreTick_ParamsSize;

	private static bool OnPixelsReceived_IsValid;

	private IntPtr OnPixelsReceived_InstanceFunctionAddress;

	private static IntPtr OnPixelsReceived_FunctionAddress;

	private static int OnPixelsReceived_ParamsSize;

	private static bool OnPixelsReceived_Pixels_IsValid;

	private static FFieldAddress OnPixelsReceived_Pixels_PropertyAddress;

	private static int OnPixelsReceived_Pixels_Offset;

	private static bool OnPixelsReceived_ID_IsValid;

	private static FFieldAddress OnPixelsReceived_ID_PropertyAddress;

	private static int OnPixelsReceived_ID_Offset;

	private static bool OnPixelsReceived_FrameMetrics_IsValid;

	private static FFieldAddress OnPixelsReceived_FrameMetrics_PropertyAddress;

	private static int OnPixelsReceived_FrameMetrics_Offset;

	private static bool OnPauseCapture_IsValid;

	private IntPtr OnPauseCapture_InstanceFunctionAddress;

	private static IntPtr OnPauseCapture_FunctionAddress;

	private static int OnPauseCapture_ParamsSize;

	private static bool OnFinalize_IsValid;

	private IntPtr OnFinalize_InstanceFunctionAddress;

	private static IntPtr OnFinalize_FunctionAddress;

	private static int OnFinalize_ParamsSize;

	private static bool OnCaptureFrame_IsValid;

	private IntPtr OnCaptureFrame_InstanceFunctionAddress;

	private static IntPtr OnCaptureFrame_FunctionAddress;

	private static int OnCaptureFrame_ParamsSize;

	private static bool OnCanFinalize_IsValid;

	private IntPtr OnCanFinalize_InstanceFunctionAddress;

	private static IntPtr OnCanFinalize_FunctionAddress;

	private static int OnCanFinalize_ParamsSize;

	private static bool OnCanFinalize_ReturnValue_IsValid;

	private static FFieldAddress OnCanFinalize_ReturnValue_PropertyAddress;

	private static int OnCanFinalize_ReturnValue_Offset;

	private static bool OnBeginFinalize_IsValid;

	private IntPtr OnBeginFinalize_InstanceFunctionAddress;

	private static IntPtr OnBeginFinalize_FunctionAddress;

	private static int OnBeginFinalize_ParamsSize;

	private static bool GetCurrentFrameMetrics_IsValid;

	private static IntPtr GetCurrentFrameMetrics_FunctionAddress;

	private static int GetCurrentFrameMetrics_ParamsSize;

	private static bool GetCurrentFrameMetrics_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentFrameMetrics_ReturnValue_PropertyAddress;

	private static int GetCurrentFrameMetrics_ReturnValue_Offset;

	private static bool GenerateFilename_IsValid;

	private static IntPtr GenerateFilename_FunctionAddress;

	private static int GenerateFilename_ParamsSize;

	private static bool GenerateFilename_InFrameMetrics_IsValid;

	private static FFieldAddress GenerateFilename_InFrameMetrics_PropertyAddress;

	private static int GenerateFilename_InFrameMetrics_Offset;

	private static bool GenerateFilename_ReturnValue_IsValid;

	private static FFieldAddress GenerateFilename_ReturnValue_PropertyAddress;

	private static int GenerateFilename_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)12393764861518356uL)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:World")]
	protected UWorld World
	{
		get
		{
			CheckDestroyed();
			if (!World_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:World");
				return null;
			}
			return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(base.Address, World_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!World_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:World");
			}
			else
			{
				UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(base.Address, World_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:StopCapturingFinalPixels")]
	public unsafe void StopCapturingFinalPixels()
	{
		CheckDestroyed();
		if (!StopCapturingFinalPixels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:StopCapturingFinalPixels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopCapturingFinalPixels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopCapturingFinalPixels_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopCapturingFinalPixels_FunctionAddress, argsSize: StopCapturingFinalPixels_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:StartCapturingFinalPixels")]
	public unsafe void StartCapturingFinalPixels(FCapturedPixelsID StreamID)
	{
		CheckDestroyed();
		if (!StartCapturingFinalPixels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:StartCapturingFinalPixels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartCapturingFinalPixels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartCapturingFinalPixels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(StartCapturingFinalPixels_StreamID_PropertyAddress.Address, intPtr);
		FCapturedPixelsID.ToNative(IntPtr.Add(intPtr, StartCapturingFinalPixels_StreamID_Offset), 0, StartCapturingFinalPixels_StreamID_PropertyAddress.Address, StreamID);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartCapturingFinalPixels_FunctionAddress, intPtr, StartCapturingFinalPixels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartCapturingFinalPixels_StreamID_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:ResolveBuffer")]
	public unsafe void ResolveBuffer(UTexture Buffer, FCapturedPixelsID BufferID)
	{
		CheckDestroyed();
		if (!ResolveBuffer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:ResolveBuffer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResolveBuffer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResolveBuffer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, ResolveBuffer_Buffer_Offset), 0, ResolveBuffer_Buffer_PropertyAddress.Address, Buffer);
		NativeReflection.InitializeValue_InContainer(ResolveBuffer_BufferID_PropertyAddress.Address, intPtr);
		FCapturedPixelsID.ToNative(IntPtr.Add(intPtr, ResolveBuffer_BufferID_Offset), 0, ResolveBuffer_BufferID_PropertyAddress.Address, BufferID);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResolveBuffer_FunctionAddress, intPtr, ResolveBuffer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResolveBuffer_BufferID_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnWarmUp")]
	protected unsafe void OnWarmUp()
	{
		CheckDestroyed();
		if (!OnWarmUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnWarmUp");
			return;
		}
		if (OnWarmUp_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWarmUp_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWarmUp");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWarmUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWarmUp_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnWarmUp_InstanceFunctionAddress, argsSize: OnWarmUp_ParamsSize);
	}

	protected unsafe virtual void OnWarmUp_Implementation()
	{
		CheckDestroyed();
		if (!OnWarmUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnWarmUp");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWarmUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWarmUp_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnWarmUp_FunctionAddress, argsSize: OnWarmUp_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnTick")]
	protected unsafe void OnTick()
	{
		CheckDestroyed();
		if (!OnTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnTick");
			return;
		}
		if (OnTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTick_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnTick_InstanceFunctionAddress, argsSize: OnTick_ParamsSize);
	}

	protected unsafe virtual void OnTick_Implementation()
	{
		CheckDestroyed();
		if (!OnTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTick_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnTick_FunctionAddress, argsSize: OnTick_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnStartCapture")]
	protected unsafe void OnStartCapture()
	{
		CheckDestroyed();
		if (!OnStartCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnStartCapture");
			return;
		}
		if (OnStartCapture_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnStartCapture_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnStartCapture");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStartCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStartCapture_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnStartCapture_InstanceFunctionAddress, argsSize: OnStartCapture_ParamsSize);
	}

	protected unsafe virtual void OnStartCapture_Implementation()
	{
		CheckDestroyed();
		if (!OnStartCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnStartCapture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStartCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStartCapture_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnStartCapture_FunctionAddress, argsSize: OnStartCapture_ParamsSize);
	}

	[UFunction(Flags = 134745088u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnSetup")]
	protected unsafe bool OnSetup()
	{
		CheckDestroyed();
		if (!OnSetup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnSetup");
			return false;
		}
		if (OnSetup_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSetup_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSetup");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetup_InstanceFunctionAddress, intPtr, OnSetup_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnSetup_ReturnValue_Offset), 0, OnSetup_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool OnSetup_Implementation()
	{
		CheckDestroyed();
		if (!OnSetup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnSetup");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSetup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnSetup_FunctionAddress, intPtr, OnSetup_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnSetup_ReturnValue_Offset), 0, OnSetup_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPreTick")]
	protected unsafe void OnPreTick()
	{
		CheckDestroyed();
		if (!OnPreTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPreTick");
			return;
		}
		if (OnPreTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreTick_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPreTick_InstanceFunctionAddress, argsSize: OnPreTick_ParamsSize);
	}

	protected unsafe virtual void OnPreTick_Implementation()
	{
		CheckDestroyed();
		if (!OnPreTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPreTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreTick_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPreTick_FunctionAddress, argsSize: OnPreTick_ParamsSize);
	}

	[UFunction(Flags = 138938368u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPixelsReceived")]
	protected unsafe void OnPixelsReceived(FCapturedPixels Pixels, FCapturedPixelsID ID, FFrameMetrics FrameMetrics)
	{
		CheckDestroyed();
		if (!OnPixelsReceived_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPixelsReceived");
			return;
		}
		if (OnPixelsReceived_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPixelsReceived_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPixelsReceived");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPixelsReceived_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPixelsReceived_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPixelsReceived_Pixels_PropertyAddress.Address, intPtr);
		FCapturedPixels.ToNative(IntPtr.Add(intPtr, OnPixelsReceived_Pixels_Offset), 0, OnPixelsReceived_Pixels_PropertyAddress.Address, Pixels);
		NativeReflection.InitializeValue_InContainer(OnPixelsReceived_ID_PropertyAddress.Address, intPtr);
		FCapturedPixelsID.ToNative(IntPtr.Add(intPtr, OnPixelsReceived_ID_Offset), 0, OnPixelsReceived_ID_PropertyAddress.Address, ID);
		NativeReflection.InitializeValue_InContainer(OnPixelsReceived_FrameMetrics_PropertyAddress.Address, intPtr);
		FFrameMetrics.ToNative(IntPtr.Add(intPtr, OnPixelsReceived_FrameMetrics_Offset), 0, OnPixelsReceived_FrameMetrics_PropertyAddress.Address, FrameMetrics);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPixelsReceived_InstanceFunctionAddress, intPtr, OnPixelsReceived_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPixelsReceived_Pixels_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPixelsReceived_ID_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnPixelsReceived_Implementation(FCapturedPixels Pixels, FCapturedPixelsID ID, FFrameMetrics FrameMetrics)
	{
		CheckDestroyed();
		if (!OnPixelsReceived_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPixelsReceived");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPixelsReceived_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPixelsReceived_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPixelsReceived_Pixels_PropertyAddress.Address, intPtr);
		FCapturedPixels.ToNative(IntPtr.Add(intPtr, OnPixelsReceived_Pixels_Offset), 0, OnPixelsReceived_Pixels_PropertyAddress.Address, Pixels);
		NativeReflection.InitializeValue_InContainer(OnPixelsReceived_ID_PropertyAddress.Address, intPtr);
		FCapturedPixelsID.ToNative(IntPtr.Add(intPtr, OnPixelsReceived_ID_Offset), 0, OnPixelsReceived_ID_PropertyAddress.Address, ID);
		NativeReflection.InitializeValue_InContainer(OnPixelsReceived_FrameMetrics_PropertyAddress.Address, intPtr);
		FFrameMetrics.ToNative(IntPtr.Add(intPtr, OnPixelsReceived_FrameMetrics_Offset), 0, OnPixelsReceived_FrameMetrics_PropertyAddress.Address, FrameMetrics);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPixelsReceived_FunctionAddress, intPtr, OnPixelsReceived_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPixelsReceived_Pixels_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPixelsReceived_ID_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPauseCapture")]
	protected unsafe void OnPauseCapture()
	{
		CheckDestroyed();
		if (!OnPauseCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPauseCapture");
			return;
		}
		if (OnPauseCapture_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPauseCapture_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPauseCapture");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPauseCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPauseCapture_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPauseCapture_InstanceFunctionAddress, argsSize: OnPauseCapture_ParamsSize);
	}

	protected unsafe virtual void OnPauseCapture_Implementation()
	{
		CheckDestroyed();
		if (!OnPauseCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPauseCapture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPauseCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPauseCapture_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPauseCapture_FunctionAddress, argsSize: OnPauseCapture_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnFinalize")]
	protected unsafe void OnFinalize()
	{
		CheckDestroyed();
		if (!OnFinalize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnFinalize");
			return;
		}
		if (OnFinalize_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnFinalize_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnFinalize");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFinalize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFinalize_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnFinalize_InstanceFunctionAddress, argsSize: OnFinalize_ParamsSize);
	}

	protected unsafe virtual void OnFinalize_Implementation()
	{
		CheckDestroyed();
		if (!OnFinalize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnFinalize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFinalize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFinalize_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnFinalize_FunctionAddress, argsSize: OnFinalize_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCaptureFrame")]
	protected unsafe void OnCaptureFrame()
	{
		CheckDestroyed();
		if (!OnCaptureFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCaptureFrame");
			return;
		}
		if (OnCaptureFrame_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnCaptureFrame_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnCaptureFrame");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCaptureFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCaptureFrame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnCaptureFrame_InstanceFunctionAddress, argsSize: OnCaptureFrame_ParamsSize);
	}

	protected unsafe virtual void OnCaptureFrame_Implementation()
	{
		CheckDestroyed();
		if (!OnCaptureFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCaptureFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCaptureFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCaptureFrame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnCaptureFrame_FunctionAddress, argsSize: OnCaptureFrame_ParamsSize);
	}

	[UFunction(Flags = 1208486912u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCanFinalize")]
	protected unsafe bool OnCanFinalize()
	{
		CheckDestroyed();
		if (!OnCanFinalize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCanFinalize");
			return false;
		}
		if (OnCanFinalize_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnCanFinalize_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnCanFinalize");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCanFinalize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCanFinalize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnCanFinalize_InstanceFunctionAddress, intPtr, OnCanFinalize_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnCanFinalize_ReturnValue_Offset), 0, OnCanFinalize_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool OnCanFinalize_Implementation()
	{
		CheckDestroyed();
		if (!OnCanFinalize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCanFinalize");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCanFinalize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCanFinalize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnCanFinalize_FunctionAddress, intPtr, OnCanFinalize_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnCanFinalize_ReturnValue_Offset), 0, OnCanFinalize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnBeginFinalize")]
	protected unsafe void OnBeginFinalize()
	{
		CheckDestroyed();
		if (!OnBeginFinalize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnBeginFinalize");
			return;
		}
		if (OnBeginFinalize_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnBeginFinalize_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnBeginFinalize");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBeginFinalize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBeginFinalize_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBeginFinalize_InstanceFunctionAddress, argsSize: OnBeginFinalize_ParamsSize);
	}

	protected unsafe virtual void OnBeginFinalize_Implementation()
	{
		CheckDestroyed();
		if (!OnBeginFinalize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnBeginFinalize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBeginFinalize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBeginFinalize_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBeginFinalize_FunctionAddress, argsSize: OnBeginFinalize_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:GetCurrentFrameMetrics")]
	public unsafe FFrameMetrics GetCurrentFrameMetrics()
	{
		CheckDestroyed();
		if (!GetCurrentFrameMetrics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:GetCurrentFrameMetrics");
			return default(FFrameMetrics);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentFrameMetrics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentFrameMetrics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentFrameMetrics_FunctionAddress, intPtr, GetCurrentFrameMetrics_ParamsSize);
		return FFrameMetrics.FromNative(IntPtr.Add(intPtr, GetCurrentFrameMetrics_ReturnValue_Offset), 0, GetCurrentFrameMetrics_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:GenerateFilename")]
	public unsafe string GenerateFilename(FFrameMetrics InFrameMetrics)
	{
		CheckDestroyed();
		if (!GenerateFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:GenerateFilename");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GenerateFilename_InFrameMetrics_PropertyAddress.Address, intPtr);
		FFrameMetrics.ToNative(IntPtr.Add(intPtr, GenerateFilename_InFrameMetrics_Offset), 0, GenerateFilename_InFrameMetrics_PropertyAddress.Address, InFrameMetrics);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateFilename_FunctionAddress, intPtr, GenerateFilename_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GenerateFilename_ReturnValue_Offset), 0, GenerateFilename_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GenerateFilename_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UUserDefinedCaptureProtocol()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UUserDefinedCaptureProtocol)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UUserDefinedCaptureProtocol));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieSceneCapture.UserDefinedCaptureProtocol");
		World_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "World");
		World_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "World", Classes.FObjectProperty);
		StopCapturingFinalPixels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopCapturingFinalPixels");
		StopCapturingFinalPixels_ParamsSize = NativeReflection.GetFunctionParamsSize(StopCapturingFinalPixels_FunctionAddress);
		StopCapturingFinalPixels_IsValid = StopCapturingFinalPixels_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:StopCapturingFinalPixels", StopCapturingFinalPixels_IsValid);
		StartCapturingFinalPixels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartCapturingFinalPixels");
		StartCapturingFinalPixels_ParamsSize = NativeReflection.GetFunctionParamsSize(StartCapturingFinalPixels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartCapturingFinalPixels_StreamID_PropertyAddress, StartCapturingFinalPixels_FunctionAddress, "StreamID");
		StartCapturingFinalPixels_StreamID_Offset = NativeReflectionCached.GetPropertyOffset(StartCapturingFinalPixels_FunctionAddress, "StreamID");
		StartCapturingFinalPixels_StreamID_IsValid = NativeReflectionCached.ValidatePropertyClass(StartCapturingFinalPixels_FunctionAddress, "StreamID", Classes.FStructProperty);
		StartCapturingFinalPixels_IsValid = StartCapturingFinalPixels_FunctionAddress != IntPtr.Zero && StartCapturingFinalPixels_StreamID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:StartCapturingFinalPixels", StartCapturingFinalPixels_IsValid);
		ResolveBuffer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResolveBuffer");
		ResolveBuffer_ParamsSize = NativeReflection.GetFunctionParamsSize(ResolveBuffer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResolveBuffer_Buffer_PropertyAddress, ResolveBuffer_FunctionAddress, "Buffer");
		ResolveBuffer_Buffer_Offset = NativeReflectionCached.GetPropertyOffset(ResolveBuffer_FunctionAddress, "Buffer");
		ResolveBuffer_Buffer_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveBuffer_FunctionAddress, "Buffer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveBuffer_BufferID_PropertyAddress, ResolveBuffer_FunctionAddress, "BufferID");
		ResolveBuffer_BufferID_Offset = NativeReflectionCached.GetPropertyOffset(ResolveBuffer_FunctionAddress, "BufferID");
		ResolveBuffer_BufferID_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveBuffer_FunctionAddress, "BufferID", Classes.FStructProperty);
		ResolveBuffer_IsValid = ResolveBuffer_FunctionAddress != IntPtr.Zero && ResolveBuffer_Buffer_IsValid && ResolveBuffer_BufferID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:ResolveBuffer", ResolveBuffer_IsValid);
		OnWarmUp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnWarmUp");
		OnWarmUp_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWarmUp_FunctionAddress);
		OnWarmUp_IsValid = OnWarmUp_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnWarmUp", OnWarmUp_IsValid);
		OnTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTick");
		OnTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTick_FunctionAddress);
		OnTick_IsValid = OnTick_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnTick", OnTick_IsValid);
		OnStartCapture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnStartCapture");
		OnStartCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStartCapture_FunctionAddress);
		OnStartCapture_IsValid = OnStartCapture_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnStartCapture", OnStartCapture_IsValid);
		OnSetup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSetup");
		OnSetup_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSetup_ReturnValue_PropertyAddress, OnSetup_FunctionAddress, "ReturnValue");
		OnSetup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnSetup_FunctionAddress, "ReturnValue");
		OnSetup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSetup_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OnSetup_IsValid = OnSetup_FunctionAddress != IntPtr.Zero && OnSetup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnSetup", OnSetup_IsValid);
		OnPreTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreTick");
		OnPreTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreTick_FunctionAddress);
		OnPreTick_IsValid = OnPreTick_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPreTick", OnPreTick_IsValid);
		OnPixelsReceived_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPixelsReceived");
		OnPixelsReceived_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPixelsReceived_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPixelsReceived_Pixels_PropertyAddress, OnPixelsReceived_FunctionAddress, "Pixels");
		OnPixelsReceived_Pixels_Offset = NativeReflectionCached.GetPropertyOffset(OnPixelsReceived_FunctionAddress, "Pixels");
		OnPixelsReceived_Pixels_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPixelsReceived_FunctionAddress, "Pixels", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPixelsReceived_ID_PropertyAddress, OnPixelsReceived_FunctionAddress, "ID");
		OnPixelsReceived_ID_Offset = NativeReflectionCached.GetPropertyOffset(OnPixelsReceived_FunctionAddress, "ID");
		OnPixelsReceived_ID_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPixelsReceived_FunctionAddress, "ID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPixelsReceived_FrameMetrics_PropertyAddress, OnPixelsReceived_FunctionAddress, "FrameMetrics");
		OnPixelsReceived_FrameMetrics_Offset = NativeReflectionCached.GetPropertyOffset(OnPixelsReceived_FunctionAddress, "FrameMetrics");
		OnPixelsReceived_FrameMetrics_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPixelsReceived_FunctionAddress, "FrameMetrics", Classes.FStructProperty);
		OnPixelsReceived_IsValid = OnPixelsReceived_FunctionAddress != IntPtr.Zero && OnPixelsReceived_Pixels_IsValid && OnPixelsReceived_ID_IsValid && OnPixelsReceived_FrameMetrics_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPixelsReceived", OnPixelsReceived_IsValid);
		OnPauseCapture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPauseCapture");
		OnPauseCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPauseCapture_FunctionAddress);
		OnPauseCapture_IsValid = OnPauseCapture_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnPauseCapture", OnPauseCapture_IsValid);
		OnFinalize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnFinalize");
		OnFinalize_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFinalize_FunctionAddress);
		OnFinalize_IsValid = OnFinalize_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnFinalize", OnFinalize_IsValid);
		OnCaptureFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCaptureFrame");
		OnCaptureFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCaptureFrame_FunctionAddress);
		OnCaptureFrame_IsValid = OnCaptureFrame_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCaptureFrame", OnCaptureFrame_IsValid);
		OnCanFinalize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCanFinalize");
		OnCanFinalize_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCanFinalize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnCanFinalize_ReturnValue_PropertyAddress, OnCanFinalize_FunctionAddress, "ReturnValue");
		OnCanFinalize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnCanFinalize_FunctionAddress, "ReturnValue");
		OnCanFinalize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnCanFinalize_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OnCanFinalize_IsValid = OnCanFinalize_FunctionAddress != IntPtr.Zero && OnCanFinalize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnCanFinalize", OnCanFinalize_IsValid);
		OnBeginFinalize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnBeginFinalize");
		OnBeginFinalize_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBeginFinalize_FunctionAddress);
		OnBeginFinalize_IsValid = OnBeginFinalize_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:OnBeginFinalize", OnBeginFinalize_IsValid);
		GetCurrentFrameMetrics_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentFrameMetrics");
		GetCurrentFrameMetrics_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentFrameMetrics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFrameMetrics_ReturnValue_PropertyAddress, GetCurrentFrameMetrics_FunctionAddress, "ReturnValue");
		GetCurrentFrameMetrics_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFrameMetrics_FunctionAddress, "ReturnValue");
		GetCurrentFrameMetrics_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFrameMetrics_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentFrameMetrics_IsValid = GetCurrentFrameMetrics_FunctionAddress != IntPtr.Zero && GetCurrentFrameMetrics_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:GetCurrentFrameMetrics", GetCurrentFrameMetrics_IsValid);
		GenerateFilename_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateFilename");
		GenerateFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateFilename_InFrameMetrics_PropertyAddress, GenerateFilename_FunctionAddress, "InFrameMetrics");
		GenerateFilename_InFrameMetrics_Offset = NativeReflectionCached.GetPropertyOffset(GenerateFilename_FunctionAddress, "InFrameMetrics");
		GenerateFilename_InFrameMetrics_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateFilename_FunctionAddress, "InFrameMetrics", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateFilename_ReturnValue_PropertyAddress, GenerateFilename_FunctionAddress, "ReturnValue");
		GenerateFilename_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateFilename_FunctionAddress, "ReturnValue");
		GenerateFilename_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateFilename_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GenerateFilename_IsValid = GenerateFilename_FunctionAddress != IntPtr.Zero && GenerateFilename_InFrameMetrics_IsValid && GenerateFilename_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneCapture.UserDefinedCaptureProtocol:GenerateFilename", GenerateFilename_IsValid);
	}
}
