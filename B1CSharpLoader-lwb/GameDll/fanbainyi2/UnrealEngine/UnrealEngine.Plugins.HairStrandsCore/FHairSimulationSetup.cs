using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairSimulationSetup", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairSimulationSetup
{
	private static bool ResetSimulation_IsValid;

	private static FFieldAddress ResetSimulation_PropertyAddress;

	private static int ResetSimulation_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSetup:bResetSimulation")]
	public bool ResetSimulation;

	private static bool DebugSimulation_IsValid;

	private static FFieldAddress DebugSimulation_PropertyAddress;

	private static int DebugSimulation_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSetup:bDebugSimulation")]
	public bool DebugSimulation;

	private static bool LocalSimulation_IsValid;

	private static FFieldAddress LocalSimulation_PropertyAddress;

	private static int LocalSimulation_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSetup:bLocalSimulation")]
	public bool LocalSimulation;

	private static bool LinearVelocityScale_IsValid;

	private static int LinearVelocityScale_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSetup:LinearVelocityScale")]
	public float LinearVelocityScale;

	private static bool AngularVelocityScale_IsValid;

	private static int AngularVelocityScale_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSetup:AngularVelocityScale")]
	public float AngularVelocityScale;

	private static bool LocalBone_IsValid;

	private static int LocalBone_Offset;

	[UProperty(Flags = (PropFlags)6755408030990853uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSetup:LocalBone")]
	public string LocalBone;

	private static bool TeleportDistance_IsValid;

	private static int TeleportDistance_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationSetup:TeleportDistance")]
	public float TeleportDistance;

	private static bool FHairSimulationSetup_IsValid;

	private static int FHairSimulationSetup_StructSize;

	public FHairSimulationSetup Copy()
	{
		return this;
	}

	public static FHairSimulationSetup FromNative(IntPtr nativeBuffer)
	{
		return new FHairSimulationSetup(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairSimulationSetup value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairSimulationSetup FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairSimulationSetup(nativeBuffer + arrayIndex * FHairSimulationSetup_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairSimulationSetup value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairSimulationSetup_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairSimulationSetup_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationSetup");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ResetSimulation_Offset), 0, ResetSimulation_PropertyAddress.Address, ResetSimulation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DebugSimulation_Offset), 0, DebugSimulation_PropertyAddress.Address, DebugSimulation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LocalSimulation_Offset), 0, LocalSimulation_PropertyAddress.Address, LocalSimulation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LinearVelocityScale_Offset), LinearVelocityScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AngularVelocityScale_Offset), AngularVelocityScale);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, LocalBone_Offset), LocalBone);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TeleportDistance_Offset), TeleportDistance);
	}

	public FHairSimulationSetup(IntPtr nativeStruct)
	{
		if (!FHairSimulationSetup_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationSetup");
			ResetSimulation = false;
			DebugSimulation = false;
			LocalSimulation = false;
			LinearVelocityScale = 0f;
			AngularVelocityScale = 0f;
			LocalBone = FStringMarshaler.DefaultString;
			TeleportDistance = 0f;
		}
		else
		{
			ResetSimulation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ResetSimulation_Offset), 0, ResetSimulation_PropertyAddress.Address);
			DebugSimulation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DebugSimulation_Offset), 0, DebugSimulation_PropertyAddress.Address);
			LocalSimulation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LocalSimulation_Offset), 0, LocalSimulation_PropertyAddress.Address);
			LinearVelocityScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LinearVelocityScale_Offset));
			AngularVelocityScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AngularVelocityScale_Offset));
			LocalBone = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, LocalBone_Offset));
			TeleportDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TeleportDistance_Offset));
		}
	}

	static FHairSimulationSetup()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairSimulationSetup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairSimulationSetup));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairSimulationSetup");
		FHairSimulationSetup_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ResetSimulation_PropertyAddress, intPtr, "bResetSimulation");
		ResetSimulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bResetSimulation");
		ResetSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bResetSimulation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DebugSimulation_PropertyAddress, intPtr, "bDebugSimulation");
		DebugSimulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDebugSimulation");
		DebugSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDebugSimulation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalSimulation_PropertyAddress, intPtr, "bLocalSimulation");
		LocalSimulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLocalSimulation");
		LocalSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLocalSimulation", Classes.FBoolProperty);
		LinearVelocityScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearVelocityScale");
		LinearVelocityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearVelocityScale", Classes.FFloatProperty);
		AngularVelocityScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularVelocityScale");
		AngularVelocityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularVelocityScale", Classes.FFloatProperty);
		LocalBone_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalBone");
		LocalBone_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalBone", Classes.FStrProperty);
		TeleportDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TeleportDistance");
		TeleportDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TeleportDistance", Classes.FFloatProperty);
		FHairSimulationSetup_IsValid = intPtr != IntPtr.Zero && ResetSimulation_IsValid && DebugSimulation_IsValid && LocalSimulation_IsValid && LinearVelocityScale_IsValid && AngularVelocityScale_IsValid && LocalBone_IsValid && TeleportDistance_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairSimulationSetup", FHairSimulationSetup_IsValid);
	}
}
