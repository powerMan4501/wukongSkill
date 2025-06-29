using CommB1;
using Google.Protobuf;

namespace b1;

public class GuideNodeInstance_Wait : PsmNodeInstance
{
	private float _timer;

	public override string[] SupportNodeClasses => new string[1] { B1CalliopeDef.GuideNode.Wait };

	private GuideCustom_Wait CustomData { get; set; }

	public override void PostCreate()
	{
		base.PostCreate();
		CustomData = new GuideCustom_Wait();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		TriggerInputInternal(InputPin);
		_timer = CustomData.WaitSecondFloat;
		if (_timer < 0f)
		{
			TriggerFirstOutput(bFinish: true);
		}
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		if (!(_timer < 0f))
		{
			_timer -= DeltaTime;
			if (_timer < 0f)
			{
				TriggerFirstOutput(bFinish: true);
			}
		}
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}
