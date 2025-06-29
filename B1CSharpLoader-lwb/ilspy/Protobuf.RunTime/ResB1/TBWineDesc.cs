using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBWineDesc : IMessage<TBWineDesc>, IMessage, IEquatable<TBWineDesc>, IDeepCloneable<TBWineDesc>
{
	private static readonly MessageParser<TBWineDesc> _parser = new MessageParser<TBWineDesc>(() => new TBWineDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<WineDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, WineDesc.Parser);

	private readonly RepeatedField<WineDesc> list_ = new RepeatedField<WineDesc>();

	public static MessageParser<TBWineDesc> Parser => _parser;

	public RepeatedField<WineDesc> List => list_;

	public TBWineDesc()
	{
	}

	public TBWineDesc(TBWineDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBWineDesc Clone()
	{
		return new TBWineDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBWineDesc);
	}

	public bool Equals(TBWineDesc other)
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

	public void MergeFrom(TBWineDesc other)
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
