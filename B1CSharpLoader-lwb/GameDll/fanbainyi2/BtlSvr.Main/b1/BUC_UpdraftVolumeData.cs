using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_UpdraftVolumeData
{
	public List<TStrongObjectPtr<AActor>> ActorList;

	public Dictionary<int, float> CDTimerMap;

	public BUC_UpdraftVolumeData()
	{
		ActorList = new List<TStrongObjectPtr<AActor>>();
		CDTimerMap = new Dictionary<int, float>();
	}
}
