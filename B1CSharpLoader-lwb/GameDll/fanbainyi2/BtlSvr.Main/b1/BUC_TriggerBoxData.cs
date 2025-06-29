using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_TriggerBoxData
{
	private TStrongObjectPtr<AActor> mOverlappedOtherActor = new TStrongObjectPtr<AActor>();

	public AActor OverlappedOtherActor
	{
		get
		{
			return mOverlappedOtherActor.Get();
		}
		set
		{
			mOverlappedOtherActor.Set(value);
		}
	}
}
