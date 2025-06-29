using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig")]
public struct FTreeBirdSpawnConfig
{
	[DisplayName("生成模板")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig:SpawnTemplate")]
	public TSubclassOf<BGUNeutralFXAnimalSpawnPoint> SpawnTemplate;

	[DisplayName("刷新内径")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig:InnerRadius")]
	public float InnerRadius;

	[EditAnywhere]
	[UProperty]
	[DisplayName("刷新外径")]
	[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig:OutRadius")]
	public float OutRadius;

	[EditAnywhere]
	[UProperty]
	[DisplayName("玩家速度超限启用角度筛选")]
	[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig:PlayerSpdControl")]
	public float PlayerSpdControl;

	[UProperty]
	[DisplayName("高速态下生成区域角度")]
	[Tooltip("玩家速度过高得时候，只在玩家前方生成树上飞鸟")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig:SprintSpawnAreaAngle")]
	public float SprintSpawnAreaAngle;

	[EditAnywhere]
	[UProperty]
	[DisplayName("刷新检测间隔")]
	[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig:SpawnCheckInterval")]
	public float SpawnCheckInterval;

	[DisplayName("触发刷新的距离")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig:RefreshDistance")]
	public float RefreshDistance;

	[EditAnywhere]
	[UProperty]
	[Tooltip("刷新时销毁距离过远的生成器后补充数量")]
	[DisplayName("一轮刷新数量")]
	[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig:SpawnNum")]
	public FInt32Range SpawnNum;

	[DisplayName("刷新时销毁距离过远的生成器")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeBirdSpawnConfig:DestroyDist")]
	public float DestroyDist;

	private static int TreeBirdSpawnConfig_StructSize;

	private static int TreeBirdSpawnConfig_IsValid;

	private static bool SpawnTemplate_IsValid;

	private static int SpawnTemplate_Offset;

	private static bool InnerRadius_IsValid;

	private static int InnerRadius_Offset;

	private static bool OutRadius_IsValid;

	private static int OutRadius_Offset;

	private static bool PlayerSpdControl_IsValid;

	private static int PlayerSpdControl_Offset;

	private static bool SprintSpawnAreaAngle_IsValid;

	private static int SprintSpawnAreaAngle_Offset;

	private static bool SpawnCheckInterval_IsValid;

	private static int SpawnCheckInterval_Offset;

	private static bool RefreshDistance_IsValid;

	private static int RefreshDistance_Offset;

	private static bool SpawnNum_IsValid;

	private static int SpawnNum_Offset;

	private static bool DestroyDist_IsValid;

	private static int DestroyDist_Offset;

	public FTreeBirdSpawnConfig Copy()
	{
		return this;
	}

	public static FTreeBirdSpawnConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTreeBirdSpawnConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTreeBirdSpawnConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTreeBirdSpawnConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTreeBirdSpawnConfig(IntPtr.Add(nativeBuffer, arrayIndex * TreeBirdSpawnConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTreeBirdSpawnConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TreeBirdSpawnConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TreeBirdSpawnConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TreeBirdSpawnConfig");
			return;
		}
		TSubclassOfMarshaler<BGUNeutralFXAnimalSpawnPoint>.ToNative(IntPtr.Add(nativeStruct, SpawnTemplate_Offset), SpawnTemplate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InnerRadius_Offset), InnerRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutRadius_Offset), OutRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlayerSpdControl_Offset), PlayerSpdControl);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SprintSpawnAreaAngle_Offset), SprintSpawnAreaAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpawnCheckInterval_Offset), SpawnCheckInterval);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RefreshDistance_Offset), RefreshDistance);
		BlittableTypeMarshaler<FInt32Range>.ToNative(IntPtr.Add(nativeStruct, SpawnNum_Offset), SpawnNum);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DestroyDist_Offset), DestroyDist);
	}

	public FTreeBirdSpawnConfig(IntPtr nativeStruct)
	{
		if (TreeBirdSpawnConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TreeBirdSpawnConfig");
			SpawnTemplate = default(TSubclassOf<BGUNeutralFXAnimalSpawnPoint>);
			InnerRadius = 0f;
			OutRadius = 0f;
			PlayerSpdControl = 0f;
			SprintSpawnAreaAngle = 0f;
			SpawnCheckInterval = 0f;
			RefreshDistance = 0f;
			SpawnNum = default(FInt32Range);
			DestroyDist = 0f;
		}
		else
		{
			SpawnTemplate = TSubclassOfMarshaler<BGUNeutralFXAnimalSpawnPoint>.FromNative(IntPtr.Add(nativeStruct, SpawnTemplate_Offset));
			InnerRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InnerRadius_Offset));
			OutRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutRadius_Offset));
			PlayerSpdControl = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlayerSpdControl_Offset));
			SprintSpawnAreaAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SprintSpawnAreaAngle_Offset));
			SpawnCheckInterval = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpawnCheckInterval_Offset));
			RefreshDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RefreshDistance_Offset));
			SpawnNum = BlittableTypeMarshaler<FInt32Range>.FromNative(IntPtr.Add(nativeStruct, SpawnNum_Offset));
			DestroyDist = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DestroyDist_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TreeBirdSpawnConfig");
		TreeBirdSpawnConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		SpawnTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnTemplate");
		SpawnTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnTemplate", Classes.FClassProperty);
		InnerRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "InnerRadius");
		InnerRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InnerRadius", Classes.FFloatProperty);
		OutRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "OutRadius");
		OutRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OutRadius", Classes.FFloatProperty);
		PlayerSpdControl_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerSpdControl");
		PlayerSpdControl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerSpdControl", Classes.FFloatProperty);
		SprintSpawnAreaAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "SprintSpawnAreaAngle");
		SprintSpawnAreaAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SprintSpawnAreaAngle", Classes.FFloatProperty);
		SpawnCheckInterval_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnCheckInterval");
		SpawnCheckInterval_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnCheckInterval", Classes.FFloatProperty);
		RefreshDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "RefreshDistance");
		RefreshDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RefreshDistance", Classes.FFloatProperty);
		SpawnNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnNum");
		SpawnNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnNum", Classes.FStructProperty);
		DestroyDist_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyDist");
		DestroyDist_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyDist", Classes.FFloatProperty);
		TreeBirdSpawnConfig_IsValid = ((intPtr != IntPtr.Zero && SpawnTemplate_IsValid && InnerRadius_IsValid && OutRadius_IsValid && PlayerSpdControl_IsValid && SprintSpawnAreaAngle_IsValid && SpawnCheckInterval_IsValid && RefreshDistance_IsValid && SpawnNum_IsValid && DestroyDist_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TreeBirdSpawnConfig", (byte)TreeBirdSpawnConfig_IsValid != 0);
	}

	static FTreeBirdSpawnConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTreeBirdSpawnConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTreeBirdSpawnConfig));
	}
}
