using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class FRotator : IMessage<FRotator>, IMessage, IEquatable<FRotator>, IDeepCloneable<FRotator>
{
	private static readonly MessageParser<FRotator> _parser = new MessageParser<FRotator>(() => new FRotator());

	private UnknownFieldSet _unknownFields;

	private float yaw_;

	private float pitch_;

	private float roll_;

	public static MessageParser<FRotator> Parser => _parser;

	public float Yaw
	{
		get
		{
			return yaw_;
		}
		set
		{
			yaw_ = value;
		}
	}

	public float Pitch
	{
		get
		{
			return pitch_;
		}
		set
		{
			pitch_ = value;
		}
	}

	public float Roll
	{
		get
		{
			return roll_;
		}
		set
		{
			roll_ = value;
		}
	}

	public FRotator()
	{
	}

	public FRotator(FRotator other)
		: this()
	{
		yaw_ = other.yaw_;
		pitch_ = other.pitch_;
		roll_ = other.roll_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FRotator Clone()
	{
		return new FRotator(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FRotator);
	}

	public bool Equals(FRotator other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Yaw, other.Yaw))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Pitch, other.Pitch))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Roll, other.Roll))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Yaw != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Yaw);
		}
		if (Pitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Pitch);
		}
		if (Roll != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Roll);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Yaw != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(Yaw);
		}
		if (Pitch != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Pitch);
		}
		if (Roll != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(Roll);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Yaw != 0f)
		{
			num += 5;
		}
		if (Pitch != 0f)
		{
			num += 5;
		}
		if (Roll != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FRotator other)
	{
		if (other != null)
		{
			if (other.Yaw != 0f)
			{
				Yaw = other.Yaw;
			}
			if (other.Pitch != 0f)
			{
				Pitch = other.Pitch;
			}
			if (other.Roll != 0f)
			{
				Roll = other.Roll;
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
				Yaw = input.ReadFloat();
				break;
			case 21u:
				Pitch = input.ReadFloat();
				break;
			case 29u:
				Roll = input.ReadFloat();
				break;
			}
		}
	}
}
