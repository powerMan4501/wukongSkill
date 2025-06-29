using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStBulletSwitchDesc : IMessage<TBFUStBulletSwitchDesc>, IMessage, IEquatable<TBFUStBulletSwitchDesc>, IDeepCloneable<TBFUStBulletSwitchDesc>
{
	private static readonly MessageParser<TBFUStBulletSwitchDesc> _parser = new MessageParser<TBFUStBulletSwitchDesc>(() => new TBFUStBulletSwitchDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStBulletSwitchDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStBulletSwitchDesc.Parser);

	private readonly RepeatedField<FUStBulletSwitchDesc> list_ = new RepeatedField<FUStBulletSwitchDesc>();

	public static MessageParser<TBFUStBulletSwitchDesc> Parser => _parser;

	public RepeatedField<FUStBulletSwitchDesc> List => list_;

	public TBFUStBulletSwitchDesc()
	{
	}

	public TBFUStBulletSwitchDesc(TBFUStBulletSwitchDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStBulletSwitchDesc Clone()
	{
		return new TBFUStBulletSwitchDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStBulletSwitchDesc);
	}

	public bool Equals(TBFUStBulletSwitchDesc other)
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

	public void MergeFrom(TBFUStBulletSwitchDesc other)
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
