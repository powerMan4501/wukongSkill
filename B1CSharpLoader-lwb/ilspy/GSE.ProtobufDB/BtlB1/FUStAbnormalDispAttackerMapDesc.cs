using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStAbnormalDispAttackerMapDesc : IMessage<FUStAbnormalDispAttackerMapDesc>, IMessage, IEquatable<FUStAbnormalDispAttackerMapDesc>, IDeepCloneable<FUStAbnormalDispAttackerMapDesc>
{
	private static readonly MessageParser<FUStAbnormalDispAttackerMapDesc> _parser = new MessageParser<FUStAbnormalDispAttackerMapDesc>(() => new FUStAbnormalDispAttackerMapDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private FAbnormalDispModifyInfo freeze_;

	private FAbnormalDispModifyInfo burn_;

	private FAbnormalDispModifyInfo poison_;

	private FAbnormalDispModifyInfo thunder_;

	private FAbnormalDispModifyInfo yin_;

	private FAbnormalDispModifyInfo yang_;

	private FAbnormalDispModifyInfoFreezeExt freezeExt_;

	public static MessageParser<FUStAbnormalDispAttackerMapDesc> Parser => _parser;

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

	public FAbnormalDispModifyInfo Freeze
	{
		get
		{
			return freeze_;
		}
		set
		{
			freeze_ = value;
		}
	}

	public FAbnormalDispModifyInfo Burn
	{
		get
		{
			return burn_;
		}
		set
		{
			burn_ = value;
		}
	}

	public FAbnormalDispModifyInfo Poison
	{
		get
		{
			return poison_;
		}
		set
		{
			poison_ = value;
		}
	}

	public FAbnormalDispModifyInfo Thunder
	{
		get
		{
			return thunder_;
		}
		set
		{
			thunder_ = value;
		}
	}

	public FAbnormalDispModifyInfo Yin
	{
		get
		{
			return yin_;
		}
		set
		{
			yin_ = value;
		}
	}

	public FAbnormalDispModifyInfo Yang
	{
		get
		{
			return yang_;
		}
		set
		{
			yang_ = value;
		}
	}

	public FAbnormalDispModifyInfoFreezeExt FreezeExt
	{
		get
		{
			return freezeExt_;
		}
		set
		{
			freezeExt_ = value;
		}
	}

	public FUStAbnormalDispAttackerMapDesc()
	{
	}

	public FUStAbnormalDispAttackerMapDesc(FUStAbnormalDispAttackerMapDesc other)
		: this()
	{
		iD_ = other.iD_;
		freeze_ = ((other.freeze_ != null) ? other.freeze_.Clone() : null);
		burn_ = ((other.burn_ != null) ? other.burn_.Clone() : null);
		poison_ = ((other.poison_ != null) ? other.poison_.Clone() : null);
		thunder_ = ((other.thunder_ != null) ? other.thunder_.Clone() : null);
		yin_ = ((other.yin_ != null) ? other.yin_.Clone() : null);
		yang_ = ((other.yang_ != null) ? other.yang_.Clone() : null);
		freezeExt_ = ((other.freezeExt_ != null) ? other.freezeExt_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAbnormalDispAttackerMapDesc Clone()
	{
		return new FUStAbnormalDispAttackerMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAbnormalDispAttackerMapDesc);
	}

	public bool Equals(FUStAbnormalDispAttackerMapDesc other)
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
		if (!object.Equals(Freeze, other.Freeze))
		{
			return false;
		}
		if (!object.Equals(Burn, other.Burn))
		{
			return false;
		}
		if (!object.Equals(Poison, other.Poison))
		{
			return false;
		}
		if (!object.Equals(Thunder, other.Thunder))
		{
			return false;
		}
		if (!object.Equals(Yin, other.Yin))
		{
			return false;
		}
		if (!object.Equals(Yang, other.Yang))
		{
			return false;
		}
		if (!object.Equals(FreezeExt, other.FreezeExt))
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
		if (freeze_ != null)
		{
			num ^= Freeze.GetHashCode();
		}
		if (burn_ != null)
		{
			num ^= Burn.GetHashCode();
		}
		if (poison_ != null)
		{
			num ^= Poison.GetHashCode();
		}
		if (thunder_ != null)
		{
			num ^= Thunder.GetHashCode();
		}
		if (yin_ != null)
		{
			num ^= Yin.GetHashCode();
		}
		if (yang_ != null)
		{
			num ^= Yang.GetHashCode();
		}
		if (freezeExt_ != null)
		{
			num ^= FreezeExt.GetHashCode();
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
		if (freeze_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Freeze);
		}
		if (burn_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Burn);
		}
		if (poison_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Poison);
		}
		if (thunder_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Thunder);
		}
		if (yin_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Yin);
		}
		if (yang_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Yang);
		}
		if (freezeExt_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(FreezeExt);
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
		if (freeze_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Freeze);
		}
		if (burn_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Burn);
		}
		if (poison_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Poison);
		}
		if (thunder_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Thunder);
		}
		if (yin_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Yin);
		}
		if (yang_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Yang);
		}
		if (freezeExt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FreezeExt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAbnormalDispAttackerMapDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.freeze_ != null)
		{
			if (freeze_ == null)
			{
				Freeze = new FAbnormalDispModifyInfo();
			}
			Freeze.MergeFrom(other.Freeze);
		}
		if (other.burn_ != null)
		{
			if (burn_ == null)
			{
				Burn = new FAbnormalDispModifyInfo();
			}
			Burn.MergeFrom(other.Burn);
		}
		if (other.poison_ != null)
		{
			if (poison_ == null)
			{
				Poison = new FAbnormalDispModifyInfo();
			}
			Poison.MergeFrom(other.Poison);
		}
		if (other.thunder_ != null)
		{
			if (thunder_ == null)
			{
				Thunder = new FAbnormalDispModifyInfo();
			}
			Thunder.MergeFrom(other.Thunder);
		}
		if (other.yin_ != null)
		{
			if (yin_ == null)
			{
				Yin = new FAbnormalDispModifyInfo();
			}
			Yin.MergeFrom(other.Yin);
		}
		if (other.yang_ != null)
		{
			if (yang_ == null)
			{
				Yang = new FAbnormalDispModifyInfo();
			}
			Yang.MergeFrom(other.Yang);
		}
		if (other.freezeExt_ != null)
		{
			if (freezeExt_ == null)
			{
				FreezeExt = new FAbnormalDispModifyInfoFreezeExt();
			}
			FreezeExt.MergeFrom(other.FreezeExt);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				if (freeze_ == null)
				{
					Freeze = new FAbnormalDispModifyInfo();
				}
				input.ReadMessage(Freeze);
				break;
			case 26u:
				if (burn_ == null)
				{
					Burn = new FAbnormalDispModifyInfo();
				}
				input.ReadMessage(Burn);
				break;
			case 34u:
				if (poison_ == null)
				{
					Poison = new FAbnormalDispModifyInfo();
				}
				input.ReadMessage(Poison);
				break;
			case 42u:
				if (thunder_ == null)
				{
					Thunder = new FAbnormalDispModifyInfo();
				}
				input.ReadMessage(Thunder);
				break;
			case 50u:
				if (yin_ == null)
				{
					Yin = new FAbnormalDispModifyInfo();
				}
				input.ReadMessage(Yin);
				break;
			case 58u:
				if (yang_ == null)
				{
					Yang = new FAbnormalDispModifyInfo();
				}
				input.ReadMessage(Yang);
				break;
			case 66u:
				if (freezeExt_ == null)
				{
					FreezeExt = new FAbnormalDispModifyInfoFreezeExt();
				}
				input.ReadMessage(FreezeExt);
				break;
			}
		}
	}
}
