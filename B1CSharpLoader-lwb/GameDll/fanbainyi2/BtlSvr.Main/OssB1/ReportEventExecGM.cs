using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventExecGM : IMessage<ReportEventExecGM>, IMessage, IEquatable<ReportEventExecGM>, IDeepCloneable<ReportEventExecGM>
{
	private static readonly MessageParser<ReportEventExecGM> _parser = new MessageParser<ReportEventExecGM>(() => new ReportEventExecGM());

	private UnknownFieldSet _unknownFields;

	private string gmCmd_ = "";

	public static MessageParser<ReportEventExecGM> Parser => _parser;

	public string GmCmd
	{
		get
		{
			return gmCmd_;
		}
		set
		{
			gmCmd_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventExecGM()
	{
	}

	public ReportEventExecGM(ReportEventExecGM other)
		: this()
	{
		gmCmd_ = other.gmCmd_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventExecGM Clone()
	{
		return new ReportEventExecGM(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventExecGM);
	}

	public bool Equals(ReportEventExecGM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GmCmd != other.GmCmd)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GmCmd.Length != 0)
		{
			num ^= GmCmd.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GmCmd.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(GmCmd);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GmCmd.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GmCmd);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventExecGM other)
	{
		if (other != null)
		{
			if (other.GmCmd.Length != 0)
			{
				GmCmd = other.GmCmd;
			}
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
				GmCmd = input.ReadString();
			}
		}
	}
}
