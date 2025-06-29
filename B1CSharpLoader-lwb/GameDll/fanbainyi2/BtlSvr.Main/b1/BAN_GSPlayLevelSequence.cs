using System;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN PlayLevelSequence")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence")]
internal class BAN_GSPlayLevelSequence : BAN_GSBase
{
	private static bool SequenceId_IsValid;

	private static int SequenceId_Offset;

	private static bool bUsePlayerCamera_IsValid;

	private static int bUsePlayerCamera_Offset;

	private static FFieldAddress bUsePlayerCamera_PropertyAddress;

	private static bool StartTime_IsValid;

	private static int StartTime_Offset;

	private static bool bDisableMovementInput_IsValid;

	private static int bDisableMovementInput_Offset;

	private static FFieldAddress bDisableMovementInput_PropertyAddress;

	private static bool bDisableLookAtInput_IsValid;

	private static int bDisableLookAtInput_Offset;

	private static FFieldAddress bDisableLookAtInput_PropertyAddress;

	private static bool bUseCrane_IsValid;

	private static int bUseCrane_Offset;

	private static FFieldAddress bUseCrane_PropertyAddress;

	private static bool bUseRail_IsValid;

	private static int bUseRail_Offset;

	private static FFieldAddress bUseRail_PropertyAddress;

	private static bool bHidePlayer_IsValid;

	private static int bHidePlayer_Offset;

	private static FFieldAddress bHidePlayer_PropertyAddress;

	private static bool bHideHud_IsValid;

	private static int bHideHud_Offset;

	private static FFieldAddress bHideHud_PropertyAddress;

	private static bool bDisableCameraCuts_IsValid;

	private static int bDisableCameraCuts_Offset;

	private static FFieldAddress bDisableCameraCuts_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[Category("Play")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:SequenceId")]
	public int SequenceId
	{
		get
		{
			CheckDestroyed();
			if (!SequenceId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:SequenceId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SequenceId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequenceId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:SequenceId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SequenceId_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Tooltip("不使用Sequence内的摄像机")]
	[DisplayName("使用主角摄像机")]
	[BlueprintReadWrite]
	[Category("Play")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:bUsePlayerCamera")]
	public bool bUsePlayerCamera
	{
		get
		{
			CheckDestroyed();
			if (!bUsePlayerCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bUsePlayerCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUsePlayerCamera_Offset), 0, bUsePlayerCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUsePlayerCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bUsePlayerCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUsePlayerCamera_Offset), 0, bUsePlayerCamera_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Play")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:StartTime")]
	public float StartTime
	{
		get
		{
			CheckDestroyed();
			if (!StartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:StartTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:StartTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:bDisableMovementInput")]
	public bool bDisableMovementInput
	{
		get
		{
			CheckDestroyed();
			if (!bDisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bDisableMovementInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableMovementInput_Offset), 0, bDisableMovementInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bDisableMovementInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableMovementInput_Offset), 0, bDisableMovementInput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:bDisableLookAtInput")]
	public bool bDisableLookAtInput
	{
		get
		{
			CheckDestroyed();
			if (!bDisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bDisableLookAtInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableLookAtInput_Offset), 0, bDisableLookAtInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bDisableLookAtInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableLookAtInput_Offset), 0, bDisableLookAtInput_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Camera")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:bUseCrane")]
	public bool bUseCrane
	{
		get
		{
			CheckDestroyed();
			if (!bUseCrane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bUseCrane");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseCrane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bUseCrane");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:bUseRail")]
	public bool bUseRail
	{
		get
		{
			CheckDestroyed();
			if (!bUseRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bUseRail");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bUseRail");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:bHidePlayer")]
	public bool bHidePlayer
	{
		get
		{
			CheckDestroyed();
			if (!bHidePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bHidePlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHidePlayer_Offset), 0, bHidePlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHidePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bHidePlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHidePlayer_Offset), 0, bHidePlayer_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[Category("Camera")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:bHideHud")]
	public bool bHideHud
	{
		get
		{
			CheckDestroyed();
			if (!bHideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bHideHud");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHideHud_Offset), 0, bHideHud_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bHideHud");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHideHud_Offset), 0, bHideHud_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:bDisableCameraCuts")]
	public bool bDisableCameraCuts
	{
		get
		{
			CheckDestroyed();
			if (!bDisableCameraCuts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bDisableCameraCuts");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableCameraCuts_Offset), 0, bDisableCameraCuts_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableCameraCuts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayLevelSequence:bDisableCameraCuts");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableCameraCuts_Offset), 0, bDisableCameraCuts_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayLevelSequence:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		FMovieSceneSequencePlaybackSettings playbackSettings = new FMovieSceneSequencePlaybackSettings
		{
			AutoPlay = false,
			PlayRate = 1f,
			StartTime = StartTime,
			RandomStartTime = false,
			RestoreState = false,
			DisableMovementInput = bDisableMovementInput,
			DisableLookAtInput = bDisableLookAtInput,
			HidePlayer = bHidePlayer,
			HideHud = bHideHud,
			DisableCameraCuts = bDisableCameraCuts,
			PauseAtEnd = false
		};
		FLevelSequenceCameraSettings cameraSettings = new FLevelSequenceCameraSettings
		{
			AspectRatioAxisConstraint = EAspectRatioAxisConstraint.AspectRatio_MaintainXFOV,
			OverrideAspectRatioAxisConstraint = false
		};
		FMovieGraphPlaySettings inPlaySettings = new FMovieGraphPlaySettings
		{
			PlaybackSettings = playbackSettings,
			CameraSettings = cameraSettings,
			bUsePlayerCamera = bUsePlayerCamera
		};
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(NotifyParam.owner);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_PlayMovieInstance.Invoke(SequenceId, MovieInstance.Create(NotifyParam.owner, SequenceId, inPlaySettings));
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayLevelSequence:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSPlayLevelSequence bAN_GSPlayLevelSequence = GCHelper.Find<b1.BAN_GSPlayLevelSequence>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSPlayLevelSequence.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayLevelSequence:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSPlayLevelSequence bAN_GSPlayLevelSequence = GCHelper.Find<b1.BAN_GSPlayLevelSequence>(obj);
		bool value = bAN_GSPlayLevelSequence.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSPlayLevelSequence");
		SequenceId_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceId");
		SequenceId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bUsePlayerCamera_PropertyAddress, intPtr, "bUsePlayerCamera");
		bUsePlayerCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUsePlayerCamera");
		bUsePlayerCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUsePlayerCamera", Classes.FBoolProperty);
		StartTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartTime");
		StartTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bDisableMovementInput_PropertyAddress, intPtr, "bDisableMovementInput");
		bDisableMovementInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableMovementInput");
		bDisableMovementInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableMovementInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableLookAtInput_PropertyAddress, intPtr, "bDisableLookAtInput");
		bDisableLookAtInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableLookAtInput");
		bDisableLookAtInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableLookAtInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseCrane_PropertyAddress, intPtr, "bUseCrane");
		bUseCrane_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCrane");
		bUseCrane_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCrane", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseRail_PropertyAddress, intPtr, "bUseRail");
		bUseRail_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseRail");
		bUseRail_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseRail", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHidePlayer_PropertyAddress, intPtr, "bHidePlayer");
		bHidePlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHidePlayer");
		bHidePlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHidePlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHideHud_PropertyAddress, intPtr, "bHideHud");
		bHideHud_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHideHud");
		bHideHud_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHideHud", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableCameraCuts_PropertyAddress, intPtr, "bDisableCameraCuts");
		bDisableCameraCuts_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableCameraCuts");
		bDisableCameraCuts_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableCameraCuts", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayLevelSequence:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayLevelSequence:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSPlayLevelSequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSPlayLevelSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSPlayLevelSequence));
	}
}
