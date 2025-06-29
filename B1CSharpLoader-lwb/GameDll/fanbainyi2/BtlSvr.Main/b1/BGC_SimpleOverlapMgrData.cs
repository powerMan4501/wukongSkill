using System;
using System.Collections.Generic;
using System.Threading;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_SimpleOverlapMgrData : b1.IBGC_SimpleOverlapMgrData, IPersistentECSData
{
	public AutoResetEvent ThreadEvent = new AutoResetEvent(initialState: false);

	private HashSet<AActor> GetSimpleOverlapActorsByMaskHashSetHelper = new HashSet<AActor>();

	public const float GridNumSize = 9f;

	public const float HalfGridNumSize = 4.5f;

	private static List<int> sGetOverlapGridIndexListCache = new List<int>();

	public Dictionary<Entity, BGUGridInfo> GridInfos { get; set; } = new Dictionary<Entity, BGUGridInfo>();

	public Dictionary<Entity, EntityUpdateInfo> EntityUpdateInfoDic { get; set; } = new Dictionary<Entity, EntityUpdateInfo>();

	private float GridSize { get; set; }

	public void SetGridSize(float Size)
	{
		GridSize = Size;
	}

	public float GetGridSize()
	{
		return GridSize;
	}

	public void RemoveGridInfo(AActor Actor)
	{
		GridInfos.Remove(ECSExtension.ToEntity(Actor));
	}

	public void AddGridInfo(AActor Actor, FVector2D CenterLocation)
	{
		Entity key = ECSExtension.ToEntity(Actor);
		if (GridInfos.ContainsKey(key))
		{
			return;
		}
		BGUGridInfo bGUGridInfo = new BGUGridInfo
		{
			CenterLocation = CenterLocation,
			Grid = new BGUGridChunk[9, 9]
		};
		for (int i = 0; (float)i < 9f; i++)
		{
			for (int j = 0; (float)j < 9f; j++)
			{
				bGUGridInfo.Grid[i, j] = new BGUGridChunk();
			}
		}
		GridInfos.Add(key, bGUGridInfo);
	}

	public void UpdateGridLocation(Entity Ent, FVector2D Location)
	{
		GridInfos.TryGetValue(Ent, out var value);
		if (value != null)
		{
			value.CenterLocation = Location;
		}
	}

	public FVector2D GetGridIndex(FVector2D EntLocation, FVector2D CenterLocation)
	{
		FVector2D fVector2D = EntLocation - CenterLocation;
		float value = fVector2D.X % GridSize;
		int num = 4 + (int)(fVector2D.X / GridSize) + ((!(fVector2D.X < 0f)) ? 1 : (-1)) * ((FMath.Abs(value) > GridSize / 2f) ? 1 : 0);
		value = fVector2D.Y % GridSize;
		int num2 = 4 + (int)(fVector2D.Y / GridSize) + ((!(fVector2D.Y < 0f)) ? 1 : (-1)) * ((FMath.Abs(value) > GridSize / 2f) ? 1 : 0);
		if ((float)num >= 9f || num < 0 || (float)num2 >= 9f || num2 < 0)
		{
			return new FVector2D(-1.0, -1.0);
		}
		return new FVector2D(num, num2);
	}

	public bool CheckIndexValid(FVector2D Index)
	{
		if (Index.X >= 9f || Index.X < 0f || Index.Y >= 9f || Index.Y < 0f)
		{
			return false;
		}
		return true;
	}

	public void RemoveEntityInfoByIndex(FVector2D Index, Entity GridEnt, Entity OwnEnt)
	{
		if (GridInfos.ContainsKey(GridEnt) && CheckIndexValid(Index))
		{
			GridInfos[GridEnt].Grid[(int)Index.X, (int)Index.Y].EntityInfoList?.RemoveAll((BGUEntityInfo item) => item.Ent == OwnEnt);
		}
	}

	public void CreateNewEntityInfoInGridByIndex(FVector2D Index, Entity GridEnt, EntityUpdateInfo EntUpdateInfo)
	{
		if (GridInfos.ContainsKey(GridEnt) && CheckIndexValid(Index))
		{
			List<BGUEntityInfo> entityInfoList = GridInfos[GridEnt].Grid[(int)Index.X, (int)Index.Y].EntityInfoList;
			if (entityInfoList != null)
			{
				entityInfoList.Add(new BGUEntityInfo(EntUpdateInfo));
				return;
			}
			GridInfos[GridEnt].Grid[(int)Index.X, (int)Index.Y].EntityInfoList = new List<BGUEntityInfo>
			{
				new BGUEntityInfo(EntUpdateInfo)
			};
		}
	}

	public ESimpleOverlapResult GetSimpleOverlapActorsByMask(AActor Owner, FVector InOriginalLocation, int Mask, float SphereRadius, float RectWidth, float RectLength, FVector2D RectRotation, bool IsSphere, out List<AActor> OutList, bool UseEntRadiusCheck = true)
	{
		OutList = new List<AActor>();
		GetSimpleOverlapActorsByMaskHashSetHelper.Clear();
		FVector fVector = InOriginalLocation;
		FVector2D fVector2D = new FVector2D(fVector.X, fVector.Y);
		if (DebugConfig.DrawSimpleOverlapDebug)
		{
			if (IsSphere)
			{
				USystemLibrary.DrawDebugCircle(Owner.World, fVector, SphereRadius, 20, FLinearColor.Red, 0.8f, 10f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
			}
			else
			{
				float num = RectRotation.X / FMath.Sqrt(FMath.Pow(RectRotation.X, 2f) + FMath.Pow(RectRotation.Y, 2f));
				float num2 = RectRotation.Y / FMath.Sqrt(FMath.Pow(RectRotation.X, 2f) + FMath.Pow(RectRotation.Y, 2f));
				FVector2D fVector2D2 = new FVector2D((0f - RectWidth) * num + RectLength * num2 + fVector2D.X, (0f - RectWidth) * num2 - RectLength * num + fVector2D.Y);
				FVector2D fVector2D3 = new FVector2D(RectWidth * num + RectLength * num2 + fVector2D.X, RectWidth * num2 - RectLength * num + fVector2D.Y);
				FVector2D fVector2D4 = new FVector2D(RectWidth * num - RectLength * num2 + fVector2D.X, RectWidth * num2 + RectLength * num + fVector2D.Y);
				FVector2D fVector2D5 = new FVector2D((0f - RectWidth) * num - RectLength * num2 + fVector2D.X, (0f - RectWidth) * num2 + RectLength * num + fVector2D.Y);
				USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D2.X, fVector2D2.Y, fVector.Z), new FVector(fVector2D3.X, fVector2D3.Y, fVector.Z), FLinearColor.Red, 0.5f, 10f);
				USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D3.X, fVector2D3.Y, fVector.Z), new FVector(fVector2D4.X, fVector2D4.Y, fVector.Z), FLinearColor.Red, 0.5f, 10f);
				USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D4.X, fVector2D4.Y, fVector.Z), new FVector(fVector2D5.X, fVector2D5.Y, fVector.Z), FLinearColor.Red, 0.5f, 10f);
				USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D5.X, fVector2D5.Y, fVector.Z), new FVector(fVector2D2.X, fVector2D2.Y, fVector.Z), FLinearColor.Red, 0.5f, 10f);
				USystemLibrary.DrawDebugLine(Owner, fVector, new FVector(fVector.X + RectRotation.X * 500f, fVector.Y + RectRotation.Y * 500f, fVector.Z), FLinearColor.Red, 0.5f, 10f);
			}
		}
		bool flag = false;
		_ = DebugConfig.ProfilerSimpleOverlap;
		foreach (KeyValuePair<Entity, BGUGridInfo> gridInfo in GridInfos)
		{
			BGUGridInfo value = gridInfo.Value;
			BGUGridChunk[,] grid = value.Grid;
			FVector2D fVector2D6 = value.CenterLocation - new FVector2D(4.5f * GridSize, 4.5f * GridSize);
			FVector2D fVector2D7 = value.CenterLocation + new FVector2D(4.5f * GridSize, 4.5f * GridSize);
			if (IsSphere)
			{
				_ = DebugConfig.ProfilerSimpleOverlap;
				flag = GetOverlapGridIndexList(fVector2D, new FVector2D(SphereRadius, SphereRadius), value, out var OutIndexList);
				_ = DebugConfig.ProfilerSimpleOverlap;
				List<int> list = OutIndexList;
				_ = DebugConfig.ProfilerSimpleOverlap;
				for (int i = list[0]; i <= list[1]; i++)
				{
					for (int j = list[2]; j <= list[3]; j++)
					{
						if (i >= 9 || i < 0 || j >= 9 || j < 0)
						{
							continue;
						}
						BGUGridChunk bGUGridChunk = grid[i, j];
						FVector2D fVector2D8 = new FVector2D(fVector2D6.X + (float)i * GridSize, fVector2D6.Y + (float)j * GridSize);
						FVector2D fVector2D9 = new FVector2D(fVector2D8.X + GridSize, fVector2D8.Y);
						FVector2D fVector2D10 = new FVector2D(fVector2D8.X + GridSize, fVector2D8.Y + GridSize);
						FVector2D fVector2D11 = new FVector2D(fVector2D8.X, fVector2D8.Y + GridSize);
						if (!BoxCircleIntersect((fVector2D11 + fVector2D9) / 2.0, new FVector2D(GridSize / 2f, GridSize / 2f), fVector2D, SphereRadius))
						{
							continue;
						}
						float z = fVector.Z;
						if (DebugConfig.DrawSimpleOverlapDebug)
						{
							USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D8.X, fVector2D8.Y, z), new FVector(fVector2D9.X, fVector2D9.Y, z), FLinearColor.Red, 0.8f, 10f);
							USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D9.X, fVector2D9.Y, z), new FVector(fVector2D10.X, fVector2D10.Y, z), FLinearColor.Red, 0.8f, 10f);
							USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D10.X, fVector2D10.Y, z), new FVector(fVector2D11.X, fVector2D11.Y, z), FLinearColor.Red, 0.8f, 10f);
							USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D11.X, fVector2D11.Y, z), new FVector(fVector2D8.X, fVector2D8.Y, z), FLinearColor.Red, 0.8f, 10f);
						}
						for (int num3 = bGUGridChunk.EntityInfoList.Count - 1; num3 >= 0; num3--)
						{
							BGUEntityInfo bGUEntityInfo = bGUGridChunk.EntityInfoList[num3];
							_ = DebugConfig.ProfilerSimpleOverlap;
							int mask = bGUEntityInfo.Mask;
							_ = DebugConfig.ProfilerSimpleOverlap;
							if ((mask & Mask) != 0)
							{
								_ = DebugConfig.ProfilerSimpleOverlap;
								AActor actor = bGUEntityInfo.Actor;
								if (GetSimpleOverlapActorsByMaskHashSetHelper.Contains(actor))
								{
									if (!DebugConfig.ProfilerSimpleOverlap)
									{
									}
								}
								else
								{
									_ = DebugConfig.ProfilerSimpleOverlap;
									_ = DebugConfig.ProfilerSimpleOverlap;
									bGUEntityInfo.ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation);
									if (UseEntRadiusCheck && bGUEntityInfo.Radius + SphereRadius > FVector2D.Distance(fVector2D, new FVector2D(OutLocation.X, OutLocation.Y)))
									{
										if (DebugConfig.DrawSimpleOverlapDebug)
										{
											USystemLibrary.DrawDebugCircle(Owner.World, OutLocation, bGUEntityInfo.Radius, 20, FLinearColor.Red, 0.8f, 10f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
										}
										GetSimpleOverlapActorsByMaskHashSetHelper.Add(actor);
									}
									else if (!UseEntRadiusCheck && FVector2D.Distance(fVector2D, new FVector2D(OutLocation.X, OutLocation.Y)) < SphereRadius)
									{
										GetSimpleOverlapActorsByMaskHashSetHelper.Add(actor);
									}
									_ = DebugConfig.ProfilerSimpleOverlap;
								}
							}
						}
					}
				}
				if (!DebugConfig.ProfilerSimpleOverlap)
				{
				}
				continue;
			}
			float num4 = RectRotation.X / FMath.Sqrt(FMath.Pow(RectRotation.X, 2f) + FMath.Pow(RectRotation.Y, 2f));
			float num5 = RectRotation.Y / FMath.Sqrt(FMath.Pow(RectRotation.X, 2f) + FMath.Pow(RectRotation.Y, 2f));
			FVector2D fVector2D12 = new FVector2D((0f - RectWidth) * num4 + RectLength * num5 + fVector2D.X, (0f - RectWidth) * num5 - RectLength * num4 + fVector2D.Y);
			FVector2D fVector2D13 = new FVector2D(RectWidth * num4 + RectLength * num5 + fVector2D.X, RectWidth * num5 - RectLength * num4 + fVector2D.Y);
			FVector2D fVector2D14 = new FVector2D(RectWidth * num4 - RectLength * num5 + fVector2D.X, RectWidth * num5 + RectLength * num4 + fVector2D.Y);
			FVector2D fVector2D15 = new FVector2D((0f - RectWidth) * num4 - RectLength * num5 + fVector2D.X, (0f - RectWidth) * num5 + RectLength * num4 + fVector2D.Y);
			if (DebugConfig.DrawSimpleOverlapDebug)
			{
				USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D12.X, fVector2D12.Y, fVector.Z), new FVector(fVector2D13.X, fVector2D13.Y, fVector.Z), FLinearColor.Red, 0.8f, 10f);
				USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D13.X, fVector2D13.Y, fVector.Z), new FVector(fVector2D14.X, fVector2D14.Y, fVector.Z), FLinearColor.Red, 0.8f, 10f);
				USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D14.X, fVector2D14.Y, fVector.Z), new FVector(fVector2D15.X, fVector2D15.Y, fVector.Z), FLinearColor.Red, 0.8f, 10f);
				USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D15.X, fVector2D15.Y, fVector.Z), new FVector(fVector2D12.X, fVector2D12.Y, fVector.Z), FLinearColor.Red, 0.8f, 10f);
				USystemLibrary.DrawDebugLine(Owner, fVector, new FVector(fVector.X + RectRotation.X * 500f, fVector.Y + RectRotation.Y * 500f, fVector.Z), FLinearColor.Red, 0.8f, 10f);
			}
			FVector2D[] array = new FVector2D[4] { fVector2D12, fVector2D13, fVector2D14, fVector2D15 };
			flag = FMath.Min(fVector2D6.X, fVector2D7.X) < fVector2D12.X && fVector2D12.X < FMath.Max(fVector2D6.X, fVector2D7.X) && FMath.Min(fVector2D6.Y, fVector2D7.Y) < fVector2D12.Y && fVector2D12.Y < FMath.Max(fVector2D6.Y, fVector2D7.Y) && FMath.Min(fVector2D6.X, fVector2D7.X) < fVector2D13.X && fVector2D13.X < FMath.Max(fVector2D6.X, fVector2D7.X) && FMath.Min(fVector2D6.Y, fVector2D7.Y) < fVector2D13.Y && fVector2D13.Y < FMath.Max(fVector2D6.Y, fVector2D7.Y) && FMath.Min(fVector2D6.X, fVector2D7.X) < fVector2D14.X && fVector2D14.X < FMath.Max(fVector2D6.X, fVector2D7.X) && FMath.Min(fVector2D6.Y, fVector2D7.Y) < fVector2D14.Y && fVector2D14.Y < FMath.Max(fVector2D6.Y, fVector2D7.Y) && FMath.Min(fVector2D6.X, fVector2D7.X) < fVector2D13.X && fVector2D13.X < FMath.Max(fVector2D6.X, fVector2D7.X) && FMath.Min(fVector2D6.Y, fVector2D7.Y) < fVector2D15.Y && fVector2D15.Y < FMath.Max(fVector2D6.Y, fVector2D7.Y);
			GetRectOverlapGridIndexList(array, value, out var OutIndexList2);
			for (int k = OutIndexList2[0]; k <= OutIndexList2[1]; k++)
			{
				for (int l = OutIndexList2[2]; l <= OutIndexList2[3]; l++)
				{
					FVector2D fVector2D16 = new FVector2D(fVector2D6.X + (float)k * GridSize, fVector2D6.Y + (float)l * GridSize);
					FVector2D fVector2D17 = new FVector2D(fVector2D16.X + GridSize, fVector2D16.Y);
					FVector2D fVector2D18 = new FVector2D(fVector2D16.X + GridSize, fVector2D16.Y + GridSize);
					FVector2D fVector2D19 = new FVector2D(fVector2D16.X, fVector2D16.Y + GridSize);
					FVector2D[] vertexs = new FVector2D[4] { fVector2D16, fVector2D17, fVector2D18, fVector2D19 };
					if (!IsIntersect2D(array, vertexs))
					{
						continue;
					}
					if (DebugConfig.DrawSimpleOverlapDebug)
					{
						float z2 = fVector.Z;
						USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D16.X, fVector2D16.Y, z2), new FVector(fVector2D17.X, fVector2D17.Y, z2), FLinearColor.Red, 0.8f, 10f);
						USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D17.X, fVector2D17.Y, z2), new FVector(fVector2D18.X, fVector2D18.Y, z2), FLinearColor.Red, 0.8f, 10f);
						USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D18.X, fVector2D18.Y, z2), new FVector(fVector2D19.X, fVector2D19.Y, z2), FLinearColor.Red, 0.8f, 10f);
						USystemLibrary.DrawDebugLine(Owner, new FVector(fVector2D19.X, fVector2D19.Y, z2), new FVector(fVector2D16.X, fVector2D16.Y, z2), FLinearColor.Red, 0.8f, 10f);
					}
					BGUGridChunk bGUGridChunk2 = grid[k, l];
					for (int num6 = bGUGridChunk2.EntityInfoList.Count - 1; num6 >= 0; num6--)
					{
						BGUEntityInfo bGUEntityInfo2 = bGUGridChunk2.EntityInfoList[num6];
						if ((bGUEntityInfo2.Mask & Mask) != 0)
						{
							AActor actor2 = bGUEntityInfo2.Actor;
							if (actor2 == null || actor2.IsDestroyed)
							{
								bGUGridChunk2.EntityInfoList.RemoveAt(num6);
							}
							else if (!GetSimpleOverlapActorsByMaskHashSetHelper.Contains(actor2))
							{
								bGUEntityInfo2.ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation2);
								if (UseEntRadiusCheck && BoxCircleIntersect((fVector2D12 + fVector2D14) / 2.0, new FVector2D(GridSize / 2f, GridSize / 2f), new FVector2D(OutLocation2.X, OutLocation2.Y), bGUEntityInfo2.Radius))
								{
									if (DebugConfig.DrawSimpleOverlapDebug)
									{
										USystemLibrary.DrawDebugCircle(Owner.World, OutLocation2, bGUEntityInfo2.Radius, 20, FLinearColor.Red, 0.8f, 10f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
									}
									GetSimpleOverlapActorsByMaskHashSetHelper.Add(actor2);
								}
								else if (!UseEntRadiusCheck && FMath.Min(fVector2D16.X, fVector2D18.X) < fVector2D.X && fVector2D.X < FMath.Max(fVector2D16.X, fVector2D18.X) && FMath.Min(fVector2D16.Y, fVector2D18.Y) < fVector2D.Y && fVector2D.Y < FMath.Max(fVector2D16.Y, fVector2D18.Y))
								{
									if (DebugConfig.DrawSimpleOverlapDebug)
									{
										USystemLibrary.DrawDebugCircle(Owner.World, OutLocation2, bGUEntityInfo2.Radius, 20, FLinearColor.Red, 0.8f, 10f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
									}
									GetSimpleOverlapActorsByMaskHashSetHelper.Add(actor2);
								}
							}
						}
					}
				}
			}
		}
		_ = DebugConfig.ProfilerSimpleOverlap;
		foreach (AActor item in GetSimpleOverlapActorsByMaskHashSetHelper)
		{
			OutList.Add(item);
		}
		if (flag && OutList.Count == 0)
		{
			return ESimpleOverlapResult.ValidInputAndNoOverlapping;
		}
		if (flag && OutList.Count != 0)
		{
			return ESimpleOverlapResult.ValidInputAndHasOverlapping;
		}
		if (!flag && OutList.Count == 0)
		{
			return ESimpleOverlapResult.InValidAndNoOverlapping;
		}
		return ESimpleOverlapResult.InValidAndHasOverlapping;
	}

	private float[] PointProduct(FVector2D[] Vertexs, FVector2D axis)
	{
		float[] array = new float[2]
		{
			float.MaxValue,
			float.MinValue
		};
		for (int i = 0; i < Vertexs.Length; i++)
		{
			float val = FVector2D.DotProduct(Vertexs[i], axis);
			array[0] = FMath.Min(array[0], val);
			array[1] = FMath.Max(array[1], val);
		}
		return array;
	}

	private bool IsNotIntersectInAxis(FVector2D[] Vertexs1, FVector2D[] Vertexs2, FVector2D Axis)
	{
		float[] array = PointProduct(Vertexs1, Axis);
		float[] array2 = PointProduct(Vertexs2, Axis);
		if (!(array[0] > array2[1]))
		{
			return array2[0] > array[1];
		}
		return true;
	}

	private bool IsIntersect2D(FVector2D[] Vertexs1, FVector2D[] Vertexs2)
	{
		FVector2D axis = new FVector2D(1.0, 0.0);
		FVector2D axis2 = new FVector2D(0.0, 1.0);
		FVector2D axis3 = Vertexs1[0] - Vertexs1[1];
		FVector2D axis4 = Vertexs1[1] - Vertexs1[2];
		if (!IsNotIntersectInAxis(Vertexs1, Vertexs2, axis) && !IsNotIntersectInAxis(Vertexs1, Vertexs2, axis2) && !IsNotIntersectInAxis(Vertexs1, Vertexs2, axis3))
		{
			return !IsNotIntersectInAxis(Vertexs1, Vertexs2, axis4);
		}
		return false;
	}

	private bool BoxCircleIntersect(FVector2D Center, FVector2D HalfVec, FVector2D P, float R)
	{
		FVector2D fVector2D = new FVector2D(Math.Abs(P.X - Center.X), Math.Abs(P.Y - Center.Y));
		FVector2D fVector2D2 = new FVector2D(Math.Max((fVector2D - HalfVec).X, 0f), Math.Max((fVector2D - HalfVec).Y, 0f));
		return fVector2D2.X * fVector2D2.X + fVector2D2.Y * fVector2D2.Y <= R * R;
	}

	private bool IsOverlapGrid(FVector2D LeftUpPoint, FVector2D RightUpPoint, FVector2D RightDownPoint, FVector2D LeftDownPoint, FVector2D Location, float Radius)
	{
		if (FVector2D.Distance(LeftUpPoint, Location) < Radius)
		{
			return true;
		}
		if (FVector2D.Distance(RightUpPoint, Location) < Radius)
		{
			return true;
		}
		if (FVector2D.Distance(RightDownPoint, Location) < Radius)
		{
			return true;
		}
		if (FVector2D.Distance(LeftDownPoint, Location) < Radius)
		{
			return true;
		}
		float num = (RightUpPoint.X - LeftUpPoint.X) * (Location.Y - LeftUpPoint.Y) - (RightUpPoint.Y - LeftUpPoint.Y) * (Location.X - LeftUpPoint.X);
		float num2 = (RightDownPoint.X - RightUpPoint.X) * (Location.Y - RightUpPoint.Y) - (RightDownPoint.Y - RightUpPoint.Y) * (Location.X - RightUpPoint.X);
		float num3 = (LeftDownPoint.X - RightDownPoint.X) * (Location.Y - RightDownPoint.Y) - (LeftDownPoint.Y - RightDownPoint.Y) * (Location.X - RightDownPoint.X);
		float num4 = (LeftUpPoint.X - LeftDownPoint.X) * (Location.Y - LeftDownPoint.Y) - (LeftUpPoint.Y - LeftDownPoint.Y) * (Location.X - LeftDownPoint.X);
		if ((num >= 0f && num2 >= 0f && num3 >= 0f && num4 >= 0f) || (num <= 0f && num2 <= 0f && num3 <= 0f && num4 <= 0f))
		{
			return true;
		}
		if (GetDistance(Location, LeftUpPoint, RightUpPoint) < Radius)
		{
			return true;
		}
		if (GetDistance(Location, RightUpPoint, RightDownPoint) < Radius)
		{
			return true;
		}
		if (GetDistance(Location, RightDownPoint, LeftDownPoint) < Radius)
		{
			return true;
		}
		if (GetDistance(Location, LeftDownPoint, LeftUpPoint) < Radius)
		{
			return true;
		}
		return false;
	}

	private float GetDistance(FVector2D P, FVector2D A, FVector2D B)
	{
		FVector2D fVector2D = new FVector2D(P.X - A.X, P.Y - A.Y);
		FVector2D fVector2D2 = new FVector2D(B.X - A.X, B.Y - A.Y);
		FVector2D fVector2D3 = new FVector2D(P.X - B.X, P.Y - B.Y);
		float num = (fVector2D.X * fVector2D2.X + fVector2D.Y * fVector2D2.Y) / (fVector2D2.X * fVector2D2.X + fVector2D2.Y * fVector2D2.Y);
		if (num <= 0f)
		{
			return FMath.Sqrt(fVector2D.X * fVector2D.X + fVector2D.Y * fVector2D.Y);
		}
		if (num >= 1f)
		{
			return FMath.Sqrt(fVector2D3.X * fVector2D3.X + fVector2D3.Y * fVector2D3.Y);
		}
		float num2 = A.X + fVector2D2.X * num;
		float num3 = A.Y + fVector2D2.Y * num;
		return FMath.Sqrt((P.X - num2) * (P.X - num2) + (P.Y - num3) * (P.Y - num3));
	}

	private void GetRectOverlapGridIndexList(FVector2D[] OverlapVertexs, BGUGridInfo GridInfo, out List<int> OutIndexList)
	{
		FVector2D fVector2D = new FVector2D(FMath.Min(OverlapVertexs[0].X, OverlapVertexs[1].X, OverlapVertexs[2].X, OverlapVertexs[3].X), FMath.Min(OverlapVertexs[0].Y, OverlapVertexs[1].Y, OverlapVertexs[2].Y, OverlapVertexs[3].Y));
		FVector2D fVector2D2 = new FVector2D(FMath.Max(OverlapVertexs[0].X, OverlapVertexs[1].X, OverlapVertexs[2].X, OverlapVertexs[3].X), FMath.Max(OverlapVertexs[0].Y, OverlapVertexs[1].Y, OverlapVertexs[2].Y, OverlapVertexs[3].Y));
		GetOverlapGridIndexList((fVector2D + fVector2D2) / 2.0, new FVector2D(FMath.Abs(fVector2D.X - fVector2D2.X), FMath.Abs(fVector2D.Y - fVector2D2.Y)), GridInfo, out OutIndexList);
	}

	private bool IsRectangleOverlap(FVector2D StartPoint, FVector2D EndPoint, FVector2D OverlapStartPoint, FVector2D OverlapEndPoint)
	{
		if (StartPoint.X == EndPoint.X || StartPoint.Y == EndPoint.Y || OverlapStartPoint.X == OverlapEndPoint.X || OverlapStartPoint.Y == OverlapEndPoint.Y)
		{
			return false;
		}
		if (EndPoint.X <= OverlapStartPoint.X || StartPoint.X >= OverlapEndPoint.X)
		{
			return false;
		}
		if (EndPoint.Y <= OverlapStartPoint.Y || StartPoint.Y >= OverlapEndPoint.Y)
		{
			return false;
		}
		return true;
	}

	public bool GetOverlapGridIndexList(FVector2D Location, FVector2D SquareSize, BGUGridInfo GridInfo, out List<int> OutIndexList)
	{
		sGetOverlapGridIndexListCache.Clear();
		OutIndexList = sGetOverlapGridIndexListCache;
		FVector2D startPoint = GridInfo.CenterLocation - new FVector2D(4.5f * GridSize, 4.5f * GridSize);
		FVector2D endPoint = GridInfo.CenterLocation + new FVector2D(4.5f * GridSize, 4.5f * GridSize);
		FVector2D overlapStartPoint = Location - SquareSize;
		FVector2D overlapEndPoint = Location + SquareSize;
		bool result = IsRectangleOverlap(startPoint, endPoint, overlapStartPoint, overlapEndPoint);
		overlapStartPoint = new FVector2D(FMath.Max(overlapStartPoint.X, startPoint.X), FMath.Max(overlapStartPoint.Y, startPoint.Y));
		overlapEndPoint = new FVector2D(FMath.Min(overlapEndPoint.X, endPoint.X), FMath.Min(overlapEndPoint.Y, endPoint.Y));
		float num = 0f;
		float num2 = 0f;
		float num3 = FMath.Max(overlapStartPoint.X, startPoint.X);
		float num4 = FMath.Min(overlapEndPoint.X, endPoint.X);
		num = num3 - GridInfo.CenterLocation.X;
		num2 = num % GridSize;
		int item = 4 + (int)(num / GridSize) + ((!(num < 0f)) ? 1 : (-1)) * ((FMath.Abs(num2) > GridSize / 2f) ? 1 : 0);
		num = num4 - GridInfo.CenterLocation.X;
		num2 = num % GridSize;
		int item2 = 4 + (int)(num / GridSize) + ((!(num < 0f)) ? 1 : (-1)) * ((FMath.Abs(num2) > GridSize / 2f) ? 1 : 0);
		float num5 = FMath.Max(overlapStartPoint.Y, startPoint.Y);
		float num6 = FMath.Min(overlapEndPoint.Y, endPoint.Y);
		num = num5 - GridInfo.CenterLocation.Y;
		num2 = num % GridSize;
		int item3 = 4 + (int)(num / GridSize) + ((!(num < 0f)) ? 1 : (-1)) * ((FMath.Abs(num2) > GridSize / 2f) ? 1 : 0);
		num = num6 - GridInfo.CenterLocation.Y;
		num2 = num % GridSize;
		int item4 = 4 + (int)(num / GridSize) + ((!(num < 0f)) ? 1 : (-1)) * ((FMath.Abs(num2) > GridSize / 2f) ? 1 : 0);
		OutIndexList.Add(item);
		OutIndexList.Add(item2);
		OutIndexList.Add(item3);
		OutIndexList.Add(item4);
		return result;
	}

	public void DrawDebugGrid(AActor Owner)
	{
		float num = 4.5f * GridSize;
		foreach (KeyValuePair<Entity, BGUGridInfo> gridInfo in GridInfos)
		{
			BGUGridInfo value = gridInfo.Value;
			AActor aActor = ECSUtil.ToActor(gridInfo.Key);
			FVector fVector = new FVector(value.CenterLocation.X, value.CenterLocation.Y, (!aActor.IsNullOrDestroyed()) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor).Z : 0f);
			FVector center = new FVector(fVector.X - num, fVector.Y - num, fVector.Z);
			if (DebugConfig.DrawSimpleOverlapDebug)
			{
				USystemLibrary.DrawDebugSphere(Owner, center, 30f, 50, FLinearColor.Red, 0.3f, 2f);
			}
			for (int i = 0; i < 9; i++)
			{
				FVector lineStart = new FVector(center.X + (float)i * GridSize, center.Y, center.Z);
				USystemLibrary.DrawDebugLine(LineEnd: new FVector(lineStart.X, center.Y + 9f * GridSize, center.Z), WorldContextObject: Owner, LineStart: lineStart, LineColor: FLinearColor.Green, Duration: 0.1f, Thickness: 10f);
			}
			for (int j = 0; j < 9; j++)
			{
				FVector lineStart2 = new FVector(center.X, center.Y + (float)j * GridSize, center.Z);
				USystemLibrary.DrawDebugLine(LineEnd: new FVector(center.X + 9f * GridSize, lineStart2.Y, center.Z), WorldContextObject: Owner, LineStart: lineStart2, LineColor: FLinearColor.Green, Duration: 0.1f, Thickness: 10f);
			}
		}
	}
}
