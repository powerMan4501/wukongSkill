using System;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgAttrChangeNotifyReq : IMessage<CSMsgAttrChangeNotifyReq>, IMessage, IEquatable<CSMsgAttrChangeNotifyReq>, IDeepCloneable<CSMsgAttrChangeNotifyReq>
{
	private static readonly MessageParser<CSMsgAttrChangeNotifyReq> _parser = new MessageParser<CSMsgAttrChangeNotifyReq>(() => new CSMsgAttrChangeNotifyReq());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<EffectAttrFloat> _repeated_attrList_codec = FieldCodec.ForMessage(10u, EffectAttrFloat.Parser);

	private readonly RepeatedField<EffectAttrFloat> attrList_ = new RepeatedField<EffectAttrFloat>();

	public static MessageParser<CSMsgAttrChangeNotifyReq> Parser => _parser;

	public RepeatedField<EffectAttrFloat> AttrList => attrList_;

	public CSMsgAttrChangeNotifyReq()
	{
	}

	public CSMsgAttrChangeNotifyReq(CSMsgAttrChangeNotifyReq other)
		: this()
	{
		attrList_ = other.attrList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAttrChangeNotifyReq Clone()
	{
		return new CSMsgAttrChangeNotifyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAttrChangeNotifyReq);
	}

	public bool Equals(CSMsgAttrChangeNotifyReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!attrList_.Equals(other.attrList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= attrList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		attrList_.WriteTo(output, _repeated_attrList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += attrList_.CalculateSize(_repeated_attrList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAttrChangeNotifyReq other)
	{
		if (other != null)
		{
			attrList_.Add(other.attrList_);
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
				attrList_.AddEntriesFrom(input, _repeated_attrList_codec);
			}
		}
	}
}
