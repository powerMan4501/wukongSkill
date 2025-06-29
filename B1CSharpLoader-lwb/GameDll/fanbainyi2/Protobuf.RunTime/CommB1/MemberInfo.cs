using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MemberInfo : IMessage<MemberInfo>, IMessage, IEquatable<MemberInfo>, IDeepCloneable<MemberInfo>
{
	private static readonly MessageParser<MemberInfo> _parser = new MessageParser<MemberInfo>(() => new MemberInfo());

	private UnknownFieldSet _unknownFields;

	private ulong memberId_;

	private string memberName_ = "";

	private int level_;

	public static MessageParser<MemberInfo> Parser => _parser;

	public ulong MemberId
	{
		get
		{
			return memberId_;
		}
		set
		{
			memberId_ = value;
		}
	}

	public string MemberName
	{
		get
		{
			return memberName_;
		}
		set
		{
			memberName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public MemberInfo()
	{
	}

	public MemberInfo(MemberInfo other)
		: this()
	{
		memberId_ = other.memberId_;
		memberName_ = other.memberName_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MemberInfo Clone()
	{
		return new MemberInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MemberInfo);
	}

	public bool Equals(MemberInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MemberId != other.MemberId)
		{
			return false;
		}
		if (MemberName != other.MemberName)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MemberId != 0L)
		{
			num ^= MemberId.GetHashCode();
		}
		if (MemberName.Length != 0)
		{
			num ^= MemberName.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MemberId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(MemberId);
		}
		if (MemberName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MemberName);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Level);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MemberId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MemberId);
		}
		if (MemberName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MemberName);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MemberInfo other)
	{
		if (other != null)
		{
			if (other.MemberId != 0L)
			{
				MemberId = other.MemberId;
			}
			if (other.MemberName.Length != 0)
			{
				MemberName = other.MemberName;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
				MemberId = input.ReadUInt64();
				break;
			case 18u:
				MemberName = input.ReadString();
				break;
			case 24u:
				Level = input.ReadInt32();
				break;
			}
		}
	}
}
