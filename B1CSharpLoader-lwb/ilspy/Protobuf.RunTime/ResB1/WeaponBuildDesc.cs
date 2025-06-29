using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class WeaponBuildDesc : IMessage<WeaponBuildDesc>, IMessage, IEquatable<WeaponBuildDesc>, IDeepCloneable<WeaponBuildDesc>
{
	private static readonly MessageParser<WeaponBuildDesc> _parser = new MessageParser<WeaponBuildDesc>(() => new WeaponBuildDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int requireWeapon_;

	private static readonly FieldCodec<ItemOne> _repeated_costItem_codec = FieldCodec.ForMessage(26u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> costItem_ = new RepeatedField<ItemOne>();

	private static readonly FieldCodec<ItemOne> _repeated_transformItem_codec = FieldCodec.ForMessage(34u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> transformItem_ = new RepeatedField<ItemOne>();

	private int seriesId_;

	private YesNoType hiddenByDefault_;

	private static readonly FieldCodec<ItemOne> _repeated_keyItemList_codec = FieldCodec.ForMessage(58u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> keyItemList_ = new RepeatedField<ItemOne>();

	private int availableGameplus_;

	public static MessageParser<WeaponBuildDesc> Parser => _parser;

	public int Id
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

	public int RequireWeapon
	{
		get
		{
			return requireWeapon_;
		}
		set
		{
			requireWeapon_ = value;
		}
	}

	public RepeatedField<ItemOne> CostItem => costItem_;

	public RepeatedField<ItemOne> TransformItem => transformItem_;

	public int SeriesId
	{
		get
		{
			return seriesId_;
		}
		set
		{
			seriesId_ = value;
		}
	}

	public YesNoType HiddenByDefault
	{
		get
		{
			return hiddenByDefault_;
		}
		set
		{
			hiddenByDefault_ = value;
		}
	}

	public RepeatedField<ItemOne> KeyItemList => keyItemList_;

	public int AvailableGameplus
	{
		get
		{
			return availableGameplus_;
		}
		set
		{
			availableGameplus_ = value;
		}
	}

	public WeaponBuildDesc()
	{
	}

	public WeaponBuildDesc(WeaponBuildDesc other)
		: this()
	{
		id_ = other.id_;
		requireWeapon_ = other.requireWeapon_;
		costItem_ = other.costItem_.Clone();
		transformItem_ = other.transformItem_.Clone();
		seriesId_ = other.seriesId_;
		hiddenByDefault_ = other.hiddenByDefault_;
		keyItemList_ = other.keyItemList_.Clone();
		availableGameplus_ = other.availableGameplus_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WeaponBuildDesc Clone()
	{
		return new WeaponBuildDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WeaponBuildDesc);
	}

	public bool Equals(WeaponBuildDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (RequireWeapon != other.RequireWeapon)
		{
			return false;
		}
		if (!costItem_.Equals(other.costItem_))
		{
			return false;
		}
		if (!transformItem_.Equals(other.transformItem_))
		{
			return false;
		}
		if (SeriesId != other.SeriesId)
		{
			return false;
		}
		if (HiddenByDefault != other.HiddenByDefault)
		{
			return false;
		}
		if (!keyItemList_.Equals(other.keyItemList_))
		{
			return false;
		}
		if (AvailableGameplus != other.AvailableGameplus)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (RequireWeapon != 0)
		{
			num ^= RequireWeapon.GetHashCode();
		}
		num ^= costItem_.GetHashCode();
		num ^= transformItem_.GetHashCode();
		if (SeriesId != 0)
		{
			num ^= SeriesId.GetHashCode();
		}
		if (HiddenByDefault != YesNoType.No)
		{
			num ^= HiddenByDefault.GetHashCode();
		}
		num ^= keyItemList_.GetHashCode();
		if (AvailableGameplus != 0)
		{
			num ^= AvailableGameplus.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (RequireWeapon != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RequireWeapon);
		}
		costItem_.WriteTo(output, _repeated_costItem_codec);
		transformItem_.WriteTo(output, _repeated_transformItem_codec);
		if (SeriesId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(SeriesId);
		}
		if (HiddenByDefault != YesNoType.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)HiddenByDefault);
		}
		keyItemList_.WriteTo(output, _repeated_keyItemList_codec);
		if (AvailableGameplus != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(AvailableGameplus);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (RequireWeapon != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RequireWeapon);
		}
		num += costItem_.CalculateSize(_repeated_costItem_codec);
		num += transformItem_.CalculateSize(_repeated_transformItem_codec);
		if (SeriesId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeriesId);
		}
		if (HiddenByDefault != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HiddenByDefault);
		}
		num += keyItemList_.CalculateSize(_repeated_keyItemList_codec);
		if (AvailableGameplus != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AvailableGameplus);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WeaponBuildDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RequireWeapon != 0)
			{
				RequireWeapon = other.RequireWeapon;
			}
			costItem_.Add(other.costItem_);
			transformItem_.Add(other.transformItem_);
			if (other.SeriesId != 0)
			{
				SeriesId = other.SeriesId;
			}
			if (other.HiddenByDefault != YesNoType.No)
			{
				HiddenByDefault = other.HiddenByDefault;
			}
			keyItemList_.Add(other.keyItemList_);
			if (other.AvailableGameplus != 0)
			{
				AvailableGameplus = other.AvailableGameplus;
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
			case 8u:
				Id = input.ReadInt32();
				break;
			case 16u:
				RequireWeapon = input.ReadInt32();
				break;
			case 26u:
				costItem_.AddEntriesFrom(input, _repeated_costItem_codec);
				break;
			case 34u:
				transformItem_.AddEntriesFrom(input, _repeated_transformItem_codec);
				break;
			case 40u:
				SeriesId = input.ReadInt32();
				break;
			case 48u:
				HiddenByDefault = (YesNoType)input.ReadEnum();
				break;
			case 58u:
				keyItemList_.AddEntriesFrom(input, _repeated_keyItemList_codec);
				break;
			case 64u:
				AvailableGameplus = input.ReadInt32();
				break;
			}
		}
	}
}
