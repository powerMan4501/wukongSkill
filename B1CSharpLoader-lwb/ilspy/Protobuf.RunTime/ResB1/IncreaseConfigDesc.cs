using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class IncreaseConfigDesc : IMessage<IncreaseConfigDesc>, IMessage, IEquatable<IncreaseConfigDesc>, IDeepCloneable<IncreaseConfigDesc>
{
	private static readonly MessageParser<IncreaseConfigDesc> _parser = new MessageParser<IncreaseConfigDesc>(() => new IncreaseConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private IncreaseType type_;

	private static readonly FieldCodec<IncreaseConfigOne> _repeated_count_codec = FieldCodec.ForMessage(26u, IncreaseConfigOne.Parser);

	private readonly RepeatedField<IncreaseConfigOne> count_ = new RepeatedField<IncreaseConfigOne>();

	public static MessageParser<IncreaseConfigDesc> Parser => _parser;

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

	public IncreaseType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public RepeatedField<IncreaseConfigOne> Count => count_;

	public IncreaseConfigDesc()
	{
	}

	public IncreaseConfigDesc(IncreaseConfigDesc other)
		: this()
	{
		id_ = other.id_;
		type_ = other.type_;
		count_ = other.count_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public IncreaseConfigDesc Clone()
	{
		return new IncreaseConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as IncreaseConfigDesc);
	}

	public bool Equals(IncreaseConfigDesc other)
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
		if (Type != other.Type)
		{
			return false;
		}
		if (!count_.Equals(other.count_))
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
		if (Type != IncreaseType.Default)
		{
			num ^= Type.GetHashCode();
		}
		num ^= count_.GetHashCode();
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
		if (Type != IncreaseType.Default)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		count_.WriteTo(output, _repeated_count_codec);
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
		if (Type != IncreaseType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		num += count_.CalculateSize(_repeated_count_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(IncreaseConfigDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Type != IncreaseType.Default)
			{
				Type = other.Type;
			}
			count_.Add(other.count_);
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
				Type = (IncreaseType)input.ReadEnum();
				break;
			case 26u:
				count_.AddEntriesFrom(input, _repeated_count_codec);
				break;
			}
		}
	}
}
