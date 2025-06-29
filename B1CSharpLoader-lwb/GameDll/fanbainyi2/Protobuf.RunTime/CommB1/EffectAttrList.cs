using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class EffectAttrList : IMessage<EffectAttrList>, IMessage, IEquatable<EffectAttrList>, IDeepCloneable<EffectAttrList>
{
	private static readonly MessageParser<EffectAttrList> _parser = new MessageParser<EffectAttrList>(() => new EffectAttrList());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<EffectAttrFloat> _repeated_attrs_codec = FieldCodec.ForMessage(10u, EffectAttrFloat.Parser);

	private readonly RepeatedField<EffectAttrFloat> attrs_ = new RepeatedField<EffectAttrFloat>();

	public static MessageParser<EffectAttrList> Parser => _parser;

	public RepeatedField<EffectAttrFloat> Attrs => attrs_;

	public EffectAttrList()
	{
	}

	public EffectAttrList(EffectAttrList other)
		: this()
	{
		attrs_ = other.attrs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EffectAttrList Clone()
	{
		return new EffectAttrList(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EffectAttrList);
	}

	public bool Equals(EffectAttrList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!attrs_.Equals(other.attrs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= attrs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		attrs_.WriteTo(output, _repeated_attrs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += attrs_.CalculateSize(_repeated_attrs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EffectAttrList other)
	{
		if (other != null)
		{
			attrs_.Add(other.attrs_);
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
				attrs_.AddEntriesFrom(input, _repeated_attrs_codec);
			}
		}
	}
}
