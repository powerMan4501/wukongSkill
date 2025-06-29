using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_DeadAreaLogicData
{
	private TStrongObjectPtr<AActor> mDeadActor = new TStrongObjectPtr<AActor>();

	public AActor DeadActor
	{
		get
		{
			return mDeadActor.Get();
		}
		set
		{
			mDeadActor.Set(value);
		}
	}
}
