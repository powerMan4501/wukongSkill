using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleDataClientSyncWrapper : IMessage<RoleDataClientSyncWrapper>, IMessage, IEquatable<RoleDataClientSyncWrapper>, IDeepCloneable<RoleDataClientSyncWrapper>
{
	private static readonly MessageParser<RoleDataClientSyncWrapper> _parser = new MessageParser<RoleDataClientSyncWrapper>(() => new RoleDataClientSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private RoleStaticsDataSyncWrapper staticsData_;

	public static MessageParser<RoleDataClientSyncWrapper> Parser => _parser;

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

	public RoleStaticsDataSyncWrapper StaticsData
	{
		get
		{
			return staticsData_;
		}
		set
		{
			staticsData_ = value;
		}
	}

	public RoleDataClientSyncWrapper()
	{
	}

	public RoleDataClientSyncWrapper(RoleDataClientSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		staticsData_ = ((other.staticsData_ != null) ? other.staticsData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataClientSyncWrapper Clone()
	{
		return new RoleDataClientSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataClientSyncWrapper);
	}

	public bool Equals(RoleDataClientSyncWrapper other)
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
		if (!object.Equals(StaticsData, other.StaticsData))
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
		if (staticsData_ != null)
		{
			num ^= StaticsData.GetHashCode();
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
		if (staticsData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(StaticsData);
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
		if (staticsData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StaticsData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDataClientSyncWrapper other)
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
		if (other.staticsData_ != null)
		{
			if (staticsData_ == null)
			{
				StaticsData = new RoleStaticsDataSyncWrapper();
			}
			StaticsData.MergeFrom(other.StaticsData);
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
				if (staticsData_ == null)
				{
					StaticsData = new RoleStaticsDataSyncWrapper();
				}
				input.ReadMessage(StaticsData);
				break;
			}
		}
	}
}
