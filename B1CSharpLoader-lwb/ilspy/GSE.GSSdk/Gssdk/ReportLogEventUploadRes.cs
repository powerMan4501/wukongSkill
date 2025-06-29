using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportLogEventUploadRes : IMessage<ReportLogEventUploadRes>, IMessage, IEquatable<ReportLogEventUploadRes>, IDeepCloneable<ReportLogEventUploadRes>
{
	private static readonly MessageParser<ReportLogEventUploadRes> _parser = new MessageParser<ReportLogEventUploadRes>(() => new ReportLogEventUploadRes());

	private UnknownFieldSet _unknownFields;

	private int code_;

	private string msg_ = "";

	private string resId_ = "";

	public static MessageParser<ReportLogEventUploadRes> Parser => _parser;

	public int Code
	{
		get
		{
			return code_;
		}
		set
		{
			code_ = value;
		}
	}

	public string Msg
	{
		get
		{
			return msg_;
		}
		set
		{
			msg_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ResId
	{
		get
		{
			return resId_;
		}
		set
		{
			resId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportLogEventUploadRes()
	{
	}

	public ReportLogEventUploadRes(ReportLogEventUploadRes other)
		: this()
	{
		code_ = other.code_;
		msg_ = other.msg_;
		resId_ = other.resId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogEventUploadRes Clone()
	{
		return new ReportLogEventUploadRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogEventUploadRes);
	}

	public bool Equals(ReportLogEventUploadRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Code != other.Code)
		{
			return false;
		}
		if (Msg != other.Msg)
		{
			return false;
		}
		if (ResId != other.ResId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Code != 0)
		{
			num ^= Code.GetHashCode();
		}
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
		}
		if (ResId.Length != 0)
		{
			num ^= ResId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Code != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Code);
		}
		if (Msg.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Msg);
		}
		if (ResId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ResId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Code != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Code);
		}
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		if (ResId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogEventUploadRes other)
	{
		if (other != null)
		{
			if (other.Code != 0)
			{
				Code = other.Code;
			}
			if (other.Msg.Length != 0)
			{
				Msg = other.Msg;
			}
			if (other.ResId.Length != 0)
			{
				ResId = other.ResId;
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
				Code = input.ReadInt32();
				break;
			case 18u:
				Msg = input.ReadString();
				break;
			case 26u:
				ResId = input.ReadString();
				break;
			}
		}
	}
}
