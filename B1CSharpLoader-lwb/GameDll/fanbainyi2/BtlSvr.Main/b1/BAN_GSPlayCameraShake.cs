using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Play Camera Shake")]
[USharpPath("/Script/b1-Managed.BAN_GSPlayCameraShake")]
public class BAN_GSPlayCameraShake : BAN_GSBase
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

	private static bool bDisableWhenViewTargetIsntPlayer_IsValid;

	private static int bDisableWhenViewTargetIsntPlayer_Offset;

	private static FFieldAddress bDisableWhenViewTargetIsntPlayer_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayCameraShake:CameraShake")]
	public TSubclassOf<UMatineeCameraShake> CameraShake
	{
		get
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:CameraShake");
				return default(TSubclassOf<UMatineeCameraShake>);
			}
			return TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(base.Address, CameraShake_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:CameraShake");
			}
			else
			{
				TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(base.Address, CameraShake_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "WithControl")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayCameraShake:CamShakeScaleByDistCurve")]
	public UCurveFloat CamShakeScaleByDistCurve
	{
		get
		{
			CheckDestroyed();
			if (!CamShakeScaleByDistCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:CamShakeScaleByDistCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, CamShakeScaleByDistCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CamShakeScaleByDistCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:CamShakeScaleByDistCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, CamShakeScaleByDistCurve_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "WithControl")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayCameraShake:EpicenterIsAttach")]
	public bool EpicenterIsAttach
	{
		get
		{
			CheckDestroyed();
			if (!EpicenterIsAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:EpicenterIsAttach");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EpicenterIsAttach_Offset), 0, EpicenterIsAttach_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EpicenterIsAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:EpicenterIsAttach");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EpicenterIsAttach_Offset), 0, EpicenterIsAttach_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "WithControl")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayCameraShake:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("非玩家镜头时禁用震屏")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayCameraShake:bDisableWhenViewTargetIsntPlayer")]
	public bool bDisableWhenViewTargetIsntPlayer
	{
		get
		{
			CheckDestroyed();
			if (!bDisableWhenViewTargetIsntPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:bDisableWhenViewTargetIsntPlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableWhenViewTargetIsntPlayer_Offset), 0, bDisableWhenViewTargetIsntPlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableWhenViewTargetIsntPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayCameraShake:bDisableWhenViewTargetIsntPlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableWhenViewTargetIsntPlayer_Offset), 0, bDisableWhenViewTargetIsntPlayer_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayCameraShake:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(aCharacter);
		if (!(actorStreamingLevelWorld == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld) && (!aCharacter.IsPlayerControlled() || aCharacter.IsLocallyControlled()) && (!bDisableWhenViewTargetIsntPlayer || !(UGSE_EngineFuncLib.GetFirstLocalPlayerController(aCharacter).GetViewTarget() != aCharacter)))
		{
			UMatineeCameraShake uMatineeCameraShake = UBUS_UtilComm.PlayCameraShakeByClass(aCharacter, CameraShake.Value);
			if (!(uMatineeCameraShake == null))
			{
				FVector socketLocation = aCharacter.Mesh.GetSocketLocation(SocketName);
				BGS_EventCollectionCS.Get(aCharacter).Evt_BGS_AddCameraShakeWithControl.Invoke(uMatineeCameraShake, CamShakeScaleByDistCurve, socketLocation, -1f, EpicenterIsAttach, SocketName, aCharacter);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayCameraShake:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSPlayCameraShake bAN_GSPlayCameraShake = GCHelper.Find<BAN_GSPlayCameraShake>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSPlayCameraShake.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSPlayCameraShake");
		CameraShake_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraShake");
		CameraShake_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraShake", Classes.FClassProperty);
		CamShakeScaleByDistCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "CamShakeScaleByDistCurve");
		CamShakeScaleByDistCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CamShakeScaleByDistCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref EpicenterIsAttach_PropertyAddress, intPtr, "EpicenterIsAttach");
		EpicenterIsAttach_Offset = NativeReflection.GetPropertyOffset(intPtr, "EpicenterIsAttach");
		EpicenterIsAttach_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EpicenterIsAttach", Classes.FBoolProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bDisableWhenViewTargetIsntPlayer_PropertyAddress, intPtr, "bDisableWhenViewTargetIsntPlayer");
		bDisableWhenViewTargetIsntPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableWhenViewTargetIsntPlayer");
		bDisableWhenViewTargetIsntPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableWhenViewTargetIsntPlayer", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayCameraShake:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSPlayCameraShake()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSPlayCameraShake)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSPlayCameraShake));
	}
}
