using System;
using ArchiveB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MemberRoleData : IMessage<MemberRoleData>, IMessage, IEquatable<MemberRoleData>, IDeepCloneable<MemberRoleData>
{
	private static readonly MessageParser<MemberRoleData> _parser = new MessageParser<MemberRoleData>(() => new MemberRoleData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<WearEquip> _repeated_equipList_codec = FieldCodec.ForMessage(10u, WearEquip.Parser);

	private readonly RepeatedField<WearEquip> equipList_ = new RepeatedField<WearEquip>();

	private int level_;

	private string memberName_ = "";

	public static MessageParser<MemberRoleData> Parser => _parser;

	public RepeatedField<WearEquip> EquipList => equipList_;

	public int Level
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

	public string MemberName
	{
		get
		{
			return memberName_;
		}
		set
		{
			memberName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public MemberRoleData()
	{
	}

	public MemberRoleData(MemberRoleData other)
		: this()
	{
		equipList_ = other.equipList_.Clone();
		level_ = other.level_;
		memberName_ = other.memberName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MemberRoleData Clone()
	{
		return new MemberRoleData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MemberRoleData);
	}

	public bool Equals(MemberRoleData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!equipList_.Equals(other.equipList_))
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (MemberName != other.MemberName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= equipList_.GetHashCode();
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (MemberName.Length != 0)
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
		equipList_.WriteTo(output, _repeated_equipList_codec);
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Level);
		}
		if (MemberName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(MemberName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += equipList_.CalculateSize(_repeated_equipList_codec);
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (MemberName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MemberName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MemberRoleData other)
	{
		if (other != null)
		{
			equipList_.Add(other.equipList_);
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.MemberName.Length != 0)
			{
				MemberName = other.MemberName;
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
			case 10u:
				equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
				break;
			case 16u:
				Level = input.ReadInt32();
				break;
			case 26u:
				MemberName = input.ReadString();
				break;
			}
		}
	}
}
