using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSpawnBulletsData : IMessage<FUStSpawnBulletsData>, IMessage, IEquatable<FUStSpawnBulletsData>, IDeepCloneable<FUStSpawnBulletsData>
{
	private static readonly MessageParser<FUStSpawnBulletsData> _parser = new MessageParser<FUStSpawnBulletsData>(() => new FUStSpawnBulletsData());

	private UnknownFieldSet _unknownFields;

	private int notifyStartTime_;

	private int notifyDurationTime_;

	private static readonly FieldCodec<int> _repeated_buffIDList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> buffIDList_ = new RepeatedField<int>();

	private int bulletID_;

	private int bulletWave_;

	private int bulletNumInOneWave_;

	private FUStProjectileBase spawnBase_;

	private FUStProjectilePosOffset spawnPosOffsetInfo_;

	private FUStProjectileBase targetBase_;

	private FUStProjectilePosOffset targetPosOffsetInfo_;

	private FUStProjectileBornDir bornDirBaseInfo_;

	private FUStProjectileBornDirOffset bornDirOffset_;

	private FUStSpawnBulletSpeed bulletFlySpd_;

	private FUStSpawnBulletSpeed bulletRotSpd_;

	private bool bEnableMultiTargetMode_;

	private FUStProjectileMulTargetRule mutilTargetRule_;

	public static MessageParser<FUStSpawnBulletsData> Parser => _parser;

	public int NotifyStartTime
	{
		get
		{
			return notifyStartTime_;
		}
		set
		{
			notifyStartTime_ = value;
		}
	}

	public int NotifyDurationTime
	{
		get
		{
			return notifyDurationTime_;
		}
		set
		{
			notifyDurationTime_ = value;
		}
	}

	public RepeatedField<int> BuffIDList => buffIDList_;

	public int BulletID
	{
		get
		{
			return bulletID_;
		}
		set
		{
			bulletID_ = value;
		}
	}

	public int BulletWave
	{
		get
		{
			return bulletWave_;
		}
		set
		{
			bulletWave_ = value;
		}
	}

	public int BulletNumInOneWave
	{
		get
		{
			return bulletNumInOneWave_;
		}
		set
		{
			bulletNumInOneWave_ = value;
		}
	}

	public FUStProjectileBase SpawnBase
	{
		get
		{
			return spawnBase_;
		}
		set
		{
			spawnBase_ = value;
		}
	}

	public FUStProjectilePosOffset SpawnPosOffsetInfo
	{
		get
		{
			return spawnPosOffsetInfo_;
		}
		set
		{
			spawnPosOffsetInfo_ = value;
		}
	}

	public FUStProjectileBase TargetBase
	{
		get
		{
			return targetBase_;
		}
		set
		{
			targetBase_ = value;
		}
	}

	public FUStProjectilePosOffset TargetPosOffsetInfo
	{
		get
		{
			return targetPosOffsetInfo_;
		}
		set
		{
			targetPosOffsetInfo_ = value;
		}
	}

	public FUStProjectileBornDir BornDirBaseInfo
	{
		get
		{
			return bornDirBaseInfo_;
		}
		set
		{
			bornDirBaseInfo_ = value;
		}
	}

	public FUStProjectileBornDirOffset BornDirOffset
	{
		get
		{
			return bornDirOffset_;
		}
		set
		{
			bornDirOffset_ = value;
		}
	}

	public FUStSpawnBulletSpeed BulletFlySpd
	{
		get
		{
			return bulletFlySpd_;
		}
		set
		{
			bulletFlySpd_ = value;
		}
	}

	public FUStSpawnBulletSpeed BulletRotSpd
	{
		get
		{
			return bulletRotSpd_;
		}
		set
		{
			bulletRotSpd_ = value;
		}
	}

	public bool BEnableMultiTargetMode
	{
		get
		{
			return bEnableMultiTargetMode_;
		}
		set
		{
			bEnableMultiTargetMode_ = value;
		}
	}

	public FUStProjectileMulTargetRule MutilTargetRule
	{
		get
		{
			return mutilTargetRule_;
		}
		set
		{
			mutilTargetRule_ = value;
		}
	}

	public FUStSpawnBulletsData()
	{
	}

	public FUStSpawnBulletsData(FUStSpawnBulletsData other)
		: this()
	{
		notifyStartTime_ = other.notifyStartTime_;
		notifyDurationTime_ = other.notifyDurationTime_;
		buffIDList_ = other.buffIDList_.Clone();
		bulletID_ = other.bulletID_;
		bulletWave_ = other.bulletWave_;
		bulletNumInOneWave_ = other.bulletNumInOneWave_;
		spawnBase_ = ((other.spawnBase_ != null) ? other.spawnBase_.Clone() : null);
		spawnPosOffsetInfo_ = ((other.spawnPosOffsetInfo_ != null) ? other.spawnPosOffsetInfo_.Clone() : null);
		targetBase_ = ((other.targetBase_ != null) ? other.targetBase_.Clone() : null);
		targetPosOffsetInfo_ = ((other.targetPosOffsetInfo_ != null) ? other.targetPosOffsetInfo_.Clone() : null);
		bornDirBaseInfo_ = ((other.bornDirBaseInfo_ != null) ? other.bornDirBaseInfo_.Clone() : null);
		bornDirOffset_ = ((other.bornDirOffset_ != null) ? other.bornDirOffset_.Clone() : null);
		bulletFlySpd_ = ((other.bulletFlySpd_ != null) ? other.bulletFlySpd_.Clone() : null);
		bulletRotSpd_ = ((other.bulletRotSpd_ != null) ? other.bulletRotSpd_.Clone() : null);
		bEnableMultiTargetMode_ = other.bEnableMultiTargetMode_;
		mutilTargetRule_ = ((other.mutilTargetRule_ != null) ? other.mutilTargetRule_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSpawnBulletsData Clone()
	{
		return new FUStSpawnBulletsData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSpawnBulletsData);
	}

	public bool Equals(FUStSpawnBulletsData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NotifyStartTime != other.NotifyStartTime)
		{
			return false;
		}
		if (NotifyDurationTime != other.NotifyDurationTime)
		{
			return false;
		}
		if (!buffIDList_.Equals(other.buffIDList_))
		{
			return false;
		}
		if (BulletID != other.BulletID)
		{
			return false;
		}
		if (BulletWave != other.BulletWave)
		{
			return false;
		}
		if (BulletNumInOneWave != other.BulletNumInOneWave)
		{
			return false;
		}
		if (!object.Equals(SpawnBase, other.SpawnBase))
		{
			return false;
		}
		if (!object.Equals(SpawnPosOffsetInfo, other.SpawnPosOffsetInfo))
		{
			return false;
		}
		if (!object.Equals(TargetBase, other.TargetBase))
		{
			return false;
		}
		if (!object.Equals(TargetPosOffsetInfo, other.TargetPosOffsetInfo))
		{
			return false;
		}
		if (!object.Equals(BornDirBaseInfo, other.BornDirBaseInfo))
		{
			return false;
		}
		if (!object.Equals(BornDirOffset, other.BornDirOffset))
		{
			return false;
		}
		if (!object.Equals(BulletFlySpd, other.BulletFlySpd))
		{
			return false;
		}
		if (!object.Equals(BulletRotSpd, other.BulletRotSpd))
		{
			return false;
		}
		if (BEnableMultiTargetMode != other.BEnableMultiTargetMode)
		{
			return false;
		}
		if (!object.Equals(MutilTargetRule, other.MutilTargetRule))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (NotifyStartTime != 0)
		{
			num ^= NotifyStartTime.GetHashCode();
		}
		if (NotifyDurationTime != 0)
		{
			num ^= NotifyDurationTime.GetHashCode();
		}
		num ^= buffIDList_.GetHashCode();
		if (BulletID != 0)
		{
			num ^= BulletID.GetHashCode();
		}
		if (BulletWave != 0)
		{
			num ^= BulletWave.GetHashCode();
		}
		if (BulletNumInOneWave != 0)
		{
			num ^= BulletNumInOneWave.GetHashCode();
		}
		if (spawnBase_ != null)
		{
			num ^= SpawnBase.GetHashCode();
		}
		if (spawnPosOffsetInfo_ != null)
		{
			num ^= SpawnPosOffsetInfo.GetHashCode();
		}
		if (targetBase_ != null)
		{
			num ^= TargetBase.GetHashCode();
		}
		if (targetPosOffsetInfo_ != null)
		{
			num ^= TargetPosOffsetInfo.GetHashCode();
		}
		if (bornDirBaseInfo_ != null)
		{
			num ^= BornDirBaseInfo.GetHashCode();
		}
		if (bornDirOffset_ != null)
		{
			num ^= BornDirOffset.GetHashCode();
		}
		if (bulletFlySpd_ != null)
		{
			num ^= BulletFlySpd.GetHashCode();
		}
		if (bulletRotSpd_ != null)
		{
			num ^= BulletRotSpd.GetHashCode();
		}
		if (BEnableMultiTargetMode)
		{
			num ^= BEnableMultiTargetMode.GetHashCode();
		}
		if (mutilTargetRule_ != null)
		{
			num ^= MutilTargetRule.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (NotifyStartTime != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(NotifyStartTime);
		}
		if (NotifyDurationTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(NotifyDurationTime);
		}
		buffIDList_.WriteTo(output, _repeated_buffIDList_codec);
		if (BulletID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BulletID);
		}
		if (BulletWave != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BulletWave);
		}
		if (BulletNumInOneWave != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BulletNumInOneWave);
		}
		if (spawnBase_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(SpawnBase);
		}
		if (spawnPosOffsetInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(SpawnPosOffsetInfo);
		}
		if (targetBase_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(TargetBase);
		}
		if (targetPosOffsetInfo_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(TargetPosOffsetInfo);
		}
		if (bornDirBaseInfo_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(BornDirBaseInfo);
		}
		if (bornDirOffset_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(BornDirOffset);
		}
		if (bulletFlySpd_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(BulletFlySpd);
		}
		if (bulletRotSpd_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BulletRotSpd);
		}
		if (BEnableMultiTargetMode)
		{
			output.WriteRawTag(120);
			output.WriteBool(BEnableMultiTargetMode);
		}
		if (mutilTargetRule_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(MutilTargetRule);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (NotifyStartTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NotifyStartTime);
		}
		if (NotifyDurationTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NotifyDurationTime);
		}
		num += buffIDList_.CalculateSize(_repeated_buffIDList_codec);
		if (BulletID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BulletID);
		}
		if (BulletWave != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BulletWave);
		}
		if (BulletNumInOneWave != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BulletNumInOneWave);
		}
		if (spawnBase_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SpawnBase);
		}
		if (spawnPosOffsetInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SpawnPosOffsetInfo);
		}
		if (targetBase_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetBase);
		}
		if (targetPosOffsetInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TargetPosOffsetInfo);
		}
		if (bornDirBaseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BornDirBaseInfo);
		}
		if (bornDirOffset_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BornDirOffset);
		}
		if (bulletFlySpd_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BulletFlySpd);
		}
		if (bulletRotSpd_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BulletRotSpd);
		}
		if (BEnableMultiTargetMode)
		{
			num += 2;
		}
		if (mutilTargetRule_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MutilTargetRule);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSpawnBulletsData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NotifyStartTime != 0)
		{
			NotifyStartTime = other.NotifyStartTime;
		}
		if (other.NotifyDurationTime != 0)
		{
			NotifyDurationTime = other.NotifyDurationTime;
		}
		buffIDList_.Add(other.buffIDList_);
		if (other.BulletID != 0)
		{
			BulletID = other.BulletID;
		}
		if (other.BulletWave != 0)
		{
			BulletWave = other.BulletWave;
		}
		if (other.BulletNumInOneWave != 0)
		{
			BulletNumInOneWave = other.BulletNumInOneWave;
		}
		if (other.spawnBase_ != null)
		{
			if (spawnBase_ == null)
			{
				SpawnBase = new FUStProjectileBase();
			}
			SpawnBase.MergeFrom(other.SpawnBase);
		}
		if (other.spawnPosOffsetInfo_ != null)
		{
			if (spawnPosOffsetInfo_ == null)
			{
				SpawnPosOffsetInfo = new FUStProjectilePosOffset();
			}
			SpawnPosOffsetInfo.MergeFrom(other.SpawnPosOffsetInfo);
		}
		if (other.targetBase_ != null)
		{
			if (targetBase_ == null)
			{
				TargetBase = new FUStProjectileBase();
			}
			TargetBase.MergeFrom(other.TargetBase);
		}
		if (other.targetPosOffsetInfo_ != null)
		{
			if (targetPosOffsetInfo_ == null)
			{
				TargetPosOffsetInfo = new FUStProjectilePosOffset();
			}
			TargetPosOffsetInfo.MergeFrom(other.TargetPosOffsetInfo);
		}
		if (other.bornDirBaseInfo_ != null)
		{
			if (bornDirBaseInfo_ == null)
			{
				BornDirBaseInfo = new FUStProjectileBornDir();
			}
			BornDirBaseInfo.MergeFrom(other.BornDirBaseInfo);
		}
		if (other.bornDirOffset_ != null)
		{
			if (bornDirOffset_ == null)
			{
				BornDirOffset = new FUStProjectileBornDirOffset();
			}
			BornDirOffset.MergeFrom(other.BornDirOffset);
		}
		if (other.bulletFlySpd_ != null)
		{
			if (bulletFlySpd_ == null)
			{
				BulletFlySpd = new FUStSpawnBulletSpeed();
			}
			BulletFlySpd.MergeFrom(other.BulletFlySpd);
		}
		if (other.bulletRotSpd_ != null)
		{
			if (bulletRotSpd_ == null)
			{
				BulletRotSpd = new FUStSpawnBulletSpeed();
			}
			BulletRotSpd.MergeFrom(other.BulletRotSpd);
		}
		if (other.BEnableMultiTargetMode)
		{
			BEnableMultiTargetMode = other.BEnableMultiTargetMode;
		}
		if (other.mutilTargetRule_ != null)
		{
			if (mutilTargetRule_ == null)
			{
				MutilTargetRule = new FUStProjectileMulTargetRule();
			}
			MutilTargetRule.MergeFrom(other.MutilTargetRule);
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
				NotifyStartTime = input.ReadInt32();
				break;
			case 16u:
				NotifyDurationTime = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				buffIDList_.AddEntriesFrom(input, _repeated_buffIDList_codec);
				break;
			case 32u:
				BulletID = input.ReadInt32();
				break;
			case 40u:
				BulletWave = input.ReadInt32();
				break;
			case 48u:
				BulletNumInOneWave = input.ReadInt32();
				break;
			case 58u:
				if (spawnBase_ == null)
				{
					SpawnBase = new FUStProjectileBase();
				}
				input.ReadMessage(SpawnBase);
				break;
			case 66u:
				if (spawnPosOffsetInfo_ == null)
				{
					SpawnPosOffsetInfo = new FUStProjectilePosOffset();
				}
				input.ReadMessage(SpawnPosOffsetInfo);
				break;
			case 74u:
				if (targetBase_ == null)
				{
					TargetBase = new FUStProjectileBase();
				}
				input.ReadMessage(TargetBase);
				break;
			case 82u:
				if (targetPosOffsetInfo_ == null)
				{
					TargetPosOffsetInfo = new FUStProjectilePosOffset();
				}
				input.ReadMessage(TargetPosOffsetInfo);
				break;
			case 90u:
				if (bornDirBaseInfo_ == null)
				{
					BornDirBaseInfo = new FUStProjectileBornDir();
				}
				input.ReadMessage(BornDirBaseInfo);
				break;
			case 98u:
				if (bornDirOffset_ == null)
				{
					BornDirOffset = new FUStProjectileBornDirOffset();
				}
				input.ReadMessage(BornDirOffset);
				break;
			case 106u:
				if (bulletFlySpd_ == null)
				{
					BulletFlySpd = new FUStSpawnBulletSpeed();
				}
				input.ReadMessage(BulletFlySpd);
				break;
			case 114u:
				if (bulletRotSpd_ == null)
				{
					BulletRotSpd = new FUStSpawnBulletSpeed();
				}
				input.ReadMessage(BulletRotSpd);
				break;
			case 120u:
				BEnableMultiTargetMode = input.ReadBool();
				break;
			case 130u:
				if (mutilTargetRule_ == null)
				{
					MutilTargetRule = new FUStProjectileMulTargetRule();
				}
				input.ReadMessage(MutilTargetRule);
				break;
			}
		}
	}
}
