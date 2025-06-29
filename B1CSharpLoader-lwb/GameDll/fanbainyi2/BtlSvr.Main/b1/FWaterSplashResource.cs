using System;
using b1.Plugins.AkAudio;
using GSDispLib;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.WaterSplashResource")]
public struct FWaterSplashResource
{
	public static string ParamName_WaterSplashDir;

	public static string ParamName_WorldSweepTangent;

	[BlueprintReadWrite]
	[DisplayName("特效应用朝向信息")]
	[Tooltip("2D离心方向,Niagara传参参数名“User.WaterSplashDir”")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.WaterSplashResource:ApplyDir")]
	public bool ApplyDir;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.WaterSplashResource:AdvanceNiagara")]
	public BUC_DispLibDBC_PlayAdvanceNiagara AdvanceNiagara;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.WaterSplashResource:NiagaraSys")]
	public UNiagaraSystem NiagaraSys;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.WaterSplashResource:AkEvent")]
	public UAkAudioEvent AkEvent;

	private static int WaterSplashResource_StructSize;

	private static int WaterSplashResource_IsValid;

	private static bool ApplyDir_IsValid;

	private static int ApplyDir_Offset;

	private static FFieldAddress ApplyDir_PropertyAddress;

	private static bool AdvanceNiagara_IsValid;

	private static int AdvanceNiagara_Offset;

	private static bool NiagaraSys_IsValid;

	private static int NiagaraSys_Offset;

	private static bool AkEvent_IsValid;

	private static int AkEvent_Offset;

	static FWaterSplashResource()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FWaterSplashResource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterSplashResource));
		ParamName_WaterSplashDir = "User.WaterSplashDir";
		ParamName_WorldSweepTangent = "User.Tangent";
	}

	public FWaterSplashResource Copy()
	{
		return this;
	}

	public static FWaterSplashResource FromNative(IntPtr nativeBuffer)
	{
		return new FWaterSplashResource(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterSplashResource value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterSplashResource FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterSplashResource(IntPtr.Add(nativeBuffer, arrayIndex * WaterSplashResource_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterSplashResource value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * WaterSplashResource_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (WaterSplashResource_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.WaterSplashResource");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyDir_Offset), 0, ApplyDir_PropertyAddress.Address, ApplyDir);
		BUC_DispLibDBC_PlayAdvanceNiagara.ToNative(IntPtr.Add(nativeStruct, AdvanceNiagara_Offset), AdvanceNiagara);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, NiagaraSys_Offset), NiagaraSys);
		UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(nativeStruct, AkEvent_Offset), AkEvent);
	}

	public FWaterSplashResource(IntPtr nativeStruct)
	{
		if (WaterSplashResource_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.WaterSplashResource");
			ApplyDir = false;
			AdvanceNiagara = default(BUC_DispLibDBC_PlayAdvanceNiagara);
			NiagaraSys = null;
			AkEvent = null;
		}
		else
		{
			ApplyDir = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyDir_Offset), 0, ApplyDir_PropertyAddress.Address);
			AdvanceNiagara = BUC_DispLibDBC_PlayAdvanceNiagara.FromNative(IntPtr.Add(nativeStruct, AdvanceNiagara_Offset));
			NiagaraSys = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, NiagaraSys_Offset));
			AkEvent = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(nativeStruct, AkEvent_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.WaterSplashResource");
		WaterSplashResource_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ApplyDir_PropertyAddress, intPtr, "ApplyDir");
		ApplyDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "ApplyDir");
		ApplyDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ApplyDir", Classes.FBoolProperty);
		AdvanceNiagara_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdvanceNiagara");
		AdvanceNiagara_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdvanceNiagara", Classes.FStructProperty);
		NiagaraSys_Offset = NativeReflection.GetPropertyOffset(intPtr, "NiagaraSys");
		NiagaraSys_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NiagaraSys", Classes.FObjectProperty);
		AkEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEvent");
		AkEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEvent", Classes.FObjectProperty);
		WaterSplashResource_IsValid = ((intPtr != IntPtr.Zero && ApplyDir_IsValid && AdvanceNiagara_IsValid && NiagaraSys_IsValid && AkEvent_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.WaterSplashResource", (byte)WaterSplashResource_IsValid != 0);
	}
}
