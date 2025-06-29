using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportLogQueryRes : IMessage<ReportLogQueryRes>, IMessage, IEquatable<ReportLogQueryRes>, IDeepCloneable<ReportLogQueryRes>
{
	private static readonly MessageParser<ReportLogQueryRes> _parser = new MessageParser<ReportLogQueryRes>(() => new ReportLogQueryRes());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DevReportDataFull> _repeated_data_codec = FieldCodec.ForMessage(10u, DevReportDataFull.Parser);

	private readonly RepeatedField<DevReportDataFull> data_ = new RepeatedField<DevReportDataFull>();

	public static MessageParser<ReportLogQueryRes> Parser => _parser;

	public RepeatedField<DevReportDataFull> Data => data_;

	public ReportLogQueryRes()
	{
	}

	public ReportLogQueryRes(ReportLogQueryRes other)
		: this()
	{
		data_ = other.data_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogQueryRes Clone()
	{
		return new ReportLogQueryRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogQueryRes);
	}

	public bool Equals(ReportLogQueryRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!data_.Equals(other.data_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= data_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		data_.WriteTo(output, _repeated_data_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += data_.CalculateSize(_repeated_data_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogQueryRes other)
	{
		if (other != null)
		{
			data_.Add(other.data_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				data_.AddEntriesFrom(input, _repeated_data_codec);
			}
		}
	}
}
