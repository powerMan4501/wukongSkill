using BtlB1;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

public struct PotentialEnergyLevelDetail
{
	private TStrongObjectPtr<BGWDataAsset_B1DBC> mLevelDBC;

	public FUStPotentialEnergyLevelDetailConfig LeveConfig { get; set; }

	public BGWDataAsset_B1DBC LevelDBC
	{
		get
		{
			return mLevelDBC.Get();
		}
		set
		{
			mLevelDBC.Set(value);
		}
	}

	public float DecreaseValuePerSecond => LeveConfig.DecreaseValuePerSecond;

	public float LevelValue => LeveConfig.LevelValue;

	public float ProtectTime => LeveConfig.ProtectTime;

	public string DBCDAPath => LeveConfig.DBCDAPath;

	public RepeatedField<int> BuffIDList => LeveConfig.BuffIDList;

	public RepeatedField<int> BuffIDListLevelUp => LeveConfig.BuffIDListLevelUp;

	public int SwitchPEConfigBuffID => LeveConfig.SwitchPEConfigBuffID;

	public PotentialEnergyLevelDetail(in FUStPotentialEnergyLevelDetailConfig _LeveConfig, in BGWDataAsset_B1DBC _DBC)
	{
		LeveConfig = _LeveConfig;
		mLevelDBC = new TStrongObjectPtr<BGWDataAsset_B1DBC>(_DBC);
	}

	public PotentialEnergyLevelDetail(in FUStPotentialEnergyLevelDetailConfig _LeveConfig)
	{
		LeveConfig = _LeveConfig;
		mLevelDBC = new TStrongObjectPtr<BGWDataAsset_B1DBC>();
	}
}
