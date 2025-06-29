using System;
using Google.Protobuf;

namespace OssB1;

public sealed class MappableKey : IMessage<MappableKey>, IMessage, IEquatable<MappableKey>, IDeepCloneable<MappableKey>
{
	private static readonly MessageParser<MappableKey> _parser = new MessageParser<MappableKey>(() => new MappableKey());

	private UnknownFieldSet _unknownFields;

	private string mappableName_ = "";

	private string keyName_ = "";

	public static MessageParser<MappableKey> Parser => _parser;

	public string MappableName
	{
		get
		{
			return mappableName_;
		}
		set
		{
			mappableName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string KeyName
	{
		get
		{
			return keyName_;
		}
		set
		{
			keyName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public MappableKey()
	{
	}

	public MappableKey(MappableKey other)
		: this()
	{
		mappableName_ = other.mappableName_;
		keyName_ = other.keyName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MappableKey Clone()
	{
		return new MappableKey(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MappableKey);
	}

	public bool Equals(MappableKey other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MappableName != other.MappableName)
		{
			return false;
		}
		if (KeyName != other.KeyName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MappableName.Length != 0)
		{
			num ^= MappableName.GetHashCode();
		}
		if (KeyName.Length != 0)
		{
			num ^= KeyName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MappableName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(MappableName);
		}
		if (KeyName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(KeyName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MappableName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MappableName);
		}
		if (KeyName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(KeyName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MappableKey other)
	{
		if (other != null)
		{
			if (other.MappableName.Length != 0)
			{
				MappableName = other.MappableName;
			}
			if (other.KeyName.Length != 0)
			{
				KeyName = other.KeyName;
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
			case 10u:
				MappableName = input.ReadString();
				break;
			case 18u:
				KeyName = input.ReadString();
				break;
			}
		}
	}
}
