using System;
using b1.EventDelDefine;
using BtlB1;
using GurGsReplicate;
using GurGsStruct;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_DataReplicationSystemClient : PlayerStateSystemBase
{
	private int LastAckedVersion = -1;

	private BPC_PlayerStateTestData mPlayerStateTestData;

	private BPC_RoleBaseData mRoleBaseData;

	private BPC_TransactionData mTransactionData;

	public override void OnAttach()
	{
		mPlayerStateTestData = RequireWritableData<BPC_PlayerStateTestData>();
		mRoleBaseData = RequireWritableData<BPC_RoleBaseData>();
		mTransactionData = RequireWritableData<BPC_TransactionData>();
		OnAttachHandWritten();
	}

	public void ReplicateData(IntPtr ConnectionPtr, byte[] Buffer)
	{
		RepDataAll repDataAll = RepDataAll.Parser.ParseFrom(Buffer);
		if (repDataAll.PlayerStateTestData != null && mPlayerStateTestData != null)
		{
			if (repDataAll.PlayerStateTestData.HasTestID)
			{
				mPlayerStateTestData.TestID = repDataAll.PlayerStateTestData.TestID;
			}
			if (repDataAll.PlayerStateTestData.ActiveTransactions != null)
			{
				foreach (ListDeltaMsgPlayerTransactionBase activeTransaction in repDataAll.PlayerStateTestData.ActiveTransactions)
				{
					if (activeTransaction.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (activeTransaction.Op)
					{
					case OPType.Add:
					{
						PlayerTransactionBase playerTransactionBase = null;
						foreach (ClassDeltaMsgPlayerTransactionBase item in activeTransaction.Value)
						{
							if (item.Version <= LastAckedVersion)
							{
								continue;
							}
							switch (item.Op)
							{
							case OPType.Modify:
								if (item.Value.HasParentTransactionId)
								{
									playerTransactionBase.ParentTransactionId = item.Value.ParentTransactionId;
								}
								if (item.Value.HasTransactionId)
								{
									playerTransactionBase.TransactionId = item.Value.TransactionId;
								}
								foreach (ClassDeltaMsgPlayerTransactionTaskBase item2 in item.Value.ActiveTask)
								{
									if (item2.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (item2.Op)
									{
									case OPType.Modify:
										if (item2.Value.HasTaskType)
										{
											playerTransactionBase.ActiveTask.TaskType = item2.Value.TaskType;
										}
										if (item2.Value.HasTaskState)
										{
											playerTransactionBase.ActiveTask.TaskState = (ETransactionTaskState)item2.Value.TaskState;
										}
										break;
									case OPType.SetNull:
										playerTransactionBase.ActiveTask = null;
										break;
									case OPType.ChangeRef:
										if (item2.Value.GSRepSubClassIdx < 0)
										{
											playerTransactionBase.ActiveTask = new PlayerTransactionTaskBase();
										}
										else if (item2.Value.GSRepSubClassIdx == 0)
										{
											playerTransactionBase.ActiveTask = new PlayerTransactionTask_RequestInteractObjLock();
										}
										break;
									}
								}
								foreach (ListDeltaMsgPlayerTransactionTaskBase finishedTask in item.Value.FinishedTasks)
								{
									if (finishedTask.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (finishedTask.Op)
									{
									case OPType.Add:
									{
										PlayerTransactionTaskBase playerTransactionTaskBase = null;
										foreach (ClassDeltaMsgPlayerTransactionTaskBase item3 in finishedTask.Value)
										{
											if (item3.Version <= LastAckedVersion)
											{
												continue;
											}
											switch (item3.Op)
											{
											case OPType.Modify:
												if (item3.Value.HasTaskType)
												{
													playerTransactionTaskBase.TaskType = item3.Value.TaskType;
												}
												if (item3.Value.HasTaskState)
												{
													playerTransactionTaskBase.TaskState = (ETransactionTaskState)item3.Value.TaskState;
												}
												break;
											case OPType.SetNull:
												playerTransactionTaskBase = null;
												break;
											case OPType.ChangeRef:
												if (item3.Value.GSRepSubClassIdx < 0)
												{
													playerTransactionTaskBase = new PlayerTransactionTaskBase();
												}
												else if (item3.Value.GSRepSubClassIdx == 0)
												{
													playerTransactionTaskBase = new PlayerTransactionTask_RequestInteractObjLock();
												}
												break;
											}
										}
										playerTransactionBase.FinishedTasks.Add(playerTransactionTaskBase);
										break;
									}
									case OPType.Remove:
										playerTransactionBase.FinishedTasks.RemoveAt((int)finishedTask.Idx);
										break;
									case OPType.Modify:
										foreach (ClassDeltaMsgPlayerTransactionTaskBase item4 in finishedTask.Value)
										{
											if (item4.Version <= LastAckedVersion)
											{
												continue;
											}
											switch (item4.Op)
											{
											case OPType.Modify:
												if (item4.Value.HasTaskType)
												{
													playerTransactionBase.FinishedTasks[(int)finishedTask.Idx].TaskType = item4.Value.TaskType;
												}
												if (item4.Value.HasTaskState)
												{
													playerTransactionBase.FinishedTasks[(int)finishedTask.Idx].TaskState = (ETransactionTaskState)item4.Value.TaskState;
												}
												break;
											case OPType.SetNull:
												playerTransactionBase.FinishedTasks[(int)finishedTask.Idx] = null;
												break;
											case OPType.ChangeRef:
												if (item4.Value.GSRepSubClassIdx < 0)
												{
													playerTransactionBase.FinishedTasks[(int)finishedTask.Idx] = new PlayerTransactionTaskBase();
												}
												else if (item4.Value.GSRepSubClassIdx == 0)
												{
													playerTransactionBase.FinishedTasks[(int)finishedTask.Idx] = new PlayerTransactionTask_RequestInteractObjLock();
												}
												break;
											}
										}
										break;
									case OPType.Clear:
										playerTransactionBase.FinishedTasks.Clear();
										break;
									case OPType.SetNull:
										playerTransactionBase.FinishedTasks = null;
										break;
									case OPType.ChangeRef:
										if (playerTransactionBase.FinishedTasks == null)
										{
											playerTransactionBase.FinishedTasks = new BindListPlayerTransactionTaskBase();
										}
										else
										{
											playerTransactionBase.FinishedTasks.Clear();
										}
										break;
									}
								}
								if (item.Value.HasTransactionState)
								{
									playerTransactionBase.TransactionState = (ETransactionState)item.Value.TransactionState;
								}
								if (item.Value.HasPlayerTransactionInteractInteractTarget)
								{
									(playerTransactionBase as PlayerTransactionInteract).InteractTarget = GCHelper.FindRef(BGW_NativeFuncs.GSRep_GetActorForGUID(ConnectionPtr, item.Value.PlayerTransactionInteractInteractTarget))?.Managed as AActor;
								}
								break;
							case OPType.SetNull:
								playerTransactionBase = null;
								break;
							case OPType.ChangeRef:
								if (item.Value.GSRepSubClassIdx < 0)
								{
									playerTransactionBase = new PlayerTransactionBase();
								}
								else if (item.Value.GSRepSubClassIdx == 0)
								{
									playerTransactionBase = new PlayerTransactionInteract();
								}
								break;
							}
						}
						mPlayerStateTestData.ActiveTransactions.Add(playerTransactionBase);
						break;
					}
					case OPType.Remove:
						mPlayerStateTestData.ActiveTransactions.RemoveAt((int)activeTransaction.Idx);
						break;
					case OPType.Modify:
						foreach (ClassDeltaMsgPlayerTransactionBase item5 in activeTransaction.Value)
						{
							if (item5.Version <= LastAckedVersion)
							{
								continue;
							}
							switch (item5.Op)
							{
							case OPType.Modify:
								if (item5.Value.HasParentTransactionId)
								{
									mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].ParentTransactionId = item5.Value.ParentTransactionId;
								}
								if (item5.Value.HasTransactionId)
								{
									mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].TransactionId = item5.Value.TransactionId;
								}
								foreach (ClassDeltaMsgPlayerTransactionTaskBase item6 in item5.Value.ActiveTask)
								{
									if (item6.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (item6.Op)
									{
									case OPType.Modify:
										if (item6.Value.HasTaskType)
										{
											mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].ActiveTask.TaskType = item6.Value.TaskType;
										}
										if (item6.Value.HasTaskState)
										{
											mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].ActiveTask.TaskState = (ETransactionTaskState)item6.Value.TaskState;
										}
										break;
									case OPType.SetNull:
										mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].ActiveTask = null;
										break;
									case OPType.ChangeRef:
										if (item6.Value.GSRepSubClassIdx < 0)
										{
											mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].ActiveTask = new PlayerTransactionTaskBase();
										}
										else if (item6.Value.GSRepSubClassIdx == 0)
										{
											mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].ActiveTask = new PlayerTransactionTask_RequestInteractObjLock();
										}
										break;
									}
								}
								foreach (ListDeltaMsgPlayerTransactionTaskBase finishedTask2 in item5.Value.FinishedTasks)
								{
									if (finishedTask2.Version <= LastAckedVersion)
									{
										continue;
									}
									switch (finishedTask2.Op)
									{
									case OPType.Add:
									{
										PlayerTransactionTaskBase playerTransactionTaskBase2 = null;
										foreach (ClassDeltaMsgPlayerTransactionTaskBase item7 in finishedTask2.Value)
										{
											if (item7.Version <= LastAckedVersion)
											{
												continue;
											}
											switch (item7.Op)
											{
											case OPType.Modify:
												if (item7.Value.HasTaskType)
												{
													playerTransactionTaskBase2.TaskType = item7.Value.TaskType;
												}
												if (item7.Value.HasTaskState)
												{
													playerTransactionTaskBase2.TaskState = (ETransactionTaskState)item7.Value.TaskState;
												}
												break;
											case OPType.SetNull:
												playerTransactionTaskBase2 = null;
												break;
											case OPType.ChangeRef:
												if (item7.Value.GSRepSubClassIdx < 0)
												{
													playerTransactionTaskBase2 = new PlayerTransactionTaskBase();
												}
												else if (item7.Value.GSRepSubClassIdx == 0)
												{
													playerTransactionTaskBase2 = new PlayerTransactionTask_RequestInteractObjLock();
												}
												break;
											}
										}
										mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks.Add(playerTransactionTaskBase2);
										break;
									}
									case OPType.Remove:
										mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks.RemoveAt((int)finishedTask2.Idx);
										break;
									case OPType.Modify:
										foreach (ClassDeltaMsgPlayerTransactionTaskBase item8 in finishedTask2.Value)
										{
											if (item8.Version <= LastAckedVersion)
											{
												continue;
											}
											switch (item8.Op)
											{
											case OPType.Modify:
												if (item8.Value.HasTaskType)
												{
													mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks[(int)finishedTask2.Idx].TaskType = item8.Value.TaskType;
												}
												if (item8.Value.HasTaskState)
												{
													mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks[(int)finishedTask2.Idx].TaskState = (ETransactionTaskState)item8.Value.TaskState;
												}
												break;
											case OPType.SetNull:
												mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks[(int)finishedTask2.Idx] = null;
												break;
											case OPType.ChangeRef:
												if (item8.Value.GSRepSubClassIdx < 0)
												{
													mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks[(int)finishedTask2.Idx] = new PlayerTransactionTaskBase();
												}
												else if (item8.Value.GSRepSubClassIdx == 0)
												{
													mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks[(int)finishedTask2.Idx] = new PlayerTransactionTask_RequestInteractObjLock();
												}
												break;
											}
										}
										break;
									case OPType.Clear:
										mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks.Clear();
										break;
									case OPType.SetNull:
										mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks = null;
										break;
									case OPType.ChangeRef:
										if (mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks == null)
										{
											mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks = new BindListPlayerTransactionTaskBase();
										}
										else
										{
											mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].FinishedTasks.Clear();
										}
										break;
									}
								}
								if (item5.Value.HasTransactionState)
								{
									mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx].TransactionState = (ETransactionState)item5.Value.TransactionState;
								}
								if (item5.Value.HasPlayerTransactionInteractInteractTarget)
								{
									(mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx] as PlayerTransactionInteract).InteractTarget = GCHelper.FindRef(BGW_NativeFuncs.GSRep_GetActorForGUID(ConnectionPtr, item5.Value.PlayerTransactionInteractInteractTarget))?.Managed as AActor;
								}
								break;
							case OPType.SetNull:
								mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx] = null;
								break;
							case OPType.ChangeRef:
								if (item5.Value.GSRepSubClassIdx < 0)
								{
									mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx] = new PlayerTransactionBase();
								}
								else if (item5.Value.GSRepSubClassIdx == 0)
								{
									mPlayerStateTestData.ActiveTransactions[(int)activeTransaction.Idx] = new PlayerTransactionInteract();
								}
								break;
							}
						}
						break;
					case OPType.Clear:
						mPlayerStateTestData.ActiveTransactions.Clear();
						break;
					case OPType.SetNull:
						mPlayerStateTestData.ActiveTransactions = null;
						break;
					case OPType.ChangeRef:
						if (mPlayerStateTestData.ActiveTransactions == null)
						{
							mPlayerStateTestData.ActiveTransactions = new BindListPlayerTransactionBase();
						}
						else
						{
							mPlayerStateTestData.ActiveTransactions.Clear();
						}
						break;
					}
				}
			}
		}
		if (repDataAll.RoleBaseData != null && mRoleBaseData != null)
		{
			if (repDataAll.RoleBaseData.HasRoleName)
			{
				mRoleBaseData.RoleName = repDataAll.RoleBaseData.RoleName;
			}
			if (repDataAll.RoleBaseData.HasRoleId)
			{
				mRoleBaseData.RoleId = repDataAll.RoleBaseData.RoleId;
			}
			if (repDataAll.RoleBaseData.HasRoleLevel)
			{
				mRoleBaseData.RoleLevel = repDataAll.RoleBaseData.RoleLevel;
			}
			if (repDataAll.RoleBaseData.HasSoulSkillID)
			{
				mRoleBaseData.SoulSkillID = repDataAll.RoleBaseData.SoulSkillID;
			}
			if (repDataAll.RoleBaseData.EquipList != null)
			{
				foreach (DictDeltaMsgEquipPosition_Int equip in repDataAll.RoleBaseData.EquipList)
				{
					if (equip.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (equip.Op)
					{
					case OPType.Add:
					{
						int value = equip.Value;
						mRoleBaseData.EquipList.Add((EquipPosition)equip.Idx, value);
						break;
					}
					case OPType.Remove:
						mRoleBaseData.EquipList.Remove((EquipPosition)equip.Idx);
						break;
					case OPType.Modify:
						mRoleBaseData.EquipList[(EquipPosition)equip.Idx] = equip.Value;
						break;
					case OPType.Clear:
						mRoleBaseData.EquipList.Clear();
						break;
					case OPType.SetNull:
						mRoleBaseData.EquipList = null;
						break;
					case OPType.ChangeRef:
						if (mRoleBaseData.EquipList == null)
						{
							mRoleBaseData.EquipList = new BindDictEquipPosition_Int();
						}
						else
						{
							mRoleBaseData.EquipList.Clear();
						}
						break;
					}
				}
			}
			if (repDataAll.RoleBaseData.TalenList != null)
			{
				foreach (DictDeltaMsgInt_Int talen in repDataAll.RoleBaseData.TalenList)
				{
					if (talen.Version <= LastAckedVersion)
					{
						continue;
					}
					switch (talen.Op)
					{
					case OPType.Add:
					{
						int value2 = talen.Value;
						mRoleBaseData.TalenList.Add(talen.Idx, value2);
						break;
					}
					case OPType.Remove:
						mRoleBaseData.TalenList.Remove(talen.Idx);
						break;
					case OPType.Modify:
						mRoleBaseData.TalenList[talen.Idx] = talen.Value;
						break;
					case OPType.Clear:
						mRoleBaseData.TalenList.Clear();
						break;
					case OPType.SetNull:
						mRoleBaseData.TalenList = null;
						break;
					case OPType.ChangeRef:
						if (mRoleBaseData.TalenList == null)
						{
							mRoleBaseData.TalenList = new BindDictInt_Int();
						}
						else
						{
							mRoleBaseData.TalenList.Clear();
						}
						break;
					}
				}
			}
		}
		if (repDataAll.TransactionData != null && mTransactionData != null && repDataAll.TransactionData.ActiveTransactions != null)
		{
			foreach (ListDeltaMsgPlayerTransactionBase activeTransaction2 in repDataAll.TransactionData.ActiveTransactions)
			{
				if (activeTransaction2.Version <= LastAckedVersion)
				{
					continue;
				}
				switch (activeTransaction2.Op)
				{
				case OPType.Add:
				{
					PlayerTransactionBase playerTransactionBase2 = null;
					foreach (ClassDeltaMsgPlayerTransactionBase item9 in activeTransaction2.Value)
					{
						if (item9.Version <= LastAckedVersion)
						{
							continue;
						}
						switch (item9.Op)
						{
						case OPType.Modify:
							if (item9.Value.HasParentTransactionId)
							{
								playerTransactionBase2.ParentTransactionId = item9.Value.ParentTransactionId;
							}
							if (item9.Value.HasTransactionId)
							{
								playerTransactionBase2.TransactionId = item9.Value.TransactionId;
							}
							foreach (ClassDeltaMsgPlayerTransactionTaskBase item10 in item9.Value.ActiveTask)
							{
								if (item10.Version <= LastAckedVersion)
								{
									continue;
								}
								switch (item10.Op)
								{
								case OPType.Modify:
									if (item10.Value.HasTaskType)
									{
										playerTransactionBase2.ActiveTask.TaskType = item10.Value.TaskType;
									}
									if (item10.Value.HasTaskState)
									{
										playerTransactionBase2.ActiveTask.TaskState = (ETransactionTaskState)item10.Value.TaskState;
									}
									break;
								case OPType.SetNull:
									playerTransactionBase2.ActiveTask = null;
									break;
								case OPType.ChangeRef:
									if (item10.Value.GSRepSubClassIdx < 0)
									{
										playerTransactionBase2.ActiveTask = new PlayerTransactionTaskBase();
									}
									else if (item10.Value.GSRepSubClassIdx == 0)
									{
										playerTransactionBase2.ActiveTask = new PlayerTransactionTask_RequestInteractObjLock();
									}
									break;
								}
							}
							foreach (ListDeltaMsgPlayerTransactionTaskBase finishedTask3 in item9.Value.FinishedTasks)
							{
								if (finishedTask3.Version <= LastAckedVersion)
								{
									continue;
								}
								switch (finishedTask3.Op)
								{
								case OPType.Add:
								{
									PlayerTransactionTaskBase playerTransactionTaskBase3 = null;
									foreach (ClassDeltaMsgPlayerTransactionTaskBase item11 in finishedTask3.Value)
									{
										if (item11.Version <= LastAckedVersion)
										{
											continue;
										}
										switch (item11.Op)
										{
										case OPType.Modify:
											if (item11.Value.HasTaskType)
											{
												playerTransactionTaskBase3.TaskType = item11.Value.TaskType;
											}
											if (item11.Value.HasTaskState)
											{
												playerTransactionTaskBase3.TaskState = (ETransactionTaskState)item11.Value.TaskState;
											}
											break;
										case OPType.SetNull:
											playerTransactionTaskBase3 = null;
											break;
										case OPType.ChangeRef:
											if (item11.Value.GSRepSubClassIdx < 0)
											{
												playerTransactionTaskBase3 = new PlayerTransactionTaskBase();
											}
											else if (item11.Value.GSRepSubClassIdx == 0)
											{
												playerTransactionTaskBase3 = new PlayerTransactionTask_RequestInteractObjLock();
											}
											break;
										}
									}
									playerTransactionBase2.FinishedTasks.Add(playerTransactionTaskBase3);
									break;
								}
								case OPType.Remove:
									playerTransactionBase2.FinishedTasks.RemoveAt((int)finishedTask3.Idx);
									break;
								case OPType.Modify:
									foreach (ClassDeltaMsgPlayerTransactionTaskBase item12 in finishedTask3.Value)
									{
										if (item12.Version <= LastAckedVersion)
										{
											continue;
										}
										switch (item12.Op)
										{
										case OPType.Modify:
											if (item12.Value.HasTaskType)
											{
												playerTransactionBase2.FinishedTasks[(int)finishedTask3.Idx].TaskType = item12.Value.TaskType;
											}
											if (item12.Value.HasTaskState)
											{
												playerTransactionBase2.FinishedTasks[(int)finishedTask3.Idx].TaskState = (ETransactionTaskState)item12.Value.TaskState;
											}
											break;
										case OPType.SetNull:
											playerTransactionBase2.FinishedTasks[(int)finishedTask3.Idx] = null;
											break;
										case OPType.ChangeRef:
											if (item12.Value.GSRepSubClassIdx < 0)
											{
												playerTransactionBase2.FinishedTasks[(int)finishedTask3.Idx] = new PlayerTransactionTaskBase();
											}
											else if (item12.Value.GSRepSubClassIdx == 0)
											{
												playerTransactionBase2.FinishedTasks[(int)finishedTask3.Idx] = new PlayerTransactionTask_RequestInteractObjLock();
											}
											break;
										}
									}
									break;
								case OPType.Clear:
									playerTransactionBase2.FinishedTasks.Clear();
									break;
								case OPType.SetNull:
									playerTransactionBase2.FinishedTasks = null;
									break;
								case OPType.ChangeRef:
									if (playerTransactionBase2.FinishedTasks == null)
									{
										playerTransactionBase2.FinishedTasks = new BindListPlayerTransactionTaskBase();
									}
									else
									{
										playerTransactionBase2.FinishedTasks.Clear();
									}
									break;
								}
							}
							if (item9.Value.HasTransactionState)
							{
								playerTransactionBase2.TransactionState = (ETransactionState)item9.Value.TransactionState;
							}
							if (item9.Value.HasPlayerTransactionInteractInteractTarget)
							{
								(playerTransactionBase2 as PlayerTransactionInteract).InteractTarget = GCHelper.FindRef(BGW_NativeFuncs.GSRep_GetActorForGUID(ConnectionPtr, item9.Value.PlayerTransactionInteractInteractTarget))?.Managed as AActor;
							}
							break;
						case OPType.SetNull:
							playerTransactionBase2 = null;
							break;
						case OPType.ChangeRef:
							if (item9.Value.GSRepSubClassIdx < 0)
							{
								playerTransactionBase2 = new PlayerTransactionBase();
							}
							else if (item9.Value.GSRepSubClassIdx == 0)
							{
								playerTransactionBase2 = new PlayerTransactionInteract();
							}
							break;
						}
					}
					mTransactionData.ActiveTransactions.Add(playerTransactionBase2);
					break;
				}
				case OPType.Remove:
					mTransactionData.ActiveTransactions.RemoveAt((int)activeTransaction2.Idx);
					break;
				case OPType.Modify:
					foreach (ClassDeltaMsgPlayerTransactionBase item13 in activeTransaction2.Value)
					{
						if (item13.Version <= LastAckedVersion)
						{
							continue;
						}
						switch (item13.Op)
						{
						case OPType.Modify:
							if (item13.Value.HasParentTransactionId)
							{
								mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].ParentTransactionId = item13.Value.ParentTransactionId;
							}
							if (item13.Value.HasTransactionId)
							{
								mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].TransactionId = item13.Value.TransactionId;
							}
							foreach (ClassDeltaMsgPlayerTransactionTaskBase item14 in item13.Value.ActiveTask)
							{
								if (item14.Version <= LastAckedVersion)
								{
									continue;
								}
								switch (item14.Op)
								{
								case OPType.Modify:
									if (item14.Value.HasTaskType)
									{
										mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].ActiveTask.TaskType = item14.Value.TaskType;
									}
									if (item14.Value.HasTaskState)
									{
										mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].ActiveTask.TaskState = (ETransactionTaskState)item14.Value.TaskState;
									}
									break;
								case OPType.SetNull:
									mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].ActiveTask = null;
									break;
								case OPType.ChangeRef:
									if (item14.Value.GSRepSubClassIdx < 0)
									{
										mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].ActiveTask = new PlayerTransactionTaskBase();
									}
									else if (item14.Value.GSRepSubClassIdx == 0)
									{
										mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].ActiveTask = new PlayerTransactionTask_RequestInteractObjLock();
									}
									break;
								}
							}
							foreach (ListDeltaMsgPlayerTransactionTaskBase finishedTask4 in item13.Value.FinishedTasks)
							{
								if (finishedTask4.Version <= LastAckedVersion)
								{
									continue;
								}
								switch (finishedTask4.Op)
								{
								case OPType.Add:
								{
									PlayerTransactionTaskBase playerTransactionTaskBase4 = null;
									foreach (ClassDeltaMsgPlayerTransactionTaskBase item15 in finishedTask4.Value)
									{
										if (item15.Version <= LastAckedVersion)
										{
											continue;
										}
										switch (item15.Op)
										{
										case OPType.Modify:
											if (item15.Value.HasTaskType)
											{
												playerTransactionTaskBase4.TaskType = item15.Value.TaskType;
											}
											if (item15.Value.HasTaskState)
											{
												playerTransactionTaskBase4.TaskState = (ETransactionTaskState)item15.Value.TaskState;
											}
											break;
										case OPType.SetNull:
											playerTransactionTaskBase4 = null;
											break;
										case OPType.ChangeRef:
											if (item15.Value.GSRepSubClassIdx < 0)
											{
												playerTransactionTaskBase4 = new PlayerTransactionTaskBase();
											}
											else if (item15.Value.GSRepSubClassIdx == 0)
											{
												playerTransactionTaskBase4 = new PlayerTransactionTask_RequestInteractObjLock();
											}
											break;
										}
									}
									mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks.Add(playerTransactionTaskBase4);
									break;
								}
								case OPType.Remove:
									mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks.RemoveAt((int)finishedTask4.Idx);
									break;
								case OPType.Modify:
									foreach (ClassDeltaMsgPlayerTransactionTaskBase item16 in finishedTask4.Value)
									{
										if (item16.Version <= LastAckedVersion)
										{
											continue;
										}
										switch (item16.Op)
										{
										case OPType.Modify:
											if (item16.Value.HasTaskType)
											{
												mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks[(int)finishedTask4.Idx].TaskType = item16.Value.TaskType;
											}
											if (item16.Value.HasTaskState)
											{
												mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks[(int)finishedTask4.Idx].TaskState = (ETransactionTaskState)item16.Value.TaskState;
											}
											break;
										case OPType.SetNull:
											mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks[(int)finishedTask4.Idx] = null;
											break;
										case OPType.ChangeRef:
											if (item16.Value.GSRepSubClassIdx < 0)
											{
												mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks[(int)finishedTask4.Idx] = new PlayerTransactionTaskBase();
											}
											else if (item16.Value.GSRepSubClassIdx == 0)
											{
												mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks[(int)finishedTask4.Idx] = new PlayerTransactionTask_RequestInteractObjLock();
											}
											break;
										}
									}
									break;
								case OPType.Clear:
									mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks.Clear();
									break;
								case OPType.SetNull:
									mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks = null;
									break;
								case OPType.ChangeRef:
									if (mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks == null)
									{
										mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks = new BindListPlayerTransactionTaskBase();
									}
									else
									{
										mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].FinishedTasks.Clear();
									}
									break;
								}
							}
							if (item13.Value.HasTransactionState)
							{
								mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx].TransactionState = (ETransactionState)item13.Value.TransactionState;
							}
							if (item13.Value.HasPlayerTransactionInteractInteractTarget)
							{
								(mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx] as PlayerTransactionInteract).InteractTarget = GCHelper.FindRef(BGW_NativeFuncs.GSRep_GetActorForGUID(ConnectionPtr, item13.Value.PlayerTransactionInteractInteractTarget))?.Managed as AActor;
							}
							break;
						case OPType.SetNull:
							mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx] = null;
							break;
						case OPType.ChangeRef:
							if (item13.Value.GSRepSubClassIdx < 0)
							{
								mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx] = new PlayerTransactionBase();
							}
							else if (item13.Value.GSRepSubClassIdx == 0)
							{
								mTransactionData.ActiveTransactions[(int)activeTransaction2.Idx] = new PlayerTransactionInteract();
							}
							break;
						}
					}
					break;
				case OPType.Clear:
					mTransactionData.ActiveTransactions.Clear();
					break;
				case OPType.SetNull:
					mTransactionData.ActiveTransactions = null;
					break;
				case OPType.ChangeRef:
					if (mTransactionData.ActiveTransactions == null)
					{
						mTransactionData.ActiveTransactions = new BindListPlayerTransactionBase();
					}
					else
					{
						mTransactionData.ActiveTransactions.Clear();
					}
					break;
				}
			}
		}
		LastAckedVersion = repDataAll.Version;
	}

	public void OnAttachHandWritten()
	{
		GetPlayerEventCollection().Evt_BPS_DoReplicateData += new Del_DoReplicateData(OnRecvReplicationData);
	}

	protected int OnRecvReplicationData(IntPtr ConnectionPtr, byte[] ReplicationBytes)
	{
		try
		{
			ReplicateData(ConnectionPtr, ReplicationBytes);
			return 0;
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"Replicate Data Error!!! {arg}");
			return -1;
		}
	}
}
