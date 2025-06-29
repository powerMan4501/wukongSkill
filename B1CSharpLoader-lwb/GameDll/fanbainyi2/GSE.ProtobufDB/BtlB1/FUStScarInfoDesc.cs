using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStScarInfoDesc : IMessage<FUStScarInfoDesc>, IMessage, IEquatable<FUStScarInfoDesc>, IDeepCloneable<FUStScarInfoDesc>
{
	private static readonly MessageParser<FUStScarInfoDesc> _parser = new MessageParser<FUStScarInfoDesc>(() => new FUStScarInfoDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int attackerResID_;

	private int victimResID_;

	private EScarDecalTriggerType scarDecalTriggerType_;

	private int scarTextureDecalID_;

	private int decalWidth_;

	private int decalHeight_;

	private int decalDepth_;

	private float fadeTime_;

	private float emissiveTime_;

	private string guard_ = "";

	public static MessageParser<FUStScarInfoDesc> Parser => _parser;

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

	public int AttackerResID
	{
		get
		{
			return attackerResID_;
		}
		set
		{
			attackerResID_ = value;
		}
	}

	public int VictimResID
	{
		get
		{
			return victimResID_;
		}
		set
		{
			victimResID_ = value;
		}
	}

	public EScarDecalTriggerType ScarDecalTriggerType
	{
		get
		{
			return scarDecalTriggerType_;
		}
		set
		{
			scarDecalTriggerType_ = value;
		}
	}

	public int ScarTextureDecalID
	{
		get
		{
			return scarTextureDecalID_;
		}
		set
		{
			scarTextureDecalID_ = value;
		}
	}

	public int DecalWidth
	{
		get
		{
			return decalWidth_;
		}
		set
		{
			decalWidth_ = value;
		}
	}

	public int DecalHeight
	{
		get
		{
			return decalHeight_;
		}
		set
		{
			decalHeight_ = value;
		}
	}

	public int DecalDepth
	{
		get
		{
			return decalDepth_;
		}
		set
		{
			decalDepth_ = value;
		}
	}

	public float FadeTime
	{
		get
		{
			return fadeTime_;
		}
		set
		{
			fadeTime_ = value;
		}
	}

	public float EmissiveTime
	{
		get
		{
			return emissiveTime_;
		}
		set
		{
			emissiveTime_ = value;
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStScarInfoDesc()
	{
	}

	public FUStScarInfoDesc(FUStScarInfoDesc other)
		: this()
	{
		iD_ = other.iD_;
		attackerResID_ = other.attackerResID_;
		victimResID_ = other.victimResID_;
		scarDecalTriggerType_ = other.scarDecalTriggerType_;
		scarTextureDecalID_ = other.scarTextureDecalID_;
		decalWidth_ = other.decalWidth_;
		decalHeight_ = other.decalHeight_;
		decalDepth_ = other.decalDepth_;
		fadeTime_ = other.fadeTime_;
		emissiveTime_ = other.emissiveTime_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStScarInfoDesc Clone()
	{
		return new FUStScarInfoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStScarInfoDesc);
	}

	public bool Equals(FUStScarInfoDesc other)
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
		if (AttackerResID != other.AttackerResID)
		{
			return false;
		}
		if (VictimResID != other.VictimResID)
		{
			return false;
		}
		if (ScarDecalTriggerType != other.ScarDecalTriggerType)
		{
			return false;
		}
		if (ScarTextureDecalID != other.ScarTextureDecalID)
		{
			return false;
		}
		if (DecalWidth != other.DecalWidth)
		{
			return false;
		}
		if (DecalHeight != other.DecalHeight)
		{
			return false;
		}
		if (DecalDepth != other.DecalDepth)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FadeTime, other.FadeTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(EmissiveTime, other.EmissiveTime))
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (AttackerResID != 0)
		{
			num ^= AttackerResID.GetHashCode();
		}
		if (VictimResID != 0)
		{
			num ^= VictimResID.GetHashCode();
		}
		if (ScarDecalTriggerType != EScarDecalTriggerType.Dcss)
		{
			num ^= ScarDecalTriggerType.GetHashCode();
		}
		if (ScarTextureDecalID != 0)
		{
			num ^= ScarTextureDecalID.GetHashCode();
		}
		if (DecalWidth != 0)
		{
			num ^= DecalWidth.GetHashCode();
		}
		if (DecalHeight != 0)
		{
			num ^= DecalHeight.GetHashCode();
		}
		if (DecalDepth != 0)
		{
			num ^= DecalDepth.GetHashCode();
		}
		if (FadeTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FadeTime);
		}
		if (EmissiveTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EmissiveTime);
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
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
		if (AttackerResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AttackerResID);
		}
		if (VictimResID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(VictimResID);
		}
		if (ScarDecalTriggerType != EScarDecalTriggerType.Dcss)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ScarDecalTriggerType);
		}
		if (ScarTextureDecalID != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(ScarTextureDecalID);
		}
		if (DecalWidth != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(DecalWidth);
		}
		if (DecalHeight != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DecalHeight);
		}
		if (DecalDepth != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(DecalDepth);
		}
		if (FadeTime != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(FadeTime);
		}
		if (EmissiveTime != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(EmissiveTime);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Guard);
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
		if (AttackerResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttackerResID);
		}
		if (VictimResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(VictimResID);
		}
		if (ScarDecalTriggerType != EScarDecalTriggerType.Dcss)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ScarDecalTriggerType);
		}
		if (ScarTextureDecalID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScarTextureDecalID);
		}
		if (DecalWidth != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DecalWidth);
		}
		if (DecalHeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DecalHeight);
		}
		if (DecalDepth != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DecalDepth);
		}
		if (FadeTime != 0f)
		{
			num += 5;
		}
		if (EmissiveTime != 0f)
		{
			num += 5;
		}
		if (Guard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStScarInfoDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.AttackerResID != 0)
			{
				AttackerResID = other.AttackerResID;
			}
			if (other.VictimResID != 0)
			{
				VictimResID = other.VictimResID;
			}
			if (other.ScarDecalTriggerType != EScarDecalTriggerType.Dcss)
			{
				ScarDecalTriggerType = other.ScarDecalTriggerType;
			}
			if (other.ScarTextureDecalID != 0)
			{
				ScarTextureDecalID = other.ScarTextureDecalID;
			}
			if (other.DecalWidth != 0)
			{
				DecalWidth = other.DecalWidth;
			}
			if (other.DecalHeight != 0)
			{
				DecalHeight = other.DecalHeight;
			}
			if (other.DecalDepth != 0)
			{
				DecalDepth = other.DecalDepth;
			}
			if (other.FadeTime != 0f)
			{
				FadeTime = other.FadeTime;
			}
			if (other.EmissiveTime != 0f)
			{
				EmissiveTime = other.EmissiveTime;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
				AttackerResID = input.ReadInt32();
				break;
			case 24u:
				VictimResID = input.ReadInt32();
				break;
			case 32u:
				ScarDecalTriggerType = (EScarDecalTriggerType)input.ReadEnum();
				break;
			case 40u:
				ScarTextureDecalID = input.ReadInt32();
				break;
			case 48u:
				DecalWidth = input.ReadInt32();
				break;
			case 56u:
				DecalHeight = input.ReadInt32();
				break;
			case 64u:
				DecalDepth = input.ReadInt32();
				break;
			case 77u:
				FadeTime = input.ReadFloat();
				break;
			case 85u:
				EmissiveTime = input.ReadFloat();
				break;
			case 90u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
