using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleBag : IMessage<RoleBag>, IMessage, IEquatable<RoleBag>, IDeepCloneable<RoleBag>
{
	private static readonly MessageParser<RoleBag> _parser = new MessageParser<RoleBag>(() => new RoleBag());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<RoleMoney> _repeated_moneyList_codec = FieldCodec.ForMessage(10u, RoleMoney.Parser);

	private readonly RepeatedField<RoleMoney> moneyList_ = new RepeatedField<RoleMoney>();

	private static readonly FieldCodec<RoleItem> _repeated_itemList_codec = FieldCodec.ForMessage(18u, RoleItem.Parser);

	private readonly RepeatedField<RoleItem> itemList_ = new RepeatedField<RoleItem>();

	private static readonly FieldCodec<RoleEquip> _repeated_equipList_codec = FieldCodec.ForMessage(26u, RoleEquip.Parser);

	private readonly RepeatedField<RoleEquip> equipList_ = new RepeatedField<RoleEquip>();

	private static readonly FieldCodec<AttrItem> _repeated_attrList_codec = FieldCodec.ForMessage(34u, AttrItem.Parser);

	private readonly RepeatedField<AttrItem> attrList_ = new RepeatedField<AttrItem>();

	private static readonly FieldCodec<RoleWine> _repeated_wineList_codec = FieldCodec.ForMessage(42u, RoleWine.Parser);

	private readonly RepeatedField<RoleWine> wineList_ = new RepeatedField<RoleWine>();

	private RoleBagInfo info_;

	private static readonly FieldCodec<RoleSoulSkill> _repeated_soulSkillList_codec = FieldCodec.ForMessage(58u, RoleSoulSkill.Parser);

	private readonly RepeatedField<RoleSoulSkill> soulSkillList_ = new RepeatedField<RoleSoulSkill>();

	public static MessageParser<RoleBag> Parser => _parser;

	public RepeatedField<RoleMoney> MoneyList => moneyList_;

	public RepeatedField<RoleItem> ItemList => itemList_;

	public RepeatedField<RoleEquip> EquipList => equipList_;

	public RepeatedField<AttrItem> AttrList => attrList_;

	public RepeatedField<RoleWine> WineList => wineList_;

	public RoleBagInfo Info
	{
		get
		{
			return info_;
		}
		set
		{
			info_ = value;
		}
	}

	public RepeatedField<RoleSoulSkill> SoulSkillList => soulSkillList_;

	public RoleBag()
	{
	}

	public RoleBag(RoleBag other)
		: this()
	{
		moneyList_ = other.moneyList_.Clone();
		itemList_ = other.itemList_.Clone();
		equipList_ = other.equipList_.Clone();
		attrList_ = other.attrList_.Clone();
		wineList_ = other.wineList_.Clone();
		info_ = ((other.info_ != null) ? other.info_.Clone() : null);
		soulSkillList_ = other.soulSkillList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleBag Clone()
	{
		return new RoleBag(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleBag);
	}

	public bool Equals(RoleBag other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!moneyList_.Equals(other.moneyList_))
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (!equipList_.Equals(other.equipList_))
		{
			return false;
		}
		if (!attrList_.Equals(other.attrList_))
		{
			return false;
		}
		if (!wineList_.Equals(other.wineList_))
		{
			return false;
		}
		if (!object.Equals(Info, other.Info))
		{
			return false;
		}
		if (!soulSkillList_.Equals(other.soulSkillList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= moneyList_.GetHashCode();
		num ^= itemList_.GetHashCode();
		num ^= equipList_.GetHashCode();
		num ^= attrList_.GetHashCode();
		num ^= wineList_.GetHashCode();
		if (info_ != null)
		{
			num ^= Info.GetHashCode();
		}
		num ^= soulSkillList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		moneyList_.WriteTo(output, _repeated_moneyList_codec);
		itemList_.WriteTo(output, _repeated_itemList_codec);
		equipList_.WriteTo(output, _repeated_equipList_codec);
		attrList_.WriteTo(output, _repeated_attrList_codec);
		wineList_.WriteTo(output, _repeated_wineList_codec);
		if (info_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Info);
		}
		soulSkillList_.WriteTo(output, _repeated_soulSkillList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += moneyList_.CalculateSize(_repeated_moneyList_codec);
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		num += equipList_.CalculateSize(_repeated_equipList_codec);
		num += attrList_.CalculateSize(_repeated_attrList_codec);
		num += wineList_.CalculateSize(_repeated_wineList_codec);
		if (info_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Info);
		}
		num += soulSkillList_.CalculateSize(_repeated_soulSkillList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleBag other)
	{
		if (other == null)
		{
			return;
		}
		moneyList_.Add(other.moneyList_);
		itemList_.Add(other.itemList_);
		equipList_.Add(other.equipList_);
		attrList_.Add(other.attrList_);
		wineList_.Add(other.wineList_);
		if (other.info_ != null)
		{
			if (info_ == null)
			{
				Info = new RoleBagInfo();
			}
			Info.MergeFrom(other.Info);
		}
		soulSkillList_.Add(other.soulSkillList_);
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
			case 10u:
				moneyList_.AddEntriesFrom(input, _repeated_moneyList_codec);
				break;
			case 18u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			case 26u:
				equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
				break;
			case 34u:
				attrList_.AddEntriesFrom(input, _repeated_attrList_codec);
				break;
			case 42u:
				wineList_.AddEntriesFrom(input, _repeated_wineList_codec);
				break;
			case 50u:
				if (info_ == null)
				{
					Info = new RoleBagInfo();
				}
				input.ReadMessage(Info);
				break;
			case 58u:
				soulSkillList_.AddEntriesFrom(input, _repeated_soulSkillList_codec);
				break;
			}
		}
	}
}
