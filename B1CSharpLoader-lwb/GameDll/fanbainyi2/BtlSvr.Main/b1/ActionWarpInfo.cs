using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class ActionWarpInfo
{
	public int ResID;

	public int ExecutorNum;

	public FPAQI_SelectUnitTypeInfo SelectUnitTypeInfo;

	public EPriorityActionUnitType UnitType;

	public List<OneActionWarpInfo> ActionWarpList;

	public List<FVector> EQSGoalPos;

	public ActionWarpInfo(int _ResID, int _ExecutorNum, FPAQI_SelectUnitTypeInfo _SelectUnitTypeInfo, EPriorityActionUnitType _UnitType, List<OneActionWarpInfo> _ActionWarpList, List<FVector> _EQSGoalPos)
	{
		ResID = _ResID;
		ExecutorNum = _ExecutorNum;
		SelectUnitTypeInfo = _SelectUnitTypeInfo;
		UnitType = _UnitType;
		ActionWarpList = _ActionWarpList;
		EQSGoalPos = _EQSGoalPos;
	}
}
