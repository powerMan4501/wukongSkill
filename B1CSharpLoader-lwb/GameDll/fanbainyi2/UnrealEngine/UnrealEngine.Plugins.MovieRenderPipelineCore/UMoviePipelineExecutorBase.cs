using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[Abstract]
[UClass(Flags = (ClassFlags)818938017uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineExecutorBase : UObject
{
	private static bool SocketMessageRecievedDelegate_IsValid;

	private static int SocketMessageRecievedDelegate_Offset;

	private FMoviePipelineSocketMessageRecieved SocketMessageRecievedDelegate_DelegateCached;

	private static bool HTTPResponseRecievedDelegate_IsValid;

	private static int HTTPResponseRecievedDelegate_Offset;

	private FMoviePipelineHttpResponseRecieved HTTPResponseRecievedDelegate_DelegateCached;

	private static bool DebugWidgetClass_IsValid;

	private static int DebugWidgetClass_Offset;

	private static bool UserData_IsValid;

	private static int UserData_Offset;

	private static bool TargetPipelineClass_IsValid;

	private static int TargetPipelineClass_Offset;

	private static bool SetStatusProgress_IsValid;

	private IntPtr SetStatusProgress_InstanceFunctionAddress;

	private static IntPtr SetStatusProgress_FunctionAddress;

	private static int SetStatusProgress_ParamsSize;

	private static bool SetStatusProgress_InProgress_IsValid;

	private static FFieldAddress SetStatusProgress_InProgress_PropertyAddress;

	private static int SetStatusProgress_InProgress_Offset;

	private static bool SetStatusMessage_IsValid;

	private IntPtr SetStatusMessage_InstanceFunctionAddress;

	private static IntPtr SetStatusMessage_FunctionAddress;

	private static int SetStatusMessage_ParamsSize;

	private static bool SetStatusMessage_InStatus_IsValid;

	private static FFieldAddress SetStatusMessage_InStatus_PropertyAddress;

	private static int SetStatusMessage_InStatus_Offset;

	private static bool SetMoviePipelineClass_IsValid;

	private static IntPtr SetMoviePipelineClass_FunctionAddress;

	private static int SetMoviePipelineClass_ParamsSize;

	private static bool SetMoviePipelineClass_InPipelineClass_IsValid;

	private static FFieldAddress SetMoviePipelineClass_InPipelineClass_PropertyAddress;

	private static int SetMoviePipelineClass_InPipelineClass_Offset;

	private static bool SendSocketMessage_IsValid;

	private static IntPtr SendSocketMessage_FunctionAddress;

	private static int SendSocketMessage_ParamsSize;

	private static bool SendSocketMessage_InMessage_IsValid;

	private static FFieldAddress SendSocketMessage_InMessage_PropertyAddress;

	private static int SendSocketMessage_InMessage_Offset;

	private static bool SendSocketMessage_ReturnValue_IsValid;

	private static FFieldAddress SendSocketMessage_ReturnValue_PropertyAddress;

	private static int SendSocketMessage_ReturnValue_Offset;

	private static bool SendHTTPRequest_IsValid;

	private static IntPtr SendHTTPRequest_FunctionAddress;

	private static int SendHTTPRequest_ParamsSize;

	private static bool SendHTTPRequest_InURL_IsValid;

	private static FFieldAddress SendHTTPRequest_InURL_PropertyAddress;

	private static int SendHTTPRequest_InURL_Offset;

	private static bool SendHTTPRequest_InVerb_IsValid;

	private static FFieldAddress SendHTTPRequest_InVerb_PropertyAddress;

	private static int SendHTTPRequest_InVerb_Offset;

	private static bool SendHTTPRequest_InMessage_IsValid;

	private static FFieldAddress SendHTTPRequest_InMessage_PropertyAddress;

	private static int SendHTTPRequest_InMessage_Offset;

	private static bool SendHTTPRequest_InHeaders_IsValid;

	private static FFieldAddress SendHTTPRequest_InHeaders_PropertyAddress;

	private static int SendHTTPRequest_InHeaders_Offset;

	private static bool SendHTTPRequest_ReturnValue_IsValid;

	private static FFieldAddress SendHTTPRequest_ReturnValue_PropertyAddress;

	private static int SendHTTPRequest_ReturnValue_Offset;

	private static bool OnExecutorFinishedImpl_IsValid;

	private static IntPtr OnExecutorFinishedImpl_FunctionAddress;

	private static int OnExecutorFinishedImpl_ParamsSize;

	private static bool OnExecutorErroredImpl_IsValid;

	private static IntPtr OnExecutorErroredImpl_FunctionAddress;

	private static int OnExecutorErroredImpl_ParamsSize;

	private static bool OnExecutorErroredImpl_ErroredPipeline_IsValid;

	private static FFieldAddress OnExecutorErroredImpl_ErroredPipeline_PropertyAddress;

	private static int OnExecutorErroredImpl_ErroredPipeline_Offset;

	private static bool OnExecutorErroredImpl_bFatal_IsValid;

	private static FFieldAddress OnExecutorErroredImpl_bFatal_PropertyAddress;

	private static int OnExecutorErroredImpl_bFatal_Offset;

	private static bool OnExecutorErroredImpl_ErrorReason_IsValid;

	private static FFieldAddress OnExecutorErroredImpl_ErrorReason_PropertyAddress;

	private static int OnExecutorErroredImpl_ErrorReason_Offset;

	private static bool OnBeginFrame_IsValid;

	private IntPtr OnBeginFrame_InstanceFunctionAddress;

	private static IntPtr OnBeginFrame_FunctionAddress;

	private static int OnBeginFrame_ParamsSize;

	private static bool IsSocketConnected_IsValid;

	private static IntPtr IsSocketConnected_FunctionAddress;

	private static int IsSocketConnected_ParamsSize;

	private static bool IsSocketConnected_ReturnValue_IsValid;

	private static FFieldAddress IsSocketConnected_ReturnValue_PropertyAddress;

	private static int IsSocketConnected_ReturnValue_Offset;

	private static bool IsRendering_IsValid;

	private IntPtr IsRendering_InstanceFunctionAddress;

	private static IntPtr IsRendering_FunctionAddress;

	private static int IsRendering_ParamsSize;

	private static bool IsRendering_ReturnValue_IsValid;

	private static FFieldAddress IsRendering_ReturnValue_PropertyAddress;

	private static int IsRendering_ReturnValue_Offset;

	private static bool GetStatusProgress_IsValid;

	private IntPtr GetStatusProgress_InstanceFunctionAddress;

	private static IntPtr GetStatusProgress_FunctionAddress;

	private static int GetStatusProgress_ParamsSize;

	private static bool GetStatusProgress_ReturnValue_IsValid;

	private static FFieldAddress GetStatusProgress_ReturnValue_PropertyAddress;

	private static int GetStatusProgress_ReturnValue_Offset;

	private static bool GetStatusMessage_IsValid;

	private IntPtr GetStatusMessage_InstanceFunctionAddress;

	private static IntPtr GetStatusMessage_FunctionAddress;

	private static int GetStatusMessage_ParamsSize;

	private static bool GetStatusMessage_ReturnValue_IsValid;

	private static FFieldAddress GetStatusMessage_ReturnValue_PropertyAddress;

	private static int GetStatusMessage_ReturnValue_Offset;

	private static bool Execute_IsValid;

	private IntPtr Execute_InstanceFunctionAddress;

	private static IntPtr Execute_FunctionAddress;

	private static int Execute_ParamsSize;

	private static bool Execute_InPipelineQueue_IsValid;

	private static FFieldAddress Execute_InPipelineQueue_PropertyAddress;

	private static int Execute_InPipelineQueue_Offset;

	private static bool DisconnectSocket_IsValid;

	private static IntPtr DisconnectSocket_FunctionAddress;

	private static int DisconnectSocket_ParamsSize;

	private static bool ConnectSocket_IsValid;

	private static IntPtr ConnectSocket_FunctionAddress;

	private static int ConnectSocket_ParamsSize;

	private static bool ConnectSocket_InHostName_IsValid;

	private static FFieldAddress ConnectSocket_InHostName_PropertyAddress;

	private static int ConnectSocket_InHostName_Offset;

	private static bool ConnectSocket_InPort_IsValid;

	private static FFieldAddress ConnectSocket_InPort_PropertyAddress;

	private static int ConnectSocket_InPort_Offset;

	private static bool ConnectSocket_ReturnValue_IsValid;

	private static FFieldAddress ConnectSocket_ReturnValue_PropertyAddress;

	private static int ConnectSocket_ReturnValue_Offset;

	private static bool CancelCurrentJob_IsValid;

	private IntPtr CancelCurrentJob_InstanceFunctionAddress;

	private static IntPtr CancelCurrentJob_FunctionAddress;

	private static int CancelCurrentJob_ParamsSize;

	private static bool CancelAllJobs_IsValid;

	private IntPtr CancelAllJobs_InstanceFunctionAddress;

	private static IntPtr CancelAllJobs_FunctionAddress;

	private static int CancelAllJobs_ParamsSize;

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SocketMessageRecievedDelegate")]
	protected FMoviePipelineSocketMessageRecieved SocketMessageRecievedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!SocketMessageRecievedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SocketMessageRecievedDelegate");
				return new FMoviePipelineSocketMessageRecieved();
			}
			if (SocketMessageRecievedDelegate_DelegateCached == null)
			{
				SocketMessageRecievedDelegate_DelegateCached = new FMoviePipelineSocketMessageRecieved();
				SocketMessageRecievedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, SocketMessageRecievedDelegate_Offset));
			}
			return SocketMessageRecievedDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:HTTPResponseRecievedDelegate")]
	protected FMoviePipelineHttpResponseRecieved HTTPResponseRecievedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!HTTPResponseRecievedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:HTTPResponseRecievedDelegate");
				return new FMoviePipelineHttpResponseRecieved();
			}
			if (HTTPResponseRecievedDelegate_DelegateCached == null)
			{
				HTTPResponseRecievedDelegate_DelegateCached = new FMoviePipelineHttpResponseRecieved();
				HTTPResponseRecievedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, HTTPResponseRecievedDelegate_Offset));
			}
			return HTTPResponseRecievedDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:DebugWidgetClass")]
	public TSubclassOf<UMovieRenderDebugWidget> DebugWidgetClass
	{
		get
		{
			CheckDestroyed();
			if (!DebugWidgetClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:DebugWidgetClass");
				return default(TSubclassOf<UMovieRenderDebugWidget>);
			}
			return TSubclassOfMarshaler<UMovieRenderDebugWidget>.FromNative(IntPtr.Add(base.Address, DebugWidgetClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugWidgetClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:DebugWidgetClass");
			}
			else
			{
				TSubclassOfMarshaler<UMovieRenderDebugWidget>.ToNative(IntPtr.Add(base.Address, DebugWidgetClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:UserData")]
	public string UserData
	{
		get
		{
			CheckDestroyed();
			if (!UserData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:UserData");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, UserData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UserData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:UserData");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, UserData_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510148uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:TargetPipelineClass")]
	protected TSubclassOf<UMoviePipeline> TargetPipelineClass
	{
		get
		{
			CheckDestroyed();
			if (!TargetPipelineClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:TargetPipelineClass");
				return default(TSubclassOf<UMoviePipeline>);
			}
			return TSubclassOfMarshaler<UMoviePipeline>.FromNative(IntPtr.Add(base.Address, TargetPipelineClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPipelineClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:TargetPipelineClass");
			}
			else
			{
				TSubclassOfMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(base.Address, TargetPipelineClass_Offset), value);
			}
		}
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetStatusProgress")]
	public unsafe void SetStatusProgress(float InProgress)
	{
		CheckDestroyed();
		if (!SetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetStatusProgress");
			return;
		}
		if (SetStatusProgress_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetStatusProgress_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetStatusProgress");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStatusProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStatusProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStatusProgress_InProgress_Offset), 0, SetStatusProgress_InProgress_PropertyAddress.Address, InProgress);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStatusProgress_InstanceFunctionAddress, intPtr, SetStatusProgress_ParamsSize);
	}

	protected unsafe virtual void SetStatusProgress_Implementation(float InProgress)
	{
		CheckDestroyed();
		if (!SetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetStatusProgress");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStatusProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStatusProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStatusProgress_InProgress_Offset), 0, SetStatusProgress_InProgress_PropertyAddress.Address, InProgress);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStatusProgress_FunctionAddress, intPtr, SetStatusProgress_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetStatusMessage")]
	public unsafe void SetStatusMessage(string InStatus)
	{
		CheckDestroyed();
		if (!SetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetStatusMessage");
			return;
		}
		if (SetStatusMessage_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetStatusMessage_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetStatusMessage");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStatusMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStatusMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStatusMessage_InStatus_Offset), 0, SetStatusMessage_InStatus_PropertyAddress.Address, InStatus);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStatusMessage_InstanceFunctionAddress, intPtr, SetStatusMessage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStatusMessage_InStatus_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void SetStatusMessage_Implementation(string InStatus)
	{
		CheckDestroyed();
		if (!SetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetStatusMessage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStatusMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStatusMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStatusMessage_InStatus_Offset), 0, SetStatusMessage_InStatus_PropertyAddress.Address, InStatus);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStatusMessage_FunctionAddress, intPtr, SetStatusMessage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStatusMessage_InStatus_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetMoviePipelineClass")]
	public unsafe void SetMoviePipelineClass(TSubclassOf<UObject> InPipelineClass)
	{
		CheckDestroyed();
		if (!SetMoviePipelineClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetMoviePipelineClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMoviePipelineClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMoviePipelineClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetMoviePipelineClass_InPipelineClass_Offset), 0, SetMoviePipelineClass_InPipelineClass_PropertyAddress.Address, InPipelineClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMoviePipelineClass_FunctionAddress, intPtr, SetMoviePipelineClass_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SendSocketMessage")]
	protected unsafe bool SendSocketMessage(string InMessage)
	{
		CheckDestroyed();
		if (!SendSocketMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SendSocketMessage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SendSocketMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SendSocketMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SendSocketMessage_InMessage_Offset), 0, SendSocketMessage_InMessage_PropertyAddress.Address, InMessage);
		NativeReflection.InvokeFunctionOptimized(base.Address, SendSocketMessage_FunctionAddress, intPtr, SendSocketMessage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SendSocketMessage_InMessage_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SendSocketMessage_ReturnValue_Offset), 0, SendSocketMessage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SendHTTPRequest")]
	protected unsafe int SendHTTPRequest(string InURL, string InVerb, string InMessage, Dictionary<string, string> InHeaders)
	{
		CheckDestroyed();
		if (!SendHTTPRequest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SendHTTPRequest");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SendHTTPRequest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SendHTTPRequest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SendHTTPRequest_InURL_Offset), 0, SendHTTPRequest_InURL_PropertyAddress.Address, InURL);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SendHTTPRequest_InVerb_Offset), 0, SendHTTPRequest_InVerb_PropertyAddress.Address, InVerb);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SendHTTPRequest_InMessage_Offset), 0, SendHTTPRequest_InMessage_PropertyAddress.Address, InMessage);
		NativeReflection.InitializeValue_InContainer(SendHTTPRequest_InHeaders_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, SendHTTPRequest_InHeaders_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SendHTTPRequest_InHeaders_Offset), InHeaders);
		NativeReflection.InvokeFunctionOptimized(base.Address, SendHTTPRequest_FunctionAddress, intPtr, SendHTTPRequest_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SendHTTPRequest_InURL_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SendHTTPRequest_InVerb_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SendHTTPRequest_InMessage_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SendHTTPRequest_InHeaders_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SendHTTPRequest_ReturnValue_Offset), 0, SendHTTPRequest_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67634176u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnExecutorFinishedImpl")]
	protected unsafe void OnExecutorFinishedImpl()
	{
		CheckDestroyed();
		if (!OnExecutorFinishedImpl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnExecutorFinishedImpl");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExecutorFinishedImpl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExecutorFinishedImpl_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnExecutorFinishedImpl_FunctionAddress, argsSize: OnExecutorFinishedImpl_ParamsSize);
	}

	[UFunction(Flags = 67634176u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnExecutorErroredImpl")]
	protected unsafe void OnExecutorErroredImpl(UMoviePipeline ErroredPipeline, bool bFatal, FText ErrorReason)
	{
		CheckDestroyed();
		if (!OnExecutorErroredImpl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnExecutorErroredImpl");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExecutorErroredImpl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExecutorErroredImpl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, OnExecutorErroredImpl_ErroredPipeline_Offset), 0, OnExecutorErroredImpl_ErroredPipeline_PropertyAddress.Address, ErroredPipeline);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnExecutorErroredImpl_bFatal_Offset), 0, OnExecutorErroredImpl_bFatal_PropertyAddress.Address, bFatal);
		NativeReflection.InitializeValue_InContainer(OnExecutorErroredImpl_ErrorReason_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnExecutorErroredImpl_ErrorReason_Offset), 0, OnExecutorErroredImpl_ErrorReason_PropertyAddress.Address, ErrorReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnExecutorErroredImpl_FunctionAddress, intPtr, OnExecutorErroredImpl_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnExecutorErroredImpl_ErrorReason_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnBeginFrame")]
	public unsafe void OnBeginFrame()
	{
		CheckDestroyed();
		if (!OnBeginFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnBeginFrame");
			return;
		}
		if (OnBeginFrame_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnBeginFrame_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnBeginFrame");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBeginFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBeginFrame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBeginFrame_InstanceFunctionAddress, argsSize: OnBeginFrame_ParamsSize);
	}

	protected unsafe virtual void OnBeginFrame_Implementation()
	{
		CheckDestroyed();
		if (!OnBeginFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnBeginFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnBeginFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBeginFrame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnBeginFrame_FunctionAddress, argsSize: OnBeginFrame_ParamsSize);
	}

	[UFunction(Flags = 1409811457u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:IsSocketConnected")]
	protected unsafe bool IsSocketConnected()
	{
		CheckDestroyed();
		if (!IsSocketConnected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:IsSocketConnected");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSocketConnected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSocketConnected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSocketConnected_FunctionAddress, intPtr, IsSocketConnected_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSocketConnected_ReturnValue_Offset), 0, IsSocketConnected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1543638016u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:IsRendering")]
	public unsafe bool IsRendering()
	{
		CheckDestroyed();
		if (!IsRendering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:IsRendering");
			return false;
		}
		if (IsRendering_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsRendering_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsRendering");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRendering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRendering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRendering_InstanceFunctionAddress, intPtr, IsRendering_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRendering_ReturnValue_Offset), 0, IsRendering_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsRendering_Implementation()
	{
		CheckDestroyed();
		if (!IsRendering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:IsRendering");
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

	[UFunction(Flags = 1543638016u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:GetStatusProgress")]
	public unsafe float GetStatusProgress()
	{
		CheckDestroyed();
		if (!GetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:GetStatusProgress");
			return 0f;
		}
		if (GetStatusProgress_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetStatusProgress_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetStatusProgress");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusProgress_InstanceFunctionAddress, intPtr, GetStatusProgress_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStatusProgress_ReturnValue_Offset), 0, GetStatusProgress_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual float GetStatusProgress_Implementation()
	{
		CheckDestroyed();
		if (!GetStatusProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:GetStatusProgress");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusProgress_FunctionAddress, intPtr, GetStatusProgress_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStatusProgress_ReturnValue_Offset), 0, GetStatusProgress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1543638016u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:GetStatusMessage")]
	public unsafe string GetStatusMessage()
	{
		CheckDestroyed();
		if (!GetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:GetStatusMessage");
			return FStringMarshaler.DefaultString;
		}
		if (GetStatusMessage_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetStatusMessage_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetStatusMessage");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusMessage_InstanceFunctionAddress, intPtr, GetStatusMessage_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStatusMessage_ReturnValue_Offset), 0, GetStatusMessage_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStatusMessage_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetStatusMessage_Implementation()
	{
		CheckDestroyed();
		if (!GetStatusMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:GetStatusMessage");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusMessage_FunctionAddress, intPtr, GetStatusMessage_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStatusMessage_ReturnValue_Offset), 0, GetStatusMessage_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStatusMessage_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:Execute")]
	public unsafe void Execute(UMoviePipelineQueue InPipelineQueue)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:Execute");
			return;
		}
		if (Execute_InstanceFunctionAddress == IntPtr.Zero)
		{
			Execute_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Execute");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineQueue>.ToNative(IntPtr.Add(intPtr, Execute_InPipelineQueue_Offset), 0, Execute_InPipelineQueue_PropertyAddress.Address, InPipelineQueue);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_InstanceFunctionAddress, intPtr, Execute_ParamsSize);
	}

	protected unsafe virtual void Execute_Implementation(UMoviePipelineQueue InPipelineQueue)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:Execute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineQueue>.ToNative(IntPtr.Add(intPtr, Execute_InPipelineQueue_Offset), 0, Execute_InPipelineQueue_PropertyAddress.Address, InPipelineQueue);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_FunctionAddress, intPtr, Execute_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:DisconnectSocket")]
	protected unsafe void DisconnectSocket()
	{
		CheckDestroyed();
		if (!DisconnectSocket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:DisconnectSocket");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisconnectSocket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisconnectSocket_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DisconnectSocket_FunctionAddress, argsSize: DisconnectSocket_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:ConnectSocket")]
	protected unsafe bool ConnectSocket(string InHostName, int InPort)
	{
		CheckDestroyed();
		if (!ConnectSocket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:ConnectSocket");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConnectSocket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConnectSocket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConnectSocket_InHostName_Offset), 0, ConnectSocket_InHostName_PropertyAddress.Address, InHostName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConnectSocket_InPort_Offset), 0, ConnectSocket_InPort_PropertyAddress.Address, InPort);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConnectSocket_FunctionAddress, intPtr, ConnectSocket_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConnectSocket_InHostName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConnectSocket_ReturnValue_Offset), 0, ConnectSocket_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:CancelCurrentJob")]
	public unsafe void CancelCurrentJob()
	{
		CheckDestroyed();
		if (!CancelCurrentJob_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:CancelCurrentJob");
			return;
		}
		if (CancelCurrentJob_InstanceFunctionAddress == IntPtr.Zero)
		{
			CancelCurrentJob_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CancelCurrentJob");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelCurrentJob_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelCurrentJob_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CancelCurrentJob_InstanceFunctionAddress, argsSize: CancelCurrentJob_ParamsSize);
	}

	protected unsafe virtual void CancelCurrentJob_Implementation()
	{
		CheckDestroyed();
		if (!CancelCurrentJob_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:CancelCurrentJob");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelCurrentJob_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelCurrentJob_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CancelCurrentJob_FunctionAddress, argsSize: CancelCurrentJob_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:CancelAllJobs")]
	public unsafe void CancelAllJobs()
	{
		CheckDestroyed();
		if (!CancelAllJobs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:CancelAllJobs");
			return;
		}
		if (CancelAllJobs_InstanceFunctionAddress == IntPtr.Zero)
		{
			CancelAllJobs_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CancelAllJobs");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelAllJobs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelAllJobs_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CancelAllJobs_InstanceFunctionAddress, argsSize: CancelAllJobs_ParamsSize);
	}

	protected unsafe virtual void CancelAllJobs_Implementation()
	{
		CheckDestroyed();
		if (!CancelAllJobs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:CancelAllJobs");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelAllJobs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelAllJobs_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CancelAllJobs_FunctionAddress, argsSize: CancelAllJobs_ParamsSize);
	}

	static UMoviePipelineExecutorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineExecutorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineExecutorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase");
		SocketMessageRecievedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketMessageRecievedDelegate");
		SocketMessageRecievedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketMessageRecievedDelegate", Classes.FMulticastDelegateProperty);
		HTTPResponseRecievedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HTTPResponseRecievedDelegate");
		HTTPResponseRecievedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HTTPResponseRecievedDelegate", Classes.FMulticastDelegateProperty);
		DebugWidgetClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugWidgetClass");
		DebugWidgetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugWidgetClass", Classes.FClassProperty);
		UserData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserData");
		UserData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserData", Classes.FStrProperty);
		TargetPipelineClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetPipelineClass");
		TargetPipelineClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetPipelineClass", Classes.FClassProperty);
		SetStatusProgress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStatusProgress");
		SetStatusProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStatusProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStatusProgress_InProgress_PropertyAddress, SetStatusProgress_FunctionAddress, "InProgress");
		SetStatusProgress_InProgress_Offset = NativeReflectionCached.GetPropertyOffset(SetStatusProgress_FunctionAddress, "InProgress");
		SetStatusProgress_InProgress_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStatusProgress_FunctionAddress, "InProgress", Classes.FFloatProperty);
		SetStatusProgress_IsValid = SetStatusProgress_FunctionAddress != IntPtr.Zero && SetStatusProgress_InProgress_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetStatusProgress", SetStatusProgress_IsValid);
		SetStatusMessage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStatusMessage");
		SetStatusMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStatusMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStatusMessage_InStatus_PropertyAddress, SetStatusMessage_FunctionAddress, "InStatus");
		SetStatusMessage_InStatus_Offset = NativeReflectionCached.GetPropertyOffset(SetStatusMessage_FunctionAddress, "InStatus");
		SetStatusMessage_InStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStatusMessage_FunctionAddress, "InStatus", Classes.FStrProperty);
		SetStatusMessage_IsValid = SetStatusMessage_FunctionAddress != IntPtr.Zero && SetStatusMessage_InStatus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetStatusMessage", SetStatusMessage_IsValid);
		SetMoviePipelineClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMoviePipelineClass");
		SetMoviePipelineClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMoviePipelineClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMoviePipelineClass_InPipelineClass_PropertyAddress, SetMoviePipelineClass_FunctionAddress, "InPipelineClass");
		SetMoviePipelineClass_InPipelineClass_Offset = NativeReflectionCached.GetPropertyOffset(SetMoviePipelineClass_FunctionAddress, "InPipelineClass");
		SetMoviePipelineClass_InPipelineClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMoviePipelineClass_FunctionAddress, "InPipelineClass", Classes.FClassProperty);
		SetMoviePipelineClass_IsValid = SetMoviePipelineClass_FunctionAddress != IntPtr.Zero && SetMoviePipelineClass_InPipelineClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SetMoviePipelineClass", SetMoviePipelineClass_IsValid);
		SendSocketMessage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SendSocketMessage");
		SendSocketMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(SendSocketMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SendSocketMessage_InMessage_PropertyAddress, SendSocketMessage_FunctionAddress, "InMessage");
		SendSocketMessage_InMessage_Offset = NativeReflectionCached.GetPropertyOffset(SendSocketMessage_FunctionAddress, "InMessage");
		SendSocketMessage_InMessage_IsValid = NativeReflectionCached.ValidatePropertyClass(SendSocketMessage_FunctionAddress, "InMessage", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SendSocketMessage_ReturnValue_PropertyAddress, SendSocketMessage_FunctionAddress, "ReturnValue");
		SendSocketMessage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SendSocketMessage_FunctionAddress, "ReturnValue");
		SendSocketMessage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SendSocketMessage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SendSocketMessage_IsValid = SendSocketMessage_FunctionAddress != IntPtr.Zero && SendSocketMessage_InMessage_IsValid && SendSocketMessage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SendSocketMessage", SendSocketMessage_IsValid);
		SendHTTPRequest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SendHTTPRequest");
		SendHTTPRequest_ParamsSize = NativeReflection.GetFunctionParamsSize(SendHTTPRequest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SendHTTPRequest_InURL_PropertyAddress, SendHTTPRequest_FunctionAddress, "InURL");
		SendHTTPRequest_InURL_Offset = NativeReflectionCached.GetPropertyOffset(SendHTTPRequest_FunctionAddress, "InURL");
		SendHTTPRequest_InURL_IsValid = NativeReflectionCached.ValidatePropertyClass(SendHTTPRequest_FunctionAddress, "InURL", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SendHTTPRequest_InVerb_PropertyAddress, SendHTTPRequest_FunctionAddress, "InVerb");
		SendHTTPRequest_InVerb_Offset = NativeReflectionCached.GetPropertyOffset(SendHTTPRequest_FunctionAddress, "InVerb");
		SendHTTPRequest_InVerb_IsValid = NativeReflectionCached.ValidatePropertyClass(SendHTTPRequest_FunctionAddress, "InVerb", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SendHTTPRequest_InMessage_PropertyAddress, SendHTTPRequest_FunctionAddress, "InMessage");
		SendHTTPRequest_InMessage_Offset = NativeReflectionCached.GetPropertyOffset(SendHTTPRequest_FunctionAddress, "InMessage");
		SendHTTPRequest_InMessage_IsValid = NativeReflectionCached.ValidatePropertyClass(SendHTTPRequest_FunctionAddress, "InMessage", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SendHTTPRequest_InHeaders_PropertyAddress, SendHTTPRequest_FunctionAddress, "InHeaders");
		SendHTTPRequest_InHeaders_Offset = NativeReflectionCached.GetPropertyOffset(SendHTTPRequest_FunctionAddress, "InHeaders");
		SendHTTPRequest_InHeaders_IsValid = NativeReflectionCached.ValidatePropertyClass(SendHTTPRequest_FunctionAddress, "InHeaders", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref SendHTTPRequest_ReturnValue_PropertyAddress, SendHTTPRequest_FunctionAddress, "ReturnValue");
		SendHTTPRequest_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SendHTTPRequest_FunctionAddress, "ReturnValue");
		SendHTTPRequest_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SendHTTPRequest_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SendHTTPRequest_IsValid = SendHTTPRequest_FunctionAddress != IntPtr.Zero && SendHTTPRequest_InURL_IsValid && SendHTTPRequest_InVerb_IsValid && SendHTTPRequest_InMessage_IsValid && SendHTTPRequest_InHeaders_IsValid && SendHTTPRequest_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:SendHTTPRequest", SendHTTPRequest_IsValid);
		OnExecutorFinishedImpl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnExecutorFinishedImpl");
		OnExecutorFinishedImpl_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExecutorFinishedImpl_FunctionAddress);
		OnExecutorFinishedImpl_IsValid = OnExecutorFinishedImpl_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnExecutorFinishedImpl", OnExecutorFinishedImpl_IsValid);
		OnExecutorErroredImpl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnExecutorErroredImpl");
		OnExecutorErroredImpl_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExecutorErroredImpl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnExecutorErroredImpl_ErroredPipeline_PropertyAddress, OnExecutorErroredImpl_FunctionAddress, "ErroredPipeline");
		OnExecutorErroredImpl_ErroredPipeline_Offset = NativeReflectionCached.GetPropertyOffset(OnExecutorErroredImpl_FunctionAddress, "ErroredPipeline");
		OnExecutorErroredImpl_ErroredPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExecutorErroredImpl_FunctionAddress, "ErroredPipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExecutorErroredImpl_bFatal_PropertyAddress, OnExecutorErroredImpl_FunctionAddress, "bFatal");
		OnExecutorErroredImpl_bFatal_Offset = NativeReflectionCached.GetPropertyOffset(OnExecutorErroredImpl_FunctionAddress, "bFatal");
		OnExecutorErroredImpl_bFatal_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExecutorErroredImpl_FunctionAddress, "bFatal", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExecutorErroredImpl_ErrorReason_PropertyAddress, OnExecutorErroredImpl_FunctionAddress, "ErrorReason");
		OnExecutorErroredImpl_ErrorReason_Offset = NativeReflectionCached.GetPropertyOffset(OnExecutorErroredImpl_FunctionAddress, "ErrorReason");
		OnExecutorErroredImpl_ErrorReason_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExecutorErroredImpl_FunctionAddress, "ErrorReason", Classes.FTextProperty);
		OnExecutorErroredImpl_IsValid = OnExecutorErroredImpl_FunctionAddress != IntPtr.Zero && OnExecutorErroredImpl_ErroredPipeline_IsValid && OnExecutorErroredImpl_bFatal_IsValid && OnExecutorErroredImpl_ErrorReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnExecutorErroredImpl", OnExecutorErroredImpl_IsValid);
		OnBeginFrame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnBeginFrame");
		OnBeginFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBeginFrame_FunctionAddress);
		OnBeginFrame_IsValid = OnBeginFrame_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:OnBeginFrame", OnBeginFrame_IsValid);
		IsSocketConnected_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSocketConnected");
		IsSocketConnected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSocketConnected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSocketConnected_ReturnValue_PropertyAddress, IsSocketConnected_FunctionAddress, "ReturnValue");
		IsSocketConnected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSocketConnected_FunctionAddress, "ReturnValue");
		IsSocketConnected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSocketConnected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSocketConnected_IsValid = IsSocketConnected_FunctionAddress != IntPtr.Zero && IsSocketConnected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:IsSocketConnected", IsSocketConnected_IsValid);
		IsRendering_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsRendering");
		IsRendering_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRendering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRendering_ReturnValue_PropertyAddress, IsRendering_FunctionAddress, "ReturnValue");
		IsRendering_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRendering_FunctionAddress, "ReturnValue");
		IsRendering_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRendering_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRendering_IsValid = IsRendering_FunctionAddress != IntPtr.Zero && IsRendering_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:IsRendering", IsRendering_IsValid);
		GetStatusProgress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStatusProgress");
		GetStatusProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatusProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatusProgress_ReturnValue_PropertyAddress, GetStatusProgress_FunctionAddress, "ReturnValue");
		GetStatusProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatusProgress_FunctionAddress, "ReturnValue");
		GetStatusProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatusProgress_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStatusProgress_IsValid = GetStatusProgress_FunctionAddress != IntPtr.Zero && GetStatusProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:GetStatusProgress", GetStatusProgress_IsValid);
		GetStatusMessage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStatusMessage");
		GetStatusMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatusMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatusMessage_ReturnValue_PropertyAddress, GetStatusMessage_FunctionAddress, "ReturnValue");
		GetStatusMessage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatusMessage_FunctionAddress, "ReturnValue");
		GetStatusMessage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatusMessage_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStatusMessage_IsValid = GetStatusMessage_FunctionAddress != IntPtr.Zero && GetStatusMessage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:GetStatusMessage", GetStatusMessage_IsValid);
		Execute_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Execute");
		Execute_ParamsSize = NativeReflection.GetFunctionParamsSize(Execute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Execute_InPipelineQueue_PropertyAddress, Execute_FunctionAddress, "InPipelineQueue");
		Execute_InPipelineQueue_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "InPipelineQueue");
		Execute_InPipelineQueue_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "InPipelineQueue", Classes.FObjectProperty);
		Execute_IsValid = Execute_FunctionAddress != IntPtr.Zero && Execute_InPipelineQueue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:Execute", Execute_IsValid);
		DisconnectSocket_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisconnectSocket");
		DisconnectSocket_ParamsSize = NativeReflection.GetFunctionParamsSize(DisconnectSocket_FunctionAddress);
		DisconnectSocket_IsValid = DisconnectSocket_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:DisconnectSocket", DisconnectSocket_IsValid);
		ConnectSocket_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConnectSocket");
		ConnectSocket_ParamsSize = NativeReflection.GetFunctionParamsSize(ConnectSocket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConnectSocket_InHostName_PropertyAddress, ConnectSocket_FunctionAddress, "InHostName");
		ConnectSocket_InHostName_Offset = NativeReflectionCached.GetPropertyOffset(ConnectSocket_FunctionAddress, "InHostName");
		ConnectSocket_InHostName_IsValid = NativeReflectionCached.ValidatePropertyClass(ConnectSocket_FunctionAddress, "InHostName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConnectSocket_InPort_PropertyAddress, ConnectSocket_FunctionAddress, "InPort");
		ConnectSocket_InPort_Offset = NativeReflectionCached.GetPropertyOffset(ConnectSocket_FunctionAddress, "InPort");
		ConnectSocket_InPort_IsValid = NativeReflectionCached.ValidatePropertyClass(ConnectSocket_FunctionAddress, "InPort", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConnectSocket_ReturnValue_PropertyAddress, ConnectSocket_FunctionAddress, "ReturnValue");
		ConnectSocket_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConnectSocket_FunctionAddress, "ReturnValue");
		ConnectSocket_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConnectSocket_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ConnectSocket_IsValid = ConnectSocket_FunctionAddress != IntPtr.Zero && ConnectSocket_InHostName_IsValid && ConnectSocket_InPort_IsValid && ConnectSocket_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:ConnectSocket", ConnectSocket_IsValid);
		CancelCurrentJob_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CancelCurrentJob");
		CancelCurrentJob_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelCurrentJob_FunctionAddress);
		CancelCurrentJob_IsValid = CancelCurrentJob_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:CancelCurrentJob", CancelCurrentJob_IsValid);
		CancelAllJobs_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CancelAllJobs");
		CancelAllJobs_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelAllJobs_FunctionAddress);
		CancelAllJobs_IsValid = CancelAllJobs_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineExecutorBase:CancelAllJobs", CancelAllJobs_IsValid);
	}
}
