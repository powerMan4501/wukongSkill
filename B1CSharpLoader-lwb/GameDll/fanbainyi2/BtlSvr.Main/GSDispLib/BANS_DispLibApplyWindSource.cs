using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[DisplayName("BANS DispLib Apply Wind Source")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource")]
internal class BANS_DispLibApplyWindSource : BANS_GSBase
{
	private static bool EditorActive_IsValid;

	private static int EditorActive_Offset;

	private static FFieldAddress EditorActive_PropertyAddress;

	private static bool EditorPlayActive_IsValid;

	private static int EditorPlayActive_Offset;

	private static FFieldAddress EditorPlayActive_PropertyAddress;

	private static bool EventName_IsValid;

	private static int EventName_Offset;

	private static bool PauseEventNames_IsValid;

	private static int PauseEventNames_Offset;

	private static FFieldAddress PauseEventNames_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> PauseEventNames_Marshaler;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

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

	private static bool DBC_IdentityID_IsValid;

	private static int DBC_IdentityID_Offset;

	private static bool LastFrameSocketPosWS_IsValid;

	private static int LastFrameSocketPosWS_Offset;

	private static bool WindType_IsValid;

	private static int WindType_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool Received_NotifyTick_IsValid;

	private static IntPtr Received_NotifyTick_FunctionAddress;

	private static int Received_NotifyTick_ParamsSize;

	private static bool Received_NotifyTick_MeshComp_IsValid;

	private static int Received_NotifyTick_MeshComp_Offset;

	private static bool Received_NotifyTick_Animation_IsValid;

	private static int Received_NotifyTick_Animation_Offset;

	private static bool Received_NotifyTick_FrameDeltaTime_IsValid;

	private static int Received_NotifyTick_FrameDeltaTime_Offset;

	private static bool Received_NotifyTick_EventReference_IsValid;

	private static int Received_NotifyTick_EventReference_Offset;

	private static FFieldAddress Received_NotifyTick_EventReference_PropertyAddress;

	private static bool Received_NotifyTick_ReturnValue_IsValid;

	private static int Received_NotifyTick_ReturnValue_Offset;

	private static FFieldAddress Received_NotifyTick_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "关闭后动画编辑器不会播放当前效果")]
	[BlueprintReadWrite]
	[DisplayName("Editor Active")]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:EditorActive")]
	public bool EditorActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:EditorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:EditorActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Editor Play Active")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "关闭后编辑器运行时不会播放当前效果，不影响真机运行时")]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:EditorPlayActive")]
	public bool EditorPlayActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorPlayActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:EditorPlayActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorPlayActive_Offset), 0, EditorPlayActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorPlayActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:EditorPlayActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorPlayActive_Offset), 0, EditorPlayActive_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("事件名")]
	[UMeta(MD.ToolTip, "事件名类似tag，当需要暂停某个风源的时候用事件名来索引。为了方便配置，对于作用相似的风源即使不同角色间也应该统一事件名")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:EventName")]
	public FName EventName
	{
		get
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:EventName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, EventName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:EventName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, EventName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("暂停事件")]
	[UMeta(MD.ToolTip, "暂停当前角色的这些WEFM事件")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:PauseEventNames")]
	public TArrayReadWrite<FName> PauseEventNames
	{
		get
		{
			CheckDestroyed();
			if (!PauseEventNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:PauseEventNames");
				return null;
			}
			if (PauseEventNames_Marshaler == null)
			{
				PauseEventNames_Marshaler = new TArrayReadWriteMarshaler<FName>(1, PauseEventNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return PauseEventNames_Marshaler.FromNative(IntPtr.Add(base.Address, PauseEventNames_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("风源中心")]
	[UMeta("AnimNotifyBoneName", "true")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("风源中心本地偏移")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:SocketLocalOffset")]
	public FVector SocketLocalOffset
	{
		get
		{
			CheckDestroyed();
			if (!SocketLocalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:SocketLocalOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, SocketLocalOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketLocalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:SocketLocalOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, SocketLocalOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("触发概率")]
	[UMeta(MDProp.ClampMax, 1)]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:TriggerProbability")]
	public float TriggerProbability
	{
		get
		{
			CheckDestroyed();
			if (!TriggerProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:TriggerProbability");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerProbability_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerProbability_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:TriggerProbability");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerProbability_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("半径")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:Radius")]
	public BUC_DispLibUtil_DBCAdvProcessScalar Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:Radius");
				return default(BUC_DispLibUtil_DBCAdvProcessScalar);
			}
			return BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:Radius");
			}
			else
			{
				BUC_DispLibUtil_DBCAdvProcessScalar.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("速度阈值")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MD.ToolTip, "风源中心速度低于此值时不会产生风")]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:VelocityThreshold")]
	public float VelocityThreshold
	{
		get
		{
			CheckDestroyed();
			if (!VelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:VelocityThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VelocityThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:VelocityThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VelocityThreshold_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("基础强度")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MD.ToolTip, "风源中心强度 = 基础强度 + 风源中心的速度 * 速度强度倍率")]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:BaseIntensity")]
	public BUC_DispLibUtil_DBCAdvProcessScalar BaseIntensity
	{
		get
		{
			CheckDestroyed();
			if (!BaseIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:BaseIntensity");
				return default(BUC_DispLibUtil_DBCAdvProcessScalar);
			}
			return BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(base.Address, BaseIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:BaseIntensity");
			}
			else
			{
				BUC_DispLibUtil_DBCAdvProcessScalar.ToNative(IntPtr.Add(base.Address, BaseIntensity_Offset), value);
			}
		}
	}

	[DisplayName("速度强度倍率")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MD.ToolTip, "风源中心强度 = 基础强度 + 风源中心的速度 * 速度强度倍率")]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:ScaleVelocityIntensity")]
	public float ScaleVelocityIntensity
	{
		get
		{
			CheckDestroyed();
			if (!ScaleVelocityIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:ScaleVelocityIntensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScaleVelocityIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleVelocityIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:ScaleVelocityIntensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScaleVelocityIntensity_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "距离风源中心越近的点注入的风强越接近【强度】，距离风源中心越远（越接近半径值）的点注入的风强越接近【强度】*【末端衰减率】")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("末端衰减率")]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:DistanceDamplingRate")]
	public float DistanceDamplingRate
	{
		get
		{
			CheckDestroyed();
			if (!DistanceDamplingRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:DistanceDamplingRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceDamplingRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceDamplingRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:DistanceDamplingRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceDamplingRate_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("风源类型")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:WindMotorMode")]
	public DispLibDBCWindMotorMode WindMotorMode
	{
		get
		{
			CheckDestroyed();
			if (!WindMotorMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:WindMotorMode");
				return DispLibDBCWindMotorMode.NoWind;
			}
			return EnumMarshaler<DispLibDBCWindMotorMode>.FromNative(IntPtr.Add(base.Address, WindMotorMode_Offset), 0, WindMotorMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WindMotorMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:WindMotorMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCWindMotorMode>.ToNative(IntPtr.Add(base.Address, WindMotorMode_Offset), 0, WindMotorMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("范围轴向")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "指定风源范围的轴向，与遮罩参数配合可以实现半球/弧地圆锥等形状的注风区域")]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:RangeAxis")]
	public DispLibDBCAxisMode RangeAxis
	{
		get
		{
			CheckDestroyed();
			if (!RangeAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:RangeAxis");
				return DispLibDBCAxisMode.WS_X;
			}
			return EnumMarshaler<DispLibDBCAxisMode>.FromNative(IntPtr.Add(base.Address, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RangeAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:RangeAxis");
			}
			else
			{
				EnumMarshaler<DispLibDBCAxisMode>.ToNative(IntPtr.Add(base.Address, RangeAxis_Offset), 0, RangeAxis_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MD.ToolTip, "当范围轴向与速度有关时，此参数应用为世界旋转且不建议进行旋转，因为结果不可控")]
	[DisplayName("范围轴向本地旋转")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:RangeAxisLocalRotation")]
	public FVector RangeAxisLocalRotation
	{
		get
		{
			CheckDestroyed();
			if (!RangeAxisLocalRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:RangeAxisLocalRotation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RangeAxisLocalRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeAxisLocalRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:RangeAxisLocalRotation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RangeAxisLocalRotation_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "待注入的风场Cell中心点与范围轴向的点乘结果若小于这个值，则不注入，例如 = 0 可以实现只注入轴向半球范围, = 0.5 可注入沿轴向的弧底锥形")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("范围遮罩")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:RangeMask")]
	public float RangeMask
	{
		get
		{
			CheckDestroyed();
			if (!RangeMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:RangeMask");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RangeMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:RangeMask");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RangeMask_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "对于定向风，风速方向即最终方向；对于其他类型的风会在其原本方向上叠加此方向，使用【缩放副风速方向】控制叠加的强度")]
	[DisplayName("风速(副风速)方向")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:VelocityDir")]
	public DispLibDBCAxisMode VelocityDir
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:VelocityDir");
				return DispLibDBCAxisMode.WS_X;
			}
			return EnumMarshaler<DispLibDBCAxisMode>.FromNative(IntPtr.Add(base.Address, VelocityDir_Offset), 0, VelocityDir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:VelocityDir");
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
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:VelocityDirLocalRotation")]
	public FVector VelocityDirLocalRotation
	{
		get
		{
			CheckDestroyed();
			if (!VelocityDirLocalRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:VelocityDirLocalRotation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, VelocityDirLocalRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VelocityDirLocalRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:VelocityDirLocalRotation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, VelocityDirLocalRotation_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "WindMotorMode != DispLibDBCWindMotorMode::LocalDirectionalWind")]
	[DisplayName("缩放副风速方向")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:ScaleSecondVelocity")]
	public BUC_DispLibUtil_DBCAdvProcessScalar ScaleSecondVelocity
	{
		get
		{
			CheckDestroyed();
			if (!ScaleSecondVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:ScaleSecondVelocity");
				return default(BUC_DispLibUtil_DBCAdvProcessScalar);
			}
			return BUC_DispLibUtil_DBCAdvProcessScalar.FromNative(IntPtr.Add(base.Address, ScaleSecondVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleSecondVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:ScaleSecondVelocity");
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

	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:DBC_IdentityID")]
	public int DBC_IdentityID
	{
		get
		{
			CheckDestroyed();
			if (!DBC_IdentityID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:DBC_IdentityID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DBC_IdentityID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBC_IdentityID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:DBC_IdentityID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DBC_IdentityID_Offset), value);
			}
		}
	}

	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:LastFrameSocketPosWS")]
	public FVector LastFrameSocketPosWS
	{
		get
		{
			CheckDestroyed();
			if (!LastFrameSocketPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:LastFrameSocketPosWS");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LastFrameSocketPosWS_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastFrameSocketPosWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:LastFrameSocketPosWS");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LastFrameSocketPosWS_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:WindType")]
	public int WindType
	{
		get
		{
			CheckDestroyed();
			if (!WindType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:WindType");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WindType_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_DispLibApplyWindSource:WindType");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WindType_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.CanBePlacedInASCS = true;
		base.CanUseQueuedType = true;
		VelocityThreshold = 1500f;
		ScaleVelocityIntensity = 0.05f;
		WindMotorMode = DispLibDBCWindMotorMode.LocalOmniWind;
		RangeAxis = DispLibDBCAxisMode.WS_Z;
		RangeMask = -1.1f;
		TriggerProbability = 1f;
		DBC_IdentityID = 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		base.Received_NotifyBegin_Implementation(meshComp, animation, TotalDuration, default(FAnimNotifyEventReference));
		FVector location = meshComp.GetSocketTransform(SocketName).GetLocation();
		LastFrameSocketPosWS = location;
		m_RadiusProcess = new DBCAdvProcessScalar(Radius);
		m_BaseIntensityProcess = new DBCAdvProcessScalar(BaseIntensity);
		m_ScaleSecondVelocityProcess = new DBCAdvProcessScalar(ScaleSecondVelocity);
		WindType = (int)WindMotorMode;
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(meshComp.GetOwner());
		if (bUS_DispLibEventCollection == null)
		{
			return;
		}
		foreach (FName pauseEventName in PauseEventNames)
		{
			bUS_DispLibEventCollection.Evt_RequestPauseWind(pauseEventName);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		base.Received_NotifyEnd_Implementation(meshComp, animation, default(FAnimNotifyEventReference));
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(meshComp.GetOwner());
		if (bUS_DispLibEventCollection == null)
		{
			return;
		}
		foreach (FName pauseEventName in PauseEventNames)
		{
			bUS_DispLibEventCollection.Evt_RequestContinueWind(pauseEventName);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_DispLibApplyWindSource:Received_NotifyTick")]
	protected override bool Received_NotifyTick_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime, FAnimNotifyEventReference EventReference)
	{
		base.Received_NotifyTick_Implementation(MeshComp, Animation, FrameDeltaTime, EventReference);
		if (WindMotorMode == DispLibDBCWindMotorMode.NoWind || !BGU_DispLibDataUtil.GetCurActiveMontageeUniqueID(MeshComp, Animation, out var MontageeUniqueID))
		{
			return false;
		}
		FTransform socketTransform = MeshComp.GetSocketTransform(SocketName);
		FVector location = socketTransform.GetLocation();
		FVector fVector = (location - LastFrameSocketPosWS) / FrameDeltaTime;
		LastFrameSocketPosWS = location;
		fVector.ToDirectionAndLength(out var dir, out var length);
		m_BaseIntensityProcess.UpdateValue(FrameDeltaTime, length);
		m_RadiusProcess.UpdateValue(FrameDeltaTime, length);
		m_ScaleSecondVelocityProcess.UpdateValue(FrameDeltaTime, length);
		if (length < VelocityThreshold)
		{
			return true;
		}
		FVector centerPosWS = socketTransform.TransformPosition(SocketLocalOffset);
		FVector axisVector = DispLibFuncUtil.GetAxisVector(VelocityDir, MeshComp, socketTransform, dir, VelocityDirLocalRotation);
		FVector axisVector2 = DispLibFuncUtil.GetAxisVector(RangeAxis, MeshComp, socketTransform, dir, RangeAxisLocalRotation);
		if (WindMotorMode != DispLibDBCWindMotorMode.LocalDirectionalWind)
		{
			axisVector *= (double)m_ScaleSecondVelocityProcess.CurFrameValue;
		}
		float num = m_BaseIntensityProcess.CurFrameValue + ScaleVelocityIntensity * length;
		if (num <= 0.001f)
		{
			return true;
		}
		FVector windSizeV = new FVector(m_RadiusProcess.CurFrameValue, 0.0, 0.0);
		uint RequesterUniqueID = (uint)DBC_IdentityID;
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(MeshComp.GetOwner());
		if (bUS_DispLibEventCollection != null)
		{
			bUS_DispLibEventCollection.Evt_RequestDynamicWindEvent(ref RequesterUniqueID, centerPosWS, axisVector, windSizeV, num, WindType, DistanceDamplingRate, new FVector4(axisVector2, RangeMask), GetUniqueID(), MontageeUniqueID);
		}
		else
		{
			BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(MeshComp))?.Evt_DLDWorld_RequestDirectInject_Wind(ref RequesterUniqueID, centerPosWS, axisVector, windSizeV, num, WindType, DistanceDamplingRate, new FVector4(axisVector2, RangeMask), GetUniqueID(), MontageeUniqueID);
		}
		DBC_IdentityID = (int)RequesterUniqueID;
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_DispLibApplyWindSource:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_DispLibApplyWindSource bANS_DispLibApplyWindSource = GCHelper.Find<GSDispLib.BANS_DispLibApplyWindSource>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_DispLibApplyWindSource.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_DispLibApplyWindSource:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_DispLibApplyWindSource bANS_DispLibApplyWindSource = GCHelper.Find<GSDispLib.BANS_DispLibApplyWindSource>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_DispLibApplyWindSource.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_DispLibApplyWindSource:Received_NotifyTick")]
	private static void Received_NotifyTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_DispLibApplyWindSource bANS_DispLibApplyWindSource = GCHelper.Find<GSDispLib.BANS_DispLibApplyWindSource>(obj);
		USkeletalMeshComponent meshComp = UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(buffer, Received_NotifyTick_MeshComp_Offset));
		UAnimSequenceBase animation = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(buffer, Received_NotifyTick_Animation_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Received_NotifyTick_FrameDeltaTime_Offset));
		FAnimNotifyEventReference eventReference = FAnimNotifyEventReference.FromNative(IntPtr.Add(buffer, Received_NotifyTick_EventReference_Offset));
		bool value = bANS_DispLibApplyWindSource.Received_NotifyTick_Implementation(meshComp, animation, frameDeltaTime, eventReference);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, Received_NotifyTick_ReturnValue_Offset), 0, Received_NotifyTick_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_DispLibApplyWindSource");
		NativeReflection.GetPropertyRef(ref EditorActive_PropertyAddress, intPtr, "EditorActive");
		EditorActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorActive");
		EditorActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorActive", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EditorPlayActive_PropertyAddress, intPtr, "EditorPlayActive");
		EditorPlayActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorPlayActive");
		EditorPlayActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorPlayActive", Classes.FBoolProperty);
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref PauseEventNames_PropertyAddress, intPtr, "PauseEventNames");
		PauseEventNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "PauseEventNames");
		PauseEventNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PauseEventNames", Classes.FArrayProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
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
		DBC_IdentityID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DBC_IdentityID");
		DBC_IdentityID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DBC_IdentityID", Classes.FIntProperty);
		LastFrameSocketPosWS_Offset = NativeReflection.GetPropertyOffset(intPtr, "LastFrameSocketPosWS");
		LastFrameSocketPosWS_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LastFrameSocketPosWS", Classes.FStructProperty);
		WindType_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindType");
		WindType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindType", Classes.FIntProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_DispLibApplyWindSource:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_DispLibApplyWindSource:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		Received_NotifyTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Received_NotifyTick");
		Received_NotifyTick_ParamsSize = NativeReflection.GetFunctionParamsSize(Received_NotifyTick_FunctionAddress);
		Received_NotifyTick_MeshComp_Offset = NativeReflection.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "MeshComp");
		Received_NotifyTick_MeshComp_IsValid = NativeReflection.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		Received_NotifyTick_Animation_Offset = NativeReflection.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "Animation");
		Received_NotifyTick_Animation_IsValid = NativeReflection.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "Animation", Classes.FObjectProperty);
		Received_NotifyTick_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "FrameDeltaTime");
		Received_NotifyTick_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref Received_NotifyTick_EventReference_PropertyAddress, Received_NotifyTick_FunctionAddress, "EventReference");
		Received_NotifyTick_EventReference_Offset = NativeReflection.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "EventReference");
		Received_NotifyTick_EventReference_IsValid = NativeReflection.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref Received_NotifyTick_ReturnValue_PropertyAddress, Received_NotifyTick_FunctionAddress, "ReturnValue");
		Received_NotifyTick_ReturnValue_Offset = NativeReflection.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "ReturnValue");
		Received_NotifyTick_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Received_NotifyTick_IsValid = Received_NotifyTick_FunctionAddress != IntPtr.Zero && Received_NotifyTick_MeshComp_IsValid && Received_NotifyTick_Animation_IsValid && Received_NotifyTick_FrameDeltaTime_IsValid && Received_NotifyTick_EventReference_IsValid && Received_NotifyTick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_DispLibApplyWindSource:Received_NotifyTick", Received_NotifyTick_IsValid);
	}

	static BANS_DispLibApplyWindSource()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BANS_DispLibApplyWindSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BANS_DispLibApplyWindSource));
	}
}
