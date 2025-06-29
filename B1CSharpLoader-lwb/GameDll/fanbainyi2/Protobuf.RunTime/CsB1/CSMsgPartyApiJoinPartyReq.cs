using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgPartyApiJoinPartyReq : IMessage<CSMsgPartyApiJoinPartyReq>, IMessage, IEquatable<CSMsgPartyApiJoinPartyReq>, IDeepCloneable<CSMsgPartyApiJoinPartyReq>
{
	private static readonly MessageParser<CSMsgPartyApiJoinPartyReq> _parser = new MessageParser<CSMsgPartyApiJoinPartyReq>(() => new CSMsgPartyApiJoinPartyReq());

	private UnknownFieldSet _unknownFields;

	private bool joinHelp_;

	private ulong partyId_;

	private string partySessionId_ = "";

	public static MessageParser<CSMsgPartyApiJoinPartyReq> Parser => _parser;

	public bool JoinHelp
	{
		get
		{
			return joinHelp_;
		}
		set
		{
			joinHelp_ = value;
		}
	}

	public ulong PartyId
	{
		get
		{
			return partyId_;
		}
		set
		{
			partyId_ = value;
		}
	}

	public string PartySessionId
	{
		get
		{
			return partySessionId_;
		}
		set
		{
			partySessionId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CSMsgPartyApiJoinPartyReq()
	{
	}

	public CSMsgPartyApiJoinPartyReq(CSMsgPartyApiJoinPartyReq other)
		: this()
	{
		joinHelp_ = other.joinHelp_;
		partyId_ = other.partyId_;
		partySessionId_ = other.partySessionId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgPartyApiJoinPartyReq Clone()
	{
		return new CSMsgPartyApiJoinPartyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgPartyApiJoinPartyReq);
	}

	public bool Equals(CSMsgPartyApiJoinPartyReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JoinHelp != other.JoinHelp)
		{
			return false;
		}
		if (PartyId != other.PartyId)
		{
			return false;
		}
		if (PartySessionId != other.PartySessionId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (JoinHelp)
		{
			num ^= JoinHelp.GetHashCode();
		}
		if (PartyId != 0L)
		{
			num ^= PartyId.GetHashCode();
		}
		if (PartySessionId.Length != 0)
		{
			num ^= PartySessionId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (JoinHelp)
		{
			output.WriteRawTag(8);
			output.WriteBool(JoinHelp);
		}
		if (PartyId != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(PartyId);
		}
		if (PartySessionId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(PartySessionId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (JoinHelp)
		{
			num += 2;
		}
		if (PartyId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PartyId);
		}
		if (PartySessionId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PartySessionId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgPartyApiJoinPartyReq other)
	{
		if (other != null)
		{
			if (other.JoinHelp)
			{
				JoinHelp = other.JoinHelp;
			}
			if (other.PartyId != 0L)
			{
				PartyId = other.PartyId;
			}
			if (other.PartySessionId.Length != 0)
			{
				PartySessionId = other.PartySessionId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				JoinHelp = input.ReadBool();
				break;
			case 16u:
				PartyId = input.ReadUInt64();
				break;
			case 26u:
				PartySessionId = input.ReadString();
				break;
			}
		}
	}
}
