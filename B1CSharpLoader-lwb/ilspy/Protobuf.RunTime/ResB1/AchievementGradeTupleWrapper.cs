using System;
using Google.Protobuf;

namespace ResB1;

public sealed class AchievementGradeTupleWrapper : IMessage<AchievementGradeTupleWrapper>, IMessage, IEquatable<AchievementGradeTupleWrapper>, IDeepCloneable<AchievementGradeTupleWrapper>
{
	private static readonly MessageParser<AchievementGradeTupleWrapper> _parser = new MessageParser<AchievementGradeTupleWrapper>(() => new AchievementGradeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private AchievementGrade item1_;

	private AchievementGrade item2_;

	public static MessageParser<AchievementGradeTupleWrapper> Parser => _parser;

	public AchievementGrade Item1
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

	public AchievementGrade Item2
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

	public AchievementGradeTupleWrapper()
	{
	}

	public AchievementGradeTupleWrapper(AchievementGradeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementGradeTupleWrapper Clone()
	{
		return new AchievementGradeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementGradeTupleWrapper);
	}

	public bool Equals(AchievementGradeTupleWrapper other)
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
		if (Item1 != AchievementGrade.Glod)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != AchievementGrade.Glod)
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
		if (Item1 != AchievementGrade.Glod)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != AchievementGrade.Glod)
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
		if (Item1 != AchievementGrade.Glod)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != AchievementGrade.Glod)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementGradeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != AchievementGrade.Glod)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != AchievementGrade.Glod)
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
				Item1 = (AchievementGrade)input.ReadEnum();
				break;
			case 16u:
				Item2 = (AchievementGrade)input.ReadEnum();
				break;
			}
		}
	}
}
