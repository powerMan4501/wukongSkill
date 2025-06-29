using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagHuluSettingReq : IMessage<CSMsgBagHuluSettingReq>, IMessage, IEquatable<CSMsgBagHuluSettingReq>, IDeepCloneable<CSMsgBagHuluSettingReq>
{
	private static readonly MessageParser<CSMsgBagHuluSettingReq> _parser = new MessageParser<CSMsgBagHuluSettingReq>(() => new CSMsgBagHuluSettingReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagHuluSettingReq> Parser => _parser;

	public CSMsgBagHuluSettingReq()
	{
	}

	public CSMsgBagHuluSettingReq(CSMsgBagHuluSettingReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagHuluSettingReq Clone()
	{
		return new CSMsgBagHuluSettingReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagHuluSettingReq);
	}

	public bool Equals(CSMsgBagHuluSettingReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagHuluSettingReq other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
