using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class BPC_TransData : IMessage<BPC_TransData>, IMessage, IEquatable<BPC_TransData>, IDeepCloneable<BPC_TransData>
{
	private static readonly MessageParser<BPC_TransData> _parser = new MessageParser<BPC_TransData>(() => new BPC_TransData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int curActorResId_;

	public static MessageParser<BPC_TransData> Parser => _parser;

	public int CurActorResId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return curActorResId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			curActorResId_ = value;
		}
	}

	public bool HasCurActorResId => (_hasBits0 & 1) != 0;

	public BPC_TransData()
	{
	}

	public BPC_TransData(BPC_TransData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		curActorResId_ = other.curActorResId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BPC_TransData Clone()
	{
		return new BPC_TransData(this);
	}

	public void ClearCurActorResId()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BPC_TransData);
	}

	public bool Equals(BPC_TransData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurActorResId != other.CurActorResId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasCurActorResId)
		{
			num ^= CurActorResId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasCurActorResId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CurActorResId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasCurActorResId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurActorResId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BPC_TransData other)
	{
		if (other != null)
		{
			if (other.HasCurActorResId)
			{
				CurActorResId = other.CurActorResId;
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
				CurActorResId = input.ReadInt32();
			}
		}
	}
}
