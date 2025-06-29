using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBArtBookDesc : IMessage<TBArtBookDesc>, IMessage, IEquatable<TBArtBookDesc>, IDeepCloneable<TBArtBookDesc>
{
	private static readonly MessageParser<TBArtBookDesc> _parser = new MessageParser<TBArtBookDesc>(() => new TBArtBookDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ArtBookDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, ArtBookDesc.Parser);

	private readonly RepeatedField<ArtBookDesc> list_ = new RepeatedField<ArtBookDesc>();

	public static MessageParser<TBArtBookDesc> Parser => _parser;

	public RepeatedField<ArtBookDesc> List => list_;

	public TBArtBookDesc()
	{
	}

	public TBArtBookDesc(TBArtBookDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBArtBookDesc Clone()
	{
		return new TBArtBookDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBArtBookDesc);
	}

	public bool Equals(TBArtBookDesc other)
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

	public void MergeFrom(TBArtBookDesc other)
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
