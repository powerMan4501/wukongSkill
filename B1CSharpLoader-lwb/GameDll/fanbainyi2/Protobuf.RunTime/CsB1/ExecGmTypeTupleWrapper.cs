using System;
using Google.Protobuf;

namespace CsB1;

public sealed class ExecGmTypeTupleWrapper : IMessage<ExecGmTypeTupleWrapper>, IMessage, IEquatable<ExecGmTypeTupleWrapper>, IDeepCloneable<ExecGmTypeTupleWrapper>
{
	private static readonly MessageParser<ExecGmTypeTupleWrapper> _parser = new MessageParser<ExecGmTypeTupleWrapper>(() => new ExecGmTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ExecGmType item1_;

	private ExecGmType item2_;

	public static MessageParser<ExecGmTypeTupleWrapper> Parser => _parser;

	public ExecGmType Item1
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

	public ExecGmType Item2
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

	public ExecGmTypeTupleWrapper()
	{
	}

	public ExecGmTypeTupleWrapper(ExecGmTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ExecGmTypeTupleWrapper Clone()
	{
		return new ExecGmTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ExecGmTypeTupleWrapper);
	}

	public bool Equals(ExecGmTypeTupleWrapper other)
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
		if (Item1 != ExecGmType.Cmd)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ExecGmType.Cmd)
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
		if (Item1 != ExecGmType.Cmd)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ExecGmType.Cmd)
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
		if (Item1 != ExecGmType.Cmd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ExecGmType.Cmd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ExecGmTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ExecGmType.Cmd)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ExecGmType.Cmd)
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
				Item1 = (ExecGmType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ExecGmType)input.ReadEnum();
				break;
			}
		}
	}
}
