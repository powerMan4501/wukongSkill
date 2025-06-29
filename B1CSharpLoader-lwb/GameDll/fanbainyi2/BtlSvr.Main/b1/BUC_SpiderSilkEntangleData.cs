using b1.ECS;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SpiderSilkEntangleData : IBUC_SpiderSilkEntangleData, IPersistentECSData
{
	public bool bInSpiderSilkEntangleState { get; set; }

	public bool bHandleSpiderSilkyHardMovingBuff { get; set; }

	public TStrongObjectPtr<BGWDataAsset_SpiderSilkEntangleConfig> mSpiderSilkEntangleConfig { get; set; }

	public BGWDataAsset_SpiderSilkEntangleConfig SpiderSilkEntangleConfig
	{
		get
		{
			return mSpiderSilkEntangleConfig.Get();
		}
		set
		{
			mSpiderSilkEntangleConfig.Set(value);
		}
	}

	public TStrongObjectPtr<UNiagaraComponent> mNiagaraComp { get; set; }

	public UNiagaraComponent NiagaraComp
	{
		get
		{
			return mNiagaraComp.Get();
		}
		set
		{
			mNiagaraComp.Set(value);
		}
	}

	private float Count { get; set; }

	public float SpeedMonitor_Interval_Timer { get; set; }

	public uint DBCReqID { get; set; }

	public BUC_SpiderSilkEntangleData()
	{
		bInSpiderSilkEntangleState = false;
		bHandleSpiderSilkyHardMovingBuff = false;
		mSpiderSilkEntangleConfig = new TStrongObjectPtr<BGWDataAsset_SpiderSilkEntangleConfig>();
		mNiagaraComp = new TStrongObjectPtr<UNiagaraComponent>();
		Count = 0f;
		SpeedMonitor_Interval_Timer = 0f;
		DBCReqID = 0u;
	}

	public void AddCount(float Value)
	{
		if (bInSpiderSilkEntangleState && !(SpiderSilkEntangleConfig == null))
		{
			Count = MathLib.Clamp(Count + Value, 0f, SpiderSilkEntangleConfig.MaxCount);
		}
	}

	public float GetCount()
	{
		return Count;
	}

	public void ResetCount()
	{
		Count = 0f;
	}
}
