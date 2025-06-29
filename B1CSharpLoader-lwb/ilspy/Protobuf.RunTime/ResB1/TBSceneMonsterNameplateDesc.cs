using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBSceneMonsterNameplateDesc : IMessage<TBSceneMonsterNameplateDesc>, IMessage, IEquatable<TBSceneMonsterNameplateDesc>, IDeepCloneable<TBSceneMonsterNameplateDesc>
{
	private static readonly MessageParser<TBSceneMonsterNameplateDesc> _parser = new MessageParser<TBSceneMonsterNameplateDesc>(() => new TBSceneMonsterNameplateDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<SceneMonsterNameplateDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, SceneMonsterNameplateDesc.Parser);

	private readonly RepeatedField<SceneMonsterNameplateDesc> list_ = new RepeatedField<SceneMonsterNameplateDesc>();

	public static MessageParser<TBSceneMonsterNameplateDesc> Parser => _parser;

	public RepeatedField<SceneMonsterNameplateDesc> List => list_;

	public TBSceneMonsterNameplateDesc()
	{
	}

	public TBSceneMonsterNameplateDesc(TBSceneMonsterNameplateDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBSceneMonsterNameplateDesc Clone()
	{
		return new TBSceneMonsterNameplateDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBSceneMonsterNameplateDesc);
	}

	public bool Equals(TBSceneMonsterNameplateDesc other)
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

	public void MergeFrom(TBSceneMonsterNameplateDesc other)
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
