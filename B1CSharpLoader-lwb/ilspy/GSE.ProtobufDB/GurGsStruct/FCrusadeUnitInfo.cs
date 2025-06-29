using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class FCrusadeUnitInfo : IMessage<FCrusadeUnitInfo>, IMessage, IEquatable<FCrusadeUnitInfo>, IDeepCloneable<FCrusadeUnitInfo>
{
	private static readonly MessageParser<FCrusadeUnitInfo> _parser = new MessageParser<FCrusadeUnitInfo>(() => new FCrusadeUnitInfo());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int crusadeState_;

	public static MessageParser<FCrusadeUnitInfo> Parser => _parser;

	public int CrusadeState
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return crusadeState_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			crusadeState_ = value;
		}
	}

	public bool HasCrusadeState => (_hasBits0 & 1) != 0;

	public FCrusadeUnitInfo()
	{
	}

	public FCrusadeUnitInfo(FCrusadeUnitInfo other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		crusadeState_ = other.crusadeState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FCrusadeUnitInfo Clone()
	{
		return new FCrusadeUnitInfo(this);
	}

	public void ClearCrusadeState()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as FCrusadeUnitInfo);
	}

	public bool Equals(FCrusadeUnitInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CrusadeState != other.CrusadeState)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasCrusadeState)
		{
			num ^= CrusadeState.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasCrusadeState)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CrusadeState);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasCrusadeState)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CrusadeState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FCrusadeUnitInfo other)
	{
		if (other != null)
		{
			if (other.HasCrusadeState)
			{
				CrusadeState = other.CrusadeState;
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
				CrusadeState = input.ReadInt32();
			}
		}
	}
}
