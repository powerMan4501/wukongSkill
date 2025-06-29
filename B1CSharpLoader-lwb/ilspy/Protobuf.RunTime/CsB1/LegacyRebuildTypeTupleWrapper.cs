using System;
using Google.Protobuf;

namespace CsB1;

public sealed class LegacyRebuildTypeTupleWrapper : IMessage<LegacyRebuildTypeTupleWrapper>, IMessage, IEquatable<LegacyRebuildTypeTupleWrapper>, IDeepCloneable<LegacyRebuildTypeTupleWrapper>
{
	private static readonly MessageParser<LegacyRebuildTypeTupleWrapper> _parser = new MessageParser<LegacyRebuildTypeTupleWrapper>(() => new LegacyRebuildTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private LegacyRebuildType item1_;

	private LegacyRebuildType item2_;

	public static MessageParser<LegacyRebuildTypeTupleWrapper> Parser => _parser;

	public LegacyRebuildType Item1
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

	public LegacyRebuildType Item2
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

	public LegacyRebuildTypeTupleWrapper()
	{
	}

	public LegacyRebuildTypeTupleWrapper(LegacyRebuildTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LegacyRebuildTypeTupleWrapper Clone()
	{
		return new LegacyRebuildTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LegacyRebuildTypeTupleWrapper);
	}

	public bool Equals(LegacyRebuildTypeTupleWrapper other)
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
		if (Item1 != LegacyRebuildType.TalentId)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != LegacyRebuildType.TalentId)
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
		if (Item1 != LegacyRebuildType.TalentId)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != LegacyRebuildType.TalentId)
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
		if (Item1 != LegacyRebuildType.TalentId)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != LegacyRebuildType.TalentId)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LegacyRebuildTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != LegacyRebuildType.TalentId)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != LegacyRebuildType.TalentId)
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
				Item1 = (LegacyRebuildType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (LegacyRebuildType)input.ReadEnum();
				break;
			}
		}
	}
}
