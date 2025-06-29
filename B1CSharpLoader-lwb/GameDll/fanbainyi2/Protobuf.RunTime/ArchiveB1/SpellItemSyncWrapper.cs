using System;
using BtlB1;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class SpellItemSyncWrapper : IMessage<SpellItemSyncWrapper>, IMessage, IEquatable<SpellItemSyncWrapper>, IDeepCloneable<SpellItemSyncWrapper>
{
	private static readonly MessageParser<SpellItemSyncWrapper> _parser = new MessageParser<SpellItemSyncWrapper>(() => new SpellItemSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private SpellTypeSyncWrapper type_;

	private Int32SyncWrapper spellId_;

	public static MessageParser<SpellItemSyncWrapper> Parser => _parser;

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

	public SpellTypeSyncWrapper Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public Int32SyncWrapper SpellId
	{
		get
		{
			return spellId_;
		}
		set
		{
			spellId_ = value;
		}
	}

	public SpellItemSyncWrapper()
	{
	}

	public SpellItemSyncWrapper(SpellItemSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		type_ = ((other.type_ != null) ? other.type_.Clone() : null);
		spellId_ = ((other.spellId_ != null) ? other.spellId_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SpellItemSyncWrapper Clone()
	{
		return new SpellItemSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SpellItemSyncWrapper);
	}

	public bool Equals(SpellItemSyncWrapper other)
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
		if (!object.Equals(Type, other.Type))
		{
			return false;
		}
		if (!object.Equals(SpellId, other.SpellId))
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
		if (type_ != null)
		{
			num ^= Type.GetHashCode();
		}
		if (spellId_ != null)
		{
			num ^= SpellId.GetHashCode();
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
		if (type_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Type);
		}
		if (spellId_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(SpellId);
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
		if (type_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Type);
		}
		if (spellId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SpellId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SpellItemSyncWrapper other)
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
		if (other.type_ != null)
		{
			if (type_ == null)
			{
				Type = new SpellTypeSyncWrapper();
			}
			Type.MergeFrom(other.Type);
		}
		if (other.spellId_ != null)
		{
			if (spellId_ == null)
			{
				SpellId = new Int32SyncWrapper();
			}
			SpellId.MergeFrom(other.SpellId);
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
				if (type_ == null)
				{
					Type = new SpellTypeSyncWrapper();
				}
				input.ReadMessage(Type);
				break;
			case 34u:
				if (spellId_ == null)
				{
					SpellId = new Int32SyncWrapper();
				}
				input.ReadMessage(SpellId);
				break;
			}
		}
	}
}
