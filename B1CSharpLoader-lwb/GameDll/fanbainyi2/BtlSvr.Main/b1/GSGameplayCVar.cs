using UnrealEngine.Runtime;

namespace b1;

public static class GSGameplayCVar
{
	public static GsCvarData CVar_TROSceneCounterCullEnable = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TRO.SceneInactive.CounterCull.Enable", 1, "0: disable 1：enable"));

	public static GsCvarData CVar_TROSceneCounterCullMaxCount = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TRO.SceneInactive.CounterCull.MaxCount", 15, "最大裁剪数量，SceneInactiveComp的上限"));

	public static GsCvarData CVar_TROCounterCullDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TRO.CounterCull.Debug", 0, "0: disable 1：enable"));

	public static GsCvarData CVar_TROCounterCullEnable = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TRO.CounterCull.Enable", 1, "0: disable 1：enable"));

	public static GsCvarData CVar_TROCounterCullMaxCount = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TRO.CounterCull.MaxCount", 30, "角色最大数量"));

	public static GsCvarData CVar_TROCounterNearMaxCount = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TRO.CounterCull.MaxNearCount", 15, "角色最大总是Tick数量"));

	public static GsCvarData CVar_TROCounterCullInteractObjMaxCullDistance = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TRO.CounterCull.InteractObj.MaxCullDistance", 4000f, "最远Tick裁剪距离"));

	public static GsCvarData CVar_CloseCamAdapt = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.CloseCamAdapt", 0, "Force Close GS Camera Adapt For Difference ViewPort Ratio. Enable:1  Disable:0"));

	public static GsCvarData CVar_UseBetaGM = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.UseBetaGM", 0, "Is Use Beta GM. Enable:1 Disable:0"));

	public static GsCvarData CVar_ListenerAlpha = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("test.ListenerAlpha", 100, "eg：0: 玩家位置 100：相机位置，50玩家与相机中间"));

	public static GsCvarData CVar_B1ShowDamageNumber = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.B1ShowDamageNumber", 1, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableDispInteract = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableDispInteract", 1, "0: 关闭互动 1：开启互动"));

	public static GsCvarData CVar_AnimAsyncLoadSoftRes = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.AnimAsyncLoadSoftRes", 1, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_AnimEnableABPHelperCompLODOptimize = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Anim.EnableABPHelperCompLODOptimize", 1, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_AnimEnableThreadTick = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Anim.EnableThreadTick", 1, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_AnimEnableFootIKDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Anim.EnableFootIKDebug", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_AnimDisableAMSpeedRate = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Anim.DisableAMSpeedRate", 0, "Disable: 1; Enable: 0"));

	public static GsCvarData CVar_EnableSoundLog = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("blog.EnableSoundLog", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableAtkFXLog = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("blog.EnableAtkFXLog", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableCollisionHitMove = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("blog.EnableCollisionHitMove", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableSkillCastResultLog = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("blog.EnableSkillCastResultLog", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableBeAttackedVertexAnimationLog = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("blog.EnableBeAttackedVertexAnimationLog", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableSweepCheckRuntimeShowCollision = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableSweepCheckRuntimeShowCollision", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableSweepCheckShowHitTargetCollision = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableSweepCheckShowHitTargetCollision", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableSweepCheckEndDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableSweepCheckEndDebug", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableAutoLockTargetDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableAutoLockTargetDebug", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableAttackWarningDetaectShowCollision = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableAttackWarningDetaectShowCollision", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableAttackWarningDetaectOpt = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableAttackWarningDetaectOpt", 1, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableAttackWarningRuntimeShowCollision = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableAttackWarningRuntimeShowCollision", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_FilterPlayerSweepCheck = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.FilterPlayerSweepCheck", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_DebugShowSweepCheck_SweepRange = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DebugShowSweepCheck_SweepRange", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_ForceShowSweepCheckOptCollision = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ForceShowSweepCheckOptCollision", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_DisableSweepCheckOpt = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DisableSweepCheckOpt", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_DisableSweepCheckOpt2 = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DisableSweepCheckOpt2", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_GroupLeisureDebugDraw = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.GroupLeisureDebugDraw", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_DmgCacl = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("blog.DmgCacl", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableHitMoveDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("blog.EnableHitMoveDebug", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_EnableGroundFXLog = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("blog.EnableGroundFXLog", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_DoFreshMultiTarget = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DrawDebug.DoFreshMultiTarget", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_ShowPrioritySelectUnit = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DrawDebug.ShowPrioritySelectUnit", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_ShowShapeSelectRange = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DrawDebug.ShowShapeSelectRange", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_ShowShapeSelectUnit = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DrawDebug.ShowShapeSelectUnit", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_ShowEQSResult = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DrawDebug.ShowEQSResult", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_DeadAnimPhyBlendWeight = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("test.DeadAnimPhyBlendWeight", 100, "phy weight"));

	public static GsCvarData CVar_ListenerDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("test.ListenerDebug", 0, "0: 关闭调试 1：开启调试"));

	public static GsCvarData CVar_turtleback = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("test.turtleback", 0, "Turtle Back"));

	public static GsCvarData CVar_EmptyStaminaCombo = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EmptyStaminaCombo", 0, "Can use combo skill when stamina not enough."));

	public static GsCvarData CVar_ReverseSplineFlyVerticalInput = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ReverseSplineFlyVerticalInput", 0, "Reverse up and down input when spline flying."));

	public static GsCvarData CVar_PreciseDodgeAlwaysSuccess = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.PreciseDodgeAlwaysSuccess", 0, "0：关闭, 1:开启, 精准闪避替换翻滚"));

	public static GsCvarData CVar_PreciseDodgeBeatbackCanTrigger = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.PreciseDodge.BeatbackCanTrigger", 1, "0：关闭, 1:开启, 受击能否精准闪避"));

	public static GsCvarData CVar_EnableSkillCheckerDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableSkillCheckerDebug", 0, "0：关闭, 1:开启"));

	public static GsCvarData CVar_EnableAudioObjectDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableAudioObjectDebug", 0, "声音调试用，0为关闭，1为开启"));

	public static GsCvarData CVar_EnableAudioEmitterDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableAudioEmitterDebug", 0, "点声源调试开关，0为关闭，1为开启"));

	public static GsCvarData CVar_MoveForceWalk = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Move.ForceWalk", 0, "Player force walk move. 0:Disable, 1:Enable"));

	public static GsCvarData CVar_EnableSoulCurveDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableSoulCurveDebug", 0, "0: 关闭调试 1：开启调试"));

	public static GsCvarData CVar_TamerShowDebugInfo = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Tamer.ShowDebugInfo", 0, "0: 关闭调试 1：开启调试"));

	public static GsCvarData CVar_TamerShowMonsterCount = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Tamer.ShowMonsterCount", 0, "0: 不显示怪物数量 1：显示怪物数量"));

	public static GsCvarData CVar_TamerShowAsyncTraceResult = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Tamer.ShowAsyncTraceResult", 0, "0: 不显示射线检测结果 1：显示射线检测结果"));

	public static GsCvarData CVar_TamerAsyncTraceEnable = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Tamer.AsyncTrace.Enable", 1, "0: 关闭射线检测 1：启用射线检测"));

	public static GsCvarData CVar_ECachedRepActorsnableSeqTransformDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ECachedRepActorsnableSeqTransformDebug", 0, "0: 关闭Debug, 1：开启开启"));

	public static GsCvarData CVar_GroupAIDebugInfoEnableHotZoneDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.GroupAIDebugInfo.EnableHotZoneDebug", 0, "0: 关闭Debug, 1: 开启Debug"));

	public static GsCvarData CVar_UROEnableDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("a.URO.EnableDebug", 0, "0: 关闭Debug, 1: 开启Debug"));

	public static GsCvarData CVar_GroupAIDebugInfoEnableGroupAIAreaDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.GroupAIDebugInfo.EnableGroupAIAreaDebug", 0, "0: 关闭Debug, 1: 开启Debug"));

	public static GsCvarData CVar_IntimidateDebugInfoShowIntimidateRange = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.IntimidateDebugInfo.ShowIntimidateRange", 0, "0: 关闭Debug, 1: 开启Debug"));

	public static GsCvarData CVar_EnableSpiderWebDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableSpiderWebDebug", 0, "0: 关闭蛛网Debug 1：开启蛛网Debug"));

	public static GsCvarData CVar_SkipAllPlaySequenceNode = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.SkipAllPlaySequenceNode", 0, "0: 正常播放seq 1：跳过所有结点触发的Seq"));

	public static GsCvarData CVar_SkipAllChapterMovie = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.SkipAllChapterMovie", 0, "0: 正常播放seq 1：跳过所有ChapterMovie"));

	public static GsCvarData CVar_EnableAiConversationDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableAiConversationDebug", 0, "0: 关闭 1：开启"));

	public static GsCvarData CVar_ForceFastTeleporting = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ForceFastTeleporting", 0, "0: 正常复活点/关卡传送 1：不等关卡加载完，直接传送"));

	public static GsCvarData CVar_DrawDebugSDFInfo = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("DrawDebug.SDFInfo", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_PhysAnimDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.PhysAnimDebug", 0, "show PhysAnim debug info"));

	public static GsCvarData CVar_PhysAnimImpulseScale = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.PhysAnim.ImpulseScale", 1f, "Set beattack scale. default is 1.0"));

	public static GsCvarData CVar_PhysAnimBeAtkRadius = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.PhysAnim.BeAtkRadius", 300, "BeAttack AddRadialImpulse Radius, default is 300"));

	public static GsCvarData CVar_PhysAnimEnableBeAttack = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.PhysAnim.EnableBeAttack", 1, "enable BeAttack phys anim"));

	public static GsCvarData CVar_SpiderDrawTarget = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Spider.DrawTarget", 0, "White is LastTarget, Red is CurrentTarget"));

	public static GsCvarData CVar_SkipWaitImportAsset = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.SkipWaitImportAsset", 0, "等待资源加载完毕再结束loading"));

	public static GsCvarData CVar_UIPreload = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.UIPreload", 0, "UI预加载 0编辑器下不预加载，bui加载UI, 1预加载UI, 2预加载UITex资源"));

	public static GsCvarData CVar_DebugParkour = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DebugParkour", 0, "是否显示自动翻越的判定情况: 0不显示，1显示"));

	public static GsCvarData CVar_ShowDebugBulletEQG = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ShowDebugBulletEQG", 0, "是否显示子弹EQG撒点: 0不显示，1显示"));

	public static GsCvarData CVar_DrawDebugSpiderNavigation = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DrawDebugSpiderNavigation", 0, "是否显示AI蜘蛛爬墙寻路路线: 0不显示，1显示"));

	public static GsCvarData CVar_DebugBuffHud = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DebugBuffHud", 0, "是否显示BuffHud信息: 0不显示，1显示"));

	public static GsCvarData CVar_CalliopeNodeDebugLog = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Calliope.Node.DebugLog", 0, "是否输出Calliope结点的DebugLog 0:不输出 1:输出"));

	public static GsCvarData CVar_CalliopeAssetDebugLog = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Calliope.Asset.DebugLog", 0, "是否显示Calliope资源DebugLog: 0不显示，1显示"));

	public static GsCvarData CVar_MoviePreviewEnable = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Movie.Preview.Enable", 1, "是否启用预览seq 0:不启用 1:启用"));

	public static GsCvarData CVar_ShowAutoLockDebugInfo = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ShowAutoLockDebugInfo", 0, "是否显示自动锁定信息: 0不显示，1显示"));

	public static GsCvarData CVar_UROEnable = new GsCvarData(IConsoleManager.Get().FindConsoleVariable("a.URO.Enable"));

	public static GsCvarData CVar_ShowImmobilizedDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ShowImmobilizedDebug", 0, "是否显示定身调试信息: 0不显示，1显示"));

	public static GsCvarData CVar_ScarDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ScarDebug", 0, "是否显示伤痕调试信息: 0不显示，1显示"));

	public static GsCvarData CVar_FoliageFadeDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.FoliageFadeDebug", 0, "是否显示调试信息: 0不显示，1显示"));

	public static GsCvarData CVar_DeathBlendPhysicDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DeathBlendPhysic.debug", 0, "是否显示调试信息: 0不显示，1显示"));

	public static GsCvarData CVar_TTTBTestModeDebugShape = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TTTBTestMode.DebugShape", 0, "0关闭，1开启"));

	public static GsCvarData CVar_DrawPerformerBowDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Performer.DebugBow", 0, "0关闭，1开启"));

	public static GsCvarData CVar_DisableChangeEquip = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Equip.DisableChangeEquip", 0, "【针对全局】0开启换装，1禁用换装"));

	public static GsCvarData CVar_DisableChangeEquipForPlay = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Equip.DisableChangeEquipForPlay", 0, "【针对play下看到单位】0开启换装，1禁用换装"));

	public static GsCvarData CVar_DisableChangeEquipForSystem = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Equip.DisableChangeEquipForSystem", 0, "【针对换装界面】0开启换装，1禁用换装"));

	public static GsCvarData CVar_LevelDesiredPlayerHP = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Dmg.LevelDesiredPlayerHP", 0, "关卡期望血量（用于真实伤害计算）: <=0关闭调试，>0时替换表格查询"));

	public static GsCvarData CVar_MFOverlapInterval = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.MF.MFOverlapInterval", 300, "法术场检测间隔(毫秒)"));

	public static GsCvarData CVar_EnablePlaneMoveMode = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.AutoTest.EnablePlaneMoveMode", 0, "关闭Tamer刷怪,主角屏蔽停步动画"));

	public static GsCvarData CVar_EnableAODebugMode = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.AO.Debug", 0, "0: disable 1：enable"));

	public static GsCvarData CVar_TPModeRotateIncludedAngle = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TPModeRotateIncludedAngle", 30, "TPMode下，没锁定单位，主角朝向和摄像机朝向夹角"));

	public static GsCvarData CVar_TempRemoveMuteLogic = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.TempRemoveMute", 0, "临时屏蔽进入装备场景时Mute逻辑，用于测试回声系统功能"));

	public static GsCvarData CVar_ShowProjectileCheckComp = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ShowProjectileCheckComp", 0, "Enable: 1; Disable: 0"));

	public static GsCvarData CVar_RemovePauseTPMode = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.RemovePauseTPMode", 0, "进入拍照模式时移除暂停"));

	public static GsCvarData CVar_CliffDelayDead = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.CliffDelayDead", 2000, "跳出悬崖空气墙延迟死亡时间(毫秒)"));

	public static GsCvarData CVar_EnableFallingOverTime = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableFallingOverTime", 1, "打开坠落超时死亡 0关闭，1开启"));

	public static GsCvarData CVar_GSWorkingScreenRatioAdapterFill = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.GSWorkingScreenRatioAdapterFill", 1000000, "当前工作的长宽AdapterFil值,x1000000后的值,用于通知LoadingScreen"));

	public static GsCvarData CVar_Diana_Debug_TamerDetail = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Diana.ShowDebug.TamerDetail", 0, "0:在Diana中显示 1:不显示"));

	public static GsCvarData CVar_TestForPS5ParamBiu = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ParamBiuDebug.Enable", 0, "0:不显示debug 1:显示debug"));

	public static GsCvarData CVar_AutoSkipMovies = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Movie.AutoSkip", 0, "0:不生效 1:自动跳过Seq"));

	public static GsCvarData CVar_Movie_DisableCVarCtrl = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Movie.DisableCvarCtrl", 0, "disable scalablity cvar ctrl"));

	public static GsCvarData CVar_SetCanUpdatePreloadInfo = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Diana.SetCanUpdatePreloadInfo", 0, "0:不更新 1:启动更新PreloadInfo"));

	public static GsCvarData CVar_ShowPreciseDodgeDebugDraw = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.PreciseDodge.ShowDebug.Draw", 0, "0:不显示 1:显示调试信息"));

	public static GsCvarData CVar_ShowPreciseDodgeDebugText = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.PreciseDodge.ShowDebug.Text", 0, "0:不显示 1:显示调试信息"));

	public static GsCvarData CVar_AIPathMoveToDebugDraw = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.AIPathMoveToDebug", 0, "0:不显示 1:显示调试信息"));

	public static GsCvarData CVar_CombineSweepCheckShape = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableCombineSweepCheckShape", 1, "0: 关闭, 1: 开启"));

	public static GsCvarData CVar_DebugIntervalTrigger = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.DebugIntervalTrigger", 0, "0:不显示 1:显示调试信息"));

	public static GsCvarData CVar_SyncLoadSoftResource = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.SyncLoadSoftResource", 0, "Force sync load soft resources."));

	public static GsCvarData CVar_CanSkipSeq = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.CanSkipSeq", 1, "0:无法跳过，1;可跳过"));

	public static GsCvarData CVar_IsEnableQuickPreFixCineCamera = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.IsEnableQuickPreFixCineCamera", 1, "1:启用 0:关闭 是否快速预调整CinCamera的长宽比"));

	public static GsCvarData CVar_EquipUnloadDelayTime = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EquipUnloadDelayTime", 3, "How much time to wait when certain equip is marked for unloading."));

	public static GsCvarData CVar_EquipForceUnloadMaxLimit = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EquipForceUnloadMaxLimit", 3, "If number of equip of the same EquipPosition reaches this limit, the oldest equip will get unloaded immediately regardless of EquipUnloadDelayTime."));

	public static GsCvarData CVar_NSDebug_EnableShowAllAttackRotationDebug = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.NSDebug.EnableShowAllAttackRotationDebug", 0, "是否开启全部AttackRotationDebug；0：关闭，1：开启"));

	public static GsCvarData CVar_NSDebug_ShowAMScaleDebugInfo = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.NSDebug.ShowAMScaleDebugInfo", 0, "是否开启全部AMScaleDebug；0：关闭，1：开启"));

	public static GsCvarData CVar_LowMemoryThreshold = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.LowMemoryThreshold", 1024, "低内存阈值"));

	public static GsCvarData CVar_ExitLowMemoryThreshold = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ExitLowMemoryThreshold", 1074, "脱离低内存状态的值"));

	public static GsCvarData CVar_SequenceFastForwardSkipTimeRate = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.SequenceFastForwardSkipTimeRate", 128, "快进跳过Sequence的最高播放速率"));

	public static GsCvarData CVar_EnableAutoSwitchPhysicInDeadAM = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableAutoSwitchPhysicInDeadAM", 0, "是否死亡后自动转物理【全局开关】"));

	public static GsCvarData CVar_EnableChangeTagUIColorAlpha = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.EnableChangeTagUIColorAlpha", 1, "是否允许更改TagUIColorAlpha， 0：不允许，1：允许"));

	public static GsCvarData CVar_ForceEnableAutoCameraLock = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ForceEnableAutoCameraLock", 0, "强制打开AutoCameraLock， 0：不强制打开，1：强制打开"));

	public static GsCvarData CVar_ForceEnableOnlyAutoLockTarget = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ForceEnableOnlyAutoLockTarget", 0, "强制打开OnlyAutoLockTarget， 0：不强制打开，1：强制打开"));

	public static GsCvarData CVar_ForceHidePlayerHeadEquip = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.ForceHidePlayerHeadEquip", 0, "强制HidePlayerHeadEquip， 0：不强制Hide，1：强制Hide"));

	public static GsCvarData CVar_ForceSequenceUseTickClockSource = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Movie.ClockSource.ForceTick", 0, "强制seq使用Tick时钟， 0：不强制（读表），1：强制"));

	public static GsCvarData CVar_ForceProcessGraphTick = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Process.ForceTick", 0, "强制CPG开始Tick， 0：不强制，1：强制"));

	public static GsCvarData CVar_StraightCameraVersion = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Camera.StraightVersion", 2, "直线镜头版本， 1：旧版直线镜头，2：新版直线镜头"));

	public static GsCvarData CVar_GroupAIEnableBattleFormation = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.GroupAI.EnableBattleFormation", 0, "0: 关闭战阵模式, 1: 开启战阵模式"));

	public static GsCvarData CVar_EnableDestroySequenceActor = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Movie.DestroySequenceActor.Enable", 1, "0: 禁用, 1: 启用"));

	public static GsCvarData CVar_RandomDestroyDestructible = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.Destructible.RandomDestroyTest", 0, "性能测试用，初始化时随机销毁一部分破碎物，检查性能是否有变化；仅测试用，不保证相关流程正常。 0~100: 销毁几率百分比。"));

	public static GsCvarData CVar_CSVParserShippingMode = new GsCvarData(IConsoleManager.Get().RegisterConsoleVariable("b.CSVParser.ShippingMode", 0, "允许转表工具跳过表格的Tips数据导出"));
}
