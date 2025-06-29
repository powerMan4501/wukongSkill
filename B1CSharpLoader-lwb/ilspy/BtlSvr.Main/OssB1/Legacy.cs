using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class Legacy : IMessage<Legacy>, IMessage, IEquatable<Legacy>, IDeepCloneable<Legacy>
{
	private static readonly MessageParser<Legacy> _parser = new MessageParser<Legacy>(() => new Legacy());

	private UnknownFieldSet _unknownFields;

	private int legacyId_;

	private static readonly FieldCodec<int> _repeated_talentIdList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> talentIdList_ = new RepeatedField<int>();

	public static MessageParser<Legacy> Parser => _parser;

	public int LegacyId
	{
		get
		{
			return legacyId_;
		}
		set
		{
			legacyId_ = value;
		}
	}

	public RepeatedField<int> TalentIdList => talentIdList_;

	public Legacy()
	{
	}

	public Legacy(Legacy other)
		: this()
	{
		legacyId_ = other.legacyId_;
		talentIdList_ = other.talentIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Legacy Clone()
	{
		return new Legacy(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Legacy);
	}

	public bool Equals(Legacy other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LegacyId != other.LegacyId)
		{
			return false;
		}
		if (!talentIdList_.Equals(other.talentIdList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LegacyId != 0)
		{
			num ^= LegacyId.GetHashCode();
		}
		num ^= talentIdList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LegacyId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LegacyId);
		}
		talentIdList_.WriteTo(output, _repeated_talentIdList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LegacyId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LegacyId);
		}
		num += talentIdList_.CalculateSize(_repeated_talentIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Legacy other)
	{
		if (other != null)
		{
			if (other.LegacyId != 0)
			{
				LegacyId = other.LegacyId;
			}
			talentIdList_.Add(other.talentIdList_);
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
				LegacyId = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				talentIdList_.AddEntriesFrom(input, _repeated_talentIdList_codec);
				break;
			}
		}
	}
}
