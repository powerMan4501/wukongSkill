using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportUserEvent : IMessage<ReportUserEvent>, IMessage, IEquatable<ReportUserEvent>, IDeepCloneable<ReportUserEvent>
{
	private static readonly MessageParser<ReportUserEvent> _parser = new MessageParser<ReportUserEvent>(() => new ReportUserEvent());

	private UnknownFieldSet _unknownFields;

	private ReportEvtType evtType_;

	private string evtName_ = "";

	private long evtResult_;

	private long evtIntParam_;

	private string evtStrParam_ = "";

	private static readonly FieldCodec<ReportMonitorKeyVal> _repeated_evtProps_codec = FieldCodec.ForMessage(50u, ReportMonitorKeyVal.Parser);

	private readonly RepeatedField<ReportMonitorKeyVal> evtProps_ = new RepeatedField<ReportMonitorKeyVal>();

	private long evtMetricSum_;

	private long evtMetricNum_;

	private long evtMetricMin_;

	private long evtMetricMax_;

	private uint time_;

	public static MessageParser<ReportUserEvent> Parser => _parser;

	public ReportEvtType EvtType
	{
		get
		{
			return evtType_;
		}
		set
		{
			evtType_ = value;
		}
	}

	public string EvtName
	{
		get
		{
			return evtName_;
		}
		set
		{
			evtName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public long EvtResult
	{
		get
		{
			return evtResult_;
		}
		set
		{
			evtResult_ = value;
		}
	}

	public long EvtIntParam
	{
		get
		{
			return evtIntParam_;
		}
		set
		{
			evtIntParam_ = value;
		}
	}

	public string EvtStrParam
	{
		get
		{
			return evtStrParam_;
		}
		set
		{
			evtStrParam_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<ReportMonitorKeyVal> EvtProps => evtProps_;

	public long EvtMetricSum
	{
		get
		{
			return evtMetricSum_;
		}
		set
		{
			evtMetricSum_ = value;
		}
	}

	public long EvtMetricNum
	{
		get
		{
			return evtMetricNum_;
		}
		set
		{
			evtMetricNum_ = value;
		}
	}

	public long EvtMetricMin
	{
		get
		{
			return evtMetricMin_;
		}
		set
		{
			evtMetricMin_ = value;
		}
	}

	public long EvtMetricMax
	{
		get
		{
			return evtMetricMax_;
		}
		set
		{
			evtMetricMax_ = value;
		}
	}

	public uint Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	public ReportUserEvent()
	{
	}

	public ReportUserEvent(ReportUserEvent other)
		: this()
	{
		evtType_ = other.evtType_;
		evtName_ = other.evtName_;
		evtResult_ = other.evtResult_;
		evtIntParam_ = other.evtIntParam_;
		evtStrParam_ = other.evtStrParam_;
		evtProps_ = other.evtProps_.Clone();
		evtMetricSum_ = other.evtMetricSum_;
		evtMetricNum_ = other.evtMetricNum_;
		evtMetricMin_ = other.evtMetricMin_;
		evtMetricMax_ = other.evtMetricMax_;
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportUserEvent Clone()
	{
		return new ReportUserEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportUserEvent);
	}

	public bool Equals(ReportUserEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EvtType != other.EvtType)
		{
			return false;
		}
		if (EvtName != other.EvtName)
		{
			return false;
		}
		if (EvtResult != other.EvtResult)
		{
			return false;
		}
		if (EvtIntParam != other.EvtIntParam)
		{
			return false;
		}
		if (EvtStrParam != other.EvtStrParam)
		{
			return false;
		}
		if (!evtProps_.Equals(other.evtProps_))
		{
			return false;
		}
		if (EvtMetricSum != other.EvtMetricSum)
		{
			return false;
		}
		if (EvtMetricNum != other.EvtMetricNum)
		{
			return false;
		}
		if (EvtMetricMin != other.EvtMetricMin)
		{
			return false;
		}
		if (EvtMetricMax != other.EvtMetricMax)
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EvtType != ReportEvtType.CustomName)
		{
			num ^= EvtType.GetHashCode();
		}
		if (EvtName.Length != 0)
		{
			num ^= EvtName.GetHashCode();
		}
		if (EvtResult != 0L)
		{
			num ^= EvtResult.GetHashCode();
		}
		if (EvtIntParam != 0L)
		{
			num ^= EvtIntParam.GetHashCode();
		}
		if (EvtStrParam.Length != 0)
		{
			num ^= EvtStrParam.GetHashCode();
		}
		num ^= evtProps_.GetHashCode();
		if (EvtMetricSum != 0L)
		{
			num ^= EvtMetricSum.GetHashCode();
		}
		if (EvtMetricNum != 0L)
		{
			num ^= EvtMetricNum.GetHashCode();
		}
		if (EvtMetricMin != 0L)
		{
			num ^= EvtMetricMin.GetHashCode();
		}
		if (EvtMetricMax != 0L)
		{
			num ^= EvtMetricMax.GetHashCode();
		}
		if (Time != 0)
		{
			num ^= Time.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EvtType != ReportEvtType.CustomName)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EvtType);
		}
		if (EvtName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(EvtName);
		}
		if (EvtResult != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(EvtResult);
		}
		if (EvtIntParam != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(EvtIntParam);
		}
		if (EvtStrParam.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(EvtStrParam);
		}
		evtProps_.WriteTo(output, _repeated_evtProps_codec);
		if (EvtMetricSum != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(EvtMetricSum);
		}
		if (EvtMetricNum != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(EvtMetricNum);
		}
		if (EvtMetricMin != 0L)
		{
			output.WriteRawTag(72);
			output.WriteInt64(EvtMetricMin);
		}
		if (EvtMetricMax != 0L)
		{
			output.WriteRawTag(80);
			output.WriteInt64(EvtMetricMax);
		}
		if (Time != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Time);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EvtType != ReportEvtType.CustomName)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EvtType);
		}
		if (EvtName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EvtName);
		}
		if (EvtResult != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EvtResult);
		}
		if (EvtIntParam != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EvtIntParam);
		}
		if (EvtStrParam.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EvtStrParam);
		}
		num += evtProps_.CalculateSize(_repeated_evtProps_codec);
		if (EvtMetricSum != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EvtMetricSum);
		}
		if (EvtMetricNum != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EvtMetricNum);
		}
		if (EvtMetricMin != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EvtMetricMin);
		}
		if (EvtMetricMax != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EvtMetricMax);
		}
		if (Time != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Time);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportUserEvent other)
	{
		if (other != null)
		{
			if (other.EvtType != ReportEvtType.CustomName)
			{
				EvtType = other.EvtType;
			}
			if (other.EvtName.Length != 0)
			{
				EvtName = other.EvtName;
			}
			if (other.EvtResult != 0L)
			{
				EvtResult = other.EvtResult;
			}
			if (other.EvtIntParam != 0L)
			{
				EvtIntParam = other.EvtIntParam;
			}
			if (other.EvtStrParam.Length != 0)
			{
				EvtStrParam = other.EvtStrParam;
			}
			evtProps_.Add(other.evtProps_);
			if (other.EvtMetricSum != 0L)
			{
				EvtMetricSum = other.EvtMetricSum;
			}
			if (other.EvtMetricNum != 0L)
			{
				EvtMetricNum = other.EvtMetricNum;
			}
			if (other.EvtMetricMin != 0L)
			{
				EvtMetricMin = other.EvtMetricMin;
			}
			if (other.EvtMetricMax != 0L)
			{
				EvtMetricMax = other.EvtMetricMax;
			}
			if (other.Time != 0)
			{
				Time = other.Time;
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
				EvtType = (ReportEvtType)input.ReadEnum();
				break;
			case 18u:
				EvtName = input.ReadString();
				break;
			case 24u:
				EvtResult = input.ReadInt64();
				break;
			case 32u:
				EvtIntParam = input.ReadInt64();
				break;
			case 42u:
				EvtStrParam = input.ReadString();
				break;
			case 50u:
				evtProps_.AddEntriesFrom(input, _repeated_evtProps_codec);
				break;
			case 56u:
				EvtMetricSum = input.ReadInt64();
				break;
			case 64u:
				EvtMetricNum = input.ReadInt64();
				break;
			case 72u:
				EvtMetricMin = input.ReadInt64();
				break;
			case 80u:
				EvtMetricMax = input.ReadInt64();
				break;
			case 88u:
				Time = input.ReadUInt32();
				break;
			}
		}
	}
}
