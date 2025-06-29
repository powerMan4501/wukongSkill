using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PhysicsCore.BodyInstanceCore", "PhysicsCore", UnrealModuleType.Engine)]
public struct FBodyInstanceCore
{
	private static bool SimulatePhysics_IsValid;

	private static FFieldAddress SimulatePhysics_PropertyAddress;

	private static int SimulatePhysics_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/PhysicsCore.BodyInstanceCore:bSimulatePhysics")]
	public bool SimulatePhysics;

	private static bool EnableGravity_IsValid;

	private static FFieldAddress EnableGravity_PropertyAddress;

	private static int EnableGravity_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/PhysicsCore.BodyInstanceCore:bEnableGravity")]
	public bool EnableGravity;

	private static bool AutoWeld_IsValid;

	private static FFieldAddress AutoWeld_PropertyAddress;

	private static int AutoWeld_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/PhysicsCore.BodyInstanceCore:bAutoWeld")]
	public bool AutoWeld;

	private static bool StartAwake_IsValid;

	private static FFieldAddress StartAwake_PropertyAddress;

	private static int StartAwake_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/PhysicsCore.BodyInstanceCore:bStartAwake")]
	public bool StartAwake;

	private static bool GenerateWakeEvents_IsValid;

	private static FFieldAddress GenerateWakeEvents_PropertyAddress;

	private static int GenerateWakeEvents_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/PhysicsCore.BodyInstanceCore:bGenerateWakeEvents")]
	public bool GenerateWakeEvents;

	private static bool UpdateMassWhenScaleChanges_IsValid;

	private static FFieldAddress UpdateMassWhenScaleChanges_PropertyAddress;

	private static int UpdateMassWhenScaleChanges_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/PhysicsCore.BodyInstanceCore:bUpdateMassWhenScaleChanges")]
	public bool UpdateMassWhenScaleChanges;

	private static bool FBodyInstanceCore_IsValid;

	private static int FBodyInstanceCore_StructSize;

	public FBodyInstanceCore Copy()
	{
		return this;
	}

	public static FBodyInstanceCore FromNative(IntPtr nativeBuffer)
	{
		return new FBodyInstanceCore(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBodyInstanceCore value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBodyInstanceCore FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBodyInstanceCore(nativeBuffer + arrayIndex * FBodyInstanceCore_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBodyInstanceCore value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBodyInstanceCore_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBodyInstanceCore_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PhysicsCore.BodyInstanceCore");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SimulatePhysics_Offset), 0, SimulatePhysics_PropertyAddress.Address, SimulatePhysics);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableGravity_Offset), 0, EnableGravity_PropertyAddress.Address, EnableGravity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoWeld_Offset), 0, AutoWeld_PropertyAddress.Address, AutoWeld);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, StartAwake_Offset), 0, StartAwake_PropertyAddress.Address, StartAwake);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateWakeEvents_Offset), 0, GenerateWakeEvents_PropertyAddress.Address, GenerateWakeEvents);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UpdateMassWhenScaleChanges_Offset), 0, UpdateMassWhenScaleChanges_PropertyAddress.Address, UpdateMassWhenScaleChanges);
	}

	public FBodyInstanceCore(IntPtr nativeStruct)
	{
		if (!FBodyInstanceCore_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PhysicsCore.BodyInstanceCore");
			SimulatePhysics = false;
			EnableGravity = false;
			AutoWeld = false;
			StartAwake = false;
			GenerateWakeEvents = false;
			UpdateMassWhenScaleChanges = false;
		}
		else
		{
			SimulatePhysics = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SimulatePhysics_Offset), 0, SimulatePhysics_PropertyAddress.Address);
			EnableGravity = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableGravity_Offset), 0, EnableGravity_PropertyAddress.Address);
			AutoWeld = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoWeld_Offset), 0, AutoWeld_PropertyAddress.Address);
			StartAwake = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, StartAwake_Offset), 0, StartAwake_PropertyAddress.Address);
			GenerateWakeEvents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateWakeEvents_Offset), 0, GenerateWakeEvents_PropertyAddress.Address);
			UpdateMassWhenScaleChanges = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UpdateMassWhenScaleChanges_Offset), 0, UpdateMassWhenScaleChanges_PropertyAddress.Address);
		}
	}

	static FBodyInstanceCore()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBodyInstanceCore)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBodyInstanceCore));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PhysicsCore.BodyInstanceCore");
		FBodyInstanceCore_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SimulatePhysics_PropertyAddress, intPtr, "bSimulatePhysics");
		SimulatePhysics_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSimulatePhysics");
		SimulatePhysics_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSimulatePhysics", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableGravity_PropertyAddress, intPtr, "bEnableGravity");
		EnableGravity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableGravity");
		EnableGravity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableGravity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoWeld_PropertyAddress, intPtr, "bAutoWeld");
		AutoWeld_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoWeld");
		AutoWeld_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoWeld", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAwake_PropertyAddress, intPtr, "bStartAwake");
		StartAwake_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStartAwake");
		StartAwake_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStartAwake", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateWakeEvents_PropertyAddress, intPtr, "bGenerateWakeEvents");
		GenerateWakeEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateWakeEvents");
		GenerateWakeEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateWakeEvents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateMassWhenScaleChanges_PropertyAddress, intPtr, "bUpdateMassWhenScaleChanges");
		UpdateMassWhenScaleChanges_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUpdateMassWhenScaleChanges");
		UpdateMassWhenScaleChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUpdateMassWhenScaleChanges", Classes.FBoolProperty);
		FBodyInstanceCore_IsValid = intPtr != IntPtr.Zero && SimulatePhysics_IsValid && EnableGravity_IsValid && AutoWeld_IsValid && StartAwake_IsValid && GenerateWakeEvents_IsValid && UpdateMassWhenScaleChanges_IsValid;
		NativeReflection.LogStructIsValid("/Script/PhysicsCore.BodyInstanceCore", FBodyInstanceCore_IsValid);
	}
}
