using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class PlayerTransactionBase : IMessage<PlayerTransactionBase>, IMessage, IEquatable<PlayerTransactionBase>, IDeepCloneable<PlayerTransactionBase>
{
	private static readonly MessageParser<PlayerTransactionBase> _parser = new MessageParser<PlayerTransactionBase>(() => new PlayerTransactionBase());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int parentTransactionId_;

	private int transactionId_;

	private static readonly FieldCodec<ClassDeltaMsgPlayerTransactionTaskBase> _repeated_activeTask_codec = FieldCodec.ForMessage(26u, ClassDeltaMsgPlayerTransactionTaskBase.Parser);

	private readonly RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase> activeTask_ = new RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase>();

	private static readonly FieldCodec<ListDeltaMsgPlayerTransactionTaskBase> _repeated_finishedTasks_codec = FieldCodec.ForMessage(34u, ListDeltaMsgPlayerTransactionTaskBase.Parser);

	private readonly RepeatedField<ListDeltaMsgPlayerTransactionTaskBase> finishedTasks_ = new RepeatedField<ListDeltaMsgPlayerTransactionTaskBase>();

	private int transactionState_;

	private uint playerTransactionInteractInteractTarget_;

	private int gSRepSubClassIdx_;

	public static MessageParser<PlayerTransactionBase> Parser => _parser;

	public int ParentTransactionId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return parentTransactionId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			parentTransactionId_ = value;
		}
	}

	public bool HasParentTransactionId => (_hasBits0 & 1) != 0;

	public int TransactionId
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return transactionId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			transactionId_ = value;
		}
	}

	public bool HasTransactionId => (_hasBits0 & 2) != 0;

	public RepeatedField<ClassDeltaMsgPlayerTransactionTaskBase> ActiveTask => activeTask_;

	public RepeatedField<ListDeltaMsgPlayerTransactionTaskBase> FinishedTasks => finishedTasks_;

	public int TransactionState
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return transactionState_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			transactionState_ = value;
		}
	}

	public bool HasTransactionState => (_hasBits0 & 4) != 0;

	public uint PlayerTransactionInteractInteractTarget
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return playerTransactionInteractInteractTarget_;
			}
			return 0u;
		}
		set
		{
			_hasBits0 |= 8;
			playerTransactionInteractInteractTarget_ = value;
		}
	}

	public bool HasPlayerTransactionInteractInteractTarget => (_hasBits0 & 8) != 0;

	public int GSRepSubClassIdx
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return gSRepSubClassIdx_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 16;
			gSRepSubClassIdx_ = value;
		}
	}

	public bool HasGSRepSubClassIdx => (_hasBits0 & 0x10) != 0;

	public PlayerTransactionBase()
	{
	}

	public PlayerTransactionBase(PlayerTransactionBase other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		parentTransactionId_ = other.parentTransactionId_;
		transactionId_ = other.transactionId_;
		activeTask_ = other.activeTask_.Clone();
		finishedTasks_ = other.finishedTasks_.Clone();
		transactionState_ = other.transactionState_;
		playerTransactionInteractInteractTarget_ = other.playerTransactionInteractInteractTarget_;
		gSRepSubClassIdx_ = other.gSRepSubClassIdx_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerTransactionBase Clone()
	{
		return new PlayerTransactionBase(this);
	}

	public void ClearParentTransactionId()
	{
		_hasBits0 &= -2;
	}

	public void ClearTransactionId()
	{
		_hasBits0 &= -3;
	}

	public void ClearTransactionState()
	{
		_hasBits0 &= -5;
	}

	public void ClearPlayerTransactionInteractInteractTarget()
	{
		_hasBits0 &= -9;
	}

	public void ClearGSRepSubClassIdx()
	{
		_hasBits0 &= -17;
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerTransactionBase);
	}

	public bool Equals(PlayerTransactionBase other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ParentTransactionId != other.ParentTransactionId)
		{
			return false;
		}
		if (TransactionId != other.TransactionId)
		{
			return false;
		}
		if (!activeTask_.Equals(other.activeTask_))
		{
			return false;
		}
		if (!finishedTasks_.Equals(other.finishedTasks_))
		{
			return false;
		}
		if (TransactionState != other.TransactionState)
		{
			return false;
		}
		if (PlayerTransactionInteractInteractTarget != other.PlayerTransactionInteractInteractTarget)
		{
			return false;
		}
		if (GSRepSubClassIdx != other.GSRepSubClassIdx)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasParentTransactionId)
		{
			num ^= ParentTransactionId.GetHashCode();
		}
		if (HasTransactionId)
		{
			num ^= TransactionId.GetHashCode();
		}
		num ^= activeTask_.GetHashCode();
		num ^= finishedTasks_.GetHashCode();
		if (HasTransactionState)
		{
			num ^= TransactionState.GetHashCode();
		}
		if (HasPlayerTransactionInteractInteractTarget)
		{
			num ^= PlayerTransactionInteractInteractTarget.GetHashCode();
		}
		if (HasGSRepSubClassIdx)
		{
			num ^= GSRepSubClassIdx.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasParentTransactionId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ParentTransactionId);
		}
		if (HasTransactionId)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TransactionId);
		}
		activeTask_.WriteTo(output, _repeated_activeTask_codec);
		finishedTasks_.WriteTo(output, _repeated_finishedTasks_codec);
		if (HasTransactionState)
		{
			output.WriteRawTag(40);
			output.WriteInt32(TransactionState);
		}
		if (HasPlayerTransactionInteractInteractTarget)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PlayerTransactionInteractInteractTarget);
		}
		if (HasGSRepSubClassIdx)
		{
			output.WriteRawTag(56);
			output.WriteInt32(GSRepSubClassIdx);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasParentTransactionId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ParentTransactionId);
		}
		if (HasTransactionId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TransactionId);
		}
		num += activeTask_.CalculateSize(_repeated_activeTask_codec);
		num += finishedTasks_.CalculateSize(_repeated_finishedTasks_codec);
		if (HasTransactionState)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TransactionState);
		}
		if (HasPlayerTransactionInteractInteractTarget)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlayerTransactionInteractInteractTarget);
		}
		if (HasGSRepSubClassIdx)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GSRepSubClassIdx);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerTransactionBase other)
	{
		if (other != null)
		{
			if (other.HasParentTransactionId)
			{
				ParentTransactionId = other.ParentTransactionId;
			}
			if (other.HasTransactionId)
			{
				TransactionId = other.TransactionId;
			}
			activeTask_.Add(other.activeTask_);
			finishedTasks_.Add(other.finishedTasks_);
			if (other.HasTransactionState)
			{
				TransactionState = other.TransactionState;
			}
			if (other.HasPlayerTransactionInteractInteractTarget)
			{
				PlayerTransactionInteractInteractTarget = other.PlayerTransactionInteractInteractTarget;
			}
			if (other.HasGSRepSubClassIdx)
			{
				GSRepSubClassIdx = other.GSRepSubClassIdx;
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
				ParentTransactionId = input.ReadInt32();
				break;
			case 16u:
				TransactionId = input.ReadInt32();
				break;
			case 26u:
				activeTask_.AddEntriesFrom(input, _repeated_activeTask_codec);
				break;
			case 34u:
				finishedTasks_.AddEntriesFrom(input, _repeated_finishedTasks_codec);
				break;
			case 40u:
				TransactionState = input.ReadInt32();
				break;
			case 48u:
				PlayerTransactionInteractInteractTarget = input.ReadUInt32();
				break;
			case 56u:
				GSRepSubClassIdx = input.ReadInt32();
				break;
			}
		}
	}
}
