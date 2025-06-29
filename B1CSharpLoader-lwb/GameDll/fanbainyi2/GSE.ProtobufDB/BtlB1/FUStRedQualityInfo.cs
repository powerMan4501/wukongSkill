using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStRedQualityInfo : IMessage<FUStRedQualityInfo>, IMessage, IEquatable<FUStRedQualityInfo>, IDeepCloneable<FUStRedQualityInfo>
{
	private static readonly MessageParser<FUStRedQualityInfo> _parser = new MessageParser<FUStRedQualityInfo>(() => new FUStRedQualityInfo());

	private UnknownFieldSet _unknownFields;

	private int attrEffectID_;

	private int talentID_;

	private string redQualityEffectDesc_ = "";

	public static MessageParser<FUStRedQualityInfo> Parser => _parser;

	public int AttrEffectID
	{
		get
		{
			return attrEffectID_;
		}
		set
		{
			attrEffectID_ = value;
		}
	}

	public int TalentID
	{
		get
		{
			return talentID_;
		}
		set
		{
			talentID_ = value;
		}
	}

	public string RedQualityEffectDesc
	{
		get
		{
			return redQualityEffectDesc_;
		}
		set
		{
			redQualityEffectDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStRedQualityInfo()
	{
	}

	public FUStRedQualityInfo(FUStRedQualityInfo other)
		: this()
	{
		attrEffectID_ = other.attrEffectID_;
		talentID_ = other.talentID_;
		redQualityEffectDesc_ = other.redQualityEffectDesc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStRedQualityInfo Clone()
	{
		return new FUStRedQualityInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStRedQualityInfo);
	}

	public bool Equals(FUStRedQualityInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AttrEffectID != other.AttrEffectID)
		{
			return false;
		}
		if (TalentID != other.TalentID)
		{
			return false;
		}
		if (RedQualityEffectDesc != other.RedQualityEffectDesc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AttrEffectID != 0)
		{
			num ^= AttrEffectID.GetHashCode();
		}
		if (TalentID != 0)
		{
			num ^= TalentID.GetHashCode();
		}
		if (RedQualityEffectDesc.Length != 0)
		{
			num ^= RedQualityEffectDesc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AttrEffectID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AttrEffectID);
		}
		if (TalentID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TalentID);
		}
		if (RedQualityEffectDesc.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(RedQualityEffectDesc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AttrEffectID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrEffectID);
		}
		if (TalentID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentID);
		}
		if (RedQualityEffectDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RedQualityEffectDesc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStRedQualityInfo other)
	{
		if (other != null)
		{
			if (other.AttrEffectID != 0)
			{
				AttrEffectID = other.AttrEffectID;
			}
			if (other.TalentID != 0)
			{
				TalentID = other.TalentID;
			}
			if (other.RedQualityEffectDesc.Length != 0)
			{
				RedQualityEffectDesc = other.RedQualityEffectDesc;
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
				AttrEffectID = input.ReadInt32();
				break;
			case 16u:
				TalentID = input.ReadInt32();
				break;
			case 26u:
				RedQualityEffectDesc = input.ReadString();
				break;
			}
		}
	}
}
