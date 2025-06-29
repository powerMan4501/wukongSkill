using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.BGU_AIMoverRequest", "b1", UnrealModuleType.Game)]
public struct FBGU_AIMoverRequest
{
	private static bool AllowPartialPath_IsValid;

	private static FFieldAddress AllowPartialPath_PropertyAddress;

	private static int AllowPartialPath_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGU_AIMoverRequest:AllowPartialPath")]
	public bool AllowPartialPath;

	private static bool CanStrafe_IsValid;

	private static FFieldAddress CanStrafe_PropertyAddress;

	private static int CanStrafe_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGU_AIMoverRequest:CanStrafe")]
	public bool CanStrafe;

	private static bool ReachTestIncludesAgentRadius_IsValid;

	private static FFieldAddress ReachTestIncludesAgentRadius_PropertyAddress;

	private static int ReachTestIncludesAgentRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGU_AIMoverRequest:ReachTestIncludesAgentRadius")]
	public bool ReachTestIncludesAgentRadius;

	private static bool ReachTestIncludesGoalRadius_IsValid;

	private static FFieldAddress ReachTestIncludesGoalRadius_PropertyAddress;

	private static int ReachTestIncludesGoalRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGU_AIMoverRequest:ReachTestIncludesGoalRadius")]
	public bool ReachTestIncludesGoalRadius;

	private static bool ProjectGoalLocation_IsValid;

	private static FFieldAddress ProjectGoalLocation_PropertyAddress;

	private static int ProjectGoalLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGU_AIMoverRequest:ProjectGoalLocation")]
	public bool ProjectGoalLocation;

	private static bool UsePathfinding_IsValid;

	private static FFieldAddress UsePathfinding_PropertyAddress;

	private static int UsePathfinding_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGU_AIMoverRequest:UsePathfinding")]
	public bool UsePathfinding;

	private static bool AcceptanceRadius_IsValid;

	private static int AcceptanceRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGU_AIMoverRequest:AcceptanceRadius")]
	public float AcceptanceRadius;

	private static bool TargetActor_IsValid;

	private static int TargetActor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGU_AIMoverRequest:TargetActor")]
	public AActor TargetActor;

	private static bool TargetLocation_IsValid;

	private static int TargetLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGU_AIMoverRequest:TargetLocation")]
	public FVector TargetLocation;

	private static bool FBGU_AIMoverRequest_IsValid;

	private static int FBGU_AIMoverRequest_StructSize;

	public FBGU_AIMoverRequest Copy()
	{
		return this;
	}

	public static FBGU_AIMoverRequest FromNative(IntPtr nativeBuffer)
	{
		return new FBGU_AIMoverRequest(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGU_AIMoverRequest value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGU_AIMoverRequest FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGU_AIMoverRequest(nativeBuffer + arrayIndex * FBGU_AIMoverRequest_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGU_AIMoverRequest value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBGU_AIMoverRequest_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBGU_AIMoverRequest_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGU_AIMoverRequest");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowPartialPath_Offset), 0, AllowPartialPath_PropertyAddress.Address, AllowPartialPath);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanStrafe_Offset), 0, CanStrafe_PropertyAddress.Address, CanStrafe);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ReachTestIncludesAgentRadius_Offset), 0, ReachTestIncludesAgentRadius_PropertyAddress.Address, ReachTestIncludesAgentRadius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ReachTestIncludesGoalRadius_Offset), 0, ReachTestIncludesGoalRadius_PropertyAddress.Address, ReachTestIncludesGoalRadius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ProjectGoalLocation_Offset), 0, ProjectGoalLocation_PropertyAddress.Address, ProjectGoalLocation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UsePathfinding_Offset), 0, UsePathfinding_PropertyAddress.Address, UsePathfinding);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AcceptanceRadius_Offset), AcceptanceRadius);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, TargetActor_Offset), TargetActor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, TargetLocation_Offset), TargetLocation);
	}

	public FBGU_AIMoverRequest(IntPtr nativeStruct)
	{
		if (!FBGU_AIMoverRequest_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BGU_AIMoverRequest");
			AllowPartialPath = false;
			CanStrafe = false;
			ReachTestIncludesAgentRadius = false;
			ReachTestIncludesGoalRadius = false;
			ProjectGoalLocation = false;
			UsePathfinding = false;
			AcceptanceRadius = 0f;
			TargetActor = null;
			TargetLocation = default(FVector);
		}
		else
		{
			AllowPartialPath = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowPartialPath_Offset), 0, AllowPartialPath_PropertyAddress.Address);
			CanStrafe = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanStrafe_Offset), 0, CanStrafe_PropertyAddress.Address);
			ReachTestIncludesAgentRadius = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ReachTestIncludesAgentRadius_Offset), 0, ReachTestIncludesAgentRadius_PropertyAddress.Address);
			ReachTestIncludesGoalRadius = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ReachTestIncludesGoalRadius_Offset), 0, ReachTestIncludesGoalRadius_PropertyAddress.Address);
			ProjectGoalLocation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ProjectGoalLocation_Offset), 0, ProjectGoalLocation_PropertyAddress.Address);
			UsePathfinding = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UsePathfinding_Offset), 0, UsePathfinding_PropertyAddress.Address);
			AcceptanceRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AcceptanceRadius_Offset));
			TargetActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, TargetActor_Offset));
			TargetLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, TargetLocation_Offset));
		}
	}

	static FBGU_AIMoverRequest()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBGU_AIMoverRequest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGU_AIMoverRequest));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.BGU_AIMoverRequest");
		FBGU_AIMoverRequest_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AllowPartialPath_PropertyAddress, intPtr, "AllowPartialPath");
		AllowPartialPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AllowPartialPath");
		AllowPartialPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AllowPartialPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanStrafe_PropertyAddress, intPtr, "CanStrafe");
		CanStrafe_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanStrafe");
		CanStrafe_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanStrafe", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReachTestIncludesAgentRadius_PropertyAddress, intPtr, "ReachTestIncludesAgentRadius");
		ReachTestIncludesAgentRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReachTestIncludesAgentRadius");
		ReachTestIncludesAgentRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReachTestIncludesAgentRadius", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReachTestIncludesGoalRadius_PropertyAddress, intPtr, "ReachTestIncludesGoalRadius");
		ReachTestIncludesGoalRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReachTestIncludesGoalRadius");
		ReachTestIncludesGoalRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReachTestIncludesGoalRadius", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectGoalLocation_PropertyAddress, intPtr, "ProjectGoalLocation");
		ProjectGoalLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProjectGoalLocation");
		ProjectGoalLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProjectGoalLocation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsePathfinding_PropertyAddress, intPtr, "UsePathfinding");
		UsePathfinding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UsePathfinding");
		UsePathfinding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UsePathfinding", Classes.FBoolProperty);
		AcceptanceRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AcceptanceRadius");
		AcceptanceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AcceptanceRadius", Classes.FFloatProperty);
		TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetActor");
		TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetActor", Classes.FObjectProperty);
		TargetLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetLocation");
		TargetLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetLocation", Classes.FStructProperty);
		FBGU_AIMoverRequest_IsValid = intPtr != IntPtr.Zero && AllowPartialPath_IsValid && CanStrafe_IsValid && ReachTestIncludesAgentRadius_IsValid && ReachTestIncludesGoalRadius_IsValid && ProjectGoalLocation_IsValid && UsePathfinding_IsValid && AcceptanceRadius_IsValid && TargetActor_IsValid && TargetLocation_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.BGU_AIMoverRequest", FBGU_AIMoverRequest_IsValid);
	}
}
