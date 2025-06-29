using System;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 513)]
[BlueprintType]
[UMetaPath("/Script/Engine.BodyInstance", "Engine", UnrealModuleType.Engine)]
public struct FBodyInstance
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

	private static bool SleepFamily_IsValid;

	private static FFieldAddress SleepFamily_PropertyAddress;

	private static int SleepFamily_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.BodyInstance:SleepFamily")]
	public ESleepFamily SleepFamily;

	private static bool UseCCD_IsValid;

	private static FFieldAddress UseCCD_PropertyAddress;

	private static int UseCCD_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.BodyInstance:bUseCCD")]
	public bool UseCCD;

	private static bool IgnoreAnalyticCollisions_IsValid;

	private static FFieldAddress IgnoreAnalyticCollisions_PropertyAddress;

	private static int IgnoreAnalyticCollisions_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.BodyInstance:bIgnoreAnalyticCollisions")]
	public bool IgnoreAnalyticCollisions;

	private static bool NotifyRigidBodyCollision_IsValid;

	private static FFieldAddress NotifyRigidBodyCollision_PropertyAddress;

	private static int NotifyRigidBodyCollision_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.BodyInstance:bNotifyRigidBodyCollision")]
	public bool NotifyRigidBodyCollision;

	private static bool SmoothEdgeCollisions_IsValid;

	private static FFieldAddress SmoothEdgeCollisions_PropertyAddress;

	private static int SmoothEdgeCollisions_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.BodyInstance:bSmoothEdgeCollisions")]
	public bool SmoothEdgeCollisions;

	private static bool PositionSolverIterationCount_IsValid;

	private static int PositionSolverIterationCount_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.BodyInstance:PositionSolverIterationCount")]
	public byte PositionSolverIterationCount;

	private static bool VelocitySolverIterationCount_IsValid;

	private static int VelocitySolverIterationCount_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.BodyInstance:VelocitySolverIterationCount")]
	public byte VelocitySolverIterationCount;

	private static bool MaxDepenetrationVelocity_IsValid;

	private static int MaxDepenetrationVelocity_Offset;

	[UProperty(Flags = (PropFlags)11272263001178645uL)]
	[UMetaPath("/Script/Engine.BodyInstance:MaxDepenetrationVelocity")]
	public float MaxDepenetrationVelocity;

	private static bool MassInKgOverride_IsValid;

	private static int MassInKgOverride_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.BodyInstance:MassInKgOverride")]
	public float MassInKgOverride;

	private static bool LinearDamping_IsValid;

	private static int LinearDamping_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BodyInstance:LinearDamping")]
	public float LinearDamping;

	private static bool AngularDamping_IsValid;

	private static int AngularDamping_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BodyInstance:AngularDamping")]
	public float AngularDamping;

	private static bool COMNudge_IsValid;

	private static int COMNudge_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.BodyInstance:COMNudge")]
	public FVector COMNudge;

	private static bool MassScale_IsValid;

	private static int MassScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.BodyInstance:MassScale")]
	public float MassScale;

	private static bool InertiaTensorScale_IsValid;

	private static int InertiaTensorScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.BodyInstance:InertiaTensorScale")]
	public FVector InertiaTensorScale;

	private static bool WalkableSlopeOverride_IsValid;

	private static int WalkableSlopeOverride_Offset;

	[UProperty(Flags = (PropFlags)9020463187492885uL)]
	[UMetaPath("/Script/Engine.BodyInstance:WalkableSlopeOverride")]
	public FWalkableSlopeOverride WalkableSlopeOverride;

	private static bool PhysMaterialOverride_IsValid;

	private static int PhysMaterialOverride_Offset;

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/Engine.BodyInstance:PhysMaterialOverride")]
	public UPhysicalMaterial PhysMaterialOverride;

	private static bool MaxAngularVelocity_IsValid;

	private static int MaxAngularVelocity_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.BodyInstance:MaxAngularVelocity")]
	public float MaxAngularVelocity;

	private static bool CustomSleepThresholdMultiplier_IsValid;

	private static int CustomSleepThresholdMultiplier_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.BodyInstance:CustomSleepThresholdMultiplier")]
	public float CustomSleepThresholdMultiplier;

	private static bool StabilizationThresholdMultiplier_IsValid;

	private static int StabilizationThresholdMultiplier_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.BodyInstance:StabilizationThresholdMultiplier")]
	public float StabilizationThresholdMultiplier;

	private static bool FBodyInstance_IsValid;

	private static int FBodyInstance_StructSize;

	public FBodyInstance Copy()
	{
		return this;
	}

	public static FBodyInstance FromNative(IntPtr nativeBuffer)
	{
		return new FBodyInstance(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBodyInstance value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBodyInstance FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBodyInstance(nativeBuffer + arrayIndex * FBodyInstance_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBodyInstance value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBodyInstance_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBodyInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BodyInstance");
			return;
		}
		EnumMarshaler<ESleepFamily>.ToNative(IntPtr.Add(nativeStruct, SleepFamily_Offset), 0, SleepFamily_PropertyAddress.Address, SleepFamily);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseCCD_Offset), 0, UseCCD_PropertyAddress.Address, UseCCD);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreAnalyticCollisions_Offset), 0, IgnoreAnalyticCollisions_PropertyAddress.Address, IgnoreAnalyticCollisions);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NotifyRigidBodyCollision_Offset), 0, NotifyRigidBodyCollision_PropertyAddress.Address, NotifyRigidBodyCollision);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SmoothEdgeCollisions_Offset), 0, SmoothEdgeCollisions_PropertyAddress.Address, SmoothEdgeCollisions);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, PositionSolverIterationCount_Offset), PositionSolverIterationCount);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(nativeStruct, VelocitySolverIterationCount_Offset), VelocitySolverIterationCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDepenetrationVelocity_Offset), MaxDepenetrationVelocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MassInKgOverride_Offset), MassInKgOverride);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LinearDamping_Offset), LinearDamping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AngularDamping_Offset), AngularDamping);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, COMNudge_Offset), COMNudge);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MassScale_Offset), MassScale);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, InertiaTensorScale_Offset), InertiaTensorScale);
		BlittableTypeMarshaler<FWalkableSlopeOverride>.ToNative(IntPtr.Add(nativeStruct, WalkableSlopeOverride_Offset), WalkableSlopeOverride);
		UObjectMarshaler<UPhysicalMaterial>.ToNative(IntPtr.Add(nativeStruct, PhysMaterialOverride_Offset), PhysMaterialOverride);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxAngularVelocity_Offset), MaxAngularVelocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CustomSleepThresholdMultiplier_Offset), CustomSleepThresholdMultiplier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StabilizationThresholdMultiplier_Offset), StabilizationThresholdMultiplier);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SimulatePhysics_Offset), 0, SimulatePhysics_PropertyAddress.Address, SimulatePhysics);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableGravity_Offset), 0, EnableGravity_PropertyAddress.Address, EnableGravity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoWeld_Offset), 0, AutoWeld_PropertyAddress.Address, AutoWeld);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, StartAwake_Offset), 0, StartAwake_PropertyAddress.Address, StartAwake);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateWakeEvents_Offset), 0, GenerateWakeEvents_PropertyAddress.Address, GenerateWakeEvents);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UpdateMassWhenScaleChanges_Offset), 0, UpdateMassWhenScaleChanges_PropertyAddress.Address, UpdateMassWhenScaleChanges);
	}

	public FBodyInstance(IntPtr nativeStruct)
	{
		if (!FBodyInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.BodyInstance");
			SleepFamily = ESleepFamily.Normal;
			UseCCD = false;
			IgnoreAnalyticCollisions = false;
			NotifyRigidBodyCollision = false;
			SmoothEdgeCollisions = false;
			PositionSolverIterationCount = 0;
			VelocitySolverIterationCount = 0;
			MaxDepenetrationVelocity = 0f;
			MassInKgOverride = 0f;
			LinearDamping = 0f;
			AngularDamping = 0f;
			COMNudge = default(FVector);
			MassScale = 0f;
			InertiaTensorScale = default(FVector);
			WalkableSlopeOverride = default(FWalkableSlopeOverride);
			PhysMaterialOverride = null;
			MaxAngularVelocity = 0f;
			CustomSleepThresholdMultiplier = 0f;
			StabilizationThresholdMultiplier = 0f;
			SimulatePhysics = false;
			EnableGravity = false;
			AutoWeld = false;
			StartAwake = false;
			GenerateWakeEvents = false;
			UpdateMassWhenScaleChanges = false;
		}
		else
		{
			SleepFamily = EnumMarshaler<ESleepFamily>.FromNative(IntPtr.Add(nativeStruct, SleepFamily_Offset), 0, SleepFamily_PropertyAddress.Address);
			UseCCD = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseCCD_Offset), 0, UseCCD_PropertyAddress.Address);
			IgnoreAnalyticCollisions = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreAnalyticCollisions_Offset), 0, IgnoreAnalyticCollisions_PropertyAddress.Address);
			NotifyRigidBodyCollision = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NotifyRigidBodyCollision_Offset), 0, NotifyRigidBodyCollision_PropertyAddress.Address);
			SmoothEdgeCollisions = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SmoothEdgeCollisions_Offset), 0, SmoothEdgeCollisions_PropertyAddress.Address);
			PositionSolverIterationCount = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, PositionSolverIterationCount_Offset));
			VelocitySolverIterationCount = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(nativeStruct, VelocitySolverIterationCount_Offset));
			MaxDepenetrationVelocity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDepenetrationVelocity_Offset));
			MassInKgOverride = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MassInKgOverride_Offset));
			LinearDamping = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LinearDamping_Offset));
			AngularDamping = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AngularDamping_Offset));
			COMNudge = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, COMNudge_Offset));
			MassScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MassScale_Offset));
			InertiaTensorScale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, InertiaTensorScale_Offset));
			WalkableSlopeOverride = BlittableTypeMarshaler<FWalkableSlopeOverride>.FromNative(IntPtr.Add(nativeStruct, WalkableSlopeOverride_Offset));
			PhysMaterialOverride = UObjectMarshaler<UPhysicalMaterial>.FromNative(IntPtr.Add(nativeStruct, PhysMaterialOverride_Offset));
			MaxAngularVelocity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxAngularVelocity_Offset));
			CustomSleepThresholdMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CustomSleepThresholdMultiplier_Offset));
			StabilizationThresholdMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StabilizationThresholdMultiplier_Offset));
			SimulatePhysics = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SimulatePhysics_Offset), 0, SimulatePhysics_PropertyAddress.Address);
			EnableGravity = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableGravity_Offset), 0, EnableGravity_PropertyAddress.Address);
			AutoWeld = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoWeld_Offset), 0, AutoWeld_PropertyAddress.Address);
			StartAwake = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, StartAwake_Offset), 0, StartAwake_PropertyAddress.Address);
			GenerateWakeEvents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateWakeEvents_Offset), 0, GenerateWakeEvents_PropertyAddress.Address);
			UpdateMassWhenScaleChanges = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UpdateMassWhenScaleChanges_Offset), 0, UpdateMassWhenScaleChanges_PropertyAddress.Address);
		}
	}

	static FBodyInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBodyInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBodyInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.BodyInstance");
		FBodyInstance_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflectionCached.GetPropertyRef(ref SleepFamily_PropertyAddress, intPtr, "SleepFamily");
		SleepFamily_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SleepFamily");
		SleepFamily_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SleepFamily", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UseCCD_PropertyAddress, intPtr, "bUseCCD");
		UseCCD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseCCD");
		UseCCD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseCCD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreAnalyticCollisions_PropertyAddress, intPtr, "bIgnoreAnalyticCollisions");
		IgnoreAnalyticCollisions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreAnalyticCollisions");
		IgnoreAnalyticCollisions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreAnalyticCollisions", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyRigidBodyCollision_PropertyAddress, intPtr, "bNotifyRigidBodyCollision");
		NotifyRigidBodyCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNotifyRigidBodyCollision");
		NotifyRigidBodyCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNotifyRigidBodyCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SmoothEdgeCollisions_PropertyAddress, intPtr, "bSmoothEdgeCollisions");
		SmoothEdgeCollisions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSmoothEdgeCollisions");
		SmoothEdgeCollisions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSmoothEdgeCollisions", Classes.FBoolProperty);
		PositionSolverIterationCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositionSolverIterationCount");
		PositionSolverIterationCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositionSolverIterationCount", Classes.FByteProperty);
		VelocitySolverIterationCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VelocitySolverIterationCount");
		VelocitySolverIterationCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VelocitySolverIterationCount", Classes.FByteProperty);
		MaxDepenetrationVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDepenetrationVelocity");
		MaxDepenetrationVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDepenetrationVelocity", Classes.FFloatProperty);
		MassInKgOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MassInKgOverride");
		MassInKgOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MassInKgOverride", Classes.FFloatProperty);
		LinearDamping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearDamping");
		LinearDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearDamping", Classes.FFloatProperty);
		AngularDamping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularDamping");
		AngularDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularDamping", Classes.FFloatProperty);
		COMNudge_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "COMNudge");
		COMNudge_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "COMNudge", Classes.FStructProperty);
		MassScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MassScale");
		MassScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MassScale", Classes.FFloatProperty);
		InertiaTensorScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InertiaTensorScale");
		InertiaTensorScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InertiaTensorScale", Classes.FStructProperty);
		WalkableSlopeOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WalkableSlopeOverride");
		WalkableSlopeOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WalkableSlopeOverride", Classes.FStructProperty);
		PhysMaterialOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysMaterialOverride");
		PhysMaterialOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysMaterialOverride", Classes.FObjectProperty);
		MaxAngularVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxAngularVelocity");
		MaxAngularVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxAngularVelocity", Classes.FFloatProperty);
		CustomSleepThresholdMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomSleepThresholdMultiplier");
		CustomSleepThresholdMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomSleepThresholdMultiplier", Classes.FFloatProperty);
		StabilizationThresholdMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StabilizationThresholdMultiplier");
		StabilizationThresholdMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StabilizationThresholdMultiplier", Classes.FFloatProperty);
		FBodyInstance_IsValid = intPtr != IntPtr.Zero && SleepFamily_IsValid && UseCCD_IsValid && IgnoreAnalyticCollisions_IsValid && NotifyRigidBodyCollision_IsValid && SmoothEdgeCollisions_IsValid && PositionSolverIterationCount_IsValid && VelocitySolverIterationCount_IsValid && MaxDepenetrationVelocity_IsValid && MassInKgOverride_IsValid && LinearDamping_IsValid && AngularDamping_IsValid && COMNudge_IsValid && MassScale_IsValid && InertiaTensorScale_IsValid && WalkableSlopeOverride_IsValid && PhysMaterialOverride_IsValid && MaxAngularVelocity_IsValid && CustomSleepThresholdMultiplier_IsValid && StabilizationThresholdMultiplier_IsValid && SimulatePhysics_IsValid && EnableGravity_IsValid && AutoWeld_IsValid && StartAwake_IsValid && GenerateWakeEvents_IsValid && UpdateMassWhenScaleChanges_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.BodyInstance", FBodyInstance_IsValid);
	}
}
