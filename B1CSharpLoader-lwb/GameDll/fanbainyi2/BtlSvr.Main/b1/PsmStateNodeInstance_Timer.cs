using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class PsmStateNodeInstance_Timer : PsmStateNodeInstance
{
	[UClass]
	[USharpPath("/Script/b1-Managed.ProcessTimerFunctionFinder")]
	public class UProcessTimerFunctionFinder : UObject
	{
		private static bool OnStep_IsValid;

		private static IntPtr OnStep_FunctionAddress;

		private static int OnStep_ParamsSize;

		private static bool OnCompletion_IsValid;

		private static IntPtr OnCompletion_FunctionAddress;

		private static int OnCompletion_ParamsSize;

		public PsmStateNodeInstance_Timer Parent { get; set; }

		[UFunction]
		[USharpPath("/Script/b1-Managed.ProcessTimerFunctionFinder:OnStep")]
		private void OnStep()
		{
			Parent?.OnStep();
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.ProcessTimerFunctionFinder:OnCompletion")]
		private void OnCompletion()
		{
			Parent?.OnCompletion();
		}

		[UFunctionInvoker("/Script/b1-Managed.ProcessTimerFunctionFinder:OnStep")]
		private static void OnStep__Invoker(IntPtr buffer, IntPtr obj)
		{
			UProcessTimerFunctionFinder uProcessTimerFunctionFinder = GCHelper.Find<UProcessTimerFunctionFinder>(obj);
			uProcessTimerFunctionFinder.OnStep();
		}

		[UFunctionInvoker("/Script/b1-Managed.ProcessTimerFunctionFinder:OnCompletion")]
		private static void OnCompletion__Invoker(IntPtr buffer, IntPtr obj)
		{
			UProcessTimerFunctionFinder uProcessTimerFunctionFinder = GCHelper.Find<UProcessTimerFunctionFinder>(obj);
			uProcessTimerFunctionFinder.OnCompletion();
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.ProcessTimerFunctionFinder");
			OnStep_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStep");
			OnStep_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStep_FunctionAddress);
			OnStep_IsValid = OnStep_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.ProcessTimerFunctionFinder:OnStep", OnStep_IsValid);
			OnCompletion_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCompletion");
			OnCompletion_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCompletion_FunctionAddress);
			OnCompletion_IsValid = OnCompletion_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.ProcessTimerFunctionFinder:OnCompletion", OnCompletion_IsValid);
		}

		static UProcessTimerFunctionFinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(UProcessTimerFunctionFinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(UProcessTimerFunctionFinder));
		}
	}

	public override string NodeClass => "Process.State.Timer";

	protected float CompletionTime { get; set; }

	protected float StepTime { get; set; }

	private FTimerHandle CompletionTimerHandle { get; set; }

	private FTimerHandle StepTimerHandle { get; set; }

	private float SumOfStepTime { get; set; }

	private string PN_In => BGW_FlowUtils.PinName.In.PlainName;

	private string PN_Completed => BGW_FlowUtils.PinName.Completed.PlainName;

	private string PN_Skip => BGW_FlowUtils.PinName.Skip.PlainName;

	private string PN_Step => BGW_FlowUtils.PinName.Step.PlainName;

	private string PN_Skipped => BGW_FlowUtils.PinName.Skip.PlainName;

	private QuestCustom_Timer CustomData { get; set; }

	private TStrongObjectPtr<UProcessTimerFunctionFinder> ProcessTimerFunctionFinder { get; set; }

	public override void PostCreate()
	{
		CustomData = new QuestCustom_Timer();
		CustomData.MergeFrom(base.Node.NodeData);
		CompletionTime = CustomData.CompletionTime;
		StepTime = CustomData.StepTime;
		SumOfStepTime = 0f;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (ProcessTimerFunctionFinder == null || !ProcessTimerFunctionFinder.IsValid())
		{
			ProcessTimerFunctionFinder = new TStrongObjectPtr<UProcessTimerFunctionFinder>(UObject.NewObject<UProcessTimerFunctionFinder>(GetOwner()));
			ProcessTimerFunctionFinder.Get().Parent = this;
		}
		if (CompletionTime == 0f)
		{
			LogError("Invalid Timer settings");
			TriggerOutput(PN_Completed, bFinish: true);
		}
		else if (InputPin == PN_In)
		{
			if (CompletionTimerHandle.IsValid || StepTimerHandle.IsValid)
			{
				LogError("Timer already active");
				return;
			}
			FTimerManager fTimerManager = FTimerManager.PIEWorld ?? FTimerManager.GameInstance;
			if (fTimerManager == null)
			{
				LogError("No valid world");
				TriggerOutput("Completed", bFinish: true);
				return;
			}
			if (StepTime > 0f)
			{
				StepTimerHandle = fTimerManager.SetTimer(ProcessTimerFunctionFinder.Get(), "OnStep", StepTime, looping: true);
			}
			CompletionTimerHandle = fTimerManager.SetTimer(ProcessTimerFunctionFinder.Get(), "OnCompletion", CompletionTime);
		}
		else if (InputPin == PN_Skip)
		{
			TriggerOutput(PN_Skipped, bFinish: true);
		}
	}

	private void OnStep()
	{
		SumOfStepTime += StepTime;
		if (SumOfStepTime >= CompletionTime)
		{
			TriggerOutput(PN_Completed, bFinish: true);
		}
		else
		{
			TriggerOutput(PN_Step, bFinish: false);
		}
	}

	private void OnCompletion()
	{
		TriggerOutput(PN_Completed, bFinish: true);
	}

	public override void Shutdown()
	{
		Finish();
		ProcessTimerFunctionFinder.Set(null);
		ProcessTimerFunctionFinder = null;
	}

	protected override void Finish()
	{
		FTimerManager fTimerManager = FTimerManager.PIEWorld ?? FTimerManager.GameInstance;
		if (fTimerManager != null)
		{
			FTimerHandle handle = CompletionTimerHandle;
			fTimerManager.ClearTimer(ref handle);
		}
		CompletionTimerHandle.Invalidate();
		if (fTimerManager != null)
		{
			FTimerHandle handle2 = StepTimerHandle;
			fTimerManager.ClearTimer(ref handle2);
		}
		StepTimerHandle.Invalidate();
		SumOfStepTime = 0f;
		base.Finish();
	}
}
