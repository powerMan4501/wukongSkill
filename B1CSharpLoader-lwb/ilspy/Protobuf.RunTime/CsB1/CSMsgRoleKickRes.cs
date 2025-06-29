using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleKickRes : IMessage<CSMsgRoleKickRes>, IMessage, IEquatable<CSMsgRoleKickRes>, IDeepCloneable<CSMsgRoleKickRes>
{
	private static readonly MessageParser<CSMsgRoleKickRes> _parser = new MessageParser<CSMsgRoleKickRes>(() => new CSMsgRoleKickRes());

	private UnknownFieldSet _unknownFields;

	private RoleKickReason kickReason_;

	private uint kickParam_;

	private uint timeNow_;

	public static MessageParser<CSMsgRoleKickRes> Parser => _parser;

	public RoleKickReason KickReason
	{
		get
		{
			return kickReason_;
		}
		set
		{
			kickReason_ = value;
		}
	}

	public uint KickParam
	{
		get
		{
			return kickParam_;
		}
		set
		{
			kickParam_ = value;
		}
	}

	public uint TimeNow
	{
		get
		{
			return timeNow_;
		}
		set
		{
			timeNow_ = value;
		}
	}

	public CSMsgRoleKickRes()
	{
	}

	public CSMsgRoleKickRes(CSMsgRoleKickRes other)
		: this()
	{
		kickReason_ = other.kickReason_;
		kickParam_ = other.kickParam_;
		timeNow_ = other.timeNow_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleKickRes Clone()
	{
		return new CSMsgRoleKickRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleKickRes);
	}

	public bool Equals(CSMsgRoleKickRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KickReason != other.KickReason)
		{
			return false;
		}
		if (KickParam != other.KickParam)
		{
			return false;
		}
		if (TimeNow != other.TimeNow)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (KickReason != RoleKickReason.RoleKickLogin)
		{
			num ^= KickReason.GetHashCode();
		}
		if (KickParam != 0)
		{
			num ^= KickParam.GetHashCode();
		}
		if (TimeNow != 0)
		{
			num ^= TimeNow.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (KickReason != RoleKickReason.RoleKickLogin)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)KickReason);
		}
		if (KickParam != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(KickParam);
		}
		if (TimeNow != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(TimeNow);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (KickReason != RoleKickReason.RoleKickLogin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)KickReason);
		}
		if (KickParam != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KickParam);
		}
		if (TimeNow != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TimeNow);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoleKickRes other)
	{
		if (other != null)
		{
			if (other.KickReason != RoleKickReason.RoleKickLogin)
			{
				KickReason = other.KickReason;
			}
			if (other.KickParam != 0)
			{
				KickParam = other.KickParam;
			}
			if (other.TimeNow != 0)
			{
				TimeNow = other.TimeNow;
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
				KickReason = (RoleKickReason)input.ReadEnum();
				break;
			case 16u:
				KickParam = input.ReadUInt32();
				break;
			case 24u:
				TimeNow = input.ReadUInt32();
				break;
			}
		}
	}
}
