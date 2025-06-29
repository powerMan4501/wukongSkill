using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class DictDeltaMsgInt_BindListBindListEntity : IMessage<DictDeltaMsgInt_BindListBindListEntity>, IMessage, IEquatable<DictDeltaMsgInt_BindListBindListEntity>, IDeepCloneable<DictDeltaMsgInt_BindListBindListEntity>
{
	private static readonly MessageParser<DictDeltaMsgInt_BindListBindListEntity> _parser = new MessageParser<DictDeltaMsgInt_BindListBindListEntity>(() => new DictDeltaMsgInt_BindListBindListEntity());

	private UnknownFieldSet _unknownFields;

	private int key_;

	private static readonly FieldCodec<uint> _repeated_value_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> value_ = new RepeatedField<uint>();

	public static MessageParser<DictDeltaMsgInt_BindListBindListEntity> Parser => _parser;

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

	public RepeatedField<uint> Value => value_;

	public DictDeltaMsgInt_BindListBindListEntity()
	{
	}

	public DictDeltaMsgInt_BindListBindListEntity(DictDeltaMsgInt_BindListBindListEntity other)
		: this()
	{
		key_ = other.key_;
		value_ = other.value_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DictDeltaMsgInt_BindListBindListEntity Clone()
	{
		return new DictDeltaMsgInt_BindListBindListEntity(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DictDeltaMsgInt_BindListBindListEntity);
	}

	public bool Equals(DictDeltaMsgInt_BindListBindListEntity other)
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
		if (!value_.Equals(other.value_))
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
		num ^= value_.GetHashCode();
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
		value_.WriteTo(output, _repeated_value_codec);
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
		num += value_.CalculateSize(_repeated_value_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DictDeltaMsgInt_BindListBindListEntity other)
	{
		if (other != null)
		{
			if (other.Key != 0)
			{
				Key = other.Key;
			}
			value_.Add(other.value_);
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
				Key = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				value_.AddEntriesFrom(input, _repeated_value_codec);
				break;
			}
		}
	}
}
