using System.Collections.Generic;
using b1;
using B1UI;
using CommB1;
using ResB1;
using UnrealEngine.Engine;

namespace Game_Helper;

public class BuffRun
{
	private static Dictionary<string, BuffRunTemplate> buffEffect = new Dictionary<string, BuffRunTemplate>();

	public AActor Owner;

	public BGUCharacterCS OwnerAsCharacterCS;

	public BUS_GSEventCollection BUSEventCollection;

	public BGS_GSEventCollection BGSEventCollection;

	public BGW_EventCollection BGWEventCollection;

	public BuffRunComp _buffRunComp = new BuffRunComp();

	public PlayerDataMgr playerDataMgr;

	public void Init()
	{
		playerDataMgr = GSG.GamePlayer.CreateTransaction((OPReason)2);
		Owner = _buffRunComp._Owner;
		ref BGUCharacterCS ownerAsCharacterCS = ref OwnerAsCharacterCS;
		AActor owner = Owner;
		ownerAsCharacterCS = (BGUCharacterCS)(object)((owner is BGUCharacterCS) ? owner : null);
		BUSEventCollection = _buffRunComp._BUSEventCollection;
		BGSEventCollection = _buffRunComp._BGSEventCollection;
		BGWEventCollection = _buffRunComp._BGWEventCollection;
		AddBuffRun<AddItem>();
		AddBuffRun<AllTaskItem>();
		AddBuffRun<GM>();
		AddBuffRun<Ksxl>();
		AddBuffRun<UseBossSkill>();
	}

	public void AddBuffRun<T>(T Class = null) where T : BuffRunTemplate, new()
	{
		if (!buffEffect.ContainsKey(typeof(T).Name))
		{
			T val = new T();
			if (Class != null)
			{
				val = Class;
			}
			val.Init(this);
			buffEffect.Add(typeof(T).Name, val);
		}
	}

	public void Run(BuffDescRuntime buffDescRuntime, int EffectIdx)
	{
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 1);
		if (buffEffect.TryGetValue(stringEffectParam, out var value))
		{
			value.BuffRunTime(buffDescRuntime, EffectIdx);
		}
	}

	public bool IsKey(BuffDescRuntime buffDescRuntime, int EffectIdx)
	{
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
		if (stringEffectParam == null)
		{
			return false;
		}
		if (!stringEffectParam.Contains("作者：浪漫（QQ：923289638-签名防止盗版）"))
		{
			return false;
		}
		return true;
	}
}
