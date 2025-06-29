using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgBagMultiplayerDropReq : IMessage<CSMsgBagMultiplayerDropReq>, IMessage, IEquatable<CSMsgBagMultiplayerDropReq>, IDeepCloneable<CSMsgBagMultiplayerDropReq>
{
	private static readonly MessageParser<CSMsgBagMultiplayerDropReq> _parser = new MessageParser<CSMsgBagMultiplayerDropReq>(() => new CSMsgBagMultiplayerDropReq());

	private UnknownFieldSet _unknownFields;

	private int multiplayerDropId_;

	private static readonly FieldCodec<ulong> _repeated_nearbyPlayers_codec = FieldCodec.ForUInt64(18u);

	private readonly RepeatedField<ulong> nearbyPlayers_ = new RepeatedField<ulong>();

	public static MessageParser<CSMsgBagMultiplayerDropReq> Parser => _parser;

	public int MultiplayerDropId
	{
		get
		{
			return multiplayerDropId_;
		}
		set
		{
			multiplayerDropId_ = value;
		}
	}

	public RepeatedField<ulong> NearbyPlayers => nearbyPlayers_;

	public CSMsgBagMultiplayerDropReq()
	{
	}

	public CSMsgBagMultiplayerDropReq(CSMsgBagMultiplayerDropReq other)
		: this()
	{
		multiplayerDropId_ = other.multiplayerDropId_;
		nearbyPlayers_ = other.nearbyPlayers_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagMultiplayerDropReq Clone()
	{
		return new CSMsgBagMultiplayerDropReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagMultiplayerDropReq);
	}

	public bool Equals(CSMsgBagMultiplayerDropReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MultiplayerDropId != other.MultiplayerDropId)
		{
			return false;
		}
		if (!nearbyPlayers_.Equals(other.nearbyPlayers_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MultiplayerDropId != 0)
		{
			num ^= MultiplayerDropId.GetHashCode();
		}
		num ^= nearbyPlayers_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MultiplayerDropId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MultiplayerDropId);
		}
		nearbyPlayers_.WriteTo(output, _repeated_nearbyPlayers_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MultiplayerDropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MultiplayerDropId);
		}
		num += nearbyPlayers_.CalculateSize(_repeated_nearbyPlayers_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagMultiplayerDropReq other)
	{
		if (other != null)
		{
			if (other.MultiplayerDropId != 0)
			{
				MultiplayerDropId = other.MultiplayerDropId;
			}
			nearbyPlayers_.Add(other.nearbyPlayers_);
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
				MultiplayerDropId = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				nearbyPlayers_.AddEntriesFrom(input, _repeated_nearbyPlayers_codec);
				break;
			}
		}
	}
}
