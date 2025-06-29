using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class FSummonProcessorData
{
	public bool bSummoning { get; set; }

	public List<FTransform> SelectedPoints { get; } = new List<FTransform>();
}
