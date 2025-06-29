using System;
using BtlB1;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class WearEquipSyncWrapper : IMessage<WearEquipSyncWrapper>, IMessage, IEquatable<WearEquipSyncWrapper>, IDeepCloneable<WearEquipSyncWrapper>
{
	private static readonly MessageParser<WearEquipSyncWrapper> _parser = new MessageParser<WearEquipSyncWrapper>(() => new WearEquipSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper id_;

	private EquipPositionSyncWrapper position_;

	private Uint64SyncWrapper uid_;

	public static MessageParser<WearEquipSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper Id
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

	public EquipPositionSyncWrapper Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	public Uint64SyncWrapper Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	public WearEquipSyncWrapper()
	{
	}

	public WearEquipSyncWrapper(WearEquipSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		id_ = ((other.id_ != null) ? other.id_.Clone() : null);
		position_ = ((other.position_ != null) ? other.position_.Clone() : null);
		uid_ = ((other.uid_ != null) ? other.uid_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WearEquipSyncWrapper Clone()
	{
		return new WearEquipSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WearEquipSyncWrapper);
	}

	public bool Equals(WearEquipSyncWrapper other)
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
		if (!object.Equals(Id, other.Id))
		{
			return false;
		}
		if (!object.Equals(Position, other.Position))
		{
			return false;
		}
		if (!object.Equals(Uid, other.Uid))
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
		if (id_ != null)
		{
			num ^= Id.GetHashCode();
		}
		if (position_ != null)
		{
			num ^= Position.GetHashCode();
		}
		if (uid_ != null)
		{
			num ^= Uid.GetHashCode();
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
		if (id_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Id);
		}
		if (position_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Position);
		}
		if (uid_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Uid);
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
		if (id_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Id);
		}
		if (position_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Position);
		}
		if (uid_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WearEquipSyncWrapper other)
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
		if (other.id_ != null)
		{
			if (id_ == null)
			{
				Id = new Int32SyncWrapper();
			}
			Id.MergeFrom(other.Id);
		}
		if (other.position_ != null)
		{
			if (position_ == null)
			{
				Position = new EquipPositionSyncWrapper();
			}
			Position.MergeFrom(other.Position);
		}
		if (other.uid_ != null)
		{
			if (uid_ == null)
			{
				Uid = new Uint64SyncWrapper();
			}
			Uid.MergeFrom(other.Uid);
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
				if (id_ == null)
				{
					Id = new Int32SyncWrapper();
				}
				input.ReadMessage(Id);
				break;
			case 34u:
				if (position_ == null)
				{
					Position = new EquipPositionSyncWrapper();
				}
				input.ReadMessage(Position);
				break;
			case 42u:
				if (uid_ == null)
				{
					Uid = new Uint64SyncWrapper();
				}
				input.ReadMessage(Uid);
				break;
			}
		}
	}
}
