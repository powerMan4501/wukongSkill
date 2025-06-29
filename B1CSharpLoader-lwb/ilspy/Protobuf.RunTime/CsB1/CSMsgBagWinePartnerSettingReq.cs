using System;
using ArchiveB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagWinePartnerSettingReq : IMessage<CSMsgBagWinePartnerSettingReq>, IMessage, IEquatable<CSMsgBagWinePartnerSettingReq>, IDeepCloneable<CSMsgBagWinePartnerSettingReq>
{
	private static readonly MessageParser<CSMsgBagWinePartnerSettingReq> _parser = new MessageParser<CSMsgBagWinePartnerSettingReq>(() => new CSMsgBagWinePartnerSettingReq());

	private UnknownFieldSet _unknownFields;

	private RoleWine wineSetting_;

	public static MessageParser<CSMsgBagWinePartnerSettingReq> Parser => _parser;

	public RoleWine WineSetting
	{
		get
		{
			return wineSetting_;
		}
		set
		{
			wineSetting_ = value;
		}
	}

	public CSMsgBagWinePartnerSettingReq()
	{
	}

	public CSMsgBagWinePartnerSettingReq(CSMsgBagWinePartnerSettingReq other)
		: this()
	{
		wineSetting_ = ((other.wineSetting_ != null) ? other.wineSetting_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagWinePartnerSettingReq Clone()
	{
		return new CSMsgBagWinePartnerSettingReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagWinePartnerSettingReq);
	}

	public bool Equals(CSMsgBagWinePartnerSettingReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(WineSetting, other.WineSetting))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (wineSetting_ != null)
		{
			num ^= WineSetting.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (wineSetting_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(WineSetting);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (wineSetting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WineSetting);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagWinePartnerSettingReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.wineSetting_ != null)
		{
			if (wineSetting_ == null)
			{
				WineSetting = new RoleWine();
			}
			WineSetting.MergeFrom(other.WineSetting);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (wineSetting_ == null)
			{
				WineSetting = new RoleWine();
			}
			input.ReadMessage(WineSetting);
		}
	}
}
