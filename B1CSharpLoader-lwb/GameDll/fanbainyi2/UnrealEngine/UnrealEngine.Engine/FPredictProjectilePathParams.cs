using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.PredictProjectilePathParams", "Engine", UnrealModuleType.Engine)]
public struct FPredictProjectilePathParams
{
	private static bool StartLocation_IsValid;

	private static int StartLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:StartLocation")]
	public FVector StartLocation;

	private static bool LaunchVelocity_IsValid;

	private static int LaunchVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:LaunchVelocity")]
	public FVector LaunchVelocity;

	private static bool TraceWithCollision_IsValid;

	private static FFieldAddress TraceWithCollision_PropertyAddress;

	private static int TraceWithCollision_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:bTraceWithCollision")]
	public bool TraceWithCollision;

	private static bool ProjectileRadius_IsValid;

	private static int ProjectileRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:ProjectileRadius")]
	public float ProjectileRadius;

	private static bool MaxSimTime_IsValid;

	private static int MaxSimTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:MaxSimTime")]
	public float MaxSimTime;

	private static bool TraceWithChannel_IsValid;

	private static FFieldAddress TraceWithChannel_PropertyAddress;

	private static int TraceWithChannel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:bTraceWithChannel")]
	public bool TraceWithChannel;

	private static bool TraceChannel_IsValid;

	private static FFieldAddress TraceChannel_PropertyAddress;

	private static int TraceChannel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:TraceChannel")]
	public ECollisionChannel TraceChannel;

	private static bool ObjectTypes_IsValid;

	private static FFieldAddress ObjectTypes_PropertyAddress;

	private static int ObjectTypes_Offset;

	[UProperty(Flags = (PropFlags)4507997673882117uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:ObjectTypes")]
	public List<EObjectTypeQuery> ObjectTypes;

	private static bool ActorsToIgnore_IsValid;

	private static FFieldAddress ActorsToIgnore_PropertyAddress;

	private static int ActorsToIgnore_Offset;

	[UProperty(Flags = (PropFlags)5633897580724741uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:ActorsToIgnore")]
	public List<AActor> ActorsToIgnore;

	private static bool SimFrequency_IsValid;

	private static int SimFrequency_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:SimFrequency")]
	public float SimFrequency;

	private static bool OverrideGravityZ_IsValid;

	private static int OverrideGravityZ_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:OverrideGravityZ")]
	public float OverrideGravityZ;

	private static bool DrawDebugType_IsValid;

	private static FFieldAddress DrawDebugType_PropertyAddress;

	private static int DrawDebugType_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:DrawDebugType")]
	public EDrawDebugTrace DrawDebugType;

	private static bool DrawDebugTime_IsValid;

	private static int DrawDebugTime_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:DrawDebugTime")]
	public float DrawDebugTime;

	private static bool TraceComplex_IsValid;

	private static FFieldAddress TraceComplex_PropertyAddress;

	private static int TraceComplex_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathParams:bTraceComplex")]
	public bool TraceComplex;

	private static bool FPredictProjectilePathParams_IsValid;

	private static int FPredictProjectilePathParams_StructSize;

	public FPredictProjectilePathParams Copy()
	{
		FPredictProjectilePathParams result = this;
		if (ObjectTypes != null)
		{
			result.ObjectTypes = new List<EObjectTypeQuery>(ObjectTypes);
		}
		if (ActorsToIgnore != null)
		{
			result.ActorsToIgnore = new List<AActor>(ActorsToIgnore);
		}
		return result;
	}

	public static FPredictProjectilePathParams FromNative(IntPtr nativeBuffer)
	{
		return new FPredictProjectilePathParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPredictProjectilePathParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPredictProjectilePathParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPredictProjectilePathParams(nativeBuffer + arrayIndex * FPredictProjectilePathParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPredictProjectilePathParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPredictProjectilePathParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPredictProjectilePathParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PredictProjectilePathParams");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, StartLocation_Offset), StartLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LaunchVelocity_Offset), LaunchVelocity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TraceWithCollision_Offset), 0, TraceWithCollision_PropertyAddress.Address, TraceWithCollision);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ProjectileRadius_Offset), ProjectileRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxSimTime_Offset), MaxSimTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TraceWithChannel_Offset), 0, TraceWithChannel_PropertyAddress.Address, TraceWithChannel);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(nativeStruct, TraceChannel_Offset), 0, TraceChannel_PropertyAddress.Address, TraceChannel);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ObjectTypes_Offset), ObjectTypes);
		new TArrayCopyMarshaler<AActor>(1, ActorsToIgnore_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ActorsToIgnore_Offset), ActorsToIgnore);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SimFrequency_Offset), SimFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OverrideGravityZ_Offset), OverrideGravityZ);
		EnumMarshaler<EDrawDebugTrace>.ToNative(IntPtr.Add(nativeStruct, DrawDebugType_Offset), 0, DrawDebugType_PropertyAddress.Address, DrawDebugType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DrawDebugTime_Offset), DrawDebugTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TraceComplex_Offset), 0, TraceComplex_PropertyAddress.Address, TraceComplex);
	}

	public FPredictProjectilePathParams(IntPtr nativeStruct)
	{
		if (!FPredictProjectilePathParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PredictProjectilePathParams");
			StartLocation = default(FVector);
			LaunchVelocity = default(FVector);
			TraceWithCollision = false;
			ProjectileRadius = 0f;
			MaxSimTime = 0f;
			TraceWithChannel = false;
			TraceChannel = ECollisionChannel.ECC_WorldStatic;
			ObjectTypes = null;
			ActorsToIgnore = null;
			SimFrequency = 0f;
			OverrideGravityZ = 0f;
			DrawDebugType = EDrawDebugTrace.None;
			DrawDebugTime = 0f;
			TraceComplex = false;
		}
		else
		{
			StartLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, StartLocation_Offset));
			LaunchVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LaunchVelocity_Offset));
			TraceWithCollision = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TraceWithCollision_Offset), 0, TraceWithCollision_PropertyAddress.Address);
			ProjectileRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ProjectileRadius_Offset));
			MaxSimTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxSimTime_Offset));
			TraceWithChannel = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TraceWithChannel_Offset), 0, TraceWithChannel_PropertyAddress.Address);
			TraceChannel = EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(nativeStruct, TraceChannel_Offset), 0, TraceChannel_PropertyAddress.Address);
			ObjectTypes = new TArrayCopyMarshaler<EObjectTypeQuery>(1, ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ObjectTypes_Offset));
			ActorsToIgnore = new TArrayCopyMarshaler<AActor>(1, ActorsToIgnore_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ActorsToIgnore_Offset));
			SimFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SimFrequency_Offset));
			OverrideGravityZ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OverrideGravityZ_Offset));
			DrawDebugType = EnumMarshaler<EDrawDebugTrace>.FromNative(IntPtr.Add(nativeStruct, DrawDebugType_Offset), 0, DrawDebugType_PropertyAddress.Address);
			DrawDebugTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DrawDebugTime_Offset));
			TraceComplex = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TraceComplex_Offset), 0, TraceComplex_PropertyAddress.Address);
		}
	}

	static FPredictProjectilePathParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPredictProjectilePathParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPredictProjectilePathParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PredictProjectilePathParams");
		FPredictProjectilePathParams_StructSize = NativeReflection.GetStructSize(intPtr);
		StartLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartLocation");
		StartLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartLocation", Classes.FStructProperty);
		LaunchVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LaunchVelocity");
		LaunchVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LaunchVelocity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceWithCollision_PropertyAddress, intPtr, "bTraceWithCollision");
		TraceWithCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTraceWithCollision");
		TraceWithCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTraceWithCollision", Classes.FBoolProperty);
		ProjectileRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProjectileRadius");
		ProjectileRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProjectileRadius", Classes.FFloatProperty);
		MaxSimTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSimTime");
		MaxSimTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSimTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceWithChannel_PropertyAddress, intPtr, "bTraceWithChannel");
		TraceWithChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTraceWithChannel");
		TraceWithChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTraceWithChannel", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceChannel_PropertyAddress, intPtr, "TraceChannel");
		TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TraceChannel");
		TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectTypes_PropertyAddress, intPtr, "ObjectTypes");
		ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectTypes");
		ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorsToIgnore_PropertyAddress, intPtr, "ActorsToIgnore");
		ActorsToIgnore_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorsToIgnore");
		ActorsToIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorsToIgnore", Classes.FArrayProperty);
		SimFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimFrequency");
		SimFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimFrequency", Classes.FFloatProperty);
		OverrideGravityZ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverrideGravityZ");
		OverrideGravityZ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverrideGravityZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugType_PropertyAddress, intPtr, "DrawDebugType");
		DrawDebugType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawDebugType");
		DrawDebugType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawDebugType", Classes.FByteProperty);
		DrawDebugTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawDebugTime");
		DrawDebugTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawDebugTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TraceComplex_PropertyAddress, intPtr, "bTraceComplex");
		TraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTraceComplex");
		TraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTraceComplex", Classes.FBoolProperty);
		FPredictProjectilePathParams_IsValid = intPtr != IntPtr.Zero && StartLocation_IsValid && LaunchVelocity_IsValid && TraceWithCollision_IsValid && ProjectileRadius_IsValid && MaxSimTime_IsValid && TraceWithChannel_IsValid && TraceChannel_IsValid && ObjectTypes_IsValid && ActorsToIgnore_IsValid && SimFrequency_IsValid && OverrideGravityZ_IsValid && DrawDebugType_IsValid && DrawDebugTime_IsValid && TraceComplex_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.PredictProjectilePathParams", FPredictProjectilePathParams_IsValid);
	}
}
