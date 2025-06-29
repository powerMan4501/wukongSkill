using System;
using Google.Protobuf;
using ResB1;

namespace CsB1;

public sealed class CSMsgTaskChangeQuestStageReq : IMessage<CSMsgTaskChangeQuestStageReq>, IMessage, IEquatable<CSMsgTaskChangeQuestStageReq>, IDeepCloneable<CSMsgTaskChangeQuestStageReq>
{
	private static readonly MessageParser<CSMsgTaskChangeQuestStageReq> _parser = new MessageParser<CSMsgTaskChangeQuestStageReq>(() => new CSMsgTaskChangeQuestStageReq());

	private UnknownFieldSet _unknownFields;

	private int questId_;

	private QuestStage questStage_;

	public static MessageParser<CSMsgTaskChangeQuestStageReq> Parser => _parser;

	public int QuestId
	{
		get
		{
			return questId_;
		}
		set
		{
			questId_ = value;
		}
	}

	public QuestStage QuestStage
	{
		get
		{
			return questStage_;
		}
		set
		{
			questStage_ = value;
		}
	}

	public CSMsgTaskChangeQuestStageReq()
	{
	}

	public CSMsgTaskChangeQuestStageReq(CSMsgTaskChangeQuestStageReq other)
		: this()
	{
		questId_ = other.questId_;
		questStage_ = other.questStage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgTaskChangeQuestStageReq Clone()
	{
		return new CSMsgTaskChangeQuestStageReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgTaskChangeQuestStageReq);
	}

	public bool Equals(CSMsgTaskChangeQuestStageReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QuestId != other.QuestId)
		{
			return false;
		}
		if (QuestStage != other.QuestStage)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (QuestId != 0)
		{
			num ^= QuestId.GetHashCode();
		}
		if (QuestStage != QuestStage.Default)
		{
			num ^= QuestStage.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (QuestId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(QuestId);
		}
		if (QuestStage != QuestStage.Default)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)QuestStage);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (QuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QuestId);
		}
		if (QuestStage != QuestStage.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)QuestStage);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgTaskChangeQuestStageReq other)
	{
		if (other != null)
		{
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
			}
			if (other.QuestStage != QuestStage.Default)
			{
				QuestStage = other.QuestStage;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				QuestId = input.ReadInt32();
				break;
			case 16u:
				QuestStage = (QuestStage)input.ReadEnum();
				break;
			}
		}
	}
}
