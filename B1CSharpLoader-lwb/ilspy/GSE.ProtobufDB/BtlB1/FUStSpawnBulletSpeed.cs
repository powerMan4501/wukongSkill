using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSpawnBulletSpeed : IMessage<FUStSpawnBulletSpeed>, IMessage, IEquatable<FUStSpawnBulletSpeed>, IDeepCloneable<FUStSpawnBulletSpeed>
{
	private static readonly MessageParser<FUStSpawnBulletSpeed> _parser = new MessageParser<FUStSpawnBulletSpeed>(() => new FUStSpawnBulletSpeed());

	private UnknownFieldSet _unknownFields;

	private FUStSpawnBulletMinMaxValue spd_;

	private float accelerationTime_;

	private string spdCurvePath_ = "";

	public static MessageParser<FUStSpawnBulletSpeed> Parser => _parser;

	public FUStSpawnBulletMinMaxValue Spd
	{
		get
		{
			return spd_;
		}
		set
		{
			spd_ = value;
		}
	}

	public float AccelerationTime
	{
		get
		{
			return accelerationTime_;
		}
		set
		{
			accelerationTime_ = value;
		}
	}

	public string SpdCurvePath
	{
		get
		{
			return spdCurvePath_;
		}
		set
		{
			spdCurvePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStSpawnBulletSpeed()
	{
	}

	public FUStSpawnBulletSpeed(FUStSpawnBulletSpeed other)
		: this()
	{
		spd_ = ((other.spd_ != null) ? other.spd_.Clone() : null);
		accelerationTime_ = other.accelerationTime_;
		spdCurvePath_ = other.spdCurvePath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSpawnBulletSpeed Clone()
	{
		return new FUStSpawnBulletSpeed(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSpawnBulletSpeed);
	}

	public bool Equals(FUStSpawnBulletSpeed other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Spd, other.Spd))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AccelerationTime, other.AccelerationTime))
		{
			return false;
		}
		if (SpdCurvePath != other.SpdCurvePath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (spd_ != null)
		{
			num ^= Spd.GetHashCode();
		}
		if (AccelerationTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AccelerationTime);
		}
		if (SpdCurvePath.Length != 0)
		{
			num ^= SpdCurvePath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (spd_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Spd);
		}
		if (AccelerationTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(AccelerationTime);
		}
		if (SpdCurvePath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(SpdCurvePath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (spd_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Spd);
		}
		if (AccelerationTime != 0f)
		{
			num += 5;
		}
		if (SpdCurvePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SpdCurvePath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSpawnBulletSpeed other)
	{
		if (other == null)
		{
			return;
		}
		if (other.spd_ != null)
		{
			if (spd_ == null)
			{
				Spd = new FUStSpawnBulletMinMaxValue();
			}
			Spd.MergeFrom(other.Spd);
		}
		if (other.AccelerationTime != 0f)
		{
			AccelerationTime = other.AccelerationTime;
		}
		if (other.SpdCurvePath.Length != 0)
		{
			SpdCurvePath = other.SpdCurvePath;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (spd_ == null)
				{
					Spd = new FUStSpawnBulletMinMaxValue();
				}
				input.ReadMessage(Spd);
				break;
			case 21u:
				AccelerationTime = input.ReadFloat();
				break;
			case 26u:
				SpdCurvePath = input.ReadString();
				break;
			}
		}
	}
}
