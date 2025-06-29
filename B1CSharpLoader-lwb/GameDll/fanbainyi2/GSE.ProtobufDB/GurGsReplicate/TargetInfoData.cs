using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class TargetInfoData : IMessage<TargetInfoData>, IMessage, IEquatable<TargetInfoData>, IDeepCloneable<TargetInfoData>
{
	private static readonly MessageParser<TargetInfoData> _parser = new MessageParser<TargetInfoData>(() => new TargetInfoData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ClassDeltaMsgUnitLockTargetInfo> _repeated_targetInfo_codec = FieldCodec.ForMessage(10u, ClassDeltaMsgUnitLockTargetInfo.Parser);

	private readonly RepeatedField<ClassDeltaMsgUnitLockTargetInfo> targetInfo_ = new RepeatedField<ClassDeltaMsgUnitLockTargetInfo>();

	public static MessageParser<TargetInfoData> Parser => _parser;

	public RepeatedField<ClassDeltaMsgUnitLockTargetInfo> TargetInfo => targetInfo_;

	public TargetInfoData()
	{
	}

	public TargetInfoData(TargetInfoData other)
		: this()
	{
		targetInfo_ = other.targetInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TargetInfoData Clone()
	{
		return new TargetInfoData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TargetInfoData);
	}

	public bool Equals(TargetInfoData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!targetInfo_.Equals(other.targetInfo_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= targetInfo_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		targetInfo_.WriteTo(output, _repeated_targetInfo_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += targetInfo_.CalculateSize(_repeated_targetInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TargetInfoData other)
	{
		if (other != null)
		{
			targetInfo_.Add(other.targetInfo_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				targetInfo_.AddEntriesFrom(input, _repeated_targetInfo_codec);
			}
		}
	}
}
