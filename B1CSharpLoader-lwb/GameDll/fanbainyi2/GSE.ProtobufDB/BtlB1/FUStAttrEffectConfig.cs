using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAttrEffectConfig : IMessage<FUStAttrEffectConfig>, IMessage, IEquatable<FUStAttrEffectConfig>, IDeepCloneable<FUStAttrEffectConfig>
{
	private static readonly MessageParser<FUStAttrEffectConfig> _parser = new MessageParser<FUStAttrEffectConfig>(() => new FUStAttrEffectConfig());

	private UnknownFieldSet _unknownFields;

	private EGSYesNo isFloatType_;

	private int attrID_;

	private float attrValue_;

	public static MessageParser<FUStAttrEffectConfig> Parser => _parser;

	public EGSYesNo IsFloatType
	{
		get
		{
			return isFloatType_;
		}
		set
		{
			isFloatType_ = value;
		}
	}

	public int AttrID
	{
		get
		{
			return attrID_;
		}
		set
		{
			attrID_ = value;
		}
	}

	public float AttrValue
	{
		get
		{
			return attrValue_;
		}
		set
		{
			attrValue_ = value;
		}
	}

	public FUStAttrEffectConfig()
	{
	}

	public FUStAttrEffectConfig(FUStAttrEffectConfig other)
		: this()
	{
		isFloatType_ = other.isFloatType_;
		attrID_ = other.attrID_;
		attrValue_ = other.attrValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAttrEffectConfig Clone()
	{
		return new FUStAttrEffectConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAttrEffectConfig);
	}

	public bool Equals(FUStAttrEffectConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsFloatType != other.IsFloatType)
		{
			return false;
		}
		if (AttrID != other.AttrID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttrValue, other.AttrValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsFloatType != EGSYesNo.No)
		{
			num ^= IsFloatType.GetHashCode();
		}
		if (AttrID != 0)
		{
			num ^= AttrID.GetHashCode();
		}
		if (AttrValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttrValue);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsFloatType != EGSYesNo.No)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)IsFloatType);
		}
		if (AttrID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AttrID);
		}
		if (AttrValue != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(AttrValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsFloatType != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsFloatType);
		}
		if (AttrID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrID);
		}
		if (AttrValue != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAttrEffectConfig other)
	{
		if (other != null)
		{
			if (other.IsFloatType != EGSYesNo.No)
			{
				IsFloatType = other.IsFloatType;
			}
			if (other.AttrID != 0)
			{
				AttrID = other.AttrID;
			}
			if (other.AttrValue != 0f)
			{
				AttrValue = other.AttrValue;
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
				IsFloatType = (EGSYesNo)input.ReadEnum();
				break;
			case 16u:
				AttrID = input.ReadInt32();
				break;
			case 29u:
				AttrValue = input.ReadFloat();
				break;
			}
		}
	}
}
