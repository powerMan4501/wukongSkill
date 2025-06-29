using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGW_DispLibGameDBDataAsset")]
public class BGW_DispLibGameDBDataAsset : UBGWDataAsset
{
	private static bool DispConstDA_IsValid;

	private static int DispConstDA_Offset;

	private static bool CameraEnvFXDA_IsValid;

	private static int CameraEnvFXDA_Offset;

	private static bool FNameCacheDA_IsValid;

	private static int FNameCacheDA_Offset;

	private static bool UniversalArtFresnelCacheDA_IsValid;

	private static int UniversalArtFresnelCacheDA_Offset;

	[BlueprintReadWrite]
	[DisplayName("Display Const DataAsset")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:DispConstDA")]
	public BGW_DispLibConstDataAsset DispConstDA
	{
		get
		{
			CheckDestroyed();
			if (!DispConstDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:DispConstDA");
				return null;
			}
			return UObjectMarshaler<BGW_DispLibConstDataAsset>.FromNative(IntPtr.Add(base.Address, DispConstDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DispConstDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:DispConstDA");
			}
			else
			{
				UObjectMarshaler<BGW_DispLibConstDataAsset>.ToNative(IntPtr.Add(base.Address, DispConstDA_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Camera Env FX DataAsset")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:CameraEnvFXDA")]
	public BGW_DispLibCameraEnvFXDataAsset CameraEnvFXDA
	{
		get
		{
			CheckDestroyed();
			if (!CameraEnvFXDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:CameraEnvFXDA");
				return null;
			}
			return UObjectMarshaler<BGW_DispLibCameraEnvFXDataAsset>.FromNative(IntPtr.Add(base.Address, CameraEnvFXDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraEnvFXDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:CameraEnvFXDA");
			}
			else
			{
				UObjectMarshaler<BGW_DispLibCameraEnvFXDataAsset>.ToNative(IntPtr.Add(base.Address, CameraEnvFXDA_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("FName Cache DataAsset")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:FNameCacheDA")]
	public BGW_DispLibFNameCacheDataAsset FNameCacheDA
	{
		get
		{
			CheckDestroyed();
			if (!FNameCacheDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:FNameCacheDA");
				return null;
			}
			return UObjectMarshaler<BGW_DispLibFNameCacheDataAsset>.FromNative(IntPtr.Add(base.Address, FNameCacheDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FNameCacheDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:FNameCacheDA");
			}
			else
			{
				UObjectMarshaler<BGW_DispLibFNameCacheDataAsset>.ToNative(IntPtr.Add(base.Address, FNameCacheDA_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("Universal Art Fresnel Cache DataAsset")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:UniversalArtFresnelCacheDA")]
	public BGW_DispLibUniversalArtFresnelCacheDataAsset UniversalArtFresnelCacheDA
	{
		get
		{
			CheckDestroyed();
			if (!UniversalArtFresnelCacheDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:UniversalArtFresnelCacheDA");
				return null;
			}
			return UObjectMarshaler<BGW_DispLibUniversalArtFresnelCacheDataAsset>.FromNative(IntPtr.Add(base.Address, UniversalArtFresnelCacheDA_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UniversalArtFresnelCacheDA_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibGameDBDataAsset:UniversalArtFresnelCacheDA");
			}
			else
			{
				UObjectMarshaler<BGW_DispLibUniversalArtFresnelCacheDataAsset>.ToNative(IntPtr.Add(base.Address, UniversalArtFresnelCacheDA_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_DispLibGameDBDataAsset");
		DispConstDA_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DispConstDA");
		DispConstDA_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DispConstDA", Classes.FObjectProperty);
		CameraEnvFXDA_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraEnvFXDA");
		CameraEnvFXDA_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraEnvFXDA", Classes.FObjectProperty);
		FNameCacheDA_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FNameCacheDA");
		FNameCacheDA_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FNameCacheDA", Classes.FObjectProperty);
		UniversalArtFresnelCacheDA_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UniversalArtFresnelCacheDA");
		UniversalArtFresnelCacheDA_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UniversalArtFresnelCacheDA", Classes.FObjectProperty);
	}

	static BGW_DispLibGameDBDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DispLibGameDBDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DispLibGameDBDataAsset));
	}
}
