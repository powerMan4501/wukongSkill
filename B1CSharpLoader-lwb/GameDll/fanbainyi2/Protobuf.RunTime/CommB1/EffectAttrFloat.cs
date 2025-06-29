using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class EffectAttrFloat : IMessage<EffectAttrFloat>, IMessage, IEquatable<EffectAttrFloat>, IDeepCloneable<EffectAttrFloat>
{
	private static readonly MessageParser<EffectAttrFloat> _parser = new MessageParser<EffectAttrFloat>(() => new EffectAttrFloat());

	private UnknownFieldSet _unknownFields;

	private EBGUAttrFloat type_;

	private float value_;

	public static MessageParser<EffectAttrFloat> Parser => _parser;

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

	public EffectAttrFloat()
	{
	}

	public EffectAttrFloat(EffectAttrFloat other)
		: this()
	{
		type_ = other.type_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EffectAttrFloat Clone()
	{
		return new EffectAttrFloat(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EffectAttrFloat);
	}

	public bool Equals(EffectAttrFloat other)
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

	public void MergeFrom(EffectAttrFloat other)
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
