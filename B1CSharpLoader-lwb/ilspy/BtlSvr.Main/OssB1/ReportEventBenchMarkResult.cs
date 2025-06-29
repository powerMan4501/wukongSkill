using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventBenchMarkResult : IMessage<ReportEventBenchMarkResult>, IMessage, IEquatable<ReportEventBenchMarkResult>, IDeepCloneable<ReportEventBenchMarkResult>
{
	private static readonly MessageParser<ReportEventBenchMarkResult> _parser = new MessageParser<ReportEventBenchMarkResult>(() => new ReportEventBenchMarkResult());

	private UnknownFieldSet _unknownFields;

	private int aveFps_;

	private int maxFps_;

	private int minFps_;

	private int ninetyFiveLowFps_;

	private int cpuUsage_;

	private int gpuUsage_;

	private string settingInfo_ = "";

	public static MessageParser<ReportEventBenchMarkResult> Parser => _parser;

	public int AveFps
	{
		get
		{
			return aveFps_;
		}
		set
		{
			aveFps_ = value;
		}
	}

	public int MaxFps
	{
		get
		{
			return maxFps_;
		}
		set
		{
			maxFps_ = value;
		}
	}

	public int MinFps
	{
		get
		{
			return minFps_;
		}
		set
		{
			minFps_ = value;
		}
	}

	public int NinetyFiveLowFps
	{
		get
		{
			return ninetyFiveLowFps_;
		}
		set
		{
			ninetyFiveLowFps_ = value;
		}
	}

	public int CpuUsage
	{
		get
		{
			return cpuUsage_;
		}
		set
		{
			cpuUsage_ = value;
		}
	}

	public int GpuUsage
	{
		get
		{
			return gpuUsage_;
		}
		set
		{
			gpuUsage_ = value;
		}
	}

	public string SettingInfo
	{
		get
		{
			return settingInfo_;
		}
		set
		{
			settingInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventBenchMarkResult()
	{
	}

	public ReportEventBenchMarkResult(ReportEventBenchMarkResult other)
		: this()
	{
		aveFps_ = other.aveFps_;
		maxFps_ = other.maxFps_;
		minFps_ = other.minFps_;
		ninetyFiveLowFps_ = other.ninetyFiveLowFps_;
		cpuUsage_ = other.cpuUsage_;
		gpuUsage_ = other.gpuUsage_;
		settingInfo_ = other.settingInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventBenchMarkResult Clone()
	{
		return new ReportEventBenchMarkResult(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventBenchMarkResult);
	}

	public bool Equals(ReportEventBenchMarkResult other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AveFps != other.AveFps)
		{
			return false;
		}
		if (MaxFps != other.MaxFps)
		{
			return false;
		}
		if (MinFps != other.MinFps)
		{
			return false;
		}
		if (NinetyFiveLowFps != other.NinetyFiveLowFps)
		{
			return false;
		}
		if (CpuUsage != other.CpuUsage)
		{
			return false;
		}
		if (GpuUsage != other.GpuUsage)
		{
			return false;
		}
		if (SettingInfo != other.SettingInfo)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AveFps != 0)
		{
			num ^= AveFps.GetHashCode();
		}
		if (MaxFps != 0)
		{
			num ^= MaxFps.GetHashCode();
		}
		if (MinFps != 0)
		{
			num ^= MinFps.GetHashCode();
		}
		if (NinetyFiveLowFps != 0)
		{
			num ^= NinetyFiveLowFps.GetHashCode();
		}
		if (CpuUsage != 0)
		{
			num ^= CpuUsage.GetHashCode();
		}
		if (GpuUsage != 0)
		{
			num ^= GpuUsage.GetHashCode();
		}
		if (SettingInfo.Length != 0)
		{
			num ^= SettingInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AveFps != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AveFps);
		}
		if (MaxFps != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MaxFps);
		}
		if (MinFps != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MinFps);
		}
		if (NinetyFiveLowFps != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(NinetyFiveLowFps);
		}
		if (CpuUsage != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CpuUsage);
		}
		if (GpuUsage != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(GpuUsage);
		}
		if (SettingInfo.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(SettingInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AveFps != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AveFps);
		}
		if (MaxFps != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxFps);
		}
		if (MinFps != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MinFps);
		}
		if (NinetyFiveLowFps != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NinetyFiveLowFps);
		}
		if (CpuUsage != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CpuUsage);
		}
		if (GpuUsage != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GpuUsage);
		}
		if (SettingInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SettingInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventBenchMarkResult other)
	{
		if (other != null)
		{
			if (other.AveFps != 0)
			{
				AveFps = other.AveFps;
			}
			if (other.MaxFps != 0)
			{
				MaxFps = other.MaxFps;
			}
			if (other.MinFps != 0)
			{
				MinFps = other.MinFps;
			}
			if (other.NinetyFiveLowFps != 0)
			{
				NinetyFiveLowFps = other.NinetyFiveLowFps;
			}
			if (other.CpuUsage != 0)
			{
				CpuUsage = other.CpuUsage;
			}
			if (other.GpuUsage != 0)
			{
				GpuUsage = other.GpuUsage;
			}
			if (other.SettingInfo.Length != 0)
			{
				SettingInfo = other.SettingInfo;
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
				AveFps = input.ReadInt32();
				break;
			case 16u:
				MaxFps = input.ReadInt32();
				break;
			case 24u:
				MinFps = input.ReadInt32();
				break;
			case 32u:
				NinetyFiveLowFps = input.ReadInt32();
				break;
			case 40u:
				CpuUsage = input.ReadInt32();
				break;
			case 48u:
				GpuUsage = input.ReadInt32();
				break;
			case 58u:
				SettingInfo = input.ReadString();
				break;
			}
		}
	}
}
