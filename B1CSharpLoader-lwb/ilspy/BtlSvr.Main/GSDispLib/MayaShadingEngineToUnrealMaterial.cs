using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[USharpPath("/Script/b1-Managed.MayaShadingEngineToUnrealMaterial")]
public struct MayaShadingEngineToUnrealMaterial
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MayaShadingEngineToUnrealMaterial:MayaShadingEngineName")]
	public FName MayaShadingEngineName;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MayaShadingEngineToUnrealMaterial:Material")]
	public UMaterial Material;

	private static int MayaShadingEngineToUnrealMaterial_StructSize;

	private static int MayaShadingEngineToUnrealMaterial_IsValid;

	private static bool MayaShadingEngineName_IsValid;

	private static int MayaShadingEngineName_Offset;

	private static bool Material_IsValid;

	private static int Material_Offset;

	public MayaShadingEngineToUnrealMaterial Copy()
	{
		return this;
	}

	public static MayaShadingEngineToUnrealMaterial FromNative(IntPtr nativeBuffer)
	{
		return new MayaShadingEngineToUnrealMaterial(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, MayaShadingEngineToUnrealMaterial value)
	{
		value.ToNative(nativeBuffer);
	}

	public static MayaShadingEngineToUnrealMaterial FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new MayaShadingEngineToUnrealMaterial(IntPtr.Add(nativeBuffer, arrayIndex * MayaShadingEngineToUnrealMaterial_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, MayaShadingEngineToUnrealMaterial value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MayaShadingEngineToUnrealMaterial_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MayaShadingEngineToUnrealMaterial_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MayaShadingEngineToUnrealMaterial");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MayaShadingEngineName_Offset), MayaShadingEngineName);
		UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(nativeStruct, Material_Offset), Material);
	}

	public MayaShadingEngineToUnrealMaterial(IntPtr nativeStruct)
	{
		if (MayaShadingEngineToUnrealMaterial_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MayaShadingEngineToUnrealMaterial");
			MayaShadingEngineName = default(FName);
			Material = null;
		}
		else
		{
			MayaShadingEngineName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MayaShadingEngineName_Offset));
			Material = UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(nativeStruct, Material_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MayaShadingEngineToUnrealMaterial");
		MayaShadingEngineToUnrealMaterial_StructSize = NativeReflection.GetStructSize(intPtr);
		MayaShadingEngineName_Offset = NativeReflection.GetPropertyOffset(intPtr, "MayaShadingEngineName");
		MayaShadingEngineName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MayaShadingEngineName", Classes.FNameProperty);
		Material_Offset = NativeReflection.GetPropertyOffset(intPtr, "Material");
		Material_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Material", Classes.FObjectProperty);
		MayaShadingEngineToUnrealMaterial_IsValid = ((intPtr != IntPtr.Zero && MayaShadingEngineName_IsValid && Material_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MayaShadingEngineToUnrealMaterial", (byte)MayaShadingEngineToUnrealMaterial_IsValid != 0);
	}

	static MayaShadingEngineToUnrealMaterial()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MayaShadingEngineToUnrealMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MayaShadingEngineToUnrealMaterial));
	}
}
