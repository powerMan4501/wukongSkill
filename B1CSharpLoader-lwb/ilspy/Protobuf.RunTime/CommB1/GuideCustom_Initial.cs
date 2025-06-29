using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class GuideCustom_Initial : IMessage<GuideCustom_Initial>, IMessage, IEquatable<GuideCustom_Initial>, IDeepCloneable<GuideCustom_Initial>
{
	private static readonly MessageParser<GuideCustom_Initial> _parser = new MessageParser<GuideCustom_Initial>(() => new GuideCustom_Initial());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ProcessCustom_Param> _repeated_assetParams_codec = FieldCodec.ForMessage(10u, ProcessCustom_Param.Parser);

	private readonly RepeatedField<ProcessCustom_Param> assetParams_ = new RepeatedField<ProcessCustom_Param>();

	public static MessageParser<GuideCustom_Initial> Parser => _parser;

	public RepeatedField<ProcessCustom_Param> AssetParams => assetParams_;

	public GuideCustom_Initial()
	{
	}

	public GuideCustom_Initial(GuideCustom_Initial other)
		: this()
	{
		assetParams_ = other.assetParams_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GuideCustom_Initial Clone()
	{
		return new GuideCustom_Initial(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GuideCustom_Initial);
	}

	public bool Equals(GuideCustom_Initial other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!assetParams_.Equals(other.assetParams_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= assetParams_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		assetParams_.WriteTo(output, _repeated_assetParams_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += assetParams_.CalculateSize(_repeated_assetParams_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GuideCustom_Initial other)
	{
		if (other != null)
		{
			assetParams_.Add(other.assetParams_);
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
				assetParams_.AddEntriesFrom(input, _repeated_assetParams_codec);
			}
		}
	}
}
