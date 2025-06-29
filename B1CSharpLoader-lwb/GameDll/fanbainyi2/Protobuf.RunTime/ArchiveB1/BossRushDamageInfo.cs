using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushDamageInfo : IMessage<BossRushDamageInfo>, IMessage, IEquatable<BossRushDamageInfo>, IDeepCloneable<BossRushDamageInfo>
{
	private static readonly MessageParser<BossRushDamageInfo> _parser = new MessageParser<BossRushDamageInfo>(() => new BossRushDamageInfo());

	private UnknownFieldSet _unknownFields;

	private float totalDamage_;

	private float hightestDamage_;

	private float criticalDmgRate_;

	private float totalBeDamaged_;

	private float criticalDmgTotal_;

	private float elemDotDmgTotal_;

	private float elemDotDmgRate_;

	public static MessageParser<BossRushDamageInfo> Parser => _parser;

	public float TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	public float HightestDamage
	{
		get
		{
			return hightestDamage_;
		}
		set
		{
			hightestDamage_ = value;
		}
	}

	public float CriticalDmgRate
	{
		get
		{
			return criticalDmgRate_;
		}
		set
		{
			criticalDmgRate_ = value;
		}
	}

	public float TotalBeDamaged
	{
		get
		{
			return totalBeDamaged_;
		}
		set
		{
			totalBeDamaged_ = value;
		}
	}

	public float CriticalDmgTotal
	{
		get
		{
			return criticalDmgTotal_;
		}
		set
		{
			criticalDmgTotal_ = value;
		}
	}

	public float ElemDotDmgTotal
	{
		get
		{
			return elemDotDmgTotal_;
		}
		set
		{
			elemDotDmgTotal_ = value;
		}
	}

	public float ElemDotDmgRate
	{
		get
		{
			return elemDotDmgRate_;
		}
		set
		{
			elemDotDmgRate_ = value;
		}
	}

	public BossRushDamageInfo()
	{
	}

	public BossRushDamageInfo(BossRushDamageInfo other)
		: this()
	{
		totalDamage_ = other.totalDamage_;
		hightestDamage_ = other.hightestDamage_;
		criticalDmgRate_ = other.criticalDmgRate_;
		totalBeDamaged_ = other.totalBeDamaged_;
		criticalDmgTotal_ = other.criticalDmgTotal_;
		elemDotDmgTotal_ = other.elemDotDmgTotal_;
		elemDotDmgRate_ = other.elemDotDmgRate_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushDamageInfo Clone()
	{
		return new BossRushDamageInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushDamageInfo);
	}

	public bool Equals(BossRushDamageInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalDamage, other.TotalDamage))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HightestDamage, other.HightestDamage))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CriticalDmgRate, other.CriticalDmgRate))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalBeDamaged, other.TotalBeDamaged))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CriticalDmgTotal, other.CriticalDmgTotal))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ElemDotDmgTotal, other.ElemDotDmgTotal))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ElemDotDmgRate, other.ElemDotDmgRate))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TotalDamage != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalDamage);
		}
		if (HightestDamage != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HightestDamage);
		}
		if (CriticalDmgRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CriticalDmgRate);
		}
		if (TotalBeDamaged != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalBeDamaged);
		}
		if (CriticalDmgTotal != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CriticalDmgTotal);
		}
		if (ElemDotDmgTotal != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ElemDotDmgTotal);
		}
		if (ElemDotDmgRate != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ElemDotDmgRate);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TotalDamage != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(TotalDamage);
		}
		if (HightestDamage != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(HightestDamage);
		}
		if (CriticalDmgRate != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(CriticalDmgRate);
		}
		if (TotalBeDamaged != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(TotalBeDamaged);
		}
		if (CriticalDmgTotal != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(CriticalDmgTotal);
		}
		if (ElemDotDmgTotal != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(ElemDotDmgTotal);
		}
		if (ElemDotDmgRate != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(ElemDotDmgRate);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TotalDamage != 0f)
		{
			num += 5;
		}
		if (HightestDamage != 0f)
		{
			num += 5;
		}
		if (CriticalDmgRate != 0f)
		{
			num += 5;
		}
		if (TotalBeDamaged != 0f)
		{
			num += 5;
		}
		if (CriticalDmgTotal != 0f)
		{
			num += 5;
		}
		if (ElemDotDmgTotal != 0f)
		{
			num += 5;
		}
		if (ElemDotDmgRate != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushDamageInfo other)
	{
		if (other != null)
		{
			if (other.TotalDamage != 0f)
			{
				TotalDamage = other.TotalDamage;
			}
			if (other.HightestDamage != 0f)
			{
				HightestDamage = other.HightestDamage;
			}
			if (other.CriticalDmgRate != 0f)
			{
				CriticalDmgRate = other.CriticalDmgRate;
			}
			if (other.TotalBeDamaged != 0f)
			{
				TotalBeDamaged = other.TotalBeDamaged;
			}
			if (other.CriticalDmgTotal != 0f)
			{
				CriticalDmgTotal = other.CriticalDmgTotal;
			}
			if (other.ElemDotDmgTotal != 0f)
			{
				ElemDotDmgTotal = other.ElemDotDmgTotal;
			}
			if (other.ElemDotDmgRate != 0f)
			{
				ElemDotDmgRate = other.ElemDotDmgRate;
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
			case 13u:
				TotalDamage = input.ReadFloat();
				break;
			case 21u:
				HightestDamage = input.ReadFloat();
				break;
			case 29u:
				CriticalDmgRate = input.ReadFloat();
				break;
			case 37u:
				TotalBeDamaged = input.ReadFloat();
				break;
			case 45u:
				CriticalDmgTotal = input.ReadFloat();
				break;
			case 53u:
				ElemDotDmgTotal = input.ReadFloat();
				break;
			case 61u:
				ElemDotDmgRate = input.ReadFloat();
				break;
			}
		}
	}
}
