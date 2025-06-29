using System;
using Google.Protobuf;
using ResB1;

namespace CsB1;

public sealed class CSMsgBagMultiplayerDropRes : IMessage<CSMsgBagMultiplayerDropRes>, IMessage, IEquatable<CSMsgBagMultiplayerDropRes>, IDeepCloneable<CSMsgBagMultiplayerDropRes>
{
	private static readonly MessageParser<CSMsgBagMultiplayerDropRes> _parser = new MessageParser<CSMsgBagMultiplayerDropRes>(() => new CSMsgBagMultiplayerDropRes());

	private UnknownFieldSet _unknownFields;

	private int randDropId_;

	private YesNoType isSpecialDrop_;

	public static MessageParser<CSMsgBagMultiplayerDropRes> Parser => _parser;

	public int RandDropId
	{
		get
		{
			return randDropId_;
		}
		set
		{
			randDropId_ = value;
		}
	}

	public YesNoType IsSpecialDrop
	{
		get
		{
			return isSpecialDrop_;
		}
		set
		{
			isSpecialDrop_ = value;
		}
	}

	public CSMsgBagMultiplayerDropRes()
	{
	}

	public CSMsgBagMultiplayerDropRes(CSMsgBagMultiplayerDropRes other)
		: this()
	{
		randDropId_ = other.randDropId_;
		isSpecialDrop_ = other.isSpecialDrop_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagMultiplayerDropRes Clone()
	{
		return new CSMsgBagMultiplayerDropRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagMultiplayerDropRes);
	}

	public bool Equals(CSMsgBagMultiplayerDropRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RandDropId != other.RandDropId)
		{
			return false;
		}
		if (IsSpecialDrop != other.IsSpecialDrop)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RandDropId != 0)
		{
			num ^= RandDropId.GetHashCode();
		}
		if (IsSpecialDrop != YesNoType.No)
		{
			num ^= IsSpecialDrop.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RandDropId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(RandDropId);
		}
		if (IsSpecialDrop != YesNoType.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsSpecialDrop);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RandDropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RandDropId);
		}
		if (IsSpecialDrop != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsSpecialDrop);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagMultiplayerDropRes other)
	{
		if (other != null)
		{
			if (other.RandDropId != 0)
			{
				RandDropId = other.RandDropId;
			}
			if (other.IsSpecialDrop != YesNoType.No)
			{
				IsSpecialDrop = other.IsSpecialDrop;
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
				RandDropId = input.ReadInt32();
				break;
			case 16u:
				IsSpecialDrop = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
