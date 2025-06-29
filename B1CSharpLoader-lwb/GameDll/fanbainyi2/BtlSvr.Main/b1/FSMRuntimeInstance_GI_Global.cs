using System.Collections.Generic;
using b1.Plugins.Calliope;

namespace b1;

public class FSMRuntimeInstance_GI_Global : FSMRuntimeInstanceBase
{
	public delegate FSMState_GI_GlobalBase Del_StateCreate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams);

	public delegate FSMConditionBase Del_ConditionCreate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams);

	private static Dictionary<string, Del_StateCreate> sStateCreateFuncs = new Dictionary<string, Del_StateCreate>();

	private static Dictionary<string, Del_ConditionCreate> sConditionCreateFuncs = new Dictionary<string, Del_ConditionCreate>();

	private static Dictionary<string, SGI_Global> sEStateNameMap = new Dictionary<string, SGI_Global>
	{
		{
			"FSM.BED_FSMNode_GI_Global_WaitGameStart",
			SGI_Global.WaitGameStart
		},
		{
			"FSM.BED_FSMNode_GI_Global_MainMenu",
			SGI_Global.MainMenu
		},
		{
			"FSM.BED_FSMNode_GI_Global_InBattleWaitingStartNewGame",
			SGI_Global.InBattleWaitingStartNewGame
		},
		{
			"FSM.BED_FSMNode_GI_Global_WXLogin",
			SGI_Global.WXLogin
		},
		{
			"FSM.BED_FSMNode_GI_Global_WaittingSelectLevel820Demo",
			SGI_Global.WaittingSelectLevel820Demo
		},
		{
			"FSM.BED_FSMNode_GI_Global_InBattleStandAlone",
			SGI_Global.InBattleStandAlone
		},
		{
			"FSM.BED_FSMNode_GI_Global_InBattleParty",
			SGI_Global.InBattleParty
		},
		{
			"FSM.BED_FSMNode_GI_Global_InBattleOnLineClient",
			SGI_Global.InBattleOnLineClient
		},
		{
			"FSM.BED_FSMNode_GI_Global_InBattleOnLineLS",
			SGI_Global.InBattleOnLineLS
		},
		{
			"FSM.BED_FSMNode_GI_Global_InBattleOnLineDS",
			SGI_Global.InBattleOnLineDS
		},
		{
			"FSM.BED_FSMNode_GI_Global_OpenMainMenuLevel",
			SGI_Global.OpenMainMenuLevel
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_StartUp",
			SGI_Global.SubG_GI_Loading_StartUp
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_StartNewGame",
			SGI_Global.SubG_GI_Loading_StartNewGame
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_Teleport",
			SGI_Global.SubG_GI_Loading_Teleport
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_GameLevelPass",
			SGI_Global.SubG_GI_Loading_GameLevelPass
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ToiletStandAlone",
			SGI_Global.SubG_GI_Loading_ToiletStandAlone
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ToiletListenServer",
			SGI_Global.SubG_GI_Loading_ToiletListenServer
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ToiletDedicateServer",
			SGI_Global.SubG_GI_Loading_ToiletDedicateServer
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ToiletClient",
			SGI_Global.SubG_GI_Loading_ToiletClient
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_UnKnowLevelTravel",
			SGI_Global.SubG_GI_Loading_UnKnowLevelTravel
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_BackToMainMenu",
			SGI_Global.SubG_GI_Loading_BackToMainMenu
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_InitWXLogin",
			SGI_Global.SubG_GI_Loading_InitWXLogin
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PostWXLoginFinish",
			SGI_Global.SubG_GI_Loading_PostWXLoginFinish
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ReplayBattle",
			SGI_Global.SubG_GI_Loading_ReplayBattle
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_HandleDisConnect",
			SGI_Global.SubG_GI_Loading_HandleDisConnect
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_BackToStandAlone",
			SGI_Global.SubG_GI_Loading_BackToStandAlone
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_StartNewGamePlus",
			SGI_Global.SubG_GI_Loading_StartNewGamePlus
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish",
			SGI_Global.SubG_GI_Loading_SaveArchiveAndWaitFinish
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_820DemoStartUp",
			SGI_Global.SubG_GI_Loading_820DemoStartUp
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_820DemoReSetGameData",
			SGI_Global.SubG_GI_Loading_820DemoReSetGameData
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PreEnterMainMenu",
			SGI_Global.SubG_GI_Loading_PreEnterMainMenu
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel",
			SGI_Global.SubG_GI_Loading_TravelLevel
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO",
			SGI_Global.SubG_GI_Loading_SetConfigAndPrecompilePSO
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelToNextChapter",
			SGI_Global.SubG_GI_Loading_TravelToNextChapter
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PreviewSequence",
			SGI_Global.SubG_GI_Loading_PreviewSequence
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ServerLogin",
			SGI_Global.SubG_GI_Loading_ServerLogin
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PartyRoomServer",
			SGI_Global.SubG_GI_Loading_PartyRoomServer
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PartyRoomClient",
			SGI_Global.SubG_GI_Loading_PartyRoomClient
		},
		{
			"FSM.BED_FSMNode_GI_Global_AsClientInGame",
			SGI_Global.AsClientInGame
		},
		{
			"FSM.BED_FSMNode_GI_Global_AsListenServerInGame",
			SGI_Global.AsListenServerInGame
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Global_WXLogin",
			SGI_Global.SubG_GI_Global_WXLogin
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Global_BenchMark",
			SGI_Global.SubG_GI_Global_BenchMark
		},
		{
			"FSM.BED_FSMNode_GI_Global_InBenchMark",
			SGI_Global.InBenchMark
		},
		{
			"FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig",
			SGI_Global.SubG_GI_Loading_CheckGSSdkServerConfig
		}
	};

	public FSMState_GI_GlobalBase ActiveState { get; private set; }

	public SGI_Global ActiveEState => sEStateNameMap[ActiveNode.NodeClass];

	public FSMContext_GI_Global Context { get; private set; }

	public static void RegisterStates(int EntityMgrIdx, string NodeClassName, Del_StateCreate CreateFunc)
	{
		sStateCreateFuncs[NodeClassName] = CreateFunc;
	}

	public static void RegisterConditions(int EntityMgrIdx, string NodeClassName, Del_ConditionCreate CreateFunc)
	{
		sConditionCreateFuncs[NodeClassName] = CreateFunc;
	}

	public FSMRuntimeInstance_GI_Global(FCalliopeGraph CalliopeGraph, FSMContext_GI_Global InContext, UCalliopeAsset CalliopeAsset)
		: base(CalliopeGraph, InContext, CalliopeAsset)
	{
		Context = InContext;
	}

	public override void Start(object InputParams, FSMContextBase Context)
	{
		base.Start(InputParams, Context);
		FreshActiveState(InputParams, FromAnyState: false);
	}

	public void ForceShutDown()
	{
		ActiveState = null;
		Finish();
	}

	protected void FreshActiveState(object InputParams, bool FromAnyState)
	{
		try
		{
			ActiveState?.OnExit();
			if (FromAnyState)
			{
				ActiveState?.OnAbort();
			}
			if (ActiveNode.NodeClass == "FSM.BED_FSMNode_End")
			{
				ActiveState = null;
				Finish();
			}
			else if (ActiveNode.NodeClass.StartsWith("FSM.BED_FSMNode_Condition_"))
			{
				FSMConditionBase fSMConditionBase = sConditionCreateFuncs[ActiveNode.NodeClass](this, ActiveNode, InputParams);
				if (TriggerEventByString(fSMConditionBase.GetResult(), Context, out var FromAnyState2))
				{
					FreshActiveState(fSMConditionBase.GetNextNodeInputParam(), FromAnyState2);
				}
			}
			else
			{
				ActiveState = sStateCreateFuncs[ActiveNode.NodeClass](this, ActiveNode, InputParams);
				ActiveState?.OnEnter();
			}
		}
		catch (FSMException exception)
		{
			OnExceptionInvoke(exception);
		}
	}

	public override int OnTick(float Delta)
	{
		try
		{
			return ActiveState.OnTick(Delta);
		}
		catch (FSMException exception)
		{
			OnExceptionInvoke(exception);
		}
		return 0;
	}

	public void TriggerEvent(EGI_Global Event, object InputParams = null)
	{
		TriggerEvent(Event.ToString(), InputParams);
	}

	public void TriggerEvent(string EventName, object InputParams = null)
	{
		if (TriggerEventByString(EventName, Context, out var FromAnyState))
		{
			FreshActiveState(InputParams, FromAnyState);
		}
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_StartUp_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_StartNewGame_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_Teleport_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_GameLevelPass_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_ToiletStandAlone_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_ToiletListenServer_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_ToiletDedicateServer_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_ToiletClient_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_UnKnowLevelTravel_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_BackToMainMenu_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_InitWXLogin_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_PostWXLoginFinish_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_ReplayBattle_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_HandleDisConnect_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_BackToStandAlone_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_StartNewGamePlus_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_820DemoStartUp_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_820DemoReSetGameData_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_PreEnterMainMenu_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_TravelLevel_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_TravelToNextChapter_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_PreviewSequence_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_ServerLogin_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_PartyRoomServer_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_PartyRoomClient_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Global_WXLogin_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Global_BenchMark_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(EGI_Global_SubG_GI_Loading_CheckGSSdkServerConfig_Return Event, object InputParams = null)
	{
		TriggerSubGraphEvent(Event.ToString(), InputParams);
	}

	public void TriggerSubGraphEvent(string EventName, object InputParams = null)
	{
		if (TriggerEventByString(EventName, Context, out var FromAnyState))
		{
			FreshActiveState(InputParams, FromAnyState);
		}
	}
}
