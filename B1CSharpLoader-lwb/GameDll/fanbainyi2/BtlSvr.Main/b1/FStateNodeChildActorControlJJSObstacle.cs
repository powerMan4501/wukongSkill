using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.StateNodeChildActorControlJJSObstacle")]
public struct FStateNodeChildActorControlJJSObstacle
{
	[DisplayName("专属物件别名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.StateNodeChildActorControlJJSObstacle:Nickname")]
	public FGameplayTag Nickname;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("状态")]
	[USharpPath("/Script/b1-Managed.StateNodeChildActorControlJJSObstacle:State")]
	public EDynamicObstacleState State;

	private static int StateNodeChildActorControlJJSObstacle_StructSize;

	private static int StateNodeChildActorControlJJSObstacle_IsValid;

	private static bool Nickname_IsValid;

	private static int Nickname_Offset;

	private static bool State_IsValid;

	private static int State_Offset;

	private static FFieldAddress State_PropertyAddress;

	public FStateNodeChildActorControlJJSObstacle Copy()
	{
		return this;
	}

	public static FStateNodeChildActorControlJJSObstacle FromNative(IntPtr nativeBuffer)
	{
		return new FStateNodeChildActorControlJJSObstacle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStateNodeChildActorControlJJSObstacle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStateNodeChildActorControlJJSObstacle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStateNodeChildActorControlJJSObstacle(IntPtr.Add(nativeBuffer, arrayIndex * StateNodeChildActorControlJJSObstacle_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStateNodeChildActorControlJJSObstacle value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * StateNodeChildActorControlJJSObstacle_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (StateNodeChildActorControlJJSObstacle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StateNodeChildActorControlJJSObstacle");
			return;
		}
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, Nickname_Offset), Nickname);
		EnumMarshaler<EDynamicObstacleState>.ToNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address, State);
	}

	public FStateNodeChildActorControlJJSObstacle(IntPtr nativeStruct)
	{
		if (StateNodeChildActorControlJJSObstacle_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StateNodeChildActorControlJJSObstacle");
			Nickname = default(FGameplayTag);
			State = EDynamicObstacleState.Opened;
		}
		else
		{
			Nickname = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, Nickname_Offset));
			State = EnumMarshaler<EDynamicObstacleState>.FromNative(IntPtr.Add(nativeStruct, State_Offset), 0, State_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.StateNodeChildActorControlJJSObstacle");
		StateNodeChildActorControlJJSObstacle_StructSize = NativeReflection.GetStructSize(intPtr);
		Nickname_Offset = NativeReflection.GetPropertyOffset(intPtr, "Nickname");
		Nickname_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Nickname", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref State_PropertyAddress, intPtr, "State");
		State_Offset = NativeReflection.GetPropertyOffset(intPtr, "State");
		State_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "State", Classes.FEnumProperty);
		StateNodeChildActorControlJJSObstacle_IsValid = ((intPtr != IntPtr.Zero && Nickname_IsValid && State_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.StateNodeChildActorControlJJSObstacle", (byte)StateNodeChildActorControlJJSObstacle_IsValid != 0);
	}

	static FStateNodeChildActorControlJJSObstacle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FStateNodeChildActorControlJJSObstacle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStateNodeChildActorControlJJSObstacle));
	}
}
