using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DirReportReq : IMessage<DirReportReq>, IMessage, IEquatable<DirReportReq>, IDeepCloneable<DirReportReq>
{
	private static readonly MessageParser<DirReportReq> _parser = new MessageParser<DirReportReq>(() => new DirReportReq());

	private UnknownFieldSet _unknownFields;

	private ServerInfo info_;

	private int ompReport_;

	public static MessageParser<DirReportReq> Parser => _parser;

	public ServerInfo Info
	{
		get
		{
			return info_;
		}
		set
		{
			info_ = value;
		}
	}

	public int OmpReport
	{
		get
		{
			return ompReport_;
		}
		set
		{
			ompReport_ = value;
		}
	}

	public DirReportReq()
	{
	}

	public DirReportReq(DirReportReq other)
		: this()
	{
		info_ = ((other.info_ != null) ? other.info_.Clone() : null);
		ompReport_ = other.ompReport_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DirReportReq Clone()
	{
		return new DirReportReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DirReportReq);
	}

	public bool Equals(DirReportReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Info, other.Info))
		{
			return false;
		}
		if (OmpReport != other.OmpReport)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (info_ != null)
		{
			num ^= Info.GetHashCode();
		}
		if (OmpReport != 0)
		{
			num ^= OmpReport.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (info_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Info);
		}
		if (OmpReport != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OmpReport);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (info_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Info);
		}
		if (OmpReport != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OmpReport);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DirReportReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.info_ != null)
		{
			if (info_ == null)
			{
				Info = new ServerInfo();
			}
			Info.MergeFrom(other.Info);
		}
		if (other.OmpReport != 0)
		{
			OmpReport = other.OmpReport;
		}
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
				if (info_ == null)
				{
					Info = new ServerInfo();
				}
				input.ReadMessage(Info);
				break;
			case 16u:
				OmpReport = input.ReadInt32();
				break;
			}
		}
	}
}
