using b1;
using CommB1;
using UnrealEngine.Engine;

namespace Game_Helper;

public class BuffRunTemplate
{
	protected static AActor Owner;

	protected static BGUCharacterCS OwnerAsCharacterCS;

	protected static BUS_GSEventCollection BUSEventCollection;

	protected static BGS_GSEventCollection BGSEventCollection;

	protected static BGW_EventCollection BGWEventCollection;

	protected static PlayerDataMgr playerDataMgr;

	public void BuffRunTime(BuffDescRuntime buffDescRuntime, int EffectIdx)
	{
		BuffRunTime_Implement(buffDescRuntime, EffectIdx);
	}

	protected virtual void BuffRunTime_Implement(BuffDescRuntime buffDescRuntime, int EffectIdx)
	{
	}

	public void Init(BuffRun buffRun)
	{
		Owner = buffRun.Owner;
		AActor owner = Owner;
		OwnerAsCharacterCS = (BGUCharacterCS)(object)((owner is BGUCharacterCS) ? owner : null);
		BUSEventCollection = buffRun.BUSEventCollection;
		BGSEventCollection = buffRun.BGSEventCollection;
		BGWEventCollection = buffRun.BGWEventCollection;
		playerDataMgr = buffRun.playerDataMgr;
	}

	public void UpData()
	{
		if (playerDataMgr != null)
		{
			playerDataMgr.Commit();
		}
	}
}
