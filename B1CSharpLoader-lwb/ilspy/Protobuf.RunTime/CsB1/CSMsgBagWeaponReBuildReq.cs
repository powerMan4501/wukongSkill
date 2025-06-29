using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagWeaponReBuildReq : IMessage<CSMsgBagWeaponReBuildReq>, IMessage, IEquatable<CSMsgBagWeaponReBuildReq>, IDeepCloneable<CSMsgBagWeaponReBuildReq>
{
	private static readonly MessageParser<CSMsgBagWeaponReBuildReq> _parser = new MessageParser<CSMsgBagWeaponReBuildReq>(() => new CSMsgBagWeaponReBuildReq());

	private UnknownFieldSet _unknownFields;

	private ulong originWeaponUid_;

	private int targetId_;

	public static MessageParser<CSMsgBagWeaponReBuildReq> Parser => _parser;

	public ulong OriginWeaponUid
	{
		get
		{
			return originWeaponUid_;
		}
		set
		{
			originWeaponUid_ = value;
		}
	}

	public int TargetId
	{
		get
		{
			return targetId_;
		}
		set
		{
			targetId_ = value;
		}
	}

	public CSMsgBagWeaponReBuildReq()
	{
	}

	public CSMsgBagWeaponReBuildReq(CSMsgBagWeaponReBuildReq other)
		: this()
	{
		originWeaponUid_ = other.originWeaponUid_;
		targetId_ = other.targetId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagWeaponReBuildReq Clone()
	{
		return new CSMsgBagWeaponReBuildReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagWeaponReBuildReq);
	}

	public bool Equals(CSMsgBagWeaponReBuildReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OriginWeaponUid != other.OriginWeaponUid)
		{
			return false;
		}
		if (TargetId != other.TargetId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (OriginWeaponUid != 0L)
		{
			num ^= OriginWeaponUid.GetHashCode();
		}
		if (TargetId != 0)
		{
			num ^= TargetId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (OriginWeaponUid != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(OriginWeaponUid);
		}
		if (TargetId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TargetId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (OriginWeaponUid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(OriginWeaponUid);
		}
		if (TargetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagWeaponReBuildReq other)
	{
		if (other != null)
		{
			if (other.OriginWeaponUid != 0L)
			{
				OriginWeaponUid = other.OriginWeaponUid;
			}
			if (other.TargetId != 0)
			{
				TargetId = other.TargetId;
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
				OriginWeaponUid = input.ReadUInt64();
				break;
			case 16u:
				TargetId = input.ReadInt32();
				break;
			}
		}
	}
}
