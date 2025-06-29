using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class ListDeltaMsgPlayerPersistentAttr : IMessage<ListDeltaMsgPlayerPersistentAttr>, IMessage, IEquatable<ListDeltaMsgPlayerPersistentAttr>, IDeepCloneable<ListDeltaMsgPlayerPersistentAttr>
{
	private static readonly MessageParser<ListDeltaMsgPlayerPersistentAttr> _parser = new MessageParser<ListDeltaMsgPlayerPersistentAttr>(() => new ListDeltaMsgPlayerPersistentAttr());

	private UnknownFieldSet _unknownFields;

	private PlayerPersistentAttr value_;

	public static MessageParser<ListDeltaMsgPlayerPersistentAttr> Parser => _parser;

	public PlayerPersistentAttr Value
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

	public ListDeltaMsgPlayerPersistentAttr()
	{
	}

	public ListDeltaMsgPlayerPersistentAttr(ListDeltaMsgPlayerPersistentAttr other)
		: this()
	{
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgPlayerPersistentAttr Clone()
	{
		return new ListDeltaMsgPlayerPersistentAttr(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgPlayerPersistentAttr);
	}

	public bool Equals(ListDeltaMsgPlayerPersistentAttr other)
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

	public void MergeFrom(ListDeltaMsgPlayerPersistentAttr other)
	{
		if (other == null)
		{
			return;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				Value = new PlayerPersistentAttr();
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
				Value = new PlayerPersistentAttr();
			}
			input.ReadMessage(Value);
		}
	}
}
