using System;
using Google.Protobuf;

namespace ResB1;

public sealed class MsgErrCodeTupleWrapper : IMessage<MsgErrCodeTupleWrapper>, IMessage, IEquatable<MsgErrCodeTupleWrapper>, IDeepCloneable<MsgErrCodeTupleWrapper>
{
	private static readonly MessageParser<MsgErrCodeTupleWrapper> _parser = new MessageParser<MsgErrCodeTupleWrapper>(() => new MsgErrCodeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private MsgErrCode item1_;

	private MsgErrCode item2_;

	public static MessageParser<MsgErrCodeTupleWrapper> Parser => _parser;

	public MsgErrCode Item1
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

	public MsgErrCode Item2
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

	public MsgErrCodeTupleWrapper()
	{
	}

	public MsgErrCodeTupleWrapper(MsgErrCodeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MsgErrCodeTupleWrapper Clone()
	{
		return new MsgErrCodeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MsgErrCodeTupleWrapper);
	}

	public bool Equals(MsgErrCodeTupleWrapper other)
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
		if (Item1 != MsgErrCode.ErrSuccess)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != MsgErrCode.ErrSuccess)
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
		if (Item1 != MsgErrCode.ErrSuccess)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != MsgErrCode.ErrSuccess)
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
		if (Item1 != MsgErrCode.ErrSuccess)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != MsgErrCode.ErrSuccess)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MsgErrCodeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != MsgErrCode.ErrSuccess)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != MsgErrCode.ErrSuccess)
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
				Item1 = (MsgErrCode)input.ReadEnum();
				break;
			case 16u:
				Item2 = (MsgErrCode)input.ReadEnum();
				break;
			}
		}
	}
}
