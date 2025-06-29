using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagArmorUpgradeReq : IMessage<CSMsgBagArmorUpgradeReq>, IMessage, IEquatable<CSMsgBagArmorUpgradeReq>, IDeepCloneable<CSMsgBagArmorUpgradeReq>
{
	private static readonly MessageParser<CSMsgBagArmorUpgradeReq> _parser = new MessageParser<CSMsgBagArmorUpgradeReq>(() => new CSMsgBagArmorUpgradeReq());

	private UnknownFieldSet _unknownFields;

	private ulong armorUid_;

	public static MessageParser<CSMsgBagArmorUpgradeReq> Parser => _parser;

	public ulong ArmorUid
	{
		get
		{
			return armorUid_;
		}
		set
		{
			armorUid_ = value;
		}
	}

	public CSMsgBagArmorUpgradeReq()
	{
	}

	public CSMsgBagArmorUpgradeReq(CSMsgBagArmorUpgradeReq other)
		: this()
	{
		armorUid_ = other.armorUid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagArmorUpgradeReq Clone()
	{
		return new CSMsgBagArmorUpgradeReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagArmorUpgradeReq);
	}

	public bool Equals(CSMsgBagArmorUpgradeReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ArmorUid != other.ArmorUid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ArmorUid != 0L)
		{
			num ^= ArmorUid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ArmorUid != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(ArmorUid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ArmorUid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ArmorUid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagArmorUpgradeReq other)
	{
		if (other != null)
		{
			if (other.ArmorUid != 0L)
			{
				ArmorUid = other.ArmorUid;
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
				ArmorUid = input.ReadUInt64();
			}
		}
	}
}
