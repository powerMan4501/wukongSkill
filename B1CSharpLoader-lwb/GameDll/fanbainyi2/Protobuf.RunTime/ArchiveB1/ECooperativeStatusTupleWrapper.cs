using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ECooperativeStatusTupleWrapper : IMessage<ECooperativeStatusTupleWrapper>, IMessage, IEquatable<ECooperativeStatusTupleWrapper>, IDeepCloneable<ECooperativeStatusTupleWrapper>
{
	private static readonly MessageParser<ECooperativeStatusTupleWrapper> _parser = new MessageParser<ECooperativeStatusTupleWrapper>(() => new ECooperativeStatusTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ECooperativeStatus item1_;

	private ECooperativeStatus item2_;

	public static MessageParser<ECooperativeStatusTupleWrapper> Parser => _parser;

	public ECooperativeStatus Item1
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

	public ECooperativeStatus Item2
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

	public ECooperativeStatusTupleWrapper()
	{
	}

	public ECooperativeStatusTupleWrapper(ECooperativeStatusTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ECooperativeStatusTupleWrapper Clone()
	{
		return new ECooperativeStatusTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ECooperativeStatusTupleWrapper);
	}

	public bool Equals(ECooperativeStatusTupleWrapper other)
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
		if (Item1 != ECooperativeStatus.Forbid)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ECooperativeStatus.Forbid)
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
		if (Item1 != ECooperativeStatus.Forbid)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ECooperativeStatus.Forbid)
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
		if (Item1 != ECooperativeStatus.Forbid)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ECooperativeStatus.Forbid)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ECooperativeStatusTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ECooperativeStatus.Forbid)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ECooperativeStatus.Forbid)
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
				Item1 = (ECooperativeStatus)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ECooperativeStatus)input.ReadEnum();
				break;
			}
		}
	}
}
