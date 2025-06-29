using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_GiveBackControlRight : IMessage<MovieCustom_GiveBackControlRight>, IMessage, IEquatable<MovieCustom_GiveBackControlRight>, IDeepCloneable<MovieCustom_GiveBackControlRight>
{
	private static readonly MessageParser<MovieCustom_GiveBackControlRight> _parser = new MessageParser<MovieCustom_GiveBackControlRight>(() => new MovieCustom_GiveBackControlRight());

	private UnknownFieldSet _unknownFields;

	private float cameraBlendOutTime_;

	private int cameraBlendOutFunc_;

	private float cameraBlendOutExp_;

	public static MessageParser<MovieCustom_GiveBackControlRight> Parser => _parser;

	public float CameraBlendOutTime
	{
		get
		{
			return cameraBlendOutTime_;
		}
		set
		{
			cameraBlendOutTime_ = value;
		}
	}

	public int CameraBlendOutFunc
	{
		get
		{
			return cameraBlendOutFunc_;
		}
		set
		{
			cameraBlendOutFunc_ = value;
		}
	}

	public float CameraBlendOutExp
	{
		get
		{
			return cameraBlendOutExp_;
		}
		set
		{
			cameraBlendOutExp_ = value;
		}
	}

	public MovieCustom_GiveBackControlRight()
	{
	}

	public MovieCustom_GiveBackControlRight(MovieCustom_GiveBackControlRight other)
		: this()
	{
		cameraBlendOutTime_ = other.cameraBlendOutTime_;
		cameraBlendOutFunc_ = other.cameraBlendOutFunc_;
		cameraBlendOutExp_ = other.cameraBlendOutExp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_GiveBackControlRight Clone()
	{
		return new MovieCustom_GiveBackControlRight(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_GiveBackControlRight);
	}

	public bool Equals(MovieCustom_GiveBackControlRight other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraBlendOutTime, other.CameraBlendOutTime))
		{
			return false;
		}
		if (CameraBlendOutFunc != other.CameraBlendOutFunc)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CameraBlendOutExp, other.CameraBlendOutExp))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CameraBlendOutTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraBlendOutTime);
		}
		if (CameraBlendOutFunc != 0)
		{
			num ^= CameraBlendOutFunc.GetHashCode();
		}
		if (CameraBlendOutExp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CameraBlendOutExp);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CameraBlendOutTime != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(CameraBlendOutTime);
		}
		if (CameraBlendOutFunc != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CameraBlendOutFunc);
		}
		if (CameraBlendOutExp != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(CameraBlendOutExp);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CameraBlendOutTime != 0f)
		{
			num += 5;
		}
		if (CameraBlendOutFunc != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CameraBlendOutFunc);
		}
		if (CameraBlendOutExp != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_GiveBackControlRight other)
	{
		if (other != null)
		{
			if (other.CameraBlendOutTime != 0f)
			{
				CameraBlendOutTime = other.CameraBlendOutTime;
			}
			if (other.CameraBlendOutFunc != 0)
			{
				CameraBlendOutFunc = other.CameraBlendOutFunc;
			}
			if (other.CameraBlendOutExp != 0f)
			{
				CameraBlendOutExp = other.CameraBlendOutExp;
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
				CameraBlendOutTime = input.ReadFloat();
				break;
			case 16u:
				CameraBlendOutFunc = input.ReadInt32();
				break;
			case 29u:
				CameraBlendOutExp = input.ReadFloat();
				break;
			}
		}
	}
}
