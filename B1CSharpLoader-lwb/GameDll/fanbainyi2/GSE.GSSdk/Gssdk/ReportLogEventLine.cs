using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportLogEventLine : IMessage<ReportLogEventLine>, IMessage, IEquatable<ReportLogEventLine>, IDeepCloneable<ReportLogEventLine>
{
	private static readonly MessageParser<ReportLogEventLine> _parser = new MessageParser<ReportLogEventLine>(() => new ReportLogEventLine());

	private UnknownFieldSet _unknownFields;

	private uint timestamp_;

	private uint frame_;

	private uint sequence_;

	private string tag_ = "";

	private string msgStr_ = "";

	private string associateFileUuid_ = "";

	public static MessageParser<ReportLogEventLine> Parser => _parser;

	public uint Timestamp
	{
		get
		{
			return timestamp_;
		}
		set
		{
			timestamp_ = value;
		}
	}

	public uint Frame
	{
		get
		{
			return frame_;
		}
		set
		{
			frame_ = value;
		}
	}

	public uint Sequence
	{
		get
		{
			return sequence_;
		}
		set
		{
			sequence_ = value;
		}
	}

	public string Tag
	{
		get
		{
			return tag_;
		}
		set
		{
			tag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MsgStr
	{
		get
		{
			return msgStr_;
		}
		set
		{
			msgStr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AssociateFileUuid
	{
		get
		{
			return associateFileUuid_;
		}
		set
		{
			associateFileUuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportLogEventLine()
	{
	}

	public ReportLogEventLine(ReportLogEventLine other)
		: this()
	{
		timestamp_ = other.timestamp_;
		frame_ = other.frame_;
		sequence_ = other.sequence_;
		tag_ = other.tag_;
		msgStr_ = other.msgStr_;
		associateFileUuid_ = other.associateFileUuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogEventLine Clone()
	{
		return new ReportLogEventLine(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogEventLine);
	}

	public bool Equals(ReportLogEventLine other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Timestamp != other.Timestamp)
		{
			return false;
		}
		if (Frame != other.Frame)
		{
			return false;
		}
		if (Sequence != other.Sequence)
		{
			return false;
		}
		if (Tag != other.Tag)
		{
			return false;
		}
		if (MsgStr != other.MsgStr)
		{
			return false;
		}
		if (AssociateFileUuid != other.AssociateFileUuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Timestamp != 0)
		{
			num ^= Timestamp.GetHashCode();
		}
		if (Frame != 0)
		{
			num ^= Frame.GetHashCode();
		}
		if (Sequence != 0)
		{
			num ^= Sequence.GetHashCode();
		}
		if (Tag.Length != 0)
		{
			num ^= Tag.GetHashCode();
		}
		if (MsgStr.Length != 0)
		{
			num ^= MsgStr.GetHashCode();
		}
		if (AssociateFileUuid.Length != 0)
		{
			num ^= AssociateFileUuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Timestamp != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Timestamp);
		}
		if (Frame != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Frame);
		}
		if (Sequence != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Sequence);
		}
		if (Tag.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Tag);
		}
		if (MsgStr.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(MsgStr);
		}
		if (AssociateFileUuid.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(AssociateFileUuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Timestamp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Timestamp);
		}
		if (Frame != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Frame);
		}
		if (Sequence != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Sequence);
		}
		if (Tag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Tag);
		}
		if (MsgStr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MsgStr);
		}
		if (AssociateFileUuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AssociateFileUuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogEventLine other)
	{
		if (other != null)
		{
			if (other.Timestamp != 0)
			{
				Timestamp = other.Timestamp;
			}
			if (other.Frame != 0)
			{
				Frame = other.Frame;
			}
			if (other.Sequence != 0)
			{
				Sequence = other.Sequence;
			}
			if (other.Tag.Length != 0)
			{
				Tag = other.Tag;
			}
			if (other.MsgStr.Length != 0)
			{
				MsgStr = other.MsgStr;
			}
			if (other.AssociateFileUuid.Length != 0)
			{
				AssociateFileUuid = other.AssociateFileUuid;
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
				Timestamp = input.ReadUInt32();
				break;
			case 16u:
				Frame = input.ReadUInt32();
				break;
			case 24u:
				Sequence = input.ReadUInt32();
				break;
			case 34u:
				Tag = input.ReadString();
				break;
			case 42u:
				MsgStr = input.ReadString();
				break;
			case 50u:
				AssociateFileUuid = input.ReadString();
				break;
			}
		}
	}
}
