using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventHarvest : IMessage<ReportEventHarvest>, IMessage, IEquatable<ReportEventHarvest>, IDeepCloneable<ReportEventHarvest>
{
	private static readonly MessageParser<ReportEventHarvest> _parser = new MessageParser<ReportEventHarvest>(() => new ReportEventHarvest());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private static readonly FieldCodec<Item> _repeated_itemList_codec = FieldCodec.ForMessage(18u, Item.Parser);

	private readonly RepeatedField<Item> itemList_ = new RepeatedField<Item>();

	private int intervalSec_;

	public static MessageParser<ReportEventHarvest> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public RepeatedField<Item> ItemList => itemList_;

	public int IntervalSec
	{
		get
		{
			return intervalSec_;
		}
		set
		{
			intervalSec_ = value;
		}
	}

	public ReportEventHarvest()
	{
	}

	public ReportEventHarvest(ReportEventHarvest other)
		: this()
	{
		roleId_ = other.roleId_;
		itemList_ = other.itemList_.Clone();
		intervalSec_ = other.intervalSec_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventHarvest Clone()
	{
		return new ReportEventHarvest(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventHarvest);
	}

	public bool Equals(ReportEventHarvest other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (IntervalSec != other.IntervalSec)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (IntervalSec != 0)
		{
			num ^= IntervalSec.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (IntervalSec != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(IntervalSec);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (IntervalSec != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IntervalSec);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventHarvest other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			itemList_.Add(other.itemList_);
			if (other.IntervalSec != 0)
			{
				IntervalSec = other.IntervalSec;
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
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			case 24u:
				IntervalSec = input.ReadInt32();
				break;
			}
		}
	}
}
