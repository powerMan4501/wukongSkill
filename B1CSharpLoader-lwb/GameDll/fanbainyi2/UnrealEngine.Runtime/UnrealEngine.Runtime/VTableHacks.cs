using System;
using System.Collections.Generic;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

internal static class VTableHacks
{
	private delegate void GetLifetimeReplicatedPropsDel(IntPtr address, IntPtr arrayAddress);

	private delegate void SetupPlayerInputComponentDel(IntPtr address, IntPtr inputComponentAddress);

	private delegate void ActorBeginPlayDel(IntPtr address);

	private delegate void ActorEndPlayDel(IntPtr address, byte endPlayReason);

	private delegate void ActorComponentBeginPlayDel(IntPtr address);

	private delegate void ActorComponentEndPlayDel(IntPtr address, byte endPlayReason);

	private class FunctionRedirect
	{
		public IntPtr Class;

		public int VTableIndex;

		public IntPtr NativeCallback;

		public string DummyName;

		public Delegate Callback;

		public FunctionRedirect(IntPtr unrealClass, string dummyName, Delegate callback)
		{
			Class = unrealClass;
			DummyName = dummyName;
			Callback = callback;
		}

		public IntPtr GetOriginal(UObject obj)
		{
			UClass uClass = obj.GetClass();
			if (uClass.VTableOriginalFunctions == null)
			{
				HackVTable(obj);
			}
			uClass.VTableOriginalFunctions.TryGetValue(VTableIndex, out var value);
			return value;
		}
	}

	private static FunctionRedirect repProps;

	private static FunctionRedirect setupPlayerInput;

	private static FunctionRedirect actorBeginPlay;

	private static FunctionRedirect actorEndPlay;

	private static FunctionRedirect actorComponentBeginPlay;

	private static FunctionRedirect actorComponentEndPlay;

	private static List<FunctionRedirect> vtableRedirects;

	private static void AddVTableRedirects()
	{
		_ = Classes.UObject;
		_ = Classes.APawn;
		_ = Classes.AActor;
		_ = Classes.UActorComponent;
	}

	private static void OnGetLifetimeReplicatedProps(IntPtr address, IntPtr arrayAddress)
	{
		UObject uObject = GCHelper.Find<UObject>(address);
		IntPtr original = repProps.GetOriginal(uObject);
		Native_VTableHacks.CallOriginal_GetLifetimeReplicatedProps(original, address, arrayAddress);
		using TArrayUnsafeRef<FLifetimeProperty> dest = new TArrayUnsafeRef<FLifetimeProperty>(arrayAddress);
		FLifetimePropertyCollection lifetimeProps = new FLifetimePropertyCollection(address, dest);
		uObject.GetLifetimeReplicatedProps(lifetimeProps);
	}

	private static void OnSetupPlayerInputComponent(IntPtr address, IntPtr inputComponentAddress)
	{
		UObject uObject = GCHelper.Find<UObject>(address);
		IntPtr original = setupPlayerInput.GetOriginal(uObject);
		Native_VTableHacks.CallOriginal_SetupPlayerInputComponent(original, address, inputComponentAddress);
		uObject.SetupPlayerInputComponent(inputComponentAddress);
	}

	private static void OnActorBeginPlay(IntPtr address)
	{
		UObject uObject = GCHelper.Find<UObject>(address);
		IntPtr original = actorBeginPlay.GetOriginal(uObject);
		Native_VTableHacks.CallOriginal_ActorBeginPlay(original, address);
		uObject.BeginPlayInternal();
	}

	private static void OnActorEndPlay(IntPtr address, byte endPlayReason)
	{
		UObject uObject = GCHelper.Find<UObject>(address);
		IntPtr original = actorEndPlay.GetOriginal(uObject);
		Native_VTableHacks.CallOriginal_ActorEndPlay(original, address, endPlayReason);
		uObject.EndPlayInternal(endPlayReason);
	}

	private static void OnActorComponentBeginPlay(IntPtr address)
	{
		UObject uObject = GCHelper.Find<UObject>(address);
		IntPtr original = actorComponentBeginPlay.GetOriginal(uObject);
		Native_VTableHacks.CallOriginal_ActorComponentBeginPlay(original, address);
		uObject.BeginPlayInternal();
	}

	private static void OnActorComponentEndPlay(IntPtr address, byte endPlayReason)
	{
		UObject uObject = GCHelper.Find<UObject>(address);
		IntPtr original = actorComponentEndPlay.GetOriginal(uObject);
		Native_VTableHacks.CallOriginal_ActorComponentEndPlay(original, address, endPlayReason);
		uObject.EndPlayInternal(endPlayReason);
	}

	private static FunctionRedirect AddVTableRedirect(IntPtr unrealClass, string dummyName, Delegate callback)
	{
		FunctionRedirect functionRedirect = new FunctionRedirect(unrealClass, dummyName, callback);
		vtableRedirects.Add(functionRedirect);
		return functionRedirect;
	}

	public static void Load()
	{
		vtableRedirects = new List<FunctionRedirect>();
	}

	public unsafe static void Unload()
	{
		foreach (FunctionRedirect vtableRedirect in vtableRedirects)
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe(vtableRedirect.DummyName);
			Native_VTableHacks.Set_VTableCallback(ref fStringUnsafe.Array, IntPtr.Zero);
		}
		foreach (IntPtr item in new NativeReflection.NativeObjectIterator(Classes.UObject, EObjectFlags.NoFlags))
		{
			foreach (FunctionRedirect vtableRedirect2 in vtableRedirects)
			{
				if (!Native_UObjectBaseUtility.IsA(item, vtableRedirect2.Class))
				{
					continue;
				}
				IntPtr* ptr = *(IntPtr**)(void*)item;
				if (ptr[vtableRedirect2.VTableIndex] == vtableRedirect2.NativeCallback)
				{
					UClass uClass = GCHelper.Find<UObject>(item).GetClass();
					if (uClass.VTableOriginalFunctions != null && uClass.VTableOriginalFunctions.TryGetValue(vtableRedirect2.VTableIndex, out var value))
					{
						FMemory.PageProtect((IntPtr)(ptr + vtableRedirect2.VTableIndex), (IntPtr)IntPtr.Size, canRead: true, canWrite: true);
						ptr[vtableRedirect2.VTableIndex] = value;
					}
				}
			}
		}
	}

	public static void HackVTable(UObject obj)
	{
	}

	private unsafe static IntPtr FindOriginalVTableOwner(IntPtr baseMostClass, IntPtr ownerClass, IntPtr functionAddress, int vtableIndex)
	{
		if (ownerClass == baseMostClass)
		{
			return ownerClass;
		}
		IntPtr result = ownerClass;
		while ((ownerClass = Native_UClass.GetSuperClass(ownerClass)) != IntPtr.Zero)
		{
			if (*(IntPtr*)((nint)(*(IntPtr*)(void*)Native_UClass.GetDefaultObject(ownerClass, true)) + (nint)vtableIndex * (nint)sizeof(IntPtr)) == functionAddress)
			{
				result = ownerClass;
			}
			if (ownerClass == baseMostClass)
			{
				return ownerClass;
			}
		}
		return result;
	}
}
