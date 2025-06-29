using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EChallengeDifficultyTupleWrapper : IMessage<EChallengeDifficultyTupleWrapper>, IMessage, IEquatable<EChallengeDifficultyTupleWrapper>, IDeepCloneable<EChallengeDifficultyTupleWrapper>
{
	private static readonly MessageParser<EChallengeDifficultyTupleWrapper> _parser = new MessageParser<EChallengeDifficultyTupleWrapper>(() => new EChallengeDifficultyTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EChallengeDifficulty item1_;

	private EChallengeDifficulty item2_;

	public static MessageParser<EChallengeDifficultyTupleWrapper> Parser => _parser;

	public EChallengeDifficulty Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public EChallengeDifficulty Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public EChallengeDifficultyTupleWrapper()
	{
	}

	public EChallengeDifficultyTupleWrapper(EChallengeDifficultyTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EChallengeDifficultyTupleWrapper Clone()
	{
		return new EChallengeDifficultyTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EChallengeDifficultyTupleWrapper);
	}

	public bool Equals(EChallengeDifficultyTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != EChallengeDifficulty.Min)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EChallengeDifficulty.Min)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != EChallengeDifficulty.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EChallengeDifficulty.Min)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != EChallengeDifficulty.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EChallengeDifficulty.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EChallengeDifficultyTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EChallengeDifficulty.Min)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EChallengeDifficulty.Min)
			{
				Item2 = other.Item2;
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
				Item1 = (EChallengeDifficulty)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EChallengeDifficulty)input.ReadEnum();
				break;
			}
		}
	}
}
