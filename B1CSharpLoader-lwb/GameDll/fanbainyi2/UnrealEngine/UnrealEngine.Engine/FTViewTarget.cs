using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.TViewTarget", "Engine", UnrealModuleType.Engine)]
public struct FTViewTarget
{
	private static bool Target_IsValid;

	private static int Target_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.TViewTarget:Target")]
	public AActor Target;

	private static bool POV_IsValid;

	private static int POV_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.TViewTarget:POV")]
	public FMinimalViewInfo POV;

	private static bool PlayerState_IsValid;

	private static int PlayerState_Offset;

	[UProperty(Flags = (PropFlags)12393764861510149uL)]
	[UMetaPath("/Script/Engine.TViewTarget:PlayerState")]
	public APlayerState PlayerState;

	private static bool FTViewTarget_IsValid;

	private static int FTViewTarget_StructSize;

	public FTViewTarget Copy()
	{
		return this;
	}

	public static FTViewTarget FromNative(IntPtr nativeBuffer)
	{
		return new FTViewTarget(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTViewTarget value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTViewTarget FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTViewTarget(nativeBuffer + arrayIndex * FTViewTarget_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTViewTarget value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTViewTarget_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTViewTarget_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TViewTarget");
			return;
		}
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Target_Offset), Target);
		FMinimalViewInfo.ToNative(IntPtr.Add(nativeStruct, POV_Offset), POV);
		UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(nativeStruct, PlayerState_Offset), PlayerState);
	}

	public FTViewTarget(IntPtr nativeStruct)
	{
		if (!FTViewTarget_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TViewTarget");
			Target = null;
			POV = default(FMinimalViewInfo);
			PlayerState = null;
		}
		else
		{
			Target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Target_Offset));
			POV = FMinimalViewInfo.FromNative(IntPtr.Add(nativeStruct, POV_Offset));
			PlayerState = UObjectMarshaler<APlayerState>.FromNative(IntPtr.Add(nativeStruct, PlayerState_Offset));
		}
	}

	static FTViewTarget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTViewTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTViewTarget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TViewTarget");
		FTViewTarget_StructSize = NativeReflection.GetStructSize(intPtr);
		Target_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Target");
		Target_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Target", Classes.FObjectProperty);
		POV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "POV");
		POV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "POV", Classes.FStructProperty);
		PlayerState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerState");
		PlayerState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerState", Classes.FObjectProperty);
		FTViewTarget_IsValid = intPtr != IntPtr.Zero && Target_IsValid && POV_IsValid && PlayerState_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.TViewTarget", FTViewTarget_IsValid);
	}
}
