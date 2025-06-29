using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class AchievementStat : IMessage<AchievementStat>, IMessage, IEquatable<AchievementStat>, IDeepCloneable<AchievementStat>
{
	private static readonly MessageParser<AchievementStat> _parser = new MessageParser<AchievementStat>(() => new AchievementStat());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<int> _repeated_equipIdList_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> equipIdList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_spellIdList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> spellIdList_ = new RepeatedField<int>();

	private static readonly FieldCodec<ItemStat> _repeated_itemList_codec = FieldCodec.ForMessage(26u, ItemStat.Parser);

	private readonly RepeatedField<ItemStat> itemList_ = new RepeatedField<ItemStat>();

	public static MessageParser<AchievementStat> Parser => _parser;

	public RepeatedField<int> EquipIdList => equipIdList_;

	public RepeatedField<int> SpellIdList => spellIdList_;

	public RepeatedField<ItemStat> ItemList => itemList_;

	public AchievementStat()
	{
	}

	public AchievementStat(AchievementStat other)
		: this()
	{
		equipIdList_ = other.equipIdList_.Clone();
		spellIdList_ = other.spellIdList_.Clone();
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementStat Clone()
	{
		return new AchievementStat(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementStat);
	}

	public bool Equals(AchievementStat other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!equipIdList_.Equals(other.equipIdList_))
		{
			return false;
		}
		if (!spellIdList_.Equals(other.spellIdList_))
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= equipIdList_.GetHashCode();
		num ^= spellIdList_.GetHashCode();
		num ^= itemList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		equipIdList_.WriteTo(output, _repeated_equipIdList_codec);
		spellIdList_.WriteTo(output, _repeated_spellIdList_codec);
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += equipIdList_.CalculateSize(_repeated_equipIdList_codec);
		num += spellIdList_.CalculateSize(_repeated_spellIdList_codec);
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementStat other)
	{
		if (other != null)
		{
			equipIdList_.Add(other.equipIdList_);
			spellIdList_.Add(other.spellIdList_);
			itemList_.Add(other.itemList_);
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
			case 10u:
				equipIdList_.AddEntriesFrom(input, _repeated_equipIdList_codec);
				break;
			case 16u:
			case 18u:
				spellIdList_.AddEntriesFrom(input, _repeated_spellIdList_codec);
				break;
			case 26u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			}
		}
	}
}
