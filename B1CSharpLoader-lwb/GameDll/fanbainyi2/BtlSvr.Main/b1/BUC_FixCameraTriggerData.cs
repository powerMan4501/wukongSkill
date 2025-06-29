using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUC_FixCameraTriggerData
{
	private TStrongObjectPtr<AActor> mPlayerViewTarget = new TStrongObjectPtr<AActor>();

	public int TriggerCount;

	public AActor PlayerViewTarget
	{
		get
		{
			return mPlayerViewTarget.Get();
		}
		set
		{
			mPlayerViewTarget.Set(value);
		}
	}
}
