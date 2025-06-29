using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBUnitDropNumDesc : IMessage<TBUnitDropNumDesc>, IMessage, IEquatable<TBUnitDropNumDesc>, IDeepCloneable<TBUnitDropNumDesc>
{
	private static readonly MessageParser<TBUnitDropNumDesc> _parser = new MessageParser<TBUnitDropNumDesc>(() => new TBUnitDropNumDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<UnitDropNumDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, UnitDropNumDesc.Parser);

	private readonly RepeatedField<UnitDropNumDesc> list_ = new RepeatedField<UnitDropNumDesc>();

	public static MessageParser<TBUnitDropNumDesc> Parser => _parser;

	public RepeatedField<UnitDropNumDesc> List => list_;

	public TBUnitDropNumDesc()
	{
	}

	public TBUnitDropNumDesc(TBUnitDropNumDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBUnitDropNumDesc Clone()
	{
		return new TBUnitDropNumDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBUnitDropNumDesc);
	}

	public bool Equals(TBUnitDropNumDesc other)
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

	public void MergeFrom(TBUnitDropNumDesc other)
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
