using System;
using Google.Protobuf;

namespace ResB1;

public sealed class BossUnlockConfig : IMessage<BossUnlockConfig>, IMessage, IEquatable<BossUnlockConfig>, IDeepCloneable<BossUnlockConfig>
{
	private static readonly MessageParser<BossUnlockConfig> _parser = new MessageParser<BossUnlockConfig>(() => new BossUnlockConfig());

	private UnknownFieldSet _unknownFields;

	private EBossUnlockCondition unlockCondition_;

	private int unlockId_;

	public static MessageParser<BossUnlockConfig> Parser => _parser;

	public EBossUnlockCondition UnlockCondition
	{
		get
		{
			return unlockCondition_;
		}
		set
		{
			unlockCondition_ = value;
		}
	}

	public int UnlockId
	{
		get
		{
			return unlockId_;
		}
		set
		{
			unlockId_ = value;
		}
	}

	public BossUnlockConfig()
	{
	}

	public BossUnlockConfig(BossUnlockConfig other)
		: this()
	{
		unlockCondition_ = other.unlockCondition_;
		unlockId_ = other.unlockId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossUnlockConfig Clone()
	{
		return new BossUnlockConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossUnlockConfig);
	}

	public bool Equals(BossUnlockConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnlockCondition != other.UnlockCondition)
		{
			return false;
		}
		if (UnlockId != other.UnlockId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnlockCondition != EBossUnlockCondition.None)
		{
			num ^= UnlockCondition.GetHashCode();
		}
		if (UnlockId != 0)
		{
			num ^= UnlockId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnlockCondition != EBossUnlockCondition.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)UnlockCondition);
		}
		if (UnlockId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UnlockId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnlockCondition != EBossUnlockCondition.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnlockCondition);
		}
		if (UnlockId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnlockId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossUnlockConfig other)
	{
		if (other != null)
		{
			if (other.UnlockCondition != EBossUnlockCondition.None)
			{
				UnlockCondition = other.UnlockCondition;
			}
			if (other.UnlockId != 0)
			{
				UnlockId = other.UnlockId;
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
				UnlockCondition = (EBossUnlockCondition)input.ReadEnum();
				break;
			case 16u:
				UnlockId = input.ReadInt32();
				break;
			}
		}
	}
}
