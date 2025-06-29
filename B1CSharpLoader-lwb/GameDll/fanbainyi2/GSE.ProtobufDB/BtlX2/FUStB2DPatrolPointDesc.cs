using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class FUStB2DPatrolPointDesc : IMessage<FUStB2DPatrolPointDesc>, IMessage, IEquatable<FUStB2DPatrolPointDesc>, IDeepCloneable<FUStB2DPatrolPointDesc>
{
	private static readonly MessageParser<FUStB2DPatrolPointDesc> _parser = new MessageParser<FUStB2DPatrolPointDesc>(() => new FUStB2DPatrolPointDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int stageId_;

	private int groupId_;

	private int wpIdx_;

	private int wpX_;

	private int wpY_;

	public static MessageParser<FUStB2DPatrolPointDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	public int WpIdx
	{
		get
		{
			return wpIdx_;
		}
		set
		{
			wpIdx_ = value;
		}
	}

	public int WpX
	{
		get
		{
			return wpX_;
		}
		set
		{
			wpX_ = value;
		}
	}

	public int WpY
	{
		get
		{
			return wpY_;
		}
		set
		{
			wpY_ = value;
		}
	}

	public FUStB2DPatrolPointDesc()
	{
	}

	public FUStB2DPatrolPointDesc(FUStB2DPatrolPointDesc other)
		: this()
	{
		id_ = other.id_;
		stageId_ = other.stageId_;
		groupId_ = other.groupId_;
		wpIdx_ = other.wpIdx_;
		wpX_ = other.wpX_;
		wpY_ = other.wpY_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DPatrolPointDesc Clone()
	{
		return new FUStB2DPatrolPointDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DPatrolPointDesc);
	}

	public bool Equals(FUStB2DPatrolPointDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (WpIdx != other.WpIdx)
		{
			return false;
		}
		if (WpX != other.WpX)
		{
			return false;
		}
		if (WpY != other.WpY)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (WpIdx != 0)
		{
			num ^= WpIdx.GetHashCode();
		}
		if (WpX != 0)
		{
			num ^= WpX.GetHashCode();
		}
		if (WpY != 0)
		{
			num ^= WpY.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(StageId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupId);
		}
		if (WpIdx != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(WpIdx);
		}
		if (WpX != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(WpX);
		}
		if (WpY != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(WpY);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StageId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (WpIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WpIdx);
		}
		if (WpX != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WpX);
		}
		if (WpY != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WpY);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DPatrolPointDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.WpIdx != 0)
			{
				WpIdx = other.WpIdx;
			}
			if (other.WpX != 0)
			{
				WpX = other.WpX;
			}
			if (other.WpY != 0)
			{
				WpY = other.WpY;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				StageId = input.ReadInt32();
				break;
			case 24u:
				GroupId = input.ReadInt32();
				break;
			case 32u:
				WpIdx = input.ReadInt32();
				break;
			case 40u:
				WpX = input.ReadInt32();
				break;
			case 48u:
				WpY = input.ReadInt32();
				break;
			}
		}
	}
}
