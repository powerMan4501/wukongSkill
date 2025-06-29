using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportLogEventRes : IMessage<ReportLogEventRes>, IMessage, IEquatable<ReportLogEventRes>, IDeepCloneable<ReportLogEventRes>
{
	private static readonly MessageParser<ReportLogEventRes> _parser = new MessageParser<ReportLogEventRes>(() => new ReportLogEventRes());

	private UnknownFieldSet _unknownFields;

	private int dummy_;

	public static MessageParser<ReportLogEventRes> Parser => _parser;

	public int Dummy
	{
		get
		{
			return dummy_;
		}
		set
		{
			dummy_ = value;
		}
	}

	public ReportLogEventRes()
	{
	}

	public ReportLogEventRes(ReportLogEventRes other)
		: this()
	{
		dummy_ = other.dummy_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogEventRes Clone()
	{
		return new ReportLogEventRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogEventRes);
	}

	public bool Equals(ReportLogEventRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Dummy != other.Dummy)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Dummy != 0)
		{
			num ^= Dummy.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Dummy != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Dummy);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Dummy != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Dummy);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogEventRes other)
	{
		if (other != null)
		{
			if (other.Dummy != 0)
			{
				Dummy = other.Dummy;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Dummy = input.ReadInt32();
			}
		}
	}
}
