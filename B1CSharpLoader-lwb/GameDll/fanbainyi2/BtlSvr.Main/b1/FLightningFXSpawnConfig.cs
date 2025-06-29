using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig")]
public struct FLightningFXSpawnConfig
{
	[EditAnywhere]
	[UProperty]
	[DisplayName("闪电特效")]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:LightningTemplate")]
	public UNiagaraSystem LightningTemplate;

	[UProperty]
	[DisplayName("贴花Actor")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:DecalActorClass")]
	public TSubclassOf<BGUDecalActor> DecalActorClass;

	[DisplayName("生成波数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:SpawnWaves")]
	public int SpawnWaves;

	[UProperty]
	[EditAnywhere]
	[DisplayName("生成间隔")]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:WaveGap")]
	public float WaveGap;

	[DisplayName("每波生成多少个")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:SpawnNumPerWave")]
	public int SpawnNumPerWave;

	[DisplayName("闪电贴花延迟出现时间")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:LightningDelaySpawnDecalTime")]
	public float LightningDelaySpawnDecalTime;

	[DisplayName("每波重新计算点")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:bRecalcPointPerWave")]
	public bool bRecalcPointPerWave;

	[DisplayName("是否为自生成模式")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:bSpawnBySelfMode")]
	public bool bSpawnBySelfMode;

	[DisplayName("基于Parent的Transform筛选打击朝向")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:DirBaseOnParent")]
	public bool DirBaseOnParent;

	[UMeta(MDProp.EditCondition, "bSpawnBySelfMode")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:RangeDir_X")]
	public FFloatRange RangeDir_X;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "bSpawnBySelfMode")]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:RangeDir_Y")]
	public FFloatRange RangeDir_Y;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "bSpawnBySelfMode")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:RangeDir_Z")]
	public FFloatRange RangeDir_Z;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "bSpawnBySelfMode")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:LineTraceMaxLength")]
	public float LineTraceMaxLength;

	[UMeta(MDProp.EditCondition, "bSpawnBySelfMode")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:TraceTypeQuery")]
	public ETraceTypeQuery TraceTypeQuery;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "bSpawnBySelfMode")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LightningFXSpawnConfig:PointMinBetween")]
	public float PointMinBetween;

	private static int LightningFXSpawnConfig_StructSize;

	private static int LightningFXSpawnConfig_IsValid;

	private static bool LightningTemplate_IsValid;

	private static int LightningTemplate_Offset;

	private static bool DecalActorClass_IsValid;

	private static int DecalActorClass_Offset;

	private static bool SpawnWaves_IsValid;

	private static int SpawnWaves_Offset;

	private static bool WaveGap_IsValid;

	private static int WaveGap_Offset;

	private static bool SpawnNumPerWave_IsValid;

	private static int SpawnNumPerWave_Offset;

	private static bool LightningDelaySpawnDecalTime_IsValid;

	private static int LightningDelaySpawnDecalTime_Offset;

	private static bool bRecalcPointPerWave_IsValid;

	private static int bRecalcPointPerWave_Offset;

	private static FFieldAddress bRecalcPointPerWave_PropertyAddress;

	private static bool bSpawnBySelfMode_IsValid;

	private static int bSpawnBySelfMode_Offset;

	private static FFieldAddress bSpawnBySelfMode_PropertyAddress;

	private static bool DirBaseOnParent_IsValid;

	private static int DirBaseOnParent_Offset;

	private static FFieldAddress DirBaseOnParent_PropertyAddress;

	private static bool RangeDir_X_IsValid;

	private static int RangeDir_X_Offset;

	private static bool RangeDir_Y_IsValid;

	private static int RangeDir_Y_Offset;

	private static bool RangeDir_Z_IsValid;

	private static int RangeDir_Z_Offset;

	private static bool LineTraceMaxLength_IsValid;

	private static int LineTraceMaxLength_Offset;

	private static bool TraceTypeQuery_IsValid;

	private static int TraceTypeQuery_Offset;

	private static FFieldAddress TraceTypeQuery_PropertyAddress;

	private static bool PointMinBetween_IsValid;

	private static int PointMinBetween_Offset;

	public FLightningFXSpawnConfig Copy()
	{
		return this;
	}

	public static FLightningFXSpawnConfig FromNative(IntPtr nativeBuffer)
	{
		return new FLightningFXSpawnConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLightningFXSpawnConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLightningFXSpawnConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLightningFXSpawnConfig(IntPtr.Add(nativeBuffer, arrayIndex * LightningFXSpawnConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLightningFXSpawnConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * LightningFXSpawnConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (LightningFXSpawnConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LightningFXSpawnConfig");
			return;
		}
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, LightningTemplate_Offset), LightningTemplate);
		TSubclassOfMarshaler<BGUDecalActor>.ToNative(IntPtr.Add(nativeStruct, DecalActorClass_Offset), DecalActorClass);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SpawnWaves_Offset), SpawnWaves);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WaveGap_Offset), WaveGap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SpawnNumPerWave_Offset), SpawnNumPerWave);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LightningDelaySpawnDecalTime_Offset), LightningDelaySpawnDecalTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bRecalcPointPerWave_Offset), 0, bRecalcPointPerWave_PropertyAddress.Address, bRecalcPointPerWave);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bSpawnBySelfMode_Offset), 0, bSpawnBySelfMode_PropertyAddress.Address, bSpawnBySelfMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DirBaseOnParent_Offset), 0, DirBaseOnParent_PropertyAddress.Address, DirBaseOnParent);
		BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(nativeStruct, RangeDir_X_Offset), RangeDir_X);
		BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(nativeStruct, RangeDir_Y_Offset), RangeDir_Y);
		BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(nativeStruct, RangeDir_Z_Offset), RangeDir_Z);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LineTraceMaxLength_Offset), LineTraceMaxLength);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(nativeStruct, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address, TraceTypeQuery);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PointMinBetween_Offset), PointMinBetween);
	}

	public FLightningFXSpawnConfig(IntPtr nativeStruct)
	{
		if (LightningFXSpawnConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LightningFXSpawnConfig");
			LightningTemplate = null;
			DecalActorClass = default(TSubclassOf<BGUDecalActor>);
			SpawnWaves = 0;
			WaveGap = 0f;
			SpawnNumPerWave = 0;
			LightningDelaySpawnDecalTime = 0f;
			bRecalcPointPerWave = false;
			bSpawnBySelfMode = false;
			DirBaseOnParent = false;
			RangeDir_X = default(FFloatRange);
			RangeDir_Y = default(FFloatRange);
			RangeDir_Z = default(FFloatRange);
			LineTraceMaxLength = 0f;
			TraceTypeQuery = ETraceTypeQuery.TraceTypeQuery1;
			PointMinBetween = 0f;
		}
		else
		{
			LightningTemplate = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, LightningTemplate_Offset));
			DecalActorClass = TSubclassOfMarshaler<BGUDecalActor>.FromNative(IntPtr.Add(nativeStruct, DecalActorClass_Offset));
			SpawnWaves = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SpawnWaves_Offset));
			WaveGap = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WaveGap_Offset));
			SpawnNumPerWave = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SpawnNumPerWave_Offset));
			LightningDelaySpawnDecalTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LightningDelaySpawnDecalTime_Offset));
			bRecalcPointPerWave = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bRecalcPointPerWave_Offset), 0, bRecalcPointPerWave_PropertyAddress.Address);
			bSpawnBySelfMode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bSpawnBySelfMode_Offset), 0, bSpawnBySelfMode_PropertyAddress.Address);
			DirBaseOnParent = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DirBaseOnParent_Offset), 0, DirBaseOnParent_PropertyAddress.Address);
			RangeDir_X = BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(nativeStruct, RangeDir_X_Offset));
			RangeDir_Y = BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(nativeStruct, RangeDir_Y_Offset));
			RangeDir_Z = BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(nativeStruct, RangeDir_Z_Offset));
			LineTraceMaxLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LineTraceMaxLength_Offset));
			TraceTypeQuery = EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(nativeStruct, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address);
			PointMinBetween = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PointMinBetween_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.LightningFXSpawnConfig");
		LightningFXSpawnConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		LightningTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "LightningTemplate");
		LightningTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LightningTemplate", Classes.FObjectProperty);
		DecalActorClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "DecalActorClass");
		DecalActorClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DecalActorClass", Classes.FClassProperty);
		SpawnWaves_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnWaves");
		SpawnWaves_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnWaves", Classes.FIntProperty);
		WaveGap_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaveGap");
		WaveGap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaveGap", Classes.FFloatProperty);
		SpawnNumPerWave_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnNumPerWave");
		SpawnNumPerWave_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnNumPerWave", Classes.FIntProperty);
		LightningDelaySpawnDecalTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "LightningDelaySpawnDecalTime");
		LightningDelaySpawnDecalTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LightningDelaySpawnDecalTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bRecalcPointPerWave_PropertyAddress, intPtr, "bRecalcPointPerWave");
		bRecalcPointPerWave_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRecalcPointPerWave");
		bRecalcPointPerWave_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRecalcPointPerWave", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSpawnBySelfMode_PropertyAddress, intPtr, "bSpawnBySelfMode");
		bSpawnBySelfMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSpawnBySelfMode");
		bSpawnBySelfMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSpawnBySelfMode", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DirBaseOnParent_PropertyAddress, intPtr, "DirBaseOnParent");
		DirBaseOnParent_Offset = NativeReflection.GetPropertyOffset(intPtr, "DirBaseOnParent");
		DirBaseOnParent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DirBaseOnParent", Classes.FBoolProperty);
		RangeDir_X_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeDir_X");
		RangeDir_X_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeDir_X", Classes.FStructProperty);
		RangeDir_Y_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeDir_Y");
		RangeDir_Y_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeDir_Y", Classes.FStructProperty);
		RangeDir_Z_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeDir_Z");
		RangeDir_Z_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeDir_Z", Classes.FStructProperty);
		LineTraceMaxLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTraceMaxLength");
		LineTraceMaxLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTraceMaxLength", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TraceTypeQuery_PropertyAddress, intPtr, "TraceTypeQuery");
		TraceTypeQuery_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceTypeQuery");
		TraceTypeQuery_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceTypeQuery", Classes.FEnumProperty);
		PointMinBetween_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointMinBetween");
		PointMinBetween_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointMinBetween", Classes.FFloatProperty);
		LightningFXSpawnConfig_IsValid = ((intPtr != IntPtr.Zero && LightningTemplate_IsValid && DecalActorClass_IsValid && SpawnWaves_IsValid && WaveGap_IsValid && SpawnNumPerWave_IsValid && LightningDelaySpawnDecalTime_IsValid && bRecalcPointPerWave_IsValid && bSpawnBySelfMode_IsValid && DirBaseOnParent_IsValid && RangeDir_X_IsValid && RangeDir_Y_IsValid && RangeDir_Z_IsValid && LineTraceMaxLength_IsValid && TraceTypeQuery_IsValid && PointMinBetween_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.LightningFXSpawnConfig", (byte)LightningFXSpawnConfig_IsValid != 0);
	}

	static FLightningFXSpawnConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FLightningFXSpawnConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLightningFXSpawnConfig));
	}
}
