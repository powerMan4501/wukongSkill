using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[ShortTooltip("GS Montage Move Data")]
[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FGSMontageMoveData")]
public struct FGSMontageMoveData
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("B1")]
	[USharpPath("/Script/b1-Managed.FGSMontageMoveData:Montage")]
	public UAnimMontage Montage;

	[Category("B1")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSMontageMoveData:Scale")]
	public float Scale;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("B1")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSMontageMoveData:PlayTimeRate")]
	public float PlayTimeRate;

	[UProperty]
	[BlueprintReadWrite]
	[Category("B1")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSMontageMoveData:MontagePosOffset")]
	public float MontagePosOffset;

	[Category("B1")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSMontageMoveData:StartSectionName")]
	public FName StartSectionName;

	private static int FGSMontageMoveData_StructSize;

	private static int FGSMontageMoveData_IsValid;

	private static bool Montage_IsValid;

	private static int Montage_Offset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool PlayTimeRate_IsValid;

	private static int PlayTimeRate_Offset;

	private static bool MontagePosOffset_IsValid;

	private static int MontagePosOffset_Offset;

	private static bool StartSectionName_IsValid;

	private static int StartSectionName_Offset;

	public FGSMontageMoveData Copy()
	{
		return this;
	}

	public static FGSMontageMoveData FromNative(IntPtr nativeBuffer)
	{
		return new FGSMontageMoveData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSMontageMoveData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSMontageMoveData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSMontageMoveData(IntPtr.Add(nativeBuffer, arrayIndex * FGSMontageMoveData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSMontageMoveData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSMontageMoveData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSMontageMoveData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSMontageMoveData");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, Montage_Offset), Montage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlayTimeRate_Offset), PlayTimeRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MontagePosOffset_Offset), MontagePosOffset);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StartSectionName_Offset), StartSectionName);
	}

	public FGSMontageMoveData(IntPtr nativeStruct)
	{
		if (FGSMontageMoveData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSMontageMoveData");
			Montage = null;
			Scale = 0f;
			PlayTimeRate = 0f;
			MontagePosOffset = 0f;
			StartSectionName = default(FName);
		}
		else
		{
			Montage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, Montage_Offset));
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			PlayTimeRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlayTimeRate_Offset));
			MontagePosOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MontagePosOffset_Offset));
			StartSectionName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StartSectionName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSMontageMoveData");
		FGSMontageMoveData_StructSize = NativeReflection.GetStructSize(intPtr);
		Montage_Offset = NativeReflection.GetPropertyOffset(intPtr, "Montage");
		Montage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Montage", Classes.FObjectProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		PlayTimeRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayTimeRate");
		PlayTimeRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayTimeRate", Classes.FFloatProperty);
		MontagePosOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "MontagePosOffset");
		MontagePosOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MontagePosOffset", Classes.FFloatProperty);
		StartSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartSectionName");
		StartSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartSectionName", Classes.FNameProperty);
		FGSMontageMoveData_IsValid = ((intPtr != IntPtr.Zero && Montage_IsValid && Scale_IsValid && PlayTimeRate_IsValid && MontagePosOffset_IsValid && StartSectionName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSMontageMoveData", (byte)FGSMontageMoveData_IsValid != 0);
	}

	static FGSMontageMoveData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSMontageMoveData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSMontageMoveData));
	}
}
