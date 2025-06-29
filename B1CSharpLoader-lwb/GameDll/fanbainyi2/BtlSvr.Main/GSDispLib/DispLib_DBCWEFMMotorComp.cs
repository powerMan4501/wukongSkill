using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp")]
public class DispLib_DBCWEFMMotorComp : UBaseEditorTickableActorComp
{
	private uint RequesterUniqueID;

	private USceneComponent RealAttachComp;

	private FVector CenterPosWS;

	private FVector DirWS;

	private FVector LastFrameSocketPosWS;

	private FVector4 WindDataV4;

	private int WindType;

	private float PlayAtTime;

	private float EndAtTime;

	private bool RuntimeInitOver;

	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static bool GetSocketOnThisComp_IsValid;

	private static int GetSocketOnThisComp_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool SocketLocalOffset_IsValid;

	private static int SocketLocalOffset_Offset;

	private static bool TriggerProbability_IsValid;

	private static int TriggerProbability_Offset;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool VelocityThreshold_IsValid;

	private static int VelocityThreshold_Offset;

	private static bool BaseIntensity_IsValid;

	private static int BaseIntensity_Offset;

	private static bool ScaleVelocityIntensity_IsValid;

	private static int ScaleVelocityIntensity_Offset;

	private static bool DistanceDamplingRate_IsValid;

	private static int DistanceDamplingRate_Offset;

	private static bool WindMotorMode_IsValid;

	private static int WindMotorMode_Offset;

	private static FFieldAddress WindMotorMode_PropertyAddress;

	private static bool RangeAxis_IsValid;

	private static int RangeAxis_Offset;

	private static FFieldAddress RangeAxis_PropertyAddress;

	private static bool RangeAxisLocalRotation_IsValid;

	private static int RangeAxisLocalRotation_Offset;

	private static bool RangeMask_IsValid;

	private static int RangeMask_Offset;

	private static bool VelocityDir_IsValid;

	private static int VelocityDir_Offset;

	private static FFieldAddress VelocityDir_PropertyAddress;

	private static bool VelocityDirLocalRotation_IsValid;

	private static int VelocityDirLocalRotation_Offset;

	private static bool ScaleSecondVelocity_IsValid;

	private static int ScaleSecondVelocity_Offset;

	private static bool EditorTestDoOnceWindEvent_IsValid;

	private static IntPtr EditorTestDoOnceWindEvent_FunctionAddress;

	private static int EditorTestDoOnceWindEvent_ParamsSize;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[UMeta(MD.ToolTip, "事件名类似tag，当需要暂停某个风源的时候用事件名来索引。为了方便配置，对于作用相似的风源即使不同角色间也应该统一事件名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("事件名")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:EventName")]
	public FName EventName
	{
		get
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:EventName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EventName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:EventName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EventName_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("依附目标Comp Tag")]
	[UMeta(MD.ToolTip, "None 表示RootComp")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:GetSocketOnThisComp")]
	public FName GetSocketOnThisComp
	{
		get
		{
			CheckDestroyed();
			if (!GetSocketOnThisComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:GetSocketOnThisComp");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, GetSocketOnThisComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GetSocketOnThisComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:GetSocketOnThisComp");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, GetSocketOnThisComp_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("风源中心")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[DisplayName("延迟时间")]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, 0)]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:Delay")]
	public float Delay
	{
		get
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:Delay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Delay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:Delay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Delay_Offset), value);
			}
		}
	}

	[DisplayName("结束模式")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:EndMode")]
	public DispLibDBCEndMode EndMode
	{
		get
		{
			CheckDestroyed();
			if (!EndMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:EndMode");
				return DispLibDBCEndMode.AutoRelease;
			}
			return EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(base.Address, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EndMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:EndMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(base.Address, EndMode_Offset), 0, EndMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("持续时间")]
	[UMeta(MDProp.EditCondition, "EndMode == DispLibDBCEndMode::FixDuration")]
	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("风源中心本地偏移")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:SocketLocalOffset")]
	public FVector SocketLocalOffset
	{
		get
		{
			CheckDestroyed();
			if (!SocketLocalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:SocketLocalOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, SocketLocalOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketLocalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:SocketLocalOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, SocketLocalOffset_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, 1)]
	[UMeta(MDProp.ClampMin, 0)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("触发概率")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:TriggerProbability")]
	public float TriggerProbability
	{
		get
		{
			CheckDestroyed();
			if (!TriggerProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:TriggerProbability");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerProbability_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:TriggerProbability");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerProbability_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("半径")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:Radius")]
	public BUC_DispLibUtil_DBCAdvProcessScalar Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:Radius");
				return default(BUC_DispLibUtil_DBCAdvProcessScalar);
			}
			return BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:Radius");
			}
			else
			{
				BUC_DispLibUtil_DBCAdvProcessScalar.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[DisplayName("速度阈值")]
	[UMeta(MDProp.ClampMin, 0)]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "风源中心速度低于此值时不会产生风")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:VelocityThreshold")]
	public float VelocityThreshold
	{
		get
		{
			CheckDestroyed();
			if (!VelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:VelocityThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:VelocityThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityThreshold_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MD.ToolTip, "风源中心强度 = 基础强度 + 风源中心的速度 * 速度强度倍率")]
	[UProperty]
	[DisplayName("基础强度")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:BaseIntensity")]
	public BUC_DispLibUtil_DBCAdvProcessScalar BaseIntensity
	{
		get
		{
			CheckDestroyed();
			if (!BaseIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:BaseIntensity");
				return default(BUC_DispLibUtil_DBCAdvProcessScalar);
			}
			return BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(base.Address, BaseIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:BaseIntensity");
			}
			else
			{
				BUC_DispLibUtil_DBCAdvProcessScalar.ToNative(IntPtr.Add(base.Address, BaseIntensity_Offset), value);
			}
		}
	}

	[DisplayName("速度强度倍率")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MD.ToolTip, "风源中心强度 = 基础强度 + 风源中心的速度 * 速度强度倍率")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:ScaleVelocityIntensity")]
	public float ScaleVelocityIntensity
	{
		get
		{
			CheckDestroyed();
			if (!ScaleVelocityIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:ScaleVelocityIntensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScaleVelocityIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleVelocityIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:ScaleVelocityIntensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScaleVelocityIntensity_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "距离风源中心越近的位置风强越接近【中心强度】，距离风源中心越远（越接近半径值）的位置风强越接近【中心强度】*【末端衰减率】")]
	[DisplayName("末端衰减率")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:DistanceDamplingRate")]
	public float DistanceDamplingRate
	{
		get
		{
			CheckDestroyed();
			if (!DistanceDamplingRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:DistanceDamplingRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceDamplingRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceDamplingRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:DistanceDamplingRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceDamplingRate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("风源类型")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:WindMotorMode")]
	public DispLibDBCWindMotorMode WindMotorMode
	{
		get
		{
			CheckDestroyed();
			if (!WindMotorMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:WindMotorMode");
				return DispLibDBCWindMotorMode.NoWind;
			}
			return EnumMarshaler<DispLibDBCWindMotorMode>.FromNative(IntPtr.Add(base.Address, WindMotorMode_Offset), 0, WindMotorMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WindMotorMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:WindMotorMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCWindMotorMode>.ToNative(IntPtr.Add(base.Address, WindMotorMode_Offset), 0, WindMotorMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("范围轴向")]
	[UMeta(MD.ToolTip, "指定风源范围的轴向，与遮罩参数配合可以实现半球/弧底圆锥等形状的注风区域")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:RangeAxis")]
	public DispLibDBCAxisMode RangeAxis
	{
		get
		{
			CheckDestroyed();
			if (!RangeAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:RangeAxis");
				return DispLibDBCAxisMode.WS_X;
			}
			return EnumMarshaler<DispLibDBCAxisMode>.FromNative(IntPtr.Add(base.Address, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RangeAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:RangeAxis");
			}
			else
			{
				EnumMarshaler<DispLibDBCAxisMode>.ToNative(IntPtr.Add(base.Address, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("范围轴向本地旋转")]
	[UMeta(MD.ToolTip, "当范围轴向与速度有关时，此参数应用为世界旋转且不建议进行旋转，因为结果不可控")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:RangeAxisLocalRotation")]
	public FVector RangeAxisLocalRotation
	{
		get
		{
			CheckDestroyed();
			if (!RangeAxisLocalRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:RangeAxisLocalRotation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RangeAxisLocalRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeAxisLocalRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:RangeAxisLocalRotation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RangeAxisLocalRotation_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "待注入的风场Cell中心点与范围轴向的点乘结果若小于这个值，则不注入，例如 = 0 可以实现只注入轴向半球范围, = 0.5 可注入沿轴向的弧底锥形")]
	[DisplayName("范围遮罩")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:RangeMask")]
	public float RangeMask
	{
		get
		{
			CheckDestroyed();
			if (!RangeMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:RangeMask");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RangeMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:RangeMask");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RangeMask_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "对于定向风，风速方向即最终方向；对于其他类型的风会在其原本方向上叠加此方向，使用【缩放副风速方向】控制叠加的强度")]
	[DisplayName("风速(副风速)方向")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:VelocityDir")]
	public DispLibDBCAxisMode VelocityDir
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:VelocityDir");
				return DispLibDBCAxisMode.WS_X;
			}
			return EnumMarshaler<DispLibDBCAxisMode>.FromNative(IntPtr.Add(base.Address, VelocityDir_Offset), 0, VelocityDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:VelocityDir");
			}
			else
			{
				EnumMarshaler<DispLibDBCAxisMode>.ToNative(IntPtr.Add(base.Address, VelocityDir_Offset), 0, VelocityDir_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("风速(副风速)方向本地旋转")]
	[UMeta(MD.ToolTip, "当风速(副风速)方向与速度有关时，此参数应用为世界旋转且不建议进行旋转，因为结果不可控")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:VelocityDirLocalRotation")]
	public FVector VelocityDirLocalRotation
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDirLocalRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:VelocityDirLocalRotation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, VelocityDirLocalRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDirLocalRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:VelocityDirLocalRotation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, VelocityDirLocalRotation_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("缩放副风速方向")]
	[UMeta(MDProp.EditCondition, "WindMotorMode != DispLibDBCWindMotorMode::LocalDirectionalWind")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:ScaleSecondVelocity")]
	public BUC_DispLibUtil_DBCAdvProcessScalar ScaleSecondVelocity
	{
		get
		{
			CheckDestroyed();
			if (!ScaleSecondVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:ScaleSecondVelocity");
				return default(BUC_DispLibUtil_DBCAdvProcessScalar);
			}
			return BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(base.Address, ScaleSecondVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleSecondVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:ScaleSecondVelocity");
			}
			else
			{
				BUC_DispLibUtil_DBCAdvProcessScalar.ToNative(IntPtr.Add(base.Address, ScaleSecondVelocity_Offset), value);
			}
		}
	}

	private DBCAdvProcessScalar m_RadiusProcess { get; set; }

	private DBCAdvProcessScalar m_BaseIntensityProcess { get; set; }

	private DBCAdvProcessScalar m_ScaleSecondVelocityProcess { get; set; }

	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.BeginPlayInCS_Implementation();
		InitData();
	}

	private void FindRealAttachComp()
	{
		if (GetSocketOnThisComp == FName.None)
		{
			RealAttachComp = GetOwner().RootComponent;
			return;
		}
		List<UActorComponent> componentsByTag = GetOwner().GetComponentsByTag(UClass.GetClass<USceneComponent>(), GetSocketOnThisComp);
		if (componentsByTag.Count != 0)
		{
			RealAttachComp = componentsByTag[0] as USceneComponent;
		}
	}

	private void InitData()
	{
		RuntimeInitOver = false;
		WindType = (int)WindMotorMode;
		PlayAtTime = BGU_DispLibDataUtil.GSTimeAfterBeginPlay(GetOwner()) + Delay;
		if (EndMode == DispLibDBCEndMode.ProcedureNotity)
		{
			EndAtTime = -1f;
		}
		else if (EndMode == DispLibDBCEndMode.FixDuration)
		{
			EndAtTime = PlayAtTime + Duration;
		}
		else
		{
			EndAtTime = PlayAtTime + 8f;
		}
		FindRealAttachComp();
		LastFrameSocketPosWS = RealAttachComp.GetSocketLocation(SocketName);
		m_RadiusProcess = new DBCAdvProcessScalar(Radius);
		m_BaseIntensityProcess = new DBCAdvProcessScalar(BaseIntensity);
		m_ScaleSecondVelocityProcess = new DBCAdvProcessScalar(ScaleSecondVelocity);
		RuntimeInitOver = true;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:EditorTestDoOnceWindEvent")]
	public void EditorTestDoOnceWindEvent()
	{
	}

	private void Editor_RefreshData(float DeltaTime, float Velocitylength)
	{
	}

	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
	}

	private void DoDebug(float DeltaTime, ref float VLength)
	{
	}

	private void UpdataProcessParams(float DeltaTime, float VelocityLength)
	{
		m_BaseIntensityProcess.UpdateValue(DeltaTime, VelocityLength);
		m_RadiusProcess.UpdateValue(DeltaTime, VelocityLength);
		m_ScaleSecondVelocityProcess.UpdateValue(DeltaTime, VelocityLength);
	}

	[USharpPath("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		base.TickComponentInCS_Implementation(DeltaTime);
		if (WindMotorMode == DispLibDBCWindMotorMode.NoWind)
		{
			return;
		}
		float num = BGU_DispLibDataUtil.GSTimeAfterBeginPlay(GetOwner());
		if (num < PlayAtTime || (EndAtTime != -1f && num > EndAtTime))
		{
			return;
		}
		BWS_DispLibEventCollection bWS_DispLibEventCollection = BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(GetOwner()));
		if (bWS_DispLibEventCollection == null)
		{
			return;
		}
		FTransform socketTransform = RealAttachComp.GetSocketTransform(SocketName);
		FVector location = socketTransform.GetLocation();
		FVector fVector = (location - LastFrameSocketPosWS) / DeltaTime;
		LastFrameSocketPosWS = location;
		fVector.ToDirectionAndLength(out var dir, out var length);
		UpdataProcessParams(DeltaTime, length);
		if (FMath.FRand() >= TriggerProbability || length < VelocityThreshold)
		{
			return;
		}
		CenterPosWS = socketTransform.TransformPosition(SocketLocalOffset);
		FVector axisVector = DispLibFuncUtil.GetAxisVector(VelocityDir, RealAttachComp, socketTransform, dir, VelocityDirLocalRotation);
		FVector axisVector2 = DispLibFuncUtil.GetAxisVector(RangeAxis, RealAttachComp, socketTransform, dir, RangeAxisLocalRotation);
		WindDataV4 = new FVector4(axisVector2, RangeMask);
		float num2 = m_BaseIntensityProcess.CurFrameValue + ScaleVelocityIntensity * length;
		if (!(num2 <= 0.0001f))
		{
			if (WindMotorMode != DispLibDBCWindMotorMode.LocalDirectionalWind && WindMotorMode != DispLibDBCWindMotorMode.NoWind)
			{
				axisVector *= (double)m_ScaleSecondVelocityProcess.CurFrameValue;
			}
			FVector windSizeV = new FVector(m_RadiusProcess.CurFrameValue, 0.0, 0.0);
			bWS_DispLibEventCollection.Evt_DLDWorld_RequestDirectInject_Wind(ref RequesterUniqueID, CenterPosWS, axisVector, windSizeV, num2, WindType, DistanceDamplingRate, WindDataV4);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:EditorTestDoOnceWindEvent")]
	private static void EditorTestDoOnceWindEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCWEFMMotorComp dispLib_DBCWEFMMotorComp = GCHelper.Find<DispLib_DBCWEFMMotorComp>(obj);
		dispLib_DBCWEFMMotorComp.EditorTestDoOnceWindEvent();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCWEFMMotorComp dispLib_DBCWEFMMotorComp = GCHelper.Find<DispLib_DBCWEFMMotorComp>(obj);
		dispLib_DBCWEFMMotorComp.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCWEFMMotorComp dispLib_DBCWEFMMotorComp = GCHelper.Find<DispLib_DBCWEFMMotorComp>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		dispLib_DBCWEFMMotorComp.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCWEFMMotorComp dispLib_DBCWEFMMotorComp = GCHelper.Find<DispLib_DBCWEFMMotorComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		dispLib_DBCWEFMMotorComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_DBCWEFMMotorComp");
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FNameProperty);
		GetSocketOnThisComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "GetSocketOnThisComp");
		GetSocketOnThisComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GetSocketOnThisComp", Classes.FNameProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		SocketLocalOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketLocalOffset");
		SocketLocalOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketLocalOffset", Classes.FStructProperty);
		TriggerProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerProbability");
		TriggerProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerProbability", Classes.FFloatProperty);
		Radius_Offset = NativeReflection.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Radius", Classes.FStructProperty);
		VelocityThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityThreshold");
		VelocityThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityThreshold", Classes.FFloatProperty);
		BaseIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseIntensity");
		BaseIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseIntensity", Classes.FStructProperty);
		ScaleVelocityIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleVelocityIntensity");
		ScaleVelocityIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleVelocityIntensity", Classes.FFloatProperty);
		DistanceDamplingRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceDamplingRate");
		DistanceDamplingRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceDamplingRate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref WindMotorMode_PropertyAddress, intPtr, "WindMotorMode");
		WindMotorMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindMotorMode");
		WindMotorMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindMotorMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref RangeAxis_PropertyAddress, intPtr, "RangeAxis");
		RangeAxis_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeAxis");
		RangeAxis_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeAxis", Classes.FEnumProperty);
		RangeAxisLocalRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeAxisLocalRotation");
		RangeAxisLocalRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeAxisLocalRotation", Classes.FStructProperty);
		RangeMask_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeMask");
		RangeMask_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeMask", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref VelocityDir_PropertyAddress, intPtr, "VelocityDir");
		VelocityDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDir");
		VelocityDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDir", Classes.FEnumProperty);
		VelocityDirLocalRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "VelocityDirLocalRotation");
		VelocityDirLocalRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VelocityDirLocalRotation", Classes.FStructProperty);
		ScaleSecondVelocity_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleSecondVelocity");
		ScaleSecondVelocity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleSecondVelocity", Classes.FStructProperty);
		EditorTestDoOnceWindEvent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorTestDoOnceWindEvent");
		EditorTestDoOnceWindEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorTestDoOnceWindEvent_FunctionAddress);
		EditorTestDoOnceWindEvent_IsValid = EditorTestDoOnceWindEvent_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:EditorTestDoOnceWindEvent", EditorTestDoOnceWindEvent_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:OnPropertyChanged", OnPropertyChanged_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCWEFMMotorComp:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static DispLib_DBCWEFMMotorComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_DBCWEFMMotorComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_DBCWEFMMotorComp));
	}
}
