using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBMapFragmentDesc : IMessage<TBMapFragmentDesc>, IMessage, IEquatable<TBMapFragmentDesc>, IDeepCloneable<TBMapFragmentDesc>
{
	private static readonly MessageParser<TBMapFragmentDesc> _parser = new MessageParser<TBMapFragmentDesc>(() => new TBMapFragmentDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<MapFragmentDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, MapFragmentDesc.Parser);

	private readonly RepeatedField<MapFragmentDesc> list_ = new RepeatedField<MapFragmentDesc>();

	public static MessageParser<TBMapFragmentDesc> Parser => _parser;

	public RepeatedField<MapFragmentDesc> List => list_;

	public TBMapFragmentDesc()
	{
	}

	public TBMapFragmentDesc(TBMapFragmentDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBMapFragmentDesc Clone()
	{
		return new TBMapFragmentDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBMapFragmentDesc);
	}

	public bool Equals(TBMapFragmentDesc other)
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

	public void MergeFrom(TBMapFragmentDesc other)
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
