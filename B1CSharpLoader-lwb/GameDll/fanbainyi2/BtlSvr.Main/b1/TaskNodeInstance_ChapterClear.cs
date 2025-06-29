using System;
using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class TaskNodeInstance_ChapterClear : QuestNodeInstance
{
	private ACharacter _Player;

	private uint GravityHandleID;

	private AStaticMeshActor Plane;

	private readonly FVector ClearChapterPlayerLocOffset = new FVector(0.0, 0.0, 1000.0);

	private bool HasRegNextChapterTravelBegin;

	private TaskCustom_ChapterClear CustomData { get; set; }

	private ACharacter Player
	{
		get
		{
			if (_Player.IsNullOrDestroyed())
			{
				_Player = UBGUFunctionLibrary.GetPlayerCharacter(base.Owner);
			}
			return _Player;
		}
	}

	protected override void PostCreate()
	{
		CustomData = new TaskCustom_ChapterClear();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		PlayChapterMovie();
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		if (DebugConfig.OpenNewChapterPlayerSafeLocation && !Plane.IsNullOrDestroyed())
		{
			BGUFuncLibActorTransformCS.BGUSetActorLocation(Player, BGW_CharacterViewMgr.Get(Player).CharacterViewLoc + ClearChapterPlayerLocOffset, bSweep: false, bTeleport: false, out var _);
			Player.SetActorHiddenInGame(bNewHidden: true);
		}
	}

	private void PlayChapterMovie()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_UIChapterMovie(CustomData.ChapterId);
			bGW_EventCollection.Evt_NextChapterTravelBegin = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_NextChapterTravelBegin, new Del_Void_Int(OnChapterMovieFinish));
			HasRegNextChapterTravelBegin = true;
		}
		BUS_EventCollectionCS.Get(Player)?.Evt_BuffAdd.Invoke(212, Player, Player, -1f);
		if (DebugConfig.OpenNewChapterPlayerSafeLocation)
		{
			IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(Player);
			BUS_EventCollectionCS.Get(Player)?.Evt_SetFloatProperty.Invoke(EPropType.Movement_GravityScale, 0f);
			GravityHandleID = readOnlyData.GetLastHandleID();
			Player.SetActorHiddenInGame(bNewHidden: true);
			BGUFuncLibActorTransformCS.BGUSetActorLocation(Player, BGW_CharacterViewMgr.Get(Player).CharacterViewLoc + ClearChapterPlayerLocOffset, bSweep: false, bTeleport: false, out var _);
			FVector location = BGW_CharacterViewMgr.Get(Player).CharacterViewLoc + ClearChapterPlayerLocOffset + new FVector(0.0, 0.0, 0f - Player.CapsuleComponent.GetScaledCapsuleHalfHeight());
			FRotator rotation = new FRotator(0.0, 0.0, 0.0);
			Plane = Player.World.SpawnActor<AStaticMeshActor>(ref location, ref rotation);
			Plane.SetMobility(EComponentMobility.Movable);
			Plane.StaticMeshComponent.SetStaticMesh(UObject.LoadObject<UStaticMesh>(null, "/Engine/BasicShapes/Plane.Plane"));
			Plane.SetActorScale3D(new FVector(10.0, 10.0, 1.0));
			Plane.SetActorHiddenInGame(bNewHidden: true);
			BUS_EventCollectionCS.Get(Player)?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterChapterClearWorkFlow, -1f);
		}
	}

	private void OnChapterMovieFinish(int ChapterID)
	{
		if (ChapterID == CustomData.ChapterId)
		{
			TriggerFirstOutput(bFinish: true);
			if (HasRegNextChapterTravelBegin)
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
				bGW_EventCollection.Evt_NextChapterTravelBegin = (Del_Void_Int)Delegate.Remove(bGW_EventCollection.Evt_NextChapterTravelBegin, new Del_Void_Int(OnChapterMovieFinish));
				HasRegNextChapterTravelBegin = false;
			}
		}
	}

	public override void Shutdown()
	{
		if (HasRegNextChapterTravelBegin)
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection.Evt_NextChapterTravelBegin = (Del_Void_Int)Delegate.Remove(bGW_EventCollection.Evt_NextChapterTravelBegin, new Del_Void_Int(OnChapterMovieFinish));
			HasRegNextChapterTravelBegin = false;
		}
	}

	protected override void Finish()
	{
		BUS_EventCollectionCS.Get(Player)?.Evt_BuffRemove.Invoke(212, EBuffEffectTriggerType.None, 1);
		if (GravityHandleID != 0)
		{
			BUS_EventCollectionCS.Get(Player)?.Evt_ResetProperty.Invoke(GravityHandleID);
		}
		if (DebugConfig.OpenNewChapterPlayerSafeLocation)
		{
			if (!Plane.IsNullOrDestroyed())
			{
				Plane.DestroyActor();
			}
			BUS_EventCollectionCS.Get(Player)?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.ExitChapterClearWorkFlow, -1f);
		}
		base.Finish();
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_ShowBattleUIFinish = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_ShowBattleUIFinish, new Del_Void(OnUIManagerReady));
	}

	private void OnUIManagerReady()
	{
		PlayChapterMovie();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_ShowBattleUIFinish = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_ShowBattleUIFinish, new Del_Void(OnUIManagerReady));
	}
}
