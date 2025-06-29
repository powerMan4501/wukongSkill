using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.AkAudio;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "切换变身音乐", "一个参数时，为DAPath", "两个参数时为开始AudioEvent路径和EndedAudioEvent路径", "有第三个参数时，含义为LeaveBattleAudioEvent路径" })]
public class BUEffectSwitchTransMusic : BUEffectTemplate
{
	public BUEffectSwitchTransMusic()
	{
		EffectType = EBuffAndSkillEffectType.SwitchTransMusic;
	}

	[ParamInfoS(2, "TransMusicLeaveBattleAudioEvent路径")]
	[ParamInfoS(0, "TransBGMConfigDA路径，参数数量大于定于2时：为TransMusicBeginAudioEvent路径")]
	[ParamInfoS(1, "TransMusicEndAudioEvent路径")]
	[TemplateFunNote("Buff触发时切换变身音乐")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target) || !BGU_DataUtil.GetIsPlayer(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime.GetEffectsCount() <= EffectIdx)
		{
			return;
		}
		int stringEffectParamCount = buffDescRuntime.GetStringEffectParamCount(EffectIdx);
		if (stringEffectParamCount == 1)
		{
			BGWTransBGMConfigDataAsset bGWTransBGMConfigDataAsset = BGW_PreloadAssetMgr.Get(Target.World).TryGetCachedResourceObj<BGWTransBGMConfigDataAsset>(buffDescRuntime.GetStringEffectParam(EffectIdx, 0), ELoadResourceType.SyncLoadAndCache);
			BGS_EventCollectionCS.Get(Target)?.Evt_BGS_TryPlayTransMusic.Invoke(new BGMWrap(ECSUtil.ToEntity(Target), bGWTransBGMConfigDataAsset.TransBGMConfig.AkEventBegin, bGWTransBGMConfigDataAsset.TransBGMConfig.AkEventStop, new Dictionary<EBGMStopCondition, BGMStopEventInfo> { 
			{
				EBGMStopCondition.LeaveBattle,
				new BGMStopEventInfo(bGWTransBGMConfigDataAsset.TransBGMConfig.LeaveBattleEventStop)
			} }));
		}
		else if (stringEffectParamCount >= 2)
		{
			UAkAudioEvent akEventBegin = BGW_PreloadAssetMgr.Get(Target.World).TryGetCachedResourceObj<UAkAudioEvent>(buffDescRuntime.GetStringEffectParam(EffectIdx, 0), ELoadResourceType.SyncLoadAndCache);
			UAkAudioEvent akEventStop = BGW_PreloadAssetMgr.Get(Target.World).TryGetCachedResourceObj<UAkAudioEvent>(buffDescRuntime.GetStringEffectParam(EffectIdx, 1), ELoadResourceType.SyncLoadAndCache);
			if (stringEffectParamCount == 2)
			{
				BGS_EventCollectionCS.Get(Target)?.Evt_BGS_TryPlayTransMusic.Invoke(new BGMWrap(ECSUtil.ToEntity(Target), akEventBegin, akEventStop));
				return;
			}
			UAkAudioEvent stopEvent = BGW_PreloadAssetMgr.Get(Target.World).TryGetCachedResourceObj<UAkAudioEvent>(buffDescRuntime.GetStringEffectParam(EffectIdx, 2), ELoadResourceType.SyncLoadAndCache);
			BGS_EventCollectionCS.Get(Target)?.Evt_BGS_TryPlayTransMusic.Invoke(new BGMWrap(ECSUtil.ToEntity(Target), akEventBegin, akEventStop, new Dictionary<EBGMStopCondition, BGMStopEventInfo> { 
			{
				EBGMStopCondition.LeaveBattle,
				new BGMStopEventInfo(stopEvent)
			} }));
		}
	}

	[TemplateFunNote("Buff移除时根据单位Entity恢复之前的设置")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BGS_EventCollectionCS.Get(Target)?.Evt_BGS_TryStopTransMusic.Invoke(ECSUtil.ToEntity(Target));
	}
}
