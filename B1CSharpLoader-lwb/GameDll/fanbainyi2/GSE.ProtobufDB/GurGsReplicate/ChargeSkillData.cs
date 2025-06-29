using System;
using Google.Protobuf;

namespace GurGsReplicate;

public sealed class ChargeSkillData : IMessage<ChargeSkillData>, IMessage, IEquatable<ChargeSkillData>, IDeepCloneable<ChargeSkillData>
{
	private static readonly MessageParser<ChargeSkillData> _parser = new MessageParser<ChargeSkillData>(() => new ChargeSkillData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int curChargeLevel_;

	public static MessageParser<ChargeSkillData> Parser => _parser;

	public int CurChargeLevel
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return curChargeLevel_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			curChargeLevel_ = value;
		}
	}

	public bool HasCurChargeLevel => (_hasBits0 & 1) != 0;

	public ChargeSkillData()
	{
	}

	public ChargeSkillData(ChargeSkillData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		curChargeLevel_ = other.curChargeLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChargeSkillData Clone()
	{
		return new ChargeSkillData(this);
	}

	public void ClearCurChargeLevel()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChargeSkillData);
	}

	public bool Equals(ChargeSkillData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurChargeLevel != other.CurChargeLevel)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasCurChargeLevel)
		{
			num ^= CurChargeLevel.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasCurChargeLevel)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CurChargeLevel);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasCurChargeLevel)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurChargeLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ChargeSkillData other)
	{
		if (other != null)
		{
			if (other.HasCurChargeLevel)
			{
				CurChargeLevel = other.CurChargeLevel;
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
				CurChargeLevel = input.ReadInt32();
			}
		}
	}
}
