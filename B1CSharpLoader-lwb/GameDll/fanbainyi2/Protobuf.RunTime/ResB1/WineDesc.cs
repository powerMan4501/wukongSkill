using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class WineDesc : IMessage<WineDesc>, IMessage, IEquatable<WineDesc>, IDeepCloneable<WineDesc>
{
	private static readonly MessageParser<WineDesc> _parser = new MessageParser<WineDesc>(() => new WineDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int series_;

	private int level_;

	private int nextId_;

	private int itemListCount_;

	private static readonly FieldCodec<ItemOne> _repeated_costItem_codec = FieldCodec.ForMessage(50u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> costItem_ = new RepeatedField<ItemOne>();

	private static readonly FieldCodec<string> _repeated_upgradeDesc_codec = FieldCodec.ForString(58u);

	private readonly RepeatedField<string> upgradeDesc_ = new RepeatedField<string>();

	private int localizationTag_;

	public static MessageParser<WineDesc> Parser => _parser;

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

	public int Series
	{
		get
		{
			return series_;
		}
		set
		{
			series_ = value;
		}
	}

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

	public int NextId
	{
		get
		{
			return nextId_;
		}
		set
		{
			nextId_ = value;
		}
	}

	public int ItemListCount
	{
		get
		{
			return itemListCount_;
		}
		set
		{
			itemListCount_ = value;
		}
	}

	public RepeatedField<ItemOne> CostItem => costItem_;

	public RepeatedField<string> UpgradeDesc => upgradeDesc_;

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public WineDesc()
	{
	}

	public WineDesc(WineDesc other)
		: this()
	{
		id_ = other.id_;
		series_ = other.series_;
		level_ = other.level_;
		nextId_ = other.nextId_;
		itemListCount_ = other.itemListCount_;
		costItem_ = other.costItem_.Clone();
		upgradeDesc_ = other.upgradeDesc_.Clone();
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public WineDesc Clone()
	{
		return new WineDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as WineDesc);
	}

	public bool Equals(WineDesc other)
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
		if (Series != other.Series)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (NextId != other.NextId)
		{
			return false;
		}
		if (ItemListCount != other.ItemListCount)
		{
			return false;
		}
		if (!costItem_.Equals(other.costItem_))
		{
			return false;
		}
		if (!upgradeDesc_.Equals(other.upgradeDesc_))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (Series != 0)
		{
			num ^= Series.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (NextId != 0)
		{
			num ^= NextId.GetHashCode();
		}
		if (ItemListCount != 0)
		{
			num ^= ItemListCount.GetHashCode();
		}
		num ^= costItem_.GetHashCode();
		num ^= upgradeDesc_.GetHashCode();
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
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
		if (Series != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Series);
		}
		if (Level != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Level);
		}
		if (NextId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(NextId);
		}
		if (ItemListCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ItemListCount);
		}
		costItem_.WriteTo(output, _repeated_costItem_codec);
		upgradeDesc_.WriteTo(output, _repeated_upgradeDesc_codec);
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LocalizationTag);
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
		if (Series != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Series);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (NextId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NextId);
		}
		if (ItemListCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemListCount);
		}
		num += costItem_.CalculateSize(_repeated_costItem_codec);
		num += upgradeDesc_.CalculateSize(_repeated_upgradeDesc_codec);
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(WineDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Series != 0)
			{
				Series = other.Series;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.NextId != 0)
			{
				NextId = other.NextId;
			}
			if (other.ItemListCount != 0)
			{
				ItemListCount = other.ItemListCount;
			}
			costItem_.Add(other.costItem_);
			upgradeDesc_.Add(other.upgradeDesc_);
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				Series = input.ReadInt32();
				break;
			case 24u:
				Level = input.ReadInt32();
				break;
			case 32u:
				NextId = input.ReadInt32();
				break;
			case 40u:
				ItemListCount = input.ReadInt32();
				break;
			case 50u:
				costItem_.AddEntriesFrom(input, _repeated_costItem_codec);
				break;
			case 58u:
				upgradeDesc_.AddEntriesFrom(input, _repeated_upgradeDesc_codec);
				break;
			case 64u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
