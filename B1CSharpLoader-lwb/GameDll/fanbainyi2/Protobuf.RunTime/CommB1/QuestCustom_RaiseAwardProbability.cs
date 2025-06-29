using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_RaiseAwardProbability : IMessage<QuestCustom_RaiseAwardProbability>, IMessage, IEquatable<QuestCustom_RaiseAwardProbability>, IDeepCloneable<QuestCustom_RaiseAwardProbability>
{
	private static readonly MessageParser<QuestCustom_RaiseAwardProbability> _parser = new MessageParser<QuestCustom_RaiseAwardProbability>(() => new QuestCustom_RaiseAwardProbability());

	private UnknownFieldSet _unknownFields;

	private int eventId_;

	private int raiseType_;

	private int probability_;

	private bool canReduce_;

	public static MessageParser<QuestCustom_RaiseAwardProbability> Parser => _parser;

	public int EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	public int RaiseType
	{
		get
		{
			return raiseType_;
		}
		set
		{
			raiseType_ = value;
		}
	}

	public int Probability
	{
		get
		{
			return probability_;
		}
		set
		{
			probability_ = value;
		}
	}

	public bool CanReduce
	{
		get
		{
			return canReduce_;
		}
		set
		{
			canReduce_ = value;
		}
	}

	public QuestCustom_RaiseAwardProbability()
	{
	}

	public QuestCustom_RaiseAwardProbability(QuestCustom_RaiseAwardProbability other)
		: this()
	{
		eventId_ = other.eventId_;
		raiseType_ = other.raiseType_;
		probability_ = other.probability_;
		canReduce_ = other.canReduce_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_RaiseAwardProbability Clone()
	{
		return new QuestCustom_RaiseAwardProbability(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_RaiseAwardProbability);
	}

	public bool Equals(QuestCustom_RaiseAwardProbability other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (RaiseType != other.RaiseType)
		{
			return false;
		}
		if (Probability != other.Probability)
		{
			return false;
		}
		if (CanReduce != other.CanReduce)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (RaiseType != 0)
		{
			num ^= RaiseType.GetHashCode();
		}
		if (Probability != 0)
		{
			num ^= Probability.GetHashCode();
		}
		if (CanReduce)
		{
			num ^= CanReduce.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EventId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EventId);
		}
		if (RaiseType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RaiseType);
		}
		if (Probability != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Probability);
		}
		if (CanReduce)
		{
			output.WriteRawTag(32);
			output.WriteBool(CanReduce);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (RaiseType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RaiseType);
		}
		if (Probability != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Probability);
		}
		if (CanReduce)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_RaiseAwardProbability other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.RaiseType != 0)
			{
				RaiseType = other.RaiseType;
			}
			if (other.Probability != 0)
			{
				Probability = other.Probability;
			}
			if (other.CanReduce)
			{
				CanReduce = other.CanReduce;
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
				EventId = input.ReadInt32();
				break;
			case 16u:
				RaiseType = input.ReadInt32();
				break;
			case 24u:
				Probability = input.ReadInt32();
				break;
			case 32u:
				CanReduce = input.ReadBool();
				break;
			}
		}
	}
}
