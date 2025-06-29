using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPartDamagedInfo : IMessage<FUStPartDamagedInfo>, IMessage, IEquatable<FUStPartDamagedInfo>, IDeepCloneable<FUStPartDamagedInfo>
{
	private static readonly MessageParser<FUStPartDamagedInfo> _parser = new MessageParser<FUStPartDamagedInfo>(() => new FUStPartDamagedInfo());

	private UnknownFieldSet _unknownFields;

	private float damagedValueRatio_;

	public static MessageParser<FUStPartDamagedInfo> Parser => _parser;

	public float DamagedValueRatio
	{
		get
		{
			return damagedValueRatio_;
		}
		set
		{
			damagedValueRatio_ = value;
		}
	}

	public FUStPartDamagedInfo()
	{
	}

	public FUStPartDamagedInfo(FUStPartDamagedInfo other)
		: this()
	{
		damagedValueRatio_ = other.damagedValueRatio_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPartDamagedInfo Clone()
	{
		return new FUStPartDamagedInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPartDamagedInfo);
	}

	public bool Equals(FUStPartDamagedInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DamagedValueRatio, other.DamagedValueRatio))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DamagedValueRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DamagedValueRatio);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DamagedValueRatio != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(DamagedValueRatio);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DamagedValueRatio != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPartDamagedInfo other)
	{
		if (other != null)
		{
			if (other.DamagedValueRatio != 0f)
			{
				DamagedValueRatio = other.DamagedValueRatio;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 13)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				DamagedValueRatio = input.ReadFloat();
			}
		}
	}
}
