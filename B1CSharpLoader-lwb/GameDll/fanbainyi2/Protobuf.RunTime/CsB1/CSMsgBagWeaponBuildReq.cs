using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagWeaponBuildReq : IMessage<CSMsgBagWeaponBuildReq>, IMessage, IEquatable<CSMsgBagWeaponBuildReq>, IDeepCloneable<CSMsgBagWeaponBuildReq>
{
	private static readonly MessageParser<CSMsgBagWeaponBuildReq> _parser = new MessageParser<CSMsgBagWeaponBuildReq>(() => new CSMsgBagWeaponBuildReq());

	private UnknownFieldSet _unknownFields;

	private int weaponId_;

	public static MessageParser<CSMsgBagWeaponBuildReq> Parser => _parser;

	public int WeaponId
	{
		get
		{
			return weaponId_;
		}
		set
		{
			weaponId_ = value;
		}
	}

	public CSMsgBagWeaponBuildReq()
	{
	}

	public CSMsgBagWeaponBuildReq(CSMsgBagWeaponBuildReq other)
		: this()
	{
		weaponId_ = other.weaponId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagWeaponBuildReq Clone()
	{
		return new CSMsgBagWeaponBuildReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagWeaponBuildReq);
	}

	public bool Equals(CSMsgBagWeaponBuildReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WeaponId != other.WeaponId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (WeaponId != 0)
		{
			num ^= WeaponId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (WeaponId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(WeaponId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (WeaponId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WeaponId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagWeaponBuildReq other)
	{
		if (other != null)
		{
			if (other.WeaponId != 0)
			{
				WeaponId = other.WeaponId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				WeaponId = input.ReadInt32();
			}
		}
	}
}
