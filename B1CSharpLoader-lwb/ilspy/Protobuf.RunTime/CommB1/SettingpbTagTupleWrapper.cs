using System;
using Google.Protobuf;

namespace CommB1;

public sealed class SettingpbTagTupleWrapper : IMessage<SettingpbTagTupleWrapper>, IMessage, IEquatable<SettingpbTagTupleWrapper>, IDeepCloneable<SettingpbTagTupleWrapper>
{
	private static readonly MessageParser<SettingpbTagTupleWrapper> _parser = new MessageParser<SettingpbTagTupleWrapper>(() => new SettingpbTagTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private SettingpbTag item1_;

	private SettingpbTag item2_;

	public static MessageParser<SettingpbTagTupleWrapper> Parser => _parser;

	public SettingpbTag Item1
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

	public SettingpbTag Item2
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

	public SettingpbTagTupleWrapper()
	{
	}

	public SettingpbTagTupleWrapper(SettingpbTagTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SettingpbTagTupleWrapper Clone()
	{
		return new SettingpbTagTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SettingpbTagTupleWrapper);
	}

	public bool Equals(SettingpbTagTupleWrapper other)
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
		if (Item1 != SettingpbTag.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != SettingpbTag.Default)
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
		if (Item1 != SettingpbTag.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != SettingpbTag.Default)
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
		if (Item1 != SettingpbTag.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != SettingpbTag.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SettingpbTagTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != SettingpbTag.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != SettingpbTag.Default)
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
				Item1 = (SettingpbTag)input.ReadEnum();
				break;
			case 16u:
				Item2 = (SettingpbTag)input.ReadEnum();
				break;
			}
		}
	}
}
