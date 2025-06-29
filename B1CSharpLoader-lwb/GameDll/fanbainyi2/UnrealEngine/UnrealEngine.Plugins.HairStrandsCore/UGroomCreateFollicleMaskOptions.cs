using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class UGroomCreateFollicleMaskOptions : UObject
{
	private static bool Resolution_IsValid;

	private static int Resolution_Offset;

	private static bool RootRadius_IsValid;

	private static int RootRadius_Offset;

	private static bool Grooms_IsValid;

	private static FFieldAddress Grooms_PropertyAddress;

	private static int Grooms_Offset;

	private TArrayReadWriteMarshaler<FFollicleMaskOptions> Grooms_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions:Resolution")]
	public int Resolution
	{
		get
		{
			CheckDestroyed();
			if (!Resolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions:Resolution");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Resolution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Resolution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions:Resolution");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Resolution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions:RootRadius")]
	public int RootRadius
	{
		get
		{
			CheckDestroyed();
			if (!RootRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions:RootRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RootRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions:RootRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RootRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions:Grooms")]
	public TArrayReadWrite<FFollicleMaskOptions> Grooms
	{
		get
		{
			CheckDestroyed();
			if (!Grooms_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions:Grooms");
				return null;
			}
			if (Grooms_MarshalerCached == null)
			{
				Grooms_MarshalerCached = new TArrayReadWriteMarshaler<FFollicleMaskOptions>(1, Grooms_PropertyAddress, CachedMarshalingDelegates<FFollicleMaskOptions, FFollicleMaskOptions>.FromNative, CachedMarshalingDelegates<FFollicleMaskOptions, FFollicleMaskOptions>.ToNative);
			}
			return Grooms_MarshalerCached.FromNative(IntPtr.Add(base.Address, Grooms_Offset));
		}
	}

	static UGroomCreateFollicleMaskOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroomCreateFollicleMaskOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroomCreateFollicleMaskOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HairStrandsCore.GroomCreateFollicleMaskOptions");
		Resolution_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Resolution");
		Resolution_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Resolution", Classes.FIntProperty);
		RootRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RootRadius");
		RootRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RootRadius", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Grooms_PropertyAddress, unrealStruct, "Grooms");
		Grooms_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Grooms");
		Grooms_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Grooms", Classes.FArrayProperty);
	}
}
