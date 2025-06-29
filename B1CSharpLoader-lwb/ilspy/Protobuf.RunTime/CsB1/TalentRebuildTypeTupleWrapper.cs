using System;
using Google.Protobuf;

namespace CsB1;

public sealed class TalentRebuildTypeTupleWrapper : IMessage<TalentRebuildTypeTupleWrapper>, IMessage, IEquatable<TalentRebuildTypeTupleWrapper>, IDeepCloneable<TalentRebuildTypeTupleWrapper>
{
	private static readonly MessageParser<TalentRebuildTypeTupleWrapper> _parser = new MessageParser<TalentRebuildTypeTupleWrapper>(() => new TalentRebuildTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private TalentRebuildType item1_;

	private TalentRebuildType item2_;

	public static MessageParser<TalentRebuildTypeTupleWrapper> Parser => _parser;

	public TalentRebuildType Item1
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

	public TalentRebuildType Item2
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

	public TalentRebuildTypeTupleWrapper()
	{
	}

	public TalentRebuildTypeTupleWrapper(TalentRebuildTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TalentRebuildTypeTupleWrapper Clone()
	{
		return new TalentRebuildTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TalentRebuildTypeTupleWrapper);
	}

	public bool Equals(TalentRebuildTypeTupleWrapper other)
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
		if (Item1 != TalentRebuildType.All)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != TalentRebuildType.All)
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
		if (Item1 != TalentRebuildType.All)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != TalentRebuildType.All)
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
		if (Item1 != TalentRebuildType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != TalentRebuildType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TalentRebuildTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != TalentRebuildType.All)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != TalentRebuildType.All)
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
				Item1 = (TalentRebuildType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (TalentRebuildType)input.ReadEnum();
				break;
			}
		}
	}
}
