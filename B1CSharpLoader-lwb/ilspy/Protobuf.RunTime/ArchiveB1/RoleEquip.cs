using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleEquip : IMessage<RoleEquip>, IMessage, IEquatable<RoleEquip>, IDeepCloneable<RoleEquip>
{
	private static readonly MessageParser<RoleEquip> _parser = new MessageParser<RoleEquip>(() => new RoleEquip());

	private UnknownFieldSet _unknownFields;

	private int equipId_;

	private ulong uid_;

	private static readonly FieldCodec<int> _repeated_historyIdList_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> historyIdList_ = new RepeatedField<int>();

	public static MessageParser<RoleEquip> Parser => _parser;

	public int EquipId
	{
		get
		{
			return equipId_;
		}
		set
		{
			equipId_ = value;
		}
	}

	public ulong Uid
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

	public RepeatedField<int> HistoryIdList => historyIdList_;

	public RoleEquip()
	{
	}

	public RoleEquip(RoleEquip other)
		: this()
	{
		equipId_ = other.equipId_;
		uid_ = other.uid_;
		historyIdList_ = other.historyIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleEquip Clone()
	{
		return new RoleEquip(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleEquip);
	}

	public bool Equals(RoleEquip other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EquipId != other.EquipId)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (!historyIdList_.Equals(other.historyIdList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EquipId != 0)
		{
			num ^= EquipId.GetHashCode();
		}
		if (Uid != 0L)
		{
			num ^= Uid.GetHashCode();
		}
		num ^= historyIdList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EquipId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EquipId);
		}
		if (Uid != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(Uid);
		}
		historyIdList_.WriteTo(output, _repeated_historyIdList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EquipId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EquipId);
		}
		if (Uid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Uid);
		}
		num += historyIdList_.CalculateSize(_repeated_historyIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleEquip other)
	{
		if (other != null)
		{
			if (other.EquipId != 0)
			{
				EquipId = other.EquipId;
			}
			if (other.Uid != 0L)
			{
				Uid = other.Uid;
			}
			historyIdList_.Add(other.historyIdList_);
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
				EquipId = input.ReadInt32();
				break;
			case 32u:
				Uid = input.ReadUInt64();
				break;
			case 40u:
			case 42u:
				historyIdList_.AddEntriesFrom(input, _repeated_historyIdList_codec);
				break;
			}
		}
	}
}
