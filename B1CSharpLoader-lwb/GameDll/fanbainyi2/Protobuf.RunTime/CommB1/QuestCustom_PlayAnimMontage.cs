using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_PlayAnimMontage : IMessage<QuestCustom_PlayAnimMontage>, IMessage, IEquatable<QuestCustom_PlayAnimMontage>, IDeepCloneable<QuestCustom_PlayAnimMontage>
{
	private static readonly MessageParser<QuestCustom_PlayAnimMontage> _parser = new MessageParser<QuestCustom_PlayAnimMontage>(() => new QuestCustom_PlayAnimMontage());

	private UnknownFieldSet _unknownFields;

	private string casterGuid_ = "";

	private string amPath_ = "";

	public static MessageParser<QuestCustom_PlayAnimMontage> Parser => _parser;

	public string CasterGuid
	{
		get
		{
			return casterGuid_;
		}
		set
		{
			casterGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AmPath
	{
		get
		{
			return amPath_;
		}
		set
		{
			amPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_PlayAnimMontage()
	{
	}

	public QuestCustom_PlayAnimMontage(QuestCustom_PlayAnimMontage other)
		: this()
	{
		casterGuid_ = other.casterGuid_;
		amPath_ = other.amPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayAnimMontage Clone()
	{
		return new QuestCustom_PlayAnimMontage(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayAnimMontage);
	}

	public bool Equals(QuestCustom_PlayAnimMontage other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CasterGuid != other.CasterGuid)
		{
			return false;
		}
		if (AmPath != other.AmPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CasterGuid.Length != 0)
		{
			num ^= CasterGuid.GetHashCode();
		}
		if (AmPath.Length != 0)
		{
			num ^= AmPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CasterGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(CasterGuid);
		}
		if (AmPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AmPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CasterGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CasterGuid);
		}
		if (AmPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AmPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PlayAnimMontage other)
	{
		if (other != null)
		{
			if (other.CasterGuid.Length != 0)
			{
				CasterGuid = other.CasterGuid;
			}
			if (other.AmPath.Length != 0)
			{
				AmPath = other.AmPath;
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
				CasterGuid = input.ReadString();
				break;
			case 18u:
				AmPath = input.ReadString();
				break;
			}
		}
	}
}
