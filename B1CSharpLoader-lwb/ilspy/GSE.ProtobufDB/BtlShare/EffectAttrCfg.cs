using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class EffectAttrCfg : IMessage<EffectAttrCfg>, IMessage, IEquatable<EffectAttrCfg>, IDeepCloneable<EffectAttrCfg>
{
	private static readonly MessageParser<EffectAttrCfg> _parser = new MessageParser<EffectAttrCfg>(() => new EffectAttrCfg());

	private UnknownFieldSet _unknownFields;

	private EBGUAttrFloat type_;

	private float value_;

	public static MessageParser<EffectAttrCfg> Parser => _parser;

	public EBGUAttrFloat Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public float Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public EffectAttrCfg()
	{
	}

	public EffectAttrCfg(EffectAttrCfg other)
		: this()
	{
		type_ = other.type_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EffectAttrCfg Clone()
	{
		return new EffectAttrCfg(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EffectAttrCfg);
	}

	public bool Equals(EffectAttrCfg other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Value, other.Value))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Type != EBGUAttrFloat.None)
		{
			num ^= Type.GetHashCode();
		}
		if (Value != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Value);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Type != EBGUAttrFloat.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (Value != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Type != EBGUAttrFloat.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Value != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EffectAttrCfg other)
	{
		if (other != null)
		{
			if (other.Type != EBGUAttrFloat.None)
			{
				Type = other.Type;
			}
			if (other.Value != 0f)
			{
				Value = other.Value;
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
				Type = (EBGUAttrFloat)input.ReadEnum();
				break;
			case 21u:
				Value = input.ReadFloat();
				break;
			}
		}
	}
}
