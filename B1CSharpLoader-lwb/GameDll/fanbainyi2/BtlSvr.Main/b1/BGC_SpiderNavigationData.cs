using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_SpiderNavigationData : IBGC_SpiderNavigationData, IPersistentECSData
{
	public List<FSpiderNavMeshBlockInfo> NavMeshes { get; set; }

	public BGC_SpiderNavigationData()
	{
		NavMeshes = new List<FSpiderNavMeshBlockInfo>();
	}

	public List<FSpiderNavPointInfo> TryFindPath(FVector StartPos, ESpiderNavPositionType StartPosType, FVector TargetPos, FVector TargetPosNormal, ESpiderNavPositionType TargetPosType)
	{
		List<FSpiderNavPointInfo> list = new List<FSpiderNavPointInfo>();
		Dictionary<int, FSpiderNavPointInfo> EndPointConnectedPoints = new Dictionary<int, FSpiderNavPointInfo>();
		EndPointConnectedPoints.Add(-1, new FSpiderNavPointInfo(StartPos, FVector.ZeroVector, 0f, StartPosType == ESpiderNavPositionType.Ground));
		EndPointConnectedPoints.Add(-2, new FSpiderNavPointInfo(TargetPos, TargetPosNormal, 0f, TargetPosType == ESpiderNavPositionType.Ground));
		RegisterEndPoint(TargetPos, out var BlockIndex, ref EndPointConnectedPoints, -2);
		if (BlockIndex < 0 || !TryRegisterEndPoinToBlock(StartPos, BlockIndex, ref EndPointConnectedPoints, -1))
		{
			return list;
		}
		Dictionary<int, FSpiderNavPathFindingPoint> SearchedList = new Dictionary<int, FSpiderNavPathFindingPoint> { 
		{
			-2,
			new FSpiderNavPathFindingPoint(-2, -1, 0f, CalPredictionCost(BlockIndex, StartPos, -2, EndPointConnectedPoints))
		} };
		List<int> list2 = new List<int> { -2 };
		bool flag = false;
		while (list2.Count > 0)
		{
			int num = list2[0];
			foreach (FSpiderNavPointLinkInfo navLink in GetPointInfoWithExpandPoints(BlockIndex, num, EndPointConnectedPoints).NavLinks)
			{
				float num2 = SearchedList[num].Cost_F + navLink.Cost;
				if (SearchedList.ContainsKey(navLink.LinkPointIndex))
				{
					if (list2.Contains(navLink.LinkPointIndex) && SearchedList[navLink.LinkPointIndex].Cost_F > num2)
					{
						SearchedList[navLink.LinkPointIndex].FatherPointIndex = num;
						SearchedList[navLink.LinkPointIndex].Cost_F = num2;
					}
				}
				else
				{
					SearchedList.Add(navLink.LinkPointIndex, new FSpiderNavPathFindingPoint(navLink.LinkPointIndex, num, num2, CalPredictionCost(BlockIndex, StartPos, navLink.LinkPointIndex, EndPointConnectedPoints)));
					list2.Add(navLink.LinkPointIndex);
				}
				if (-1 == navLink.LinkPointIndex)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				break;
			}
			list2.RemoveAt(0);
			list2.Sort((int x, int y) => (!(SearchedList[x].Cost_F + SearchedList[x].Cost_G < SearchedList[y].Cost_F + SearchedList[y].Cost_G)) ? 1 : (-1));
		}
		if (flag)
		{
			int fatherPointIndex;
			for (fatherPointIndex = SearchedList[-1].FatherPointIndex; fatherPointIndex != -2; fatherPointIndex = SearchedList[fatherPointIndex].FatherPointIndex)
			{
				list.Add(GetPointInfoWithExpandPoints(BlockIndex, fatherPointIndex, EndPointConnectedPoints));
			}
			list.Add(GetPointInfoWithExpandPoints(BlockIndex, fatherPointIndex, EndPointConnectedPoints));
		}
		return list;
	}

	private FSpiderNavPointInfo GetPointInfoWithExpandPoints(int BlockIndex, int PointIndex, Dictionary<int, FSpiderNavPointInfo> ExpandPoints)
	{
		if (ExpandPoints.TryGetValue(PointIndex, out var value))
		{
			return value;
		}
		return NavMeshes[BlockIndex].NavPoints[PointIndex];
	}

	private float CalPredictionCost(int BlockIndex, FVector TargetPos, int PointIndex, Dictionary<int, FSpiderNavPointInfo> EndPointExpandPoints)
	{
		return (TargetPos - GetPointInfoWithExpandPoints(BlockIndex, PointIndex, EndPointExpandPoints).PointLocation).Size();
	}

	private void RegisterEndPoint(FVector Position, out int BlockIndex, ref Dictionary<int, FSpiderNavPointInfo> EndPointConnectedPoints, int EndPointIndex)
	{
		BlockIndex = -1;
		int num = -1;
		float num2 = float.MaxValue;
		List<List<int>> list = new List<List<int>>();
		for (int i = 0; i < NavMeshes.Count; i++)
		{
			List<int> list2 = new List<int>();
			for (int j = 0; j < NavMeshes[i].NavPoints.Count; j++)
			{
				if (EndPointConnectedPoints[EndPointIndex].IsGroundPoint && !NavMeshes[i].NavPoints[j].IsGroundPoint)
				{
					continue;
				}
				float num3 = (NavMeshes[i].NavPoints[j].PointLocation - Position).Size();
				if (EndPointConnectedPoints[EndPointIndex].IsGroundPoint || !(num3 > NavMeshes[i].NavPoints[j].LinkRadius))
				{
					list2.Add(j);
					if (BlockIndex == -1 || num == -1 || num3 < num2)
					{
						BlockIndex = i;
						num = j;
						num2 = num3;
					}
				}
			}
			list.Add(list2);
		}
		if (BlockIndex < 0)
		{
			return;
		}
		foreach (int item in list[BlockIndex])
		{
			float cost = (NavMeshes[BlockIndex].NavPoints[item].PointLocation - Position).Size();
			if (EndPointConnectedPoints.ContainsKey(item))
			{
				EndPointConnectedPoints[EndPointIndex].NavLinks.Add(new FSpiderNavPointLinkInfo
				{
					LinkPointIndex = item,
					Cost = cost
				});
				EndPointConnectedPoints[item].NavLinks.Add(new FSpiderNavPointLinkInfo
				{
					LinkPointIndex = EndPointIndex,
					Cost = cost
				});
			}
			else
			{
				EndPointConnectedPoints[EndPointIndex].NavLinks.Add(new FSpiderNavPointLinkInfo
				{
					LinkPointIndex = item,
					Cost = cost
				});
				FSpiderNavPointInfo fSpiderNavPointInfo = new FSpiderNavPointInfo(NavMeshes[BlockIndex].NavPoints[item]);
				fSpiderNavPointInfo.NavLinks.Add(new FSpiderNavPointLinkInfo
				{
					LinkPointIndex = EndPointIndex,
					Cost = cost
				});
				EndPointConnectedPoints.Add(item, fSpiderNavPointInfo);
			}
		}
	}

	private bool TryRegisterEndPoinToBlock(FVector Position, int BlockIndex, ref Dictionary<int, FSpiderNavPointInfo> EndPointConnectedPoints, int EndPointIndex)
	{
		int num = -1;
		float num2 = float.MaxValue;
		List<int> list = new List<int>();
		for (int i = 0; i < NavMeshes[BlockIndex].NavPoints.Count; i++)
		{
			if (EndPointConnectedPoints[EndPointIndex].IsGroundPoint && !NavMeshes[BlockIndex].NavPoints[i].IsGroundPoint)
			{
				continue;
			}
			float num3 = (NavMeshes[BlockIndex].NavPoints[i].PointLocation - Position).Size();
			if (EndPointConnectedPoints[EndPointIndex].IsGroundPoint || !(num3 > NavMeshes[BlockIndex].NavPoints[i].LinkRadius))
			{
				list.Add(i);
				if (BlockIndex == -1 || num == -1 || num3 < num2)
				{
					num = i;
					num2 = num3;
				}
			}
		}
		if (num >= 0)
		{
			foreach (int item in list)
			{
				float cost = (NavMeshes[BlockIndex].NavPoints[item].PointLocation - Position).Size();
				if (EndPointConnectedPoints.ContainsKey(item))
				{
					EndPointConnectedPoints[EndPointIndex].NavLinks.Add(new FSpiderNavPointLinkInfo
					{
						LinkPointIndex = item,
						Cost = cost
					});
					EndPointConnectedPoints[item].NavLinks.Add(new FSpiderNavPointLinkInfo
					{
						LinkPointIndex = EndPointIndex,
						Cost = cost
					});
				}
				else
				{
					EndPointConnectedPoints[EndPointIndex].NavLinks.Add(new FSpiderNavPointLinkInfo
					{
						LinkPointIndex = item,
						Cost = cost
					});
					FSpiderNavPointInfo fSpiderNavPointInfo = new FSpiderNavPointInfo(NavMeshes[BlockIndex].NavPoints[item]);
					fSpiderNavPointInfo.NavLinks.Add(new FSpiderNavPointLinkInfo
					{
						LinkPointIndex = EndPointIndex,
						Cost = cost
					});
					EndPointConnectedPoints.Add(item, fSpiderNavPointInfo);
				}
			}
			return true;
		}
		return false;
	}
}
