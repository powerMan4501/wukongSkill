using System;
using System.Collections;
using System.Collections.Generic;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UMetaPath("/Script/CoreUObject.Object", "CoreUObject", UnrealModuleType.Engine)]
public class UObject : IEquatable<UObject>, IInterface
{
	private Dictionary<Type, IInterface> injectedInterfaces;

	internal uint objRefId;

	internal UObjectRef objRef;

	private CachedUObject<UClass> cachedClass;

	private CachedUObject<UObject> cachedOuter;

	private CachedUObject<UPackage> cachedOutermost;

	public static Exception EventDef => new EventNotRewrittenException();

	public IntPtr Address { get; internal set; }

	public bool IsDestroyed => objRef == null;

	public bool IsKnownType => objRef.IsKnownType;

	public bool IsPendingKill
	{
		get
		{
			return Native_UObjectBaseUtility.IsPendingKill(Address);
		}
		set
		{
			if (value)
			{
				Native_UObjectBaseUtility.MarkPendingKill(Address);
			}
			else
			{
				Native_UObjectBaseUtility.ClearPendingKill(Address);
			}
		}
	}

	public string PathName => GetPathName();

	public bool IsRooted
	{
		get
		{
			return Native_UObjectBaseUtility.IsRooted(Address);
		}
		set
		{
			if (value)
			{
				Native_UObjectBaseUtility.AddToRoot(Address);
			}
			else
			{
				Native_UObjectBaseUtility.RemoveFromRoot(Address);
			}
		}
	}

	public bool IsNative => Native_UObjectBaseUtility.IsNative(Address);

	public static ObjectOuter AnyPackage => ObjectOuter.AnyPackage;

	public IntPtr GetAddress()
	{
		return Address;
	}

	public UObject GetObject()
	{
		return this;
	}

	public bool IsValidLowLevel()
	{
		return Native_UObjectBase.IsValidLowLevel(Address);
	}

	public bool IsValidLowLevelFast(bool recursive = true)
	{
		return Native_UObjectBase.IsValidLowLevelFast(Address, recursive);
	}

	public string GetName()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UObjectBaseUtility.GetName(Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public FName GetFName()
	{
		Native_UObjectBase.GetFName(Address, out var result);
		return result;
	}

	public TStatId GetStatId()
	{
		Native_UObjectBase.GetStatID(Address, out var result);
		return result;
	}

	public string GetFullGroupName(bool startWithOuter)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UObjectBaseUtility.GetFullGroupName(Address, startWithOuter, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public string GetFullName(UObject stopOuter = null)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UObjectBaseUtility.GetFullName(Address, (stopOuter == null) ? IntPtr.Zero : stopOuter.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public string GetPathName(UObject stopOuter = null)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_UObjectBaseUtility.GetPathName(Address, (stopOuter == null) ? IntPtr.Zero : stopOuter.Address, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public uint GetUniqueID()
	{
		return Native_UObjectBase.GetUniqueID(Address);
	}

	public UClass GetClass()
	{
		return cachedClass.Update(Native_UObjectBase.GetClass(Address));
	}

	public UObject GetOuter()
	{
		return cachedOuter.Update(Native_UObjectBase.GetOuter(Address));
	}

	public EObjectFlags GetFlags()
	{
		return Native_UObjectBase.GetFlags(Address);
	}

	public void SetFlags(EObjectFlags newFlags)
	{
		Native_UObjectBaseUtility.SetFlags(Address, newFlags);
	}

	public void ClearFlags(EObjectFlags newFlags)
	{
		Native_UObjectBaseUtility.ClearFlags(Address, newFlags);
	}

	public bool HasAnyFlags(EObjectFlags flagsToCheck)
	{
		return Native_UObjectBaseUtility.HasAnyFlags(Address, flagsToCheck);
	}

	public bool HasAllFlags(EObjectFlags flagsToCheck)
	{
		return Native_UObjectBaseUtility.HasAllFlags(Address, flagsToCheck);
	}

	public void AtomicallySetFlags(EObjectFlags flagsToAdd)
	{
		Native_UObjectBase.AtomicallySetFlags(Address, flagsToAdd);
	}

	public void AtomicallyClearFlags(EObjectFlags flagsToClear)
	{
		Native_UObjectBase.AtomicallyClearFlags(Address, flagsToClear);
	}

	public EObjectFlags GetMaskedFlags(EObjectFlags mask)
	{
		return Native_UObjectBaseUtility.GetMaskedFlags(Address, mask);
	}

	public void Mark(EObjectMark marks)
	{
		Native_UObjectBaseUtility.Mark(Address, marks);
	}

	public void UnMark(EObjectMark marks)
	{
		Native_UObjectBaseUtility.UnMark(Address, marks);
	}

	public bool HasAnyMarks(EObjectMark marks)
	{
		return Native_UObjectBaseUtility.HasAnyMarks(Address, marks);
	}

	public bool HasAllMarks(EObjectMark marks)
	{
		return Native_UObjectBaseUtility.HasAnyMarks(Address, marks);
	}

	public void MarkPendingKill()
	{
		Native_UObjectBaseUtility.MarkPendingKill(Address);
	}

	public void ClearPendingKill()
	{
		Native_UObjectBaseUtility.ClearPendingKill(Address);
	}

	public void AddToRoot()
	{
		Native_UObjectBaseUtility.AddToRoot(Address);
	}

	public void RemoveFromRoot()
	{
		Native_UObjectBaseUtility.RemoveFromRoot(Address);
	}

	public void SetInternalFlags(EInternalObjectFlags flagsToSet)
	{
		Native_UObjectBaseUtility.SetInternalFlags(Address, flagsToSet);
	}

	public EInternalObjectFlags GetInternalFlags()
	{
		return Native_UObjectBaseUtility.GetInternalFlags(Address);
	}

	public bool HasAnyInternalFlags(EInternalObjectFlags flagsToCheck)
	{
		return Native_UObjectBaseUtility.HasAnyInternalFlags(Address, flagsToCheck);
	}

	public UPackage GetOutermost()
	{
		return cachedOutermost.Update(Native_UObjectBaseUtility.GetOutermost(Address));
	}

	public bool MarkPackageDirty()
	{
		return Native_UObjectBaseUtility.MarkPackageDirty(Address);
	}

	public bool IsTemplate(EObjectFlags templateTypes = EObjectFlags.ClassDefaultObject | EObjectFlags.ArchetypeObject)
	{
		return Native_UObjectBaseUtility.IsTemplate(Address, templateTypes);
	}

	public UObject GetTypedOuter(UClass target)
	{
		return GCHelper.Find<UObject>(Native_UObjectBaseUtility.GetTypedOuter(Address, (target == null) ? IntPtr.Zero : target.Address));
	}

	public UObject GetTypedOuter<T>() where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		if (uClass != null)
		{
			return GetTypedOuter(uClass);
		}
		return null;
	}

	public bool IsIn(UObject someOuter)
	{
		return Native_UObjectBaseUtility.IsIn(Address, (someOuter == null) ? IntPtr.Zero : someOuter.Address);
	}

	public bool IsInA(UClass someBaseClass)
	{
		return Native_UObjectBaseUtility.IsInA(Address, (someBaseClass == null) ? IntPtr.Zero : someBaseClass.Address);
	}

	public bool RootPackageHasAnyFlags(EPackageFlags checkFlagMask)
	{
		return Native_UObjectBaseUtility.RootPackageHasAnyFlags(Address, checkFlagMask);
	}

	public bool IsA<T>() where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		if (uClass == null)
		{
			return false;
		}
		return Native_UObjectBaseUtility.IsA(Address, uClass.Address);
	}

	public bool IsA(UClass someBaseClass)
	{
		return Native_UObjectBaseUtility.IsA(Address, (someBaseClass == null) ? IntPtr.Zero : someBaseClass.Address);
	}

	public bool IsA(Type type)
	{
		UClass uClass = UClass.GetClass(type);
		if (uClass == null)
		{
			return false;
		}
		return Native_UObjectBaseUtility.IsA(Address, uClass.Address);
	}

	public bool TryCast<T>(out UObject obj) where T : UObject
	{
		T val = this as T;
		if (val != null)
		{
			obj = val;
			return true;
		}
		if (IsA<T>())
		{
			obj = this;
			return true;
		}
		obj = null;
		return false;
	}

	public UObject TryCast<T>(out bool knownType) where T : UObject
	{
		T val = this as T;
		if (val != null)
		{
			knownType = true;
			return val;
		}
		if (IsA<T>())
		{
			knownType = false;
			return this;
		}
		knownType = false;
		return null;
	}

	public UObject TryCast<T>() where T : UObject
	{
		TryCast<T>(out UObject obj);
		return obj;
	}

	public T Cast<T>() where T : UObject
	{
		return this as T;
	}

	public UClass FindNearestCommonBaseClass(UClass testClass)
	{
		return GCHelper.Find<UClass>(Native_UObjectBaseUtility.FindNearestCommonBaseClass(Address, (testClass == null) ? IntPtr.Zero : testClass.Address));
	}

	public IntPtr GetInterfaceAddress(UClass interfaceClass)
	{
		return Native_UObjectBaseUtility.GetInterfaceAddress(Address, (interfaceClass == null) ? IntPtr.Zero : interfaceClass.Address);
	}

	public IntPtr GetNativeInterfaceAddress(UClass interfaceClass)
	{
		return Native_UObjectBaseUtility.GetNativeInterfaceAddress(Address, (interfaceClass == null) ? IntPtr.Zero : interfaceClass.Address);
	}

	public bool IsDefaultSubobject()
	{
		return Native_UObjectBaseUtility.IsDefaultSubobject(Address);
	}

	public virtual void GetLifetimeReplicatedProps(FLifetimePropertyCollection lifetimeProps)
	{
	}

	internal virtual void SetupPlayerInputComponent(IntPtr playerInputComponent)
	{
	}

	internal virtual void BeginPlayInternal()
	{
	}

	internal virtual void EndPlayInternal(byte endPlayReason)
	{
	}

	public UFunction FindFunction(FName name)
	{
		return GCHelper.Find<UFunction>(Native_UObject.FindFunction(Address, ref name));
	}

	public UFunction FindFunctionChecked(FName name)
	{
		return GCHelper.Find<UFunction>(Native_UObject.FindFunctionChecked(Address, ref name));
	}

	public static TObjectIterator<T> GetObjects<T>(EObjectFlags additionalExclusionFlags = EObjectFlags.ClassDefaultObject, bool includeDerivedClasses = true, EInternalObjectFlags internalExclusionFlags = EInternalObjectFlags.None) where T : UObject
	{
		return new TObjectIterator<T>(additionalExclusionFlags, includeDerivedClasses, internalExclusionFlags);
	}

	public static FObjectIterator GetObjectsEx<T>(bool onlyGCedObjects = false, EObjectFlags additionalExclusionFlags = EObjectFlags.NoFlags, EInternalObjectFlags internalExclusionFlags = EInternalObjectFlags.None) where T : UObject
	{
		return GetObjectsEx(UClass.GetClass<T>(), onlyGCedObjects, additionalExclusionFlags, internalExclusionFlags);
	}

	public static FObjectIterator GetObjectsEx(UClass unrealClass, bool onlyGCedObjects = false, EObjectFlags additionalExclusionFlags = EObjectFlags.NoFlags, EInternalObjectFlags internalExclusionFlags = EInternalObjectFlags.None)
	{
		return new FObjectIterator(unrealClass, onlyGCedObjects, additionalExclusionFlags, internalExclusionFlags);
	}

	public static FObjectIterator GetObjectsEx(bool onlyGCedObjects = false, EObjectFlags additionalExclusionFlags = EObjectFlags.NoFlags, EInternalObjectFlags internalExclusionFlags = EInternalObjectFlags.None)
	{
		return new FObjectIterator(null, onlyGCedObjects, additionalExclusionFlags, internalExclusionFlags);
	}

	public bool CallFunctionByNameWithArguments(string cmd, bool forceCallWithNonExec = false)
	{
		return CallFunctionByNameWithArguments(cmd, this, forceCallWithNonExec);
	}

	public bool CallFunctionByNameWithArguments(string cmd, UObject executor, bool forceCallWithNonExec = false)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(cmd);
		return Native_UObject.CallFunctionByNameWithArguments(Address, ref fStringUnsafe.Array, IntPtr.Zero, executor.Address, forceCallWithNonExec);
	}

	public static string GetNameSafe(UObject obj)
	{
		if (obj == null)
		{
			return "None";
		}
		return obj.GetName();
	}

	public static string GetPathNameSafe(UObject obj)
	{
		if (obj == null)
		{
			return "None";
		}
		return obj.GetPathName();
	}

	public static string GetFullNameSafe(UObject obj)
	{
		if (obj == null || Native_UObjectBase.GetClass(obj.Address) == IntPtr.Zero)
		{
			return "None";
		}
		return obj.GetFullName();
	}

	public static object DynamicInvokeStatic<T>(string functionName, object[] parameters) where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		if (uClass != null)
		{
			return DynamicInvokeStatic(uClass, functionName, parameters);
		}
		return null;
	}

	public static object DynamicInvokeStatic(UClass unrealClass, string functionName, params object[] parameters)
	{
		return DynamicInvokeInternal(unrealClass, unrealClass.ClassDefaultObject, functionName, parameters);
	}

	public static object DynamicInvoke(UObject obj, string functionName, params object[] parameters)
	{
		return DynamicInvokeInternal(obj.GetClass(), obj, functionName, parameters);
	}

	private unsafe static object DynamicInvokeInternal(UClass unrealClass, UObject obj, string functionName, params object[] parameters)
	{
		UFunction uFunction = obj.GetClass().FindFunctionByName(new FName(functionName));
		if (uFunction == null)
		{
			return null;
		}
		if (parameters == null)
		{
			parameters = new object[0];
		}
		bool flag = true;
		Dictionary<FProperty, Delegate> dictionary = new Dictionary<FProperty, Delegate>();
		Dictionary<FProperty, Delegate> dictionary2 = new Dictionary<FProperty, Delegate>();
		FProperty fProperty = null;
		List<FProperty> list = new List<FProperty>();
		foreach (FProperty fField in uFunction.GetFFields<FProperty>())
		{
			if (fField.HasAnyPropertyFlags(EPropertyFlags.Parm))
			{
				if (fField.HasAnyPropertyFlags(EPropertyFlags.ReturnParm))
				{
					fProperty = fField;
				}
				else
				{
					list.Add(fField);
				}
				Type typeFromProperty = FProperty.GetTypeFromProperty(fField.Address);
				if (typeFromProperty == null)
				{
					flag = false;
					break;
				}
				Delegate fromNative = MarshalingDelegateResolverSlow.GetFromNative(typeFromProperty);
				Delegate toNative = MarshalingDelegateResolverSlow.GetToNative(typeFromProperty);
				if ((object)fromNative == null || (object)toNative == null)
				{
					flag = false;
					break;
				}
				dictionary.Add(fField, fromNative);
				dictionary2.Add(fField, toNative);
			}
		}
		if (parameters.Length != list.Count)
		{
			flag = false;
		}
		if (!flag)
		{
			return null;
		}
		list.Sort((FProperty x, FProperty y) => x.GetOffset_ForUFunction().CompareTo(y.GetOffset_ForUFunction()));
		object result = null;
		int parmsSize = uFunction.ParmsSize;
		byte* value = stackalloc byte[(int)uFunction.ParmsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, parmsSize);
		foreach (FProperty fField2 in uFunction.GetFFields<FProperty>())
		{
			if (fField2.HasAnyPropertyFlags(EPropertyFlags.Parm))
			{
				Native_FProperty.InitializeValue_InContainer(fField2.Address, intPtr);
			}
		}
		for (int num = 0; num < parameters.Length; num++)
		{
			FProperty fProperty4 = list[num];
			object obj2 = parameters[num];
			if (obj2 != null && (!fProperty4.HasAnyPropertyFlags(EPropertyFlags.OutParm) || fProperty4.HasAnyPropertyFlags(EPropertyFlags.ReferenceParm)))
			{
				dictionary2[fProperty4].DynamicInvoke(intPtr + fProperty4.GetOffset_ForUFunction(), 0, fProperty4.Address, obj2);
			}
		}
		NativeReflection.InvokeFunction(obj.Address, uFunction.Address, intPtr, parmsSize);
		for (int num2 = 0; num2 < parameters.Length; num2++)
		{
			FProperty fProperty5 = list[num2];
			if (fProperty5.HasAnyPropertyFlags(EPropertyFlags.OutParm))
			{
				parameters[num2] = dictionary[fProperty5].DynamicInvoke(intPtr + fProperty5.GetOffset_ForUFunction(), 0, fProperty5.Address);
			}
		}
		if (fProperty != null)
		{
			result = dictionary[fProperty].DynamicInvoke(intPtr + fProperty.GetOffset_ForUFunction(), 0, fProperty.Address);
		}
		foreach (FProperty fField3 in uFunction.GetFFields<FProperty>())
		{
			if (fField3.HasAnyPropertyFlags(EPropertyFlags.Parm))
			{
				Native_FProperty.DestroyValue_InContainer(fField3.Address, intPtr);
			}
		}
		return result;
	}

	public virtual void Initialize()
	{
	}

	public virtual void Initialize(FObjectInitializer initializer)
	{
	}

	public void CheckDestroyed()
	{
		if ((object)this == null || IsDestroyed)
		{
			throw new Exception("Attempting to access a destroyed unreal object of type " + GetType().ToString());
		}
	}

	public virtual void OnAssemblyUnload()
	{
	}

	public virtual void OnAssemblyReload()
	{
	}

	protected virtual void OnNativeTypeChanged()
	{
	}

	internal void ReleaseInjectedInterfaces()
	{
		if (injectedInterfaces == null)
		{
			return;
		}
		foreach (IInterface value in injectedInterfaces.Values)
		{
			UnrealInterfacePool.ReturnObject(value);
		}
		injectedInterfaces = null;
	}

	public unsafe T GetInterface<T>() where T : class, IInterface
	{
		T val = this as T;
		if (val != null)
		{
			return val;
		}
		if (injectedInterfaces == null)
		{
			if (objRef == null)
			{
				return null;
			}
			UClass uClass = GetClass();
			if (uClass as USharpClass != null)
			{
				return null;
			}
			FScriptArray* ptr = (FScriptArray*)(void*)Native_UClass.Get_InterfacesRef(uClass.Address);
			if (ptr->ArrayNum != 0)
			{
				injectedInterfaces = new Dictionary<Type, IInterface>();
				FImplementedInterface[] interfaces = uClass.Interfaces;
				for (int i = 0; i < interfaces.Length; i++)
				{
					FImplementedInterface fImplementedInterface = interfaces[i];
					if (!(fImplementedInterface.InterfaceClassAddress != IntPtr.Zero))
					{
						continue;
					}
					Type typeFromClassAddress = UClass.GetTypeFromClassAddress(fImplementedInterface.InterfaceClassAddress);
					if (!(typeFromClassAddress != null))
					{
						continue;
					}
					IInterface obj = UnrealInterfacePool.New(typeFromClassAddress, objRef);
					if (obj != null)
					{
						injectedInterfaces[typeFromClassAddress] = obj;
						if (typeFromClassAddress == typeof(T))
						{
							val = obj as T;
						}
					}
				}
			}
		}
		else
		{
			injectedInterfaces.TryGetValue(typeof(T), out var value);
			val = value as T;
		}
		return val;
	}

	public bool DoesImplementInterface<T>() where T : IInterface
	{
		IntPtr interfaceClassAddress = UClass.GetInterfaceClassAddress<T>();
		if (interfaceClassAddress != IntPtr.Zero && Native_UClass.GetClassFlags(interfaceClassAddress).HasFlag(EClassFlags.Interface))
		{
			return Native_UClass.ImplementsInterface(Native_UObjectBase.GetClass(Address), interfaceClassAddress);
		}
		return false;
	}

	public bool DoesImplementInterface(Type type)
	{
		UClass uClass = UClass.GetClass(type);
		if (uClass != null && uClass.ClassFlags.HasFlag(EClassFlags.Interface))
		{
			return Native_UClass.ImplementsInterface(Native_UObjectBase.GetClass(Address), uClass.Address);
		}
		return false;
	}

	public Coroutine StartCoroutine(object obj, IEnumerator coroutine, bool pool = true)
	{
		return Coroutine.StartCoroutine(this, coroutine, pool);
	}

	public Coroutine StartCoroutine(IEnumerator coroutine, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		return Coroutine.StartCoroutine(this, coroutine, group, pool);
	}

	public Coroutine StartCoroutine(IEnumerator coroutine, CoroutineGroup group = CoroutineGroup.Tick, string tag = null, bool pool = true)
	{
		return Coroutine.StartCoroutine(this, coroutine, group, tag, pool);
	}

	public void StopCoroutine(Coroutine coroutine)
	{
		Coroutine.StopCoroutine(coroutine);
	}

	public void StopCoroutine(IEnumerator coroutine)
	{
		Coroutine.StopCoroutine(this, coroutine);
	}

	public void StopAllCoroutines()
	{
		Coroutine.StopAllCoroutines(this);
	}

	public void StopCoroutines(string tag)
	{
		Coroutine.StopCoroutines(tag);
	}

	public List<Coroutine> FindCoroutines()
	{
		return Coroutine.FindCoroutines(this);
	}

	public List<Coroutine> FindCoroutines(string tag)
	{
		return Coroutine.FindCoroutines(this, tag);
	}

	public bool ContainsCoroutine(Coroutine coroutine)
	{
		return coroutine.Owner as UObject == this;
	}

	public void StartInvoker(InvokerHandler handler, TimeSpan time, TimeSpan repeatedTime = default(TimeSpan), CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvoker(this, handler, time, repeatedTime, group, pool);
	}

	public void StartInvoker(InvokerHandlerWithInvoker handler, TimeSpan time, TimeSpan repeatedTime = default(TimeSpan), CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvoker(this, handler, time, repeatedTime, group, pool);
	}

	public void StartInvoker(InvokerHandlerWithObject handler, TimeSpan time, TimeSpan repeatedTime = default(TimeSpan), CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvoker(this, handler, time, repeatedTime, group, pool);
	}

	public void StartInvoker(InvokerHandlerWithObjectInvoker handler, TimeSpan time, TimeSpan repeatedTime = default(TimeSpan), CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvoker(this, handler, time, repeatedTime, group, pool);
	}

	public void StartInvokerTicks(InvokerHandler handler, ulong ticks, ulong repeatedTicks = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvokerTicks(this, handler, ticks, repeatedTicks, group, pool);
	}

	public void StartInvokerTicks(InvokerHandlerWithInvoker handler, ulong ticks, ulong repeatedTicks = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvokerTicks(this, handler, ticks, repeatedTicks, group, pool);
	}

	public void StartInvokerTicks(InvokerHandlerWithObject handler, ulong ticks, ulong repeatedTicks = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvokerTicks(this, handler, ticks, repeatedTicks, group, pool);
	}

	public void StartInvokerTicks(InvokerHandlerWithObjectInvoker handler, ulong ticks, ulong repeatedTicks = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvokerTicks(this, handler, ticks, repeatedTicks, group, pool);
	}

	public void StartInvokerFrames(InvokerHandler handler, ulong frames, ulong repeatedFrames = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvokerFrames(this, handler, frames, repeatedFrames, group, pool);
	}

	public void StartInvokerFrames(InvokerHandlerWithInvoker handler, ulong frames, ulong repeatedFrames = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvokerFrames(this, handler, frames, repeatedFrames, group, pool);
	}

	public void StartInvokerFrames(InvokerHandlerWithObject handler, ulong frames, ulong repeatedFrames = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvokerFrames(this, handler, frames, repeatedFrames, group, pool);
	}

	public void StartInvokerFrames(InvokerHandlerWithObjectInvoker handler, ulong frames, ulong repeatedFrames = 0uL, CoroutineGroup group = CoroutineGroup.Tick, bool pool = true)
	{
		Invoker.StartInvokerFrames(this, handler, frames, repeatedFrames, group, pool);
	}

	public void StopInvoker(Invoker invoker)
	{
		invoker.Stop();
	}

	public void StopInvokerByMethod(Delegate method)
	{
		Invoker.StopInvokerByMethod(this, method);
	}

	public void StopAllInvokers()
	{
		Invoker.StopAllInvokers(this);
	}

	public List<Invoker> FindInvokers()
	{
		return Invoker.FindInvokers(this);
	}

	public List<Invoker> FindInvokers(string tag)
	{
		return Invoker.FindInvokers(this, tag);
	}

	public List<Invoker> FindInvokers(int tagId)
	{
		return Invoker.FindInvokers(this, tagId);
	}

	public bool ContainsInvoker(Invoker invoker)
	{
		return invoker.Owner as UObject == this;
	}

	private static bool CompareBaseObjects(UObject lhs, UObject rhs)
	{
		bool flag = (object)lhs == null;
		bool flag2 = (object)rhs == null;
		if (flag2 && flag)
		{
			return true;
		}
		if (flag2)
		{
			if (!lhs.IsDestroyed)
			{
				return lhs.HasAnyFlags(EObjectFlags.FinishDestroyed);
			}
			return true;
		}
		if (flag)
		{
			if (!rhs.IsDestroyed)
			{
				return rhs.HasAnyFlags(EObjectFlags.FinishDestroyed);
			}
			return true;
		}
		return (object)lhs == rhs;
	}

	public static bool operator ==(UObject x, UObject y)
	{
		return CompareBaseObjects(x, y);
	}

	public static bool operator !=(UObject x, UObject y)
	{
		return !CompareBaseObjects(x, y);
	}

	public override bool Equals(object other)
	{
		UObject uObject = other as UObject;
		if (uObject == null && other != null && !(other is UObject))
		{
			return false;
		}
		return CompareBaseObjects(this, uObject);
	}

	public bool Equals(UObject other)
	{
		if ((object)other == null)
		{
			return false;
		}
		return objRefId == other.objRefId;
	}

	public override int GetHashCode()
	{
		return objRefId.GetHashCode();
	}

	public static bool IsSavingPackage()
	{
		return Native_UObjectGlobals.Get_GIsSavingPackage();
	}

	public static bool IsGarbageCollecting()
	{
		return Native_UObjectGlobals.IsGarbageCollecting();
	}

	public static void CollectGarbage()
	{
		Native_UObjectGlobals.CollectGarbageDefault();
	}

	public static void CollectGarbage(EObjectFlags keepFlags, bool performFullPurge = true)
	{
		Native_UObjectGlobals.CollectGarbage(keepFlags, performFullPurge);
	}

	public static bool TryCollectGarbage()
	{
		return Native_UObjectGlobals.TryCollectGarbageDefault();
	}

	public static bool TryCollectGarbage(EObjectFlags keepFlags, bool performFullPurge = true)
	{
		return Native_UObjectGlobals.TryCollectGarbage(keepFlags, performFullPurge);
	}

	public static bool IsIncrementalPurgePending()
	{
		return Native_UObjectGlobals.IsIncrementalPurgePending();
	}

	public static void IncrementalPurgeGarbage(bool useTimeLimit, float timeLimit = 0.002f)
	{
		Native_UObjectGlobals.IncrementalPurgeGarbage(useTimeLimit, timeLimit);
	}

	public static FName MakeUniqueObjectName(ObjectOuter outer, UClass unrealClass, FName baseName = default(FName))
	{
		Native_UObjectGlobals.MakeUniqueObjectName(outer.Address, (unrealClass == null) ? IntPtr.Zero : unrealClass.Address, ref baseName, out var result);
		return result;
	}

	public static FName MakeObjectNameFromDisplayLabel(string displayLabel, FName currentObjectName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(displayLabel);
		Native_UObjectGlobals.MakeObjectNameFromDisplayLabel(ref fStringUnsafe.Array, ref currentObjectName, out var result);
		return result;
	}

	public static bool IsReferenced(UObject res, EObjectFlags keepFlags, EInternalObjectFlags internalKeepFlags, bool checkSubObjects = false)
	{
		return Native_UObjectGlobals.IsReferenced((res == null) ? IntPtr.Zero : res.Address, keepFlags, internalKeepFlags, checkSubObjects, IntPtr.Zero);
	}

	public static bool IsLoading()
	{
		return Native_UObjectGlobals.IsLoading();
	}

	public static UPackage GetTransientPackage()
	{
		return GCHelper.Find<UPackage>(Native_UObjectGlobals.GetTransientPackage());
	}

	public static T NewObject<T>(ObjectOuter outer, UClass unrealClass, FName name = default(FName), EObjectFlags flags = EObjectFlags.NoFlags, UObject template = null, bool copyTransientsFromClassDefaults = false, IntPtr instanceGraph = default(IntPtr)) where T : UObject
	{
		return NewObject<T>(checkClass: true, outer, unrealClass, name, flags, template, copyTransientsFromClassDefaults, instanceGraph);
	}

	public static T NewObject<T>(ObjectOuter outer = default(ObjectOuter)) where T : UObject
	{
		return NewObject<T>(checkClass: false, outer, UClass.GetClass<T>(), default(FName), EObjectFlags.NoFlags, null, copyTransientsFromClassDefaults: false, (IntPtr)0);
	}

	public static T NewObject<T>(ObjectOuter outer, FName name = default(FName), EObjectFlags flags = EObjectFlags.NoFlags, UObject template = null, bool copyTransientsFromClassDefaults = false, IntPtr instanceGraph = default(IntPtr)) where T : UObject
	{
		return NewObject<T>(checkClass: false, outer, UClass.GetClass<T>(), name, flags, template, copyTransientsFromClassDefaults, instanceGraph);
	}

	private static T NewObject<T>(bool checkClass, ObjectOuter outer, UClass unrealClass, FName name = default(FName), EObjectFlags flags = EObjectFlags.NoFlags, UObject template = null, bool copyTransientsFromClassDefaults = false, IntPtr instanceGraph = default(IntPtr)) where T : UObject
	{
		if (unrealClass == null)
		{
			return null;
		}
		if (!outer.IsAnyPackage && outer.Object == null)
		{
			outer.Object = GetTransientPackage();
		}
		if (name == FName.None)
		{
			FObjectInitializer.AssertIfInConstructor(outer.Object);
		}
		if (checkClass && Native_UObjectGlobals.CheckIsClassChildOf_Internal != null)
		{
			UClass uClass = UClass.GetClass<T>();
			Native_UObjectGlobals.CheckIsClassChildOf_Internal((uClass == null) ? IntPtr.Zero : uClass.Address, (unrealClass == null) ? IntPtr.Zero : unrealClass.Address);
		}
		return GCHelper.Find<T>(Native_UObjectGlobals.StaticConstructObject_Internal((unrealClass == null) ? IntPtr.Zero : unrealClass.Address, outer.Address, ref name, flags, EInternalObjectFlags.None, (template == null) ? IntPtr.Zero : template.Address, copyTransientsFromClassDefaults, instanceGraph));
	}

	public static T DuplicateObject<T>(T sourceObject, ObjectOuter outer, FName name = default(FName), EObjectFlags flagMask = EObjectFlags.AllFlags, UClass destClass = null, EDuplicateMode duplicateMode = EDuplicateMode.Normal, EInternalObjectFlags internalFlagsMask = EInternalObjectFlags.AllFlags) where T : UObject
	{
		if (sourceObject != null)
		{
			if (!outer.IsAnyPackage && outer.Object == null)
			{
				outer.Object = GetTransientPackage();
			}
			return GCHelper.Find<T>(Native_UObjectGlobals.StaticDuplicateObject((sourceObject == null) ? IntPtr.Zero : sourceObject.Address, outer.Address, ref name, flagMask, (destClass == null) ? IntPtr.Zero : destClass.Address, duplicateMode, internalFlagsMask));
		}
		return null;
	}

	public static T FindObjectFast<T>(ObjectOuter outer, FName name, bool exactClass = false, bool anyPackage = false, EObjectFlags exclusiveFlags = EObjectFlags.NoFlags, EInternalObjectFlags exclusiveInternalFlags = EInternalObjectFlags.None) where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		return GCHelper.Find<T>(Native_UObjectGlobals.StaticFindObjectFast((uClass == null) ? IntPtr.Zero : uClass.Address, outer.Address, ref name, exactClass, anyPackage, exclusiveFlags, exclusiveInternalFlags));
	}

	public static T FindObject<T>(ObjectOuter outer, string name, bool exactClass = false) where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		return GCHelper.Find<T>(Native_UObjectGlobals.StaticFindObject((uClass == null) ? IntPtr.Zero : uClass.Address, outer.Address, ref fStringUnsafe.Array, exactClass));
	}

	public static T FindObjectChecked<T>(ObjectOuter outer, string name, bool exactClass = false) where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		return GCHelper.Find<T>(Native_UObjectGlobals.StaticFindObjectChecked((uClass == null) ? IntPtr.Zero : uClass.Address, outer.Address, ref fStringUnsafe.Array, exactClass));
	}

	public static T FindObjectSafe<T>(ObjectOuter outer, string name, bool exactClass = false) where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		return GCHelper.Find<T>(Native_UObjectGlobals.StaticFindObjectSafe((uClass == null) ? IntPtr.Zero : uClass.Address, outer.Address, ref fStringUnsafe.Array, exactClass));
	}

	public static T LoadObject<T>(ObjectOuter outer, string name, string filename = null, ELoadFlags loadFlags = ELoadFlags.None) where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(filename);
		return GCHelper.Find<T>(Native_UObjectGlobals.StaticLoadObject((uClass == null) ? IntPtr.Zero : uClass.Address, outer.Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, loadFlags, IntPtr.Zero, true));
	}

	public static UClass LoadClass<T>(ObjectOuter outer, string name, string filename = null, ELoadFlags loadFlags = ELoadFlags.None) where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		if (uClass == null)
		{
			return null;
		}
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(filename);
		return GCHelper.Find<UClass>(Native_UObjectGlobals.StaticLoadClass(uClass.Address, outer.Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, loadFlags, IntPtr.Zero));
	}

	public static UClass LoadClass(UClass baseClass, ObjectOuter outer, string name, string filename = null, ELoadFlags loadFlags = ELoadFlags.None)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		using FStringUnsafe fStringUnsafe2 = new FStringUnsafe(filename);
		return GCHelper.Find<UClass>(Native_UObjectGlobals.StaticLoadClass(baseClass.Address, outer.Address, ref fStringUnsafe.Array, ref fStringUnsafe2.Array, loadFlags, IntPtr.Zero));
	}

	public static T GetDefault<T>() where T : UObject
	{
		UClass uClass = UClass.GetClass<T>();
		if (uClass != null)
		{
			return uClass.GetDefaultObject() as T;
		}
		return null;
	}

	public static T GetDefault<T>(UClass unrealClass) where T : UObject
	{
		if (unrealClass != null && unrealClass.IsA<T>())
		{
			UObject defaultObject = unrealClass.GetDefaultObject();
			if (defaultObject.IsA<T>())
			{
				return defaultObject as T;
			}
		}
		return null;
	}

	public static UPackage LoadPackage(UPackage outer, string longPackageName, ELoadFlags loadFlags)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(longPackageName);
		return GCHelper.Find<UPackage>(Native_UObjectGlobals.LoadPackage((outer == null) ? IntPtr.Zero : outer.Address, ref fStringUnsafe.Array, loadFlags));
	}

	public static UPackage FindPackage(ObjectOuter outer, string packageName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(packageName);
		return GCHelper.Find<UPackage>(Native_UObjectGlobals.FindPackage(outer.Address, ref fStringUnsafe.Array));
	}

	public static UPackage CreatePackage(ObjectOuter outer, string packageName)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(packageName);
		return GCHelper.Find<UPackage>(Native_UObjectGlobals.CreatePackage(ref fStringUnsafe.Array));
	}

	public static UObject StaticAllocateObject(UClass unrealClass, ObjectOuter outer, FName name, out bool outReusedSubobject, EObjectFlags setFlags, EInternalObjectFlags internalSetFlags, bool canReuseSubobjects = false)
	{
		csbool outReusedSubobject2;
		UObject result = GCHelper.Find<UObject>(Native_UObjectGlobals.StaticAllocateObject((unrealClass == null) ? IntPtr.Zero : unrealClass.Address, outer.Address, ref name, setFlags, internalSetFlags, canReuseSubobjects, out outReusedSubobject2));
		outReusedSubobject = outReusedSubobject2;
		return result;
	}
}
