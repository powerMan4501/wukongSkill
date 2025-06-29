using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_MagicFieldParamData : b1.IBUC_MagicFieldParamData
{
	public Dictionary<int, b1.MagicFieldDirectionInfo> MagicFieldDirection { get; set; }

	public FVector GetMFDirectionByUsage(EMagicFieldDirectionUsage Usage)
	{
		FVector zeroVector = FVector.ZeroVector;
		foreach (KeyValuePair<int, b1.MagicFieldDirectionInfo> item in MagicFieldDirection)
		{
			if (item.Value.Usage == Usage)
			{
				zeroVector += item.Value.Direction;
			}
		}
		return zeroVector;
	}
}
