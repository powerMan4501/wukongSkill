using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TranslateKeyWordDesc : IMessage<TranslateKeyWordDesc>, IMessage, IEquatable<TranslateKeyWordDesc>, IDeepCloneable<TranslateKeyWordDesc>
{
	private static readonly MessageParser<TranslateKeyWordDesc> _parser = new MessageParser<TranslateKeyWordDesc>(() => new TranslateKeyWordDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private LanType lanType_;

	private string keyword_ = "";

	private string unique_ = "";

	public static MessageParser<TranslateKeyWordDesc> Parser => _parser;

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

	public LanType LanType
	{
		get
		{
			return lanType_;
		}
		set
		{
			lanType_ = value;
		}
	}

	public string Keyword
	{
		get
		{
			return keyword_;
		}
		set
		{
			keyword_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Unique
	{
		get
		{
			return unique_;
		}
		set
		{
			unique_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public TranslateKeyWordDesc()
	{
	}

	public TranslateKeyWordDesc(TranslateKeyWordDesc other)
		: this()
	{
		id_ = other.id_;
		lanType_ = other.lanType_;
		keyword_ = other.keyword_;
		unique_ = other.unique_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TranslateKeyWordDesc Clone()
	{
		return new TranslateKeyWordDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TranslateKeyWordDesc);
	}

	public bool Equals(TranslateKeyWordDesc other)
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
		if (LanType != other.LanType)
		{
			return false;
		}
		if (Keyword != other.Keyword)
		{
			return false;
		}
		if (Unique != other.Unique)
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
		if (LanType != LanType.All)
		{
			num ^= LanType.GetHashCode();
		}
		if (Keyword.Length != 0)
		{
			num ^= Keyword.GetHashCode();
		}
		if (Unique.Length != 0)
		{
			num ^= Unique.GetHashCode();
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
		if (LanType != LanType.All)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)LanType);
		}
		if (Keyword.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Keyword);
		}
		if (Unique.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Unique);
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
		if (LanType != LanType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LanType);
		}
		if (Keyword.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Keyword);
		}
		if (Unique.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Unique);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TranslateKeyWordDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LanType != LanType.All)
			{
				LanType = other.LanType;
			}
			if (other.Keyword.Length != 0)
			{
				Keyword = other.Keyword;
			}
			if (other.Unique.Length != 0)
			{
				Unique = other.Unique;
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
				LanType = (LanType)input.ReadEnum();
				break;
			case 26u:
				Keyword = input.ReadString();
				break;
			case 34u:
				Unique = input.ReadString();
				break;
			}
		}
	}
}
