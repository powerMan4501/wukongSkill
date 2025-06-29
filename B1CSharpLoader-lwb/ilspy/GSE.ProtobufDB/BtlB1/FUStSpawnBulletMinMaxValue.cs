using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSpawnBulletMinMaxValue : IMessage<FUStSpawnBulletMinMaxValue>, IMessage, IEquatable<FUStSpawnBulletMinMaxValue>, IDeepCloneable<FUStSpawnBulletMinMaxValue>
{
	private static readonly MessageParser<FUStSpawnBulletMinMaxValue> _parser = new MessageParser<FUStSpawnBulletMinMaxValue>(() => new FUStSpawnBulletMinMaxValue());

	private UnknownFieldSet _unknownFields;

	private float leftValue_;

	private float rightValue_;

	private bool isEquidistance_;

	public static MessageParser<FUStSpawnBulletMinMaxValue> Parser => _parser;

	public float LeftValue
	{
		get
		{
			return leftValue_;
		}
		set
		{
			leftValue_ = value;
		}
	}

	public float RightValue
	{
		get
		{
			return rightValue_;
		}
		set
		{
			rightValue_ = value;
		}
	}

	public bool IsEquidistance
	{
		get
		{
			return isEquidistance_;
		}
		set
		{
			isEquidistance_ = value;
		}
	}

	public FUStSpawnBulletMinMaxValue()
	{
	}

	public FUStSpawnBulletMinMaxValue(FUStSpawnBulletMinMaxValue other)
		: this()
	{
		leftValue_ = other.leftValue_;
		rightValue_ = other.rightValue_;
		isEquidistance_ = other.isEquidistance_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSpawnBulletMinMaxValue Clone()
	{
		return new FUStSpawnBulletMinMaxValue(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSpawnBulletMinMaxValue);
	}

	public bool Equals(FUStSpawnBulletMinMaxValue other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LeftValue, other.LeftValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RightValue, other.RightValue))
		{
			return false;
		}
		if (IsEquidistance != other.IsEquidistance)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LeftValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LeftValue);
		}
		if (RightValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RightValue);
		}
		if (IsEquidistance)
		{
			num ^= IsEquidistance.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LeftValue != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(LeftValue);
		}
		if (RightValue != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(RightValue);
		}
		if (IsEquidistance)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsEquidistance);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LeftValue != 0f)
		{
			num += 5;
		}
		if (RightValue != 0f)
		{
			num += 5;
		}
		if (IsEquidistance)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSpawnBulletMinMaxValue other)
	{
		if (other != null)
		{
			if (other.LeftValue != 0f)
			{
				LeftValue = other.LeftValue;
			}
			if (other.RightValue != 0f)
			{
				RightValue = other.RightValue;
			}
			if (other.IsEquidistance)
			{
				IsEquidistance = other.IsEquidistance;
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
				LeftValue = input.ReadFloat();
				break;
			case 21u:
				RightValue = input.ReadFloat();
				break;
			case 24u:
				IsEquidistance = input.ReadBool();
				break;
			}
		}
	}
}
