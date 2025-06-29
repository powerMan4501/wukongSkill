using System.Collections.Generic;
using System.IO;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_TextRecord : AutoTestNodeLib.TestState_Node
{
	private readonly string StartFilePath;

	private readonly string NameToRecord;

	public TestState_TextRecord(UObject WorldContext, string StartFilePath, string NameToRecord)
	{
		base.WorldContext = WorldContext;
		this.StartFilePath = StartFilePath;
		this.NameToRecord = NameToRecord;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		using (StreamWriter streamWriter = new StreamWriter(StartFilePath, append: true))
		{
			streamWriter.WriteLine(NameToRecord);
		}
		Description = "在 " + StartFilePath + " 中记录了 " + NameToRecord;
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
