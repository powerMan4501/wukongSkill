using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBCommonErrorUITipsDesc : IMessage<TBCommonErrorUITipsDesc>, IMessage, IEquatable<TBCommonErrorUITipsDesc>, IDeepCloneable<TBCommonErrorUITipsDesc>
{
	private static readonly MessageParser<TBCommonErrorUITipsDesc> _parser = new MessageParser<TBCommonErrorUITipsDesc>(() => new TBCommonErrorUITipsDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CommonErrorUITipsDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, CommonErrorUITipsDesc.Parser);

	private readonly RepeatedField<CommonErrorUITipsDesc> list_ = new RepeatedField<CommonErrorUITipsDesc>();

	public static MessageParser<TBCommonErrorUITipsDesc> Parser => _parser;

	public RepeatedField<CommonErrorUITipsDesc> List => list_;

	public TBCommonErrorUITipsDesc()
	{
	}

	public TBCommonErrorUITipsDesc(TBCommonErrorUITipsDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBCommonErrorUITipsDesc Clone()
	{
		return new TBCommonErrorUITipsDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBCommonErrorUITipsDesc);
	}

	public bool Equals(TBCommonErrorUITipsDesc other)
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

	public void MergeFrom(TBCommonErrorUITipsDesc other)
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
