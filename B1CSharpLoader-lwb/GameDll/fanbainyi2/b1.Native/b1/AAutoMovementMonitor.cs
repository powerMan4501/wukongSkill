using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor", "UnrealExtent", UnrealModuleType.Game)]
public class AAutoMovementMonitor : AActor
{
	private static bool AutoMovePattern_IsValid;

	private static int AutoMovePattern_Offset;

	private static bool ReportFilePath_IsValid;

	private static int ReportFilePath_Offset;

	private static bool PathPoints_IsValid;

	private static FFieldAddress PathPoints_PropertyAddress;

	private static int PathPoints_Offset;

	private TArrayReadWriteMarshaler<FVector> PathPoints_MarshalerCached;

	private static bool CachedPathPoints_IsValid;

	private static FFieldAddress CachedPathPoints_PropertyAddress;

	private static int CachedPathPoints_Offset;

	private TArrayReadWriteMarshaler<FVector> CachedPathPoints_MarshalerCached;

	private static bool LogProcessingState_IsValid;

	private static FFieldAddress LogProcessingState_PropertyAddress;

	private static int LogProcessingState_Offset;

	private static bool IsReadyToProcess_IsValid;

	private static FFieldAddress IsReadyToProcess_PropertyAddress;

	private static int IsReadyToProcess_Offset;

	private static bool PitchingPositively_IsValid;

	private static FFieldAddress PitchingPositively_PropertyAddress;

	private static int PitchingPositively_Offset;

	private static bool TargetPositionIndex_IsValid;

	private static int TargetPositionIndex_Offset;

	private static bool TargetYawIndex_IsValid;

	private static int TargetYawIndex_Offset;

	private static bool TargetPitchIndex_IsValid;

	private static int TargetPitchIndex_Offset;

	private static bool TargetPosition_IsValid;

	private static int TargetPosition_Offset;

	private static bool TargetRotation_IsValid;

	private static int TargetRotation_Offset;

	private static bool ViewingPhaseIndex_IsValid;

	private static int ViewingPhaseIndex_Offset;

	private static bool AutoMoveStartTimeSinceAppStarted_IsValid;

	private static int AutoMoveStartTimeSinceAppStarted_Offset;

	private static bool LastPointEndTimestamp_IsValid;

	private static int LastPointEndTimestamp_Offset;

	private static bool TransportViewingPosition_IsValid;

	private IntPtr TransportViewingPosition_InstanceFunctionAddress;

	private static IntPtr TransportViewingPosition_FunctionAddress;

	private static int TransportViewingPosition_ParamsSize;

	private static bool TransportViewingPosition_InLocation_IsValid;

	private static FFieldAddress TransportViewingPosition_InLocation_PropertyAddress;

	private static int TransportViewingPosition_InLocation_Offset;

	private static bool TransportViewingPosition_InRotator_IsValid;

	private static FFieldAddress TransportViewingPosition_InRotator_PropertyAddress;

	private static int TransportViewingPosition_InRotator_Offset;

	private static bool TransportViewingPosition_bProxyCall_IsValid;

	private static FFieldAddress TransportViewingPosition_bProxyCall_PropertyAddress;

	private static int TransportViewingPosition_bProxyCall_Offset;

	private static bool SwitchToVirtualPawn_IsValid;

	private IntPtr SwitchToVirtualPawn_InstanceFunctionAddress;

	private static IntPtr SwitchToVirtualPawn_FunctionAddress;

	private static int SwitchToVirtualPawn_ParamsSize;

	private static bool SwitchToVirtualPawn_VirtualPlayerBaseClass_IsValid;

	private static FFieldAddress SwitchToVirtualPawn_VirtualPlayerBaseClass_PropertyAddress;

	private static int SwitchToVirtualPawn_VirtualPlayerBaseClass_Offset;

	private static bool SwitchToVirtualPawn_SpawningOffset_IsValid;

	private static FFieldAddress SwitchToVirtualPawn_SpawningOffset_PropertyAddress;

	private static int SwitchToVirtualPawn_SpawningOffset_Offset;

	private static bool SwitchRotateDirection_IsValid;

	private static IntPtr SwitchRotateDirection_FunctionAddress;

	private static int SwitchRotateDirection_ParamsSize;

	private static bool StopAutoMovement_IsValid;

	private static IntPtr StopAutoMovement_FunctionAddress;

	private static int StopAutoMovement_ParamsSize;

	private static bool SetSparseVersionEnabled_IsValid;

	private static IntPtr SetSparseVersionEnabled_FunctionAddress;

	private static int SetSparseVersionEnabled_ParamsSize;

	private static bool SetSparseVersionEnabled_bEnabled_IsValid;

	private static FFieldAddress SetSparseVersionEnabled_bEnabled_PropertyAddress;

	private static int SetSparseVersionEnabled_bEnabled_Offset;

	private static bool ResumeAutoMovement_IsValid;

	private IntPtr ResumeAutoMovement_InstanceFunctionAddress;

	private static IntPtr ResumeAutoMovement_FunctionAddress;

	private static int ResumeAutoMovement_ParamsSize;

	private static bool ResetYawRotation_IsValid;

	private static IntPtr ResetYawRotation_FunctionAddress;

	private static int ResetYawRotation_ParamsSize;

	private static bool ResetTransportAttemptedCount_IsValid;

	private static IntPtr ResetTransportAttemptedCount_FunctionAddress;

	private static int ResetTransportAttemptedCount_ParamsSize;

	private static bool ResetPitchRotation_IsValid;

	private static IntPtr ResetPitchRotation_FunctionAddress;

	private static int ResetPitchRotation_ParamsSize;

	private static bool ResetAutoMovement_IsValid;

	private static IntPtr ResetAutoMovement_FunctionAddress;

	private static int ResetAutoMovement_ParamsSize;

	private static bool RegisterAutoMovementConsoleCommands_IsValid;

	private static IntPtr RegisterAutoMovementConsoleCommands_FunctionAddress;

	private static int RegisterAutoMovementConsoleCommands_ParamsSize;

	private static bool ProcessAutoMovement_IsValid;

	private static IntPtr ProcessAutoMovement_FunctionAddress;

	private static int ProcessAutoMovement_ParamsSize;

	private static bool ProcessAutoMovement_InLocation_IsValid;

	private static FFieldAddress ProcessAutoMovement_InLocation_PropertyAddress;

	private static int ProcessAutoMovement_InLocation_Offset;

	private static bool ProcessAutoMovement_InRotator_IsValid;

	private static FFieldAddress ProcessAutoMovement_InRotator_PropertyAddress;

	private static int ProcessAutoMovement_InRotator_Offset;

	private static bool PreAutoMovement_IsValid;

	private IntPtr PreAutoMovement_InstanceFunctionAddress;

	private static IntPtr PreAutoMovement_FunctionAddress;

	private static int PreAutoMovement_ParamsSize;

	private static bool PostAutoMovement_IsValid;

	private IntPtr PostAutoMovement_InstanceFunctionAddress;

	private static IntPtr PostAutoMovement_FunctionAddress;

	private static int PostAutoMovement_ParamsSize;

	private static bool PauseAutoMovement_IsValid;

	private IntPtr PauseAutoMovement_InstanceFunctionAddress;

	private static IntPtr PauseAutoMovement_FunctionAddress;

	private static int PauseAutoMovement_ParamsSize;

	private static bool LoadPathPoints_IsValid;

	private static IntPtr LoadPathPoints_FunctionAddress;

	private static int LoadPathPoints_ParamsSize;

	private static bool IncreaseViewingRotation_IsValid;

	private IntPtr IncreaseViewingRotation_InstanceFunctionAddress;

	private static IntPtr IncreaseViewingRotation_FunctionAddress;

	private static int IncreaseViewingRotation_ParamsSize;

	private static bool IncreaseViewingRotation_RotateType_IsValid;

	private static FFieldAddress IncreaseViewingRotation_RotateType_PropertyAddress;

	private static int IncreaseViewingRotation_RotateType_Offset;

	private static bool IncreaseViewingRotation_bProxyCall_IsValid;

	private static FFieldAddress IncreaseViewingRotation_bProxyCall_PropertyAddress;

	private static int IncreaseViewingRotation_bProxyCall_Offset;

	private static bool HasCompletedYawingObservation_IsValid;

	private static IntPtr HasCompletedYawingObservation_FunctionAddress;

	private static int HasCompletedYawingObservation_ParamsSize;

	private static bool HasCompletedYawingObservation_ReturnValue_IsValid;

	private static FFieldAddress HasCompletedYawingObservation_ReturnValue_PropertyAddress;

	private static int HasCompletedYawingObservation_ReturnValue_Offset;

	private static bool HasCompletedPitchingObservation_IsValid;

	private static IntPtr HasCompletedPitchingObservation_FunctionAddress;

	private static int HasCompletedPitchingObservation_ParamsSize;

	private static bool HasCompletedPitchingObservation_ReturnValue_IsValid;

	private static FFieldAddress HasCompletedPitchingObservation_ReturnValue_PropertyAddress;

	private static int HasCompletedPitchingObservation_ReturnValue_Offset;

	private static bool GetRotationIncrement_IsValid;

	private static IntPtr GetRotationIncrement_FunctionAddress;

	private static int GetRotationIncrement_ParamsSize;

	private static bool GetRotationIncrement_InRotatorMask_IsValid;

	private static FFieldAddress GetRotationIncrement_InRotatorMask_PropertyAddress;

	private static int GetRotationIncrement_InRotatorMask_Offset;

	private static bool GetRotationIncrement_ViewingPattern_IsValid;

	private static FFieldAddress GetRotationIncrement_ViewingPattern_PropertyAddress;

	private static int GetRotationIncrement_ViewingPattern_Offset;

	private static bool GetRotationIncrement_ReturnValue_IsValid;

	private static FFieldAddress GetRotationIncrement_ReturnValue_PropertyAddress;

	private static int GetRotationIncrement_ReturnValue_Offset;

	private static bool GetPointExecutionDurationInfo_IsValid;

	private static IntPtr GetPointExecutionDurationInfo_FunctionAddress;

	private static int GetPointExecutionDurationInfo_ParamsSize;

	private static bool GetPointExecutionDurationInfo_InStartTimestamp_IsValid;

	private static FFieldAddress GetPointExecutionDurationInfo_InStartTimestamp_PropertyAddress;

	private static int GetPointExecutionDurationInfo_InStartTimestamp_Offset;

	private static bool GetPointExecutionDurationInfo_ReturnValue_IsValid;

	private static FFieldAddress GetPointExecutionDurationInfo_ReturnValue_PropertyAddress;

	private static int GetPointExecutionDurationInfo_ReturnValue_Offset;

	private static bool ExitAppOnAutoMoveFinished_IsValid;

	private static IntPtr ExitAppOnAutoMoveFinished_FunctionAddress;

	private static int ExitAppOnAutoMoveFinished_ParamsSize;

	private static bool EnableAutoMovement_IsValid;

	private static IntPtr EnableAutoMovement_FunctionAddress;

	private static int EnableAutoMovement_ParamsSize;

	private static bool DrawStatOnHeatmap_IsValid;

	private IntPtr DrawStatOnHeatmap_InstanceFunctionAddress;

	private static IntPtr DrawStatOnHeatmap_FunctionAddress;

	private static int DrawStatOnHeatmap_ParamsSize;

	private static bool DrawStatOnHeatmap_InStatName_IsValid;

	private static FFieldAddress DrawStatOnHeatmap_InStatName_PropertyAddress;

	private static int DrawStatOnHeatmap_InStatName_Offset;

	private static bool DrawStatOnHeatmap_InTileCount_IsValid;

	private static FFieldAddress DrawStatOnHeatmap_InTileCount_PropertyAddress;

	private static int DrawStatOnHeatmap_InTileCount_Offset;

	private static bool CreatePointInstances_IsValid;

	private IntPtr CreatePointInstances_InstanceFunctionAddress;

	private static IntPtr CreatePointInstances_FunctionAddress;

	private static int CreatePointInstances_ParamsSize;

	private static bool CreatePointInstances_InPoints_IsValid;

	private static FFieldAddress CreatePointInstances_InPoints_PropertyAddress;

	private static int CreatePointInstances_InPoints_Offset;

	private static bool CheckHitRotation_IsValid;

	private IntPtr CheckHitRotation_InstanceFunctionAddress;

	private static IntPtr CheckHitRotation_FunctionAddress;

	private static int CheckHitRotation_ParamsSize;

	private static bool CheckHitRotation_InRotator_IsValid;

	private static FFieldAddress CheckHitRotation_InRotator_PropertyAddress;

	private static int CheckHitRotation_InRotator_Offset;

	private static bool CheckHitLocation_IsValid;

	private static IntPtr CheckHitLocation_FunctionAddress;

	private static int CheckHitLocation_ParamsSize;

	private static bool CheckHitLocation_InLocation_IsValid;

	private static FFieldAddress CheckHitLocation_InLocation_PropertyAddress;

	private static int CheckHitLocation_InLocation_Offset;

	private static bool CheckHitLocation_ReturnValue_IsValid;

	private static FFieldAddress CheckHitLocation_ReturnValue_PropertyAddress;

	private static int CheckHitLocation_ReturnValue_Offset;

	private static bool CheckAutoMovementCompleted_IsValid;

	private static IntPtr CheckAutoMovementCompleted_FunctionAddress;

	private static int CheckAutoMovementCompleted_ParamsSize;

	private static bool CheckAutoMovementCompleted_ReturnValue_IsValid;

	private static FFieldAddress CheckAutoMovementCompleted_ReturnValue_PropertyAddress;

	private static int CheckAutoMovementCompleted_ReturnValue_Offset;

	private static bool CaptureViewingInfo_IsValid;

	private IntPtr CaptureViewingInfo_InstanceFunctionAddress;

	private static IntPtr CaptureViewingInfo_FunctionAddress;

	private static int CaptureViewingInfo_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:AutoMovePattern")]
	public UAutoMovementPattern AutoMovePattern
	{
		get
		{
			CheckDestroyed();
			if (!AutoMovePattern_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:AutoMovePattern");
				return null;
			}
			return UObjectMarshaler<UAutoMovementPattern>.FromNative(IntPtr.Add(base.Address, AutoMovePattern_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoMovePattern_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:AutoMovePattern");
			}
			else
			{
				UObjectMarshaler<UAutoMovementPattern>.ToNative(IntPtr.Add(base.Address, AutoMovePattern_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441187333uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:ReportFilePath")]
	public string ReportFilePath
	{
		get
		{
			CheckDestroyed();
			if (!ReportFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:ReportFilePath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ReportFilePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReportFilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:ReportFilePath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ReportFilePath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:PathPoints")]
	public TArrayReadWrite<FVector> PathPoints
	{
		get
		{
			CheckDestroyed();
			if (!PathPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:PathPoints");
				return null;
			}
			if (PathPoints_MarshalerCached == null)
			{
				PathPoints_MarshalerCached = new TArrayReadWriteMarshaler<FVector>(1, PathPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return PathPoints_MarshalerCached.FromNative(IntPtr.Add(base.Address, PathPoints_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:CachedPathPoints")]
	public TArrayReadWrite<FVector> CachedPathPoints
	{
		get
		{
			CheckDestroyed();
			if (!CachedPathPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:CachedPathPoints");
				return null;
			}
			if (CachedPathPoints_MarshalerCached == null)
			{
				CachedPathPoints_MarshalerCached = new TArrayReadWriteMarshaler<FVector>(1, CachedPathPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return CachedPathPoints_MarshalerCached.FromNative(IntPtr.Add(base.Address, CachedPathPoints_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:bLogProcessingState")]
	public bool LogProcessingState
	{
		get
		{
			CheckDestroyed();
			if (!LogProcessingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:bLogProcessingState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LogProcessingState_Offset), 0, LogProcessingState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LogProcessingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:bLogProcessingState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LogProcessingState_Offset), 0, LogProcessingState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:bIsReadyToProcess")]
	public bool IsReadyToProcess
	{
		get
		{
			CheckDestroyed();
			if (!IsReadyToProcess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:bIsReadyToProcess");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsReadyToProcess_Offset), 0, IsReadyToProcess_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsReadyToProcess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:bIsReadyToProcess");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsReadyToProcess_Offset), 0, IsReadyToProcess_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:bPitchingPositively")]
	public bool PitchingPositively
	{
		get
		{
			CheckDestroyed();
			if (!PitchingPositively_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:bPitchingPositively");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PitchingPositively_Offset), 0, PitchingPositively_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PitchingPositively_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:bPitchingPositively");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PitchingPositively_Offset), 0, PitchingPositively_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:TargetPositionIndex")]
	public int TargetPositionIndex
	{
		get
		{
			CheckDestroyed();
			if (!TargetPositionIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetPositionIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetPositionIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPositionIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetPositionIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetPositionIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:TargetYawIndex")]
	public int TargetYawIndex
	{
		get
		{
			CheckDestroyed();
			if (!TargetYawIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetYawIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetYawIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetYawIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetYawIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetYawIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:TargetPitchIndex")]
	public int TargetPitchIndex
	{
		get
		{
			CheckDestroyed();
			if (!TargetPitchIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetPitchIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetPitchIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPitchIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetPitchIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetPitchIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:TargetPosition")]
	public FVector TargetPosition
	{
		get
		{
			CheckDestroyed();
			if (!TargetPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetPosition");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, TargetPosition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetPosition");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, TargetPosition_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420720645uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:TargetRotation")]
	public FRotator TargetRotation
	{
		get
		{
			CheckDestroyed();
			if (!TargetRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, TargetRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:TargetRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, TargetRotation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:ViewingPhaseIndex")]
	public int ViewingPhaseIndex
	{
		get
		{
			CheckDestroyed();
			if (!ViewingPhaseIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:ViewingPhaseIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ViewingPhaseIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewingPhaseIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:ViewingPhaseIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ViewingPhaseIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441187333uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:AutoMoveStartTimeSinceAppStarted")]
	public string AutoMoveStartTimeSinceAppStarted
	{
		get
		{
			CheckDestroyed();
			if (!AutoMoveStartTimeSinceAppStarted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:AutoMoveStartTimeSinceAppStarted");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AutoMoveStartTimeSinceAppStarted_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoMoveStartTimeSinceAppStarted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:AutoMoveStartTimeSinceAppStarted");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AutoMoveStartTimeSinceAppStarted_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:LastPointEndTimestamp")]
	public float LastPointEndTimestamp
	{
		get
		{
			CheckDestroyed();
			if (!LastPointEndTimestamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:LastPointEndTimestamp");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LastPointEndTimestamp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastPointEndTimestamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementMonitor:LastPointEndTimestamp");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LastPointEndTimestamp_Offset), value);
			}
		}
	}

	[UFunction(Flags = 209849344u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:TransportViewingPosition")]
	public unsafe void TransportViewingPosition(FVector InLocation, FRotator InRotator, bool bProxyCall = false)
	{
		CheckDestroyed();
		if (!TransportViewingPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:TransportViewingPosition");
			return;
		}
		if (TransportViewingPosition_InstanceFunctionAddress == IntPtr.Zero)
		{
			TransportViewingPosition_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "TransportViewingPosition");
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransportViewingPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransportViewingPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TransportViewingPosition_InLocation_Offset), 0, TransportViewingPosition_InLocation_PropertyAddress.Address, InLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, TransportViewingPosition_InRotator_Offset), 0, TransportViewingPosition_InRotator_PropertyAddress.Address, InRotator);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TransportViewingPosition_bProxyCall_Offset), 0, TransportViewingPosition_bProxyCall_PropertyAddress.Address, bProxyCall);
		NativeReflection.InvokeFunctionOptimized(base.Address, TransportViewingPosition_InstanceFunctionAddress, intPtr, TransportViewingPosition_ParamsSize);
	}

	protected unsafe virtual void TransportViewingPosition_Implementation(FVector InLocation, FRotator InRotator, bool bProxyCall = false)
	{
		CheckDestroyed();
		if (!TransportViewingPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:TransportViewingPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransportViewingPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransportViewingPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TransportViewingPosition_InLocation_Offset), 0, TransportViewingPosition_InLocation_PropertyAddress.Address, InLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, TransportViewingPosition_InRotator_Offset), 0, TransportViewingPosition_InRotator_PropertyAddress.Address, InRotator);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TransportViewingPosition_bProxyCall_Offset), 0, TransportViewingPosition_bProxyCall_PropertyAddress.Address, bProxyCall);
		NativeReflection.InvokeFunctionOptimized(base.Address, TransportViewingPosition_FunctionAddress, intPtr, TransportViewingPosition_ParamsSize);
	}

	[UFunction(Flags = 209849344u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:SwitchToVirtualPawn")]
	public unsafe void SwitchToVirtualPawn(TSubclassOf<UObject> VirtualPlayerBaseClass, FVector SpawningOffset)
	{
		CheckDestroyed();
		if (!SwitchToVirtualPawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:SwitchToVirtualPawn");
			return;
		}
		if (SwitchToVirtualPawn_InstanceFunctionAddress == IntPtr.Zero)
		{
			SwitchToVirtualPawn_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SwitchToVirtualPawn");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchToVirtualPawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchToVirtualPawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SwitchToVirtualPawn_VirtualPlayerBaseClass_Offset), 0, SwitchToVirtualPawn_VirtualPlayerBaseClass_PropertyAddress.Address, VirtualPlayerBaseClass);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SwitchToVirtualPawn_SpawningOffset_Offset), 0, SwitchToVirtualPawn_SpawningOffset_PropertyAddress.Address, SpawningOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchToVirtualPawn_InstanceFunctionAddress, intPtr, SwitchToVirtualPawn_ParamsSize);
	}

	protected unsafe virtual void SwitchToVirtualPawn_Implementation(TSubclassOf<UObject> VirtualPlayerBaseClass, FVector SpawningOffset)
	{
		CheckDestroyed();
		if (!SwitchToVirtualPawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:SwitchToVirtualPawn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchToVirtualPawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchToVirtualPawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SwitchToVirtualPawn_VirtualPlayerBaseClass_Offset), 0, SwitchToVirtualPawn_VirtualPlayerBaseClass_PropertyAddress.Address, VirtualPlayerBaseClass);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SwitchToVirtualPawn_SpawningOffset_Offset), 0, SwitchToVirtualPawn_SpawningOffset_PropertyAddress.Address, SpawningOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchToVirtualPawn_FunctionAddress, intPtr, SwitchToVirtualPawn_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:SwitchRotateDirection")]
	public unsafe void SwitchRotateDirection()
	{
		CheckDestroyed();
		if (!SwitchRotateDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:SwitchRotateDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchRotateDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchRotateDirection_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SwitchRotateDirection_FunctionAddress, argsSize: SwitchRotateDirection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:StopAutoMovement")]
	public unsafe void StopAutoMovement()
	{
		CheckDestroyed();
		if (!StopAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:StopAutoMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopAutoMovement_FunctionAddress, argsSize: StopAutoMovement_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:SetSparseVersionEnabled")]
	public unsafe void SetSparseVersionEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetSparseVersionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:SetSparseVersionEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSparseVersionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSparseVersionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSparseVersionEnabled_bEnabled_Offset), 0, SetSparseVersionEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSparseVersionEnabled_FunctionAddress, intPtr, SetSparseVersionEnabled_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:ResumeAutoMovement")]
	public unsafe void ResumeAutoMovement()
	{
		CheckDestroyed();
		if (!ResumeAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:ResumeAutoMovement");
			return;
		}
		if (ResumeAutoMovement_InstanceFunctionAddress == IntPtr.Zero)
		{
			ResumeAutoMovement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ResumeAutoMovement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResumeAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResumeAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResumeAutoMovement_InstanceFunctionAddress, argsSize: ResumeAutoMovement_ParamsSize);
	}

	protected unsafe virtual void ResumeAutoMovement_Implementation()
	{
		CheckDestroyed();
		if (!ResumeAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:ResumeAutoMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResumeAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResumeAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResumeAutoMovement_FunctionAddress, argsSize: ResumeAutoMovement_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:ResetYawRotation")]
	public unsafe void ResetYawRotation()
	{
		CheckDestroyed();
		if (!ResetYawRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:ResetYawRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetYawRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetYawRotation_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetYawRotation_FunctionAddress, argsSize: ResetYawRotation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:ResetTransportAttemptedCount")]
	public unsafe void ResetTransportAttemptedCount()
	{
		CheckDestroyed();
		if (!ResetTransportAttemptedCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:ResetTransportAttemptedCount");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetTransportAttemptedCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetTransportAttemptedCount_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetTransportAttemptedCount_FunctionAddress, argsSize: ResetTransportAttemptedCount_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:ResetPitchRotation")]
	public unsafe void ResetPitchRotation()
	{
		CheckDestroyed();
		if (!ResetPitchRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:ResetPitchRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetPitchRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetPitchRotation_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetPitchRotation_FunctionAddress, argsSize: ResetPitchRotation_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:ResetAutoMovement")]
	public unsafe void ResetAutoMovement()
	{
		CheckDestroyed();
		if (!ResetAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:ResetAutoMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetAutoMovement_FunctionAddress, argsSize: ResetAutoMovement_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:RegisterAutoMovementConsoleCommands")]
	public unsafe void RegisterAutoMovementConsoleCommands()
	{
		CheckDestroyed();
		if (!RegisterAutoMovementConsoleCommands_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:RegisterAutoMovementConsoleCommands");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterAutoMovementConsoleCommands_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterAutoMovementConsoleCommands_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RegisterAutoMovementConsoleCommands_FunctionAddress, argsSize: RegisterAutoMovementConsoleCommands_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:ProcessAutoMovement")]
	public unsafe void ProcessAutoMovement(FVector InLocation, FRotator InRotator)
	{
		CheckDestroyed();
		if (!ProcessAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:ProcessAutoMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessAutoMovement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ProcessAutoMovement_InLocation_Offset), 0, ProcessAutoMovement_InLocation_PropertyAddress.Address, InLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, ProcessAutoMovement_InRotator_Offset), 0, ProcessAutoMovement_InRotator_PropertyAddress.Address, InRotator);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProcessAutoMovement_FunctionAddress, intPtr, ProcessAutoMovement_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:PreAutoMovement")]
	public unsafe void PreAutoMovement()
	{
		CheckDestroyed();
		if (!PreAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:PreAutoMovement");
			return;
		}
		if (PreAutoMovement_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreAutoMovement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreAutoMovement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreAutoMovement_InstanceFunctionAddress, argsSize: PreAutoMovement_ParamsSize);
	}

	protected unsafe virtual void PreAutoMovement_Implementation()
	{
		CheckDestroyed();
		if (!PreAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:PreAutoMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreAutoMovement_FunctionAddress, argsSize: PreAutoMovement_ParamsSize);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:PostAutoMovement")]
	public unsafe void PostAutoMovement()
	{
		CheckDestroyed();
		if (!PostAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:PostAutoMovement");
			return;
		}
		if (PostAutoMovement_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostAutoMovement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostAutoMovement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostAutoMovement_InstanceFunctionAddress, argsSize: PostAutoMovement_ParamsSize);
	}

	protected unsafe virtual void PostAutoMovement_Implementation()
	{
		CheckDestroyed();
		if (!PostAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:PostAutoMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostAutoMovement_FunctionAddress, argsSize: PostAutoMovement_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:PauseAutoMovement")]
	public unsafe void PauseAutoMovement()
	{
		CheckDestroyed();
		if (!PauseAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:PauseAutoMovement");
			return;
		}
		if (PauseAutoMovement_InstanceFunctionAddress == IntPtr.Zero)
		{
			PauseAutoMovement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PauseAutoMovement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PauseAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PauseAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PauseAutoMovement_InstanceFunctionAddress, argsSize: PauseAutoMovement_ParamsSize);
	}

	protected unsafe virtual void PauseAutoMovement_Implementation()
	{
		CheckDestroyed();
		if (!PauseAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:PauseAutoMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PauseAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PauseAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PauseAutoMovement_FunctionAddress, argsSize: PauseAutoMovement_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:LoadPathPoints")]
	public unsafe void LoadPathPoints()
	{
		CheckDestroyed();
		if (!LoadPathPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:LoadPathPoints");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadPathPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadPathPoints_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LoadPathPoints_FunctionAddress, argsSize: LoadPathPoints_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:IncreaseViewingRotation")]
	public unsafe void IncreaseViewingRotation(ERotateType RotateType, bool bProxyCall = false)
	{
		CheckDestroyed();
		if (!IncreaseViewingRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:IncreaseViewingRotation");
			return;
		}
		if (IncreaseViewingRotation_InstanceFunctionAddress == IntPtr.Zero)
		{
			IncreaseViewingRotation_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IncreaseViewingRotation");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IncreaseViewingRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IncreaseViewingRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERotateType>.ToNative(IntPtr.Add(intPtr, IncreaseViewingRotation_RotateType_Offset), 0, IncreaseViewingRotation_RotateType_PropertyAddress.Address, RotateType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IncreaseViewingRotation_bProxyCall_Offset), 0, IncreaseViewingRotation_bProxyCall_PropertyAddress.Address, bProxyCall);
		NativeReflection.InvokeFunctionOptimized(base.Address, IncreaseViewingRotation_InstanceFunctionAddress, intPtr, IncreaseViewingRotation_ParamsSize);
	}

	protected unsafe virtual void IncreaseViewingRotation_Implementation(ERotateType RotateType, bool bProxyCall = false)
	{
		CheckDestroyed();
		if (!IncreaseViewingRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:IncreaseViewingRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IncreaseViewingRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IncreaseViewingRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERotateType>.ToNative(IntPtr.Add(intPtr, IncreaseViewingRotation_RotateType_Offset), 0, IncreaseViewingRotation_RotateType_PropertyAddress.Address, RotateType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IncreaseViewingRotation_bProxyCall_Offset), 0, IncreaseViewingRotation_bProxyCall_PropertyAddress.Address, bProxyCall);
		NativeReflection.InvokeFunctionOptimized(base.Address, IncreaseViewingRotation_FunctionAddress, intPtr, IncreaseViewingRotation_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:HasCompletedYawingObservation")]
	public unsafe bool HasCompletedYawingObservation()
	{
		CheckDestroyed();
		if (!HasCompletedYawingObservation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:HasCompletedYawingObservation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasCompletedYawingObservation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasCompletedYawingObservation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasCompletedYawingObservation_FunctionAddress, intPtr, HasCompletedYawingObservation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasCompletedYawingObservation_ReturnValue_Offset), 0, HasCompletedYawingObservation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:HasCompletedPitchingObservation")]
	public unsafe bool HasCompletedPitchingObservation()
	{
		CheckDestroyed();
		if (!HasCompletedPitchingObservation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:HasCompletedPitchingObservation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasCompletedPitchingObservation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasCompletedPitchingObservation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasCompletedPitchingObservation_FunctionAddress, intPtr, HasCompletedPitchingObservation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasCompletedPitchingObservation_ReturnValue_Offset), 0, HasCompletedPitchingObservation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:GetRotationIncrement")]
	public unsafe FRotator GetRotationIncrement(FVector InRotatorMask, FAutoMovementViewingPattern ViewingPattern)
	{
		CheckDestroyed();
		if (!GetRotationIncrement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:GetRotationIncrement");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotationIncrement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotationIncrement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetRotationIncrement_InRotatorMask_Offset), 0, GetRotationIncrement_InRotatorMask_PropertyAddress.Address, InRotatorMask);
		NativeReflection.InitializeValue_InContainer(GetRotationIncrement_ViewingPattern_PropertyAddress.Address, intPtr);
		FAutoMovementViewingPattern.ToNative(IntPtr.Add(intPtr, GetRotationIncrement_ViewingPattern_Offset), 0, GetRotationIncrement_ViewingPattern_PropertyAddress.Address, ViewingPattern);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRotationIncrement_FunctionAddress, intPtr, GetRotationIncrement_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetRotationIncrement_ViewingPattern_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotationIncrement_ReturnValue_Offset), 0, GetRotationIncrement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:GetPointExecutionDurationInfo")]
	public unsafe string GetPointExecutionDurationInfo(long InStartTimestamp)
	{
		CheckDestroyed();
		if (!GetPointExecutionDurationInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:GetPointExecutionDurationInfo");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPointExecutionDurationInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPointExecutionDurationInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, GetPointExecutionDurationInfo_InStartTimestamp_Offset), 0, GetPointExecutionDurationInfo_InStartTimestamp_PropertyAddress.Address, InStartTimestamp);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPointExecutionDurationInfo_FunctionAddress, intPtr, GetPointExecutionDurationInfo_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPointExecutionDurationInfo_ReturnValue_Offset), 0, GetPointExecutionDurationInfo_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPointExecutionDurationInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:ExitAppOnAutoMoveFinished")]
	public unsafe void ExitAppOnAutoMoveFinished()
	{
		CheckDestroyed();
		if (!ExitAppOnAutoMoveFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:ExitAppOnAutoMoveFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExitAppOnAutoMoveFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExitAppOnAutoMoveFinished_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ExitAppOnAutoMoveFinished_FunctionAddress, argsSize: ExitAppOnAutoMoveFinished_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:EnableAutoMovement")]
	public unsafe void EnableAutoMovement()
	{
		CheckDestroyed();
		if (!EnableAutoMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:EnableAutoMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableAutoMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableAutoMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EnableAutoMovement_FunctionAddress, argsSize: EnableAutoMovement_ParamsSize);
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:DrawStatOnHeatmap")]
	public unsafe void DrawStatOnHeatmap(string InStatName, int InTileCount)
	{
		CheckDestroyed();
		if (!DrawStatOnHeatmap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:DrawStatOnHeatmap");
			return;
		}
		if (DrawStatOnHeatmap_InstanceFunctionAddress == IntPtr.Zero)
		{
			DrawStatOnHeatmap_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DrawStatOnHeatmap");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawStatOnHeatmap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawStatOnHeatmap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DrawStatOnHeatmap_InStatName_Offset), 0, DrawStatOnHeatmap_InStatName_PropertyAddress.Address, InStatName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawStatOnHeatmap_InTileCount_Offset), 0, DrawStatOnHeatmap_InTileCount_PropertyAddress.Address, InTileCount);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawStatOnHeatmap_InstanceFunctionAddress, intPtr, DrawStatOnHeatmap_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DrawStatOnHeatmap_InStatName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void DrawStatOnHeatmap_Implementation(string InStatName, int InTileCount)
	{
		CheckDestroyed();
		if (!DrawStatOnHeatmap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:DrawStatOnHeatmap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawStatOnHeatmap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawStatOnHeatmap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DrawStatOnHeatmap_InStatName_Offset), 0, DrawStatOnHeatmap_InStatName_PropertyAddress.Address, InStatName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawStatOnHeatmap_InTileCount_Offset), 0, DrawStatOnHeatmap_InTileCount_PropertyAddress.Address, InTileCount);
		NativeReflection.InvokeFunctionOptimized(base.Address, DrawStatOnHeatmap_FunctionAddress, intPtr, DrawStatOnHeatmap_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DrawStatOnHeatmap_InStatName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 205655040u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:CreatePointInstances")]
	public unsafe void CreatePointInstances(List<FVector> InPoints)
	{
		CheckDestroyed();
		if (!CreatePointInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:CreatePointInstances");
			return;
		}
		if (CreatePointInstances_InstanceFunctionAddress == IntPtr.Zero)
		{
			CreatePointInstances_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CreatePointInstances");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePointInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePointInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, CreatePointInstances_InPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CreatePointInstances_InPoints_Offset), InPoints);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePointInstances_InstanceFunctionAddress, intPtr, CreatePointInstances_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreatePointInstances_InPoints_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void CreatePointInstances_Implementation(List<FVector> InPoints)
	{
		CheckDestroyed();
		if (!CreatePointInstances_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:CreatePointInstances");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePointInstances_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePointInstances_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, CreatePointInstances_InPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, CreatePointInstances_InPoints_Offset), InPoints);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePointInstances_FunctionAddress, intPtr, CreatePointInstances_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreatePointInstances_InPoints_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 209849344u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:CheckHitRotation")]
	public unsafe void CheckHitRotation(FRotator InRotator)
	{
		CheckDestroyed();
		if (!CheckHitRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:CheckHitRotation");
			return;
		}
		if (CheckHitRotation_InstanceFunctionAddress == IntPtr.Zero)
		{
			CheckHitRotation_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CheckHitRotation");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckHitRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckHitRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, CheckHitRotation_InRotator_Offset), 0, CheckHitRotation_InRotator_PropertyAddress.Address, InRotator);
		NativeReflection.InvokeFunctionOptimized(base.Address, CheckHitRotation_InstanceFunctionAddress, intPtr, CheckHitRotation_ParamsSize);
	}

	protected unsafe virtual void CheckHitRotation_Implementation(FRotator InRotator)
	{
		CheckDestroyed();
		if (!CheckHitRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:CheckHitRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckHitRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckHitRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, CheckHitRotation_InRotator_Offset), 0, CheckHitRotation_InRotator_PropertyAddress.Address, InRotator);
		NativeReflection.InvokeFunctionOptimized(base.Address, CheckHitRotation_FunctionAddress, intPtr, CheckHitRotation_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:CheckHitLocation")]
	public unsafe bool CheckHitLocation(FVector InLocation)
	{
		CheckDestroyed();
		if (!CheckHitLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:CheckHitLocation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckHitLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckHitLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CheckHitLocation_InLocation_Offset), 0, CheckHitLocation_InLocation_PropertyAddress.Address, InLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, CheckHitLocation_FunctionAddress, intPtr, CheckHitLocation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckHitLocation_ReturnValue_Offset), 0, CheckHitLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:CheckAutoMovementCompleted")]
	public unsafe bool CheckAutoMovementCompleted()
	{
		CheckDestroyed();
		if (!CheckAutoMovementCompleted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:CheckAutoMovementCompleted");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckAutoMovementCompleted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckAutoMovementCompleted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CheckAutoMovementCompleted_FunctionAddress, intPtr, CheckAutoMovementCompleted_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckAutoMovementCompleted_ReturnValue_Offset), 0, CheckAutoMovementCompleted_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementMonitor:CaptureViewingInfo")]
	public unsafe void CaptureViewingInfo()
	{
		CheckDestroyed();
		if (!CaptureViewingInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:CaptureViewingInfo");
			return;
		}
		if (CaptureViewingInfo_InstanceFunctionAddress == IntPtr.Zero)
		{
			CaptureViewingInfo_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CaptureViewingInfo");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureViewingInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureViewingInfo_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CaptureViewingInfo_InstanceFunctionAddress, argsSize: CaptureViewingInfo_ParamsSize);
	}

	protected unsafe virtual void CaptureViewingInfo_Implementation()
	{
		CheckDestroyed();
		if (!CaptureViewingInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMovementMonitor:CaptureViewingInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureViewingInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureViewingInfo_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CaptureViewingInfo_FunctionAddress, argsSize: CaptureViewingInfo_ParamsSize);
	}

	static AAutoMovementMonitor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAutoMovementMonitor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAutoMovementMonitor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.AutoMovementMonitor");
		AutoMovePattern_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoMovePattern");
		AutoMovePattern_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoMovePattern", Classes.FObjectProperty);
		ReportFilePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReportFilePath");
		ReportFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReportFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PathPoints_PropertyAddress, intPtr, "PathPoints");
		PathPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathPoints");
		PathPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CachedPathPoints_PropertyAddress, intPtr, "CachedPathPoints");
		CachedPathPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CachedPathPoints");
		CachedPathPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CachedPathPoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LogProcessingState_PropertyAddress, intPtr, "bLogProcessingState");
		LogProcessingState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLogProcessingState");
		LogProcessingState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLogProcessingState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsReadyToProcess_PropertyAddress, intPtr, "bIsReadyToProcess");
		IsReadyToProcess_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsReadyToProcess");
		IsReadyToProcess_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsReadyToProcess", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PitchingPositively_PropertyAddress, intPtr, "bPitchingPositively");
		PitchingPositively_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPitchingPositively");
		PitchingPositively_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPitchingPositively", Classes.FBoolProperty);
		TargetPositionIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetPositionIndex");
		TargetPositionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetPositionIndex", Classes.FIntProperty);
		TargetYawIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetYawIndex");
		TargetYawIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetYawIndex", Classes.FIntProperty);
		TargetPitchIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetPitchIndex");
		TargetPitchIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetPitchIndex", Classes.FIntProperty);
		TargetPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetPosition");
		TargetPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetPosition", Classes.FStructProperty);
		TargetRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetRotation");
		TargetRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetRotation", Classes.FStructProperty);
		ViewingPhaseIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewingPhaseIndex");
		ViewingPhaseIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewingPhaseIndex", Classes.FIntProperty);
		AutoMoveStartTimeSinceAppStarted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoMoveStartTimeSinceAppStarted");
		AutoMoveStartTimeSinceAppStarted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoMoveStartTimeSinceAppStarted", Classes.FStrProperty);
		LastPointEndTimestamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastPointEndTimestamp");
		LastPointEndTimestamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastPointEndTimestamp", Classes.FFloatProperty);
		TransportViewingPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TransportViewingPosition");
		TransportViewingPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(TransportViewingPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransportViewingPosition_InLocation_PropertyAddress, TransportViewingPosition_FunctionAddress, "InLocation");
		TransportViewingPosition_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(TransportViewingPosition_FunctionAddress, "InLocation");
		TransportViewingPosition_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(TransportViewingPosition_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransportViewingPosition_InRotator_PropertyAddress, TransportViewingPosition_FunctionAddress, "InRotator");
		TransportViewingPosition_InRotator_Offset = NativeReflectionCached.GetPropertyOffset(TransportViewingPosition_FunctionAddress, "InRotator");
		TransportViewingPosition_InRotator_IsValid = NativeReflectionCached.ValidatePropertyClass(TransportViewingPosition_FunctionAddress, "InRotator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransportViewingPosition_bProxyCall_PropertyAddress, TransportViewingPosition_FunctionAddress, "bProxyCall");
		TransportViewingPosition_bProxyCall_Offset = NativeReflectionCached.GetPropertyOffset(TransportViewingPosition_FunctionAddress, "bProxyCall");
		TransportViewingPosition_bProxyCall_IsValid = NativeReflectionCached.ValidatePropertyClass(TransportViewingPosition_FunctionAddress, "bProxyCall", Classes.FBoolProperty);
		TransportViewingPosition_IsValid = TransportViewingPosition_FunctionAddress != IntPtr.Zero && TransportViewingPosition_InLocation_IsValid && TransportViewingPosition_InRotator_IsValid && TransportViewingPosition_bProxyCall_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:TransportViewingPosition", TransportViewingPosition_IsValid);
		SwitchToVirtualPawn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchToVirtualPawn");
		SwitchToVirtualPawn_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchToVirtualPawn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchToVirtualPawn_VirtualPlayerBaseClass_PropertyAddress, SwitchToVirtualPawn_FunctionAddress, "VirtualPlayerBaseClass");
		SwitchToVirtualPawn_VirtualPlayerBaseClass_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToVirtualPawn_FunctionAddress, "VirtualPlayerBaseClass");
		SwitchToVirtualPawn_VirtualPlayerBaseClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToVirtualPawn_FunctionAddress, "VirtualPlayerBaseClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToVirtualPawn_SpawningOffset_PropertyAddress, SwitchToVirtualPawn_FunctionAddress, "SpawningOffset");
		SwitchToVirtualPawn_SpawningOffset_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToVirtualPawn_FunctionAddress, "SpawningOffset");
		SwitchToVirtualPawn_SpawningOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToVirtualPawn_FunctionAddress, "SpawningOffset", Classes.FStructProperty);
		SwitchToVirtualPawn_IsValid = SwitchToVirtualPawn_FunctionAddress != IntPtr.Zero && SwitchToVirtualPawn_VirtualPlayerBaseClass_IsValid && SwitchToVirtualPawn_SpawningOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:SwitchToVirtualPawn", SwitchToVirtualPawn_IsValid);
		SwitchRotateDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchRotateDirection");
		SwitchRotateDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchRotateDirection_FunctionAddress);
		SwitchRotateDirection_IsValid = SwitchRotateDirection_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:SwitchRotateDirection", SwitchRotateDirection_IsValid);
		StopAutoMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAutoMovement");
		StopAutoMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAutoMovement_FunctionAddress);
		StopAutoMovement_IsValid = StopAutoMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:StopAutoMovement", StopAutoMovement_IsValid);
		SetSparseVersionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSparseVersionEnabled");
		SetSparseVersionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSparseVersionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSparseVersionEnabled_bEnabled_PropertyAddress, SetSparseVersionEnabled_FunctionAddress, "bEnabled");
		SetSparseVersionEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetSparseVersionEnabled_FunctionAddress, "bEnabled");
		SetSparseVersionEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSparseVersionEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetSparseVersionEnabled_IsValid = SetSparseVersionEnabled_FunctionAddress != IntPtr.Zero && SetSparseVersionEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:SetSparseVersionEnabled", SetSparseVersionEnabled_IsValid);
		ResumeAutoMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResumeAutoMovement");
		ResumeAutoMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(ResumeAutoMovement_FunctionAddress);
		ResumeAutoMovement_IsValid = ResumeAutoMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:ResumeAutoMovement", ResumeAutoMovement_IsValid);
		ResetYawRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetYawRotation");
		ResetYawRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetYawRotation_FunctionAddress);
		ResetYawRotation_IsValid = ResetYawRotation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:ResetYawRotation", ResetYawRotation_IsValid);
		ResetTransportAttemptedCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetTransportAttemptedCount");
		ResetTransportAttemptedCount_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetTransportAttemptedCount_FunctionAddress);
		ResetTransportAttemptedCount_IsValid = ResetTransportAttemptedCount_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:ResetTransportAttemptedCount", ResetTransportAttemptedCount_IsValid);
		ResetPitchRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetPitchRotation");
		ResetPitchRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetPitchRotation_FunctionAddress);
		ResetPitchRotation_IsValid = ResetPitchRotation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:ResetPitchRotation", ResetPitchRotation_IsValid);
		ResetAutoMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetAutoMovement");
		ResetAutoMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetAutoMovement_FunctionAddress);
		ResetAutoMovement_IsValid = ResetAutoMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:ResetAutoMovement", ResetAutoMovement_IsValid);
		RegisterAutoMovementConsoleCommands_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterAutoMovementConsoleCommands");
		RegisterAutoMovementConsoleCommands_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterAutoMovementConsoleCommands_FunctionAddress);
		RegisterAutoMovementConsoleCommands_IsValid = RegisterAutoMovementConsoleCommands_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:RegisterAutoMovementConsoleCommands", RegisterAutoMovementConsoleCommands_IsValid);
		ProcessAutoMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProcessAutoMovement");
		ProcessAutoMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessAutoMovement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProcessAutoMovement_InLocation_PropertyAddress, ProcessAutoMovement_FunctionAddress, "InLocation");
		ProcessAutoMovement_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(ProcessAutoMovement_FunctionAddress, "InLocation");
		ProcessAutoMovement_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessAutoMovement_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessAutoMovement_InRotator_PropertyAddress, ProcessAutoMovement_FunctionAddress, "InRotator");
		ProcessAutoMovement_InRotator_Offset = NativeReflectionCached.GetPropertyOffset(ProcessAutoMovement_FunctionAddress, "InRotator");
		ProcessAutoMovement_InRotator_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessAutoMovement_FunctionAddress, "InRotator", Classes.FStructProperty);
		ProcessAutoMovement_IsValid = ProcessAutoMovement_FunctionAddress != IntPtr.Zero && ProcessAutoMovement_InLocation_IsValid && ProcessAutoMovement_InRotator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:ProcessAutoMovement", ProcessAutoMovement_IsValid);
		PreAutoMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreAutoMovement");
		PreAutoMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(PreAutoMovement_FunctionAddress);
		PreAutoMovement_IsValid = PreAutoMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:PreAutoMovement", PreAutoMovement_IsValid);
		PostAutoMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostAutoMovement");
		PostAutoMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(PostAutoMovement_FunctionAddress);
		PostAutoMovement_IsValid = PostAutoMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:PostAutoMovement", PostAutoMovement_IsValid);
		PauseAutoMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PauseAutoMovement");
		PauseAutoMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(PauseAutoMovement_FunctionAddress);
		PauseAutoMovement_IsValid = PauseAutoMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:PauseAutoMovement", PauseAutoMovement_IsValid);
		LoadPathPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LoadPathPoints");
		LoadPathPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadPathPoints_FunctionAddress);
		LoadPathPoints_IsValid = LoadPathPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:LoadPathPoints", LoadPathPoints_IsValid);
		IncreaseViewingRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IncreaseViewingRotation");
		IncreaseViewingRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(IncreaseViewingRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IncreaseViewingRotation_RotateType_PropertyAddress, IncreaseViewingRotation_FunctionAddress, "RotateType");
		IncreaseViewingRotation_RotateType_Offset = NativeReflectionCached.GetPropertyOffset(IncreaseViewingRotation_FunctionAddress, "RotateType");
		IncreaseViewingRotation_RotateType_IsValid = NativeReflectionCached.ValidatePropertyClass(IncreaseViewingRotation_FunctionAddress, "RotateType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IncreaseViewingRotation_bProxyCall_PropertyAddress, IncreaseViewingRotation_FunctionAddress, "bProxyCall");
		IncreaseViewingRotation_bProxyCall_Offset = NativeReflectionCached.GetPropertyOffset(IncreaseViewingRotation_FunctionAddress, "bProxyCall");
		IncreaseViewingRotation_bProxyCall_IsValid = NativeReflectionCached.ValidatePropertyClass(IncreaseViewingRotation_FunctionAddress, "bProxyCall", Classes.FBoolProperty);
		IncreaseViewingRotation_IsValid = IncreaseViewingRotation_FunctionAddress != IntPtr.Zero && IncreaseViewingRotation_RotateType_IsValid && IncreaseViewingRotation_bProxyCall_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:IncreaseViewingRotation", IncreaseViewingRotation_IsValid);
		HasCompletedYawingObservation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasCompletedYawingObservation");
		HasCompletedYawingObservation_ParamsSize = NativeReflection.GetFunctionParamsSize(HasCompletedYawingObservation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasCompletedYawingObservation_ReturnValue_PropertyAddress, HasCompletedYawingObservation_FunctionAddress, "ReturnValue");
		HasCompletedYawingObservation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasCompletedYawingObservation_FunctionAddress, "ReturnValue");
		HasCompletedYawingObservation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasCompletedYawingObservation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasCompletedYawingObservation_IsValid = HasCompletedYawingObservation_FunctionAddress != IntPtr.Zero && HasCompletedYawingObservation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:HasCompletedYawingObservation", HasCompletedYawingObservation_IsValid);
		HasCompletedPitchingObservation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasCompletedPitchingObservation");
		HasCompletedPitchingObservation_ParamsSize = NativeReflection.GetFunctionParamsSize(HasCompletedPitchingObservation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasCompletedPitchingObservation_ReturnValue_PropertyAddress, HasCompletedPitchingObservation_FunctionAddress, "ReturnValue");
		HasCompletedPitchingObservation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasCompletedPitchingObservation_FunctionAddress, "ReturnValue");
		HasCompletedPitchingObservation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasCompletedPitchingObservation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasCompletedPitchingObservation_IsValid = HasCompletedPitchingObservation_FunctionAddress != IntPtr.Zero && HasCompletedPitchingObservation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:HasCompletedPitchingObservation", HasCompletedPitchingObservation_IsValid);
		GetRotationIncrement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRotationIncrement");
		GetRotationIncrement_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotationIncrement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotationIncrement_InRotatorMask_PropertyAddress, GetRotationIncrement_FunctionAddress, "InRotatorMask");
		GetRotationIncrement_InRotatorMask_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationIncrement_FunctionAddress, "InRotatorMask");
		GetRotationIncrement_InRotatorMask_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationIncrement_FunctionAddress, "InRotatorMask", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationIncrement_ViewingPattern_PropertyAddress, GetRotationIncrement_FunctionAddress, "ViewingPattern");
		GetRotationIncrement_ViewingPattern_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationIncrement_FunctionAddress, "ViewingPattern");
		GetRotationIncrement_ViewingPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationIncrement_FunctionAddress, "ViewingPattern", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotationIncrement_ReturnValue_PropertyAddress, GetRotationIncrement_FunctionAddress, "ReturnValue");
		GetRotationIncrement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotationIncrement_FunctionAddress, "ReturnValue");
		GetRotationIncrement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotationIncrement_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotationIncrement_IsValid = GetRotationIncrement_FunctionAddress != IntPtr.Zero && GetRotationIncrement_InRotatorMask_IsValid && GetRotationIncrement_ViewingPattern_IsValid && GetRotationIncrement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:GetRotationIncrement", GetRotationIncrement_IsValid);
		GetPointExecutionDurationInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPointExecutionDurationInfo");
		GetPointExecutionDurationInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPointExecutionDurationInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPointExecutionDurationInfo_InStartTimestamp_PropertyAddress, GetPointExecutionDurationInfo_FunctionAddress, "InStartTimestamp");
		GetPointExecutionDurationInfo_InStartTimestamp_Offset = NativeReflectionCached.GetPropertyOffset(GetPointExecutionDurationInfo_FunctionAddress, "InStartTimestamp");
		GetPointExecutionDurationInfo_InStartTimestamp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPointExecutionDurationInfo_FunctionAddress, "InStartTimestamp", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetPointExecutionDurationInfo_ReturnValue_PropertyAddress, GetPointExecutionDurationInfo_FunctionAddress, "ReturnValue");
		GetPointExecutionDurationInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPointExecutionDurationInfo_FunctionAddress, "ReturnValue");
		GetPointExecutionDurationInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPointExecutionDurationInfo_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPointExecutionDurationInfo_IsValid = GetPointExecutionDurationInfo_FunctionAddress != IntPtr.Zero && GetPointExecutionDurationInfo_InStartTimestamp_IsValid && GetPointExecutionDurationInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:GetPointExecutionDurationInfo", GetPointExecutionDurationInfo_IsValid);
		ExitAppOnAutoMoveFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExitAppOnAutoMoveFinished");
		ExitAppOnAutoMoveFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(ExitAppOnAutoMoveFinished_FunctionAddress);
		ExitAppOnAutoMoveFinished_IsValid = ExitAppOnAutoMoveFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:ExitAppOnAutoMoveFinished", ExitAppOnAutoMoveFinished_IsValid);
		EnableAutoMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableAutoMovement");
		EnableAutoMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableAutoMovement_FunctionAddress);
		EnableAutoMovement_IsValid = EnableAutoMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:EnableAutoMovement", EnableAutoMovement_IsValid);
		DrawStatOnHeatmap_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DrawStatOnHeatmap");
		DrawStatOnHeatmap_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawStatOnHeatmap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawStatOnHeatmap_InStatName_PropertyAddress, DrawStatOnHeatmap_FunctionAddress, "InStatName");
		DrawStatOnHeatmap_InStatName_Offset = NativeReflectionCached.GetPropertyOffset(DrawStatOnHeatmap_FunctionAddress, "InStatName");
		DrawStatOnHeatmap_InStatName_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawStatOnHeatmap_FunctionAddress, "InStatName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawStatOnHeatmap_InTileCount_PropertyAddress, DrawStatOnHeatmap_FunctionAddress, "InTileCount");
		DrawStatOnHeatmap_InTileCount_Offset = NativeReflectionCached.GetPropertyOffset(DrawStatOnHeatmap_FunctionAddress, "InTileCount");
		DrawStatOnHeatmap_InTileCount_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawStatOnHeatmap_FunctionAddress, "InTileCount", Classes.FIntProperty);
		DrawStatOnHeatmap_IsValid = DrawStatOnHeatmap_FunctionAddress != IntPtr.Zero && DrawStatOnHeatmap_InStatName_IsValid && DrawStatOnHeatmap_InTileCount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:DrawStatOnHeatmap", DrawStatOnHeatmap_IsValid);
		CreatePointInstances_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreatePointInstances");
		CreatePointInstances_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePointInstances_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePointInstances_InPoints_PropertyAddress, CreatePointInstances_FunctionAddress, "InPoints");
		CreatePointInstances_InPoints_Offset = NativeReflectionCached.GetPropertyOffset(CreatePointInstances_FunctionAddress, "InPoints");
		CreatePointInstances_InPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePointInstances_FunctionAddress, "InPoints", Classes.FArrayProperty);
		CreatePointInstances_IsValid = CreatePointInstances_FunctionAddress != IntPtr.Zero && CreatePointInstances_InPoints_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:CreatePointInstances", CreatePointInstances_IsValid);
		CheckHitRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckHitRotation");
		CheckHitRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckHitRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckHitRotation_InRotator_PropertyAddress, CheckHitRotation_FunctionAddress, "InRotator");
		CheckHitRotation_InRotator_Offset = NativeReflectionCached.GetPropertyOffset(CheckHitRotation_FunctionAddress, "InRotator");
		CheckHitRotation_InRotator_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckHitRotation_FunctionAddress, "InRotator", Classes.FStructProperty);
		CheckHitRotation_IsValid = CheckHitRotation_FunctionAddress != IntPtr.Zero && CheckHitRotation_InRotator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:CheckHitRotation", CheckHitRotation_IsValid);
		CheckHitLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckHitLocation");
		CheckHitLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckHitLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckHitLocation_InLocation_PropertyAddress, CheckHitLocation_FunctionAddress, "InLocation");
		CheckHitLocation_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(CheckHitLocation_FunctionAddress, "InLocation");
		CheckHitLocation_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckHitLocation_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckHitLocation_ReturnValue_PropertyAddress, CheckHitLocation_FunctionAddress, "ReturnValue");
		CheckHitLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckHitLocation_FunctionAddress, "ReturnValue");
		CheckHitLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckHitLocation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckHitLocation_IsValid = CheckHitLocation_FunctionAddress != IntPtr.Zero && CheckHitLocation_InLocation_IsValid && CheckHitLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:CheckHitLocation", CheckHitLocation_IsValid);
		CheckAutoMovementCompleted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckAutoMovementCompleted");
		CheckAutoMovementCompleted_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckAutoMovementCompleted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckAutoMovementCompleted_ReturnValue_PropertyAddress, CheckAutoMovementCompleted_FunctionAddress, "ReturnValue");
		CheckAutoMovementCompleted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckAutoMovementCompleted_FunctionAddress, "ReturnValue");
		CheckAutoMovementCompleted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckAutoMovementCompleted_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckAutoMovementCompleted_IsValid = CheckAutoMovementCompleted_FunctionAddress != IntPtr.Zero && CheckAutoMovementCompleted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:CheckAutoMovementCompleted", CheckAutoMovementCompleted_IsValid);
		CaptureViewingInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CaptureViewingInfo");
		CaptureViewingInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(CaptureViewingInfo_FunctionAddress);
		CaptureViewingInfo_IsValid = CaptureViewingInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMovementMonitor:CaptureViewingInfo", CaptureViewingInfo_IsValid);
	}
}
