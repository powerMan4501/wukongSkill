using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportTrackRes : IMessage<ReportTrackRes>, IMessage, IEquatable<ReportTrackRes>, IDeepCloneable<ReportTrackRes>
{
	private static readonly MessageParser<ReportTrackRes> _parser = new MessageParser<ReportTrackRes>(() => new ReportTrackRes());

	private UnknownFieldSet _unknownFields;

	private int dummy_;

	public static MessageParser<ReportTrackRes> Parser => _parser;

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

	public ReportTrackRes()
	{
	}

	public ReportTrackRes(ReportTrackRes other)
		: this()
	{
		dummy_ = other.dummy_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportTrackRes Clone()
	{
		return new ReportTrackRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportTrackRes);
	}

	public bool Equals(ReportTrackRes other)
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

	public void MergeFrom(ReportTrackRes other)
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
