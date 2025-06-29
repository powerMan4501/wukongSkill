using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EBGUSimpleState")]
public enum EBGUSimpleState : byte
{
	Normal = 0,
	[Tooltip("免疫伤害")]
	ImmueDamage = 1,
	[Tooltip("无法攻击")]
	CantAttack = 2,
	[Tooltip("无法移动")]
	CantMove = 3,
	[Tooltip("取消救命毫毛冷却")]
	[UseInProgramOnly]
	CancelLifeSavingCD = 4,
	[Tooltip("攻击无视对方属性抗性")]
	IgnoreTargetElemDef = 5,
	[Tooltip("ignore all player input.")]
	IgnoreAllInput = 6,
	[Tooltip("可命中子弹")]
	CanHitBullet = 7,
	[UseInProgramOnly]
	[Tooltip("棍势清空保护状态")]
	PEClearProtect = 8,
	[UseInProgramOnly]
	[Tooltip("定身")]
	Immobilizing = 9,
	[Tooltip("免疫非属性伤害")]
	ImmueDmgExceptElementDmg = 10,
	[Tooltip("免疫冰冻积累")]
	ImmueFreezeAcc = 11,
	[Tooltip("所有操作无效, 但除了操作镜头")]
	BanInputButCamera = 12,
	[Tooltip("标识受击动画中可以开始融入死亡动画的阶段")]
	[UseInProgramOnly]
	CanBlendToDeadAM = 13,
	[Tooltip("免疫冰冻破碎动画")]
	ImmueFrozenBrokenAM = 14,
	[Tooltip("无法死亡【最好不要再用了，有坑。新增锁1血不死SimpleState-CantBeDead1HP（173）】")]
	CantBeDead = 15,
	[Tooltip("禁止播放摇冰动画")]
	CantPlayShakeFreezeAM = 16,
	[Tooltip("免疫硬直")]
	ImmueStiff = 17,
	[Tooltip("免疫定身")]
	ImmueImmobilizing = 18,
	[Tooltip("免疫动画同步（抓投）")]
	ImmueAnimationSyncing = 19,
	[Tooltip("禁用所有救命毫毛手段（状态在受击者身上）")]
	ForbidAllLifeSavingHair = 20,
	[Tooltip("禁用除九转还魂丹外的所有救命毫毛手段（状态在受击者身上）")]
	ForbidAllLifeSavingHairExceptJZHHD = 21,
	[Tooltip("部位破坏后虚弱")]
	[UseInProgramOnly]
	BreakPart2Weak = 22,
	[Tooltip("免疫火积累")]
	ImmueBurnAcc = 23,
	[Tooltip("免疫毒积累")]
	ImmuePoisonAcc = 24,
	[Tooltip("免疫雷积累")]
	ImmueThunderAcc = 25,
	[Tooltip("阻止扫描单位判定击中(不包含BulletSweepCheck)")]
	CantSweepUnit = 26,
	[Tooltip("使用CarMontageMoveMode移动")]
	UseCarMontageMoveMode = 27,
	[Tooltip("阻止被SweepCheck(包含BulletSweepCheck)")]
	CantBeSweepChecked = 28,
	[Tooltip("免疫DeadZone")]
	ImmueDeadZone = 29,
	[Tooltip("标记单位不可以被锁定（主要是用在主角身上）")]
	CantBeLock = 30,
	[Tooltip("体力用尽气绝状态")]
	StaminaDepleted = 31,
	[Tooltip("勾引出招")]
	SeduceAttack = 32,
	[Tooltip("无CD")]
	[UseInProgramOnly]
	CancelSkillCD = 33,
	[Tooltip("强制缓慢移动")]
	MoveSlowly = 35,
	[Tooltip("无法成为目标【超强隐身，忽略一切反隐】【谨慎配置，目前应该只用在GM测试中使用】")]
	CantBeBaseTarget = 38,
	[Tooltip("技能霸体护甲状态")]
	SkillSuperArmor = 39,
	[Tooltip("锁定耐力")]
	StaminaLock = 40,
	[Tooltip("反击技触发成功（触发成功，下一帧才开始播放动画）添加一帧受击保护状态，避免同一帧再进来一次NormalStiff事件")]
	HRCounterattackProtectOneFrame = 42,
	[Tooltip("技能霸体护甲破碎")]
	[UseInProgramOnly]
	BreakSkillSuperArmor = 43,
	[Tooltip("沉默(无法释放技能)")]
	Silent = 44,
	[Tooltip("受击触发弹刀")]
	BounceAttack = 45,
	[Tooltip("蓄力技时期可以强制出击（忽略ComboWindow等限制）")]
	CanForceAttackInChargeSkill = 47,
	[Tooltip("受击时可播放融合受击")]
	CanTriggerBeHitAdditiveAnim = 48,
	[Tooltip("上半身动态混合模式，只在有移动输入混上半身")]
	DynamicUpperBodyMode = 50,
	[Tooltip("左臂动态混合模式，只在有移动输入混左臂")]
	DynamicLeftArmMode = 51,
	[Tooltip("右臂动态混合模式，只在有移动输入混右臂")]
	DynamicRightArmMode = 52,
	[Tooltip("锁定状态下强制Walk速度移动，主角变身怪物后适配锁定状态MM")]
	LockStateWalking = 53,
	[Tooltip("飞行移动状态")]
	FlyControlMode = 54,
	[Tooltip("转转棍模式")]
	TPSMode = 55,
	[Tooltip("玩家在Seq中标识")]
	PlayerInSeq = 56,
	[Tooltip("受击者有此状态被击中时，攻击者不播攻击表现")]
	ImmueAttackPerformEffect = 57,
	[Tooltip("禁用受击者顿帧")]
	DisableFreezeFrame = 58,
	[Tooltip("受击者有此状态被击中时，受击者不播受击表现，受击特效，受击音效")]
	ImmueBeAttackedPerformEffect = 59,
	[Tooltip("保持MM运转,（abp用，暂无找到其他解决方法，先通过标记特定情况,使MM状态机节点在该状态下Blend 0.01）")]
	KeepMMRunning = 61,
	[Tooltip("可击溃铜头铁臂")]
	CanDefeatTTTB = 62,
	[Tooltip("静音，关闭单位AK")]
	Mute = 63,
	[Tooltip("锁定旋转")]
	LockRotation = 64,
	[Tooltip("不可被感知（无论是否被锁定，加该状态都无法成为目标）【对于可发现隐身单位的怪物无效】")]
	Imperceptible = 66,
	[Tooltip("忽略敌对行为")]
	IgnoreHostile = 68,
	[UseInProgramOnly]
	[Tooltip("正在转阶段")]
	InPhaseTransition = 69,
	[UseInProgramOnly]
	[Tooltip("被点吸附")]
	InPointAttraction = 71,
	[Tooltip("强制表演状态")]
	[UseInProgramOnly]
	ForcePerformance = 72,
	[Tooltip("主角无法锁定目标")]
	PlayerCantLock = 73,
	[Tooltip("可以触发格挡（一般情况）")]
	CanTriggerBlockNormal = 74,
	[Tooltip("强制出击（忽略ComboWindow等限制）")]
	[UseInProgramOnly]
	ForceSkill = 75,
	[Tooltip("格挡崩坏状态")]
	[UseInProgramOnly]
	BreakBlock = 76,
	[UseInProgramOnly]
	[Tooltip("正在动画同步（抓投），用于标记从抓投判定成功到同步动画结束")]
	InAnimationSyncing = 77,
	[Tooltip("可以触发格挡（处于特殊状态下，如AttackState）")]
	[UseInProgramOnly]
	CanTriggerBlockInSPState = 78,
	[UseInProgramOnly]
	[Tooltip("格挡崩坏虚弱状态")]
	BreakBlock2Weak = 79,
	[Tooltip("处于铜头铁臂中")]
	InTTTB = 80,
	[Tooltip("允许MontageSection跳转")]
	MontageSectionJumpApproved = 81,
	[Tooltip("冻结")]
	[UseInProgramOnly]
	Frozen = 82,
	[Tooltip("冰免")]
	FreezeImmue = 83,
	[Tooltip("火免")]
	BurnImmue = 84,
	[Tooltip("毒免")]
	PoisonImmue = 85,
	[Tooltip("雷免")]
	ThunderImmue = 86,
	[Tooltip("物理模拟移动模式")]
	[UseInProgramOnly]
	PhysicsSimulationMoveMode = 87,
	[Tooltip("聚形散气状态")]
	[UseInProgramOnly]
	PhantomRush = 88,
	[UseInProgramOnly]
	[Tooltip("打破定身虚弱")]
	BreakImmobilize2Weak = 89,
	[UseInProgramOnly]
	[Tooltip("被嘲讽")]
	BeTaunted = 90,
	[Tooltip("样条线飞行等待中")]
	[UseInProgramOnly]
	SplineFlyWaiting = 91,
	[Tooltip("玩家死亡不扣道行点")]
	PlayerDeadNoPunish = 92,
	[Tooltip("蛛丝阻力移动")]
	SpiderSilkyHardMoving = 93,
	[Tooltip("冰冻阻力移动")]
	FrozenMoving = 94,
	[Tooltip("泥泞阻力移动")]
	MuddyMoving = 95,
	[Tooltip("大风阻力移动")]
	WinddyMoving = 96,
	[Tooltip("免疫Category为Neutral的Buff/Effect")]
	ImmuneNeutral = 97,
	[Tooltip("免疫Category为Positive的Buff/Effect")]
	ImmunePositive = 98,
	[Tooltip("免疫Category为Negative的Buff/Effect")]
	ImmuneNegative = 99,
	[UseInProgramOnly]
	[Tooltip("在上升气流中")]
	InUpdraft = 100,
	[UseInProgramOnly]
	[Tooltip("交互中")]
	Interacting = 101,
	[Tooltip("不允许显示血条")]
	CantShowBlood = 102,
	[UseInProgramOnly]
	[Tooltip("抓投中非DeathWindow中死亡")]
	PendingDeathInAnimationSyncing = 103,
	[Tooltip("无法使用所有法术")]
	IgnoreSpell = 104,
	[Tooltip("无法使用RollSkill")]
	IgnoreRollSkill = 105,
	[Tooltip("无法使用变身技能")]
	IgnoreUnitTransSkill = 107,
	[Tooltip("无法切换转棍模式输入")]
	IgnoreSpinLightInput = 108,
	[Tooltip("无法交互输入")]
	IgnoreInteractInput = 109,
	[Tooltip("无法移动输入")]
	IgnoreMoveInput = 110,
	[Tooltip("无法跳跃输入")]
	IgnoreJumpInput = 111,
	[Tooltip("无法轻棍输入")]
	IgnoreLightAttackInput = 112,
	[Tooltip("无法重棍输入")]
	IgnoreHeavyAttackInput = 113,
	[Tooltip("阴免")]
	YinImmue = 114,
	[Tooltip("阳免")]
	YangImmue = 115,
	[Tooltip("普通伤害免疫")]
	CommonDamageImmue = 116,
	[Tooltip("强力伤害免疫")]
	StrongDamageImmue = 117,
	[Tooltip("忽略将胶囊与曲面对齐")]
	IgnoreAlignCapsule2Surface = 118,
	[Tooltip("处于蜘蛛海中")]
	WithinOceanSea = 119,
	[Tooltip("变身死亡时不退出变身")]
	NoAutoTransformBack = 120,
	[Tooltip("死亡时使用固定镜头 (神猎石敢当防止镜头穿插用)")]
	DeadUseFixCamera = 121,
	[Tooltip("无法使用向后移动输入")]
	[UseInProgramOnly]
	IgnoreMoveBackInput = 123,
	[Tooltip("无法使用左右移动输入")]
	[UseInProgramOnly]
	IgnoreXAxisMoveInput = 124,
	[Tooltip("禁用自动回复冰异常状态")]
	[UseInProgramOnly]
	DisableAutoRecoverFreeze = 125,
	[Tooltip("禁用自动回复燃烧异常状态")]
	[UseInProgramOnly]
	DisableAutoRecoverBurn = 126,
	[UseInProgramOnly]
	[Tooltip("禁用自动回复毒异常状态")]
	DisableAutoRecoverPoison = 127,
	[UseInProgramOnly]
	[Tooltip("禁用自动回复雷异常状态")]
	DisableAutoRecoverThunder = 128,
	[Tooltip("禁用自动回复阴异常状态")]
	[UseInProgramOnly]
	DisableAutoRecoverYin = 129,
	[Tooltip("禁用自动回复阳异常状态")]
	[UseInProgramOnly]
	DisableAutoRecoverYang = 130,
	[Tooltip("仇恨更新开关")]
	CantHatredTick = 133,
	[Tooltip("狂暴状态")]
	[UseInProgramOnly]
	Berserk = 134,
	[Tooltip("UnitBar的显示与否忽略BattleInfo信息")]
	IgnoreBattleInfoInUnitBar = 135,
	[Tooltip("技能表演中，不能退出变身")]
	CantTransBack = 136,
	[Tooltip("锁变身能量")]
	TransEnergyLock = 137,
	[Tooltip("锁棍势能量")]
	PELock = 138,
	[Tooltip("转移伤害到root角色")]
	DamageTransfer = 139,
	[Tooltip("骑行退出状态")]
	[UseInProgramOnly]
	RidingExitingStatus = 140,
	[Tooltip("不能变身")]
	CantTrans = 141,
	[Tooltip("屏蔽大圣天赋")]
	BanLegacyTalent = 142,
	[UseInProgramOnly]
	[Tooltip("使用筋斗云")]
	CloudMove = 143,
	[Tooltip("蟋蟀待机")]
	[UseInProgramOnly]
	CricketIdle = 144,
	[Tooltip("禁用定身破碎动画")]
	DisableImmobilizedBreakAnim = 145,
	[Tooltip("启用特殊定身破碎动画")]
	EnableSpecialImmobilizedBreakAnim = 146,
	[Tooltip("锁法宝能量")]
	FabaoEnergyLock = 147,
	[Tooltip("锁精魄能量")]
	VigorEnergyLock = 148,
	[Tooltip("无法获得法宝能量")]
	CantGainFabaoEnergy = 149,
	[Tooltip("无法获得精魄能量")]
	CantGainVigorEnergy = 150,
	[Tooltip("蟋蟀拔须交互Loop")]
	InteractCricketLoop = 151,
	[Tooltip("正在动画同步（交互）")]
	InInteractAnimationSyncing = 152,
	[Tooltip("拒绝AtkRotation对准")]
	RefuseAttackRotation = 153,
	[Tooltip("拒绝AMScale对准")]
	RefuseAMScale = 154,
	[Tooltip("禁用反击技并清空反击技状态")]
	DisableHRCounterAttack = 155,
	[Tooltip("受伤不显示伤害数字")]
	DisableDamageNumUI = 156,
	[Tooltip("伪装（未被锁定时，加该状态可以隐身，期间无法被发现；被锁定时，加该状态无法解除被锁定状态，仍然会被继续攻击）【对于可发现隐身单位的怪物无效】")]
	Camouflage = 157,
	[Tooltip("主角用,不显示锁定白点UI")]
	CantShowLock = 158,
	[Tooltip("用于标记从抓投判定成功到PreCheck notify结束")]
	[UseInProgramOnly]
	PreAnimationSyncing = 159,
	[Tooltip("禁止使用精魄技能")]
	IgnoreVigorSkill = 160,
	[Tooltip("禁止处于精魄状态")]
	CantInVigorSkill = 161,
	[Tooltip("不可交互")]
	CantInteract = 162,
	[Tooltip("反隐")]
	Sentry = 163,
	[Tooltip("锁蓝")]
	LockMP = 164,
	[Tooltip("无法成为自动锁定目标")]
	CantBeAutoLockTarget = 165,
	[Tooltip("禁止显示主角相关伤害数字")]
	CantShowDamageUI = 166,
	[Tooltip("锁定目标用,不显示锁定白点UI")]
	TargetCantShowLock = 167,
	[Tooltip("禁止触发精准闪避")]
	CantTriggerPreciseDodge = 168,
	[Tooltip("禁止变身大圣")]
	BanTrans2DaSheng = 169,
	[Tooltip("禁止使用法宝")]
	CantCastFaBao = 170,
	[Tooltip("Seq中禁变身标识")]
	CantTransInSeq = 171,
	[Tooltip("禁止使用道具")]
	IgnoreUseItem = 172,
	[Tooltip("新无法死亡(锁1血版本)")]
	CantBeDead1HP = 173,
	EnumMax = 174
}
