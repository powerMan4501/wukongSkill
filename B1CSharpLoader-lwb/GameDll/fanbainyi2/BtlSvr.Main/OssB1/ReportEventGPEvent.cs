using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventGPEvent : IMessage<ReportEventGPEvent>, IMessage, IEquatable<ReportEventGPEvent>, IDeepCloneable<ReportEventGPEvent>
{
	private static readonly MessageParser<ReportEventGPEvent> _parser = new MessageParser<ReportEventGPEvent>(() => new ReportEventGPEvent());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private int isSuccess_;

	private int peLevel_;

	private int isInBattle_;

	public static MessageParser<ReportEventGPEvent> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public int IsSuccess
	{
		get
		{
			return isSuccess_;
		}
		set
		{
			isSuccess_ = value;
		}
	}

	public int PeLevel
	{
		get
		{
			return peLevel_;
		}
		set
		{
			peLevel_ = value;
		}
	}

	public int IsInBattle
	{
		get
		{
			return isInBattle_;
		}
		set
		{
			isInBattle_ = value;
		}
	}

	public ReportEventGPEvent()
	{
	}

	public ReportEventGPEvent(ReportEventGPEvent other)
		: this()
	{
		roleId_ = other.roleId_;
		isSuccess_ = other.isSuccess_;
		peLevel_ = other.peLevel_;
		isInBattle_ = other.isInBattle_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventGPEvent Clone()
	{
		return new ReportEventGPEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventGPEvent);
	}

	public bool Equals(ReportEventGPEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (IsSuccess != other.IsSuccess)
		{
			return false;
		}
		if (PeLevel != other.PeLevel)
		{
			return false;
		}
		if (IsInBattle != other.IsInBattle)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (IsSuccess != 0)
		{
			num ^= IsSuccess.GetHashCode();
		}
		if (PeLevel != 0)
		{
			num ^= PeLevel.GetHashCode();
		}
		if (IsInBattle != 0)
		{
			num ^= IsInBattle.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		if (IsSuccess != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(IsSuccess);
		}
		if (PeLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PeLevel);
		}
		if (IsInBattle != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(IsInBattle);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (IsSuccess != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsSuccess);
		}
		if (PeLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PeLevel);
		}
		if (IsInBattle != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsInBattle);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventGPEvent other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.IsSuccess != 0)
			{
				IsSuccess = other.IsSuccess;
			}
			if (other.PeLevel != 0)
			{
				PeLevel = other.PeLevel;
			}
			if (other.IsInBattle != 0)
			{
				IsInBattle = other.IsInBattle;
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
				RoleId = input.ReadUInt64();
				break;
			case 16u:
				IsSuccess = input.ReadInt32();
				break;
			case 24u:
				PeLevel = input.ReadInt32();
				break;
			case 32u:
				IsInBattle = input.ReadInt32();
				break;
			}
		}
	}
}
