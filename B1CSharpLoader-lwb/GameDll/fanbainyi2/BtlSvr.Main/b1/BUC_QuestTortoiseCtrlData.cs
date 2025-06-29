using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_QuestTortoiseCtrlData
{
	public AActor Tortoise;

	public List<int> TortoiseUnitResIDList = new List<int>();

	public HashSet<AActor> TortoiseInBattleUnitActors = new HashSet<AActor>();

	public Dictionary<int, FTortoiseRotateTriggerBoxInfo> TortoiseRotateTriggerBoxInfoDict = new Dictionary<int, FTortoiseRotateTriggerBoxInfo>();

	public bool IsTortoiseRotating;

	public int CurTortoiseRotateID;

	public float CurRotateTime;

	public float TotalRotateTime;

	public FTransform RotateStartTransform;

	public List<int> RotateQueue { get; } = new List<int>();
}
