using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_Timer")]
public class MovieNodeInstance_Timer : MovieNodeInstance
{
	private static bool OnStep_IsValid;

	private static IntPtr OnStep_FunctionAddress;

	private static int OnStep_ParamsSize;

	private static bool OnCompletion_IsValid;

	private static IntPtr OnCompletion_FunctionAddress;

	private static int OnCompletion_ParamsSize;

	protected float CompletionTime { get; set; }

	protected float StepTime { get; set; }

	private FTimerHandle CompletionTimerHandle { get; set; }

	private FTimerHandle StepTimerHandle { get; set; }

	private float SumOfSteps { get; set; }

	private string PN_In => BGW_FlowUtils.PinName.In.PlainName;

	private string PN_Completed => BGW_FlowUtils.PinName.Completed.PlainName;

	private string PN_Step => BGW_FlowUtils.PinName.Step.PlainName;

	private MovieCustom_Timer CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_Timer();
		CustomData.MergeFrom(base.Node.NodeData);
		CompletionTime = CustomData.CompletionTime;
		StepTime = CustomData.StepTime;
		SumOfSteps = 0f;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (CompletionTime == 0f)
		{
			LogError("Invalid Timer settings");
			TriggerOutput(PN_Completed, bFinish: true);
		}
		else
		{
			if (!(InputPin == PN_In))
			{
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
				StepTimerHandle = fTimerManager.SetTimer(this, "OnStep", StepTime, looping: true);
			}
			CompletionTimerHandle = fTimerManager.SetTimer(this, "OnCompletion", CompletionTime);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.MovieNodeInstance_Timer:OnStep")]
	protected void OnStep()
	{
		SumOfSteps += StepTime;
		if (SumOfSteps >= CompletionTime)
		{
			TriggerOutput(PN_Completed, bFinish: true);
		}
		else
		{
			TriggerOutput(PN_Step, bFinish: false);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.MovieNodeInstance_Timer:OnCompletion")]
	protected void OnCompletion()
	{
		TriggerOutput(PN_Completed, bFinish: true);
		Finish();
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
		SumOfSteps = 0f;
		base.Finish();
	}

	[UFunctionInvoker("/Script/b1-Managed.MovieNodeInstance_Timer:OnStep")]
	private static void OnStep__Invoker(IntPtr buffer, IntPtr obj)
	{
		MovieNodeInstance_Timer movieNodeInstance_Timer = GCHelper.Find<MovieNodeInstance_Timer>(obj);
		movieNodeInstance_Timer.OnStep();
	}

	[UFunctionInvoker("/Script/b1-Managed.MovieNodeInstance_Timer:OnCompletion")]
	private static void OnCompletion__Invoker(IntPtr buffer, IntPtr obj)
	{
		MovieNodeInstance_Timer movieNodeInstance_Timer = GCHelper.Find<MovieNodeInstance_Timer>(obj);
		movieNodeInstance_Timer.OnCompletion();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_Timer");
		OnStep_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnStep");
		OnStep_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStep_FunctionAddress);
		OnStep_IsValid = OnStep_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MovieNodeInstance_Timer:OnStep", OnStep_IsValid);
		OnCompletion_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCompletion");
		OnCompletion_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCompletion_FunctionAddress);
		OnCompletion_IsValid = OnCompletion_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MovieNodeInstance_Timer:OnCompletion", OnCompletion_IsValid);
	}

	static MovieNodeInstance_Timer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_Timer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_Timer));
	}
}
