using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("BAN DispLib Play Camera Shake")]
[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake")]
public class BAN_DispLibPlayCameraShake : BAN_GSBase
{
	private static bool EditorActive_IsValid;

	private static int EditorActive_Offset;

	private static FFieldAddress EditorActive_PropertyAddress;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool CameraShake_IsValid;

	private static int CameraShake_Offset;

	private static bool Override_Oscillation_Duration_IsValid;

	private static int Override_Oscillation_Duration_Offset;

	private static bool ForceApply_IsValid;

	private static int ForceApply_Offset;

	private static FFieldAddress ForceApply_PropertyAddress;

	private static bool CustomScaleCurve_IsValid;

	private static int CustomScaleCurve_Offset;

	private static bool UseDistanceDamping_IsValid;

	private static int UseDistanceDamping_Offset;

	private static FFieldAddress UseDistanceDamping_PropertyAddress;

	private static bool AttachedTarget_IsValid;

	private static int AttachedTarget_Offset;

	private static FFieldAddress AttachedTarget_PropertyAddress;

	private static bool AttachedTargetSocketName_IsValid;

	private static int AttachedTargetSocketName_Offset;

	private static bool CamShakeScaleByDistCurve_IsValid;

	private static int CamShakeScaleByDistCurve_Offset;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Editor Active")]
	[UProperty]
	[UMeta(MD.ToolTip, "关闭后编辑器下不会播放当前效果，不影响运行时")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:EditorActive")]
	public bool EditorActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:EditorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:EditorActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("延迟时间")]
	[UMeta(MD.ToolTip, "优先调整Notify位置来实现延迟，只有Notify靠近montage末尾还希望延迟时再使用此参数")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:Delay")]
	public float Delay
	{
		get
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:Delay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Delay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:Delay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Delay_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Camera Shake")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:CameraShake")]
	public TSubclassOf<UMatineeCameraShake> CameraShake
	{
		get
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:CameraShake");
				return default(TSubclassOf<UMatineeCameraShake>);
			}
			return TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(base.Address, CameraShake_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:CameraShake");
			}
			else
			{
				TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(base.Address, CameraShake_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("Override Duration")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:Override_Oscillation_Duration")]
	public float Override_Oscillation_Duration
	{
		get
		{
			CheckDestroyed();
			if (!Override_Oscillation_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:Override_Oscillation_Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Override_Oscillation_Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Override_Oscillation_Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:Override_Oscillation_Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Override_Oscillation_Duration_Offset), value);
			}
		}
	}

	[DisplayName("忽略保护时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:ForceApply")]
	public bool ForceApply
	{
		get
		{
			CheckDestroyed();
			if (!ForceApply_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:ForceApply");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceApply_Offset), 0, ForceApply_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceApply_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:ForceApply");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceApply_Offset), 0, ForceApply_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("强度缩放曲线")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:CustomScaleCurve")]
	public BUC_DispLibUtil_DBCPCurveScalar CustomScaleCurve
	{
		get
		{
			CheckDestroyed();
			if (!CustomScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:CustomScaleCurve");
				return default(BUC_DispLibUtil_DBCPCurveScalar);
			}
			return BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(base.Address, CustomScaleCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:CustomScaleCurve");
			}
			else
			{
				BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(base.Address, CustomScaleCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("启用距离衰减")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:UseDistanceDamping")]
	public bool UseDistanceDamping
	{
		get
		{
			CheckDestroyed();
			if (!UseDistanceDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:UseDistanceDamping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseDistanceDamping_Offset), 0, UseDistanceDamping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseDistanceDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:UseDistanceDamping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseDistanceDamping_Offset), 0, UseDistanceDamping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("跟随插槽更新中心位置")]
	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:AttachedTarget")]
	public bool AttachedTarget
	{
		get
		{
			CheckDestroyed();
			if (!AttachedTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:AttachedTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachedTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:AttachedTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("目标插槽")]
	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:AttachedTargetSocketName")]
	public FName AttachedTargetSocketName
	{
		get
		{
			CheckDestroyed();
			if (!AttachedTargetSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:AttachedTargetSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachedTargetSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachedTargetSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:AttachedTargetSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachedTargetSocketName_Offset), value);
			}
		}
	}

	[DisplayName("衰减曲线(0-1)")]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:CamShakeScaleByDistCurve")]
	public UCurveFloat CamShakeScaleByDistCurve
	{
		get
		{
			CheckDestroyed();
			if (!CamShakeScaleByDistCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:CamShakeScaleByDistCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, CamShakeScaleByDistCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CamShakeScaleByDistCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:CamShakeScaleByDistCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, CamShakeScaleByDistCurve_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[DisplayName("最大距离")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:MaxDistance")]
	public float MaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:MaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_DispLibPlayCameraShake:MaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDistance_Offset), value);
			}
		}
	}

	protected bool ValidateParameters()
	{
		if (CameraShake == default(TSubclassOf<UMatineeCameraShake>))
		{
			return false;
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_DispLibPlayCameraShake:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		if (ValidateParameters())
		{
			PlayCameraShakeByDBC(meshComp, animation);
		}
	}

	protected bool PlayCameraShakeByDBC(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		return Runtime_DoCameraShakeByDBC(MeshComp, Animation);
	}

	private bool EditorCustomScene_DoCameraShakeByDBC(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		return true;
	}

	private bool EditorGame_DoCameraShakeByDBC(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		return Runtime_DoCameraShakeByDBC(MeshComp, Animation);
	}

	private bool Runtime_DoCameraShakeByDBC(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		if (!BGU_DispLibDataUtil.GetCurActiveMontageeUniqueID(MeshComp, Animation, out var _))
		{
			return false;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(MeshComp.GetOwner());
		if (actorStreamingLevelWorld == null)
		{
			return false;
		}
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			return false;
		}
		UMatineeCameraShake uMatineeCameraShake = UBUS_UtilComm.PlayCameraShakeByClass(MeshComp.GetOwner(), CameraShake.Value);
		if (uMatineeCameraShake == null)
		{
			return false;
		}
		AActor owner = MeshComp.GetOwner();
		BGS_EventCollectionCS.Get(owner).Evt_BGS_AddCameraShakeWithControl.Invoke(uMatineeCameraShake, CamShakeScaleByDistCurve, BGUFuncLibActorTransformCS.BGUGetActorLocation(owner), Override_Oscillation_Duration, AttachedTarget, AttachedTargetSocketName, owner);
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_DispLibPlayCameraShake:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_DispLibPlayCameraShake bAN_DispLibPlayCameraShake = GCHelper.Find<BAN_DispLibPlayCameraShake>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_DispLibPlayCameraShake.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_DispLibPlayCameraShake");
		NativeReflection.GetPropertyRef(ref EditorActive_PropertyAddress, intPtr, "EditorActive");
		EditorActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorActive");
		EditorActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorActive", Classes.FBoolProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		CameraShake_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraShake");
		CameraShake_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraShake", Classes.FClassProperty);
		Override_Oscillation_Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Override_Oscillation_Duration");
		Override_Oscillation_Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Override_Oscillation_Duration", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ForceApply_PropertyAddress, intPtr, "ForceApply");
		ForceApply_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceApply");
		ForceApply_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceApply", Classes.FBoolProperty);
		CustomScaleCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomScaleCurve");
		CustomScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomScaleCurve", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UseDistanceDamping_PropertyAddress, intPtr, "UseDistanceDamping");
		UseDistanceDamping_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseDistanceDamping");
		UseDistanceDamping_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseDistanceDamping", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AttachedTarget_PropertyAddress, intPtr, "AttachedTarget");
		AttachedTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTarget");
		AttachedTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTarget", Classes.FBoolProperty);
		AttachedTargetSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetSocketName");
		AttachedTargetSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetSocketName", Classes.FNameProperty);
		CamShakeScaleByDistCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "CamShakeScaleByDistCurve");
		CamShakeScaleByDistCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CamShakeScaleByDistCurve", Classes.FObjectProperty);
		MaxDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_DispLibPlayCameraShake:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_DispLibPlayCameraShake()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_DispLibPlayCameraShake)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_DispLibPlayCameraShake));
	}
}
