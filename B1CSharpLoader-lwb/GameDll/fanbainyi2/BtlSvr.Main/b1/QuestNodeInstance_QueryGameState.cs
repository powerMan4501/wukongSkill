using CommB1;
using Google.Protobuf;

namespace b1;

public class QuestNodeInstance_QueryGameState : QuestNodeInstance
{
	private EQueryGameStateCondition QueryCondition { get; set; }

	private QuestCustom_QueryGameState CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_QueryGameState();
		CustomData.MergeFrom(base.Node.NodeData);
		QueryCondition = (EQueryGameStateCondition)CustomData.QueryCondition;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		switch (QueryCondition)
		{
		case EQueryGameStateCondition.HasArchive:
			if (OnCheckArchive())
			{
				TriggerSuccess();
			}
			else
			{
				TriggerFailed();
			}
			break;
		case EQueryGameStateCondition.IsDebug:
			if (OnCheckIsDebug())
			{
				TriggerSuccess();
			}
			else
			{
				TriggerFailed();
			}
			break;
		default:
			TriggerOutput("Other", bFinish: true);
			break;
		}
	}

	private void TriggerSuccess()
	{
		TriggerOutput("Success", bFinish: true);
	}

	private void TriggerFailed()
	{
		TriggerOutput("Failed", bFinish: true);
	}

	private bool OnCheckArchive()
	{
		if (base.ArchivedMgr.HasArchiveFile() || DebugConfig.DebugStartWithOutArchive)
		{
			return true;
		}
		return false;
	}

	private bool OnCheckIsDebug()
	{
		if (BGW_GameArchiveMgr.Get(base.Owner).IsCurrentArchiveIdInvalid(out var _))
		{
			return true;
		}
		return false;
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
		switch (QueryCondition)
		{
		case EQueryGameStateCondition.HasArchive:
			if (OnCheckArchive())
			{
				TriggerSuccess();
			}
			else
			{
				TriggerFailed();
			}
			break;
		case EQueryGameStateCondition.IsDebug:
			if (OnCheckIsDebug())
			{
				TriggerSuccess();
			}
			else
			{
				TriggerFailed();
			}
			break;
		default:
			TriggerOutput("Other", bFinish: true);
			break;
		}
	}
}
