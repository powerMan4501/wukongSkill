using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class PartyTaskParamSyncWrapper : IMessage<PartyTaskParamSyncWrapper>, IMessage, IEquatable<PartyTaskParamSyncWrapper>, IDeepCloneable<PartyTaskParamSyncWrapper>
{
	private static readonly MessageParser<PartyTaskParamSyncWrapper> _parser = new MessageParser<PartyTaskParamSyncWrapper>(() => new PartyTaskParamSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper levelId_;

	public static MessageParser<PartyTaskParamSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public Int32SyncWrapper LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public PartyTaskParamSyncWrapper()
	{
	}

	public PartyTaskParamSyncWrapper(PartyTaskParamSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		levelId_ = ((other.levelId_ != null) ? other.levelId_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyTaskParamSyncWrapper Clone()
	{
		return new PartyTaskParamSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyTaskParamSyncWrapper);
	}

	public bool Equals(PartyTaskParamSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(LevelId, other.LevelId))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (levelId_ != null)
		{
			num ^= LevelId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (levelId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LevelId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (levelId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LevelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyTaskParamSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.levelId_ != null)
		{
			if (levelId_ == null)
			{
				LevelId = new Int32SyncWrapper();
			}
			LevelId.MergeFrom(other.LevelId);
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
			case 8u:
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (levelId_ == null)
				{
					LevelId = new Int32SyncWrapper();
				}
				input.ReadMessage(LevelId);
				break;
			}
		}
	}
}
