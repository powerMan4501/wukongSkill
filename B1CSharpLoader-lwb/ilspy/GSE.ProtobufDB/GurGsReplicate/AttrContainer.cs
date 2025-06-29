using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class AttrContainer : IMessage<AttrContainer>, IMessage, IEquatable<AttrContainer>, IDeepCloneable<AttrContainer>
{
	private static readonly MessageParser<AttrContainer> _parser = new MessageParser<AttrContainer>(() => new AttrContainer());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListWNRDeltaMsgFloat> _repeated_floatAttrs_codec = FieldCodec.ForMessage(10u, ListWNRDeltaMsgFloat.Parser);

	private readonly RepeatedField<ListWNRDeltaMsgFloat> floatAttrs_ = new RepeatedField<ListWNRDeltaMsgFloat>();

	public static MessageParser<AttrContainer> Parser => _parser;

	public RepeatedField<ListWNRDeltaMsgFloat> FloatAttrs => floatAttrs_;

	public AttrContainer()
	{
	}

	public AttrContainer(AttrContainer other)
		: this()
	{
		floatAttrs_ = other.floatAttrs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AttrContainer Clone()
	{
		return new AttrContainer(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AttrContainer);
	}

	public bool Equals(AttrContainer other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!floatAttrs_.Equals(other.floatAttrs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= floatAttrs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		floatAttrs_.WriteTo(output, _repeated_floatAttrs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += floatAttrs_.CalculateSize(_repeated_floatAttrs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AttrContainer other)
	{
		if (other != null)
		{
			floatAttrs_.Add(other.floatAttrs_);
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
				floatAttrs_.AddEntriesFrom(input, _repeated_floatAttrs_codec);
			}
		}
	}
}
