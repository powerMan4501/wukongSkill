using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_UpdraftLogicData
{
	public List<TStrongObjectPtr<AActor>> ActorList;

	public Dictionary<int, float> CDTimerMap;

	public float UpVelocity;

	public float CD;

	public bool bEnableDebug;

	public BUC_UpdraftLogicData()
	{
		ActorList = new List<TStrongObjectPtr<AActor>>();
		CDTimerMap = new Dictionary<int, float>();
		bEnableDebug = false;
	}
}
