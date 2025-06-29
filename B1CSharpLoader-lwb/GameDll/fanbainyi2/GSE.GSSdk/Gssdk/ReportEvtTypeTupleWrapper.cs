using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportEvtTypeTupleWrapper : IMessage<ReportEvtTypeTupleWrapper>, IMessage, IEquatable<ReportEvtTypeTupleWrapper>, IDeepCloneable<ReportEvtTypeTupleWrapper>
{
	private static readonly MessageParser<ReportEvtTypeTupleWrapper> _parser = new MessageParser<ReportEvtTypeTupleWrapper>(() => new ReportEvtTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ReportEvtType item1_;

	private ReportEvtType item2_;

	public static MessageParser<ReportEvtTypeTupleWrapper> Parser => _parser;

	public ReportEvtType Item1
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

	public ReportEvtType Item2
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

	public ReportEvtTypeTupleWrapper()
	{
	}

	public ReportEvtTypeTupleWrapper(ReportEvtTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEvtTypeTupleWrapper Clone()
	{
		return new ReportEvtTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEvtTypeTupleWrapper);
	}

	public bool Equals(ReportEvtTypeTupleWrapper other)
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
		if (Item1 != ReportEvtType.CustomName)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ReportEvtType.CustomName)
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
		if (Item1 != ReportEvtType.CustomName)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ReportEvtType.CustomName)
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
		if (Item1 != ReportEvtType.CustomName)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ReportEvtType.CustomName)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEvtTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ReportEvtType.CustomName)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ReportEvtType.CustomName)
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
				Item1 = (ReportEvtType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ReportEvtType)input.ReadEnum();
				break;
			}
		}
	}
}
