using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace L18NB1;

public sealed class LocalizationConfigDesc : IMessage<LocalizationConfigDesc>, IMessage, IEquatable<LocalizationConfigDesc>, IDeepCloneable<LocalizationConfigDesc>
{
	private static readonly MessageParser<LocalizationConfigDesc> _parser = new MessageParser<LocalizationConfigDesc>(() => new LocalizationConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string tableName_ = "";

	private string key_ = "";

	private static readonly FieldCodec<LocalizationItem> _repeated_fields_codec = FieldCodec.ForMessage(34u, LocalizationItem.Parser);

	private readonly RepeatedField<LocalizationItem> fields_ = new RepeatedField<LocalizationItem>();

	public static MessageParser<LocalizationConfigDesc> Parser => _parser;

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

	public string TableName
	{
		get
		{
			return tableName_;
		}
		set
		{
			tableName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public RepeatedField<LocalizationItem> Fields => fields_;

	public LocalizationConfigDesc()
	{
	}

	public LocalizationConfigDesc(LocalizationConfigDesc other)
		: this()
	{
		id_ = other.id_;
		tableName_ = other.tableName_;
		key_ = other.key_;
		fields_ = other.fields_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LocalizationConfigDesc Clone()
	{
		return new LocalizationConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LocalizationConfigDesc);
	}

	public bool Equals(LocalizationConfigDesc other)
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
		if (TableName != other.TableName)
		{
			return false;
		}
		if (Key != other.Key)
		{
			return false;
		}
		if (!fields_.Equals(other.fields_))
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
		if (TableName.Length != 0)
		{
			num ^= TableName.GetHashCode();
		}
		if (Key.Length != 0)
		{
			num ^= Key.GetHashCode();
		}
		num ^= fields_.GetHashCode();
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
		if (TableName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(TableName);
		}
		if (Key.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Key);
		}
		fields_.WriteTo(output, _repeated_fields_codec);
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
		if (TableName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TableName);
		}
		if (Key.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Key);
		}
		num += fields_.CalculateSize(_repeated_fields_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LocalizationConfigDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.TableName.Length != 0)
			{
				TableName = other.TableName;
			}
			if (other.Key.Length != 0)
			{
				Key = other.Key;
			}
			fields_.Add(other.fields_);
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
				TableName = input.ReadString();
				break;
			case 26u:
				Key = input.ReadString();
				break;
			case 34u:
				fields_.AddEntriesFrom(input, _repeated_fields_codec);
				break;
			}
		}
	}
}
