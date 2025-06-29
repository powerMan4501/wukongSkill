using System;
using System.Linq;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

[UStruct(Flags = 513)]
[UMetaPath("/Script/Engine.TickFunction")]
public struct FTickFunction
{
	private static FFieldAddress TickGroup_PropertyAddress;

	private static int TickGroup_Offset;

	private static FFieldAddress EndTickGroup_PropertyAddress;

	private static int EndTickGroup_Offset;

	private static FFieldAddress TickEvenWhenPaused_PropertyAddress;

	private static int TickEvenWhenPaused_Offset;

	private static FFieldAddress CanEverTick_PropertyAddress;

	private static int CanEverTick_Offset;

	private static FFieldAddress StartWithTickEnabled_PropertyAddress;

	private static int StartWithTickEnabled_Offset;

	private static FFieldAddress AllowTickOnDedicatedServer_PropertyAddress;

	private static int AllowTickOnDedicatedServer_Offset;

	private static int TickInterval_Offset;

	public IntPtr Address;

	internal static int FTickFunction_StructSize;

	[UProperty(Flags = (PropFlags)6759867280851457uL)]
	[UMetaPath("/Script/Engine.TickFunction:TickGroup")]
	public ETickingGroup TickGroup
	{
		get
		{
			return EnumMarshaler<ETickingGroup>.FromNative(IntPtr.Add(Address, TickGroup_Offset), 0, TickGroup_PropertyAddress.Address);
		}
		set
		{
			EnumMarshaler<ETickingGroup>.ToNative(IntPtr.Add(Address, TickGroup_Offset), 0, TickGroup_PropertyAddress.Address, value);
		}
	}

	[UProperty(Flags = (PropFlags)6759867280851457uL)]
	[UMetaPath("/Script/Engine.TickFunction:EndTickGroup")]
	public ETickingGroup EndTickGroup
	{
		get
		{
			return EnumMarshaler<ETickingGroup>.FromNative(IntPtr.Add(Address, EndTickGroup_Offset), 0, EndTickGroup_PropertyAddress.Address);
		}
		set
		{
			EnumMarshaler<ETickingGroup>.ToNative(IntPtr.Add(Address, EndTickGroup_Offset), 0, EndTickGroup_PropertyAddress.Address, value);
		}
	}

	[UProperty(Flags = (PropFlags)6759866207109121uL)]
	[UMetaPath("/Script/Engine.TickFunction:bTickEvenWhenPaused")]
	public bool TickEvenWhenPaused
	{
		get
		{
			return BoolMarshaler.FromNative(IntPtr.Add(Address, TickEvenWhenPaused_Offset), 0, TickEvenWhenPaused_PropertyAddress.Address);
		}
		set
		{
			BoolMarshaler.ToNative(IntPtr.Add(Address, TickEvenWhenPaused_Offset), 0, TickEvenWhenPaused_PropertyAddress.Address, value);
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532480uL)]
	[UMetaPath("/Script/Engine.TickFunction:bCanEverTick")]
	public bool CanEverTick
	{
		get
		{
			return BoolMarshaler.FromNative(IntPtr.Add(Address, CanEverTick_Offset), 0, CanEverTick_PropertyAddress.Address);
		}
		set
		{
			BoolMarshaler.ToNative(IntPtr.Add(Address, CanEverTick_Offset), 0, CanEverTick_PropertyAddress.Address, value);
		}
	}

	[UProperty(Flags = (PropFlags)6755468160598017uL)]
	[UMetaPath("/Script/Engine.TickFunction:bStartWithTickEnabled")]
	public bool StartWithTickEnabled
	{
		get
		{
			return BoolMarshaler.FromNative(IntPtr.Add(Address, StartWithTickEnabled_Offset), 0, StartWithTickEnabled_PropertyAddress.Address);
		}
		set
		{
			BoolMarshaler.ToNative(IntPtr.Add(Address, StartWithTickEnabled_Offset), 0, StartWithTickEnabled_PropertyAddress.Address, value);
		}
	}

	[UProperty(Flags = (PropFlags)6759866207109121uL)]
	[UMetaPath("/Script/Engine.TickFunction:bAllowTickOnDedicatedServer")]
	public bool AllowTickOnDedicatedServer
	{
		get
		{
			return BoolMarshaler.FromNative(IntPtr.Add(Address, AllowTickOnDedicatedServer_Offset), 0, AllowTickOnDedicatedServer_PropertyAddress.Address);
		}
		set
		{
			BoolMarshaler.ToNative(IntPtr.Add(Address, AllowTickOnDedicatedServer_Offset), 0, AllowTickOnDedicatedServer_PropertyAddress.Address, value);
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340353uL)]
	[UMetaPath("/Script/Engine.TickFunction:TickInterval")]
	public float TickInterval
	{
		get
		{
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(Address, AllowTickOnDedicatedServer_Offset));
		}
		set
		{
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(Address, AllowTickOnDedicatedServer_Offset), value);
		}
	}

	public bool HighPriority
	{
		get
		{
			return Native_FTickFunction.Get_bHighPriority(Address);
		}
		set
		{
			Native_FTickFunction.Set_bHighPriority(Address, value);
		}
	}

	public bool RunOnAnyThread
	{
		get
		{
			return Native_FTickFunction.Get_bRunOnAnyThread(Address);
		}
		set
		{
			Native_FTickFunction.Set_bRunOnAnyThread(Address, value);
		}
	}

	public bool IsNull => Address == IntPtr.Zero;

	public void RegisterTickFunction(UObject level)
	{
		Native_FTickFunction.RegisterTickFunction(Address, level.Address);
	}

	public void RegisterTickFunction(IntPtr level)
	{
		Native_FTickFunction.RegisterTickFunction(Address, level);
	}

	public void UnRegisterTickFunction()
	{
		Native_FTickFunction.UnRegisterTickFunction(Address);
	}

	public bool IsTickFunctionRegistered()
	{
		return Native_FTickFunction.IsTickFunctionRegistered(Address);
	}

	public void SetTickFunctionEnable(bool enabled)
	{
		Native_FTickFunction.SetTickFunctionEnable(Address, enabled);
	}

	public bool IsCompletionHandleValid()
	{
		return Native_FTickFunction.IsCompletionHandleValid(Address);
	}

	public ETickingGroup GetActualTickGroup()
	{
		return Native_FTickFunction.GetActualTickGroup(Address);
	}

	public ETickingGroup GetActualEndTickGroup()
	{
		return Native_FTickFunction.GetActualEndTickGroup(Address);
	}

	public void AddPrerequisite(UObject targetObject, FTickFunction targetTickFunction)
	{
		Native_FTickFunction.AddPrerequisite(Address, targetObject.Address, targetTickFunction.Address);
	}

	public void RemovePrerequisite(UObject targetObject, FTickFunction targetTickFunction)
	{
		Native_FTickFunction.RemovePrerequisite(Address, targetObject.Address, targetTickFunction.Address);
	}

	public void SetPriorityIncludingPrerequisites(bool highPriority)
	{
		Native_FTickFunction.SetPriorityIncludingPrerequisites(Address, highPriority);
	}

	public FTickPrerequisite[] GetPrerequisites()
	{
		return new TArrayUnsafeRef<FTickPrerequisite>(Native_FTickFunction.GetPrerequisites(Address)).ToArray();
	}

	public void SetPrerequisites(FTickPrerequisite[] prerequisites)
	{
		TArrayUnsafeRef<FTickPrerequisite> tArrayUnsafeRef = new TArrayUnsafeRef<FTickPrerequisite>(Native_FTickFunction.GetPrerequisites(Address));
		tArrayUnsafeRef.Clear();
		if (prerequisites != null)
		{
			tArrayUnsafeRef.AddRange(prerequisites);
		}
	}

	public unsafe IntPtr GetTargetPtr()
	{
		return *(IntPtr*)(void*)(Address + FTickFunction_StructSize);
	}

	public UObject GetTarget()
	{
		return GCHelper.Find<UObject>(GetTargetPtr());
	}

	public T GetTarget<T>() where T : UObject
	{
		return GCHelper.Find<T>(GetTargetPtr());
	}

	public static FTickFunction New(TickFunctionType type)
	{
		return new FTickFunction(Native_FTickFunction.New(type));
	}

	public void Delete()
	{
		Native_FTickFunction.Delete(Address);
	}

	public void SetTickGroup(ETickingGroup tickGroup)
	{
		TickGroup = tickGroup;
	}

	public void SetEndTickGroup(ETickingGroup endTickGroup)
	{
		EndTickGroup = endTickGroup;
	}

	public void SetTickEvenWhenPaused(bool tickEvenWhenPaused)
	{
		TickEvenWhenPaused = tickEvenWhenPaused;
	}

	public void SetCanEverTick(bool canEverTick)
	{
		CanEverTick = canEverTick;
	}

	public void SetStartWithTickEnabled(bool startWithTickEnabled)
	{
		StartWithTickEnabled = startWithTickEnabled;
	}

	public void SetAllowTickOnDedicatedServer(bool allowTickOnDedicatedServer)
	{
		AllowTickOnDedicatedServer = allowTickOnDedicatedServer;
	}

	public void SetTickInterval(float tickInterval)
	{
		TickInterval = tickInterval;
	}

	public void SetHighPriority(bool highPriority)
	{
		HighPriority = highPriority;
	}

	public void SetRunOnAnyThread(bool runOnAnyThread)
	{
		RunOnAnyThread = runOnAnyThread;
	}

	public FTickFunction(IntPtr address)
	{
		Address = address;
	}

	static FTickFunction()
	{
		LoadNativeType();
		UnrealTypes.OnCCtorCalled(typeof(FTickFunction));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TickFunction");
		FTickFunction_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref TickGroup_PropertyAddress, intPtr, "TickGroup");
		TickGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TickGroup");
		bool flag = NativeReflectionCached.ValidatePropertyClass(intPtr, "TickGroup", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref EndTickGroup_PropertyAddress, intPtr, "EndTickGroup");
		EndTickGroup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndTickGroup");
		bool flag2 = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndTickGroup", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref TickEvenWhenPaused_PropertyAddress, intPtr, "bTickEvenWhenPaused");
		TickEvenWhenPaused_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTickEvenWhenPaused");
		bool flag3 = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTickEvenWhenPaused", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanEverTick_PropertyAddress, intPtr, "bCanEverTick");
		CanEverTick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanEverTick");
		bool flag4 = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanEverTick", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StartWithTickEnabled_PropertyAddress, intPtr, "bStartWithTickEnabled");
		StartWithTickEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStartWithTickEnabled");
		bool flag5 = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStartWithTickEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowTickOnDedicatedServer_PropertyAddress, intPtr, "bAllowTickOnDedicatedServer");
		AllowTickOnDedicatedServer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowTickOnDedicatedServer");
		bool flag6 = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowTickOnDedicatedServer", Classes.FBoolProperty);
		TickInterval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TickInterval");
		bool flag7 = NativeReflectionCached.ValidatePropertyClass(intPtr, "TickInterval", Classes.FFloatProperty);
		_ = intPtr != IntPtr.Zero;
		string.Format("[LoadNativeType] FTickFunction is not VALID!!!, classAddress = {7}, TickGroup_IsValid = {0}, EndTickGroup_IsValid = {1}, TickEvenWhenPaused_IsValid = {2}, CanEverTick_IsValid = {3}, StartWithTickEnabled_IsValid = {4}, AllowTickOnDedicatedServer_IsValid = {5}, TickInterval_IsValid = {6}", flag, flag2, flag3, flag4, flag5, flag6, flag7, intPtr);
	}
}
