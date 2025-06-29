using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_LogComp : UActorCompBaseCS
{
	private BUC_LogData LogData;

	public override void OnAttach()
	{
		base.OnAttach();
		LogData = RequireWritableData<BUC_LogData>();
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		BUC_LogData.IsUsedGM = false;
		LogData.StartTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}
}
