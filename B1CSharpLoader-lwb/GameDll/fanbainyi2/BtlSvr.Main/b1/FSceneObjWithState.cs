using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.SceneObjWithState")]
public struct FSceneObjWithState
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SceneObjWithState:UnitGuid")]
	public string UnitGuid;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SceneObjWithState:ActiveState")]
	public ESceneObjTransitionState ActiveState;

	private static int SceneObjWithState_StructSize;

	private static int SceneObjWithState_IsValid;

	private static bool UnitGuid_IsValid;

	private static int UnitGuid_Offset;

	private static bool ActiveState_IsValid;

	private static int ActiveState_Offset;

	private static FFieldAddress ActiveState_PropertyAddress;

	public FSceneObjWithState Copy()
	{
		return this;
	}

	public static FSceneObjWithState FromNative(IntPtr nativeBuffer)
	{
		return new FSceneObjWithState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSceneObjWithState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSceneObjWithState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSceneObjWithState(IntPtr.Add(nativeBuffer, arrayIndex * SceneObjWithState_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSceneObjWithState value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SceneObjWithState_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SceneObjWithState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SceneObjWithState");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, UnitGuid_Offset), UnitGuid);
		EnumMarshaler<ESceneObjTransitionState>.ToNative(IntPtr.Add(nativeStruct, ActiveState_Offset), 0, ActiveState_PropertyAddress.Address, ActiveState);
	}

	public FSceneObjWithState(IntPtr nativeStruct)
	{
		if (SceneObjWithState_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SceneObjWithState");
			UnitGuid = null;
			ActiveState = ESceneObjTransitionState.State0;
		}
		else
		{
			UnitGuid = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, UnitGuid_Offset));
			ActiveState = EnumMarshaler<ESceneObjTransitionState>.FromNative(IntPtr.Add(nativeStruct, ActiveState_Offset), 0, ActiveState_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SceneObjWithState");
		SceneObjWithState_StructSize = NativeReflection.GetStructSize(intPtr);
		UnitGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitGuid");
		UnitGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ActiveState_PropertyAddress, intPtr, "ActiveState");
		ActiveState_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActiveState");
		ActiveState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActiveState", Classes.FEnumProperty);
		SceneObjWithState_IsValid = ((intPtr != IntPtr.Zero && UnitGuid_IsValid && ActiveState_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SceneObjWithState", (byte)SceneObjWithState_IsValid != 0);
	}

	static FSceneObjWithState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSceneObjWithState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSceneObjWithState));
	}
}
