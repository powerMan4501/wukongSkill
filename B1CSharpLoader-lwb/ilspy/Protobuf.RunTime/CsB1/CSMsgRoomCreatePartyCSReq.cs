using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoomCreatePartyCSReq : IMessage<CSMsgRoomCreatePartyCSReq>, IMessage, IEquatable<CSMsgRoomCreatePartyCSReq>, IDeepCloneable<CSMsgRoomCreatePartyCSReq>
{
	private static readonly MessageParser<CSMsgRoomCreatePartyCSReq> _parser = new MessageParser<CSMsgRoomCreatePartyCSReq>(() => new CSMsgRoomCreatePartyCSReq());

	private UnknownFieldSet _unknownFields;

	private string partySessionId_ = "";

	private string ownerPlatformId_ = "";

	private PartySetting setting_;

	private MemberRoleData roleData_;

	public static MessageParser<CSMsgRoomCreatePartyCSReq> Parser => _parser;

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

	public string OwnerPlatformId
	{
		get
		{
			return ownerPlatformId_;
		}
		set
		{
			ownerPlatformId_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public MemberRoleData RoleData
	{
		get
		{
			return roleData_;
		}
		set
		{
			roleData_ = value;
		}
	}

	public CSMsgRoomCreatePartyCSReq()
	{
	}

	public CSMsgRoomCreatePartyCSReq(CSMsgRoomCreatePartyCSReq other)
		: this()
	{
		partySessionId_ = other.partySessionId_;
		ownerPlatformId_ = other.ownerPlatformId_;
		setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
		roleData_ = ((other.roleData_ != null) ? other.roleData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoomCreatePartyCSReq Clone()
	{
		return new CSMsgRoomCreatePartyCSReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoomCreatePartyCSReq);
	}

	public bool Equals(CSMsgRoomCreatePartyCSReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PartySessionId != other.PartySessionId)
		{
			return false;
		}
		if (OwnerPlatformId != other.OwnerPlatformId)
		{
			return false;
		}
		if (!object.Equals(Setting, other.Setting))
		{
			return false;
		}
		if (!object.Equals(RoleData, other.RoleData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PartySessionId.Length != 0)
		{
			num ^= PartySessionId.GetHashCode();
		}
		if (OwnerPlatformId.Length != 0)
		{
			num ^= OwnerPlatformId.GetHashCode();
		}
		if (setting_ != null)
		{
			num ^= Setting.GetHashCode();
		}
		if (roleData_ != null)
		{
			num ^= RoleData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PartySessionId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PartySessionId);
		}
		if (OwnerPlatformId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(OwnerPlatformId);
		}
		if (setting_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Setting);
		}
		if (roleData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RoleData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PartySessionId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PartySessionId);
		}
		if (OwnerPlatformId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OwnerPlatformId);
		}
		if (setting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Setting);
		}
		if (roleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoomCreatePartyCSReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PartySessionId.Length != 0)
		{
			PartySessionId = other.PartySessionId;
		}
		if (other.OwnerPlatformId.Length != 0)
		{
			OwnerPlatformId = other.OwnerPlatformId;
		}
		if (other.setting_ != null)
		{
			if (setting_ == null)
			{
				Setting = new PartySetting();
			}
			Setting.MergeFrom(other.Setting);
		}
		if (other.roleData_ != null)
		{
			if (roleData_ == null)
			{
				RoleData = new MemberRoleData();
			}
			RoleData.MergeFrom(other.RoleData);
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
			case 10u:
				PartySessionId = input.ReadString();
				break;
			case 18u:
				OwnerPlatformId = input.ReadString();
				break;
			case 26u:
				if (setting_ == null)
				{
					Setting = new PartySetting();
				}
				input.ReadMessage(Setting);
				break;
			case 34u:
				if (roleData_ == null)
				{
					RoleData = new MemberRoleData();
				}
				input.ReadMessage(RoleData);
				break;
			}
		}
	}
}
