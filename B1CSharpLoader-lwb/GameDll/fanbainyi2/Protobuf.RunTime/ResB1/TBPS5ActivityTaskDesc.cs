using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBPS5ActivityTaskDesc : IMessage<TBPS5ActivityTaskDesc>, IMessage, IEquatable<TBPS5ActivityTaskDesc>, IDeepCloneable<TBPS5ActivityTaskDesc>
{
	private static readonly MessageParser<TBPS5ActivityTaskDesc> _parser = new MessageParser<TBPS5ActivityTaskDesc>(() => new TBPS5ActivityTaskDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<PS5ActivityTaskDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, PS5ActivityTaskDesc.Parser);

	private readonly RepeatedField<PS5ActivityTaskDesc> list_ = new RepeatedField<PS5ActivityTaskDesc>();

	public static MessageParser<TBPS5ActivityTaskDesc> Parser => _parser;

	public RepeatedField<PS5ActivityTaskDesc> List => list_;

	public TBPS5ActivityTaskDesc()
	{
	}

	public TBPS5ActivityTaskDesc(TBPS5ActivityTaskDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBPS5ActivityTaskDesc Clone()
	{
		return new TBPS5ActivityTaskDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBPS5ActivityTaskDesc);
	}

	public bool Equals(TBPS5ActivityTaskDesc other)
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

	public void MergeFrom(TBPS5ActivityTaskDesc other)
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
