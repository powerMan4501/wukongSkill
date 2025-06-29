using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagWineUpgradeReq : IMessage<CSMsgBagWineUpgradeReq>, IMessage, IEquatable<CSMsgBagWineUpgradeReq>, IDeepCloneable<CSMsgBagWineUpgradeReq>
{
	private static readonly MessageParser<CSMsgBagWineUpgradeReq> _parser = new MessageParser<CSMsgBagWineUpgradeReq>(() => new CSMsgBagWineUpgradeReq());

	private UnknownFieldSet _unknownFields;

	private int wineUpgradeItem_;

	private int wineId_;

	public static MessageParser<CSMsgBagWineUpgradeReq> Parser => _parser;

	public int WineUpgradeItem
	{
		get
		{
			return wineUpgradeItem_;
		}
		set
		{
			wineUpgradeItem_ = value;
		}
	}

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

	public CSMsgBagWineUpgradeReq()
	{
	}

	public CSMsgBagWineUpgradeReq(CSMsgBagWineUpgradeReq other)
		: this()
	{
		wineUpgradeItem_ = other.wineUpgradeItem_;
		wineId_ = other.wineId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagWineUpgradeReq Clone()
	{
		return new CSMsgBagWineUpgradeReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagWineUpgradeReq);
	}

	public bool Equals(CSMsgBagWineUpgradeReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WineUpgradeItem != other.WineUpgradeItem)
		{
			return false;
		}
		if (WineId != other.WineId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (WineUpgradeItem != 0)
		{
			num ^= WineUpgradeItem.GetHashCode();
		}
		if (WineId != 0)
		{
			num ^= WineId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (WineUpgradeItem != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(WineUpgradeItem);
		}
		if (WineId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(WineId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (WineUpgradeItem != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WineUpgradeItem);
		}
		if (WineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WineId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagWineUpgradeReq other)
	{
		if (other != null)
		{
			if (other.WineUpgradeItem != 0)
			{
				WineUpgradeItem = other.WineUpgradeItem;
			}
			if (other.WineId != 0)
			{
				WineId = other.WineId;
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
				WineUpgradeItem = input.ReadInt32();
				break;
			case 16u:
				WineId = input.ReadInt32();
				break;
			}
		}
	}
}
