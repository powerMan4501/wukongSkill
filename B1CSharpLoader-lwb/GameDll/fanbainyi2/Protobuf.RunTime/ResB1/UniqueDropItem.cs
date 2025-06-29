using System;
using Google.Protobuf;

namespace ResB1;

public sealed class UniqueDropItem : IMessage<UniqueDropItem>, IMessage, IEquatable<UniqueDropItem>, IDeepCloneable<UniqueDropItem>
{
	private static readonly MessageParser<UniqueDropItem> _parser = new MessageParser<UniqueDropItem>(() => new UniqueDropItem());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private NumConfigType numType_;

	private int configValue_;

	public static MessageParser<UniqueDropItem> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public NumConfigType NumType
	{
		get
		{
			return numType_;
		}
		set
		{
			numType_ = value;
		}
	}

	public int ConfigValue
	{
		get
		{
			return configValue_;
		}
		set
		{
			configValue_ = value;
		}
	}

	public UniqueDropItem()
	{
	}

	public UniqueDropItem(UniqueDropItem other)
		: this()
	{
		id_ = other.id_;
		numType_ = other.numType_;
		configValue_ = other.configValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UniqueDropItem Clone()
	{
		return new UniqueDropItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UniqueDropItem);
	}

	public bool Equals(UniqueDropItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (NumType != other.NumType)
		{
			return false;
		}
		if (ConfigValue != other.ConfigValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (NumType != NumConfigType.Default)
		{
			num ^= NumType.GetHashCode();
		}
		if (ConfigValue != 0)
		{
			num ^= ConfigValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (NumType != NumConfigType.Default)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)NumType);
		}
		if (ConfigValue != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ConfigValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (NumType != NumConfigType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NumType);
		}
		if (ConfigValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConfigValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UniqueDropItem other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.NumType != NumConfigType.Default)
			{
				NumType = other.NumType;
			}
			if (other.ConfigValue != 0)
			{
				ConfigValue = other.ConfigValue;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				NumType = (NumConfigType)input.ReadEnum();
				break;
			case 24u:
				ConfigValue = input.ReadInt32();
				break;
			}
		}
	}
}
