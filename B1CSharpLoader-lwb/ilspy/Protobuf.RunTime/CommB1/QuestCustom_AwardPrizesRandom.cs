using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_AwardPrizesRandom : IMessage<QuestCustom_AwardPrizesRandom>, IMessage, IEquatable<QuestCustom_AwardPrizesRandom>, IDeepCloneable<QuestCustom_AwardPrizesRandom>
{
	private static readonly MessageParser<QuestCustom_AwardPrizesRandom> _parser = new MessageParser<QuestCustom_AwardPrizesRandom>(() => new QuestCustom_AwardPrizesRandom());

	private UnknownFieldSet _unknownFields;

	private int successLimit_;

	private int eventId_;

	private int randomCount_;

	private float refreshDelta_;

	private float awardCd_;

	private int normalProbability_;

	private int firstProbability_;

	private int secondProbability_;

	public static MessageParser<QuestCustom_AwardPrizesRandom> Parser => _parser;

	public int SuccessLimit
	{
		get
		{
			return successLimit_;
		}
		set
		{
			successLimit_ = value;
		}
	}

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

	public int RandomCount
	{
		get
		{
			return randomCount_;
		}
		set
		{
			randomCount_ = value;
		}
	}

	public float RefreshDelta
	{
		get
		{
			return refreshDelta_;
		}
		set
		{
			refreshDelta_ = value;
		}
	}

	public float AwardCd
	{
		get
		{
			return awardCd_;
		}
		set
		{
			awardCd_ = value;
		}
	}

	public int NormalProbability
	{
		get
		{
			return normalProbability_;
		}
		set
		{
			normalProbability_ = value;
		}
	}

	public int FirstProbability
	{
		get
		{
			return firstProbability_;
		}
		set
		{
			firstProbability_ = value;
		}
	}

	public int SecondProbability
	{
		get
		{
			return secondProbability_;
		}
		set
		{
			secondProbability_ = value;
		}
	}

	public QuestCustom_AwardPrizesRandom()
	{
	}

	public QuestCustom_AwardPrizesRandom(QuestCustom_AwardPrizesRandom other)
		: this()
	{
		successLimit_ = other.successLimit_;
		eventId_ = other.eventId_;
		randomCount_ = other.randomCount_;
		refreshDelta_ = other.refreshDelta_;
		awardCd_ = other.awardCd_;
		normalProbability_ = other.normalProbability_;
		firstProbability_ = other.firstProbability_;
		secondProbability_ = other.secondProbability_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_AwardPrizesRandom Clone()
	{
		return new QuestCustom_AwardPrizesRandom(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_AwardPrizesRandom);
	}

	public bool Equals(QuestCustom_AwardPrizesRandom other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SuccessLimit != other.SuccessLimit)
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (RandomCount != other.RandomCount)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RefreshDelta, other.RefreshDelta))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AwardCd, other.AwardCd))
		{
			return false;
		}
		if (NormalProbability != other.NormalProbability)
		{
			return false;
		}
		if (FirstProbability != other.FirstProbability)
		{
			return false;
		}
		if (SecondProbability != other.SecondProbability)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SuccessLimit != 0)
		{
			num ^= SuccessLimit.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (RandomCount != 0)
		{
			num ^= RandomCount.GetHashCode();
		}
		if (RefreshDelta != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RefreshDelta);
		}
		if (AwardCd != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AwardCd);
		}
		if (NormalProbability != 0)
		{
			num ^= NormalProbability.GetHashCode();
		}
		if (FirstProbability != 0)
		{
			num ^= FirstProbability.GetHashCode();
		}
		if (SecondProbability != 0)
		{
			num ^= SecondProbability.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SuccessLimit != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SuccessLimit);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(EventId);
		}
		if (RandomCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RandomCount);
		}
		if (RefreshDelta != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(RefreshDelta);
		}
		if (AwardCd != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(AwardCd);
		}
		if (NormalProbability != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(NormalProbability);
		}
		if (FirstProbability != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(FirstProbability);
		}
		if (SecondProbability != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SecondProbability);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SuccessLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuccessLimit);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (RandomCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RandomCount);
		}
		if (RefreshDelta != 0f)
		{
			num += 5;
		}
		if (AwardCd != 0f)
		{
			num += 5;
		}
		if (NormalProbability != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NormalProbability);
		}
		if (FirstProbability != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FirstProbability);
		}
		if (SecondProbability != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SecondProbability);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_AwardPrizesRandom other)
	{
		if (other != null)
		{
			if (other.SuccessLimit != 0)
			{
				SuccessLimit = other.SuccessLimit;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.RandomCount != 0)
			{
				RandomCount = other.RandomCount;
			}
			if (other.RefreshDelta != 0f)
			{
				RefreshDelta = other.RefreshDelta;
			}
			if (other.AwardCd != 0f)
			{
				AwardCd = other.AwardCd;
			}
			if (other.NormalProbability != 0)
			{
				NormalProbability = other.NormalProbability;
			}
			if (other.FirstProbability != 0)
			{
				FirstProbability = other.FirstProbability;
			}
			if (other.SecondProbability != 0)
			{
				SecondProbability = other.SecondProbability;
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
				SuccessLimit = input.ReadInt32();
				break;
			case 16u:
				EventId = input.ReadInt32();
				break;
			case 24u:
				RandomCount = input.ReadInt32();
				break;
			case 37u:
				RefreshDelta = input.ReadFloat();
				break;
			case 45u:
				AwardCd = input.ReadFloat();
				break;
			case 48u:
				NormalProbability = input.ReadInt32();
				break;
			case 56u:
				FirstProbability = input.ReadInt32();
				break;
			case 64u:
				SecondProbability = input.ReadInt32();
				break;
			}
		}
	}
}
