using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using AOT;
using ArchiveB1;
using b1.AutoQA;
using b1.BGW;
using b1.EventDelDefine;
using b1.Localization;
using b1.Plugins.AkAudio;
using b1.Plugins.AsyncLoadingScreen;
using b1.Profile;
using BtlB1;
using BtlShare;
using Diana.Common;
using GSDispLib;
using GSE.GSSdk;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWConsoleCommands")]
public class BGWConsoleCommands : GameInstanceSystemBaseUObj
{
	private bool ResisterAllCMDFinish;

	private static WeakReference<BGWConsoleCommands> LastInst;

	private static int PlayerGMLevelFlags;

	private bool bDelayCheckSetServerConfigGMLevelInited;

	private static Del_ActivateTalent Evt_ActivateTalent;

	private static FTimerHandle ArrowTick;

	private static bool GenerateArrow_IsValid;

	private static IntPtr GenerateArrow_FunctionAddress;

	private static int GenerateArrow_ParamsSize;

	public override bool bTickEnabled => true;

	public static bool NoAnyGM => PlayerGMLevelFlags <= 0;

	public static bool IsPlayerGMInputEnabled
	{
		get
		{
			if (PlayerGMLevelFlags > 0)
			{
				return true;
			}
			IConsoleVariable consoleVariable = IConsoleManager.Get()?.FindConsoleVariable(DebugConfig.EnableAllGMCMDAndDebug);
			if (consoleVariable != null && consoleVariable.GetInt() == 1)
			{
				return true;
			}
			return false;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DelayCheckServerConfigEnableGMRegisteration();
		CheckRegisterAllCMD();
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		LastInst = null;
	}

	private static UObject GetThis()
	{
		if (ABGPPlayerController.GetCachedConsoleWorldContext() != null)
		{
			return ABGPPlayerController.GetCachedConsoleWorldContext();
		}
		if (LastInst.TryGetTarget(out var target))
		{
			return target;
		}
		return null;
	}

	private static string[] GetArgs(IntPtr argsPtr)
	{
		return IConsoleManager.GetArgsHelper(argsPtr);
	}

	private static UObject GetWorld(IntPtr worldPtr)
	{
		return IConsoleManager.GetWorldHelper(worldPtr);
	}

	private void RegisterConsoleCommand(string name, string help, FConsoleCommandDelegate command)
	{
		try
		{
			IConsoleManager.Get().RegisterConsoleCommand(name, help, command);
			GMInfo.RegisterGMInfo(name, help);
		}
		catch
		{
			BGW_LogUtil.LogError("failed to register console command: " + name);
		}
	}

	private void RegisterConsoleCommandWithArgs(string name, string help, FConsoleCommandWithArgsDelegate command)
	{
		try
		{
			IConsoleManager.Get().RegisterConsoleCommandWithArgs(name, help, command);
			GMInfo.RegisterGMInfo(name, help);
		}
		catch
		{
			BGW_LogUtil.LogError("failed to register console command: " + name);
		}
	}

	private void RegisterConsoleCommandWithWorld(string name, string help, FConsoleCommandWithWorldDelegate command)
	{
		try
		{
			IConsoleManager.Get().RegisterConsoleCommandWithWorld(name, help, command);
			GMInfo.RegisterGMInfo(name, help);
		}
		catch
		{
			BGW_LogUtil.LogError("failed to register console command: " + name);
		}
	}

	private void RegisterConsoleCommandWithOutputDevice(string name, string help, FConsoleCommandWithOutputDeviceDelegate command)
	{
		try
		{
			IConsoleManager.Get().RegisterConsoleCommandWithOutputDevice(name, help, command);
			GMInfo.RegisterGMInfo(name, help);
		}
		catch
		{
			BGW_LogUtil.LogError("failed to register console command: " + name);
		}
	}

	private void RegisterConsoleCommandWithWorldAndArgs(string name, string help, FConsoleCommandWithWorldAndArgsDelegate command)
	{
		try
		{
			IConsoleManager.Get().RegisterConsoleCommandWithWorldAndArgs(name, help, command);
			GMInfo.RegisterGMInfo(name, help);
		}
		catch
		{
			BGW_LogUtil.LogError("failed to register console command: " + name);
		}
	}

	private bool IsConsolePlatform()
	{
		if (FPlatformProperties.GetPlatform() != EPlatform.PS5)
		{
			return FPlatformProperties.GetPlatform() == EPlatform.XSX;
		}
		return true;
	}

	public static bool HasGMFlag(int Flag)
	{
		if (PlayerGMLevelFlags <= 0)
		{
			return false;
		}
		if (!IsPlayerGMInputEnabled)
		{
			return false;
		}
		if (PlayerGMLevelFlags == int.MaxValue)
		{
			return true;
		}
		return (PlayerGMLevelFlags & Flag) == Flag;
	}

	public static void EnablePlayerGMInput()
	{
		USystemLibrary.ExecuteConsoleCommand(GetThis(), DebugConfig.EnableAllGMCMDAndDebug + " 1", null);
	}

	public void SetGMFlag(int Level, bool bInitEnableInput)
	{
		if (Level < 0)
		{
			BGW_LogUtil.LogError($"gm error set error level :{Level}");
			return;
		}
		if (PlayerGMLevelFlags < 0 && Level > 0)
		{
			IConsoleManager.Get().RegisterConsoleVariable(DebugConfig.EnableAllGMCMDAndDebug, bInitEnableInput ? 1 : 0, "0: disable 1：enable");
		}
		PlayerGMLevelFlags = Level;
		bDelayCheckSetServerConfigGMLevelInited = true;
	}

	public void DelayCheckServerConfigEnableGMRegisteration()
	{
		if (bDelayCheckSetServerConfigGMLevelInited)
		{
			return;
		}
		if (DebugConfig.ForceEnableDebugGMFlags > 0 && !B1Global.GIsGameReleasedReally_Just4DevSimulation)
		{
			SetGMFlag(DebugConfig.ForceEnableDebugGMFlags, bInitEnableInput: true);
			return;
		}
		BGW_GSSdkMgr bGW_GSSdkMgr = BGW_GSSdkMgr.Get(this);
		if (bGW_GSSdkMgr.IsServerJsonConfigLoaded && bGW_GSSdkMgr.IsGSSdkUserJsonConfigLoaded)
		{
			int userGMIntFlags = bGW_GSSdkMgr.GetUserGMIntFlags();
			SetGMFlag(userGMIntFlags, bInitEnableInput: false);
		}
	}

	public override void OnInit()
	{
		LastInst = new WeakReference<BGWConsoleCommands>(this);
		UGSE_EngineFuncLib.DisableDebugExecBindings(GetThis(), IsDisable: true);
		USystemLibrary.ExecuteConsoleCommand(this, "DisableAllScreenMessages", null);
		IConsoleManager.Get().RegisterConsoleVariable("blog.EnableDeathDispInfoLog", 0, "Enable: 1; Disable: 0");
		IConsoleManager.Get().RegisterConsoleVariable("b.PSO.DisablePausePrecompileWhenWXLogin", 0, "默认0，登录界面暂停pso编译");
		IConsoleManager.Get().RegisterConsoleVariable("b.PSO.EnableAdjustPSOPrecompileBatch", 0, "0: 关闭 1：开启");
		IConsoleManager.Get().RegisterConsoleVariable("b.PSO.PrecompileBatchSize", 1, "");
		IConsoleManager.Get().RegisterConsoleVariable("b.PSO.PrecompileBatchTime", 0f, "");
		IConsoleManager.Get().RegisterConsoleVariable("b.PSO.WaitPSOPrecompileFinishWhenLoadMap", 1, "默认1，阻塞进入游戏场景");
		IConsoleManager.Get().RegisterConsoleVariable("b.PSO.ForceDisablePSOUsageMask", 0, "默认0，使用PSO分批加载");
		InitDefaultGM();
		int valueInGameThread = GSGameplayCVar.CVar_ForceHidePlayerHeadEquip.GetValueInGameThread();
		IConsoleVariable consoleVariable = IConsoleManager.Get().RegisterConsoleVariable("b.ForceHidePlayerHeadEquip", valueInGameThread, "强制HidePlayerHeadEquip， 0：不强制Hide，1：强制Hide");
		consoleVariable.SetOnChangedCallback(RefreshModularMesh);
		GSGameplayCVar.CVar_ForceHidePlayerHeadEquip = new GsCvarData(consoleVariable);
		if (DebugConfig.Debug820Demo || DebugConfig.Demo820OverSeaVersion)
		{
			DebugConfig.EnableAllGMCMDAndDebug = "b.820ControlGM";
			IConsoleManager.Get().RegisterConsoleVariable(DebugConfig.EnableAllGMCMDAndDebug, 0, "0: disable 1：enable");
			bDelayCheckSetServerConfigGMLevelInited = true;
		}
	}

	private void CheckRegisterAllCMD()
	{
		if (IsPlayerGMInputEnabled && !ResisterAllCMDFinish)
		{
			ResisterAllCMDFinish = true;
			InitCheatGM();
			InitDebugGM();
			InitUEDebugGM();
		}
	}

	private void InitDefaultGM()
	{
		GMInfo.SetCurRegistInfo(EGMType.GM_BGW, int.MaxValue);
		RegisterConsoleCommandWithArgs("b.TestLogin", "b.TestLogin UserName PassWd", TestLogin);
		GMInfo.ResetCurRegistInfo();
	}

	private void InitUEDebugGM()
	{
		if (HasGMFlag(8))
		{
			GMInfo.SetCurRegistInfo(EGMType.GM_BGW, 8);
			UGSE_EngineFuncLib.DisableDebugExecBindings(GetThis(), IsDisable: false);
			UGSE_EngineFuncLib.RegisteConsoleKey(new List<FName>
			{
				new FName("Tilde")
			});
			GMInfo.ResetCurRegistInfo();
		}
	}

	private void InitDebugGM()
	{
		if (HasGMFlag(4))
		{
			GMInfo.SetCurRegistInfo(EGMType.GM_BGW, 4);
			RegisterConsoleCommandWithWorldAndArgs("b.sys", "Quick B1Game System Command", OnGSSysGMV2);
			RegisterConsoleCommandWithArgs("b.teleport", "Teleport to xxx", OnGSTeleport);
			RegisterConsoleCommandWithArgs("b.derektest", "", OnDerekTest);
			RegisterConsoleCommandWithArgs("b.TestCSharpPerf", "", TestCSharpPerf);
			RegisterConsoleCommandWithArgs("b.hideactor", "HideActor name hide contains", OnGSHideActor);
			RegisterConsoleCommandWithArgs("b.switchlight", "SwitchLight name intensity", OnGSSwitchLight);
			RegisterConsoleCommandWithArgs("b.fly", "Enter or leave fly mode", OnFlyMode);
			RegisterConsoleCommandWithArgs("b.ActiveAllRebirthPoint", "ActiveAllRebirthPoint", OnActiveAllRebirthPoint);
			RegisterConsoleCommandWithArgs("b.TeleToRebirthPoint", "TeleToRebirthPoint", OnTeleToRebirthPoint);
			RegisterConsoleCommandWithArgs("b.teleportToPosition", "Teleport To Position (3 args)", OnTeleportToPosition);
			RegisterConsoleCommandWithArgs("b.SetControlRotation", "", OnSetControlRotation);
			RegisterConsoleCommandWithArgs("b.teleportToLevelPosition", "b.teleportToLevelPosition LevelId X Y Z Pitch Yaw Roll CameraPitch CameraYaw CameraRoll", OnTeleportToLevelPosition);
			RegisterConsoleCommandWithArgs("b.MonsterTeleport", "b.MonsterTeleport MonsterTeleportDescId", MonsterTeleport);
			RegisterConsoleCommandWithArgs("b.teleportToViewSeq", "b.teleportToViewSeq SeqId", OnTeleportToLevelPositionToPreviewSeq);
			RegisterConsoleCommandWithArgs("b.teleportToLevelPositionByName", "bn.teleportToLevelPositionByName LevelId X Y Z Pitch Yaw Roll", OnTeleportToLevelPositionByName);
			RegisterConsoleCommandWithArgs("b.DelAllArchived", "DelAllArchived", DelAllArchived);
			RegisterConsoleCommandWithArgs("b.IncreaseSpecialEnergy", "IncreaseSpecialEnergy", IncreaseSpecialEnergy);
			RegisterConsoleCommandWithArgs("b.ShowSpecialEnergy", "ShowSpecialEnergy", ShowSpecialEnergy);
			RegisterConsoleCommandWithArgs("b.ManualCSharpGC", "ManualCSharpGC", ManualCSharpGC);
			RegisterConsoleCommandWithArgs("b.CommandletTest", "CommandletTest", CommandletTest);
			RegisterConsoleCommandWithArgs("b.TeleportToTrace", "TeleportToTrace", TeleportToTrace);
			RegisterConsoleCommandWithArgs("b.UIPlayStory", "UIPlayStory", UIPlayStory);
			RegisterConsoleCommandWithArgs("b.GameLevelPass", "GameLevelPass", GameLevelPass);
			RegisterConsoleCommandWithArgs("b.EnterNextGame", "EnterNextGame", EnterNextGame);
			RegisterConsoleCommandWithArgs("b.SwitchChan", "SwitchChan", SwitchChan);
			RegisterConsoleCommandWithArgs("b.DreamTeleport", "DreamTeleport", DreamTeleport);
			RegisterConsoleCommandWithArgs("b.AddBuff", "AddBuff + BuffId", OnGSAddBuff);
			RegisterConsoleCommandWithArgs("b.RemoveBuff", "RemoveBuff + BuffId", OnGSRemoveBuff);
			RegisterConsoleCommandWithArgs("b.AddBuff2Monster", "AddBuff + UnitGuid + BuffId", OnGSAddBuff2Monster);
			RegisterConsoleCommandWithArgs("b.RemoveBuff2Monster", "RemoveBuff + UnitGuid + BuffId", OnGSRemoveBuff2Monster);
			RegisterConsoleCommandWithArgs("b.TryCastSkill", "TryCastSkill + UnitGuid + SkillId", OnGSTryCastSkill);
			RegisterConsoleCommandWithArgs("b.KillMonster", "KillMonster + UnitGuid", OnGSKillMonster);
			RegisterConsoleCommandWithArgs("b.SetSE", "b.SetSE + (float)atk", OnGSSetSpecialEnergy);
			RegisterConsoleCommandWithArgs("b.ChangeHP", "b.ChangeHP + (float)hp", OnGSChangeHP);
			RegisterConsoleCommandWithArgs("b.ChangeMP", "b.ChangeMP + (float)mp", OnGSChangeMP);
			RegisterConsoleCommandWithArgs("b.SetCamArmMode", "b.SetCamArmMode + (int)Mode", OnGSChangeCamArmMode);
			RegisterConsoleCommandWithArgs("b.SetLockCamArmMode", "b.SetLockCamArmMode + (int)Mode", OnGSChangeLockCamArmMode);
			RegisterConsoleCommandWithArgs("b.KillEnemyByResID", "KillEnemyByResID", OnKillEnemyByResId);
			RegisterConsoleCommandWithArgs("b.ReturnToPosition", "Return To Position", OnReturnToPosition);
			RegisterConsoleCommandWithArgs("b.ECS.ThreadTickCount", "If 0, disable Thread tick, other wise use n thread counts", OnECSThreadTickCount);
			RegisterConsoleCommandWithArgs("b.Profiler.Enable", "Enable/Disable UActorCompContainerCS Profiler, 0:Disable, 1:Enable, empty:Switch on/off", OnEnableProfiler);
			RegisterConsoleCommand("b.Profiler.EnableTick", "Enable/Disable UActorCompContainerCS Profiler", OnEnableTickProfiler);
			RegisterConsoleCommandWithArgs("b.Profiler.EnableBeginPlay", "Enable/Disable UActorCompContainerCS Profiler", OnEnableBeginPlayProfiler);
			RegisterConsoleCommandWithArgs("b.Profiler.SetTagFilterEnable", "Set Profile Tag Filter Enable", OnSetProfileTagFilterEnable);
			RegisterConsoleCommandWithArgs("b.Profiler.SetTagFilterDisable", "Set Profile Tag Filter Disable", OnSetProfileTagFilterDisable);
			RegisterConsoleCommandWithArgs("b.FakeDeviceInfo", "Fake Device Info", OnFakeDeviceInfo);
			RegisterConsoleCommandWithArgs("b.LoadingExceptionTest", "Loading Exception Test", OnLoadingExceptionTest);
			RegisterConsoleCommandWithArgs("b.OpenLoadingScreen", "Open Loading Screen", OnOpenLoadingScreen);
			RegisterConsoleCommandWithArgs("b.ShepherdTest", "Shepherd Test", OnShepherdTest);
			RegisterConsoleCommandWithArgs("b.FinishPlayerGuide", "Finish Player Guide", OnFinishPlayerGuide);
			RegisterConsoleCommandWithArgs("b.RemoteControlCamera", "Remote control camera", OnRemoteControlCamera);
			RegisterConsoleCommandWithArgs("b.ChangeUSharpGenOptimizedLevel", "Change USharpGen optimized level", OnChangeUSharpGenOptimizedLevel);
			RegisterConsoleCommand("b.TestWriteFile", "Test write file", OnTestWriteFile);
			RegisterConsoleCommandWithArgs("b.TriggerGlobalEvent", "Trigger Global Event", OnTriggerGlobalEvent);
			RegisterConsoleCommandWithArgs("b.ToggleCustomizedInputType", "DarkSouls/MonsterHunter", OnToggleCustomizedInputType);
			RegisterConsoleCommandWithArgs("b.ReplayTest", "Replay Test", OnReplayTest);
			RegisterConsoleCommandWithArgs("b.TransitionPhase", "Transition phase which is defined in CSG", OnTransitionPhase);
			RegisterConsoleCommandWithArgs("b.TransitionEachPhase", "Transition each phase which is defined in CSG", OnTransitionEachPhase);
			RegisterConsoleCommandWithArgs("b.SwitchPlatformIcon", "Switch platform icons, 0: XSX, 1: PS5", OnSwitchPlatformIcon);
			RegisterConsoleCommandWithArgs("b.InjectInputAction", "Inject input action with trigger event", OnInjectInputAction);
			RegisterConsoleCommand("b.Archive.RemoveAll", "Remove all archives", OnRemoveAllArchive);
			RegisterConsoleCommandWithArgs("b.Archive.FakeBad", "Fake bad archive", OnFakeBadArchive);
			RegisterConsoleCommand("b.PreloadTestAsset", "Preload test assets", PreloadAssets);
			RegisterConsoleCommand("b.GameConnect", "GameConnect", OnGameConnect);
			RegisterConsoleCommand("b.GameSend", "GameSend", OnGameSend);
			RegisterConsoleCommand("b.ViewportCaptureMouse", "ViewportCaptureMouse", OnViewportCaptureMouse);
			RegisterConsoleCommand("b.LoadAllStreamingLevels", "LoadAllStreamingLevels", OnLoadAllStreamingLevels);
			RegisterConsoleCommandWithArgs("b.SetReportMergeLimit", "set report trig limit", OnSetReportMergeLimit);
			RegisterConsoleCommandWithArgs("b.SetQualityLevel", "set quality level", SetQualityLevel);
			RegisterConsoleCommandWithArgs("b.EnableDrawSkillArea", "GameSend", OnEnableDrawSkillArea);
			RegisterConsoleCommandWithArgs("b.DisableDrawSkillArea", "GameSend", OnDisableDrawSkillArea);
			RegisterConsoleCommandWithArgs("b.ShowSweepCheckShape", "GameSend", OnShowSweepCheckShape);
			RegisterConsoleCommandWithArgs("b.CloseOptimizeTick", "CloseOptimizeTick", OnCloseOptimizeTick);
			RegisterConsoleCommandWithArgs("b.RefreshGameDB", "刷新表格数据", RefreshGameDB);
			RegisterConsoleCommandWithArgs("b.ChangeInputMode", "ChangeInputMode", OnChangeInputMode);
			RegisterConsoleCommandWithArgs("b.GCTest", "Test GC, 0 call C# GC, 1 call unreal GC", OnGCTest);
			RegisterConsoleCommandWithArgs("b.CrashTest", "Test Crash, 0 for c++, 1 for c#", OnCrashTest);
			RegisterConsoleCommandWithArgs("b.PausePsoBatching", "Pause PSO precomplilation batching process", OnPausePsoBatching);
			RegisterConsoleCommandWithArgs("b.ResumePsoBatching", "Resume PSO precomplilation batching process", OnResumePsoBatching);
			RegisterConsoleCommandWithArgs("b.LogRemainingPsoNum", "Print remaining PSO precompilation num", OnPrintRemainingPsoNum);
			RegisterConsoleCommandWithArgs("b.Memreport.ResolveObjectRef", "b.ResolveMemreportObjectRef filename1 filename 2. Process object reference based on difference of 2 given mem reports", OnResolveMemreportObjectRef);
			RegisterConsoleCommandWithArgs("b.PrintRefChianByObjectPath", "arg0: specified object path", OnPrintRefChain);
			RegisterConsoleCommandWithArgs("b.MaxCamLockTargetDistance", "Set MaxCamLockTargetDistance", SetMaxCamLockTargetDistance);
			RegisterConsoleCommandWithArgs("b.SetCamPitch", "SetCameraPitch", OnSetCamPitch);
			RegisterConsoleCommandWithArgs("b.SetArmLen", "SetCameraTargetArmLength", OnSetTargetArmLength);
			RegisterConsoleCommandWithArgs("b.SetFOV", "SetCameraFieldOfView", OnSetFOV);
			RegisterConsoleCommandWithArgs("b.Camera.SetTableParam.Player", "Set Player Camera Table Data [DataType] [Value]", OnSetPlayerCameraTableParam);
			RegisterConsoleCommandWithArgs("b.Camera.SetTableParam.Straight", "Set Straight Camera Table Data [DataType] [Value]", OnSetStraightCameraTableParam);
			RegisterConsoleCommandWithArgs("b.Camera.SetTableParam.Diagonal", "Set Diagonal Camera Table Data [DataType] [Value]", OnSetDiagonalCameraTableParam);
			RegisterConsoleCommandWithArgs("b.Camera.SetTableParam.Giant", "Set Giant Camera Table Data [DataType] [Value]", OnSetGiantCameraTableParam);
			RegisterConsoleCommandWithArgs("b.PrintLighting", "pring all active lights and postprocess", OnPrintLighting);
			RegisterConsoleCommandWithArgs("b.SpawnCharacter", "Spawn Character By ResID", OnSpawnCharacterByResID);
			RegisterConsoleCommandWithArgs("b.WEFMDebug", "[DBC][WEFM] Show WEFM visual debug fx 0 or 1", DBC_EditorDebug_WEFMVisualEditorDebugFX);
			RegisterConsoleCommandWithArgs("b.SetWEFMActive", "[DBC][WEFM] Set WEFM active true or false", DBC_Debug_SetWEFMActive);
			RegisterConsoleCommandWithArgs("b.WEFMLOD", "[DBC][WEFM] set WEFM lod quality, index is data asset setting array index", DBC_Debug_SetWEFMLOD);
			RegisterConsoleCommandWithArgs("b.DBCLogEventQueue", "[DBC][Debug] log duration too long events. [LogDBCEventQuene] [TaktTime] [LogAllEvent] [MaxEventDuration]", DBC_Debug_LogEventQueue);
			RegisterConsoleCommandWithArgs("b.DBCMergeNiagara.Enable", "[DBC][DBCMergeNiagara] 0 = disable DBCMergeNiagara.", DBC_EnableDBCMergeNiagara);
			RegisterConsoleCommandWithArgs("b.Debuginfo", "Enable/Disable Debug Info [DebugConfigX2] [On/Off]", OnDebugInfo);
			RegisterConsoleCommandWithArgs("b.TestChris", "", TestChris);
			RegisterConsoleCommandWithArgs("b.ChrisTestHaptic", "", ChrisTestHaptic);
			RegisterConsoleCommandWithArgs("b.ChrisTestFeedBack", "", ChrisTestFeedBack);
			RegisterConsoleCommandWithArgs("b.ChapterClear", "(int)ChapterID", ChapterClear);
			RegisterConsoleCommandWithArgs("b.ComboTest", "[Param1 = ComboList(Json)]", ComboTest);
			RegisterConsoleCommandWithArgs("b.Save", "SavaData Param = Slot  Default Zero", OnTriggerSave);
			RegisterConsoleCommandWithArgs("b.closeLoading", "SavaData Param = Slot  Default Zero", OnCloseLoading);
			RegisterConsoleCommandWithArgs("b.ToggleCharacterView", "Toggle Character View (Enable: 1; Disable: 0)", OnToggleCharacterView);
			RegisterConsoleCommandWithWorld("b.TestPredict", "TestPredict", OnTestPredict);
			RegisterConsoleCommandWithArgs("test.DestroyNiagara", "destroy all niagara for debugging", OnDestroyAllNiagara);
			RegisterConsoleCommandWithArgs("b.EnableAutoMove", "arg0: Index of the monitor instance, arg1: Index of the move pattern", OnEnableAutoMove);
			RegisterConsoleCommandWithArgs("b.SetVfxAutoPlayRootFolder", "Set VFXAutoPlayer's root folder", OnSetVFXAutoPlayRootFolder);
			RegisterConsoleCommandWithArgs("b.TestSeq", "(int)SequenceID", OnTestSpecificSequence);
			RegisterConsoleCommandWithArgs("b.DestroyActorsWithKeyword", "(string) Specify the keyword contained in the name of those actors to be deleted", OnSpecifiedDeletedActorsKeyword);
			RegisterConsoleCommandWithArgs("b.ChangeLanguage", "", OnChangeLanguage);
			RegisterConsoleCommandWithArgs("b.SetCSharpTickEnable", "", OnSetCSharpTickEnable);
			RegisterConsoleCommandWithArgs("b.ForceTileSwitchLOD", "ForceTileSwitchLOD TileName 0/1 : 0:Switch off, 1:Switch on", OnForceTileSwitchLOD);
			RegisterConsoleCommandWithArgs("b.HilightDestructible", "以紫色高亮显示可破碎物（本次Play中不可逆，只能以紫色显示了）", OnHilightDestructible);
			RegisterConsoleCommandWithArgs("b.HilightBlockAirWall", "显示阻挡空气墙的线框：0为隐藏；1为显示", OnHilightBlockAirWall);
			RegisterConsoleCommandWithArgs("b.HilightCliffAirWall", "显示悬崖空气墙的线框：0为隐藏；1为显示", OnHilightCliffAirWall);
			RegisterConsoleCommandWithArgs("b.ToggleDeadZoneShow", "切换DeadZone在运行时的显隐情况", OnToggleDeadZoneShow);
			RegisterConsoleCommandWithArgs("b.ToggleTriggerBoxShow", "切换TriggerBox的线框显隐情况，目前包括ForceFight盒子，动态空气墙，阵营混战盒子，BuffTrigger盒子", OnToggleTriggerBoxShow);
			RegisterConsoleCommandWithArgs("b.KillSpecificEnemy", "无条件击杀具体怪。需要指定其Tamer名称", OnKillSpecificEnemy);
			RegisterConsoleCommandWithArgs("b.PlayerTraceStart", "在主角停留过的位置生成箭头，标注已走过的位置。传入数字作为生成间隔，默认1s生成一个", OnPlayerTraceStart);
			RegisterConsoleCommandWithArgs("b.PlayerTraceStop", "停止在主角位置生成箭头", OnPlayerTraceStop);
			RegisterConsoleCommandWithArgs("b.PlayerTraceClean", "清除已生成的箭头", OnPlayerTraceClean);
			RegisterConsoleCommandWithArgs("b.RunAutoTest", "执行单个自动测试TestCase，参数为测试用例名称TestLabel", OnRunAutoTest);
			RegisterConsoleCommandWithArgs("b.StopAutoTest", "停止（跳过）当前正在执行的自动测试TestCase", OnStopAutoTest);
			RegisterConsoleCommandWithArgs("b.RunTestSuite", "执行预定义的测试用例集TestSuite，参数为用例集名称，可至TestSuiteDef.cs中寻找", OnRunTestSuite);
			RegisterConsoleCommandWithArgs("b.StopTestSuite", "彻底停止当前正在执行的测试用例集", OnStopTestSuite);
			RegisterConsoleCommandWithArgs("b.RunCustomSuite", "执行组装测试用例集", OnRunTestCasesFromGM);
			RegisterConsoleCommandWithArgs("b.QATransLevel", "直接调用选关事件（谭旭测试用，请勿随意尝试！）", OnQATransLevel);
			RegisterConsoleCommandWithArgs("b.QACamTp", "Teleport To F10 Point", OnTeleportToPoint);
			RegisterConsoleCommand("b.QAGenError", "生成弹窗报错（C#）", OnGenError);
			RegisterConsoleCommand("b.QAGenCrash", "生成崩溃（C++）", OnGenCrash);
			RegisterConsoleCommand("b.QATest", "临时测试函数", OnQATest);
			RegisterConsoleCommand("b.QARest", "进行一次原地的硬调息", OnQARest);
			RegisterConsoleCommand("b.QAGenerateSkillHud", "显示控制怪物的UI面板", OnQAGenerateSkillHud);
			RegisterConsoleCommandWithArgs("b.QAGenerateTamer", "生成怪物", OnQAGenerateTamer);
			RegisterConsoleCommand("b.QAStartRecordFPS", "开始记录帧率", OnQAStartRecordFPS);
			RegisterConsoleCommand("b.QAStopRecordFPS", "记录帧率结束", OnQAStopRecordFPS);
			RegisterConsoleCommandWithArgs("b.AddTraceStat", "新增监控Stat", OnAddTraceStatInfo);
			RegisterConsoleCommandWithArgs("b.RunStartMemReportAnalysis", "执行memreport文件分析流程，参数为需要导出的Class类型，使用,分隔", OnRunStartMemReportAnalysis);
			RegisterConsoleCommandWithArgs("b.EnableComboAINodeLog", "开关Combo节点Debug：0为关闭；1为开启", OnEnableComboAINodeLog);
			RegisterConsoleCommandWithArgs("b.EnableComboAINodeScoreLog", "开关Combo节点算分Debug：0为关闭；1为开启", OnEnableComboAINodeScoreLog);
			RegisterConsoleCommandWithArgs("b.DisableSetBT", "测试用，关闭行为树", OnDisableSetBT);
			RegisterConsoleCommandWithArgs("b.DisableEnemyChasing", "关闭敌人追逐", OnDisbaleEnemyChasing);
			RegisterConsoleCommandWithArgs("b.TextureInfo.Start", "开始抓取纹理 mip 数据", OnStartCaptureTextureInfo);
			RegisterConsoleCommandWithArgs("b.TextureInfo.Stop", "停止抓取纹理 mip 数据", OnStopCaptureTextureInfo);
			RegisterConsoleCommandWithArgs("b.Task.ShowStageState", "打印当前RoleData里全部任务阶段状态信息，第一个参数是指定任务线ID（可以不带）", OnShowTaskStageState);
			RegisterConsoleCommandWithArgs("b.Preload.PrintResourceInfo", "打印当前Preload信息", OnPrintResourceInfo);
			RegisterConsoleCommandWithArgs("b.Preload.PrintAbnormalResourceList", "打印Preload异常资源列表", OnPrintAbnormalResourcePathList);
			RegisterConsoleCommandWithArgs("b.Preload.AACSLoadDistance", "修改AACS Preload动画资源触发距离(不填或者填0则不修改该参数)：{异步XY}{异步Z}{同步XY}{同步Z}", OnAAPreloadDistance);
			RegisterConsoleCommandWithArgs("b.Preload.MonsterResourceReleaseDuration", "修改单位预加载资源卸载判断间隔时间（默认是5秒，不填参数恢复默认）：{时间(秒)}", OnMonsterResourceReleaseDuration);
			RegisterConsoleCommandWithArgs("b.DrawDebug.EnableShowShapeSelectRange", "画出形状选择范围信息, 1开启，0关闭", EnableShapeSelectRange);
			RegisterConsoleCommandWithArgs("b.DrawDebug.EnableShowShapeSelectUnit", "画出形状选择单位信息, 1开启，0关闭", EnableShapeSelectUnit);
			RegisterConsoleCommandWithArgs("b.AssociationUnitInfo.PrintCurrentInfo", "打印当前协战单位信息", PrintCurrentAssociationUnitInfo);
			RegisterConsoleCommandWithArgs("b.FollowPartner.PrintCurrentInfo", "打印当前跟随作战单位信息", PrintCurrentFollowPartnerInfo);
			RegisterConsoleCommandWithArgs("b.FollowPartner.PrintCurrentWeakAiInteractInfo", "打印当前WeakAiInteract信息", PrintCurrentWeakAiInteractInfo);
			RegisterConsoleCommandWithArgs("b.SetViewLocationAndRotation", "设置Editor视野位置 第一个参数是位置 第二个参数是朝向", SetViewLocationAndRotation);
			RegisterConsoleCommandWithArgs("b.RefreshLevelInfo", "刷新场景信息，Diana用", RefreshLevelInfo);
			RegisterConsoleCommandWithArgs("b.RefreshActorInfo", "RefreshActorInfo [ActorType] OR RefreshActorInfo [OnOff] [ActorGuid] ,刷新Actor信息，Diana用 ", RefreshActorInfo);
			RegisterConsoleCommandWithArgs("b.PauseLevelStreaming", "暂停关卡streaming", OnPauseLevelStreaming);
			RegisterConsoleCommandWithArgs("b.ResumeLevelStreaming", "恢复关卡streaming", OnResumeLevelStreaming);
			RegisterConsoleCommandWithArgs("b.ForceUnloadLevels", "强行卸载包含指定关键词的关卡(用空格隔开)", OnForceUnloadLevels);
			RegisterConsoleCommandWithArgs("b.ForceLoadLevels", "强行加载包含指定关键词的关卡(用空格隔开)", OnForceLoadLevels);
			RegisterConsoleCommandWithArgs("b.FlushDistanceStreaming", "针对包含指定关键词的关卡(用空格隔开, 参数为空表示恢复所有关卡), 恢复其距离加载", OnFlushDistanceStreaming);
			RegisterConsoleCommandWithArgs("b.ModifyStreamingDistanceScaleByLayer", "缩放指定 layer 的加载距离. <arg0>: Layer name; <arg1> LOD index(-1 means original); <arg2>: scale factor <arg3>: block or not", OnModifyStreamingDistanceScale);
			RegisterConsoleCommandWithArgs("b.Demo820SettingInit", "设置初始化", OnDemo820SettingInit);
			RegisterConsoleCommandWithArgs("b.Demo820GMSetTimeInfo", "设置时间配置", OnDemo820GMSetTimeInfo);
			RegisterConsoleCommandWithArgs("b.Demo820TimePause", "设置暂停时间", OnDemo820TimePause);
			RegisterConsoleCommand("b.PlayGo.Pause", "Play Go 暂停下载", OnPlayGoPause);
			RegisterConsoleCommand("b.PlayGo.Resume", "Play Go 恢复下载", OnPlayGoResume);
			RegisterConsoleCommand("b.PlayGo.Begin", "Play Go 开始下载", OnPlayGoBegin);
			RegisterConsoleCommand("b.PlayGo.Finish", "Play Go 完成下载", OnPlayGoFinish);
			RegisterConsoleCommandWithArgs("b.PlayGo.SetSpeed", "Play Go 设置速度（单位: G/s）", OnPlayGoSetSpeed);
			RegisterConsoleCommandWithArgs("b.OpenBattleInfoTool", "开启BattleInfo", OnOpenBattleInfo);
			RegisterConsoleCommandWithArgs("b.RefreshBattleInfoTool", "Refresh BattleInfo", OnRefreshBattleInfo);
			RegisterConsoleCommandWithArgs("b.LogLevelStreamingState", "显示所有当前受控的LevelState信息，选项：[-WCTile] [关卡Keyword1] [关卡Keyword2...]", LogLevelStreamingState);
			RegisterConsoleCommandWithArgs("b.LogCurrentRequestingLevelStateOperations", "显示当前正在执行的请求信息", LogCurrentRequestingLevelStateOperations);
			RegisterConsoleCommandWithArgs("b.LogProcessingStreamingLevels", "显示正在处理的 LevelStreaming 队列", LogProcessingStreamingLevels);
			RegisterConsoleCommand("b.PrintWukongMatQualityInfo", "打印当前wukong身上MatQuality", OnPrintWukongMatQualityInfo);
			RegisterConsoleCommandWithArgs("b.ShowActorDebugWidget", "ShowActorDebugWidget + UnitGuid + 0/1", OnGSShowDebugWidget);
			RegisterConsoleCommandWithArgs("b.SetShowPreloadDetailInfoType", "Diana设置Preload详细信息展示类型", OnGSSetShowPreloadDetailInfoType);
			RegisterConsoleCommandWithArgs("b.OpenInputLog", "Input Log", OnOpenInputLog);
			RegisterConsoleCommandWithArgs("b.SwitchInputDisplay", "SwitchInputDisplay", OnSwitchInputDisplay);
			RegisterConsoleCommandWithArgs("b.BeginSaveArchived", "BeginSaveArchived", OnBeginSaveArchived);
			RegisterConsoleCommandWithArgs("b.AllMuseum", "AllMuseum", OnAllMuseum);
			RegisterConsoleCommandWithArgs("b.Artbook", "Artbook", OnAddArtbook);
			RegisterConsoleCommandWithArgs("b.Mv", "Mv", OnAddMuseumMv);
			RegisterConsoleCommandWithArgs("b.LoadHotScript", "b.LoadHotScript DllPath EntryClassName EntryMethodName", LoadHotScript);
			RegisterConsoleCommandWithArgs("wwise.rtpc", "RtpcName RtpcVal eg:wwise.rtpc RTPC_Volume_Global 100", SetWwiseRtpc);
			RegisterConsoleCommandWithArgs("wwise.event", "EventName eg:wwise.event EVT_ui_item_genqi_focus", InvokeWwiseEvent);
			GMInfo.ResetCurRegistInfo();
		}
	}

	private void InitCheatGM()
	{
		if (HasGMFlag(2))
		{
			GMInfo.SetCurRegistInfo(EGMType.GM_BGW, 2);
			RegisterConsoleCommandWithArgs("b.RunDiana", "运行Diana", RunDiana);
			RegisterConsoleCommandWithArgs("b.SetMaxHP", "b.SetMaxHP + (float)maxhp", OnGSSetMaxHP);
			RegisterConsoleCommandWithArgs("b.SetMaxMP", "b.SetMaxMP + (float)maxmp", OnGSSetMaxMP);
			RegisterConsoleCommandWithArgs("b.SetATK", "b.SetATK + (float)atk", OnGSSetAttack);
			RegisterConsoleCommandWithArgs("b.SetBloodBottle", "Set Blood Bottle + (float)number", OnGSSetBloodBottle);
			RegisterConsoleCommandWithArgs("b.SetStaminaMax", "Set Stamina Max + (float)number", OnGSSetStaminaMax);
			RegisterConsoleCommandWithArgs("b.SetPE", "b.SetPE + (float)energy value", OnGSSetPE);
			RegisterConsoleCommandWithArgs("b.SetTransEnergy", "b.SetTransEnergy + (float)energy value", OnGSSetTransEnergy);
			RegisterConsoleCommandWithArgs("b.ChangeCharacterSpd", "b.ChangeCharacterSpd + (float)spd", OnGSChangeCharacterSpd);
			RegisterConsoleCommandWithArgs("b.ChangeEnemySpd", "b.ChangeEnemySpd + (float)spd", OnGSChangeEnemySpd);
			RegisterConsoleCommandWithArgs("b.ChangeGlobalSpd", "b.ChangeGlobalSpd + (float)spd", OnGSChangeGlobalSpd);
			RegisterConsoleCommandWithArgs("b.fullHP", "Full HP", OnGSFullHP);
			RegisterConsoleCommandWithArgs("b.fullMP", "Full MP", OnGSFullMP);
			RegisterConsoleCommandWithArgs("b.fullPE", "Full PE", OnGSFullPE);
			RegisterConsoleCommandWithArgs("b.FullBloodBottle", "Full Blood Bottle", OnGSFullBloodBottle);
			RegisterConsoleCommandWithArgs("b.FullFaBaoEnergy", "Full FaBao Energy", OnGSFullFabaoEnergy);
			RegisterConsoleCommandWithArgs("b.SetFaBaoEnergy", "b.FullFaBaoEnergy + (float)value", OnGSSetFabaoEnergy);
			RegisterConsoleCommandWithArgs("b.FullVigorEnergy", "Full Vigor Energy", OnGSFullVigorEnergy);
			RegisterConsoleCommandWithArgs("b.SetVigorEnergy", "b.SetVigorEnergy + (float)value", OnGSSetVigorEnergy);
			RegisterConsoleCommandWithArgs("b.KillAllEnemy", "KillAllEnemy", OnGSKillAllEnemy);
			RegisterConsoleCommandWithArgs("b.RemoveAllBuff", "Remove All Buff", OnGSRemoveAllBuff);
			RegisterConsoleCommandWithArgs("b.FullTransEnergy", "FullTransEnergy", FullTransEnergy);
			RegisterConsoleCommandWithArgs("b.Task.TryPushStage", "测试往下推进任务阶段。第一个参数是阶段ID，第二个参数是是否推进到结束（1为是）", OnTryPushTaskStage);
			RegisterConsoleCommandWithArgs("b.Invincible", "Hyper Muteki", OnGSInvincible);
			RegisterConsoleCommandWithArgs("b.UnInvincible", "Hyper Muteki", OnGSUnInvincible);
			RegisterConsoleCommandWithArgs("b.LockHP", "Lock HP", OnGSLockHP);
			RegisterConsoleCommandWithArgs("b.UnlockHP", "Unlock HP", OnGSUnlockHP);
			RegisterConsoleCommandWithArgs("b.LockMP", "Lock MP", OnGSLockMP);
			RegisterConsoleCommandWithArgs("b.UnlockMP", "Unlock MP", OnGSUnlockMP);
			RegisterConsoleCommandWithArgs("b.LockStamina", "Lock Stamina", OnGSLockStamina);
			RegisterConsoleCommandWithArgs("b.UnLockStamina", "UnLock Stamina", OnGSUnLockStamina);
			RegisterConsoleCommandWithArgs("b.Invisible", "Invisible", OnGSInvisible);
			RegisterConsoleCommandWithArgs("b.UnInvisible", "UnInvisible", OnGSUnInvisible);
			RegisterConsoleCommandWithArgs("b.CancelCD", "CancelCD + (bool)Cancel", OnGSCancelSkillCD);
			RegisterConsoleCommandWithArgs("b.CancelLifeSavingHairCD", "CancelLifeSavingHairCD + (bool)Cancel", OnGSCancelLifeSavingHairDC);
			RegisterConsoleCommandWithArgs("b.LockTransEnergy", "LockTransEnergy", OnGSLockTransEnergy);
			RegisterConsoleCommandWithArgs("b.UnlockTransEnergy", "UnlockTransEnergy", OnGSUnLockTransEnergy);
			RegisterConsoleCommandWithArgs("b.LockPE", "LockPE", OnGSLockPE);
			RegisterConsoleCommandWithArgs("b.UnlockPE", "UnlockPE", OnGSUnLockPE);
			RegisterConsoleCommandWithArgs("b.LockFaBaoEnergy", "LockFaBaoEnergy", OnGSLockFaBaoEnergy);
			RegisterConsoleCommandWithArgs("b.UnlockFaBaoEnergy", "UnlockFaBaoEnergy", OnGSUnLockFaBaoEnergy);
			RegisterConsoleCommandWithArgs("b.LockVigorEnergy", "LockVigorEnergy", OnGSLockVigorEnergy);
			RegisterConsoleCommandWithArgs("b.UnlockVigorEnergy", "UnlockVigorEnergy", OnGSUnLockVigorEnergy);
			RegisterConsoleCommandWithArgs("b.LockEnemyHP", "LockEnemyHP", OnGSLockEnemyHP);
			RegisterConsoleCommandWithArgs("b.UnLockEnemyHP", "UnockEnemyHP", OnGSUnlockEnemyHP);
			RegisterConsoleCommandWithArgs("b.CancelEnemyCD", "CancelAllEnemyCD + (bool)Cancel", OnGSCancelEnemySkillCD);
			RegisterConsoleCommandWithArgs("b.ToggleAllEnemyAI", "ToggleAllEnemyAI + (bool)Pause", OnGSToggleAllEnemyAI);
			RegisterConsoleCommandWithArgs("b.SetDebugTargetMask", "设置目标调试Mask， b.SetDebugTargetMask [UnitGuid] [Mask]", OnSetDebugTargetMask);
			RegisterConsoleCommandWithArgs("b.SetAllUnitTargetIsFirstPlayer", "SetAllUnitTargetIsFirstPlayer", OnSetAllUnitTargetIsFirstPlayer);
			RegisterConsoleCommandWithArgs("b.SetCanTriggerGroupAI", "SetCanTriggerGroupAI enable:1 disable:0", SetCanTriggerGroupAI);
			RegisterConsoleCommandWithArgs("b.GamePlayTraceStart", "GamePlayTraceStart", OnGamePlayTraceStart);
			RegisterConsoleCommandWithArgs("b.GamePlayTraceEnd", "GamePlayTraceEnd", OnGamePlayTraceEnd);
			RegisterConsoleCommandWithArgs("b.QuictRebirth", "QuictRebirth", OnQuickRebirth);
			RegisterConsoleCommandWithArgs("b.QuickTeleport", "teleport", OnQuickTeleport);
			RegisterConsoleCommandWithArgs("b.StartSkill", "teleport", OnCallStartSkill);
			RegisterConsoleCommandWithArgs("b.EndSkill", "teleport", OnCallEndSkill);
			RegisterConsoleCommandWithArgs("b.SaveNiagaraStatInfo", "teleport", OnCallSaveNiagaraInfo);
			GMInfo.ResetCurRegistInfo();
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnOpenInputLog(IntPtr NativePtr)
	{
		string[] args = GetArgs(NativePtr);
		if (args.Length == 1)
		{
			if (args[0] == "0")
			{
				BGW_EventCollection.Get(GetThis()).Evt_OpenInputLog(bOpen: false);
			}
			else if (args[0] == "1")
			{
				BGW_EventCollection.Get(GetThis()).Evt_OpenInputLog(bOpen: true);
			}
		}
		else if (args.Length == 2)
		{
			if (args[0] == "0")
			{
				BGW_EventCollection.Get(GetThis()).Evt_OpenInputLog(bOpen: false);
			}
			else if (args[0] == "1")
			{
				BGW_EventCollection.Get(GetThis()).Evt_OpenInputLog(bOpen: true, args[1]);
			}
		}
		else
		{
			BGW_EventCollection.Get(GetThis()).Evt_OpenInputLog(bOpen: true);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnReplayTest(IntPtr NativePtr)
	{
		string[] args = GetArgs(NativePtr);
		string text = args[0].ToLower();
		if (args.Length == 1)
		{
			switch (text)
			{
			case "record":
				BGW_ReplaySystemMgr.Get(GetThis()).BeginRecord();
				break;
			case "stop":
				BGW_ReplaySystemMgr.Get(GetThis()).StopRecord();
				break;
			case "checkpoint":
				BGW_ReplaySystemMgr.Get(GetThis()).RequestCheckpoint();
				break;
			}
		}
		else if (args.Length == 2)
		{
			if (text == "skip")
			{
				float timeToSkip = float.Parse(args[1]);
				BGW_ReplaySystemMgr.Get(GetThis()).SkipTime(timeToSkip);
			}
			else if (text == "play")
			{
				BGW_ReplaySystemMgr.Get(GetThis()).PlayRecord(args[1]);
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTransitionPhase(IntPtr NativePtr)
	{
		string[] args = GetArgs(NativePtr);
		if (args.Length < 2)
		{
			return;
		}
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGU_CharacterAI>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			IBUC_FsmData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_FsmData>(allActorsOfClass[i]);
			if (readOnlyData != null)
			{
				FsmInstancePhaseComp phaseComp = readOnlyData.GetPhaseComp();
				if (phaseComp != null && phaseComp.TemplateAsset.AssetPath.ToLower().Contains(args[0].ToLower()))
				{
					phaseComp.TransitionPhaseForDebug(string.Join(".", args, 1, args.Length - 1));
					break;
				}
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTransitionEachPhase(IntPtr NativePtr)
	{
		string[] args = GetArgs(NativePtr);
		if (args.Length < 2)
		{
			return;
		}
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGU_CharacterAI>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			IBUC_FsmData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_FsmData>(allActorsOfClass[i]);
			if (readOnlyData != null)
			{
				FsmInstancePhaseComp phaseComp = readOnlyData.GetPhaseComp();
				if (phaseComp != null && phaseComp.TemplateAsset.AssetPath.ToLower().Contains(args[0].ToLower()))
				{
					phaseComp.TransitionEachPhaseForDebug(args.Skip(1).Take(args.Length - 1).ToArray());
					break;
				}
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSwitchPlatformIcon(IntPtr NativePtr)
	{
		string[] args = GetArgs(NativePtr);
		if (args.Any() && int.TryParse(args[0], out var result))
		{
			switch (result)
			{
			case 0:
				FInputDeviceTracker.ForceSetIconTypes(EGSInputIconType.XSX);
				break;
			case 1:
				FInputDeviceTracker.ForceSetIconTypes(EGSInputIconType.PS5);
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnInjectInputAction(IntPtr NativePtr)
	{
		string[] args = GetArgs(NativePtr);
		if (args.Length < 2)
		{
			return;
		}
		foreach (ETriggerEvent item in Enum.GetValues(typeof(ETriggerEvent)).Cast<ETriggerEvent>())
		{
			if (item.ToString().ToLower() == args[1].ToLower())
			{
				BGW_EventCollection.Get(GetThis()).Evt_InjectInputTriggerEvent(args[0], item, FInputActionValue.True);
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnRemoveAllArchive()
	{
		try
		{
			BGW_GameArchiveMgr.Get(GetThis()).GMClearAllArchive("OnRemoveAllArchive:Console Command");
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.InvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnFakeBadArchive(IntPtr NativePtr)
	{
		try
		{
			if (!BGUFuncLibMap.IsBattleMap(GetThis()))
			{
				FMessage.OpenDialog("请到厕所或者战斗关卡这样有角色的地方创建");
				return;
			}
			string[] args = GetArgs(NativePtr);
			if (args.Any() && int.TryParse(args[0], out var result))
			{
				if (result < 1 && result > 5)
				{
					FMessage.OpenDialog("请输入 1~5 的数字");
				}
				else
				{
					USystemLibrary.ExecuteConsoleCommand(GetThis(), $"b.sys GMArchive {result}", null);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.InvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnChangeUSharpGenOptimizedLevel(IntPtr NativePtr)
	{
		string[] args = GetArgs(NativePtr);
		if (args.Length == 1 && int.TryParse(args[0], out var result))
		{
			switch (result)
			{
			case 0:
				NativeReflection.IsOptimized = false;
				NativeReflection.IsDebugAssert = true;
				break;
			case 1:
				NativeReflection.IsOptimized = true;
				NativeReflection.IsDebugAssert = true;
				break;
			case 2:
				NativeReflection.IsOptimized = true;
				NativeReflection.IsDebugAssert = false;
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnShepherdTest(IntPtr NativePtr)
	{
		try
		{
			BGWGameInstanceCS bGWGameInstanceCS = BGWGameInstanceCS.Get(GetThis());
			if (bGWGameInstanceCS.GetCurLoadingScreenState() != EGSLoadingScreenState.Idle)
			{
				bGWGameInstanceCS.CloseLoadingScreen();
				return;
			}
			string[] args = GetArgs(NativePtr);
			if (args.Length >= 2 && int.TryParse(args[0], out var result) && int.TryParse(args[1], out var Id))
			{
				UMaterialInstance parent = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UMaterialInstance>("MaterialInstanceConstant'/Game/00Main/UI/BluePrintsV3/Loading/MI_UIBRLoading_Pic.MI_UIBRLoading_Pic'", ELoadResourceType.SyncLoadAndCache);
				UMaterialInstanceDynamic uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(GetThis(), parent, FName.None, EMIDCreationFlags.None);
				uMaterialInstanceDynamic.SetScalarParameterValue(new FName("Pic_1"), ((result & 1) == 0) ? 0f : 1f);
				uMaterialInstanceDynamic.SetScalarParameterValue(new FName("Pic_2"), ((result & 2) == 0) ? 0f : 1f);
				uMaterialInstanceDynamic.SetTextureParameterValue(new FName("MainTex"), GetTestTexture());
				bGWGameInstanceCS.OpenLoadingScreen(UseSlateThread: false, EGSLoadingScreenType.BossRush);
				FBossRushInfo bossRushInfo = new FBossRushInfo
				{
					LoadingType = EBossRushLoadingType.BossIterations,
					BossName = FText.GetEmpty()
				};
				bGWGameInstanceCS.RegisterBossRushInfo(bossRushInfo);
			}
			UTexture2D GetTestTexture()
			{
				string path = $"Texture2D'/Game/00MainHZ/UI/AlwaysCook/Wallpaper/Rebirthpoint/IMG_rebirthpoint_{Id}_b.IMG_rebirthpoint_{Id}_b'";
				return BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UTexture2D>(path, ELoadResourceType.SyncLoadAndCache);
			}
		}
		catch (Exception)
		{
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnFinishPlayerGuide(IntPtr NativePtr)
	{
		try
		{
			BGU_DataUtil.GetGameStateReadonlyData<BGC_PlayerGuideData>(GetThis())?.FinishedGroupGuideList.Add(1001);
		}
		catch (Exception)
		{
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnRemoteControlCamera(IntPtr NativePtr)
	{
		string[] args = GetArgs(NativePtr);
		if (args.Any() && int.TryParse(args[0], out var result))
		{
			BGW_EventCollection.Get(GetThis()).Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.RemoteCamera, result == 1);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTriggerGlobalEvent(IntPtr NativePtr)
	{
		try
		{
			string[] args = GetArgs(NativePtr);
			if (args.Length != 1)
			{
				return;
			}
			foreach (EGI_Global item in Enum.GetValues(typeof(EGI_Global)).Cast<EGI_Global>())
			{
				if (item.ToString() == args[0])
				{
					BGW_EventCollection.Get(GetThis()).Evt_BGW_TriggerGlobalFSMEvent(item);
					break;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnTestWriteFile()
	{
		string filename = "/Temp/ShepherdTest";
		List<byte> bytesToWrite = new List<byte> { 1, 2, 3, 4, 5, 6, 7, 8 };
		UGSFileHelper.WriteFile(filename, bytesToWrite);
		UGSFileHelper.ReadFile(filename, out var _);
		if (UGSFileHelper.FileExists(filename))
		{
			UGSFileHelper.DeleteFile(filename);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnToggleCustomizedInputType(IntPtr NativePtr)
	{
		string[] args = GetArgs(NativePtr);
		if (args.Length == 1 && int.TryParse(args[0], out var result))
		{
			switch (result)
			{
			case 0:
				BGW_EnhancedInputMgrV2.Get(GetThis()).InputSettingTracker.GamepadSetting.ToggleCustomizedInputType(ECustomizedInputType.TypeA);
				return;
			case 1:
				BGW_EnhancedInputMgrV2.Get(GetThis()).InputSettingTracker.GamepadSetting.ToggleCustomizedInputType(ECustomizedInputType.TypeB);
				return;
			}
		}
		BGW_EnhancedInputMgrV2.Get(GetThis()).InputSettingTracker.GamepadSetting.ToggleCustomizedInputType(ECustomizedInputType.TypeA);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnOpenLoadingScreen(IntPtr NativePtr)
	{
		BGWGameInstanceCS.Get(GetThis()).OpenLoadingScreen(UseSlateThread: false, EGSLoadingScreenType.Full);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnLoadingExceptionTest(IntPtr NativePtr)
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnFakeDeviceInfo(IntPtr NativaArgs)
	{
		string[] args = GetArgs(NativaArgs);
		if (args.Length != 2)
		{
			return;
		}
		FieldInfo field = typeof(BGUFuncLibDeviceInfoCS).GetField("_DeviceInfo");
		if (field == null)
		{
			return;
		}
		FieldInfo[] fields = field.FieldType.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			if (!fieldInfo.Name.ToLower().Contains(args[0].ToLower()))
			{
				continue;
			}
			object deviceInfo = BGUFuncLibDeviceInfoCS.GetDeviceInfo();
			if (fieldInfo.FieldType == typeof(int))
			{
				try
				{
					fieldInfo.SetValue(deviceInfo, Convert.ToInt32(args[1]));
				}
				catch (Exception ex)
				{
					FMessage.OpenDialog(ex.Message, "FakeDeviceInfo");
				}
			}
			else if (fieldInfo.FieldType == typeof(EPlatformType))
			{
				bool flag = false;
				foreach (EPlatformType value in Enum.GetValues(typeof(EPlatformType)))
				{
					if (value.ToString().ToLower().Contains(args[1].ToLower()))
					{
						fieldInfo.SetValue(deviceInfo, value);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					FMessage.OpenDialog("输入平台的格式不正确。", "FakeDeviceInfo");
				}
			}
			else
			{
				fieldInfo.SetValue(deviceInfo, args[1]);
			}
		}
		BGUFuncLibDeviceInfoCS.WriteDeviceInfoToLocalFile();
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetProfileTagFilterEnable(IntPtr NativaArgs)
	{
		string[] args = GetArgs(NativaArgs);
		int num = 0;
		FieldInfo[] fields = typeof(GSE_ProfileUtil.EProfileTag).GetFields();
		FieldInfo field = typeof(GSE_ProfileUtil).GetField("sProfileTagFilter");
		if (args.Length == 0)
		{
			field.SetValue(GetThis(), int.MaxValue);
			return;
		}
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			string[] array2 = args;
			foreach (string text in array2)
			{
				if (fieldInfo.Name.ToLower().Contains(text.ToLower()))
				{
					int num2 = (int)fieldInfo.GetValue(GetThis());
					num |= num2;
				}
			}
		}
		int num3 = (int)field.GetValue(GetThis());
		field.SetValue(GetThis(), num3 | num);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetProfileTagFilterDisable(IntPtr NativaArgs)
	{
		string[] args = GetArgs(NativaArgs);
		int num = int.MaxValue;
		FieldInfo[] fields = typeof(GSE_ProfileUtil.EProfileTag).GetFields();
		FieldInfo field = typeof(GSE_ProfileUtil).GetField("sProfileTagFilter");
		if (args.Length == 0)
		{
			field.SetValue(GetThis(), 0);
			return;
		}
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			string[] array2 = args;
			foreach (string text in array2)
			{
				if (fieldInfo.Name.ToLower().Contains(text.ToLower()))
				{
					int num2 = (int)fieldInfo.GetValue(GetThis());
					num &= ~num2;
				}
			}
		}
		int num3 = (int)field.GetValue(GetThis());
		field.SetValue(GetThis(), num3 & num);
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnEnableTickProfiler()
	{
		FieldInfo field = typeof(GSE_ProfileUtil).GetField("sOpenProfiler");
		field.SetValue(value: !(bool)field.GetValue(GetThis()), obj: GetThis());
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSCloseCamAdapt(IntPtr NativaArgs)
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSysGM(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			string text = "";
			for (int i = 0; i < args.Length; i++)
			{
				if (i >= 1)
				{
					text += " ";
				}
				text += args[i];
			}
			BGUFunctionLibraryManaged.RunScriptGM(text, GetThis());
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtrIntPtr))]
	private static void OnGSSysGMV2(IntPtr argsPtr, IntPtr worldPtr)
	{
		try
		{
			string[] args = GetArgs(argsPtr);
			UObject world = GetWorld(worldPtr);
			if (args.Length == 0)
			{
				return;
			}
			string text = "";
			for (int i = 0; i < args.Length; i++)
			{
				if (i >= 1)
				{
					text += " ";
				}
				text += args[i];
			}
			BGUFunctionLibraryManaged.RunScriptGM(text, world);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSysGMForConsole(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			string text = "";
			for (int i = 0; i < args.Length; i++)
			{
				if (i >= 1)
				{
					text += " ";
				}
				text += args[i];
			}
			BGUFunctionLibraryManaged.RunScriptGM(text, GetThis());
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTeleportToPosition(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 3)
			{
				BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).GetControlledPawn() as BGUCharacterCS;
				if (bGUCharacterCS != null)
				{
					float.TryParse(args[0], out var result);
					float.TryParse(args[1], out var result2);
					float.TryParse(args[2], out var result3);
					BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_SetActorLocationGM.Invoke(new FVector(result, result2, result3), bSweep: false, bTeleport: true);
					ActorFuncLib.SetActorTransformSimple(bGUCharacterCS.Address, new FTransform(new FVector(result, result2, result3)), bSweep: false, 1);
					BGUFunctionLibraryCS.BlockTillLevelStreamingCompleted(bGUCharacterCS.World);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTeleportToPoint(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			string input = args[0].Substring(args[0].IndexOf('('));
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis());
			string pattern = "-?\\d+(?:\\.\\d+)?(?:[eE][+-]?\\d+)?";
			MatchCollection matchCollection = Regex.Matches(input, pattern);
			double[] array = new double[matchCollection.Count];
			for (int i = 0; i < matchCollection.Count; i++)
			{
				array[i] = double.Parse(matchCollection[i].Value);
			}
			firstLocalPlayerController.GetControlledPawn().SetActorLocation(new FVector(array[0], array[1], array[2]), bSweep: false, out var _, bTeleport: false);
			firstLocalPlayerController.SetControlRotation(new FRotator(array[4], array[5], array[3]));
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnGenError()
	{
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnGenCrash()
	{
		try
		{
			UGSE_EngineFuncLib.QAGenCrash();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnQATest()
	{
		try
		{
			(UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).GetControlledPawn() as BGUCharacterCS).SetActorLocation(new FVector(-69464.0, 63631.0, -1608.444), bSweep: false, out var _, bTeleport: true);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnQARest()
	{
		try
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).GetControlledPawn() as BGUCharacterCS);
			if (!(bUS_GSEventCollection == null))
			{
				bUS_GSEventCollection.Evt_TriggerPlayerRest?.Invoke();
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnQAGenerateSkillHud()
	{
		try
		{
			string resPath = "/Game/3rd/QATest/Helper/SkillHUD_LockVer.SkillHUD_LockVer_C";
			UGSE_UMGFuncLib.CreateUserWidget(GetThis(), resPath).AddToViewport(10000);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnQAGenerateTamer(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			TStrongObjectPtr<UClass> tStrongObjectPtr = new TStrongObjectPtr<UClass>();
			UBlueprint uBlueprint = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UBlueprint>(args[0], ELoadResourceType.SyncLoadAndCache);
			if (uBlueprint != null)
			{
				tStrongObjectPtr.Set(uBlueprint.GeneratedClass);
			}
			else
			{
				UClass uClass = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>(args[0], ELoadResourceType.SyncLoadAndCache);
				if (uClass == null)
				{
					return;
				}
				tStrongObjectPtr.Set(uClass);
			}
			FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).GetControlledPawn().GetActorLocation();
			FVector fVector = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).GetControlledPawn().GetActorRotation()
				.GetForwardVector() * 1000.0;
			FVector fVector2 = actorLocation + fVector;
			FRotator rotation = UMathLibrary.FindLookAtRotation(fVector2, actorLocation);
			BGU_UnrealWorldUtil.RequestSpawnUnit(UGSE_EngineFuncLib.GetWorldFromObj(GetThis()), tStrongObjectPtr.Get(), new FTransform(rotation, fVector2), null);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnQAStartRecordFPS()
	{
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnQAStopRecordFPS()
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnAddTraceStatInfo(IntPtr NativeArgs)
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetControlRotation(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			float result = 0f;
			float result2 = 0f;
			float result3 = 0f;
			float.TryParse(args[0], out result);
			float.TryParse(args[1], out result2);
			float.TryParse(args[2], out result3);
			UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).SetControlRotation(new FRotator(result, result2, result3));
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void MonsterTeleport(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length < 1)
			{
				return;
			}
			int.TryParse(args[0], out var result);
			GMMonsterTeleportDesc gMMonsterTeleportDesc = GameDBRuntime.GetGMMonsterTeleportDesc(result);
			if (gMMonsterTeleportDesc == null)
			{
				BGW_LogUtil.LogError($"MonsterTeleport MonsterTeleportId:{result} InValid!!!");
				return;
			}
			SGI_Global globalFSMInstanceCurState = BGW_GameLifeTimeMgr.Get(GetThis()).GlobalFSMInstanceCurState;
			switch (globalFSMInstanceCurState)
			{
			case SGI_Global.MainMenu:
				BGW_EventCollection.Get(GetThis()).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.GMLevelTravel, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
				{
					GMTravelParams = new GMTravelParams
					{
						MonsterTeleportId = result,
						GMTravelType = EGMTravelType.MonsterTeleport
					}
				});
				break;
			case SGI_Global.InBattleStandAlone:
				BGUFunctionLibraryCS.TeleportToLevelPosition(GetThis(), gMMonsterTeleportDesc.LevelId, new FVector(gMMonsterTeleportDesc.Position.PosX, gMMonsterTeleportDesc.Position.PosY, gMMonsterTeleportDesc.Position.PosZ), new FRotator(gMMonsterTeleportDesc.Rotation.PosX, gMMonsterTeleportDesc.Rotation.PosY, gMMonsterTeleportDesc.Rotation.PosZ), TravelUseDefaultPlayerStart: false, delegate
				{
					BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).GetControlledPawn())?.Evt_GMRecordRebirthPos.Invoke();
				});
				break;
			default:
				BGW_LogUtil.LogError($"MonsterTeleport ActiveGlobalFSMState:{globalFSMInstanceCurState} InValid");
				break;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTeleportToLevelPosition(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length < 1)
			{
				return;
			}
			float result = 0f;
			float result2 = 0f;
			float result3 = 0f;
			float result4 = 0f;
			float result5 = 0f;
			float result6 = 0f;
			float camPitch = 0f;
			float camYaw = 0f;
			float camRoll = 0f;
			bool travelUseDefaultPlayerStart = true;
			bool TravelUseCustomCamRotation = false;
			int.TryParse(args[0], out var result7);
			if (args.Length >= 4)
			{
				travelUseDefaultPlayerStart = false;
				float.TryParse(args[1], out result);
				float.TryParse(args[2], out result2);
				float.TryParse(args[3], out result3);
			}
			if (args.Length >= 7)
			{
				float.TryParse(args[4], out result4);
				float.TryParse(args[5], out result5);
				float.TryParse(args[6], out result6);
			}
			if (args.Length >= 10)
			{
				TravelUseCustomCamRotation = true;
				float.TryParse(args[7], out camPitch);
				float.TryParse(args[8], out camYaw);
				float.TryParse(args[9], out camRoll);
			}
			BGUFunctionLibraryCS.TeleportToLevelPosition(GetThis(), result7, new FVector(result, result2, result3), new FRotator(result4, result5, result6), travelUseDefaultPlayerStart, delegate
			{
				if (TravelUseCustomCamRotation)
				{
					UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).SetControlRotation(new FRotator(camPitch, camYaw, camRoll));
				}
			});
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTeleportToLevelPositionToPreviewSeq(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length < 1)
			{
				return;
			}
			int.TryParse(args[0], out var result);
			if (BGUFuncLibMap.IsBattleMap(GetThis()) && !ArchiveFileUtil.IsWithSeqSnapShot(result))
			{
				if (BGUFuncLibSequenceCS.GetPreviewSeqInfo(GetThis(), result, out var LevelId, out var PreviewPosition, out var PreviewRotation, out var OnleportFinish, null))
				{
					BGUFunctionLibraryCS.TeleportToLevelPosition(GetThis(), LevelId, PreviewPosition, PreviewRotation, TravelUseDefaultPlayerStart: false, OnleportFinish);
				}
			}
			else
			{
				BGW_EventCollection.Get(GetThis()).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.GMLevelTravel, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
				{
					GMTravelParams = new GMTravelParams
					{
						SeqPreviewId = result,
						GMTravelType = EGMTravelType.SeqPreview
					}
				});
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTeleportToLevelPositionByName(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 1)
			{
				float result = 0f;
				float result2 = 0f;
				float result3 = 0f;
				float result4 = 0f;
				float result5 = 0f;
				float result6 = 0f;
				bool unKnowLevelTravelUseDefaultPlayerStart = true;
				string name = args[0];
				if (args.Length >= 4)
				{
					unKnowLevelTravelUseDefaultPlayerStart = false;
					float.TryParse(args[1], out result);
					float.TryParse(args[2], out result2);
					float.TryParse(args[3], out result3);
				}
				if (args.Length >= 7)
				{
					float.TryParse(args[4], out result4);
					float.TryParse(args[5], out result5);
					float.TryParse(args[6], out result6);
				}
				FSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel.OverrideUnKnowLevelTravelPlayerStart = new FTransform(new FRotator(result4, result5, result6), new FVector(result, result2, result3));
				FSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel.UnKnowLevelTravelUseDefaultPlayerStart = unKnowLevelTravelUseDefaultPlayerStart;
				UGameplayStatics.OpenLevel(GetThis(), new FName(name));
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	private static void ActivateTalent(int TalentID, int ChangeLevel)
	{
	}

	public static void DerekPerftest(Action TestFunc, string Comment, int TestCount = 100000)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		for (int i = 0; i < TestCount; i++)
		{
			TestFunc();
		}
		stopwatch.Stop();
		BGW_LogUtil.LogError($"DerekPerftest {Comment} {stopwatch.ElapsedMilliseconds}");
	}

	public static int Fibonacci(int n)
	{
		if (n <= 1)
		{
			return n;
		}
		return Fibonacci(n - 1) + Fibonacci(n - 2);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void TestCSharpPerf(IntPtr NativeArgs)
	{
		DerekPerftest(delegate
		{
			Fibonacci(45);
		}, "Fibonacci", 1);
		DerekPerftest(delegate
		{
			string[] array = new string[7] { "Hello", "World", "This", "is", "a", "test", "string" };
			string text = "";
			for (int i = 0; i < 100; i++)
			{
				text += array[i % array.Length];
			}
		}, "string Concat", 10000);
		DerekPerftest(delegate
		{
			BGW_LogUtil.LogError("Perf Test");
		}, "Log", 10000);
		DerekPerftest(delegate
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			for (int i = 0; i < 100; i++)
			{
				dictionary.Add(i.ToString(), i);
			}
			foreach (KeyValuePair<string, int> item in dictionary)
			{
				BGW_LogUtil.LogError($"{item.Value} {item.Key}");
			}
		}, "Log And ItrDic", 1000);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnDerekTest(IntPtr NativeArgs)
	{
		BUS_EventCollectionCS.Get(UGameplayStatics.GetPlayerCharacter(GetThis(), 0));
		new BUS_TalentComp();
		DerekPerftest(delegate
		{
		}, "EventCollection.Evt_ActivateTalent");
		int j = 100;
		string str = null;
		DerekPerftest(delegate
		{
			str = $"hello {j++}";
		}, "string Concact");
		DerekPerftest(delegate
		{
		}, "nack Delegate");
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSTeleport(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (!(playerCharacter == null) && args.Length != 0)
			{
				string name = args[0];
				BPS_EventCollectionCS.GetLocal(playerCharacter).Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.TeleportNamedPoint, new TeleportParam_TeleportNamedPoint
				{
					TeleportPointName = new FName(name),
					LevelId = -1
				}, EPlayerTeleportReason.Test);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSHideActor(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			bool actorHiddenInGame = true;
			bool flag = false;
			bool flag2 = false;
			if (playerCharacter == null || args.Length == 0)
			{
				return;
			}
			if (args.Length >= 2)
			{
				if (args[1] == "1")
				{
					actorHiddenInGame = false;
				}
				else if (args[1] == "2")
				{
					flag = true;
				}
			}
			if (args.Length >= 3 && args[2] == "1")
			{
				flag2 = true;
			}
			AActor[] allActorsOfClass = playerCharacter.World.GetAllActorsOfClass<AActor>();
			foreach (AActor aActor in allActorsOfClass)
			{
				string name = aActor.GetName();
				if (flag2)
				{
					if (name.Contains(args[0]))
					{
						if (flag)
						{
							aActor.MarkPendingKill();
						}
						else
						{
							aActor.SetActorHiddenInGame(actorHiddenInGame);
						}
					}
				}
				else if (name == args[0])
				{
					if (flag)
					{
						aActor.MarkPendingKill();
					}
					else
					{
						aActor.SetActorHiddenInGame(actorHiddenInGame);
					}
					break;
				}
			}
			UObject.CollectGarbage();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSwitchLight(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (playerCharacter == null || args.Length == 0)
			{
				return;
			}
			float intensity = 10f;
			if (args.Length >= 2 && float.TryParse(args[1], out var result))
			{
				intensity = result;
			}
			ADirectionalLight[] allActorsOfClass = playerCharacter.World.GetAllActorsOfClass<ADirectionalLight>();
			foreach (ADirectionalLight aDirectionalLight in allActorsOfClass)
			{
				if (aDirectionalLight.GetName() == args[0])
				{
					aDirectionalLight.LightComponent.Intensity = intensity;
					aDirectionalLight.LightComponent.SetVisibility(bNewVisibility: true);
				}
				else
				{
					aDirectionalLight.LightComponent.Intensity = 0f;
					aDirectionalLight.LightComponent.SetVisibility(bNewVisibility: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSShowBattleUI(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (!(UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()) == null) && args.Length >= 1)
			{
				int.TryParse(args[0], out var _);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSFullHP(IntPtr NativeArgs)
	{
		try
		{
			GetArgs(NativeArgs);
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, BGUFunctionLibraryCS.BGUGetFloatAttr(aActor, EBGUAttrFloat.HpMax));
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetFabaoEnergy(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed() && float.TryParse(args[0].ToLower(), out var result))
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.FabaoEnergy, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSFullFabaoEnergy(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.FabaoEnergy, BGUFunctionLibraryCS.BGUGetFloatAttr(aActor, EBGUAttrFloat.FabaoEnergyMax));
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSFullVigorEnergy(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.VigorEnergy, BGUFunctionLibraryCS.BGUGetFloatAttr(aActor, EBGUAttrFloat.VigorEnergyMax));
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetVigorEnergy(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed() && float.TryParse(args[0].ToLower(), out var result))
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.VigorEnergy, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void TestLogin(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length > 1)
			{
				BGW_GSAutoTestUtil.GSAutoTestLogin(GetThis(), args[0], args[1]);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSFullMP(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Mp, BGUFunctionLibraryCS.BGUGetFloatAttr(aActor, EBGUAttrFloat.MpMax));
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSFullPE(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Pevalue, 999f);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnFlyMode(IntPtr NativeArgs)
	{
		try
		{
			BGU_NormalMoveMode.GMFlyMode = !BGU_NormalMoveMode.GMFlyMode;
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSLockHP(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.ImmueDamage, IsRemove: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnlockHP(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.ImmueDamage, IsRemove: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSLockMP(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.LockMP, IsRemove: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnlockMP(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.LockMP, IsRemove: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSLockEnemyHP(IntPtr NativeArgs)
	{
		try
		{
			UObject uObject = GetThis();
			IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TamerData, BGC_TamerData>(uObject);
			if (gameStateReadonlyData == null)
			{
				return;
			}
			gameStateReadonlyData.GetSpawnedMonsterList(out var OutMonsterList);
			foreach (string item in OutMonsterList)
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(BGU_DataUtil.GetActorByGuid(uObject, item), EBGUSimpleState.ImmueDamage, IsRemove: false);
			}
			BGW_EventCollection.Get(uObject)?.Evt_LockAllMonsterHP(P1: true);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnlockEnemyHP(IntPtr NativeArgs)
	{
		try
		{
			UObject uObject = GetThis();
			IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TamerData, BGC_TamerData>(uObject);
			if (gameStateReadonlyData == null)
			{
				return;
			}
			gameStateReadonlyData.GetSpawnedMonsterList(out var OutMonsterList);
			foreach (string item in OutMonsterList)
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(BGU_DataUtil.GetActorByGuid(uObject, item), EBGUSimpleState.ImmueDamage, IsRemove: true);
			}
			BGW_EventCollection.Get(uObject)?.Evt_LockAllMonsterHP(P1: false);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnEnableDrawSkillArea(IntPtr NativeArgs)
	{
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			ABGUCharacter aBGUCharacter = playerCharacter as ABGUCharacter;
			if (!(playerCharacter == null) && !(aBGUCharacter == null))
			{
				BUS_EventCollectionCS.Get(playerCharacter).Evt_EnableDrawSkillArea.Invoke(P1: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnDisableDrawSkillArea(IntPtr NativeArgs)
	{
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			ABGUCharacter aBGUCharacter = playerCharacter as ABGUCharacter;
			if (!(playerCharacter == null) && !(aBGUCharacter == null))
			{
				BUS_EventCollectionCS.Get(playerCharacter).Evt_EnableDrawSkillArea.Invoke(P1: false);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnShowSweepCheckShape(IntPtr NativeArgs)
	{
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			ABGUCharacter aBGUCharacter = playerCharacter as ABGUCharacter;
			if (!(playerCharacter == null) && !(aBGUCharacter == null))
			{
				BUS_EventCollectionCS.Get(playerCharacter).Evt_ShowSweepCheckShape.Invoke();
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSLockStamina(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.StaminaLock, IsRemove: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnLockStamina(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.StaminaLock, IsRemove: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSLockPE(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.PELock, IsRemove: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnLockPE(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.PELock, IsRemove: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSLockTransEnergy(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.TransEnergyLock, IsRemove: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnLockTransEnergy(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.TransEnergyLock, IsRemove: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSLockFaBaoEnergy(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.FabaoEnergyLock, IsRemove: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnLockFaBaoEnergy(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.FabaoEnergyLock, IsRemove: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSLockVigorEnergy(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.VigorEnergyLock, IsRemove: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnLockVigorEnergy(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.VigorEnergyLock, IsRemove: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSInvincible(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.ImmueDamage, IsRemove: false);
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.ImmueStiff, IsRemove: false);
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.ImmueImmobilizing, IsRemove: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void DelAllArchived(IntPtr NativeArgs)
	{
		try
		{
			BGW_GameArchiveMgr.Get(GetThis()).GMClearAllArchive("Console Command:DelAllArchived");
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void FullTransEnergy(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0 && int.TryParse(args[0].ToLower(), out var result))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).GetControlledPawn());
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_GMSetFullEnergy.Invoke(result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void IncreaseSpecialEnergy(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				ABGUCharacter actor = null;
				if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
				{
					actor = Player as ABGUCharacter;
				}
				if (int.TryParse(args[0].ToLower(), out var result))
				{
					BUS_EventCollectionCS.Get(actor).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.SpecialEnergy, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void ShowSpecialEnergy(IntPtr NativeArgs)
	{
		try
		{
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (aBGUCharacter != null)
			{
				BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(aBGUCharacter);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void ManualCSharpGC(IntPtr NativeArgs)
	{
		try
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void CommandletTest(IntPtr NativeArgs)
	{
		try
		{
			try
			{
				b1.SpawnActorCommandlet spawnActorCommandlet = new b1.SpawnActorCommandlet();
				BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player);
				spawnActorCommandlet.DoProces("/Game/3rd/MiggeTest/map_migge_test.map_migge_test", Player.World);
			}
			catch (Exception arg)
			{
				BGW_LogUtil.LogDbgMigge($"ExportBattleData Failed ! \n {arg}");
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void TeleportToTrace(IntPtr NativeArgs)
	{
		try
		{
			AGameStateBase gameState = UGameplayStatics.GetGameState(GetThis());
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			using List<BossTraceInfo>.Enumerator enumerator = BGU_DataUtil.GetReadOnlyData<BGC_BossTraceData>(gameState).GetBossTraceList().GetEnumerator();
			if (enumerator.MoveNext())
			{
				BossTraceInfo current = enumerator.Current;
				BUS_EventCollectionCS.Get(playerCharacter)?.Evt_SetActorLocationAndRotation.Invoke(current.TraceCenterPoint.GetActorLocation(), current.TraceCenterPoint.GetActorRotation(), bSweep: false, bTeleport: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void UIPlayStory(IntPtr NativeArgs)
	{
		try
		{
			int result = 1;
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				int.TryParse(args[0].ToLower(), out result);
			}
			BGW_UIMgr.Get(GetThis())?.PlaySubtitle("测试名字", "测试字幕测试字幕测试字幕测试字幕", result);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void ShouldShowMouse(IntPtr NativeArgs)
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void GameLevelPass(IntPtr NativeArgs)
	{
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (playerCharacter != null)
			{
				BGW_EventCollection.Get(playerCharacter).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.GameLevelPass);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void EnterNextGame(IntPtr NativeArgs)
	{
		try
		{
			int result = 1;
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				int.TryParse(args[0].ToLower(), out result);
			}
			UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (GetThis() != null)
			{
				BGW_EventCollection.Get(GetThis()).Evt_ReStartByArchiveId(result);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void SwitchChan(IntPtr NativeArgs)
	{
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (playerCharacter != null)
			{
				BUS_EventCollectionCS.Get(playerCharacter)?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(10511, ECastSkillSourceType.GM));
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void DreamTeleport(IntPtr NativeArgs)
	{
		try
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetThis());
			FDreamTeleportInfo dreamTeleportInfo = new FDreamTeleportInfo
			{
				bTeleportToOtherLevel = true,
				TargetLevelID = 103
			};
			bGW_EventCollection.Evt_RequestDreamTeleport(dreamTeleportInfo);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnBeginSaveArchived(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			int result;
			if (args.Length == 0)
			{
				UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
				BGW_GameArchiveMgr.Get(GetThis())?.MarkSaveArchive(EArchiveSaveSource.Console);
			}
			else if (int.TryParse(args[0].ToLower(), out result))
			{
				BGW_GameArchiveMgr.Get(GetThis()).CreateNewArchive(CreateArchiveSource.GM);
				BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGameplayStatics.GetPlayerController(GetThis(), 0));
				BGW_EventCollection.Get(GetThis());
				BGW_GameArchiveMgr.Get(GetThis())?.MarkSaveArchive(EArchiveSaveSource.Console);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	public static void SaveShareArchiveFile(ShareArchiveFileUnpacked SharedArchive)
	{
		ShareArchiveFile shareArchiveFile = BGW_GameArchiveMgr.PackShareArchiveFile(SharedArchive.SharedRoleData, BGW_GameArchiveMgr.Get(GetThis()).SharedArchiveUid);
		BGW_GameArchiveMgr.Get(GetThis())?.WriteSharedArchiveFileOnly(shareArchiveFile);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnAllMuseum(IntPtr NativeArgs)
	{
		try
		{
			ShareArchiveFileUnpacked shareArchiveFileUnpacked = BGW_GameArchiveMgr.Get(GetThis())?.LoadShareDataOnly();
			RoleMuseum roleMuseum = shareArchiveFileUnpacked.SharedRoleData;
			if (roleMuseum == null)
			{
				roleMuseum = new RoleMuseum();
			}
			if (roleMuseum.RedPoint == null)
			{
				roleMuseum.RedPoint = new MuseumRedPoint();
			}
			foreach (MuseumMVDesc item in GameDBRuntime.GetTBMuseumMVDesc().List)
			{
				roleMuseum.MvIdList.Add(item.Id);
				roleMuseum.RedPoint.MvRedpoint.Add(item.Id);
			}
			SaveShareArchiveFile(shareArchiveFileUnpacked);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnAddArtbook(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !int.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			if (GameDBRuntime.GetArtBookDesc(result) != null)
			{
				ShareArchiveFileUnpacked shareArchiveFileUnpacked = BGW_GameArchiveMgr.Get(GetThis())?.LoadShareDataOnly();
				if (shareArchiveFileUnpacked.SharedRoleData == null)
				{
					shareArchiveFileUnpacked.SharedRoleData = new RoleMuseum();
				}
				if (shareArchiveFileUnpacked.SharedRoleData.RedPoint == null)
				{
					shareArchiveFileUnpacked.SharedRoleData.RedPoint = new MuseumRedPoint();
				}
				SaveShareArchiveFile(shareArchiveFileUnpacked);
			}
			else
			{
				BGW_LogUtil.LogError($"GetArtBookDesc Failed Id:{result}");
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnAddMuseumMv(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !int.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			if (GameDBRuntime.GetMuseumMVDesc(result) != null)
			{
				ShareArchiveFileUnpacked shareArchiveFileUnpacked = BGW_GameArchiveMgr.Get(GetThis())?.LoadShareDataOnly();
				if (shareArchiveFileUnpacked.SharedRoleData == null)
				{
					shareArchiveFileUnpacked.SharedRoleData = new RoleMuseum();
				}
				if (shareArchiveFileUnpacked.SharedRoleData.RedPoint == null)
				{
					shareArchiveFileUnpacked.SharedRoleData.RedPoint = new MuseumRedPoint();
				}
				if (!shareArchiveFileUnpacked.SharedRoleData.MvIdList.Contains(result))
				{
					shareArchiveFileUnpacked.SharedRoleData.MvIdList.Add(result);
					shareArchiveFileUnpacked.SharedRoleData.RedPoint.MvRedpoint.Add(result);
					SaveShareArchiveFile(shareArchiveFileUnpacked);
				}
			}
			else
			{
				BGW_LogUtil.LogError($"GetMuseumMVDesc Failed Id:{result}");
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSwitchInputDisplay(IntPtr NativeArgs)
	{
		try
		{
			BGW_UIEventCollection.Get(GetThis())?.Evt_UI_SwitchInputDisplay(B1: true);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnActiveAllRebirthPoint(IntPtr NativeArgs)
	{
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			foreach (FUStRebirthPointDesc value in BGW_GameDB.GetAllRebirthPointDesc().Values)
			{
				LevelDesc levelDesc = GameDBRuntime.GetLevelDesc(value.GroupMapID);
				if (levelDesc != null && levelDesc.RebirthSortId >= 1)
				{
					BPS_EventCollectionCS.GetLocal(playerCharacter).Evt_ActiveRebirthPoint.Invoke(value.ID, P2: true);
				}
			}
			foreach (BGURebirthPointBase allActorsOfClass in playerCharacter.World.GetAllActorsOfClassList<BGURebirthPointBase>())
			{
				BUS_EventCollectionCS.Get(allActorsOfClass).Evt_InteractRebirthPoint.Invoke(playerCharacter);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTeleToRebirthPoint(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0 && int.TryParse(args[0].ToLower(), out var result))
			{
				BPS_EventCollectionCS.GetLocal(UGameplayStatics.GetPlayerCharacter(GetThis(), 0)).Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.RebirthPointTeleportOnly, new TeleportParam_RebirthPoint
				{
					RebirthPointId = result
				}, EPlayerTeleportReason.Test);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnDestroyAllNiagara(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			AActor[] array = null;
			if (args.Length >= 1)
			{
				array = ((args[0] == "1") ? UGameplayStatics.GetAllActorsOfClass(playerCharacter, UClass.GetClass<ANiagaraActor>()) : ((!(args[0] == "2")) ? UGameplayStatics.GetAllActorsOfClass(playerCharacter, UClass.GetClass<AActor>()) : UGameplayStatics.GetAllActorsOfClass(playerCharacter, UClass.GetClass<BGUFXActorBase>())));
			}
			TSubclassOf<UActorComponent> componentClass = UClass.GetClass<UNiagaraComponent>();
			AActor[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				foreach (UActorComponent item in array2[i].GetComponentsByClass(componentClass))
				{
					UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
					if (!(uNiagaraComponent == null))
					{
						UGSE_NiagaraFuncLib.ForceDestroyNiagaraComponent(uNiagaraComponent);
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnInvincible(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.ImmueDamage, IsRemove: true);
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.ImmueStiff, IsRemove: true);
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.ImmueImmobilizing, IsRemove: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSTryCastSkill(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length > 1)
			{
				string unitGuid = args[0];
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetThis(), unitGuid);
				if (!(actorByGuid == null) && int.TryParse(args[1], out var result))
				{
					BGUFunctionLibraryCS.BGUTryCastSpell(actorByGuid, result, ECastSkillSourceType.GM);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSAddBuff(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			if (float.TryParse(args[0].ToLower(), out var result))
			{
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
				foreach (AActor aActor in allActorsOfClass)
				{
					if (!aActor.IsNullOrDestroyed())
					{
						float result2 = 0f;
						if (args.Length > 1)
						{
							float.TryParse(args[1].ToLower(), out result2);
						}
						BGUFunctionLibraryCS.BGUAddBuff(aActor, aActor, (int)result, EBuffSourceType.GM, result2);
					}
				}
			}
			else
			{
				UGSE_EngineFuncLib.LogDbg("Command input error!", bPrintScreen: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSRemoveBuff(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			if (float.TryParse(args[0].ToLower(), out var result))
			{
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
				foreach (AActor aActor in allActorsOfClass)
				{
					if (!aActor.IsNullOrDestroyed())
					{
						BGUFunctionLibraryCS.BGURemoveBuffImmediately(aActor, (int)result, EBuffEffectTriggerType.None);
					}
				}
			}
			else
			{
				UGSE_EngineFuncLib.LogDbg("Command input error!", bPrintScreen: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSAddBuff2Monster(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 2)
			{
				string unitGuid = args[0];
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetThis(), unitGuid);
				if (!(actorByGuid == null) && float.TryParse(args[1].ToLower(), out var result))
				{
					BGUFunctionLibraryCS.BGUAddBuff(actorByGuid, actorByGuid, (int)result, EBuffSourceType.GM);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSRemoveBuff2Monster(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 2)
			{
				string unitGuid = args[0];
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetThis(), unitGuid);
				if (!(actorByGuid == null) && float.TryParse(args[1].ToLower(), out var result))
				{
					BGUFunctionLibraryCS.BGURemoveBuffImmediately(actorByGuid, (int)result, EBuffEffectTriggerType.None);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSKillMonster(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 1)
			{
				string unitGuid = args[0];
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetThis(), unitGuid);
				if (!(actorByGuid == null))
				{
					BUS_EventCollectionCS.Get(actorByGuid).Evt_UnitDead.Invoke(actorByGuid, EDeadReason.SkillDamage);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSRemoveAllBuff(IntPtr NativeArgs)
	{
		try
		{
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (!(Player == null) && !(aBGUCharacter == null))
			{
				BGUFunctionLibraryCS.BGURemoveAllBuff(aBGUCharacter, EBuffEffectTriggerType.None);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSChangeGlobalSpd(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (!(Player == null) && !(aBGUCharacter == null))
			{
				float result = 1f;
				if (float.TryParse(args[0].ToLower(), out result))
				{
					UGameplayStatics.SetGlobalTimeDilation(aBGUCharacter, result);
				}
				else
				{
					UGSE_EngineFuncLib.LogDbg("Command input error!", bPrintScreen: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSChangeCharacterSpd(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			float result = 1f;
			if (float.TryParse(args[0].ToLower(), out result))
			{
				AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
				foreach (AActor aActor in allActorsOfClass)
				{
					if (!aActor.IsNullOrDestroyed())
					{
						BUS_EventCollectionCS.Get(aActor).Evt_SetGMCustomTimeDilation.Invoke(result);
					}
				}
			}
			else
			{
				UGSE_EngineFuncLib.LogDbg("Command input error!", bPrintScreen: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSChangeEnemySpd(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (Player == null || aBGUCharacter == null)
			{
				return;
			}
			float result = 1f;
			if (float.TryParse(args[0].ToLower(), out result))
			{
				ABGUCharacter[] allActorsOfClass = Player.World.GetAllActorsOfClass<ABGUCharacter>();
				foreach (ABGUCharacter aBGUCharacter2 in allActorsOfClass)
				{
					if (aBGUCharacter2 != aBGUCharacter)
					{
						BUS_EventCollectionCS.Get(aBGUCharacter2).Evt_SetGMCustomTimeDilation.Invoke(result);
					}
				}
			}
			else
			{
				UGSE_EngineFuncLib.LogDbg("Command input error!", bPrintScreen: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetMaxHP(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				ABGUCharacter aBGUCharacter = null;
				if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
				{
					aBGUCharacter = Player as ABGUCharacter;
				}
				if (!(Player == null) && !(aBGUCharacter == null) && float.TryParse(args[0].ToLower(), out var result))
				{
					BUS_EventCollectionCS.Get(aBGUCharacter).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.HpMaxBase, result);
					BUS_EventCollectionCS.Get(aBGUCharacter).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Hp, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSChangeHP(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				ABGUCharacter aBGUCharacter = null;
				if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
				{
					aBGUCharacter = Player as ABGUCharacter;
				}
				if (!(Player == null) && !(aBGUCharacter == null) && float.TryParse(args[0].ToLower(), out var result))
				{
					BUS_EventCollectionCS.Get(aBGUCharacter).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Hp, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSChangeMP(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				ABGUCharacter aBGUCharacter = null;
				if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
				{
					aBGUCharacter = Player as ABGUCharacter;
				}
				if (!(Player == null) && !(aBGUCharacter == null) && float.TryParse(args[0].ToLower(), out var result))
				{
					BUS_EventCollectionCS.Get(aBGUCharacter).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Mp, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetMaxMP(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !float.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.MpMaxBase, result);
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Mp, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetAttack(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !float.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.AtkBase, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetSpecialEnergy(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !float.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.SpecialEnergy, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetBloodBottle(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !float.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			int num = (int)result;
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.BloodBottomNumMaxBase, num);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSFullBloodBottle(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					float newValue = BGUFunctionLibraryCS.BGUGetFloatAttr(aActor, EBGUAttrFloat.BloodBottomNumMax);
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.BloodBottomNum, newValue);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetStaminaMax(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !float.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
					bUS_GSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.StaminaMaxBase, result);
					bUS_GSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Stamina, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetPE(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !float.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Pevalue, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetTransEnergy(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !float.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.TransEnergyMaxBase, result);
					BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.CurEnergy, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSChangeCamArmMode(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (Player == null || aBGUCharacter == null || !float.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			int num = (int)result;
			if (num <= 4 && num >= 0)
			{
				EDefaultCamArmMode camArmMode = (EDefaultCamArmMode)num;
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aBGUCharacter);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_SetCameraArmMode.Invoke(camArmMode);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSChangeLockCamArmMode(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (Player == null || aBGUCharacter == null || !float.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			int num = (int)result;
			if (num <= 4 && num >= 0)
			{
				EDefaultCamArmMode camArmMode = (EDefaultCamArmMode)num;
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aBGUCharacter);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_SetLockCameraArmMode.Invoke(camArmMode);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSCancelSkillCD(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			int result;
			if (args.Length == 0)
			{
				result = 1;
			}
			else
			{
				int.TryParse(args[0].ToLower(), out result);
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed() && BGUFunctionLibraryCS.BGUHasUnitSimpleState(aActor, EBGUSimpleState.CancelSkillCD) != result > 0)
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.CancelSkillCD, result <= 0);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSCancelLifeSavingHairDC(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			int result;
			if (args.Length == 0)
			{
				result = 1;
			}
			else
			{
				int.TryParse(args[0].ToLower(), out result);
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed() && BGUFunctionLibraryCS.BGUHasUnitSimpleState(aActor, EBGUSimpleState.CancelLifeSavingCD) != result > 0)
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(aActor, EBGUSimpleState.CancelLifeSavingCD, result <= 0);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSCancelEnemySkillCD(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			bool result = false;
			if (args.Length != 0)
			{
				bool.TryParse(args[0].ToLower(), out result);
			}
			UObject uObject = GetThis();
			IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TamerData, BGC_TamerData>(uObject);
			if (gameStateReadonlyData == null)
			{
				return;
			}
			gameStateReadonlyData.GetSpawnedMonsterList(out var OutMonsterList);
			foreach (string item in OutMonsterList)
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(uObject, item);
				if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(actorByGuid, EBGUSimpleState.CancelSkillCD) && result)
				{
					return;
				}
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(actorByGuid, EBGUSimpleState.CancelSkillCD, !result);
			}
			BGW_EventCollection.Get(uObject)?.Evt_CancelAllMonsterSkillCD(result);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSKillAllEnemy(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			float result = 0f;
			if (args.Length != 0)
			{
				float.TryParse(args[0].ToLower(), out result);
			}
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (Player == null || aBGUCharacter == null)
			{
				return;
			}
			ABGUCharacter[] allActorsOfClass = Player.World.GetAllActorsOfClass<ABGUCharacter>();
			if (allActorsOfClass.Length < 1)
			{
				return;
			}
			ABGUCharacter[] array = allActorsOfClass;
			foreach (ABGUCharacter aBGUCharacter2 in array)
			{
				if (BGUFunctionLibraryCS.BGUIsEnemyTeam(aBGUCharacter, aBGUCharacter2) && (!(result > 0f) || !(result < FVector.Distance(aBGUCharacter2.GetActorLocation(), aBGUCharacter.GetActorLocation()))))
				{
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aBGUCharacter2);
					if (bUS_GSEventCollection != null)
					{
						bUS_GSEventCollection.Evt_UnitDead.Invoke(aBGUCharacter, EDeadReason.SkillDamage);
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnKillEnemyByResId(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			int result = 0;
			if (args.Length != 0)
			{
				int.TryParse(args[0].ToLower(), out result);
			}
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (Player == null || aBGUCharacter == null)
			{
				return;
			}
			ABGUCharacter[] allActorsOfClass = Player.World.GetAllActorsOfClass<ABGUCharacter>();
			if (allActorsOfClass.Length < 1)
			{
				return;
			}
			ABGUCharacter[] array = allActorsOfClass;
			foreach (ABGUCharacter aBGUCharacter2 in array)
			{
				if (BGUFunctionLibraryCS.BGUIsEnemyTeam(aBGUCharacter, aBGUCharacter2) && BGU_DataUtil.GetActorResID(aBGUCharacter2) == result)
				{
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aBGUCharacter2);
					if (bUS_GSEventCollection != null)
					{
						bUS_GSEventCollection.Evt_UnitDead.Invoke(aBGUCharacter, EDeadReason.SkillDamage);
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSToggleAllEnemyAI(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			bool result = false;
			if (args.Length != 0)
			{
				bool.TryParse(args[0].ToLower(), out result);
			}
			UObject uObject = GetThis();
			IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_TamerData, BGC_TamerData>(uObject);
			if (gameStateReadonlyData == null)
			{
				return;
			}
			gameStateReadonlyData.GetSpawnedMonsterList(out var OutMonsterList);
			foreach (string item in OutMonsterList)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(uObject, item));
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_AIPauseBT.Invoke(result);
				}
			}
			BGW_EventCollection.Get(uObject)?.Evt_PauseAllMonsterAI(result);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSInvisible(IntPtr NativeArgs)
	{
		try
		{
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (!(Player == null) && !(aBGUCharacter == null))
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aBGUCharacter, EBGUSimpleState.Imperceptible, IsRemove: false);
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aBGUCharacter, EBGUSimpleState.CantBeBaseTarget, IsRemove: false);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnGameConnect()
	{
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnGameSend()
	{
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnViewportCaptureMouse()
	{
		try
		{
			UGSE_EngineFuncLib.CaptureCurrentViewport(bCapture: true);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnLoadAllStreamingLevels()
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
		List<ULevelStreaming> list = UBGWFunctionLibrary.BGWGetAllStreamingLevels(playerCharacter.World);
		for (int i = 0; i < list.Count; i++)
		{
			string levelStreamingAssetName = UBGWFunctionLibrary.GetLevelStreamingAssetName(list[i]);
			UBGUFunctionLibrary.BGULoadStreamLevel(playerCharacter.World, new FName(levelStreamingAssetName), bMakeVisibleAfterLoad: true, bShouldBlockOnLoad: true, playerCharacter.World, B1GlobalFNames.OnStreamingLevelShown, i + 100);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetReportMergeLimit(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length >= 1)
		{
			int result = 0;
			if (int.TryParse(args[0], out result))
			{
				GSSDKReport.SetTrackEventBatchMergeLimit(result);
				return;
			}
		}
		GSSDKReport.SetTrackEventBatchMergeLimit(0);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void SetQualityLevel(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length >= 1)
		{
			int result = 0;
			if (int.TryParse(args[0], out result))
			{
				EScalabilityQuality eScalabilityQuality = (EScalabilityQuality)result;
				UGSE_SystemSettingsFuncLib.SetResolutionQualityScale(UGSE_SystemSettingsFuncLib.GetResolutionScaleFromQualityLevel(eScalabilityQuality));
				UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
				gameUserSettings.SetViewDistanceQuality((int)(eScalabilityQuality - 1));
				gameUserSettings.SetAntiAliasingQuality((int)(eScalabilityQuality - 1));
				gameUserSettings.SetPostProcessingQuality((int)(eScalabilityQuality - 1));
				gameUserSettings.SetShadowQuality((int)(eScalabilityQuality - 1));
				gameUserSettings.SetTextureQuality((int)(eScalabilityQuality - 1));
				gameUserSettings.SetVisualEffectQuality((int)(eScalabilityQuality - 1));
				gameUserSettings.SetShadingQuality((int)(eScalabilityQuality - 1));
				gameUserSettings.SetFoliageQuality((int)(eScalabilityQuality - 1));
				gameUserSettings.SetGlobalIlluminationQuality((int)(eScalabilityQuality - 1));
				gameUserSettings.SetReflectionQuality((int)(eScalabilityQuality - 1));
				UGSE_GSGameSettingsFuncLib.ApplyGSGameSettings(bSaveSettings: true);
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnECSThreadTickCount(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 1 && int.TryParse(args[0], out var result))
			{
				BGW_ECSWorld.ThreadCount = result;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnEnableBeginPlayProfiler(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 1)
			{
				if (args[0] == "0")
				{
					GSE_ProfileUtil.sOpenProfileBeginPlay = false;
				}
				else
				{
					GSE_ProfileUtil.sOpenProfileBeginPlay = true;
				}
			}
			else
			{
				GSE_ProfileUtil.sOpenProfileBeginPlay = !GSE_ProfileUtil.sOpenProfileBeginPlay;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnResolveMemreportObjectRef(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 2)
			{
				BGU_ObjMemUtil.ResolveMemreportObjReference(args[0], args[1]);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPrintRefChain(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				string text = UGSE_EngineFuncLib.FindAndPrintStaleRefsByObjectPath(args[0]);
				UGSE_EngineFuncLib.LogWLevel("[ET] " + text, 4);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnEnableProfiler(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 1)
			{
				if (args[0] == "0")
				{
					GSE_ProfileUtil.sOpenProfiler = false;
				}
				else
				{
					GSE_ProfileUtil.sOpenProfiler = true;
				}
			}
			else
			{
				GSE_ProfileUtil.sOpenProfiler = !GSE_ProfileUtil.sOpenProfiler;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGM(IntPtr NativeArgs)
	{
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			ABGUCharacter aBGUCharacter = playerCharacter as ABGUCharacter;
			if (!(playerCharacter == null) && !(aBGUCharacter == null))
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aBGUCharacter, EBGUSimpleState.ImmueDamage, IsRemove: false);
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aBGUCharacter, EBGUSimpleState.StaminaLock, IsRemove: false);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGMOut(IntPtr NativeArgs)
	{
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			ABGUCharacter aBGUCharacter = playerCharacter as ABGUCharacter;
			if (!(playerCharacter == null) && !(aBGUCharacter == null))
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aBGUCharacter, EBGUSimpleState.ImmueDamage, IsRemove: true);
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aBGUCharacter, EBGUSimpleState.StaminaLock, IsRemove: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGCTest(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 1)
			{
				if (args[0] == "1")
				{
					UObject.CollectGarbage();
				}
				else if (args[0] == "2")
				{
					GC.Collect(int.Parse(args[1]), (GCCollectionMode)int.Parse(args[2]));
				}
				else if (args[0] == "3")
				{
					GCHelper.GetObjectTypeCounterList(PrintLog: true);
				}
				else if (args[0] == "4")
				{
					GS_GCHelper.Instance.Enable = !GS_GCHelper.Instance.Enable;
				}
				else if (args[0] == "5")
				{
					UObject.CollectGarbage();
					GC.Collect();
					UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
					UObject.CollectGarbage();
					GC.Collect();
					UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
				}
				else if (args[0] == "6")
				{
					UGameUserSettings.GetGameUserSettings().EnableHDRDisplayOutput(bEnable: true);
				}
				else if (args[0] == "7")
				{
					UGameUserSettings.GetGameUserSettings().EnableHDRDisplayOutput(bEnable: false);
				}
				else if (args[0] == "8")
				{
					BGW_GCMgr.GC_INTERVAL = float.Parse(args[1]);
					BGW_GCMgr.GC_FORCE_INTERVAL = float.Parse(args[2]);
				}
				else if (args[0] == "9")
				{
					BGS_SimpleOverlapMgrSystem.UseThread = !BGS_SimpleOverlapMgrSystem.UseThread;
				}
				else if (args[0] == "10")
				{
					GS_GCHelper.Instance.VerboseLog = !GS_GCHelper.Instance.VerboseLog;
				}
				else if (args[0] == "11")
				{
					GS_GCHelper.Instance.KillAllField = !GS_GCHelper.Instance.KillAllField;
				}
				else if (args[0] == "12")
				{
					StrongPtrGCCollector.EnableSetNull = !StrongPtrGCCollector.EnableSetNull;
				}
				else if (args[0] == "13")
				{
					StrongPtrGCCollector.EnableCollector = !StrongPtrGCCollector.EnableCollector;
				}
				else if (args[0] == "14")
				{
					StrongPtrGCCollector.ForceInGameThread = !StrongPtrGCCollector.ForceInGameThread;
				}
				else if (args[0] == "15")
				{
					int num = int.Parse(args[1]);
					FTransform identity = FTransform.Identity;
					FTransform identity2 = FTransform.Identity;
					_ = FTransform.Identity;
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					for (int i = 0; i < num; i++)
					{
						_ = identity * identity2;
					}
					stopwatch.Stop();
				}
				else if (args[0] == "16")
				{
					int count = int.Parse(args[1]);
					Stopwatch stopwatch2 = new Stopwatch();
					stopwatch2.Start();
					UGSE_EngineFuncLib.PerfTest(1, count);
					stopwatch2.Stop();
				}
				else if (args[0] == "17")
				{
					int count2 = int.Parse(args[1]);
					Stopwatch stopwatch3 = new Stopwatch();
					stopwatch3.Start();
					UGSE_EngineFuncLib.PerfTest(2, count2);
					stopwatch3.Stop();
				}
			}
			else
			{
				GC.Collect();
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private unsafe static void OnCrashTest(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length >= 2)
		{
			try
			{
				if (args[0] == "0")
				{
					int* ptr = null;
					*ptr = 1;
				}
				else if (args[0] == "1")
				{
					((object)null).GetHashCode();
				}
				return;
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
				return;
			}
		}
		int* ptr2 = null;
		*ptr2 = 1;
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPausePsoBatching(IntPtr NativeArgs)
	{
		try
		{
			UGSE_EngineFuncLib.PausePsoBatching();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnResumePsoBatching(IntPtr NativeArgs)
	{
		try
		{
			UGSE_EngineFuncLib.ResumePsoBatching();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPrintRemainingPsoNum(IntPtr NativeArgs)
	{
		try
		{
			UGSE_EngineFuncLib.GetRemainingPsoPrecompileNum();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSUnInvisible(IntPtr NativeArgs)
	{
		try
		{
			ABGUCharacter aBGUCharacter = null;
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				aBGUCharacter = Player as ABGUCharacter;
			}
			if (!(Player == null) && !(aBGUCharacter == null))
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aBGUCharacter, EBGUSimpleState.Imperceptible, IsRemove: true);
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aBGUCharacter, EBGUSimpleState.CantBeBaseTarget, IsRemove: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnUnloadLevel(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (!(UGameplayStatics.GetPlayerCharacter(GetThis(), 0) == null) && args.Length != 0)
			{
				string name = args[0].ToLower();
				UGameplayStatics.UnloadStreamLevel(GetThis(), new FName(name), default(FLatentActionInfo), bShouldBlockOnUnload: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnLoadObjectTest(IntPtr NativeArgs)
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnReturnToPosition(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 3)
			{
				ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
				if (!(playerCharacter == null))
				{
					float result = 0f;
					float result2 = 0f;
					float result3 = 0f;
					float.TryParse(args[0], out result);
					float.TryParse(args[1], out result2);
					float.TryParse(args[2], out result3);
					FVector newLocation = new FVector(result, result2, result3);
					BGUFuncLibActorTransformCS.BGUSetActorLocation(playerCharacter, newLocation, bSweep: false, bTeleport: true, out var _);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetFOV(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (playerCharacter == null || args.Length == 0)
			{
				return;
			}
			float result = 0f;
			if (float.TryParse(args[0], out result))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(playerCharacter);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_EnableCustomFOV.Invoke(P1: true);
				}
				playerCharacter.GetComponentByClass<UCameraComponent>().FieldOfView = result;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetPlayerCameraTableParam(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (!(playerCharacter == null) && args.Length >= 2 && Enum.TryParse<EPlayerCameraTableParamType>(args[0], out var result) && float.TryParse(args[1], out var result2))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(playerCharacter);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_SetPlayerCameraParam.Invoke(result, result2);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetStraightCameraTableParam(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (!(playerCharacter == null) && args.Length >= 2 && Enum.TryParse<EStraightCameraTableParamType>(args[0], out var result) && float.TryParse(args[1], out var result2))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(playerCharacter);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_SetStraightCameraParam.Invoke(result, result2);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetDiagonalCameraTableParam(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (!(playerCharacter == null) && args.Length >= 2 && Enum.TryParse<EDiagonalCameraTableParamType>(args[0], out var result) && float.TryParse(args[1], out var result2))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(playerCharacter);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_SetDiagonalCameraParam.Invoke(result, result2);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetGiantCameraTableParam(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (!(playerCharacter == null) && args.Length >= 2 && Enum.TryParse<EGiantCameraTableParamType>(args[0], out var result) && float.TryParse(args[1], out var result2))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(playerCharacter);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_SetGiantCameraParam.Invoke(result, result2);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetCamPitch(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (playerCharacter == null || args.Length == 0)
			{
				return;
			}
			float result = 0f;
			if (float.TryParse(args[0], out result))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(playerCharacter);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_EnableCustomCamPitch.Invoke(P1: true, result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void SetMaxCamLockTargetDistance(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (playerCharacter == null || args.Length == 0)
			{
				return;
			}
			float result = 0f;
			if (float.TryParse(args[0], out result))
			{
				IBUC_PlayerInputConfigData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>(playerCharacter);
				if (unPersistentReadOnlyData != null)
				{
					FGSCameraAutoLockSetting gSCameraAutoLockSetting = unPersistentReadOnlyData.GSCameraAutoLockSetting;
					gSCameraAutoLockSetting.MaxCamLockTargetDistance = result;
					unPersistentReadOnlyData.GSCameraAutoLockSetting = gSCameraAutoLockSetting;
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetTargetArmLength(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (playerCharacter == null || args.Length == 0)
			{
				return;
			}
			float result = 0f;
			if (float.TryParse(args[0], out result))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(playerCharacter);
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_SetCameraArmMode.Invoke(EDefaultCamArmMode.Free);
					bUS_GSEventCollection.Evt_ForceSetFreeCameraArmLength.Invoke(result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPrintLighting(IntPtr NativeArgs)
	{
		try
		{
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (!(playerCharacter == null))
			{
				b1.PostProcessDebugger.PrintAll(playerCharacter.World);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSpawnCharacterByResID(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			int result = 0;
			if (int.TryParse(args[0], out result))
			{
				APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis()).GetControlledPawn();
				FUStSummonCommDesc originalSummonCommDesc = BGW_GameDB.GetOriginalSummonCommDesc(result);
				TSubclassOf<ACharacter> tSubclassOf = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>(originalSummonCommDesc.SummonBPTemplatePath, ELoadResourceType.SyncLoadAndCache);
				FVector Location = BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn) + new FVector(100.0, 0.0, 0.0);
				FRotator Rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(controlledPawn);
				BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(controlledPawn.World, tSubclassOf.Value, in Location, in Rotation);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnCloseOptimizeTick(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 1 && args.Length >= 1)
			{
				DebugConfig.CanOptimizeTick = int.Parse(args[0]) > 0;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void RefreshGameDB(IntPtr NativeArgs)
	{
		try
		{
			BGUFunctionLibraryCS.RefreshGameDB();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnChangeInputMode(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length < 1 || args.Length < 1)
			{
				return;
			}
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis());
			if (!(firstLocalPlayerController == null))
			{
				firstLocalPlayerController.ShowMouseCursor = true;
				switch (int.Parse(args[0]))
				{
				case 0:
					UWidgetLibrary.SetInputMode_GameAndUIEx(firstLocalPlayerController, null, EMouseLockMode.LockAlways, bHideCursorDuringCapture: true);
					break;
				case 1:
					UWidgetLibrary.SetInputMode_GameOnly(firstLocalPlayerController);
					break;
				case 2:
					UWidgetLibrary.SetInputMode_UIOnlyEx(firstLocalPlayerController, null, EMouseLockMode.LockAlways);
					break;
				case 3:
					firstLocalPlayerController.ShowMouseCursor = false;
					break;
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnDebugInfo(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length < 1)
			{
				return;
			}
			bool flag = true;
			if (args.Length >= 2)
			{
				flag = int.Parse(args[1]) > 0;
			}
			if (args[0] == "hatrednpcinfo")
			{
				string[] files = Directory.GetFiles(FPaths.Combine(FPaths.ProjectPersistentDownloadDir, "Hatred"));
				for (int i = 0; i < files.Length; i++)
				{
					File.Delete(files[i]);
				}
			}
			FieldInfo[] fields = typeof(DebugConfig).GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.Name.Equals(args[0], StringComparison.OrdinalIgnoreCase))
				{
					fieldInfo.SetValue(fieldInfo, flag);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void TestChris(IntPtr NativeArgs)
	{
		try
		{
			BGW_EventCollection.Get(GetThis()).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.BenchMark);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void ComboTest(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player);
			string p = string.Empty;
			if (args.Length >= 1)
			{
				p = args[0];
			}
			BGW_EventCollection.Get(Player).Evt_ComboTest(p);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void ChapterClear(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			ABGUCharacter worldCtx = null;
			if (args.Length >= 1)
			{
				if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
				{
					worldCtx = Player as ABGUCharacter;
				}
				int result = 0;
				int.TryParse(args[0], out result);
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(worldCtx);
				if (bGW_EventCollection != null)
				{
					bGW_EventCollection.Evt_UIChapterMovie(result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void SetWwiseRtpc(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 2 && args.Length >= 2)
			{
				int num = int.Parse(args[1]);
				UAkGameplayStatics.SetRTPCValue(null, num, 0, null, new FName(args[0]));
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void InvokeWwiseEvent(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 1 && args.Length >= 1)
			{
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis());
				UAkGameplayStatics.PostEvent(null, firstLocalPlayerController, 0, null, bStopWhenAttachedToDestroyed: false, args[0]);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void ChrisTestHaptic(IntPtr NativeArgs)
	{
		try
		{
			GetArgs(NativeArgs);
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis());
			if (!firstLocalPlayerController.IsNullOrDestroyed())
			{
				UHapticFeedbackEffect_Curve hapticEffect = BGW_PreloadAssetMgr.Get(firstLocalPlayerController).TryGetCachedResourceObj<UHapticFeedbackEffect_Curve>("HapticFeedbackEffect_Curve'/Game/00Main/Design/Curve/FeedBack/HF_test1.HF_test1'", ELoadResourceType.SyncLoadAndCache);
				firstLocalPlayerController.PlayHapticEffect(hapticEffect, EControllerHand.AnyHand);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void ChrisTestFeedBack(IntPtr NativeArgs)
	{
		try
		{
			GetArgs(NativeArgs);
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis());
			if (!firstLocalPlayerController.IsNullOrDestroyed())
			{
				UForceFeedbackEffect forceFeedbackEffect = BGW_PreloadAssetMgr.Get(firstLocalPlayerController).TryGetCachedResourceObj<UForceFeedbackEffect>("ForceFeedbackEffect'/Game/00Main/Design/Curve/FeedBack/FF_test1.FF_test1'", ELoadResourceType.SyncLoadAndCache);
				firstLocalPlayerController.ClientPlayForceFeedback(forceFeedbackEffect, FName.None, bLooping: false, bIgnoreTimeDilation: false, bPlayWhilePaused: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnCloseLoading(IntPtr NativeArgs)
	{
		try
		{
			BGWGameInstanceCS.Get(GetThis()).CloseLoadingScreen();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTriggerSave(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			int p = 0;
			if (args.Length >= 1)
			{
				p = int.Parse(args[0]);
			}
			if (BGU_CommonUtil.GetCurrentPlayer(GetThis(), out var Player))
			{
				BGS_EventCollectionCS.Get(Player.World).Evt_BGS_TriggerSaveData.Invoke(p);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSEnableEnemyBar(IntPtr NativeArgs)
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSwitchHideLockPoint(IntPtr NativeArgs)
	{
		try
		{
			GetArgs(NativeArgs);
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
					if (bUS_GSEventCollection != null)
					{
						bUS_GSEventCollection.Evt_Camera_SwitchHideUILockPoint.Invoke();
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void DBC_EditorDebug_WEFMVisualEditorDebugFX(IntPtr NativeArgs)
	{
		try
		{
			if (!DispLibDispWorld.GetInstance(GetThis()).WEFM_VisualDebugFX.IsNullOrDestroyed())
			{
				GetArgs(NativeArgs);
				DispLibDispWorld.GetInstance(GetThis()).WEFM_VisualDebugFX.SetActive(!DispLibDispWorld.GetInstance(GetThis()).WEFM_VisualDebugFX.IsActive(), bReset: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void DBC_Debug_SetWEFMLOD(IntPtr NativeArgs)
	{
		try
		{
			if (!DispLibDispWorld.GetInstance(GetThis()).WEFMManager.IsNullOrDestroyed() && !DispLibDispWorld.GetInstance(GetThis()).WEFM_VisualDebugFX.IsNullOrDestroyed())
			{
				GetArgs(NativeArgs);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void DBC_Debug_SetWEFMActive(IntPtr NativeArgs)
	{
		try
		{
			UNiagaraComponent wEFMManager = DispLibDispWorld.GetInstance(GetThis()).WEFMManager;
			if (!wEFMManager.IsNullOrDestroyed())
			{
				string[] args = GetArgs(NativeArgs);
				bool result = false;
				if (args.Length != 0)
				{
					bool.TryParse(args[0].ToLower(), out result);
				}
				wEFMManager.SetActive(result, bReset: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void DBC_Debug_LogEventQueue(IntPtr NativeArgs)
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void DBC_EnableDBCMergeNiagara(IntPtr NativeArgs)
	{
		try
		{
			DispLibDispWorld instance = DispLibDispWorld.GetInstance(GetThis());
			BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(instance);
			if (bGW_ECSWorld == null)
			{
				BGW_LogUtil.LogError("DBC_EnableDBCMergeNiagara can not get ECSWorld");
				return;
			}
			_ = instance.ECSEntity;
			BWC_DispLibDispWorldGlobalData bWC_DispLibDispWorldGlobalData = bGW_ECSWorld.GetObject<BWC_DispLibDispWorldGlobalData>(instance.ECSEntity);
			if (bWC_DispLibDispWorldGlobalData == null)
			{
				BGW_LogUtil.LogError("DBC_EnableDBCMergeNiagara can not get BWC_DispLibDispWorldGlobalData");
				return;
			}
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				BGW_LogUtil.LogError($"b.DBCMergeNiagara.Enable = {bWC_DispLibDispWorldGlobalData.CMDOverride_EnableDBCMergeNiagara}");
			}
			else if (args.Length == 1)
			{
				int.TryParse(args[0].ToLower(), out var result);
				bWC_DispLibDispWorldGlobalData.CMDOverride_EnableDBCMergeNiagara = result;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTestPredict(IntPtr world)
	{
		try
		{
			for (int i = 0; i < 10; i++)
			{
				BUS_EventCollectionCS.Get(UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetWorld(world)).GetControlledPawn()).Evt_TestPredict.Invoke();
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnToggleCharacterView(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 1)
			{
				if (args[0] == "1")
				{
					BGW_CharacterViewMgr.Get(GetThis()).ToggleCharacterView(bSwitchOn: true);
				}
				else if (args[0] == "0")
				{
					BGW_CharacterViewMgr.Get(GetThis()).ToggleCharacterView(bSwitchOn: false);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnEnableAutoMove(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			AAutoMovementMonitor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AAutoMovementMonitor>(GetThis());
			if (args.Length == 0)
			{
				return;
			}
			if (args[0] == "-1")
			{
				for (int i = 0; i < allActorsOfClass.Length; i++)
				{
					allActorsOfClass[i].StopAutoMovement();
					BGU_UnrealWorldUtil.DestroyActor(allActorsOfClass[i]);
				}
			}
			else
			{
				if (allActorsOfClass.Length != 0)
				{
					return;
				}
				int result = -1;
				if (!int.TryParse(args[0], out result))
				{
					return;
				}
				string text = "";
				BGWDataAsset_AutoMoveMonitorsConfig bGWDataAsset_AutoMoveMonitorsConfig = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<BGWDataAsset_AutoMoveMonitorsConfig>("BGWDataAsset_AutoMoveMonitorsConfig'/Game/00Main/DataAsset/AutoMovement/DA_AutoMoveInstancesConfig.DA_AutoMoveInstancesConfig'", ELoadResourceType.SyncLoadAndCache);
				if (!(bGWDataAsset_AutoMoveMonitorsConfig != null) || bGWDataAsset_AutoMoveMonitorsConfig.AutoMoveCaptureModes.Count <= result)
				{
					return;
				}
				text = bGWDataAsset_AutoMoveMonitorsConfig.AutoMoveCaptureModes[result].AssetPath;
				APlayerController playerController = UGameplayStatics.GetPlayerController(GetThis(), 0);
				playerController.GetActorTransform();
				AAutoMovementMonitor aAutoMovementMonitor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(Cls: BGW_PreloadAssetMgr.Get(playerController).TryGetCachedResourceObj<UClass>(text, ELoadResourceType.SyncLoadAndCache), World: playerController.World) as AAutoMovementMonitor;
				_ = aAutoMovementMonitor != null;
				int result2 = 0;
				if (args.Length > 1)
				{
					int.TryParse(args[1], out result2);
				}
				if (bGWDataAsset_AutoMoveMonitorsConfig.AutoMoveMotionPatterns.Count > result2)
				{
					string assetPath = bGWDataAsset_AutoMoveMonitorsConfig.AutoMoveMotionPatterns[result2].AssetPath;
					UAutoMovementPattern uAutoMovementPattern = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UAutoMovementPattern>(assetPath, ELoadResourceType.SyncLoadAndCache);
					if (uAutoMovementPattern != null)
					{
						aAutoMovementMonitor.AutoMovePattern = uAutoMovementPattern;
						aAutoMovementMonitor.SetSparseVersionEnabled(bEnabled: false);
					}
				}
				if (args.Length > 2)
				{
					int result3 = -1;
					if (int.TryParse(args[2], out result3) && result3 == 1)
					{
						aAutoMovementMonitor.SetSparseVersionEnabled(bEnabled: true);
					}
				}
				if (args.Length > 3)
				{
					int result4 = -1;
					if (int.TryParse(args[3], out result4) && result4 == 0)
					{
						OnDisbaleEnemyChasing((IntPtr)0);
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetVFXAutoPlayRootFolder(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				UAutoMovementUtil.SetVfxAutoPlayerRootFolderPath(args[0].ToString());
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTestSpecificSequence(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			string text = args[0];
			string[] array = File.ReadAllLines(Path.Combine(USystemLibrary.GetProjectContentDirectory(), "00Main/Sequence/SeqTestConfig.txt"));
			FVector fVector = FVector.ZeroVector;
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split(':');
				if (array3.Length > 1 && array3[0] == text)
				{
					string[] array4 = array3[1].Split(',');
					if (array4.Length >= 3)
					{
						fVector = new FVector(float.Parse(array4[0]), float.Parse(array4[1]), float.Parse(array4[2]));
					}
					break;
				}
			}
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
			if (!(fVector == FVector.ZeroVector))
			{
				BGUFuncLibActorTransformCS.BGUSetActorLocation(playerCharacter, fVector, bSweep: false, bTeleport: true, out var _);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSpecifiedDeletedActorsKeyword(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				string inKeyword = args[0];
				UGSE_EngineFuncLib.DestroyActorsWithSpecifiedKeyword(GetThis(), inKeyword);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnChangeLanguage(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				GSLocalization.SetCurrentCulture(args[0]);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetCSharpTickEnable(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0 && int.TryParse(args[0].ToLower(), out var result))
			{
				BGWGameInstanceCS.EnableCSharpTick = result != 0;
				BGW_ECSWorld.Get(GetThis()).RecalculateAllActorCanTick();
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnForceTileSwitchLOD(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 2)
			{
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis());
				if (!(firstLocalPlayerController == null) && int.TryParse(args[1].ToLower(), out var result))
				{
					UBGUFunctionLibrary.ForceLoadTileLOD(firstLocalPlayerController, args[0], result);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnDisbaleEnemyChasing(IntPtr NativeArgs)
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
		if (!(playerCharacter == null))
		{
			BGUCharacterCS bGUCharacterCS = playerCharacter as BGUCharacterCS;
			if (!(bGUCharacterCS == null))
			{
				bGUCharacterCS.SetTeamIDInCS(0);
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnStartCaptureTextureInfo(IntPtr NativeArgs)
	{
		APlayerController playerController = UGameplayStatics.GetPlayerController(GetThis(), 0);
		playerController.GetActorTransform();
		string path = "/Game/00Main/BPLibrary/BGW/BP_TextureMipInfoCapturer.BP_TextureMipInfoCapturer_C";
		UClass uClass = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>(path, ELoadResourceType.SyncLoadAndCache);
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), uClass);
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
		USystemLibrary.ExecuteConsoleCommand(GetThis(), "r.VT.GSCapture 1", null);
		UGSE_TextureFuncLib.StartCapturingStreamingTextureStats();
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnStopCaptureTextureInfo(IntPtr NativeArgs)
	{
		USystemLibrary.ExecuteConsoleCommand(GetThis(), "r.VT.Dump", null);
		USystemLibrary.ExecuteConsoleCommand(GetThis(), "r.VT.GSCapture 0", null);
		UGSE_TextureFuncLib.EndCapturingStreamingTextureStats();
		UGameplayStatics.GetPlayerController(GetThis(), 0).GetActorTransform();
		string path = "/Game/00Main/BPLibrary/BGW/BP_TextureMipInfoCapturer.BP_TextureMipInfoCapturer_C";
		UClass actorClass = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>(path, ELoadResourceType.SyncLoadAndCache);
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), actorClass);
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			allActorsOfClass[i].SetActorTickEnabled(bEnabled: false);
			BGU_UnrealWorldUtil.DestroyActor(allActorsOfClass[i]);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPauseLevelStreaming(IntPtr NativeArgs)
	{
		BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(GetThis());
		if (bGW_LevelStreamingManger != null)
		{
			bGW_LevelStreamingManger.PauseAllLevelDistanceStreaming();
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnResumeLevelStreaming(IntPtr NativeArgs)
	{
		BGW_LevelStreamingManger bGW_LevelStreamingManger = BGW_LevelStreamingManger.Get(GetThis());
		if (bGW_LevelStreamingManger != null)
		{
			bGW_LevelStreamingManger.ResumeAllLevelDistanceStreaming();
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnForceUnloadLevels(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length == 0)
		{
			return;
		}
		foreach (string item in args.ToList())
		{
			foreach (FGSSetLevelStateFailedInfo item2 in UBGUWCStreamingFuncLib.SetLevelsState(GetThis(), item.Trim(), EGSLevelState.Unloaded))
			{
				_ = item2;
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnForceLoadLevels(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length == 0)
		{
			return;
		}
		foreach (string item in args.ToList())
		{
			foreach (FGSSetLevelStateFailedInfo item2 in UBGUWCStreamingFuncLib.SetLevelsState(GetThis(), item.Trim(), EGSLevelState.LoadedVisible))
			{
				_ = item2;
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnDemo820SettingInit(IntPtr NativeArgs)
	{
		bool bNeedShowBox = true;
		bool flag = true;
		int num = 0;
		string[] args = GetArgs(NativeArgs);
		if (args.Length != 0)
		{
			bNeedShowBox = args[0] == "1";
		}
		if (args.Length > 1)
		{
			flag = args[1] == "1";
		}
		if (args.Length > 2)
		{
			num = int.Parse(args[2]);
		}
		switch (num)
		{
		case 0:
			ApplySettingByDeviceInfo();
			break;
		case 1:
		{
			UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
			if (gameUserSettings != null)
			{
				gameUserSettings.RunHardwareBenchmark();
			}
			break;
		}
		}
		if (flag)
		{
			UGSE_EngineFuncLib.PSOFullCompilation();
			BGW_820DemoPlayTimeMgr.Get(GetThis()).BeginWaitPSOFinish(bNeedShowBox);
		}
		else
		{
			BGW_820DemoPlayTimeMgr.Get(GetThis()).OnDemo820SettingInitFinishLogic(bNeedShowBox);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnDemo820GMSetTimeInfo(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length >= 8)
		{
			int gMGameplayTimeMax = int.Parse(args[0]);
			int gMTipsTimeDur = int.Parse(args[1]);
			int gMSmallTipsTimeDur = int.Parse(args[2]);
			int gMTipsTime = int.Parse(args[3]);
			int gMTipsTime2 = int.Parse(args[4]);
			int gMTipsTime3 = int.Parse(args[5]);
			int gMTipsTime4 = int.Parse(args[6]);
			int num = int.Parse(args[7]);
			BGW_820DemoPlayTimeMgr.Get(GetThis()).SetTimeInfoByGM(gMGameplayTimeMax, gMTipsTimeDur, gMSmallTipsTimeDur, gMTipsTime, gMTipsTime2, gMTipsTime3, gMTipsTime4);
			string name = "b.GMSetTimeInfo";
			IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable(name);
			if (consoleVariable == null)
			{
				IConsoleManager.Get().RegisterConsoleVariable(name, num, "Auto Register After Not Find");
			}
			else
			{
				consoleVariable.Set(num);
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnDemo820TimePause(IntPtr NativeArgs)
	{
		BGW_820DemoPlayTimeMgr.Get(GetThis()).GMPauseTick();
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnPlayGoPause()
	{
		BGW_PlayGoMgr.Get(GetThis()).Pause();
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnPlayGoResume()
	{
		BGW_PlayGoMgr.Get(GetThis()).Resume();
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPlayGoSetSpeed(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length != 0 && float.TryParse(args[0], out var result))
		{
			BGW_PlayGoMgr.Get(GetThis()).SetSpeed(result);
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnPlayGoBegin()
	{
		BGW_PlayGoMgr.Get(GetThis()).Begin();
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnPlayGoFinish()
	{
		BGW_PlayGoMgr.Get(GetThis()).Finish();
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void OnPrintWukongMatQualityInfo()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetThis());
		if (firstLocalPlayerController != null)
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			if (controlledPawn != null)
			{
				BUS_EventCollectionCS.Get(controlledPawn)?.Evt_PrintWukongMatQualityInfo.Invoke();
			}
		}
	}

	private static void ApplySettingByDeviceInfo()
	{
		EPlatform platform = FPlatformProperties.GetPlatform();
		UGSE_EngineFuncLib.GetDeviceInfo(out var _, out var Gpu, out var _);
		UGameUserSettings gameUserSettings = UGameUserSettings.GetGameUserSettings();
		gameUserSettings.SetVSyncEnabled(bEnable: false);
		gameUserSettings.SetFullscreenMode(EWindowMode.WindowedFullscreen);
		FIntPoint screenResolution = new FIntPoint
		{
			X = 2560,
			Y = 1440
		};
		if (platform == EPlatform.Windows)
		{
			FVector2D windowScreenResolution = UGSE_EngineFuncLib.GetWindowScreenResolution();
			screenResolution.X = (int)windowScreenResolution.X;
			screenResolution.Y = (int)windowScreenResolution.Y;
		}
		gameUserSettings.SetScreenResolution(screenResolution);
		int num = 3;
		switch (platform)
		{
		case EPlatform.PS5:
			num = 2;
			break;
		case EPlatform.XSX:
			num = 2;
			break;
		}
		if (Gpu.Contains("4070") || Gpu.Contains("4080") || Gpu.Contains("4090"))
		{
			num = 3;
		}
		else if (Gpu.Contains("2070") || Gpu.Contains("2060") || Gpu.Contains("2080") || Gpu.Contains("3060") || Gpu.Contains("3070") || Gpu.Contains("3080") || Gpu.Contains("3090"))
		{
			num = 2;
		}
		else if (Gpu.Contains("1660"))
		{
			num = 1;
		}
		float newValue = 75f;
		if (platform == EPlatform.Windows)
		{
			float num2 = 720f;
			if (num >= 2)
			{
				num2 = 1080f;
			}
			newValue = num2 / (float)screenResolution.Y * 100f;
		}
		BGW_SettingFuncUtil.SetScreenPercentage(newValue, NeedApply: false);
		gameUserSettings.SetViewDistanceQuality(num);
		gameUserSettings.SetAntiAliasingQuality(num);
		gameUserSettings.SetPostProcessingQuality(num);
		gameUserSettings.SetShadingQuality(num);
		gameUserSettings.SetShadowQuality(num);
		gameUserSettings.SetTextureQuality(num);
		gameUserSettings.SetVisualEffectQuality(num);
		gameUserSettings.SetFoliageQuality(num);
		gameUserSettings.SetGlobalIlluminationQuality(num);
		gameUserSettings.SetReflectionQuality(num);
		gameUserSettings.ApplyHardwareBenchmarkResults();
		UGSE_GSGameSettingsFuncLib.ApplyGSGameSettings(bSaveSettings: true);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnFlushDistanceStreaming(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length == 0)
		{
			OnResumeLevelStreaming(NativeArgs);
			return;
		}
		foreach (string item in args.ToList())
		{
			foreach (FGSSetLevelStateFailedInfo item2 in UBGUWCStreamingFuncLib.SetLevelsState(GetThis(), item.Trim(), EGSLevelState.Auto))
			{
				_ = item2;
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnModifyStreamingDistanceScale(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length < 3)
		{
			return;
		}
		int result = -1;
		float result2 = 1f;
		bool bBlockTillStreamingCompleted = false;
		if (int.TryParse(args[1], out result) && float.TryParse(args[2], out result2))
		{
			if (args.Length > 3)
			{
				int result3 = 0;
				int.TryParse(args[3], out result3);
				bBlockTillStreamingCompleted = result3 > 0;
			}
			UBGUWCStreamingFuncLib.ModifyStreamingDistanceScaleByStreamingLayer(GetThis(), args[0], result, result2, bBlockTillStreamingCompleted);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnTryPushTaskStage(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 2 && int.TryParse(args[0].ToLower(), out var result) && int.TryParse(args[1].ToLower(), out var result2))
			{
				BGUFuncLibForTaskAndNPCTest.TryPushTaskStageStateForTest(GetThis(), result, result2);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnShowTaskStageState(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			int taskLineID = 0;
			if (args.Length != 0 && int.TryParse(args[0].ToLower(), out var result))
			{
				taskLineID = result;
			}
			BGUFuncLibForTaskAndNPCTest.ShowTaskStageState(GetThis(), taskLineID);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPrintResourceInfo(IntPtr NativeArgs)
	{
		try
		{
			BGW_PreloadAssetMgr.Get(GetThis())?.PrintNoLoadedObjInfoList();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPrintAbnormalResourcePathList(IntPtr NativeArgs)
	{
		try
		{
			BGW_PreloadAssetMgr.Get(GetThis())?.PrintAbnormalResourcePathList();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void EnableShapeSelectRange(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0 && int.TryParse(args[0].ToLower(), out var result))
			{
				SelectRangeDebugInfo.EnableDebugForSelectRange = result == 1;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void EnableShapeSelectUnit(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0 && int.TryParse(args[0].ToLower(), out var result))
			{
				SelectRangeDebugInfo.EnableDebugForSelectUnit = result == 1;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void PrintCurrentAssociationUnitInfo(IntPtr NativeArgs)
	{
		try
		{
			BGW_EventCollection.Get(GetThis())?.Evt_BGW_PrintCurrentAssociationUnitInfo();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void PrintCurrentFollowPartnerInfo(IntPtr NativeArgs)
	{
		try
		{
			BGW_EventCollection.Get(GetThis())?.Evt_BGW_PrintCurrentFollowPartnerInfo();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void PrintCurrentWeakAiInteractInfo(IntPtr NativeArgs)
	{
		try
		{
			BGW_EventCollection.Get(GetThis())?.Evt_BGW_PrintCurrentWeakAiInteractInfo();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	public static void RefreshModularMesh(IntPtr NativeArgs)
	{
		try
		{
			BGUPlayerCharacterCS bGUPlayerCharacterCS = UGameplayStatics.GetPlayerCharacter(GetThis(), 0) as BGUPlayerCharacterCS;
			if (bGUPlayerCharacterCS != null)
			{
				BUS_EventCollectionCS.Get(bGUPlayerCharacterCS)?.Evt_OnRefreshEquip.Invoke();
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void SetViewLocationAndRotation(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				FVector viewLocation = default(FVector);
				if (viewLocation.InitFromString(args[0]))
				{
					UGSE_EditorFuncLib.SetViewLocation(viewLocation);
				}
			}
			if (args.Length > 1)
			{
				FRotator viewRotation = default(FRotator);
				if (viewRotation.InitFromString(args[1]))
				{
					UGSE_EditorFuncLib.SetViewRotation(viewRotation);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void RefreshLevelInfo(IntPtr NativeArgs)
	{
		try
		{
			BGW_EventCollection.Get(GetThis())?.Evt_RefreshLevelInfo();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void RefreshActorInfo(IntPtr NativeArgs)
	{
		try
		{
			string p = "";
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				p = args[0];
			}
			if (args.Length > 1 && int.TryParse(args[1], out var result))
			{
				if (result < 0)
				{
					BGW_EventCollection.Get(GetThis())?.Evt_RefreshActorInfoOnce(p);
					return;
				}
				bool p2 = result != 0;
				BGW_EventCollection.Get(GetThis())?.Evt_MarkActorInfoRealTime(p, p2);
			}
			else
			{
				BGW_EventCollection.Get(GetThis())?.Evt_RefreshActorInfo(p);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(AOT.Del_Void))]
	private static void PreloadAssets()
	{
		new List<string>
		{
			"BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Grass/DBC/DBC_WuKong_Atk_Foot_Grass_Smoke_Low.DBC_WuKong_Atk_Foot_Grass_Smoke_Low'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Water/DBC/DBC_WuKong_Atk_Foot_Water_ShuiHua_Low.DBC_WuKong_Atk_Foot_Water_ShuiHua_Low'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Stone/DBC/DBC_WuKong_Atk_Foot_Stone_Smoke_Low.DBC_WuKong_Atk_Foot_Stone_Smoke_Low'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Mud/DBC/DBC_WuKong_Atk_Foot_Mud_Smoke_Low.DBC_WuKong_Atk_Foot_Mud_Smoke_Low'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Soil/DBC/DBC_WuKong_Atk_Foot_Soil_Smoke_Low.DBC_WuKong_Atk_Foot_Soil_Smoke_Low'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Wood/DBC/DBC_WuKong_Atk_Foot_Wood_Smoke_Low.DBC_WuKong_Atk_Foot_Wood_Smoke_Low'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Sand/DBC/DBC_WuKong_Atk_Foot_Sand_Smoke_Low.DBC_WuKong_Atk_Foot_Sand_Smoke_Low'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Snow/DBC/DBC_WuKong_Atk_Foot_Snow_Smoke_Low.DBC_WuKong_Atk_Foot_Snow_Smoke_Low'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Ice/DBC/DBC_WuKong_Atk_Foot_Ice_Smoke_Low.DBC_WuKong_Atk_Foot_Ice_Smoke_Low'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Grass/DBC/DBC_WuKong_Atk_Foot_Grass_Smoke_Middle.DBC_WuKong_Atk_Foot_Grass_Smoke_Middle'",
			"BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Water/DBC/DBC_WuKong_Atk_Foot_Water_ShuiHua_Middle.DBC_WuKong_Atk_Foot_Water_ShuiHua_Middle'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Stone/DBC/DBC_WuKong_Atk_Foot_Stone_Smoke_Middle.DBC_WuKong_Atk_Foot_Stone_Smoke_Middle'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Mud/DBC/DBC_WuKong_Atk_Foot_Mud_Smoke_Middle.DBC_WuKong_Atk_Foot_Mud_Smoke_Middle'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Soil/DBC/DBC_WuKong_Atk_Foot_Soil_Smoke_Middle.DBC_WuKong_Atk_Foot_Soil_Smoke_Middle'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Wood/DBC/DBC_WuKong_Atk_Foot_Wood_Smoke_Middle.DBC_WuKong_Atk_Foot_Wood_Smoke_Middle'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Sand/DBC/DBC_WuKong_Atk_Foot_Sand_Smoke_Middle.DBC_WuKong_Atk_Foot_Sand_Smoke_Middle'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Snow/DBC/DBC_WuKong_Atk_Foot_Snow_Smoke_Middle.DBC_WuKong_Atk_Foot_Snow_Smoke_Middle'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Ice/DBC/DBC_WuKong_Atk_Foot_Ice_Smoke_Middle.DBC_WuKong_Atk_Foot_Ice_Smoke_Middle'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Grass/DBC/DBC_WuKong_Atk_Foot_Grass_Smoke_High.DBC_WuKong_Atk_Foot_Grass_Smoke_High'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Water/DBC/DBC_WuKong_Atk_Foot_Water_ShuiHua_High.DBC_WuKong_Atk_Foot_Water_ShuiHua_High'",
			"BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Stone/DBC/DBC_WuKong_Atk_Foot_Stone_Smoke_High.DBC_WuKong_Atk_Foot_Stone_Smoke_High'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Mud/DBC/DBC_WuKong_Atk_Foot_Mud_Smoke_High.DBC_WuKong_Atk_Foot_Mud_Smoke_High'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Soil/DBC/DBC_WuKong_Atk_Foot_Soil_Smoke_High.DBC_WuKong_Atk_Foot_Soil_Smoke_High'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Wood/DBC/DBC_WuKong_Atk_Foot_Wood_Smoke_High.DBC_WuKong_Atk_Foot_Wood_Smoke_High'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Sand/DBC/DBC_WuKong_Atk_Foot_Sand_Smoke_High.DBC_WuKong_Atk_Foot_Sand_Smoke_High'", "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FootEffects/ZaDi/Snow/DBC/DBC_WuKong_Atk_Foot_Snow_Smoke_High.DBC_WuKong_Atk_Foot_Snow_Smoke_High'"
		};
		if (!(UGameplayStatics.GetPlayerController(GetThis(), 0) == null))
		{
			_ = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000L) / 10000;
			_ = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000L) / 10000;
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnHilightDestructible(IntPtr NativeArgs)
	{
		try
		{
			UClass actorClass = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00MainHZ/Environment/BPO/BP_DestructibleBase.BP_DestructibleBase_C'", ELoadResourceType.SyncLoadAndCache);
			UMaterialInstanceConstant material = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UMaterialInstanceConstant>("MaterialInstanceConstant'/Game/00Main/GlobalMat/MatLibrary/Materials/Basic/M_QA_Destructible_Inst.M_QA_Destructible_Inst'", ELoadResourceType.SyncLoadAndCache);
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), actorClass);
			for (int i = 0; i < allActorsOfClass.Length; i++)
			{
				List<UActorComponent> componentsByClass = allActorsOfClass[i].GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>());
				for (int j = 0; j < componentsByClass.Count; j++)
				{
					UStaticMeshComponent uStaticMeshComponent = componentsByClass[j] as UStaticMeshComponent;
					if (uStaticMeshComponent != null)
					{
						for (int k = 0; k < uStaticMeshComponent.GetMaterials().Count; k++)
						{
							uStaticMeshComponent.SetMaterial(k, material);
						}
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnHilightBlockAirWall(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !int.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			UClass actorClass = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("/Script/Engine.BlockingVolume", ELoadResourceType.SyncLoadAndCache);
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), actorClass);
			foreach (AActor aActor in allActorsOfClass)
			{
				if (aActor.ActorHasTag(new FName("CliffAirWall")))
				{
					continue;
				}
				List<UActorComponent> componentsByClass = aActor.GetComponentsByClass(UClass.GetClass<UBrushComponent>());
				for (int j = 0; j < componentsByClass.Count; j++)
				{
					UBrushComponent uBrushComponent = componentsByClass[j] as UBrushComponent;
					if (uBrushComponent != null)
					{
						uBrushComponent.SetHiddenInGame(result == 0);
					}
				}
			}
			actorClass = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("/Script/UnrealExtent.BGWBlockingVolume", ELoadResourceType.SyncLoadAndCache);
			allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), actorClass);
			foreach (AActor aActor2 in allActorsOfClass)
			{
				if (aActor2.ActorHasTag(new FName("CliffAirWall")))
				{
					continue;
				}
				List<UActorComponent> componentsByClass2 = aActor2.GetComponentsByClass(UClass.GetClass<UBrushComponent>());
				for (int k = 0; k < componentsByClass2.Count; k++)
				{
					UBrushComponent uBrushComponent2 = componentsByClass2[k] as UBrushComponent;
					if (uBrushComponent2 != null)
					{
						uBrushComponent2.SetHiddenInGame(result == 0);
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnHilightCliffAirWall(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0 || !int.TryParse(args[0].ToLower(), out var result))
			{
				return;
			}
			UClass actorClass = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("/Script/Engine.BlockingVolume", ELoadResourceType.SyncLoadAndCache);
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), actorClass);
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.ActorHasTag(new FName("CliffAirWall")))
				{
					continue;
				}
				List<UActorComponent> componentsByClass = aActor.GetComponentsByClass(UClass.GetClass<UBrushComponent>());
				for (int j = 0; j < componentsByClass.Count; j++)
				{
					UBrushComponent uBrushComponent = componentsByClass[j] as UBrushComponent;
					if (uBrushComponent != null)
					{
						uBrushComponent.SetHiddenInGame(result == 0);
					}
				}
			}
			actorClass = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("/Script/UnrealExtent.BGWBlockingVolume", ELoadResourceType.SyncLoadAndCache);
			allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), actorClass);
			foreach (AActor aActor2 in allActorsOfClass)
			{
				if (!aActor2.ActorHasTag(new FName("CliffAirWall")))
				{
					continue;
				}
				List<UActorComponent> componentsByClass2 = aActor2.GetComponentsByClass(UClass.GetClass<UBrushComponent>());
				for (int k = 0; k < componentsByClass2.Count; k++)
				{
					UBrushComponent uBrushComponent2 = componentsByClass2[k] as UBrushComponent;
					if (uBrushComponent2 != null)
					{
						uBrushComponent2.SetHiddenInGame(result == 0);
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	private static void ToggleBoxTemp(UClass BP)
	{
		try
		{
			if (BP == null)
			{
				return;
			}
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), BP);
			for (int i = 0; i < allActorsOfClass.Length; i++)
			{
				List<UActorComponent> componentsByClass = allActorsOfClass[i].GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>());
				for (int j = 0; j < componentsByClass.Count; j++)
				{
					UStaticMeshComponent uStaticMeshComponent = componentsByClass[j] as UStaticMeshComponent;
					if (uStaticMeshComponent != null)
					{
						bool newHidden = !uStaticMeshComponent.HiddenInGame;
						uStaticMeshComponent.SetHiddenInGame(newHidden);
					}
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnToggleTriggerBoxShow(IntPtr NativeArgs)
	{
		try
		{
			UClass bP = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/BPLibrary/SceneObj/ForceFightControlTrigger/BP_ForceFightControlBoxTrigger.BP_ForceFightControlBoxTrigger_C'", ELoadResourceType.SyncLoadAndCache);
			UClass bP2 = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/BPLibrary/SceneObj/BP_DynamicObstcle.BP_DynamicObstcle_C'", ELoadResourceType.SyncLoadAndCache);
			UClass bP3 = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/BPLibrary/SceneObj/BP_BuffTriggerActor.BP_BuffTriggerActor_C'", ELoadResourceType.SyncLoadAndCache);
			UClass bP4 = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/BPLibrary/SceneObj/BP_BattleTriggerBox.BP_BattleTriggerBox_C'", ELoadResourceType.SyncLoadAndCache);
			UClass bP5 = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/BPLibrary/SceneObj/BP_OverlapBox.BP_OverlapBox_C'", ELoadResourceType.SyncLoadAndCache);
			UClass bP6 = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/BPLibrary/SceneObj/BP_OverlapBoxForSeq.BP_OverlapBoxForSeq_C'", ELoadResourceType.SyncLoadAndCache);
			ToggleBoxTemp(bP);
			ToggleBoxTemp(bP2);
			ToggleBoxTemp(bP3);
			ToggleBoxTemp(bP4);
			ToggleBoxTemp(bP5);
			ToggleBoxTemp(bP6);
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnToggleDeadZoneShow(IntPtr NativeArgs)
	{
		try
		{
			ToggleBoxTemp(BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/00Main/Design/Blueprints/TriggerBox/DeadZone.DeadZone_C'", ELoadResourceType.SyncLoadAndCache));
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnKillSpecificEnemy(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length == 0)
			{
				return;
			}
			string value = args[0];
			BUTamerActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>(GetThis());
			foreach (BUTamerActor bUTamerActor in allActorsOfClass)
			{
				if (bUTamerActor.GetName().Contains(value) && bUTamerActor.GetMonster() != null)
				{
					BUS_EventCollectionCS.Get(bUTamerActor.GetMonster())?.Evt_UnitDead.Invoke(null, EDeadReason.SkillDamage);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGWConsoleCommands:GenerateArrow")]
	private static void GenerateArrow()
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetThis(), 0);
		FVector location = UGameplayStatics.GetPlayerCharacter(playerCharacter.World, 0).GetActorLocation();
		FRotator rotation = UGameplayStatics.GetPlayerCharacter(playerCharacter.World, 0).GetControlRotation();
		FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
		};
		UClass unrealClass = BGW_PreloadAssetMgr.Get(playerCharacter.World).TryGetCachedResourceObj<UClass>("Blueprint'/Game/3rd/QATest/Helper/Test_Arrow.Test_Arrow_C'", ELoadResourceType.SyncLoadAndCache);
		playerCharacter.World.SpawnActor(unrealClass, ref location, ref rotation, ref parameters);
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPlayerTraceStart(IntPtr NativeArgs)
	{
		try
		{
			if (!ArrowTick.IsValid)
			{
				string[] args = GetArgs(NativeArgs);
				float result;
				try
				{
					float.TryParse(args[0].ToLower(), out result);
				}
				catch
				{
					result = 1f;
				}
				ArrowTick = (FTimerManager.PIEWorld ?? FTimerManager.GameInstance).SetTimer(GetThis(), "GenerateArrow", result, looping: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPlayerTraceStop(IntPtr NativeArgs)
	{
		try
		{
			if (ArrowTick.IsValid)
			{
				(FTimerManager.PIEWorld ?? FTimerManager.GameInstance).ClearTimer(ref ArrowTick);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnAAPreloadDistance(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			int num = args.Length;
			if (num > 0)
			{
				int asycXY = int.Parse(args[0]);
				int asycZ = ((num > 1) ? int.Parse(args[1]) : 0);
				int sycXY = ((num > 2) ? int.Parse(args[2]) : 0);
				int sycZ = ((num > 3) ? int.Parse(args[3]) : 0);
				b1.BUS_PreloadLogicComp.SetAALoadingDistance(asycXY, asycZ, sycXY, sycZ);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnMonsterResourceReleaseDuration(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length > 0)
			{
				BGW_PreloadAssetMgr.SetReleaseDuration(int.Parse(args[0]));
			}
			else
			{
				BGW_PreloadAssetMgr.SetReleaseDuration(5);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPlayerTraceClean(IntPtr NativeArgs)
	{
		try
		{
			UClass actorClass = BGW_PreloadAssetMgr.Get(GetThis()).TryGetCachedResourceObj<UClass>("Blueprint'/Game/3rd/QATest/Helper/Test_Arrow.Test_Arrow_C'", ELoadResourceType.SyncLoadAndCache);
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), actorClass);
			for (int i = 0; i < allActorsOfClass.Length; i++)
			{
				BGU_UnrealWorldUtil.DestroyActor(allActorsOfClass[i]);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnRunAutoTest(IntPtr NativePtr)
	{
		try
		{
			string[] args = GetArgs(NativePtr);
			if (args.Length == 1)
			{
				string item = args[0];
				BIS_AutoTestManagerV2.Get(GetThis()).RunTestCasesFromGM(new List<string> { item });
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnStopAutoTest(IntPtr NativePtr)
	{
		try
		{
			BIS_AutoTestManagerV2.Get(GetThis()).SkipCurrentCase();
			BIS_AutoTestManagerV2.Get(GetThis()).IsInvincibleMode = false;
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnRunTestSuite(IntPtr NativePtr)
	{
		try
		{
			string[] args = GetArgs(NativePtr);
			if (args.Length == 1)
			{
				string suiteName = args[0];
				BIS_AutoTestManagerV2.Get(GetThis()).RunTestSuiteFromGM(suiteName);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnStopTestSuite(IntPtr NativePtr)
	{
		try
		{
			BIS_AutoTestManagerV2.Get(GetThis()).StopCurrentSuite();
			BIS_AutoTestManagerV2.Get(GetThis()).IsInvincibleMode = false;
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnRunTestCasesFromGM(IntPtr NativePtr)
	{
		try
		{
			string[] args = GetArgs(NativePtr);
			if (args.Length != 0)
			{
				BIS_AutoTestManagerV2.Get(GetThis()).RunTestCasesFromGM(args.ToList());
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnQATransLevel(IntPtr NativePtr)
	{
		try
		{
			string[] args = GetArgs(NativePtr);
			if (args.Length == 1)
			{
				int targetId = int.Parse(args[0]);
				BGW_EventCollection.Get(GetThis()).Evt_BGW_TriggerGlobalFSMEvent(EGI_Global.StartNewGame, new FSMInputData_GI_Global_SubG_GI_Loading_TravelLevel
				{
					TargetId = targetId
				});
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnEnableComboAINodeLog(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length != 0)
		{
			int.TryParse(args[0].ToLower(), out var _);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnEnableComboAINodeScoreLog(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length != 0)
		{
			int.TryParse(args[0].ToLower(), out var _);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetDebugTargetMask(IntPtr NativeArgs)
	{
		string[] args = GetArgs(NativeArgs);
		if (args.Length == 2)
		{
			string unitGuid = args[0];
			BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(GetThis(), unitGuid) as BGUCharacterCS;
			if (!(bGUCharacterCS == null) && int.TryParse(args[1].ToLower(), out var result))
			{
				BGS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_BGS_SetNeedShowDebugChr.Invoke(bGUCharacterCS, result);
			}
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnDisableSetBT(IntPtr NativeArgs)
	{
	}

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr WindowPtr, int Flags);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr WindowPtr);

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void LoadHotScript(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 3)
			{
				string tickMethod = null;
				int tickGroup = 0;
				if (args.Length >= 5)
				{
					tickMethod = args[3];
					tickGroup = int.Parse(args[4]);
				}
				BGW_ILRuntimeMgr.Get(GetThis()).LoadHotScriptAssembly(args[0].Replace("\"", ""), args[1], args[2], tickMethod, tickGroup);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnOpenBattleInfo(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0 && int.TryParse(args[0].ToLower(), out var result))
			{
				BGUFunctionLibraryCS.OpenBattleInfoTool(result == 1);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnRefreshBattleInfo(IntPtr NativeArgs)
	{
		try
		{
			BGUFunctionLibraryCS.RefreshBattleInfoTool();
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnSetAllUnitTargetIsFirstPlayer(IntPtr NativeArgs)
	{
		try
		{
			BGUFunctionLibraryCS.SetAllUnitTargetIsFirstPlayer(GetThis());
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGamePlayTraceStart(IntPtr NativeArgs)
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGamePlayTraceEnd(IntPtr NativeArgs)
	{
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnQuickRebirth(IntPtr NativeArgs)
	{
		try
		{
			AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>());
			foreach (AActor aActor in allActorsOfClass)
			{
				if (!aActor.IsNullOrDestroyed())
				{
					BUS_EventCollectionCS.Get(aActor)?.Evt_UnitRebirth.Invoke(ERebirthType.Quick);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnQuickTeleport(IntPtr NativeArgs)
	{
		try
		{
			UGameplayStatics.OpenLevel(UGameplayStatics.GetAllActorsOfClass(GetThis(), UClass.GetClass<BGUPlayerCharacterCS>())[0], new FName(UGameplayStatics.GetCurrentLevelName(GetThis())));
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnCallSaveNiagaraInfo(IntPtr NativeArgs)
	{
		try
		{
			GetArgs(NativeArgs);
			UGameplayStatics.GetAllActorsOfClassWithTag(GetThis(), UClass.GetClass<AActor>(), new FName("NiagaraStat"), out var OutActors);
			if (OutActors.Count > 0)
			{
				AActor aActor = OutActors[0];
				string cmd = $"SaveStatData {1}";
				aActor.CallFunctionByNameWithArguments(cmd, forceCallWithNonExec: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnCallEndSkill(IntPtr NativeArgs)
	{
		try
		{
			UGameplayStatics.GetAllActorsOfClassWithTag(GetThis(), UClass.GetClass<AActor>(), new FName("NiagaraStat"), out var OutActors);
			if (OutActors.Count > 0)
			{
				OutActors[0].CallFunctionByNameWithArguments("EndSkill", forceCallWithNonExec: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnCallStartSkill(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 5)
			{
				AActor aActor = null;
				UGameplayStatics.GetAllActorsOfClassWithTag(GetThis(), UClass.GetClass<AActor>(), new FName("NiagaraStat"), out var OutActors);
				if (OutActors.Count > 0)
				{
					aActor = OutActors[0];
					string cmd = $"StartSkill {args[0]} {args[1]} {args[2]} {args[3]} {args[4]}";
					aActor.CallFunctionByNameWithArguments(cmd, forceCallWithNonExec: true);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void SetCanTriggerGroupAI(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0 && int.TryParse(args[0].ToLower(), out var result))
			{
				BGUFunctionLibraryCS.BGUSetCanTriggerGroupAI(GetThis(), result == 1);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void RunDiana(IntPtr NativeArgs)
	{
		try
		{
			string text = "Diana.Main";
			string text2 = FPaths.Combine(FPaths.ProjectDir, "Binaries", "Win64", "Managed", "Diana") + "\\" + text + ".exe";
			if (File.Exists(text2))
			{
				UGSE_EngineFuncLib.RunProcess(text2);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void LogLevelStreamingState(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			BGW_EventCollection.Get(GetThis()).Evt_LogLevelStreamingState(args.ToList());
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void LogCurrentRequestingLevelStateOperations(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			BGW_EventCollection.Get(GetThis()).Evt_LogCurrentRequestingLevelStateOperations(args.ToList());
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void LogProcessingStreamingLevels(IntPtr NativeArgs)
	{
		try
		{
			UBGUWCStreamingFuncLib.QueryProcessingStreamingLevels(GetThis());
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSShowDebugWidget(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length >= 2)
			{
				string text = args[0];
				AActor aActor = null;
				aActor = ((!(text == B1GlobalFNames.Player_Wukong.ToString())) ? BGU_DataUtil.GetActorByGuid(GetThis(), text) : UGameplayStatics.GetPlayerCharacter(GetThis(), 0));
				if (!(aActor == null) && int.TryParse(args[1].ToLower(), out var result))
				{
					BUS_EventCollectionCS.Get(aActor)?.Evt_SetDebugWidgetState.Invoke(result != 0);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnGSSetShowPreloadDetailInfoType(IntPtr NativeArgs)
	{
		try
		{
			string[] args = GetArgs(NativeArgs);
			if (args.Length != 0)
			{
				BGW_PreloadAssetMgr.Get(GetThis())?.SetPreloadResourceDetailInfoType(args.ToList());
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnRunStartMemReportAnalysis(IntPtr NativePtr)
	{
		try
		{
			foreach (b1.AutoQA.CrossLevel_AutoTest_Template testCase in BIS_AutoTestManagerV2.Get(GetThis()).TestCaseList)
			{
				if (!(testCase is b1.AutoQA.CrossLevel_AutoTest_StartMemReportAnalysis crossLevel_AutoTest_StartMemReportAnalysis))
				{
					continue;
				}
				string[] args = GetArgs(NativePtr);
				if (args.Length >= 1)
				{
					crossLevel_AutoTest_StartMemReportAnalysis.NeedExportClassList = args[0].Split(',').ToList();
					if (crossLevel_AutoTest_StartMemReportAnalysis.NeedExportClassList.Contains("All"))
					{
						crossLevel_AutoTest_StartMemReportAnalysis.NeedExportClassList = null;
					}
				}
				if (args.Length >= 2)
				{
					crossLevel_AutoTest_StartMemReportAnalysis.IsNeedExportMemReport = args[1] == "NeedExportMemReport";
				}
				crossLevel_AutoTest_StartMemReportAnalysis.RunTest();
				break;
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	static BGWConsoleCommands()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWConsoleCommands)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWConsoleCommands));
		PlayerGMLevelFlags = -1;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWConsoleCommands:GenerateArrow")]
	private static void GenerateArrow__Invoker(IntPtr buffer, IntPtr obj)
	{
		GenerateArrow();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGWConsoleCommands");
		GenerateArrow_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateArrow");
		GenerateArrow_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateArrow_FunctionAddress);
		GenerateArrow_IsValid = GenerateArrow_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWConsoleCommands:GenerateArrow", GenerateArrow_IsValid);
	}
}
