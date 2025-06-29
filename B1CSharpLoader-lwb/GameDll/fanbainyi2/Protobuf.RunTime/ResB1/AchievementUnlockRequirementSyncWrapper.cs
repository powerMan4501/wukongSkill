using System;
using Google.Protobuf;

namespace ResB1;

public sealed class AchievementUnlockRequirementSyncWrapper : IMessage<AchievementUnlockRequirementSyncWrapper>, IMessage, IEquatable<AchievementUnlockRequirementSyncWrapper>, IDeepCloneable<AchievementUnlockRequirementSyncWrapper>
{
	private static readonly MessageParser<AchievementUnlockRequirementSyncWrapper> _parser = new MessageParser<AchievementUnlockRequirementSyncWrapper>(() => new AchievementUnlockRequirementSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private AchievementUnlockRequirement value_;

	public static MessageParser<AchievementUnlockRequirementSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public AchievementUnlockRequirement Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public AchievementUnlockRequirementSyncWrapper()
	{
	}

	public AchievementUnlockRequirementSyncWrapper(AchievementUnlockRequirementSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementUnlockRequirementSyncWrapper Clone()
	{
		return new AchievementUnlockRequirementSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementUnlockRequirementSyncWrapper);
	}

	public bool Equals(AchievementUnlockRequirementSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (Value != other.Value)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (Value != AchievementUnlockRequirement.None)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (Value != AchievementUnlockRequirement.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (Value != AchievementUnlockRequirement.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementUnlockRequirementSyncWrapper other)
	{
		if (other != null)
		{
			if (other.SyncFlag != 0)
			{
				SyncFlag = other.SyncFlag;
			}
			if (other.SyncIdx != 0)
			{
				SyncIdx = other.SyncIdx;
			}
			if (other.Value != AchievementUnlockRequirement.None)
			{
				Value = other.Value;
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 24u:
				Value = (AchievementUnlockRequirement)input.ReadEnum();
				break;
			}
		}
	}
}
