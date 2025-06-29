using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class PersistentBGCData : IMessage<PersistentBGCData>, IMessage, IEquatable<PersistentBGCData>, IDeepCloneable<PersistentBGCData>
{
	private static readonly MessageParser<PersistentBGCData> _parser = new MessageParser<PersistentBGCData>(() => new PersistentBGCData());

	private UnknownFieldSet _unknownFields;

	private BGC_CollectionGroupData bGCCollectionGroupData_;

	private BGC_GameStateTestData bGCGameStateTestData_;

	private BGC_OnlineAssistData bGCOnlineAssistData_;

	private BGC_PlayerGuideData bGCPlayerGuideData_;

	private BGC_PlayerDeathData bGCPlayerDeathData_;

	private BGC_PigsyStoryData bGCPigsyStoryData_;

	public static MessageParser<PersistentBGCData> Parser => _parser;

	public BGC_CollectionGroupData BGCCollectionGroupData
	{
		get
		{
			return bGCCollectionGroupData_;
		}
		set
		{
			bGCCollectionGroupData_ = value;
		}
	}

	public BGC_GameStateTestData BGCGameStateTestData
	{
		get
		{
			return bGCGameStateTestData_;
		}
		set
		{
			bGCGameStateTestData_ = value;
		}
	}

	public BGC_OnlineAssistData BGCOnlineAssistData
	{
		get
		{
			return bGCOnlineAssistData_;
		}
		set
		{
			bGCOnlineAssistData_ = value;
		}
	}

	public BGC_PlayerGuideData BGCPlayerGuideData
	{
		get
		{
			return bGCPlayerGuideData_;
		}
		set
		{
			bGCPlayerGuideData_ = value;
		}
	}

	public BGC_PlayerDeathData BGCPlayerDeathData
	{
		get
		{
			return bGCPlayerDeathData_;
		}
		set
		{
			bGCPlayerDeathData_ = value;
		}
	}

	public BGC_PigsyStoryData BGCPigsyStoryData
	{
		get
		{
			return bGCPigsyStoryData_;
		}
		set
		{
			bGCPigsyStoryData_ = value;
		}
	}

	public PersistentBGCData()
	{
	}

	public PersistentBGCData(PersistentBGCData other)
		: this()
	{
		bGCCollectionGroupData_ = ((other.bGCCollectionGroupData_ != null) ? other.bGCCollectionGroupData_.Clone() : null);
		bGCGameStateTestData_ = ((other.bGCGameStateTestData_ != null) ? other.bGCGameStateTestData_.Clone() : null);
		bGCOnlineAssistData_ = ((other.bGCOnlineAssistData_ != null) ? other.bGCOnlineAssistData_.Clone() : null);
		bGCPlayerGuideData_ = ((other.bGCPlayerGuideData_ != null) ? other.bGCPlayerGuideData_.Clone() : null);
		bGCPlayerDeathData_ = ((other.bGCPlayerDeathData_ != null) ? other.bGCPlayerDeathData_.Clone() : null);
		bGCPigsyStoryData_ = ((other.bGCPigsyStoryData_ != null) ? other.bGCPigsyStoryData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PersistentBGCData Clone()
	{
		return new PersistentBGCData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PersistentBGCData);
	}

	public bool Equals(PersistentBGCData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BGCCollectionGroupData, other.BGCCollectionGroupData))
		{
			return false;
		}
		if (!object.Equals(BGCGameStateTestData, other.BGCGameStateTestData))
		{
			return false;
		}
		if (!object.Equals(BGCOnlineAssistData, other.BGCOnlineAssistData))
		{
			return false;
		}
		if (!object.Equals(BGCPlayerGuideData, other.BGCPlayerGuideData))
		{
			return false;
		}
		if (!object.Equals(BGCPlayerDeathData, other.BGCPlayerDeathData))
		{
			return false;
		}
		if (!object.Equals(BGCPigsyStoryData, other.BGCPigsyStoryData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (bGCCollectionGroupData_ != null)
		{
			num ^= BGCCollectionGroupData.GetHashCode();
		}
		if (bGCGameStateTestData_ != null)
		{
			num ^= BGCGameStateTestData.GetHashCode();
		}
		if (bGCOnlineAssistData_ != null)
		{
			num ^= BGCOnlineAssistData.GetHashCode();
		}
		if (bGCPlayerGuideData_ != null)
		{
			num ^= BGCPlayerGuideData.GetHashCode();
		}
		if (bGCPlayerDeathData_ != null)
		{
			num ^= BGCPlayerDeathData.GetHashCode();
		}
		if (bGCPigsyStoryData_ != null)
		{
			num ^= BGCPigsyStoryData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (bGCCollectionGroupData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BGCCollectionGroupData);
		}
		if (bGCGameStateTestData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BGCGameStateTestData);
		}
		if (bGCOnlineAssistData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BGCOnlineAssistData);
		}
		if (bGCPlayerGuideData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BGCPlayerGuideData);
		}
		if (bGCPlayerDeathData_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BGCPlayerDeathData);
		}
		if (bGCPigsyStoryData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BGCPigsyStoryData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (bGCCollectionGroupData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGCCollectionGroupData);
		}
		if (bGCGameStateTestData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGCGameStateTestData);
		}
		if (bGCOnlineAssistData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGCOnlineAssistData);
		}
		if (bGCPlayerGuideData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGCPlayerGuideData);
		}
		if (bGCPlayerDeathData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGCPlayerDeathData);
		}
		if (bGCPigsyStoryData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BGCPigsyStoryData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PersistentBGCData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bGCCollectionGroupData_ != null)
		{
			if (bGCCollectionGroupData_ == null)
			{
				BGCCollectionGroupData = new BGC_CollectionGroupData();
			}
			BGCCollectionGroupData.MergeFrom(other.BGCCollectionGroupData);
		}
		if (other.bGCGameStateTestData_ != null)
		{
			if (bGCGameStateTestData_ == null)
			{
				BGCGameStateTestData = new BGC_GameStateTestData();
			}
			BGCGameStateTestData.MergeFrom(other.BGCGameStateTestData);
		}
		if (other.bGCOnlineAssistData_ != null)
		{
			if (bGCOnlineAssistData_ == null)
			{
				BGCOnlineAssistData = new BGC_OnlineAssistData();
			}
			BGCOnlineAssistData.MergeFrom(other.BGCOnlineAssistData);
		}
		if (other.bGCPlayerGuideData_ != null)
		{
			if (bGCPlayerGuideData_ == null)
			{
				BGCPlayerGuideData = new BGC_PlayerGuideData();
			}
			BGCPlayerGuideData.MergeFrom(other.BGCPlayerGuideData);
		}
		if (other.bGCPlayerDeathData_ != null)
		{
			if (bGCPlayerDeathData_ == null)
			{
				BGCPlayerDeathData = new BGC_PlayerDeathData();
			}
			BGCPlayerDeathData.MergeFrom(other.BGCPlayerDeathData);
		}
		if (other.bGCPigsyStoryData_ != null)
		{
			if (bGCPigsyStoryData_ == null)
			{
				BGCPigsyStoryData = new BGC_PigsyStoryData();
			}
			BGCPigsyStoryData.MergeFrom(other.BGCPigsyStoryData);
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
			case 10u:
				if (bGCCollectionGroupData_ == null)
				{
					BGCCollectionGroupData = new BGC_CollectionGroupData();
				}
				input.ReadMessage(BGCCollectionGroupData);
				break;
			case 18u:
				if (bGCGameStateTestData_ == null)
				{
					BGCGameStateTestData = new BGC_GameStateTestData();
				}
				input.ReadMessage(BGCGameStateTestData);
				break;
			case 26u:
				if (bGCOnlineAssistData_ == null)
				{
					BGCOnlineAssistData = new BGC_OnlineAssistData();
				}
				input.ReadMessage(BGCOnlineAssistData);
				break;
			case 34u:
				if (bGCPlayerGuideData_ == null)
				{
					BGCPlayerGuideData = new BGC_PlayerGuideData();
				}
				input.ReadMessage(BGCPlayerGuideData);
				break;
			case 42u:
				if (bGCPlayerDeathData_ == null)
				{
					BGCPlayerDeathData = new BGC_PlayerDeathData();
				}
				input.ReadMessage(BGCPlayerDeathData);
				break;
			case 50u:
				if (bGCPigsyStoryData_ == null)
				{
					BGCPigsyStoryData = new BGC_PigsyStoryData();
				}
				input.ReadMessage(BGCPigsyStoryData);
				break;
			}
		}
	}
}
