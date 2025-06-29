using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitSoulCamera : IMessage<FUStUnitSoulCamera>, IMessage, IEquatable<FUStUnitSoulCamera>, IDeepCloneable<FUStUnitSoulCamera>
{
	private static readonly MessageParser<FUStUnitSoulCamera> _parser = new MessageParser<FUStUnitSoulCamera>(() => new FUStUnitSoulCamera());

	private UnknownFieldSet _unknownFields;

	private int resID_;

	private int soulCameraID_;

	public static MessageParser<FUStUnitSoulCamera> Parser => _parser;

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public int SoulCameraID
	{
		get
		{
			return soulCameraID_;
		}
		set
		{
			soulCameraID_ = value;
		}
	}

	public FUStUnitSoulCamera()
	{
	}

	public FUStUnitSoulCamera(FUStUnitSoulCamera other)
		: this()
	{
		resID_ = other.resID_;
		soulCameraID_ = other.soulCameraID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitSoulCamera Clone()
	{
		return new FUStUnitSoulCamera(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitSoulCamera);
	}

	public bool Equals(FUStUnitSoulCamera other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ResID != other.ResID)
		{
			return false;
		}
		if (SoulCameraID != other.SoulCameraID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (SoulCameraID != 0)
		{
			num ^= SoulCameraID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ResID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ResID);
		}
		if (SoulCameraID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SoulCameraID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (SoulCameraID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoulCameraID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitSoulCamera other)
	{
		if (other != null)
		{
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.SoulCameraID != 0)
			{
				SoulCameraID = other.SoulCameraID;
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
				ResID = input.ReadInt32();
				break;
			case 16u:
				SoulCameraID = input.ReadInt32();
				break;
			}
		}
	}
}
