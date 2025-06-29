using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventItemChange : IMessage<ReportEventItemChange>, IMessage, IEquatable<ReportEventItemChange>, IDeepCloneable<ReportEventItemChange>
{
	private static readonly MessageParser<ReportEventItemChange> _parser = new MessageParser<ReportEventItemChange>(() => new ReportEventItemChange());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private int itemId_;

	private long change_;

	private long num_;

	private int opReason_;

	private int shopId_;

	private static readonly FieldCodec<int> _repeated_fromDropId_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> fromDropId_ = new RepeatedField<int>();

	public static MessageParser<ReportEventItemChange> Parser => _parser;

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

	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	public long Change
	{
		get
		{
			return change_;
		}
		set
		{
			change_ = value;
		}
	}

	public long Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	public int OpReason
	{
		get
		{
			return opReason_;
		}
		set
		{
			opReason_ = value;
		}
	}

	public int ShopId
	{
		get
		{
			return shopId_;
		}
		set
		{
			shopId_ = value;
		}
	}

	public RepeatedField<int> FromDropId => fromDropId_;

	public ReportEventItemChange()
	{
	}

	public ReportEventItemChange(ReportEventItemChange other)
		: this()
	{
		roleId_ = other.roleId_;
		itemId_ = other.itemId_;
		change_ = other.change_;
		num_ = other.num_;
		opReason_ = other.opReason_;
		shopId_ = other.shopId_;
		fromDropId_ = other.fromDropId_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventItemChange Clone()
	{
		return new ReportEventItemChange(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventItemChange);
	}

	public bool Equals(ReportEventItemChange other)
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
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (Change != other.Change)
		{
			return false;
		}
		if (Num != other.Num)
		{
			return false;
		}
		if (OpReason != other.OpReason)
		{
			return false;
		}
		if (ShopId != other.ShopId)
		{
			return false;
		}
		if (!fromDropId_.Equals(other.fromDropId_))
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
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (Change != 0L)
		{
			num ^= Change.GetHashCode();
		}
		if (Num != 0L)
		{
			num ^= Num.GetHashCode();
		}
		if (OpReason != 0)
		{
			num ^= OpReason.GetHashCode();
		}
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
		}
		num ^= fromDropId_.GetHashCode();
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
		if (ItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemId);
		}
		if (Change != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(Change);
		}
		if (Num != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(Num);
		}
		if (OpReason != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(OpReason);
		}
		if (ShopId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ShopId);
		}
		fromDropId_.WriteTo(output, _repeated_fromDropId_codec);
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
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (Change != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Change);
		}
		if (Num != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Num);
		}
		if (OpReason != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OpReason);
		}
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShopId);
		}
		num += fromDropId_.CalculateSize(_repeated_fromDropId_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventItemChange other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.Change != 0L)
			{
				Change = other.Change;
			}
			if (other.Num != 0L)
			{
				Num = other.Num;
			}
			if (other.OpReason != 0)
			{
				OpReason = other.OpReason;
			}
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
			}
			fromDropId_.Add(other.fromDropId_);
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
			case 16u:
				ItemId = input.ReadInt32();
				break;
			case 24u:
				Change = input.ReadInt64();
				break;
			case 32u:
				Num = input.ReadInt64();
				break;
			case 40u:
				OpReason = input.ReadInt32();
				break;
			case 48u:
				ShopId = input.ReadInt32();
				break;
			case 56u:
			case 58u:
				fromDropId_.AddEntriesFrom(input, _repeated_fromDropId_codec);
				break;
			}
		}
	}
}
