using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake")]
public struct BUC_DispLibDBC_PlayCameraShake
{
	[EditAnywhere]
	[DisplayName("延迟时间")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:Delay")]
	public float Delay;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:CameraShake")]
	public TSubclassOf<UMatineeCameraShake> CameraShake;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Override Duration")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:Override_Oscillation_Duration")]
	public float Override_Oscillation_Duration;

	[UProperty]
	[DisplayName("忽略保护时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:ForceApply")]
	public bool ForceApply;

	[DisplayName("强度缩放曲线")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:CustomScaleCurve")]
	public BUC_DispLibUtil_DBCPCurveScalar CustomScaleCurve;

	[DisplayName("启用距离衰减")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:UseDistanceDamping")]
	public bool UseDistanceDamping;

	[UProperty]
	[EditAnywhere]
	[DisplayName("跟随插槽更新中心位置")]
	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:AttachedTarget")]
	public bool AttachedTarget;

	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标插槽")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:AttachedTargetSocketName")]
	public FName AttachedTargetSocketName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("衰减曲线(0-1)")]
	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:CamShakeScaleByDistCurve")]
	public UCurveFloat CamShakeScaleByDistCurve;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("最大距离")]
	[UMeta(MDProp.EditCondition, "UseDistanceDamping")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:MaxDistance")]
	public float MaxDistance;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[DisplayName("暂停优先级")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake:PausePriority")]
	public int PausePriority;

	private static int BUC_DispLibDBC_PlayCameraShake_StructSize;

	private static int BUC_DispLibDBC_PlayCameraShake_IsValid;

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

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	public BUC_DispLibDBC_PlayCameraShake SetCustomData(float _Delay, TSubclassOf<UMatineeCameraShake> _CameraShake, float _Override_Oscillation_Duration, bool _ForceApply, BUC_DispLibUtil_DBCPCurveScalar _CustomScaleCurve, bool _UseDistanceDamping, bool _AttachedTarget, FName _AttachedTargetSocketName, UCurveFloat _CamShakeScaleByDistCurve, float _MaxDistance)
	{
		Delay = _Delay;
		CameraShake = _CameraShake;
		Override_Oscillation_Duration = _Override_Oscillation_Duration;
		CustomScaleCurve = _CustomScaleCurve;
		ForceApply = _ForceApply;
		UseDistanceDamping = _UseDistanceDamping;
		AttachedTarget = _AttachedTarget;
		AttachedTargetSocketName = _AttachedTargetSocketName;
		CamShakeScaleByDistCurve = _CamShakeScaleByDistCurve;
		MaxDistance = _MaxDistance;
		return this;
	}

	public BUC_DispLibDBC_PlayCameraShake Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_PlayCameraShake FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_PlayCameraShake(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_PlayCameraShake value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_PlayCameraShake FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_PlayCameraShake(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayCameraShake_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_PlayCameraShake value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayCameraShake_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayCameraShake_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(nativeStruct, CameraShake_Offset), CameraShake);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Override_Oscillation_Duration_Offset), Override_Oscillation_Duration);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForceApply_Offset), 0, ForceApply_PropertyAddress.Address, ForceApply);
		BUC_DispLibUtil_DBCPCurveScalar.ToNative(IntPtr.Add(nativeStruct, CustomScaleCurve_Offset), CustomScaleCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseDistanceDamping_Offset), 0, UseDistanceDamping_PropertyAddress.Address, UseDistanceDamping);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address, AttachedTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset), AttachedTargetSocketName);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, CamShakeScaleByDistCurve_Offset), CamShakeScaleByDistCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Offset), MaxDistance);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
	}

	public BUC_DispLibDBC_PlayCameraShake(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayCameraShake_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake");
			Delay = 0f;
			CameraShake = default(TSubclassOf<UMatineeCameraShake>);
			Override_Oscillation_Duration = 0f;
			ForceApply = false;
			CustomScaleCurve = default(BUC_DispLibUtil_DBCPCurveScalar);
			UseDistanceDamping = false;
			AttachedTarget = false;
			AttachedTargetSocketName = default(FName);
			CamShakeScaleByDistCurve = null;
			MaxDistance = 0f;
			PausePriority = 0;
		}
		else
		{
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			CameraShake = TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(nativeStruct, CameraShake_Offset));
			Override_Oscillation_Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Override_Oscillation_Duration_Offset));
			ForceApply = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForceApply_Offset), 0, ForceApply_PropertyAddress.Address);
			CustomScaleCurve = BUC_DispLibUtil_DBCPCurveScalar.FromNative(IntPtr.Add(nativeStruct, CustomScaleCurve_Offset));
			UseDistanceDamping = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseDistanceDamping_Offset), 0, UseDistanceDamping_PropertyAddress.Address);
			AttachedTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address);
			AttachedTargetSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset));
			CamShakeScaleByDistCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, CamShakeScaleByDistCurve_Offset));
			MaxDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake");
		BUC_DispLibDBC_PlayCameraShake_StructSize = NativeReflection.GetStructSize(intPtr);
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
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		BUC_DispLibDBC_PlayCameraShake_IsValid = ((intPtr != IntPtr.Zero && Delay_IsValid && CameraShake_IsValid && Override_Oscillation_Duration_IsValid && ForceApply_IsValid && CustomScaleCurve_IsValid && UseDistanceDamping_IsValid && AttachedTarget_IsValid && AttachedTargetSocketName_IsValid && CamShakeScaleByDistCurve_IsValid && MaxDistance_IsValid && PausePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_PlayCameraShake", (byte)BUC_DispLibDBC_PlayCameraShake_IsValid != 0);
	}

	static BUC_DispLibDBC_PlayCameraShake()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_PlayCameraShake)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_PlayCameraShake));
	}
}
