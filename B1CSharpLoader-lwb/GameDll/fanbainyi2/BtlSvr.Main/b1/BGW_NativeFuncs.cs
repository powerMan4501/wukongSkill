using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_NativeFuncs
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_TestFunc123(int A, IntPtr B);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void Del_CellPartition_SetInitialParam(double mapWidth, double mapHeight, int cellX, int cellY, double biasX, double biasY, int maxUnit, int maxUnitRadius);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void Del_CellPartition_CAddUnit(IntPtr relatedActor, int objType, int teamIdx, int idx);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void Del_CellPartition_CRemoveUnit(IntPtr relatedActor, int idx);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void Del_CellPartition_CResetCellPartition(int idx);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate void Del_CellPartition_CUpdateUnitPos(IntPtr relatedActor, double newX, double newY, double oldX, double oldY, int idx);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate int Del_CellPartition_CGetNeighbors(IntPtr relatedActor, double range, IntPtr output, int outputMax, int teamFilter, int unitFilter, int idx);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate void Del_CellPartition_CDestroyMgr(int idx);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate int Del_CellPartition_CGetUnitInCircle(double center_x, double center_y, double radius, IntPtr output, int outputMax, int teamFilter, int unitFilter, int filterAnd, int idx);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate int Del_CellPartition_CGetUnitInRect(double center_x, double center_y, double rectWidth, double rectHeight, double rectRotateX, double rectRotateY, IntPtr output, int outputMax, int teamFilter, int unitFilter, int filterAnd, int idx);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int Del_CellPartition_CGetUnitInSector(double center_x, double center_y, double radius, double fatest_x, double fatest_y, double theta, IntPtr output, int outputMax, int teamFilter, int unitFilter, int filterAnd, int idx);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void Del_CellPartition_CSetUnitTeam(IntPtr relatedActor, int newTeam, int idx);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate void Del_CellPartition_CSetUnitFilter(IntPtr relatedActor, int newFilter, int idx);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate void Del_CellPartition_CUpdateAllUnitPos(int idx);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int Del_GSPathFind_NewOneMap(int iMapWidth, int iMapHeight, int iPathBeautyDistSquare);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void Del_GSPathFind_ReleaseMap(int iMapIndex);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate char Del_GSPathFind_GetMapBlockVal(int iMapIndex, ushort x, ushort y);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void Del_GSPathFind_SetMapBlockVal(int iMapIndex, ushort x, ushort y, ushort val);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void Del_GSPathFind_SetGridBlock(int iMapIndex, int posX, int posY, int unitSize, char unitType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate void Del_GSPathFind_ClearGridBlock(int iMapIndex, int posX, int posY, int unitSize, char unitType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate char Del_GSPathFind_IsPointFree(int iMapIndex, int posX, int posY, char unitSize, char unitType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate char Del_GSPathFind_IsPointInStaticBlock(int iMapIndex, int posX, int posY, char unitSize, char unitType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate int Del_GSPathFind_FindPathAllForCS(int iMapIndex, int posBeginX, int posBeginY, int posEndX, int posEndY, int radius, int unitSize, char unitType, IntPtr output);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate char Del_GSPathFind_IsLineThroughForCS(int posBeginX, int posBeginY, int posEndX, int posEndY, char unitSize, char unitType, IntPtr res);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int ECSNetSerializationCallBack(IntPtr ConnectionPtr, int Version, IntPtr param);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate int ECSNetDeSerializationCallBack(IntPtr ConnectionPtr, IntPtr param);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate void Del_GSRep_SwapRepData(IntPtr Actor, IntPtr UserData, IntPtr NativeListData);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void Del_GSRep_Init(ECSNetSerializationCallBack SerializationCallBack, ECSNetDeSerializationCallBack DeSerializationCallBack);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate uint Del_GSRep_GetGUIDForActor(IntPtr Connection, IntPtr Actor);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GSRep_GetActorForGUID(IntPtr Connection, uint GUID);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GSRep_GetActorByNetGuid(IntPtr Connection, IntPtr Actor);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate uint Del_GSRep_GetGUIDByActor(IntPtr Actor);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GSRep_GetActorFromGUID(IntPtr WorldContext, uint GUID);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GSVar_GetData(IntPtr CVar);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int Del_UBGUFunctionLibrary_BGUGetResID(IntPtr Param1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate bool Del_LineTraceForWorldStaticObjects(IntPtr WorldContext, ref FVector StartTrace, ref FVector EndTrace, bool bDebug, IntPtr HitResult);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate bool Del_LineTraceSimpleNoIgnores(IntPtr WorldContext, ref FVector StartTrace, ref FVector EndTrace, ETraceTypeQuery QueryChannel, bool bDebug, IntPtr HitResult, bool bTraceComplex = false);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate bool Del_SetCSharpAdjustLocation(IntPtr MoveComp, FVector Location);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[MonoNativeFunctionWrapper]
	public delegate bool Del_SetCSharpAdJustRotation(IntPtr MoveComp, FRotator Rotation);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate bool Del_SetOptimizeInfo(IntPtr MoveComp, bool IsPatrolling, bool CanOptimizeFromCS, bool IsInBattle, bool bReturnMaterialOnMove);

	[MonoNativeFunctionWrapper]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate bool Del_AddNotifyPreloadedAsset(IntPtr Notify, IntPtr Asset);

	public static Del_TestFunc123 TestFunc123;

	public static Del_CellPartition_SetInitialParam CellPartition_SetInitialParam;

	public static Del_CellPartition_CAddUnit CellPartition_AddUnit;

	public static Del_CellPartition_CRemoveUnit CellPartition_RemoveUnit;

	public static Del_CellPartition_CResetCellPartition CellPartition_ResetCellPartition;

	public static Del_CellPartition_CUpdateUnitPos CellPartition_UpdateUnitPos;

	public static Del_CellPartition_CGetNeighbors CellPartition_GetNeighbors;

	public static Del_CellPartition_CDestroyMgr CellPartition_DestroyMgr;

	public static Del_CellPartition_CGetUnitInCircle CellPartition_GetUnitInCircle;

	public static Del_CellPartition_CGetUnitInRect CellPartition_GetUnitInRect;

	public static Del_CellPartition_CGetUnitInSector CellPartition_GetUnitInSector;

	public static Del_CellPartition_CSetUnitTeam CellPartition_SetUnitTeam;

	public static Del_CellPartition_CSetUnitFilter CellPartition_SetUnitFilter;

	public static Del_CellPartition_CUpdateAllUnitPos CellPartition_UpdateAllUnitPos;

	public static Del_GSPathFind_NewOneMap GSPathFind_NewOneMap;

	public static Del_GSPathFind_ReleaseMap GSPathFind_ReleaseMap;

	public static Del_GSPathFind_GetMapBlockVal GSPathFind_GetMapBlockVal;

	public static Del_GSPathFind_SetMapBlockVal GSPathFind_SetMapBlockVal;

	public static Del_GSPathFind_SetGridBlock GSPathFind_SetGridBlock;

	public static Del_GSPathFind_ClearGridBlock GSPathFind_ClearGridBlock;

	public static Del_GSPathFind_IsPointFree GSPathFind_IsPointFree;

	public static Del_GSPathFind_IsPointInStaticBlock GSPathFind_IsPointInStaticBlock;

	public static Del_GSPathFind_FindPathAllForCS GSPathFind_FindPathAllForCS;

	public static Del_GSPathFind_IsLineThroughForCS GSPathFind_IsLineThroughForCS;

	public static Del_GSRep_SwapRepData GSRep_SwapRepData;

	public static Del_GSRep_Init GSRep_Init;

	public static Del_GSRep_GetActorForGUID GSRep_GetActorForGUID;

	public static Del_GSRep_GetGUIDForActor GSRep_GetGUIDForActor;

	public static Del_GSRep_GetGUIDByActor GSRep_GetGUIDByActor;

	public static Del_GSRep_GetActorFromGUID GSRep_GetActorFromGUID;

	public static Del_GSVar_GetData GSVar_GetData;

	public static Del_UBGUFunctionLibrary_BGUGetResID UBGUFunctionLibrary_BGUGetResID;

	public static Del_LineTraceForWorldStaticObjects LineTraceForWorldStaticObjects;

	public static Del_LineTraceSimpleNoIgnores LineTraceSimpleNoIgnores;

	public static Del_SetCSharpAdjustLocation SetCSharpAdjustLocation;

	public static Del_SetCSharpAdJustRotation SetCSharpAdJustRotation;

	public static Del_SetOptimizeInfo SetOptimizeInfo;

	public static Del_AddNotifyPreloadedAsset AddNotifyPreloadedAsset;

	static BGW_NativeFuncs()
	{
		Type typeFromHandle = typeof(BGW_NativeFuncs);
		Dictionary<string, FIntPtr> allFuncAsMap = UBGWCppExport.GetAllFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (allFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
