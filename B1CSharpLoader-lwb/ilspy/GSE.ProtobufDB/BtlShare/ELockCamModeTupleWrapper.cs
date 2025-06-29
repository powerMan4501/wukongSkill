using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ELockCamModeTupleWrapper : IMessage<ELockCamModeTupleWrapper>, IMessage, IEquatable<ELockCamModeTupleWrapper>, IDeepCloneable<ELockCamModeTupleWrapper>
{
	private static readonly MessageParser<ELockCamModeTupleWrapper> _parser = new MessageParser<ELockCamModeTupleWrapper>(() => new ELockCamModeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ELockCamMode item1_;

	private ELockCamMode item2_;

	public static MessageParser<ELockCamModeTupleWrapper> Parser => _parser;

	public ELockCamMode Item1
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

	public ELockCamMode Item2
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

	public ELockCamModeTupleWrapper()
	{
	}

	public ELockCamModeTupleWrapper(ELockCamModeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ELockCamModeTupleWrapper Clone()
	{
		return new ELockCamModeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ELockCamModeTupleWrapper);
	}

	public bool Equals(ELockCamModeTupleWrapper other)
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
		if (Item1 != ELockCamMode.Soul)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ELockCamMode.Soul)
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
		if (Item1 != ELockCamMode.Soul)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ELockCamMode.Soul)
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
		if (Item1 != ELockCamMode.Soul)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ELockCamMode.Soul)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ELockCamModeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ELockCamMode.Soul)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ELockCamMode.Soul)
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
				Item1 = (ELockCamMode)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ELockCamMode)input.ReadEnum();
				break;
			}
		}
	}
}
