using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EDeviceSettingTypeTupleWrapper : IMessage<EDeviceSettingTypeTupleWrapper>, IMessage, IEquatable<EDeviceSettingTypeTupleWrapper>, IDeepCloneable<EDeviceSettingTypeTupleWrapper>
{
	private static readonly MessageParser<EDeviceSettingTypeTupleWrapper> _parser = new MessageParser<EDeviceSettingTypeTupleWrapper>(() => new EDeviceSettingTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EDeviceSettingType item1_;

	private EDeviceSettingType item2_;

	public static MessageParser<EDeviceSettingTypeTupleWrapper> Parser => _parser;

	public EDeviceSettingType Item1
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

	public EDeviceSettingType Item2
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

	public EDeviceSettingTypeTupleWrapper()
	{
	}

	public EDeviceSettingTypeTupleWrapper(EDeviceSettingTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EDeviceSettingTypeTupleWrapper Clone()
	{
		return new EDeviceSettingTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EDeviceSettingTypeTupleWrapper);
	}

	public bool Equals(EDeviceSettingTypeTupleWrapper other)
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
		if (Item1 != EDeviceSettingType.Close)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EDeviceSettingType.Close)
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
		if (Item1 != EDeviceSettingType.Close)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EDeviceSettingType.Close)
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
		if (Item1 != EDeviceSettingType.Close)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EDeviceSettingType.Close)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EDeviceSettingTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EDeviceSettingType.Close)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EDeviceSettingType.Close)
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
				Item1 = (EDeviceSettingType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EDeviceSettingType)input.ReadEnum();
				break;
			}
		}
	}
}
