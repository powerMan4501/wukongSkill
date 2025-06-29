using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStGlobalConfigDesc : IMessage<FUStGlobalConfigDesc>, IMessage, IEquatable<FUStGlobalConfigDesc>, IDeepCloneable<FUStGlobalConfigDesc>
{
	private static readonly MessageParser<FUStGlobalConfigDesc> _parser = new MessageParser<FUStGlobalConfigDesc>(() => new FUStGlobalConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private FUStGlobalConfigInfo configInfo_;

	public static MessageParser<FUStGlobalConfigDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public FUStGlobalConfigInfo ConfigInfo
	{
		get
		{
			return configInfo_;
		}
		set
		{
			configInfo_ = value;
		}
	}

	public FUStGlobalConfigDesc()
	{
	}

	public FUStGlobalConfigDesc(FUStGlobalConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		configInfo_ = ((other.configInfo_ != null) ? other.configInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStGlobalConfigDesc Clone()
	{
		return new FUStGlobalConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStGlobalConfigDesc);
	}

	public bool Equals(FUStGlobalConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (!object.Equals(ConfigInfo, other.ConfigInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (configInfo_ != null)
		{
			num ^= ConfigInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (configInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ConfigInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (configInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ConfigInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStGlobalConfigDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.configInfo_ != null)
		{
			if (configInfo_ == null)
			{
				ConfigInfo = new FUStGlobalConfigInfo();
			}
			ConfigInfo.MergeFrom(other.ConfigInfo);
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
			case 8u:
				ID = input.ReadInt32();
				break;
			case 18u:
				if (configInfo_ == null)
				{
					ConfigInfo = new FUStGlobalConfigInfo();
				}
				input.ReadMessage(ConfigInfo);
				break;
			}
		}
	}
}
