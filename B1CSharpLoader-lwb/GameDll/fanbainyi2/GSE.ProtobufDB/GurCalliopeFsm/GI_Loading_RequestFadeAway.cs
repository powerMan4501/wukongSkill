using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurCalliopeFsm;

public sealed class GI_Loading_RequestFadeAway : IMessage<GI_Loading_RequestFadeAway>, IMessage, IEquatable<GI_Loading_RequestFadeAway>, IDeepCloneable<GI_Loading_RequestFadeAway>
{
	private static readonly MessageParser<GI_Loading_RequestFadeAway> _parser = new MessageParser<GI_Loading_RequestFadeAway>(() => new GI_Loading_RequestFadeAway());

	private UnknownFieldSet _unknownFields;

	private float waitSecond_;

	public static MessageParser<GI_Loading_RequestFadeAway> Parser => _parser;

	public float WaitSecond
	{
		get
		{
			return waitSecond_;
		}
		set
		{
			waitSecond_ = value;
		}
	}

	public GI_Loading_RequestFadeAway()
	{
	}

	public GI_Loading_RequestFadeAway(GI_Loading_RequestFadeAway other)
		: this()
	{
		waitSecond_ = other.waitSecond_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GI_Loading_RequestFadeAway Clone()
	{
		return new GI_Loading_RequestFadeAway(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GI_Loading_RequestFadeAway);
	}

	public bool Equals(GI_Loading_RequestFadeAway other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(WaitSecond, other.WaitSecond))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (WaitSecond != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(WaitSecond);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (WaitSecond != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(WaitSecond);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (WaitSecond != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GI_Loading_RequestFadeAway other)
	{
		if (other != null)
		{
			if (other.WaitSecond != 0f)
			{
				WaitSecond = other.WaitSecond;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 13)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				WaitSecond = input.ReadFloat();
			}
		}
	}
}
