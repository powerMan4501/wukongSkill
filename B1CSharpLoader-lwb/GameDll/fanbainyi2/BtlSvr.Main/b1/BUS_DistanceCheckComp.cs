using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_DistanceCheckComp : UActorCompBaseCS
{
	private b1.BUC_DistanceCheckData DistanceCheckData;

	private Dictionary<uint, b1.FDistanceCheckRequest> CheckRequests = new Dictionary<uint, b1.FDistanceCheckRequest>();

	private Dictionary<uint, float> CheckRequestTimer = new Dictionary<uint, float>();

	public override void OnAttach()
	{
		DistanceCheckData = RequireWritableData<b1.BUC_DistanceCheckData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateCheckRequests();
		if (CheckRequests.Count == 0)
		{
			return;
		}
		List<uint> list = new List<uint>();
		foreach (KeyValuePair<uint, b1.FDistanceCheckRequest> checkRequest in CheckRequests)
		{
			uint key = checkRequest.Key;
			b1.FDistanceCheckRequest value = checkRequest.Value;
			CheckRequestTimer[key] += DeltaTime;
			if (!(CheckRequestTimer[key] >= value.DeltaTime))
			{
				continue;
			}
			CheckRequestTimer[key] = 0f;
			AActor aActor = ECSUtil.ToActor(value.TargetEntity);
			if (aActor == null)
			{
				list.Add(key);
				continue;
			}
			float num = 0f;
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner) - BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
			if (value.CheckAxis == b1.EDistanceCheckAxis.XYZ)
			{
				num = Owner.GetDistanceTo(aActor);
			}
			else if (value.CheckAxis == b1.EDistanceCheckAxis.XY)
			{
				num = FMath.Sqrt(FMath.Square(fVector.X) + FMath.Square(fVector.Y));
			}
			else if (value.CheckAxis == b1.EDistanceCheckAxis.Z)
			{
				num = FMath.Abs(fVector.Z);
			}
			bool flag = false;
			if (value.CompareType == b1.EDistanceCompareType.LessThanTarget)
			{
				flag = num <= value.TargetDistance;
			}
			else if (value.CompareType == b1.EDistanceCompareType.MoreThanTarget)
			{
				flag = num >= value.TargetDistance;
			}
			if (flag && value.Callback(aActor, num))
			{
				list.Add(key);
			}
		}
		foreach (uint item in list)
		{
			CheckRequests.Remove(item);
			CheckRequestTimer.Remove(item);
		}
		list.Clear();
	}

	private void UpdateCheckRequests()
	{
		foreach (KeyValuePair<uint, b1.FDistanceCheckRequest> tempCheckRequest in DistanceCheckData.TempCheckRequests)
		{
			CheckRequests.Add(tempCheckRequest.Key, tempCheckRequest.Value);
			CheckRequestTimer.Add(tempCheckRequest.Key, 0f);
		}
		foreach (uint needRemoveCheckRequest in DistanceCheckData.NeedRemoveCheckRequests)
		{
			if (CheckRequests.ContainsKey(needRemoveCheckRequest))
			{
				CheckRequests.Remove(needRemoveCheckRequest);
				CheckRequestTimer.Remove(needRemoveCheckRequest);
			}
		}
		DistanceCheckData.TempCheckRequests.Clear();
		DistanceCheckData.NeedRemoveCheckRequests.Clear();
	}
}
