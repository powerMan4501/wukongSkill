using System;
using Google.Protobuf;

namespace GurCalliopeFsm;

public sealed class GI_Loading_WaitTick : IMessage<GI_Loading_WaitTick>, IMessage, IEquatable<GI_Loading_WaitTick>, IDeepCloneable<GI_Loading_WaitTick>
{
	private static readonly MessageParser<GI_Loading_WaitTick> _parser = new MessageParser<GI_Loading_WaitTick>(() => new GI_Loading_WaitTick());

	private UnknownFieldSet _unknownFields;

	private int waitTotalTick_;

	public static MessageParser<GI_Loading_WaitTick> Parser => _parser;

	public int WaitTotalTick
	{
		get
		{
			return waitTotalTick_;
		}
		set
		{
			waitTotalTick_ = value;
		}
	}

	public GI_Loading_WaitTick()
	{
	}

	public GI_Loading_WaitTick(GI_Loading_WaitTick other)
		: this()
	{
		waitTotalTick_ = other.waitTotalTick_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Loading_WaitTick Clone()
	{
		return new GI_Loading_WaitTick(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Loading_WaitTick);
	}

	public bool Equals(GI_Loading_WaitTick other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WaitTotalTick != other.WaitTotalTick)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (WaitTotalTick != 0)
		{
			num ^= WaitTotalTick.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (WaitTotalTick != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(WaitTotalTick);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (WaitTotalTick != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WaitTotalTick);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Loading_WaitTick other)
	{
		if (other != null)
		{
			if (other.WaitTotalTick != 0)
			{
				WaitTotalTick = other.WaitTotalTick;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				WaitTotalTick = input.ReadInt32();
			}
		}
	}
}
