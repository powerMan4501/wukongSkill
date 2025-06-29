using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class GI_Loading_LoadingUIFadeIn : IMessage<GI_Loading_LoadingUIFadeIn>, IMessage, IEquatable<GI_Loading_LoadingUIFadeIn>, IDeepCloneable<GI_Loading_LoadingUIFadeIn>
{
	private static readonly MessageParser<GI_Loading_LoadingUIFadeIn> _parser = new MessageParser<GI_Loading_LoadingUIFadeIn>(() => new GI_Loading_LoadingUIFadeIn());

	private UnknownFieldSet _unknownFields;

	private int waitTick_;

	private int reason_;

	public static MessageParser<GI_Loading_LoadingUIFadeIn> Parser => _parser;

	public int WaitTick
	{
		get
		{
			return waitTick_;
		}
		set
		{
			waitTick_ = value;
		}
	}

	public int Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	public GI_Loading_LoadingUIFadeIn()
	{
	}

	public GI_Loading_LoadingUIFadeIn(GI_Loading_LoadingUIFadeIn other)
		: this()
	{
		waitTick_ = other.waitTick_;
		reason_ = other.reason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Loading_LoadingUIFadeIn Clone()
	{
		return new GI_Loading_LoadingUIFadeIn(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Loading_LoadingUIFadeIn);
	}

	public bool Equals(GI_Loading_LoadingUIFadeIn other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WaitTick != other.WaitTick)
		{
			return false;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (WaitTick != 0)
		{
			num ^= WaitTick.GetHashCode();
		}
		if (Reason != 0)
		{
			num ^= Reason.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (WaitTick != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(WaitTick);
		}
		if (Reason != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Reason);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (WaitTick != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WaitTick);
		}
		if (Reason != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Reason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Loading_LoadingUIFadeIn other)
	{
		if (other != null)
		{
			if (other.WaitTick != 0)
			{
				WaitTick = other.WaitTick;
			}
			if (other.Reason != 0)
			{
				Reason = other.Reason;
			}
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
				WaitTick = input.ReadInt32();
				break;
			case 16u:
				Reason = input.ReadInt32();
				break;
			}
		}
	}
}
