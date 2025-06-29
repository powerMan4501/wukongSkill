using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class GssdkReportConfig : IMessage<GssdkReportConfig>, IMessage, IEquatable<GssdkReportConfig>, IDeepCloneable<GssdkReportConfig>
{
	private static readonly MessageParser<GssdkReportConfig> _parser = new MessageParser<GssdkReportConfig>(() => new GssdkReportConfig());

	private UnknownFieldSet _unknownFields;

	private string keyPrefix_ = "";

	private string mqNs_ = "";

	private static readonly FieldCodec<string> _repeated_evtPrefix_codec = FieldCodec.ForString(26u);

	private readonly RepeatedField<string> evtPrefix_ = new RepeatedField<string>();

	private string mqDataNs_ = "";

	private int clusterId_;

	private int isSaveMonitor_;

	private int isCompress_;

	private int withDebugLog_;

	public static MessageParser<GssdkReportConfig> Parser => _parser;

	public string KeyPrefix
	{
		get
		{
			return keyPrefix_;
		}
		set
		{
			keyPrefix_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MqNs
	{
		get
		{
			return mqNs_;
		}
		set
		{
			mqNs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> EvtPrefix => evtPrefix_;

	public string MqDataNs
	{
		get
		{
			return mqDataNs_;
		}
		set
		{
			mqDataNs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ClusterId
	{
		get
		{
			return clusterId_;
		}
		set
		{
			clusterId_ = value;
		}
	}

	public int IsSaveMonitor
	{
		get
		{
			return isSaveMonitor_;
		}
		set
		{
			isSaveMonitor_ = value;
		}
	}

	public int IsCompress
	{
		get
		{
			return isCompress_;
		}
		set
		{
			isCompress_ = value;
		}
	}

	public int WithDebugLog
	{
		get
		{
			return withDebugLog_;
		}
		set
		{
			withDebugLog_ = value;
		}
	}

	public GssdkReportConfig()
	{
	}

	public GssdkReportConfig(GssdkReportConfig other)
		: this()
	{
		keyPrefix_ = other.keyPrefix_;
		mqNs_ = other.mqNs_;
		evtPrefix_ = other.evtPrefix_.Clone();
		mqDataNs_ = other.mqDataNs_;
		clusterId_ = other.clusterId_;
		isSaveMonitor_ = other.isSaveMonitor_;
		isCompress_ = other.isCompress_;
		withDebugLog_ = other.withDebugLog_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkReportConfig Clone()
	{
		return new GssdkReportConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkReportConfig);
	}

	public bool Equals(GssdkReportConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KeyPrefix != other.KeyPrefix)
		{
			return false;
		}
		if (MqNs != other.MqNs)
		{
			return false;
		}
		if (!evtPrefix_.Equals(other.evtPrefix_))
		{
			return false;
		}
		if (MqDataNs != other.MqDataNs)
		{
			return false;
		}
		if (ClusterId != other.ClusterId)
		{
			return false;
		}
		if (IsSaveMonitor != other.IsSaveMonitor)
		{
			return false;
		}
		if (IsCompress != other.IsCompress)
		{
			return false;
		}
		if (WithDebugLog != other.WithDebugLog)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (KeyPrefix.Length != 0)
		{
			num ^= KeyPrefix.GetHashCode();
		}
		if (MqNs.Length != 0)
		{
			num ^= MqNs.GetHashCode();
		}
		num ^= evtPrefix_.GetHashCode();
		if (MqDataNs.Length != 0)
		{
			num ^= MqDataNs.GetHashCode();
		}
		if (ClusterId != 0)
		{
			num ^= ClusterId.GetHashCode();
		}
		if (IsSaveMonitor != 0)
		{
			num ^= IsSaveMonitor.GetHashCode();
		}
		if (IsCompress != 0)
		{
			num ^= IsCompress.GetHashCode();
		}
		if (WithDebugLog != 0)
		{
			num ^= WithDebugLog.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (KeyPrefix.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(KeyPrefix);
		}
		if (MqNs.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MqNs);
		}
		evtPrefix_.WriteTo(output, _repeated_evtPrefix_codec);
		if (MqDataNs.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(MqDataNs);
		}
		if (ClusterId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ClusterId);
		}
		if (IsSaveMonitor != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(IsSaveMonitor);
		}
		if (IsCompress != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(IsCompress);
		}
		if (WithDebugLog != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(WithDebugLog);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (KeyPrefix.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(KeyPrefix);
		}
		if (MqNs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MqNs);
		}
		num += evtPrefix_.CalculateSize(_repeated_evtPrefix_codec);
		if (MqDataNs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MqDataNs);
		}
		if (ClusterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ClusterId);
		}
		if (IsSaveMonitor != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsSaveMonitor);
		}
		if (IsCompress != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsCompress);
		}
		if (WithDebugLog != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WithDebugLog);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkReportConfig other)
	{
		if (other != null)
		{
			if (other.KeyPrefix.Length != 0)
			{
				KeyPrefix = other.KeyPrefix;
			}
			if (other.MqNs.Length != 0)
			{
				MqNs = other.MqNs;
			}
			evtPrefix_.Add(other.evtPrefix_);
			if (other.MqDataNs.Length != 0)
			{
				MqDataNs = other.MqDataNs;
			}
			if (other.ClusterId != 0)
			{
				ClusterId = other.ClusterId;
			}
			if (other.IsSaveMonitor != 0)
			{
				IsSaveMonitor = other.IsSaveMonitor;
			}
			if (other.IsCompress != 0)
			{
				IsCompress = other.IsCompress;
			}
			if (other.WithDebugLog != 0)
			{
				WithDebugLog = other.WithDebugLog;
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
				KeyPrefix = input.ReadString();
				break;
			case 18u:
				MqNs = input.ReadString();
				break;
			case 26u:
				evtPrefix_.AddEntriesFrom(input, _repeated_evtPrefix_codec);
				break;
			case 34u:
				MqDataNs = input.ReadString();
				break;
			case 40u:
				ClusterId = input.ReadInt32();
				break;
			case 48u:
				IsSaveMonitor = input.ReadInt32();
				break;
			case 56u:
				IsCompress = input.ReadInt32();
				break;
			case 64u:
				WithDebugLog = input.ReadInt32();
				break;
			}
		}
	}
}
