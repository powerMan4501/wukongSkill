using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AIModule.ActorPerceptionUpdateInfo", "AIModule", UnrealModuleType.Engine)]
public struct FActorPerceptionUpdateInfo
{
	private static bool TargetId_IsValid;

	private static int TargetId_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AIModule.ActorPerceptionUpdateInfo:TargetId")]
	public int TargetId;

	private static bool Target_IsValid;

	private static int Target_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/AIModule.ActorPerceptionUpdateInfo:Target")]
	public TWeakObject<AActor> Target;

	private static bool Stimulus_IsValid;

	private static int Stimulus_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/AIModule.ActorPerceptionUpdateInfo:Stimulus")]
	public FAIStimulus Stimulus;

	private static bool FActorPerceptionUpdateInfo_IsValid;

	private static int FActorPerceptionUpdateInfo_StructSize;

	public FActorPerceptionUpdateInfo Copy()
	{
		return this;
	}

	public static FActorPerceptionUpdateInfo FromNative(IntPtr nativeBuffer)
	{
		return new FActorPerceptionUpdateInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FActorPerceptionUpdateInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FActorPerceptionUpdateInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FActorPerceptionUpdateInfo(nativeBuffer + arrayIndex * FActorPerceptionUpdateInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FActorPerceptionUpdateInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FActorPerceptionUpdateInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FActorPerceptionUpdateInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.ActorPerceptionUpdateInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetId_Offset), TargetId);
		TWeakObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Target_Offset), Target);
		FAIStimulus.ToNative(IntPtr.Add(nativeStruct, Stimulus_Offset), Stimulus);
	}

	public FActorPerceptionUpdateInfo(IntPtr nativeStruct)
	{
		if (!FActorPerceptionUpdateInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.ActorPerceptionUpdateInfo");
			TargetId = 0;
			Target = default(TWeakObject<AActor>);
			Stimulus = default(FAIStimulus);
		}
		else
		{
			TargetId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetId_Offset));
			Target = TWeakObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Target_Offset));
			Stimulus = FAIStimulus.FromNative(IntPtr.Add(nativeStruct, Stimulus_Offset));
		}
	}

	static FActorPerceptionUpdateInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FActorPerceptionUpdateInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FActorPerceptionUpdateInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.ActorPerceptionUpdateInfo");
		FActorPerceptionUpdateInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		TargetId_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetId");
		TargetId_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetId", Classes.FIntProperty);
		Target_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Target");
		Target_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Target", Classes.FWeakObjectProperty);
		Stimulus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Stimulus");
		Stimulus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Stimulus", Classes.FStructProperty);
		FActorPerceptionUpdateInfo_IsValid = intPtr != IntPtr.Zero && TargetId_IsValid && Target_IsValid && Stimulus_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.ActorPerceptionUpdateInfo", FActorPerceptionUpdateInfo_IsValid);
	}
}
