using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FAbnormalDispModifyInfoFreezeExt : IMessage<FAbnormalDispModifyInfoFreezeExt>, IMessage, IEquatable<FAbnormalDispModifyInfoFreezeExt>, IDeepCloneable<FAbnormalDispModifyInfoFreezeExt>
{
	private static readonly MessageParser<FAbnormalDispModifyInfoFreezeExt> _parser = new MessageParser<FAbnormalDispModifyInfoFreezeExt>(() => new FAbnormalDispModifyInfoFreezeExt());

	private UnknownFieldSet _unknownFields;

	private EAbnormalDispModifyType mTBroken_;

	private string dBCBroken_ = "";

	private EAbnormalDispModifyType mTAutoRelease_;

	private string dBCAutoRelease_ = "";

	private EAbnormalDispModifyType mTShakeFreeze_;

	private string dBCShakeFreeze_ = "";

	public static MessageParser<FAbnormalDispModifyInfoFreezeExt> Parser => _parser;

	public EAbnormalDispModifyType MTBroken
	{
		get
		{
			return mTBroken_;
		}
		set
		{
			mTBroken_ = value;
		}
	}

	public string DBCBroken
	{
		get
		{
			return dBCBroken_;
		}
		set
		{
			dBCBroken_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EAbnormalDispModifyType MTAutoRelease
	{
		get
		{
			return mTAutoRelease_;
		}
		set
		{
			mTAutoRelease_ = value;
		}
	}

	public string DBCAutoRelease
	{
		get
		{
			return dBCAutoRelease_;
		}
		set
		{
			dBCAutoRelease_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EAbnormalDispModifyType MTShakeFreeze
	{
		get
		{
			return mTShakeFreeze_;
		}
		set
		{
			mTShakeFreeze_ = value;
		}
	}

	public string DBCShakeFreeze
	{
		get
		{
			return dBCShakeFreeze_;
		}
		set
		{
			dBCShakeFreeze_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FAbnormalDispModifyInfoFreezeExt()
	{
	}

	public FAbnormalDispModifyInfoFreezeExt(FAbnormalDispModifyInfoFreezeExt other)
		: this()
	{
		mTBroken_ = other.mTBroken_;
		dBCBroken_ = other.dBCBroken_;
		mTAutoRelease_ = other.mTAutoRelease_;
		dBCAutoRelease_ = other.dBCAutoRelease_;
		mTShakeFreeze_ = other.mTShakeFreeze_;
		dBCShakeFreeze_ = other.dBCShakeFreeze_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FAbnormalDispModifyInfoFreezeExt Clone()
	{
		return new FAbnormalDispModifyInfoFreezeExt(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FAbnormalDispModifyInfoFreezeExt);
	}

	public bool Equals(FAbnormalDispModifyInfoFreezeExt other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MTBroken != other.MTBroken)
		{
			return false;
		}
		if (DBCBroken != other.DBCBroken)
		{
			return false;
		}
		if (MTAutoRelease != other.MTAutoRelease)
		{
			return false;
		}
		if (DBCAutoRelease != other.DBCAutoRelease)
		{
			return false;
		}
		if (MTShakeFreeze != other.MTShakeFreeze)
		{
			return false;
		}
		if (DBCShakeFreeze != other.DBCShakeFreeze)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MTBroken != EAbnormalDispModifyType.None)
		{
			num ^= MTBroken.GetHashCode();
		}
		if (DBCBroken.Length != 0)
		{
			num ^= DBCBroken.GetHashCode();
		}
		if (MTAutoRelease != EAbnormalDispModifyType.None)
		{
			num ^= MTAutoRelease.GetHashCode();
		}
		if (DBCAutoRelease.Length != 0)
		{
			num ^= DBCAutoRelease.GetHashCode();
		}
		if (MTShakeFreeze != EAbnormalDispModifyType.None)
		{
			num ^= MTShakeFreeze.GetHashCode();
		}
		if (DBCShakeFreeze.Length != 0)
		{
			num ^= DBCShakeFreeze.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MTBroken != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)MTBroken);
		}
		if (DBCBroken.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DBCBroken);
		}
		if (MTAutoRelease != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)MTAutoRelease);
		}
		if (DBCAutoRelease.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DBCAutoRelease);
		}
		if (MTShakeFreeze != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)MTShakeFreeze);
		}
		if (DBCShakeFreeze.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(DBCShakeFreeze);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MTBroken != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MTBroken);
		}
		if (DBCBroken.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCBroken);
		}
		if (MTAutoRelease != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MTAutoRelease);
		}
		if (DBCAutoRelease.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCAutoRelease);
		}
		if (MTShakeFreeze != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MTShakeFreeze);
		}
		if (DBCShakeFreeze.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCShakeFreeze);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FAbnormalDispModifyInfoFreezeExt other)
	{
		if (other != null)
		{
			if (other.MTBroken != EAbnormalDispModifyType.None)
			{
				MTBroken = other.MTBroken;
			}
			if (other.DBCBroken.Length != 0)
			{
				DBCBroken = other.DBCBroken;
			}
			if (other.MTAutoRelease != EAbnormalDispModifyType.None)
			{
				MTAutoRelease = other.MTAutoRelease;
			}
			if (other.DBCAutoRelease.Length != 0)
			{
				DBCAutoRelease = other.DBCAutoRelease;
			}
			if (other.MTShakeFreeze != EAbnormalDispModifyType.None)
			{
				MTShakeFreeze = other.MTShakeFreeze;
			}
			if (other.DBCShakeFreeze.Length != 0)
			{
				DBCShakeFreeze = other.DBCShakeFreeze;
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
				MTBroken = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 18u:
				DBCBroken = input.ReadString();
				break;
			case 24u:
				MTAutoRelease = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 34u:
				DBCAutoRelease = input.ReadString();
				break;
			case 40u:
				MTShakeFreeze = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 50u:
				DBCShakeFreeze = input.ReadString();
				break;
			}
		}
	}
}
