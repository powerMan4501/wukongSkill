using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportRoleCommMisc : IMessage<ReportRoleCommMisc>, IMessage, IEquatable<ReportRoleCommMisc>, IDeepCloneable<ReportRoleCommMisc>
{
	private static readonly MessageParser<ReportRoleCommMisc> _parser = new MessageParser<ReportRoleCommMisc>(() => new ReportRoleCommMisc());

	private UnknownFieldSet _unknownFields;

	private string errFlag_ = "";

	private int errType_;

	public static MessageParser<ReportRoleCommMisc> Parser => _parser;

	public string ErrFlag
	{
		get
		{
			return errFlag_;
		}
		set
		{
			errFlag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ErrType
	{
		get
		{
			return errType_;
		}
		set
		{
			errType_ = value;
		}
	}

	public ReportRoleCommMisc()
	{
	}

	public ReportRoleCommMisc(ReportRoleCommMisc other)
		: this()
	{
		errFlag_ = other.errFlag_;
		errType_ = other.errType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportRoleCommMisc Clone()
	{
		return new ReportRoleCommMisc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportRoleCommMisc);
	}

	public bool Equals(ReportRoleCommMisc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ErrFlag != other.ErrFlag)
		{
			return false;
		}
		if (ErrType != other.ErrType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ErrFlag.Length != 0)
		{
			num ^= ErrFlag.GetHashCode();
		}
		if (ErrType != 0)
		{
			num ^= ErrType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ErrFlag.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ErrFlag);
		}
		if (ErrType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ErrType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ErrFlag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ErrFlag);
		}
		if (ErrType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ErrType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportRoleCommMisc other)
	{
		if (other != null)
		{
			if (other.ErrFlag.Length != 0)
			{
				ErrFlag = other.ErrFlag;
			}
			if (other.ErrType != 0)
			{
				ErrType = other.ErrType;
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
				ErrFlag = input.ReadString();
				break;
			case 16u:
				ErrType = input.ReadInt32();
				break;
			}
		}
	}
}
