using System;
using System.Collections.Generic;
using System.IO;
using b1.AutoQA;
using b1.EventDelDefine;
using LitJson;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.FunctionalTesting;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class BIS_AutoTestManagerV2 : GameInstanceSystemBase
{
	private enum TestManagerState
	{
		Idle,
		RegisterCaseFromATP,
		RegisterCaseFromGM,
		ResetAllCaseStatus,
		SelectCase,
		RunCase,
		MonitorCaseState,
		DealCaseResult,
		TestComplete,
		TestInterrupted,
		FatalError
	}

	private enum TestManagerRunMode
	{
		ATPRun,
		GMRun
	}

	public class AtpConfigStruct
	{
		public string TargetMap { get; set; }

		public string AutoTestRunType { get; set; }

		public string AutoTestCustomList { get; set; }

		public string AutoTestSuiteName { get; set; }

		public string AutoMoveCaptureMode { get; set; }

		public bool AutoMoveSimpleTest { get; set; }

		public bool AutoMoveEnableSparsePoints { get; set; }

		public bool AutoMoveEnableEnemyAI { get; set; }

		public string AutoMoveStartPointIndex { get; set; }

		public string AdditionalConsoleCmds { get; set; }

		public AtpConfigStruct()
		{
			TargetMap = "HFS01_Persistentlevel";
			AutoTestRunType = "CustomList";
			AutoTestCustomList = "QAEnterMap,HFS_1_1_开场打青牛,HFS_2_1_苍狼林进山";
			AutoTestSuiteName = "HFS_MainStory";
			AutoMoveCaptureMode = "StatInfoCapture";
			AutoMoveSimpleTest = true;
			AutoMoveEnableSparsePoints = true;
			AutoMoveEnableEnemyAI = true;
			AutoMoveStartPointIndex = "0";
			AdditionalConsoleCmds = "stat fps";
		}
	}

	public string LogFolderPath = UPaths.ProjectSavedDir() + "/AutoTestLogs";

	public string TempFolderPath = UPaths.ProjectSavedDir() + "/AutoTestTemp";

	public bool AutoTestCanLog = !B1Global.GIsGameReleased;

	public bool WXLoginSuccess;

	public List<ICSharpTestCase> TestCasesToRun = new List<ICSharpTestCase>();

	public List<ICSharpTestCase> TestCaseList = new List<ICSharpTestCase>();

	public ICSharpTestCase CaseToRun;

	public UUserWidget GMInfo_Enemy;

	public FVector TargetLocation = new FVector(-120205.0, -1315.0, 5625.0);

	public DateTime SomeStartTime = DateTime.Now;

	public bool IsPlayingMV;

	public bool IsEndCredits;

	public bool IsInvincibleMode;

	public bool IsBossRushSettlement;

	private JsonData CaseResultData;

	private JsonData LastJsonData;

	private TestManagerState ManagerState;

	private AtpConfigStruct AtpConfigValues = new AtpConfigStruct();

	private float CurrentCaseTime;

	private TestManagerRunMode ManagerRunMode;

	private List<string> CaseNameList;

	private StreamWriter SWForTestMonitor;

	public Action NextTickInvoke;

	public AtpConfigStruct GetAtpConfigValues
	{
		get
		{
			return AtpConfigValues;
		}
		set
		{
			AtpConfigValues = value;
		}
	}

	public override bool bTickEnabled => true;

	public string RunningCaseName
	{
		get
		{
			if (CaseToRun == null)
			{
				return "CustomCase";
			}
			return CaseToRun.TestLabel;
		}
	}

	private string MonitorLogPath => LogFolderPath + "/TestMonitor.log";

	private string ResultFilePath => LogFolderPath + "/CaseResult.json";

	public static BIS_AutoTestManagerV2 Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BIS_AutoTestManagerV2>(WorldContext);
	}

	public bool IsIdleState()
	{
		return ManagerState == TestManagerState.Idle;
	}

	public void RunTestSuiteFromGM(string SuiteName)
	{
		if (!TestSuiteDef.TestSuiteDict.ContainsKey(SuiteName))
		{
			AutoTestHelperLib.QALog(base.Owner, "测试集" + SuiteName + "不存在，请查阅TestSuiteDef.cs，输入正确的名称");
			return;
		}
		if (ManagerState != TestManagerState.Idle || CaseToRun != null)
		{
			AutoTestHelperLib.QALog(base.Owner, "当前已有用例在执行，不能多开测试！");
			return;
		}
		TestCasesToRun.Clear();
		CaseNameList = new List<string>();
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(base.Owner);
		if (worldFromObj != null && worldFromObj.GetName() == "WXLogin_P")
		{
			CaseNameList.Add("QAWXLogin");
		}
		CaseNameList.AddRange(TestSuiteDef.TestSuiteDict[SuiteName]);
		TransferState(TestManagerState.ResetAllCaseStatus);
	}

	public void RunTestCasesFromGM(List<string> CasesName)
	{
		if (ManagerState != TestManagerState.Idle || CaseToRun != null)
		{
			AutoTestHelperLib.QALog(base.Owner, "当前已有用例在执行，不能多开测试！");
			return;
		}
		TestCasesToRun.Clear();
		CaseNameList = new List<string>();
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(base.Owner);
		if (worldFromObj != null && worldFromObj.GetName() == "WXLogin_P")
		{
			CaseNameList.Add("QAWXLogin");
		}
		foreach (string item in CasesName)
		{
			foreach (ICSharpTestCase testCase in TestCaseList)
			{
				if (testCase.TestLabel == item)
				{
					CaseNameList.Add(item);
				}
			}
		}
		if (CaseNameList.Count == 0)
		{
			AutoTestHelperLib.QALog(base.Owner, "输入的Case都不存在！请查阅TestSuiteDef.cs，输入正确的名称");
		}
		else
		{
			TransferState(TestManagerState.ResetAllCaseStatus);
		}
	}

	public void SkipCurrentCase()
	{
		if (CaseToRun != null)
		{
			MonitorLog("用户决定终止执行：" + CaseToRun.TestLabel);
			CaseToRun.HaltForReason(CaseState.UserSkip, "用户决定终止执行");
		}
		else
		{
			AutoTestHelperLib.QALog(base.Owner, "当前并没有任何测试用例在运行！");
		}
	}

	public void StopCurrentSuite()
	{
		if (ManagerState != TestManagerState.Idle || CaseToRun != null)
		{
			foreach (ICSharpTestCase item in TestCasesToRun)
			{
				if (item.GetCaseState() == CaseState.Pending || item.GetCaseState() == CaseState.Running)
				{
					MonitorLog("用户决定终止执行：" + item.TestLabel);
					item.HaltForReason(CaseState.UserSkip, "用户决定终止执行");
				}
			}
			return;
		}
		AutoTestHelperLib.QALog(base.Owner, "当前并没有任何测试集在运行！");
	}

	public override void OnInit()
	{
		RegisterAllCrossLevelTest();
		AutoTestCanLog = !B1Global.GIsGameReleased;
		UGSE_EngineFuncLib.LogWLevel("[AutoTestFrameWork] Prod Condition: " + B1Global.GIsGameReleased, 4);
		UGSE_EngineFuncLib.LogWLevel("[AutoTestFrameWork] AutoTestCanLog: " + AutoTestCanLog, 4);
		if (AutoTestCanLog)
		{
			try
			{
				if (FPlatformProperties.GetPlatform() == EPlatform.PS5)
				{
					LogFolderPath = "/devlog/app/b1/b1/saved/AutoTestLogs";
					TempFolderPath = "/devlog/app/b1/b1/saved/AutoTestTemp";
				}
				if (!Directory.Exists(LogFolderPath))
				{
					Directory.CreateDirectory(LogFolderPath);
				}
				if (!Directory.Exists(TempFolderPath))
				{
					Directory.CreateDirectory(TempFolderPath);
				}
			}
			catch (Exception ex)
			{
				AutoTestCanLog = false;
				UGSE_EngineFuncLib.LogWLevel("[AutoTestFrameWork] Can't make autotest log dir!", 4);
				UGSE_EngineFuncLib.LogWLevel("[AutoTestFrameWork] " + ex.ToString(), 4);
			}
		}
		if (UGSE_EngineFuncLib.HasLaunchOption("AutoTest") && LoadATPConfig())
		{
			ManagerRunMode = TestManagerRunMode.ATPRun;
			ManagerState = TestManagerState.RegisterCaseFromATP;
			if (UGSE_EngineFuncLib.HasLaunchOption("ContinueAutoTest") && File.Exists(ResultFilePath))
			{
				CaseResultData = JsonMapper.ToObject(File.ReadAllText(ResultFilePath));
			}
		}
		else
		{
			ManagerRunMode = TestManagerRunMode.GMRun;
			ManagerState = TestManagerState.Idle;
		}
	}

	public override void OnAttach()
	{
		base.OnAttach();
		USharpExceptionHandler.AddHandleFunc(HandleUSharpInvokeFunctionExcpetion, EUSharpExceptionType.InvokeFunction, IsMustInGameThread: true);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_UIActived = (Del_Void_IntBool)Delegate.Combine(bGW_EventCollection.Evt_UIActived, new Del_Void_IntBool(QAMonitorMVUI));
			bGW_EventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
		}
	}

	public override void OnShutdown()
	{
		SWForTestMonitor?.Close();
		USharpExceptionHandler.RemoveHandleFunc(HandleUSharpInvokeFunctionExcpetion, EUSharpExceptionType.InvokeFunction);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_UIActived = (Del_Void_IntBool)Delegate.Remove(bGW_EventCollection.Evt_UIActived, new Del_Void_IntBool(QAMonitorMVUI));
			bGW_EventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
		}
		base.OnShutdown();
	}

	private void QAMonitorMVUI(int PageID, bool IsInActiveShowing)
	{
		switch (PageID)
		{
		case 54:
			IsPlayingMV = IsInActiveShowing;
			break;
		case 71:
			IsEndCredits = IsInActiveShowing;
			break;
		case 92:
			IsBossRushSettlement = IsInActiveShowing;
			break;
		}
	}

	private void OnPlayerDelayBeginPlayFinished()
	{
		if (IsInvincibleMode)
		{
			APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner)?.GetControlledPawn();
			if (aPawn != null)
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aPawn, EBGUSimpleState.ImmueStiff, IsRemove: false);
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(aPawn, EBGUSimpleState.ImmueImmobilizing, IsRemove: false);
				USystemLibrary.ExecuteConsoleCommand(base.Owner, "b.LockHP", null);
			}
		}
	}

	private void HandleUSharpInvokeFunctionExcpetion(Exception e)
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass(base.Owner, UClass.GetClass<AFunctionalTest>());
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			(((AFunctionalTest)allActorsOfClass[i]) as ICSharpTestCase).HaltForReason(CaseState.Error, "检测到C#弹窗报错,请据此修改您的代码！\n" + e.ToString());
		}
		foreach (ICSharpTestCase testCase in TestCaseList)
		{
			testCase.HaltForReason(CaseState.Error, "检测到C#弹窗报错,请据此修改您的代码！\n" + e.ToString());
		}
		if (ManagerRunMode == TestManagerRunMode.ATPRun && CaseToRun == null)
		{
			if (!Directory.Exists(LogFolderPath))
			{
				Directory.CreateDirectory(LogFolderPath);
			}
			MonitorLog(DateTime.Now.ToString() + "|Error|" + e.ToString());
			MonitorLog("侦测到C#报错，将要从框架层退出");
			TransferState(TestManagerState.FatalError);
		}
	}

	private void RegisterAllCrossLevelTest()
	{
		Type typeFromHandle = typeof(b1.AutoQA.CrossLevel_AutoTest_Template);
		Type[] types = typeFromHandle.Assembly.GetTypes();
		foreach (Type type in types)
		{
			Type baseType = type.BaseType;
			if (baseType != null && baseType.Name == typeFromHandle.Name)
			{
				b1.AutoQA.CrossLevel_AutoTest_Template crossLevel_AutoTest_Template = type.Assembly.CreateInstance(type.FullName) as b1.AutoQA.CrossLevel_AutoTest_Template;
				crossLevel_AutoTest_Template.WorldContext = base.Owner;
				TestCaseList.Add(crossLevel_AutoTest_Template);
			}
		}
	}

	public void QAQuitGame()
	{
	}

	private void MonitorLog(string InString)
	{
		if (AutoTestCanLog)
		{
			if (SWForTestMonitor == null || SWForTestMonitor.BaseStream == null || !SWForTestMonitor.BaseStream.CanWrite)
			{
				SWForTestMonitor = new StreamWriter(MonitorLogPath, append: true)
				{
					AutoFlush = true
				};
			}
			SWForTestMonitor.WriteLine(DateTime.Now.ToString() + "|Info|" + InString);
			SWForTestMonitor.Flush();
		}
		UGSE_EngineFuncLib.LogWLevel("[AutoTestFrameWork] " + InString, 4);
	}

	private void RecordCaseState()
	{
		if (!AutoTestCanLog)
		{
			return;
		}
		JsonData jsonData = new JsonData { ["TestMonitor"] = ManagerState.ToString() };
		if (TestCasesToRun != null)
		{
			foreach (ICSharpTestCase item in TestCasesToRun)
			{
				jsonData[item.TestLabel] = item.GetCaseState().ToString();
			}
		}
		string text = jsonData.ToJson();
		string text2 = ((LastJsonData != null) ? LastJsonData.ToJson() : "");
		if (text != text2)
		{
			File.WriteAllText(ResultFilePath, text);
			LastJsonData = jsonData;
		}
	}

	private void TransferState(TestManagerState NextState)
	{
		ManagerState = NextState;
		CurrentCaseTime = 0f;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (NextTickInvoke != null)
		{
			NextTickInvoke();
			NextTickInvoke = null;
		}
		foreach (ICSharpTestCase testCase in TestCaseList)
		{
			testCase.OnTick(DeltaTime);
		}
		if (ManagerState != TestManagerState.Idle)
		{
			RecordCaseState();
		}
		switch (ManagerState)
		{
		case TestManagerState.RegisterCaseFromATP:
		{
			TestCasesToRun.Clear();
			CaseNameList = new List<string>();
			if (DebugConfig.GSSdkLoginChannel == "gamesci")
			{
				CaseNameList.Add("QAWXLogin");
			}
			string value = AtpConfigValues.AutoTestRunType.Trim();
			RunType runType = (RunType)Enum.Parse(typeof(RunType), value);
			if (runType == RunType.ReadSuite)
			{
				if (!TestSuiteDef.TestSuiteDict.ContainsKey(AtpConfigValues.AutoTestSuiteName))
				{
					MonitorLog("测试集" + AtpConfigValues.AutoTestSuiteName + "不存在，请查阅TestSuiteDef.cs，输入正确的名称");
					TransferState(TestManagerState.FatalError);
					break;
				}
				CaseNameList.AddRange(TestSuiteDef.TestSuiteDict[AtpConfigValues.AutoTestSuiteName]);
			}
			if (runType == RunType.CustomList)
			{
				string text = AtpConfigValues.AutoTestCustomList.Trim();
				CaseNameList.AddRange(text.Split(','));
			}
			TransferState(TestManagerState.ResetAllCaseStatus);
			break;
		}
		case TestManagerState.ResetAllCaseStatus:
		{
			SWForTestMonitor?.Close();
			if (File.Exists(MonitorLogPath))
			{
				File.Delete(MonitorLogPath);
			}
			if (File.Exists(ResultFilePath))
			{
				File.Delete(ResultFilePath);
			}
			foreach (string caseName in CaseNameList)
			{
				bool flag2 = false;
				foreach (ICSharpTestCase testCase2 in TestCaseList)
				{
					if (!(testCase2.TestLabel == caseName))
					{
						continue;
					}
					MonitorLog("收集到可执行用例：" + testCase2.TestLabel);
					if (CaseResultData != null && CaseResultData.Keys.Contains(testCase2.TestLabel))
					{
						CaseState caseState = (CaseState)Enum.Parse(typeof(CaseState), (string)CaseResultData[testCase2.TestLabel]);
						if (testCase2.GetCaseType() != CaseType.AutoReset)
						{
							testCase2.SetCaseState((caseState == CaseState.Running) ? CaseState.Crashed : caseState);
							MonitorLog("根据上次执行结果，将用例 " + testCase2.TestLabel + " 状态置为" + caseState);
						}
					}
					if (ManagerRunMode == TestManagerRunMode.GMRun)
					{
						testCase2.Reset();
					}
					TestCasesToRun.Add(testCase2);
					flag2 = true;
				}
				if (!flag2)
				{
					MonitorLog("未收集到用例：" + caseName);
				}
			}
			string[] array = AtpConfigValues.AdditionalConsoleCmds.Trim().Split(';');
			foreach (string text2 in array)
			{
				MonitorLog(text2);
				USystemLibrary.ExecuteConsoleCommand(base.Owner, text2, null);
			}
			USystemLibrary.ExecuteConsoleCommand(base.Owner, "UISetting.PlayerGuide 0", null);
			BGW_EventCollection.Get(base.Owner).Evt_SettingValueChanged(1, 0, UISettingConfigType.PlayerGuide);
			TransferState(TestManagerState.SelectCase);
			break;
		}
		case TestManagerState.SelectCase:
		{
			bool flag = false;
			foreach (ICSharpTestCase item in TestCasesToRun)
			{
				if (item.GetCaseState() == CaseState.Pending)
				{
					CaseToRun = item;
					MonitorLog("将执行" + CaseToRun.TestLabel + ",用例限时" + CaseToRun.TimeLimit);
					flag = true;
					break;
				}
			}
			if (flag)
			{
				TransferState(TestManagerState.RunCase);
				break;
			}
			MonitorLog("全部用例执行完成，将要退出");
			TransferState(TestManagerState.TestComplete);
			break;
		}
		case TestManagerState.RunCase:
			USystemLibrary.ExecuteConsoleCommand(base.Owner, "b.DBCLogEventQueue 1 300 0 180", null);
			MonitorLog("b.DBCLogEventQueue 1 300 0 180");
			CaseToRun.RunTest();
			MonitorLog("用例 " + RunningCaseName + " 执行中");
			TransferState(TestManagerState.MonitorCaseState);
			break;
		case TestManagerState.MonitorCaseState:
			CurrentCaseTime += DeltaTime;
			if (CaseToRun.GetCaseState() != CaseState.Running)
			{
				MonitorLog("用例" + RunningCaseName + "执行完成, 用时 " + CurrentCaseTime);
				TransferState(TestManagerState.DealCaseResult);
			}
			else if (CurrentCaseTime > CaseToRun.TimeLimit)
			{
				MonitorLog("用例 " + RunningCaseName + " 已超过限定时间 " + CaseToRun.TimeLimit + " 将主动退出");
				CaseToRun.HaltForReason(CaseState.Blocked, "用例超时退出");
				TransferState(TestManagerState.DealCaseResult);
			}
			break;
		case TestManagerState.DealCaseResult:
			if (CaseToRun.GetCaseState() == CaseState.UserSkip)
			{
				TransferState(TestManagerState.SelectCase);
			}
			else if (CaseToRun.GetCaseState() != CaseState.Succeeded && CaseToRun.GetCaseType() == CaseType.AutoReset)
			{
				MonitorLog("侦测到无法进图的问题，测试只能终止");
				TransferState(TestManagerState.TestComplete);
			}
			else if (CaseToRun.GetCaseState() == CaseState.Error)
			{
				MonitorLog("侦测到C#报错，为避免影响后续测试流程，将要退出游戏");
				TransferState(TestManagerState.TestInterrupted);
			}
			else if (CaseToRun.GetCaseState() != CaseState.Succeeded)
			{
				MonitorLog("侦测到流程问题，为避免影响后续测试流程，将要退出游戏");
				TransferState(TestManagerState.TestInterrupted);
			}
			else
			{
				TransferState(TestManagerState.SelectCase);
			}
			CaseToRun = null;
			break;
		case TestManagerState.TestComplete:
		case TestManagerState.TestInterrupted:
		case TestManagerState.FatalError:
			if (ManagerRunMode == TestManagerRunMode.ATPRun)
			{
				QAQuitGame();
			}
			if (ManagerRunMode == TestManagerRunMode.GMRun)
			{
				TransferState(TestManagerState.Idle);
			}
			break;
		case TestManagerState.Idle:
		case TestManagerState.RegisterCaseFromGM:
			break;
		}
	}

	public bool LoadATPConfig()
	{
		string text = UPaths.ProjectDir() + "/Tools/AutoMove/Config/AutoRunConfig.json";
		if (FPlatformProperties.GetPlatform() == EPlatform.PS5)
		{
			text = "/app0/b1/Tools/AutoMove/Config/AutoRunConfig.json";
		}
		try
		{
			string json_text = File.ReadAllText(text);
			AtpConfigValues = JsonMapper.ToObject<AtpConfigStruct>(new JsonReader(json_text));
			_ = AtpConfigValues;
		}
		catch (FileNotFoundException)
		{
			BGW_LogUtil.LogError("\n**** 错误！未找到 " + text + "! 请确认该文件存在。 ****");
			return false;
		}
		catch (DirectoryNotFoundException)
		{
			BGW_LogUtil.LogError("\n**** 错误！未找到 " + text + "! 请确认该文件存在。 ****");
			return false;
		}
		catch (JsonException arg)
		{
			BGW_LogUtil.LogError($"\n**** 错误！Json 数据解析异常: {arg} ****");
			return false;
		}
		return true;
	}
}
