using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStLifeSavingHairConfigDesc : IMessage<FUStLifeSavingHairConfigDesc>, IMessage, IEquatable<FUStLifeSavingHairConfigDesc>, IDeepCloneable<FUStLifeSavingHairConfigDesc>
{
	private static readonly MessageParser<FUStLifeSavingHairConfigDesc> _parser = new MessageParser<FUStLifeSavingHairConfigDesc>(() => new FUStLifeSavingHairConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int spellID_;

	private int defaultCD_;

	private string aMPath_ = "";

	private static readonly FieldCodec<int> _repeated_effectIDList_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> effectIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_buffIDList_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> buffIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_buffIDListDurLifeSaving_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> buffIDListDurLifeSaving_ = new RepeatedField<int>();

	public static MessageParser<FUStLifeSavingHairConfigDesc> Parser => _parser;

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

	public int SpellID
	{
		get
		{
			return spellID_;
		}
		set
		{
			spellID_ = value;
		}
	}

	public int DefaultCD
	{
		get
		{
			return defaultCD_;
		}
		set
		{
			defaultCD_ = value;
		}
	}

	public string AMPath
	{
		get
		{
			return aMPath_;
		}
		set
		{
			aMPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> EffectIDList => effectIDList_;

	public RepeatedField<int> BuffIDList => buffIDList_;

	public RepeatedField<int> BuffIDListDurLifeSaving => buffIDListDurLifeSaving_;

	public FUStLifeSavingHairConfigDesc()
	{
	}

	public FUStLifeSavingHairConfigDesc(FUStLifeSavingHairConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		spellID_ = other.spellID_;
		defaultCD_ = other.defaultCD_;
		aMPath_ = other.aMPath_;
		effectIDList_ = other.effectIDList_.Clone();
		buffIDList_ = other.buffIDList_.Clone();
		buffIDListDurLifeSaving_ = other.buffIDListDurLifeSaving_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStLifeSavingHairConfigDesc Clone()
	{
		return new FUStLifeSavingHairConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStLifeSavingHairConfigDesc);
	}

	public bool Equals(FUStLifeSavingHairConfigDesc other)
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
		if (SpellID != other.SpellID)
		{
			return false;
		}
		if (DefaultCD != other.DefaultCD)
		{
			return false;
		}
		if (AMPath != other.AMPath)
		{
			return false;
		}
		if (!effectIDList_.Equals(other.effectIDList_))
		{
			return false;
		}
		if (!buffIDList_.Equals(other.buffIDList_))
		{
			return false;
		}
		if (!buffIDListDurLifeSaving_.Equals(other.buffIDListDurLifeSaving_))
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
		if (SpellID != 0)
		{
			num ^= SpellID.GetHashCode();
		}
		if (DefaultCD != 0)
		{
			num ^= DefaultCD.GetHashCode();
		}
		if (AMPath.Length != 0)
		{
			num ^= AMPath.GetHashCode();
		}
		num ^= effectIDList_.GetHashCode();
		num ^= buffIDList_.GetHashCode();
		num ^= buffIDListDurLifeSaving_.GetHashCode();
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
		if (SpellID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SpellID);
		}
		if (DefaultCD != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DefaultCD);
		}
		if (AMPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(AMPath);
		}
		effectIDList_.WriteTo(output, _repeated_effectIDList_codec);
		buffIDList_.WriteTo(output, _repeated_buffIDList_codec);
		buffIDListDurLifeSaving_.WriteTo(output, _repeated_buffIDListDurLifeSaving_codec);
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
		if (SpellID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SpellID);
		}
		if (DefaultCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultCD);
		}
		if (AMPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AMPath);
		}
		num += effectIDList_.CalculateSize(_repeated_effectIDList_codec);
		num += buffIDList_.CalculateSize(_repeated_buffIDList_codec);
		num += buffIDListDurLifeSaving_.CalculateSize(_repeated_buffIDListDurLifeSaving_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStLifeSavingHairConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.SpellID != 0)
			{
				SpellID = other.SpellID;
			}
			if (other.DefaultCD != 0)
			{
				DefaultCD = other.DefaultCD;
			}
			if (other.AMPath.Length != 0)
			{
				AMPath = other.AMPath;
			}
			effectIDList_.Add(other.effectIDList_);
			buffIDList_.Add(other.buffIDList_);
			buffIDListDurLifeSaving_.Add(other.buffIDListDurLifeSaving_);
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
				SpellID = input.ReadInt32();
				break;
			case 24u:
				DefaultCD = input.ReadInt32();
				break;
			case 34u:
				AMPath = input.ReadString();
				break;
			case 40u:
			case 42u:
				effectIDList_.AddEntriesFrom(input, _repeated_effectIDList_codec);
				break;
			case 48u:
			case 50u:
				buffIDList_.AddEntriesFrom(input, _repeated_buffIDList_codec);
				break;
			case 56u:
			case 58u:
				buffIDListDurLifeSaving_.AddEntriesFrom(input, _repeated_buffIDListDurLifeSaving_codec);
				break;
			}
		}
	}
}
