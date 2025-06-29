using System;
using Google.Protobuf;

namespace ResB1;

public sealed class OPReasonTupleWrapper : IMessage<OPReasonTupleWrapper>, IMessage, IEquatable<OPReasonTupleWrapper>, IDeepCloneable<OPReasonTupleWrapper>
{
	private static readonly MessageParser<OPReasonTupleWrapper> _parser = new MessageParser<OPReasonTupleWrapper>(() => new OPReasonTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private OPReason item1_;

	private OPReason item2_;

	public static MessageParser<OPReasonTupleWrapper> Parser => _parser;

	public OPReason Item1
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

	public OPReason Item2
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

	public OPReasonTupleWrapper()
	{
	}

	public OPReasonTupleWrapper(OPReasonTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OPReasonTupleWrapper Clone()
	{
		return new OPReasonTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OPReasonTupleWrapper);
	}

	public bool Equals(OPReasonTupleWrapper other)
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
		if (Item1 != OPReason.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != OPReason.None)
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
		if (Item1 != OPReason.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != OPReason.None)
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
		if (Item1 != OPReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != OPReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(OPReasonTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != OPReason.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != OPReason.None)
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
				Item1 = (OPReason)input.ReadEnum();
				break;
			case 16u:
				Item2 = (OPReason)input.ReadEnum();
				break;
			}
		}
	}
}
