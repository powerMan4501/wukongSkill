using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_TrainDummyResultReport : IMessage<QuestCustom_TrainDummyResultReport>, IMessage, IEquatable<QuestCustom_TrainDummyResultReport>, IDeepCloneable<QuestCustom_TrainDummyResultReport>
{
	private static readonly MessageParser<QuestCustom_TrainDummyResultReport> _parser = new MessageParser<QuestCustom_TrainDummyResultReport>(() => new QuestCustom_TrainDummyResultReport());

	private UnknownFieldSet _unknownFields;

	private string trainDummyMgrActorGuid_ = "";

	public static MessageParser<QuestCustom_TrainDummyResultReport> Parser => _parser;

	public string TrainDummyMgrActorGuid
	{
		get
		{
			return trainDummyMgrActorGuid_;
		}
		set
		{
			trainDummyMgrActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_TrainDummyResultReport()
	{
	}

	public QuestCustom_TrainDummyResultReport(QuestCustom_TrainDummyResultReport other)
		: this()
	{
		trainDummyMgrActorGuid_ = other.trainDummyMgrActorGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_TrainDummyResultReport Clone()
	{
		return new QuestCustom_TrainDummyResultReport(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_TrainDummyResultReport);
	}

	public bool Equals(QuestCustom_TrainDummyResultReport other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TrainDummyMgrActorGuid != other.TrainDummyMgrActorGuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TrainDummyMgrActorGuid.Length != 0)
		{
			num ^= TrainDummyMgrActorGuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TrainDummyMgrActorGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(TrainDummyMgrActorGuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TrainDummyMgrActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TrainDummyMgrActorGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_TrainDummyResultReport other)
	{
		if (other != null)
		{
			if (other.TrainDummyMgrActorGuid.Length != 0)
			{
				TrainDummyMgrActorGuid = other.TrainDummyMgrActorGuid;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				TrainDummyMgrActorGuid = input.ReadString();
			}
		}
	}
}
