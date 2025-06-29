using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_QuestData
{
	public Dictionary<FGameplayTag, string> LastNotifyGraphRecord { get; } = new Dictionary<FGameplayTag, string>();

	public QuestInstance RootInstance { get; set; }

	public MultiMap<string, IObserveNodeInstance> ObservingActorNodeMultiMap { get; } = new MultiMap<string, IObserveNodeInstance>();

	public MultiMap<IObserveNodeInstance, string> ObservingNodeMultiMap { get; } = new MultiMap<IObserveNodeInstance, string>();
}
