using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp")]
public class BUS_DumperTruckTriggerConfigComp : UActorEditCompBase
{
	private static bool TamerActor_IsValid;

	private static int TamerActor_Offset;

	private static bool AnimationAsset_IsValid;

	private static int AnimationAsset_Offset;

	private static bool SplineList_IsValid;

	private static int SplineList_Offset;

	private static FFieldAddress SplineList_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<AActor>> SplineList_Marshaler;

	private static bool TurnSpeed_IsValid;

	private static int TurnSpeed_Offset;

	private static bool Acceleration_IsValid;

	private static int Acceleration_Offset;

	private static bool MaxSpeed_IsValid;

	private static int MaxSpeed_Offset;

	private static bool MinSpeed_IsValid;

	private static int MinSpeed_Offset;

	private static bool StartSpeed_IsValid;

	private static int StartSpeed_Offset;

	private static bool MultiSplineDefaultIndex_IsValid;

	private static int MultiSplineDefaultIndex_Offset;

	private static bool FirstAccelerationIndex_IsValid;

	private static int FirstAccelerationIndex_Offset;

	private static bool SecondAccelerationIndex_IsValid;

	private static int SecondAccelerationIndex_Offset;

	private static bool SpeedRateParam_IsValid;

	private static int SpeedRateParam_Offset;

	private static bool RotatorWaitTime_IsValid;

	private static int RotatorWaitTime_Offset;

	private static bool SpeedRateParamCurve_IsValid;

	private static int SpeedRateParamCurve_Offset;

	private static bool UseCurveTime_IsValid;

	private static int UseCurveTime_Offset;

	private static bool StartPointIndex_IsValid;

	private static int StartPointIndex_Offset;

	private static bool IsStartForward_IsValid;

	private static int IsStartForward_Offset;

	private static FFieldAddress IsStartForward_PropertyAddress;

	private static bool ForwardBuffID_IsValid;

	private static int ForwardBuffID_Offset;

	private static bool BackBuffID_IsValid;

	private static int BackBuffID_Offset;

	private static bool ImmobilizeBuffSpeedThreshold_IsValid;

	private static int ImmobilizeBuffSpeedThreshold_Offset;

	private static bool ImmobilizeDeBuffSpeedThreshold_IsValid;

	private static int ImmobilizeDeBuffSpeedThreshold_Offset;

	private static bool ImmobilizeBuffID_IsValid;

	private static int ImmobilizeBuffID_Offset;

	private static bool ImmobilizeDeBuffID_IsValid;

	private static int ImmobilizeDeBuffID_Offset;

	private static bool SweepCheckParamter_IsValid;

	private static int SweepCheckParamter_Offset;

	private static bool BeginEventParamter_IsValid;

	private static int BeginEventParamter_Offset;

	private static bool EndEventParamter_IsValid;

	private static int EndEventParamter_Offset;

	private static bool DamageAvailableSpeedThreshold_IsValid;

	private static int DamageAvailableSpeedThreshold_Offset;

	private static bool DamageDisableSpeedThreshold_IsValid;

	private static int DamageDisableSpeedThreshold_Offset;

	private static bool AutoEnable_IsValid;

	private static int AutoEnable_Offset;

	private static FFieldAddress AutoEnable_PropertyAddress;

	[EditAnywhere]
	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:TamerActor")]
	public BUTamerActor TamerActor
	{
		get
		{
			CheckDestroyed();
			if (!TamerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:TamerActor");
				return null;
			}
			return UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(base.Address, TamerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:TamerActor");
			}
			else
			{
				UObjectMarshaler<BUTamerActor>.ToNative(IntPtr.Add(base.Address, TamerActor_Offset), value);
			}
		}
	}

	[Tooltip("替换的Animation")]
	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:AnimationAsset")]
	public UAnimationAsset AnimationAsset
	{
		get
		{
			CheckDestroyed();
			if (!AnimationAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:AnimationAsset");
				return null;
			}
			return UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(base.Address, AnimationAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimationAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:AnimationAsset");
			}
			else
			{
				UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(base.Address, AnimationAsset_Offset), value);
			}
		}
	}

	[Tooltip("寻路轨迹")]
	[UProperty]
	[EditAnywhere]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SplineList")]
	public TArrayReadWrite<TSoftObject<AActor>> SplineList
	{
		get
		{
			CheckDestroyed();
			if (!SplineList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SplineList");
				return null;
			}
			if (SplineList_Marshaler == null)
			{
				SplineList_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<AActor>>(1, SplineList_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative);
			}
			return SplineList_Marshaler.FromNative(IntPtr.Add(base.Address, SplineList_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[Tooltip("旋转速度")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:TurnSpeed")]
	public int TurnSpeed
	{
		get
		{
			CheckDestroyed();
			if (!TurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:TurnSpeed");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TurnSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:TurnSpeed");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TurnSpeed_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("DumperTruckTrigger config")]
	[UProperty]
	[Tooltip("加速度")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:Acceleration")]
	public float Acceleration
	{
		get
		{
			CheckDestroyed();
			if (!Acceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:Acceleration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Acceleration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Acceleration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:Acceleration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Acceleration_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("DumperTruckTrigger config")]
	[UProperty]
	[Tooltip("最大速度")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:MaxSpeed")]
	public float MaxSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:MaxSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:MaxSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSpeed_Offset), value);
			}
		}
	}

	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[Tooltip("最小速度")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:MinSpeed")]
	public float MinSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MinSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:MinSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:MinSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinSpeed_Offset), value);
			}
		}
	}

	[Category("DumperTruckTrigger config")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("开始速度")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:StartSpeed")]
	public float StartSpeed
	{
		get
		{
			CheckDestroyed();
			if (!StartSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:StartSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:StartSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartSpeed_Offset), value);
			}
		}
	}

	[Tooltip("默认寻路轨迹Index")]
	[EditAnywhere]
	[Category("DumperTruckTrigger config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:MultiSplineDefaultIndex")]
	public int MultiSplineDefaultIndex
	{
		get
		{
			CheckDestroyed();
			if (!MultiSplineDefaultIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:MultiSplineDefaultIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MultiSplineDefaultIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiSplineDefaultIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:MultiSplineDefaultIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MultiSplineDefaultIndex_Offset), value);
			}
		}
	}

	[Tooltip("第一个加速带结束位置，开始位置为起始端")]
	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:FirstAccelerationIndex")]
	public int FirstAccelerationIndex
	{
		get
		{
			CheckDestroyed();
			if (!FirstAccelerationIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:FirstAccelerationIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FirstAccelerationIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstAccelerationIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:FirstAccelerationIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FirstAccelerationIndex_Offset), value);
			}
		}
	}

	[Tooltip("第二个加速带结束位置，开始位置为结束端")]
	[EditAnywhere]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SecondAccelerationIndex")]
	public int SecondAccelerationIndex
	{
		get
		{
			CheckDestroyed();
			if (!SecondAccelerationIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SecondAccelerationIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SecondAccelerationIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SecondAccelerationIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SecondAccelerationIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SecondAccelerationIndex_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[Tooltip("速度动画缩放参数")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SpeedRateParam")]
	public float SpeedRateParam
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SpeedRateParam");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpeedRateParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SpeedRateParam");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpeedRateParam_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("DumperTruckTrigger config")]
	[Tooltip("转向等待时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:RotatorWaitTime")]
	public float RotatorWaitTime
	{
		get
		{
			CheckDestroyed();
			if (!RotatorWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:RotatorWaitTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotatorWaitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotatorWaitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:RotatorWaitTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotatorWaitTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[Tooltip("转向表现曲线")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SpeedRateParamCurve")]
	public UCurveFloat SpeedRateParamCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateParamCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SpeedRateParamCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, SpeedRateParamCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateParamCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SpeedRateParamCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, SpeedRateParamCurve_Offset), value);
			}
		}
	}

	[Tooltip("转向时使用曲线控制时间")]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:UseCurveTime")]
	public float UseCurveTime
	{
		get
		{
			CheckDestroyed();
			if (!UseCurveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:UseCurveTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UseCurveTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UseCurveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:UseCurveTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UseCurveTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("转向表现曲线")]
	[Category("DumperTruckTrigger config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:StartPointIndex")]
	public int StartPointIndex
	{
		get
		{
			CheckDestroyed();
			if (!StartPointIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:StartPointIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartPointIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartPointIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:StartPointIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartPointIndex_Offset), value);
			}
		}
	}

	[Tooltip("转向表现曲线")]
	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:IsStartForward")]
	public bool IsStartForward
	{
		get
		{
			CheckDestroyed();
			if (!IsStartForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:IsStartForward");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsStartForward_Offset), 0, IsStartForward_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsStartForward_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:IsStartForward");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsStartForward_Offset), 0, IsStartForward_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("正向移动特效BuffID")]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ForwardBuffID")]
	public int ForwardBuffID
	{
		get
		{
			CheckDestroyed();
			if (!ForwardBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ForwardBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForwardBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForwardBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ForwardBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForwardBuffID_Offset), value);
			}
		}
	}

	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("反向移动特效BuffID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:BackBuffID")]
	public int BackBuffID
	{
		get
		{
			CheckDestroyed();
			if (!BackBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:BackBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BackBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:BackBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BackBuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("定身缩短速度阈值（大于）")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeBuffSpeedThreshold")]
	public int ImmobilizeBuffSpeedThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeBuffSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeBuffSpeedThreshold");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ImmobilizeBuffSpeedThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeBuffSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeBuffSpeedThreshold");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ImmobilizeBuffSpeedThreshold_Offset), value);
			}
		}
	}

	[Tooltip("定身增长速度阈值（小于）")]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeDeBuffSpeedThreshold")]
	public int ImmobilizeDeBuffSpeedThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeDeBuffSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeDeBuffSpeedThreshold");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ImmobilizeDeBuffSpeedThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeDeBuffSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeDeBuffSpeedThreshold");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ImmobilizeDeBuffSpeedThreshold_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("定身缩短BuffID")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeBuffID")]
	public int ImmobilizeBuffID
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ImmobilizeBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ImmobilizeBuffID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[Tooltip("定身增长BuffID")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeDeBuffID")]
	public int ImmobilizeDeBuffID
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeDeBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeDeBuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ImmobilizeDeBuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeDeBuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:ImmobilizeDeBuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ImmobilizeDeBuffID_Offset), value);
			}
		}
	}

	[Category("DumperTruckTrigger config")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("SweepCheck参数")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SweepCheckParamter")]
	public FSweepCheckParamter SweepCheckParamter
	{
		get
		{
			CheckDestroyed();
			if (!SweepCheckParamter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SweepCheckParamter");
				return default(FSweepCheckParamter);
			}
			return FSweepCheckParamter.FromNative(IntPtr.Add(base.Address, SweepCheckParamter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SweepCheckParamter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:SweepCheckParamter");
			}
			else
			{
				FSweepCheckParamter.ToNative(IntPtr.Add(base.Address, SweepCheckParamter_Offset), value);
			}
		}
	}

	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("减起Event参数")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:BeginEventParamter")]
	public FAKEventParamter BeginEventParamter
	{
		get
		{
			CheckDestroyed();
			if (!BeginEventParamter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:BeginEventParamter");
				return default(FAKEventParamter);
			}
			return FAKEventParamter.FromNative(IntPtr.Add(base.Address, BeginEventParamter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginEventParamter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:BeginEventParamter");
			}
			else
			{
				FAKEventParamter.ToNative(IntPtr.Add(base.Address, BeginEventParamter_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("渐停Event参数")]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:EndEventParamter")]
	public FAKEventParamter EndEventParamter
	{
		get
		{
			CheckDestroyed();
			if (!EndEventParamter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:EndEventParamter");
				return default(FAKEventParamter);
			}
			return FAKEventParamter.FromNative(IntPtr.Add(base.Address, EndEventParamter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndEventParamter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:EndEventParamter");
			}
			else
			{
				FAKEventParamter.ToNative(IntPtr.Add(base.Address, EndEventParamter_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("大于时生成子弹有伤害（0到1之间）")]
	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:DamageAvailableSpeedThreshold")]
	public float DamageAvailableSpeedThreshold
	{
		get
		{
			CheckDestroyed();
			if (!DamageAvailableSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:DamageAvailableSpeedThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DamageAvailableSpeedThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DamageAvailableSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:DamageAvailableSpeedThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DamageAvailableSpeedThreshold_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("小于时生成子弹没伤害（0到1之间）")]
	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:DamageDisableSpeedThreshold")]
	public float DamageDisableSpeedThreshold
	{
		get
		{
			CheckDestroyed();
			if (!DamageDisableSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:DamageDisableSpeedThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DamageDisableSpeedThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DamageDisableSpeedThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:DamageDisableSpeedThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DamageDisableSpeedThreshold_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否默认开启")]
	[Tooltip("是否默认开启，控制器的开启和关闭可由CQG控制")]
	[USharpPath("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:AutoEnable")]
	public bool AutoEnable
	{
		get
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:AutoEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp:AutoEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoEnable_Offset), 0, AutoEnable_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AutoEnable = true;
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_DumperTruckTriggerData bUC_DumperTruckTriggerData = RequireWritableData<BUC_DumperTruckTriggerData>();
		if (TamerActor != null)
		{
			bUC_DumperTruckTriggerData.UnitGuid = TamerActor.GetFinalGuid();
		}
		RequireWritableData<BUC_QuestOverlapData>().bAutoEnableOverlap = AutoEnable;
		bUC_DumperTruckTriggerData.SplineList = new List<USplineComponent>();
		foreach (TSoftObject<AActor> spline in SplineList)
		{
			if (spline.Value != null)
			{
				USplineComponent componentByClass = spline.Value.GetComponentByClass<USplineComponent>();
				if (componentByClass != null)
				{
					bUC_DumperTruckTriggerData.SplineList.Add(componentByClass);
				}
			}
		}
		bUC_DumperTruckTriggerData.TurnSpeed = TurnSpeed;
		bUC_DumperTruckTriggerData.Acceleration = Acceleration;
		bUC_DumperTruckTriggerData.MaxSpeed = MaxSpeed;
		bUC_DumperTruckTriggerData.MinSpeed = MinSpeed;
		bUC_DumperTruckTriggerData.StartSpeed = StartSpeed;
		bUC_DumperTruckTriggerData.MultiSplineDefaultIndex = MultiSplineDefaultIndex;
		bUC_DumperTruckTriggerData.FirstAccelerationIndex = FirstAccelerationIndex;
		bUC_DumperTruckTriggerData.SecondAccelerationIndex = SecondAccelerationIndex;
		bUC_DumperTruckTriggerData.SpeedRateParam = SpeedRateParam;
		bUC_DumperTruckTriggerData.RotatorWaitTime = RotatorWaitTime;
		bUC_DumperTruckTriggerData.SpeedRateParamCurve = SpeedRateParamCurve;
		bUC_DumperTruckTriggerData.StartPointIndex = StartPointIndex;
		bUC_DumperTruckTriggerData.IsStartForward = IsStartForward;
		bUC_DumperTruckTriggerData.UseCurveTime = UseCurveTime;
		bUC_DumperTruckTriggerData.ForwardBuffID = ForwardBuffID;
		bUC_DumperTruckTriggerData.BackBuffID = BackBuffID;
		bUC_DumperTruckTriggerData.AnimationAsset = AnimationAsset;
		bUC_DumperTruckTriggerData.ImmobilizeBuffSpeedThreshold = ImmobilizeBuffSpeedThreshold;
		bUC_DumperTruckTriggerData.ImmobilizeDeBuffSpeedThreshold = ImmobilizeDeBuffSpeedThreshold;
		bUC_DumperTruckTriggerData.ImmobilizeBuffID = ImmobilizeBuffID;
		bUC_DumperTruckTriggerData.ImmobilizeDeBuffID = ImmobilizeDeBuffID;
		bUC_DumperTruckTriggerData.DamageAvailableSpeedThreshold = DamageAvailableSpeedThreshold;
		bUC_DumperTruckTriggerData.DamageDisableSpeedThreshold = DamageDisableSpeedThreshold;
		bUC_DumperTruckTriggerData.SweepCheckParamter = SweepCheckParamter;
		bUC_DumperTruckTriggerData.BeginAKEventParamter = BeginEventParamter;
		bUC_DumperTruckTriggerData.EndAKEventParamter = EndEventParamter;
		bUC_DumperTruckTriggerData.ObjectID = (int)Owner.GetUniqueID();
		bUC_DumperTruckTriggerData.FromInstanceID = (int)Owner.GetUniqueID();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_DumperTruckTriggerConfigComp");
		TamerActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TamerActor");
		TamerActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TamerActor", Classes.FObjectProperty);
		AnimationAsset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimationAsset");
		AnimationAsset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimationAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SplineList_PropertyAddress, unrealStruct, "SplineList");
		SplineList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SplineList");
		SplineList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SplineList", Classes.FArrayProperty);
		TurnSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TurnSpeed");
		TurnSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TurnSpeed", Classes.FIntProperty);
		Acceleration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Acceleration");
		Acceleration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Acceleration", Classes.FFloatProperty);
		MaxSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxSpeed");
		MaxSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxSpeed", Classes.FFloatProperty);
		MinSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinSpeed");
		MinSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinSpeed", Classes.FFloatProperty);
		StartSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartSpeed");
		StartSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartSpeed", Classes.FFloatProperty);
		MultiSplineDefaultIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MultiSplineDefaultIndex");
		MultiSplineDefaultIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MultiSplineDefaultIndex", Classes.FIntProperty);
		FirstAccelerationIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FirstAccelerationIndex");
		FirstAccelerationIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FirstAccelerationIndex", Classes.FIntProperty);
		SecondAccelerationIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SecondAccelerationIndex");
		SecondAccelerationIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SecondAccelerationIndex", Classes.FIntProperty);
		SpeedRateParam_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedRateParam");
		SpeedRateParam_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedRateParam", Classes.FFloatProperty);
		RotatorWaitTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RotatorWaitTime");
		RotatorWaitTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RotatorWaitTime", Classes.FFloatProperty);
		SpeedRateParamCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedRateParamCurve");
		SpeedRateParamCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedRateParamCurve", Classes.FObjectProperty);
		UseCurveTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseCurveTime");
		UseCurveTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseCurveTime", Classes.FFloatProperty);
		StartPointIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartPointIndex");
		StartPointIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartPointIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsStartForward_PropertyAddress, unrealStruct, "IsStartForward");
		IsStartForward_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsStartForward");
		IsStartForward_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsStartForward", Classes.FBoolProperty);
		ForwardBuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForwardBuffID");
		ForwardBuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForwardBuffID", Classes.FIntProperty);
		BackBuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BackBuffID");
		BackBuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BackBuffID", Classes.FIntProperty);
		ImmobilizeBuffSpeedThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeBuffSpeedThreshold");
		ImmobilizeBuffSpeedThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeBuffSpeedThreshold", Classes.FIntProperty);
		ImmobilizeDeBuffSpeedThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeDeBuffSpeedThreshold");
		ImmobilizeDeBuffSpeedThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeDeBuffSpeedThreshold", Classes.FIntProperty);
		ImmobilizeBuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeBuffID");
		ImmobilizeBuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeBuffID", Classes.FIntProperty);
		ImmobilizeDeBuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmobilizeDeBuffID");
		ImmobilizeDeBuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmobilizeDeBuffID", Classes.FIntProperty);
		SweepCheckParamter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SweepCheckParamter");
		SweepCheckParamter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SweepCheckParamter", Classes.FStructProperty);
		BeginEventParamter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginEventParamter");
		BeginEventParamter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginEventParamter", Classes.FStructProperty);
		EndEventParamter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndEventParamter");
		EndEventParamter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndEventParamter", Classes.FStructProperty);
		DamageAvailableSpeedThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DamageAvailableSpeedThreshold");
		DamageAvailableSpeedThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DamageAvailableSpeedThreshold", Classes.FFloatProperty);
		DamageDisableSpeedThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DamageDisableSpeedThreshold");
		DamageDisableSpeedThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DamageDisableSpeedThreshold", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AutoEnable_PropertyAddress, unrealStruct, "AutoEnable");
		AutoEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoEnable");
		AutoEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoEnable", Classes.FBoolProperty);
	}

	static BUS_DumperTruckTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DumperTruckTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DumperTruckTriggerConfigComp));
	}
}
