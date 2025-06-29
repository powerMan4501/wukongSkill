using System;
using Google.Protobuf;

namespace ResB1;

public sealed class BossSuccessiveInfo : IMessage<BossSuccessiveInfo>, IMessage, IEquatable<BossSuccessiveInfo>, IDeepCloneable<BossSuccessiveInfo>
{
	private static readonly MessageParser<BossSuccessiveInfo> _parser = new MessageParser<BossSuccessiveInfo>(() => new BossSuccessiveInfo());

	private UnknownFieldSet _unknownFields;

	private int configId_;

	private int buffId_;

	public static MessageParser<BossSuccessiveInfo> Parser => _parser;

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

	public int BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	public BossSuccessiveInfo()
	{
	}

	public BossSuccessiveInfo(BossSuccessiveInfo other)
		: this()
	{
		configId_ = other.configId_;
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossSuccessiveInfo Clone()
	{
		return new BossSuccessiveInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossSuccessiveInfo);
	}

	public bool Equals(BossSuccessiveInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConfigId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConfigId);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConfigId);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossSuccessiveInfo other)
	{
		if (other != null)
		{
			if (other.ConfigId != 0)
			{
				ConfigId = other.ConfigId;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
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
				ConfigId = input.ReadInt32();
				break;
			case 16u:
				BuffId = input.ReadInt32();
				break;
			}
		}
	}
}
