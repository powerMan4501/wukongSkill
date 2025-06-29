using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class QuestStageOne : IMessage<QuestStageOne>, IMessage, IEquatable<QuestStageOne>, IDeepCloneable<QuestStageOne>
{
	private static readonly MessageParser<QuestStageOne> _parser = new MessageParser<QuestStageOne>(() => new QuestStageOne());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private QuestStage stage_;

	public static MessageParser<QuestStageOne> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public QuestStage Stage
	{
		get
		{
			return stage_;
		}
		set
		{
			stage_ = value;
		}
	}

	public QuestStageOne()
	{
	}

	public QuestStageOne(QuestStageOne other)
		: this()
	{
		id_ = other.id_;
		stage_ = other.stage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestStageOne Clone()
	{
		return new QuestStageOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestStageOne);
	}

	public bool Equals(QuestStageOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Stage != other.Stage)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Stage != QuestStage.Default)
		{
			num ^= Stage.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Stage != QuestStage.Default)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Stage);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Stage != QuestStage.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Stage);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestStageOne other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Stage != QuestStage.Default)
			{
				Stage = other.Stage;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				Stage = (QuestStage)input.ReadEnum();
				break;
			}
		}
	}
}
