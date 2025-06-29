using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ActorCallData : b1.IBUC_ActorCallData
{
	private TStrongObjectPtr<AActor> mCallActorCls = new TStrongObjectPtr<AActor>();

	public AActor CallActorCls
	{
		get
		{
			return mCallActorCls.Get();
		}
		set
		{
			mCallActorCls.Set(value);
		}
	}
}
