using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ChangedMappableKey : IMessage<ChangedMappableKey>, IMessage, IEquatable<ChangedMappableKey>, IDeepCloneable<ChangedMappableKey>
{
	private static readonly MessageParser<ChangedMappableKey> _parser = new MessageParser<ChangedMappableKey>(() => new ChangedMappableKey());

	private UnknownFieldSet _unknownFields;

	private string mappableName_ = "";

	private string oldKeyName_ = "";

	private string newKeyName_ = "";

	public static MessageParser<ChangedMappableKey> Parser => _parser;

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

	public string OldKeyName
	{
		get
		{
			return oldKeyName_;
		}
		set
		{
			oldKeyName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string NewKeyName
	{
		get
		{
			return newKeyName_;
		}
		set
		{
			newKeyName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ChangedMappableKey()
	{
	}

	public ChangedMappableKey(ChangedMappableKey other)
		: this()
	{
		mappableName_ = other.mappableName_;
		oldKeyName_ = other.oldKeyName_;
		newKeyName_ = other.newKeyName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChangedMappableKey Clone()
	{
		return new ChangedMappableKey(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChangedMappableKey);
	}

	public bool Equals(ChangedMappableKey other)
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
		if (OldKeyName != other.OldKeyName)
		{
			return false;
		}
		if (NewKeyName != other.NewKeyName)
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
		if (OldKeyName.Length != 0)
		{
			num ^= OldKeyName.GetHashCode();
		}
		if (NewKeyName.Length != 0)
		{
			num ^= NewKeyName.GetHashCode();
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
		if (OldKeyName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(OldKeyName);
		}
		if (NewKeyName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(NewKeyName);
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
		if (OldKeyName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OldKeyName);
		}
		if (NewKeyName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NewKeyName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ChangedMappableKey other)
	{
		if (other != null)
		{
			if (other.MappableName.Length != 0)
			{
				MappableName = other.MappableName;
			}
			if (other.OldKeyName.Length != 0)
			{
				OldKeyName = other.OldKeyName;
			}
			if (other.NewKeyName.Length != 0)
			{
				NewKeyName = other.NewKeyName;
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
				OldKeyName = input.ReadString();
				break;
			case 26u:
				NewKeyName = input.ReadString();
				break;
			}
		}
	}
}
