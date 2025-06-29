using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportEventItem : IMessage<ReportEventItem>, IMessage, IEquatable<ReportEventItem>, IDeepCloneable<ReportEventItem>
{
	private static readonly MessageParser<ReportEventItem> _parser = new MessageParser<ReportEventItem>(() => new ReportEventItem());

	private UnknownFieldSet _unknownFields;

	private string service_ = "";

	private string api_ = "";

	private string meth_ = "";

	private string headers_ = "";

	private string compress_ = "";

	private ByteString data_ = ByteString.Empty;

	public static MessageParser<ReportEventItem> Parser => _parser;

	public string Service
	{
		get
		{
			return service_;
		}
		set
		{
			service_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Api
	{
		get
		{
			return api_;
		}
		set
		{
			api_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Meth
	{
		get
		{
			return meth_;
		}
		set
		{
			meth_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Headers
	{
		get
		{
			return headers_;
		}
		set
		{
			headers_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Compress
	{
		get
		{
			return compress_;
		}
		set
		{
			compress_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ByteString Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventItem()
	{
	}

	public ReportEventItem(ReportEventItem other)
		: this()
	{
		service_ = other.service_;
		api_ = other.api_;
		meth_ = other.meth_;
		headers_ = other.headers_;
		compress_ = other.compress_;
		data_ = other.data_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventItem Clone()
	{
		return new ReportEventItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventItem);
	}

	public bool Equals(ReportEventItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Service != other.Service)
		{
			return false;
		}
		if (Api != other.Api)
		{
			return false;
		}
		if (Meth != other.Meth)
		{
			return false;
		}
		if (Headers != other.Headers)
		{
			return false;
		}
		if (Compress != other.Compress)
		{
			return false;
		}
		if (Data != other.Data)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Service.Length != 0)
		{
			num ^= Service.GetHashCode();
		}
		if (Api.Length != 0)
		{
			num ^= Api.GetHashCode();
		}
		if (Meth.Length != 0)
		{
			num ^= Meth.GetHashCode();
		}
		if (Headers.Length != 0)
		{
			num ^= Headers.GetHashCode();
		}
		if (Compress.Length != 0)
		{
			num ^= Compress.GetHashCode();
		}
		if (Data.Length != 0)
		{
			num ^= Data.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Service.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Service);
		}
		if (Api.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Api);
		}
		if (Meth.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Meth);
		}
		if (Headers.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Headers);
		}
		if (Compress.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Compress);
		}
		if (Data.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteBytes(Data);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Service.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Service);
		}
		if (Api.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Api);
		}
		if (Meth.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Meth);
		}
		if (Headers.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Headers);
		}
		if (Compress.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Compress);
		}
		if (Data.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Data);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventItem other)
	{
		if (other != null)
		{
			if (other.Service.Length != 0)
			{
				Service = other.Service;
			}
			if (other.Api.Length != 0)
			{
				Api = other.Api;
			}
			if (other.Meth.Length != 0)
			{
				Meth = other.Meth;
			}
			if (other.Headers.Length != 0)
			{
				Headers = other.Headers;
			}
			if (other.Compress.Length != 0)
			{
				Compress = other.Compress;
			}
			if (other.Data.Length != 0)
			{
				Data = other.Data;
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
				Service = input.ReadString();
				break;
			case 18u:
				Api = input.ReadString();
				break;
			case 26u:
				Meth = input.ReadString();
				break;
			case 34u:
				Headers = input.ReadString();
				break;
			case 42u:
				Compress = input.ReadString();
				break;
			case 50u:
				Data = input.ReadBytes();
				break;
			}
		}
	}
}
