using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStOnlineScreenMsgConfDesc : IMessage<FUStOnlineScreenMsgConfDesc>, IMessage, IEquatable<FUStOnlineScreenMsgConfDesc>, IDeepCloneable<FUStOnlineScreenMsgConfDesc>
{
	private static readonly MessageParser<FUStOnlineScreenMsgConfDesc> _parser = new MessageParser<FUStOnlineScreenMsgConfDesc>(() => new FUStOnlineScreenMsgConfDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EScreenMsgType screenMsgType_;

	private string tipsWord_ = "";

	private int tipsDuration_;

	public static MessageParser<FUStOnlineScreenMsgConfDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public EScreenMsgType ScreenMsgType
	{
		get
		{
			return screenMsgType_;
		}
		set
		{
			screenMsgType_ = value;
		}
	}

	public string TipsWord
	{
		get
		{
			return tipsWord_;
		}
		set
		{
			tipsWord_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TipsDuration
	{
		get
		{
			return tipsDuration_;
		}
		set
		{
			tipsDuration_ = value;
		}
	}

	public FUStOnlineScreenMsgConfDesc()
	{
	}

	public FUStOnlineScreenMsgConfDesc(FUStOnlineScreenMsgConfDesc other)
		: this()
	{
		iD_ = other.iD_;
		screenMsgType_ = other.screenMsgType_;
		tipsWord_ = other.tipsWord_;
		tipsDuration_ = other.tipsDuration_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStOnlineScreenMsgConfDesc Clone()
	{
		return new FUStOnlineScreenMsgConfDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStOnlineScreenMsgConfDesc);
	}

	public bool Equals(FUStOnlineScreenMsgConfDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (ScreenMsgType != other.ScreenMsgType)
		{
			return false;
		}
		if (TipsWord != other.TipsWord)
		{
			return false;
		}
		if (TipsDuration != other.TipsDuration)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (ScreenMsgType != EScreenMsgType.PlayerDead)
		{
			num ^= ScreenMsgType.GetHashCode();
		}
		if (TipsWord.Length != 0)
		{
			num ^= TipsWord.GetHashCode();
		}
		if (TipsDuration != 0)
		{
			num ^= TipsDuration.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (ScreenMsgType != EScreenMsgType.PlayerDead)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ScreenMsgType);
		}
		if (TipsWord.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(TipsWord);
		}
		if (TipsDuration != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TipsDuration);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (ScreenMsgType != EScreenMsgType.PlayerDead)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ScreenMsgType);
		}
		if (TipsWord.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TipsWord);
		}
		if (TipsDuration != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TipsDuration);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStOnlineScreenMsgConfDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ScreenMsgType != EScreenMsgType.PlayerDead)
			{
				ScreenMsgType = other.ScreenMsgType;
			}
			if (other.TipsWord.Length != 0)
			{
				TipsWord = other.TipsWord;
			}
			if (other.TipsDuration != 0)
			{
				TipsDuration = other.TipsDuration;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				ScreenMsgType = (EScreenMsgType)input.ReadEnum();
				break;
			case 26u:
				TipsWord = input.ReadString();
				break;
			case 32u:
				TipsDuration = input.ReadInt32();
				break;
			}
		}
	}
}
