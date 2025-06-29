using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportMonitorSet : IMessage<ReportMonitorSet>, IMessage, IEquatable<ReportMonitorSet>, IDeepCloneable<ReportMonitorSet>
{
	private static readonly MessageParser<ReportMonitorSet> _parser = new MessageParser<ReportMonitorSet>(() => new ReportMonitorSet());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ReportMonitorKeyVal> _repeated_envKvs_codec = FieldCodec.ForMessage(10u, ReportMonitorKeyVal.Parser);

	private readonly RepeatedField<ReportMonitorKeyVal> envKvs_ = new RepeatedField<ReportMonitorKeyVal>();

	private string setEvtKey_ = "";

	private long setEvtVal_;

	private long setEvtValNum_;

	private long setEvtValMin_;

	private long setEvtValMax_;

	private long setEvtValSum_;

	private uint time_;

	public static MessageParser<ReportMonitorSet> Parser => _parser;

	public RepeatedField<ReportMonitorKeyVal> EnvKvs => envKvs_;

	public string SetEvtKey
	{
		get
		{
			return setEvtKey_;
		}
		set
		{
			setEvtKey_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public long SetEvtVal
	{
		get
		{
			return setEvtVal_;
		}
		set
		{
			setEvtVal_ = value;
		}
	}

	public long SetEvtValNum
	{
		get
		{
			return setEvtValNum_;
		}
		set
		{
			setEvtValNum_ = value;
		}
	}

	public long SetEvtValMin
	{
		get
		{
			return setEvtValMin_;
		}
		set
		{
			setEvtValMin_ = value;
		}
	}

	public long SetEvtValMax
	{
		get
		{
			return setEvtValMax_;
		}
		set
		{
			setEvtValMax_ = value;
		}
	}

	public long SetEvtValSum
	{
		get
		{
			return setEvtValSum_;
		}
		set
		{
			setEvtValSum_ = value;
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

	public ReportMonitorSet()
	{
	}

	public ReportMonitorSet(ReportMonitorSet other)
		: this()
	{
		envKvs_ = other.envKvs_.Clone();
		setEvtKey_ = other.setEvtKey_;
		setEvtVal_ = other.setEvtVal_;
		setEvtValNum_ = other.setEvtValNum_;
		setEvtValMin_ = other.setEvtValMin_;
		setEvtValMax_ = other.setEvtValMax_;
		setEvtValSum_ = other.setEvtValSum_;
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportMonitorSet Clone()
	{
		return new ReportMonitorSet(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportMonitorSet);
	}

	public bool Equals(ReportMonitorSet other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!envKvs_.Equals(other.envKvs_))
		{
			return false;
		}
		if (SetEvtKey != other.SetEvtKey)
		{
			return false;
		}
		if (SetEvtVal != other.SetEvtVal)
		{
			return false;
		}
		if (SetEvtValNum != other.SetEvtValNum)
		{
			return false;
		}
		if (SetEvtValMin != other.SetEvtValMin)
		{
			return false;
		}
		if (SetEvtValMax != other.SetEvtValMax)
		{
			return false;
		}
		if (SetEvtValSum != other.SetEvtValSum)
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
		num ^= envKvs_.GetHashCode();
		if (SetEvtKey.Length != 0)
		{
			num ^= SetEvtKey.GetHashCode();
		}
		if (SetEvtVal != 0L)
		{
			num ^= SetEvtVal.GetHashCode();
		}
		if (SetEvtValNum != 0L)
		{
			num ^= SetEvtValNum.GetHashCode();
		}
		if (SetEvtValMin != 0L)
		{
			num ^= SetEvtValMin.GetHashCode();
		}
		if (SetEvtValMax != 0L)
		{
			num ^= SetEvtValMax.GetHashCode();
		}
		if (SetEvtValSum != 0L)
		{
			num ^= SetEvtValSum.GetHashCode();
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
		envKvs_.WriteTo(output, _repeated_envKvs_codec);
		if (SetEvtKey.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SetEvtKey);
		}
		if (SetEvtVal != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(SetEvtVal);
		}
		if (SetEvtValNum != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(SetEvtValNum);
		}
		if (SetEvtValMin != 0L)
		{
			output.WriteRawTag(40);
			output.WriteInt64(SetEvtValMin);
		}
		if (SetEvtValMax != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(SetEvtValMax);
		}
		if (SetEvtValSum != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(SetEvtValSum);
		}
		if (Time != 0)
		{
			output.WriteRawTag(64);
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
		num += envKvs_.CalculateSize(_repeated_envKvs_codec);
		if (SetEvtKey.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SetEvtKey);
		}
		if (SetEvtVal != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(SetEvtVal);
		}
		if (SetEvtValNum != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(SetEvtValNum);
		}
		if (SetEvtValMin != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(SetEvtValMin);
		}
		if (SetEvtValMax != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(SetEvtValMax);
		}
		if (SetEvtValSum != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(SetEvtValSum);
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

	public void MergeFrom(ReportMonitorSet other)
	{
		if (other != null)
		{
			envKvs_.Add(other.envKvs_);
			if (other.SetEvtKey.Length != 0)
			{
				SetEvtKey = other.SetEvtKey;
			}
			if (other.SetEvtVal != 0L)
			{
				SetEvtVal = other.SetEvtVal;
			}
			if (other.SetEvtValNum != 0L)
			{
				SetEvtValNum = other.SetEvtValNum;
			}
			if (other.SetEvtValMin != 0L)
			{
				SetEvtValMin = other.SetEvtValMin;
			}
			if (other.SetEvtValMax != 0L)
			{
				SetEvtValMax = other.SetEvtValMax;
			}
			if (other.SetEvtValSum != 0L)
			{
				SetEvtValSum = other.SetEvtValSum;
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
			case 10u:
				envKvs_.AddEntriesFrom(input, _repeated_envKvs_codec);
				break;
			case 18u:
				SetEvtKey = input.ReadString();
				break;
			case 24u:
				SetEvtVal = input.ReadInt64();
				break;
			case 32u:
				SetEvtValNum = input.ReadInt64();
				break;
			case 40u:
				SetEvtValMin = input.ReadInt64();
				break;
			case 48u:
				SetEvtValMax = input.ReadInt64();
				break;
			case 56u:
				SetEvtValSum = input.ReadInt64();
				break;
			case 64u:
				Time = input.ReadUInt32();
				break;
			}
		}
	}
}
