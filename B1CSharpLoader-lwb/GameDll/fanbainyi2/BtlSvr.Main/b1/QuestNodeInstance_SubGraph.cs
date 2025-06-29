using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_SubGraph : QuestNodeInstance
{
	public string AssetPath { get; set; }

	public FCalliopeGraph SubGraph { get; set; }

	public QuestSubInstance SubInstance { get; set; }

	private QuestCustom_SubGraph CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_SubGraph();
		CustomData.MergeFrom(base.Node.NodeData);
		AssetPath = CustomData.AssetPath;
		SubGraph = GameplayTagExtension.LoadGraph(CustomData.AssetPath);
	}

	public override bool IsDataValid()
	{
		if (SubGraph == null || SubGraph.Nodes.Count == 0)
		{
			return false;
		}
		return true;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (SubGraph == null)
		{
			Finish();
			return;
		}
		if (SubInstance == null)
		{
			SubInstance = QuestSubInstance.Create(this);
			SubInstance.OnGraphStart();
		}
		SubInstance?.TriggerCustomInput(InputPin);
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		if (SubInstance != null)
		{
			SubInstance.OnGraphTick(DeltaTime);
		}
	}

	public override void Shutdown()
	{
		base.Shutdown();
		SubInstance = null;
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		if (SubGraph == null)
		{
			Finish();
		}
		else if (SubInstance == null)
		{
			SubInstance = QuestSubInstance.Create(this);
		}
	}
}
