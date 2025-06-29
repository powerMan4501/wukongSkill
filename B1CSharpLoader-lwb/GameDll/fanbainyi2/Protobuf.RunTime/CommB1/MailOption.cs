using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MailOption : IMessage<MailOption>, IMessage, IEquatable<MailOption>, IDeepCloneable<MailOption>
{
	private static readonly MessageParser<MailOption> _parser = new MessageParser<MailOption>(() => new MailOption());

	private UnknownFieldSet _unknownFields;

	private MailFilter filter_;

	private uint expireTimestamp_;

	private uint startTimestamp_;

	private uint keepTime_;

	private uint isFetchDelete_;

	public static MessageParser<MailOption> Parser => _parser;

	public MailFilter Filter
	{
		get
		{
			return filter_;
		}
		set
		{
			filter_ = value;
		}
	}

	public uint ExpireTimestamp
	{
		get
		{
			return expireTimestamp_;
		}
		set
		{
			expireTimestamp_ = value;
		}
	}

	public uint StartTimestamp
	{
		get
		{
			return startTimestamp_;
		}
		set
		{
			startTimestamp_ = value;
		}
	}

	public uint KeepTime
	{
		get
		{
			return keepTime_;
		}
		set
		{
			keepTime_ = value;
		}
	}

	public uint IsFetchDelete
	{
		get
		{
			return isFetchDelete_;
		}
		set
		{
			isFetchDelete_ = value;
		}
	}

	public MailOption()
	{
	}

	public MailOption(MailOption other)
		: this()
	{
		filter_ = ((other.filter_ != null) ? other.filter_.Clone() : null);
		expireTimestamp_ = other.expireTimestamp_;
		startTimestamp_ = other.startTimestamp_;
		keepTime_ = other.keepTime_;
		isFetchDelete_ = other.isFetchDelete_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailOption Clone()
	{
		return new MailOption(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailOption);
	}

	public bool Equals(MailOption other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Filter, other.Filter))
		{
			return false;
		}
		if (ExpireTimestamp != other.ExpireTimestamp)
		{
			return false;
		}
		if (StartTimestamp != other.StartTimestamp)
		{
			return false;
		}
		if (KeepTime != other.KeepTime)
		{
			return false;
		}
		if (IsFetchDelete != other.IsFetchDelete)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (filter_ != null)
		{
			num ^= Filter.GetHashCode();
		}
		if (ExpireTimestamp != 0)
		{
			num ^= ExpireTimestamp.GetHashCode();
		}
		if (StartTimestamp != 0)
		{
			num ^= StartTimestamp.GetHashCode();
		}
		if (KeepTime != 0)
		{
			num ^= KeepTime.GetHashCode();
		}
		if (IsFetchDelete != 0)
		{
			num ^= IsFetchDelete.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (filter_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Filter);
		}
		if (ExpireTimestamp != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ExpireTimestamp);
		}
		if (StartTimestamp != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(StartTimestamp);
		}
		if (KeepTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(KeepTime);
		}
		if (IsFetchDelete != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(IsFetchDelete);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (filter_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Filter);
		}
		if (ExpireTimestamp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ExpireTimestamp);
		}
		if (StartTimestamp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StartTimestamp);
		}
		if (KeepTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KeepTime);
		}
		if (IsFetchDelete != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IsFetchDelete);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailOption other)
	{
		if (other == null)
		{
			return;
		}
		if (other.filter_ != null)
		{
			if (filter_ == null)
			{
				Filter = new MailFilter();
			}
			Filter.MergeFrom(other.Filter);
		}
		if (other.ExpireTimestamp != 0)
		{
			ExpireTimestamp = other.ExpireTimestamp;
		}
		if (other.StartTimestamp != 0)
		{
			StartTimestamp = other.StartTimestamp;
		}
		if (other.KeepTime != 0)
		{
			KeepTime = other.KeepTime;
		}
		if (other.IsFetchDelete != 0)
		{
			IsFetchDelete = other.IsFetchDelete;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (filter_ == null)
				{
					Filter = new MailFilter();
				}
				input.ReadMessage(Filter);
				break;
			case 16u:
				ExpireTimestamp = input.ReadUInt32();
				break;
			case 24u:
				StartTimestamp = input.ReadUInt32();
				break;
			case 32u:
				KeepTime = input.ReadUInt32();
				break;
			case 40u:
				IsFetchDelete = input.ReadUInt32();
				break;
			}
		}
	}
}
