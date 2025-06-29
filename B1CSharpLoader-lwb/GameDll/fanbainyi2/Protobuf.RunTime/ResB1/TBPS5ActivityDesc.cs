using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBPS5ActivityDesc : IMessage<TBPS5ActivityDesc>, IMessage, IEquatable<TBPS5ActivityDesc>, IDeepCloneable<TBPS5ActivityDesc>
{
	private static readonly MessageParser<TBPS5ActivityDesc> _parser = new MessageParser<TBPS5ActivityDesc>(() => new TBPS5ActivityDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<PS5ActivityDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, PS5ActivityDesc.Parser);

	private readonly RepeatedField<PS5ActivityDesc> list_ = new RepeatedField<PS5ActivityDesc>();

	public static MessageParser<TBPS5ActivityDesc> Parser => _parser;

	public RepeatedField<PS5ActivityDesc> List => list_;

	public TBPS5ActivityDesc()
	{
	}

	public TBPS5ActivityDesc(TBPS5ActivityDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBPS5ActivityDesc Clone()
	{
		return new TBPS5ActivityDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBPS5ActivityDesc);
	}

	public bool Equals(TBPS5ActivityDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!list_.Equals(other.list_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= list_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		list_.WriteTo(output, _repeated_list_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += list_.CalculateSize(_repeated_list_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TBPS5ActivityDesc other)
	{
		if (other != null)
		{
			list_.Add(other.list_);
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
				list_.AddEntriesFrom(input, _repeated_list_codec);
			}
		}
	}
}
