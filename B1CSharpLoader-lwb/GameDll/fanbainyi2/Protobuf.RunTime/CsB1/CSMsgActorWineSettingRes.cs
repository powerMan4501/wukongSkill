using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorWineSettingRes : IMessage<CSMsgActorWineSettingRes>, IMessage, IEquatable<CSMsgActorWineSettingRes>, IDeepCloneable<CSMsgActorWineSettingRes>
{
	private static readonly MessageParser<CSMsgActorWineSettingRes> _parser = new MessageParser<CSMsgActorWineSettingRes>(() => new CSMsgActorWineSettingRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorWineSettingRes> Parser => _parser;

	public CSMsgActorWineSettingRes()
	{
	}

	public CSMsgActorWineSettingRes(CSMsgActorWineSettingRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorWineSettingRes Clone()
	{
		return new CSMsgActorWineSettingRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorWineSettingRes);
	}

	public bool Equals(CSMsgActorWineSettingRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorWineSettingRes other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
