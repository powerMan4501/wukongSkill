using System.Text;

namespace b1;

public class PsmNodeInstance_GroupStart : PsmNodeInstance
{
	public override string[] SupportNodeClasses => new string[2]
	{
		B1CalliopeDef.ProcessMachineNode.GroupStart,
		B1CalliopeDef.BossRushNode.GroupStart
	};

	private string GroupName { get; set; }

	public override void PostCreate()
	{
		GroupName = Encoding.UTF8.GetString(base.Node.NodeData);
		if (base.ParentInstance != null)
		{
			base.ParentInstance.RegisterGroupStartNodeInstance(GroupName, this);
		}
	}

	protected override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: true);
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
