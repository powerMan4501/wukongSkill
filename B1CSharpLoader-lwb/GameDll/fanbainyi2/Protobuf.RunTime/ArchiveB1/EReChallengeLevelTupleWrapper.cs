using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class EReChallengeLevelTupleWrapper : IMessage<EReChallengeLevelTupleWrapper>, IMessage, IEquatable<EReChallengeLevelTupleWrapper>, IDeepCloneable<EReChallengeLevelTupleWrapper>
{
	private static readonly MessageParser<EReChallengeLevelTupleWrapper> _parser = new MessageParser<EReChallengeLevelTupleWrapper>(() => new EReChallengeLevelTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EReChallengeLevel item1_;

	private EReChallengeLevel item2_;

	public static MessageParser<EReChallengeLevelTupleWrapper> Parser => _parser;

	public EReChallengeLevel Item1
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

	public EReChallengeLevel Item2
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

	public EReChallengeLevelTupleWrapper()
	{
	}

	public EReChallengeLevelTupleWrapper(EReChallengeLevelTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EReChallengeLevelTupleWrapper Clone()
	{
		return new EReChallengeLevelTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EReChallengeLevelTupleWrapper);
	}

	public bool Equals(EReChallengeLevelTupleWrapper other)
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
		if (Item1 != EReChallengeLevel.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EReChallengeLevel.Default)
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
		if (Item1 != EReChallengeLevel.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EReChallengeLevel.Default)
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
		if (Item1 != EReChallengeLevel.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EReChallengeLevel.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EReChallengeLevelTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EReChallengeLevel.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EReChallengeLevel.Default)
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
				Item1 = (EReChallengeLevel)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EReChallengeLevel)input.ReadEnum();
				break;
			}
		}
	}
}
