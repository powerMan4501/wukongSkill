using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBSoulSkillDropDesc : IMessage<TBSoulSkillDropDesc>, IMessage, IEquatable<TBSoulSkillDropDesc>, IDeepCloneable<TBSoulSkillDropDesc>
{
	private static readonly MessageParser<TBSoulSkillDropDesc> _parser = new MessageParser<TBSoulSkillDropDesc>(() => new TBSoulSkillDropDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<SoulSkillDropDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, SoulSkillDropDesc.Parser);

	private readonly RepeatedField<SoulSkillDropDesc> list_ = new RepeatedField<SoulSkillDropDesc>();

	public static MessageParser<TBSoulSkillDropDesc> Parser => _parser;

	public RepeatedField<SoulSkillDropDesc> List => list_;

	public TBSoulSkillDropDesc()
	{
	}

	public TBSoulSkillDropDesc(TBSoulSkillDropDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBSoulSkillDropDesc Clone()
	{
		return new TBSoulSkillDropDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBSoulSkillDropDesc);
	}

	public bool Equals(TBSoulSkillDropDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!list_.Equals(other.list_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= list_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		list_.WriteTo(output, _repeated_list_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += list_.CalculateSize(_repeated_list_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TBSoulSkillDropDesc other)
	{
		if (other != null)
		{
			list_.Add(other.list_);
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
				list_.AddEntriesFrom(input, _repeated_list_codec);
			}
		}
	}
}
