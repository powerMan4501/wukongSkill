using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class TaskStageGainItemInfo : IMessage<TaskStageGainItemInfo>, IMessage, IEquatable<TaskStageGainItemInfo>, IDeepCloneable<TaskStageGainItemInfo>
{
	private static readonly MessageParser<TaskStageGainItemInfo> _parser = new MessageParser<TaskStageGainItemInfo>(() => new TaskStageGainItemInfo());

	private UnknownFieldSet _unknownFields;

	private int gainItemID_;

	private int gainItemNum_;

	public static MessageParser<TaskStageGainItemInfo> Parser => _parser;

	public int GainItemID
	{
		get
		{
			return gainItemID_;
		}
		set
		{
			gainItemID_ = value;
		}
	}

	public int GainItemNum
	{
		get
		{
			return gainItemNum_;
		}
		set
		{
			gainItemNum_ = value;
		}
	}

	public TaskStageGainItemInfo()
	{
	}

	public TaskStageGainItemInfo(TaskStageGainItemInfo other)
		: this()
	{
		gainItemID_ = other.gainItemID_;
		gainItemNum_ = other.gainItemNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskStageGainItemInfo Clone()
	{
		return new TaskStageGainItemInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskStageGainItemInfo);
	}

	public bool Equals(TaskStageGainItemInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GainItemID != other.GainItemID)
		{
			return false;
		}
		if (GainItemNum != other.GainItemNum)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GainItemID != 0)
		{
			num ^= GainItemID.GetHashCode();
		}
		if (GainItemNum != 0)
		{
			num ^= GainItemNum.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GainItemID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GainItemID);
		}
		if (GainItemNum != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GainItemNum);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GainItemID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GainItemID);
		}
		if (GainItemNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GainItemNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TaskStageGainItemInfo other)
	{
		if (other != null)
		{
			if (other.GainItemID != 0)
			{
				GainItemID = other.GainItemID;
			}
			if (other.GainItemNum != 0)
			{
				GainItemNum = other.GainItemNum;
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
				GainItemID = input.ReadInt32();
				break;
			case 16u:
				GainItemNum = input.ReadInt32();
				break;
			}
		}
	}
}
