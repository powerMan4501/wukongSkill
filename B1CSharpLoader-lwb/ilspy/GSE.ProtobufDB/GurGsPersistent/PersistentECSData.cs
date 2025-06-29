using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class PersistentECSData : IMessage<PersistentECSData>, IMessage, IEquatable<PersistentECSData>, IDeepCloneable<PersistentECSData>
{
	private static readonly MessageParser<PersistentECSData> _parser = new MessageParser<PersistentECSData>(() => new PersistentECSData());

	private UnknownFieldSet _unknownFields;

	private PersistentBGCData bGCData_;

	private PersistentBPCData bPCData_;

	private static readonly FieldCodec<PersistentBUCDataWithLevel> _repeated_bUCData_codec = FieldCodec.ForMessage(26u, PersistentBUCDataWithLevel.Parser);

	private readonly RepeatedField<PersistentBUCDataWithLevel> bUCData_ = new RepeatedField<PersistentBUCDataWithLevel>();

	public static MessageParser<PersistentECSData> Parser => _parser;

	public PersistentBGCData BGCData
	{
		get
		{
			return bGCData_;
		}
		set
		{
			bGCData_ = value;
		}
	}

	public PersistentBPCData BPCData
	{
		get
		{
			return bPCData_;
		}
		set
		{
			bPCData_ = value;
		}
	}

	public RepeatedField<PersistentBUCDataWithLevel> BUCData => bUCData_;

	public PersistentECSData()
	{
	}

	public PersistentECSData(PersistentECSData other)
		: this()
	{
		bGCData_ = ((other.bGCData_ != null) ? other.bGCData_.Clone() : null);
		bPCData_ = ((other.bPCData_ != null) ? other.bPCData_.Clone() : null);
		bUCData_ = other.bUCData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PersistentECSData Clone()
	{
		return new PersistentECSData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PersistentECSData);
	}

	public bool Equals(PersistentECSData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BGCData, other.BGCData))
		{
			return false;
		}
		if (!object.Equals(BPCData, other.BPCData))
		{
			return false;
		}
		if (!bUCData_.Equals(other.bUCData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (bGCData_ != null)
		{
			num ^= BGCData.GetHashCode();
		}
		if (bPCData_ != null)
		{
			num ^= BPCData.GetHashCode();
		}
		num ^= bUCData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (bGCData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BGCData);
		}
		if (bPCData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BPCData);
		}
		bUCData_.WriteTo(output, _repeated_bUCData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (bGCData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGCData);
		}
		if (bPCData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPCData);
		}
		num += bUCData_.CalculateSize(_repeated_bUCData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PersistentECSData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bGCData_ != null)
		{
			if (bGCData_ == null)
			{
				BGCData = new PersistentBGCData();
			}
			BGCData.MergeFrom(other.BGCData);
		}
		if (other.bPCData_ != null)
		{
			if (bPCData_ == null)
			{
				BPCData = new PersistentBPCData();
			}
			BPCData.MergeFrom(other.BPCData);
		}
		bUCData_.Add(other.bUCData_);
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
				if (bGCData_ == null)
				{
					BGCData = new PersistentBGCData();
				}
				input.ReadMessage(BGCData);
				break;
			case 18u:
				if (bPCData_ == null)
				{
					BPCData = new PersistentBPCData();
				}
				input.ReadMessage(BPCData);
				break;
			case 26u:
				bUCData_.AddEntriesFrom(input, _repeated_bUCData_codec);
				break;
			}
		}
	}
}
