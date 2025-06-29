using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_EnvMgrData : IBGC_EnvMgrData, IPersistentECSData
{
	private TStrongObjectPtr<BGUEnvironmentSurfaceEffectMgr> mEffectMgr = new TStrongObjectPtr<BGUEnvironmentSurfaceEffectMgr>();

	public BGUEnvironmentSurfaceEffectMgr EffectMgr
	{
		get
		{
			return mEffectMgr.Get();
		}
		set
		{
			mEffectMgr.Set(value);
		}
	}
}
