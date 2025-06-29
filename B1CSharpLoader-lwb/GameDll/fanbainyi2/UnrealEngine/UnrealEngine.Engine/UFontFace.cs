using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.FontFace", "Engine", UnrealModuleType.Engine)]
public class UFontFace : UObject, IFontFaceInterface, IInterface
{
	private static bool SourceFilename_IsValid;

	private static int SourceFilename_Offset;

	private static bool Hinting_IsValid;

	private static FFieldAddress Hinting_PropertyAddress;

	private static int Hinting_Offset;

	private static bool LoadingPolicy_IsValid;

	private static FFieldAddress LoadingPolicy_PropertyAddress;

	private static int LoadingPolicy_Offset;

	private static bool LayoutMethod_IsValid;

	private static FFieldAddress LayoutMethod_PropertyAddress;

	private static int LayoutMethod_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/Engine.FontFace:SourceFilename")]
	public string SourceFilename
	{
		get
		{
			CheckDestroyed();
			if (!SourceFilename_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FontFace:SourceFilename");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SourceFilename_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceFilename_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FontFace:SourceFilename");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SourceFilename_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.FontFace:Hinting")]
	public EFontHinting Hinting
	{
		get
		{
			CheckDestroyed();
			if (!Hinting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FontFace:Hinting");
				return EFontHinting.Default;
			}
			return EnumMarshaler<EFontHinting>.FromNative(IntPtr.Add(base.Address, Hinting_Offset), 0, Hinting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Hinting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FontFace:Hinting");
			}
			else
			{
				EnumMarshaler<EFontHinting>.ToNative(IntPtr.Add(base.Address, Hinting_Offset), 0, Hinting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.FontFace:LoadingPolicy")]
	public EFontLoadingPolicy LoadingPolicy
	{
		get
		{
			CheckDestroyed();
			if (!LoadingPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FontFace:LoadingPolicy");
				return EFontLoadingPolicy.LazyLoad;
			}
			return EnumMarshaler<EFontLoadingPolicy>.FromNative(IntPtr.Add(base.Address, LoadingPolicy_Offset), 0, LoadingPolicy_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LoadingPolicy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FontFace:LoadingPolicy");
			}
			else
			{
				EnumMarshaler<EFontLoadingPolicy>.ToNative(IntPtr.Add(base.Address, LoadingPolicy_Offset), 0, LoadingPolicy_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.FontFace:LayoutMethod")]
	public EFontLayoutMethod LayoutMethod
	{
		get
		{
			CheckDestroyed();
			if (!LayoutMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FontFace:LayoutMethod");
				return EFontLayoutMethod.Metrics;
			}
			return EnumMarshaler<EFontLayoutMethod>.FromNative(IntPtr.Add(base.Address, LayoutMethod_Offset), 0, LayoutMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LayoutMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.FontFace:LayoutMethod");
			}
			else
			{
				EnumMarshaler<EFontLayoutMethod>.ToNative(IntPtr.Add(base.Address, LayoutMethod_Offset), 0, LayoutMethod_PropertyAddress.Address, value);
			}
		}
	}

	static UFontFace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFontFace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFontFace));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.FontFace");
		SourceFilename_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceFilename");
		SourceFilename_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceFilename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Hinting_PropertyAddress, unrealStruct, "Hinting");
		Hinting_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Hinting");
		Hinting_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Hinting", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadingPolicy_PropertyAddress, unrealStruct, "LoadingPolicy");
		LoadingPolicy_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LoadingPolicy");
		LoadingPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LoadingPolicy", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LayoutMethod_PropertyAddress, unrealStruct, "LayoutMethod");
		LayoutMethod_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LayoutMethod");
		LayoutMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LayoutMethod", Classes.FEnumProperty);
	}
}
