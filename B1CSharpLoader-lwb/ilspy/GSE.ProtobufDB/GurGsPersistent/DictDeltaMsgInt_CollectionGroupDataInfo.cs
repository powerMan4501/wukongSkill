using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class DictDeltaMsgInt_CollectionGroupDataInfo : IMessage<DictDeltaMsgInt_CollectionGroupDataInfo>, IMessage, IEquatable<DictDeltaMsgInt_CollectionGroupDataInfo>, IDeepCloneable<DictDeltaMsgInt_CollectionGroupDataInfo>
{
	private static readonly MessageParser<DictDeltaMsgInt_CollectionGroupDataInfo> _parser = new MessageParser<DictDeltaMsgInt_CollectionGroupDataInfo>(() => new DictDeltaMsgInt_CollectionGroupDataInfo());

	private UnknownFieldSet _unknownFields;

	private int key_;

	private CollectionGroupDataInfo value_;

	public static MessageParser<DictDeltaMsgInt_CollectionGroupDataInfo> Parser => _parser;

	public int Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = value;
		}
	}

	public CollectionGroupDataInfo Value
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

	public DictDeltaMsgInt_CollectionGroupDataInfo()
	{
	}

	public DictDeltaMsgInt_CollectionGroupDataInfo(DictDeltaMsgInt_CollectionGroupDataInfo other)
		: this()
	{
		key_ = other.key_;
		value_ = ((other.value_ != null) ? other.value_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgInt_CollectionGroupDataInfo Clone()
	{
		return new DictDeltaMsgInt_CollectionGroupDataInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgInt_CollectionGroupDataInfo);
	}

	public bool Equals(DictDeltaMsgInt_CollectionGroupDataInfo other)
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
		if (Key != 0)
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
		if (Key != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Key);
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
		if (Key != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Key);
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

	public void MergeFrom(DictDeltaMsgInt_CollectionGroupDataInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Key != 0)
		{
			Key = other.Key;
		}
		if (other.value_ != null)
		{
			if (value_ == null)
			{
				Value = new CollectionGroupDataInfo();
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
			case 8u:
				Key = input.ReadInt32();
				break;
			case 18u:
				if (value_ == null)
				{
					Value = new CollectionGroupDataInfo();
				}
				input.ReadMessage(Value);
				break;
			}
		}
	}
}
