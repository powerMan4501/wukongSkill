using System;
using Google.Protobuf;
using ResB1;

namespace CsB1;

public sealed class CSMsgBagCommDropReq : IMessage<CSMsgBagCommDropReq>, IMessage, IEquatable<CSMsgBagCommDropReq>, IDeepCloneable<CSMsgBagCommDropReq>
{
	private static readonly MessageParser<CSMsgBagCommDropReq> _parser = new MessageParser<CSMsgBagCommDropReq>(() => new CSMsgBagCommDropReq());

	private UnknownFieldSet _unknownFields;

	private int dropId_;

	private OPReason reason_;

	private YesNoType manualPickup_;

	public static MessageParser<CSMsgBagCommDropReq> Parser => _parser;

	public int DropId
	{
		get
		{
			return dropId_;
		}
		set
		{
			dropId_ = value;
		}
	}

	public OPReason Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	public YesNoType ManualPickup
	{
		get
		{
			return manualPickup_;
		}
		set
		{
			manualPickup_ = value;
		}
	}

	public CSMsgBagCommDropReq()
	{
	}

	public CSMsgBagCommDropReq(CSMsgBagCommDropReq other)
		: this()
	{
		dropId_ = other.dropId_;
		reason_ = other.reason_;
		manualPickup_ = other.manualPickup_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagCommDropReq Clone()
	{
		return new CSMsgBagCommDropReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagCommDropReq);
	}

	public bool Equals(CSMsgBagCommDropReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DropId != other.DropId)
		{
			return false;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (ManualPickup != other.ManualPickup)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DropId != 0)
		{
			num ^= DropId.GetHashCode();
		}
		if (Reason != OPReason.None)
		{
			num ^= Reason.GetHashCode();
		}
		if (ManualPickup != YesNoType.No)
		{
			num ^= ManualPickup.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DropId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DropId);
		}
		if (Reason != OPReason.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Reason);
		}
		if (ManualPickup != YesNoType.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ManualPickup);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropId);
		}
		if (Reason != OPReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (ManualPickup != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ManualPickup);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagCommDropReq other)
	{
		if (other != null)
		{
			if (other.DropId != 0)
			{
				DropId = other.DropId;
			}
			if (other.Reason != OPReason.None)
			{
				Reason = other.Reason;
			}
			if (other.ManualPickup != YesNoType.No)
			{
				ManualPickup = other.ManualPickup;
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
				DropId = input.ReadInt32();
				break;
			case 16u:
				Reason = (OPReason)input.ReadEnum();
				break;
			case 24u:
				ManualPickup = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
