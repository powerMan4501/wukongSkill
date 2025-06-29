using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class FallDyingData : IMessage<FallDyingData>, IMessage, IEquatable<FallDyingData>, IDeepCloneable<FallDyingData>
{
	private static readonly MessageParser<FallDyingData> _parser = new MessageParser<FallDyingData>(() => new FallDyingData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private float fallDyingTime_;

	private float saveSelfWaitTime_;

	private int unitFallDyingState_;

	private FVector vectorTest_;

	private FRotator rotatorTest_;

	private static readonly FieldCodec<ListDeltaMsgFloat> _repeated_gSListTest_codec = FieldCodec.ForMessage(50u, ListDeltaMsgFloat.Parser);

	private readonly RepeatedField<ListDeltaMsgFloat> gSListTest_ = new RepeatedField<ListDeltaMsgFloat>();

	public static MessageParser<FallDyingData> Parser => _parser;

	public float FallDyingTime
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return fallDyingTime_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 1;
			fallDyingTime_ = value;
		}
	}

	public bool HasFallDyingTime => (_hasBits0 & 1) != 0;

	public float SaveSelfWaitTime
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return saveSelfWaitTime_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			saveSelfWaitTime_ = value;
		}
	}

	public bool HasSaveSelfWaitTime => (_hasBits0 & 2) != 0;

	public int UnitFallDyingState
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return unitFallDyingState_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			unitFallDyingState_ = value;
		}
	}

	public bool HasUnitFallDyingState => (_hasBits0 & 4) != 0;

	public FVector VectorTest
	{
		get
		{
			return vectorTest_;
		}
		set
		{
			vectorTest_ = value;
		}
	}

	public FRotator RotatorTest
	{
		get
		{
			return rotatorTest_;
		}
		set
		{
			rotatorTest_ = value;
		}
	}

	public RepeatedField<ListDeltaMsgFloat> GSListTest => gSListTest_;

	public FallDyingData()
	{
	}

	public FallDyingData(FallDyingData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		fallDyingTime_ = other.fallDyingTime_;
		saveSelfWaitTime_ = other.saveSelfWaitTime_;
		unitFallDyingState_ = other.unitFallDyingState_;
		vectorTest_ = ((other.vectorTest_ != null) ? other.vectorTest_.Clone() : null);
		rotatorTest_ = ((other.rotatorTest_ != null) ? other.rotatorTest_.Clone() : null);
		gSListTest_ = other.gSListTest_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FallDyingData Clone()
	{
		return new FallDyingData(this);
	}

	public void ClearFallDyingTime()
	{
		_hasBits0 &= -2;
	}

	public void ClearSaveSelfWaitTime()
	{
		_hasBits0 &= -3;
	}

	public void ClearUnitFallDyingState()
	{
		_hasBits0 &= -5;
	}

	public override bool Equals(object other)
	{
		return Equals(other as FallDyingData);
	}

	public bool Equals(FallDyingData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FallDyingTime, other.FallDyingTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SaveSelfWaitTime, other.SaveSelfWaitTime))
		{
			return false;
		}
		if (UnitFallDyingState != other.UnitFallDyingState)
		{
			return false;
		}
		if (!object.Equals(VectorTest, other.VectorTest))
		{
			return false;
		}
		if (!object.Equals(RotatorTest, other.RotatorTest))
		{
			return false;
		}
		if (!gSListTest_.Equals(other.gSListTest_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasFallDyingTime)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FallDyingTime);
		}
		if (HasSaveSelfWaitTime)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SaveSelfWaitTime);
		}
		if (HasUnitFallDyingState)
		{
			num ^= UnitFallDyingState.GetHashCode();
		}
		if (vectorTest_ != null)
		{
			num ^= VectorTest.GetHashCode();
		}
		if (rotatorTest_ != null)
		{
			num ^= RotatorTest.GetHashCode();
		}
		num ^= gSListTest_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasFallDyingTime)
		{
			output.WriteRawTag(13);
			output.WriteFloat(FallDyingTime);
		}
		if (HasSaveSelfWaitTime)
		{
			output.WriteRawTag(21);
			output.WriteFloat(SaveSelfWaitTime);
		}
		if (HasUnitFallDyingState)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UnitFallDyingState);
		}
		if (vectorTest_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(VectorTest);
		}
		if (rotatorTest_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(RotatorTest);
		}
		gSListTest_.WriteTo(output, _repeated_gSListTest_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasFallDyingTime)
		{
			num += 5;
		}
		if (HasSaveSelfWaitTime)
		{
			num += 5;
		}
		if (HasUnitFallDyingState)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitFallDyingState);
		}
		if (vectorTest_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(VectorTest);
		}
		if (rotatorTest_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RotatorTest);
		}
		num += gSListTest_.CalculateSize(_repeated_gSListTest_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FallDyingData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HasFallDyingTime)
		{
			FallDyingTime = other.FallDyingTime;
		}
		if (other.HasSaveSelfWaitTime)
		{
			SaveSelfWaitTime = other.SaveSelfWaitTime;
		}
		if (other.HasUnitFallDyingState)
		{
			UnitFallDyingState = other.UnitFallDyingState;
		}
		if (other.vectorTest_ != null)
		{
			if (vectorTest_ == null)
			{
				VectorTest = new FVector();
			}
			VectorTest.MergeFrom(other.VectorTest);
		}
		if (other.rotatorTest_ != null)
		{
			if (rotatorTest_ == null)
			{
				RotatorTest = new FRotator();
			}
			RotatorTest.MergeFrom(other.RotatorTest);
		}
		gSListTest_.Add(other.gSListTest_);
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
			case 13u:
				FallDyingTime = input.ReadFloat();
				break;
			case 21u:
				SaveSelfWaitTime = input.ReadFloat();
				break;
			case 24u:
				UnitFallDyingState = input.ReadInt32();
				break;
			case 34u:
				if (vectorTest_ == null)
				{
					VectorTest = new FVector();
				}
				input.ReadMessage(VectorTest);
				break;
			case 42u:
				if (rotatorTest_ == null)
				{
					RotatorTest = new FRotator();
				}
				input.ReadMessage(RotatorTest);
				break;
			case 50u:
				gSListTest_.AddEntriesFrom(input, _repeated_gSListTest_codec);
				break;
			}
		}
	}
}
