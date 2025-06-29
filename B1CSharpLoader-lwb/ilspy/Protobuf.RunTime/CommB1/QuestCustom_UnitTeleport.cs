using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_UnitTeleport : IMessage<QuestCustom_UnitTeleport>, IMessage, IEquatable<QuestCustom_UnitTeleport>, IDeepCloneable<QuestCustom_UnitTeleport>
{
	private static readonly MessageParser<QuestCustom_UnitTeleport> _parser = new MessageParser<QuestCustom_UnitTeleport>(() => new QuestCustom_UnitTeleport());

	private UnknownFieldSet _unknownFields;

	private string notifyActorGuid_ = "";

	private int skillBeforeTeleport_;

	private int skillAfterTeleport_;

	private int locationType_;

	private float rotationType_;

	public static MessageParser<QuestCustom_UnitTeleport> Parser => _parser;

	public string NotifyActorGuid
	{
		get
		{
			return notifyActorGuid_;
		}
		set
		{
			notifyActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SkillBeforeTeleport
	{
		get
		{
			return skillBeforeTeleport_;
		}
		set
		{
			skillBeforeTeleport_ = value;
		}
	}

	public int SkillAfterTeleport
	{
		get
		{
			return skillAfterTeleport_;
		}
		set
		{
			skillAfterTeleport_ = value;
		}
	}

	public int LocationType
	{
		get
		{
			return locationType_;
		}
		set
		{
			locationType_ = value;
		}
	}

	public float RotationType
	{
		get
		{
			return rotationType_;
		}
		set
		{
			rotationType_ = value;
		}
	}

	public QuestCustom_UnitTeleport()
	{
	}

	public QuestCustom_UnitTeleport(QuestCustom_UnitTeleport other)
		: this()
	{
		notifyActorGuid_ = other.notifyActorGuid_;
		skillBeforeTeleport_ = other.skillBeforeTeleport_;
		skillAfterTeleport_ = other.skillAfterTeleport_;
		locationType_ = other.locationType_;
		rotationType_ = other.rotationType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_UnitTeleport Clone()
	{
		return new QuestCustom_UnitTeleport(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_UnitTeleport);
	}

	public bool Equals(QuestCustom_UnitTeleport other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NotifyActorGuid != other.NotifyActorGuid)
		{
			return false;
		}
		if (SkillBeforeTeleport != other.SkillBeforeTeleport)
		{
			return false;
		}
		if (SkillAfterTeleport != other.SkillAfterTeleport)
		{
			return false;
		}
		if (LocationType != other.LocationType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RotationType, other.RotationType))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (NotifyActorGuid.Length != 0)
		{
			num ^= NotifyActorGuid.GetHashCode();
		}
		if (SkillBeforeTeleport != 0)
		{
			num ^= SkillBeforeTeleport.GetHashCode();
		}
		if (SkillAfterTeleport != 0)
		{
			num ^= SkillAfterTeleport.GetHashCode();
		}
		if (LocationType != 0)
		{
			num ^= LocationType.GetHashCode();
		}
		if (RotationType != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RotationType);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (NotifyActorGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(NotifyActorGuid);
		}
		if (SkillBeforeTeleport != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SkillBeforeTeleport);
		}
		if (SkillAfterTeleport != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SkillAfterTeleport);
		}
		if (LocationType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LocationType);
		}
		if (RotationType != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(RotationType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (NotifyActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NotifyActorGuid);
		}
		if (SkillBeforeTeleport != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillBeforeTeleport);
		}
		if (SkillAfterTeleport != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillAfterTeleport);
		}
		if (LocationType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocationType);
		}
		if (RotationType != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_UnitTeleport other)
	{
		if (other != null)
		{
			if (other.NotifyActorGuid.Length != 0)
			{
				NotifyActorGuid = other.NotifyActorGuid;
			}
			if (other.SkillBeforeTeleport != 0)
			{
				SkillBeforeTeleport = other.SkillBeforeTeleport;
			}
			if (other.SkillAfterTeleport != 0)
			{
				SkillAfterTeleport = other.SkillAfterTeleport;
			}
			if (other.LocationType != 0)
			{
				LocationType = other.LocationType;
			}
			if (other.RotationType != 0f)
			{
				RotationType = other.RotationType;
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
			case 10u:
				NotifyActorGuid = input.ReadString();
				break;
			case 16u:
				SkillBeforeTeleport = input.ReadInt32();
				break;
			case 24u:
				SkillAfterTeleport = input.ReadInt32();
				break;
			case 32u:
				LocationType = input.ReadInt32();
				break;
			case 45u:
				RotationType = input.ReadFloat();
				break;
			}
		}
	}
}
