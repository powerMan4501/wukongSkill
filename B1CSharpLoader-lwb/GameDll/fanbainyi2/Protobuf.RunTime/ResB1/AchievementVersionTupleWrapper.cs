using System;
using Google.Protobuf;

namespace ResB1;

public sealed class AchievementVersionTupleWrapper : IMessage<AchievementVersionTupleWrapper>, IMessage, IEquatable<AchievementVersionTupleWrapper>, IDeepCloneable<AchievementVersionTupleWrapper>
{
	private static readonly MessageParser<AchievementVersionTupleWrapper> _parser = new MessageParser<AchievementVersionTupleWrapper>(() => new AchievementVersionTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private AchievementVersion item1_;

	private AchievementVersion item2_;

	public static MessageParser<AchievementVersionTupleWrapper> Parser => _parser;

	public AchievementVersion Item1
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

	public AchievementVersion Item2
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

	public AchievementVersionTupleWrapper()
	{
	}

	public AchievementVersionTupleWrapper(AchievementVersionTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementVersionTupleWrapper Clone()
	{
		return new AchievementVersionTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementVersionTupleWrapper);
	}

	public bool Equals(AchievementVersionTupleWrapper other)
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
		if (Item1 != AchievementVersion.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != AchievementVersion.Default)
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
		if (Item1 != AchievementVersion.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != AchievementVersion.Default)
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
		if (Item1 != AchievementVersion.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != AchievementVersion.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementVersionTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != AchievementVersion.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != AchievementVersion.Default)
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
				Item1 = (AchievementVersion)input.ReadEnum();
				break;
			case 16u:
				Item2 = (AchievementVersion)input.ReadEnum();
				break;
			}
		}
	}
}
