using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportMonitorAdd : IMessage<ReportMonitorAdd>, IMessage, IEquatable<ReportMonitorAdd>, IDeepCloneable<ReportMonitorAdd>
{
	private static readonly MessageParser<ReportMonitorAdd> _parser = new MessageParser<ReportMonitorAdd>(() => new ReportMonitorAdd());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ReportMonitorKeyVal> _repeated_envKvs_codec = FieldCodec.ForMessage(10u, ReportMonitorKeyVal.Parser);

	private readonly RepeatedField<ReportMonitorKeyVal> envKvs_ = new RepeatedField<ReportMonitorKeyVal>();

	private long addEvtVal_;

	private string addEvtKey_ = "";

	private uint time_;

	public static MessageParser<ReportMonitorAdd> Parser => _parser;

	public RepeatedField<ReportMonitorKeyVal> EnvKvs => envKvs_;

	public long AddEvtVal
	{
		get
		{
			return addEvtVal_;
		}
		set
		{
			addEvtVal_ = value;
		}
	}

	public string AddEvtKey
	{
		get
		{
			return addEvtKey_;
		}
		set
		{
			addEvtKey_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public ReportMonitorAdd()
	{
	}

	public ReportMonitorAdd(ReportMonitorAdd other)
		: this()
	{
		envKvs_ = other.envKvs_.Clone();
		addEvtVal_ = other.addEvtVal_;
		addEvtKey_ = other.addEvtKey_;
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportMonitorAdd Clone()
	{
		return new ReportMonitorAdd(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportMonitorAdd);
	}

	public bool Equals(ReportMonitorAdd other)
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
		if (AddEvtVal != other.AddEvtVal)
		{
			return false;
		}
		if (AddEvtKey != other.AddEvtKey)
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
		if (AddEvtVal != 0L)
		{
			num ^= AddEvtVal.GetHashCode();
		}
		if (AddEvtKey.Length != 0)
		{
			num ^= AddEvtKey.GetHashCode();
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
		if (AddEvtVal != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(AddEvtVal);
		}
		if (AddEvtKey.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AddEvtKey);
		}
		if (Time != 0)
		{
			output.WriteRawTag(32);
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
		if (AddEvtVal != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(AddEvtVal);
		}
		if (AddEvtKey.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AddEvtKey);
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

	public void MergeFrom(ReportMonitorAdd other)
	{
		if (other != null)
		{
			envKvs_.Add(other.envKvs_);
			if (other.AddEvtVal != 0L)
			{
				AddEvtVal = other.AddEvtVal;
			}
			if (other.AddEvtKey.Length != 0)
			{
				AddEvtKey = other.AddEvtKey;
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
			case 16u:
				AddEvtVal = input.ReadInt64();
				break;
			case 26u:
				AddEvtKey = input.ReadString();
				break;
			case 32u:
				Time = input.ReadUInt32();
				break;
			}
		}
	}
}
