using System.Collections.Generic;
using b1.CppExport;

namespace b1;

public class BUC_FlowGeneralData
{
	public GameplayTagContainerRef RecentlySentNotifyTags = new GameplayTagContainerRef();

	public GameplayTagContainerRef NotifyTagsFromGraph = new GameplayTagContainerRef();

	public bool HasBegunPlay { get; set; }

	public List<FNotifyTagReplication> NotifyTagsFromAnotherComponent { get; } = new List<FNotifyTagReplication>();
}
