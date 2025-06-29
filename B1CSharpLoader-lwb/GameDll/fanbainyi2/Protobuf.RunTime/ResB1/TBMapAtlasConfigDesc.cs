using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBMapAtlasConfigDesc : IMessage<TBMapAtlasConfigDesc>, IMessage, IEquatable<TBMapAtlasConfigDesc>, IDeepCloneable<TBMapAtlasConfigDesc>
{
	private static readonly MessageParser<TBMapAtlasConfigDesc> _parser = new MessageParser<TBMapAtlasConfigDesc>(() => new TBMapAtlasConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<MapAtlasConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, MapAtlasConfigDesc.Parser);

	private readonly RepeatedField<MapAtlasConfigDesc> list_ = new RepeatedField<MapAtlasConfigDesc>();

	public static MessageParser<TBMapAtlasConfigDesc> Parser => _parser;

	public RepeatedField<MapAtlasConfigDesc> List => list_;

	public TBMapAtlasConfigDesc()
	{
	}

	public TBMapAtlasConfigDesc(TBMapAtlasConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBMapAtlasConfigDesc Clone()
	{
		return new TBMapAtlasConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBMapAtlasConfigDesc);
	}

	public bool Equals(TBMapAtlasConfigDesc other)
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

	public void MergeFrom(TBMapAtlasConfigDesc other)
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
