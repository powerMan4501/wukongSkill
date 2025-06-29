using System;
using Google.Protobuf;

namespace X2.Base;

public sealed class FUStB2DUnitSpawnDesc : IMessage<FUStB2DUnitSpawnDesc>, IMessage, IEquatable<FUStB2DUnitSpawnDesc>, IDeepCloneable<FUStB2DUnitSpawnDesc>
{
	private static readonly MessageParser<FUStB2DUnitSpawnDesc> _parser = new MessageParser<FUStB2DUnitSpawnDesc>(() => new FUStB2DUnitSpawnDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int stageId_;

	private int unitId_;

	private int groupId_;

	private int posX_;

	private int posY_;

	private int resType_;

	private int effectLength_;

	private int bornBuff_;

	private int effectParam1_;

	private int bossLot_;

	private int blockResistance_;

	private int rotateValue_;

	private int distanceBornPos_;

	public static MessageParser<FUStB2DUnitSpawnDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	public int UnitId
	{
		get
		{
			return unitId_;
		}
		set
		{
			unitId_ = value;
		}
	}

	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	public int PosX
	{
		get
		{
			return posX_;
		}
		set
		{
			posX_ = value;
		}
	}

	public int PosY
	{
		get
		{
			return posY_;
		}
		set
		{
			posY_ = value;
		}
	}

	public int ResType
	{
		get
		{
			return resType_;
		}
		set
		{
			resType_ = value;
		}
	}

	public int EffectLength
	{
		get
		{
			return effectLength_;
		}
		set
		{
			effectLength_ = value;
		}
	}

	public int BornBuff
	{
		get
		{
			return bornBuff_;
		}
		set
		{
			bornBuff_ = value;
		}
	}

	public int EffectParam1
	{
		get
		{
			return effectParam1_;
		}
		set
		{
			effectParam1_ = value;
		}
	}

	public int BossLot
	{
		get
		{
			return bossLot_;
		}
		set
		{
			bossLot_ = value;
		}
	}

	public int BlockResistance
	{
		get
		{
			return blockResistance_;
		}
		set
		{
			blockResistance_ = value;
		}
	}

	public int RotateValue
	{
		get
		{
			return rotateValue_;
		}
		set
		{
			rotateValue_ = value;
		}
	}

	public int DistanceBornPos
	{
		get
		{
			return distanceBornPos_;
		}
		set
		{
			distanceBornPos_ = value;
		}
	}

	public FUStB2DUnitSpawnDesc()
	{
	}

	public FUStB2DUnitSpawnDesc(FUStB2DUnitSpawnDesc other)
		: this()
	{
		id_ = other.id_;
		stageId_ = other.stageId_;
		unitId_ = other.unitId_;
		groupId_ = other.groupId_;
		posX_ = other.posX_;
		posY_ = other.posY_;
		resType_ = other.resType_;
		effectLength_ = other.effectLength_;
		bornBuff_ = other.bornBuff_;
		effectParam1_ = other.effectParam1_;
		bossLot_ = other.bossLot_;
		blockResistance_ = other.blockResistance_;
		rotateValue_ = other.rotateValue_;
		distanceBornPos_ = other.distanceBornPos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DUnitSpawnDesc Clone()
	{
		return new FUStB2DUnitSpawnDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DUnitSpawnDesc);
	}

	public bool Equals(FUStB2DUnitSpawnDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (UnitId != other.UnitId)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (PosX != other.PosX)
		{
			return false;
		}
		if (PosY != other.PosY)
		{
			return false;
		}
		if (ResType != other.ResType)
		{
			return false;
		}
		if (EffectLength != other.EffectLength)
		{
			return false;
		}
		if (BornBuff != other.BornBuff)
		{
			return false;
		}
		if (EffectParam1 != other.EffectParam1)
		{
			return false;
		}
		if (BossLot != other.BossLot)
		{
			return false;
		}
		if (BlockResistance != other.BlockResistance)
		{
			return false;
		}
		if (RotateValue != other.RotateValue)
		{
			return false;
		}
		if (DistanceBornPos != other.DistanceBornPos)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (UnitId != 0)
		{
			num ^= UnitId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (PosX != 0)
		{
			num ^= PosX.GetHashCode();
		}
		if (PosY != 0)
		{
			num ^= PosY.GetHashCode();
		}
		if (ResType != 0)
		{
			num ^= ResType.GetHashCode();
		}
		if (EffectLength != 0)
		{
			num ^= EffectLength.GetHashCode();
		}
		if (BornBuff != 0)
		{
			num ^= BornBuff.GetHashCode();
		}
		if (EffectParam1 != 0)
		{
			num ^= EffectParam1.GetHashCode();
		}
		if (BossLot != 0)
		{
			num ^= BossLot.GetHashCode();
		}
		if (BlockResistance != 0)
		{
			num ^= BlockResistance.GetHashCode();
		}
		if (RotateValue != 0)
		{
			num ^= RotateValue.GetHashCode();
		}
		if (DistanceBornPos != 0)
		{
			num ^= DistanceBornPos.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(StageId);
		}
		if (UnitId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UnitId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		if (PosX != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(PosX);
		}
		if (PosY != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PosY);
		}
		if (ResType != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ResType);
		}
		if (EffectLength != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(EffectLength);
		}
		if (BornBuff != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(BornBuff);
		}
		if (EffectParam1 != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(EffectParam1);
		}
		if (BossLot != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(BossLot);
		}
		if (BlockResistance != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(BlockResistance);
		}
		if (RotateValue != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(RotateValue);
		}
		if (DistanceBornPos != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(DistanceBornPos);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageId);
		}
		if (UnitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (PosX != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PosX);
		}
		if (PosY != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PosY);
		}
		if (ResType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResType);
		}
		if (EffectLength != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectLength);
		}
		if (BornBuff != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BornBuff);
		}
		if (EffectParam1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectParam1);
		}
		if (BossLot != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BossLot);
		}
		if (BlockResistance != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BlockResistance);
		}
		if (RotateValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RotateValue);
		}
		if (DistanceBornPos != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DistanceBornPos);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DUnitSpawnDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.UnitId != 0)
			{
				UnitId = other.UnitId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.PosX != 0)
			{
				PosX = other.PosX;
			}
			if (other.PosY != 0)
			{
				PosY = other.PosY;
			}
			if (other.ResType != 0)
			{
				ResType = other.ResType;
			}
			if (other.EffectLength != 0)
			{
				EffectLength = other.EffectLength;
			}
			if (other.BornBuff != 0)
			{
				BornBuff = other.BornBuff;
			}
			if (other.EffectParam1 != 0)
			{
				EffectParam1 = other.EffectParam1;
			}
			if (other.BossLot != 0)
			{
				BossLot = other.BossLot;
			}
			if (other.BlockResistance != 0)
			{
				BlockResistance = other.BlockResistance;
			}
			if (other.RotateValue != 0)
			{
				RotateValue = other.RotateValue;
			}
			if (other.DistanceBornPos != 0)
			{
				DistanceBornPos = other.DistanceBornPos;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				StageId = input.ReadInt32();
				break;
			case 24u:
				UnitId = input.ReadInt32();
				break;
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 40u:
				PosX = input.ReadInt32();
				break;
			case 48u:
				PosY = input.ReadInt32();
				break;
			case 56u:
				ResType = input.ReadInt32();
				break;
			case 64u:
				EffectLength = input.ReadInt32();
				break;
			case 72u:
				BornBuff = input.ReadInt32();
				break;
			case 80u:
				EffectParam1 = input.ReadInt32();
				break;
			case 88u:
				BossLot = input.ReadInt32();
				break;
			case 96u:
				BlockResistance = input.ReadInt32();
				break;
			case 104u:
				RotateValue = input.ReadInt32();
				break;
			case 112u:
				DistanceBornPos = input.ReadInt32();
				break;
			}
		}
	}
}
