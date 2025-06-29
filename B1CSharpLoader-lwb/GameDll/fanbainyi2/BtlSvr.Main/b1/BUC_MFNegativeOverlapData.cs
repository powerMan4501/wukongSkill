using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUC_MFNegativeOverlapData : IBUC_MFNegativeOverlapData
{
	public UPrimitiveComponent OverlapComp;

	public HashSet<AActor> InnerActors { get; set; }

	public BUC_MFNegativeOverlapData()
	{
		InnerActors = new HashSet<AActor>();
	}
}
