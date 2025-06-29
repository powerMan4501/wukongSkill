using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_RequestLevelStateInfo : IMessage<CalliopeCustom_RequestLevelStateInfo>, IMessage, IEquatable<CalliopeCustom_RequestLevelStateInfo>, IDeepCloneable<CalliopeCustom_RequestLevelStateInfo>
{
	private static readonly MessageParser<CalliopeCustom_RequestLevelStateInfo> _parser = new MessageParser<CalliopeCustom_RequestLevelStateInfo>(() => new CalliopeCustom_RequestLevelStateInfo());

	private UnknownFieldSet _unknownFields;

	private int levelId_;

	private int configId_;

	public static MessageParser<CalliopeCustom_RequestLevelStateInfo> Parser => _parser;

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public int ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	public CalliopeCustom_RequestLevelStateInfo()
	{
	}

	public CalliopeCustom_RequestLevelStateInfo(CalliopeCustom_RequestLevelStateInfo other)
		: this()
	{
		levelId_ = other.levelId_;
		configId_ = other.configId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_RequestLevelStateInfo Clone()
	{
		return new CalliopeCustom_RequestLevelStateInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_RequestLevelStateInfo);
	}

	public bool Equals(CalliopeCustom_RequestLevelStateInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LevelId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LevelId);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ConfigId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConfigId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_RequestLevelStateInfo other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.ConfigId != 0)
			{
				ConfigId = other.ConfigId;
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
				LevelId = input.ReadInt32();
				break;
			case 16u:
				ConfigId = input.ReadInt32();
				break;
			}
		}
	}
}
