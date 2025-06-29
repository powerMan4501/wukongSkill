using UnrealEngine.Runtime;

namespace b1;

public class PsmNodeInstance_SubMachine : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[14]
	{
		B1CalliopeDef.ProcessMachineNode.BattlePaceController,
		B1CalliopeDef.ProcessMachineNode.Idle,
		B1CalliopeDef.ProcessMachineNode.Story,
		B1CalliopeDef.ProcessMachineNode.Battle,
		B1CalliopeDef.ProcessMachineNode.SaveArchive,
		B1CalliopeDef.ProcessMachineNode.Group,
		B1CalliopeDef.ProcessMachineNode.ReportOSS,
		B1CalliopeDef.GuideNode.Mark,
		B1CalliopeDef.GuideNode.Listener,
		B1CalliopeDef.BossRushNode.Idle,
		B1CalliopeDef.BossRushNode.Story,
		B1CalliopeDef.BossRushNode.Battle,
		B1CalliopeDef.BossRushNode.Group,
		B1CalliopeDef.BossRushNode.Wait
	};

	private PsmSubMachine SubMachine { get; set; }

	public override void PostCreate()
	{
		SubMachine = FPsmSubMachineFactory.CreateInstance(base.Node.NodeClass);
		SubMachine.ParentNodeInstance = this;
		SubMachine.PostCreate();
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (SubMachine == null)
		{
			TriggerFirstOutput(bFinish: true);
			return;
		}
		SubMachine.TerminateCallBack = OnSubMachineTerminate;
		SubMachine.Start();
	}

	private void OnSubMachineTerminate(string TerminateTag)
	{
		if (SubMachine != null && SubMachine.IsGroupNode(out var GroupName))
		{
			base.ParentInstance.TerminateGroup(GroupName);
		}
		if (string.IsNullOrEmpty(TerminateTag))
		{
			TriggerOutput(BGW_FlowUtils.PinName.StateMachineFinished.PlainName, bFinish: true);
		}
		else
		{
			TriggerOutput(TerminateTag, bFinish: true);
		}
	}

	public override void OnEvent(FGameplayTag EventTag)
	{
		SubMachine.OnEvent(EventTag);
	}

	public override void Tick(float DeltaTime)
	{
		SubMachine.OnTick(DeltaTime);
	}

	protected override void Finish()
	{
		base.Finish();
		SubMachine.Shutdown();
	}

	public override void Shutdown()
	{
		base.Shutdown();
		SubMachine.Shutdown();
	}

	public override void RecoverActiveState()
	{
		if (string.IsNullOrEmpty(base.CurrentGroupName))
		{
			if (SubMachine.TerminateCallBack == null)
			{
				SubMachine.TerminateCallBack = OnSubMachineTerminate;
			}
			SubMachine.OnRecover();
		}
		else
		{
			Finish();
		}
	}

	public override void OnReset()
	{
		if (base.Node.OutputEdges.ContainsKey(BGW_FlowUtils.PinName.Reset.PlainName))
		{
			TriggerOutput(BGW_FlowUtils.PinName.Reset.PlainName, bFinish: true);
		}
		else if (string.IsNullOrEmpty(base.CurrentGroupName))
		{
			if (SubMachine.TerminateCallBack == null)
			{
				SubMachine.TerminateCallBack = OnSubMachineTerminate;
			}
			SubMachine.OnReset();
		}
		else
		{
			Finish();
		}
	}

	public override bool CheckNodeQueryable(out string ErrorMassager)
	{
		return SubMachine.CheckNodeQueryable(out ErrorMassager);
	}

	public string GetName()
	{
		return SubMachine.GetType().ToString();
	}
}
