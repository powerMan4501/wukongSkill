using System.Collections.Generic;
using System.IO;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_RecordUnitDead2File : AutoTestNodeLib.TestState_Node
{
	private readonly string RecordFilePath;

	private readonly string TamerBP;

	public TestState_RecordUnitDead2File(UObject WorldContext, string RecordFilePath, string TamerBP)
	{
		base.WorldContext = WorldContext;
		this.RecordFilePath = RecordFilePath;
		this.TamerBP = TamerBP;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		using (StreamWriter streamWriter = new StreamWriter(RecordFilePath, append: true))
		{
			streamWriter.WriteLine(TamerBP + "," + BIS_AutoTestManagerV2.Get(WorldContext).SomeStartTime.ToString());
		}
		Description = "在 " + RecordFilePath + " 中记录了 " + TamerBP + " 的帧率";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
