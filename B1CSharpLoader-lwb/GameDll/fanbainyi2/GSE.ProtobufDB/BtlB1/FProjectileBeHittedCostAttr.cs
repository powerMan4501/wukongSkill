using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FProjectileBeHittedCostAttr : IMessage<FProjectileBeHittedCostAttr>, IMessage, IEquatable<FProjectileBeHittedCostAttr>, IDeepCloneable<FProjectileBeHittedCostAttr>
{
	private static readonly MessageParser<FProjectileBeHittedCostAttr> _parser = new MessageParser<FProjectileBeHittedCostAttr>(() => new FProjectileBeHittedCostAttr());

	private UnknownFieldSet _unknownFields;

	private EProjectileBeHittedCostAttrType costAttrType_;

	private float switchRatio_;

	public static MessageParser<FProjectileBeHittedCostAttr> Parser => _parser;

	public EProjectileBeHittedCostAttrType CostAttrType
	{
		get
		{
			return costAttrType_;
		}
		set
		{
			costAttrType_ = value;
		}
	}

	public float SwitchRatio
	{
		get
		{
			return switchRatio_;
		}
		set
		{
			switchRatio_ = value;
		}
	}

	public FProjectileBeHittedCostAttr()
	{
	}

	public FProjectileBeHittedCostAttr(FProjectileBeHittedCostAttr other)
		: this()
	{
		costAttrType_ = other.costAttrType_;
		switchRatio_ = other.switchRatio_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FProjectileBeHittedCostAttr Clone()
	{
		return new FProjectileBeHittedCostAttr(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FProjectileBeHittedCostAttr);
	}

	public bool Equals(FProjectileBeHittedCostAttr other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CostAttrType != other.CostAttrType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SwitchRatio, other.SwitchRatio))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CostAttrType != EProjectileBeHittedCostAttrType.None)
		{
			num ^= CostAttrType.GetHashCode();
		}
		if (SwitchRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SwitchRatio);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CostAttrType != EProjectileBeHittedCostAttrType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)CostAttrType);
		}
		if (SwitchRatio != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(SwitchRatio);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CostAttrType != EProjectileBeHittedCostAttrType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CostAttrType);
		}
		if (SwitchRatio != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FProjectileBeHittedCostAttr other)
	{
		if (other != null)
		{
			if (other.CostAttrType != EProjectileBeHittedCostAttrType.None)
			{
				CostAttrType = other.CostAttrType;
			}
			if (other.SwitchRatio != 0f)
			{
				SwitchRatio = other.SwitchRatio;
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
				CostAttrType = (EProjectileBeHittedCostAttrType)input.ReadEnum();
				break;
			case 21u:
				SwitchRatio = input.ReadFloat();
				break;
			}
		}
	}
}
