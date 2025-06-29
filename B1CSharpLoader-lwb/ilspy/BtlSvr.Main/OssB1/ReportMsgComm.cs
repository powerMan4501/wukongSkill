using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportMsgComm : IMessage<ReportMsgComm>, IMessage, IEquatable<ReportMsgComm>, IDeepCloneable<ReportMsgComm>
{
	private static readonly MessageParser<ReportMsgComm> _parser = new MessageParser<ReportMsgComm>(() => new ReportMsgComm());

	private UnknownFieldSet _unknownFields;

	private ReporterEnv reporter_;

	public static MessageParser<ReportMsgComm> Parser => _parser;

	public ReporterEnv Reporter
	{
		get
		{
			return reporter_;
		}
		set
		{
			reporter_ = value;
		}
	}

	public ReportMsgComm()
	{
	}

	public ReportMsgComm(ReportMsgComm other)
		: this()
	{
		reporter_ = ((other.reporter_ != null) ? other.reporter_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportMsgComm Clone()
	{
		return new ReportMsgComm(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportMsgComm);
	}

	public bool Equals(ReportMsgComm other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Reporter, other.Reporter))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (reporter_ != null)
		{
			num ^= Reporter.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (reporter_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Reporter);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (reporter_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reporter);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportMsgComm other)
	{
		if (other == null)
		{
			return;
		}
		if (other.reporter_ != null)
		{
			if (reporter_ == null)
			{
				Reporter = new ReporterEnv();
			}
			Reporter.MergeFrom(other.Reporter);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (reporter_ == null)
			{
				Reporter = new ReporterEnv();
			}
			input.ReadMessage(Reporter);
		}
	}
}
