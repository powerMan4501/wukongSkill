using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSSceneActorActivationInfo")]
public struct FGSSceneActorActivationInfo
{
	[BlueprintReadWrite]
	[DisplayName("物体开关功能类型")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("物体需要开关的功能类型")]
	[USharpPath("/Script/b1-Managed.FGSSceneActorActivationInfo:SceneActorActivationType")]
	public EGSSceneActorActivationType SceneActorActivationType;

	[UProperty]
	[Tooltip("功能启用的最大距离")]
	[DisplayName("启用距离")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSSceneActorActivationInfo:ActivateDistance")]
	public float ActivateDistance;

	[UMeta(MDProp.EditCondition, "SceneActorActivationType != EGSSceneActorActivationType::BGUActorActivation && SceneActorActivationType != EGSSceneActorActivationType::HiddenInGame")]
	[UProperty]
	[DisplayName("开关组件Tag")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("需要开关功能的组件Tag")]
	[USharpPath("/Script/b1-Managed.FGSSceneActorActivationInfo:Tag")]
	public FName Tag;

	private static int FGSSceneActorActivationInfo_StructSize;

	private static int FGSSceneActorActivationInfo_IsValid;

	private static bool SceneActorActivationType_IsValid;

	private static int SceneActorActivationType_Offset;

	private static FFieldAddress SceneActorActivationType_PropertyAddress;

	private static bool ActivateDistance_IsValid;

	private static int ActivateDistance_Offset;

	private static bool Tag_IsValid;

	private static int Tag_Offset;

	public FGSSceneActorActivationInfo Copy()
	{
		return this;
	}

	public static FGSSceneActorActivationInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSSceneActorActivationInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSceneActorActivationInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSceneActorActivationInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSceneActorActivationInfo(IntPtr.Add(nativeBuffer, arrayIndex * FGSSceneActorActivationInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSceneActorActivationInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSceneActorActivationInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSceneActorActivationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSceneActorActivationInfo");
			return;
		}
		EnumMarshaler<EGSSceneActorActivationType>.ToNative(IntPtr.Add(nativeStruct, SceneActorActivationType_Offset), 0, SceneActorActivationType_PropertyAddress.Address, SceneActorActivationType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ActivateDistance_Offset), ActivateDistance);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Tag_Offset), Tag);
	}

	public FGSSceneActorActivationInfo(IntPtr nativeStruct)
	{
		if (FGSSceneActorActivationInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSceneActorActivationInfo");
			SceneActorActivationType = EGSSceneActorActivationType.PhysicsSimulation;
			ActivateDistance = 0f;
			Tag = default(FName);
		}
		else
		{
			SceneActorActivationType = EnumMarshaler<EGSSceneActorActivationType>.FromNative(IntPtr.Add(nativeStruct, SceneActorActivationType_Offset), 0, SceneActorActivationType_PropertyAddress.Address);
			ActivateDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ActivateDistance_Offset));
			Tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Tag_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSceneActorActivationInfo");
		FGSSceneActorActivationInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SceneActorActivationType_PropertyAddress, intPtr, "SceneActorActivationType");
		SceneActorActivationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneActorActivationType");
		SceneActorActivationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneActorActivationType", Classes.FEnumProperty);
		ActivateDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActivateDistance");
		ActivateDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActivateDistance", Classes.FFloatProperty);
		Tag_Offset = NativeReflection.GetPropertyOffset(intPtr, "Tag");
		Tag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Tag", Classes.FNameProperty);
		FGSSceneActorActivationInfo_IsValid = ((intPtr != IntPtr.Zero && SceneActorActivationType_IsValid && ActivateDistance_IsValid && Tag_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSceneActorActivationInfo", (byte)FGSSceneActorActivationInfo_IsValid != 0);
	}

	static FGSSceneActorActivationInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSceneActorActivationInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSceneActorActivationInfo));
	}
}
