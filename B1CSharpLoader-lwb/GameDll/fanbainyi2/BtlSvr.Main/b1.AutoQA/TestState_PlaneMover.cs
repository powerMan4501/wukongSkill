using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal class TestState_PlaneMover : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		RecoverFromLastTest,
		StartFromSingleRebirthPoint,
		StartFromEveryRebirthPoint,
		SelectPoint,
		TeleportToOriginPoint,
		WaitForPlayerStable,
		GetDirection,
		TryToMove,
		FinishTest
	}

	public enum ReachStatus
	{
		Smooth,
		HalfWay,
		Deviated,
		Blocked,
		Fallen
	}

	public class ReachResult
	{
		public ReachStatus Status;

		public FVector CurrentPosition;

		public FVector StablePoint;

		public FVector TargetPoint;

		public ReachResult(ReachStatus Status, FVector CurrentPosition)
		{
			this.Status = Status;
			this.CurrentPosition = CurrentPosition;
			StablePoint = FVector.ZeroVector;
			TargetPoint = FVector.ZeroVector;
		}

		public ReachResult(ReachStatus Status, FVector CurrentPosition, FVector StablePoint, FVector TargetPoint)
		{
			this.Status = Status;
			this.CurrentPosition = CurrentPosition;
			this.StablePoint = StablePoint;
			this.TargetPoint = TargetPoint;
		}

		public override string ToString()
		{
			return Status.ToString() + "," + CurrentPosition.ToString();
		}
	}

	public Dictionary<QADirections, FVector> QADirectionsToFVector = new Dictionary<QADirections, FVector>
	{
		{
			QADirections.Y,
			new FVector(0.0, StepLength, 0.0)
		},
		{
			QADirections.YX,
			new FVector(StepLength, StepLength, 0.0)
		},
		{
			QADirections.X,
			new FVector(StepLength, 0.0, 0.0)
		},
		{
			QADirections.NYX,
			new FVector(StepLength, -1 * StepLength, 0.0)
		},
		{
			QADirections.NY,
			new FVector(0.0, -1 * StepLength, 0.0)
		},
		{
			QADirections.NYNX,
			new FVector(-1 * StepLength, -1 * StepLength, 0.0)
		},
		{
			QADirections.NX,
			new FVector(-1 * StepLength, 0.0, 0.0)
		},
		{
			QADirections.YNX,
			new FVector(-1 * StepLength, StepLength, 0.0)
		}
	};

	private static readonly int StepLength = 100;

	private static readonly int ReachRadius = 56;

	private static readonly float MoveTimeLimit = 3f;

	private static readonly float FallenLimit = 1000f;

	private readonly string SingleRebirthPointName;

	private readonly FVector SingleDefaultPoint = FVector.ZeroVector;

	private readonly bool CheckDefaultPointVaild;

	private Dictionary<string, FVector> AllBirthPoints;

	private int CheckNumber;

	private readonly int MaxCheckNumber = 3;

	private FVector LastCheckedEndPos;

	private FVector LastFramePlayerLocation;

	private FVector CurrentFramePlayerLocation;

	private const float SUBSTEP_INTERVAL_MONSTER = 0.033f;

	private FVector OriginPoint;

	private FVector IndexPoint;

	private FVector StablePoint;

	private FVector TargetPoint;

	private FVector LastTimePlayerLocation;

	private FVector TempTelPoint;

	private QADirections? CurrentDirection;

	private b1.AutoQA.QADirectionsIterator DirIter;

	private Queue<FVector> PointToTestBFS = new Queue<FVector>();

	private bool IsInTeleportLoading;

	private bool HasMaxValue;

	private float MaxValue;

	private bool HasMinValue;

	private float MinValue;

	private InnerState CurrentState;

	private float CurrentStateCounter;

	public Dictionary<QADirections, ReachResult> SingleResult;

	public Dictionary<FVector, Dictionary<QADirections, ReachResult>> TotalResult = new Dictionary<FVector, Dictionary<QADirections, ReachResult>>();

	public HashSet<FVector> Tested = new HashSet<FVector>();

	private string RecoveryFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/" + SingleRebirthPointName + "PlaneMoverRecovery.csv";

	private string ResultFilePath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/" + SingleRebirthPointName + "PlaneMoverResult.csv";

	private string ResultJsonPath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath + "/" + SingleRebirthPointName + "PlaneMoverResult.json";

	private string AutoTestTempPath => BIS_AutoTestManagerV2.Get(WorldContext).TempFolderPath ?? "";

	public TestState_PlaneMover(UObject WorldContext, string RebirthPointName, bool CheckDefaultPointVaild, ref Dictionary<string, FVector> AllBirthPoints, bool HasMaxValue, float MaxValue, bool HasMinValue, float MinValue)
	{
		base.WorldContext = WorldContext;
		SingleRebirthPointName = RebirthPointName;
		this.CheckDefaultPointVaild = CheckDefaultPointVaild;
		this.AllBirthPoints = AllBirthPoints;
		this.HasMaxValue = HasMaxValue;
		this.MaxValue = MaxValue;
		this.HasMinValue = HasMinValue;
		this.MinValue = MinValue;
		TransferState(InnerState.RecoverFromLastTest);
	}

	public TestState_PlaneMover(UObject WorldContext, string RebirthPointName, FVector StartPoint, bool CheckDefaultPointVaild, ref Dictionary<string, FVector> AllBirthPoints, bool HasMaxValue, float MaxValue, bool HasMinValue, float MinValue)
	{
		base.WorldContext = WorldContext;
		SingleRebirthPointName = RebirthPointName;
		SingleDefaultPoint = StartPoint;
		this.CheckDefaultPointVaild = CheckDefaultPointVaild;
		this.AllBirthPoints = AllBirthPoints;
		this.HasMaxValue = HasMaxValue;
		this.MaxValue = MaxValue;
		this.HasMinValue = HasMinValue;
		this.MinValue = MinValue;
		TransferState(InnerState.RecoverFromLastTest);
	}

	private bool CheckInArea(FVector Location, bool HasMaxValue, float MaxValue, bool HasMinValue, float MinValue)
	{
		if (HasMaxValue && Location.X > MaxValue)
		{
			return false;
		}
		if (HasMinValue && Location.X < MinValue)
		{
			return false;
		}
		return true;
	}

	private void OnDreamTeleportFinished()
	{
		IsInTeleportLoading = false;
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext)?.GetControlledPawn();
		BGUFunctionLibraryCS.BGUAddBuff(aPawn, aPawn, 212, EBuffSourceType.AutoTest);
		TransferState(InnerState.WaitForPlayerStable);
	}

	private void QAAddMovment(UObject WorldContext, QADirections Dir)
	{
		(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext)?.GetControlledPawn()).AddMovementInput(QADirectionsToFVector[Dir].GetSafeNormal());
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		CurrentStateCounter = 0f;
		LastTimePlayerLocation = default(FVector);
	}

	private void DiscoverNewPointBFS(FVector NewPoint)
	{
		PointToTestBFS.Enqueue(NewPoint);
		using StreamWriter streamWriter = new StreamWriter(RecoveryFilePath, append: true);
		streamWriter.WriteLine(NewPoint.ToString());
	}

	private FVector ParseFVector(string coordinateString)
	{
		FVector result = default(FVector);
		foreach (Match item in Regex.Matches(coordinateString, "([XYZ])=([+-]?\\d+\\.?\\d*)"))
		{
			string value = item.Groups[1].Value;
			float num = float.Parse(item.Groups[2].Value);
			switch (value)
			{
			case "X":
				result.X = num;
				break;
			case "Y":
				result.Y = num;
				break;
			case "Z":
				result.Z = num;
				break;
			}
		}
		return result;
	}

	private FVector CalcIndexPoint(FVector InPoint)
	{
		int num = (int)(InPoint.X / (float)StepLength);
		int num2 = (int)(InPoint.Y / (float)StepLength);
		int num3 = (int)(InPoint.Z / (float)StepLength);
		return new FVector(num, num2, num3);
	}

	private bool CheckClosestEndPos(FVector New, FVector TargetPoint)
	{
		bool num = FVector.Distance(New, TargetPoint) < FVector.Distance(LastCheckedEndPos, TargetPoint);
		if (num)
		{
			LastCheckedEndPos = New;
		}
		return num;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		CurrentStateCounter += DeltaTime;
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		APawn aPawn = firstLocalPlayerController?.GetControlledPawn();
		FVector actorLocation = aPawn.GetActorLocation();
		LastFramePlayerLocation = CurrentFramePlayerLocation;
		CurrentFramePlayerLocation = actorLocation;
		switch (CurrentState)
		{
		case InnerState.RecoverFromLastTest:
			if (File.Exists(RecoveryFilePath) && File.Exists(ResultFilePath))
			{
				AutoTestLoggerLib.QALogInfo(WorldContext, "继续上次的踩坑测试");
				foreach (string item2 in File.ReadLines(ResultFilePath))
				{
					string[] array = item2.Split(',');
					FVector fVector5 = ParseFVector(array[1]);
					SingleResult = new Dictionary<QADirections, ReachResult>();
					for (int j = 2; j < array.Length; j += 3)
					{
						QADirections key = (QADirections)Enum.Parse(typeof(QADirections), array[j]);
						ReachStatus status = (ReachStatus)Enum.Parse(typeof(ReachStatus), array[j + 1]);
						FVector currentPosition = ParseFVector(array[j + 2]);
						SingleResult.Add(key, new ReachResult(status, currentPosition));
					}
					TotalResult.Add(fVector5, SingleResult);
					Tested.Add(CalcIndexPoint(fVector5));
				}
				foreach (string item3 in File.ReadLines(RecoveryFilePath))
				{
					PointToTestBFS.Enqueue(ParseFVector(item3));
				}
				StateStack.Push(new AutoTestNodeLib.TestState_Invincible(WorldContext));
				TransferState(InnerState.SelectPoint);
			}
			else
			{
				AutoTestLoggerLib.QALogInfo(WorldContext, "开始一次全新的踩坑测试");
				if (File.Exists(RecoveryFilePath))
				{
					File.Delete(RecoveryFilePath);
				}
				if (File.Exists(ResultFilePath))
				{
					File.Delete(ResultFilePath);
				}
				if (File.Exists(ResultJsonPath))
				{
					File.Delete(ResultJsonPath);
				}
				StateStack.Push(new AutoTestNodeLib.TestState_Invincible(WorldContext));
				if (SingleRebirthPointName == null)
				{
					TransferState(InnerState.StartFromEveryRebirthPoint);
				}
				else
				{
					TransferState(InnerState.StartFromSingleRebirthPoint);
				}
			}
			Description = "RecoverFromLastTest";
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.StartFromSingleRebirthPoint:
		{
			FVector fVector3 = FVector.ZeroVector;
			if (SingleDefaultPoint != FVector.ZeroVector)
			{
				fVector3 = SingleDefaultPoint + new FVector(0.0, 0.0, 120.0);
			}
			else
			{
				BGURebirthPointBase[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGURebirthPointBase>(WorldContext);
				foreach (BGURebirthPointBase bGURebirthPointBase in allActorsOfClass)
				{
					if (!(bGURebirthPointBase.GetName() != SingleRebirthPointName))
					{
						BUC_InteractData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(bGURebirthPointBase);
						FUStInteractiveUnitCommDesc interactiveUnitCommDesc2 = BGW_GameDB.GetInteractiveUnitCommDesc(readOnlyData2.InteractiveUnitID);
						FVector v2 = new FVector(interactiveUnitCommDesc2.InteractDistance / 2f, 0.0, 0.0);
						FVector fVector4 = readOnlyData2.QAInteractRangeAnchor.GetWorldTransform().TransformPosition(v2);
						USystemLibrary.DrawDebugSphere(WorldContext, fVector4, 25f, 8, FLinearColor.Pink, 1f, 10f);
						fVector3 = fVector4 + new FVector(0.0, 0.0, 120.0);
					}
				}
			}
			DiscoverNewPointBFS(fVector3 + new FVector(0.0, 0.0, 120.0));
			Description = "开场选点完毕";
			StateStack.Push(new AutoTestNodeLib.TestState_Invincible(WorldContext));
			TransferState(InnerState.SelectPoint);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.StartFromEveryRebirthPoint:
		{
			BGURebirthPointBase[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGURebirthPointBase>(WorldContext);
			for (int i = 0; i < allActorsOfClass.Length; i++)
			{
				BUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(allActorsOfClass[i]);
				FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(readOnlyData.InteractiveUnitID);
				FVector v = new FVector(interactiveUnitCommDesc.InteractDistance / 2f, 0.0, 0.0);
				FVector fVector = readOnlyData.QAInteractRangeAnchor.GetWorldTransform().TransformPosition(v);
				USystemLibrary.DrawDebugSphere(WorldContext, fVector, 25f, 8, FLinearColor.Pink, 1f, 10f);
				DiscoverNewPointBFS(fVector + new FVector(0.0, 0.0, 120.0));
			}
			Description = "开场选点完毕";
			StateStack.Push(new AutoTestNodeLib.TestState_Invincible(WorldContext));
			TransferState(InnerState.SelectPoint);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.SelectPoint:
			while (PointToTestBFS.Count > 0)
			{
				OriginPoint = PointToTestBFS.Dequeue();
				IndexPoint = CalcIndexPoint(OriginPoint);
				List<string> list = new List<string>();
				foreach (KeyValuePair<string, FVector> allBirthPoint in AllBirthPoints)
				{
					if (CalcIndexPoint(allBirthPoint.Value) == CalcIndexPoint(OriginPoint))
					{
						list.Add(allBirthPoint.Key);
					}
				}
				foreach (string item4 in list)
				{
					AllBirthPoints.Remove(item4);
				}
				if (!CheckInArea(OriginPoint, HasMaxValue, MaxValue, HasMinValue, MinValue))
				{
					AutoTestLoggerLib.QALogInfo(WorldContext, IndexPoint.ToString() + "超过划定区域,放弃");
					continue;
				}
				if (Tested.Contains(IndexPoint))
				{
					AutoTestLoggerLib.QALogInfo(WorldContext, IndexPoint.ToString() + " 已经测过了，放弃");
					continue;
				}
				Tested.Add(IndexPoint);
				StablePoint = default(FVector);
				DirIter = new b1.AutoQA.QADirectionsIterator();
				SingleResult = new Dictionary<QADirections, ReachResult>();
				TransferState(InnerState.TeleportToOriginPoint);
				Description = "找到了待测点 " + IndexPoint.ToString();
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "没有点了，结束啦";
			TransferState(InnerState.FinishTest);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.TeleportToOriginPoint:
			if (IsInTeleportLoading)
			{
				Description = "等待传送加载完成";
				return AutoTestNodeLib.NodeState.Running;
			}
			if (StablePoint != default(FVector))
			{
				if (FVector.Distance(StablePoint, BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn)) > 10000f)
				{
					IsInTeleportLoading = true;
					BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
					bGW_EventCollection.Evt_BGW_PlayerTeleportToFinished = (BGW_EventCollection.Del_PlayerTeleportToFinished)Delegate.Combine(bGW_EventCollection.Evt_BGW_PlayerTeleportToFinished, new BGW_EventCollection.Del_PlayerTeleportToFinished(OnDreamTeleportFinished));
					BGUFunctionLibraryCS.TeleportToLevelPosition(WorldContext, UBGWFunctionLibraryCS.GetLevelIdByLevelName(UGameplayStatics.GetCurrentLevelName(WorldContext)), StablePoint, new FRotator(0.0, 40.0, 0.0), TravelUseDefaultPlayerStart: false);
					Description = "传送到稳定点";
				}
				else
				{
					UBGUFunctionLibraryForCS.BGUTeleportTo(aPawn, OriginPoint, default(FRotator), bIsATest: false, bNoCheck: true);
					Description = "传送到稳定点";
					TransferState(InnerState.WaitForPlayerStable);
				}
			}
			else if (FVector.Distance(OriginPoint, BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn)) > 10000f)
			{
				IsInTeleportLoading = true;
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection2.Evt_BGW_PlayerTeleportToFinished = (BGW_EventCollection.Del_PlayerTeleportToFinished)Delegate.Combine(bGW_EventCollection2.Evt_BGW_PlayerTeleportToFinished, new BGW_EventCollection.Del_PlayerTeleportToFinished(OnDreamTeleportFinished));
				BGUFunctionLibraryCS.TeleportToLevelPosition(WorldContext, UBGWFunctionLibraryCS.GetLevelIdByLevelName(UGameplayStatics.GetCurrentLevelName(WorldContext)), OriginPoint, new FRotator(0.0, 40.0, 0.0), TravelUseDefaultPlayerStart: false);
				Description = "传送到origin点";
			}
			else
			{
				UBGUFunctionLibraryForCS.BGUTeleportTo(aPawn, OriginPoint, default(FRotator), bIsATest: false, bNoCheck: true);
				Description = "传送到origin点";
				TransferState(InnerState.WaitForPlayerStable);
			}
			firstLocalPlayerController.StopMovement();
			(aPawn as ACharacter).StopAnimMontage(null);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.WaitForPlayerStable:
		{
			if (CurrentStateCounter > MoveTimeLimit * 5f)
			{
				TransferState(InnerState.SelectPoint);
				Description = $"传送Origin点{OriginPoint}过程中出现无限下落，不尝试重传了";
				return AutoTestNodeLib.NodeState.Running;
			}
			StateStack.Push(new AutoTestNodeLib.TestState_Invincible(WorldContext));
			BGW_EventCollection bGW_EventCollection3 = BGW_EventCollection.Get(WorldContext);
			bGW_EventCollection3.Evt_BGW_PlayerTeleportToFinished = (BGW_EventCollection.Del_PlayerTeleportToFinished)Delegate.Remove(bGW_EventCollection3.Evt_BGW_PlayerTeleportToFinished, new BGW_EventCollection.Del_PlayerTeleportToFinished(OnDreamTeleportFinished));
			if (LastTimePlayerLocation == default(FVector))
			{
				LastTimePlayerLocation = actorLocation;
				TempTelPoint = actorLocation;
				Description = "等待角色位置稳定中";
			}
			else if ((double)FVector.Distance(actorLocation, LastTimePlayerLocation) < 0.01)
			{
				StablePoint = actorLocation;
				Description = "角色位置已经稳定 " + StablePoint.ToString();
				StateStack.Push(new AutoTestNodeLib.TestState_WaitForPreloadAndShader(WorldContext));
				TransferState(InnerState.GetDirection);
			}
			else
			{
				LastTimePlayerLocation = actorLocation;
				Description = "等待角色位置稳定中";
			}
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.GetDirection:
			CurrentDirection = DirIter.GetNextUnused();
			if (!CurrentDirection.HasValue)
			{
				TotalResult.Add(OriginPoint, SingleResult);
				using (StreamWriter streamWriter = new StreamWriter(ResultFilePath, append: true))
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(IndexPoint.ToString());
					stringBuilder.Append(",");
					stringBuilder.Append(OriginPoint.ToString());
					stringBuilder.Append(",");
					foreach (KeyValuePair<QADirections, ReachResult> item5 in SingleResult)
					{
						stringBuilder.Append(item5.Key.ToString());
						stringBuilder.Append(",");
						stringBuilder.Append(item5.Value.ToString());
						stringBuilder.Append(",");
					}
					stringBuilder.Remove(stringBuilder.Length - 1, 1);
					streamWriter.WriteLine(stringBuilder.ToString());
				}
				Description = "该点完成";
				TransferState(InnerState.SelectPoint);
			}
			else
			{
				TargetPoint = StablePoint + QADirectionsToFVector[CurrentDirection.Value];
				FRotator newRotation = UMathLibrary.FindLookAtRotation(firstLocalPlayerController.PlayerCameraManager.GetCameraLocation(), TargetPoint);
				aPawn.SetActorRotation(newRotation, bTeleportPhysics: false);
				Description = "换个方向";
				TransferState(InnerState.TryToMove);
			}
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.TryToMove:
		{
			double num = UMathLibrary.Distance2D(new FVector2D(actorLocation.X, actorLocation.Y), new FVector2D(TargetPoint.X, TargetPoint.Y));
			double num2 = TargetPoint.Z - actorLocation.Z;
			Description = "[Dist]离目的地还有" + num;
			if (num2 > (double)FallenLimit)
			{
				SingleResult.Add(CurrentDirection.Value, new ReachResult(ReachStatus.Fallen, actorLocation));
				CheckNumber = 0;
				Description = "掉下去了";
				TransferState(InnerState.TeleportToOriginPoint);
			}
			else if (BGUFunctionLibraryCS.BGUHasUnitState(aPawn, EBGUUnitState.JumpMoving))
			{
				Description = "主角跳跃中, HeightBetween = " + num2;
				if (CurrentStateCounter > MoveTimeLimit * 5f)
				{
					SingleResult.Add(CurrentDirection.Value, new ReachResult(ReachStatus.Fallen, actorLocation));
					CheckNumber = 0;
					TransferState(InnerState.TeleportToOriginPoint);
				}
			}
			else if (FVector.DotProduct(actorLocation - StablePoint, actorLocation - TargetPoint) > 0f)
			{
				firstLocalPlayerController.StopMovement();
				(aPawn as ACharacter).StopAnimMontage(null);
				if (actorLocation != LastTimePlayerLocation)
				{
					LastTimePlayerLocation = actorLocation;
					Description = "到达了目标位置，但是等待主角稳定中";
				}
				else
				{
					FVector fVector2 = FMath.ClosestPointOnLine(LastFramePlayerLocation, CurrentFramePlayerLocation, TargetPoint);
					float num3 = FVector2D.Distance(new FVector2D(fVector2.X, fVector2.Y), new FVector2D(TargetPoint.X, TargetPoint.Y));
					bool flag = DeltaTime > 0.033f;
					if (num < (double)ReachRadius || (flag && num3 < (float)ReachRadius))
					{
						SingleResult.Add(CurrentDirection.Value, new ReachResult(ReachStatus.Smooth, actorLocation));
						CheckNumber = 0;
						DiscoverNewPointBFS(actorLocation);
						AutoTestLoggerLib.QALogInfo(WorldContext, CurrentDirection.Value.ToString() + " 方向上成功到达, 距离为" + num);
						Description = "成功到达";
						TransferState(InnerState.TeleportToOriginPoint);
					}
					else
					{
						if ((double)FVector2D.Distance(new FVector2D(actorLocation.X, actorLocation.Y), new FVector2D(StablePoint.X, StablePoint.Y)) > 680.0 && CheckNumber < MaxCheckNumber)
						{
							DirIter.RollBackDirIndex();
							if (CheckNumber == 0)
							{
								LastCheckedEndPos = actorLocation;
							}
							CheckClosestEndPos(actorLocation, TargetPoint);
							Description = $"第{CheckNumber}次测试，差距过大，重新测";
							CheckNumber++;
						}
						else
						{
							if (CheckNumber != 3)
							{
								LastCheckedEndPos = actorLocation;
							}
							SingleResult.Add(CurrentDirection.Value, new ReachResult(ReachStatus.Deviated, LastCheckedEndPos));
							AutoTestLoggerLib.QALogInfo(WorldContext, CurrentDirection.Value.ToString() + " 方向上偏航, 距离为" + num);
							Description = "偏航了";
							CheckNumber = 0;
						}
						TransferState(InnerState.TeleportToOriginPoint);
					}
				}
			}
			else
			{
				if (!(CurrentStateCounter > MoveTimeLimit) && !(actorLocation == LastTimePlayerLocation))
				{
					LastTimePlayerLocation = actorLocation;
					QAAddMovment(WorldContext, CurrentDirection.Value);
					return AutoTestNodeLib.NodeState.Running;
				}
				if (UMathLibrary.Distance2D(new FVector2D(actorLocation.X, actorLocation.Y), new FVector2D(StablePoint.X, StablePoint.Y)) < (double)ReachRadius)
				{
					SingleResult.Add(CurrentDirection.Value, new ReachResult(ReachStatus.Blocked, actorLocation));
					CheckNumber = 0;
					Description = "原地阻塞";
				}
				else
				{
					SingleResult.Add(CurrentDirection.Value, new ReachResult(ReachStatus.HalfWay, actorLocation));
					CheckNumber = 0;
					Description = "走到半路";
				}
				TransferState(InnerState.TeleportToOriginPoint);
			}
			Description = null;
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.FinishTest:
		{
			Description = "踩坑测试完成";
			KeyValuePair<string, FVector> keyValuePair = AllBirthPoints.First();
			AllBirthPoints.Remove(keyValuePair.Key);
			if (AllBirthPoints.Count > 0)
			{
				KeyValuePair<string, FVector> keyValuePair2 = AllBirthPoints.First();
				AutoTestNodeLib.TestState_Node item = StateStack.Pop();
				StateStack.Push(new b1.AutoQA.TestState_PlaneMover(WorldContext, keyValuePair2.Key, keyValuePair2.Value, CheckDefaultPointVaild: true, ref AllBirthPoints, HasMaxValue, MaxValue, HasMinValue, MinValue));
				StateStack.Push(item);
			}
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		default:
			Description = "异常流程！";
			return AutoTestNodeLib.NodeState.Running;
		}
	}
}
