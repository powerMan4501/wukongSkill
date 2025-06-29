using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPlayerTransUnitConfDesc : IMessage<FUStPlayerTransUnitConfDesc>, IMessage, IEquatable<FUStPlayerTransUnitConfDesc>, IDeepCloneable<FUStPlayerTransUnitConfDesc>
{
	private static readonly MessageParser<FUStPlayerTransUnitConfDesc> _parser = new MessageParser<FUStPlayerTransUnitConfDesc>(() => new FUStPlayerTransUnitConfDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<FUStMagicConfInfo> _repeated_magicSkillInfoList_codec = FieldCodec.ForMessage(18u, FUStMagicConfInfo.Parser);

	private readonly RepeatedField<FUStMagicConfInfo> magicSkillInfoList_ = new RepeatedField<FUStMagicConfInfo>();

	private int reSetTransId_;

	private int transBackBeHit_;

	private static readonly FieldCodec<FUStSwitchMagicConfInfo> _repeated_switchMagicSkillInfoList_codec = FieldCodec.ForMessage(42u, FUStSwitchMagicConfInfo.Parser);

	private readonly RepeatedField<FUStSwitchMagicConfInfo> switchMagicSkillInfoList_ = new RepeatedField<FUStSwitchMagicConfInfo>();

	private EPlayerTransType transType_;

	private int transBackSkillId_;

	private int drinkSkillId_;

	private int deadDontTransback_;

	private int readArchiveTrans_;

	private int showSettingUiOnly_;

	public static MessageParser<FUStPlayerTransUnitConfDesc> Parser => _parser;

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

	public RepeatedField<FUStMagicConfInfo> MagicSkillInfoList => magicSkillInfoList_;

	public int ReSetTransId
	{
		get
		{
			return reSetTransId_;
		}
		set
		{
			reSetTransId_ = value;
		}
	}

	public int TransBackBeHit
	{
		get
		{
			return transBackBeHit_;
		}
		set
		{
			transBackBeHit_ = value;
		}
	}

	public RepeatedField<FUStSwitchMagicConfInfo> SwitchMagicSkillInfoList => switchMagicSkillInfoList_;

	public EPlayerTransType TransType
	{
		get
		{
			return transType_;
		}
		set
		{
			transType_ = value;
		}
	}

	public int TransBackSkillId
	{
		get
		{
			return transBackSkillId_;
		}
		set
		{
			transBackSkillId_ = value;
		}
	}

	public int DrinkSkillId
	{
		get
		{
			return drinkSkillId_;
		}
		set
		{
			drinkSkillId_ = value;
		}
	}

	public int DeadDontTransback
	{
		get
		{
			return deadDontTransback_;
		}
		set
		{
			deadDontTransback_ = value;
		}
	}

	public int ReadArchiveTrans
	{
		get
		{
			return readArchiveTrans_;
		}
		set
		{
			readArchiveTrans_ = value;
		}
	}

	public int ShowSettingUiOnly
	{
		get
		{
			return showSettingUiOnly_;
		}
		set
		{
			showSettingUiOnly_ = value;
		}
	}

	public FUStPlayerTransUnitConfDesc()
	{
	}

	public FUStPlayerTransUnitConfDesc(FUStPlayerTransUnitConfDesc other)
		: this()
	{
		iD_ = other.iD_;
		magicSkillInfoList_ = other.magicSkillInfoList_.Clone();
		reSetTransId_ = other.reSetTransId_;
		transBackBeHit_ = other.transBackBeHit_;
		switchMagicSkillInfoList_ = other.switchMagicSkillInfoList_.Clone();
		transType_ = other.transType_;
		transBackSkillId_ = other.transBackSkillId_;
		drinkSkillId_ = other.drinkSkillId_;
		deadDontTransback_ = other.deadDontTransback_;
		readArchiveTrans_ = other.readArchiveTrans_;
		showSettingUiOnly_ = other.showSettingUiOnly_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPlayerTransUnitConfDesc Clone()
	{
		return new FUStPlayerTransUnitConfDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPlayerTransUnitConfDesc);
	}

	public bool Equals(FUStPlayerTransUnitConfDesc other)
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
		if (!magicSkillInfoList_.Equals(other.magicSkillInfoList_))
		{
			return false;
		}
		if (ReSetTransId != other.ReSetTransId)
		{
			return false;
		}
		if (TransBackBeHit != other.TransBackBeHit)
		{
			return false;
		}
		if (!switchMagicSkillInfoList_.Equals(other.switchMagicSkillInfoList_))
		{
			return false;
		}
		if (TransType != other.TransType)
		{
			return false;
		}
		if (TransBackSkillId != other.TransBackSkillId)
		{
			return false;
		}
		if (DrinkSkillId != other.DrinkSkillId)
		{
			return false;
		}
		if (DeadDontTransback != other.DeadDontTransback)
		{
			return false;
		}
		if (ReadArchiveTrans != other.ReadArchiveTrans)
		{
			return false;
		}
		if (ShowSettingUiOnly != other.ShowSettingUiOnly)
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
		num ^= magicSkillInfoList_.GetHashCode();
		if (ReSetTransId != 0)
		{
			num ^= ReSetTransId.GetHashCode();
		}
		if (TransBackBeHit != 0)
		{
			num ^= TransBackBeHit.GetHashCode();
		}
		num ^= switchMagicSkillInfoList_.GetHashCode();
		if (TransType != EPlayerTransType.BattleUnit)
		{
			num ^= TransType.GetHashCode();
		}
		if (TransBackSkillId != 0)
		{
			num ^= TransBackSkillId.GetHashCode();
		}
		if (DrinkSkillId != 0)
		{
			num ^= DrinkSkillId.GetHashCode();
		}
		if (DeadDontTransback != 0)
		{
			num ^= DeadDontTransback.GetHashCode();
		}
		if (ReadArchiveTrans != 0)
		{
			num ^= ReadArchiveTrans.GetHashCode();
		}
		if (ShowSettingUiOnly != 0)
		{
			num ^= ShowSettingUiOnly.GetHashCode();
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
		magicSkillInfoList_.WriteTo(output, _repeated_magicSkillInfoList_codec);
		if (ReSetTransId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ReSetTransId);
		}
		if (TransBackBeHit != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TransBackBeHit);
		}
		switchMagicSkillInfoList_.WriteTo(output, _repeated_switchMagicSkillInfoList_codec);
		if (TransType != EPlayerTransType.BattleUnit)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)TransType);
		}
		if (TransBackSkillId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TransBackSkillId);
		}
		if (DrinkSkillId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(DrinkSkillId);
		}
		if (DeadDontTransback != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(DeadDontTransback);
		}
		if (ReadArchiveTrans != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ReadArchiveTrans);
		}
		if (ShowSettingUiOnly != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ShowSettingUiOnly);
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
		num += magicSkillInfoList_.CalculateSize(_repeated_magicSkillInfoList_codec);
		if (ReSetTransId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReSetTransId);
		}
		if (TransBackBeHit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TransBackBeHit);
		}
		num += switchMagicSkillInfoList_.CalculateSize(_repeated_switchMagicSkillInfoList_codec);
		if (TransType != EPlayerTransType.BattleUnit)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TransType);
		}
		if (TransBackSkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TransBackSkillId);
		}
		if (DrinkSkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DrinkSkillId);
		}
		if (DeadDontTransback != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DeadDontTransback);
		}
		if (ReadArchiveTrans != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReadArchiveTrans);
		}
		if (ShowSettingUiOnly != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShowSettingUiOnly);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPlayerTransUnitConfDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			magicSkillInfoList_.Add(other.magicSkillInfoList_);
			if (other.ReSetTransId != 0)
			{
				ReSetTransId = other.ReSetTransId;
			}
			if (other.TransBackBeHit != 0)
			{
				TransBackBeHit = other.TransBackBeHit;
			}
			switchMagicSkillInfoList_.Add(other.switchMagicSkillInfoList_);
			if (other.TransType != EPlayerTransType.BattleUnit)
			{
				TransType = other.TransType;
			}
			if (other.TransBackSkillId != 0)
			{
				TransBackSkillId = other.TransBackSkillId;
			}
			if (other.DrinkSkillId != 0)
			{
				DrinkSkillId = other.DrinkSkillId;
			}
			if (other.DeadDontTransback != 0)
			{
				DeadDontTransback = other.DeadDontTransback;
			}
			if (other.ReadArchiveTrans != 0)
			{
				ReadArchiveTrans = other.ReadArchiveTrans;
			}
			if (other.ShowSettingUiOnly != 0)
			{
				ShowSettingUiOnly = other.ShowSettingUiOnly;
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
			case 18u:
				magicSkillInfoList_.AddEntriesFrom(input, _repeated_magicSkillInfoList_codec);
				break;
			case 24u:
				ReSetTransId = input.ReadInt32();
				break;
			case 32u:
				TransBackBeHit = input.ReadInt32();
				break;
			case 42u:
				switchMagicSkillInfoList_.AddEntriesFrom(input, _repeated_switchMagicSkillInfoList_codec);
				break;
			case 48u:
				TransType = (EPlayerTransType)input.ReadEnum();
				break;
			case 56u:
				TransBackSkillId = input.ReadInt32();
				break;
			case 64u:
				DrinkSkillId = input.ReadInt32();
				break;
			case 72u:
				DeadDontTransback = input.ReadInt32();
				break;
			case 80u:
				ReadArchiveTrans = input.ReadInt32();
				break;
			case 88u:
				ShowSettingUiOnly = input.ReadInt32();
				break;
			}
		}
	}
}
