using UnrealEngine.Runtime;

namespace b1;

public interface IObserveNodeInstance
{
	void OnNotifyGraph(string Guid, FGameplayTag Tag);
}
