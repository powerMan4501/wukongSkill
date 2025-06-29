using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BGC_FieldData
{
	public readonly float UPDATE_INTERVAL = 1f;

	public float UpdateRemainTimer;

	public bool UnitDeadListenFlag;

	public Dictionary<AActor, Dictionary<int, Stack<AActor>>> InnerTargetMonitor { get; set; }

	public Dictionary<AActor, Dictionary<int, AActor>> FieldCasterRecord { get; set; }

	public BGC_FieldData()
	{
		InnerTargetMonitor = new Dictionary<AActor, Dictionary<int, Stack<AActor>>>();
		FieldCasterRecord = new Dictionary<AActor, Dictionary<int, AActor>>();
	}
}
