using System;
using System.Collections;
using System.Collections.Generic;
using AOT;
using UnrealEngine.Engine;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class Coroutine
{
	private delegate void Del_OnPostWorldCleanup(IntPtr world, bool sessionEnded, bool cleanupResources);

	public const bool PoolByDefault = true;

	private bool complete;

	private Dictionary<uint, YieldInstruction> keepAliveInstructions;

	private Queue<YieldInstruction> injectedInstructionQueue;

	private CoroutineGroup group;

	private string tag;

	internal int mainCollectionIndex = -1;

	internal int tagsCollectionIndex = -1;

	internal int objectsCollectionIndex = -1;

	private static bool insideMainCoroutineLoop = false;

	private static CoroutineGroup runningGroup = CoroutineGroup.None;

	private static List<Coroutine> coroutines = new List<Coroutine>();

	internal static List<IComparableYieldInstructionCollection> comparableCollections = new List<IComparableYieldInstructionCollection>();

	private static Dictionary<UObject, List<Coroutine>> coroutinesByObject = new Dictionary<UObject, List<Coroutine>>();

	private static Dictionary<string, List<Coroutine>> coroutinesByTag = new Dictionary<string, List<Coroutine>>();

	public object Owner { get; internal set; }

	public IEnumerator Enumerator { get; internal set; }

	public bool Complete
	{
		get
		{
			return complete;
		}
		set
		{
			if (complete != value)
			{
				complete = value;
				if (complete && this.OnComplete != null)
				{
					this.OnComplete(this);
				}
			}
		}
	}

	public bool IsCurrentInstructionInjected { get; private set; }

	public YieldInstruction CurrentInstruction { get; private set; }

	public CoroutineGroup Group
	{
		get
		{
			return group;
		}
		set
		{
			if (group != value)
			{
				CoroutineGroup oldGroup = group;
				group = value;
				if (CurrentInstruction != null && CurrentInstruction.IsInsideComparableCollection)
				{
					CurrentInstruction.comparableCollection.OnGroupChanged(CurrentInstruction, oldGroup, group);
				}
			}
		}
	}

	public CoroutineGroup TargetGroup { get; set; }

	public CoroutineGroup CurrentGroup
	{
		get
		{
			if (TargetGroup == CoroutineGroup.None)
			{
				return Group;
			}
			return TargetGroup;
		}
	}

	public string Tag
	{
		get
		{
			return tag;
		}
		set
		{
			if (mainCollectionIndex != -1 && tag != value)
			{
				OnCoroutineTagChanged(this, tag, value);
			}
			tag = value;
		}
	}

	public bool IsPaused { get; set; }

	public bool IsPooled { get; internal set; }

	public event CoroutineEventHandler OnReset;

	public event CoroutineEventHandler OnComplete;

	public event CoroutineEventHandler OnStopped;

	public static SetCoroutineGroup SetGroup(CoroutineGroup group)
	{
		return YieldPools.SetCoroutineGroup.PoolNew(group);
	}

	public static WaitForExactFrame WaitForExactFrame(ulong frame)
	{
		return YieldPools.WaitForExactFrame.PoolNew(frame);
	}

	public static WaitForExactTick WaitForExactTick(ulong tick)
	{
		return YieldPools.WaitForExactTick.PoolNew(tick);
	}

	public static WaitForTicks WaitForTicks(ulong ticks)
	{
		return YieldPools.WaitForTicks.PoolNew(ticks);
	}

	public static WaitForFrames WaitForFrames(ulong frames)
	{
		return YieldPools.WaitForFrames.PoolNew(frames);
	}

	public static WaitForTicks WaitOneTick()
	{
		return WaitForTicks(1uL);
	}

	public static WaitForFrames WaitOneFrame()
	{
		return WaitForFrames(1uL);
	}

	public static WaitForGroup WaitForGroup(CoroutineGroup group, ulong skipTicks = 0uL, uint skipFrames = 0u)
	{
		return YieldPools.WaitForGroup.PoolNew(group, skipTicks, skipFrames);
	}

	public static WaitUntil WaitUntil(WaitUntilCallback callback)
	{
		return YieldPools.WaitUntil.PoolNew(callback);
	}

	public static WaitWhile WaitWhile(WaitWhileCallback callback)
	{
		return YieldPools.WaitWhile.PoolNew(callback);
	}

	public static WaitAll WaitAll(params YieldInstruction[] instructions)
	{
		return YieldPools.WaitAll.PoolNew(instructions);
	}

	public static WaitAny WaitAny(params YieldInstruction[] instructions)
	{
		return YieldPools.WaitAny.PoolNew(instructions);
	}

	public static WaitForever WaitForever()
	{
		return YieldPools.WaitForever.PoolNew();
	}

	public static WaitForCoroutine WaitForCoroutine(Coroutine coroutine)
	{
		return YieldPools.WaitForCoroutine.PoolNew(coroutine);
	}

	public static WaitFor WaitFor(TimeSpan time)
	{
		return YieldPools.WaitFor.PoolNew(time);
	}

	public static WaitForMilliseconds WaitForMilliseconds(uint milliseconds)
	{
		return YieldPools.WaitForMilliseconds.PoolNew(milliseconds);
	}

	public static WaitForMilliseconds WaitForMilliseconds(double milliseconds)
	{
		return YieldPools.WaitForMilliseconds.PoolNew(milliseconds);
	}

	public static WaitForSeconds WaitForSeconds(uint seconds)
	{
		return YieldPools.WaitForSeconds.PoolNew(seconds);
	}

	public static WaitForSeconds WaitForSeconds(double seconds)
	{
		return YieldPools.WaitForSeconds.PoolNew(seconds);
	}

	public static WaitForRealtime WaitForRealtime(TimeSpan time)
	{
		return YieldPools.WaitForRealtime.PoolNew(time);
	}

	public static WaitForMillisecondsRealtime WaitForMillisecondsRealtime(uint milliseconds)
	{
		return YieldPools.WaitForMillisecondsRealtime.PoolNew(milliseconds);
	}

	public static WaitForMillisecondsRealtime WaitForMillisecondsRealtime(double milliseconds)
	{
		return YieldPools.WaitForMillisecondsRealtime.PoolNew(milliseconds);
	}

	public static WaitForSecondsRealtime WaitForSecondsRealtime(uint seconds)
	{
		return YieldPools.WaitForSecondsRealtime.PoolNew(seconds);
	}

	public static WaitForSecondsRealtime WaitForSecondsRealtime(double seconds)
	{
		return YieldPools.WaitForSecondsRealtime.PoolNew(seconds);
	}

	public Coroutine()
	{
	}

	public Coroutine(IEnumerator enumerator)
	{
		Enumerator = enumerator;
	}

	internal void Reset()
	{
		if (this.OnReset != null)
		{
			this.OnReset(this);
		}
		TargetGroup = CoroutineGroup.None;
		IsPaused = false;
		ReleaseInstructions();
		complete = false;
		mainCollectionIndex = -1;
		tagsCollectionIndex = -1;
		objectsCollectionIndex = -1;
		Owner = null;
		Tag = null;
		this.OnReset = null;
		this.OnComplete = null;
		this.OnStopped = null;
	}

	public void Stop()
	{
		if (!complete)
		{
			complete = true;
			if (this.OnStopped != null)
			{
				this.OnStopped(this);
			}
		}
		ReleaseInstructions();
	}

	private void ReleaseInstructions()
	{
		if (injectedInstructionQueue != null)
		{
			foreach (YieldInstruction item in injectedInstructionQueue)
			{
				ReleaseInstruction(item);
			}
			injectedInstructionQueue.Clear();
		}
		if (CurrentInstruction != null)
		{
			ReleaseInstruction(CurrentInstruction);
		}
		CurrentInstruction = null;
		if (keepAliveInstructions == null)
		{
			return;
		}
		foreach (KeyValuePair<uint, YieldInstruction> keepAliveInstruction in keepAliveInstructions)
		{
			keepAliveInstruction.Value.pool.ReturnObject(keepAliveInstruction.Value);
		}
		keepAliveInstructions.Clear();
	}

	private void ReleaseInstruction(YieldInstruction instruction)
	{
		if (instruction.running)
		{
			instruction.End();
		}
		if (!instruction.IsPooled)
		{
			return;
		}
		if (instruction.keepAlive)
		{
			if (keepAliveInstructions == null)
			{
				keepAliveInstructions = new Dictionary<uint, YieldInstruction>();
			}
			if (!keepAliveInstructions.ContainsKey(instruction.poolId))
			{
				keepAliveInstructions.Add(instruction.poolId, instruction);
			}
		}
		else
		{
			instruction.pool.ReturnObject(instruction);
		}
	}

	public void Process(CoroutineGroup group)
	{
		if (IsPaused || !ProcessCurrentInstruction(group))
		{
			return;
		}
		if (Enumerator == null)
		{
			FMessage.Log(ELogVerbosity.Error, "Coroutine enumerator is null");
			Stop();
			return;
		}
		try
		{
			while (Enumerator.MoveNext())
			{
				if (Enumerator.Current is YieldInstruction currentInstruction)
				{
					CurrentInstruction = currentInstruction;
					CurrentInstruction.Owner = this;
					CurrentInstruction.Begin();
					if (!ProcessCurrentInstruction(group))
					{
						return;
					}
					continue;
				}
				return;
			}
		}
		catch (Exception ex)
		{
			FMessage.Log(ELogVerbosity.Error, "Exception when running coroutine. " + Environment.NewLine + ex.ToString());
			Stop();
			return;
		}
		Complete = true;
	}

	private bool ProcessCurrentInstruction(CoroutineGroup group)
	{
		if (CurrentInstruction != null)
		{
			if (!ProcessInstruction(CurrentInstruction, group))
			{
				return false;
			}
			CurrentInstruction = null;
		}
		while (injectedInstructionQueue != null && injectedInstructionQueue.Count > 0)
		{
			CurrentInstruction = injectedInstructionQueue.Dequeue();
			CurrentInstruction.Begin();
			IsCurrentInstructionInjected = true;
			if (!ProcessInstruction(CurrentInstruction, group))
			{
				return false;
			}
		}
		IsCurrentInstructionInjected = false;
		return true;
	}

	private bool ProcessInstruction(YieldInstruction instruction, CoroutineGroup group)
	{
		if (CurrentGroup != group || instruction.KeepWaiting)
		{
			return false;
		}
		instruction.End();
		ReleaseInstruction(instruction);
		return true;
	}

	public void InjectInstruction(YieldInstruction instruction, YieldInstructionInjectType injectType = YieldInstructionInjectType.Queue)
	{
		instruction.Owner = this;
		if (instruction.running)
		{
			throw new InvalidOperationException("Cannot inject an already running instruction.");
		}
		if (CurrentInstruction != null)
		{
			switch (injectType)
			{
			case YieldInstructionInjectType.RemoveCurrent:
				ReleaseInstruction(CurrentInstruction);
				CurrentInstruction = instruction;
				CurrentInstruction.Begin();
				break;
			case YieldInstructionInjectType.SwapCurrent:
				if (CurrentInstruction.running)
				{
					CurrentInstruction.End();
				}
				CurrentInstruction = instruction;
				CurrentInstruction.Begin();
				break;
			default:
				if (injectedInstructionQueue == null)
				{
					injectedInstructionQueue = new Queue<YieldInstruction>();
				}
				injectedInstructionQueue.Enqueue(instruction);
				break;
			}
		}
		else
		{
			CurrentInstruction = instruction;
		}
	}

	private static void ObseleteFunc()
	{
		throw new Exception("Coroutine is obselete and no more supported in this Version");
	}

	internal static void ProcessCoroutines(CoroutineGroup group)
	{
	}

	private static void CoroutineRemoveAtSwap(Coroutine coroutine, bool returnToPool)
	{
		ObseleteFunc();
		Coroutine coroutine2 = coroutines[coroutines.Count - 1];
		coroutines.RemoveAtSwapEx(ref coroutine.mainCollectionIndex, ref coroutine2.mainCollectionIndex);
		if (returnToPool)
		{
			UObject key;
			if (coroutine.objectsCollectionIndex >= 0 && (key = coroutine.Owner as UObject) != null && coroutinesByObject.TryGetValue(key, out var value))
			{
				Coroutine coroutine3 = value[value.Count - 1];
				value.RemoveAtSwapEx(ref coroutine.objectsCollectionIndex, ref coroutine3.objectsCollectionIndex);
			}
			if (coroutine.tagsCollectionIndex >= 0 && !string.IsNullOrEmpty(coroutine.Tag) && coroutinesByTag.TryGetValue(coroutine.Tag, out var value2))
			{
				Coroutine coroutine4 = value2[value2.Count - 1];
				value2.RemoveAtSwapEx(ref coroutine.tagsCollectionIndex, ref coroutine4.tagsCollectionIndex);
			}
			if (coroutine.IsPooled)
			{
				CoroutinePool.ReturnObject(coroutine);
			}
		}
	}

	internal static void ComparableBegin(Coroutine coroutine)
	{
		ObseleteFunc();
		CoroutineRemoveAtSwap(coroutine, returnToPool: false);
	}

	internal static void ComparableEnd(Coroutine coroutine)
	{
		ObseleteFunc();
		coroutine.mainCollectionIndex = coroutines.Count;
		coroutines.Add(coroutine);
		if (!insideMainCoroutineLoop)
		{
			if (coroutine.CurrentGroup == runningGroup && !coroutine.Complete)
			{
				coroutine.Process(runningGroup);
			}
			_ = coroutine.Complete;
		}
	}

	public static Coroutine StartCoroutine(object obj, IEnumerator coroutine, bool pool = true)
	{
		ObseleteFunc();
		return StartCoroutine(obj, coroutine, CoroutineGroup.Tick, pool);
	}

	public static Coroutine StartCoroutine(object obj, IEnumerator coroutine, CoroutineGroup group, bool pool = true)
	{
		ObseleteFunc();
		return StartCoroutine(obj, coroutine, group, null, pool);
	}

	public static Coroutine StartCoroutine(object obj, IEnumerator coroutine, CoroutineGroup group, string tag = null, bool pool = true)
	{
		ObseleteFunc();
		Coroutine coroutine2 = null;
		UObject uObject = obj as UObject;
		if (uObject != null)
		{
			Native_UObject.GetWorld(uObject.Address);
		}
		coroutine2 = ((!pool) ? new Coroutine(coroutine) : CoroutinePool.New(coroutine));
		coroutine2.Owner = obj;
		coroutine2.Group = group;
		coroutine2.mainCollectionIndex = coroutines.Count;
		coroutine2.Tag = tag;
		coroutines.Add(coroutine2);
		if (uObject != null)
		{
			if (!coroutinesByObject.TryGetValue(uObject, out var value))
			{
				coroutinesByObject.Add(uObject, value = new List<Coroutine>());
			}
			coroutine2.objectsCollectionIndex = value.Count;
			value.Add(coroutine2);
		}
		if (!string.IsNullOrEmpty(tag))
		{
			if (!coroutinesByTag.TryGetValue(tag, out var value2))
			{
				coroutinesByTag.Add(tag, value2 = new List<Coroutine>());
			}
			coroutine2.tagsCollectionIndex = value2.Count;
			value2.Add(coroutine2);
		}
		return coroutine2;
	}

	public static void StopCoroutine(Coroutine coroutine)
	{
		coroutine.Stop();
	}

	public static void StopCoroutine(IEnumerator coroutine)
	{
		foreach (KeyValuePair<UObject, List<Coroutine>> item in coroutinesByObject)
		{
			foreach (Coroutine item2 in item.Value)
			{
				item2.Stop();
			}
		}
	}

	public static void StopCoroutine(UObject owner, IEnumerator coroutine)
	{
		List<Coroutine> list = FindCoroutines(owner);
		if (list == null || list.Count <= 0)
		{
			return;
		}
		foreach (Coroutine item in list)
		{
			if (item.Enumerator == coroutine)
			{
				item.Stop();
			}
		}
	}

	public static void StopCoroutines(string tag)
	{
		if (string.IsNullOrEmpty(tag))
		{
			foreach (Coroutine coroutine in coroutines)
			{
				if (coroutine.Tag == tag)
				{
					coroutine.Stop();
				}
			}
			return;
		}
		if (!coroutinesByTag.TryGetValue(tag, out var value))
		{
			return;
		}
		foreach (Coroutine item in value)
		{
			item.Stop();
		}
	}

	public static void StopAllCoroutines(UObject owner)
	{
		if (!coroutinesByObject.TryGetValue(owner, out var value))
		{
			return;
		}
		foreach (Coroutine item in value)
		{
			item.Stop();
		}
	}

	public static List<Coroutine> FindCoroutines(string tag)
	{
		if (string.IsNullOrEmpty(tag))
		{
			List<Coroutine> list = new List<Coroutine>();
			{
				foreach (Coroutine coroutine in coroutines)
				{
					if (coroutine.Tag == tag)
					{
						list.Add(coroutine);
					}
				}
				return list;
			}
		}
		coroutinesByTag.TryGetValue(tag, out var value);
		return value;
	}

	public static List<Coroutine> FindCoroutines(UObject owner)
	{
		coroutinesByObject.TryGetValue(owner, out var value);
		return value;
	}

	public static List<Coroutine> FindCoroutines(UObject owner, string tag)
	{
		List<Coroutine> list = new List<Coroutine>();
		List<Coroutine> list2 = FindCoroutines(owner);
		if (list2 != null)
		{
			foreach (Coroutine item in list2)
			{
				if (item.Tag == tag)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	public static List<Coroutine> GetAllCoroutines()
	{
		return coroutines;
	}

	internal static void OnCoroutineTagChanged(Coroutine coroutine, string oldTag, string newTag)
	{
		if (coroutine.tagsCollectionIndex != -1 && coroutinesByTag.TryGetValue(oldTag, out var value))
		{
			Coroutine coroutine2 = value[value.Count - 1];
			value.RemoveAtSwapEx(ref coroutine.tagsCollectionIndex, ref coroutine2.tagsCollectionIndex);
		}
		if (!string.IsNullOrEmpty(newTag))
		{
			if (!coroutinesByTag.TryGetValue(newTag, out var value2))
			{
				coroutinesByTag.Add(newTag, value2 = new List<Coroutine>());
			}
			coroutine.tagsCollectionIndex = value2.Count;
			value2.Add(coroutine);
		}
	}

	internal static void OnNativeFunctionsRegistered()
	{
		FWorldDelegates.OnPostWorldCleanup.Bind(OnPostWorldCleanup);
	}

	[MonoPInvokeCallback(typeof(Del_OnPostWorldCleanup))]
	private static void OnPostWorldCleanup(IntPtr world, bool sessionEnded, bool cleanupResources)
	{
		try
		{
			foreach (KeyValuePair<UObject, List<Coroutine>> item in coroutinesByObject)
			{
				if (item.Key.Address != IntPtr.Zero)
				{
					if (Native_UObject.GetWorld(item.Key.Address) == world)
					{
						StopAllCoroutines(item.Key);
					}
				}
				else
				{
					StopAllCoroutines(item.Key);
				}
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	internal static void RemoveObjectByGC(UObject obj)
	{
	}
}
