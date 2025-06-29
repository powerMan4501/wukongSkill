using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class ListDeltaMsgUnitHatredTargetInfo : IMessage<ListDeltaMsgUnitHatredTargetInfo>, IMessage, IEquatable<ListDeltaMsgUnitHatredTargetInfo>, IDeepCloneable<ListDeltaMsgUnitHatredTargetInfo>
{
	private static readonly MessageParser<ListDeltaMsgUnitHatredTargetInfo> _parser = new MessageParser<ListDeltaMsgUnitHatredTargetInfo>(() => new ListDeltaMsgUnitHatredTargetInfo());

	private UnknownFieldSet _unknownFields;

	private UnitHatredTargetInfo value_;

	public static MessageParser<ListDeltaMsgUnitHatredTargetInfo> Parser => _parser;

	public UnitHatredTargetInfo Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public ListDeltaMsgUnitHatredTargetInfo()
	{
	}

	public ListDeltaMsgUnitHatredTargetInfo(ListDeltaMsgUnitHatredTargetInfo other)
		: this()
	{
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgUnitHatredTargetInfo Clone()
	{
		return new ListDeltaMsgUnitHatredTargetInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgUnitHatredTargetInfo);
	}

	public bool Equals(ListDeltaMsgUnitHatredTargetInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Value, other.Value))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (value_ != null)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (value_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (value_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListDeltaMsgUnitHatredTargetInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				Value = new UnitHatredTargetInfo();
			}
			Value.MergeFrom(other.Value);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (value_ == null)
			{
				Value = new UnitHatredTargetInfo();
			}
			input.ReadMessage(Value);
		}
	}
}
