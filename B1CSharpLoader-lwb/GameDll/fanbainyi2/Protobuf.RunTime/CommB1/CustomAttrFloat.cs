using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CustomAttrFloat : IMessage<CustomAttrFloat>, IMessage, IEquatable<CustomAttrFloat>, IDeepCloneable<CustomAttrFloat>
{
	private static readonly MessageParser<CustomAttrFloat> _parser = new MessageParser<CustomAttrFloat>(() => new CustomAttrFloat());

	private UnknownFieldSet _unknownFields;

	private int type_;

	private float value_;

	public static MessageParser<CustomAttrFloat> Parser => _parser;

	public int Type
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

	public CustomAttrFloat()
	{
	}

	public CustomAttrFloat(CustomAttrFloat other)
		: this()
	{
		type_ = other.type_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CustomAttrFloat Clone()
	{
		return new CustomAttrFloat(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CustomAttrFloat);
	}

	public bool Equals(CustomAttrFloat other)
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
		if (Type != 0)
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
		if (Type != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Type);
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
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Type);
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

	public void MergeFrom(CustomAttrFloat other)
	{
		if (other != null)
		{
			if (other.Type != 0)
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
				Type = input.ReadInt32();
				break;
			case 21u:
				Value = input.ReadFloat();
				break;
			}
		}
	}
}
