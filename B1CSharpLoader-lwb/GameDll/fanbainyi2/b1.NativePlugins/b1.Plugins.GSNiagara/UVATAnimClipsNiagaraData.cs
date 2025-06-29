using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSNiagara;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSNiagara.VATAnimClipsNiagaraData", "GSNiagara", UnrealModuleType.GamePlugin)]
public class UVATAnimClipsNiagaraData : UPrimaryDataAsset
{
	private static bool GlobalInputDirection_IsValid;

	private static int GlobalInputDirection_Offset;

	private static bool GlobalInputIntensity_IsValid;

	private static int GlobalInputIntensity_Offset;

	private static bool CachedDirs_IsValid;

	private static FFieldAddress CachedDirs_PropertyAddress;

	private static int CachedDirs_Offset;

	private TArrayReadWriteMarshaler<FVector2D> CachedDirs_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSNiagara.VATAnimClipsNiagaraData:GlobalInputDirection")]
	public FVector2D GlobalInputDirection
	{
		get
		{
			CheckDestroyed();
			if (!GlobalInputDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.VATAnimClipsNiagaraData:GlobalInputDirection");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, GlobalInputDirection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlobalInputDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.VATAnimClipsNiagaraData:GlobalInputDirection");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, GlobalInputDirection_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSNiagara.VATAnimClipsNiagaraData:GlobalInputIntensity")]
	public float GlobalInputIntensity
	{
		get
		{
			CheckDestroyed();
			if (!GlobalInputIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.VATAnimClipsNiagaraData:GlobalInputIntensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GlobalInputIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlobalInputIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.VATAnimClipsNiagaraData:GlobalInputIntensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GlobalInputIntensity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/GSNiagara.VATAnimClipsNiagaraData:CachedDirs")]
	public TArrayReadWrite<FVector2D> CachedDirs
	{
		get
		{
			CheckDestroyed();
			if (!CachedDirs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.VATAnimClipsNiagaraData:CachedDirs");
				return null;
			}
			if (CachedDirs_MarshalerCached == null)
			{
				CachedDirs_MarshalerCached = new TArrayReadWriteMarshaler<FVector2D>(1, CachedDirs_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative);
			}
			return CachedDirs_MarshalerCached.FromNative(IntPtr.Add(base.Address, CachedDirs_Offset));
		}
	}

	static UVATAnimClipsNiagaraData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVATAnimClipsNiagaraData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVATAnimClipsNiagaraData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSNiagara.VATAnimClipsNiagaraData");
		GlobalInputDirection_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GlobalInputDirection");
		GlobalInputDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GlobalInputDirection", Classes.FStructProperty);
		GlobalInputIntensity_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GlobalInputIntensity");
		GlobalInputIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GlobalInputIntensity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CachedDirs_PropertyAddress, unrealStruct, "CachedDirs");
		CachedDirs_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CachedDirs");
		CachedDirs_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CachedDirs", Classes.FArrayProperty);
	}
}
