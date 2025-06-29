using System;
using Google.Protobuf;

namespace ResB1;

public sealed class LoadingTipsWeightDesc : IMessage<LoadingTipsWeightDesc>, IMessage, IEquatable<LoadingTipsWeightDesc>, IDeepCloneable<LoadingTipsWeightDesc>
{
	private static readonly MessageParser<LoadingTipsWeightDesc> _parser = new MessageParser<LoadingTipsWeightDesc>(() => new LoadingTipsWeightDesc());

	private UnknownFieldSet _unknownFields;

	private LoadingTipsType tipsType_;

	private int baseWeight_;

	private int deathAddWeight_;

	private int transferAddWeight_;

	private int unitKillAddWeight_;

	public static MessageParser<LoadingTipsWeightDesc> Parser => _parser;

	public LoadingTipsType TipsType
	{
		get
		{
			return tipsType_;
		}
		set
		{
			tipsType_ = value;
		}
	}

	public int BaseWeight
	{
		get
		{
			return baseWeight_;
		}
		set
		{
			baseWeight_ = value;
		}
	}

	public int DeathAddWeight
	{
		get
		{
			return deathAddWeight_;
		}
		set
		{
			deathAddWeight_ = value;
		}
	}

	public int TransferAddWeight
	{
		get
		{
			return transferAddWeight_;
		}
		set
		{
			transferAddWeight_ = value;
		}
	}

	public int UnitKillAddWeight
	{
		get
		{
			return unitKillAddWeight_;
		}
		set
		{
			unitKillAddWeight_ = value;
		}
	}

	public LoadingTipsWeightDesc()
	{
	}

	public LoadingTipsWeightDesc(LoadingTipsWeightDesc other)
		: this()
	{
		tipsType_ = other.tipsType_;
		baseWeight_ = other.baseWeight_;
		deathAddWeight_ = other.deathAddWeight_;
		transferAddWeight_ = other.transferAddWeight_;
		unitKillAddWeight_ = other.unitKillAddWeight_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LoadingTipsWeightDesc Clone()
	{
		return new LoadingTipsWeightDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LoadingTipsWeightDesc);
	}

	public bool Equals(LoadingTipsWeightDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TipsType != other.TipsType)
		{
			return false;
		}
		if (BaseWeight != other.BaseWeight)
		{
			return false;
		}
		if (DeathAddWeight != other.DeathAddWeight)
		{
			return false;
		}
		if (TransferAddWeight != other.TransferAddWeight)
		{
			return false;
		}
		if (UnitKillAddWeight != other.UnitKillAddWeight)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TipsType != LoadingTipsType.None)
		{
			num ^= TipsType.GetHashCode();
		}
		if (BaseWeight != 0)
		{
			num ^= BaseWeight.GetHashCode();
		}
		if (DeathAddWeight != 0)
		{
			num ^= DeathAddWeight.GetHashCode();
		}
		if (TransferAddWeight != 0)
		{
			num ^= TransferAddWeight.GetHashCode();
		}
		if (UnitKillAddWeight != 0)
		{
			num ^= UnitKillAddWeight.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TipsType != LoadingTipsType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)TipsType);
		}
		if (BaseWeight != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BaseWeight);
		}
		if (DeathAddWeight != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DeathAddWeight);
		}
		if (TransferAddWeight != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TransferAddWeight);
		}
		if (UnitKillAddWeight != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(UnitKillAddWeight);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TipsType != LoadingTipsType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TipsType);
		}
		if (BaseWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BaseWeight);
		}
		if (DeathAddWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DeathAddWeight);
		}
		if (TransferAddWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TransferAddWeight);
		}
		if (UnitKillAddWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitKillAddWeight);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LoadingTipsWeightDesc other)
	{
		if (other != null)
		{
			if (other.TipsType != LoadingTipsType.None)
			{
				TipsType = other.TipsType;
			}
			if (other.BaseWeight != 0)
			{
				BaseWeight = other.BaseWeight;
			}
			if (other.DeathAddWeight != 0)
			{
				DeathAddWeight = other.DeathAddWeight;
			}
			if (other.TransferAddWeight != 0)
			{
				TransferAddWeight = other.TransferAddWeight;
			}
			if (other.UnitKillAddWeight != 0)
			{
				UnitKillAddWeight = other.UnitKillAddWeight;
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
				TipsType = (LoadingTipsType)input.ReadEnum();
				break;
			case 16u:
				BaseWeight = input.ReadInt32();
				break;
			case 24u:
				DeathAddWeight = input.ReadInt32();
				break;
			case 32u:
				TransferAddWeight = input.ReadInt32();
				break;
			case 40u:
				UnitKillAddWeight = input.ReadInt32();
				break;
			}
		}
	}
}
