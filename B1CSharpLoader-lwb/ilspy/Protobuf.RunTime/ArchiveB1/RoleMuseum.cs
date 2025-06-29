using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleMuseum : IMessage<RoleMuseum>, IMessage, IEquatable<RoleMuseum>, IDeepCloneable<RoleMuseum>
{
	private static readonly MessageParser<RoleMuseum> _parser = new MessageParser<RoleMuseum>(() => new RoleMuseum());

	private UnknownFieldSet _unknownFields;

	private MuseumRedPoint redPoint_;

	private GlobalData globalData_;

	private static readonly FieldCodec<int> _repeated_mvIdList_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> mvIdList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_soundtrackIdList_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> soundtrackIdList_ = new RepeatedField<int>();

	public static MessageParser<RoleMuseum> Parser => _parser;

	public MuseumRedPoint RedPoint
	{
		get
		{
			return redPoint_;
		}
		set
		{
			redPoint_ = value;
		}
	}

	public GlobalData GlobalData
	{
		get
		{
			return globalData_;
		}
		set
		{
			globalData_ = value;
		}
	}

	public RepeatedField<int> MvIdList => mvIdList_;

	public RepeatedField<int> SoundtrackIdList => soundtrackIdList_;

	public RoleMuseum()
	{
	}

	public RoleMuseum(RoleMuseum other)
		: this()
	{
		redPoint_ = ((other.redPoint_ != null) ? other.redPoint_.Clone() : null);
		globalData_ = ((other.globalData_ != null) ? other.globalData_.Clone() : null);
		mvIdList_ = other.mvIdList_.Clone();
		soundtrackIdList_ = other.soundtrackIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleMuseum Clone()
	{
		return new RoleMuseum(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleMuseum);
	}

	public bool Equals(RoleMuseum other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RedPoint, other.RedPoint))
		{
			return false;
		}
		if (!object.Equals(GlobalData, other.GlobalData))
		{
			return false;
		}
		if (!mvIdList_.Equals(other.mvIdList_))
		{
			return false;
		}
		if (!soundtrackIdList_.Equals(other.soundtrackIdList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (redPoint_ != null)
		{
			num ^= RedPoint.GetHashCode();
		}
		if (globalData_ != null)
		{
			num ^= GlobalData.GetHashCode();
		}
		num ^= mvIdList_.GetHashCode();
		num ^= soundtrackIdList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (redPoint_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(RedPoint);
		}
		if (globalData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(GlobalData);
		}
		mvIdList_.WriteTo(output, _repeated_mvIdList_codec);
		soundtrackIdList_.WriteTo(output, _repeated_soundtrackIdList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (redPoint_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RedPoint);
		}
		if (globalData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GlobalData);
		}
		num += mvIdList_.CalculateSize(_repeated_mvIdList_codec);
		num += soundtrackIdList_.CalculateSize(_repeated_soundtrackIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleMuseum other)
	{
		if (other == null)
		{
			return;
		}
		if (other.redPoint_ != null)
		{
			if (redPoint_ == null)
			{
				RedPoint = new MuseumRedPoint();
			}
			RedPoint.MergeFrom(other.RedPoint);
		}
		if (other.globalData_ != null)
		{
			if (globalData_ == null)
			{
				GlobalData = new GlobalData();
			}
			GlobalData.MergeFrom(other.GlobalData);
		}
		mvIdList_.Add(other.mvIdList_);
		soundtrackIdList_.Add(other.soundtrackIdList_);
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
			case 42u:
				if (redPoint_ == null)
				{
					RedPoint = new MuseumRedPoint();
				}
				input.ReadMessage(RedPoint);
				break;
			case 50u:
				if (globalData_ == null)
				{
					GlobalData = new GlobalData();
				}
				input.ReadMessage(GlobalData);
				break;
			case 56u:
			case 58u:
				mvIdList_.AddEntriesFrom(input, _repeated_mvIdList_codec);
				break;
			case 64u:
			case 66u:
				soundtrackIdList_.AddEntriesFrom(input, _repeated_soundtrackIdList_codec);
				break;
			}
		}
	}
}
