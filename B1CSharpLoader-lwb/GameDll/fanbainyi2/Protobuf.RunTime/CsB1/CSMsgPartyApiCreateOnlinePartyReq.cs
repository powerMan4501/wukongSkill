using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiCreateOnlinePartyReq : IMessage<CSMsgPartyApiCreateOnlinePartyReq>, IMessage, IEquatable<CSMsgPartyApiCreateOnlinePartyReq>, IDeepCloneable<CSMsgPartyApiCreateOnlinePartyReq>
{
	private static readonly MessageParser<CSMsgPartyApiCreateOnlinePartyReq> _parser = new MessageParser<CSMsgPartyApiCreateOnlinePartyReq>(() => new CSMsgPartyApiCreateOnlinePartyReq());

	private UnknownFieldSet _unknownFields;

	private bool checkRejoin_;

	private PartySetting setting_;

	public static MessageParser<CSMsgPartyApiCreateOnlinePartyReq> Parser => _parser;

	public bool CheckRejoin
	{
		get
		{
			return checkRejoin_;
		}
		set
		{
			checkRejoin_ = value;
		}
	}

	public PartySetting Setting
	{
		get
		{
			return setting_;
		}
		set
		{
			setting_ = value;
		}
	}

	public CSMsgPartyApiCreateOnlinePartyReq()
	{
	}

	public CSMsgPartyApiCreateOnlinePartyReq(CSMsgPartyApiCreateOnlinePartyReq other)
		: this()
	{
		checkRejoin_ = other.checkRejoin_;
		setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiCreateOnlinePartyReq Clone()
	{
		return new CSMsgPartyApiCreateOnlinePartyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiCreateOnlinePartyReq);
	}

	public bool Equals(CSMsgPartyApiCreateOnlinePartyReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CheckRejoin != other.CheckRejoin)
		{
			return false;
		}
		if (!object.Equals(Setting, other.Setting))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CheckRejoin)
		{
			num ^= CheckRejoin.GetHashCode();
		}
		if (setting_ != null)
		{
			num ^= Setting.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CheckRejoin)
		{
			output.WriteRawTag(8);
			output.WriteBool(CheckRejoin);
		}
		if (setting_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Setting);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CheckRejoin)
		{
			num += 2;
		}
		if (setting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Setting);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgPartyApiCreateOnlinePartyReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CheckRejoin)
		{
			CheckRejoin = other.CheckRejoin;
		}
		if (other.setting_ != null)
		{
			if (setting_ == null)
			{
				Setting = new PartySetting();
			}
			Setting.MergeFrom(other.Setting);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				CheckRejoin = input.ReadBool();
				break;
			case 18u:
				if (setting_ == null)
				{
					Setting = new PartySetting();
				}
				input.ReadMessage(Setting);
				break;
			}
		}
	}
}
