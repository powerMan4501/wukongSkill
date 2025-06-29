using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_SpawnSocketAttachTamer : IMessage<BehaviorCustom_SpawnSocketAttachTamer>, IMessage, IEquatable<BehaviorCustom_SpawnSocketAttachTamer>, IDeepCloneable<BehaviorCustom_SpawnSocketAttachTamer>
{
	private static readonly MessageParser<BehaviorCustom_SpawnSocketAttachTamer> _parser = new MessageParser<BehaviorCustom_SpawnSocketAttachTamer>(() => new BehaviorCustom_SpawnSocketAttachTamer());

	private UnknownFieldSet _unknownFields;

	private ByteString matchInfo_ = ByteString.Empty;

	public static MessageParser<BehaviorCustom_SpawnSocketAttachTamer> Parser => _parser;

	public ByteString MatchInfo
	{
		get
		{
			return matchInfo_;
		}
		set
		{
			matchInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_SpawnSocketAttachTamer()
	{
	}

	public BehaviorCustom_SpawnSocketAttachTamer(BehaviorCustom_SpawnSocketAttachTamer other)
		: this()
	{
		matchInfo_ = other.matchInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_SpawnSocketAttachTamer Clone()
	{
		return new BehaviorCustom_SpawnSocketAttachTamer(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_SpawnSocketAttachTamer);
	}

	public bool Equals(BehaviorCustom_SpawnSocketAttachTamer other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MatchInfo != other.MatchInfo)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MatchInfo.Length != 0)
		{
			num ^= MatchInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MatchInfo.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteBytes(MatchInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MatchInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(MatchInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_SpawnSocketAttachTamer other)
	{
		if (other != null)
		{
			if (other.MatchInfo.Length != 0)
			{
				MatchInfo = other.MatchInfo;
			}
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
				MatchInfo = input.ReadBytes();
			}
		}
	}
}
