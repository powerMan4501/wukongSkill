using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using b1.ECS;
using b1.EventDelDefine;
using b1.GSFile;
using b1.UI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_LeakLogUtil
{
	private const string LogName = "LeakLog";

	private const ELeakLogLevel LogLevel = ELeakLogLevel.Leak;

	private static readonly string LogDir = Path.Combine(GSEFileUtil.ProjectPersistentDownloadDir, "LeakLog");

	public static readonly string SnapShotDir = Path.Combine(GSEFileUtil.ProjectPersistentDownloadDir, "ExportGameData");

	private UObject WorldContext;

	private const float CheckTime = 60f;

	private float CurCheckTime;

	private bool IsObjLeak;

	private bool EventMemoryLeakTest;

	private bool MemoryLeakTestCacheObj;

	private BGW_EventCollection EventCollection;

	private bool OpenProfiler;

	public void Init(UObject InWorldContext)
	{
		WorldContext = InWorldContext;
		EventCollection = BGW_EventCollection.Get(WorldContext);
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_LeakLogTest = (Del_Bool_Void)Delegate.Combine(eventCollection.Evt_LeakLogTest, new Del_Bool_Void(OnLeakLogTest));
		IsObjLeak = false;
		EventMemoryLeakTest = DebugConfig.EventMemoryLeakTest;
		StrongPtrLeakDetection.SetEventMemoryLeakTest(DebugConfig.EventMemoryLeakTest);
		MemoryLeakTestCacheObj = DebugConfig.MemoryLeakTestCacheObj;
		UpdateEventMemoryLeakTest(0f);
	}

	public bool GetIsNeedLog(ELeakLogLevel InLogLevel)
	{
		return (InLogLevel & ELeakLogLevel.Leak) != 0;
	}

	public void OnTick(float DeltaTime)
	{
		UpdateEventMemoryLeakTest(DeltaTime);
	}

	private void UpdateEventMemoryLeakTest(float DeltaTime)
	{
		if (WorldContext.IsNullOrDestroyed())
		{
			return;
		}
		bool eventMemoryLeakTest = DebugConfig.EventMemoryLeakTest;
		if (EventMemoryLeakTest ^ eventMemoryLeakTest)
		{
			StrongPtrLeakDetection.SetEventMemoryLeakTest(eventMemoryLeakTest);
			EventMemoryLeakTest = eventMemoryLeakTest;
		}
		if (DebugConfig.TickEventMemoryLeakTest)
		{
			if (!EventMemoryLeakTest)
			{
				DebugConfig.EventMemoryLeakTest = true;
			}
			CurCheckTime += DeltaTime;
			if (CurCheckTime >= 60f)
			{
				CurCheckTime = 0f;
				CheckLeak(ForceCheck: false);
			}
		}
	}

	public void Destroy()
	{
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_LeakLogTest = (Del_Bool_Void)Delegate.Remove(eventCollection.Evt_LeakLogTest, new Del_Bool_Void(OnLeakLogTest));
		WorldContext = null;
	}

	public bool OnLeakLogTest()
	{
		if (!WorldContext.IsNullOrDestroyed())
		{
			UObject.CollectGarbage();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
			UObject.CollectGarbage();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
			UObject.CollectGarbage();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
			IsObjLeak = false;
			CheckLeak(ForceCheck: true);
		}
		return IsObjLeak;
	}

	public void CheckLeak(bool ForceCheck)
	{
		bool flag = false;
		bool flag2 = false;
		if ((DebugConfig.ObjMemoryLeakTest && !IsObjLeak) || ForceCheck)
		{
			List<string> list = new List<string>();
			DirectoryInfo directoryInfo = new DirectoryInfo(LogDir);
			if (directoryInfo.Exists)
			{
				directoryInfo.Delete(recursive: true);
			}
			DirectoryInfo directoryInfo2 = new DirectoryInfo(SnapShotDir);
			if (directoryInfo2.Exists)
			{
				try
				{
					directoryInfo2.Delete(recursive: true);
				}
				catch (Exception ex)
				{
					BGW_LogUtil.LogError("[GSLeakLogUtil] 删除快照文件夹失败:" + ex.Message);
				}
			}
			List<LeakObjPtr> leakObjPtrs = new List<LeakObjPtr>();
			List<LeakStrongPtr> leakStrongPtrs = new List<LeakStrongPtr>();
			List<UnTraceStrongPtr> unTraceStrongPtrs = new List<UnTraceStrongPtr>();
			List<NullStrongPtr> nullStrongPtrs = new List<NullStrongPtr>();
			CheckLeak(list, leakObjPtrs, leakStrongPtrs, unTraceStrongPtrs, nullStrongPtrs, out var HasLeak, out var HasUnTrace);
			flag = flag || HasLeak;
			flag2 = flag2 || HasUnTrace;
			if (HasLeak)
			{
				RunBat(FPaths.Combine(FPaths.ProjectDir, "Tools/dotMemory"), "get_ue_snapshot_biu.bat", IsCatchExitCode: true);
				list.Add(GSEUtil.GetLatestFileTimeInfo(SnapShotDir));
				GSSdkLog("[GSLeakLogUtil] LeakLog", "Log & SnapShotData", list.ToArray());
				IsObjLeak = true;
			}
		}
		if (DebugConfig.EventMemoryLeakTest || ForceCheck)
		{
			CheckEventMemoryLeak(WorldContext, out var HasLeak2, out var HasUnTrace2);
			flag = flag || HasLeak2;
			flag2 = flag2 || HasUnTrace2;
		}
	}

	public void CheckLeak(List<string> FilePathList, List<LeakObjPtr> LeakObjPtrs, List<LeakStrongPtr> LeakStrongPtrs, List<UnTraceStrongPtr> UnTraceStrongPtrs, List<NullStrongPtr> NullStrongPtrs, out bool HasLeak, out bool HasUnTrace)
	{
		HasLeak = false;
		HasUnTrace = false;
		CheckStrongPtrLeak(FilePathList, LeakStrongPtrs, UnTraceStrongPtrs, NullStrongPtrs, out var HasLeak2, out var HasUnTrace2);
		HasLeak |= HasLeak2;
		HasUnTrace |= HasUnTrace2;
		CheckObjLeak(FilePathList, LeakObjPtrs, out var HasLeak3);
		HasLeak |= HasLeak3;
		foreach (WeakReference<GSEventCollectionBase> s_weakReference in GSEventCollectionBase.s_weakReferences)
		{
			if (s_weakReference.TryGetTarget(out var target) && (object)target != null)
			{
				CheckECObjLeak(FilePathList, target, LeakObjPtrs, out var HasLeak4, out var HasUnTrace3);
				HasLeak |= HasLeak4;
				HasUnTrace |= HasUnTrace3;
			}
		}
	}

	public void CheckEventMemoryLeak(UObject GameInstance, out bool HasLeak, out bool HasUnTrace)
	{
		HasLeak = false;
		HasUnTrace = false;
		_ = OpenProfiler;
		CheckBGWEventBindLeak(BGW_EventCollection.Get(GameInstance), out var HasLeak2, out var HasUnTrace2);
		_ = OpenProfiler;
		_ = OpenProfiler;
		CheckBGWEventBindLeak(BGW_UIEventCollection.Get(GameInstance), out var HasLeak3, out var HasUnTrace3);
		_ = OpenProfiler;
		HasLeak |= HasLeak2 || HasLeak3;
		HasUnTrace |= HasUnTrace2 || HasUnTrace3;
		foreach (WeakReference<GSEventCollectionBase> s_weakReference in GSEventCollectionBase.s_weakReferences)
		{
			if (s_weakReference.TryGetTarget(out var target) && (object)target != null)
			{
				_ = OpenProfiler;
				CheckObjEventBindLeak(target, out var HasLeak4, out var HasUnTrace4);
				_ = OpenProfiler;
				HasLeak |= HasLeak4;
				HasUnTrace |= HasUnTrace4;
			}
		}
	}

	private void CheckBGWEventBindLeak(object Instance, out bool HasLeak, out bool HasUnTrace)
	{
		HasLeak = false;
		HasUnTrace = false;
		Dictionary<string, LeakLogDataGroup> dictionary = new Dictionary<string, LeakLogDataGroup>();
		FieldInfo[] fields = Instance.GetType().GetFields();
		if (fields != null)
		{
			FieldInfo[] array = fields;
			foreach (FieldInfo fieldInfo in array)
			{
				if (!fieldInfo.FieldType.IsSubclassOf(typeof(Delegate)) || !(fieldInfo.GetValue(Instance) is Delegate obj))
				{
					continue;
				}
				Delegate[] invocationList = obj.GetInvocationList();
				foreach (Delegate obj2 in invocationList)
				{
					if (obj2.Method.Name.Contains("<.ctor>") || !(obj2.Method != null))
					{
						continue;
					}
					LeakLogData leakLogData = new DelLeakLogData(obj2);
					GetDelTargetResult delTargetObj = GetDelTargetObj(obj2);
					if (delTargetObj.GetIsLeak() && GetIsNeedLog(ELeakLogLevel.Leak))
					{
						GSSdkLog("[GSLeakLogUtil] Leak", leakLogData.ToString());
						HasLeak = true;
					}
					else if (delTargetObj.GetIsValid())
					{
						UObject obj3 = delTargetObj.Obj;
						UWorld world = GetWorld(obj3);
						string key = ((world != null) ? world.GetFullName() : obj3.GetFullName());
						if (!dictionary.TryGetValue(key, out var value))
						{
							value = new LeakLogDataGroup(world);
							dictionary.Add(key, value);
						}
						value.AddData(leakLogData);
					}
					else
					{
						if (GetLogUntrace() && GetIsNeedLog(ELeakLogLevel.Untrace))
						{
							GSSdkLog("[GSLeakLogUtil] UnTrace", leakLogData.ToString());
						}
						HasUnTrace = true;
					}
				}
			}
		}
		if (dictionary.Count <= 1 || !GetIsNeedLog(ELeakLogLevel.MultiWorld))
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, LeakLogDataGroup> item in dictionary)
		{
			stringBuilder.AppendLine(item.ToString());
		}
		GSSdkLog("[GSLeakLogUtil] Multiple Worlds: ", stringBuilder.ToString());
	}

	private static UWorld GetWorld(UObject Obj)
	{
		return UEngine.GEngine.GetWorldFromContextObject(Obj);
	}

	private void CheckObjEventBindLeak(object Instance, out bool HasLeak, out bool HasUnTrace)
	{
		HasLeak = false;
		HasUnTrace = false;
		Dictionary<string, LeakLogDataGroup> dictionary = new Dictionary<string, LeakLogDataGroup>();
		_ = OpenProfiler;
		FieldInfo[] fields = Instance.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
		_ = OpenProfiler;
		if (fields != null)
		{
			_ = OpenProfiler;
			FieldInfo[] array = fields;
			foreach (FieldInfo obj in array)
			{
				_ = OpenProfiler;
				_ = OpenProfiler;
				object value = obj.GetValue(Instance);
				_ = OpenProfiler;
				if (value is IFreshAbleGSEvent && value != null)
				{
					_ = OpenProfiler;
					FieldInfo[] fields2 = value.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
					if (fields2 != null)
					{
						_ = OpenProfiler;
						FieldInfo[] array2 = fields2;
						foreach (FieldInfo fieldInfo in array2)
						{
							if (!fieldInfo.FieldType.IsSubclassOf(typeof(Delegate)) || !(fieldInfo.GetValue(value) is Delegate obj2))
							{
								continue;
							}
							_ = OpenProfiler;
							Delegate[] invocationList = obj2.GetInvocationList();
							foreach (Delegate obj3 in invocationList)
							{
								if (obj3.Method.Name.Contains("<.ctor>") || (obj3.Target != null && obj3.Target is GSEventCollectionBase))
								{
									continue;
								}
								LeakLogData leakLogData = new DelLeakLogData(obj3);
								_ = OpenProfiler;
								GetDelTargetResult delTargetObj = GetDelTargetObj(obj3);
								_ = OpenProfiler;
								if (delTargetObj.GetIsLeak() && GetIsNeedLog(ELeakLogLevel.Leak))
								{
									GSSdkLog("[GSLeakLogUtil] Leak", leakLogData.ToString());
									HasLeak = true;
								}
								else if (delTargetObj.GetIsValid() || delTargetObj.GetIsCatch())
								{
									UObject obj4 = delTargetObj.Obj;
									if (obj4 != null)
									{
										UWorld world = GetWorld(obj4);
										string key = ((world != null) ? world.GetFullName() : obj4.GetFullName());
										if (!dictionary.TryGetValue(key, out var value2))
										{
											value2 = new LeakLogDataGroup(world);
											dictionary.Add(key, value2);
										}
										value2.AddData(leakLogData);
									}
								}
								else
								{
									if (GetLogUntrace() && GetIsNeedLog(ELeakLogLevel.Untrace))
									{
										GSSdkLog("[GSLeakLogUtil] UnTrace", leakLogData.ToString());
									}
									HasUnTrace = true;
								}
							}
							_ = OpenProfiler;
						}
						_ = OpenProfiler;
					}
					_ = OpenProfiler;
				}
				_ = OpenProfiler;
			}
			_ = OpenProfiler;
		}
		if (dictionary.Count <= GetLogMultiWorldCount() || !GetIsNeedLog(ELeakLogLevel.Untrace))
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, LeakLogDataGroup> item in dictionary)
		{
			stringBuilder.AppendLine(item.ToString());
		}
		GSSdkLog("[GSLeakLogUtil] Multiple Worlds: ", stringBuilder.ToString());
	}

	private void CheckObjLeak(List<string> FilePathList, List<LeakObjPtr> LeakObjPtrs, out bool HasLeak)
	{
		HasLeak = false;
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		List<LeakObjPtr> list = new List<LeakObjPtr>();
		foreach (WeakReference<BGGGameStateCS> s_weakReference in BGGGameStateCS.s_weakReferences)
		{
			if (s_weakReference.TryGetTarget(out var target) && target.IsNullOrDestroyed() && (object)target != null)
			{
				num++;
				HasLeak = true;
				list.Add(new LeakObjPtr(target, MemoryLeakTestCacheObj));
			}
		}
		if (!HasLeak)
		{
			return;
		}
		LeakObjPtrs.AddRange(list);
		foreach (WeakReference<BGGGameStateCS> s_weakReference2 in BGGGameStateCS.s_weakReferences)
		{
			if (s_weakReference2.TryGetTarget(out var target2))
			{
				if (!target2.IsNullOrDestroyed())
				{
					stringBuilder.AppendLine(UGSE_EngineFuncLib.FindAndPrintStaleReferencesToObject(target2));
				}
				else if ((object)target2 != null)
				{
					stringBuilder.AppendLine("纯C#泄露");
				}
			}
		}
		if (!Directory.Exists(LogDir))
		{
			Directory.CreateDirectory(LogDir);
		}
		string text = Path.Combine(LogDir, "LeakLog_Obj.log");
		StreamWriter streamWriter = new StreamWriter(text, append: true);
		streamWriter.WriteLine(stringBuilder.ToString());
		streamWriter.Close();
		FilePathList.Add(text);
	}

	private void CheckECObjLeak(List<string> FilePathList, object Instance, List<LeakObjPtr> LeakObjPtrs, out bool HasLeak, out bool HasUnTrace)
	{
		HasLeak = false;
		HasUnTrace = false;
		LeakLogDataGroup leakLogDataGroup = new LeakLogDataGroup("UnTrace");
		LeakLogDataGroup leakLogDataGroup2 = new LeakLogDataGroup("Leak");
		Dictionary<string, LeakLogDataGroup> dictionary = new Dictionary<string, LeakLogDataGroup>
		{
			{ "UnTrace", leakLogDataGroup },
			{ "Leak", leakLogDataGroup2 }
		};
		if (Instance is GSEventCollectionBase gSEventCollectionBase)
		{
			LeakLogData data = new ECLeakLogData(gSEventCollectionBase);
			if (!gSEventCollectionBase.IsNullOrDestroyed())
			{
				UWorld world = GetWorld(gSEventCollectionBase);
				string key = ((world != null) ? world.GetFullName() : gSEventCollectionBase.GetFullName());
				if (!dictionary.TryGetValue(key, out var value))
				{
					value = new LeakLogDataGroup(world);
					dictionary.Add(key, value);
				}
				value.AddData(data);
			}
			else if ((object)gSEventCollectionBase != null && gSEventCollectionBase.IsDestroyed)
			{
				leakLogDataGroup2.AddData(data);
				HasLeak = true;
			}
			else
			{
				leakLogDataGroup.AddData(data);
				HasUnTrace = true;
			}
			if (HasLeak)
			{
				LeakObjPtrs.Add(new LeakObjPtr(Instance, MemoryLeakTestCacheObj));
			}
		}
		if (!((HasLeak || dictionary.Count > 3) | HasUnTrace))
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, LeakLogDataGroup> item in dictionary)
		{
			stringBuilder.AppendLine(item.ToString());
		}
		if (!Directory.Exists(LogDir))
		{
			Directory.CreateDirectory(LogDir);
		}
		string text = Path.Combine(LogDir, string.Format("{0}_EventBindLog_{1}.log", "LeakLog", Instance.GetType()));
		StreamWriter streamWriter = new StreamWriter(text, append: true);
		streamWriter.WriteLine(stringBuilder.ToString());
		streamWriter.Close();
		FilePathList.Add(text);
	}

	private void CheckStrongPtrLeak(List<string> FilePathList, List<LeakStrongPtr> LeakStrongPtrs, List<UnTraceStrongPtr> UnTraceStrongPtrs, List<NullStrongPtr> NullStrongPtrs, out bool HasLeak, out bool HasUnTrace)
	{
		HasLeak = false;
		HasUnTrace = false;
		LeakLogDataGroup leakLogDataGroup = new LeakLogDataGroup("Leak");
		LeakLogDataGroup value = new LeakLogDataGroup("UnTrace");
		Dictionary<string, LeakLogDataGroup> dictionary = new Dictionary<string, LeakLogDataGroup>
		{
			{ "Leak", leakLogDataGroup },
			{ "UnTrace", value }
		};
		for (int num = StrongPtrLeakDetection.s_weakReferences.Count - 1; num >= 0; num--)
		{
			if (StrongPtrLeakDetection.s_weakReferences[num] != null && StrongPtrLeakDetection.s_weakReferences[num].TryGetTarget(out var target))
			{
				LeakLogData data = new StrongPtrLeakLogData(target);
				UObject uObject = target.GetUObject();
				if (!uObject.IsNullOrDestroyed())
				{
					UWorld world = GetWorld(uObject);
					if (world == null)
					{
						HasUnTrace = true;
						UnTraceStrongPtrs.Add(new UnTraceStrongPtr(target));
					}
					string key = ((world != null) ? world.GetFullName() : uObject.GetFullName());
					if (!dictionary.TryGetValue(key, out var value2))
					{
						value2 = new LeakLogDataGroup(world);
						dictionary.Add(key, value2);
					}
					value2.AddData(data);
				}
				else if ((object)uObject != null && uObject.IsDestroyed)
				{
					HasLeak = true;
					leakLogDataGroup.AddData(data);
					LeakStrongPtrs.Add(new LeakStrongPtr(target));
				}
				else
				{
					NullStrongPtrs.Add(new NullStrongPtr(target));
				}
			}
		}
		if (!((HasLeak || dictionary.Count > 2) | HasUnTrace))
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, LeakLogDataGroup> item in dictionary)
		{
			stringBuilder.AppendLine(item.ToString());
		}
		if (!Directory.Exists(LogDir))
		{
			Directory.CreateDirectory(LogDir);
		}
		string text = Path.Combine(LogDir, "LeakLog_StrongPtr.log");
		StreamWriter streamWriter = new StreamWriter(text, append: true);
		streamWriter.WriteLine(stringBuilder.ToString());
		streamWriter.Close();
		FilePathList.Add(text);
	}

	public static void RunBat(string WorkingDir, string BatName, bool IsCatchExitCode = false)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(BatName);
			processStartInfo.WorkingDirectory = WorkingDir;
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			process.StartInfo = processStartInfo;
			process.Start();
			process.WaitForExit();
			if (process.ExitCode != 0 && IsCatchExitCode)
			{
				throw new Exception($"Run bat {BatName} in {WorkingDir} exits with code: {process.ExitCode}");
			}
		}
		catch (Exception ex)
		{
			FMessage.OpenDialog(ex.Message);
			BGW_LogUtil.LogError(ex.Message);
		}
	}

	public GetDelTargetResult GetDelTargetObj(Delegate InvokeDel)
	{
		UObject uObject = null;
		bool inIsCatch = false;
		bool inIsLeak = false;
		object target = InvokeDel.Target;
		Type type = ((target != null) ? target.GetType() : InvokeDel.Method.DeclaringType);
		if (uObject == null && target is UObject uObject2)
		{
			uObject = (uObject2.IsNullOrDestroyed() ? uObject2 : uObject2.GetOuter());
		}
		else if (uObject == null && target is IEntityComponent entityComponent)
		{
			Entity ownerEntity = entityComponent.GetOwnerEntity();
			uObject = ECSUtil.ToActor(ownerEntity);
			if (BGW_ECSWorld.Get(WorldContext).GetEntityRefState(ownerEntity, out var State))
			{
				inIsLeak = State.HasLeakLoged;
				inIsCatch = State.NeedDestroy;
			}
		}
		else if (uObject == null && target is IGameInstObjCS gameInstObjCS)
		{
			uObject = gameInstObjCS.Owner;
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && target is GameStateSystemBase gameStateSystemBase)
		{
			uObject = gameStateSystemBase.GetOwner();
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && (target is PsmSubMachine || target is PsmSubMachineState || target is PsmStateNodeInstance || target is FGuardConditionBase || target is UActorCompBaseCS))
		{
			MethodInfo method = target.GetType().GetMethod("GetOwner", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method != null)
			{
				uObject = method.Invoke(target, null) as UObject;
			}
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && target is QuestNodeInstance questNodeInstance)
		{
			uObject = questNodeInstance.Owner;
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && target is BUS_AIComp.FsmSolverBase fsmSolverBase)
		{
			uObject = fsmSolverBase.OwningChr;
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && target is BAC_Event bAC_Event)
		{
			uObject = bAC_Event.GetSpeaker();
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && target is BGUBgmTrackBase bGUBgmTrackBase)
		{
			uObject = bGUBgmTrackBase.GetOwner();
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && target is FBehaviorNodeInstanceBase fBehaviorNodeInstanceBase)
		{
			uObject = fBehaviorNodeInstanceBase.Owner;
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && (target is GSUIActorMgr.EvtClass || type == typeof(GSUIActorMgr.EvtClass)))
		{
			uObject = WorldContext;
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && target is IInputLeakHandle inputLeakHandle)
		{
			uObject = inputLeakHandle.GetOwner();
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null && target is BUInteractActionTemplate)
		{
			uObject = WorldContext;
			inIsLeak = uObject.IsNullOrDestroyed();
		}
		else if (uObject == null)
		{
			return GetScriptTargetObj(InvokeDel);
		}
		return new GetDelTargetResult(uObject, inIsLeak, inIsCatch);
	}

	protected virtual GetDelTargetResult GetScriptTargetObj(Delegate InvokeDel)
	{
		return null;
	}

	private bool GetLogUntrace()
	{
		return !DebugConfig.ILRuntime;
	}

	private int GetLogMultiWorldCount()
	{
		if (UGSE_EngineFuncLib.IsStandAlone(GetWorld(WorldContext)))
		{
			return 1;
		}
		return 2;
	}

	public void GSSdkLog(string Tag, string Msg, string[] AssociateFileList = null)
	{
		if (AssociateFileList != null)
		{
			for (int i = 0; i < AssociateFileList.Length; i++)
			{
				_ = AssociateFileList[i];
			}
		}
	}

	public void GSSdkLog(string Tag, object MsgObj, string[] AssociateFileList = null)
	{
	}

	public static bool GetUsagedMemory(out long PrivateMemorySize, out long WorkingSet)
	{
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			PrivateMemorySize = currentProcess.PrivateMemorySize64;
			WorkingSet = currentProcess.WorkingSet64;
			return true;
		}
		catch
		{
			PrivateMemorySize = 0L;
			WorkingSet = 0L;
		}
		return false;
	}

	public static long CovertBToM(long B)
	{
		return B / 1024 / 1024;
	}
}
