using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class PsmNodeInstance_State : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.ProcessMachineNode.State };

	private ProcessCustom_State CustomData { get; set; }

	private PsmStateInstance StateInstance { get; set; }

	public override void PostCreate()
	{
		CustomData = new ProcessCustom_State();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ParentInstance.RegisterStateNodeInstance(CustomData.StateName, this);
		if (base.ParentInstance.TryGetStateInstance(CustomData.StateName, out var StateInstance))
		{
			this.StateInstance = StateInstance;
		}
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		StateInstance?.OnEnterAction();
	}

	public override void OnEvent(FGameplayTag EventTag)
	{
		if (base.Node.OutputEdges.ContainsKey(EventTag.TagName.PlainName))
		{
			TriggerOutput(EventTag.TagName.PlainName, bFinish: true);
		}
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		StateInstance?.OnTickAction(DeltaTime);
	}

	protected override void Finish()
	{
		base.Finish();
		if (!base.ParentInstance.IsInReset())
		{
			StateInstance?.OnExitAction();
		}
	}

	public override void Shutdown()
	{
		StateInstance?.Shutdown();
		StateInstance = null;
		base.Shutdown();
	}

	public override void RecoverActiveState()
	{
		StateInstance?.OnResetAction();
		if (base.Node.OutputEdges.ContainsKey(BGW_FlowUtils.PinName.Reset.PlainName))
		{
			TriggerOutput(BGW_FlowUtils.PinName.Reset.PlainName, bFinish: true);
		}
	}
}
