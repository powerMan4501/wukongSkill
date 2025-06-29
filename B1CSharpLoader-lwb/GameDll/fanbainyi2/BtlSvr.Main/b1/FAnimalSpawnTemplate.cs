using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimalSpawnTemplate")]
public struct FAnimalSpawnTemplate
{
	[DisplayName("生物TamerClass")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimalSpawnTemplate:AnimalTamerClass")]
	public TSubclassOf<BUTamerActor> AnimalTamerClass;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("生成数量")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimalSpawnTemplate:SpawnCountRange")]
	public FInt32Range SpawnCountRange;

	[UProperty]
	[DisplayName("随机缩放")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimalSpawnTemplate:ScaleRange")]
	public FFloatRange ScaleRange;

	private static int AnimalSpawnTemplate_StructSize;

	private static int AnimalSpawnTemplate_IsValid;

	private static bool AnimalTamerClass_IsValid;

	private static int AnimalTamerClass_Offset;

	private static bool SpawnCountRange_IsValid;

	private static int SpawnCountRange_Offset;

	private static bool ScaleRange_IsValid;

	private static int ScaleRange_Offset;

	public FAnimalSpawnTemplate Copy()
	{
		return this;
	}

	public static FAnimalSpawnTemplate FromNative(IntPtr nativeBuffer)
	{
		return new FAnimalSpawnTemplate(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimalSpawnTemplate value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimalSpawnTemplate FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimalSpawnTemplate(IntPtr.Add(nativeBuffer, arrayIndex * AnimalSpawnTemplate_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimalSpawnTemplate value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimalSpawnTemplate_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimalSpawnTemplate_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimalSpawnTemplate");
			return;
		}
		TSubclassOfMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, AnimalTamerClass_Offset), AnimalTamerClass);
		BlittableTypeMarshaler<FInt32Range>.ToNative(IntPtr.Add(nativeStruct, SpawnCountRange_Offset), SpawnCountRange);
		BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(nativeStruct, ScaleRange_Offset), ScaleRange);
	}

	public FAnimalSpawnTemplate(IntPtr nativeStruct)
	{
		if (AnimalSpawnTemplate_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimalSpawnTemplate");
			AnimalTamerClass = default(TSubclassOf<BUTamerActor>);
			SpawnCountRange = default(FInt32Range);
			ScaleRange = default(FFloatRange);
		}
		else
		{
			AnimalTamerClass = TSubclassOfMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, AnimalTamerClass_Offset));
			SpawnCountRange = BlittableTypeMarshaler<FInt32Range>.FromNative(IntPtr.Add(nativeStruct, SpawnCountRange_Offset));
			ScaleRange = BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(nativeStruct, ScaleRange_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimalSpawnTemplate");
		AnimalSpawnTemplate_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimalTamerClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimalTamerClass");
		AnimalTamerClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimalTamerClass", Classes.FClassProperty);
		SpawnCountRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnCountRange");
		SpawnCountRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnCountRange", Classes.FStructProperty);
		ScaleRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScaleRange");
		ScaleRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScaleRange", Classes.FStructProperty);
		AnimalSpawnTemplate_IsValid = ((intPtr != IntPtr.Zero && AnimalTamerClass_IsValid && SpawnCountRange_IsValid && ScaleRange_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimalSpawnTemplate", (byte)AnimalSpawnTemplate_IsValid != 0);
	}

	static FAnimalSpawnTemplate()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimalSpawnTemplate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimalSpawnTemplate));
	}
}
