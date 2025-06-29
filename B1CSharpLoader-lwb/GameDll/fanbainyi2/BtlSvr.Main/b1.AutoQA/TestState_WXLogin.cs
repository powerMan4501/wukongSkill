using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_WXLogin : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Begin,
		WXLogin,
		Finish
	}

	private InnerState CurrentState;

	private int TickCounter;

	private string Username;

	private string Password;

	private bool BUI_StartGame_Appeared;

	public TestState_WXLogin(UObject WorldContext, string Username, string Password)
	{
		base.WorldContext = WorldContext;
		this.Username = Username;
		this.Password = Password;
	}

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "执行中";
		switch (CurrentState)
		{
		case InnerState.Begin:
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "EnableAllScreenMessages", null);
			DebugConfig.DebugStartWithOutArchive = true;
			Description = "游戏开始，先等10s，等界面载入完成";
			if (TickCounter >= 10)
			{
				TransferState(InnerState.WXLogin);
			}
			break;
		case InnerState.WXLogin:
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "EnableAllScreenMessages", null);
			if (GetCurLevelName() == "WXLogin_P")
			{
				string text = BGW_GSAutoTestUtil.GSAutoTestLogin(WorldContext, Username, Password);
				if (!string.IsNullOrEmpty(text))
				{
					Description = "[TestState_AutoEnterMainMap] Login Failed, ErrorMsg: " + text;
					return AutoTestNodeLib.NodeState.Failed;
				}
				UClass uClass = null;
				uClass = BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/StartGame/BUI_StartGame.BUI_StartGame_C'", ELoadResourceType.SyncLoadAndCache);
				if (!(uClass == null))
				{
					UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets, uClass, TopLevelOnly: false);
					if (FoundWidgets.Count > 0 && !BUI_StartGame_Appeared)
					{
						Description = "自动登录成功";
						TransferState(InnerState.Finish);
					}
					if (BUI_StartGame_Appeared)
					{
					}
				}
			}
			else if (GetCurLevelName() == "Startup_V2_P")
			{
				TransferState(InnerState.Finish);
			}
			break;
		case InnerState.Finish:
			Description = "自动登录完成";
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "进入错误状态";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}

	private string GetCurLevelName()
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
		if (worldFromObj != null)
		{
			return worldFromObj.GetName();
		}
		return "";
	}
}
