using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.ViewportInteraction;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ViewportInteraction.ViewportActionKeyInput", "ViewportInteraction", UnrealModuleType.Engine)]
public struct FViewportActionKeyInput
{
	private static bool ActionType_IsValid;

	private static int ActionType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/ViewportInteraction.ViewportActionKeyInput:ActionType")]
	public FName ActionType;

	private static bool Event_IsValid;

	private static FFieldAddress Event_PropertyAddress;

	private static int Event_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/ViewportInteraction.ViewportActionKeyInput:Event")]
	public EInputEventType Event;

	private static bool FViewportActionKeyInput_IsValid;

	private static int FViewportActionKeyInput_StructSize;

	public FViewportActionKeyInput Copy()
	{
		return this;
	}

	public static FViewportActionKeyInput FromNative(IntPtr nativeBuffer)
	{
		return new FViewportActionKeyInput(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FViewportActionKeyInput value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FViewportActionKeyInput FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FViewportActionKeyInput(nativeBuffer + arrayIndex * FViewportActionKeyInput_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FViewportActionKeyInput value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FViewportActionKeyInput_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FViewportActionKeyInput_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ViewportInteraction.ViewportActionKeyInput");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ActionType_Offset), ActionType);
		EnumMarshaler<EInputEventType>.ToNative(IntPtr.Add(nativeStruct, Event_Offset), 0, Event_PropertyAddress.Address, Event);
	}

	public FViewportActionKeyInput(IntPtr nativeStruct)
	{
		if (!FViewportActionKeyInput_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ViewportInteraction.ViewportActionKeyInput");
			ActionType = default(FName);
			Event = EInputEventType.IE_Pressed;
		}
		else
		{
			ActionType = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ActionType_Offset));
			Event = EnumMarshaler<EInputEventType>.FromNative(IntPtr.Add(nativeStruct, Event_Offset), 0, Event_PropertyAddress.Address);
		}
	}

	static FViewportActionKeyInput()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FViewportActionKeyInput)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FViewportActionKeyInput));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ViewportInteraction.ViewportActionKeyInput");
		FViewportActionKeyInput_StructSize = NativeReflection.GetStructSize(intPtr);
		ActionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActionType");
		ActionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActionType", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Event_PropertyAddress, intPtr, "Event");
		Event_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Event");
		Event_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Event", Classes.FByteProperty);
		FViewportActionKeyInput_IsValid = intPtr != IntPtr.Zero && ActionType_IsValid && Event_IsValid;
		NativeReflection.LogStructIsValid("/Script/ViewportInteraction.ViewportActionKeyInput", FViewportActionKeyInput_IsValid);
	}
}
