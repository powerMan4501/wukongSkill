using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.QuartzQuantizationBoundary", "Engine", UnrealModuleType.Engine)]
public struct FQuartzQuantizationBoundary
{
	private static bool Quantization_IsValid;

	private static FFieldAddress Quantization_PropertyAddress;

	private static int Quantization_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.QuartzQuantizationBoundary:Quantization")]
	public EQuartzCommandQuantization Quantization;

	private static bool Multiplier_IsValid;

	private static int Multiplier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.QuartzQuantizationBoundary:Multiplier")]
	public float Multiplier;

	private static bool CountingReferencePoint_IsValid;

	private static FFieldAddress CountingReferencePoint_PropertyAddress;

	private static int CountingReferencePoint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.QuartzQuantizationBoundary:CountingReferencePoint")]
	public EQuarztQuantizationReference CountingReferencePoint;

	private static bool FireOnClockStart_IsValid;

	private static FFieldAddress FireOnClockStart_PropertyAddress;

	private static int FireOnClockStart_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.QuartzQuantizationBoundary:bFireOnClockStart")]
	public bool FireOnClockStart;

	private static bool CancelCommandIfClockIsNotRunning_IsValid;

	private static FFieldAddress CancelCommandIfClockIsNotRunning_PropertyAddress;

	private static int CancelCommandIfClockIsNotRunning_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.QuartzQuantizationBoundary:bCancelCommandIfClockIsNotRunning")]
	public bool CancelCommandIfClockIsNotRunning;

	private static bool ResetClockOnQueued_IsValid;

	private static FFieldAddress ResetClockOnQueued_PropertyAddress;

	private static int ResetClockOnQueued_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.QuartzQuantizationBoundary:bResetClockOnQueued")]
	public bool ResetClockOnQueued;

	private static bool ResumeClockOnQueued_IsValid;

	private static FFieldAddress ResumeClockOnQueued_PropertyAddress;

	private static int ResumeClockOnQueued_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.QuartzQuantizationBoundary:bResumeClockOnQueued")]
	public bool ResumeClockOnQueued;

	private static bool FQuartzQuantizationBoundary_IsValid;

	private static int FQuartzQuantizationBoundary_StructSize;

	public FQuartzQuantizationBoundary Copy()
	{
		return this;
	}

	public static FQuartzQuantizationBoundary FromNative(IntPtr nativeBuffer)
	{
		return new FQuartzQuantizationBoundary(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FQuartzQuantizationBoundary value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FQuartzQuantizationBoundary FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FQuartzQuantizationBoundary(nativeBuffer + arrayIndex * FQuartzQuantizationBoundary_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FQuartzQuantizationBoundary value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FQuartzQuantizationBoundary_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FQuartzQuantizationBoundary_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzQuantizationBoundary");
			return;
		}
		EnumMarshaler<EQuartzCommandQuantization>.ToNative(IntPtr.Add(nativeStruct, Quantization_Offset), 0, Quantization_PropertyAddress.Address, Quantization);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Multiplier_Offset), Multiplier);
		EnumMarshaler<EQuarztQuantizationReference>.ToNative(IntPtr.Add(nativeStruct, CountingReferencePoint_Offset), 0, CountingReferencePoint_PropertyAddress.Address, CountingReferencePoint);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FireOnClockStart_Offset), 0, FireOnClockStart_PropertyAddress.Address, FireOnClockStart);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CancelCommandIfClockIsNotRunning_Offset), 0, CancelCommandIfClockIsNotRunning_PropertyAddress.Address, CancelCommandIfClockIsNotRunning);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ResetClockOnQueued_Offset), 0, ResetClockOnQueued_PropertyAddress.Address, ResetClockOnQueued);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ResumeClockOnQueued_Offset), 0, ResumeClockOnQueued_PropertyAddress.Address, ResumeClockOnQueued);
	}

	public FQuartzQuantizationBoundary(IntPtr nativeStruct)
	{
		if (!FQuartzQuantizationBoundary_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.QuartzQuantizationBoundary");
			Quantization = EQuartzCommandQuantization.Bar;
			Multiplier = 0f;
			CountingReferencePoint = EQuarztQuantizationReference.BarRelative;
			FireOnClockStart = false;
			CancelCommandIfClockIsNotRunning = false;
			ResetClockOnQueued = false;
			ResumeClockOnQueued = false;
		}
		else
		{
			Quantization = EnumMarshaler<EQuartzCommandQuantization>.FromNative(IntPtr.Add(nativeStruct, Quantization_Offset), 0, Quantization_PropertyAddress.Address);
			Multiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Multiplier_Offset));
			CountingReferencePoint = EnumMarshaler<EQuarztQuantizationReference>.FromNative(IntPtr.Add(nativeStruct, CountingReferencePoint_Offset), 0, CountingReferencePoint_PropertyAddress.Address);
			FireOnClockStart = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FireOnClockStart_Offset), 0, FireOnClockStart_PropertyAddress.Address);
			CancelCommandIfClockIsNotRunning = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CancelCommandIfClockIsNotRunning_Offset), 0, CancelCommandIfClockIsNotRunning_PropertyAddress.Address);
			ResetClockOnQueued = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ResetClockOnQueued_Offset), 0, ResetClockOnQueued_PropertyAddress.Address);
			ResumeClockOnQueued = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ResumeClockOnQueued_Offset), 0, ResumeClockOnQueued_PropertyAddress.Address);
		}
	}

	static FQuartzQuantizationBoundary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FQuartzQuantizationBoundary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FQuartzQuantizationBoundary));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.QuartzQuantizationBoundary");
		FQuartzQuantizationBoundary_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Quantization_PropertyAddress, intPtr, "Quantization");
		Quantization_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Quantization");
		Quantization_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Quantization", Classes.FEnumProperty);
		Multiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Multiplier");
		Multiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Multiplier", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CountingReferencePoint_PropertyAddress, intPtr, "CountingReferencePoint");
		CountingReferencePoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CountingReferencePoint");
		CountingReferencePoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CountingReferencePoint", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FireOnClockStart_PropertyAddress, intPtr, "bFireOnClockStart");
		FireOnClockStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFireOnClockStart");
		FireOnClockStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFireOnClockStart", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CancelCommandIfClockIsNotRunning_PropertyAddress, intPtr, "bCancelCommandIfClockIsNotRunning");
		CancelCommandIfClockIsNotRunning_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCancelCommandIfClockIsNotRunning");
		CancelCommandIfClockIsNotRunning_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCancelCommandIfClockIsNotRunning", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetClockOnQueued_PropertyAddress, intPtr, "bResetClockOnQueued");
		ResetClockOnQueued_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bResetClockOnQueued");
		ResetClockOnQueued_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bResetClockOnQueued", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ResumeClockOnQueued_PropertyAddress, intPtr, "bResumeClockOnQueued");
		ResumeClockOnQueued_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bResumeClockOnQueued");
		ResumeClockOnQueued_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bResumeClockOnQueued", Classes.FBoolProperty);
		FQuartzQuantizationBoundary_IsValid = intPtr != IntPtr.Zero && Quantization_IsValid && Multiplier_IsValid && CountingReferencePoint_IsValid && FireOnClockStart_IsValid && CancelCommandIfClockIsNotRunning_IsValid && ResetClockOnQueued_IsValid && ResumeClockOnQueued_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.QuartzQuantizationBoundary", FQuartzQuantizationBoundary_IsValid);
	}
}
