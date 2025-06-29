using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessContext")]
public class GSDispLib_PostProcessContext : UObject
{
	private static bool PostProcessVolume_IsValid;

	private static int PostProcessVolume_Offset;

	private static bool World_IsValid;

	private static int World_Offset;

	private static bool Config_IsValid;

	private static int Config_Offset;

	private static bool ImageProcessor_IsValid;

	private static int ImageProcessor_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessContext:PostProcessVolume")]
	public APostProcessVolume PostProcessVolume
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessContext:PostProcessVolume");
				return null;
			}
			return UObjectMarshaler<APostProcessVolume>.FromNative(IntPtr.Add(base.Address, PostProcessVolume_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessContext:PostProcessVolume");
			}
			else
			{
				UObjectMarshaler<APostProcessVolume>.ToNative(IntPtr.Add(base.Address, PostProcessVolume_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessContext:World")]
	public UWorld World
	{
		get
		{
			CheckDestroyed();
			if (!World_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessContext:World");
				return null;
			}
			return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(base.Address, World_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!World_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessContext:World");
			}
			else
			{
				UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(base.Address, World_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessContext:Config")]
	public UDispLib_PostProcessConf Config
	{
		get
		{
			CheckDestroyed();
			if (!Config_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessContext:Config");
				return null;
			}
			return UObjectMarshaler<UDispLib_PostProcessConf>.FromNative(IntPtr.Add(base.Address, Config_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Config_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessContext:Config");
			}
			else
			{
				UObjectMarshaler<UDispLib_PostProcessConf>.ToNative(IntPtr.Add(base.Address, Config_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSDispLib_PostProcessContext:ImageProcessor")]
	public BWS_DispLibImageProcessor ImageProcessor
	{
		get
		{
			CheckDestroyed();
			if (!ImageProcessor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessContext:ImageProcessor");
				return null;
			}
			return UObjectMarshaler<BWS_DispLibImageProcessor>.FromNative(IntPtr.Add(base.Address, ImageProcessor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImageProcessor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDispLib_PostProcessContext:ImageProcessor");
			}
			else
			{
				UObjectMarshaler<BWS_DispLibImageProcessor>.ToNative(IntPtr.Add(base.Address, ImageProcessor_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSDispLib_PostProcessContext");
		PostProcessVolume_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PostProcessVolume");
		PostProcessVolume_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PostProcessVolume", Classes.FObjectProperty);
		World_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "World");
		World_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "World", Classes.FObjectProperty);
		Config_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Config");
		Config_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Config", Classes.FObjectProperty);
		ImageProcessor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImageProcessor");
		ImageProcessor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImageProcessor", Classes.FObjectProperty);
	}

	static GSDispLib_PostProcessContext()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib_PostProcessContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib_PostProcessContext));
	}
}
