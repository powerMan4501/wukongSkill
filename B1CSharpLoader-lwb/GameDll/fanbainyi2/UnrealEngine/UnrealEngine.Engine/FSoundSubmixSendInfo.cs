using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundSubmixSendInfo", "Engine", UnrealModuleType.Engine)]
public struct FSoundSubmixSendInfo
{
	private static bool SendLevelControlMethod_IsValid;

	private static FFieldAddress SendLevelControlMethod_PropertyAddress;

	private static int SendLevelControlMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:SendLevelControlMethod")]
	public ESendLevelControlMethod SendLevelControlMethod;

	private static bool SendStage_IsValid;

	private static FFieldAddress SendStage_PropertyAddress;

	private static int SendStage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:SendStage")]
	public ESubmixSendStage SendStage;

	private static bool SoundSubmix_IsValid;

	private static int SoundSubmix_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:SoundSubmix")]
	public USoundSubmixBase SoundSubmix;

	private static bool SendLevel_IsValid;

	private static int SendLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:SendLevel")]
	public float SendLevel;

	private static bool DisableManualSendClamp_IsValid;

	private static FFieldAddress DisableManualSendClamp_PropertyAddress;

	private static int DisableManualSendClamp_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:DisableManualSendClamp")]
	public bool DisableManualSendClamp;

	private static bool MinSendLevel_IsValid;

	private static int MinSendLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:MinSendLevel")]
	public float MinSendLevel;

	private static bool MaxSendLevel_IsValid;

	private static int MaxSendLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:MaxSendLevel")]
	public float MaxSendLevel;

	private static bool MinSendDistance_IsValid;

	private static int MinSendDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:MinSendDistance")]
	public float MinSendDistance;

	private static bool MaxSendDistance_IsValid;

	private static int MaxSendDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:MaxSendDistance")]
	public float MaxSendDistance;

	private static bool CustomSendLevelCurve_IsValid;

	private static int CustomSendLevelCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSendInfo:CustomSendLevelCurve")]
	public FRuntimeFloatCurve CustomSendLevelCurve;

	private static bool FSoundSubmixSendInfo_IsValid;

	private static int FSoundSubmixSendInfo_StructSize;

	public FSoundSubmixSendInfo Copy()
	{
		return this;
	}

	public static FSoundSubmixSendInfo FromNative(IntPtr nativeBuffer)
	{
		return new FSoundSubmixSendInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundSubmixSendInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundSubmixSendInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundSubmixSendInfo(nativeBuffer + arrayIndex * FSoundSubmixSendInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundSubmixSendInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundSubmixSendInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundSubmixSendInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundSubmixSendInfo");
			return;
		}
		EnumMarshaler<ESendLevelControlMethod>.ToNative(IntPtr.Add(nativeStruct, SendLevelControlMethod_Offset), 0, SendLevelControlMethod_PropertyAddress.Address, SendLevelControlMethod);
		EnumMarshaler<ESubmixSendStage>.ToNative(IntPtr.Add(nativeStruct, SendStage_Offset), 0, SendStage_PropertyAddress.Address, SendStage);
		UObjectMarshaler<USoundSubmixBase>.ToNative(IntPtr.Add(nativeStruct, SoundSubmix_Offset), SoundSubmix);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SendLevel_Offset), SendLevel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableManualSendClamp_Offset), 0, DisableManualSendClamp_PropertyAddress.Address, DisableManualSendClamp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSendLevel_Offset), MinSendLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxSendLevel_Offset), MaxSendLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSendDistance_Offset), MinSendDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxSendDistance_Offset), MaxSendDistance);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, CustomSendLevelCurve_Offset), CustomSendLevelCurve);
	}

	public FSoundSubmixSendInfo(IntPtr nativeStruct)
	{
		if (!FSoundSubmixSendInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundSubmixSendInfo");
			SendLevelControlMethod = ESendLevelControlMethod.Linear;
			SendStage = ESubmixSendStage.PostDistanceAttenuation;
			SoundSubmix = null;
			SendLevel = 0f;
			DisableManualSendClamp = false;
			MinSendLevel = 0f;
			MaxSendLevel = 0f;
			MinSendDistance = 0f;
			MaxSendDistance = 0f;
			CustomSendLevelCurve = default(FRuntimeFloatCurve);
		}
		else
		{
			SendLevelControlMethod = EnumMarshaler<ESendLevelControlMethod>.FromNative(IntPtr.Add(nativeStruct, SendLevelControlMethod_Offset), 0, SendLevelControlMethod_PropertyAddress.Address);
			SendStage = EnumMarshaler<ESubmixSendStage>.FromNative(IntPtr.Add(nativeStruct, SendStage_Offset), 0, SendStage_PropertyAddress.Address);
			SoundSubmix = UObjectMarshaler<USoundSubmixBase>.FromNative(IntPtr.Add(nativeStruct, SoundSubmix_Offset));
			SendLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SendLevel_Offset));
			DisableManualSendClamp = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableManualSendClamp_Offset), 0, DisableManualSendClamp_PropertyAddress.Address);
			MinSendLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSendLevel_Offset));
			MaxSendLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxSendLevel_Offset));
			MinSendDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSendDistance_Offset));
			MaxSendDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxSendDistance_Offset));
			CustomSendLevelCurve = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, CustomSendLevelCurve_Offset));
		}
	}

	static FSoundSubmixSendInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundSubmixSendInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundSubmixSendInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundSubmixSendInfo");
		FSoundSubmixSendInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SendLevelControlMethod_PropertyAddress, intPtr, "SendLevelControlMethod");
		SendLevelControlMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SendLevelControlMethod");
		SendLevelControlMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SendLevelControlMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SendStage_PropertyAddress, intPtr, "SendStage");
		SendStage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SendStage");
		SendStage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SendStage", Classes.FEnumProperty);
		SoundSubmix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoundSubmix");
		SoundSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoundSubmix", Classes.FObjectProperty);
		SendLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SendLevel");
		SendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SendLevel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableManualSendClamp_PropertyAddress, intPtr, "DisableManualSendClamp");
		DisableManualSendClamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisableManualSendClamp");
		DisableManualSendClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisableManualSendClamp", Classes.FBoolProperty);
		MinSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSendLevel");
		MinSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSendLevel", Classes.FFloatProperty);
		MaxSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSendLevel");
		MaxSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSendLevel", Classes.FFloatProperty);
		MinSendDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSendDistance");
		MinSendDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSendDistance", Classes.FFloatProperty);
		MaxSendDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSendDistance");
		MaxSendDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSendDistance", Classes.FFloatProperty);
		CustomSendLevelCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomSendLevelCurve");
		CustomSendLevelCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomSendLevelCurve", Classes.FStructProperty);
		FSoundSubmixSendInfo_IsValid = intPtr != IntPtr.Zero && SendLevelControlMethod_IsValid && SendStage_IsValid && SoundSubmix_IsValid && SendLevel_IsValid && DisableManualSendClamp_IsValid && MinSendLevel_IsValid && MaxSendLevel_IsValid && MinSendDistance_IsValid && MaxSendDistance_IsValid && CustomSendLevelCurve_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundSubmixSendInfo", FSoundSubmixSendInfo_IsValid);
	}
}
