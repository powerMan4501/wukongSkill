using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_ManagedStreamingLevelStateConfig : IMessage<CalliopeCustom_ManagedStreamingLevelStateConfig>, IMessage, IEquatable<CalliopeCustom_ManagedStreamingLevelStateConfig>, IDeepCloneable<CalliopeCustom_ManagedStreamingLevelStateConfig>
{
	private static readonly MessageParser<CalliopeCustom_ManagedStreamingLevelStateConfig> _parser = new MessageParser<CalliopeCustom_ManagedStreamingLevelStateConfig>(() => new CalliopeCustom_ManagedStreamingLevelStateConfig());

	private UnknownFieldSet _unknownFields;

	private string configGuid_ = "";

	private ManagedStreamingLevelStateConfigParam dataAssetIdValue_;

	public static MessageParser<CalliopeCustom_ManagedStreamingLevelStateConfig> Parser => _parser;

	public string ConfigGuid
	{
		get
		{
			return configGuid_;
		}
		set
		{
			configGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ManagedStreamingLevelStateConfigParam DataAssetIdValue
	{
		get
		{
			return dataAssetIdValue_;
		}
		set
		{
			dataAssetIdValue_ = value;
		}
	}

	public CalliopeCustom_ManagedStreamingLevelStateConfig()
	{
	}

	public CalliopeCustom_ManagedStreamingLevelStateConfig(CalliopeCustom_ManagedStreamingLevelStateConfig other)
		: this()
	{
		configGuid_ = other.configGuid_;
		dataAssetIdValue_ = ((other.dataAssetIdValue_ != null) ? other.dataAssetIdValue_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_ManagedStreamingLevelStateConfig Clone()
	{
		return new CalliopeCustom_ManagedStreamingLevelStateConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_ManagedStreamingLevelStateConfig);
	}

	public bool Equals(CalliopeCustom_ManagedStreamingLevelStateConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConfigGuid != other.ConfigGuid)
		{
			return false;
		}
		if (!object.Equals(DataAssetIdValue, other.DataAssetIdValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConfigGuid.Length != 0)
		{
			num ^= ConfigGuid.GetHashCode();
		}
		if (dataAssetIdValue_ != null)
		{
			num ^= DataAssetIdValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConfigGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ConfigGuid);
		}
		if (dataAssetIdValue_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(DataAssetIdValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConfigGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConfigGuid);
		}
		if (dataAssetIdValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DataAssetIdValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_ManagedStreamingLevelStateConfig other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ConfigGuid.Length != 0)
		{
			ConfigGuid = other.ConfigGuid;
		}
		if (other.dataAssetIdValue_ != null)
		{
			if (dataAssetIdValue_ == null)
			{
				DataAssetIdValue = new ManagedStreamingLevelStateConfigParam();
			}
			DataAssetIdValue.MergeFrom(other.DataAssetIdValue);
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
			case 10u:
				ConfigGuid = input.ReadString();
				break;
			case 18u:
				if (dataAssetIdValue_ == null)
				{
					DataAssetIdValue = new ManagedStreamingLevelStateConfigParam();
				}
				input.ReadMessage(DataAssetIdValue);
				break;
			}
		}
	}
}
