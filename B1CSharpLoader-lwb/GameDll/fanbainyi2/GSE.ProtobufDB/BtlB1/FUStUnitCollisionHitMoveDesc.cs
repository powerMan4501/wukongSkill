using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStUnitCollisionHitMoveDesc : IMessage<FUStUnitCollisionHitMoveDesc>, IMessage, IEquatable<FUStUnitCollisionHitMoveDesc>, IDeepCloneable<FUStUnitCollisionHitMoveDesc>
{
	private static readonly MessageParser<FUStUnitCollisionHitMoveDesc> _parser = new MessageParser<FUStUnitCollisionHitMoveDesc>(() => new FUStUnitCollisionHitMoveDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float unitHitMoveWeight_;

	private EGSYesNo disableBattleURO_;

	private static readonly FieldCodec<FUStUnitCollisionConfig> _repeated_otherCollisions_codec = FieldCodec.ForMessage(34u, FUStUnitCollisionConfig.Parser);

	private readonly RepeatedField<FUStUnitCollisionConfig> otherCollisions_ = new RepeatedField<FUStUnitCollisionConfig>();

	public static MessageParser<FUStUnitCollisionHitMoveDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public float UnitHitMoveWeight
	{
		get
		{
			return unitHitMoveWeight_;
		}
		set
		{
			unitHitMoveWeight_ = value;
		}
	}

	public EGSYesNo DisableBattleURO
	{
		get
		{
			return disableBattleURO_;
		}
		set
		{
			disableBattleURO_ = value;
		}
	}

	public RepeatedField<FUStUnitCollisionConfig> OtherCollisions => otherCollisions_;

	public FUStUnitCollisionHitMoveDesc()
	{
	}

	public FUStUnitCollisionHitMoveDesc(FUStUnitCollisionHitMoveDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitHitMoveWeight_ = other.unitHitMoveWeight_;
		disableBattleURO_ = other.disableBattleURO_;
		otherCollisions_ = other.otherCollisions_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitCollisionHitMoveDesc Clone()
	{
		return new FUStUnitCollisionHitMoveDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitCollisionHitMoveDesc);
	}

	public bool Equals(FUStUnitCollisionHitMoveDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(UnitHitMoveWeight, other.UnitHitMoveWeight))
		{
			return false;
		}
		if (DisableBattleURO != other.DisableBattleURO)
		{
			return false;
		}
		if (!otherCollisions_.Equals(other.otherCollisions_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (UnitHitMoveWeight != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(UnitHitMoveWeight);
		}
		if (DisableBattleURO != EGSYesNo.No)
		{
			num ^= DisableBattleURO.GetHashCode();
		}
		num ^= otherCollisions_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (UnitHitMoveWeight != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(UnitHitMoveWeight);
		}
		if (DisableBattleURO != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)DisableBattleURO);
		}
		otherCollisions_.WriteTo(output, _repeated_otherCollisions_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (UnitHitMoveWeight != 0f)
		{
			num += 5;
		}
		if (DisableBattleURO != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DisableBattleURO);
		}
		num += otherCollisions_.CalculateSize(_repeated_otherCollisions_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitCollisionHitMoveDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitHitMoveWeight != 0f)
			{
				UnitHitMoveWeight = other.UnitHitMoveWeight;
			}
			if (other.DisableBattleURO != EGSYesNo.No)
			{
				DisableBattleURO = other.DisableBattleURO;
			}
			otherCollisions_.Add(other.otherCollisions_);
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
				ID = input.ReadInt32();
				break;
			case 21u:
				UnitHitMoveWeight = input.ReadFloat();
				break;
			case 24u:
				DisableBattleURO = (EGSYesNo)input.ReadEnum();
				break;
			case 34u:
				otherCollisions_.AddEntriesFrom(input, _repeated_otherCollisions_codec);
				break;
			}
		}
	}
}
