using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class EquipMantraSyncWrapper : IMessage<EquipMantraSyncWrapper>, IMessage, IEquatable<EquipMantraSyncWrapper>, IDeepCloneable<EquipMantraSyncWrapper>
{
	private static readonly MessageParser<EquipMantraSyncWrapper> _parser = new MessageParser<EquipMantraSyncWrapper>(() => new EquipMantraSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper pos_;

	private Int32SyncWrapper mantraId_;

	public static MessageParser<EquipMantraSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	public Int32SyncWrapper MantraId
	{
		get
		{
			return mantraId_;
		}
		set
		{
			mantraId_ = value;
		}
	}

	public EquipMantraSyncWrapper()
	{
	}

	public EquipMantraSyncWrapper(EquipMantraSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
		mantraId_ = ((other.mantraId_ != null) ? other.mantraId_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EquipMantraSyncWrapper Clone()
	{
		return new EquipMantraSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EquipMantraSyncWrapper);
	}

	public bool Equals(EquipMantraSyncWrapper other)
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
		if (!object.Equals(Pos, other.Pos))
		{
			return false;
		}
		if (!object.Equals(MantraId, other.MantraId))
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
		if (pos_ != null)
		{
			num ^= Pos.GetHashCode();
		}
		if (mantraId_ != null)
		{
			num ^= MantraId.GetHashCode();
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
		if (pos_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Pos);
		}
		if (mantraId_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MantraId);
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
		if (pos_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Pos);
		}
		if (mantraId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MantraId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EquipMantraSyncWrapper other)
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
		if (other.pos_ != null)
		{
			if (pos_ == null)
			{
				Pos = new Int32SyncWrapper();
			}
			Pos.MergeFrom(other.Pos);
		}
		if (other.mantraId_ != null)
		{
			if (mantraId_ == null)
			{
				MantraId = new Int32SyncWrapper();
			}
			MantraId.MergeFrom(other.MantraId);
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
				if (pos_ == null)
				{
					Pos = new Int32SyncWrapper();
				}
				input.ReadMessage(Pos);
				break;
			case 34u:
				if (mantraId_ == null)
				{
					MantraId = new Int32SyncWrapper();
				}
				input.ReadMessage(MantraId);
				break;
			}
		}
	}
}
