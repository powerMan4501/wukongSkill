using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStUnitDeadDesc : IMessage<FUStUnitDeadDesc>, IMessage, IEquatable<FUStUnitDeadDesc>, IDeepCloneable<FUStUnitDeadDesc>
{
	private static readonly MessageParser<FUStUnitDeadDesc> _parser = new MessageParser<FUStUnitDeadDesc>(() => new FUStUnitDeadDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int unitResID_;

	private float delayClearArmorTime_;

	private float delayDestroyActorTime_;

	private float deadSlopeThreshold_;

	private float deadDropRecoverHP_;

	private float deadDropRecoverMP_;

	private static readonly FieldCodec<int> _repeated_deadTriggerEffectID_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> deadTriggerEffectID_ = new RepeatedField<int>();

	private string deadPAPath_ = "";

	private string deadUseFrozenFracture_ = "";

	private string deathDispConfigPath_ = "";

	private string abnormalStateDeathDispDBCDAPath_ = "";

	private string throwUpCurve_ = "";

	private string guard_ = "";

	public static MessageParser<FUStUnitDeadDesc> Parser => _parser;

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

	public int UnitResID
	{
		get
		{
			return unitResID_;
		}
		set
		{
			unitResID_ = value;
		}
	}

	public float DelayClearArmorTime
	{
		get
		{
			return delayClearArmorTime_;
		}
		set
		{
			delayClearArmorTime_ = value;
		}
	}

	public float DelayDestroyActorTime
	{
		get
		{
			return delayDestroyActorTime_;
		}
		set
		{
			delayDestroyActorTime_ = value;
		}
	}

	public float DeadSlopeThreshold
	{
		get
		{
			return deadSlopeThreshold_;
		}
		set
		{
			deadSlopeThreshold_ = value;
		}
	}

	public float DeadDropRecoverHP
	{
		get
		{
			return deadDropRecoverHP_;
		}
		set
		{
			deadDropRecoverHP_ = value;
		}
	}

	public float DeadDropRecoverMP
	{
		get
		{
			return deadDropRecoverMP_;
		}
		set
		{
			deadDropRecoverMP_ = value;
		}
	}

	public RepeatedField<int> DeadTriggerEffectID => deadTriggerEffectID_;

	public string DeadPAPath
	{
		get
		{
			return deadPAPath_;
		}
		set
		{
			deadPAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeadUseFrozenFracture
	{
		get
		{
			return deadUseFrozenFracture_;
		}
		set
		{
			deadUseFrozenFracture_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeathDispConfigPath
	{
		get
		{
			return deathDispConfigPath_;
		}
		set
		{
			deathDispConfigPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AbnormalStateDeathDispDBCDAPath
	{
		get
		{
			return abnormalStateDeathDispDBCDAPath_;
		}
		set
		{
			abnormalStateDeathDispDBCDAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ThrowUpCurve
	{
		get
		{
			return throwUpCurve_;
		}
		set
		{
			throwUpCurve_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStUnitDeadDesc()
	{
	}

	public FUStUnitDeadDesc(FUStUnitDeadDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitResID_ = other.unitResID_;
		delayClearArmorTime_ = other.delayClearArmorTime_;
		delayDestroyActorTime_ = other.delayDestroyActorTime_;
		deadSlopeThreshold_ = other.deadSlopeThreshold_;
		deadDropRecoverHP_ = other.deadDropRecoverHP_;
		deadDropRecoverMP_ = other.deadDropRecoverMP_;
		deadTriggerEffectID_ = other.deadTriggerEffectID_.Clone();
		deadPAPath_ = other.deadPAPath_;
		deadUseFrozenFracture_ = other.deadUseFrozenFracture_;
		deathDispConfigPath_ = other.deathDispConfigPath_;
		abnormalStateDeathDispDBCDAPath_ = other.abnormalStateDeathDispDBCDAPath_;
		throwUpCurve_ = other.throwUpCurve_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitDeadDesc Clone()
	{
		return new FUStUnitDeadDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitDeadDesc);
	}

	public bool Equals(FUStUnitDeadDesc other)
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
		if (UnitResID != other.UnitResID)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DelayClearArmorTime, other.DelayClearArmorTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DelayDestroyActorTime, other.DelayDestroyActorTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DeadSlopeThreshold, other.DeadSlopeThreshold))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DeadDropRecoverHP, other.DeadDropRecoverHP))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DeadDropRecoverMP, other.DeadDropRecoverMP))
		{
			return false;
		}
		if (!deadTriggerEffectID_.Equals(other.deadTriggerEffectID_))
		{
			return false;
		}
		if (DeadPAPath != other.DeadPAPath)
		{
			return false;
		}
		if (DeadUseFrozenFracture != other.DeadUseFrozenFracture)
		{
			return false;
		}
		if (DeathDispConfigPath != other.DeathDispConfigPath)
		{
			return false;
		}
		if (AbnormalStateDeathDispDBCDAPath != other.AbnormalStateDeathDispDBCDAPath)
		{
			return false;
		}
		if (ThrowUpCurve != other.ThrowUpCurve)
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (UnitResID != 0)
		{
			num ^= UnitResID.GetHashCode();
		}
		if (DelayClearArmorTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DelayClearArmorTime);
		}
		if (DelayDestroyActorTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DelayDestroyActorTime);
		}
		if (DeadSlopeThreshold != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DeadSlopeThreshold);
		}
		if (DeadDropRecoverHP != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DeadDropRecoverHP);
		}
		if (DeadDropRecoverMP != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DeadDropRecoverMP);
		}
		num ^= deadTriggerEffectID_.GetHashCode();
		if (DeadPAPath.Length != 0)
		{
			num ^= DeadPAPath.GetHashCode();
		}
		if (DeadUseFrozenFracture.Length != 0)
		{
			num ^= DeadUseFrozenFracture.GetHashCode();
		}
		if (DeathDispConfigPath.Length != 0)
		{
			num ^= DeathDispConfigPath.GetHashCode();
		}
		if (AbnormalStateDeathDispDBCDAPath.Length != 0)
		{
			num ^= AbnormalStateDeathDispDBCDAPath.GetHashCode();
		}
		if (ThrowUpCurve.Length != 0)
		{
			num ^= ThrowUpCurve.GetHashCode();
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
		}
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
		if (UnitResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UnitResID);
		}
		if (DelayClearArmorTime != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(DelayClearArmorTime);
		}
		if (DelayDestroyActorTime != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(DelayDestroyActorTime);
		}
		if (DeadSlopeThreshold != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(DeadSlopeThreshold);
		}
		if (DeadDropRecoverHP != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(DeadDropRecoverHP);
		}
		if (DeadDropRecoverMP != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(DeadDropRecoverMP);
		}
		deadTriggerEffectID_.WriteTo(output, _repeated_deadTriggerEffectID_codec);
		if (DeadPAPath.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(DeadPAPath);
		}
		if (DeadUseFrozenFracture.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(DeadUseFrozenFracture);
		}
		if (DeathDispConfigPath.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(DeathDispConfigPath);
		}
		if (AbnormalStateDeathDispDBCDAPath.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(AbnormalStateDeathDispDBCDAPath);
		}
		if (ThrowUpCurve.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(ThrowUpCurve);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(Guard);
		}
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
		if (UnitResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitResID);
		}
		if (DelayClearArmorTime != 0f)
		{
			num += 5;
		}
		if (DelayDestroyActorTime != 0f)
		{
			num += 5;
		}
		if (DeadSlopeThreshold != 0f)
		{
			num += 5;
		}
		if (DeadDropRecoverHP != 0f)
		{
			num += 5;
		}
		if (DeadDropRecoverMP != 0f)
		{
			num += 5;
		}
		num += deadTriggerEffectID_.CalculateSize(_repeated_deadTriggerEffectID_codec);
		if (DeadPAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadPAPath);
		}
		if (DeadUseFrozenFracture.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeadUseFrozenFracture);
		}
		if (DeathDispConfigPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeathDispConfigPath);
		}
		if (AbnormalStateDeathDispDBCDAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AbnormalStateDeathDispDBCDAPath);
		}
		if (ThrowUpCurve.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ThrowUpCurve);
		}
		if (Guard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitDeadDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitResID != 0)
			{
				UnitResID = other.UnitResID;
			}
			if (other.DelayClearArmorTime != 0f)
			{
				DelayClearArmorTime = other.DelayClearArmorTime;
			}
			if (other.DelayDestroyActorTime != 0f)
			{
				DelayDestroyActorTime = other.DelayDestroyActorTime;
			}
			if (other.DeadSlopeThreshold != 0f)
			{
				DeadSlopeThreshold = other.DeadSlopeThreshold;
			}
			if (other.DeadDropRecoverHP != 0f)
			{
				DeadDropRecoverHP = other.DeadDropRecoverHP;
			}
			if (other.DeadDropRecoverMP != 0f)
			{
				DeadDropRecoverMP = other.DeadDropRecoverMP;
			}
			deadTriggerEffectID_.Add(other.deadTriggerEffectID_);
			if (other.DeadPAPath.Length != 0)
			{
				DeadPAPath = other.DeadPAPath;
			}
			if (other.DeadUseFrozenFracture.Length != 0)
			{
				DeadUseFrozenFracture = other.DeadUseFrozenFracture;
			}
			if (other.DeathDispConfigPath.Length != 0)
			{
				DeathDispConfigPath = other.DeathDispConfigPath;
			}
			if (other.AbnormalStateDeathDispDBCDAPath.Length != 0)
			{
				AbnormalStateDeathDispDBCDAPath = other.AbnormalStateDeathDispDBCDAPath;
			}
			if (other.ThrowUpCurve.Length != 0)
			{
				ThrowUpCurve = other.ThrowUpCurve;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				UnitResID = input.ReadInt32();
				break;
			case 29u:
				DelayClearArmorTime = input.ReadFloat();
				break;
			case 37u:
				DelayDestroyActorTime = input.ReadFloat();
				break;
			case 45u:
				DeadSlopeThreshold = input.ReadFloat();
				break;
			case 53u:
				DeadDropRecoverHP = input.ReadFloat();
				break;
			case 61u:
				DeadDropRecoverMP = input.ReadFloat();
				break;
			case 64u:
			case 66u:
				deadTriggerEffectID_.AddEntriesFrom(input, _repeated_deadTriggerEffectID_codec);
				break;
			case 74u:
				DeadPAPath = input.ReadString();
				break;
			case 82u:
				DeadUseFrozenFracture = input.ReadString();
				break;
			case 90u:
				DeathDispConfigPath = input.ReadString();
				break;
			case 98u:
				AbnormalStateDeathDispDBCDAPath = input.ReadString();
				break;
			case 106u:
				ThrowUpCurve = input.ReadString();
				break;
			case 114u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
