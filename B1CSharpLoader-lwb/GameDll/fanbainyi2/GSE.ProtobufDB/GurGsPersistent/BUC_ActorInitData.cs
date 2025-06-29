using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class BUC_ActorInitData : IMessage<BUC_ActorInitData>, IMessage, IEquatable<BUC_ActorInitData>, IDeepCloneable<BUC_ActorInitData>
{
	private static readonly MessageParser<BUC_ActorInitData> _parser = new MessageParser<BUC_ActorInitData>(() => new BUC_ActorInitData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private bool persistentDataDontResetOnNewGamePlus_;

	public static MessageParser<BUC_ActorInitData> Parser => _parser;

	public bool PersistentDataDontResetOnNewGamePlus
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return persistentDataDontResetOnNewGamePlus_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 1;
			persistentDataDontResetOnNewGamePlus_ = value;
		}
	}

	public bool HasPersistentDataDontResetOnNewGamePlus => (_hasBits0 & 1) != 0;

	public BUC_ActorInitData()
	{
	}

	public BUC_ActorInitData(BUC_ActorInitData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		persistentDataDontResetOnNewGamePlus_ = other.persistentDataDontResetOnNewGamePlus_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BUC_ActorInitData Clone()
	{
		return new BUC_ActorInitData(this);
	}

	public void ClearPersistentDataDontResetOnNewGamePlus()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BUC_ActorInitData);
	}

	public bool Equals(BUC_ActorInitData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PersistentDataDontResetOnNewGamePlus != other.PersistentDataDontResetOnNewGamePlus)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasPersistentDataDontResetOnNewGamePlus)
		{
			num ^= PersistentDataDontResetOnNewGamePlus.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasPersistentDataDontResetOnNewGamePlus)
		{
			output.WriteRawTag(8);
			output.WriteBool(PersistentDataDontResetOnNewGamePlus);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasPersistentDataDontResetOnNewGamePlus)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BUC_ActorInitData other)
	{
		if (other != null)
		{
			if (other.HasPersistentDataDontResetOnNewGamePlus)
			{
				PersistentDataDontResetOnNewGamePlus = other.PersistentDataDontResetOnNewGamePlus;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				PersistentDataDontResetOnNewGamePlus = input.ReadBool();
			}
		}
	}
}
