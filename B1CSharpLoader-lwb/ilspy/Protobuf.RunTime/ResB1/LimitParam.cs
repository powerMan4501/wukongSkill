using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class LimitParam : IMessage<LimitParam>, IMessage, IEquatable<LimitParam>, IDeepCloneable<LimitParam>
{
	private static readonly MessageParser<LimitParam> _parser = new MessageParser<LimitParam>(() => new LimitParam());

	private UnknownFieldSet _unknownFields;

	private int questId_;

	private static readonly FieldCodec<QuestStage> _repeated_questState_codec = FieldCodec.ForEnum(18u, (QuestStage x) => (int)x, (int x) => (QuestStage)x);

	private readonly RepeatedField<QuestStage> questState_ = new RepeatedField<QuestStage>();

	private int limitGameCountMin_;

	private int limitGameCountMax_;

	public static MessageParser<LimitParam> Parser => _parser;

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

	public RepeatedField<QuestStage> QuestState => questState_;

	public int LimitGameCountMin
	{
		get
		{
			return limitGameCountMin_;
		}
		set
		{
			limitGameCountMin_ = value;
		}
	}

	public int LimitGameCountMax
	{
		get
		{
			return limitGameCountMax_;
		}
		set
		{
			limitGameCountMax_ = value;
		}
	}

	public LimitParam()
	{
	}

	public LimitParam(LimitParam other)
		: this()
	{
		questId_ = other.questId_;
		questState_ = other.questState_.Clone();
		limitGameCountMin_ = other.limitGameCountMin_;
		limitGameCountMax_ = other.limitGameCountMax_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LimitParam Clone()
	{
		return new LimitParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LimitParam);
	}

	public bool Equals(LimitParam other)
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
		if (!questState_.Equals(other.questState_))
		{
			return false;
		}
		if (LimitGameCountMin != other.LimitGameCountMin)
		{
			return false;
		}
		if (LimitGameCountMax != other.LimitGameCountMax)
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
		num ^= questState_.GetHashCode();
		if (LimitGameCountMin != 0)
		{
			num ^= LimitGameCountMin.GetHashCode();
		}
		if (LimitGameCountMax != 0)
		{
			num ^= LimitGameCountMax.GetHashCode();
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
		questState_.WriteTo(output, _repeated_questState_codec);
		if (LimitGameCountMin != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LimitGameCountMin);
		}
		if (LimitGameCountMax != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LimitGameCountMax);
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
		num += questState_.CalculateSize(_repeated_questState_codec);
		if (LimitGameCountMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitGameCountMin);
		}
		if (LimitGameCountMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitGameCountMax);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LimitParam other)
	{
		if (other != null)
		{
			if (other.QuestId != 0)
			{
				QuestId = other.QuestId;
			}
			questState_.Add(other.questState_);
			if (other.LimitGameCountMin != 0)
			{
				LimitGameCountMin = other.LimitGameCountMin;
			}
			if (other.LimitGameCountMax != 0)
			{
				LimitGameCountMax = other.LimitGameCountMax;
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
			case 18u:
				questState_.AddEntriesFrom(input, _repeated_questState_codec);
				break;
			case 24u:
				LimitGameCountMin = input.ReadInt32();
				break;
			case 32u:
				LimitGameCountMax = input.ReadInt32();
				break;
			}
		}
	}
}
