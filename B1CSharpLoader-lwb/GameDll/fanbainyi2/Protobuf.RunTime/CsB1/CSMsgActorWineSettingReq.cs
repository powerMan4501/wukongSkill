using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorWineSettingReq : IMessage<CSMsgActorWineSettingReq>, IMessage, IEquatable<CSMsgActorWineSettingReq>, IDeepCloneable<CSMsgActorWineSettingReq>
{
	private static readonly MessageParser<CSMsgActorWineSettingReq> _parser = new MessageParser<CSMsgActorWineSettingReq>(() => new CSMsgActorWineSettingReq());

	private UnknownFieldSet _unknownFields;

	private int wineId_;

	public static MessageParser<CSMsgActorWineSettingReq> Parser => _parser;

	public int WineId
	{
		get
		{
			return wineId_;
		}
		set
		{
			wineId_ = value;
		}
	}

	public CSMsgActorWineSettingReq()
	{
	}

	public CSMsgActorWineSettingReq(CSMsgActorWineSettingReq other)
		: this()
	{
		wineId_ = other.wineId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorWineSettingReq Clone()
	{
		return new CSMsgActorWineSettingReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorWineSettingReq);
	}

	public bool Equals(CSMsgActorWineSettingReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WineId != other.WineId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (WineId != 0)
		{
			num ^= WineId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (WineId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(WineId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (WineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WineId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorWineSettingReq other)
	{
		if (other != null)
		{
			if (other.WineId != 0)
			{
				WineId = other.WineId;
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
				WineId = input.ReadInt32();
			}
		}
	}
}
