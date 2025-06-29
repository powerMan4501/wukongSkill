using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.NavDataConfig", "Engine", UnrealModuleType.Engine)]
public struct FNavDataConfig
{
	private static bool AgentRadius_IsValid;

	private static int AgentRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavAgentProperties:AgentRadius")]
	public float AgentRadius;

	private static bool AgentHeight_IsValid;

	private static int AgentHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavAgentProperties:AgentHeight")]
	public float AgentHeight;

	private static bool AgentStepHeight_IsValid;

	private static int AgentStepHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavAgentProperties:AgentStepHeight")]
	public float AgentStepHeight;

	private static bool NavWalkingSearchHeightScale_IsValid;

	private static int NavWalkingSearchHeightScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavAgentProperties:NavWalkingSearchHeightScale")]
	public float NavWalkingSearchHeightScale;

	private static bool PreferredNavData_IsValid;

	private static int PreferredNavData_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/Engine.NavAgentProperties:PreferredNavData")]
	public FSoftClassPath PreferredNavData;

	private static bool CanCrouch_IsValid;

	private static FFieldAddress CanCrouch_PropertyAddress;

	private static int CanCrouch_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanCrouch")]
	public bool CanCrouch;

	private static bool CanJump_IsValid;

	private static FFieldAddress CanJump_PropertyAddress;

	private static int CanJump_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanJump")]
	public bool CanJump;

	private static bool CanWalk_IsValid;

	private static FFieldAddress CanWalk_PropertyAddress;

	private static int CanWalk_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanWalk")]
	public bool CanWalk;

	private static bool CanSwim_IsValid;

	private static FFieldAddress CanSwim_PropertyAddress;

	private static int CanSwim_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanSwim")]
	public bool CanSwim;

	private static bool CanFly_IsValid;

	private static FFieldAddress CanFly_PropertyAddress;

	private static int CanFly_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanFly")]
	public bool CanFly;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavDataConfig:Name")]
	public FName Name;

	private static bool Color_IsValid;

	private static int Color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.NavDataConfig:Color")]
	public FColor Color;

	private static bool DefaultQueryExtent_IsValid;

	private static int DefaultQueryExtent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.NavDataConfig:DefaultQueryExtent")]
	public FVector DefaultQueryExtent;

	private static bool NavDataClass_IsValid;

	private static int NavDataClass_Offset;

	[UProperty(Flags = (PropFlags)12393695068291077uL)]
	[UMetaPath("/Script/Engine.NavDataConfig:NavDataClass")]
	public TSoftClass<AActor> NavDataClass;

	private static bool FNavDataConfig_IsValid;

	private static int FNavDataConfig_StructSize;

	public FNavDataConfig Copy()
	{
		return this;
	}

	public static FNavDataConfig FromNative(IntPtr nativeBuffer)
	{
		return new FNavDataConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNavDataConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNavDataConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNavDataConfig(nativeBuffer + arrayIndex * FNavDataConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNavDataConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FNavDataConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FNavDataConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NavDataConfig");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, Color_Offset), Color);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, DefaultQueryExtent_Offset), DefaultQueryExtent);
		TSoftClassMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, NavDataClass_Offset), NavDataClass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AgentRadius_Offset), AgentRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AgentHeight_Offset), AgentHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AgentStepHeight_Offset), AgentStepHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NavWalkingSearchHeightScale_Offset), NavWalkingSearchHeightScale);
		FSoftClassPath.ToNative(IntPtr.Add(nativeStruct, PreferredNavData_Offset), PreferredNavData);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanCrouch_Offset), 0, CanCrouch_PropertyAddress.Address, CanCrouch);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanJump_Offset), 0, CanJump_PropertyAddress.Address, CanJump);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanWalk_Offset), 0, CanWalk_PropertyAddress.Address, CanWalk);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanSwim_Offset), 0, CanSwim_PropertyAddress.Address, CanSwim);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanFly_Offset), 0, CanFly_PropertyAddress.Address, CanFly);
	}

	public FNavDataConfig(IntPtr nativeStruct)
	{
		if (!FNavDataConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.NavDataConfig");
			Name = default(FName);
			Color = default(FColor);
			DefaultQueryExtent = default(FVector);
			NavDataClass = default(TSoftClass<AActor>);
			AgentRadius = 0f;
			AgentHeight = 0f;
			AgentStepHeight = 0f;
			NavWalkingSearchHeightScale = 0f;
			PreferredNavData = default(FSoftClassPath);
			CanCrouch = false;
			CanJump = false;
			CanWalk = false;
			CanSwim = false;
			CanFly = false;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Color = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, Color_Offset));
			DefaultQueryExtent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, DefaultQueryExtent_Offset));
			NavDataClass = TSoftClassMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, NavDataClass_Offset));
			AgentRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AgentRadius_Offset));
			AgentHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AgentHeight_Offset));
			AgentStepHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AgentStepHeight_Offset));
			NavWalkingSearchHeightScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NavWalkingSearchHeightScale_Offset));
			PreferredNavData = FSoftClassPath.FromNative(IntPtr.Add(nativeStruct, PreferredNavData_Offset));
			CanCrouch = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanCrouch_Offset), 0, CanCrouch_PropertyAddress.Address);
			CanJump = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanJump_Offset), 0, CanJump_PropertyAddress.Address);
			CanWalk = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanWalk_Offset), 0, CanWalk_PropertyAddress.Address);
			CanSwim = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanSwim_Offset), 0, CanSwim_PropertyAddress.Address);
			CanFly = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanFly_Offset), 0, CanFly_PropertyAddress.Address);
		}
	}

	static FNavDataConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNavDataConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNavDataConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.NavDataConfig");
		FNavDataConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		AgentRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AgentRadius");
		AgentRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AgentRadius", Classes.FFloatProperty);
		AgentHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AgentHeight");
		AgentHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AgentHeight", Classes.FFloatProperty);
		AgentStepHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AgentStepHeight");
		AgentStepHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AgentStepHeight", Classes.FFloatProperty);
		NavWalkingSearchHeightScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavWalkingSearchHeightScale");
		NavWalkingSearchHeightScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavWalkingSearchHeightScale", Classes.FFloatProperty);
		PreferredNavData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreferredNavData");
		PreferredNavData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreferredNavData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanCrouch_PropertyAddress, intPtr, "bCanCrouch");
		CanCrouch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanCrouch");
		CanCrouch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanCrouch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanJump_PropertyAddress, intPtr, "bCanJump");
		CanJump_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanJump");
		CanJump_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanJump", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanWalk_PropertyAddress, intPtr, "bCanWalk");
		CanWalk_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanWalk");
		CanWalk_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanWalk", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSwim_PropertyAddress, intPtr, "bCanSwim");
		CanSwim_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanSwim");
		CanSwim_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanSwim", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanFly_PropertyAddress, intPtr, "bCanFly");
		CanFly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanFly");
		CanFly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanFly", Classes.FBoolProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Color");
		Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Color", Classes.FStructProperty);
		DefaultQueryExtent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultQueryExtent");
		DefaultQueryExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultQueryExtent", Classes.FStructProperty);
		NavDataClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NavDataClass");
		NavDataClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NavDataClass", Classes.FSoftClassProperty);
		FNavDataConfig_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Color_IsValid && DefaultQueryExtent_IsValid && NavDataClass_IsValid && AgentRadius_IsValid && AgentHeight_IsValid && AgentStepHeight_IsValid && NavWalkingSearchHeightScale_IsValid && PreferredNavData_IsValid && CanCrouch_IsValid && CanJump_IsValid && CanWalk_IsValid && CanSwim_IsValid && CanFly_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.NavDataConfig", FNavDataConfig_IsValid);
	}
}
