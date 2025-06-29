using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.StateNodeChildActorControl")]
public struct FStateNodeChildActorControl
{
	[DisplayName("管理的JJS阻挡")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.StateNodeChildActorControl:JJSObstacleCollection")]
	public List<FStateNodeChildActorControlJJSObstacle> JJSObstacleCollection;

	private static int StateNodeChildActorControl_StructSize;

	private static int StateNodeChildActorControl_IsValid;

	private static bool JJSObstacleCollection_IsValid;

	private static int JJSObstacleCollection_Offset;

	private static FFieldAddress JJSObstacleCollection_PropertyAddress;

	public FStateNodeChildActorControl Copy()
	{
		FStateNodeChildActorControl result = this;
		if (JJSObstacleCollection != null)
		{
			result.JJSObstacleCollection = new List<FStateNodeChildActorControlJJSObstacle>(JJSObstacleCollection);
		}
		return result;
	}

	public static FStateNodeChildActorControl FromNative(IntPtr nativeBuffer)
	{
		return new FStateNodeChildActorControl(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStateNodeChildActorControl value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStateNodeChildActorControl FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStateNodeChildActorControl(IntPtr.Add(nativeBuffer, arrayIndex * StateNodeChildActorControl_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStateNodeChildActorControl value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * StateNodeChildActorControl_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (StateNodeChildActorControl_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StateNodeChildActorControl");
		}
		else
		{
			new TArrayCopyMarshaler<FStateNodeChildActorControlJJSObstacle>(1, JJSObstacleCollection_PropertyAddress, CachedMarshalingDelegates<FStateNodeChildActorControlJJSObstacle, FStateNodeChildActorControlJJSObstacle>.FromNative, CachedMarshalingDelegates<FStateNodeChildActorControlJJSObstacle, FStateNodeChildActorControlJJSObstacle>.ToNative).ToNative(IntPtr.Add(nativeStruct, JJSObstacleCollection_Offset), JJSObstacleCollection);
		}
	}

	public FStateNodeChildActorControl(IntPtr nativeStruct)
	{
		if (StateNodeChildActorControl_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StateNodeChildActorControl");
			JJSObstacleCollection = null;
		}
		else
		{
			JJSObstacleCollection = new TArrayCopyMarshaler<FStateNodeChildActorControlJJSObstacle>(1, JJSObstacleCollection_PropertyAddress, CachedMarshalingDelegates<FStateNodeChildActorControlJJSObstacle, FStateNodeChildActorControlJJSObstacle>.FromNative, CachedMarshalingDelegates<FStateNodeChildActorControlJJSObstacle, FStateNodeChildActorControlJJSObstacle>.ToNative).FromNative(IntPtr.Add(nativeStruct, JJSObstacleCollection_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.StateNodeChildActorControl");
		StateNodeChildActorControl_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref JJSObstacleCollection_PropertyAddress, intPtr, "JJSObstacleCollection");
		JJSObstacleCollection_Offset = NativeReflection.GetPropertyOffset(intPtr, "JJSObstacleCollection");
		JJSObstacleCollection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JJSObstacleCollection", Classes.FArrayProperty);
		StateNodeChildActorControl_IsValid = ((intPtr != IntPtr.Zero && JJSObstacleCollection_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.StateNodeChildActorControl", (byte)StateNodeChildActorControl_IsValid != 0);
	}

	static FStateNodeChildActorControl()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FStateNodeChildActorControl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStateNodeChildActorControl));
	}
}
