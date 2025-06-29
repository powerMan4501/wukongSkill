using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartyMemberUpdateParam : IMessage<PartyMemberUpdateParam>, IMessage, IEquatable<PartyMemberUpdateParam>, IDeepCloneable<PartyMemberUpdateParam>
{
	private static readonly MessageParser<PartyMemberUpdateParam> _parser = new MessageParser<PartyMemberUpdateParam>(() => new PartyMemberUpdateParam());

	private UnknownFieldSet _unknownFields;

	private PartyMemberUpdateType updateType_;

	private MemberRoleData roleData_;

	public static MessageParser<PartyMemberUpdateParam> Parser => _parser;

	public PartyMemberUpdateType UpdateType
	{
		get
		{
			return updateType_;
		}
		set
		{
			updateType_ = value;
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

	public PartyMemberUpdateParam()
	{
	}

	public PartyMemberUpdateParam(PartyMemberUpdateParam other)
		: this()
	{
		updateType_ = other.updateType_;
		roleData_ = ((other.roleData_ != null) ? other.roleData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyMemberUpdateParam Clone()
	{
		return new PartyMemberUpdateParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyMemberUpdateParam);
	}

	public bool Equals(PartyMemberUpdateParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UpdateType != other.UpdateType)
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
		if (UpdateType != PartyMemberUpdateType.UpdateRoleData)
		{
			num ^= UpdateType.GetHashCode();
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
		if (UpdateType != PartyMemberUpdateType.UpdateRoleData)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)UpdateType);
		}
		if (roleData_ != null)
		{
			output.WriteRawTag(18);
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
		if (UpdateType != PartyMemberUpdateType.UpdateRoleData)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UpdateType);
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

	public void MergeFrom(PartyMemberUpdateParam other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UpdateType != PartyMemberUpdateType.UpdateRoleData)
		{
			UpdateType = other.UpdateType;
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
			case 8u:
				UpdateType = (PartyMemberUpdateType)input.ReadEnum();
				break;
			case 18u:
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
