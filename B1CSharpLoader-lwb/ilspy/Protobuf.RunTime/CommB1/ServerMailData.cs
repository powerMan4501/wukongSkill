using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class ServerMailData : IMessage<ServerMailData>, IMessage, IEquatable<ServerMailData>, IDeepCloneable<ServerMailData>
{
	private static readonly MessageParser<ServerMailData> _parser = new MessageParser<ServerMailData>(() => new ServerMailData());

	private UnknownFieldSet _unknownFields;

	private uint lastCheckTime_;

	private uint seq_;

	private ulong maxId_;

	private YesNoType isReady_;

	private static readonly FieldCodec<AwolMsgServerMail> _repeated_mails_codec = FieldCodec.ForMessage(42u, AwolMsgServerMail.Parser);

	private readonly RepeatedField<AwolMsgServerMail> mails_ = new RepeatedField<AwolMsgServerMail>();

	public static MessageParser<ServerMailData> Parser => _parser;

	public uint LastCheckTime
	{
		get
		{
			return lastCheckTime_;
		}
		set
		{
			lastCheckTime_ = value;
		}
	}

	public uint Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	public ulong MaxId
	{
		get
		{
			return maxId_;
		}
		set
		{
			maxId_ = value;
		}
	}

	public YesNoType IsReady
	{
		get
		{
			return isReady_;
		}
		set
		{
			isReady_ = value;
		}
	}

	public RepeatedField<AwolMsgServerMail> Mails => mails_;

	public ServerMailData()
	{
	}

	public ServerMailData(ServerMailData other)
		: this()
	{
		lastCheckTime_ = other.lastCheckTime_;
		seq_ = other.seq_;
		maxId_ = other.maxId_;
		isReady_ = other.isReady_;
		mails_ = other.mails_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ServerMailData Clone()
	{
		return new ServerMailData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ServerMailData);
	}

	public bool Equals(ServerMailData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LastCheckTime != other.LastCheckTime)
		{
			return false;
		}
		if (Seq != other.Seq)
		{
			return false;
		}
		if (MaxId != other.MaxId)
		{
			return false;
		}
		if (IsReady != other.IsReady)
		{
			return false;
		}
		if (!mails_.Equals(other.mails_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LastCheckTime != 0)
		{
			num ^= LastCheckTime.GetHashCode();
		}
		if (Seq != 0)
		{
			num ^= Seq.GetHashCode();
		}
		if (MaxId != 0L)
		{
			num ^= MaxId.GetHashCode();
		}
		if (IsReady != YesNoType.No)
		{
			num ^= IsReady.GetHashCode();
		}
		num ^= mails_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LastCheckTime != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LastCheckTime);
		}
		if (Seq != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Seq);
		}
		if (MaxId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(MaxId);
		}
		if (IsReady != YesNoType.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)IsReady);
		}
		mails_.WriteTo(output, _repeated_mails_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LastCheckTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LastCheckTime);
		}
		if (Seq != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Seq);
		}
		if (MaxId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MaxId);
		}
		if (IsReady != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsReady);
		}
		num += mails_.CalculateSize(_repeated_mails_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ServerMailData other)
	{
		if (other != null)
		{
			if (other.LastCheckTime != 0)
			{
				LastCheckTime = other.LastCheckTime;
			}
			if (other.Seq != 0)
			{
				Seq = other.Seq;
			}
			if (other.MaxId != 0L)
			{
				MaxId = other.MaxId;
			}
			if (other.IsReady != YesNoType.No)
			{
				IsReady = other.IsReady;
			}
			mails_.Add(other.mails_);
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
				LastCheckTime = input.ReadUInt32();
				break;
			case 16u:
				Seq = input.ReadUInt32();
				break;
			case 24u:
				MaxId = input.ReadUInt64();
				break;
			case 32u:
				IsReady = (YesNoType)input.ReadEnum();
				break;
			case 42u:
				mails_.AddEntriesFrom(input, _repeated_mails_codec);
				break;
			}
		}
	}
}
