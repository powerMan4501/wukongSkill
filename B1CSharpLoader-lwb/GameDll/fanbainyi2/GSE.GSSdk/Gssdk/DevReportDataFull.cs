using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class DevReportDataFull : IMessage<DevReportDataFull>, IMessage, IEquatable<DevReportDataFull>, IDeepCloneable<DevReportDataFull>
{
	private static readonly MessageParser<DevReportDataFull> _parser = new MessageParser<DevReportDataFull>(() => new DevReportDataFull());

	private UnknownFieldSet _unknownFields;

	private DevReportData data_;

	private static readonly FieldCodec<DevResData> _repeated_res_codec = FieldCodec.ForMessage(18u, DevResData.Parser);

	private readonly RepeatedField<DevResData> res_ = new RepeatedField<DevResData>();

	public static MessageParser<DevReportDataFull> Parser => _parser;

	public DevReportData Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	public RepeatedField<DevResData> Res => res_;

	public DevReportDataFull()
	{
	}

	public DevReportDataFull(DevReportDataFull other)
		: this()
	{
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		res_ = other.res_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DevReportDataFull Clone()
	{
		return new DevReportDataFull(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DevReportDataFull);
	}

	public bool Equals(DevReportDataFull other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Data, other.Data))
		{
			return false;
		}
		if (!res_.Equals(other.res_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
		}
		num ^= res_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (data_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Data);
		}
		res_.WriteTo(output, _repeated_res_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		num += res_.CalculateSize(_repeated_res_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DevReportDataFull other)
	{
		if (other == null)
		{
			return;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new DevReportData();
			}
			Data.MergeFrom(other.Data);
		}
		res_.Add(other.res_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (data_ == null)
				{
					Data = new DevReportData();
				}
				input.ReadMessage(Data);
				break;
			case 18u:
				res_.AddEntriesFrom(input, _repeated_res_codec);
				break;
			}
		}
	}
}
