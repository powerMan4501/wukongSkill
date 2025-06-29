using System;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara")]
public struct BUC_DispLibDBC_PlayNiagara
{
	[DisplayName("延迟时间")]
	[UMeta(MDProp.ClampMin, 0)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:Delay")]
	public float Delay;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束模式")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UProperty]
	[DisplayName("持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[UMeta(MDProp.EditCondition, "EndMode == DispLibDBCEndMode::FixDuration")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:Duration")]
	public float Duration;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[UMeta(MD.ToolTip, "若不为0设置特效参数 GS_EfxEndDispStageTime; 逻辑通知特效可以结束或固定持续时间过后，设置特效参数 GS_EfxStop = true; EndMode 是 AutoRelease 时无效（视为0)")]
	[DisplayName("结束表现时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("销毁时机")]
	[UMeta(MD.ToolTip, "逻辑在何时通知特效销毁")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:DestroyTiming")]
	public DispLibDBCEffectDestroyTiming DestroyTiming;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("Template")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:Template")]
	public UNiagaraSystem Template;

	[DisplayName("目标MeshComp")]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MD.ToolTip, "填写目标Comp的tag，为None表示以master作为目标骨骼，否则查找tag对应的骨骼，多个结果只取第一个")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:OverrideMeshCompTagName")]
	public FName OverrideMeshCompTagName;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("依附目标挂点")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:AttachedTarget")]
	public bool AttachedTarget;

	[DisplayName("目标挂点名")]
	[UMeta(MD.ToolTip, "如果配置了一个有效的挂点但是不勾选【依附目标挂点】，特效会创建在挂点位置但是不依附于挂点")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:AttachedTargetSocketName")]
	public FName AttachedTargetSocketName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("本地空间偏移")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:OffsetInLocalSpace")]
	public bool OffsetInLocalSpace;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:LocationOffset")]
	public FVector LocationOffset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:RotationOffset")]
	public FRotator RotationOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:Scale")]
	public FVector Scale;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("吸附地面")]
	[UMeta(MD.ToolTip, "勾选此参数，特效强制不跟随挂点且忽略 DBCOverrideTransform\r\n勾选此参数后，\r\nLocation如何计算：从配置的挂点位置（不计算配置的offset）向世界空间负Z轴打射线，命中地面后在命中点的 Location 基础上计算配置的 LocationOffset，如果勾选了【偏移是否基于本地空间】，LocationOffset 是在配置的挂点空间计算的\r\n   Rotation如何计算：命中地面后根据【吸附地面时特效朝向】决定特效朝向，但无论哪种方式都会完全忽略配置的 RotationOffset")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:SnapGround")]
	public bool SnapGround;

	[UProperty]
	[EditAnywhere]
	[DisplayName("吸附地面时特效朝向")]
	[UMeta(MDProp.EditCondition, "SnapGround == true")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:SnapGroundRotationMode")]
	public DispLibDBCSnapGroundRotationMode SnapGroundRotationMode;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "AttachedTarget")]
	[DisplayName("结束表现阶段与挂点分离")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:DetachOnEndDispStageBegin")]
	public bool DetachOnEndDispStageBegin;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("阴影")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:EnableShadow")]
	public bool EnableShadow;

	[EditAnywhere]
	[UProperty]
	[DisplayName("透明排序优先级")]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "这个值会设置给Comp这一级，数值越大的排序时更靠近摄像机")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:TranslucentSortPriority")]
	public int TranslucentSortPriority;

	[DisplayName("强制不使用池")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:ForcePoolModeNone")]
	public bool ForcePoolModeNone;

	[UMeta(MD.ToolTip, "当触发暂停时请求方会给定一个优先级，如果此参数大于优先级则不会进入暂停逻辑，如果小于等于优先级会根据【暂停模式】有不同的行为;\n角色被定身时逻辑给出的优先级是 -1")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("暂停优先级")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:PausePriority")]
	public int PausePriority;

	[UProperty]
	[UMeta(MD.ToolTip, "进入暂停逻辑后，此配置项决定了特效的行为")]
	[DisplayName("暂停模式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:PauseMode")]
	public DispLibDBCPauseMode PauseMode;

	[UProperty]
	[DisplayName("结束表现阶段优先级")]
	[UMeta(MD.ToolTip, "每次进入结束表现阶段时逻辑会给出此次结束表现阶段的优先级，不同原因触发的结束表现阶段其优先级可能不同;\n如果此参数小于优先级则不会进入结束表现阶段而是直接进入销毁流程;\n正常流程下因事件到达持续时间或程序通知停止而进入结束表现阶段时逻辑给出的优先级是 -1\n因角色死亡触发结束表现阶段时逻辑给出的优先级是 0\n因角色回家或土地庙重置触发结束表现阶段时逻辑给出的优先级是 0")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:EndStagePriority")]
	public int EndStagePriority;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("强制可见性优先级")]
	[UMeta(MD.ToolTip, "当外部请求强制设置可见性时会给定一个优先级，如果此参数大于优先级则不会受此请求的影响；\n主角因为释放人种袋变身而强制隐藏所有特效时逻辑给出的优先级是 100\n主角因为进入Seq而监听宿主Actor的Hidden状态而隐藏所有特效时逻辑给出的优先级是 50\n主角因为进入Seq而强制隐藏所有特效时逻辑给出的优先级是 10")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:ForceChangeVisibleStateDEFPriority")]
	public int ForceChangeVisibleStateDEFPriority;

	[UMeta(MD.ToolTip, "如果强制设置可见性的请求允许执行，此配置决定特效的默认行为。如果需要对指定优先级的请求有不同的行为，可以将特效改为为 AdvanceNiagara 精细配置行为")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("强制可见性行为")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:ForceVisibleStateDefaultMode")]
	public DispLibDBCNiagaraForceVisibleStateMode ForceVisibleStateDefaultMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Meta String")]
	[UMeta(MD.ToolTip, "会设置为Comp或Actor的Tag，用于对外传递一些信息，例如在 DispLogicMode = Custom 时对外标识特效的用途")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:MetaString")]
	public FName MetaString;

	[UMeta(MD.ToolTip, "DBC性能控制")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("DBC Scalability")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara:ScalabilitySettings")]
	public BUC_DispLibDBC_NiagaraEventScalabilitySettings ScalabilitySettings;

	private static int BUC_DispLibDBC_PlayNiagara_StructSize;

	private static int BUC_DispLibDBC_PlayNiagara_IsValid;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool DestroyTiming_IsValid;

	private static int DestroyTiming_Offset;

	private static FFieldAddress DestroyTiming_PropertyAddress;

	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool OverrideMeshCompTagName_IsValid;

	private static int OverrideMeshCompTagName_Offset;

	private static bool AttachedTarget_IsValid;

	private static int AttachedTarget_Offset;

	private static FFieldAddress AttachedTarget_PropertyAddress;

	private static bool AttachedTargetSocketName_IsValid;

	private static int AttachedTargetSocketName_Offset;

	private static bool OffsetInLocalSpace_IsValid;

	private static int OffsetInLocalSpace_Offset;

	private static FFieldAddress OffsetInLocalSpace_PropertyAddress;

	private static bool LocationOffset_IsValid;

	private static int LocationOffset_Offset;

	private static bool RotationOffset_IsValid;

	private static int RotationOffset_Offset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool SnapGround_IsValid;

	private static int SnapGround_Offset;

	private static FFieldAddress SnapGround_PropertyAddress;

	private static bool SnapGroundRotationMode_IsValid;

	private static int SnapGroundRotationMode_Offset;

	private static FFieldAddress SnapGroundRotationMode_PropertyAddress;

	private static bool DetachOnEndDispStageBegin_IsValid;

	private static int DetachOnEndDispStageBegin_Offset;

	private static FFieldAddress DetachOnEndDispStageBegin_PropertyAddress;

	private static bool EnableShadow_IsValid;

	private static int EnableShadow_Offset;

	private static FFieldAddress EnableShadow_PropertyAddress;

	private static bool TranslucentSortPriority_IsValid;

	private static int TranslucentSortPriority_Offset;

	private static bool ForcePoolModeNone_IsValid;

	private static int ForcePoolModeNone_Offset;

	private static FFieldAddress ForcePoolModeNone_PropertyAddress;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	private static bool PauseMode_IsValid;

	private static int PauseMode_Offset;

	private static FFieldAddress PauseMode_PropertyAddress;

	private static bool EndStagePriority_IsValid;

	private static int EndStagePriority_Offset;

	private static bool ForceChangeVisibleStateDEFPriority_IsValid;

	private static int ForceChangeVisibleStateDEFPriority_Offset;

	private static bool ForceVisibleStateDefaultMode_IsValid;

	private static int ForceVisibleStateDefaultMode_Offset;

	private static FFieldAddress ForceVisibleStateDefaultMode_PropertyAddress;

	private static bool MetaString_IsValid;

	private static int MetaString_Offset;

	private static bool ScalabilitySettings_IsValid;

	private static int ScalabilitySettings_Offset;

	public BUC_DispLibDBC_PlayNiagara(float _Duration, DispLibDBCEndMode _EndMode, UNiagaraSystem _Template)
	{
		Delay = 0f;
		EndMode = _EndMode;
		Duration = _Duration;
		DelayTimeAfterStop = 0f;
		DestroyTiming = DispLibDBCEffectDestroyTiming.OnEndDispStageEnd;
		Template = _Template;
		OverrideMeshCompTagName = FName.None;
		AttachedTarget = false;
		AttachedTargetSocketName = FName.None;
		OffsetInLocalSpace = false;
		LocationOffset = FVector.ZeroVector;
		RotationOffset = FRotator.ZeroRotator;
		Scale = FVector.OneVector;
		SnapGround = false;
		SnapGroundRotationMode = DispLibDBCSnapGroundRotationMode.HitPointNormalProjected;
		DetachOnEndDispStageBegin = false;
		EnableShadow = false;
		TranslucentSortPriority = 0;
		ForcePoolModeNone = false;
		PausePriority = 0;
		EndStagePriority = 0;
		PauseMode = DispLibDBCPauseMode.Pause;
		ForceChangeVisibleStateDEFPriority = 0;
		ForceVisibleStateDefaultMode = DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState;
		MetaString = FName.None;
		ScalabilitySettings = default(BUC_DispLibDBC_NiagaraEventScalabilitySettings);
	}

	public BUC_DispLibDBC_PlayNiagara(float _Delay, DispLibDBCEndMode _EndMode, float _Duration, float _DelayTimeAfterStop, DispLibDBCEffectDestroyTiming _DestroyTiming, UNiagaraSystem _Template, FName _OverrideMeshCompTagName, bool _AttachedTarget, FName _AttachedTargetSocketName, bool _OffsetInLocalSpace, FVector _LocationOffset, FRotator _RotationOffset, FVector _Scale, bool _SnapGround, DispLibDBCSnapGroundRotationMode _SnapGroundRotationMode, bool _DetachOnEndDispStageBegin, bool _EnableShadow, int _TranslucentSortPriority, bool _ForcePoolModeNone, int _PausePriority, DispLibDBCPauseMode _PauseMode, int _EndStagePriority, int _ForceChangeVisibleStateDEFPriority, DispLibDBCNiagaraForceVisibleStateMode _ForceVisibleStateDefaultMode, FName _MetaString, BUC_DispLibDBC_NiagaraEventScalabilitySettings _ScalabilitySettings)
	{
		Delay = _Delay;
		EndMode = _EndMode;
		Duration = _Duration;
		DelayTimeAfterStop = _DelayTimeAfterStop;
		DestroyTiming = _DestroyTiming;
		Template = _Template;
		OverrideMeshCompTagName = _OverrideMeshCompTagName;
		AttachedTarget = _AttachedTarget;
		AttachedTargetSocketName = _AttachedTargetSocketName;
		OffsetInLocalSpace = _OffsetInLocalSpace;
		LocationOffset = _LocationOffset;
		RotationOffset = _RotationOffset;
		Scale = _Scale;
		SnapGround = _SnapGround;
		SnapGroundRotationMode = _SnapGroundRotationMode;
		DetachOnEndDispStageBegin = _DetachOnEndDispStageBegin;
		EnableShadow = _EnableShadow;
		TranslucentSortPriority = _TranslucentSortPriority;
		ForcePoolModeNone = _ForcePoolModeNone;
		PausePriority = _PausePriority;
		EndStagePriority = _EndStagePriority;
		PauseMode = _PauseMode;
		ForceChangeVisibleStateDEFPriority = _ForceChangeVisibleStateDEFPriority;
		ForceVisibleStateDefaultMode = _ForceVisibleStateDefaultMode;
		MetaString = _MetaString;
		ScalabilitySettings = _ScalabilitySettings;
	}

	public BUC_DispLibDBC_PlayNiagara Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_PlayNiagara FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_PlayNiagara(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_PlayNiagara value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_PlayNiagara FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_PlayNiagara(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayNiagara_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_PlayNiagara value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayNiagara_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayNiagara_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
		EnumMarshaler<DispLibDBCEffectDestroyTiming>.ToNative(IntPtr.Add(nativeStruct, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address, DestroyTiming);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, Template_Offset), Template);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, OverrideMeshCompTagName_Offset), OverrideMeshCompTagName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address, AttachedTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset), AttachedTargetSocketName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OffsetInLocalSpace_Offset), 0, OffsetInLocalSpace_PropertyAddress.Address, OffsetInLocalSpace);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LocationOffset_Offset), LocationOffset);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, RotationOffset_Offset), RotationOffset);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address, SnapGround);
		EnumMarshaler<DispLibDBCSnapGroundRotationMode>.ToNative(IntPtr.Add(nativeStruct, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address, SnapGroundRotationMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address, DetachOnEndDispStageBegin);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address, EnableShadow);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TranslucentSortPriority_Offset), TranslucentSortPriority);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForcePoolModeNone_Offset), 0, ForcePoolModeNone_PropertyAddress.Address, ForcePoolModeNone);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
		EnumMarshaler<DispLibDBCPauseMode>.ToNative(IntPtr.Add(nativeStruct, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address, PauseMode);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset), EndStagePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ForceChangeVisibleStateDEFPriority_Offset), ForceChangeVisibleStateDEFPriority);
		EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.ToNative(IntPtr.Add(nativeStruct, ForceVisibleStateDefaultMode_Offset), 0, ForceVisibleStateDefaultMode_PropertyAddress.Address, ForceVisibleStateDefaultMode);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MetaString_Offset), MetaString);
		BUC_DispLibDBC_NiagaraEventScalabilitySettings.ToNative(IntPtr.Add(nativeStruct, ScalabilitySettings_Offset), ScalabilitySettings);
	}

	public BUC_DispLibDBC_PlayNiagara(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayNiagara_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara");
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			DelayTimeAfterStop = 0f;
			DestroyTiming = DispLibDBCEffectDestroyTiming.OnEndDispStageEnd;
			Template = null;
			OverrideMeshCompTagName = default(FName);
			AttachedTarget = false;
			AttachedTargetSocketName = default(FName);
			OffsetInLocalSpace = false;
			LocationOffset = default(FVector);
			RotationOffset = default(FRotator);
			Scale = default(FVector);
			SnapGround = false;
			SnapGroundRotationMode = DispLibDBCSnapGroundRotationMode.HitPointNormalProjected;
			DetachOnEndDispStageBegin = false;
			EnableShadow = false;
			TranslucentSortPriority = 0;
			ForcePoolModeNone = false;
			PausePriority = 0;
			PauseMode = DispLibDBCPauseMode.Pause;
			EndStagePriority = 0;
			ForceChangeVisibleStateDEFPriority = 0;
			ForceVisibleStateDefaultMode = DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState;
			MetaString = default(FName);
			ScalabilitySettings = default(BUC_DispLibDBC_NiagaraEventScalabilitySettings);
		}
		else
		{
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
			DestroyTiming = EnumMarshaler<DispLibDBCEffectDestroyTiming>.FromNative(IntPtr.Add(nativeStruct, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address);
			Template = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, Template_Offset));
			OverrideMeshCompTagName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, OverrideMeshCompTagName_Offset));
			AttachedTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address);
			AttachedTargetSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset));
			OffsetInLocalSpace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OffsetInLocalSpace_Offset), 0, OffsetInLocalSpace_PropertyAddress.Address);
			LocationOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LocationOffset_Offset));
			RotationOffset = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, RotationOffset_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			SnapGround = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address);
			SnapGroundRotationMode = EnumMarshaler<DispLibDBCSnapGroundRotationMode>.FromNative(IntPtr.Add(nativeStruct, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address);
			DetachOnEndDispStageBegin = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address);
			EnableShadow = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address);
			TranslucentSortPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TranslucentSortPriority_Offset));
			ForcePoolModeNone = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForcePoolModeNone_Offset), 0, ForcePoolModeNone_PropertyAddress.Address);
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
			PauseMode = EnumMarshaler<DispLibDBCPauseMode>.FromNative(IntPtr.Add(nativeStruct, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address);
			EndStagePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset));
			ForceChangeVisibleStateDEFPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ForceChangeVisibleStateDEFPriority_Offset));
			ForceVisibleStateDefaultMode = EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.FromNative(IntPtr.Add(nativeStruct, ForceVisibleStateDefaultMode_Offset), 0, ForceVisibleStateDefaultMode_PropertyAddress.Address);
			MetaString = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MetaString_Offset));
			ScalabilitySettings = BUC_DispLibDBC_NiagaraEventScalabilitySettings.FromNative(IntPtr.Add(nativeStruct, ScalabilitySettings_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara");
		BUC_DispLibDBC_PlayNiagara_StructSize = NativeReflection.GetStructSize(intPtr);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DestroyTiming_PropertyAddress, intPtr, "DestroyTiming");
		DestroyTiming_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyTiming");
		DestroyTiming_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyTiming", Classes.FEnumProperty);
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FObjectProperty);
		OverrideMeshCompTagName_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideMeshCompTagName");
		OverrideMeshCompTagName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideMeshCompTagName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref AttachedTarget_PropertyAddress, intPtr, "AttachedTarget");
		AttachedTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTarget");
		AttachedTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTarget", Classes.FBoolProperty);
		AttachedTargetSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetSocketName");
		AttachedTargetSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetSocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref OffsetInLocalSpace_PropertyAddress, intPtr, "OffsetInLocalSpace");
		OffsetInLocalSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetInLocalSpace");
		OffsetInLocalSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetInLocalSpace", Classes.FBoolProperty);
		LocationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocationOffset");
		LocationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocationOffset", Classes.FStructProperty);
		RotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationOffset");
		RotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationOffset", Classes.FStructProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SnapGround_PropertyAddress, intPtr, "SnapGround");
		SnapGround_Offset = NativeReflection.GetPropertyOffset(intPtr, "SnapGround");
		SnapGround_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SnapGround", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SnapGroundRotationMode_PropertyAddress, intPtr, "SnapGroundRotationMode");
		SnapGroundRotationMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "SnapGroundRotationMode");
		SnapGroundRotationMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SnapGroundRotationMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DetachOnEndDispStageBegin_PropertyAddress, intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetachOnEndDispStageBegin", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableShadow_PropertyAddress, intPtr, "EnableShadow");
		EnableShadow_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableShadow");
		EnableShadow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableShadow", Classes.FBoolProperty);
		TranslucentSortPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "TranslucentSortPriority");
		TranslucentSortPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TranslucentSortPriority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ForcePoolModeNone_PropertyAddress, intPtr, "ForcePoolModeNone");
		ForcePoolModeNone_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForcePoolModeNone");
		ForcePoolModeNone_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForcePoolModeNone", Classes.FBoolProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref PauseMode_PropertyAddress, intPtr, "PauseMode");
		PauseMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "PauseMode");
		PauseMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PauseMode", Classes.FEnumProperty);
		EndStagePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStagePriority");
		EndStagePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStagePriority", Classes.FIntProperty);
		ForceChangeVisibleStateDEFPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceChangeVisibleStateDEFPriority");
		ForceChangeVisibleStateDEFPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceChangeVisibleStateDEFPriority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ForceVisibleStateDefaultMode_PropertyAddress, intPtr, "ForceVisibleStateDefaultMode");
		ForceVisibleStateDefaultMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceVisibleStateDefaultMode");
		ForceVisibleStateDefaultMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceVisibleStateDefaultMode", Classes.FEnumProperty);
		MetaString_Offset = NativeReflection.GetPropertyOffset(intPtr, "MetaString");
		MetaString_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MetaString", Classes.FNameProperty);
		ScalabilitySettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScalabilitySettings");
		ScalabilitySettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScalabilitySettings", Classes.FStructProperty);
		BUC_DispLibDBC_PlayNiagara_IsValid = ((intPtr != IntPtr.Zero && Delay_IsValid && EndMode_IsValid && Duration_IsValid && DelayTimeAfterStop_IsValid && DestroyTiming_IsValid && Template_IsValid && OverrideMeshCompTagName_IsValid && AttachedTarget_IsValid && AttachedTargetSocketName_IsValid && OffsetInLocalSpace_IsValid && LocationOffset_IsValid && RotationOffset_IsValid && Scale_IsValid && SnapGround_IsValid && SnapGroundRotationMode_IsValid && DetachOnEndDispStageBegin_IsValid && EnableShadow_IsValid && TranslucentSortPriority_IsValid && ForcePoolModeNone_IsValid && PausePriority_IsValid && PauseMode_IsValid && EndStagePriority_IsValid && ForceChangeVisibleStateDEFPriority_IsValid && ForceVisibleStateDefaultMode_IsValid && MetaString_IsValid && ScalabilitySettings_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_PlayNiagara", (byte)BUC_DispLibDBC_PlayNiagara_IsValid != 0);
	}

	static BUC_DispLibDBC_PlayNiagara()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_PlayNiagara)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_PlayNiagara));
	}
}
