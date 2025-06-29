using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AsyncLoadingScreen;
using b1.UI.Comm;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class AutoTestNodeLib
{
	public enum NodeState
	{
		Pending,
		Running,
		Failed,
		Succeeded,
		Pause
	}

	public abstract class TestState_Node
	{
		protected UObject WorldContext;

		public abstract NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime);
	}

	private class TestState_SimpleTemplate : TestState_Node
	{
		public TestState_SimpleTemplate(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> _, float DeltaTime)
		{
			Description = "正在执行中";
			return NodeState.Running;
		}
	}

	public class TestState_ComplexTemplate : TestState_Node
	{
		private enum InnerState
		{
			State1,
			State2,
			State3
		}

		private int TickCounter;

		private InnerState CurrentState;

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public TestState_ComplexTemplate(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.State1:
				Description = "在State1做XXX";
				TransferState(InnerState.State2);
				return NodeState.Running;
			case InnerState.State2:
				Description = "事件已完成";
				TransferState(InnerState.State3);
				return NodeState.Running;
			case InnerState.State3:
				Description = "成功";
				return NodeState.Succeeded;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
		}
	}

	public class TestState_LogInfo : TestState_Node
	{
		private readonly string InfoText;

		public TestState_LogInfo(UObject WorldContext, string InfoText)
		{
			base.WorldContext = WorldContext;
			this.InfoText = InfoText;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> _, float DeltaTime)
		{
			Description = InfoText;
			return NodeState.Succeeded;
		}
	}

	public class TestState_RecordFootStep : TestState_Node
	{
		private readonly string RecordFilePath;

		public TestState_RecordFootStep(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
			RecordFilePath = BIS_AutoTestManagerV2.Get(WorldContext).LogFolderPath + "/StepRecord.txt";
			using (new StreamWriter(RecordFilePath, append: false))
			{
			}
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> _, float DeltaTime)
		{
			using (StreamWriter streamWriter = new StreamWriter(RecordFilePath, append: true))
			{
				FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation();
				streamWriter.WriteLine($"new FVector({actorLocation.X:0}, {actorLocation.Y:0}, {actorLocation.Z:0}), ");
			}
			Description = "帧率记录中";
			return NodeState.Running;
		}
	}

	public class TestState_RandomSetSpell : TestState_Node
	{
		public TestState_RandomSetSpell(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> _, float DeltaTime)
		{
			AutoTestHelperLib.RandomSetFaBao(WorldContext);
			AutoTestHelperLib.RandomSetSpell(WorldContext);
			AutoTestHelperLib.RandomSetVigorSkill(WorldContext);
			Description = "随机设置了法宝、技能、化身技";
			return NodeState.Succeeded;
		}
	}

	public class TestState_EndCredits : TestState_Node
	{
		private enum InnerState
		{
			Start,
			WatchEndCredits,
			WaitForLoadMap,
			JudgeNewMapID
		}

		private readonly int ToLevel = 1;

		private InnerState CurrentState;

		private bool bLoadMapCompleted;

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
		}

		public TestState_EndCredits(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		private void OnPostLoadMapWithWorld()
		{
			bLoadMapCompleted = true;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.Start:
			{
				Description = null;
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
				TransferState(InnerState.WatchEndCredits);
				break;
			}
			case InnerState.WatchEndCredits:
				if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
				{
					Description = "看片儿";
					StateStack.Push(new TestState_WatchSequence(WorldContext));
				}
				else if (BIS_AutoTestManagerV2.Get(WorldContext).IsPlayingMV)
				{
					Description = "看章节中转MV";
				}
				else if (BIS_AutoTestManagerV2.Get(WorldContext).IsEndCredits)
				{
					Description = "看EndCredits";
				}
				else
				{
					Description = "演职员表播完了";
					TransferState(InnerState.WaitForLoadMap);
				}
				break;
			case InnerState.WaitForLoadMap:
				if (bLoadMapCompleted)
				{
					BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
					bGW_EventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
					Description = "过图成功";
					TransferState(InnerState.JudgeNewMapID);
				}
				else
				{
					Description = "等待过图中";
				}
				break;
			case InnerState.JudgeNewMapID:
			{
				int currentLevelID = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(WorldContext).CurrentLevelID;
				Description = "到达了关卡 " + currentLevelID;
				if (currentLevelID == ToLevel)
				{
					Description = "到达了目标关卡 " + currentLevelID;
					return NodeState.Succeeded;
				}
				Description = "没有到达目标关卡，当前关卡ID为 " + currentLevelID;
				return NodeState.Failed;
			}
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			return NodeState.Running;
		}
	}

	public class TestState_ReceiveChapterAward : TestState_Node
	{
		private enum InnerState
		{
			WatchMV,
			WatchChapterSeq,
			ReceiveAward,
			GoToNextChapter,
			Confirm,
			WaitForLoadMap,
			JudgeNewMapID
		}

		private int TickCounter;

		private bool Roll;

		private int FromLevel;

		private int ToLevel;

		private bool NeedJudgeLevel;

		private InnerState CurrentState;

		private bool bLoadMapCompleted;

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public TestState_ReceiveChapterAward(UObject WorldContext, int fromLevel, int toLevel)
		{
			base.WorldContext = WorldContext;
			FromLevel = fromLevel;
			ToLevel = toLevel;
			NeedJudgeLevel = true;
		}

		public TestState_ReceiveChapterAward(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
			NeedJudgeLevel = false;
		}

		private void OnPostLoadMapWithWorld()
		{
			bLoadMapCompleted = true;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.WatchMV:
				if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
				{
					Description = "看片儿";
					StateStack.Push(new TestState_WatchSequence(WorldContext));
				}
				else if (BIS_AutoTestManagerV2.Get(WorldContext).IsPlayingMV)
				{
					Description = "看章节中转MV";
				}
				else
				{
					Description = "到了章节中转界面";
					TransferState(InnerState.WatchChapterSeq);
				}
				break;
			case InnerState.WatchChapterSeq:
				if (BGW_ChapterViewMgr.Get(WorldContext).ChapterSeqPlayer == null)
				{
					Description = "等待ChapterSeq加载";
					break;
				}
				if (BGW_ChapterViewMgr.Get(WorldContext).ChapterSeqPlayer.IsPlaying())
				{
					Description = "看章节结尾解说SEQ";
					break;
				}
				Description = "领奖！";
				StateStack.Push(new TestState_Wait(WorldContext, 20));
				TransferState(InnerState.ReceiveAward);
				break;
			case InnerState.ReceiveAward:
				if (AutoTestHelperLib.FindText(WorldContext, "确认", bNeedClick: true))
				{
					Description = "确认收货";
					StateStack.Push(new TestState_Wait(WorldContext, 20));
				}
				else
				{
					Description = "收获完毕";
					TransferState(InnerState.GoToNextChapter);
				}
				break;
			case InnerState.GoToNextChapter:
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIStory", ETriggerEvent.Triggered);
				StateStack.Push(new TestState_Wait(WorldContext, 10));
				Description = "按下了E";
				TransferState(InnerState.Confirm);
				break;
			case InnerState.Confirm:
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
				AutoTestHelperLib.FindText(WorldContext, "确定", bNeedClick: true);
				Description = "点击了确定";
				TransferState(InnerState.WaitForLoadMap);
				break;
			}
			case InnerState.WaitForLoadMap:
				if (bLoadMapCompleted)
				{
					BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
					bGW_EventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
					Description = "过图成功";
					TransferState(InnerState.JudgeNewMapID);
				}
				else
				{
					Description = "等待过图中";
				}
				break;
			case InnerState.JudgeNewMapID:
			{
				int currentLevelID = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(WorldContext).CurrentLevelID;
				if (NeedJudgeLevel)
				{
					if (currentLevelID == ToLevel)
					{
						Description = "到达了目标关卡 " + currentLevelID;
						return NodeState.Succeeded;
					}
					Description = "没有到达目标关卡，当前关卡ID为 " + currentLevelID;
					return NodeState.Failed;
				}
				Description = "到达了目标关卡 " + currentLevelID;
				return NodeState.Succeeded;
			}
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			TickCounter++;
			return NodeState.Running;
		}
	}

	public class TestState_ConsoleCommand : TestState_Node
	{
		private readonly string Command;

		public TestState_ConsoleCommand(UObject WorldContext, string Command)
		{
			base.WorldContext = WorldContext;
			this.Command = Command;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			USystemLibrary.ExecuteConsoleCommand(WorldContext, Command, null);
			AutoTestLoggerLib.QALogInfo(WorldContext, "控制台指令：" + Command);
			Description = "执行完成";
			return NodeState.Succeeded;
		}
	}

	public class TestState_Invincible : TestState_Node
	{
		public TestState_Invincible(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn();
			if (controlledPawn == null || BUS_EventCollectionCS.Get(controlledPawn) == null)
			{
				Description = "还没有主角，在等创生";
				return NodeState.Running;
			}
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.ImmueStiff, IsRemove: false);
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.ImmueImmobilizing, IsRemove: false);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.LockHP", null);
			BIS_AutoTestManagerV2.Get(WorldContext).IsInvincibleMode = true;
			Description = "主角现在锁血，免疫硬直, 免疫定身";
			return NodeState.Succeeded;
		}
	}

	public class TestState_Interact : TestState_Node
	{
		private enum InnerState
		{
			Find_ActorToInteract_ByUClass,
			Find_ActorToInteract_ByName,
			Defeat_Enemy,
			Judge_Interactable,
			RunTo_TargetLocation,
			Reset_PlayerRotation,
			Press_Interact,
			Interact_Begin,
			Interact_End
		}

		private int TickCounter;

		private string ActorName;

		private string ActorLevel;

		private readonly UClass ActorClass;

		private AActor ActorToInteract;

		private bool IgnoreInteractCheck;

		private readonly FVector InteractOffset;

		private InnerState CurrentState;

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public TestState_Interact(UObject WorldContext, string ActorName, bool IgnoreInteractCheck = false, FVector InteractOffset = default(FVector))
		{
			base.WorldContext = WorldContext;
			this.ActorName = ActorName;
			this.IgnoreInteractCheck = IgnoreInteractCheck;
			this.InteractOffset = InteractOffset;
			CurrentState = InnerState.Find_ActorToInteract_ByName;
		}

		public TestState_Interact(UObject WorldContext, string ActorName, string ActorLevel, bool IgnoreInteractCheck = false, FVector InteractOffset = default(FVector))
		{
			base.WorldContext = WorldContext;
			this.ActorName = ActorName;
			this.ActorLevel = ActorLevel;
			this.IgnoreInteractCheck = IgnoreInteractCheck;
			this.InteractOffset = InteractOffset;
			CurrentState = InnerState.Find_ActorToInteract_ByName;
		}

		public TestState_Interact(UObject WorldContext, UClass Class, bool IgnoreInteractCheck = false, FVector InteractOffset = default(FVector))
		{
			base.WorldContext = WorldContext;
			ActorClass = Class;
			this.IgnoreInteractCheck = IgnoreInteractCheck;
			this.InteractOffset = InteractOffset;
			CurrentState = InnerState.Find_ActorToInteract_ByUClass;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.Find_ActorToInteract_ByName:
			{
				Description = "寻找需要交互的物件中";
				AActor[] array = UGameplayStatics.GetAllActorsOfClass<AActor>(WorldContext);
				foreach (AActor aActor2 in array)
				{
					if (aActor2.GetName() == ActorName && (ActorLevel == null || aActor2.GetLevel().GetOutermost().GetName()
						.Contains(ActorLevel)))
					{
						if (aActor2 is BUTamerActor)
						{
							ActorToInteract = (aActor2 as BUTamerActor).GetMonster();
						}
						else
						{
							ActorToInteract = aActor2;
						}
						Description = $"找到了{ActorName}";
						TransferState(InnerState.Judge_Interactable);
						return NodeState.Running;
					}
				}
				Description = "在Interact节点中，未能找到" + ActorName + "，请检查策划是否修改了该区域的配置情况";
				return NodeState.Failed;
			}
			case InnerState.Find_ActorToInteract_ByUClass:
			{
				Description = "寻找需要交互的物件中";
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, ActorClass);
				if (allActorsOfClass.Length == 0)
				{
					Description = "在TestState_Interact节点中，未能找到" + ActorClass.ToString() + "，请检查策划是否修改了该区域的物件布置情况";
					return NodeState.Failed;
				}
				FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation();
				double num = double.MaxValue;
				AActor[] array = allActorsOfClass;
				foreach (AActor aActor in array)
				{
					double num2 = UMathLibrary.Vector_Distance(aActor.GetActorLocation(), actorLocation);
					if (num2 < num)
					{
						num = num2;
						ActorToInteract = aActor;
					}
				}
				ActorName = allActorsOfClass[0].GetName();
				Description = $"找到了{ActorName}";
				TransferState(InnerState.Judge_Interactable);
				break;
			}
			case InnerState.Judge_Interactable:
			{
				UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).StopMovement();
				BUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(ActorToInteract);
				if (readOnlyData == null || readOnlyData.InteractiveUnitID == 0)
				{
					Description = $"{ActorName} 不是个可交互物，请检查脚本配置!";
					return NodeState.Failed;
				}
				if (readOnlyData.InteractUIState == EInteractUIState.Interactable)
				{
					if (!AutoTestHelperLib.Interact(WorldContext))
					{
						Description = "交互失败";
						return NodeState.Failed;
					}
					if (IgnoreInteractCheck)
					{
						Description = "交互成功，根据脚本不检查交互情况";
						return NodeState.Succeeded;
					}
					Description = "交互成功，继续检查后续的交互情况";
					TransferState(InnerState.Interact_Begin);
				}
				else
				{
					Description = "还不能交互，准备移动到交互物附近";
					TransferState(InnerState.RunTo_TargetLocation);
				}
				break;
			}
			case InnerState.RunTo_TargetLocation:
			{
				UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).StopMovement();
				BUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(ActorToInteract);
				FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(readOnlyData.InteractiveUnitID);
				if (readOnlyData.QAInteractRangeAnchor == null)
				{
					Description = "QAInteractRangeAnchor还未获取到，等一下";
					break;
				}
				FVector fVector2 = default(FVector);
				int j;
				for (j = 5; j < 10; j++)
				{
					FVector v = ((InteractOffset == default(FVector)) ? new FVector(interactiveUnitCommDesc.InteractDistance / 10f * (float)j, 0.0, 0.0) : InteractOffset);
					fVector2 = readOnlyData.QAInteractRangeAnchor.GetWorldTransform().TransformPosition(v);
					if (UBGUFunctionLibrary.BGUProjectPointToNavigation(WorldContext, fVector2, out var _, null, null, new FVector(0.0, 0.0, 300.0)))
					{
						AutoTestLoggerLib.QALogInfo(WorldContext, "InteractDistance比例为" + j + "/10");
						break;
					}
				}
				if (j == 10)
				{
					Description = "交互物的可交互范围内，没有Nav，请检查附近的Nav生成情况！";
					return NodeState.Failed;
				}
				AutoTestLoggerLib.QALogInfo(WorldContext, "交互物所在位置 " + ActorToInteract.GetActorLocation().ToString());
				AutoTestLoggerLib.QALogInfo(WorldContext, "准备前往交互对位点 " + fVector2.ToString());
				USystemLibrary.DrawDebugSphere(WorldContext, fVector2, 25f, 8, FLinearColor.Pink, 30f, 10f);
				StateStack.Push(new TestState_AttackOnTheMove(WorldContext, fVector2, ActorName));
				TransferState(InnerState.Reset_PlayerRotation);
				Description = "当前还不能交互，继续前往 " + ActorName;
				break;
			}
			case InnerState.Reset_PlayerRotation:
			{
				UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).StopMovement();
				BUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(ActorToInteract);
				FVector fVector = ((readOnlyData.QAInteractRangeAnchor != null) ? readOnlyData.QAInteractRangeAnchor.GetWorldLocation() : ActorToInteract.GetActorLocation());
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
				APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
				controlledPawn.SetActorRotation((fVector - controlledPawn.GetActorLocation()).Rotation(), bTeleportPhysics: false);
				BUC_PlayerCameraData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(controlledPawn);
				FRotator value = UMathLibrary.FindLookAtRotation(firstLocalPlayerController.PlayerCameraManager.GetCameraLocation(), fVector);
				unPersistentReadOnlyData.ControlData.ControllerRotation.SetValue(value);
				if (TickCounter > 6)
				{
					TransferState(InnerState.Judge_Interactable);
					Description = "完成了角色转身和镜头调整";
				}
				else
				{
					Description = "镜头调整中";
				}
				break;
			}
			case InnerState.Interact_Begin:
				Description = "等待进入交互状态";
				if ((BGU_DataUtil.GetReadOnlyData<IBPC_PlayerInteractData, BPC_PlayerInteractData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).PlayerState) as BPC_PlayerInteractData).IsInInteraction())
				{
					Description = "已进入交互状态";
					TransferState(InnerState.Interact_End);
				}
				break;
			case InnerState.Interact_End:
				Description = "等待交互状态结束";
				if (!(BGU_DataUtil.GetReadOnlyData<IBPC_PlayerInteractData, BPC_PlayerInteractData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).PlayerState) as BPC_PlayerInteractData).IsInInteraction())
				{
					Description = "交互状态结束";
					TransferState(InnerState.Interact_End);
					return NodeState.Succeeded;
				}
				break;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			TickCounter++;
			return NodeState.Running;
		}
	}

	public class TestState_Wait : TestState_Node
	{
		private int TickCounter;

		private readonly int WaitCounter;

		public TestState_Wait(UObject WorldContext, int WaitCounter)
		{
			base.WorldContext = WorldContext;
			this.WaitCounter = WaitCounter;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			if (TickCounter > WaitCounter)
			{
				Description = "等待完毕，继续向下";
				return NodeState.Succeeded;
			}
			Description = "等待中";
			TickCounter++;
			return NodeState.Running;
		}
	}

	public class TestState_Glide : TestState_Node
	{
		public TestState_Glide(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			string text = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn())?.ActiveMover?.ToString();
			if (text == "b1.BGU_GlideMoveMode")
			{
				Description = "滑沙中";
				return NodeState.Running;
			}
			Description = "滑沙完了, 状态为" + text;
			return NodeState.Succeeded;
		}
	}

	public class TestState_B1GM : TestState_Node
	{
		private readonly string GMString;

		public TestState_B1GM(UObject WorldContext, string GMString)
		{
			base.WorldContext = WorldContext;
			this.GMString = GMString;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			BGUFunctionLibraryManaged.RunScriptGM(GMString, WorldContext);
			Description = "B1面板指令：" + GMString;
			return NodeState.Succeeded;
		}
	}

	public class TestState_GenerateUnitFromTamer : TestState_Node
	{
		private enum InnerState
		{
			SpawnTamer,
			WaitSpawnUnit
		}

		private readonly TStrongObjectPtr<UClass> TempBP = new TStrongObjectPtr<UClass>();

		private int Number;

		private InnerState CurrentState;

		private string UnitFinalGUID;

		public TestState_GenerateUnitFromTamer(UObject WorldContext, string ClassPath, int Num = 1)
		{
			base.WorldContext = WorldContext;
			UBlueprint uBlueprint = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UBlueprint>(ClassPath, ELoadResourceType.SyncLoadAndCache);
			if (uBlueprint != null)
			{
				TempBP.Set(uBlueprint.GeneratedClass);
			}
			else
			{
				UClass newValue = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>(ClassPath, ELoadResourceType.SyncLoadAndCache);
				TempBP.Set(newValue);
			}
			Number = Num;
		}

		public TestState_GenerateUnitFromTamer(UObject WorldContext, UClass Class, int Num = 1)
		{
			base.WorldContext = WorldContext;
			TempBP.Set(Class);
			Number = Num;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			if (TempBP.Get() == null)
			{
				Description = "生成失败";
				return NodeState.Succeeded;
			}
			switch (CurrentState)
			{
			case InnerState.SpawnTamer:
			{
				FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation();
				FVector fVector = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorRotation()
					.GetForwardVector() * 1000.0;
				FVector fVector2 = actorLocation + fVector;
				FRotator rotation = UMathLibrary.FindLookAtRotation(fVector2, actorLocation);
				while (Number > 0)
				{
					Number--;
					UnitFinalGUID = BGU_UnrealWorldUtil.RequestSpawnUnit(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), TempBP.Get(), new FTransform(rotation, fVector2), null);
				}
				Description = "生成成功";
				TransferState(InnerState.WaitSpawnUnit);
				break;
			}
			case InnerState.WaitSpawnUnit:
			{
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, TempBP.Get());
				for (int i = 0; i < allActorsOfClass.Length; i++)
				{
					BUTamerActor bUTamerActor = allActorsOfClass[i] as BUTamerActor;
					if (bUTamerActor != null && bUTamerActor.GetFinalGuid() == UnitFinalGUID && bUTamerActor.GetMonster() != null)
					{
						Description = "Unit生成成功";
						return NodeState.Succeeded;
					}
				}
				Description = "等待Unit生成";
				break;
			}
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			return NodeState.Running;
		}
	}

	public class TestState_WatchSequence : TestState_Node
	{
		private enum InnerState
		{
			WaitFor_SequenceStart,
			WaitFor_PauseEnd,
			Watch_Sequence
		}

		private int TickCounter;

		private int SequenceID;

		private readonly int SpellID;

		private InnerState CurrentState;

		public TestState_WatchSequence(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		public TestState_WatchSequence(UObject WorldContext, int SpellID)
		{
			base.WorldContext = WorldContext;
			this.SpellID = SpellID;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.WaitFor_SequenceStart:
				if (TickCounter > 60)
				{
					Description = "等了很久还没开始播片";
					return NodeState.Failed;
				}
				if (AutoTestHelperLib.GetPlayingSequenceID(WorldContext, out SequenceID))
				{
					Description = "开始播放 " + SequenceID;
					TransferState(InnerState.WaitFor_PauseEnd);
				}
				else
				{
					Description = "在等播片开始";
				}
				TickCounter++;
				return NodeState.Running;
			case InnerState.WaitFor_PauseEnd:
			{
				BGW_EventCollection.Get(WorldContext).Evt_RequestUpdateMovieArchiveData();
				TStrongObjectPtr<MovieInstance> tStrongObjectPtr = BGU_DataUtil.GetGameStateReadonlyData<BGC_MovieData>(WorldContext)?.MovieInstances?.Values?.ToList()?.FirstOrDefault();
				if (tStrongObjectPtr == null)
				{
					(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as ACharacter).StopAnimMontage(null);
					Description = SequenceID + " 播片完成";
					return NodeState.Succeeded;
				}
				if (tStrongObjectPtr.Get().bIsPlayingLoopMovie)
				{
					BGS_EventCollectionCS.Get(WorldContext).Evt_SkipCurrentMovie.Invoke();
					Description = "这是个循环播片，跳过其循环部分";
					return NodeState.Running;
				}
				if (tStrongObjectPtr.Get().IsInState(EMoviePlayState.Paused))
				{
					Description = "等待Sequence的Paused状态结束";
					return NodeState.Running;
				}
				TransferState(InnerState.Watch_Sequence);
				Description = "播放 " + SequenceID + " 中";
				return NodeState.Running;
			}
			case InnerState.Watch_Sequence:
			{
				BGW_EventCollection.Get(WorldContext).Evt_RequestUpdateMovieArchiveData();
				BGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_MovieData>(WorldContext);
				if (gameStateReadonlyData != null && gameStateReadonlyData.MovieInstances?.Count == 1)
				{
					TStrongObjectPtr<MovieInstance> tStrongObjectPtr = gameStateReadonlyData.MovieInstances.Values.ToList()[0];
					if (tStrongObjectPtr.Get().IsInState(EMoviePlayState.Paused))
					{
						StateStack.Push(new TestState_GetNewItem(WorldContext, SpellID));
						Description = "Sequence " + SequenceID + " 中打算发放法术 " + SpellID;
						return NodeState.Running;
					}
					Description = "播放 " + SequenceID + " 中";
					return NodeState.Running;
				}
				(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as ACharacter)?.StopAnimMontage(null);
				Description = SequenceID + " 播片完成";
				return NodeState.Succeeded;
			}
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
		}
	}

	public enum AutoBattleExitCondition
	{
		KillTarget = 1,
		CanNotLock = 2,
		SequenceBegin = 4,
		HealthPercent = 8,
		PlayerHasBuff = 0x10,
		SuicideAtHP = 0x20
	}

	public class TestState_AutoBattle : TestState_Node
	{
		private enum InnerState
		{
			FindEnemy_ByName,
			FindEnemy_ByUClass,
			FindEnemy_ByBattleState,
			FindEnemy_InRadius,
			ApproachAndAttack_Enemy
		}

		private int TickCounter;

		private InnerState CurrentState;

		private BGUCharacterCS EnemyUnit;

		private BUTamerActor EnemyTamer;

		private readonly string ActorName;

		private readonly string ActorLevel;

		private readonly UClass Class;

		private AutoBattleExitCondition ExitCondition;

		private string[] ExtraArgs;

		private int Radius;

		public TestState_AutoBattle(UObject WorldContext, BGUCharacterCS EnemyUnit, AutoBattleExitCondition ExitCondition = AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
		{
			base.WorldContext = WorldContext;
			this.EnemyUnit = EnemyUnit;
			this.ExitCondition = ExitCondition;
			this.ExtraArgs = ExtraArgs;
			CurrentState = InnerState.ApproachAndAttack_Enemy;
		}

		public TestState_AutoBattle(UObject WorldContext, BUTamerActor EnemyTamer, AutoBattleExitCondition ExitCondition = AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
		{
			base.WorldContext = WorldContext;
			this.EnemyTamer = EnemyTamer;
			this.ExitCondition = ExitCondition;
			this.ExtraArgs = ExtraArgs;
			CurrentState = InnerState.ApproachAndAttack_Enemy;
		}

		public TestState_AutoBattle(UObject WorldContext, string ActorName, AutoBattleExitCondition ExitCondition = AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
		{
			base.WorldContext = WorldContext;
			this.ActorName = ActorName;
			ActorLevel = null;
			this.ExitCondition = ExitCondition;
			this.ExtraArgs = ExtraArgs;
			CurrentState = InnerState.FindEnemy_ByName;
		}

		public TestState_AutoBattle(UObject WorldContext, string ActorName, string ActorLevel, AutoBattleExitCondition ExitCondition = AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
		{
			base.WorldContext = WorldContext;
			this.ActorName = ActorName;
			this.ActorLevel = ActorLevel;
			this.ExitCondition = ExitCondition;
			this.ExtraArgs = ExtraArgs;
			CurrentState = InnerState.FindEnemy_ByName;
		}

		public TestState_AutoBattle(UObject WorldContext, UClass Class, AutoBattleExitCondition ExitCondition = AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
		{
			base.WorldContext = WorldContext;
			UBlueprint uBlueprint = Class.Cast<UBlueprint>();
			if (uBlueprint != null)
			{
				this.Class = uBlueprint.GeneratedClass.ClassDefaultObject.Cast<BUTamerActor>().GetMonsterClass();
			}
			else
			{
				BUTamerActor bUTamerActor = Class.ClassDefaultObject.Cast<BUTamerActor>();
				if (bUTamerActor != null)
				{
					this.Class = bUTamerActor.GetMonsterClass();
				}
				else
				{
					this.Class = Class;
				}
			}
			this.ExitCondition = ExitCondition;
			this.ExtraArgs = ExtraArgs;
			CurrentState = InnerState.FindEnemy_ByUClass;
		}

		public TestState_AutoBattle(UObject WorldContext, AutoBattleExitCondition ExitCondition = AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
		{
			base.WorldContext = WorldContext;
			this.ExitCondition = ExitCondition;
			this.ExtraArgs = ExtraArgs;
			CurrentState = InnerState.FindEnemy_ByBattleState;
		}

		public TestState_AutoBattle(UObject WorldContext, int Radius, AutoBattleExitCondition ExitCondition = AutoBattleExitCondition.KillTarget, params string[] ExtraArgs)
		{
			base.WorldContext = WorldContext;
			this.Radius = Radius;
			this.ExitCondition = ExitCondition;
			this.ExtraArgs = ExtraArgs;
			CurrentState = InnerState.FindEnemy_InRadius;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			if (BGUFunctionLibraryCS.BGUHasUnitState(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), EBGUUnitState.Dead))
			{
				Description = "主角死了，等待复活";
				return NodeState.Running;
			}
			BGUCharacterCS EnemyUnit;
			switch (CurrentState)
			{
			case InnerState.FindEnemy_ByName:
			{
				BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(WorldContext);
				foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
				{
					if (bGUCharacterCS.GetName() == ActorName && (ActorLevel == null || bGUCharacterCS.GetLevel().GetOutermost().GetName()
						.Contains(ActorLevel)))
					{
						this.EnemyUnit = bGUCharacterCS;
						Description = $"找到了{ActorName}";
						TransferState(InnerState.ApproachAndAttack_Enemy);
						return NodeState.Running;
					}
				}
				BUTamerActor[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>(WorldContext);
				foreach (BUTamerActor bUTamerActor in allActorsOfClass2)
				{
					if (bUTamerActor.GetName() == ActorName && (ActorLevel == null || bUTamerActor.GetLevel().GetOutermost().GetName()
						.Contains(ActorLevel)))
					{
						EnemyTamer = bUTamerActor;
						Description = $"找到了{ActorName}";
						TransferState(InnerState.ApproachAndAttack_Enemy);
						return NodeState.Running;
					}
				}
				Description = "在AutoBattle节点中，未能找到" + ActorName + "，请检查策划是否修改了该区域的种怪情况";
				return NodeState.Failed;
			}
			case InnerState.FindEnemy_ByUClass:
			{
				AActor[] allActorsOfClass3 = UGameplayStatics.GetAllActorsOfClass(WorldContext, Class);
				if (allActorsOfClass3.Length == 0)
				{
					Description = "在AutoBattle节点中，未能找到" + Class.GetName() + "，请检查策划是否修改了该区域的种怪情况";
					return NodeState.Failed;
				}
				this.EnemyUnit = allActorsOfClass3[0] as BGUCharacterCS;
				EnemyTamer = allActorsOfClass3[0] as BUTamerActor;
				Description = $"找到了{allActorsOfClass3[0].GetName()}";
				TransferState(InnerState.ApproachAndAttack_Enemy);
				break;
			}
			case InnerState.FindEnemy_ByBattleState:
				Description = "寻找对自己有仇恨的敌人中";
				if (AutoTestHelperLib.FindNearbyUnit(WorldContext, 3000, out EnemyUnit))
				{
					if (AutoTestHelperLib.IsUnitInBattle(EnemyUnit))
					{
						this.EnemyUnit = EnemyUnit;
						Description = $"找到了{this.EnemyUnit.GetName()}";
						TransferState(InnerState.ApproachAndAttack_Enemy);
						break;
					}
					Description = EnemyUnit.GetName() + " 在身边，但并不敌对";
					return NodeState.Succeeded;
				}
				Description = "身边没有敌人";
				return NodeState.Succeeded;
			case InnerState.FindEnemy_InRadius:
				Description = "寻找对自己有仇恨的敌人中";
				if (AutoTestHelperLib.FindNearbyUnit(WorldContext, Radius, out EnemyUnit))
				{
					this.EnemyUnit = EnemyUnit;
					Description = $"找到了{this.EnemyUnit.GetName()}";
					TransferState(InnerState.ApproachAndAttack_Enemy);
					break;
				}
				Description = "身边没有敌人";
				return NodeState.Succeeded;
			case InnerState.ApproachAndAttack_Enemy:
				if ((ExitCondition & AutoBattleExitCondition.PlayerHasBuff) != 0 && BGUFunctionLibraryCS.BGUHasBuffByID(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), int.Parse(ExtraArgs[0])))
				{
					Description = "侦测到主角有Buff " + ExtraArgs[0] + ",满足了退出条件";
					return NodeState.Succeeded;
				}
				if ((ExitCondition & AutoBattleExitCondition.SequenceBegin) != 0 && AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
				{
					Description = "侦测到播片，满足了战斗退出条件";
					return NodeState.Succeeded;
				}
				if (this.EnemyUnit == null)
				{
					if (EnemyTamer == null)
					{
						Description = "怪物已经消失";
						return NodeState.Succeeded;
					}
					this.EnemyUnit = EnemyTamer.GetMonster();
					if (this.EnemyUnit == null)
					{
						Description = "Tamer " + EnemyTamer.GetName() + " 还未创生Unit，需要往Tamer方向走走";
						AutoTestHelperLib.RunToPosition(WorldContext, EnemyTamer.GetActorLocation());
						return NodeState.Running;
					}
				}
				else if ((ExitCondition & AutoBattleExitCondition.HealthPercent) != 0)
				{
					float num = BGUFunctionLibraryCS.BGUGetFloatAttr(this.EnemyUnit, EBGUAttrFloat.Hp) / BGUFunctionLibraryCS.BGUGetFloatAttr(this.EnemyUnit, EBGUAttrFloat.HpMax);
					if (num <= float.Parse(ExtraArgs[0]))
					{
						Description = "目标怪物满足了血量条件：小于" + (int)(float.Parse(ExtraArgs[0]) * 100f) + "%";
						return NodeState.Succeeded;
					}
					AutoTestLoggerLib.QALogInfo(WorldContext, "目标怪物血量百分比为" + (int)(num * 100f) + "%");
				}
				else if ((ExitCondition & AutoBattleExitCondition.SuicideAtHP) != 0 && BGUFunctionLibraryCS.BGUGetFloatAttr(this.EnemyUnit, EBGUAttrFloat.Hp) / BGUFunctionLibraryCS.BGUGetFloatAttr(this.EnemyUnit, EBGUAttrFloat.HpMax) <= float.Parse(ExtraArgs[0]))
				{
					Description = "目标怪物满足了血量条件：小于" + (int)(float.Parse(ExtraArgs[0]) * 100f) + "%，主角按约定自杀";
					USystemLibrary.ExecuteConsoleCommand(WorldContext, "bn.suicide", null);
					return NodeState.Running;
				}
				if (!BGUFunctionLibraryCS.BGUHasUnitState(this.EnemyUnit, EBGUUnitState.Dead))
				{
					if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), EBGUSimpleState.InAnimationSyncing))
					{
						Description = $"主角正在被抓投";
						return NodeState.Running;
					}
					if (!BGUFunctionLibraryCS.BGUIsEnemyTeam(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), this.EnemyUnit))
					{
						Description = $"目标{this.EnemyUnit.GetName()}已转换为中立阵营";
						return NodeState.Succeeded;
					}
					if (!AutoTestHelperLib.CanUnitBeTarget(this.EnemyUnit))
					{
						if ((ExitCondition & AutoBattleExitCondition.CanNotLock) != 0)
						{
							Description = $"目标{this.EnemyUnit.GetName()}已无法被攻击，转换目标";
							return NodeState.Succeeded;
						}
						if ((ExitCondition & AutoBattleExitCondition.KillTarget) != 0)
						{
							Description = $"目标{this.EnemyUnit.GetName()}已无法被攻击，暂缓攻击";
							return NodeState.Running;
						}
					}
					if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
					{
						Description = "侦测到播片，先看片子";
						StateStack.Push(new TestState_WatchSequence(WorldContext));
						return NodeState.Running;
					}
					AutoTestHelperLib.ApproachAndAttack(WorldContext, this.EnemyUnit);
					Description = $"试图击杀{this.EnemyUnit.GetName()}中";
					break;
				}
				if ((ExitCondition & AutoBattleExitCondition.KillTarget) == 0)
				{
					Description = "未能满足预定的退出条件" + ExitCondition.ToString() + "，怪物被击杀掉了";
					return NodeState.Failed;
				}
				Description = $"目标{this.EnemyUnit.GetName()}已被击杀";
				return NodeState.Succeeded;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			TickCounter++;
			if (TickCounter > 300)
			{
				if (!(this.EnemyUnit != null))
				{
					Description = "未能到达敌人附近，请检查脚本和具体环境！";
					return NodeState.Failed;
				}
				if (TickCounter % 2 == 0 && (int)BGW_GameDB.GetUnitBattleInfoExtendDesc(this.EnemyUnit.GetFinalBattleInfoExtendID()).QualityType < 5)
				{
					BGUFunctionLibraryCS.TriggerEffectToTarget(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), 1080101, this.EnemyUnit);
					Description = "和小怪缠斗太久，多半是卡住了，开始虚空打人！";
				}
			}
			return NodeState.Running;
		}
	}

	public class TestState_BossRushAutoBattle : TestState_Node
	{
		private enum InnerState
		{
			Enter_BossRush,
			FindEnemy,
			ApproachAndAttack_Enemy,
			BattleFinish,
			JustWait
		}

		private int TickCounter;

		private InnerState CurrentState;

		private BGUCharacterCS EnemyUnit;

		private BUTamerActor EnemyTamer;

		private readonly string ActorName;

		private readonly string ActorLevel;

		private readonly UClass Class;

		private AutoBattleExitCondition ExitCondition;

		private string[] ExtraArgs;

		private int Radius;

		private string EnterBRCommand;

		private bool bLoadMapCompleted;

		public TestState_BossRushAutoBattle(UObject WorldContext, string EnterBRCommand)
		{
			base.WorldContext = WorldContext;
			this.EnterBRCommand = EnterBRCommand;
			CurrentState = InnerState.Enter_BossRush;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		private void OnPostLoadMapWithWorld()
		{
			bLoadMapCompleted = true;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			if (BGUFunctionLibraryCS.BGUHasUnitState(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), EBGUUnitState.Dead))
			{
				Description = "主角死了，等待复活";
				return NodeState.Running;
			}
			switch (CurrentState)
			{
			case InnerState.Enter_BossRush:
				Description = "准备进入BR，其指令为" + EnterBRCommand;
				USystemLibrary.ExecuteConsoleCommand(WorldContext, EnterBRCommand, null);
				TransferState(InnerState.FindEnemy);
				StateStack.Push(new TestState_Invincible(WorldContext));
				break;
			case InnerState.FindEnemy:
			{
				Description = "寻找对自己有仇恨的敌人中";
				BGUCharacterCS EnemyUnit;
				if (BIS_AutoTestManagerV2.Get(WorldContext).IsBossRushSettlement)
				{
					BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
					bGW_EventCollection2.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
					USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.sys BossRushFinish", null);
					Description = "BR结束了";
					TransferState(InnerState.BattleFinish);
				}
				else if (AutoTestHelperLib.FindNearbyUnit(WorldContext, 50000, out EnemyUnit))
				{
					this.EnemyUnit = EnemyUnit;
					Description = $"找到了{this.EnemyUnit.GetName()}";
					TransferState(InnerState.ApproachAndAttack_Enemy);
				}
				else
				{
					Description = "身边没有敌人，持续寻找中";
				}
				break;
			}
			case InnerState.ApproachAndAttack_Enemy:
				if (this.EnemyUnit == null)
				{
					Description = "怪物已经消失";
					TransferState(InnerState.FindEnemy);
				}
				else if (!BGUFunctionLibraryCS.BGUHasUnitState(this.EnemyUnit, EBGUUnitState.Dead))
				{
					if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), EBGUSimpleState.InAnimationSyncing))
					{
						Description = $"主角正在被抓投";
						return NodeState.Running;
					}
					if (!BGUFunctionLibraryCS.BGUIsEnemyTeam(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), this.EnemyUnit))
					{
						Description = $"目标{this.EnemyUnit.GetName()}已转换为中立阵营";
						TransferState(InnerState.FindEnemy);
						break;
					}
					if (!AutoTestHelperLib.CanUnitBeTarget(this.EnemyUnit))
					{
						Description = $"目标{this.EnemyUnit.GetName()}已无法被攻击，转换目标";
						TransferState(InnerState.FindEnemy);
						break;
					}
					if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
					{
						Description = "侦测到播片，先看片子";
						StateStack.Push(new TestState_WatchSequence(WorldContext));
						return NodeState.Running;
					}
					AutoTestHelperLib.ApproachAndAttack(WorldContext, this.EnemyUnit);
					Description = $"试图击杀{this.EnemyUnit.GetName()}中";
				}
				else
				{
					Description = $"目标{this.EnemyUnit.GetName()}已被击杀";
					TransferState(InnerState.FindEnemy);
				}
				break;
			case InnerState.BattleFinish:
			{
				BUC_UnitDebugData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitDebugData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn());
				if (bLoadMapCompleted && unPersistentReadOnlyData != null)
				{
					BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
					bGW_EventCollection.Evt_PostLoadMapWithWorld = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostLoadMapWithWorld, new Del_Void(OnPostLoadMapWithWorld));
					Description = "过图成功，主角初始化成功";
					StateStack.Push(new TestState_Wait(WorldContext, 60));
					TransferState(InnerState.JustWait);
				}
				else
				{
					Description = "等待过图中";
				}
				break;
			}
			case InnerState.JustWait:
				Description = "这一轮BR完成";
				return NodeState.Succeeded;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			TickCounter++;
			return NodeState.Running;
		}
	}

	public class TestState_HongWeiAutoBattle : TestState_Node
	{
		private enum InnerState
		{
			FindEnemy_ByName,
			FindEnemy_ByUClass,
			FindEnemy_ByBattleState,
			Approach_Enemy,
			Attack_Enemy
		}

		private int TickCounter;

		private InnerState CurrentState;

		private BGUCharacterCS Enemy;

		private readonly string ActorName;

		private readonly UClass Class;

		public TestState_HongWeiAutoBattle(UObject WorldContext, BGUCharacterCS Enemy)
		{
			base.WorldContext = WorldContext;
			this.Enemy = Enemy;
			CurrentState = InnerState.Approach_Enemy;
		}

		public TestState_HongWeiAutoBattle(UObject WorldContext, string ActorName)
		{
			base.WorldContext = WorldContext;
			this.ActorName = ActorName;
			CurrentState = InnerState.FindEnemy_ByName;
		}

		public TestState_HongWeiAutoBattle(UObject WorldContext, UClass Class)
		{
			base.WorldContext = WorldContext;
			this.Class = Class;
			CurrentState = InnerState.FindEnemy_ByUClass;
		}

		public TestState_HongWeiAutoBattle(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
			CurrentState = InnerState.FindEnemy_ByBattleState;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.FindEnemy_ByName:
			{
				BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(WorldContext);
				foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
				{
					if (bGUCharacterCS.GetName() == ActorName)
					{
						Enemy = bGUCharacterCS;
						Description = $"找到了{ActorName}";
						TransferState(InnerState.Approach_Enemy);
						return NodeState.Running;
					}
				}
				Description = "在AutoBattle节点中，未能找到" + ActorName + "，请检查策划是否修改了该区域的种怪情况";
				return NodeState.Failed;
			}
			case InnerState.FindEnemy_ByUClass:
			{
				AActor[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass(WorldContext, Class);
				if (allActorsOfClass2.Length == 0)
				{
					Description = "在AutoBattle节点中，未能找到" + Class.ToString() + "，请检查策划是否修改了该区域的种怪情况";
					return NodeState.Failed;
				}
				Enemy = allActorsOfClass2[0] as BGUCharacterCS;
				Description = $"找到了{Class.ToString()}";
				TransferState(InnerState.Approach_Enemy);
				break;
			}
			case InnerState.FindEnemy_ByBattleState:
			{
				Description = "寻找对自己有仇恨的敌人中";
				if (AutoTestHelperLib.FindNearbyUnit(WorldContext, 3000, out var EnemyUnit))
				{
					if (AutoTestHelperLib.IsUnitInBattle(EnemyUnit))
					{
						Enemy = EnemyUnit;
						TransferState(InnerState.Approach_Enemy);
					}
					break;
				}
				Description = "身边没有敌人";
				return NodeState.Succeeded;
			}
			case InnerState.Approach_Enemy:
				if (AutoTestHelperLib.GetAutoTestActionState(WorldContext) != EAINodeActionType.Combo)
				{
					AutoTestHelperLib.Combo(WorldContext, 60f, Enemy);
				}
				if (!BGUFunctionLibraryCS.BGUHasUnitState(Enemy, EBGUUnitState.Dead))
				{
					Description = $"试图击杀{Enemy.GetName()}中";
					return NodeState.Running;
				}
				AutoTestHelperLib.StopCurrentAction(WorldContext);
				Description = $"目标{Enemy.GetName()}已被击杀";
				return NodeState.Succeeded;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			TickCounter++;
			return NodeState.Running;
		}
	}

	public enum AutoMoveExitCondition
	{
		ReachDestination,
		SequenceBegin,
		GlideBegin,
		Interactable
	}

	public class TestState_AttackOnTheMove : TestState_Node
	{
		private readonly int AttackRadius;

		private FVector TargetLocation;

		private readonly string DestinationName;

		private readonly AutoMoveExitCondition MoveExitCondition;

		private readonly AutoBattleExitCondition BattleExitCondition;

		private FVector CurrentLocation;

		private readonly string ActorName;

		private readonly string ActorLevel;

		private bool NeedInitialize;

		private int MoveToActionCount;

		private int ReachRadius = 150;

		private bool NeedCheck = true;

		public TestState_AttackOnTheMove(UObject WorldContext, FVector TargetLocation, string DestinationName, int AttackRadius = 1000, AutoMoveExitCondition MoveExitCondition = AutoMoveExitCondition.ReachDestination, AutoBattleExitCondition BattleExitCondition = AutoBattleExitCondition.KillTarget)
		{
			base.WorldContext = WorldContext;
			this.TargetLocation = TargetLocation;
			this.DestinationName = DestinationName;
			this.AttackRadius = AttackRadius;
			this.MoveExitCondition = MoveExitCondition;
			this.BattleExitCondition = BattleExitCondition;
			NeedInitialize = false;
			ReachRadius = 100;
		}

		public TestState_AttackOnTheMove(UObject WorldContext, string ActorName, string DestinationName, int AttackRadius = 1000, AutoMoveExitCondition MoveExitCondition = AutoMoveExitCondition.ReachDestination, AutoBattleExitCondition BattleExitCondition = AutoBattleExitCondition.KillTarget)
		{
			base.WorldContext = WorldContext;
			this.ActorName = ActorName;
			ActorLevel = null;
			this.DestinationName = DestinationName;
			this.AttackRadius = AttackRadius;
			this.MoveExitCondition = MoveExitCondition;
			this.BattleExitCondition = BattleExitCondition;
			NeedInitialize = true;
		}

		public TestState_AttackOnTheMove(UObject WorldContext, string ActorName, string ActorLevel, string DestinationName, int AttackRadius = 1000, AutoMoveExitCondition MoveExitCondition = AutoMoveExitCondition.ReachDestination, AutoBattleExitCondition BattleExitCondition = AutoBattleExitCondition.KillTarget)
		{
			base.WorldContext = WorldContext;
			this.ActorName = ActorName;
			this.ActorLevel = ActorLevel;
			this.DestinationName = DestinationName;
			this.AttackRadius = AttackRadius;
			this.MoveExitCondition = MoveExitCondition;
			this.BattleExitCondition = BattleExitCondition;
			NeedInitialize = true;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			if (BGUFunctionLibraryCS.BGUHasUnitState(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), EBGUUnitState.Dead))
			{
				Description = "主角死了，等待复活";
				return NodeState.Running;
			}
			if (NeedInitialize)
			{
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(WorldContext);
				foreach (AActor aActor in allActorsOfClass)
				{
					if (aActor.GetName() == ActorName && (ActorLevel == null || aActor.GetLevel().GetOutermost().GetName()
						.Contains(ActorLevel)))
					{
						TargetLocation = aActor.GetActorLocation() + aActor.GetActorForwardVector() * 250.0;
						NeedInitialize = false;
						Description = $"找到了{ActorName}";
						return NodeState.Running;
					}
				}
				Description = "在AttackOnTheMove节点中，未能找到" + ActorName + "，请检查策划是否修改了该区域的种怪情况";
				return NodeState.Failed;
			}
			if (NeedCheck)
			{
				AutoTestLoggerLib.QALogInfo(WorldContext, "目标点为 " + TargetLocation.ToString());
				if (!UBGUFunctionLibrary.BGUProjectPointToNavigation(WorldContext, TargetLocation, out var _, null, null, new FVector(0.0, 0.0, 500.0)))
				{
					AutoTestLoggerLib.QALogWarning(WorldContext, "目标点 " + TargetLocation.ToString() + " 是一个没有Nav的地方！");
				}
				NeedCheck = false;
			}
			if (AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
			{
				Description = "侦测到播片，开始看片";
				if (MoveExitCondition == AutoMoveExitCondition.SequenceBegin)
				{
					return NodeState.Succeeded;
				}
				StateStack.Push(new TestState_WatchSequence(WorldContext));
				return NodeState.Pause;
			}
			if (MoveExitCondition == AutoMoveExitCondition.GlideBegin && "b1.BGU_GlideMoveMode" == BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn())?.ActiveMover?.ToString())
			{
				Description = "进入了滑沙状态";
				return NodeState.Succeeded;
			}
			if (AutoTestHelperLib.FindNearbyUnit(WorldContext, AttackRadius, out var EnemyUnit))
			{
				Description = $"发现身边{AttackRadius}范围内有敌人{EnemyUnit.GetName()}，选定其为目标开始攻击";
				StateStack.Push(new TestState_AutoBattle(WorldContext, EnemyUnit, BattleExitCondition));
				return NodeState.Pause;
			}
			if (AutoTestHelperLib.RunToPosition(WorldContext, TargetLocation, ReachRadius))
			{
				Description = "到达了目的地" + DestinationName;
				return NodeState.Succeeded;
			}
			CurrentLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation();
			Description = "当前行进目标" + DestinationName;
			return NodeState.Running;
		}
	}

	public enum QARebirthPointChoice
	{
		Leave,
		Rest,
		Teleport
	}

	public class TestState_ActivateRebirthPoint : TestState_Node
	{
		private enum InnerState
		{
			Check_IsInBattle,
			Check_InteractUI,
			Press_Interact,
			Click_RestUI,
			Click_LeaveUI,
			Click_TeleportUI,
			Choose_TeleportPoint_1,
			Choose_TeleportPoint_2,
			Check_LeaveResult
		}

		private InnerState CurrentState = InnerState.Press_Interact;

		private int TickCounter;

		private List<UUserWidget> TempWidgets;

		private TStrongObjectPtr<UClass> TempBP = new TStrongObjectPtr<UClass>();

		private string ActorName;

		private QARebirthPointChoice Choice;

		private string[] ExtraArgs;

		public TestState_ActivateRebirthPoint(UObject WorldContext, string ActorName, QARebirthPointChoice Choice = QARebirthPointChoice.Leave, params string[] ExtraArgs)
		{
			base.WorldContext = WorldContext;
			this.ActorName = ActorName;
			this.Choice = Choice;
			this.ExtraArgs = ExtraArgs;
			TempBP.Set(BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/ShrineInteractive/BUI_Tudi_Enter.BUI_Tudi_Enter_C'", ELoadResourceType.SyncLoadAndCache));
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.Check_InteractUI:
			case InnerState.Press_Interact:
				StateStack.Push(new TestState_Interact(WorldContext, ActorName, IgnoreInteractCheck: true));
				Description = "试着和土地庙交互中";
				switch (Choice)
				{
				case QARebirthPointChoice.Leave:
					TransferState(InnerState.Click_LeaveUI);
					break;
				case QARebirthPointChoice.Rest:
					TransferState(InnerState.Click_RestUI);
					break;
				case QARebirthPointChoice.Teleport:
					TransferState(InnerState.Click_TeleportUI);
					break;
				}
				return NodeState.Pause;
			case InnerState.Click_RestUI:
				Description = "等待土地庙UI出现中";
				if (TickCounter < 20)
				{
					break;
				}
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out TempWidgets, TempBP.Get(), TopLevelOnly: false);
				if (TempWidgets.Count == 1)
				{
					UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets3, "调息");
					if (FoundWidgets3.Count == 1)
					{
						using (List<UWidget>.Enumerator enumerator = FoundWidgets3.GetEnumerator())
						{
							if (enumerator.MoveNext())
							{
								AutoTestHelperLib.ClickButton((UTextBlock)enumerator.Current);
							}
						}
						Description = "点击了土地庙的调息按钮";
						TransferState(InnerState.Click_LeaveUI);
						break;
					}
					Description = "土地庙界面没有调息按钮!";
					return NodeState.Failed;
				}
				Description = "交互后没有显示土地庙界面!";
				return NodeState.Failed;
			case InnerState.Click_TeleportUI:
				Description = "等待土地庙UI出现中";
				if (TickCounter < 20)
				{
					break;
				}
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out TempWidgets, TempBP.Get(), TopLevelOnly: false);
				if (TempWidgets.Count == 1)
				{
					UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets5, "缩地");
					if (FoundWidgets5.Count == 1)
					{
						using (List<UWidget>.Enumerator enumerator = FoundWidgets5.GetEnumerator())
						{
							if (enumerator.MoveNext())
							{
								AutoTestHelperLib.ClickButton((UTextBlock)enumerator.Current);
							}
						}
						Description = "点击了土地庙的缩地按钮";
						TransferState(InnerState.Choose_TeleportPoint_1);
						break;
					}
					Description = "土地庙界面没有缩地按钮!";
					return NodeState.Failed;
				}
				Description = "交互后没有显示土地庙界面!";
				return NodeState.Failed;
			case InnerState.Choose_TeleportPoint_1:
			{
				string rebirthGroupNameById = BGUFuncLibMap.GetRebirthGroupNameById(BGW_GameDB.GetRebirthPointDesc(int.Parse(ExtraArgs[0])).GroupMapID);
				UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets2, rebirthGroupNameById);
				if (FoundWidgets2.Count == 1)
				{
					using (List<UWidget>.Enumerator enumerator = FoundWidgets2.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							AutoTestHelperLib.ClickButton((UTextBlock)enumerator.Current);
						}
					}
					Description = "点击了大关卡" + rebirthGroupNameById;
					TransferState(InnerState.Choose_TeleportPoint_2);
					break;
				}
				Description = "关卡列表没有" + rebirthGroupNameById;
				return NodeState.Failed;
			}
			case InnerState.Choose_TeleportPoint_2:
			{
				string name = BGW_GameDB.GetRebirthPointDesc(int.Parse(ExtraArgs[0])).Name;
				UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets, name);
				if (FoundWidgets.Count == 1)
				{
					using (List<UWidget>.Enumerator enumerator = FoundWidgets.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							AutoTestHelperLib.ClickButton((UTextBlock)enumerator.Current);
						}
					}
					Description = "点击了传送点" + name;
					return NodeState.Succeeded;
				}
				Description = "缩地列表没有" + name;
				return NodeState.Failed;
			}
			case InnerState.Click_LeaveUI:
				Description = "等待土地庙UI出现中";
				if (TickCounter < 20)
				{
					break;
				}
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out TempWidgets, TempBP.Get(), TopLevelOnly: false);
				if (TempWidgets.Count == 1)
				{
					UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets4, "离开");
					if (FoundWidgets4.Count == 1)
					{
						using (List<UWidget>.Enumerator enumerator = FoundWidgets4.GetEnumerator())
						{
							if (enumerator.MoveNext())
							{
								AutoTestHelperLib.ClickButton((UTextBlock)enumerator.Current);
							}
						}
						Description = "点击了土地庙的离开按钮";
						TransferState(InnerState.Check_LeaveResult);
						break;
					}
					Description = "土地庙界面没有离开按钮!";
					return NodeState.Failed;
				}
				Description = "交互后没有显示土地庙界面!";
				return NodeState.Failed;
			case InnerState.Check_LeaveResult:
				Description = "检测土地庙界面中";
				if (TickCounter >= 10)
				{
					UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out TempWidgets, TempBP.Get(), TopLevelOnly: false);
					if (TempWidgets.Count == 0 || TempWidgets[0].GetVisibility() == ESlateVisibility.HitTestInvisible)
					{
						Description = "土地庙界面在离开后消失";
						return NodeState.Succeeded;
					}
					Description = "土地庙界面在离开后没有消失!";
					return NodeState.Failed;
				}
				break;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			TickCounter++;
			return NodeState.Running;
		}
	}

	public class TestState_Teleport : TestState_Node
	{
		private enum InnerState
		{
			Find_ActorToTeleport,
			Do_Teleport
		}

		private InnerState CurrentState;

		private int TickCounter;

		private string ActorName;

		private string ActorLevel;

		private AActor ActorToTeleport;

		public TestState_Teleport(UObject WorldContext, string ActorName, string ActorLevel)
		{
			base.WorldContext = WorldContext;
			this.ActorName = ActorName;
			this.ActorLevel = ActorLevel;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.Find_ActorToTeleport:
			{
				Description = "寻找传送目标";
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(WorldContext);
				foreach (AActor aActor in allActorsOfClass)
				{
					if (aActor.GetName() == ActorName && aActor.GetLevel().GetOutermost().GetName()
						.Contains(ActorLevel))
					{
						ActorToTeleport = aActor;
						Description = $"找到了{ActorName}";
						TransferState(InnerState.Do_Teleport);
						return NodeState.Running;
					}
				}
				Description = "没有在 " + ActorLevel + " 中找到传送目标 " + ActorName;
				return NodeState.Failed;
			}
			case InnerState.Do_Teleport:
			{
				FVector actorLocation = ActorToTeleport.GetActorLocation();
				Description = "执行传送至" + actorLocation.ToString();
				USystemLibrary.ExecuteConsoleCommand(WorldContext, $"b.teleportToPosition {actorLocation.X.ToString()} {actorLocation.Y.ToString()} {actorLocation.Z.ToString()}", null);
				return NodeState.Succeeded;
			}
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
		}
	}

	public class TestState_TestBegin : TestState_Node
	{
		private enum InnerState
		{
			WaitFor_PlayerBeginPlay,
			Add_Buff,
			Judge_StartPoint,
			Skip_StartSequence,
			TeleportTo_Destination,
			WaitFor_Teleport,
			Rest,
			Kill_UnitsNearby,
			WaitFor_Preload,
			TestBeginFinish
		}

		private InnerState CurrentState;

		private int TickCounter;

		private List<UUserWidget> TempWidgets;

		private UClass TempBP;

		private int StartSceneSequenceID;

		private int StartRebirthPointID;

		private string StartActorName;

		private bool TeleportFinish;

		public TestState_TestBegin(UObject WorldContext, int StartRebirthPointID, string StartActorLable, int StartSceneSequenceID)
		{
			base.WorldContext = WorldContext;
			this.StartRebirthPointID = StartRebirthPointID;
			StartActorName = StartActorLable;
			this.StartSceneSequenceID = StartSceneSequenceID;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		private void OnDreamTeleportFinished()
		{
			TeleportFinish = true;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.WaitFor_PlayerBeginPlay:
				Description = "等待主角初始化完成中";
				if (BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitDebugData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn()) != null)
				{
					if (BGWGameInstanceCS.Get(WorldContext).GetCurLoadingScreenState() == EGSLoadingScreenState.Idle)
					{
						Description = "LoadingScreen已消失";
						StateStack.Push(new TestState_Wait(WorldContext, 10));
						TransferState(InnerState.Add_Buff);
					}
					else
					{
						Description = "等待LoadingScreen消失中";
					}
				}
				break;
			case InnerState.Add_Buff:
				Description = "给主角上无敌";
				StateStack.Push(new TestState_Invincible(WorldContext));
				TransferState(InnerState.Judge_StartPoint);
				break;
			case InnerState.Judge_StartPoint:
			{
				if (AutoTestHelperLib.GetPlayingSequenceID(WorldContext, out var SequenceID) && SequenceID == StartSceneSequenceID)
				{
					Description = "在播开场的Sequence " + StartSceneSequenceID + "，说明是从头执行的，准备跳过这一段，直接前往测试出发点";
					StateStack.Push(new TestState_Wait(WorldContext, 10));
					TransferState(InnerState.Skip_StartSequence);
					break;
				}
				BGURebirthPointBase[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGURebirthPointBase>(WorldContext);
				foreach (BGURebirthPointBase bGURebirthPointBase in allActorsOfClass)
				{
					if (bGURebirthPointBase.GetName() == StartActorName && UMathLibrary.Vector_Distance(bGURebirthPointBase.GetActorLocation(), UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation()) < 5000.0)
					{
						Description = "已经在" + StartActorName + "附近";
						TransferState(InnerState.WaitFor_Preload);
						return NodeState.Running;
					}
				}
				Description = "不在" + StartActorName + "附近，需要传送";
				TransferState(InnerState.TeleportTo_Destination);
				break;
			}
			case InnerState.Skip_StartSequence:
				if (!AutoTestHelperLib.IsPlayingCameraMovie(WorldContext))
				{
					Description = "Sequence " + StartSceneSequenceID + " 已经被跳过了";
					TransferState(InnerState.TeleportTo_Destination);
				}
				else
				{
					BGS_EventCollectionCS.Get(WorldContext).Evt_SkipCurrentMovie.Invoke();
					Description = "使用GM跳过Sequence " + StartSceneSequenceID;
					StateStack.Push(new TestState_Wait(WorldContext, 10));
				}
				break;
			case InnerState.TeleportTo_Destination:
			{
				Description = "使用GM指令直接传到出生点" + StartRebirthPointID;
				TeleportFinish = false;
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(WorldContext);
				bGW_EventCollection2.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Combine(bGW_EventCollection2.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.TeleToRebirthPoint " + StartRebirthPointID, null);
				TransferState(InnerState.WaitFor_Teleport);
				break;
			}
			case InnerState.WaitFor_Teleport:
				if (TeleportFinish)
				{
					Description = "传送已完成";
					BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(WorldContext);
					bGW_EventCollection.Evt_LoadingBeginFadeAway = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_LoadingBeginFadeAway, new Del_Void(OnDreamTeleportFinished));
					TransferState(InnerState.Judge_StartPoint);
				}
				else
				{
					Description = "等待传送中";
				}
				break;
			case InnerState.WaitFor_Preload:
				Description = "跳过预加载检查";
				StateStack.Push(new TestState_AddDebugUI(WorldContext));
				StateStack.Push(new TestState_Invincible(WorldContext));
				TransferState(InnerState.TestBeginFinish);
				break;
			case InnerState.TestBeginFinish:
				(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as ACharacter).StopAnimMontage(null);
				Description = "测试准备工作就绪";
				return NodeState.Succeeded;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			TickCounter++;
			return NodeState.Running;
		}
	}

	public class TestState_GetNewItem : TestState_Node
	{
		private enum InnerState
		{
			Check_HasSpell,
			Check_DropUI,
			Click_ConfirmUI,
			Check_ConfirmResult
		}

		private InnerState CurrentState = InnerState.Check_DropUI;

		private int TickCounter;

		private int ItemID;

		private List<UUserWidget> TempWidgets;

		private TStrongObjectPtr<UClass> DropBP = new TStrongObjectPtr<UClass>();

		private TStrongObjectPtr<UClass> ConfirmBP = new TStrongObjectPtr<UClass>();

		public TestState_GetNewItem(UObject WorldContext, int ItemID)
		{
			base.WorldContext = WorldContext;
			this.ItemID = ItemID;
			DropBP.Set(BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Drop/BUI_DropSpecialV2.BUI_DropSpecialV2_C'", ELoadResourceType.SyncLoadAndCache));
			ConfirmBP.Set(BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Btn/BI_Drop_Continue.BI_Drop_Continue_C'", ELoadResourceType.SyncLoadAndCache));
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.Check_DropUI:
				Description = "等待掉落UI开启完成";
				if (TickCounter >= 20)
				{
					UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out TempWidgets, DropBP.Get(), TopLevelOnly: false);
					if (TempWidgets.Count != 1 || TempWidgets[0].GetVisibility() != ESlateVisibility.SelfHitTestInvisible)
					{
						Description = "未显示掉落的UI";
						return NodeState.Failed;
					}
					Description = "掉落的UI显示正常";
					TransferState(InnerState.Click_ConfirmUI);
				}
				break;
			case InnerState.Click_ConfirmUI:
			{
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets, ConfirmBP.Get(), TopLevelOnly: false);
				foreach (BUI_Button item in FoundWidgets)
				{
					UTextBlock uTextBlock = UGSE_UMGFuncLib.GetWidgetFromName(item, new FName("TxtName")) as UTextBlock;
					if (uTextBlock.GetText() == "确定" && uTextBlock.GetVisibility() == ESlateVisibility.SelfHitTestInvisible)
					{
						item.TriggerGSClicked();
						Description = "点击了确定按钮";
						TransferState(InnerState.Check_ConfirmResult);
						return NodeState.Running;
					}
				}
				Description = "找不到UI上的确定按钮!";
				return NodeState.Failed;
			}
			case InnerState.Check_ConfirmResult:
				Description = "等待法术掉落UI关闭完成";
				if (TickCounter >= 10)
				{
					return NodeState.Succeeded;
				}
				break;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			TickCounter++;
			return NodeState.Running;
		}
	}

	public class TestState_SetPlayerAttack : TestState_Node
	{
		private readonly int AttackNum;

		public TestState_SetPlayerAttack(UObject WorldContext, int AttackNum)
		{
			base.WorldContext = WorldContext;
			this.AttackNum = AttackNum;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			AutoTestHelperLib.SetPlayerAttack(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), AttackNum);
			Description = "设定主角攻击力为" + AttackNum;
			return NodeState.Succeeded;
		}
	}

	public class TestState_PlayEverySequence : TestState_Node
	{
		private enum InnerState
		{
			GetherAllSequence,
			SelectNextSequence,
			StartPlaySequence,
			WatchSequence
		}

		private InnerState CurrentState;

		private int TickCounter;

		private List<int> MapIDs;

		private List<int> SequenceIDs = new List<int>();

		private int SequenceIndex = -1;

		private int GetMapIDFromSequenceID(int SequenceID)
		{
			int num = SequenceID / 1000000;
			if (num >= 10 && num < 100)
			{
				return num;
			}
			return 0;
		}

		private bool IsInGameSequenceItem(FUStMovieSequenceDesc Desc)
		{
			if (Desc.SeqDesc.Length == 0)
			{
				return false;
			}
			if (GetMapIDFromSequenceID(Desc.ID) != 0)
			{
				return true;
			}
			return false;
		}

		public TestState_PlayEverySequence(UObject WorldContext, List<int> MapIDs)
		{
			base.WorldContext = WorldContext;
			this.MapIDs = MapIDs;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.GetherAllSequence:
				Description = "收集要播放的Sequence中";
				new List<int>();
				foreach (FUStMovieSequenceDesc value in BGW_GameDB.GetAllMovieSequenceDesc().Values)
				{
					if (IsInGameSequenceItem(value))
					{
						int mapIDFromSequenceID = GetMapIDFromSequenceID(BGW_GameDB.GetMovieSequenceDesc(value.ID).ID);
						if (GameDBRuntime.FastGetLevelDesc(mapIDFromSequenceID) != null && MapIDs.Contains(mapIDFromSequenceID))
						{
							SequenceIDs.Add(value.ID);
						}
					}
				}
				SequenceIDs.Sort();
				TransferState(InnerState.SelectNextSequence);
				break;
			case InnerState.SelectNextSequence:
				SequenceIndex++;
				if (SequenceIndex < SequenceIDs.Count)
				{
					Description = "开始播下一个片子";
					TransferState(InnerState.StartPlaySequence);
					break;
				}
				Description = "片子全都播完了";
				return NodeState.Succeeded;
			case InnerState.StartPlaySequence:
				Description = "开始播放Seq " + SequenceIDs[SequenceIndex];
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "b.teleportToViewSeq " + SequenceIDs[SequenceIndex], null);
				TransferState(InnerState.WatchSequence);
				break;
			case InnerState.WatchSequence:
				Description = "观看Seq中";
				StateStack.Push(new TestState_Invincible(WorldContext));
				StateStack.Push(new TestState_Wait(WorldContext, 10));
				StateStack.Push(new TestState_WatchSequence(WorldContext));
				StateStack.Push(new TestState_Invincible(WorldContext));
				TransferState(InnerState.SelectNextSequence);
				return NodeState.Pause;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
			TickCounter++;
			return NodeState.Running;
		}
	}

	public class TestState_WaitForPreloadAndShader : TestState_Node
	{
		public TestState_WaitForPreloadAndShader(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
			if (bGW_PreloadAssetMgr != null)
			{
				if (bGW_PreloadAssetMgr.PreloadCountLeft() == 0)
				{
					if (!UGSE_EngineFuncLib.QAIsCompiling())
					{
						Description = "预加载和编译都已完成";
						return NodeState.Succeeded;
					}
					Description = "编译Shader和Texture中，请稍等";
				}
				else
				{
					Description = "当前还需预加载数量：" + bGW_PreloadAssetMgr.PreloadCountLeft();
				}
			}
			else
			{
				Description = "PreloadMgr == null";
			}
			return NodeState.Running;
		}
	}

	public class TestState_AddDebugUI : TestState_Node
	{
		public TestState_AddDebugUI(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			Description = "因为Xuan的要求，暂不添加BP_UI_GMInfo_Enemy";
			return NodeState.Succeeded;
		}
	}

	public class TestState_BattleWithMulti : TestState_Node
	{
		private enum InnerState
		{
			FindEnemy_ByName,
			Select_Enemy
		}

		private int TickCounter;

		private InnerState CurrentState;

		private List<BUTamerActor> EnemyTamers = new List<BUTamerActor>();

		private readonly List<string> ActorNames;

		private readonly string ActorLevel;

		private readonly AutoBattleExitCondition BattleExitCondition;

		public TestState_BattleWithMulti(UObject WorldContext, string ActorLevel, AutoBattleExitCondition BattleExitCondition, params string[] ActorNames)
		{
			base.WorldContext = WorldContext;
			this.ActorNames = new List<string>(ActorNames);
			this.ActorLevel = ActorLevel;
			this.BattleExitCondition = BattleExitCondition;
			CurrentState = InnerState.FindEnemy_ByName;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.FindEnemy_ByName:
			{
				BUTamerActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>(WorldContext);
				foreach (BUTamerActor bUTamerActor in allActorsOfClass)
				{
					if (ActorNames.Contains(bUTamerActor.GetName()) && (ActorLevel == null || bUTamerActor.GetLevel().GetOutermost().GetName()
						.Contains(ActorLevel)))
					{
						EnemyTamers.Add(bUTamerActor);
						Description = $"找到了{bUTamerActor.GetName()}";
					}
				}
				if (ActorNames.Count != EnemyTamers.Count)
				{
					Description = "在TestState_BattleWithMulti中，有怪没找到，请检查策划种怪情况！";
					return NodeState.Failed;
				}
				Description = "所有怪都找到了";
				TransferState(InnerState.Select_Enemy);
				return NodeState.Running;
			}
			case InnerState.Select_Enemy:
				EnemyTamers.Reverse();
				foreach (BUTamerActor enemyTamer in EnemyTamers)
				{
					if (!(enemyTamer == null) && !(enemyTamer.GetMonster() == null) && !BGUFunctionLibraryCS.BGUHasUnitState(enemyTamer.GetMonster(), EBGUUnitState.Dead))
					{
						Description = "设定当前目标为" + enemyTamer.GetName();
						StateStack.Push(new TestState_AutoBattle(WorldContext, enemyTamer.GetMonster(), BattleExitCondition));
						return NodeState.Running;
					}
				}
				Description = "所有怪都杀了";
				return NodeState.Succeeded;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
		}
	}

	public class TestState_StartCapturingAdvancedInfo : TestState_Node
	{
		private string TargetFileName;

		private int TotalFrames;

		private bool CollectInsightData;

		public TestState_StartCapturingAdvancedInfo(UObject WorldContext, string TargetFileName, int TotalFrames = 0, bool CollectInsightData = false)
		{
			string text = DateTime.Now.ToString("yy_MM_dd_HH_mm");
			base.WorldContext = WorldContext;
			this.TargetFileName = TargetFileName + "-" + BGUFuncLibWXLogin.GetIpList(WorldContext) + "-" + text;
			this.TotalFrames = TotalFrames;
			this.CollectInsightData = CollectInsightData;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			string autoMoveCaptureMode = BIS_AutoTestManagerV2.Get(WorldContext).GetAtpConfigValues.AutoMoveCaptureMode;
			if (autoMoveCaptureMode.Equals("TextureInfoCapture", StringComparison.OrdinalIgnoreCase))
			{
				SpawnTextureInfoCapturer();
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "r.VT.GSCapture 1", null);
				UGSE_TextureFuncLib.StartCapturingStreamingTextureStats();
				Description = "开始抓取纹理mip数据";
				return NodeState.Succeeded;
			}
			if (autoMoveCaptureMode.Equals("StatInfoCapture", StringComparison.OrdinalIgnoreCase))
			{
				UGSE_ProfilerFuncLib.StartRecordingPerfChart(TargetFileName, TotalFrames, CollectInsightData);
				Description = "开始抓取性能数据, 目标路径: " + TargetFileName;
				return NodeState.Succeeded;
			}
			Description = "尝试开始抓取某种数据, 但 AutoMoveCaptureMode(" + autoMoveCaptureMode + ") 设置错误, 直接跳过";
			return NodeState.Succeeded;
		}

		private void SpawnTextureInfoCapturer()
		{
			APlayerController playerController = UGameplayStatics.GetPlayerController(WorldContext, 0);
			playerController.GetActorTransform();
			string path = "/Game/00Main/BPLibrary/BGW/BP_TextureMipInfoCapturer.BP_TextureMipInfoCapturer_C";
			UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>(path, ELoadResourceType.SyncLoadAndCache);
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, uClass);
			if (allActorsOfClass.Length != 0)
			{
				AActor[] array = allActorsOfClass;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SetActorTickEnabled(bEnabled: false);
				}
				allActorsOfClass[0].SetActorTickEnabled(bEnabled: true);
			}
			else
			{
				BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(playerController.World, uClass).SetActorTickEnabled(bEnabled: true);
			}
		}
	}

	public class TestState_StopCapturingAdvancedInfo : TestState_Node
	{
		public TestState_StopCapturingAdvancedInfo(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			string autoMoveCaptureMode = BIS_AutoTestManagerV2.Get(WorldContext).GetAtpConfigValues.AutoMoveCaptureMode;
			if (autoMoveCaptureMode.Equals("TextureInfoCapture", StringComparison.OrdinalIgnoreCase))
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "r.VT.Dump", null);
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "r.VT.GSCapture 0", null);
				UGSE_TextureFuncLib.EndCapturingStreamingTextureStats();
				DestroyTextureInfoCapturers();
				Description = "停止抓取纹理mip(包含 VT + streaming)数据";
				return NodeState.Succeeded;
			}
			if (autoMoveCaptureMode.Equals("StatInfoCapture", StringComparison.OrdinalIgnoreCase))
			{
				UGSE_ProfilerFuncLib.StopRecordingPerfChart();
				Description = "停止抓取性能数据";
				return NodeState.Succeeded;
			}
			Description = "尝试停止抓取某种数据, 但 AutoMoveCaptureMode(" + autoMoveCaptureMode + ") 设置错误, 直接跳过";
			return NodeState.Succeeded;
		}

		private void DestroyTextureInfoCapturers()
		{
			UGameplayStatics.GetPlayerController(WorldContext, 0).GetActorTransform();
			string path = "/Game/00Main/BPLibrary/BGW/BP_TextureMipInfoCapturer.BP_TextureMipInfoCapturer_C";
			UClass actorClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>(path, ELoadResourceType.SyncLoadAndCache);
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(WorldContext, actorClass);
			for (int i = 0; i < allActorsOfClass.Length; i++)
			{
				allActorsOfClass[i].SetActorTickEnabled(bEnabled: false);
				BGU_UnrealWorldUtil.DestroyActor(allActorsOfClass[i]);
			}
		}
	}

	public class TestState_JudgeMapID : TestState_Node
	{
		private readonly int MapID;

		private int TickCounter;

		public TestState_JudgeMapID(UObject WorldContext, int mapID)
		{
			base.WorldContext = WorldContext;
			MapID = mapID;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			int currentLevelID = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(WorldContext).CurrentLevelID;
			string text = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(WorldContext).CurrentLevelName.ToString();
			if (TickCounter > 60)
			{
				Description = "无法传入" + MapID;
				return NodeState.Failed;
			}
			if (currentLevelID == MapID)
			{
				Description = "已经传入" + text;
				return NodeState.Succeeded;
			}
			TickCounter++;
			Description = "等待传入" + MapID;
			return NodeState.Running;
		}
	}

	public class TestState_PressBtn : TestState_Node
	{
		private readonly string Text;

		public TestState_PressBtn(UObject WorldContext, string Text)
		{
			base.WorldContext = WorldContext;
			this.Text = Text;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			Description = "准备点击文字" + Text;
			if (!AutoTestHelperLib.FindText(WorldContext, Text, bNeedClick: true))
			{
				return NodeState.Failed;
			}
			return NodeState.Succeeded;
		}
	}

	public class TestState_GoBackToStartUp : TestState_Node
	{
		private enum InnerState
		{
			OpenBagAndExitGame,
			Finish
		}

		private InnerState CurrentState;

		private int TickCounter;

		public TestState_GoBackToStartUp(UObject WorldContext)
		{
			base.WorldContext = WorldContext;
		}

		private void TransferState(InnerState NextState)
		{
			CurrentState = NextState;
			TickCounter = 0;
		}

		public override NodeState OnTick(out string Description, ref Stack<TestState_Node> StateStack, float DeltaTime)
		{
			switch (CurrentState)
			{
			case InnerState.OpenBagAndExitGame:
				Description = "打开背包并准备退出";
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
				StateStack.Push(new TestState_JudgeMapID(WorldContext, 1));
				StateStack.Push(new TestState_PressBtn(WorldContext, "确定"));
				StateStack.Push(new TestState_Wait(WorldContext, 10));
				StateStack.Push(new TestState_PressBtn(WorldContext, "退出到标题界面"));
				StateStack.Push(new TestState_Wait(WorldContext, 10));
				StateStack.Push(new TestState_PressBtn(WorldContext, "退出游戏"));
				StateStack.Push(new TestState_Wait(WorldContext, 10));
				StateStack.Push(new TestState_PressBtn(WorldContext, "设置"));
				StateStack.Push(new TestState_Wait(WorldContext, 10));
				TransferState(InnerState.Finish);
				TickCounter++;
				return NodeState.Running;
			case InnerState.Finish:
				Description = "已经回到选关界面";
				return NodeState.Succeeded;
			default:
				Description = "进入了异常测试状态，测试脚本有逻辑问题!";
				return NodeState.Failed;
			}
		}
	}
}
