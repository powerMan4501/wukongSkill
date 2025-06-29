using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigElementWeight", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigElementWeight
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigElementWeight:Location")]
	public float Location;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigElementWeight:Rotation")]
	public float Rotation;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.RigElementWeight:Scale")]
	public float Scale;

	private static bool FRigElementWeight_IsValid;

	private static int FRigElementWeight_StructSize;

	public FRigElementWeight Copy()
	{
		return this;
	}

	public static FRigElementWeight FromNative(IntPtr nativeBuffer)
	{
		return new FRigElementWeight(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigElementWeight value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigElementWeight FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigElementWeight(nativeBuffer + arrayIndex * FRigElementWeight_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigElementWeight value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigElementWeight_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigElementWeight_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigElementWeight");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
	}

	public FRigElementWeight(IntPtr nativeStruct)
	{
		if (!FRigElementWeight_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigElementWeight");
			Location = 0f;
			Rotation = 0f;
			Scale = 0f;
		}
		else
		{
			Location = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Rotation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
		}
	}

	static FRigElementWeight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigElementWeight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigElementWeight));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigElementWeight");
		FRigElementWeight_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FFloatProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FFloatProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		FRigElementWeight_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Rotation_IsValid && Scale_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigElementWeight", FRigElementWeight_IsValid);
	}
}
