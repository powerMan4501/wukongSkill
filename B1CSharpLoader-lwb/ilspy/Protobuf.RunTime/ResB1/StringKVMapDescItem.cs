using System;
using Google.Protobuf;

namespace ResB1;

public sealed class StringKVMapDescItem : IMessage<StringKVMapDescItem>, IMessage, IEquatable<StringKVMapDescItem>, IDeepCloneable<StringKVMapDescItem>
{
	private static readonly MessageParser<StringKVMapDescItem> _parser = new MessageParser<StringKVMapDescItem>(() => new StringKVMapDescItem());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string file_ = "";

	private string row_ = "";

	private string index_ = "";

	private string key_ = "";

	private string value_ = "";

	public static MessageParser<StringKVMapDescItem> Parser => _parser;

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

	public string File
	{
		get
		{
			return file_;
		}
		set
		{
			file_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Row
	{
		get
		{
			return row_;
		}
		set
		{
			row_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

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

	public string Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public StringKVMapDescItem()
	{
	}

	public StringKVMapDescItem(StringKVMapDescItem other)
		: this()
	{
		id_ = other.id_;
		file_ = other.file_;
		row_ = other.row_;
		index_ = other.index_;
		key_ = other.key_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public StringKVMapDescItem Clone()
	{
		return new StringKVMapDescItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as StringKVMapDescItem);
	}

	public bool Equals(StringKVMapDescItem other)
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
		if (File != other.File)
		{
			return false;
		}
		if (Row != other.Row)
		{
			return false;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (Key != other.Key)
		{
			return false;
		}
		if (Value != other.Value)
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
		if (File.Length != 0)
		{
			num ^= File.GetHashCode();
		}
		if (Row.Length != 0)
		{
			num ^= Row.GetHashCode();
		}
		if (Index.Length != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (Key.Length != 0)
		{
			num ^= Key.GetHashCode();
		}
		if (Value.Length != 0)
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (File.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(File);
		}
		if (Row.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Row);
		}
		if (Index.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Index);
		}
		if (Key.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Key);
		}
		if (Value.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Value);
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
		if (File.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(File);
		}
		if (Row.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Row);
		}
		if (Index.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Index);
		}
		if (Key.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Key);
		}
		if (Value.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(StringKVMapDescItem other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.File.Length != 0)
			{
				File = other.File;
			}
			if (other.Row.Length != 0)
			{
				Row = other.Row;
			}
			if (other.Index.Length != 0)
			{
				Index = other.Index;
			}
			if (other.Key.Length != 0)
			{
				Key = other.Key;
			}
			if (other.Value.Length != 0)
			{
				Value = other.Value;
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
			case 18u:
				File = input.ReadString();
				break;
			case 26u:
				Row = input.ReadString();
				break;
			case 34u:
				Index = input.ReadString();
				break;
			case 42u:
				Key = input.ReadString();
				break;
			case 50u:
				Value = input.ReadString();
				break;
			}
		}
	}
}
