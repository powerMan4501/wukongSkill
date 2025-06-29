using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS GSPlayCameraShake")]
[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake")]
public class BANS_GSPlayCameraShake : BANS_GSBase
{
	private static bool CameraShake_IsValid;

	private static int CameraShake_Offset;

	private static bool CamShakeScaleByDistCurve_IsValid;

	private static int CamShakeScaleByDistCurve_Offset;

	private static bool EpicenterIsAttach_IsValid;

	private static int EpicenterIsAttach_Offset;

	private static FFieldAddress EpicenterIsAttach_PropertyAddress;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool StopWhenNotifyEnded_IsValid;

	private static int StopWhenNotifyEnded_Offset;

	private static FFieldAddress StopWhenNotifyEnded_PropertyAddress;

	private static bool Stop_Immediately_IsValid;

	private static int Stop_Immediately_Offset;

	private static FFieldAddress Stop_Immediately_PropertyAddress;

	private static bool bDisableWhenViewTargetIsntPlayer_IsValid;

	private static int bDisableWhenViewTargetIsntPlayer_Offset;

	private static FFieldAddress bDisableWhenViewTargetIsntPlayer_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:CameraShake")]
	public TSubclassOf<UMatineeCameraShake> CameraShake
	{
		get
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:CameraShake");
				return default(TSubclassOf<UMatineeCameraShake>);
			}
			return TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(base.Address, CameraShake_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:CameraShake");
			}
			else
			{
				TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(base.Address, CameraShake_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("振幅随距离缩放曲线")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:CamShakeScaleByDistCurve")]
	public UCurveFloat CamShakeScaleByDistCurve
	{
		get
		{
			CheckDestroyed();
			if (!CamShakeScaleByDistCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:CamShakeScaleByDistCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, CamShakeScaleByDistCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CamShakeScaleByDistCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:CamShakeScaleByDistCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, CamShakeScaleByDistCurve_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:EpicenterIsAttach")]
	public bool EpicenterIsAttach
	{
		get
		{
			CheckDestroyed();
			if (!EpicenterIsAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:EpicenterIsAttach");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EpicenterIsAttach_Offset), 0, EpicenterIsAttach_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EpicenterIsAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:EpicenterIsAttach");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EpicenterIsAttach_Offset), 0, EpicenterIsAttach_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[DisplayName("NotifyState结束时停止震动")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:StopWhenNotifyEnded")]
	public bool StopWhenNotifyEnded
	{
		get
		{
			CheckDestroyed();
			if (!StopWhenNotifyEnded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:StopWhenNotifyEnded");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StopWhenNotifyEnded_Offset), 0, StopWhenNotifyEnded_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StopWhenNotifyEnded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:StopWhenNotifyEnded");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StopWhenNotifyEnded_Offset), 0, StopWhenNotifyEnded_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "StopWhenNotifyEnded")]
	[DisplayName("停止时立刻停止")]
	[Tooltip("true:立刻停止； false:根据CamShake中的配置淡出")]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:Stop_Immediately")]
	public bool Stop_Immediately
	{
		get
		{
			CheckDestroyed();
			if (!Stop_Immediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:Stop_Immediately");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Stop_Immediately_Offset), 0, Stop_Immediately_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Stop_Immediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:Stop_Immediately");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Stop_Immediately_Offset), 0, Stop_Immediately_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("非玩家镜头时禁用震屏")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:bDisableWhenViewTargetIsntPlayer")]
	public bool bDisableWhenViewTargetIsntPlayer
	{
		get
		{
			CheckDestroyed();
			if (!bDisableWhenViewTargetIsntPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:bDisableWhenViewTargetIsntPlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableWhenViewTargetIsntPlayer_Offset), 0, bDisableWhenViewTargetIsntPlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableWhenViewTargetIsntPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayCameraShake:bDisableWhenViewTargetIsntPlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableWhenViewTargetIsntPlayer_Offset), 0, bDisableWhenViewTargetIsntPlayer_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		StopWhenNotifyEnded = true;
		Stop_Immediately = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(aCharacter);
		if (!(actorStreamingLevelWorld == null) && (!bDisableWhenViewTargetIsntPlayer || !(UGSE_EngineFuncLib.GetFirstLocalPlayerController(aCharacter).GetViewTarget() != aCharacter)) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			UMatineeCameraShake uMatineeCameraShake = UBUS_UtilComm.PlayCameraShakeByClass(aCharacter, CameraShake.Value);
			if (!(uMatineeCameraShake == null))
			{
				FVector socketLocation = aCharacter.Mesh.GetSocketLocation(SocketName);
				int uniqueID = (int)GetUniqueID();
				float override_Duration = (StopWhenNotifyEnded ? TotalDuration : (-1f));
				BGS_EventCollectionCS.Get(aCharacter).Evt_BGS_AddCameraShakeWithControl.Invoke(uMatineeCameraShake, CamShakeScaleByDistCurve, socketLocation, override_Duration, EpicenterIsAttach, SocketName, aCharacter, uniqueID);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPlayCameraShake:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (StopWhenNotifyEnded)
		{
			ACharacter aCharacter = NotifyParam.owner as ACharacter;
			if (!(aCharacter == null) && (!bDisableWhenViewTargetIsntPlayer || !(UGSE_EngineFuncLib.GetFirstLocalPlayerController(aCharacter).GetViewTarget() != aCharacter)))
			{
				int uniqueID = (int)GetUniqueID();
				BGS_EventCollectionCS.Get(aCharacter).Evt_BGS_StopCamShakeByReqID.Invoke(uniqueID, Stop_Immediately);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPlayCameraShake:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSPlayCameraShake bANS_GSPlayCameraShake = GCHelper.Find<BANS_GSPlayCameraShake>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSPlayCameraShake.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPlayCameraShake:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSPlayCameraShake bANS_GSPlayCameraShake = GCHelper.Find<BANS_GSPlayCameraShake>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSPlayCameraShake.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPlayCameraShake:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSPlayCameraShake bANS_GSPlayCameraShake = GCHelper.Find<BANS_GSPlayCameraShake>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSPlayCameraShake.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSPlayCameraShake");
		CameraShake_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraShake");
		CameraShake_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraShake", Classes.FClassProperty);
		CamShakeScaleByDistCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "CamShakeScaleByDistCurve");
		CamShakeScaleByDistCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CamShakeScaleByDistCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref EpicenterIsAttach_PropertyAddress, intPtr, "EpicenterIsAttach");
		EpicenterIsAttach_Offset = NativeReflection.GetPropertyOffset(intPtr, "EpicenterIsAttach");
		EpicenterIsAttach_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EpicenterIsAttach", Classes.FBoolProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref StopWhenNotifyEnded_PropertyAddress, intPtr, "StopWhenNotifyEnded");
		StopWhenNotifyEnded_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopWhenNotifyEnded");
		StopWhenNotifyEnded_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopWhenNotifyEnded", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Stop_Immediately_PropertyAddress, intPtr, "Stop_Immediately");
		Stop_Immediately_Offset = NativeReflection.GetPropertyOffset(intPtr, "Stop_Immediately");
		Stop_Immediately_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Stop_Immediately", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableWhenViewTargetIsntPlayer_PropertyAddress, intPtr, "bDisableWhenViewTargetIsntPlayer");
		bDisableWhenViewTargetIsntPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableWhenViewTargetIsntPlayer");
		bDisableWhenViewTargetIsntPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableWhenViewTargetIsntPlayer", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPlayCameraShake:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPlayCameraShake:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPlayCameraShake:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSPlayCameraShake()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSPlayCameraShake)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSPlayCameraShake));
	}
}
