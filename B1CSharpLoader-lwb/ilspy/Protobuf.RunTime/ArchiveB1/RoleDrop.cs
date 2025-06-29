using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleDrop : IMessage<RoleDrop>, IMessage, IEquatable<RoleDrop>, IDeepCloneable<RoleDrop>
{
	private static readonly MessageParser<RoleDrop> _parser = new MessageParser<RoleDrop>(() => new RoleDrop());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DropRecord> _repeated_dropRecordList_codec = FieldCodec.ForMessage(18u, DropRecord.Parser);

	private readonly RepeatedField<DropRecord> dropRecordList_ = new RepeatedField<DropRecord>();

	private static readonly FieldCodec<SoulSkillDropRecord> _repeated_soulSkillDropList_codec = FieldCodec.ForMessage(26u, SoulSkillDropRecord.Parser);

	private readonly RepeatedField<SoulSkillDropRecord> soulSkillDropList_ = new RepeatedField<SoulSkillDropRecord>();

	public static MessageParser<RoleDrop> Parser => _parser;

	public RepeatedField<DropRecord> DropRecordList => dropRecordList_;

	public RepeatedField<SoulSkillDropRecord> SoulSkillDropList => soulSkillDropList_;

	public RoleDrop()
	{
	}

	public RoleDrop(RoleDrop other)
		: this()
	{
		dropRecordList_ = other.dropRecordList_.Clone();
		soulSkillDropList_ = other.soulSkillDropList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDrop Clone()
	{
		return new RoleDrop(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDrop);
	}

	public bool Equals(RoleDrop other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dropRecordList_.Equals(other.dropRecordList_))
		{
			return false;
		}
		if (!soulSkillDropList_.Equals(other.soulSkillDropList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= dropRecordList_.GetHashCode();
		num ^= soulSkillDropList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		dropRecordList_.WriteTo(output, _repeated_dropRecordList_codec);
		soulSkillDropList_.WriteTo(output, _repeated_soulSkillDropList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += dropRecordList_.CalculateSize(_repeated_dropRecordList_codec);
		num += soulSkillDropList_.CalculateSize(_repeated_soulSkillDropList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDrop other)
	{
		if (other != null)
		{
			dropRecordList_.Add(other.dropRecordList_);
			soulSkillDropList_.Add(other.soulSkillDropList_);
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
			case 18u:
				dropRecordList_.AddEntriesFrom(input, _repeated_dropRecordList_codec);
				break;
			case 26u:
				soulSkillDropList_.AddEntriesFrom(input, _repeated_soulSkillDropList_codec);
				break;
			}
		}
	}
}
