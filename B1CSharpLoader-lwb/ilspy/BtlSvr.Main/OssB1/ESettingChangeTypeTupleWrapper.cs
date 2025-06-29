using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ESettingChangeTypeTupleWrapper : IMessage<ESettingChangeTypeTupleWrapper>, IMessage, IEquatable<ESettingChangeTypeTupleWrapper>, IDeepCloneable<ESettingChangeTypeTupleWrapper>
{
	private static readonly MessageParser<ESettingChangeTypeTupleWrapper> _parser = new MessageParser<ESettingChangeTypeTupleWrapper>(() => new ESettingChangeTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ESettingChangeType item1_;

	private ESettingChangeType item2_;

	public static MessageParser<ESettingChangeTypeTupleWrapper> Parser => _parser;

	public ESettingChangeType Item1
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

	public ESettingChangeType Item2
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

	public ESettingChangeTypeTupleWrapper()
	{
	}

	public ESettingChangeTypeTupleWrapper(ESettingChangeTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ESettingChangeTypeTupleWrapper Clone()
	{
		return new ESettingChangeTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ESettingChangeTypeTupleWrapper);
	}

	public bool Equals(ESettingChangeTypeTupleWrapper other)
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
		if (Item1 != ESettingChangeType.Normal)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ESettingChangeType.Normal)
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
		if (Item1 != ESettingChangeType.Normal)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ESettingChangeType.Normal)
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
		if (Item1 != ESettingChangeType.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ESettingChangeType.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ESettingChangeTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ESettingChangeType.Normal)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ESettingChangeType.Normal)
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
				Item1 = (ESettingChangeType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ESettingChangeType)input.ReadEnum();
				break;
			}
		}
	}
}
