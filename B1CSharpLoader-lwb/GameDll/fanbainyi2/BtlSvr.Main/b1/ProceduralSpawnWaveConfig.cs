using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.ProceduralSpawnWaveConfig")]
public struct ProceduralSpawnWaveConfig
{
	[UProperty]
	[DisplayName("角色攻击类型")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Character Spawn Wave Config")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnWaveConfig:CharacterAssetConfig")]
	public CharacterAssetConfig CharacterAssetConfig;

	[Category("Character Spawn Wave Config")]
	[BlueprintReadWrite]
	[DisplayName("角色生成特效配置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnWaveConfig:SpawnEffectDataAsset")]
	public UBGWDataAsset SpawnEffectDataAsset;

	[BlueprintReadWrite]
	[DisplayName("角色生成方式")]
	[EditAnywhere]
	[UProperty]
	[Category("Character Spawn Wave Config")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnWaveConfig:SpawnMethod")]
	public SPAWN_METHOD SpawnMethod;

	[Category("Character Spawn Wave Config")]
	[DisplayName("角色生成基准点")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnWaveConfig:SpawnBaseLoc")]
	public SPAWN_BASE_LOCATION SpawnBaseLoc;

	[EditAnywhere]
	[DisplayName("角色生成条件")]
	[Category("Character Spawn Wave Config")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnWaveConfig:SpawnCondition")]
	public SPAWN_CONDITION SpawnCondition;

	[UProperty]
	[UMeta(MDProp.ClampMax, 1f)]
	[UMeta(MDProp.ClampMin, 0f)]
	[DisplayName("角色生成百分比参数")]
	[Category("Character Spawn Wave Config")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "SpawnMethod == SPAWN_METHOD::SPAWN_ON_WAVE")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnWaveConfig:SpawnPercentageParam")]
	public float SpawnPercentageParam;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("角色生成依赖的波次参数")]
	[UMeta(MDProp.EditCondition, "SpawnMethod == SPAWN_METHOD::SPAWN_ON_WAVE")]
	[Category("Character Spawn Wave Config")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnWaveConfig:SpawnWaveIndexParam")]
	public int SpawnWaveIndexParam;

	[UProperty]
	[UMeta(MDProp.EditCondition, "SpawnMethod == SPAWN_METHOD::SPAWN_ON_TRIGGER_RANGE")]
	[Category("Character Spawn Wave Config")]
	[UMeta(MDProp.ClampMin, 0f)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("角色生成触发范围参数")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnWaveConfig:SpawnTriggerDistanceParam")]
	public float SpawnTriggerDistanceParam;

	private static int ProceduralSpawnWaveConfig_StructSize;

	private static int ProceduralSpawnWaveConfig_IsValid;

	private static bool CharacterAssetConfig_IsValid;

	private static int CharacterAssetConfig_Offset;

	private static bool SpawnEffectDataAsset_IsValid;

	private static int SpawnEffectDataAsset_Offset;

	private static bool SpawnMethod_IsValid;

	private static int SpawnMethod_Offset;

	private static FFieldAddress SpawnMethod_PropertyAddress;

	private static bool SpawnBaseLoc_IsValid;

	private static int SpawnBaseLoc_Offset;

	private static FFieldAddress SpawnBaseLoc_PropertyAddress;

	private static bool SpawnCondition_IsValid;

	private static int SpawnCondition_Offset;

	private static FFieldAddress SpawnCondition_PropertyAddress;

	private static bool SpawnPercentageParam_IsValid;

	private static int SpawnPercentageParam_Offset;

	private static bool SpawnWaveIndexParam_IsValid;

	private static int SpawnWaveIndexParam_Offset;

	private static bool SpawnTriggerDistanceParam_IsValid;

	private static int SpawnTriggerDistanceParam_Offset;

	public ProceduralSpawnWaveConfig Copy()
	{
		return this;
	}

	public static ProceduralSpawnWaveConfig FromNative(IntPtr nativeBuffer)
	{
		return new ProceduralSpawnWaveConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ProceduralSpawnWaveConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ProceduralSpawnWaveConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ProceduralSpawnWaveConfig(IntPtr.Add(nativeBuffer, arrayIndex * ProceduralSpawnWaveConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ProceduralSpawnWaveConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProceduralSpawnWaveConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProceduralSpawnWaveConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProceduralSpawnWaveConfig");
			return;
		}
		CharacterAssetConfig.ToNative(IntPtr.Add(nativeStruct, CharacterAssetConfig_Offset), CharacterAssetConfig);
		UObjectMarshaler<UBGWDataAsset>.ToNative(IntPtr.Add(nativeStruct, SpawnEffectDataAsset_Offset), SpawnEffectDataAsset);
		EnumMarshaler<SPAWN_METHOD>.ToNative(IntPtr.Add(nativeStruct, SpawnMethod_Offset), 0, SpawnMethod_PropertyAddress.Address, SpawnMethod);
		EnumMarshaler<SPAWN_BASE_LOCATION>.ToNative(IntPtr.Add(nativeStruct, SpawnBaseLoc_Offset), 0, SpawnBaseLoc_PropertyAddress.Address, SpawnBaseLoc);
		EnumMarshaler<SPAWN_CONDITION>.ToNative(IntPtr.Add(nativeStruct, SpawnCondition_Offset), 0, SpawnCondition_PropertyAddress.Address, SpawnCondition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpawnPercentageParam_Offset), SpawnPercentageParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SpawnWaveIndexParam_Offset), SpawnWaveIndexParam);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpawnTriggerDistanceParam_Offset), SpawnTriggerDistanceParam);
	}

	public ProceduralSpawnWaveConfig(IntPtr nativeStruct)
	{
		if (ProceduralSpawnWaveConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProceduralSpawnWaveConfig");
			CharacterAssetConfig = default(CharacterAssetConfig);
			SpawnEffectDataAsset = null;
			SpawnMethod = SPAWN_METHOD.SPAWN_ON_START;
			SpawnBaseLoc = SPAWN_BASE_LOCATION.BASE_ON_DEFAULT;
			SpawnCondition = SPAWN_CONDITION.SPAWN_ON_DEFALUT;
			SpawnPercentageParam = 0f;
			SpawnWaveIndexParam = 0;
			SpawnTriggerDistanceParam = 0f;
		}
		else
		{
			CharacterAssetConfig = CharacterAssetConfig.FromNative(IntPtr.Add(nativeStruct, CharacterAssetConfig_Offset));
			SpawnEffectDataAsset = UObjectMarshaler<UBGWDataAsset>.FromNative(IntPtr.Add(nativeStruct, SpawnEffectDataAsset_Offset));
			SpawnMethod = EnumMarshaler<SPAWN_METHOD>.FromNative(IntPtr.Add(nativeStruct, SpawnMethod_Offset), 0, SpawnMethod_PropertyAddress.Address);
			SpawnBaseLoc = EnumMarshaler<SPAWN_BASE_LOCATION>.FromNative(IntPtr.Add(nativeStruct, SpawnBaseLoc_Offset), 0, SpawnBaseLoc_PropertyAddress.Address);
			SpawnCondition = EnumMarshaler<SPAWN_CONDITION>.FromNative(IntPtr.Add(nativeStruct, SpawnCondition_Offset), 0, SpawnCondition_PropertyAddress.Address);
			SpawnPercentageParam = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpawnPercentageParam_Offset));
			SpawnWaveIndexParam = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SpawnWaveIndexParam_Offset));
			SpawnTriggerDistanceParam = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpawnTriggerDistanceParam_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProceduralSpawnWaveConfig");
		ProceduralSpawnWaveConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		CharacterAssetConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "CharacterAssetConfig");
		CharacterAssetConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CharacterAssetConfig", Classes.FStructProperty);
		SpawnEffectDataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnEffectDataAsset");
		SpawnEffectDataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnEffectDataAsset", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SpawnMethod_PropertyAddress, intPtr, "SpawnMethod");
		SpawnMethod_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnMethod");
		SpawnMethod_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnMethod", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpawnBaseLoc_PropertyAddress, intPtr, "SpawnBaseLoc");
		SpawnBaseLoc_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnBaseLoc");
		SpawnBaseLoc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnBaseLoc", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpawnCondition_PropertyAddress, intPtr, "SpawnCondition");
		SpawnCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnCondition");
		SpawnCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnCondition", Classes.FEnumProperty);
		SpawnPercentageParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPercentageParam");
		SpawnPercentageParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPercentageParam", Classes.FFloatProperty);
		SpawnWaveIndexParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWaveIndexParam");
		SpawnWaveIndexParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWaveIndexParam", Classes.FIntProperty);
		SpawnTriggerDistanceParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnTriggerDistanceParam");
		SpawnTriggerDistanceParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnTriggerDistanceParam", Classes.FFloatProperty);
		ProceduralSpawnWaveConfig_IsValid = ((intPtr != IntPtr.Zero && CharacterAssetConfig_IsValid && SpawnEffectDataAsset_IsValid && SpawnMethod_IsValid && SpawnBaseLoc_IsValid && SpawnCondition_IsValid && SpawnPercentageParam_IsValid && SpawnWaveIndexParam_IsValid && SpawnTriggerDistanceParam_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProceduralSpawnWaveConfig", (byte)ProceduralSpawnWaveConfig_IsValid != 0);
	}

	static ProceduralSpawnWaveConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ProceduralSpawnWaveConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ProceduralSpawnWaveConfig));
	}
}
