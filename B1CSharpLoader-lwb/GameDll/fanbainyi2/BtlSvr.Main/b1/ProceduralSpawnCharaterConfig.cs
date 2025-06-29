using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.ProceduralSpawnCharaterConfig")]
public struct ProceduralSpawnCharaterConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, 1)]
	[DisplayName("角色生成半径")]
	[Category("Procedural Character Wave Config")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnCharaterConfig:ProceduralSpawnRadius")]
	public float ProceduralSpawnRadius;

	[EditAnywhere]
	[UProperty]
	[Category("Procedural Character Wave Config")]
	[DisplayName("是否预览角色生成配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnCharaterConfig:EnableEditorPreviewing")]
	public bool EnableEditorPreviewing;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Procedural Character Wave Config")]
	[DisplayName("角色生成波次配置")]
	[USharpPath("/Script/b1-Managed.ProceduralSpawnCharaterConfig:ProceduralWaveConfigs")]
	public List<ProceduralSpawnWaveConfig> ProceduralWaveConfigs;

	private static int ProceduralSpawnCharaterConfig_StructSize;

	private static int ProceduralSpawnCharaterConfig_IsValid;

	private static bool ProceduralSpawnRadius_IsValid;

	private static int ProceduralSpawnRadius_Offset;

	private static bool EnableEditorPreviewing_IsValid;

	private static int EnableEditorPreviewing_Offset;

	private static FFieldAddress EnableEditorPreviewing_PropertyAddress;

	private static bool ProceduralWaveConfigs_IsValid;

	private static int ProceduralWaveConfigs_Offset;

	private static FFieldAddress ProceduralWaveConfigs_PropertyAddress;

	public ProceduralSpawnCharaterConfig Copy()
	{
		ProceduralSpawnCharaterConfig result = this;
		if (ProceduralWaveConfigs != null)
		{
			result.ProceduralWaveConfigs = new List<ProceduralSpawnWaveConfig>(ProceduralWaveConfigs);
		}
		return result;
	}

	public static ProceduralSpawnCharaterConfig FromNative(IntPtr nativeBuffer)
	{
		return new ProceduralSpawnCharaterConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ProceduralSpawnCharaterConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ProceduralSpawnCharaterConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ProceduralSpawnCharaterConfig(IntPtr.Add(nativeBuffer, arrayIndex * ProceduralSpawnCharaterConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ProceduralSpawnCharaterConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ProceduralSpawnCharaterConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ProceduralSpawnCharaterConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProceduralSpawnCharaterConfig");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ProceduralSpawnRadius_Offset), ProceduralSpawnRadius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableEditorPreviewing_Offset), 0, EnableEditorPreviewing_PropertyAddress.Address, EnableEditorPreviewing);
		new TArrayCopyMarshaler<ProceduralSpawnWaveConfig>(1, ProceduralWaveConfigs_PropertyAddress, CachedMarshalingDelegates<ProceduralSpawnWaveConfig, ProceduralSpawnWaveConfig>.FromNative, CachedMarshalingDelegates<ProceduralSpawnWaveConfig, ProceduralSpawnWaveConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, ProceduralWaveConfigs_Offset), ProceduralWaveConfigs);
	}

	public ProceduralSpawnCharaterConfig(IntPtr nativeStruct)
	{
		if (ProceduralSpawnCharaterConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ProceduralSpawnCharaterConfig");
			ProceduralSpawnRadius = 0f;
			EnableEditorPreviewing = false;
			ProceduralWaveConfigs = null;
		}
		else
		{
			ProceduralSpawnRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ProceduralSpawnRadius_Offset));
			EnableEditorPreviewing = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableEditorPreviewing_Offset), 0, EnableEditorPreviewing_PropertyAddress.Address);
			ProceduralWaveConfigs = new TArrayCopyMarshaler<ProceduralSpawnWaveConfig>(1, ProceduralWaveConfigs_PropertyAddress, CachedMarshalingDelegates<ProceduralSpawnWaveConfig, ProceduralSpawnWaveConfig>.FromNative, CachedMarshalingDelegates<ProceduralSpawnWaveConfig, ProceduralSpawnWaveConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, ProceduralWaveConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ProceduralSpawnCharaterConfig");
		ProceduralSpawnCharaterConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ProceduralSpawnRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProceduralSpawnRadius");
		ProceduralSpawnRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProceduralSpawnRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableEditorPreviewing_PropertyAddress, intPtr, "EnableEditorPreviewing");
		EnableEditorPreviewing_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableEditorPreviewing");
		EnableEditorPreviewing_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableEditorPreviewing", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ProceduralWaveConfigs_PropertyAddress, intPtr, "ProceduralWaveConfigs");
		ProceduralWaveConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProceduralWaveConfigs");
		ProceduralWaveConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProceduralWaveConfigs", Classes.FArrayProperty);
		ProceduralSpawnCharaterConfig_IsValid = ((intPtr != IntPtr.Zero && ProceduralSpawnRadius_IsValid && EnableEditorPreviewing_IsValid && ProceduralWaveConfigs_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ProceduralSpawnCharaterConfig", (byte)ProceduralSpawnCharaterConfig_IsValid != 0);
	}

	static ProceduralSpawnCharaterConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ProceduralSpawnCharaterConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ProceduralSpawnCharaterConfig));
	}
}
