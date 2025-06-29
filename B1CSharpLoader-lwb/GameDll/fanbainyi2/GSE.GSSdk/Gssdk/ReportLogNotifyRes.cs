using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class ReportLogNotifyRes : IMessage<ReportLogNotifyRes>, IMessage, IEquatable<ReportLogNotifyRes>, IDeepCloneable<ReportLogNotifyRes>
{
	private static readonly MessageParser<ReportLogNotifyRes> _parser = new MessageParser<ReportLogNotifyRes>(() => new ReportLogNotifyRes());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ReportLogNotifyUnit> _repeated_data_codec = FieldCodec.ForMessage(10u, ReportLogNotifyUnit.Parser);

	private readonly RepeatedField<ReportLogNotifyUnit> data_ = new RepeatedField<ReportLogNotifyUnit>();

	public static MessageParser<ReportLogNotifyRes> Parser => _parser;

	public RepeatedField<ReportLogNotifyUnit> Data => data_;

	public ReportLogNotifyRes()
	{
	}

	public ReportLogNotifyRes(ReportLogNotifyRes other)
		: this()
	{
		data_ = other.data_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogNotifyRes Clone()
	{
		return new ReportLogNotifyRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogNotifyRes);
	}

	public bool Equals(ReportLogNotifyRes other)
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

	public void MergeFrom(ReportLogNotifyRes other)
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
