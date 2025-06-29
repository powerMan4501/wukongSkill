using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStProjectileBornDirOffset : IMessage<FUStProjectileBornDirOffset>, IMessage, IEquatable<FUStProjectileBornDirOffset>, IDeepCloneable<FUStProjectileBornDirOffset>
{
	private static readonly MessageParser<FUStProjectileBornDirOffset> _parser = new MessageParser<FUStProjectileBornDirOffset>(() => new FUStProjectileBornDirOffset());

	private UnknownFieldSet _unknownFields;

	private bool useExtraAimPoint_;

	private bool extraAimPointUseSocket_;

	private string extraAimPointName_ = "";

	private float maxDiffAngle_;

	private static readonly FieldCodec<float> _repeated_aimConstraintAxis_codec = FieldCodec.ForFloat(42u);

	private readonly RepeatedField<float> aimConstraintAxis_ = new RepeatedField<float>();

	private FUStSpawnBulletMinMaxValue bornDirOffsetX_;

	private FUStSpawnBulletMinMaxValue bornDirOffsetY_;

	private FUStSpawnBulletMinMaxValue bornDirOffsetZ_;

	public static MessageParser<FUStProjectileBornDirOffset> Parser => _parser;

	public bool UseExtraAimPoint
	{
		get
		{
			return useExtraAimPoint_;
		}
		set
		{
			useExtraAimPoint_ = value;
		}
	}

	public bool ExtraAimPointUseSocket
	{
		get
		{
			return extraAimPointUseSocket_;
		}
		set
		{
			extraAimPointUseSocket_ = value;
		}
	}

	public string ExtraAimPointName
	{
		get
		{
			return extraAimPointName_;
		}
		set
		{
			extraAimPointName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float MaxDiffAngle
	{
		get
		{
			return maxDiffAngle_;
		}
		set
		{
			maxDiffAngle_ = value;
		}
	}

	public RepeatedField<float> AimConstraintAxis => aimConstraintAxis_;

	public FUStSpawnBulletMinMaxValue BornDirOffsetX
	{
		get
		{
			return bornDirOffsetX_;
		}
		set
		{
			bornDirOffsetX_ = value;
		}
	}

	public FUStSpawnBulletMinMaxValue BornDirOffsetY
	{
		get
		{
			return bornDirOffsetY_;
		}
		set
		{
			bornDirOffsetY_ = value;
		}
	}

	public FUStSpawnBulletMinMaxValue BornDirOffsetZ
	{
		get
		{
			return bornDirOffsetZ_;
		}
		set
		{
			bornDirOffsetZ_ = value;
		}
	}

	public FUStProjectileBornDirOffset()
	{
	}

	public FUStProjectileBornDirOffset(FUStProjectileBornDirOffset other)
		: this()
	{
		useExtraAimPoint_ = other.useExtraAimPoint_;
		extraAimPointUseSocket_ = other.extraAimPointUseSocket_;
		extraAimPointName_ = other.extraAimPointName_;
		maxDiffAngle_ = other.maxDiffAngle_;
		aimConstraintAxis_ = other.aimConstraintAxis_.Clone();
		bornDirOffsetX_ = ((other.bornDirOffsetX_ != null) ? other.bornDirOffsetX_.Clone() : null);
		bornDirOffsetY_ = ((other.bornDirOffsetY_ != null) ? other.bornDirOffsetY_.Clone() : null);
		bornDirOffsetZ_ = ((other.bornDirOffsetZ_ != null) ? other.bornDirOffsetZ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStProjectileBornDirOffset Clone()
	{
		return new FUStProjectileBornDirOffset(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStProjectileBornDirOffset);
	}

	public bool Equals(FUStProjectileBornDirOffset other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UseExtraAimPoint != other.UseExtraAimPoint)
		{
			return false;
		}
		if (ExtraAimPointUseSocket != other.ExtraAimPointUseSocket)
		{
			return false;
		}
		if (ExtraAimPointName != other.ExtraAimPointName)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxDiffAngle, other.MaxDiffAngle))
		{
			return false;
		}
		if (!aimConstraintAxis_.Equals(other.aimConstraintAxis_))
		{
			return false;
		}
		if (!object.Equals(BornDirOffsetX, other.BornDirOffsetX))
		{
			return false;
		}
		if (!object.Equals(BornDirOffsetY, other.BornDirOffsetY))
		{
			return false;
		}
		if (!object.Equals(BornDirOffsetZ, other.BornDirOffsetZ))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UseExtraAimPoint)
		{
			num ^= UseExtraAimPoint.GetHashCode();
		}
		if (ExtraAimPointUseSocket)
		{
			num ^= ExtraAimPointUseSocket.GetHashCode();
		}
		if (ExtraAimPointName.Length != 0)
		{
			num ^= ExtraAimPointName.GetHashCode();
		}
		if (MaxDiffAngle != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxDiffAngle);
		}
		num ^= aimConstraintAxis_.GetHashCode();
		if (bornDirOffsetX_ != null)
		{
			num ^= BornDirOffsetX.GetHashCode();
		}
		if (bornDirOffsetY_ != null)
		{
			num ^= BornDirOffsetY.GetHashCode();
		}
		if (bornDirOffsetZ_ != null)
		{
			num ^= BornDirOffsetZ.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UseExtraAimPoint)
		{
			output.WriteRawTag(8);
			output.WriteBool(UseExtraAimPoint);
		}
		if (ExtraAimPointUseSocket)
		{
			output.WriteRawTag(16);
			output.WriteBool(ExtraAimPointUseSocket);
		}
		if (ExtraAimPointName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ExtraAimPointName);
		}
		if (MaxDiffAngle != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(MaxDiffAngle);
		}
		aimConstraintAxis_.WriteTo(output, _repeated_aimConstraintAxis_codec);
		if (bornDirOffsetX_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BornDirOffsetX);
		}
		if (bornDirOffsetY_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(BornDirOffsetY);
		}
		if (bornDirOffsetZ_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BornDirOffsetZ);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UseExtraAimPoint)
		{
			num += 2;
		}
		if (ExtraAimPointUseSocket)
		{
			num += 2;
		}
		if (ExtraAimPointName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ExtraAimPointName);
		}
		if (MaxDiffAngle != 0f)
		{
			num += 5;
		}
		num += aimConstraintAxis_.CalculateSize(_repeated_aimConstraintAxis_codec);
		if (bornDirOffsetX_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BornDirOffsetX);
		}
		if (bornDirOffsetY_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BornDirOffsetY);
		}
		if (bornDirOffsetZ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BornDirOffsetZ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStProjectileBornDirOffset other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UseExtraAimPoint)
		{
			UseExtraAimPoint = other.UseExtraAimPoint;
		}
		if (other.ExtraAimPointUseSocket)
		{
			ExtraAimPointUseSocket = other.ExtraAimPointUseSocket;
		}
		if (other.ExtraAimPointName.Length != 0)
		{
			ExtraAimPointName = other.ExtraAimPointName;
		}
		if (other.MaxDiffAngle != 0f)
		{
			MaxDiffAngle = other.MaxDiffAngle;
		}
		aimConstraintAxis_.Add(other.aimConstraintAxis_);
		if (other.bornDirOffsetX_ != null)
		{
			if (bornDirOffsetX_ == null)
			{
				BornDirOffsetX = new FUStSpawnBulletMinMaxValue();
			}
			BornDirOffsetX.MergeFrom(other.BornDirOffsetX);
		}
		if (other.bornDirOffsetY_ != null)
		{
			if (bornDirOffsetY_ == null)
			{
				BornDirOffsetY = new FUStSpawnBulletMinMaxValue();
			}
			BornDirOffsetY.MergeFrom(other.BornDirOffsetY);
		}
		if (other.bornDirOffsetZ_ != null)
		{
			if (bornDirOffsetZ_ == null)
			{
				BornDirOffsetZ = new FUStSpawnBulletMinMaxValue();
			}
			BornDirOffsetZ.MergeFrom(other.BornDirOffsetZ);
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
			case 8u:
				UseExtraAimPoint = input.ReadBool();
				break;
			case 16u:
				ExtraAimPointUseSocket = input.ReadBool();
				break;
			case 26u:
				ExtraAimPointName = input.ReadString();
				break;
			case 37u:
				MaxDiffAngle = input.ReadFloat();
				break;
			case 42u:
			case 45u:
				aimConstraintAxis_.AddEntriesFrom(input, _repeated_aimConstraintAxis_codec);
				break;
			case 50u:
				if (bornDirOffsetX_ == null)
				{
					BornDirOffsetX = new FUStSpawnBulletMinMaxValue();
				}
				input.ReadMessage(BornDirOffsetX);
				break;
			case 58u:
				if (bornDirOffsetY_ == null)
				{
					BornDirOffsetY = new FUStSpawnBulletMinMaxValue();
				}
				input.ReadMessage(BornDirOffsetY);
				break;
			case 66u:
				if (bornDirOffsetZ_ == null)
				{
					BornDirOffsetZ = new FUStSpawnBulletMinMaxValue();
				}
				input.ReadMessage(BornDirOffsetZ);
				break;
			}
		}
	}
}
