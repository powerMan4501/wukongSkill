using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara")]
public struct BUC_DispLibDBC_PlayAdvanceNiagara
{
	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("延迟时间")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:Delay")]
	public float Delay;

	[EditAnywhere]
	[UProperty]
	[DisplayName("结束模式")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UMeta(MDProp.EditCondition, "EndMode == DispLibDBCEndMode::FixDuration")]
	[DisplayName("持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:Duration")]
	public float Duration;

	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现时间")]
	[UMeta(MD.ToolTip, "表现逻辑层通知特效应该结束时要额外延后多长时间销毁特效，小于等于0会立即销毁，否则会设置特效参数 GS_EfxStop = true; EndMode 是 AutoRelease 时无效")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	[UMeta(MD.ToolTip, "不同行为模式可能有自己固定的Attach模式，所以下面的参数不需要全都填写，具体参照每种行为模式的说明")]
	[DisplayName("行为模式")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:DispLogicMode")]
	public DispLibAdvanceNiagaraDispLogicMode DispLogicMode;

	[DisplayName("销毁时机")]
	[UMeta(MD.ToolTip, "逻辑在何时通知特效销毁")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:DestroyTiming")]
	public DispLibDBCEffectDestroyTiming DestroyTiming;

	[UProperty]
	[EditAnywhere]
	[DisplayName("Template")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:Template")]
	public UNiagaraSystem Template;

	[UProperty]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "填写目标comp的tag，为None表示以master作为目标骨骼，否则查找tag对应的骨骼，多个结果只取第一个")]
	[DisplayName("目标MeshComp")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:OverrideMeshCompTagName")]
	public FName OverrideMeshCompTagName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("依附目标挂点")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachedTarget")]
	public bool AttachedTarget;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标插槽查找模式")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:TargetSocketSearchMode")]
	public DispLibSocketSearchMode TargetSocketSearchMode;

	[DisplayName("依附目标插槽")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "DispLogicMode != DispLibAdvanceNiagaraDispLogicMode::MatchingToNearestSocket")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachedTargetSocketName")]
	public FName AttachedTargetSocketName;

	[DisplayName("本地空间偏移")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:OffsetInLocalSpace")]
	public bool OffsetInLocalSpace;

	[DisplayName("依附目标插槽偏移")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachedTargetLocationOffset")]
	public FVector AttachedTargetLocationOffset;

	[DisplayName("依附目标插槽旋转")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachedTargetRotationOffset")]
	public FRotator AttachedTargetRotationOffset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("监听次要组件挂点")]
	[UMeta(MD.ToolTip, "谁执行这个DA谁就是【主要Comp】,【次要】一词一般指攻击者，这里监听次要组件挂点是监听其 Transform 变化并在必要时通知特效而不是把特效真的Attach到次要组件")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachedEmitter")]
	public bool AttachedEmitter;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("次要组件插槽查找模式")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:EmitterSocketSearchMode")]
	public DispLibSocketSearchMode EmitterSocketSearchMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("监听次要组件插槽")]
	[UMeta(MD.ToolTip, "当【行为模式】是【标准关联性】或【自定义】时，如果不监听发射者插槽，每帧传递给特效的次要目标位置都是相同的，即特效创建那一帧的次要目标位置")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachedEmitterSocketName")]
	public FName AttachedEmitterSocketName;

	[DisplayName("监听次要组件插槽偏移")]
	[EditAnywhere]
	[UMeta(MDFunc.AdvancedDisplay)]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachedEmitterLocationOffset")]
	public FVector AttachedEmitterLocationOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("监听次要组件插槽旋转")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachedEmitterRotationOffset")]
	public FRotator AttachedEmitterRotationOffset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:Scale")]
	public FVector Scale;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("吸附地面")]
	[UMeta(MD.ToolTip, "勾选此参数，特效强制不跟随挂点且忽略 DBCOverrideTransform\r\n勾选此参数后，\r\nLocation如何计算：从配置的挂点位置（不计算配置的offset）向世界空间负Z轴打射线，命中地面后在命中点的 Location 基础上计算配置的 LocationOffset，如果勾选了【偏移是否基于本地空间】，LocationOffset 是在配置的挂点空间计算的\r\n   Rotation如何计算：命中地面后根据【吸附地面时特效朝向】决定特效朝向，但无论哪种方式都会完全忽略配置的 RotationOffset")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SnapGround")]
	public bool SnapGround;

	[UMeta(MDProp.EditCondition, "SnapGround == true")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("吸附地面时特效朝向")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SnapGroundRotationMode")]
	public DispLibDBCSnapGroundRotationMode SnapGroundRotationMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[UMeta(MD.ToolTip, "没有明确定义用途的Vector4参数，会在创建特效时设置给特效的 BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxV4Param 变量")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:CustomV4Param")]
	public FVector4 CustomV4Param;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Override Transform 转化为参数")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[UMeta(MD.ToolTip, "勾选后，如果逻辑传入了有效的 DBCTransform，不会直接应用而是以参数形式传入特效 GS_EfxOverride_LO, GS_EfxOverride_RO, GS_EfxOverride_S")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SetDBCTransformAsParam")]
	public bool SetDBCTransformAsParam;

	[UMeta(MD.ToolTip, "设置自身 SkeletalMeshComp 到特效的 User.GS_EfxSelfSkeletalMesh 或者 设置自身 StaticMeshComp 到 User.GS_EfxSelfStaticMesh")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("传递自身MeshComp")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SetSelfSKMeshParam")]
	public bool SetSelfSKMeshParam;

	[BlueprintReadWrite]
	[DisplayName("传递次要MeshComp")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[UMeta(MD.ToolTip, "设置发射者 SkeletalMeshComp 到特效的 User.GS_EfxMinorSkeletalMesh 或者 设置发射者 StaticMeshComp 到 User.GS_EfxMinorStaticMesh ")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SetMinorSKMeshParam")]
	public bool SetMinorSKMeshParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("传递额外参数")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:UseExtraCustomParams")]
	public bool UseExtraCustomParams;

	[UMeta(MD.ToolTip, "注意，Niagara内的参数类型必须是float")]
	[UMeta(MDProp.EditCondition, "UseExtraCustomParams")]
	[UMeta(MD.DisplayName, "设置Scalar参数")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SetScalarParam")]
	public List<BUC_DispLibUtil_NameAndScalar> SetScalarParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置Color参数")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[UMeta(MDProp.EditCondition, "UseExtraCustomParams")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SetColorParam")]
	public List<BUC_DispLibUtil_NameAndLColor> SetColorParam;

	[UMeta(MDProp.EditCondition, "UseExtraCustomParams")]
	[UMeta(MD.DisplayName, "Scalar 参数曲线")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SetCurveScalarParam")]
	public List<BUC_DispLibUtil_NameAndScalarCurve> SetCurveScalarParam;

	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[UMeta(MDProp.EditCondition, "UseExtraCustomParams")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MD.DisplayName, "LColor 参数曲线")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SetCurveLColorParam")]
	public List<BUC_DispLibUtil_NameAndLColorCurve> SetCurveLColorParam;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Vector3 参数曲线")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[UMeta(MDProp.EditCondition, "UseExtraCustomParams")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:SetCurveV3Param")]
	public List<BUC_DispLibUtil_NameAndVectorCurve> SetCurveV3Param;

	[UMeta(MDProp.EditCondition, "AttachedTarget")]
	[UProperty]
	[DisplayName("进入结束表现阶段时与挂点分离")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:DetachOnEndDispStageBegin")]
	public bool DetachOnEndDispStageBegin;

	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "AttachedTarget")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[DisplayName("挂点约束模式")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachConstraintMode")]
	public DispLibAttachConstraintMode AttachConstraintMode;

	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[UMeta(MDProp.EditCondition, "AttachedTarget")]
	[EditAnywhere]
	[DisplayName("挂点约束参数")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:AttachConstraintValue")]
	public FVector2D AttachConstraintValue;

	[DisplayName("阴影")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:EnableShadow")]
	public bool EnableShadow;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("透明体积阴影")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:EnableVolumetricTranslucentShadow")]
	public bool EnableVolumetricTranslucentShadow;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("透明排序优先级")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[UMeta(MD.ToolTip, "数值越大的排序时更靠近摄像机")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:TranslucentSortPriority")]
	public int TranslucentSortPriority;

	[UMeta(MDProp.EditCondition, "EndMode != DispLogicMode::DBCMergedSystem")]
	[UMeta(MD.ToolTip, "一些特殊情况可能希望程序手动控制特效开始播放，例如外部获取特效后摆好位置再手动激活来规避一些拖尾问题")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("以非活跃状态发射")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:DeactiveAtSpawn")]
	public bool DeactiveAtSpawn;

	[BlueprintReadWrite]
	[DisplayName("强制不使用池")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:ForcePoolModeNone")]
	public bool ForcePoolModeNone;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[DisplayName("暂停优先级")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:PausePriority")]
	public int PausePriority;

	[DisplayName("暂停模式")]
	[UMeta(MD.ToolTip, "进入暂停逻辑后，此配置项决定了特效的行为")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:PauseMode")]
	public DispLibDBCPauseMode PauseMode;

	[UMeta(MD.ToolTip, "每次进入结束表现阶段时逻辑会给出此次结束表现阶段的优先级，不同原因触发的结束表现阶段其优先级可能不同;\n如果此参数小于优先级则不会进入结束表现阶段而是直接进入销毁流程;\n正常流程下因事件到达持续时间或程序通知停止而进入结束表现阶段时逻辑给出的优先级是 -1\n因角色死亡触发结束表现阶段时逻辑给出的优先级是 0\n因角色回家或土地庙重置触发结束表现阶段时逻辑给出的优先级是 0")]
	[DisplayName("结束表现阶段优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:EndStagePriority")]
	public int EndStagePriority;

	[UMeta(MD.ToolTip, "当外部请求强制设置可见性时会给定一个优先级，如果此参数大于优先级则不会受此请求的影响；\n主角因为释放人种袋变身而强制隐藏所有特效时逻辑给出的优先级是 100\n主角因为进入Seq而监听宿主Actor的Hidden状态而隐藏所有特效时逻辑给出的优先级是 50\n主角因为进入Seq而强制隐藏所有特效时逻辑给出的优先级是 10")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("强制可见性优先级")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:ForceChangeVisibleStateDEFPriority")]
	public int ForceChangeVisibleStateDEFPriority;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "如果强制设置可见性的请求允许执行，此配置决定特效的默认行为。如果需要对指定优先级的请求有不同的行为，可配置【强制可见性自定义模式】")]
	[DisplayName("强制可见性默认行为")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:ForceVisibleStateDefaultMode")]
	public DispLibDBCNiagaraForceVisibleStateMode ForceVisibleStateDefaultMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "强制可见性自定义行为")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:ForceVisibleStateCustomMode")]
	public List<BUC_DispLibUtil_ForceVisibleStateCustomMode> ForceVisibleStateCustomMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "会设置为Comp或Actor的Tag，用于对外传递一些信息，例如在 DispLogicMode = Custom 时对外标识特效的用途")]
	[DisplayName("Meta String")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:MetaString")]
	public FName MetaString;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("DBC Scalability")]
	[UMeta(MD.ToolTip, "DBC性能控制")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:ScalabilitySettings")]
	public BUC_DispLibDBC_NiagaraEventScalabilitySettings ScalabilitySettings;

	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "DBC特效合并")]
	[UMeta(MDProp.EditCondition, "Template")]
	[DisplayName("DBC 特效合并")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara:MergedSettings")]
	public BUC_DispLibDBC_NiagaraEventMergedSettings MergedSettings;

	private static int BUC_DispLibDBC_PlayAdvanceNiagara_StructSize;

	private static int BUC_DispLibDBC_PlayAdvanceNiagara_IsValid;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool DispLogicMode_IsValid;

	private static int DispLogicMode_Offset;

	private static FFieldAddress DispLogicMode_PropertyAddress;

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

	private static bool TargetSocketSearchMode_IsValid;

	private static int TargetSocketSearchMode_Offset;

	private static FFieldAddress TargetSocketSearchMode_PropertyAddress;

	private static bool AttachedTargetSocketName_IsValid;

	private static int AttachedTargetSocketName_Offset;

	private static bool OffsetInLocalSpace_IsValid;

	private static int OffsetInLocalSpace_Offset;

	private static FFieldAddress OffsetInLocalSpace_PropertyAddress;

	private static bool AttachedTargetLocationOffset_IsValid;

	private static int AttachedTargetLocationOffset_Offset;

	private static bool AttachedTargetRotationOffset_IsValid;

	private static int AttachedTargetRotationOffset_Offset;

	private static bool AttachedEmitter_IsValid;

	private static int AttachedEmitter_Offset;

	private static FFieldAddress AttachedEmitter_PropertyAddress;

	private static bool EmitterSocketSearchMode_IsValid;

	private static int EmitterSocketSearchMode_Offset;

	private static FFieldAddress EmitterSocketSearchMode_PropertyAddress;

	private static bool AttachedEmitterSocketName_IsValid;

	private static int AttachedEmitterSocketName_Offset;

	private static bool AttachedEmitterLocationOffset_IsValid;

	private static int AttachedEmitterLocationOffset_Offset;

	private static bool AttachedEmitterRotationOffset_IsValid;

	private static int AttachedEmitterRotationOffset_Offset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool SnapGround_IsValid;

	private static int SnapGround_Offset;

	private static FFieldAddress SnapGround_PropertyAddress;

	private static bool SnapGroundRotationMode_IsValid;

	private static int SnapGroundRotationMode_Offset;

	private static FFieldAddress SnapGroundRotationMode_PropertyAddress;

	private static bool CustomV4Param_IsValid;

	private static int CustomV4Param_Offset;

	private static bool SetDBCTransformAsParam_IsValid;

	private static int SetDBCTransformAsParam_Offset;

	private static FFieldAddress SetDBCTransformAsParam_PropertyAddress;

	private static bool SetSelfSKMeshParam_IsValid;

	private static int SetSelfSKMeshParam_Offset;

	private static FFieldAddress SetSelfSKMeshParam_PropertyAddress;

	private static bool SetMinorSKMeshParam_IsValid;

	private static int SetMinorSKMeshParam_Offset;

	private static FFieldAddress SetMinorSKMeshParam_PropertyAddress;

	private static bool UseExtraCustomParams_IsValid;

	private static int UseExtraCustomParams_Offset;

	private static FFieldAddress UseExtraCustomParams_PropertyAddress;

	private static bool SetScalarParam_IsValid;

	private static int SetScalarParam_Offset;

	private static FFieldAddress SetScalarParam_PropertyAddress;

	private static bool SetColorParam_IsValid;

	private static int SetColorParam_Offset;

	private static FFieldAddress SetColorParam_PropertyAddress;

	private static bool SetCurveScalarParam_IsValid;

	private static int SetCurveScalarParam_Offset;

	private static FFieldAddress SetCurveScalarParam_PropertyAddress;

	private static bool SetCurveLColorParam_IsValid;

	private static int SetCurveLColorParam_Offset;

	private static FFieldAddress SetCurveLColorParam_PropertyAddress;

	private static bool SetCurveV3Param_IsValid;

	private static int SetCurveV3Param_Offset;

	private static FFieldAddress SetCurveV3Param_PropertyAddress;

	private static bool DetachOnEndDispStageBegin_IsValid;

	private static int DetachOnEndDispStageBegin_Offset;

	private static FFieldAddress DetachOnEndDispStageBegin_PropertyAddress;

	private static bool AttachConstraintMode_IsValid;

	private static int AttachConstraintMode_Offset;

	private static FFieldAddress AttachConstraintMode_PropertyAddress;

	private static bool AttachConstraintValue_IsValid;

	private static int AttachConstraintValue_Offset;

	private static bool EnableShadow_IsValid;

	private static int EnableShadow_Offset;

	private static FFieldAddress EnableShadow_PropertyAddress;

	private static bool EnableVolumetricTranslucentShadow_IsValid;

	private static int EnableVolumetricTranslucentShadow_Offset;

	private static FFieldAddress EnableVolumetricTranslucentShadow_PropertyAddress;

	private static bool TranslucentSortPriority_IsValid;

	private static int TranslucentSortPriority_Offset;

	private static bool DeactiveAtSpawn_IsValid;

	private static int DeactiveAtSpawn_Offset;

	private static FFieldAddress DeactiveAtSpawn_PropertyAddress;

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

	private static bool ForceVisibleStateCustomMode_IsValid;

	private static int ForceVisibleStateCustomMode_Offset;

	private static FFieldAddress ForceVisibleStateCustomMode_PropertyAddress;

	private static bool MetaString_IsValid;

	private static int MetaString_Offset;

	private static bool ScalabilitySettings_IsValid;

	private static int ScalabilitySettings_Offset;

	private static bool MergedSettings_IsValid;

	private static int MergedSettings_Offset;

	public BUC_DispLibDBC_PlayAdvanceNiagara(float _Delay, DispLibDBCEndMode _EndMode, float _Duration, float _DelayTimeAfterStop, DispLibAdvanceNiagaraDispLogicMode _DispLogicMode, DispLibDBCEffectDestroyTiming _DestroyTiming, UNiagaraSystem _Template, FName _OverrideMeshCompTagName, bool _AttachedTarget, DispLibSocketSearchMode _TargetSocketSearchMode, FName _AttachedTargetSocketName, bool _OffsetInLocalSpace, FVector _AttachedTargetLocationOffset, FRotator _AttachedTargetRotationOffset, bool _AttachedEmitter, DispLibSocketSearchMode _EmitterSocketSearchMode, FName _AttachedEmitterSocketName, FVector _AttachedEmitterLocationOffset, FRotator _AttachedEmitterRotationOffset, FVector _Scale, bool _SnapGround, DispLibDBCSnapGroundRotationMode _SnapGroundRotationMode, FVector4 _CustomV4Param, bool _SetDBCTransformAsParam, bool _SetSelfSKMeshParam, bool _SetMinorSKMeshParam, bool _UseExtraCustomParams, List<BUC_DispLibUtil_NameAndScalar> _SetScalarParam, List<BUC_DispLibUtil_NameAndLColor> _SetColorParam, List<BUC_DispLibUtil_NameAndScalarCurve> _SetCurveScalarParam, List<BUC_DispLibUtil_NameAndLColorCurve> _SetCurveLColorParam, List<BUC_DispLibUtil_NameAndVectorCurve> _SetCurveV3Param, bool _DetachOnEndDispStageBegin, DispLibAttachConstraintMode _AttachConstraintMode, FVector2D _AttachConstraintValue, bool _EnableShadow, bool _EnableVolumetricTranslucentShadow, int _TranslucentSortPriority, bool _DeactiveAtSpawn, bool _ForcePoolModeNone, int _PausePriority, DispLibDBCPauseMode _PauseMode, int _EndStagePriority, int _ForceChangeVisibleStateDEFPriority, DispLibDBCNiagaraForceVisibleStateMode _ForceVisibleStateDefaultMode, List<BUC_DispLibUtil_ForceVisibleStateCustomMode> _ForceVisibleStateCustomMode, FName _MetaString, BUC_DispLibDBC_NiagaraEventScalabilitySettings _ScalabilitySettings, BUC_DispLibDBC_NiagaraEventMergedSettings _MergedSettings)
	{
		Delay = _Delay;
		EndMode = _EndMode;
		Duration = _Duration;
		DelayTimeAfterStop = _DelayTimeAfterStop;
		DispLogicMode = _DispLogicMode;
		DestroyTiming = _DestroyTiming;
		Template = _Template;
		OverrideMeshCompTagName = _OverrideMeshCompTagName;
		AttachedTarget = _AttachedTarget;
		TargetSocketSearchMode = _TargetSocketSearchMode;
		AttachedTargetSocketName = _AttachedTargetSocketName;
		OffsetInLocalSpace = _OffsetInLocalSpace;
		AttachedTargetLocationOffset = _AttachedTargetLocationOffset;
		AttachedTargetRotationOffset = _AttachedTargetRotationOffset;
		AttachedEmitter = _AttachedEmitter;
		EmitterSocketSearchMode = _EmitterSocketSearchMode;
		AttachedEmitterSocketName = _AttachedEmitterSocketName;
		AttachedEmitterLocationOffset = _AttachedEmitterLocationOffset;
		AttachedEmitterRotationOffset = _AttachedEmitterRotationOffset;
		Scale = _Scale;
		SnapGround = _SnapGround;
		SnapGroundRotationMode = _SnapGroundRotationMode;
		CustomV4Param = _CustomV4Param;
		SetDBCTransformAsParam = _SetDBCTransformAsParam;
		SetSelfSKMeshParam = _SetSelfSKMeshParam;
		SetMinorSKMeshParam = _SetMinorSKMeshParam;
		UseExtraCustomParams = _UseExtraCustomParams;
		SetScalarParam = _SetScalarParam;
		SetColorParam = _SetColorParam;
		SetCurveScalarParam = _SetCurveScalarParam;
		SetCurveLColorParam = _SetCurveLColorParam;
		SetCurveV3Param = _SetCurveV3Param;
		DetachOnEndDispStageBegin = _DetachOnEndDispStageBegin;
		AttachConstraintMode = _AttachConstraintMode;
		AttachConstraintValue = _AttachConstraintValue;
		EnableShadow = _EnableShadow;
		EnableVolumetricTranslucentShadow = _EnableVolumetricTranslucentShadow;
		TranslucentSortPriority = _TranslucentSortPriority;
		DeactiveAtSpawn = _DeactiveAtSpawn;
		ForcePoolModeNone = _ForcePoolModeNone;
		PausePriority = _PausePriority;
		PauseMode = _PauseMode;
		EndStagePriority = _EndStagePriority;
		ForceChangeVisibleStateDEFPriority = _ForceChangeVisibleStateDEFPriority;
		ForceVisibleStateDefaultMode = _ForceVisibleStateDefaultMode;
		ForceVisibleStateCustomMode = _ForceVisibleStateCustomMode;
		MetaString = _MetaString;
		ScalabilitySettings = _ScalabilitySettings;
		MergedSettings = _MergedSettings;
	}

	public BUC_DispLibDBC_PlayAdvanceNiagara Copy()
	{
		BUC_DispLibDBC_PlayAdvanceNiagara result = this;
		if (SetScalarParam != null)
		{
			result.SetScalarParam = new List<BUC_DispLibUtil_NameAndScalar>(SetScalarParam);
		}
		if (SetColorParam != null)
		{
			result.SetColorParam = new List<BUC_DispLibUtil_NameAndLColor>(SetColorParam);
		}
		if (SetCurveScalarParam != null)
		{
			result.SetCurveScalarParam = new List<BUC_DispLibUtil_NameAndScalarCurve>(SetCurveScalarParam);
		}
		if (SetCurveLColorParam != null)
		{
			result.SetCurveLColorParam = new List<BUC_DispLibUtil_NameAndLColorCurve>(SetCurveLColorParam);
		}
		if (SetCurveV3Param != null)
		{
			result.SetCurveV3Param = new List<BUC_DispLibUtil_NameAndVectorCurve>(SetCurveV3Param);
		}
		if (ForceVisibleStateCustomMode != null)
		{
			result.ForceVisibleStateCustomMode = new List<BUC_DispLibUtil_ForceVisibleStateCustomMode>(ForceVisibleStateCustomMode);
		}
		return result;
	}

	public static BUC_DispLibDBC_PlayAdvanceNiagara FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_PlayAdvanceNiagara(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_PlayAdvanceNiagara value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_PlayAdvanceNiagara FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_PlayAdvanceNiagara(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayAdvanceNiagara_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_PlayAdvanceNiagara value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayAdvanceNiagara_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayAdvanceNiagara_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
		EnumMarshaler<DispLibAdvanceNiagaraDispLogicMode>.ToNative(IntPtr.Add(nativeStruct, DispLogicMode_Offset), 0, DispLogicMode_PropertyAddress.Address, DispLogicMode);
		EnumMarshaler<DispLibDBCEffectDestroyTiming>.ToNative(IntPtr.Add(nativeStruct, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address, DestroyTiming);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, Template_Offset), Template);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, OverrideMeshCompTagName_Offset), OverrideMeshCompTagName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address, AttachedTarget);
		EnumMarshaler<DispLibSocketSearchMode>.ToNative(IntPtr.Add(nativeStruct, TargetSocketSearchMode_Offset), 0, TargetSocketSearchMode_PropertyAddress.Address, TargetSocketSearchMode);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset), AttachedTargetSocketName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OffsetInLocalSpace_Offset), 0, OffsetInLocalSpace_PropertyAddress.Address, OffsetInLocalSpace);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetLocationOffset_Offset), AttachedTargetLocationOffset);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, AttachedTargetRotationOffset_Offset), AttachedTargetRotationOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachedEmitter_Offset), 0, AttachedEmitter_PropertyAddress.Address, AttachedEmitter);
		EnumMarshaler<DispLibSocketSearchMode>.ToNative(IntPtr.Add(nativeStruct, EmitterSocketSearchMode_Offset), 0, EmitterSocketSearchMode_PropertyAddress.Address, EmitterSocketSearchMode);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttachedEmitterSocketName_Offset), AttachedEmitterSocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AttachedEmitterLocationOffset_Offset), AttachedEmitterLocationOffset);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(nativeStruct, AttachedEmitterRotationOffset_Offset), AttachedEmitterRotationOffset);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address, SnapGround);
		EnumMarshaler<DispLibDBCSnapGroundRotationMode>.ToNative(IntPtr.Add(nativeStruct, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address, SnapGroundRotationMode);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, CustomV4Param_Offset), CustomV4Param);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SetDBCTransformAsParam_Offset), 0, SetDBCTransformAsParam_PropertyAddress.Address, SetDBCTransformAsParam);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SetSelfSKMeshParam_Offset), 0, SetSelfSKMeshParam_PropertyAddress.Address, SetSelfSKMeshParam);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SetMinorSKMeshParam_Offset), 0, SetMinorSKMeshParam_PropertyAddress.Address, SetMinorSKMeshParam);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseExtraCustomParams_Offset), 0, UseExtraCustomParams_PropertyAddress.Address, UseExtraCustomParams);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndScalar>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalar, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndScalar>>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalar, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndScalar>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetScalarParam_Offset), SetScalarParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndLColor>(1, SetColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColor, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndLColor>>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColor, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndLColor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetColorParam_Offset), SetColorParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndScalarCurve>(1, SetCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalarCurve, BUC_DispLibUtil_NameAndScalarCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalarCurve, BUC_DispLibUtil_NameAndScalarCurve>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetCurveScalarParam_Offset), SetCurveScalarParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndLColorCurve>(1, SetCurveLColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColorCurve, BUC_DispLibUtil_NameAndLColorCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColorCurve, BUC_DispLibUtil_NameAndLColorCurve>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetCurveLColorParam_Offset), SetCurveLColorParam);
		new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndVectorCurve>(1, SetCurveV3Param_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndVectorCurve, BUC_DispLibUtil_NameAndVectorCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndVectorCurve, BUC_DispLibUtil_NameAndVectorCurve>.ToNative).ToNative(IntPtr.Add(nativeStruct, SetCurveV3Param_Offset), SetCurveV3Param);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address, DetachOnEndDispStageBegin);
		EnumMarshaler<DispLibAttachConstraintMode>.ToNative(IntPtr.Add(nativeStruct, AttachConstraintMode_Offset), 0, AttachConstraintMode_PropertyAddress.Address, AttachConstraintMode);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, AttachConstraintValue_Offset), AttachConstraintValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address, EnableShadow);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableVolumetricTranslucentShadow_Offset), 0, EnableVolumetricTranslucentShadow_PropertyAddress.Address, EnableVolumetricTranslucentShadow);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TranslucentSortPriority_Offset), TranslucentSortPriority);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DeactiveAtSpawn_Offset), 0, DeactiveAtSpawn_PropertyAddress.Address, DeactiveAtSpawn);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForcePoolModeNone_Offset), 0, ForcePoolModeNone_PropertyAddress.Address, ForcePoolModeNone);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
		EnumMarshaler<DispLibDBCPauseMode>.ToNative(IntPtr.Add(nativeStruct, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address, PauseMode);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset), EndStagePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ForceChangeVisibleStateDEFPriority_Offset), ForceChangeVisibleStateDEFPriority);
		EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.ToNative(IntPtr.Add(nativeStruct, ForceVisibleStateDefaultMode_Offset), 0, ForceVisibleStateDefaultMode_PropertyAddress.Address, ForceVisibleStateDefaultMode);
		new TArrayCopyMarshaler<BUC_DispLibUtil_ForceVisibleStateCustomMode>(1, ForceVisibleStateCustomMode_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ForceVisibleStateCustomMode, BUC_DispLibUtil_ForceVisibleStateCustomMode>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ForceVisibleStateCustomMode, BUC_DispLibUtil_ForceVisibleStateCustomMode>.ToNative).ToNative(IntPtr.Add(nativeStruct, ForceVisibleStateCustomMode_Offset), ForceVisibleStateCustomMode);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MetaString_Offset), MetaString);
		BUC_DispLibDBC_NiagaraEventScalabilitySettings.ToNative(IntPtr.Add(nativeStruct, ScalabilitySettings_Offset), ScalabilitySettings);
		BUC_DispLibDBC_NiagaraEventMergedSettings.ToNative(IntPtr.Add(nativeStruct, MergedSettings_Offset), MergedSettings);
	}

	public BUC_DispLibDBC_PlayAdvanceNiagara(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayAdvanceNiagara_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara");
			Delay = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			DelayTimeAfterStop = 0f;
			DispLogicMode = DispLibAdvanceNiagaraDispLogicMode.Custom;
			DestroyTiming = DispLibDBCEffectDestroyTiming.OnEndDispStageEnd;
			Template = null;
			OverrideMeshCompTagName = default(FName);
			AttachedTarget = false;
			TargetSocketSearchMode = DispLibSocketSearchMode.OnlyOriginSocket;
			AttachedTargetSocketName = default(FName);
			OffsetInLocalSpace = false;
			AttachedTargetLocationOffset = default(FVector);
			AttachedTargetRotationOffset = default(FRotator);
			AttachedEmitter = false;
			EmitterSocketSearchMode = DispLibSocketSearchMode.OnlyOriginSocket;
			AttachedEmitterSocketName = default(FName);
			AttachedEmitterLocationOffset = default(FVector);
			AttachedEmitterRotationOffset = default(FRotator);
			Scale = default(FVector);
			SnapGround = false;
			SnapGroundRotationMode = DispLibDBCSnapGroundRotationMode.HitPointNormalProjected;
			CustomV4Param = default(FVector4);
			SetDBCTransformAsParam = false;
			SetSelfSKMeshParam = false;
			SetMinorSKMeshParam = false;
			UseExtraCustomParams = false;
			SetScalarParam = null;
			SetColorParam = null;
			SetCurveScalarParam = null;
			SetCurveLColorParam = null;
			SetCurveV3Param = null;
			DetachOnEndDispStageBegin = false;
			AttachConstraintMode = DispLibAttachConstraintMode.Fixed;
			AttachConstraintValue = default(FVector2D);
			EnableShadow = false;
			EnableVolumetricTranslucentShadow = false;
			TranslucentSortPriority = 0;
			DeactiveAtSpawn = false;
			ForcePoolModeNone = false;
			PausePriority = 0;
			PauseMode = DispLibDBCPauseMode.Pause;
			EndStagePriority = 0;
			ForceChangeVisibleStateDEFPriority = 0;
			ForceVisibleStateDefaultMode = DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState;
			ForceVisibleStateCustomMode = null;
			MetaString = default(FName);
			ScalabilitySettings = default(BUC_DispLibDBC_NiagaraEventScalabilitySettings);
			MergedSettings = default(BUC_DispLibDBC_NiagaraEventMergedSettings);
		}
		else
		{
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
			DispLogicMode = EnumMarshaler<DispLibAdvanceNiagaraDispLogicMode>.FromNative(IntPtr.Add(nativeStruct, DispLogicMode_Offset), 0, DispLogicMode_PropertyAddress.Address);
			DestroyTiming = EnumMarshaler<DispLibDBCEffectDestroyTiming>.FromNative(IntPtr.Add(nativeStruct, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address);
			Template = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, Template_Offset));
			OverrideMeshCompTagName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, OverrideMeshCompTagName_Offset));
			AttachedTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachedTarget_Offset), 0, AttachedTarget_PropertyAddress.Address);
			TargetSocketSearchMode = EnumMarshaler<DispLibSocketSearchMode>.FromNative(IntPtr.Add(nativeStruct, TargetSocketSearchMode_Offset), 0, TargetSocketSearchMode_PropertyAddress.Address);
			AttachedTargetSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetSocketName_Offset));
			OffsetInLocalSpace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OffsetInLocalSpace_Offset), 0, OffsetInLocalSpace_PropertyAddress.Address);
			AttachedTargetLocationOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetLocationOffset_Offset));
			AttachedTargetRotationOffset = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, AttachedTargetRotationOffset_Offset));
			AttachedEmitter = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachedEmitter_Offset), 0, AttachedEmitter_PropertyAddress.Address);
			EmitterSocketSearchMode = EnumMarshaler<DispLibSocketSearchMode>.FromNative(IntPtr.Add(nativeStruct, EmitterSocketSearchMode_Offset), 0, EmitterSocketSearchMode_PropertyAddress.Address);
			AttachedEmitterSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttachedEmitterSocketName_Offset));
			AttachedEmitterLocationOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AttachedEmitterLocationOffset_Offset));
			AttachedEmitterRotationOffset = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(nativeStruct, AttachedEmitterRotationOffset_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			SnapGround = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address);
			SnapGroundRotationMode = EnumMarshaler<DispLibDBCSnapGroundRotationMode>.FromNative(IntPtr.Add(nativeStruct, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address);
			CustomV4Param = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, CustomV4Param_Offset));
			SetDBCTransformAsParam = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SetDBCTransformAsParam_Offset), 0, SetDBCTransformAsParam_PropertyAddress.Address);
			SetSelfSKMeshParam = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SetSelfSKMeshParam_Offset), 0, SetSelfSKMeshParam_PropertyAddress.Address);
			SetMinorSKMeshParam = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SetMinorSKMeshParam_Offset), 0, SetMinorSKMeshParam_PropertyAddress.Address);
			UseExtraCustomParams = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseExtraCustomParams_Offset), 0, UseExtraCustomParams_PropertyAddress.Address);
			SetScalarParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndScalar>(1, SetScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalar, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndScalar>>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalar, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndScalar>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetScalarParam_Offset));
			SetColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndLColor>(1, SetColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColor, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndLColor>>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColor, BlittableTypeMarshaler<BUC_DispLibUtil_NameAndLColor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetColorParam_Offset));
			SetCurveScalarParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndScalarCurve>(1, SetCurveScalarParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalarCurve, BUC_DispLibUtil_NameAndScalarCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndScalarCurve, BUC_DispLibUtil_NameAndScalarCurve>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetCurveScalarParam_Offset));
			SetCurveLColorParam = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndLColorCurve>(1, SetCurveLColorParam_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColorCurve, BUC_DispLibUtil_NameAndLColorCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndLColorCurve, BUC_DispLibUtil_NameAndLColorCurve>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetCurveLColorParam_Offset));
			SetCurveV3Param = new TArrayCopyMarshaler<BUC_DispLibUtil_NameAndVectorCurve>(1, SetCurveV3Param_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndVectorCurve, BUC_DispLibUtil_NameAndVectorCurve>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_NameAndVectorCurve, BUC_DispLibUtil_NameAndVectorCurve>.ToNative).FromNative(IntPtr.Add(nativeStruct, SetCurveV3Param_Offset));
			DetachOnEndDispStageBegin = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address);
			AttachConstraintMode = EnumMarshaler<DispLibAttachConstraintMode>.FromNative(IntPtr.Add(nativeStruct, AttachConstraintMode_Offset), 0, AttachConstraintMode_PropertyAddress.Address);
			AttachConstraintValue = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, AttachConstraintValue_Offset));
			EnableShadow = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address);
			EnableVolumetricTranslucentShadow = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableVolumetricTranslucentShadow_Offset), 0, EnableVolumetricTranslucentShadow_PropertyAddress.Address);
			TranslucentSortPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TranslucentSortPriority_Offset));
			DeactiveAtSpawn = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DeactiveAtSpawn_Offset), 0, DeactiveAtSpawn_PropertyAddress.Address);
			ForcePoolModeNone = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForcePoolModeNone_Offset), 0, ForcePoolModeNone_PropertyAddress.Address);
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
			PauseMode = EnumMarshaler<DispLibDBCPauseMode>.FromNative(IntPtr.Add(nativeStruct, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address);
			EndStagePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EndStagePriority_Offset));
			ForceChangeVisibleStateDEFPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ForceChangeVisibleStateDEFPriority_Offset));
			ForceVisibleStateDefaultMode = EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.FromNative(IntPtr.Add(nativeStruct, ForceVisibleStateDefaultMode_Offset), 0, ForceVisibleStateDefaultMode_PropertyAddress.Address);
			ForceVisibleStateCustomMode = new TArrayCopyMarshaler<BUC_DispLibUtil_ForceVisibleStateCustomMode>(1, ForceVisibleStateCustomMode_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibUtil_ForceVisibleStateCustomMode, BUC_DispLibUtil_ForceVisibleStateCustomMode>.FromNative, CachedMarshalingDelegates<BUC_DispLibUtil_ForceVisibleStateCustomMode, BUC_DispLibUtil_ForceVisibleStateCustomMode>.ToNative).FromNative(IntPtr.Add(nativeStruct, ForceVisibleStateCustomMode_Offset));
			MetaString = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MetaString_Offset));
			ScalabilitySettings = BUC_DispLibDBC_NiagaraEventScalabilitySettings.FromNative(IntPtr.Add(nativeStruct, ScalabilitySettings_Offset));
			MergedSettings = BUC_DispLibDBC_NiagaraEventMergedSettings.FromNative(IntPtr.Add(nativeStruct, MergedSettings_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara");
		BUC_DispLibDBC_PlayAdvanceNiagara_StructSize = NativeReflection.GetStructSize(intPtr);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DispLogicMode_PropertyAddress, intPtr, "DispLogicMode");
		DispLogicMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "DispLogicMode");
		DispLogicMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DispLogicMode", Classes.FEnumProperty);
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
		NativeReflection.GetPropertyRef(ref TargetSocketSearchMode_PropertyAddress, intPtr, "TargetSocketSearchMode");
		TargetSocketSearchMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetSocketSearchMode");
		TargetSocketSearchMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetSocketSearchMode", Classes.FEnumProperty);
		AttachedTargetSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetSocketName");
		AttachedTargetSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetSocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref OffsetInLocalSpace_PropertyAddress, intPtr, "OffsetInLocalSpace");
		OffsetInLocalSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetInLocalSpace");
		OffsetInLocalSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetInLocalSpace", Classes.FBoolProperty);
		AttachedTargetLocationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetLocationOffset");
		AttachedTargetLocationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetLocationOffset", Classes.FStructProperty);
		AttachedTargetRotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedTargetRotationOffset");
		AttachedTargetRotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedTargetRotationOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AttachedEmitter_PropertyAddress, intPtr, "AttachedEmitter");
		AttachedEmitter_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedEmitter");
		AttachedEmitter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedEmitter", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EmitterSocketSearchMode_PropertyAddress, intPtr, "EmitterSocketSearchMode");
		EmitterSocketSearchMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EmitterSocketSearchMode");
		EmitterSocketSearchMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EmitterSocketSearchMode", Classes.FEnumProperty);
		AttachedEmitterSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedEmitterSocketName");
		AttachedEmitterSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedEmitterSocketName", Classes.FNameProperty);
		AttachedEmitterLocationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedEmitterLocationOffset");
		AttachedEmitterLocationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedEmitterLocationOffset", Classes.FStructProperty);
		AttachedEmitterRotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachedEmitterRotationOffset");
		AttachedEmitterRotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachedEmitterRotationOffset", Classes.FStructProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SnapGround_PropertyAddress, intPtr, "SnapGround");
		SnapGround_Offset = NativeReflection.GetPropertyOffset(intPtr, "SnapGround");
		SnapGround_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SnapGround", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SnapGroundRotationMode_PropertyAddress, intPtr, "SnapGroundRotationMode");
		SnapGroundRotationMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "SnapGroundRotationMode");
		SnapGroundRotationMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SnapGroundRotationMode", Classes.FEnumProperty);
		CustomV4Param_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomV4Param");
		CustomV4Param_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomV4Param", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SetDBCTransformAsParam_PropertyAddress, intPtr, "SetDBCTransformAsParam");
		SetDBCTransformAsParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetDBCTransformAsParam");
		SetDBCTransformAsParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetDBCTransformAsParam", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SetSelfSKMeshParam_PropertyAddress, intPtr, "SetSelfSKMeshParam");
		SetSelfSKMeshParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetSelfSKMeshParam");
		SetSelfSKMeshParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetSelfSKMeshParam", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SetMinorSKMeshParam_PropertyAddress, intPtr, "SetMinorSKMeshParam");
		SetMinorSKMeshParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetMinorSKMeshParam");
		SetMinorSKMeshParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetMinorSKMeshParam", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseExtraCustomParams_PropertyAddress, intPtr, "UseExtraCustomParams");
		UseExtraCustomParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseExtraCustomParams");
		UseExtraCustomParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseExtraCustomParams", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SetScalarParam_PropertyAddress, intPtr, "SetScalarParam");
		SetScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetScalarParam");
		SetScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetColorParam_PropertyAddress, intPtr, "SetColorParam");
		SetColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetColorParam");
		SetColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetColorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetCurveScalarParam_PropertyAddress, intPtr, "SetCurveScalarParam");
		SetCurveScalarParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetCurveScalarParam");
		SetCurveScalarParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetCurveScalarParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetCurveLColorParam_PropertyAddress, intPtr, "SetCurveLColorParam");
		SetCurveLColorParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetCurveLColorParam");
		SetCurveLColorParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetCurveLColorParam", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SetCurveV3Param_PropertyAddress, intPtr, "SetCurveV3Param");
		SetCurveV3Param_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetCurveV3Param");
		SetCurveV3Param_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetCurveV3Param", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DetachOnEndDispStageBegin_PropertyAddress, intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetachOnEndDispStageBegin", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AttachConstraintMode_PropertyAddress, intPtr, "AttachConstraintMode");
		AttachConstraintMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachConstraintMode");
		AttachConstraintMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachConstraintMode", Classes.FEnumProperty);
		AttachConstraintValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachConstraintValue");
		AttachConstraintValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachConstraintValue", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref EnableShadow_PropertyAddress, intPtr, "EnableShadow");
		EnableShadow_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableShadow");
		EnableShadow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableShadow", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableVolumetricTranslucentShadow_PropertyAddress, intPtr, "EnableVolumetricTranslucentShadow");
		EnableVolumetricTranslucentShadow_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableVolumetricTranslucentShadow");
		EnableVolumetricTranslucentShadow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableVolumetricTranslucentShadow", Classes.FBoolProperty);
		TranslucentSortPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "TranslucentSortPriority");
		TranslucentSortPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TranslucentSortPriority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref DeactiveAtSpawn_PropertyAddress, intPtr, "DeactiveAtSpawn");
		DeactiveAtSpawn_Offset = NativeReflection.GetPropertyOffset(intPtr, "DeactiveAtSpawn");
		DeactiveAtSpawn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DeactiveAtSpawn", Classes.FBoolProperty);
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
		NativeReflection.GetPropertyRef(ref ForceVisibleStateCustomMode_PropertyAddress, intPtr, "ForceVisibleStateCustomMode");
		ForceVisibleStateCustomMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceVisibleStateCustomMode");
		ForceVisibleStateCustomMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceVisibleStateCustomMode", Classes.FArrayProperty);
		MetaString_Offset = NativeReflection.GetPropertyOffset(intPtr, "MetaString");
		MetaString_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MetaString", Classes.FNameProperty);
		ScalabilitySettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScalabilitySettings");
		ScalabilitySettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScalabilitySettings", Classes.FStructProperty);
		MergedSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "MergedSettings");
		MergedSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MergedSettings", Classes.FStructProperty);
		BUC_DispLibDBC_PlayAdvanceNiagara_IsValid = ((intPtr != IntPtr.Zero && Delay_IsValid && EndMode_IsValid && Duration_IsValid && DelayTimeAfterStop_IsValid && DispLogicMode_IsValid && DestroyTiming_IsValid && Template_IsValid && OverrideMeshCompTagName_IsValid && AttachedTarget_IsValid && TargetSocketSearchMode_IsValid && AttachedTargetSocketName_IsValid && OffsetInLocalSpace_IsValid && AttachedTargetLocationOffset_IsValid && AttachedTargetRotationOffset_IsValid && AttachedEmitter_IsValid && EmitterSocketSearchMode_IsValid && AttachedEmitterSocketName_IsValid && AttachedEmitterLocationOffset_IsValid && AttachedEmitterRotationOffset_IsValid && Scale_IsValid && SnapGround_IsValid && SnapGroundRotationMode_IsValid && CustomV4Param_IsValid && SetDBCTransformAsParam_IsValid && SetSelfSKMeshParam_IsValid && SetMinorSKMeshParam_IsValid && UseExtraCustomParams_IsValid && SetScalarParam_IsValid && SetColorParam_IsValid && SetCurveScalarParam_IsValid && SetCurveLColorParam_IsValid && SetCurveV3Param_IsValid && DetachOnEndDispStageBegin_IsValid && AttachConstraintMode_IsValid && AttachConstraintValue_IsValid && EnableShadow_IsValid && EnableVolumetricTranslucentShadow_IsValid && TranslucentSortPriority_IsValid && DeactiveAtSpawn_IsValid && ForcePoolModeNone_IsValid && PausePriority_IsValid && PauseMode_IsValid && EndStagePriority_IsValid && ForceChangeVisibleStateDEFPriority_IsValid && ForceVisibleStateDefaultMode_IsValid && ForceVisibleStateCustomMode_IsValid && MetaString_IsValid && ScalabilitySettings_IsValid && MergedSettings_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_PlayAdvanceNiagara", (byte)BUC_DispLibDBC_PlayAdvanceNiagara_IsValid != 0);
	}

	static BUC_DispLibDBC_PlayAdvanceNiagara()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_PlayAdvanceNiagara)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_PlayAdvanceNiagara));
	}
}
