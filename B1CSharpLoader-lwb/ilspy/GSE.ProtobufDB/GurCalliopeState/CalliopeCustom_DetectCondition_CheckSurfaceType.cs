using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition_CheckSurfaceType : IMessage<CalliopeCustom_DetectCondition_CheckSurfaceType>, IMessage, IEquatable<CalliopeCustom_DetectCondition_CheckSurfaceType>, IDeepCloneable<CalliopeCustom_DetectCondition_CheckSurfaceType>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition_CheckSurfaceType> _parser = new MessageParser<CalliopeCustom_DetectCondition_CheckSurfaceType>(() => new CalliopeCustom_DetectCondition_CheckSurfaceType());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int surfaceType_;

	public static MessageParser<CalliopeCustom_DetectCondition_CheckSurfaceType> Parser => _parser;

	public int SurfaceType
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return surfaceType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			surfaceType_ = value;
		}
	}

	public bool HasSurfaceType => (_hasBits0 & 1) != 0;

	public CalliopeCustom_DetectCondition_CheckSurfaceType()
	{
	}

	public CalliopeCustom_DetectCondition_CheckSurfaceType(CalliopeCustom_DetectCondition_CheckSurfaceType other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		surfaceType_ = other.surfaceType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition_CheckSurfaceType Clone()
	{
		return new CalliopeCustom_DetectCondition_CheckSurfaceType(this);
	}

	public void ClearSurfaceType()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition_CheckSurfaceType);
	}

	public bool Equals(CalliopeCustom_DetectCondition_CheckSurfaceType other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SurfaceType != other.SurfaceType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasSurfaceType)
		{
			num ^= SurfaceType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasSurfaceType)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SurfaceType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasSurfaceType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SurfaceType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition_CheckSurfaceType other)
	{
		if (other != null)
		{
			if (other.HasSurfaceType)
			{
				SurfaceType = other.SurfaceType;
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
				SurfaceType = input.ReadInt32();
			}
		}
	}
}
