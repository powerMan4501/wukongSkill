using System;
using Google.Protobuf;

namespace GurGsReplicate;

public sealed class ObjActorMovementData : IMessage<ObjActorMovementData>, IMessage, IEquatable<ObjActorMovementData>, IDeepCloneable<ObjActorMovementData>
{
	private static readonly MessageParser<ObjActorMovementData> _parser = new MessageParser<ObjActorMovementData>(() => new ObjActorMovementData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private bool useSimpleMove_;

	public static MessageParser<ObjActorMovementData> Parser => _parser;

	public bool UseSimpleMove
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return useSimpleMove_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 1;
			useSimpleMove_ = value;
		}
	}

	public bool HasUseSimpleMove => (_hasBits0 & 1) != 0;

	public ObjActorMovementData()
	{
	}

	public ObjActorMovementData(ObjActorMovementData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		useSimpleMove_ = other.useSimpleMove_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ObjActorMovementData Clone()
	{
		return new ObjActorMovementData(this);
	}

	public void ClearUseSimpleMove()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as ObjActorMovementData);
	}

	public bool Equals(ObjActorMovementData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UseSimpleMove != other.UseSimpleMove)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasUseSimpleMove)
		{
			num ^= UseSimpleMove.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasUseSimpleMove)
		{
			output.WriteRawTag(8);
			output.WriteBool(UseSimpleMove);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasUseSimpleMove)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ObjActorMovementData other)
	{
		if (other != null)
		{
			if (other.HasUseSimpleMove)
			{
				UseSimpleMove = other.UseSimpleMove;
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
				UseSimpleMove = input.ReadBool();
			}
		}
	}
}
