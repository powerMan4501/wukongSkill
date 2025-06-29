using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class EffectAttrListSyncWrapper : IMessage<EffectAttrListSyncWrapper>, IMessage, IEquatable<EffectAttrListSyncWrapper>, IDeepCloneable<EffectAttrListSyncWrapper>
{
	private static readonly MessageParser<EffectAttrListSyncWrapper> _parser = new MessageParser<EffectAttrListSyncWrapper>(() => new EffectAttrListSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<EffectAttrFloatSyncWrapper> _repeated_attrs_codec = FieldCodec.ForMessage(26u, EffectAttrFloatSyncWrapper.Parser);

	private readonly RepeatedField<EffectAttrFloatSyncWrapper> attrs_ = new RepeatedField<EffectAttrFloatSyncWrapper>();

	public static MessageParser<EffectAttrListSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public RepeatedField<EffectAttrFloatSyncWrapper> Attrs => attrs_;

	public EffectAttrListSyncWrapper()
	{
	}

	public EffectAttrListSyncWrapper(EffectAttrListSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		attrs_ = other.attrs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EffectAttrListSyncWrapper Clone()
	{
		return new EffectAttrListSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EffectAttrListSyncWrapper);
	}

	public bool Equals(EffectAttrListSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!attrs_.Equals(other.attrs_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		num ^= attrs_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		attrs_.WriteTo(output, _repeated_attrs_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		num += attrs_.CalculateSize(_repeated_attrs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EffectAttrListSyncWrapper other)
	{
		if (other != null)
		{
			if (other.SyncFlag != 0)
			{
				SyncFlag = other.SyncFlag;
			}
			if (other.SyncIdx != 0)
			{
				SyncIdx = other.SyncIdx;
			}
			attrs_.Add(other.attrs_);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				attrs_.AddEntriesFrom(input, _repeated_attrs_codec);
				break;
			}
		}
	}
}
