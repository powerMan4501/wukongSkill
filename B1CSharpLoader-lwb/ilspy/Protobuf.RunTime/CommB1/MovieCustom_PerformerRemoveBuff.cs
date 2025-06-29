using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_PerformerRemoveBuff : IMessage<MovieCustom_PerformerRemoveBuff>, IMessage, IEquatable<MovieCustom_PerformerRemoveBuff>, IDeepCloneable<MovieCustom_PerformerRemoveBuff>
{
	private static readonly MessageParser<MovieCustom_PerformerRemoveBuff> _parser = new MessageParser<MovieCustom_PerformerRemoveBuff>(() => new MovieCustom_PerformerRemoveBuff());

	private UnknownFieldSet _unknownFields;

	private string performerGuid_ = "";

	private int buffId_;

	private int buffLayer_;

	private bool isTriggerRemoveEffect_;

	private bool isPlayerAsPerformer_;

	public static MessageParser<MovieCustom_PerformerRemoveBuff> Parser => _parser;

	public string PerformerGuid
	{
		get
		{
			return performerGuid_;
		}
		set
		{
			performerGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	public int BuffLayer
	{
		get
		{
			return buffLayer_;
		}
		set
		{
			buffLayer_ = value;
		}
	}

	public bool IsTriggerRemoveEffect
	{
		get
		{
			return isTriggerRemoveEffect_;
		}
		set
		{
			isTriggerRemoveEffect_ = value;
		}
	}

	public bool IsPlayerAsPerformer
	{
		get
		{
			return isPlayerAsPerformer_;
		}
		set
		{
			isPlayerAsPerformer_ = value;
		}
	}

	public MovieCustom_PerformerRemoveBuff()
	{
	}

	public MovieCustom_PerformerRemoveBuff(MovieCustom_PerformerRemoveBuff other)
		: this()
	{
		performerGuid_ = other.performerGuid_;
		buffId_ = other.buffId_;
		buffLayer_ = other.buffLayer_;
		isTriggerRemoveEffect_ = other.isTriggerRemoveEffect_;
		isPlayerAsPerformer_ = other.isPlayerAsPerformer_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PerformerRemoveBuff Clone()
	{
		return new MovieCustom_PerformerRemoveBuff(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PerformerRemoveBuff);
	}

	public bool Equals(MovieCustom_PerformerRemoveBuff other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformerGuid != other.PerformerGuid)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (BuffLayer != other.BuffLayer)
		{
			return false;
		}
		if (IsTriggerRemoveEffect != other.IsTriggerRemoveEffect)
		{
			return false;
		}
		if (IsPlayerAsPerformer != other.IsPlayerAsPerformer)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PerformerGuid.Length != 0)
		{
			num ^= PerformerGuid.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (BuffLayer != 0)
		{
			num ^= BuffLayer.GetHashCode();
		}
		if (IsTriggerRemoveEffect)
		{
			num ^= IsTriggerRemoveEffect.GetHashCode();
		}
		if (IsPlayerAsPerformer)
		{
			num ^= IsPlayerAsPerformer.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PerformerGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PerformerGuid);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BuffId);
		}
		if (BuffLayer != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BuffLayer);
		}
		if (IsTriggerRemoveEffect)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsTriggerRemoveEffect);
		}
		if (IsPlayerAsPerformer)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsPlayerAsPerformer);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PerformerGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PerformerGuid);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (BuffLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffLayer);
		}
		if (IsTriggerRemoveEffect)
		{
			num += 2;
		}
		if (IsPlayerAsPerformer)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PerformerRemoveBuff other)
	{
		if (other != null)
		{
			if (other.PerformerGuid.Length != 0)
			{
				PerformerGuid = other.PerformerGuid;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.BuffLayer != 0)
			{
				BuffLayer = other.BuffLayer;
			}
			if (other.IsTriggerRemoveEffect)
			{
				IsTriggerRemoveEffect = other.IsTriggerRemoveEffect;
			}
			if (other.IsPlayerAsPerformer)
			{
				IsPlayerAsPerformer = other.IsPlayerAsPerformer;
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
			case 10u:
				PerformerGuid = input.ReadString();
				break;
			case 16u:
				BuffId = input.ReadInt32();
				break;
			case 24u:
				BuffLayer = input.ReadInt32();
				break;
			case 32u:
				IsTriggerRemoveEffect = input.ReadBool();
				break;
			case 40u:
				IsPlayerAsPerformer = input.ReadBool();
				break;
			}
		}
	}
}
