using System;
using ArchiveB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class MemberRoleDataSyncWrapper : IMessage<MemberRoleDataSyncWrapper>, IMessage, IEquatable<MemberRoleDataSyncWrapper>, IDeepCloneable<MemberRoleDataSyncWrapper>
{
	private static readonly MessageParser<MemberRoleDataSyncWrapper> _parser = new MessageParser<MemberRoleDataSyncWrapper>(() => new MemberRoleDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<WearEquipSyncWrapper> _repeated_equipList_codec = FieldCodec.ForMessage(26u, WearEquipSyncWrapper.Parser);

	private readonly RepeatedField<WearEquipSyncWrapper> equipList_ = new RepeatedField<WearEquipSyncWrapper>();

	private Int32SyncWrapper level_;

	private StringSyncWrapper memberName_;

	public static MessageParser<MemberRoleDataSyncWrapper> Parser => _parser;

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

	public RepeatedField<WearEquipSyncWrapper> EquipList => equipList_;

	public Int32SyncWrapper Level
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

	public StringSyncWrapper MemberName
	{
		get
		{
			return memberName_;
		}
		set
		{
			memberName_ = value;
		}
	}

	public MemberRoleDataSyncWrapper()
	{
	}

	public MemberRoleDataSyncWrapper(MemberRoleDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		equipList_ = other.equipList_.Clone();
		level_ = ((other.level_ != null) ? other.level_.Clone() : null);
		memberName_ = ((other.memberName_ != null) ? other.memberName_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MemberRoleDataSyncWrapper Clone()
	{
		return new MemberRoleDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MemberRoleDataSyncWrapper);
	}

	public bool Equals(MemberRoleDataSyncWrapper other)
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
		if (!equipList_.Equals(other.equipList_))
		{
			return false;
		}
		if (!object.Equals(Level, other.Level))
		{
			return false;
		}
		if (!object.Equals(MemberName, other.MemberName))
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
		num ^= equipList_.GetHashCode();
		if (level_ != null)
		{
			num ^= Level.GetHashCode();
		}
		if (memberName_ != null)
		{
			num ^= MemberName.GetHashCode();
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
		equipList_.WriteTo(output, _repeated_equipList_codec);
		if (level_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Level);
		}
		if (memberName_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MemberName);
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
		num += equipList_.CalculateSize(_repeated_equipList_codec);
		if (level_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Level);
		}
		if (memberName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MemberName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MemberRoleDataSyncWrapper other)
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
		equipList_.Add(other.equipList_);
		if (other.level_ != null)
		{
			if (level_ == null)
			{
				Level = new Int32SyncWrapper();
			}
			Level.MergeFrom(other.Level);
		}
		if (other.memberName_ != null)
		{
			if (memberName_ == null)
			{
				MemberName = new StringSyncWrapper();
			}
			MemberName.MergeFrom(other.MemberName);
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
				equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
				break;
			case 34u:
				if (level_ == null)
				{
					Level = new Int32SyncWrapper();
				}
				input.ReadMessage(Level);
				break;
			case 42u:
				if (memberName_ == null)
				{
					MemberName = new StringSyncWrapper();
				}
				input.ReadMessage(MemberName);
				break;
			}
		}
	}
}
