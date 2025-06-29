using System;
using Google.Protobuf;

namespace ResB1;

public sealed class UISettingDetailDisplayTypeTupleWrapper : IMessage<UISettingDetailDisplayTypeTupleWrapper>, IMessage, IEquatable<UISettingDetailDisplayTypeTupleWrapper>, IDeepCloneable<UISettingDetailDisplayTypeTupleWrapper>
{
	private static readonly MessageParser<UISettingDetailDisplayTypeTupleWrapper> _parser = new MessageParser<UISettingDetailDisplayTypeTupleWrapper>(() => new UISettingDetailDisplayTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private UISettingDetailDisplayType item1_;

	private UISettingDetailDisplayType item2_;

	public static MessageParser<UISettingDetailDisplayTypeTupleWrapper> Parser => _parser;

	public UISettingDetailDisplayType Item1
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

	public UISettingDetailDisplayType Item2
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

	public UISettingDetailDisplayTypeTupleWrapper()
	{
	}

	public UISettingDetailDisplayTypeTupleWrapper(UISettingDetailDisplayTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UISettingDetailDisplayTypeTupleWrapper Clone()
	{
		return new UISettingDetailDisplayTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UISettingDetailDisplayTypeTupleWrapper);
	}

	public bool Equals(UISettingDetailDisplayTypeTupleWrapper other)
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
		if (Item1 != UISettingDetailDisplayType.Text)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != UISettingDetailDisplayType.Text)
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
		if (Item1 != UISettingDetailDisplayType.Text)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != UISettingDetailDisplayType.Text)
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
		if (Item1 != UISettingDetailDisplayType.Text)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != UISettingDetailDisplayType.Text)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UISettingDetailDisplayTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != UISettingDetailDisplayType.Text)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != UISettingDetailDisplayType.Text)
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
				Item1 = (UISettingDetailDisplayType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (UISettingDetailDisplayType)input.ReadEnum();
				break;
			}
		}
	}
}
