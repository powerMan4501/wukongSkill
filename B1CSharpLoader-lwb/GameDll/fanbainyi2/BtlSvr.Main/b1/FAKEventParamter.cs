using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FAKEventParamter")]
public struct FAKEventParamter
{
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FAKEventParamter:AttachPointName")]
	public string AttachPointName;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("DumperTruckTrigger config")]
	[USharpPath("/Script/b1-Managed.FAKEventParamter:AkEvent")]
	public TSoftObject<UAkAudioEvent> AkEvent;

	[UProperty]
	[BlueprintReadWrite]
	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FAKEventParamter:AkStopEvent")]
	public TSoftObject<UAkAudioEvent> AkStopEvent;

	[Category("DumperTruckTrigger config")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FAKEventParamter:Follow")]
	public bool Follow;

	[UProperty]
	[EditAnywhere]
	[Category("DumperTruckTrigger config")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FAKEventParamter:EventName")]
	public string EventName;

	private static int FAKEventParamter_StructSize;

	private static int FAKEventParamter_IsValid;

	private static bool AttachPointName_IsValid;

	private static int AttachPointName_Offset;

	private static bool AkEvent_IsValid;

	private static int AkEvent_Offset;

	private static bool AkStopEvent_IsValid;

	private static int AkStopEvent_Offset;

	private static bool Follow_IsValid;

	private static int Follow_Offset;

	private static FFieldAddress Follow_PropertyAddress;

	private static bool EventName_IsValid;

	private static int EventName_Offset;

	public FAKEventParamter Copy()
	{
		return this;
	}

	public static FAKEventParamter FromNative(IntPtr nativeBuffer)
	{
		return new FAKEventParamter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAKEventParamter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAKEventParamter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAKEventParamter(IntPtr.Add(nativeBuffer, arrayIndex * FAKEventParamter_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAKEventParamter value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FAKEventParamter_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FAKEventParamter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FAKEventParamter");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, AttachPointName_Offset), AttachPointName);
		TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEvent_Offset), AkEvent);
		TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkStopEvent_Offset), AkStopEvent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Follow_Offset), 0, Follow_PropertyAddress.Address, Follow);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, EventName_Offset), EventName);
	}

	public FAKEventParamter(IntPtr nativeStruct)
	{
		if (FAKEventParamter_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FAKEventParamter");
			AttachPointName = null;
			AkEvent = default(TSoftObject<UAkAudioEvent>);
			AkStopEvent = default(TSoftObject<UAkAudioEvent>);
			Follow = false;
			EventName = null;
		}
		else
		{
			AttachPointName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, AttachPointName_Offset));
			AkEvent = TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEvent_Offset));
			AkStopEvent = TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkStopEvent_Offset));
			Follow = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Follow_Offset), 0, Follow_PropertyAddress.Address);
			EventName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, EventName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FAKEventParamter");
		FAKEventParamter_StructSize = NativeReflection.GetStructSize(intPtr);
		AttachPointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachPointName");
		AttachPointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachPointName", Classes.FStrProperty);
		AkEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEvent");
		AkEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEvent", Classes.FSoftObjectProperty);
		AkStopEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkStopEvent");
		AkStopEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkStopEvent", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref Follow_PropertyAddress, intPtr, "Follow");
		Follow_Offset = NativeReflection.GetPropertyOffset(intPtr, "Follow");
		Follow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Follow", Classes.FBoolProperty);
		EventName_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventName");
		EventName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventName", Classes.FStrProperty);
		FAKEventParamter_IsValid = ((intPtr != IntPtr.Zero && AttachPointName_IsValid && AkEvent_IsValid && AkStopEvent_IsValid && Follow_IsValid && EventName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FAKEventParamter", (byte)FAKEventParamter_IsValid != 0);
	}

	static FAKEventParamter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAKEventParamter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAKEventParamter));
	}
}
