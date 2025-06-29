using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUChapterActor")]
public class BGUChapterActor : AActor
{
	private static bool IsCheckBorder_IsValid;

	private static int IsCheckBorder_Offset;

	private static FFieldAddress IsCheckBorder_PropertyAddress;

	private static bool CameraShake_IsValid;

	private static int CameraShake_Offset;

	private static bool CameraShakeScaleBase_IsValid;

	private static int CameraShakeScaleBase_Offset;

	private static bool CameraRoamPowerMax_IsValid;

	private static int CameraRoamPowerMax_Offset;

	private static bool CameraRoamPowerCoe_IsValid;

	private static int CameraRoamPowerCoe_Offset;

	private static bool CameraRoamPowerCoe_Gamepad_IsValid;

	private static int CameraRoamPowerCoe_Gamepad_Offset;

	private static bool CameraScalePowerCoe_IsValid;

	private static int CameraScalePowerCoe_Offset;

	private static bool CameraRoamAccelerationCoe_IsValid;

	private static int CameraRoamAccelerationCoe_Offset;

	private static bool CameraRoamDecelerationCoe_IsValid;

	private static int CameraRoamDecelerationCoe_Offset;

	private static bool CameraBorderDecelerationCoe_IsValid;

	private static int CameraBorderDecelerationCoe_Offset;

	private static bool CameraRoamPowerDirSpeed_IsValid;

	private static int CameraRoamPowerDirSpeed_Offset;

	private static bool CameraScaleMin_IsValid;

	private static int CameraScaleMin_Offset;

	private static bool CameraScaleMax_IsValid;

	private static int CameraScaleMax_Offset;

	private static bool FocusDistaceBase_IsValid;

	private static int FocusDistaceBase_Offset;

	private static bool BorderMap_IsValid;

	private static int BorderMap_Offset;

	private static FFieldAddress BorderMap_PropertyAddress;

	private TMapReadWriteMarshaler<FName, float> BorderMap_Marshaler;

	private static bool CheckCameraRoamBorderDis_IsValid;

	private static int CheckCameraRoamBorderDis_Offset;

	private static bool CameraLightRandomRange_IsValid;

	private static int CameraLightRandomRange_Offset;

	private static bool CameraLightBase_IsValid;

	private static int CameraLightBase_Offset;

	private static bool CameraLightRandomTime_IsValid;

	private static int CameraLightRandomTime_Offset;

	private static bool StayTimeBeforeNear_IsValid;

	private static int StayTimeBeforeNear_Offset;

	private static bool NearDistance_IsValid;

	private static int NearDistance_Offset;

	private static bool NearSpeed_IsValid;

	private static int NearSpeed_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("是否检测边界")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:IsCheckBorder")]
	public bool IsCheckBorder
	{
		get
		{
			CheckDestroyed();
			if (!IsCheckBorder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:IsCheckBorder");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCheckBorder_Offset), 0, IsCheckBorder_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCheckBorder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:IsCheckBorder");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCheckBorder_Offset), 0, IsCheckBorder_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("CameraShake")]
	[Category("GSProperty|CameraShake")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraShake")]
	public TSubclassOf<UCameraShakeBase> CameraShake
	{
		get
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraShake");
				return default(TSubclassOf<UCameraShakeBase>);
			}
			return TSubclassOfMarshaler<UCameraShakeBase>.FromNative(IntPtr.Add(base.Address, CameraShake_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraShake");
			}
			else
			{
				TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(base.Address, CameraShake_Offset), value);
			}
		}
	}

	[Category("GSProperty|CameraShake")]
	[Tooltip("与力的比值，越大Scale越大")]
	[DisplayName("CameraShakeScale基准值")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraShakeScaleBase")]
	public float CameraShakeScaleBase
	{
		get
		{
			CheckDestroyed();
			if (!CameraShakeScaleBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraShakeScaleBase");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraShakeScaleBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShakeScaleBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraShakeScaleBase");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraShakeScaleBase_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|漫游")]
	[DisplayName("鼠标平面移动驱动力上限")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerMax")]
	public float CameraRoamPowerMax
	{
		get
		{
			CheckDestroyed();
			if (!CameraRoamPowerMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraRoamPowerMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraRoamPowerMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraRoamPowerMax_Offset), value);
			}
		}
	}

	[DisplayName("鼠标平面移动驱动力系数")]
	[Category("GSProperty|漫游")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerCoe")]
	public float CameraRoamPowerCoe
	{
		get
		{
			CheckDestroyed();
			if (!CameraRoamPowerCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerCoe");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraRoamPowerCoe_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraRoamPowerCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerCoe");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraRoamPowerCoe_Offset), value);
			}
		}
	}

	[DisplayName("手柄平面移动驱动力系数")]
	[Category("GSProperty|漫游")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerCoe_Gamepad")]
	public float CameraRoamPowerCoe_Gamepad
	{
		get
		{
			CheckDestroyed();
			if (!CameraRoamPowerCoe_Gamepad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerCoe_Gamepad");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraRoamPowerCoe_Gamepad_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraRoamPowerCoe_Gamepad_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerCoe_Gamepad");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraRoamPowerCoe_Gamepad_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|漫游")]
	[DisplayName("缩放驱动力系数")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraScalePowerCoe")]
	public float CameraScalePowerCoe
	{
		get
		{
			CheckDestroyed();
			if (!CameraScalePowerCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraScalePowerCoe");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraScalePowerCoe_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraScalePowerCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraScalePowerCoe");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraScalePowerCoe_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("漫游加速度系数")]
	[UMeta(MDProp.ClampMin, 0)]
	[Category("GSProperty|漫游")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraRoamAccelerationCoe")]
	public float CameraRoamAccelerationCoe
	{
		get
		{
			CheckDestroyed();
			if (!CameraRoamAccelerationCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamAccelerationCoe");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraRoamAccelerationCoe_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraRoamAccelerationCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamAccelerationCoe");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraRoamAccelerationCoe_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|漫游")]
	[DisplayName("漫游减速度系数")]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraRoamDecelerationCoe")]
	public float CameraRoamDecelerationCoe
	{
		get
		{
			CheckDestroyed();
			if (!CameraRoamDecelerationCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamDecelerationCoe");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraRoamDecelerationCoe_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraRoamDecelerationCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamDecelerationCoe");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraRoamDecelerationCoe_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("靠近边界减速度系数")]
	[EditAnywhere]
	[Category("GSProperty|漫游")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraBorderDecelerationCoe")]
	public float CameraBorderDecelerationCoe
	{
		get
		{
			CheckDestroyed();
			if (!CameraBorderDecelerationCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraBorderDecelerationCoe");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraBorderDecelerationCoe_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBorderDecelerationCoe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraBorderDecelerationCoe");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraBorderDecelerationCoe_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("漫游方向变化lerpSpeed")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|漫游")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerDirSpeed")]
	public float CameraRoamPowerDirSpeed
	{
		get
		{
			CheckDestroyed();
			if (!CameraRoamPowerDirSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerDirSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraRoamPowerDirSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraRoamPowerDirSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraRoamPowerDirSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraRoamPowerDirSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|漫游")]
	[DisplayName("缩放值Min")]
	[Tooltip("X值镜头位置下限，Y值镜头Focus Distance下限,Z值光照强度下限")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraScaleMin")]
	public FVector CameraScaleMin
	{
		get
		{
			CheckDestroyed();
			if (!CameraScaleMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraScaleMin");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CameraScaleMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraScaleMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraScaleMin");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CameraScaleMin_Offset), value);
			}
		}
	}

	[Tooltip("X值镜头位置上限，Y值镜头Focus Distance上限,Z值 光照强度上限")]
	[DisplayName("缩放值Max")]
	[Category("GSProperty|漫游")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraScaleMax")]
	public FVector CameraScaleMax
	{
		get
		{
			CheckDestroyed();
			if (!CameraScaleMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraScaleMax");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CameraScaleMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraScaleMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraScaleMax");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CameraScaleMax_Offset), value);
			}
		}
	}

	[DisplayName("FocusDistace基准值")]
	[Category("GSProperty|漫游")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:FocusDistaceBase")]
	public float FocusDistaceBase
	{
		get
		{
			CheckDestroyed();
			if (!FocusDistaceBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:FocusDistaceBase");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FocusDistaceBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FocusDistaceBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:FocusDistaceBase");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FocusDistaceBase_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty|漫游")]
	[EditAnywhere]
	[DisplayName("缩放边界平移参数")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:BorderMap")]
	public TMapReadWrite<FName, float> BorderMap
	{
		get
		{
			CheckDestroyed();
			if (!BorderMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:BorderMap");
				return null;
			}
			if (BorderMap_Marshaler == null)
			{
				BorderMap_Marshaler = new TMapReadWriteMarshaler<FName, float>(1, BorderMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return BorderMap_Marshaler.FromNative(IntPtr.Add(base.Address, BorderMap_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|漫游")]
	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("边界检测距离")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CheckCameraRoamBorderDis")]
	public float CheckCameraRoamBorderDis
	{
		get
		{
			CheckDestroyed();
			if (!CheckCameraRoamBorderDis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CheckCameraRoamBorderDis");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CheckCameraRoamBorderDis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckCameraRoamBorderDis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CheckCameraRoamBorderDis");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CheckCameraRoamBorderDis_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|灯光")]
	[DisplayName("灯光强度RandomRange")]
	[Tooltip("X值下限，Y值上限")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraLightRandomRange")]
	public FVector2D CameraLightRandomRange
	{
		get
		{
			CheckDestroyed();
			if (!CameraLightRandomRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraLightRandomRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, CameraLightRandomRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLightRandomRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraLightRandomRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, CameraLightRandomRange_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("灯光强度基准值")]
	[Category("GSProperty|灯光")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraLightBase")]
	public float CameraLightBase
	{
		get
		{
			CheckDestroyed();
			if (!CameraLightBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraLightBase");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraLightBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLightBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraLightBase");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraLightBase_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|灯光")]
	[DisplayName("灯光强度RandomTime")]
	[Tooltip("X值下限，Y值上限")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:CameraLightRandomTime")]
	public float CameraLightRandomTime
	{
		get
		{
			CheckDestroyed();
			if (!CameraLightRandomTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraLightRandomTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraLightRandomTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLightRandomTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:CameraLightRandomTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraLightRandomTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|自动吸附")]
	[DisplayName("开始自动吸附之前的停留时间")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:StayTimeBeforeNear")]
	public float StayTimeBeforeNear
	{
		get
		{
			CheckDestroyed();
			if (!StayTimeBeforeNear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:StayTimeBeforeNear");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StayTimeBeforeNear_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StayTimeBeforeNear_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:StayTimeBeforeNear");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StayTimeBeforeNear_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|自动吸附")]
	[DisplayName("允许自动吸附的距离")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:NearDistance")]
	public float NearDistance
	{
		get
		{
			CheckDestroyed();
			if (!NearDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:NearDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NearDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NearDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:NearDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NearDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|自动吸附")]
	[DisplayName("自动吸附速度")]
	[USharpPath("/Script/b1-Managed.BGUChapterActor:NearSpeed")]
	public float NearSpeed
	{
		get
		{
			CheckDestroyed();
			if (!NearSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:NearSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NearSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NearSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterActor:NearSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NearSpeed_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUChapterActor");
		NativeReflection.GetPropertyRef(ref IsCheckBorder_PropertyAddress, unrealStruct, "IsCheckBorder");
		IsCheckBorder_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsCheckBorder");
		IsCheckBorder_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsCheckBorder", Classes.FBoolProperty);
		CameraShake_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraShake");
		CameraShake_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraShake", Classes.FClassProperty);
		CameraShakeScaleBase_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraShakeScaleBase");
		CameraShakeScaleBase_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraShakeScaleBase", Classes.FFloatProperty);
		CameraRoamPowerMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraRoamPowerMax");
		CameraRoamPowerMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraRoamPowerMax", Classes.FFloatProperty);
		CameraRoamPowerCoe_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraRoamPowerCoe");
		CameraRoamPowerCoe_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraRoamPowerCoe", Classes.FFloatProperty);
		CameraRoamPowerCoe_Gamepad_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraRoamPowerCoe_Gamepad");
		CameraRoamPowerCoe_Gamepad_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraRoamPowerCoe_Gamepad", Classes.FFloatProperty);
		CameraScalePowerCoe_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraScalePowerCoe");
		CameraScalePowerCoe_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraScalePowerCoe", Classes.FFloatProperty);
		CameraRoamAccelerationCoe_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraRoamAccelerationCoe");
		CameraRoamAccelerationCoe_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraRoamAccelerationCoe", Classes.FFloatProperty);
		CameraRoamDecelerationCoe_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraRoamDecelerationCoe");
		CameraRoamDecelerationCoe_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraRoamDecelerationCoe", Classes.FFloatProperty);
		CameraBorderDecelerationCoe_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBorderDecelerationCoe");
		CameraBorderDecelerationCoe_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBorderDecelerationCoe", Classes.FFloatProperty);
		CameraRoamPowerDirSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraRoamPowerDirSpeed");
		CameraRoamPowerDirSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraRoamPowerDirSpeed", Classes.FFloatProperty);
		CameraScaleMin_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraScaleMin");
		CameraScaleMin_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraScaleMin", Classes.FStructProperty);
		CameraScaleMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraScaleMax");
		CameraScaleMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraScaleMax", Classes.FStructProperty);
		FocusDistaceBase_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FocusDistaceBase");
		FocusDistaceBase_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FocusDistaceBase", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BorderMap_PropertyAddress, unrealStruct, "BorderMap");
		BorderMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BorderMap");
		BorderMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BorderMap", Classes.FMapProperty);
		CheckCameraRoamBorderDis_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckCameraRoamBorderDis");
		CheckCameraRoamBorderDis_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckCameraRoamBorderDis", Classes.FFloatProperty);
		CameraLightRandomRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraLightRandomRange");
		CameraLightRandomRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraLightRandomRange", Classes.FStructProperty);
		CameraLightBase_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraLightBase");
		CameraLightBase_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraLightBase", Classes.FFloatProperty);
		CameraLightRandomTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraLightRandomTime");
		CameraLightRandomTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraLightRandomTime", Classes.FFloatProperty);
		StayTimeBeforeNear_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StayTimeBeforeNear");
		StayTimeBeforeNear_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StayTimeBeforeNear", Classes.FFloatProperty);
		NearDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NearDistance");
		NearDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NearDistance", Classes.FFloatProperty);
		NearSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NearSpeed");
		NearSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NearSpeed", Classes.FFloatProperty);
	}

	static BGUChapterActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUChapterActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUChapterActor));
	}
}
