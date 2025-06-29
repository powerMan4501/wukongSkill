using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventCommValueChange : IMessage<ReportEventCommValueChange>, IMessage, IEquatable<ReportEventCommValueChange>, IDeepCloneable<ReportEventCommValueChange>
{
	private static readonly MessageParser<ReportEventCommValueChange> _parser = new MessageParser<ReportEventCommValueChange>(() => new ReportEventCommValueChange());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private int opReason_;

	private static readonly FieldCodec<CommValueChange> _repeated_changeList_codec = FieldCodec.ForMessage(26u, CommValueChange.Parser);

	private readonly RepeatedField<CommValueChange> changeList_ = new RepeatedField<CommValueChange>();

	public static MessageParser<ReportEventCommValueChange> Parser => _parser;

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

	public int OpReason
	{
		get
		{
			return opReason_;
		}
		set
		{
			opReason_ = value;
		}
	}

	public RepeatedField<CommValueChange> ChangeList => changeList_;

	public ReportEventCommValueChange()
	{
	}

	public ReportEventCommValueChange(ReportEventCommValueChange other)
		: this()
	{
		roleId_ = other.roleId_;
		opReason_ = other.opReason_;
		changeList_ = other.changeList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventCommValueChange Clone()
	{
		return new ReportEventCommValueChange(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventCommValueChange);
	}

	public bool Equals(ReportEventCommValueChange other)
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
		if (OpReason != other.OpReason)
		{
			return false;
		}
		if (!changeList_.Equals(other.changeList_))
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
		if (OpReason != 0)
		{
			num ^= OpReason.GetHashCode();
		}
		num ^= changeList_.GetHashCode();
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
		if (OpReason != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OpReason);
		}
		changeList_.WriteTo(output, _repeated_changeList_codec);
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
		if (OpReason != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OpReason);
		}
		num += changeList_.CalculateSize(_repeated_changeList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventCommValueChange other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.OpReason != 0)
			{
				OpReason = other.OpReason;
			}
			changeList_.Add(other.changeList_);
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
				OpReason = input.ReadInt32();
				break;
			case 26u:
				changeList_.AddEntriesFrom(input, _repeated_changeList_codec);
				break;
			}
		}
	}
}
