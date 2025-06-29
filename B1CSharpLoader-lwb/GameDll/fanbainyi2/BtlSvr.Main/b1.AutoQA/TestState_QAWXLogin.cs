using System;
using System.Collections;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_QAWXLogin : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		TryToLogin,
		WatchLoginResult
	}

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
	}

	public TestState_QAWXLogin(UObject WorldContext)
	{
		base.WorldContext = WorldContext;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		switch (CurrentState)
		{
		case InnerState.TryToLogin:
		{
			DebugConfig.DebugStartWithOutArchive = true;
			string text = null;
			string text2 = null;
			if (FPlatformProperties.GetPlatform() == EPlatform.Windows)
			{
				IDictionary environmentVariables = Environment.GetEnvironmentVariables();
				if (!environmentVariables.Contains("AutoTestUserName"))
				{
					Description = "错误！未读取到自动登录用户";
					return AutoTestNodeLib.NodeState.Failed;
				}
				text = environmentVariables["AutoTestUserName"].ToString();
				if (!environmentVariables.Contains("AutoTestUserPass"))
				{
					Description = "错误！未读取到自动登录密码";
					return AutoTestNodeLib.NodeState.Failed;
				}
				text2 = environmentVariables["AutoTestUserPass"].ToString();
			}
			else
			{
				text = "pt001";
				text2 = "sUup9V54dPHHHTws";
			}
			UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext);
			if (worldFromObj != null && worldFromObj.GetName() == "WXLogin_P")
			{
				BGW_GSAutoTestUtil.GSAutoTestLogin(WorldContext, text, text2);
				Description = "发起了自动登录";
				StateStack.Push(new AutoTestNodeLib.TestState_Wait(WorldContext, 10));
				TransferState(InnerState.WatchLoginResult);
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "进入WXLogin_P关卡失败";
			return AutoTestNodeLib.NodeState.Failed;
		}
		case InnerState.WatchLoginResult:
			if (BIS_AutoTestManagerV2.Get(WorldContext).WXLoginSuccess)
			{
				Description = "自动登录成功";
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			Description = "自动登录失败";
			return AutoTestNodeLib.NodeState.Failed;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
	}
}
