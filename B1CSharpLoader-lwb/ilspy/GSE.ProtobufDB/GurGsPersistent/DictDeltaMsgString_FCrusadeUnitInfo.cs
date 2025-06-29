using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class DictDeltaMsgString_FCrusadeUnitInfo : IMessage<DictDeltaMsgString_FCrusadeUnitInfo>, IMessage, IEquatable<DictDeltaMsgString_FCrusadeUnitInfo>, IDeepCloneable<DictDeltaMsgString_FCrusadeUnitInfo>
{
	private static readonly MessageParser<DictDeltaMsgString_FCrusadeUnitInfo> _parser = new MessageParser<DictDeltaMsgString_FCrusadeUnitInfo>(() => new DictDeltaMsgString_FCrusadeUnitInfo());

	private UnknownFieldSet _unknownFields;

	private string key_ = "";

	private FCrusadeUnitInfo value_;

	public static MessageParser<DictDeltaMsgString_FCrusadeUnitInfo> Parser => _parser;

	public string Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FCrusadeUnitInfo Value
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

	public DictDeltaMsgString_FCrusadeUnitInfo()
	{
	}

	public DictDeltaMsgString_FCrusadeUnitInfo(DictDeltaMsgString_FCrusadeUnitInfo other)
		: this()
	{
		key_ = other.key_;
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgString_FCrusadeUnitInfo Clone()
	{
		return new DictDeltaMsgString_FCrusadeUnitInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgString_FCrusadeUnitInfo);
	}

	public bool Equals(DictDeltaMsgString_FCrusadeUnitInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Key != other.Key)
		{
			return false;
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
		if (Key.Length != 0)
		{
			num ^= Key.GetHashCode();
		}
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
		if (Key.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Key);
		}
		if (value_ != null)
		{
			output.WriteRawTag(18);
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
		if (Key.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Key);
		}
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

	public void MergeFrom(DictDeltaMsgString_FCrusadeUnitInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Key.Length != 0)
		{
			Key = other.Key;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				Value = new FCrusadeUnitInfo();
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 10u:
				Key = input.ReadString();
				break;
			case 18u:
				if (value_ == null)
				{
					Value = new FCrusadeUnitInfo();
				}
				input.ReadMessage(Value);
				break;
			}
		}
	}
}
