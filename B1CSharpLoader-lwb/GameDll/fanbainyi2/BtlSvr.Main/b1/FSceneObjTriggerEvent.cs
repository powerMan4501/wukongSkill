using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SceneObjTriggerEvent")]
public struct FSceneObjTriggerEvent
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SceneObjTriggerEvent:UnitGuid")]
	public string UnitGuid;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SceneObjTriggerEvent:UnTriggerEvent")]
	public ESceneObjTransitionEvent UnTriggerEvent;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SceneObjTriggerEvent:TriggerEvent")]
	public ESceneObjTransitionEvent TriggerEvent;

	private static int SceneObjTriggerEvent_StructSize;

	private static int SceneObjTriggerEvent_IsValid;

	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool UnTriggerEvent_IsValid;

	private static int UnTriggerEvent_Offset;

	private static FFieldAddress UnTriggerEvent_PropertyAddress;

	private static bool TriggerEvent_IsValid;

	private static int TriggerEvent_Offset;

	private static FFieldAddress TriggerEvent_PropertyAddress;

	public FSceneObjTriggerEvent Copy()
	{
		return this;
	}

	public static FSceneObjTriggerEvent FromNative(IntPtr nativeBuffer)
	{
		return new FSceneObjTriggerEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSceneObjTriggerEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSceneObjTriggerEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSceneObjTriggerEvent(IntPtr.Add(nativeBuffer, arrayIndex * SceneObjTriggerEvent_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSceneObjTriggerEvent value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SceneObjTriggerEvent_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SceneObjTriggerEvent_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SceneObjTriggerEvent");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, UnitGuid_Offset), UnitGuid);
		EnumMarshaler<ESceneObjTransitionEvent>.ToNative(IntPtr.Add(nativeStruct, UnTriggerEvent_Offset), 0, UnTriggerEvent_PropertyAddress.Address, UnTriggerEvent);
		EnumMarshaler<ESceneObjTransitionEvent>.ToNative(IntPtr.Add(nativeStruct, TriggerEvent_Offset), 0, TriggerEvent_PropertyAddress.Address, TriggerEvent);
	}

	public FSceneObjTriggerEvent(IntPtr nativeStruct)
	{
		if (SceneObjTriggerEvent_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SceneObjTriggerEvent");
			UnitGuid = null;
			UnTriggerEvent = ESceneObjTransitionEvent.OnSpawn;
			TriggerEvent = ESceneObjTransitionEvent.OnSpawn;
		}
		else
		{
			UnitGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, UnitGuid_Offset));
			UnTriggerEvent = EnumMarshaler<ESceneObjTransitionEvent>.FromNative(IntPtr.Add(nativeStruct, UnTriggerEvent_Offset), 0, UnTriggerEvent_PropertyAddress.Address);
			TriggerEvent = EnumMarshaler<ESceneObjTransitionEvent>.FromNative(IntPtr.Add(nativeStruct, TriggerEvent_Offset), 0, TriggerEvent_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SceneObjTriggerEvent");
		SceneObjTriggerEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref UnTriggerEvent_PropertyAddress, intPtr, "UnTriggerEvent");
		UnTriggerEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnTriggerEvent");
		UnTriggerEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnTriggerEvent", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref TriggerEvent_PropertyAddress, intPtr, "TriggerEvent");
		TriggerEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerEvent");
		TriggerEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerEvent", Classes.FEnumProperty);
		SceneObjTriggerEvent_IsValid = ((intPtr != IntPtr.Zero && UnitGuid_IsValid && UnTriggerEvent_IsValid && TriggerEvent_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SceneObjTriggerEvent", (byte)SceneObjTriggerEvent_IsValid != 0);
	}

	static FSceneObjTriggerEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSceneObjTriggerEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSceneObjTriggerEvent));
	}
}
