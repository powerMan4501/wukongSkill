using System;
using System.Collections.Generic;
using System.Reflection;
using AOT;
using UnrealEngine.Engine;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class Invoker : BinaryHeapItem, IComparable<Invoker>
{
	private delegate void Del_OnPostWorldCleanup(IntPtr world, bool sessionEnded, bool cleanupResources);

	public const bool PoolByDefault = true;

	private static InvokerCollectionGroup tickInvokers = new InvokerCollectionGroup(CoroutineGroup.Tick);

	private static InvokerCollectionGroup beginFrameInvokers = new InvokerCollectionGroup(CoroutineGroup.BeginFrame);

	private static InvokerCollectionGroup endFrameInvokers = new InvokerCollectionGroup(CoroutineGroup.EndFrame);

	private static Dictionary<string, List<Invoker>> invokersByTag = new Dictionary<string, List<Invoker>>();

	private static Dictionary<int, List<Invoker>> invokersByTagId = new Dictionary<int, List<Invoker>>();

	private static Dictionary<UObject, List<Invoker>> invokersByUObject = new Dictionary<UObject, List<Invoker>>();

	private static Dictionary<MethodInfo, List<Invoker>> invokersByMethod = new Dictionary<MethodInfo, List<Invoker>>();

	internal IntPtr OwnerWorld;

	private ulong stopAfterValue;

	private ulong stopAfterEndValue;

	private ulong startingValue;

	private ulong beginValue;

	private ulong totalCallCount;

	private bool cancelInvoke;

	private InvokerCollectionGroup collectionGroup;

	private UnrealBinaryHeapEx<Invoker> collection;

	private int invokersByUObjectIndex = -1;

	private int invokersByMethodIndex = -1;

	private int tagIdIndex = -1;

	private int tagId;

	private int tagIndex = -1;

	private string tag;

	private InvokerHandlerType handlerType;

	private InvokerHandler handler;

	private InvokerHandlerWithObject handlerWithObject;

	private InvokerHandlerWithInvoker handlerWithInvoker;

	private InvokerHandlerWithObjectInvoker handlerWithObjectInvoker;

	public bool IsPooled { get; internal set; }

	public object Owner { get; internal set; }

	public bool IsRepeated { get; private set; }

	public InvokerType Type { get; private set; }

	public CoroutineGroup Group { get; private set; }

	internal ulong Value { get; private set; }

	internal ulong RepeatedValue { get; private set; }

	public bool IsFirstRun { get; private set; }

	public bool Running { get; private set; }

	internal ulong CurrentTargetValue
	{
		get
		{
			if (!IsFirstRun)
			{
				return RepeatedValue;
			}
			return Value;
		}
	}

	public bool HasStopAfterValue { get; private set; }

	internal ulong BeginValue
	{
		get
		{
			return beginValue;
		}
		private set
		{
			beginValue = value;
			EndValue = beginValue + CurrentTargetValue;
		}
	}

	internal ulong EndValue { get; private set; }

	public bool RepeatConstantTime { get; set; }

	public int CallCount { get; private set; }

	public int MaxCallCount { get; set; }

	public uint MaxTotalCallCount { get; set; }

	public int TagId
	{
		get
		{
			return tagId;
		}
		set
		{
			if (tagId != value)
			{
				RemoveIdTagFromCollection();
				tagId = value;
				AddIdTagToCollection();
			}
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
			if (tag != value)
			{
				RemoveStringTagFromCollection();
				tag = value;
				AddStringTagToCollection();
			}
		}
	}

	public event InvokerEventHandler OnStopped;

	private static void ObseleteFunc()
	{
		throw new Exception("Invoker is obselete and no more supported");
	}

	private static Invoker StartInvoker(object obj, InvokerHandlerType handlerType, Delegate handler, InvokerType type, ulong value, ulong repeatValue, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		IntPtr ownerWorld = IntPtr.Zero;
		UObject uObject = obj as UObject;
		if (uObject != null)
		{
			ownerWorld = Native_UObject.GetWorld(uObject.Address);
		}
		Invoker invoker = (pool ? InvokerPool.GetObject() : new Invoker());
		invoker.OwnerWorld = ownerWorld;
		invoker.Owner = obj;
		invoker.SetHandler(handlerType, handler);
		switch (type)
		{
		case InvokerType.Delay:
		{
			TimeSpan timeSpan = TimeSpan.FromTicks((long)value);
			TimeSpan timeSpan2 = TimeSpan.FromTicks((long)repeatValue);
			if (timeSpan2 != default(TimeSpan))
			{
				invoker.SetTime(timeSpan, timeSpan2);
			}
			else
			{
				invoker.SetTime(timeSpan);
			}
			break;
		}
		case InvokerType.Ticks:
			if (repeatValue != 0L)
			{
				invoker.SetTicks(value, repeatValue);
			}
			else
			{
				invoker.SetTicks(value);
			}
			break;
		case InvokerType.Frames:
			if (repeatValue != 0L)
			{
				invoker.SetFrames(value, repeatValue);
			}
			else
			{
				invoker.SetFrames(value);
			}
			break;
		}
		invoker.SetGroup(group);
		invoker.Start();
		return invoker;
	}

	public static Invoker StartInvoker(object obj, InvokerHandler handler, TimeSpan time, TimeSpan repeatedTime = default(TimeSpan), CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.Default, handler, InvokerType.Delay, (ulong)time.Ticks, (ulong)repeatedTime.Ticks, group, pool);
	}

	public static Invoker StartInvoker(object obj, InvokerHandlerWithInvoker handler, TimeSpan time, TimeSpan repeatedTime = default(TimeSpan), CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.WithInvoker, handler, InvokerType.Delay, (ulong)time.Ticks, (ulong)repeatedTime.Ticks, group, pool);
	}

	public static Invoker StartInvoker(object obj, InvokerHandlerWithObject handler, TimeSpan time, TimeSpan repeatedTime = default(TimeSpan), CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.WithObject, handler, InvokerType.Delay, (ulong)time.Ticks, (ulong)repeatedTime.Ticks, group, pool);
	}

	public static Invoker StartInvoker(object obj, InvokerHandlerWithObjectInvoker handler, TimeSpan time, TimeSpan repeatedTime = default(TimeSpan), CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.WithObjectInvoker, handler, InvokerType.Delay, (ulong)time.Ticks, (ulong)repeatedTime.Ticks, group, pool);
	}

	public static Invoker StartInvokerTicks(object obj, InvokerHandler handler, ulong ticks, ulong repeatedTicks = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.Default, handler, InvokerType.Ticks, ticks, repeatedTicks, group, pool);
	}

	public static Invoker StartInvokerTicks(object obj, InvokerHandlerWithInvoker handler, ulong ticks, ulong repeatedTicks = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.WithInvoker, handler, InvokerType.Ticks, ticks, repeatedTicks, group, pool);
	}

	public static Invoker StartInvokerTicks(object obj, InvokerHandlerWithObject handler, ulong ticks, ulong repeatedTicks = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.WithObject, handler, InvokerType.Ticks, ticks, repeatedTicks, group, pool);
	}

	public static Invoker StartInvokerTicks(object obj, InvokerHandlerWithObjectInvoker handler, ulong ticks, ulong repeatedTicks = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.WithObjectInvoker, handler, InvokerType.Ticks, ticks, repeatedTicks, group, pool);
	}

	public static Invoker StartInvokerFrames(object obj, InvokerHandler handler, ulong frames, ulong repeatedFrames = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.Default, handler, InvokerType.Frames, frames, repeatedFrames, group, pool);
	}

	public static Invoker StartInvokerFrames(object obj, InvokerHandlerWithInvoker handler, ulong frames, ulong repeatedFrames = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.WithInvoker, handler, InvokerType.Frames, frames, repeatedFrames, group, pool);
	}

	public static Invoker StartInvokerFrames(object obj, InvokerHandlerWithObject handler, ulong frames, ulong repeatedFrames = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.WithObject, handler, InvokerType.Frames, frames, repeatedFrames, group, pool);
	}

	public static Invoker StartInvokerFrames(object obj, InvokerHandlerWithObjectInvoker handler, ulong frames, ulong repeatedFrames = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		ObseleteFunc();
		return StartInvoker(obj, InvokerHandlerType.WithObjectInvoker, handler, InvokerType.Frames, frames, repeatedFrames, group, pool);
	}

	public static void StopInvoker(Invoker invoker)
	{
		invoker.Stop();
	}

	public static void StopAllInvokers(UObject owner)
	{
		StopAllInvokers(owner, fullyRemove: false);
	}

	public static void StopAllInvokers(UObject owner, bool fullyRemove)
	{
		if ((object)owner != null && invokersByUObject.TryGetValue(owner, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				value[num].Stop();
			}
			if (fullyRemove)
			{
				invokersByUObject.Remove(owner);
			}
		}
	}

	public static void StopInvokerByMethod(UObject owner, Delegate method)
	{
		if (!(method.Method != null) || !invokersByMethod.TryGetValue(method.Method, out var value))
		{
			return;
		}
		for (int num = value.Count; num >= 0; num--)
		{
			Invoker invoker = value[num];
			if (invoker.Owner as UObject == owner)
			{
				invoker.Stop();
			}
		}
	}

	public static void StopInvokerByMethod(Delegate method)
	{
		if (method.Method != null && invokersByMethod.TryGetValue(method.Method, out var value))
		{
			for (int num = value.Count; num >= 0; num--)
			{
				value[num].Stop();
			}
		}
	}

	public static List<Invoker> FindInvokers(UObject owner)
	{
		List<Invoker> list = new List<Invoker>();
		if (owner != null && invokersByUObject.TryGetValue(owner, out var value))
		{
			list.AddRange(value);
		}
		return list;
	}

	public static List<Invoker> FindInvokers(UObject owner, string tag)
	{
		List<Invoker> list = new List<Invoker>();
		if (invokersByTag.TryGetValue(tag, out var value))
		{
			foreach (Invoker item in value)
			{
				if (owner == item.Owner as UObject)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	public static List<Invoker> FindInvokers(UObject owner, int tagId)
	{
		List<Invoker> list = new List<Invoker>();
		if (invokersByTagId.TryGetValue(tagId, out var value))
		{
			foreach (Invoker item in value)
			{
				if (owner == item.Owner as UObject)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	internal void SetHandler(InvokerHandlerType handlerType, Delegate handler)
	{
		switch (handlerType)
		{
		case InvokerHandlerType.Default:
			SetHandler((InvokerHandler)handler);
			break;
		case InvokerHandlerType.WithInvoker:
			SetHandler((InvokerHandlerWithInvoker)handler);
			break;
		case InvokerHandlerType.WithObject:
			SetHandler((InvokerHandlerWithObject)handler);
			break;
		case InvokerHandlerType.WithObjectInvoker:
			SetHandler((InvokerHandlerWithObjectInvoker)handler);
			break;
		}
	}

	public void SetHandler(InvokerHandler handler)
	{
		SetHandler(InvokerHandlerType.Default, handler, null, null, null);
	}

	public void SetHandler(InvokerHandlerWithInvoker handler)
	{
		SetHandler(InvokerHandlerType.WithInvoker, null, handler, null, null);
	}

	public void SetHandler(InvokerHandlerWithObject handler)
	{
		SetHandler(InvokerHandlerType.WithObject, null, null, handler, null);
	}

	public void SetHandler(InvokerHandlerWithObjectInvoker handler)
	{
		SetHandler(InvokerHandlerType.WithInvoker, null, null, null, handler);
	}

	private void SetHandler(InvokerHandlerType handlerType, InvokerHandler handler, InvokerHandlerWithInvoker handlerWithInvoker, InvokerHandlerWithObject handlerWithObject, InvokerHandlerWithObjectInvoker handlerWithObjectInvoker)
	{
		RemoveInvokerFromInvokersByMethod();
		this.handlerType = handlerType;
		this.handler = handler;
		this.handlerWithInvoker = handlerWithInvoker;
		this.handlerWithObject = handlerWithObject;
		this.handlerWithObjectInvoker = handlerWithObjectInvoker;
		AddInvokerToInvokersByMethod();
	}

	private Delegate GetHandler()
	{
		return handlerType switch
		{
			InvokerHandlerType.Default => handler, 
			InvokerHandlerType.WithInvoker => handlerWithInvoker, 
			InvokerHandlerType.WithObject => handlerWithObject, 
			InvokerHandlerType.WithObjectInvoker => handlerWithObjectInvoker, 
			_ => null, 
		};
	}

	public Invoker SetTime(TimeSpan value)
	{
		InvokerType type = Type;
		Type = InvokerType.Delay;
		Value = (ulong)value.Ticks;
		UpdateValues(type != Type);
		return this;
	}

	public Invoker SetTime(TimeSpan value, TimeSpan repeatedValue)
	{
		InvokerType type = Type;
		Type = InvokerType.Delay;
		Value = (ulong)value.Ticks;
		RepeatedValue = (ulong)repeatedValue.Ticks;
		IsRepeated = true;
		UpdateValues(type != Type);
		return this;
	}

	public Invoker SetFrames(ulong value)
	{
		InvokerType type = Type;
		Type = InvokerType.Frames;
		Value = value;
		UpdateValues(type != Type);
		return this;
	}

	public Invoker SetFrames(ulong value, ulong repeatedValue)
	{
		InvokerType type = Type;
		Type = InvokerType.Frames;
		Value = value;
		RepeatedValue = repeatedValue;
		IsRepeated = true;
		UpdateValues(type != Type);
		return this;
	}

	public Invoker SetTicks(ulong value)
	{
		InvokerType type = Type;
		Type = InvokerType.Ticks;
		Value = value;
		UpdateValues(Type != type);
		return this;
	}

	public Invoker SetTicks(ulong value, ulong repeatedValue)
	{
		InvokerType type = Type;
		Type = InvokerType.Ticks;
		Value = value;
		RepeatedValue = repeatedValue;
		IsRepeated = true;
		UpdateValues(type != Type);
		return this;
	}

	public Invoker ClearRepeatedValue()
	{
		IsRepeated = false;
		RepeatedValue = 0uL;
		UpdateValues(setStartValue: false);
		return this;
	}

	public Invoker SetGroup(CoroutineGroup group)
	{
		Group = group;
		UpdateValues(setStartValue: false);
		return this;
	}

	public TimeSpan GetTime()
	{
		return TimeSpan.FromTicks((long)Value);
	}

	public TimeSpan GetRepeatedTime()
	{
		return TimeSpan.FromTicks((long)RepeatedValue);
	}

	public ulong GetTicks()
	{
		return Value;
	}

	public ulong GetRepeatedTicks()
	{
		return RepeatedValue;
	}

	public ulong GetFrames()
	{
		return Value;
	}

	public ulong GetRepeatedFrames()
	{
		return Value;
	}

	public Invoker SetStopAfterTime(TimeSpan time)
	{
		return SetStopAfterValue((ulong)time.Ticks);
	}

	public Invoker SetStopAfterTicks(ulong ticks)
	{
		return SetStopAfterValue(ticks);
	}

	public Invoker SetStopAfterFrames(ulong frames)
	{
		return SetStopAfterValue(frames);
	}

	private Invoker SetStopAfterValue(ulong value)
	{
		stopAfterValue = value;
		stopAfterEndValue = startingValue + stopAfterValue;
		HasStopAfterValue = true;
		return this;
	}

	public TimeSpan GetStopAfterTime()
	{
		return TimeSpan.FromTicks((long)stopAfterValue);
	}

	public ulong GetStopAfterTicks()
	{
		return Value;
	}

	public ulong GetStopAfterFrames()
	{
		return Value;
	}

	public void ClearStopAfterValue()
	{
		HasStopAfterValue = false;
		stopAfterValue = 0uL;
	}

	public int CompareTo(Invoker other)
	{
		if (Type != other.Type)
		{
			throw new InvalidOperationException("Unexpected comparison of two invokers with different invoker types");
		}
		return EndValue.CompareTo(other.EndValue);
	}

	private void UpdateValues(bool setStartValue)
	{
		if (!Running)
		{
			return;
		}
		if (setStartValue)
		{
			switch (Type)
			{
			case InvokerType.Delay:
				BeginValue = (startingValue = (ulong)WorldTimeHelper.GetTimeChecked(OwnerWorld).Ticks);
				break;
			case InvokerType.Ticks:
				BeginValue = (startingValue = EngineLoop.WorldTickCounter);
				break;
			case InvokerType.Frames:
				BeginValue = (startingValue = EngineLoop.WorldFrameNumber);
				break;
			}
		}
		InvokerCollectionGroup invokerGroup = GetInvokerGroup(Group);
		UnrealBinaryHeapEx<Invoker> unrealBinaryHeapEx = invokerGroup?.GetCollection(Type);
		if (collectionGroup != null && collection != null && (collectionGroup.Group != Group || unrealBinaryHeapEx != collection))
		{
			collection.HeapRemove(this);
			collection = null;
			collectionGroup = null;
		}
		if (unrealBinaryHeapEx != null)
		{
			collectionGroup = invokerGroup;
			collection = unrealBinaryHeapEx;
			unrealBinaryHeapEx.HeapPush(this);
		}
	}

	public void Start()
	{
		if (!Running)
		{
			IsFirstRun = true;
			Running = true;
			UpdateValues(setStartValue: true);
			UpdateTags();
			AddInvokerToInvokersByUObject();
			AddInvokerToInvokersByMethod();
		}
	}

	public void Stop()
	{
		if (Running)
		{
			if (collection != null)
			{
				collection.HeapRemove(this);
				collection = null;
				collectionGroup = null;
			}
			IsFirstRun = false;
			Running = false;
			UpdateTags();
			RemoveInvokerFromInvokersByUObject();
			RemoveInvokerFromInvokersByMethod();
			if (this.OnStopped != null)
			{
				this.OnStopped(this);
			}
			if (IsPooled)
			{
				InvokerPool.ReturnObject(this);
			}
		}
	}

	internal void Reset()
	{
		this.OnStopped = null;
		Running = false;
		IsFirstRun = false;
		Tag = null;
		TagId = 0;
		OwnerWorld = IntPtr.Zero;
		Owner = null;
		IsRepeated = false;
		Type = InvokerType.Delay;
		Group = CoroutineGroup.Tick;
		Value = 0uL;
		RepeatedValue = 0uL;
		HasStopAfterValue = false;
		stopAfterValue = 0uL;
		stopAfterEndValue = 0uL;
		startingValue = 0uL;
		beginValue = 0uL;
		EndValue = 0uL;
		RepeatConstantTime = false;
		MaxCallCount = 0;
		MaxTotalCallCount = 0u;
		totalCallCount = 0uL;
		cancelInvoke = false;
		if (collection != null)
		{
			collection.HeapRemove(this);
			collection = null;
		}
		collectionGroup = null;
		handlerType = InvokerHandlerType.Default;
		handler = null;
		handlerWithObject = null;
		handlerWithInvoker = null;
		handlerWithObjectInvoker = null;
		invokersByUObjectIndex = -1;
		invokersByMethodIndex = -1;
	}

	public void CancelInvoke()
	{
		cancelInvoke = true;
	}

	public bool Invoke()
	{
		if (!Running || (MaxTotalCallCount != 0 && totalCallCount >= MaxTotalCallCount))
		{
			return false;
		}
		Invoke();
		return true;
	}

	private bool InvokeInternal()
	{
		switch (handlerType)
		{
		case InvokerHandlerType.Default:
			handler();
			break;
		case InvokerHandlerType.WithInvoker:
			handlerWithInvoker(this);
			break;
		case InvokerHandlerType.WithObject:
			handlerWithObject(Owner);
			break;
		case InvokerHandlerType.WithObjectInvoker:
			handlerWithObjectInvoker(Owner, this);
			break;
		}
		IsFirstRun = false;
		totalCallCount++;
		if (cancelInvoke || (MaxTotalCallCount != 0 && totalCallCount >= MaxTotalCallCount))
		{
			Stop();
			return false;
		}
		return true;
	}

	internal void Process(ulong value)
	{
		cancelInvoke = false;
		int num = 0;
		if (IsRepeated)
		{
			num = (int)((value - EndValue) / RepeatedValue);
		}
		CallCount = num + 1;
		int num2 = num;
		if (MaxCallCount > 0)
		{
			num2 = Math.Min(MaxCallCount - 1, num2);
		}
		ulong currentTargetValue = CurrentTargetValue;
		if (!InvokeInternal() || (HasStopAfterValue && HasStopAfterValueCompleted(currentTargetValue, 0u)))
		{
			return;
		}
		uint num3;
		for (num3 = 0u; num3 < num2; num3++)
		{
			if (cancelInvoke)
			{
				break;
			}
			if (!Running)
			{
				break;
			}
			if (!InvokeInternal() || (HasStopAfterValue && HasStopAfterValueCompleted(currentTargetValue, num3 + 1)))
			{
				return;
			}
		}
		if (IsRepeated)
		{
			if (RepeatConstantTime && Type == InvokerType.Delay)
			{
				ulong ticks = (ulong)WorldTimeHelper.GetTimeChecked(OwnerWorld).Ticks;
				BeginValue = value + (ticks - EndValue);
			}
			else
			{
				BeginValue += currentTargetValue + num3 * RepeatedValue;
			}
			collection.HeapPush(this);
		}
		else
		{
			collection = null;
			collectionGroup = null;
			Stop();
		}
	}

	private bool HasStopAfterValueCompleted(ulong oldTargetValue, uint callIndex)
	{
		_ = BeginValue;
		_ = RepeatedValue;
		ulong num = BeginValue + CurrentTargetValue;
		return stopAfterEndValue <= num;
	}

	internal static void ProcessInvokers(CoroutineGroup group)
	{
		GetInvokerGroup(group).Process();
	}

	private static InvokerCollectionGroup GetInvokerGroup(CoroutineGroup group)
	{
		return group switch
		{
			CoroutineGroup.Tick => tickInvokers, 
			CoroutineGroup.BeginFrame => beginFrameInvokers, 
			CoroutineGroup.EndFrame => endFrameInvokers, 
			_ => null, 
		};
	}

	private void AddInvokerToInvokersByUObject()
	{
		UObject uObject = Owner as UObject;
		if (uObject != null)
		{
			if (!invokersByUObject.TryGetValue(uObject, out var value))
			{
				invokersByUObject.Add(uObject, value = new List<Invoker>());
			}
			invokersByUObjectIndex = value.Count;
			value.Add(this);
		}
	}

	private void RemoveInvokerFromInvokersByUObject()
	{
		if (invokersByUObjectIndex < 0)
		{
			return;
		}
		UObject uObject = Owner as UObject;
		if (uObject != null && invokersByUObject.TryGetValue(uObject, out var value) && value.Count > 0)
		{
			Invoker invoker = value[value.Count - 1];
			value.RemoveAtSwapEx(ref invokersByUObjectIndex, ref invoker.invokersByUObjectIndex);
			if (value.Count == 0)
			{
				invokersByUObject.Remove(uObject);
			}
		}
		invokersByUObjectIndex = -1;
	}

	private void AddInvokerToInvokersByMethod()
	{
		Delegate obj = GetHandler();
		if (Running && (object)obj != null && obj.Method != null)
		{
			if (!invokersByMethod.TryGetValue(obj.Method, out var value))
			{
				invokersByMethod.Add(obj.Method, value = new List<Invoker>());
			}
			invokersByMethodIndex = value.Count;
			value.Add(this);
		}
	}

	private void RemoveInvokerFromInvokersByMethod()
	{
		if (invokersByMethodIndex >= 0)
		{
			Delegate obj = GetHandler();
			if ((object)obj != null && obj.Method != null && invokersByMethod.TryGetValue(obj.Method, out var value) && value.Count > 0)
			{
				Invoker invoker = value[value.Count - 1];
				value.RemoveAtSwapEx(ref invokersByMethodIndex, ref invoker.invokersByMethodIndex);
			}
			invokersByMethodIndex = -1;
		}
	}

	private void AddIdTagToCollection()
	{
		if (Running && tagId != 0 && tagIdIndex < 0)
		{
			if (!invokersByTagId.TryGetValue(tagId, out var value))
			{
				invokersByTagId.Add(tagId, value = new List<Invoker>());
			}
			tagIdIndex = value.Count;
			value.Add(this);
		}
	}

	private void RemoveIdTagFromCollection()
	{
		if (tagIdIndex >= 0 && invokersByTagId.TryGetValue(tagId, out var value))
		{
			Invoker invoker = value[value.Count - 1];
			value.RemoveAtSwapEx(ref tagIdIndex, ref invoker.tagIdIndex);
		}
	}

	private void AddStringTagToCollection()
	{
		if (Running && tag != null && tagIdIndex < 0)
		{
			if (!invokersByTag.TryGetValue(tag, out var value))
			{
				invokersByTag.Add(tag, value = new List<Invoker>());
			}
			tagIndex = value.Count;
			value.Add(this);
		}
	}

	private void RemoveStringTagFromCollection()
	{
		if (tagIndex >= 0 && invokersByTag.TryGetValue(tag, out var value))
		{
			Invoker invoker = value[value.Count - 1];
			value.RemoveAtSwapEx(ref tagIndex, ref invoker.tagIndex);
		}
	}

	private void UpdateTags()
	{
		if (Running)
		{
			AddIdTagToCollection();
			AddStringTagToCollection();
		}
		else
		{
			RemoveIdTagFromCollection();
			RemoveStringTagFromCollection();
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
			List<UObject> list = new List<UObject>();
			foreach (KeyValuePair<UObject, List<Invoker>> item in invokersByUObject)
			{
				if (item.Key.Address != IntPtr.Zero)
				{
					if (Native_UObject.GetWorld(item.Key.Address) == world)
					{
						list.Add(item.Key);
					}
				}
				else
				{
					list.Add(item.Key);
				}
			}
			foreach (UObject item2 in list)
			{
				StopAllInvokers(item2, fullyRemove: true);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	internal static void RemoveObjectByGC(UObject owner)
	{
		StopAllInvokers(owner, fullyRemove: true);
	}
}
