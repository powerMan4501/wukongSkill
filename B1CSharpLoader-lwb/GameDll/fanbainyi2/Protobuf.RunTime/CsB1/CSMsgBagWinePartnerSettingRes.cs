using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagWinePartnerSettingRes : IMessage<CSMsgBagWinePartnerSettingRes>, IMessage, IEquatable<CSMsgBagWinePartnerSettingRes>, IDeepCloneable<CSMsgBagWinePartnerSettingRes>
{
	private static readonly MessageParser<CSMsgBagWinePartnerSettingRes> _parser = new MessageParser<CSMsgBagWinePartnerSettingRes>(() => new CSMsgBagWinePartnerSettingRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagWinePartnerSettingRes> Parser => _parser;

	public CSMsgBagWinePartnerSettingRes()
	{
	}

	public CSMsgBagWinePartnerSettingRes(CSMsgBagWinePartnerSettingRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagWinePartnerSettingRes Clone()
	{
		return new CSMsgBagWinePartnerSettingRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagWinePartnerSettingRes);
	}

	public bool Equals(CSMsgBagWinePartnerSettingRes other)
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

	public void MergeFrom(CSMsgBagWinePartnerSettingRes other)
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
