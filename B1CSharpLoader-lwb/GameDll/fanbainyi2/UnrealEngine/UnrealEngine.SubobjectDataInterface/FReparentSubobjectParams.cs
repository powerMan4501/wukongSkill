using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.SubobjectDataInterface;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SubobjectDataInterface.ReparentSubobjectParams", "SubobjectDataInterface", UnrealModuleType.Engine)]
public struct FReparentSubobjectParams
{
	private static bool NewParentHandle_IsValid;

	private static int NewParentHandle_Offset;

	[UProperty(Flags = (PropFlags)6755399441055748uL)]
	[UMetaPath("/Script/SubobjectDataInterface.ReparentSubobjectParams:NewParentHandle")]
	public FSubobjectDataHandle NewParentHandle;

	private static bool BlueprintContext_IsValid;

	private static int BlueprintContext_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/SubobjectDataInterface.ReparentSubobjectParams:BlueprintContext")]
	public UBlueprint BlueprintContext;

	private static bool ActorPreviewContext_IsValid;

	private static int ActorPreviewContext_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/SubobjectDataInterface.ReparentSubobjectParams:ActorPreviewContext")]
	public AActor ActorPreviewContext;

	private static bool FReparentSubobjectParams_IsValid;

	private static int FReparentSubobjectParams_StructSize;

	public FReparentSubobjectParams Copy()
	{
		return this;
	}

	public static FReparentSubobjectParams FromNative(IntPtr nativeBuffer)
	{
		return new FReparentSubobjectParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FReparentSubobjectParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FReparentSubobjectParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FReparentSubobjectParams(nativeBuffer + arrayIndex * FReparentSubobjectParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FReparentSubobjectParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FReparentSubobjectParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FReparentSubobjectParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SubobjectDataInterface.ReparentSubobjectParams");
			return;
		}
		FSubobjectDataHandle.ToNative(IntPtr.Add(nativeStruct, NewParentHandle_Offset), NewParentHandle);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(nativeStruct, BlueprintContext_Offset), BlueprintContext);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, ActorPreviewContext_Offset), ActorPreviewContext);
	}

	public FReparentSubobjectParams(IntPtr nativeStruct)
	{
		if (!FReparentSubobjectParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SubobjectDataInterface.ReparentSubobjectParams");
			NewParentHandle = default(FSubobjectDataHandle);
			BlueprintContext = null;
			ActorPreviewContext = null;
		}
		else
		{
			NewParentHandle = FSubobjectDataHandle.FromNative(IntPtr.Add(nativeStruct, NewParentHandle_Offset));
			BlueprintContext = UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(nativeStruct, BlueprintContext_Offset));
			ActorPreviewContext = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, ActorPreviewContext_Offset));
		}
	}

	static FReparentSubobjectParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FReparentSubobjectParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FReparentSubobjectParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SubobjectDataInterface.ReparentSubobjectParams");
		FReparentSubobjectParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NewParentHandle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewParentHandle");
		NewParentHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewParentHandle", Classes.FStructProperty);
		BlueprintContext_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlueprintContext");
		BlueprintContext_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlueprintContext", Classes.FObjectProperty);
		ActorPreviewContext_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorPreviewContext");
		ActorPreviewContext_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorPreviewContext", Classes.FObjectProperty);
		FReparentSubobjectParams_IsValid = intPtr != IntPtr.Zero && NewParentHandle_IsValid && BlueprintContext_IsValid && ActorPreviewContext_IsValid;
		NativeReflection.LogStructIsValid("/Script/SubobjectDataInterface.ReparentSubobjectParams", FReparentSubobjectParams_IsValid);
	}
}
