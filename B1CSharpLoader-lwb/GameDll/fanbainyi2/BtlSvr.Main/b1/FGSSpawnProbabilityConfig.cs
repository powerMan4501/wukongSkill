using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityConfig")]
public struct FGSSpawnProbabilityConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityConfig:Describe")]
	public string Describe;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityConfig:MaxNum")]
	public int MaxNum;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityConfig:MinNum")]
	public int MinNum;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityConfig:PlusRate")]
	public int PlusRate;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityConfig:ChiefRate")]
	public int ChiefRate;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityConfig:FreshDelta")]
	public int FreshDelta;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSSpawnProbabilityConfig:ActorDict")]
	public Dictionary<int, string> ActorDict;

	private static int FGSSpawnProbabilityConfig_StructSize;

	private static int FGSSpawnProbabilityConfig_IsValid;

	private static bool Describe_IsValid;

	private static int Describe_Offset;

	private static bool MaxNum_IsValid;

	private static int MaxNum_Offset;

	private static bool MinNum_IsValid;

	private static int MinNum_Offset;

	private static bool PlusRate_IsValid;

	private static int PlusRate_Offset;

	private static bool ChiefRate_IsValid;

	private static int ChiefRate_Offset;

	private static bool FreshDelta_IsValid;

	private static int FreshDelta_Offset;

	private static bool ActorDict_IsValid;

	private static int ActorDict_Offset;

	private static FFieldAddress ActorDict_PropertyAddress;

	public FGSSpawnProbabilityConfig Copy()
	{
		FGSSpawnProbabilityConfig result = this;
		if (ActorDict != null)
		{
			result.ActorDict = new Dictionary<int, string>(ActorDict);
		}
		return result;
	}

	public static FGSSpawnProbabilityConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSSpawnProbabilityConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSpawnProbabilityConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSpawnProbabilityConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSpawnProbabilityConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSSpawnProbabilityConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSpawnProbabilityConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSpawnProbabilityConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSpawnProbabilityConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSpawnProbabilityConfig");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Describe_Offset), Describe);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxNum_Offset), MaxNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MinNum_Offset), MinNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PlusRate_Offset), PlusRate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ChiefRate_Offset), ChiefRate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FreshDelta_Offset), FreshDelta);
		new TMapCopyMarshaler<int, string>(1, ActorDict_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, ActorDict_Offset), ActorDict);
	}

	public FGSSpawnProbabilityConfig(IntPtr nativeStruct)
	{
		if (FGSSpawnProbabilityConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSpawnProbabilityConfig");
			Describe = null;
			MaxNum = 0;
			MinNum = 0;
			PlusRate = 0;
			ChiefRate = 0;
			FreshDelta = 0;
			ActorDict = null;
		}
		else
		{
			Describe = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Describe_Offset));
			MaxNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxNum_Offset));
			MinNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MinNum_Offset));
			PlusRate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PlusRate_Offset));
			ChiefRate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ChiefRate_Offset));
			FreshDelta = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FreshDelta_Offset));
			ActorDict = new TMapCopyMarshaler<int, string>(1, ActorDict_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, ActorDict_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSpawnProbabilityConfig");
		FGSSpawnProbabilityConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Describe_Offset = NativeReflection.GetPropertyOffset(intPtr, "Describe");
		Describe_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Describe", Classes.FStrProperty);
		MaxNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxNum");
		MaxNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxNum", Classes.FIntProperty);
		MinNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinNum");
		MinNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinNum", Classes.FIntProperty);
		PlusRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlusRate");
		PlusRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlusRate", Classes.FIntProperty);
		ChiefRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChiefRate");
		ChiefRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChiefRate", Classes.FIntProperty);
		FreshDelta_Offset = NativeReflection.GetPropertyOffset(intPtr, "FreshDelta");
		FreshDelta_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FreshDelta", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ActorDict_PropertyAddress, intPtr, "ActorDict");
		ActorDict_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorDict");
		ActorDict_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorDict", Classes.FMapProperty);
		FGSSpawnProbabilityConfig_IsValid = ((intPtr != IntPtr.Zero && Describe_IsValid && MaxNum_IsValid && MinNum_IsValid && PlusRate_IsValid && ChiefRate_IsValid && FreshDelta_IsValid && ActorDict_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSpawnProbabilityConfig", (byte)FGSSpawnProbabilityConfig_IsValid != 0);
	}

	static FGSSpawnProbabilityConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSpawnProbabilityConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSpawnProbabilityConfig));
	}
}
