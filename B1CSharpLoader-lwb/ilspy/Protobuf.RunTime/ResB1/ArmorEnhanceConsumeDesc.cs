using System;
using BtlB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class ArmorEnhanceConsumeDesc : IMessage<ArmorEnhanceConsumeDesc>, IMessage, IEquatable<ArmorEnhanceConsumeDesc>, IDeepCloneable<ArmorEnhanceConsumeDesc>
{
	private static readonly MessageParser<ArmorEnhanceConsumeDesc> _parser = new MessageParser<ArmorEnhanceConsumeDesc>(() => new ArmorEnhanceConsumeDesc());

	private UnknownFieldSet _unknownFields;

	private ItemQuality targetQuality_;

	private EquipPosition position_;

	private static readonly FieldCodec<ItemOne> _repeated_itemList_codec = FieldCodec.ForMessage(26u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> itemList_ = new RepeatedField<ItemOne>();

	public static MessageParser<ArmorEnhanceConsumeDesc> Parser => _parser;

	public ItemQuality TargetQuality
	{
		get
		{
			return targetQuality_;
		}
		set
		{
			targetQuality_ = value;
		}
	}

	public EquipPosition Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	public RepeatedField<ItemOne> ItemList => itemList_;

	public ArmorEnhanceConsumeDesc()
	{
	}

	public ArmorEnhanceConsumeDesc(ArmorEnhanceConsumeDesc other)
		: this()
	{
		targetQuality_ = other.targetQuality_;
		position_ = other.position_;
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArmorEnhanceConsumeDesc Clone()
	{
		return new ArmorEnhanceConsumeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArmorEnhanceConsumeDesc);
	}

	public bool Equals(ArmorEnhanceConsumeDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetQuality != other.TargetQuality)
		{
			return false;
		}
		if (Position != other.Position)
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
		if (TargetQuality != ItemQuality.Init)
		{
			num ^= TargetQuality.GetHashCode();
		}
		if (Position != EquipPosition.Head)
		{
			num ^= Position.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TargetQuality != ItemQuality.Init)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)TargetQuality);
		}
		if (Position != EquipPosition.Head)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Position);
		}
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TargetQuality != ItemQuality.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TargetQuality);
		}
		if (Position != EquipPosition.Head)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Position);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArmorEnhanceConsumeDesc other)
	{
		if (other != null)
		{
			if (other.TargetQuality != ItemQuality.Init)
			{
				TargetQuality = other.TargetQuality;
			}
			if (other.Position != EquipPosition.Head)
			{
				Position = other.Position;
			}
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
				TargetQuality = (ItemQuality)input.ReadEnum();
				break;
			case 16u:
				Position = (EquipPosition)input.ReadEnum();
				break;
			case 26u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			}
		}
	}
}
