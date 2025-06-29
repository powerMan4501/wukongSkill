using System;
using b1.ECS;
using b1.EventDelDefine;
using BtlShare;
using GurGsReplicate;
using GurGsStruct;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_DataReplicationSystemClient : UActorCompBaseCS
{
	private int LastAckedVersion = -1;

	private BUC_ABPHelperData mABPHelperData;

	private BUC_AttrContainer mAttrContainer;

	private BUC_BuffData mBuffData;

	private BUC_ChargeSkillData mChargeSkillData;

	private BUC_FallDyingData mFallDyingData;

	private BUC_MontageSyncData mMontageSyncData;

	private BUC_PredictionTestData mPredictionTestData;

	private BUC_ReplicateTestData mReplicateTestData;

	private BUC_SimpleStateData mSimpleStateData;

	private BUC_TargetInfoData mTargetInfoData;

	private BUC_UnitHatredData mUnitHatredData;

	private BUC_UnitStateData mUnitStateData;

	private BUC_ObjActorMovementData mObjActorMovementData;

	private BUC_InteractData mInteractData;

	private BUC_ProjectileBasicData mProjectileBasicData;

	public override void OnAttach()
	{
		mABPHelperData = RequireWritableData<BUC_ABPHelperData>();
		mAttrContainer = RequireWritableData<BUC_AttrContainer>();
		mBuffData = RequireWritableData<BUC_BuffData>();
		mChargeSkillData = RequireWritableData<BUC_ChargeSkillData>();
		mFallDyingData = RequireWritableData<BUC_FallDyingData>();
		mMontageSyncData = RequireWritableData<BUC_MontageSyncData>();
		mPredictionTestData = RequireWritableData<BUC_PredictionTestData>();
		mReplicateTestData = RequireWritableData<BUC_ReplicateTestData>();
		mSimpleStateData = RequireWritableData<BUC_SimpleStateData>();
		mTargetInfoData = RequireWritableData<BUC_TargetInfoData>();
		mUnitHatredData = RequireWritableData<BUC_UnitHatredData>();
		mUnitStateData = RequireWritableData<BUC_UnitStateData>();
		mObjActorMovementData = RequireWritableData<BUC_ObjActorMovementData>();
		mInteractData = RequireWritableData<BUC_InteractData>();
		mProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		OnAttachHandWritten();
	}

	public void ReplicateData(IntPtr ConnectionPtr, byte[] Buffer)
	{
		RepDataAll repDataAll = RepDataAll.Parser.ParseFrom(Buffer);
		if (repDataAll.ABPHelperData != null && mABPHelperData != null && repDataAll.ABPHelperData.HasABPSettingPath)
		{
			mABPHelperData.ABPSettingPath = repDataAll.ABPHelperData.ABPSettingPath;
		}
		if (repDataAll.AttrContainer != null && mAttrContainer != null && repDataAll.AttrContainer.FloatAttrs != null)
		{
			foreach (ListWNRDeltaMsgFloat floatAttr in repDataAll.AttrContainer.FloatAttrs)
			{
				if (floatAttr.Version > LastAckedVersion && floatAttr.Op == OPType.Modify)
				{
					mAttrContainer.FloatAttrs.RawData[(int)floatAttr.Idx] = floatAttr.Value;
				}
			}
		}
		if (repDataAll.BuffData != null && mBuffData != null && repDataAll.BuffData.BuffInstsDict != null)
		{
			foreach (DictDeltaMsgInt_BuffInstData item in repDataAll.BuffData.BuffInstsDict)
			{
				if (item.Version <= LastAckedVersion)
				{
					continue;
				}
				switch (item.Op)
				{
				case OPType.Add:
				{
					BuffInstData buffInstData = new BuffInstData();
					foreach (ClassDeltaMsgBuffInstData item2 in item.Value)
					{
						if (item2.Version <= LastAckedVersion)
						{
							continue;
						}
						switch (item2.Op)
						{
						case OPType.Modify:
							if (item2.Value.HasBuffID)
							{
								buffInstData.BuffID = item2.Value.BuffID;
							}
							if (item2.Value.HasLayer)
							{
								buffInstData.Layer = item2.Value.Layer;
							}
							if (item2.Value.HasCasterRef)
							{
								buffInstData.CasterRef = BGUFuncLibReplication.GetEntitySharedRefByNetGUID(item2.Value.CasterRef, ConnectionPtr);
							}
							if (item2.Value.HasDuration)
							{
								buffInstData.Duration = item2.Value.Duration;
							}
							if (item2.Value.HasBuffSourceType)
							{
								buffInstData.BuffSourceType = (EBuffSourceType)item2.Value.BuffSourceType;
							}
							foreach (ListDeltaMsgFloat cachedFixFunctionReturnValue in item2.Value.CachedFixFunctionReturnValues)
							{
								if (cachedFixFunctionReturnValue.Version <= LastAckedVersion)
								{
									continue;
								}
								switch (cachedFixFunctionReturnValue.Op)
								{
								case OPType.Add:
								{
									float value = cachedFixFunctionReturnValue.Value;
									buffInstData.CachedFixFunctionReturnValues.Add(value);
									break;
								}
								case OPType.Remove:
									buffInstData.CachedFixFunctionReturnValues.RemoveAt((int)cachedFixFunctionReturnValue.Idx);
									break;
								case OPType.Modify:
									buffInstData.CachedFixFunctionReturnValues[(int)cachedFixFunctionReturnValue.Idx] = cachedFixFunctionReturnValue.Value;
									break;
								case OPType.Clear:
									buffInstData.CachedFixFunctionReturnValues.Clear();
									break;
								case OPType.SetNull:
									buffInstData.CachedFixFunctionReturnValues = null;
									break;
								case OPType.ChangeRef:
									if (buffInstData.CachedFixFunctionReturnValues == null)
									{
										buffInstData.CachedFixFunctionReturnValues = new BindListFloat();
									}
									else
									{
										buffInstData.CachedFixFunctionReturnValues.Clear();
									}
									break;
								}
							}
							foreach (DictDeltaMsgEPropType_UInt item3 in item2.Value.PropMgrHandleID)
							{
								if (item3.Version <= LastAckedVersion)
								{
									continue;
								}
								switch (item3.Op)
								{
								case OPType.Add:
								{
									uint value2 = item3.Value;
									buffInstData.PropMgrHandleID.Add((EPropType)item3.Idx, value2);
									break;
								}
								case OPType.Remove:
									buffInstData.PropMgrHandleID.Remove((EPropType)item3.Idx);
									break;
								case OPType.Modify:
									buffInstData.PropMgrHandleID[(EPropType)item3.Idx] = item3.Value;
									break;
								case OPType.Clear:
									buffInstData.PropMgrHandleID.Clear();
									break;
								case OPType.SetNull:
									buffInstData.PropMgrHandleID = null;
									break;
								case OPType.ChangeRef:
									if (buffInstData.PropMgrHandleID == null)
									{
										buffInstData.PropMgrHandleID = new BindDictEPropType_UInt();
									}
									else
									{
										buffInstData.PropMgrHandleID.Clear();
									}
									break;
								}
							}
							break;
						case OPType.SetNull:
							buffInstData = null;
							break;
						case OPType.ChangeRef:
							buffInstData = new BuffInstData();
							break;
						}
					}
					mBuffData.BuffInstsDict.Add(item.Idx, buffInstData);
					break;
				}
				case OPType.Remove:
					mBuffData.BuffInstsDict.Remove(item.Idx);
					break;
				case OPType.Modify:
					foreach (ClassDeltaMsgBuffInstData item4 in item.Value)
					{
						if (item4.Version <= LastAckedVersion)
						{
							continue;
						}
						switch (item4.Op)
						{
						case OPType.Modify:
							if (item4.Value.HasBuffID)
							{
								mBuffData.BuffInstsDict[item.Idx].BuffID = item4.Value.BuffID;
							}
							if (item4.Value.HasLayer)
							{
								mBuffData.BuffInstsDict[item.Idx].Layer = item4.Value.Layer;
							}
							if (item4.Value.HasCasterRef)
							{
								mBuffData.BuffInstsDict[item.Idx].CasterRef = BGUFuncLibReplication.GetEntitySharedRefByNetGUID(item4.Value.CasterRef, ConnectionPtr);
							}
							if (item4.Value.HasDuration)
							{
								mBuffData.BuffInstsDict[item.Idx].Duration = item4.Value.Duration;
							}
							if (item4.Value.HasBuffSourceType)
							{
								mBuffData.BuffInstsDict[item.Idx].BuffSourceType = (EBuffSourceType)item4.Value.BuffSourceType;
							}
							foreach (ListDeltaMsgFloat cachedFixFunctionReturnValue2 in item4.Value.CachedFixFunctionReturnValues)
							{
								if (cachedFixFunctionReturnValue2.Version <= LastAckedVersion)
								{
									continue;
								}
								switch (cachedFixFunctionReturnValue2.Op)
								{
								case OPType.Add:
								{
									float value3 = cachedFixFunctionReturnValue2.Value;
									mBuffData.BuffInstsDict[item.Idx].CachedFixFunctionReturnValues.Add(value3);
									break;
								}
								case OPType.Remove:
									mBuffData.BuffInstsDict[item.Idx].CachedFixFunctionReturnValues.RemoveAt((int)cachedFixFunctionReturnValue2.Idx);
									break;
								case OPType.Modify:
									mBuffData.BuffInstsDict[item.Idx].CachedFixFunctionReturnValues[(int)cachedFixFunctionReturnValue2.Idx] = cachedFixFunctionReturnValue2.Value;
									break;
								case OPType.Clear:
									mBuffData.BuffInstsDict[item.Idx].CachedFixFunctionReturnValues.Clear();
									break;
								case OPType.SetNull:
									mBuffData.BuffInstsDict[item.Idx].CachedFixFunctionReturnValues = null;
									break;
								case OPType.ChangeRef:
									if (mBuffData.BuffInstsDict[item.Idx].CachedFixFunctionReturnValues == null)
									{
										mBuffData.BuffInstsDict[item.Idx].CachedFixFunctionReturnValues = new BindListFloat();
									}
									else
									{
										mBuffData.BuffInstsDict[item.Idx].CachedFixFunctionReturnValues.Clear();
									}
									break;
								}
							}
							foreach (DictDeltaMsgEPropType_UInt item5 in item4.Value.PropMgrHandleID)
							{
								if (item5.Version <= LastAckedVersion)
								{
									continue;
								}
								switch (item5.Op)
								{
								case OPType.Add:
								{
									uint value4 = item5.Value;
									mBuffData.BuffInstsDict[item.Idx].PropMgrHandleID.Add((EPropType)item5.Idx, value4);
									break;
								}
								case OPType.Remove:
									mBuffData.BuffInstsDict[item.Idx].PropMgrHandleID.Remove((EPropType)item5.Idx);
									break;
								case OPType.Modify:
									mBuffData.BuffInstsDict[item.Idx].PropMgrHandleID[(EPropType)item5.Idx] = item5.Value;
									break;
								case OPType.Clear:
									mBuffData.BuffInstsDict[item.Idx].PropMgrHandleID.Clear();
									break;
								case OPType.SetNull:
									mBuffData.BuffInstsDict[item.Idx].PropMgrHandleID = null;
									break;
								case OPType.ChangeRef:
									if (mBuffData.BuffInstsDict[item.Idx].PropMgrHandleID == null)
									{
										mBuffData.BuffInstsDict[item.Idx].PropMgrHandleID = new BindDictEPropType_UInt();
									}
									else
									{
										mBuffData.BuffInstsDict[item.Idx].PropMgrHandleID.Clear();
									}
									break;
								}
							}
							break;
						case OPType.SetNull:
							mBuffData.BuffInstsDict[item.Idx] = null;
							break;
						case OPType.ChangeRef:
							mBuffData.BuffInstsDict[item.Idx] = new BuffInstData();
							break;
						}
					}
					break;
				case OPType.Clear:
					mBuffData.BuffInstsDict.Clear();
					break;
				case OPType.SetNull:
					mBuffData.BuffInstsDict = null;
					break;
				case OPType.ChangeRef:
					if (mBuffData.BuffInstsDict == null)
					{
						mBuffData.BuffInstsDict = new BindDictInt_BuffInstData();
					}
					else
					{
						mBuffData.BuffInstsDict.Clear();
					}
					break;
				}
			}
		}
		if (repDataAll.ChargeSkillData != null && mChargeSkillData != null && repDataAll.ChargeSkillData.HasCurChargeLevel)
		{
			mChargeSkillData.CurChargeLevel = repDataAll.ChargeSkillData.CurChargeLevel;
		}
		if (repDataAll.FallDyingData != null && mFallDyingData != null)
		{
			if (repDataAll.FallDyingData.HasFallDyingTime)
			{
				mFallDyingData.FallDyingTime = repDataAll.FallDyingData.FallDyingTime;
			}
			if (repDataAll.FallDyingData.HasSaveSelfWaitTime)
			{
				mFallDyingData.SaveSelfWaitTime = repDataAll.FallDyingData.SaveSelfWaitTime;
			}
			if (repDataAll.FallDyingData.HasUnitFallDyingState)
			{
				mFallDyingData.UnitFallDyingState = (EFallDyingState)repDataAll.FallDyingData.UnitFallDyingState;
			}
			if (repDataAll.FallDyingData.VectorTest != null)
			{
				mFallDyingData.VectorTest = new UnrealEngine.Runtime.FVector(repDataAll.FallDyingData.VectorTest.X, repDataAll.FallDyingData.VectorTest.Y, repDataAll.FallDyingData.VectorTest.Z);
			}
			if (repDataAll.FallDyingData.RotatorTest != null)
			{
				mFallDyingData.RotatorTest = new UnrealEngine.Runtime.FRotator(repDataAll.FallDyingData.RotatorTest.Pitch, repDataAll.FallDyingData.RotatorTest.Yaw, repDataAll.FallDyingData.RotatorTest.Roll);
			}
			if (repDataAll.FallDyingData.GSListTest != null)
			{
				foreach (ListDeltaMsgFloat item6 in repDataAll.FallDyingData.GSListTest)
				{
					if (item6.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (item6.Op)
					{
					case OPType.Add:
					{
						float value5 = item6.Value;
						mFallDyingData.GSListTest.Add(value5);
						break;
					}
					case OPType.Remove:
						mFallDyingData.GSListTest.RemoveAt((int)item6.Idx);
						break;
					case OPType.Modify:
						mFallDyingData.GSListTest[(int)item6.Idx] = item6.Value;
						break;
					case OPType.Clear:
						mFallDyingData.GSListTest.Clear();
						break;
					case OPType.SetNull:
						mFallDyingData.GSListTest = null;
						break;
					case OPType.ChangeRef:
						if (mFallDyingData.GSListTest == null)
						{
							mFallDyingData.GSListTest = new BindListFloat();
						}
						else
						{
							mFallDyingData.GSListTest.Clear();
						}
						break;
					}
				}
			}
		}
		if (repDataAll.MontageSyncData != null && mMontageSyncData != null)
		{
			if (repDataAll.MontageSyncData.HasIsPlayingMontage)
			{
				mMontageSyncData.IsPlayingMontage = repDataAll.MontageSyncData.IsPlayingMontage;
			}
			if (repDataAll.MontageSyncData.HasMontagePath)
			{
				mMontageSyncData.MontagePath = repDataAll.MontageSyncData.MontagePath;
			}
			if (repDataAll.MontageSyncData.HasPosition)
			{
				mMontageSyncData.Position = repDataAll.MontageSyncData.Position;
			}
		}
		if (repDataAll.PredictionTestData != null && mPredictionTestData != null)
		{
			if (repDataAll.PredictionTestData.HasTestEntity1)
			{
				mPredictionTestData.TestEntity1 = BGUFuncLibReplication.GetEntityByNetGUID(repDataAll.PredictionTestData.TestEntity1, ConnectionPtr);
			}
			if (repDataAll.PredictionTestData.TestEntityList1 != null)
			{
				foreach (ListDeltaMsgEntity item7 in repDataAll.PredictionTestData.TestEntityList1)
				{
					if (item7.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (item7.Op)
					{
					case OPType.Add:
					{
						Entity entityByNetGUID = BGUFuncLibReplication.GetEntityByNetGUID(item7.Value, ConnectionPtr);
						mPredictionTestData.TestEntityList1.Add(entityByNetGUID);
						break;
					}
					case OPType.Remove:
						mPredictionTestData.TestEntityList1.RemoveAt((int)item7.Idx);
						break;
					case OPType.Modify:
						mPredictionTestData.TestEntityList1[(int)item7.Idx] = BGUFuncLibReplication.GetEntityByNetGUID(item7.Value, ConnectionPtr);
						break;
					case OPType.Clear:
						mPredictionTestData.TestEntityList1.Clear();
						break;
					case OPType.SetNull:
						mPredictionTestData.TestEntityList1 = null;
						break;
					case OPType.ChangeRef:
						if (mPredictionTestData.TestEntityList1 == null)
						{
							mPredictionTestData.TestEntityList1 = new BindListEntity();
						}
						else
						{
							mPredictionTestData.TestEntityList1.Clear();
						}
						break;
					}
				}
			}
			if (repDataAll.PredictionTestData.TestEntityListWithNetRole != null)
			{
				foreach (ListWNRDeltaMsgEntity item8 in repDataAll.PredictionTestData.TestEntityListWithNetRole)
				{
					if (item8.Version > LastAckedVersion && item8.Op == OPType.Modify)
					{
						mPredictionTestData.TestEntityListWithNetRole.RawData[(int)item8.Idx] = BGUFuncLibReplication.GetEntityByNetGUID(item8.Value, ConnectionPtr);
					}
				}
			}
			if (repDataAll.PredictionTestData.TestEntityDic != null)
			{
				foreach (DictDeltaMsgInt_Entity item9 in repDataAll.PredictionTestData.TestEntityDic)
				{
					if (item9.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (item9.Op)
					{
					case OPType.Add:
					{
						Entity entityByNetGUID2 = BGUFuncLibReplication.GetEntityByNetGUID(item9.Value, ConnectionPtr);
						mPredictionTestData.TestEntityDic.Add(item9.Idx, entityByNetGUID2);
						break;
					}
					case OPType.Remove:
						mPredictionTestData.TestEntityDic.Remove(item9.Idx);
						break;
					case OPType.Modify:
						mPredictionTestData.TestEntityDic[item9.Idx] = BGUFuncLibReplication.GetEntityByNetGUID(item9.Value, ConnectionPtr);
						break;
					case OPType.Clear:
						mPredictionTestData.TestEntityDic.Clear();
						break;
					case OPType.SetNull:
						mPredictionTestData.TestEntityDic = null;
						break;
					case OPType.ChangeRef:
						if (mPredictionTestData.TestEntityDic == null)
						{
							mPredictionTestData.TestEntityDic = new BindDictInt_Entity();
						}
						else
						{
							mPredictionTestData.TestEntityDic.Clear();
						}
						break;
					}
				}
			}
		}
		if (repDataAll.ReplicateTestData != null && mReplicateTestData != null)
		{
			if (repDataAll.ReplicateTestData.HasTestInt)
			{
				mReplicateTestData.TestInt = repDataAll.ReplicateTestData.TestInt;
			}
			if (repDataAll.ReplicateTestData.TestClass != null)
			{
				foreach (ClassDeltaMsgFRepTestClass item10 in repDataAll.ReplicateTestData.TestClass)
				{
					if (item10.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (item10.Op)
					{
					case OPType.Modify:
						if (item10.Value.HasRepTestClassBool)
						{
							mReplicateTestData.TestClass.RepTestClassBool = item10.Value.RepTestClassBool;
						}
						foreach (ClassDeltaMsgFRepInnerClass item11 in item10.Value.InnerClass)
						{
							if (item11.Version <= LastAckedVersion)
							{
								continue;
							}
							switch (item11.Op)
							{
							case OPType.Modify:
								if (item11.Value.HasInnerInt)
								{
									mReplicateTestData.TestClass.InnerClass.InnerInt = item11.Value.InnerInt;
								}
								break;
							case OPType.SetNull:
								mReplicateTestData.TestClass.InnerClass = null;
								break;
							case OPType.ChangeRef:
								mReplicateTestData.TestClass.InnerClass = new FRepInnerClass();
								break;
							}
						}
						foreach (ListDeltaMsgFRepInnerClass innerClass in item10.Value.InnerClassList)
						{
							if (innerClass.Version <= LastAckedVersion)
							{
								continue;
							}
							switch (innerClass.Op)
							{
							case OPType.Add:
							{
								FRepInnerClass fRepInnerClass = new FRepInnerClass();
								foreach (ClassDeltaMsgFRepInnerClass item12 in innerClass.Value)
								{
									if (item12.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (item12.Op)
									{
									case OPType.Modify:
										if (item12.Value.HasInnerInt)
										{
											fRepInnerClass.InnerInt = item12.Value.InnerInt;
										}
										break;
									case OPType.SetNull:
										fRepInnerClass = null;
										break;
									case OPType.ChangeRef:
										fRepInnerClass = new FRepInnerClass();
										break;
									}
								}
								mReplicateTestData.TestClass.InnerClassList.Add(fRepInnerClass);
								break;
							}
							case OPType.Remove:
								mReplicateTestData.TestClass.InnerClassList.RemoveAt((int)innerClass.Idx);
								break;
							case OPType.Modify:
								foreach (ClassDeltaMsgFRepInnerClass item13 in innerClass.Value)
								{
									if (item13.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (item13.Op)
									{
									case OPType.Modify:
										if (item13.Value.HasInnerInt)
										{
											mReplicateTestData.TestClass.InnerClassList[(int)innerClass.Idx].InnerInt = item13.Value.InnerInt;
										}
										break;
									case OPType.SetNull:
										mReplicateTestData.TestClass.InnerClassList[(int)innerClass.Idx] = null;
										break;
									case OPType.ChangeRef:
										mReplicateTestData.TestClass.InnerClassList[(int)innerClass.Idx] = new FRepInnerClass();
										break;
									}
								}
								break;
							case OPType.Clear:
								mReplicateTestData.TestClass.InnerClassList.Clear();
								break;
							case OPType.SetNull:
								mReplicateTestData.TestClass.InnerClassList = null;
								break;
							case OPType.ChangeRef:
								if (mReplicateTestData.TestClass.InnerClassList == null)
								{
									mReplicateTestData.TestClass.InnerClassList = new BindListFRepInnerClass();
								}
								else
								{
									mReplicateTestData.TestClass.InnerClassList.Clear();
								}
								break;
							}
						}
						break;
					case OPType.SetNull:
						mReplicateTestData.TestClass = null;
						break;
					case OPType.ChangeRef:
						mReplicateTestData.TestClass = new FRepTestClass();
						break;
					}
				}
			}
			if (repDataAll.ReplicateTestData.IntArr != null)
			{
				foreach (ListDeltaMsgInt item14 in repDataAll.ReplicateTestData.IntArr)
				{
					if (item14.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (item14.Op)
					{
					case OPType.Add:
					{
						int value6 = item14.Value;
						mReplicateTestData.IntArr.Add(value6);
						break;
					}
					case OPType.Remove:
						mReplicateTestData.IntArr.RemoveAt((int)item14.Idx);
						break;
					case OPType.Modify:
						mReplicateTestData.IntArr[(int)item14.Idx] = item14.Value;
						break;
					case OPType.Clear:
						mReplicateTestData.IntArr.Clear();
						break;
					case OPType.SetNull:
						mReplicateTestData.IntArr = null;
						break;
					case OPType.ChangeRef:
						if (mReplicateTestData.IntArr == null)
						{
							mReplicateTestData.IntArr = new BindListInt();
						}
						else
						{
							mReplicateTestData.IntArr.Clear();
						}
						break;
					}
				}
			}
			if (repDataAll.ReplicateTestData.InnerClassList != null)
			{
				foreach (ListDeltaMsgFRepInnerClass innerClass2 in repDataAll.ReplicateTestData.InnerClassList)
				{
					if (innerClass2.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (innerClass2.Op)
					{
					case OPType.Add:
					{
						FRepInnerClass fRepInnerClass2 = new FRepInnerClass();
						foreach (ClassDeltaMsgFRepInnerClass item15 in innerClass2.Value)
						{
							if (item15.Version <= LastAckedVersion)
							{
								continue;
							}
							switch (item15.Op)
							{
							case OPType.Modify:
								if (item15.Value.HasInnerInt)
								{
									fRepInnerClass2.InnerInt = item15.Value.InnerInt;
								}
								break;
							case OPType.SetNull:
								fRepInnerClass2 = null;
								break;
							case OPType.ChangeRef:
								fRepInnerClass2 = new FRepInnerClass();
								break;
							}
						}
						mReplicateTestData.InnerClassList.Add(fRepInnerClass2);
						break;
					}
					case OPType.Remove:
						mReplicateTestData.InnerClassList.RemoveAt((int)innerClass2.Idx);
						break;
					case OPType.Modify:
						foreach (ClassDeltaMsgFRepInnerClass item16 in innerClass2.Value)
						{
							if (item16.Version <= LastAckedVersion)
							{
								continue;
							}
							switch (item16.Op)
							{
							case OPType.Modify:
								if (item16.Value.HasInnerInt)
								{
									mReplicateTestData.InnerClassList[(int)innerClass2.Idx].InnerInt = item16.Value.InnerInt;
								}
								break;
							case OPType.SetNull:
								mReplicateTestData.InnerClassList[(int)innerClass2.Idx] = null;
								break;
							case OPType.ChangeRef:
								mReplicateTestData.InnerClassList[(int)innerClass2.Idx] = new FRepInnerClass();
								break;
							}
						}
						break;
					case OPType.Clear:
						mReplicateTestData.InnerClassList.Clear();
						break;
					case OPType.SetNull:
						mReplicateTestData.InnerClassList = null;
						break;
					case OPType.ChangeRef:
						if (mReplicateTestData.InnerClassList == null)
						{
							mReplicateTestData.InnerClassList = new BindListFRepInnerClass();
						}
						else
						{
							mReplicateTestData.InnerClassList.Clear();
						}
						break;
					}
				}
			}
		}
		if (repDataAll.SimpleStateData != null && mSimpleStateData != null && repDataAll.SimpleStateData.SimpleStates != null)
		{
			foreach (ListWNRDeltaMsgInt simpleState in repDataAll.SimpleStateData.SimpleStates)
			{
				if (simpleState.Version > LastAckedVersion && simpleState.Op == OPType.Modify)
				{
					mSimpleStateData.SimpleStates.RawData[(int)simpleState.Idx] = simpleState.Value;
				}
			}
		}
		if (repDataAll.TargetInfoData != null && mTargetInfoData != null && repDataAll.TargetInfoData.TargetInfo != null)
		{
			foreach (ClassDeltaMsgUnitLockTargetInfo item17 in repDataAll.TargetInfoData.TargetInfo)
			{
				if (item17.Version <= LastAckedVersion)
				{
					continue;
				}
				switch (item17.Op)
				{
				case OPType.Modify:
					if (item17.Value.HasLockTargetEntity)
					{
						mTargetInfoData.TargetInfo.LockTargetEntity = BGUFuncLibReplication.GetEntityByNetGUID(item17.Value.LockTargetEntity, ConnectionPtr);
					}
					if (item17.Value.HasLockTargetWayType)
					{
						mTargetInfoData.TargetInfo.LockTargetWayType = (ELockTargetWayType)item17.Value.LockTargetWayType;
					}
					if (item17.Value.HasLockTargetType)
					{
						mTargetInfoData.TargetInfo.LockTargetType = (ELockTargetType)item17.Value.LockTargetType;
					}
					if (item17.Value.HasLockTargetSceneCompName)
					{
						mTargetInfoData.TargetInfo.LockTargetSceneCompName = item17.Value.LockTargetSceneCompName;
					}
					if (item17.Value.HasLockTargetSkeletonSocketName)
					{
						mTargetInfoData.TargetInfo.LockTargetSkeletonSocketName = item17.Value.LockTargetSkeletonSocketName;
					}
					if (item17.Value.LockPointLocation != null)
					{
						mTargetInfoData.TargetInfo.LockPointLocation = new UnrealEngine.Runtime.FVector(item17.Value.LockPointLocation.X, item17.Value.LockPointLocation.Y, item17.Value.LockPointLocation.Z);
					}
					if (item17.Value.HasSourceType)
					{
						mTargetInfoData.TargetInfo.SourceType = (ETargetSourceType)item17.Value.SourceType;
					}
					break;
				case OPType.SetNull:
					mTargetInfoData.TargetInfo = null;
					break;
				case OPType.ChangeRef:
					mTargetInfoData.TargetInfo = new UnitLockTargetInfo();
					break;
				}
			}
		}
		if (repDataAll.UnitHatredData != null && mUnitHatredData != null && repDataAll.UnitHatredData.PlayerHatredEntityList != null)
		{
			foreach (ListDeltaMsgEntity playerHatredEntity in repDataAll.UnitHatredData.PlayerHatredEntityList)
			{
				if (playerHatredEntity.Version <= LastAckedVersion)
				{
					continue;
				}
				switch (playerHatredEntity.Op)
				{
				case OPType.Add:
				{
					Entity entityByNetGUID3 = BGUFuncLibReplication.GetEntityByNetGUID(playerHatredEntity.Value, ConnectionPtr);
					mUnitHatredData.PlayerHatredEntityList.Add(entityByNetGUID3);
					break;
				}
				case OPType.Remove:
					mUnitHatredData.PlayerHatredEntityList.RemoveAt((int)playerHatredEntity.Idx);
					break;
				case OPType.Modify:
					mUnitHatredData.PlayerHatredEntityList[(int)playerHatredEntity.Idx] = BGUFuncLibReplication.GetEntityByNetGUID(playerHatredEntity.Value, ConnectionPtr);
					break;
				case OPType.Clear:
					mUnitHatredData.PlayerHatredEntityList.Clear();
					break;
				case OPType.SetNull:
					mUnitHatredData.PlayerHatredEntityList = null;
					break;
				case OPType.ChangeRef:
					if (mUnitHatredData.PlayerHatredEntityList == null)
					{
						mUnitHatredData.PlayerHatredEntityList = new BindListEntity();
					}
					else
					{
						mUnitHatredData.PlayerHatredEntityList.Clear();
					}
					break;
				}
			}
		}
		if (repDataAll.UnitStateData != null && mUnitStateData != null && repDataAll.UnitStateData.UnitStates != null)
		{
			foreach (ListWNRDeltaMsgFloat unitState in repDataAll.UnitStateData.UnitStates)
			{
				if (unitState.Version > LastAckedVersion && unitState.Op == OPType.Modify)
				{
					mUnitStateData.UnitStates.RawData[(int)unitState.Idx] = unitState.Value;
				}
			}
		}
		if (repDataAll.ObjActorMovementData != null && mObjActorMovementData != null && repDataAll.ObjActorMovementData.HasUseSimpleMove)
		{
			mObjActorMovementData.UseSimpleMove = repDataAll.ObjActorMovementData.UseSimpleMove;
		}
		if (repDataAll.InteractData != null && mInteractData != null)
		{
			if (repDataAll.InteractData.HasInteractUnitState)
			{
				mInteractData.InteractUnitState = (EBGUInteractUnitState)repDataAll.InteractData.InteractUnitState;
			}
			if (repDataAll.InteractData.HasInteractConstraint)
			{
				mInteractData.InteractConstraint = (EInteractConstraint)repDataAll.InteractData.InteractConstraint;
			}
		}
		if (repDataAll.ProjectileBasicData != null && mProjectileBasicData != null && repDataAll.ProjectileBasicData.HasProjectileID)
		{
			mProjectileBasicData.ProjectileID = repDataAll.ProjectileBasicData.ProjectileID;
		}
		LastAckedVersion = repDataAll.Version;
	}

	public void OnAttachHandWritten()
	{
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		base.BUSEventCollection.Evt_DoReplicateData += new Del_DoReplicateData(DoReplicateData);
	}

	public override void OnNetDeActive()
	{
		base.OnNetDeActive();
		base.BUSEventCollection.Evt_DoReplicateData -= new Del_DoReplicateData(DoReplicateData);
	}

	protected int DoReplicateData(IntPtr ConnectionPtr, byte[] ReplicationBytes)
	{
		try
		{
			ReplicateData(ConnectionPtr, ReplicationBytes);
			return 0;
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError($"Replicate Data Error!!! {ex}");
			USharpExceptionHandler.HandleException(ex, EUSharpExceptionType.InvokeFunction);
			return -1;
		}
	}
}
