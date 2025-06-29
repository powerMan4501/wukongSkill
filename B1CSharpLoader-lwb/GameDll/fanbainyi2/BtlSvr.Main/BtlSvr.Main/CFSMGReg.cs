using b1;

namespace BtlSvr.Main;

public class CFSMGReg
{
	public static void Init(int EntityMgrIdx)
	{
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_WaitGameStart", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_WaitGameStart fSMState_GI_Global_WaitGameStart = new FSMState_GI_Global_WaitGameStart();
			fSMState_GI_Global_WaitGameStart.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_WaitGameStart;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_MainMenu", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_MainMenu fSMState_GI_Global_MainMenu = new FSMState_GI_Global_MainMenu();
			fSMState_GI_Global_MainMenu.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_MainMenu;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_InBattleWaitingStartNewGame", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_InBattleWaitingStartNewGame fSMState_GI_Global_InBattleWaitingStartNewGame = new FSMState_GI_Global_InBattleWaitingStartNewGame();
			fSMState_GI_Global_InBattleWaitingStartNewGame.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_InBattleWaitingStartNewGame;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_WXLogin", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_WXLogin fSMState_GI_Global_WXLogin = new FSMState_GI_Global_WXLogin();
			fSMState_GI_Global_WXLogin.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_WXLogin;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_WaittingSelectLevel820Demo", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_WaittingSelectLevel820Demo fSMState_GI_Global_WaittingSelectLevel820Demo = new FSMState_GI_Global_WaittingSelectLevel820Demo();
			fSMState_GI_Global_WaittingSelectLevel820Demo.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_WaittingSelectLevel820Demo;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_InBattleStandAlone", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_InBattleStandAlone fSMState_GI_Global_InBattleStandAlone = new FSMState_GI_Global_InBattleStandAlone();
			fSMState_GI_Global_InBattleStandAlone.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_InBattleStandAlone;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_InBattleParty", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_InBattleParty fSMState_GI_Global_InBattleParty = new FSMState_GI_Global_InBattleParty();
			fSMState_GI_Global_InBattleParty.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_InBattleParty;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_InBattleOnLineClient", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_InBattleOnLineClient fSMState_GI_Global_InBattleOnLineClient = new FSMState_GI_Global_InBattleOnLineClient();
			fSMState_GI_Global_InBattleOnLineClient.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_InBattleOnLineClient;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_InBattleOnLineLS", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_InBattleOnLineLS fSMState_GI_Global_InBattleOnLineLS = new FSMState_GI_Global_InBattleOnLineLS();
			fSMState_GI_Global_InBattleOnLineLS.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_InBattleOnLineLS;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_InBattleOnLineDS", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_InBattleOnLineDS fSMState_GI_Global_InBattleOnLineDS = new FSMState_GI_Global_InBattleOnLineDS();
			fSMState_GI_Global_InBattleOnLineDS.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_InBattleOnLineDS;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_OpenMainMenuLevel", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_OpenMainMenuLevel fSMState_GI_Global_OpenMainMenuLevel = new FSMState_GI_Global_OpenMainMenuLevel();
			fSMState_GI_Global_OpenMainMenuLevel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_OpenMainMenuLevel;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_StartUp", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_StartUp fSMState_GI_Global_SubG_GI_Loading_StartUp = new FSMState_GI_Global_SubG_GI_Loading_StartUp();
			fSMState_GI_Global_SubG_GI_Loading_StartUp.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_StartUp;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_StartNewGame", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_StartNewGame fSMState_GI_Global_SubG_GI_Loading_StartNewGame = new FSMState_GI_Global_SubG_GI_Loading_StartNewGame();
			fSMState_GI_Global_SubG_GI_Loading_StartNewGame.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_StartNewGame;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_Teleport", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_Teleport fSMState_GI_Global_SubG_GI_Loading_Teleport = new FSMState_GI_Global_SubG_GI_Loading_Teleport();
			fSMState_GI_Global_SubG_GI_Loading_Teleport.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_Teleport;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_GameLevelPass", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_GameLevelPass fSMState_GI_Global_SubG_GI_Loading_GameLevelPass = new FSMState_GI_Global_SubG_GI_Loading_GameLevelPass();
			fSMState_GI_Global_SubG_GI_Loading_GameLevelPass.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_GameLevelPass;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ToiletStandAlone", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_ToiletStandAlone fSMState_GI_Global_SubG_GI_Loading_ToiletStandAlone = new FSMState_GI_Global_SubG_GI_Loading_ToiletStandAlone();
			fSMState_GI_Global_SubG_GI_Loading_ToiletStandAlone.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_ToiletStandAlone;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ToiletListenServer", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_ToiletListenServer fSMState_GI_Global_SubG_GI_Loading_ToiletListenServer = new FSMState_GI_Global_SubG_GI_Loading_ToiletListenServer();
			fSMState_GI_Global_SubG_GI_Loading_ToiletListenServer.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_ToiletListenServer;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ToiletDedicateServer", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_ToiletDedicateServer fSMState_GI_Global_SubG_GI_Loading_ToiletDedicateServer = new FSMState_GI_Global_SubG_GI_Loading_ToiletDedicateServer();
			fSMState_GI_Global_SubG_GI_Loading_ToiletDedicateServer.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_ToiletDedicateServer;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ToiletClient", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_ToiletClient fSMState_GI_Global_SubG_GI_Loading_ToiletClient = new FSMState_GI_Global_SubG_GI_Loading_ToiletClient();
			fSMState_GI_Global_SubG_GI_Loading_ToiletClient.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_ToiletClient;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_UnKnowLevelTravel", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel fSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel = new FSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel();
			fSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_BackToMainMenu", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_BackToMainMenu fSMState_GI_Global_SubG_GI_Loading_BackToMainMenu = new FSMState_GI_Global_SubG_GI_Loading_BackToMainMenu();
			fSMState_GI_Global_SubG_GI_Loading_BackToMainMenu.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_BackToMainMenu;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_InitWXLogin", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_InitWXLogin fSMState_GI_Global_SubG_GI_Loading_InitWXLogin = new FSMState_GI_Global_SubG_GI_Loading_InitWXLogin();
			fSMState_GI_Global_SubG_GI_Loading_InitWXLogin.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_InitWXLogin;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PostWXLoginFinish", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_PostWXLoginFinish fSMState_GI_Global_SubG_GI_Loading_PostWXLoginFinish = new FSMState_GI_Global_SubG_GI_Loading_PostWXLoginFinish();
			fSMState_GI_Global_SubG_GI_Loading_PostWXLoginFinish.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_PostWXLoginFinish;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ReplayBattle", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_ReplayBattle fSMState_GI_Global_SubG_GI_Loading_ReplayBattle = new FSMState_GI_Global_SubG_GI_Loading_ReplayBattle();
			fSMState_GI_Global_SubG_GI_Loading_ReplayBattle.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_ReplayBattle;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_HandleDisConnect", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_HandleDisConnect fSMState_GI_Global_SubG_GI_Loading_HandleDisConnect = new FSMState_GI_Global_SubG_GI_Loading_HandleDisConnect();
			fSMState_GI_Global_SubG_GI_Loading_HandleDisConnect.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_HandleDisConnect;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_BackToStandAlone", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_BackToStandAlone fSMState_GI_Global_SubG_GI_Loading_BackToStandAlone = new FSMState_GI_Global_SubG_GI_Loading_BackToStandAlone();
			fSMState_GI_Global_SubG_GI_Loading_BackToStandAlone.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_BackToStandAlone;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_StartNewGamePlus", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_StartNewGamePlus fSMState_GI_Global_SubG_GI_Loading_StartNewGamePlus = new FSMState_GI_Global_SubG_GI_Loading_StartNewGamePlus();
			fSMState_GI_Global_SubG_GI_Loading_StartNewGamePlus.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_StartNewGamePlus;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish fSMState_GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish = new FSMState_GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish();
			fSMState_GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_SaveArchiveAndWaitFinish;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_820DemoStartUp", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_820DemoStartUp fSMState_GI_Global_SubG_GI_Loading_820DemoStartUp = new FSMState_GI_Global_SubG_GI_Loading_820DemoStartUp();
			fSMState_GI_Global_SubG_GI_Loading_820DemoStartUp.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_820DemoStartUp;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_820DemoReSetGameData", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_820DemoReSetGameData fSMState_GI_Global_SubG_GI_Loading_820DemoReSetGameData = new FSMState_GI_Global_SubG_GI_Loading_820DemoReSetGameData();
			fSMState_GI_Global_SubG_GI_Loading_820DemoReSetGameData.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_820DemoReSetGameData;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PreEnterMainMenu", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_PreEnterMainMenu fSMState_GI_Global_SubG_GI_Loading_PreEnterMainMenu = new FSMState_GI_Global_SubG_GI_Loading_PreEnterMainMenu();
			fSMState_GI_Global_SubG_GI_Loading_PreEnterMainMenu.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_PreEnterMainMenu;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelLevel", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_TravelLevel fSMState_GI_Global_SubG_GI_Loading_TravelLevel = new FSMState_GI_Global_SubG_GI_Loading_TravelLevel();
			fSMState_GI_Global_SubG_GI_Loading_TravelLevel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_TravelLevel;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO fSMState_GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO = new FSMState_GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO();
			fSMState_GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_SetConfigAndPrecompilePSO;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_TravelToNextChapter", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_TravelToNextChapter fSMState_GI_Global_SubG_GI_Loading_TravelToNextChapter = new FSMState_GI_Global_SubG_GI_Loading_TravelToNextChapter();
			fSMState_GI_Global_SubG_GI_Loading_TravelToNextChapter.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_TravelToNextChapter;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PreviewSequence", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_PreviewSequence fSMState_GI_Global_SubG_GI_Loading_PreviewSequence = new FSMState_GI_Global_SubG_GI_Loading_PreviewSequence();
			fSMState_GI_Global_SubG_GI_Loading_PreviewSequence.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_PreviewSequence;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_ServerLogin", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_ServerLogin fSMState_GI_Global_SubG_GI_Loading_ServerLogin = new FSMState_GI_Global_SubG_GI_Loading_ServerLogin();
			fSMState_GI_Global_SubG_GI_Loading_ServerLogin.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_ServerLogin;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PartyRoomServer", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_PartyRoomServer fSMState_GI_Global_SubG_GI_Loading_PartyRoomServer = new FSMState_GI_Global_SubG_GI_Loading_PartyRoomServer();
			fSMState_GI_Global_SubG_GI_Loading_PartyRoomServer.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_PartyRoomServer;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_PartyRoomClient", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_PartyRoomClient fSMState_GI_Global_SubG_GI_Loading_PartyRoomClient = new FSMState_GI_Global_SubG_GI_Loading_PartyRoomClient();
			fSMState_GI_Global_SubG_GI_Loading_PartyRoomClient.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_PartyRoomClient;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_AsClientInGame", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_AsClientInGame fSMState_GI_Global_AsClientInGame = new FSMState_GI_Global_AsClientInGame();
			fSMState_GI_Global_AsClientInGame.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_AsClientInGame;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_AsListenServerInGame", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_AsListenServerInGame fSMState_GI_Global_AsListenServerInGame = new FSMState_GI_Global_AsListenServerInGame();
			fSMState_GI_Global_AsListenServerInGame.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_AsListenServerInGame;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Global_WXLogin", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Global_WXLogin fSMState_GI_Global_SubG_GI_Global_WXLogin = new FSMState_GI_Global_SubG_GI_Global_WXLogin();
			fSMState_GI_Global_SubG_GI_Global_WXLogin.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Global_WXLogin;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Global_BenchMark", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Global_BenchMark fSMState_GI_Global_SubG_GI_Global_BenchMark = new FSMState_GI_Global_SubG_GI_Global_BenchMark();
			fSMState_GI_Global_SubG_GI_Global_BenchMark.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Global_BenchMark;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_InBenchMark", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_InBenchMark fSMState_GI_Global_InBenchMark = new FSMState_GI_Global_InBenchMark();
			fSMState_GI_Global_InBenchMark.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_InBenchMark;
		});
		FSMRuntimeInstance_GI_Global.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig", delegate(FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig fSMState_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig = new FSMState_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig();
			fSMState_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Global_SubG_GI_Loading_CheckGSSdkServerConfig;
		});
		FSMRuntimeInstance_GI_Global.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Global_IsIgnoreWXLogin", (FSMRuntimeInstance_GI_Global RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Global_IsIgnoreWXLogin(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_ECSWorldBeginPlay", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_ECSWorldBeginPlay fSMState_GI_Loading_ECSWorldBeginPlay = new FSMState_GI_Loading_ECSWorldBeginPlay();
			fSMState_GI_Loading_ECSWorldBeginPlay.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_ECSWorldBeginPlay;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_WaitTick", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_WaitTick fSMState_GI_Loading_WaitTick = new FSMState_GI_Loading_WaitTick();
			fSMState_GI_Loading_WaitTick.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_WaitTick;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_ECSWorldReset", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_ECSWorldReset fSMState_GI_Loading_ECSWorldReset = new FSMState_GI_Loading_ECSWorldReset();
			fSMState_GI_Loading_ECSWorldReset.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_ECSWorldReset;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_PauseGame", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_PauseGame fSMState_GI_Loading_PauseGame = new FSMState_GI_Loading_PauseGame();
			fSMState_GI_Loading_PauseGame.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_PauseGame;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_ResumeGame", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_ResumeGame fSMState_GI_Loading_ResumeGame = new FSMState_GI_Loading_ResumeGame();
			fSMState_GI_Loading_ResumeGame.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_ResumeGame;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_OpenLevelByName", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_OpenLevelByName fSMState_GI_Loading_OpenLevelByName = new FSMState_GI_Loading_OpenLevelByName();
			fSMState_GI_Loading_OpenLevelByName.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_OpenLevelByName;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_OpenLevelByIdInContext", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_OpenLevelByIdInContext fSMState_GI_Loading_OpenLevelByIdInContext = new FSMState_GI_Loading_OpenLevelByIdInContext();
			fSMState_GI_Loading_OpenLevelByIdInContext.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_OpenLevelByIdInContext;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_MarkCanFinishLoopMovie", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_MarkCanFinishLoopMovie fSMState_GI_Loading_MarkCanFinishLoopMovie = new FSMState_GI_Loading_MarkCanFinishLoopMovie();
			fSMState_GI_Loading_MarkCanFinishLoopMovie.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_MarkCanFinishLoopMovie;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_TeleportTemplateBegin", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_TeleportTemplateBegin fSMState_GI_Loading_TeleportTemplateBegin = new FSMState_GI_Loading_TeleportTemplateBegin();
			fSMState_GI_Loading_TeleportTemplateBegin.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_TeleportTemplateBegin;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_TeleportTemplateEnd", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_TeleportTemplateEnd fSMState_GI_Loading_TeleportTemplateEnd = new FSMState_GI_Loading_TeleportTemplateEnd();
			fSMState_GI_Loading_TeleportTemplateEnd.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_TeleportTemplateEnd;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_PlayerTeleportToTemplatetargetPos", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_PlayerTeleportToTemplatetargetPos fSMState_GI_Loading_PlayerTeleportToTemplatetargetPos = new FSMState_GI_Loading_PlayerTeleportToTemplatetargetPos();
			fSMState_GI_Loading_PlayerTeleportToTemplatetargetPos.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_PlayerTeleportToTemplatetargetPos;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_LoadingUIBeginFadeAway", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_LoadingUIBeginFadeAway fSMState_GI_Loading_LoadingUIBeginFadeAway = new FSMState_GI_Loading_LoadingUIBeginFadeAway();
			fSMState_GI_Loading_LoadingUIBeginFadeAway.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_LoadingUIBeginFadeAway;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_BattleLevelTravel", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_BattleLevelTravel fSMState_GI_Loading_SubG_GI_Loading_BattleLevelTravel = new FSMState_GI_Loading_SubG_GI_Loading_BattleLevelTravel();
			fSMState_GI_Loading_SubG_GI_Loading_BattleLevelTravel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_BattleLevelTravel;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_ClientEnvInit", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_ClientEnvInit fSMState_GI_Loading_SubG_GI_Loading_ClientEnvInit = new FSMState_GI_Loading_SubG_GI_Loading_ClientEnvInit();
			fSMState_GI_Loading_SubG_GI_Loading_ClientEnvInit.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_ClientEnvInit;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_HideLoadingUI", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_HideLoadingUI fSMState_GI_Loading_SubG_GI_Loading_HideLoadingUI = new FSMState_GI_Loading_SubG_GI_Loading_HideLoadingUI();
			fSMState_GI_Loading_SubG_GI_Loading_HideLoadingUI.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_HideLoadingUI;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_GSLogin", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_GSLogin fSMState_GI_Loading_SubG_GI_Loading_GSLogin = new FSMState_GI_Loading_SubG_GI_Loading_GSLogin();
			fSMState_GI_Loading_SubG_GI_Loading_GSLogin.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_GSLogin;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_ReStartGSLogin", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_ReStartGSLogin fSMState_GI_Loading_SubG_GI_Loading_ReStartGSLogin = new FSMState_GI_Loading_SubG_GI_Loading_ReStartGSLogin();
			fSMState_GI_Loading_SubG_GI_Loading_ReStartGSLogin.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_ReStartGSLogin;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish fSMState_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish = new FSMState_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish();
			fSMState_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_SaveArchiveAndWaitFinish;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_RequestTemplateTravelLevelBegin", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_RequestTemplateTravelLevelBegin fSMState_GI_Loading_RequestTemplateTravelLevelBegin = new FSMState_GI_Loading_RequestTemplateTravelLevelBegin();
			fSMState_GI_Loading_RequestTemplateTravelLevelBegin.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_RequestTemplateTravelLevelBegin;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_RequestTemplateTravelLevelEnd", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_RequestTemplateTravelLevelEnd fSMState_GI_Loading_RequestTemplateTravelLevelEnd = new FSMState_GI_Loading_RequestTemplateTravelLevelEnd();
			fSMState_GI_Loading_RequestTemplateTravelLevelEnd.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_RequestTemplateTravelLevelEnd;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_RequestTemplatePreLeaveLevel", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_RequestTemplatePreLeaveLevel fSMState_GI_Loading_RequestTemplatePreLeaveLevel = new FSMState_GI_Loading_RequestTemplatePreLeaveLevel();
			fSMState_GI_Loading_RequestTemplatePreLeaveLevel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_RequestTemplatePreLeaveLevel;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_PostLeaveLevel", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_PostLeaveLevel fSMState_GI_Loading_SubG_GI_Loading_PostLeaveLevel = new FSMState_GI_Loading_SubG_GI_Loading_PostLeaveLevel();
			fSMState_GI_Loading_SubG_GI_Loading_PostLeaveLevel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_PostLeaveLevel;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_RequestTemplateOpenLevel", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_RequestTemplateOpenLevel fSMState_GI_Loading_RequestTemplateOpenLevel = new FSMState_GI_Loading_RequestTemplateOpenLevel();
			fSMState_GI_Loading_RequestTemplateOpenLevel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_RequestTemplateOpenLevel;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_PreEnterLevel", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_PreEnterLevel fSMState_GI_Loading_SubG_GI_Loading_PreEnterLevel = new FSMState_GI_Loading_SubG_GI_Loading_PreEnterLevel();
			fSMState_GI_Loading_SubG_GI_Loading_PreEnterLevel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_PreEnterLevel;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_RequestTemplatePostEnterLevelFinish", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_RequestTemplatePostEnterLevelFinish fSMState_GI_Loading_RequestTemplatePostEnterLevelFinish = new FSMState_GI_Loading_RequestTemplatePostEnterLevelFinish();
			fSMState_GI_Loading_RequestTemplatePostEnterLevelFinish.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_RequestTemplatePostEnterLevelFinish;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_RequestTemplatePostGSLoginFinish", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_RequestTemplatePostGSLoginFinish fSMState_GI_Loading_RequestTemplatePostGSLoginFinish = new FSMState_GI_Loading_RequestTemplatePostGSLoginFinish();
			fSMState_GI_Loading_RequestTemplatePostGSLoginFinish.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_RequestTemplatePostGSLoginFinish;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_LockSaveArchiveByTravelLevel", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_LockSaveArchiveByTravelLevel fSMState_GI_Loading_LockSaveArchiveByTravelLevel = new FSMState_GI_Loading_LockSaveArchiveByTravelLevel();
			fSMState_GI_Loading_LockSaveArchiveByTravelLevel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_LockSaveArchiveByTravelLevel;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_ReleaseSaveArchiveByTravelLevel", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_ReleaseSaveArchiveByTravelLevel fSMState_GI_Loading_ReleaseSaveArchiveByTravelLevel = new FSMState_GI_Loading_ReleaseSaveArchiveByTravelLevel();
			fSMState_GI_Loading_ReleaseSaveArchiveByTravelLevel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_ReleaseSaveArchiveByTravelLevel;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive fSMState_GI_Loading_SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive = new FSMState_GI_Loading_SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive();
			fSMState_GI_Loading_SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_ResetGameInstanceDataAndSaveArchive;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_SubG_GI_Loading_HandleArchiveInTravelLevel", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_SubG_GI_Loading_HandleArchiveInTravelLevel fSMState_GI_Loading_SubG_GI_Loading_HandleArchiveInTravelLevel = new FSMState_GI_Loading_SubG_GI_Loading_HandleArchiveInTravelLevel();
			fSMState_GI_Loading_SubG_GI_Loading_HandleArchiveInTravelLevel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_SubG_GI_Loading_HandleArchiveInTravelLevel;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_OpenLoadingScreen", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_OpenLoadingScreen fSMState_GI_Loading_OpenLoadingScreen = new FSMState_GI_Loading_OpenLoadingScreen();
			fSMState_GI_Loading_OpenLoadingScreen.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_OpenLoadingScreen;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_PrepareFadeAway", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_PrepareFadeAway fSMState_GI_Loading_PrepareFadeAway = new FSMState_GI_Loading_PrepareFadeAway();
			fSMState_GI_Loading_PrepareFadeAway.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_PrepareFadeAway;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_RequestFadeAway", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_RequestFadeAway fSMState_GI_Loading_RequestFadeAway = new FSMState_GI_Loading_RequestFadeAway();
			fSMState_GI_Loading_RequestFadeAway.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_RequestFadeAway;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_CloseLoadingScreen", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_CloseLoadingScreen fSMState_GI_Loading_CloseLoadingScreen = new FSMState_GI_Loading_CloseLoadingScreen();
			fSMState_GI_Loading_CloseLoadingScreen.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_CloseLoadingScreen;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_EngineHandleDisconnect", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_EngineHandleDisconnect fSMState_GI_Loading_EngineHandleDisconnect = new FSMState_GI_Loading_EngineHandleDisconnect();
			fSMState_GI_Loading_EngineHandleDisconnect.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_EngineHandleDisconnect;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_NextChapterReqAndArchive", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_NextChapterReqAndArchive fSMState_GI_Loading_NextChapterReqAndArchive = new FSMState_GI_Loading_NextChapterReqAndArchive();
			fSMState_GI_Loading_NextChapterReqAndArchive.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_NextChapterReqAndArchive;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_GMRecordRebirthPos", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_GMRecordRebirthPos fSMState_GI_Loading_GMRecordRebirthPos = new FSMState_GI_Loading_GMRecordRebirthPos();
			fSMState_GI_Loading_GMRecordRebirthPos.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_GMRecordRebirthPos;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_NetConectionFailurePreprocess", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_NetConectionFailurePreprocess fSMState_GI_Loading_NetConectionFailurePreprocess = new FSMState_GI_Loading_NetConectionFailurePreprocess();
			fSMState_GI_Loading_NetConectionFailurePreprocess.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_NetConectionFailurePreprocess;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_InitCollectionSpawnActorState", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_InitCollectionSpawnActorState fSMState_GI_Loading_InitCollectionSpawnActorState = new FSMState_GI_Loading_InitCollectionSpawnActorState();
			fSMState_GI_Loading_InitCollectionSpawnActorState.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_InitCollectionSpawnActorState;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_PostSeamlessLevelTravel", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_PostSeamlessLevelTravel fSMState_GI_Loading_PostSeamlessLevelTravel = new FSMState_GI_Loading_PostSeamlessLevelTravel();
			fSMState_GI_Loading_PostSeamlessLevelTravel.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_PostSeamlessLevelTravel;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_QuitGame", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_QuitGame fSMState_GI_Loading_QuitGame = new FSMState_GI_Loading_QuitGame();
			fSMState_GI_Loading_QuitGame.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_QuitGame;
		});
		FSMRuntimeInstance_GI_Loading.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_GI_Loading_WaitUntilGameStateInit", delegate(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_GI_Loading_WaitUntilGameStateInit fSMState_GI_Loading_WaitUntilGameStateInit = new FSMState_GI_Loading_WaitUntilGameStateInit();
			fSMState_GI_Loading_WaitUntilGameStateInit.Init(RuntimeInstance, Node, InputParams);
			return fSMState_GI_Loading_WaitUntilGameStateInit;
		});
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_HasArchive", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_HasArchive(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInStartUpLevel", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInStartUpLevel(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInBattleLevel", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInBattleLevel(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInDefaultBattleLevel", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInDefaultBattleLevel(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_HasArchiveIdInContext", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_HasArchiveIdInContext(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInServer", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInServer(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInDedicateServer", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInDedicateServer(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInListenServer", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInListenServer(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsStandAlone", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsStandAlone(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInNetClient", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInNetClient(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInPIEClient", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInPIEClient(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_TravelUrlIsListen", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_TravelUrlIsListen(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_TravelUrlHasHost", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_TravelUrlHasHost(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsEnableLoadingUserInput", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsEnableLoadingUserInput(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInToilet", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInToilet(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInContextLevel", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInContextLevel(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_TeleportNeedLevelTravel", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_TeleportNeedLevelTravel(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_SwitchTeleportType", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_SwitchTeleportType(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsReplayWorldLoadFinish", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsReplayWorldLoadFinish(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_PlayerGameStateCheck", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_PlayerGameStateCheck(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_NeedSwitchPlayerGameMode", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_NeedSwitchPlayerGameMode(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_MonsterTeleportArchiveExist", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_MonsterTeleportArchiveExist(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_BattleLevelTravelNeedWaitCameraBlend", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_BattleLevelTravelNeedWaitCameraBlend(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsInMap", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsInMap(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_OpenSeamlessLevelTravel", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_OpenSeamlessLevelTravel(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsNeedResetGameInstanceData", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsNeedResetGameInstanceData(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_CheckGlobalTravelMode", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_CheckGlobalTravelMode(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_CheckGMFlagsSupportUnknownTravel", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_CheckGMFlagsSupportUnknownTravel(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsDriverVersionMismatch", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsDriverVersionMismatch(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsPlayGoDownloadIncomplete", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsPlayGoDownloadIncomplete(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_GI_Loading.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_GI_Loading_IsNeedPreStartGameProcess", (FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_GI_Loading_IsNeedPreStartGameProcess(RuntimeInstance.Context, Node, InputParams));
		FSMRuntimeInstance_PS_Transaction.RegisterStates(EntityMgrIdx, "FSM.BED_FSMNode_PS_Transaction_TransactionTask", delegate(FSMRuntimeInstance_PS_Transaction RuntimeInstance, FCalliopeNode Node, object InputParams)
		{
			FSMState_PS_Transaction_TransactionTask fSMState_PS_Transaction_TransactionTask = new FSMState_PS_Transaction_TransactionTask();
			fSMState_PS_Transaction_TransactionTask.Init(RuntimeInstance, Node, InputParams);
			return fSMState_PS_Transaction_TransactionTask;
		});
		FSMRuntimeInstance_PS_Transaction.RegisterConditions(EntityMgrIdx, "FSM.BED_FSMNode_Condition_PS_Transaction_TaskCondition", (FSMRuntimeInstance_PS_Transaction RuntimeInstance, FCalliopeNode Node, object InputParams) => new FSMCondition_PS_Transaction_TaskCondition(RuntimeInstance.Context, Node, InputParams));
	}
}
