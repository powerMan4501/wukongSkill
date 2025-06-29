using System;
using Google.Protobuf;

namespace L18NB1;

public sealed class LocalizationItem : IMessage<LocalizationItem>, IMessage, IEquatable<LocalizationItem>, IDeepCloneable<LocalizationItem>
{
	private static readonly MessageParser<LocalizationItem> _parser = new MessageParser<LocalizationItem>(() => new LocalizationItem());

	private UnknownFieldSet _unknownFields;

	private string name_ = "";

	public static MessageParser<LocalizationItem> Parser => _parser;

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public LocalizationItem()
	{
	}

	public LocalizationItem(LocalizationItem other)
		: this()
	{
		name_ = other.name_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LocalizationItem Clone()
	{
		return new LocalizationItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LocalizationItem);
	}

	public bool Equals(LocalizationItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LocalizationItem other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Name = input.ReadString();
			}
		}
	}
}
