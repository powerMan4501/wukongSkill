using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class StateMachineArchiveData : IMessage<StateMachineArchiveData>, IMessage, IEquatable<StateMachineArchiveData>, IDeepCloneable<StateMachineArchiveData>
{
	private static readonly MessageParser<StateMachineArchiveData> _parser = new MessageParser<StateMachineArchiveData>(() => new StateMachineArchiveData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<PsmArchiveGraphData> _repeated_psmArchiveData_codec = FieldCodec.ForMessage(10u, PsmArchiveGraphData.Parser);

	private readonly RepeatedField<PsmArchiveGraphData> psmArchiveData_ = new RepeatedField<PsmArchiveGraphData>();

	private LevelArchiveSceneObjData sceneObjData_;

	public static MessageParser<StateMachineArchiveData> Parser => _parser;

	public RepeatedField<PsmArchiveGraphData> PsmArchiveData => psmArchiveData_;

	public LevelArchiveSceneObjData SceneObjData
	{
		get
		{
			return sceneObjData_;
		}
		set
		{
			sceneObjData_ = value;
		}
	}

	public StateMachineArchiveData()
	{
	}

	public StateMachineArchiveData(StateMachineArchiveData other)
		: this()
	{
		psmArchiveData_ = other.psmArchiveData_.Clone();
		sceneObjData_ = ((other.sceneObjData_ != null) ? other.sceneObjData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public StateMachineArchiveData Clone()
	{
		return new StateMachineArchiveData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as StateMachineArchiveData);
	}

	public bool Equals(StateMachineArchiveData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!psmArchiveData_.Equals(other.psmArchiveData_))
		{
			return false;
		}
		if (!object.Equals(SceneObjData, other.SceneObjData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= psmArchiveData_.GetHashCode();
		if (sceneObjData_ != null)
		{
			num ^= SceneObjData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		psmArchiveData_.WriteTo(output, _repeated_psmArchiveData_codec);
		if (sceneObjData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(SceneObjData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += psmArchiveData_.CalculateSize(_repeated_psmArchiveData_codec);
		if (sceneObjData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SceneObjData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(StateMachineArchiveData other)
	{
		if (other == null)
		{
			return;
		}
		psmArchiveData_.Add(other.psmArchiveData_);
		if (other.sceneObjData_ != null)
		{
			if (sceneObjData_ == null)
			{
				SceneObjData = new LevelArchiveSceneObjData();
			}
			SceneObjData.MergeFrom(other.SceneObjData);
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
				psmArchiveData_.AddEntriesFrom(input, _repeated_psmArchiveData_codec);
				break;
			case 18u:
				if (sceneObjData_ == null)
				{
					SceneObjData = new LevelArchiveSceneObjData();
				}
				input.ReadMessage(SceneObjData);
				break;
			}
		}
	}
}
