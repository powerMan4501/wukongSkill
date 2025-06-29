using System.IO;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_RunProcessGraph : QuestNodeInstance
{
	private QuestCustom_RunProcessGraph CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_RunProcessGraph();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	private static string GetSubGraphRecordFilePath(string InLongPathName)
	{
		string projectDir = FPaths.ProjectDir;
		if (string.IsNullOrEmpty(projectDir) || !Directory.Exists(projectDir))
		{
			BGW_LogUtil.LogError("FCalliopeRecorder Error: Asset is null Or Path " + projectDir + " not exist");
			return null;
		}
		string path = "CalliopeData/2.0";
		string path2 = InLongPathName.TrimStart('/') + ".Data";
		return Path.Combine(projectDir, path, path2);
	}

	public override bool IsDataValid()
	{
		return true;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput(bFinish: false);
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
	}
}
