using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReporterEnv : IMessage<ReporterEnv>, IMessage, IEquatable<ReporterEnv>, IDeepCloneable<ReporterEnv>
{
	private static readonly MessageParser<ReporterEnv> _parser = new MessageParser<ReporterEnv>(() => new ReporterEnv());

	private UnknownFieldSet _unknownFields;

	private ReporterType reporterType_;

	private string reporterId_ = "";

	public static MessageParser<ReporterEnv> Parser => _parser;

	public ReporterType ReporterType
	{
		get
		{
			return reporterType_;
		}
		set
		{
			reporterType_ = value;
		}
	}

	public string ReporterId
	{
		get
		{
			return reporterId_;
		}
		set
		{
			reporterId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReporterEnv()
	{
	}

	public ReporterEnv(ReporterEnv other)
		: this()
	{
		reporterType_ = other.reporterType_;
		reporterId_ = other.reporterId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReporterEnv Clone()
	{
		return new ReporterEnv(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReporterEnv);
	}

	public bool Equals(ReporterEnv other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ReporterType != other.ReporterType)
		{
			return false;
		}
		if (ReporterId != other.ReporterId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ReporterType != ReporterType.Default)
		{
			num ^= ReporterType.GetHashCode();
		}
		if (ReporterId.Length != 0)
		{
			num ^= ReporterId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ReporterType != ReporterType.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ReporterType);
		}
		if (ReporterId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ReporterId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ReporterType != ReporterType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ReporterType);
		}
		if (ReporterId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ReporterId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReporterEnv other)
	{
		if (other != null)
		{
			if (other.ReporterType != ReporterType.Default)
			{
				ReporterType = other.ReporterType;
			}
			if (other.ReporterId.Length != 0)
			{
				ReporterId = other.ReporterId;
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
				ReporterType = (ReporterType)input.ReadEnum();
				break;
			case 18u:
				ReporterId = input.ReadString();
				break;
			}
		}
	}
}
