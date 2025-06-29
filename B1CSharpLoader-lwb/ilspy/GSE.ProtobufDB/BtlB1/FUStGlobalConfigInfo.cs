using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStGlobalConfigInfo : IMessage<FUStGlobalConfigInfo>, IMessage, IEquatable<FUStGlobalConfigInfo>, IDeepCloneable<FUStGlobalConfigInfo>
{
	private static readonly MessageParser<FUStGlobalConfigInfo> _parser = new MessageParser<FUStGlobalConfigInfo>(() => new FUStGlobalConfigInfo());

	private UnknownFieldSet _unknownFields;

	private string aliasName_ = "";

	private FUStGlobalConfigType configType_;

	private string configValue_ = "";

	public static MessageParser<FUStGlobalConfigInfo> Parser => _parser;

	public string AliasName
	{
		get
		{
			return aliasName_;
		}
		set
		{
			aliasName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStGlobalConfigType ConfigType
	{
		get
		{
			return configType_;
		}
		set
		{
			configType_ = value;
		}
	}

	public string ConfigValue
	{
		get
		{
			return configValue_;
		}
		set
		{
			configValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStGlobalConfigInfo()
	{
	}

	public FUStGlobalConfigInfo(FUStGlobalConfigInfo other)
		: this()
	{
		aliasName_ = other.aliasName_;
		configType_ = other.configType_;
		configValue_ = other.configValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStGlobalConfigInfo Clone()
	{
		return new FUStGlobalConfigInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStGlobalConfigInfo);
	}

	public bool Equals(FUStGlobalConfigInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AliasName != other.AliasName)
		{
			return false;
		}
		if (ConfigType != other.ConfigType)
		{
			return false;
		}
		if (ConfigValue != other.ConfigValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AliasName.Length != 0)
		{
			num ^= AliasName.GetHashCode();
		}
		if (ConfigType != FUStGlobalConfigType.Int)
		{
			num ^= ConfigType.GetHashCode();
		}
		if (ConfigValue.Length != 0)
		{
			num ^= ConfigValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AliasName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AliasName);
		}
		if (ConfigType != FUStGlobalConfigType.Int)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ConfigType);
		}
		if (ConfigValue.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ConfigValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AliasName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AliasName);
		}
		if (ConfigType != FUStGlobalConfigType.Int)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConfigType);
		}
		if (ConfigValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConfigValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStGlobalConfigInfo other)
	{
		if (other != null)
		{
			if (other.AliasName.Length != 0)
			{
				AliasName = other.AliasName;
			}
			if (other.ConfigType != FUStGlobalConfigType.Int)
			{
				ConfigType = other.ConfigType;
			}
			if (other.ConfigValue.Length != 0)
			{
				ConfigValue = other.ConfigValue;
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
				AliasName = input.ReadString();
				break;
			case 16u:
				ConfigType = (FUStGlobalConfigType)input.ReadEnum();
				break;
			case 26u:
				ConfigValue = input.ReadString();
				break;
			}
		}
	}
}
