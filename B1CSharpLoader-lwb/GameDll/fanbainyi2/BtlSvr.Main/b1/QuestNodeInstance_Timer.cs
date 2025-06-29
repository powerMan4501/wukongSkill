using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_Timer : QuestNodeInstance
{
	[UClass]
	[USharpPath("/Script/b1-Managed.QuestTimerFuncBinder")]
	private class QuestTimerFuncBinder : UObject
	{
		private static bool OnStep_IsValid;

		private static IntPtr OnStep_FunctionAddress;

		private static int OnStep_ParamsSize;

		private static bool OnCompletion_IsValid;

		private static IntPtr OnCompletion_FunctionAddress;

		private static int OnCompletion_ParamsSize;

		public QuestNodeInstance_Timer Owner { get; set; }

		[UFunction]
		[USharpPath("/Script/b1-Managed.QuestTimerFuncBinder:OnStep")]
		protected void OnStep()
		{
			Owner.OnStep();
		}

		[UFunction]
		[USharpPath("/Script/b1-Managed.QuestTimerFuncBinder:OnCompletion")]
		protected void OnCompletion()
		{
			Owner.OnCompletion();
		}

		[UFunctionInvoker("/Script/b1-Managed.QuestTimerFuncBinder:OnStep")]
		private static void OnStep__Invoker(IntPtr buffer, IntPtr obj)
		{
			QuestTimerFuncBinder questTimerFuncBinder = GCHelper.Find<QuestTimerFuncBinder>(obj);
			questTimerFuncBinder.OnStep();
		}

		[UFunctionInvoker("/Script/b1-Managed.QuestTimerFuncBinder:OnCompletion")]
		private static void OnCompletion__Invoker(IntPtr buffer, IntPtr obj)
		{
			QuestTimerFuncBinder questTimerFuncBinder = GCHelper.Find<QuestTimerFuncBinder>(obj);
			questTimerFuncBinder.OnCompletion();
		}

		private static void LoadNativeType()
		{
			IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.QuestTimerFuncBinder");
			OnStep_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStep");
			OnStep_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStep_FunctionAddress);
			OnStep_IsValid = OnStep_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QuestTimerFuncBinder:OnStep", OnStep_IsValid);
			OnCompletion_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCompletion");
			OnCompletion_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCompletion_FunctionAddress);
			OnCompletion_IsValid = OnCompletion_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QuestTimerFuncBinder:OnCompletion", OnCompletion_IsValid);
		}

		static QuestTimerFuncBinder()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(QuestTimerFuncBinder)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(QuestTimerFuncBinder));
		}
	}

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

	private TStrongObjectPtr<QuestTimerFuncBinder> FuncBinderPtr { get; } = new TStrongObjectPtr<QuestTimerFuncBinder>();

	protected override void PostCreate()
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
		if (!FuncBinderPtr.IsValid())
		{
			QuestTimerFuncBinder questTimerFuncBinder = UObject.NewObject<QuestTimerFuncBinder>(base.Owner);
			questTimerFuncBinder.Owner = this;
			FuncBinderPtr.Set(questTimerFuncBinder);
		}
		if (CompletionTime == 0f)
		{
			LogError("Invalid Timer settings");
			TriggerOutput(PN_Completed, bFinish: true);
		}
		else if (InputPin == PN_In)
		{
			FTimerManager fTimerManager = FTimerManager.PIEWorld ?? FTimerManager.GameInstance;
			if (fTimerManager == null)
			{
				LogError("No valid world");
				TriggerOutput("Completed", bFinish: true);
				return;
			}
			if (StepTime > 0f)
			{
				StepTimerHandle = fTimerManager.SetTimer(FuncBinderPtr.Get(), "OnStep", StepTime, looping: true);
			}
			CompletionTimerHandle = fTimerManager.SetTimer(FuncBinderPtr.Get(), "OnCompletion", CompletionTime);
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

	public override byte[] GetNodeCustomData()
	{
		return BitConverter.GetBytes(SumOfStepTime);
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
		SumOfStepTime = BitConverter.ToSingle(CustomData, 0);
	}

	public override void RecoverActiveState()
	{
		if (CompletionTime == 0f)
		{
			LogError("Invalid Timer settings");
			TriggerOutput(PN_Completed, bFinish: true);
			return;
		}
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
			StepTimerHandle = fTimerManager.SetTimer(FuncBinderPtr.Get(), "OnStep", StepTime, looping: true);
		}
		CompletionTimerHandle = fTimerManager.SetTimer(FuncBinderPtr.Get(), "OnCompletion", CompletionTime - SumOfStepTime);
	}
}
