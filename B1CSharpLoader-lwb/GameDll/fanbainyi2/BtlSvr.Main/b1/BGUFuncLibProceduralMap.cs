using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibProceduralMap")]
public class BGUFuncLibProceduralMap : UBlueprintFunctionLibrary
{
	private static readonly int MAX_GEN_ATTEMPT;

	private static readonly int MIN_INSERT_LINE_LENGTH;

	private static bool BuildDemoMapInfo_IsValid;

	private static IntPtr BuildDemoMapInfo_FunctionAddress;

	private static int BuildDemoMapInfo_ParamsSize;

	private static bool BuildDemoMapInfo_MapInfo_IsValid;

	private static int BuildDemoMapInfo_MapInfo_Offset;

	private static FFieldAddress BuildDemoMapInfo_MapInfo_PropertyAddress;

	private static bool BuildDemoMapInfo_ReturnValue_IsValid;

	private static int BuildDemoMapInfo_ReturnValue_Offset;

	private static FFieldAddress BuildDemoMapInfo_ReturnValue_PropertyAddress;

	private static bool MapConnectAllPoints_IsValid;

	private static IntPtr MapConnectAllPoints_FunctionAddress;

	private static int MapConnectAllPoints_ParamsSize;

	private static bool MapConnectAllPoints_MapInfo_IsValid;

	private static int MapConnectAllPoints_MapInfo_Offset;

	private static FFieldAddress MapConnectAllPoints_MapInfo_PropertyAddress;

	private static bool MapConnectAllPoints_AllowedGeneralCatDir_IsValid;

	private static int MapConnectAllPoints_AllowedGeneralCatDir_Offset;

	private static FFieldAddress MapConnectAllPoints_AllowedGeneralCatDir_PropertyAddress;

	private static bool MapConnectAllPoints_AllowedEntranceOutCatDir_IsValid;

	private static int MapConnectAllPoints_AllowedEntranceOutCatDir_Offset;

	private static FFieldAddress MapConnectAllPoints_AllowedEntranceOutCatDir_PropertyAddress;

	private static bool MapConnectAllPoints_AllowedExitInCatDir_IsValid;

	private static int MapConnectAllPoints_AllowedExitInCatDir_Offset;

	private static FFieldAddress MapConnectAllPoints_AllowedExitInCatDir_PropertyAddress;

	private static bool MapPopulateWithPoints_IsValid;

	private static IntPtr MapPopulateWithPoints_FunctionAddress;

	private static int MapPopulateWithPoints_ParamsSize;

	private static bool MapPopulateWithPoints_MapInfo_IsValid;

	private static int MapPopulateWithPoints_MapInfo_Offset;

	private static FFieldAddress MapPopulateWithPoints_MapInfo_PropertyAddress;

	private static bool InitProceduralMapConfig_IsValid;

	private static IntPtr InitProceduralMapConfig_FunctionAddress;

	private static int InitProceduralMapConfig_ParamsSize;

	private static bool InitProceduralMapConfig_MapConfigDataAsset_IsValid;

	private static int InitProceduralMapConfig_MapConfigDataAsset_Offset;

	private static bool InitProceduralMapConfig_MapBlockMappingInfo_IsValid;

	private static int InitProceduralMapConfig_MapBlockMappingInfo_Offset;

	private static bool InitProceduralMapConfig_MapLightInfo_IsValid;

	private static int InitProceduralMapConfig_MapLightInfo_Offset;

	private static bool InitProceduralMapConfig_MapInfo_IsValid;

	private static int InitProceduralMapConfig_MapInfo_Offset;

	private static FFieldAddress InitProceduralMapConfig_MapInfo_PropertyAddress;

	private static bool BuildWildernessLinearInfo_IsValid;

	private static IntPtr BuildWildernessLinearInfo_FunctionAddress;

	private static int BuildWildernessLinearInfo_ParamsSize;

	private static bool BuildWildernessLinearInfo_MapInfo_IsValid;

	private static int BuildWildernessLinearInfo_MapInfo_Offset;

	private static FFieldAddress BuildWildernessLinearInfo_MapInfo_PropertyAddress;

	private static bool BuildWildernessLinearInfo_ReturnValue_IsValid;

	private static int BuildWildernessLinearInfo_ReturnValue_Offset;

	private static FFieldAddress BuildWildernessLinearInfo_ReturnValue_PropertyAddress;

	private static bool GenerateProceduralMapData_IsValid;

	private static IntPtr GenerateProceduralMapData_FunctionAddress;

	private static int GenerateProceduralMapData_ParamsSize;

	private static bool GenerateProceduralMapData_MapInfo_IsValid;

	private static int GenerateProceduralMapData_MapInfo_Offset;

	private static FFieldAddress GenerateProceduralMapData_MapInfo_PropertyAddress;

	private static bool GenerateProceduralMapData_ReturnValue_IsValid;

	private static int GenerateProceduralMapData_ReturnValue_Offset;

	private static FFieldAddress GenerateProceduralMapData_ReturnValue_PropertyAddress;

	private static bool BuildProceduralDungeonsInfo_IsValid;

	private static IntPtr BuildProceduralDungeonsInfo_FunctionAddress;

	private static int BuildProceduralDungeonsInfo_ParamsSize;

	private static bool BuildProceduralDungeonsInfo_MapInfo_IsValid;

	private static int BuildProceduralDungeonsInfo_MapInfo_Offset;

	private static FFieldAddress BuildProceduralDungeonsInfo_MapInfo_PropertyAddress;

	private static bool BuildProceduralDungeonsInfo_ReturnValue_IsValid;

	private static int BuildProceduralDungeonsInfo_ReturnValue_Offset;

	private static FFieldAddress BuildProceduralDungeonsInfo_ReturnValue_PropertyAddress;

	[Category("BGU | ProcedualMap")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProceduralMap:InitProceduralMapConfig")]
	public static void InitProceduralMapConfig(in BGWProceduralMapConfigDataAsset MapConfigDataAsset, in BGWProceduralMapBlockMappingDataAsset MapBlockMappingInfo, in BGWCustomLightConfigDataAsset MapLightInfo, out MapProceduralInfo MapInfo)
	{
		MapInfo = default(MapProceduralInfo);
		if (MapConfigDataAsset == null)
		{
			USystemLibrary.PrintString(null, "地图配置信息DataAsset为空！", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 10f, FName.None);
			return;
		}
		if (MapBlockMappingInfo != null)
		{
			MapInfo.MapBlockMapping = new Dictionary<MapCatFlag, FSoftObjectPath>();
			foreach (KeyValuePair<MapCatFlag, FSoftObjectPath> item in MapBlockMappingInfo.MapBlockMapping)
			{
				MapInfo.MapBlockMapping.Add(item.Key, item.Value);
			}
		}
		else
		{
			USystemLibrary.PrintString(null, "地块映射DataAsset为空！", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 10f, FName.None);
		}
		if (MapLightInfo != null)
		{
			MapInfo.MapCustomLightConfigs = new List<FSoftObjectPath>();
			foreach (FSoftObjectPath mapCustsomLightConfig in MapLightInfo.MapCustsomLightConfigs)
			{
				MapInfo.MapCustomLightConfigs.Add(mapCustsomLightConfig);
			}
		}
		else
		{
			USystemLibrary.PrintString(null, "地图自定义光照DataAsset为空！", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 10f, FName.None);
		}
		MapInfo.MapWidth = MapConfigDataAsset.MapWidth;
		MapInfo.MapHeight = MapConfigDataAsset.MapHeight;
		MapInfo.EntranceX = MapConfigDataAsset.EntranceX;
		MapInfo.EntranceY = MapConfigDataAsset.EntranceY;
		MapInfo.ExitX = MapConfigDataAsset.ExitX;
		MapInfo.ExitY = MapConfigDataAsset.ExitY;
		MapInfo.BlockWidth = MapConfigDataAsset.BlockWidth;
		MapInfo.BlockHeight = MapConfigDataAsset.BlockHeight;
		MapInfo.ExpectedPointNumber = MapConfigDataAsset.ExpectedPointNumber;
		MapInfo.MaxPointWidth = MapConfigDataAsset.MaxPointWidth;
		MapInfo.MaxPointHeight = MapConfigDataAsset.MaxPointHeight;
		MapInfo.MinPointWidth = MapConfigDataAsset.MinPointWidth;
		MapInfo.MinPointHeight = MapConfigDataAsset.MinPointHeight;
		MapInfo.MapType = MapConfigDataAsset.MapType;
		MapInfo.IsUsingRanEE = MapConfigDataAsset.IsUsingRanEE;
		MapInfo.PathCount = 0;
		MapInfo.MapType = MapConfigDataAsset.MapType;
		MapInfo.ValidBlockNum = 0;
		MapInfo.MapMobConfigID = 1;
		MapInfo.MapInfoMatrix = Enumerable.Repeat(new MapAttrNode
		{
			BlockCatDir = MapCatFlag.CAT_NONE,
			InPointLoc = PointBlockLocFlag.PBL_NONE,
			PathCatID = 0uL,
			IsPointBlock = false
		}, MapInfo.MapWidth * MapInfo.MapHeight).ToList();
		MapInfo.PointsData = new List<MapPointData>();
		MapInfo.LinesData = new List<MapLineData>();
		MapInfo.EntranceX = FMath.Clamp(MapInfo.EntranceX, 0, MapInfo.MapWidth - 1);
		MapInfo.EntranceY = FMath.Clamp(MapInfo.EntranceY, 0, MapInfo.MapHeight - 1);
		MapInfo.ExitX = FMath.Clamp(MapInfo.ExitX, 0, MapInfo.MapWidth - 1);
		MapInfo.ExitY = FMath.Clamp(MapInfo.ExitY, 0, MapInfo.MapHeight - 1);
		MapInfo.MaxPointWidth = FMath.Clamp(MapInfo.MaxPointWidth, 1, 8);
		MapInfo.MaxPointHeight = FMath.Clamp(MapInfo.MaxPointHeight, 1, 8);
		MapInfo.MinPointWidth = FMath.Clamp(MapInfo.MinPointWidth, 1, 8);
		MapInfo.MinPointHeight = FMath.Clamp(MapInfo.MinPointHeight, 1, 8);
		MapInfo.ExpectedPointNumber = FMath.Clamp(MapInfo.ExpectedPointNumber, 0, 31);
	}

	[Category("BGU | ProcedualMap")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProceduralMap:GenerateProceduralMapData")]
	public static bool GenerateProceduralMapData(ref MapProceduralInfo MapInfo)
	{
		bool flag = false;
		switch (MapInfo.MapType)
		{
		case ProceduralMapType.PROCEDURAL_DUNGEON:
			flag = BuildProceduralDungeonsInfo(ref MapInfo);
			break;
		case ProceduralMapType.PROCEDURAL_WILDERNESS_LINEAR:
			flag = BuildWildernessLinearInfo(ref MapInfo);
			break;
		case ProceduralMapType.PROCEDURAL_DEMO_MAP:
			flag = BuildDemoMapInfo(ref MapInfo);
			break;
		}
		if (!flag)
		{
			USystemLibrary.PrintString(null, "生成地图失败!请检查地图房间数量和出入口配置是否合理！", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 10f, FName.None);
			return flag;
		}
		PostProcessMapInfo(ref MapInfo);
		return flag;
	}

	private static void PreprocessMapInfo(ref MapProceduralInfo MapInfo)
	{
		ResetMapInfo(ref MapInfo);
		if (MapInfo.IsUsingRanEE)
		{
			MapInfo.EntranceX = FMath.RandRange(0, MapInfo.MapWidth - 1);
			MapInfo.EntranceY = FMath.RandRange(0, MapInfo.MapHeight - 1);
			MapInfo.ExitX = MapInfo.EntranceX;
			MapInfo.ExitY = MapInfo.EntranceY;
			if (MapInfo.MapWidth * MapInfo.MapHeight >= 2)
			{
				while (MapInfo.EntranceX == MapInfo.ExitX && MapInfo.EntranceY == MapInfo.ExitY)
				{
					MapInfo.ExitX = FMath.RandRange(0, MapInfo.MapWidth - 1);
					MapInfo.ExitY = FMath.RandRange(0, MapInfo.MapHeight - 1);
				}
			}
		}
		else
		{
			MapInfo.EntranceX = FMath.Clamp(MapInfo.EntranceX, 0, MapInfo.MapWidth - 1);
			MapInfo.EntranceY = FMath.Clamp(MapInfo.EntranceY, 0, MapInfo.MapHeight - 1);
			MapInfo.ExitX = FMath.Clamp(MapInfo.ExitX, 0, MapInfo.MapWidth - 1);
			MapInfo.ExitY = FMath.Clamp(MapInfo.ExitY, 0, MapInfo.MapHeight - 1);
		}
	}

	private static void PostProcessMapInfo(ref MapProceduralInfo MapInfo)
	{
		CalculateValidBlockNum(ref MapInfo);
	}

	public static void CalculateValidBlockNum(ref MapProceduralInfo MapInfo)
	{
		int num = 0;
		foreach (MapAttrNode item in MapInfo.MapInfoMatrix)
		{
			if (item.BlockCatDir != MapCatFlag.CAT_NONE)
			{
				num++;
			}
		}
		MapInfo.ValidBlockNum = num;
	}

	[BlueprintCallable]
	[Category("BGU | ProcedualMap")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProceduralMap:BuildDemoMapInfo")]
	public static bool BuildDemoMapInfo(ref MapProceduralInfo MapInfo)
	{
		int num = 0;
		while (!IsMapGeneratedAsExpected(ref MapInfo, MapCatFlag.CAT_N, MapCatFlag.CAT_S) && num < MAX_GEN_ATTEMPT)
		{
			PreprocessMapInfo(ref MapInfo);
			MapInfo.MaxPointWidth = 1;
			MapInfo.MaxPointHeight = 1;
			MapInfo.MinPointWidth = 1;
			MapInfo.MinPointHeight = 1;
			MapPopulateWithPoints(ref MapInfo);
			MapConnectAllPoints(ref MapInfo, MapCatFlag.CAT_NW, MapCatFlag.CAT_N, MapCatFlag.CAT_N);
			num++;
		}
		bool num2 = num != MAX_GEN_ATTEMPT;
		if (!num2)
		{
			ResetMapInfo(ref MapInfo);
		}
		return num2;
	}

	[Category("BGU | ProcedualMap")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProceduralMap:BuildProceduralDungeonsInfo")]
	public static bool BuildProceduralDungeonsInfo(ref MapProceduralInfo MapInfo)
	{
		int num = 0;
		while (!IsMapGeneratedAsExpected(ref MapInfo) && num < MAX_GEN_ATTEMPT)
		{
			PreprocessMapInfo(ref MapInfo);
			MapPopulateWithPoints(ref MapInfo);
			MapConnectAllPoints(ref MapInfo);
			num++;
		}
		bool num2 = num != MAX_GEN_ATTEMPT;
		if (!num2)
		{
			ResetMapInfo(ref MapInfo);
		}
		return num2;
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU | ProcedualMap")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProceduralMap:BuildWildernessLinearInfo")]
	public static bool BuildWildernessLinearInfo(ref MapProceduralInfo MapInfo)
	{
		int num = 0;
		while (!IsMapGeneratedAsExpected(ref MapInfo) && num < MAX_GEN_ATTEMPT)
		{
			PreprocessMapInfo(ref MapInfo);
			MapInfo.MaxPointWidth = 1;
			MapInfo.MaxPointHeight = 1;
			MapInfo.MinPointWidth = 1;
			MapInfo.MinPointHeight = 1;
			MapPopulateWithPoints(ref MapInfo);
			MapConnectAllPoints(ref MapInfo);
			num++;
		}
		bool num2 = num != MAX_GEN_ATTEMPT;
		if (!num2)
		{
			ResetMapInfo(ref MapInfo);
		}
		return num2;
	}

	private static bool IsMapGeneratedAsExpected(ref MapProceduralInfo MapInfo, MapCatFlag AllowedEntranceCatDir = MapCatFlag.CAT_NONE, MapCatFlag AllowedExitCatDir = MapCatFlag.CAT_NONE)
	{
		bool flag = MapInfo.PointsData.Count == MapInfo.ExpectedPointNumber + 2;
		if (!flag)
		{
			return false;
		}
		MapAttrNode[] array = MapInfo.MapInfoMatrix.ToArray();
		int num = MapInfo.EntranceX + MapInfo.EntranceY * MapInfo.MapWidth;
		int num2 = MapInfo.ExitX + MapInfo.ExitY * MapInfo.MapWidth;
		return (byte)(1u & (((array[num].BlockCatDir | AllowedEntranceCatDir) == array[num].BlockCatDir) ? 1u : 0u) & (((array[num2].BlockCatDir | AllowedExitCatDir) == array[num2].BlockCatDir) ? 1u : 0u) & (flag ? 1u : 0u)) != 0;
	}

	private static bool IsConnectedAjacently(int SrcX, int SrcY, int DestX, int DestY, int MapWidth, int MapHeight, ref MapAttrNode[] RefMapMatrix)
	{
		bool flag = MathLib.Abs(SrcX - SrcY) + MathLib.Abs(DestX - DestY) == 1f;
		if (!flag)
		{
			return flag;
		}
		int num = SrcX + SrcY * MapWidth;
		int num2 = DestX + DestY * MapWidth;
		bool flag2 = RefMapMatrix[num].PathCatID == RefMapMatrix[num2].PathCatID;
		if (!flag2)
		{
			return flag2;
		}
		bool flag3 = flag && flag2;
		if (SrcX - DestX == 1)
		{
			flag3 &= (RefMapMatrix[num].BlockCatDir & MapCatFlag.CAT_W) != MapCatFlag.CAT_NONE && (RefMapMatrix[num2].BlockCatDir & MapCatFlag.CAT_E) != 0;
		}
		else if (SrcX - DestX == -1)
		{
			flag3 &= (RefMapMatrix[num].BlockCatDir & MapCatFlag.CAT_E) != MapCatFlag.CAT_NONE && (RefMapMatrix[num2].BlockCatDir & MapCatFlag.CAT_W) != 0;
		}
		else if (SrcY - DestY == 1)
		{
			flag3 &= (RefMapMatrix[num].BlockCatDir & MapCatFlag.CAT_N) != MapCatFlag.CAT_NONE && (RefMapMatrix[num2].BlockCatDir & MapCatFlag.CAT_S) != 0;
		}
		else if (SrcX - DestX == -1)
		{
			flag3 &= (RefMapMatrix[num].BlockCatDir & MapCatFlag.CAT_S) != MapCatFlag.CAT_NONE && (RefMapMatrix[num2].BlockCatDir & MapCatFlag.CAT_N) != 0;
		}
		return flag3;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU | ProcedualMap")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProceduralMap:MapPopulateWithPoints")]
	public static void MapPopulateWithPoints(ref MapProceduralInfo MapInfo)
	{
		int MapWidth = MapInfo.MapWidth;
		int MapHeight = MapInfo.MapHeight;
		MapAttrNode[] RefMapMatrix = MapInfo.MapInfoMatrix.ToArray();
		List<int> CheckPointList = new List<int>();
		for (int i = 0; i < MapWidth * MapHeight; i++)
		{
			RefMapMatrix[i].BlockCatDir = MapCatFlag.CAT_NONE;
			CheckPointList.Add(i);
		}
		while (CheckPointList.Count > 0)
		{
			int index = FMath.RandRange(0, CheckPointList.Count - 1);
			int X = CheckPointList[index] % MapWidth;
			int Y = CheckPointList[index] / MapWidth;
			int PointWidth = FMath.RandRange(MapInfo.MinPointWidth, MapInfo.MaxPointWidth);
			int PointHeight = PointWidth;
			if (CheckCanBePoint(in MapInfo.EntranceX, in MapInfo.EntranceY, in MapInfo.ExitX, in MapInfo.ExitY, in X, in Y, in PointWidth, in PointHeight, in MapWidth, in MapHeight, ref RefMapMatrix))
			{
				ConstructPoint(in X, in Y, in PointWidth, in PointHeight, in MapWidth, in MapHeight, ref RefMapMatrix, ref CheckPointList);
				MapInfo.PointsData.Add(CreatePointData(X, Y, PointWidth, PointHeight));
			}
			else
			{
				CheckPointList.RemoveAt(index);
			}
		}
		MapInfo.MapInfoMatrix = RefMapMatrix.ToList();
	}

	private static void ConstructPoint(in int X, in int Y, in int PointWidth, in int PointHeight, in int MapWidth, in int MapHeight, ref MapAttrNode[] RefMapMatrix, ref List<int> CheckPointList)
	{
		for (int i = 0; i < PointWidth; i++)
		{
			for (int j = 0; j < PointHeight; j++)
			{
				RefMapMatrix[X + i + (Y + j) * MapWidth].IsPointBlock = true;
				RefMapMatrix[X + i + (Y + j) * MapWidth].BlockCatDir = MapCatFlag.CAT_NSWE;
				CheckPointList.Remove(X + i + (Y + j) * MapWidth);
				if (i == 0 && j == 0)
				{
					RefMapMatrix[X + i + (Y + j) * MapWidth].InPointLoc = PointBlockLocFlag.PBL_NW;
				}
				else if (i == PointWidth - 1 && j == 0)
				{
					RefMapMatrix[X + i + (Y + j) * MapWidth].InPointLoc = PointBlockLocFlag.PBL_NE;
				}
				else if (i == 0 && j == PointHeight - 1)
				{
					RefMapMatrix[X + i + (Y + j) * MapWidth].InPointLoc = PointBlockLocFlag.PBL_SW;
				}
				else if (i == PointWidth - 1 && j == PointHeight - 1)
				{
					RefMapMatrix[X + i + (Y + j) * MapWidth].InPointLoc = PointBlockLocFlag.PBL_SE;
				}
				else if (j == 0)
				{
					RefMapMatrix[X + i + (Y + j) * MapWidth].InPointLoc = PointBlockLocFlag.PBL_N;
				}
				else if (i == 0)
				{
					RefMapMatrix[X + i + (Y + j) * MapWidth].InPointLoc = PointBlockLocFlag.PBL_W;
				}
				else if (i == PointWidth - 1)
				{
					RefMapMatrix[X + i + (Y + j) * MapWidth].InPointLoc = PointBlockLocFlag.PBL_E;
				}
				else if (j == PointHeight - 1)
				{
					RefMapMatrix[X + i + (Y + j) * MapWidth].InPointLoc = PointBlockLocFlag.PBL_S;
				}
				else
				{
					RefMapMatrix[X + i + (Y + j) * MapWidth].InPointLoc = PointBlockLocFlag.PBL_NSWE;
				}
			}
		}
	}

	private static bool CheckCanBePoint(in int EntranceX, in int EntranceY, in int ExitX, in int ExitY, in int X, in int Y, in int PointWidth, in int PointHeight, in int MapWidth, in int MapHeight, ref MapAttrNode[] RefMapMatrix, bool CanBeAdjacent = true)
	{
		bool flag = true;
		bool flag2 = true;
		int num = ((!CanBeAdjacent) ? 1 : 0);
		for (int i = -num; i < PointWidth + num; i++)
		{
			for (int j = -num; j < PointHeight + num; j++)
			{
				flag2 = IsSafeIndex(X + i, Y + j, MapWidth, MapHeight);
				if (i != -1 && j != -1 && i != PointWidth && j != PointHeight)
				{
					flag = flag && flag2;
				}
				flag &= X + i != EntranceX || Y + j != EntranceY;
				flag &= X + i != ExitX || Y + j != ExitY;
				if (!flag)
				{
					return flag;
				}
				if (flag2)
				{
					flag &= !RefMapMatrix[X + i + (Y + j) * MapWidth].IsPointBlock;
				}
			}
		}
		return flag;
	}

	private static void ResetMapInfo(ref MapProceduralInfo MapInfo)
	{
		MapAttrNode[] array = MapInfo.MapInfoMatrix.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].IsPointBlock = false;
			array[i].BlockCatDir = MapCatFlag.CAT_NONE;
			array[i].PathCatID = 0uL;
			array[i].InPointLoc = PointBlockLocFlag.PBL_NONE;
		}
		MapInfo.PathCount = 0;
		MapInfo.PointsData.Clear();
		MapInfo.LinesData.Clear();
		MapInfo.MapInfoMatrix = array.ToList();
	}

	private static void QueryAllAdjacentBlocks(int X, int Y, int MapWidth, int MapHeight, ref MapAttrNode[] RefMapMatrix, ref MapCatFlag RefFlagValue, in List<MapPointData> PointsData)
	{
		int num = X + Y * MapWidth;
		RefFlagValue = RefMapMatrix[num].BlockCatDir;
		if (X == 0)
		{
			RefFlagValue &= (MapCatFlag)251;
		}
		if (X == MapWidth - 1)
		{
			RefFlagValue &= (MapCatFlag)247;
		}
		if (Y == 0)
		{
			RefFlagValue &= (MapCatFlag)254;
		}
		if (Y == MapHeight - 1)
		{
			RefFlagValue &= (MapCatFlag)253;
		}
		QueryBlock(X + 1, Y, MapWidth, MapHeight, num, ref RefMapMatrix, MapCatFlag.CAT_E, ref RefFlagValue, in PointsData);
		QueryBlock(X - 1, Y, MapWidth, MapHeight, num, ref RefMapMatrix, MapCatFlag.CAT_W, ref RefFlagValue, in PointsData);
		QueryBlock(X, Y + 1, MapWidth, MapHeight, num, ref RefMapMatrix, MapCatFlag.CAT_S, ref RefFlagValue, in PointsData);
		QueryBlock(X, Y - 1, MapWidth, MapHeight, num, ref RefMapMatrix, MapCatFlag.CAT_N, ref RefFlagValue, in PointsData);
	}

	private static void QueryBlock(int X, int Y, int MapWidth, int MapHeight, int SrcIndex, ref MapAttrNode[] RefMapMatrix, in MapCatFlag CompareFlag, ref MapCatFlag RefFlag, in List<MapPointData> PointsData)
	{
		if (!IsSafeIndex(X, Y, MapWidth, MapHeight))
		{
			return;
		}
		int num = Y * MapWidth + X;
		ulong pathCatID = RefMapMatrix[SrcIndex].PathCatID;
		if (RefMapMatrix[num].BlockCatDir == MapCatFlag.CAT_NONE)
		{
			RefFlag &= (MapCatFlag)(byte)(~(int)CompareFlag);
		}
		if (RefMapMatrix[SrcIndex].IsPointBlock && RefMapMatrix[num].IsPointBlock)
		{
			if (!IsInSamePoint(SrcIndex, num, MapWidth, MapHeight, in PointsData) && (RefMapMatrix[num].PathCatID & pathCatID) == 0L)
			{
				RefFlag &= (MapCatFlag)(byte)(~(int)CompareFlag);
			}
		}
		else if ((RefMapMatrix[num].PathCatID & pathCatID) == 0L)
		{
			RefFlag &= (MapCatFlag)(byte)(~(int)CompareFlag);
		}
	}

	private static bool IsInSamePoint(int SrcIndex, int DestIndex, int MapWidth, int MapHeight, in List<MapPointData> PointsData)
	{
		bool flag = false;
		bool flag2 = false;
		foreach (MapPointData PointsDatum in PointsData)
		{
			for (int i = 0; i < PointsDatum.PointWidth; i++)
			{
				for (int j = 0; j < PointsDatum.PointHeight; j++)
				{
					int num = PointsDatum.X + i + (PointsDatum.Y + j) * MapWidth;
					if (SrcIndex == num)
					{
						flag = true;
					}
					if (DestIndex == num)
					{
						flag2 = true;
					}
					if (flag && flag2)
					{
						return true;
					}
				}
			}
			if (flag ^ flag2)
			{
				return false;
			}
		}
		return false;
	}

	private static bool IsSafeIndex(int X, int Y, int MapWidth, int MapHeight)
	{
		if (X < MapWidth && X >= 0)
		{
			if (Y < MapHeight)
			{
				return Y >= 0;
			}
			return false;
		}
		return false;
	}

	private static bool IsMapBorder(int X, int Y, int MapWidth, int MapHeight)
	{
		if (X != 0 && X != MapWidth - 1)
		{
			if (Y != 0)
			{
				return Y == MapHeight - 1;
			}
			return true;
		}
		return true;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU | ProcedualMap")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProceduralMap:MapConnectAllPoints")]
	public static void MapConnectAllPoints(ref MapProceduralInfo MapInfo, MapCatFlag AllowedGeneralCatDir = MapCatFlag.CAT_NSWE, MapCatFlag AllowedEntranceOutCatDir = MapCatFlag.CAT_NSWE, MapCatFlag AllowedExitInCatDir = MapCatFlag.CAT_NSWE)
	{
		ConnectAllPoints(ref MapInfo, AllowedGeneralCatDir, AllowedEntranceOutCatDir, AllowedExitInCatDir);
		PointsConnectionCheck(ref MapInfo);
		TraverseMapAndUpdateBlocks(ref MapInfo);
	}

	private static void ConnectAllPoints(ref MapProceduralInfo MapInfo, MapCatFlag AllowedGeneralCatDir = MapCatFlag.CAT_NSWE, MapCatFlag AllowedEntranceOutCatDir = MapCatFlag.CAT_NSWE, MapCatFlag AllowedExitInCatDir = MapCatFlag.CAT_NSWE)
	{
		int mapWidth = MapInfo.MapWidth;
		int mapHeight = MapInfo.MapHeight;
		ushort num = MapInfo.PathCount;
		int expectedPointNumber = MapInfo.ExpectedPointNumber;
		int num2 = 0;
		bool flag = num2 >= expectedPointNumber;
		MapAttrNode[] RefMapMatrix = MapInfo.MapInfoMatrix.ToArray();
		ulong num3 = GetNewPathID(MapInfo.PathCount);
		if (num3 == 0L)
		{
			return;
		}
		List<int> InPath = new List<int>();
		int num4 = MapInfo.EntranceX + MapInfo.EntranceY * MapInfo.MapWidth;
		int num5 = MapInfo.ExitX + MapInfo.ExitY * MapInfo.MapWidth;
		int num6 = -1;
		RefMapMatrix[num4].BlockCatDir = MapCatFlag.CAT_NSWE;
		RefMapMatrix[num5].BlockCatDir = MapCatFlag.CAT_NSWE;
		MapPointData mapPointData = CreatePointData(MapInfo.EntranceX, MapInfo.EntranceY, 1, 1);
		MapPointData mapPointData2 = CreatePointData(MapInfo.ExitX, MapInfo.ExitY, 1, 1);
		MapPointData pointOne = mapPointData;
		List<MapPointData> list = new List<MapPointData>();
		list.Insert(list.Count, mapPointData);
		while (MapInfo.PointsData.Count > 0)
		{
			int index = FMath.RandRange(0, MapInfo.PointsData.Count - 1);
			int destIndex = FindBestBlockToConnect(mapWidth, mapHeight, MapInfo.PointsData[index], ref RefMapMatrix);
			int num7 = FindBestBlockToConnect(mapWidth, mapHeight, MapInfo.PointsData[index], ref RefMapMatrix);
			num6 = ((num6 == -1) ? num4 : num6);
			if (FindPathWithAStar(num6, destIndex, mapWidth, mapHeight, ref RefMapMatrix, (List<int>)null, out var OutPath, (num6 == num4) ? AllowedEntranceOutCatDir : AllowedGeneralCatDir) && FindPathWithAStar(num7, num5, mapWidth, mapHeight, ref RefMapMatrix, in OutPath, out var OutPath2, (MapInfo.PointsData.Count == 1) ? AllowedExitInCatDir : AllowedGeneralCatDir) && !flag)
			{
				ConnectBlockWithPath(num6, destIndex, mapWidth, mapHeight, ref RefMapMatrix, num3, in OutPath);
				list.Insert(list.Count, MapInfo.PointsData[index]);
				MapInfo.LinesData.Add(CreateLineData(pointOne, MapInfo.PointsData[index], OutPath));
				pointOne = MapInfo.PointsData[index];
				num3 *= 2;
				num++;
				num6 = num7;
				InPath = OutPath2;
				num2++;
				if (num2 >= expectedPointNumber)
				{
					flag = true;
				}
			}
			else
			{
				MapPointData mapPointData3 = MapInfo.PointsData[index];
				for (int i = 0; i < mapPointData3.PointWidth; i++)
				{
					for (int j = 0; j < mapPointData3.PointWidth; j++)
					{
						int num8 = mapPointData3.X + i + (mapPointData3.Y + j) * MapInfo.MapWidth;
						RefMapMatrix[num8].BlockCatDir = MapCatFlag.CAT_NONE;
						RefMapMatrix[num8].InPointLoc = PointBlockLocFlag.PBL_NONE;
						RefMapMatrix[num8].IsPointBlock = false;
						RefMapMatrix[num8].PathCatID = 0uL;
					}
				}
			}
			MapInfo.PointsData.RemoveAt(index);
		}
		List<int> OutPath3;
		if (num6 != -1 && InPath.Count > 0)
		{
			ConnectBlockWithPath(num5, num6, mapWidth, mapHeight, ref RefMapMatrix, num3, in InPath);
			MapInfo.LinesData.Add(CreateLineData(pointOne, mapPointData2, InPath));
		}
		else if ((MapInfo.ExpectedPointNumber == 0 || num6 == -1) && FindPathWithAStar(num4, num5, mapWidth, mapHeight, ref RefMapMatrix, (List<int>)null, out OutPath3))
		{
			ConnectBlockWithPath(num4, num5, mapWidth, mapHeight, ref RefMapMatrix, num3, in OutPath3);
			MapInfo.LinesData.Add(CreateLineData(mapPointData, mapPointData2, OutPath3));
		}
		list.Insert(list.Count, mapPointData2);
		MapInfo.PointsData = list;
		MapInfo.PathCount = num;
		MapInfo.MapInfoMatrix = RefMapMatrix.ToList();
	}

	private static ulong GetNewPathID(int PathCount)
	{
		if (PathCount >= 64)
		{
			return 0uL;
		}
		int i = 1;
		ulong num = 1uL;
		for (; i <= PathCount; i++)
		{
			num *= 2;
		}
		return num;
	}

	private static bool IsEEPoint(in MapPointData PointData, int EntranceX, int EntranceY, int ExitX, int ExitY)
	{
		if (PointData.X == EntranceX && PointData.Y == EntranceY)
		{
			return true;
		}
		if (PointData.X == ExitX && PointData.Y == ExitY)
		{
			return true;
		}
		return false;
	}

	private static MapPointData CreatePointData(int X, int Y, int PointWidth, int PointHeight)
	{
		return new MapPointData
		{
			X = X,
			Y = Y,
			PointWidth = PointWidth,
			PointHeight = PointHeight
		};
	}

	private static MapLineData CreateLineData(MapPointData PointOne, MapPointData PointTwo, List<int> LineIndexes)
	{
		return new MapLineData
		{
			PointOne = PointOne,
			PointTwo = PointTwo,
			Indexes = LineIndexes
		};
	}

	private static void PointsConnectionCheck(ref MapProceduralInfo MapInfo)
	{
		if (MapInfo.LinesData.Count != 0)
		{
			while (!IsMapGeneratedAsExpected(ref MapInfo) && InsertPointInTheLongestLine(ref MapInfo))
			{
			}
		}
	}

	private static bool InsertPointInTheLongestLine(ref MapProceduralInfo MapInfo)
	{
		int num = 0;
		if (MapInfo.LinesData.Count == 0)
		{
			return false;
		}
		MapLineData item = new MapLineData
		{
			Indexes = new List<int>()
		};
		foreach (MapLineData linesDatum in MapInfo.LinesData)
		{
			if (linesDatum.Indexes.Count >= num)
			{
				num = linesDatum.Indexes.Count;
				item = linesDatum;
			}
		}
		if (item.Indexes.Count < MIN_INSERT_LINE_LENGTH)
		{
			return false;
		}
		MapAttrNode[] RefMapMatrix = MapInfo.MapInfoMatrix.ToArray();
		MapPointData pointOne = item.PointOne;
		MapPointData pointTwo = item.PointTwo;
		int item2 = pointOne.X + pointOne.Y * MapInfo.MapWidth;
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		int num2 = item.Indexes[item.Indexes.Count / 2];
		int X = num2 % MapInfo.MapWidth;
		int Y = num2 / MapInfo.MapHeight;
		if (!CheckCanBePoint(in MapInfo.EntranceX, in MapInfo.EntranceY, in MapInfo.ExitX, in MapInfo.ExitY, in X, in Y, 1, 1, in MapInfo.MapWidth, in MapInfo.MapHeight, ref RefMapMatrix, CanBeAdjacent: false))
		{
			return false;
		}
		MapPointData mapPointData = CreatePointData(X, Y, 1, 1);
		int index = (MapInfo.PointsData.IndexOf(pointOne) + MapInfo.PointsData.IndexOf(pointTwo)) / 2 + 1;
		MapInfo.PointsData.Insert(index, mapPointData);
		RefMapMatrix[num2].IsPointBlock = true;
		for (int i = 0; i < item.Indexes.Count; i++)
		{
			if (i <= item.Indexes.Count / 2)
			{
				list.Add(item.Indexes[i]);
			}
			if (i >= item.Indexes.Count / 2)
			{
				list2.Add(item.Indexes[i]);
			}
		}
		if (list.Contains(item2))
		{
			MapInfo.LinesData.Add(CreateLineData(pointOne, mapPointData, list));
			MapInfo.LinesData.Add(CreateLineData(pointTwo, mapPointData, list2));
		}
		else
		{
			MapInfo.LinesData.Add(CreateLineData(pointOne, mapPointData, list2));
			MapInfo.LinesData.Add(CreateLineData(pointTwo, mapPointData, list));
		}
		MapInfo.LinesData.Remove(item);
		MapInfo.MapInfoMatrix = RefMapMatrix.ToList();
		return true;
	}

	private static int FindBestBlockToConnect(int MapWidth, int MapHeight, in MapPointData PointData, ref MapAttrNode[] RefMapMatrix)
	{
		int result = -1;
		List<int> list = new List<int>();
		int x = PointData.X;
		int y = PointData.Y;
		for (int i = 0; i < PointData.PointWidth; i++)
		{
			for (int j = 0; j < PointData.PointWidth; j++)
			{
				list.Add(x + i + (y + j) * MapWidth);
			}
		}
		if (list.Count == 1)
		{
			return list[0];
		}
		List<int> list2 = new List<int>();
		List<int> list3 = new List<int>();
		for (int k = 0; k < list.Count; k++)
		{
			if (RefMapMatrix[list[k]].IsPointBlock)
			{
				if (RefMapMatrix[list[k]].PathCatID == 0L)
				{
					list2.Add(list[k]);
				}
				else
				{
					list3.Add(list[k]);
				}
			}
		}
		if (list2.Count > 0)
		{
			result = list2[FMath.RandRange(0, list2.Count - 1)];
		}
		else if (list3.Count > 0)
		{
			result = list3[FMath.RandRange(0, list3.Count - 1)];
		}
		else if (list.Count > 0)
		{
			result = list[0];
		}
		return result;
	}

	private static bool IsBlockConnected(int SrcIndex, int DestIndex, int MapWidth, int MapHeight, ref MapAttrNode[] RefMapMatrix)
	{
		List<int> RefIsland = new List<int>();
		int x = SrcIndex % MapWidth;
		int y = SrcIndex / MapWidth;
		QueryNeigbourToCalculateAggregation(x, y, MapWidth, MapHeight, ref RefIsland, in RefMapMatrix);
		return RefIsland.Contains(DestIndex);
	}

	private static bool IsPointBlockBorder(int index, ref MapAttrNode[] RefMapMatrix)
	{
		if (RefMapMatrix[index].InPointLoc != PointBlockLocFlag.PBL_NONE)
		{
			return RefMapMatrix[index].InPointLoc != PointBlockLocFlag.PBL_NSWE;
		}
		return false;
	}

	public static bool IsOpenBlock(int index, ref MapAttrNode[] RefMapMatrix)
	{
		if (RefMapMatrix[index].BlockCatDir != MapCatFlag.CAT_NWE && RefMapMatrix[index].BlockCatDir != MapCatFlag.CAT_NWE && RefMapMatrix[index].BlockCatDir != MapCatFlag.CAT_SWE && RefMapMatrix[index].BlockCatDir != MapCatFlag.CAT_NSW && RefMapMatrix[index].BlockCatDir != MapCatFlag.CAT_NSE)
		{
			return RefMapMatrix[index].BlockCatDir == MapCatFlag.CAT_NSWE;
		}
		return true;
	}

	private static bool FindPathWithAStar(int SourceIndex, int DestIndex, int MapWidth, int MapHeight, ref MapAttrNode[] RefMapMatrix, in List<int> Obstacles, out List<int> OutPath, MapCatFlag AllowedCatDir = MapCatFlag.CAT_NSWE)
	{
		int num = SourceIndex % MapWidth;
		int num2 = SourceIndex / MapWidth;
		int num3 = DestIndex % MapWidth;
		int num4 = DestIndex / MapWidth;
		MapPathFindNode[] array = Enumerable.Repeat(new MapPathFindNode
		{
			Parent = -1,
			f = 0,
			g = MapWidth * MapHeight,
			h = 0
		}, MapWidth * MapHeight).ToArray();
		List<int> list = new List<int>();
		list.Add(SourceIndex);
		List<int> list2 = new List<int>();
		bool flag = false;
		int num5 = SourceIndex;
		array[num5].g = 0;
		array[num5].h = FMath.Abs(num - num3) + FMath.Abs(num2 - num4);
		array[num5].f = array[num5].g + array[num5].h;
		while (!flag && list.Count > 0)
		{
			num5 = list[list.Count - 1];
			if (HasReachDestBlock(num5, DestIndex, MapWidth))
			{
				array[DestIndex].Parent = num5;
				flag = true;
				break;
			}
			list.Remove(num5);
			list2.Add(num5);
			int num6 = num5 % MapWidth;
			int num7 = num5 / MapWidth;
			for (int i = -1; i <= 1; i++)
			{
				for (int j = -1; j <= 1; j++)
				{
					if (FMath.Abs(i) + FMath.Abs(j) != 1 || !IsSafeIndex(num6 + i, num7 + j, MapWidth, MapHeight))
					{
						continue;
					}
					int num8 = num6 + i + (num7 + j) * MapWidth;
					if ((AllowedCatDir & MapCatFlag.CAT_S) == 0 && j == 1)
					{
						list2.Add(num8);
					}
					if ((AllowedCatDir & MapCatFlag.CAT_N) == 0 && j == -1)
					{
						list2.Add(num8);
					}
					if ((AllowedCatDir & MapCatFlag.CAT_W) == 0 && i == -1)
					{
						list2.Add(num8);
					}
					else if ((AllowedCatDir & MapCatFlag.CAT_E) == 0 && i == 1)
					{
						list2.Add(num8);
					}
					else
					{
						if (list2.Contains(num8))
						{
							continue;
						}
						if (RefMapMatrix[num8].BlockCatDir != MapCatFlag.CAT_NONE)
						{
							list2.Add(num8);
							continue;
						}
						if (Obstacles != null && Obstacles.Contains(num8))
						{
							list2.Add(num8);
							continue;
						}
						int g = array[num5].g;
						int num9 = FMath.Abs(num6 + i - num3) + FMath.Abs(num7 + j - num4);
						int num10 = g + 1;
						int num11 = num9 + num10;
						if (num10 < g && list2.Contains(num8))
						{
							array[num8].g = num10;
							array[num8].Parent = num5;
						}
						else if (g < num10 && list.Contains(num8))
						{
							array[num8].g = g;
							array[num8].Parent = num5;
						}
						else
						{
							if (list2.Contains(num8) || list.Contains(num8))
							{
								continue;
							}
							array[num8].g = num10;
							array[num8].h = num9;
							array[num8].f = num11;
							array[num8].Parent = num5;
							int index = 0;
							for (int k = 0; k < list.Count; k++)
							{
								if (num11 < array[list[k]].f)
								{
									index = k + 1;
								}
							}
							list.Insert(index, num8);
						}
					}
				}
			}
		}
		OutPath = new List<int>();
		if (flag)
		{
			int num12 = DestIndex;
			while (num12 != SourceIndex)
			{
				num12 = array[num12].Parent;
				OutPath.Insert(0, num12);
			}
		}
		return flag;
	}

	private static void ConnectBlockWithPath(int SourceIndex, int DestIndex, int MapWidth, int MapHeight, ref MapAttrNode[] RefMapMatrix, ulong InPathCatID, in List<int> InPath)
	{
		if (InPath.Count == 0)
		{
			return;
		}
		RefMapMatrix[SourceIndex].BlockCatDir = MapCatFlag.CAT_NSWE;
		RefMapMatrix[SourceIndex].PathCatID |= InPathCatID;
		RefMapMatrix[DestIndex].BlockCatDir = MapCatFlag.CAT_NSWE;
		RefMapMatrix[DestIndex].PathCatID |= InPathCatID;
		RefMapMatrix[InPath[0]].BlockCatDir = MapCatFlag.CAT_NSWE;
		RefMapMatrix[InPath[0]].PathCatID |= InPathCatID;
		RefMapMatrix[InPath[InPath.Count - 1]].BlockCatDir = MapCatFlag.CAT_NSWE;
		RefMapMatrix[InPath[InPath.Count - 1]].PathCatID |= InPathCatID;
		for (int i = 0; i < InPath.Count; i++)
		{
			if (i > 0)
			{
				int num = InPath[i - 1] % MapWidth;
				int num2 = InPath[i - 1] / MapWidth;
				int num3 = InPath[i] % MapWidth;
				int num4 = InPath[i] / MapWidth;
				if (num3 - num == 1)
				{
					RefMapMatrix[InPath[i]].BlockCatDir |= MapCatFlag.CAT_W;
					RefMapMatrix[InPath[i - 1]].BlockCatDir |= MapCatFlag.CAT_E;
				}
				else if (num3 - num == -1)
				{
					RefMapMatrix[InPath[i]].BlockCatDir |= MapCatFlag.CAT_E;
					RefMapMatrix[InPath[i - 1]].BlockCatDir |= MapCatFlag.CAT_W;
				}
				else if (num4 - num2 == 1)
				{
					RefMapMatrix[InPath[i]].BlockCatDir |= MapCatFlag.CAT_N;
					RefMapMatrix[InPath[i - 1]].BlockCatDir |= MapCatFlag.CAT_S;
				}
				else if (num4 - num2 == -1)
				{
					RefMapMatrix[InPath[i]].BlockCatDir |= MapCatFlag.CAT_S;
					RefMapMatrix[InPath[i - 1]].BlockCatDir |= MapCatFlag.CAT_N;
				}
				RefMapMatrix[InPath[i]].PathCatID |= InPathCatID;
			}
		}
	}

	private static bool HasReachDestBlock(int CurrentIndex, int DestIndex, int MapWidth)
	{
		int num = CurrentIndex % MapWidth;
		int num2 = CurrentIndex / MapWidth;
		int num3 = DestIndex % MapWidth;
		int num4 = DestIndex / MapWidth;
		return FMath.Abs(num - num3) + FMath.Abs(num2 - num4) == 1;
	}

	private static bool IsInIsland(int index, ref List<List<int>> Points)
	{
		foreach (List<int> Point in Points)
		{
			if (Point.Contains(index))
			{
				return true;
			}
		}
		return false;
	}

	private static void TraverseMapAndUpdateBlocks(ref MapProceduralInfo MapInfo)
	{
		int mapWidth = MapInfo.MapWidth;
		int mapHeight = MapInfo.MapHeight;
		MapAttrNode[] RefMapMatrix = MapInfo.MapInfoMatrix.ToArray();
		List<MapPointData> PointsData = MapInfo.PointsData;
		for (int i = 0; i < mapWidth * mapHeight; i++)
		{
			if (RefMapMatrix[i].BlockCatDir != MapCatFlag.CAT_NONE)
			{
				int x = i % mapWidth;
				int y = i / mapWidth;
				QueryAllAdjacentBlocks(x, y, mapWidth, mapHeight, ref RefMapMatrix, ref RefMapMatrix[i].BlockCatDir, in PointsData);
			}
		}
		MapInfo.MapInfoMatrix = RefMapMatrix.ToList();
	}

	private static void QueryNeigbourToCalculateAggregation(int X, int Y, int MapWidth, int MapHeight, ref List<int> RefIsland, in MapAttrNode[] RefMapMatrix)
	{
		if (IsSafeIndex(X, Y, MapWidth, MapHeight))
		{
			int num = Y * MapWidth + X;
			if (RefMapMatrix[num].BlockCatDir != MapCatFlag.CAT_NONE)
			{
				RefIsland.Add(num);
			}
			AggregationIteration(X + 1, Y, MapWidth, MapHeight, MapCatFlag.CAT_E, ref RefIsland, in RefMapMatrix);
			AggregationIteration(X - 1, Y, MapWidth, MapHeight, MapCatFlag.CAT_W, ref RefIsland, in RefMapMatrix);
			AggregationIteration(X, Y + 1, MapWidth, MapHeight, MapCatFlag.CAT_S, ref RefIsland, in RefMapMatrix);
			AggregationIteration(X, Y - 1, MapWidth, MapHeight, MapCatFlag.CAT_N, ref RefIsland, in RefMapMatrix);
		}
	}

	private static void AggregationIteration(int X, int Y, int MapWidth, int MapHeight, in MapCatFlag CompareFlag, ref List<int> RefIsland, in MapAttrNode[] RefMapMatrix)
	{
		if (!IsSafeIndex(X, Y, MapWidth, MapHeight))
		{
			return;
		}
		int num = Y * MapWidth + X;
		if (RefMapMatrix[num].BlockCatDir != MapCatFlag.CAT_NONE && !RefIsland.Contains(num))
		{
			MapCatFlag mapCatFlag = RefMapMatrix[num].BlockCatDir | CompareFlag;
			if (mapCatFlag == MapCatFlag.CAT_NS || mapCatFlag == MapCatFlag.CAT_WE || mapCatFlag == MapCatFlag.CAT_NWE || mapCatFlag == MapCatFlag.CAT_SWE || mapCatFlag == MapCatFlag.CAT_NSW || mapCatFlag == MapCatFlag.CAT_NSE || mapCatFlag == MapCatFlag.CAT_NSWE)
			{
				RefIsland.Add(num);
				AggregationIteration(X + 1, Y, MapWidth, MapHeight, MapCatFlag.CAT_E, ref RefIsland, in RefMapMatrix);
				AggregationIteration(X - 1, Y, MapWidth, MapHeight, MapCatFlag.CAT_W, ref RefIsland, in RefMapMatrix);
				AggregationIteration(X, Y + 1, MapWidth, MapHeight, MapCatFlag.CAT_S, ref RefIsland, in RefMapMatrix);
				AggregationIteration(X, Y - 1, MapWidth, MapHeight, MapCatFlag.CAT_N, ref RefIsland, in RefMapMatrix);
			}
		}
	}

	static BGUFuncLibProceduralMap()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibProceduralMap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibProceduralMap));
		MAX_GEN_ATTEMPT = 100;
		MIN_INSERT_LINE_LENGTH = 5;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProceduralMap:BuildDemoMapInfo")]
	private static void BuildDemoMapInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		MapProceduralInfo MapInfo = MapProceduralInfo.FromNative(IntPtr.Add(buffer, BuildDemoMapInfo_MapInfo_Offset));
		bool value = BuildDemoMapInfo(ref MapInfo);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BuildDemoMapInfo_ReturnValue_Offset), 0, BuildDemoMapInfo_ReturnValue_PropertyAddress.Address, value);
		MapProceduralInfo.ToNative(IntPtr.Add(buffer, BuildDemoMapInfo_MapInfo_Offset), MapInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProceduralMap:MapConnectAllPoints")]
	private static void MapConnectAllPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		MapProceduralInfo MapInfo = MapProceduralInfo.FromNative(IntPtr.Add(buffer, MapConnectAllPoints_MapInfo_Offset));
		MapCatFlag allowedGeneralCatDir = EnumMarshaler<MapCatFlag>.FromNative(IntPtr.Add(buffer, MapConnectAllPoints_AllowedGeneralCatDir_Offset), 0, MapConnectAllPoints_AllowedGeneralCatDir_PropertyAddress.Address);
		MapCatFlag allowedEntranceOutCatDir = EnumMarshaler<MapCatFlag>.FromNative(IntPtr.Add(buffer, MapConnectAllPoints_AllowedEntranceOutCatDir_Offset), 0, MapConnectAllPoints_AllowedEntranceOutCatDir_PropertyAddress.Address);
		MapCatFlag allowedExitInCatDir = EnumMarshaler<MapCatFlag>.FromNative(IntPtr.Add(buffer, MapConnectAllPoints_AllowedExitInCatDir_Offset), 0, MapConnectAllPoints_AllowedExitInCatDir_PropertyAddress.Address);
		MapConnectAllPoints(ref MapInfo, allowedGeneralCatDir, allowedEntranceOutCatDir, allowedExitInCatDir);
		MapProceduralInfo.ToNative(IntPtr.Add(buffer, MapConnectAllPoints_MapInfo_Offset), MapInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProceduralMap:MapPopulateWithPoints")]
	private static void MapPopulateWithPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		MapProceduralInfo MapInfo = MapProceduralInfo.FromNative(IntPtr.Add(buffer, MapPopulateWithPoints_MapInfo_Offset));
		MapPopulateWithPoints(ref MapInfo);
		MapProceduralInfo.ToNative(IntPtr.Add(buffer, MapPopulateWithPoints_MapInfo_Offset), MapInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProceduralMap:InitProceduralMapConfig")]
	private static void InitProceduralMapConfig__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWProceduralMapConfigDataAsset MapConfigDataAsset = UObjectMarshaler<BGWProceduralMapConfigDataAsset>.FromNative(IntPtr.Add(buffer, InitProceduralMapConfig_MapConfigDataAsset_Offset));
		BGWProceduralMapBlockMappingDataAsset MapBlockMappingInfo = UObjectMarshaler<BGWProceduralMapBlockMappingDataAsset>.FromNative(IntPtr.Add(buffer, InitProceduralMapConfig_MapBlockMappingInfo_Offset));
		BGWCustomLightConfigDataAsset MapLightInfo = UObjectMarshaler<BGWCustomLightConfigDataAsset>.FromNative(IntPtr.Add(buffer, InitProceduralMapConfig_MapLightInfo_Offset));
		InitProceduralMapConfig(in MapConfigDataAsset, in MapBlockMappingInfo, in MapLightInfo, out var MapInfo);
		UObjectMarshaler<BGWProceduralMapConfigDataAsset>.ToNative(IntPtr.Add(buffer, InitProceduralMapConfig_MapConfigDataAsset_Offset), MapConfigDataAsset);
		UObjectMarshaler<BGWProceduralMapBlockMappingDataAsset>.ToNative(IntPtr.Add(buffer, InitProceduralMapConfig_MapBlockMappingInfo_Offset), MapBlockMappingInfo);
		UObjectMarshaler<BGWCustomLightConfigDataAsset>.ToNative(IntPtr.Add(buffer, InitProceduralMapConfig_MapLightInfo_Offset), MapLightInfo);
		MapProceduralInfo.ToNative(IntPtr.Add(buffer, InitProceduralMapConfig_MapInfo_Offset), MapInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProceduralMap:BuildWildernessLinearInfo")]
	private static void BuildWildernessLinearInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		MapProceduralInfo MapInfo = MapProceduralInfo.FromNative(IntPtr.Add(buffer, BuildWildernessLinearInfo_MapInfo_Offset));
		bool value = BuildWildernessLinearInfo(ref MapInfo);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BuildWildernessLinearInfo_ReturnValue_Offset), 0, BuildWildernessLinearInfo_ReturnValue_PropertyAddress.Address, value);
		MapProceduralInfo.ToNative(IntPtr.Add(buffer, BuildWildernessLinearInfo_MapInfo_Offset), MapInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProceduralMap:GenerateProceduralMapData")]
	private static void GenerateProceduralMapData__Invoker(IntPtr buffer, IntPtr obj)
	{
		MapProceduralInfo MapInfo = MapProceduralInfo.FromNative(IntPtr.Add(buffer, GenerateProceduralMapData_MapInfo_Offset));
		bool value = GenerateProceduralMapData(ref MapInfo);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GenerateProceduralMapData_ReturnValue_Offset), 0, GenerateProceduralMapData_ReturnValue_PropertyAddress.Address, value);
		MapProceduralInfo.ToNative(IntPtr.Add(buffer, GenerateProceduralMapData_MapInfo_Offset), MapInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProceduralMap:BuildProceduralDungeonsInfo")]
	private static void BuildProceduralDungeonsInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		MapProceduralInfo MapInfo = MapProceduralInfo.FromNative(IntPtr.Add(buffer, BuildProceduralDungeonsInfo_MapInfo_Offset));
		bool value = BuildProceduralDungeonsInfo(ref MapInfo);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BuildProceduralDungeonsInfo_ReturnValue_Offset), 0, BuildProceduralDungeonsInfo_ReturnValue_PropertyAddress.Address, value);
		MapProceduralInfo.ToNative(IntPtr.Add(buffer, BuildProceduralDungeonsInfo_MapInfo_Offset), MapInfo);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibProceduralMap");
		BuildDemoMapInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BuildDemoMapInfo");
		BuildDemoMapInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildDemoMapInfo_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BuildDemoMapInfo_MapInfo_PropertyAddress, BuildDemoMapInfo_FunctionAddress, "MapInfo");
		BuildDemoMapInfo_MapInfo_Offset = NativeReflection.GetPropertyOffset(BuildDemoMapInfo_FunctionAddress, "MapInfo");
		BuildDemoMapInfo_MapInfo_IsValid = NativeReflection.ValidatePropertyClass(BuildDemoMapInfo_FunctionAddress, "MapInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BuildDemoMapInfo_ReturnValue_PropertyAddress, BuildDemoMapInfo_FunctionAddress, "ReturnValue");
		BuildDemoMapInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BuildDemoMapInfo_FunctionAddress, "ReturnValue");
		BuildDemoMapInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BuildDemoMapInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BuildDemoMapInfo_IsValid = BuildDemoMapInfo_FunctionAddress != IntPtr.Zero && BuildDemoMapInfo_MapInfo_IsValid && BuildDemoMapInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProceduralMap:BuildDemoMapInfo", BuildDemoMapInfo_IsValid);
		MapConnectAllPoints_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MapConnectAllPoints");
		MapConnectAllPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(MapConnectAllPoints_FunctionAddress);
		NativeReflection.GetPropertyRef(ref MapConnectAllPoints_MapInfo_PropertyAddress, MapConnectAllPoints_FunctionAddress, "MapInfo");
		MapConnectAllPoints_MapInfo_Offset = NativeReflection.GetPropertyOffset(MapConnectAllPoints_FunctionAddress, "MapInfo");
		MapConnectAllPoints_MapInfo_IsValid = NativeReflection.ValidatePropertyClass(MapConnectAllPoints_FunctionAddress, "MapInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref MapConnectAllPoints_AllowedGeneralCatDir_PropertyAddress, MapConnectAllPoints_FunctionAddress, "AllowedGeneralCatDir");
		MapConnectAllPoints_AllowedGeneralCatDir_Offset = NativeReflection.GetPropertyOffset(MapConnectAllPoints_FunctionAddress, "AllowedGeneralCatDir");
		MapConnectAllPoints_AllowedGeneralCatDir_IsValid = NativeReflection.ValidatePropertyClass(MapConnectAllPoints_FunctionAddress, "AllowedGeneralCatDir", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MapConnectAllPoints_AllowedEntranceOutCatDir_PropertyAddress, MapConnectAllPoints_FunctionAddress, "AllowedEntranceOutCatDir");
		MapConnectAllPoints_AllowedEntranceOutCatDir_Offset = NativeReflection.GetPropertyOffset(MapConnectAllPoints_FunctionAddress, "AllowedEntranceOutCatDir");
		MapConnectAllPoints_AllowedEntranceOutCatDir_IsValid = NativeReflection.ValidatePropertyClass(MapConnectAllPoints_FunctionAddress, "AllowedEntranceOutCatDir", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MapConnectAllPoints_AllowedExitInCatDir_PropertyAddress, MapConnectAllPoints_FunctionAddress, "AllowedExitInCatDir");
		MapConnectAllPoints_AllowedExitInCatDir_Offset = NativeReflection.GetPropertyOffset(MapConnectAllPoints_FunctionAddress, "AllowedExitInCatDir");
		MapConnectAllPoints_AllowedExitInCatDir_IsValid = NativeReflection.ValidatePropertyClass(MapConnectAllPoints_FunctionAddress, "AllowedExitInCatDir", Classes.FEnumProperty);
		MapConnectAllPoints_IsValid = MapConnectAllPoints_FunctionAddress != IntPtr.Zero && MapConnectAllPoints_MapInfo_IsValid && MapConnectAllPoints_AllowedGeneralCatDir_IsValid && MapConnectAllPoints_AllowedEntranceOutCatDir_IsValid && MapConnectAllPoints_AllowedExitInCatDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProceduralMap:MapConnectAllPoints", MapConnectAllPoints_IsValid);
		MapPopulateWithPoints_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MapPopulateWithPoints");
		MapPopulateWithPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(MapPopulateWithPoints_FunctionAddress);
		NativeReflection.GetPropertyRef(ref MapPopulateWithPoints_MapInfo_PropertyAddress, MapPopulateWithPoints_FunctionAddress, "MapInfo");
		MapPopulateWithPoints_MapInfo_Offset = NativeReflection.GetPropertyOffset(MapPopulateWithPoints_FunctionAddress, "MapInfo");
		MapPopulateWithPoints_MapInfo_IsValid = NativeReflection.ValidatePropertyClass(MapPopulateWithPoints_FunctionAddress, "MapInfo", Classes.FStructProperty);
		MapPopulateWithPoints_IsValid = MapPopulateWithPoints_FunctionAddress != IntPtr.Zero && MapPopulateWithPoints_MapInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProceduralMap:MapPopulateWithPoints", MapPopulateWithPoints_IsValid);
		InitProceduralMapConfig_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitProceduralMapConfig");
		InitProceduralMapConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(InitProceduralMapConfig_FunctionAddress);
		InitProceduralMapConfig_MapConfigDataAsset_Offset = NativeReflection.GetPropertyOffset(InitProceduralMapConfig_FunctionAddress, "MapConfigDataAsset");
		InitProceduralMapConfig_MapConfigDataAsset_IsValid = NativeReflection.ValidatePropertyClass(InitProceduralMapConfig_FunctionAddress, "MapConfigDataAsset", Classes.FObjectProperty);
		InitProceduralMapConfig_MapBlockMappingInfo_Offset = NativeReflection.GetPropertyOffset(InitProceduralMapConfig_FunctionAddress, "MapBlockMappingInfo");
		InitProceduralMapConfig_MapBlockMappingInfo_IsValid = NativeReflection.ValidatePropertyClass(InitProceduralMapConfig_FunctionAddress, "MapBlockMappingInfo", Classes.FObjectProperty);
		InitProceduralMapConfig_MapLightInfo_Offset = NativeReflection.GetPropertyOffset(InitProceduralMapConfig_FunctionAddress, "MapLightInfo");
		InitProceduralMapConfig_MapLightInfo_IsValid = NativeReflection.ValidatePropertyClass(InitProceduralMapConfig_FunctionAddress, "MapLightInfo", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref InitProceduralMapConfig_MapInfo_PropertyAddress, InitProceduralMapConfig_FunctionAddress, "MapInfo");
		InitProceduralMapConfig_MapInfo_Offset = NativeReflection.GetPropertyOffset(InitProceduralMapConfig_FunctionAddress, "MapInfo");
		InitProceduralMapConfig_MapInfo_IsValid = NativeReflection.ValidatePropertyClass(InitProceduralMapConfig_FunctionAddress, "MapInfo", Classes.FStructProperty);
		InitProceduralMapConfig_IsValid = InitProceduralMapConfig_FunctionAddress != IntPtr.Zero && InitProceduralMapConfig_MapConfigDataAsset_IsValid && InitProceduralMapConfig_MapBlockMappingInfo_IsValid && InitProceduralMapConfig_MapLightInfo_IsValid && InitProceduralMapConfig_MapInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProceduralMap:InitProceduralMapConfig", InitProceduralMapConfig_IsValid);
		BuildWildernessLinearInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BuildWildernessLinearInfo");
		BuildWildernessLinearInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildWildernessLinearInfo_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BuildWildernessLinearInfo_MapInfo_PropertyAddress, BuildWildernessLinearInfo_FunctionAddress, "MapInfo");
		BuildWildernessLinearInfo_MapInfo_Offset = NativeReflection.GetPropertyOffset(BuildWildernessLinearInfo_FunctionAddress, "MapInfo");
		BuildWildernessLinearInfo_MapInfo_IsValid = NativeReflection.ValidatePropertyClass(BuildWildernessLinearInfo_FunctionAddress, "MapInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BuildWildernessLinearInfo_ReturnValue_PropertyAddress, BuildWildernessLinearInfo_FunctionAddress, "ReturnValue");
		BuildWildernessLinearInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BuildWildernessLinearInfo_FunctionAddress, "ReturnValue");
		BuildWildernessLinearInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BuildWildernessLinearInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BuildWildernessLinearInfo_IsValid = BuildWildernessLinearInfo_FunctionAddress != IntPtr.Zero && BuildWildernessLinearInfo_MapInfo_IsValid && BuildWildernessLinearInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProceduralMap:BuildWildernessLinearInfo", BuildWildernessLinearInfo_IsValid);
		GenerateProceduralMapData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateProceduralMapData");
		GenerateProceduralMapData_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateProceduralMapData_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GenerateProceduralMapData_MapInfo_PropertyAddress, GenerateProceduralMapData_FunctionAddress, "MapInfo");
		GenerateProceduralMapData_MapInfo_Offset = NativeReflection.GetPropertyOffset(GenerateProceduralMapData_FunctionAddress, "MapInfo");
		GenerateProceduralMapData_MapInfo_IsValid = NativeReflection.ValidatePropertyClass(GenerateProceduralMapData_FunctionAddress, "MapInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GenerateProceduralMapData_ReturnValue_PropertyAddress, GenerateProceduralMapData_FunctionAddress, "ReturnValue");
		GenerateProceduralMapData_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GenerateProceduralMapData_FunctionAddress, "ReturnValue");
		GenerateProceduralMapData_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GenerateProceduralMapData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateProceduralMapData_IsValid = GenerateProceduralMapData_FunctionAddress != IntPtr.Zero && GenerateProceduralMapData_MapInfo_IsValid && GenerateProceduralMapData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProceduralMap:GenerateProceduralMapData", GenerateProceduralMapData_IsValid);
		BuildProceduralDungeonsInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BuildProceduralDungeonsInfo");
		BuildProceduralDungeonsInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildProceduralDungeonsInfo_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BuildProceduralDungeonsInfo_MapInfo_PropertyAddress, BuildProceduralDungeonsInfo_FunctionAddress, "MapInfo");
		BuildProceduralDungeonsInfo_MapInfo_Offset = NativeReflection.GetPropertyOffset(BuildProceduralDungeonsInfo_FunctionAddress, "MapInfo");
		BuildProceduralDungeonsInfo_MapInfo_IsValid = NativeReflection.ValidatePropertyClass(BuildProceduralDungeonsInfo_FunctionAddress, "MapInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BuildProceduralDungeonsInfo_ReturnValue_PropertyAddress, BuildProceduralDungeonsInfo_FunctionAddress, "ReturnValue");
		BuildProceduralDungeonsInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BuildProceduralDungeonsInfo_FunctionAddress, "ReturnValue");
		BuildProceduralDungeonsInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BuildProceduralDungeonsInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BuildProceduralDungeonsInfo_IsValid = BuildProceduralDungeonsInfo_FunctionAddress != IntPtr.Zero && BuildProceduralDungeonsInfo_MapInfo_IsValid && BuildProceduralDungeonsInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProceduralMap:BuildProceduralDungeonsInfo", BuildProceduralDungeonsInfo_IsValid);
	}
}
