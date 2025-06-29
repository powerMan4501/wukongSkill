using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBShrineShowNpcConfigDesc : IMessage<TBShrineShowNpcConfigDesc>, IMessage, IEquatable<TBShrineShowNpcConfigDesc>, IDeepCloneable<TBShrineShowNpcConfigDesc>
{
	private static readonly MessageParser<TBShrineShowNpcConfigDesc> _parser = new MessageParser<TBShrineShowNpcConfigDesc>(() => new TBShrineShowNpcConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ShrineShowNpcConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, ShrineShowNpcConfigDesc.Parser);

	private readonly RepeatedField<ShrineShowNpcConfigDesc> list_ = new RepeatedField<ShrineShowNpcConfigDesc>();

	public static MessageParser<TBShrineShowNpcConfigDesc> Parser => _parser;

	public RepeatedField<ShrineShowNpcConfigDesc> List => list_;

	public TBShrineShowNpcConfigDesc()
	{
	}

	public TBShrineShowNpcConfigDesc(TBShrineShowNpcConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBShrineShowNpcConfigDesc Clone()
	{
		return new TBShrineShowNpcConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBShrineShowNpcConfigDesc);
	}

	public bool Equals(TBShrineShowNpcConfigDesc other)
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

	public void MergeFrom(TBShrineShowNpcConfigDesc other)
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
