using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class TBFUStB2DBulletCommDesc : IMessage<TBFUStB2DBulletCommDesc>, IMessage, IEquatable<TBFUStB2DBulletCommDesc>, IDeepCloneable<TBFUStB2DBulletCommDesc>
{
	private static readonly MessageParser<TBFUStB2DBulletCommDesc> _parser = new MessageParser<TBFUStB2DBulletCommDesc>(() => new TBFUStB2DBulletCommDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStB2DBulletCommDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStB2DBulletCommDesc.Parser);

	private readonly RepeatedField<FUStB2DBulletCommDesc> list_ = new RepeatedField<FUStB2DBulletCommDesc>();

	public static MessageParser<TBFUStB2DBulletCommDesc> Parser => _parser;

	public RepeatedField<FUStB2DBulletCommDesc> List => list_;

	public TBFUStB2DBulletCommDesc()
	{
	}

	public TBFUStB2DBulletCommDesc(TBFUStB2DBulletCommDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStB2DBulletCommDesc Clone()
	{
		return new TBFUStB2DBulletCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStB2DBulletCommDesc);
	}

	public bool Equals(TBFUStB2DBulletCommDesc other)
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

	public void MergeFrom(TBFUStB2DBulletCommDesc other)
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
