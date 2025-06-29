using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleWine : IMessage<RoleWine>, IMessage, IEquatable<RoleWine>, IDeepCloneable<RoleWine>
{
	private static readonly MessageParser<RoleWine> _parser = new MessageParser<RoleWine>(() => new RoleWine());

	private UnknownFieldSet _unknownFields;

	private int wineId_;

	private static readonly FieldCodec<WinePartner> _repeated_itemList_codec = FieldCodec.ForMessage(18u, WinePartner.Parser);

	private readonly RepeatedField<WinePartner> itemList_ = new RepeatedField<WinePartner>();

	private ulong uid_;

	public static MessageParser<RoleWine> Parser => _parser;

	public int WineId
	{
		get
		{
			return wineId_;
		}
		set
		{
			wineId_ = value;
		}
	}

	public RepeatedField<WinePartner> ItemList => itemList_;

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

	public RoleWine()
	{
	}

	public RoleWine(RoleWine other)
		: this()
	{
		wineId_ = other.wineId_;
		itemList_ = other.itemList_.Clone();
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleWine Clone()
	{
		return new RoleWine(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleWine);
	}

	public bool Equals(RoleWine other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WineId != other.WineId)
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (WineId != 0)
		{
			num ^= WineId.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (Uid != 0L)
		{
			num ^= Uid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (WineId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(WineId);
		}
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (Uid != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(Uid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (WineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WineId);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (Uid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleWine other)
	{
		if (other != null)
		{
			if (other.WineId != 0)
			{
				WineId = other.WineId;
			}
			itemList_.Add(other.itemList_);
			if (other.Uid != 0L)
			{
				Uid = other.Uid;
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
				WineId = input.ReadInt32();
				break;
			case 18u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			case 24u:
				Uid = input.ReadUInt64();
				break;
			}
		}
	}
}
