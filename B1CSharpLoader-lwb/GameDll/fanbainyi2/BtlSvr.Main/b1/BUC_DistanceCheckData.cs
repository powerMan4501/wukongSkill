using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

internal class BUC_DistanceCheckData
{
	public delegate bool Del_DistanceCheck(AActor Target, float CurrentDistance);

	public Dictionary<uint, b1.FDistanceCheckRequest> TempCheckRequests = new Dictionary<uint, b1.FDistanceCheckRequest>();

	public List<uint> NeedRemoveCheckRequests = new List<uint>();

	private uint RequestIdx;

	public uint AddCheckRequest(AActor TargetActor, float TargetDistance, Del_DistanceCheck Callback, b1.EDistanceCompareType CompareType = b1.EDistanceCompareType.LessThanTarget, b1.EDistanceCheckAxis CheckAxis = b1.EDistanceCheckAxis.XYZ, float CheckDeltaTime = 0.01f)
	{
		b1.FDistanceCheckRequest value = new b1.FDistanceCheckRequest
		{
			TargetEntity = ECSUtil.ToEntity(TargetActor),
			TargetDistance = TargetDistance,
			CompareType = CompareType,
			CheckAxis = CheckAxis,
			DeltaTime = CheckDeltaTime,
			Callback = Callback
		};
		TempCheckRequests.Add(RequestIdx, value);
		return RequestIdx++;
	}

	public void RemoveCheckRequest(uint RequestIdx)
	{
		NeedRemoveCheckRequests.Add(RequestIdx);
	}
}
