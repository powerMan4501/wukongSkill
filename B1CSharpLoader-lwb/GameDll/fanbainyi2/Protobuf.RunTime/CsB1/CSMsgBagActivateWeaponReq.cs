using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagActivateWeaponReq : IMessage<CSMsgBagActivateWeaponReq>, IMessage, IEquatable<CSMsgBagActivateWeaponReq>, IDeepCloneable<CSMsgBagActivateWeaponReq>
{
	private static readonly MessageParser<CSMsgBagActivateWeaponReq> _parser = new MessageParser<CSMsgBagActivateWeaponReq>(() => new CSMsgBagActivateWeaponReq());

	private UnknownFieldSet _unknownFields;

	private int targetEquipId_;

	public static MessageParser<CSMsgBagActivateWeaponReq> Parser => _parser;

	public int TargetEquipId
	{
		get
		{
			return targetEquipId_;
		}
		set
		{
			targetEquipId_ = value;
		}
	}

	public CSMsgBagActivateWeaponReq()
	{
	}

	public CSMsgBagActivateWeaponReq(CSMsgBagActivateWeaponReq other)
		: this()
	{
		targetEquipId_ = other.targetEquipId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagActivateWeaponReq Clone()
	{
		return new CSMsgBagActivateWeaponReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagActivateWeaponReq);
	}

	public bool Equals(CSMsgBagActivateWeaponReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetEquipId != other.TargetEquipId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TargetEquipId != 0)
		{
			num ^= TargetEquipId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TargetEquipId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TargetEquipId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TargetEquipId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetEquipId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagActivateWeaponReq other)
	{
		if (other != null)
		{
			if (other.TargetEquipId != 0)
			{
				TargetEquipId = other.TargetEquipId;
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
				TargetEquipId = input.ReadInt32();
			}
		}
	}
}
