using System;
using System.Collections.Generic;
using System.Linq;
using BtlShare;
using Google.Protobuf;
using GUR.Runtime;
using GurCalliopeFsm;
using UnrealEngine.Engine;

namespace b1;

public class FSMState_GI_Global_SubG_GI_Loading_TravelLevel : FSMState_GI_Global_SubG_GI_Loading_Base
{
	private static readonly Dictionary<EGI_Global, EGI_Global_SubG_GI_Loading_TravelLevel_Return> ConvertGlobalEventDictionary = new Dictionary<EGI_Global, EGI_Global_SubG_GI_Loading_TravelLevel_Return>
	{
		{
			EGI_Global.ClientDisconnect,
			EGI_Global_SubG_GI_Loading_TravelLevel_Return.ClientDisconnect
		},
		{
			EGI_Global.ReadArchiveFailed,
			EGI_Global_SubG_GI_Loading_TravelLevel_Return.ReadArchiveFailed
		}
	};

	[EditableFSMParam(ParamType = FSMParamType.Enum, DisplayName = "传送方式")]
	public EGlobalTravelLevelType TravelLevelType { get; set; }

	[EditableFSMParam(ParamType = FSMParamType.Enum, DisplayName = "目标关卡网络模式")]
	public ETargetLevelNetType TargetLevelNetType { get; set; }

	[FSMInputParam]
	public int ArchiveId { get; set; }

	[FSMInputParam]
	private GMTravelParams GMTravelParams { get; set; }

	[FSMInputParam]
	public int TargetId { get; set; }

	public override void Init(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
		GI_Global_SubG_GI_Loading_TravelLevel gI_Global_SubG_GI_Loading_TravelLevel = new GI_Global_SubG_GI_Loading_TravelLevel();
		gI_Global_SubG_GI_Loading_TravelLevel.MergeFrom(Node.NodeData);
		SubGraphResPath = gI_Global_SubG_GI_Loading_TravelLevel.SubGraphAsset;
		TravelLevelType = (EGlobalTravelLevelType)gI_Global_SubG_GI_Loading_TravelLevel.TravelLevelType;
		TargetLevelNetType = (ETargetLevelNetType)gI_Global_SubG_GI_Loading_TravelLevel.TargetLevelNetType;
		if (InputParams is FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel fSMInputData_GI_Global_SubG_GI_Loading_TravelLevel)
		{
			ArchiveId = fSMInputData_GI_Global_SubG_GI_Loading_TravelLevel.ArchiveId;
			GMTravelParams = fSMInputData_GI_Global_SubG_GI_Loading_TravelLevel.GMTravelParams;
			TargetId = fSMInputData_GI_Global_SubG_GI_Loading_TravelLevel.TargetId;
		}
	}

	public override void OnAbort()
	{
		base.OnAbort();
		BGW_EventCollection.Get(base.OwningInstance.OwnerUObj).Evt_BGW_AbortFSMInstance(base.SubGraphRuntimeInstance);
	}

	public void InitContext()
	{
		switch (TravelLevelType)
		{
		case EGlobalTravelLevelType.Generic:
		case EGlobalTravelLevelType.StartNewGame:
		case EGlobalTravelLevelType.Online:
			SubGraphContext.TargetLevelId = TargetId;
			break;
		case EGlobalTravelLevelType.StartNewGamePlus:
		case EGlobalTravelLevelType.ReadArchive:
			SubGraphContext.ArchiveId = ArchiveId;
			break;
		case EGlobalTravelLevelType.GMTravel:
			SubGraphContext.GMTravelParams = GMTravelParams;
			break;
		case EGlobalTravelLevelType.SeamlessStartNewGame:
			SubGraphContext.TargetLevelId = BGUFuncLibMap.GetPrologueLevelId(Context.OwnerUObj);
			break;
		case EGlobalTravelLevelType.EnterBossRush:
		case EGlobalTravelLevelType.LeaveBossRush:
			SubGraphContext.ArchiveId = BGW_GameArchiveMgr.Get(Context.OwnerUObj).GetLatestArchive().ArchiveId;
			break;
		}
	}

	protected override FSMContext_GI_Loading GenSubGraphContext()
	{
		return Context.TravelLevelContext ?? (Context.TravelLevelContext = new FSMContext_GI_Loading(Context.OwnerUObj as BGWGameInstanceCS));
	}

	public override void OnSubGraphEnter()
	{
		GSEUtil.Check(Context.TravelLevelContext.TravelLevelTemplate == null, $"FSMRuntimeInstance: {TravelLevelType}TravelLevel and {Context?.TravelLevelContext?.TravelLevelTemplate?.GetType().Name} are triggered at the same time");
		TravelLevelTemplateBase template = TravelLevelTemplateFactory.GetTemplate(TravelLevelType);
		if (GSEUtil.Ensure(template != null, $"TravelLevelTemplate is null with type: {TravelLevelType}"))
		{
			InitContext();
			template?.Init(Context.TravelLevelContext, this, TravelLevelType, TargetLevelNetType);
			Context.TravelLevelContext.TravelLevelTemplate = template;
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
			bGW_EventCollection.Evt_BGW_TriggerGlobalFSMEvent = (BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent)Delegate.Combine(bGW_EventCollection.Evt_BGW_TriggerGlobalFSMEvent, new BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent(OnTriggerGlobalEvent));
			Delegate[] invocationList = BGW_EventCollection.Get(Context.OwnerUObj).Evt_BGW_TriggerGlobalFSMEvent.GetInvocationList();
			BGW_EventCollection.Get(Context.OwnerUObj).Evt_BGW_TriggerGlobalFSMEvent = null;
			foreach (Delegate item in invocationList.Reverse())
			{
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(Context.OwnerUObj);
				bGW_EventCollection2.Evt_BGW_TriggerGlobalFSMEvent = (BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent)Delegate.Combine(bGW_EventCollection2.Evt_BGW_TriggerGlobalFSMEvent, item as BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent);
			}
		}
		else
		{
			AbortSubInstance();
		}
		AddOrRemoveInvincibleBuff(IsAdd: true);
	}

	private void AddOrRemoveInvincibleBuff(bool IsAdd)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Context.OwnerUObj);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
		if (!(controlledPawn == null) && !(bUS_GSEventCollection == null))
		{
			if (IsAdd)
			{
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(212, controlledPawn, controlledPawn, 0f, EBuffSourceType.GCFSMTravelLevel);
			}
			else
			{
				bUS_GSEventCollection.Evt_BuffRemove.Invoke(212, EBuffEffectTriggerType.None, 1);
			}
		}
	}

	public override void OnSubGraphFinish()
	{
		GSEUtil.Check(CheckTravelLevelValidWhenFinish());
		AddOrRemoveInvincibleBuff(IsAdd: false);
		SubGraphFinishImpl();
		base.OwningInstance.TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_TravelLevel_Return.Finish, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
		{
			GMTravelParams = GMTravelParams
		});
	}

	public override void OnSubGraphException(FSMException FSMException)
	{
		throw FSMException;
	}

	private void OnTriggerGlobalEvent(EGI_Global Event, object InputParams)
	{
		if (ConvertGlobalEventDictionary.TryGetValue(Event, out var value))
		{
			SubGraphFinishImpl();
			AbortSubInstance();
			base.OwningInstance.TriggerSubGraphEvent(value);
		}
	}

	private void SubGraphFinishImpl()
	{
		foreach (int lockArchiveHandle in Context.TravelLevelContext.TravelLevelTemplate.LockArchiveHandleList)
		{
			BGW_GameArchiveMgr.Get(Context.OwnerUObj).ReleaseSaveLock(lockArchiveHandle);
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Context.OwnerUObj);
		bGW_EventCollection.Evt_BGW_TriggerGlobalFSMEvent = (BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent)Delegate.Remove(bGW_EventCollection.Evt_BGW_TriggerGlobalFSMEvent, new BGW_EventCollection.Del_BGW_TriggerGlobalFSMEvent(OnTriggerGlobalEvent));
		Context.TravelLevelContext = null;
	}

	private bool CheckTravelLevelValidWhenFinish()
	{
		UWorld uWorld = (Context.OwnerUObj as BGWGameInstanceCS)?.GetWorldForCS();
		if (uWorld == null)
		{
			return false;
		}
		if (TargetLevelNetType == ETargetLevelNetType.Other)
		{
			return true;
		}
		bool num = UGSE_EngineFuncLib.IsStandAlone(uWorld);
		bool flag = UGSE_EngineFuncLib.IsListenServer(uWorld);
		bool flag2 = UGSE_EngineFuncLib.IsClient(uWorld);
		bool flag3 = BGUFuncLibMap.IsMainMenuLevelId(BGUFuncLibMap.GetCurLevelId(uWorld), uWorld);
		if (num)
		{
			if (flag3)
			{
				return TargetLevelNetType == ETargetLevelNetType.MainMenu;
			}
			return TargetLevelNetType == ETargetLevelNetType.StandAlone;
		}
		if (flag)
		{
			return TargetLevelNetType == ETargetLevelNetType.ListenServer;
		}
		if (flag2)
		{
			return TargetLevelNetType == ETargetLevelNetType.Client;
		}
		return false;
	}
}
