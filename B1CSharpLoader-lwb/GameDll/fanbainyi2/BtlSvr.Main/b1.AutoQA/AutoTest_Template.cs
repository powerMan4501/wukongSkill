using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.FunctionalTesting;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[Blueprintable]
[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AutoTest_Template")]
internal class AutoTest_Template : AFunctionalTest, ICSharpTestCase
{
	protected Stack<AutoTestNodeLib.TestState_Node> StateStack = new Stack<AutoTestNodeLib.TestState_Node>();

	public CaseState CurrentCaseState;

	private CaseState ErrorCaseState;

	private AutoTestNodeLib.NodeState CurrentState;

	private string ErrorString;

	private bool PlayerDelayBeginPlayFinished;

	private float CurrentInterval;

	private static bool RunTest_IsValid;

	private static IntPtr RunTest_FunctionAddress;

	private static int RunTest_ParamsSize;

	private static bool StopTest_IsValid;

	private static IntPtr StopTest_FunctionAddress;

	private static int StopTest_ParamsSize;

	private static bool SetupTest_IsValid;

	private static IntPtr SetupTest_FunctionAddress;

	private static int SetupTest_ParamsSize;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaTime_IsValid;

	private static int ReceiveTick_DeltaTime_Offset;

	private static bool ReceiveStartTest_IsValid;

	private static IntPtr ReceiveStartTest_FunctionAddress;

	private static int ReceiveStartTest_ParamsSize;

	public UObject WorldContext
	{
		get
		{
			return this;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual float TickInterval { get; } = 0.5f;

	public virtual void Reset()
	{
		StateStack = new Stack<AutoTestNodeLib.TestState_Node>();
		CurrentCaseState = CaseState.Pending;
		ErrorCaseState = CaseState.Pending;
		ErrorString = null;
		PlayerDelayBeginPlayFinished = false;
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

	public virtual CaseType GetCaseType()
	{
		return CaseType.Normal;
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

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTest_Template:SetupTest")]
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

	public void MoveToActionTimeOut(FVector TargetLocation)
	{
		HaltForReason(CaseState.Blocked, "MoveToActionTimeOut");
	}

	public void EQSRunActionTimeOut(FVector TargetLocation)
	{
		HaltForReason(CaseState.Blocked, "EQSRunActionTimeOut");
	}

	public void ComboActionTimeOut(AActor Enemy)
	{
		BUS_EventCollectionCS.Get(Enemy).Evt_UnitDead.Invoke(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn(), EDeadReason.SkillDamage);
	}

	[USharpPath("/Script/b1-Managed.AutoTest_Template:ReceiveStartTest")]
	protected override void ReceiveStartTest_Implementation()
	{
		RunTest();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.AutoTest_Template:RunTest")]
	public void RunTest()
	{
		if (!UGSE_EngineFuncLib.IsClient(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext)))
		{
			SetupTest();
			PlayerDelayBeginPlayFinished = false;
			base.PrimaryActorTick.SetCanEverTick(canEverTick: true);
			StateStack.Clear();
			RegisterTestState();
			base.OnTestFinished.Clear();
			base.OnTestFinished.Bind(StopTest);
			StateStack = new Stack<AutoTestNodeLib.TestState_Node>(StateStack);
			BIS_AutoTestManagerV2.Get(WorldContext).CaseToRun = this;
			SetCaseState(CaseState.Running);
			AutoTestLoggerLib.QALogStart(WorldContext, base.Description + "开始");
			if (ErrorString != null)
			{
				HaltForReason(ErrorCaseState, ErrorString);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.AutoTest_Template:StopTest")]
	public void StopTest()
	{
		TearDownTest();
		base.PrimaryActorTick.SetCanEverTick(canEverTick: false);
		if (FGlobals.IsEditor)
		{
			UGSE_EngineFuncLib.QuitGame(WorldContext);
		}
	}

	[USharpPath("/Script/b1-Managed.AutoTest_Template:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaTime)
	{
		if (GetCaseState() != CaseState.Running)
		{
			return;
		}
		CurrentInterval += DeltaTime;
		if (CurrentInterval < TickInterval)
		{
			return;
		}
		if (!PlayerDelayBeginPlayFinished)
		{
			AutoTestLoggerLib.QALogInfo(WorldContext, "等待主角初始化完成中");
			BUC_UnitDebugData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitDebugData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn());
			if (unPersistentReadOnlyData != null)
			{
				PlayerDelayBeginPlayFinished = unPersistentReadOnlyData.IsPlayerDelayBeginPlayFinished;
			}
			return;
		}
		if (StateStack.Count == 0)
		{
			AutoTestLoggerLib.QALogEnd(WorldContext, base.Description + "完成");
			SetCaseState(CaseState.Succeeded);
			FinishTest(EFunctionalTestResult.Succeeded, base.Description + "通过");
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

	public void OnTick(float DeltaTime)
	{
		ReceiveTick_Implementation(DeltaTime);
	}

	float ICSharpTestCase.get_TimeLimit()
	{
		return base.TimeLimit;
	}

	string ICSharpTestCase.get_TestLabel()
	{
		return base.TestLabel;
	}

	bool ICSharpTestCase.IsEnabled()
	{
		return IsEnabled();
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTest_Template:RunTest")]
	private static void RunTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AutoQA.AutoTest_Template autoTest_Template = GCHelper.Find<b1.AutoQA.AutoTest_Template>(obj);
		autoTest_Template.RunTest();
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTest_Template:StopTest")]
	private static void StopTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AutoQA.AutoTest_Template autoTest_Template = GCHelper.Find<b1.AutoQA.AutoTest_Template>(obj);
		autoTest_Template.StopTest();
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTest_Template:SetupTest")]
	private static void SetupTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AutoQA.AutoTest_Template autoTest_Template = GCHelper.Find<b1.AutoQA.AutoTest_Template>(obj);
		autoTest_Template.SetupTest();
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTest_Template:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AutoQA.AutoTest_Template autoTest_Template = GCHelper.Find<b1.AutoQA.AutoTest_Template>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaTime_Offset));
		autoTest_Template.ReceiveTick_Implementation(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.AutoTest_Template:ReceiveStartTest")]
	private static void ReceiveStartTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.AutoQA.AutoTest_Template autoTest_Template = GCHelper.Find<b1.AutoQA.AutoTest_Template>(obj);
		autoTest_Template.ReceiveStartTest_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.AutoTest_Template");
		RunTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RunTest");
		RunTest_ParamsSize = NativeReflection.GetFunctionParamsSize(RunTest_FunctionAddress);
		RunTest_IsValid = RunTest_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTest_Template:RunTest", RunTest_IsValid);
		StopTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopTest");
		StopTest_ParamsSize = NativeReflection.GetFunctionParamsSize(StopTest_FunctionAddress);
		StopTest_IsValid = StopTest_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTest_Template:StopTest", StopTest_IsValid);
		SetupTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetupTest");
		SetupTest_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupTest_FunctionAddress);
		SetupTest_IsValid = SetupTest_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTest_Template:SetupTest", SetupTest_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaTime_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaTime");
		ReceiveTick_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTest_Template:ReceiveTick", ReceiveTick_IsValid);
		ReceiveStartTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveStartTest");
		ReceiveStartTest_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveStartTest_FunctionAddress);
		ReceiveStartTest_IsValid = ReceiveStartTest_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.AutoTest_Template:ReceiveStartTest", ReceiveStartTest_IsValid);
	}

	static AutoTest_Template()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.AutoQA.AutoTest_Template)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.AutoQA.AutoTest_Template));
	}
}
