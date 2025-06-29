using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.FunctionalTesting;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

internal abstract class CrossLevel_AutoTest_Template : ICSharpTestCase
{
	protected Stack<AutoTestNodeLib.TestState_Node> StateStack = new Stack<AutoTestNodeLib.TestState_Node>();

	public CaseState CurrentCaseState;

	private CaseState ErrorCaseState;

	private AutoTestNodeLib.NodeState CurrentState;

	private string ErrorString;

	private float CurrentInterval;

	public abstract string TestLabel { get; }

	public virtual bool bIsEnabled { get; } = true;

	public virtual string Description => TestLabel;

	public virtual float TimeLimit { get; } = 1800f;

	public virtual float TickInterval { get; } = 0.5f;

	public UObject WorldContext { get; set; }

	public void FinishTest(EFunctionalTestResult TestResult, string Message)
	{
	}

	public bool IsEnabled()
	{
		return bIsEnabled;
	}

	public virtual void Reset()
	{
		StateStack = new Stack<AutoTestNodeLib.TestState_Node>();
		CurrentCaseState = CaseState.Pending;
		ErrorCaseState = CaseState.Pending;
		ErrorString = null;
		CurrentInterval = 0f;
	}

	public void SetCaseState(CaseState NewState)
	{
		CurrentCaseState = NewState;
	}

	public CaseState GetCaseState()
	{
		return CurrentCaseState;
	}

	public string GetTestState()
	{
		return StateStack.Peek().ToString();
	}

	public void HaltForReason(CaseState State, string Reason)
	{
		if (GetCaseState() == CaseState.Running)
		{
			AutoTestLoggerLib.QALogError(WorldContext, Reason);
			SetCaseState(State);
			FinishTest((State == CaseState.Error) ? EFunctionalTestResult.Error : EFunctionalTestResult.Failed, Reason);
			StopTest();
		}
		else
		{
			ErrorCaseState = State;
			ErrorString = Reason;
		}
	}

	public virtual CaseType GetCaseType()
	{
		return CaseType.Normal;
	}

	public virtual void SetupTest()
	{
	}

	protected virtual void RegisterTestState()
	{
	}

	public virtual void TearDownTest()
	{
		UGSE_ProfilerFuncLib.StopRecordingPerfChart();
	}

	public void RunTest()
	{
		if (!UGSE_EngineFuncLib.IsClient(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext)))
		{
			SetupTest();
			StateStack.Clear();
			RegisterTestState();
			StateStack = new Stack<AutoTestNodeLib.TestState_Node>(StateStack);
			BIS_AutoTestManagerV2.Get(WorldContext).CaseToRun = this;
			SetCaseState(CaseState.Running);
			AutoTestLoggerLib.QALogStart(WorldContext, Description + "开始");
			if (ErrorString != null)
			{
				HaltForReason(ErrorCaseState, ErrorString);
			}
		}
	}

	public void StopTest()
	{
		TearDownTest();
	}

	public void OnTick(float DeltaTime)
	{
		if (GetCaseState() != CaseState.Running)
		{
			return;
		}
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn();
		if (controlledPawn != null)
		{
			BUC_PreciseDodgeData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PreciseDodgeData>(controlledPawn);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.CurrentPreciseDodgeTimeSeconds > 0f)
			{
				AutoTestHelperLib.Dodge(WorldContext);
				return;
			}
		}
		CurrentInterval += DeltaTime;
		if (CurrentInterval < TickInterval)
		{
			return;
		}
		if (StateStack.Count == 0)
		{
			AutoTestLoggerLib.QALogEnd(WorldContext, this.Description + "完成");
			SetCaseState(CaseState.Succeeded);
			FinishTest(EFunctionalTestResult.Succeeded, this.Description + "通过");
			StopTest();
			return;
		}
		CurrentState = StateStack.Peek().OnTick(out var Description, ref StateStack, CurrentInterval);
		if (Description != null)
		{
			AutoTestLoggerLib.QALogInfo(WorldContext, Description);
		}
		switch (CurrentState)
		{
		case AutoTestNodeLib.NodeState.Succeeded:
			StateStack.Pop();
			break;
		case AutoTestNodeLib.NodeState.Failed:
			HaltForReason(CaseState.Failed, Description);
			break;
		}
		CurrentInterval = 0f;
	}
}
