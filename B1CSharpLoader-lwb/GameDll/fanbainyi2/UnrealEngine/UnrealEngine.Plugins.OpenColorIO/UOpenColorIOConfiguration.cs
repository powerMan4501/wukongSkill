using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OpenColorIO;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/OpenColorIO.OpenColorIOConfiguration", "OpenColorIO", UnrealModuleType.EnginePlugin)]
public class UOpenColorIOConfiguration : UObject
{
	private static bool ConfigurationFile_IsValid;

	private static int ConfigurationFile_Offset;

	private static bool DesiredColorSpaces_IsValid;

	private static FFieldAddress DesiredColorSpaces_PropertyAddress;

	private static int DesiredColorSpaces_Offset;

	private TArrayReadWriteMarshaler<FOpenColorIOColorSpace> DesiredColorSpaces_MarshalerCached;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIOConfiguration:ConfigurationFile")]
	public FFilePath ConfigurationFile
	{
		get
		{
			CheckDestroyed();
			if (!ConfigurationFile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OpenColorIO.OpenColorIOConfiguration:ConfigurationFile");
				return default(FFilePath);
			}
			return FFilePath.FromNative(IntPtr.Add(base.Address, ConfigurationFile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigurationFile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OpenColorIO.OpenColorIOConfiguration:ConfigurationFile");
			}
			else
			{
				FFilePath.ToNative(IntPtr.Add(base.Address, ConfigurationFile_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIOConfiguration:DesiredColorSpaces")]
	public TArrayReadWrite<FOpenColorIOColorSpace> DesiredColorSpaces
	{
		get
		{
			CheckDestroyed();
			if (!DesiredColorSpaces_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/OpenColorIO.OpenColorIOConfiguration:DesiredColorSpaces");
				return null;
			}
			if (DesiredColorSpaces_MarshalerCached == null)
			{
				DesiredColorSpaces_MarshalerCached = new TArrayReadWriteMarshaler<FOpenColorIOColorSpace>(1, DesiredColorSpaces_PropertyAddress, CachedMarshalingDelegates<FOpenColorIOColorSpace, FOpenColorIOColorSpace>.FromNative, CachedMarshalingDelegates<FOpenColorIOColorSpace, FOpenColorIOColorSpace>.ToNative);
			}
			return DesiredColorSpaces_MarshalerCached.FromNative(IntPtr.Add(base.Address, DesiredColorSpaces_Offset));
		}
	}

	static UOpenColorIOConfiguration()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOpenColorIOConfiguration)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOpenColorIOConfiguration));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/OpenColorIO.OpenColorIOConfiguration");
		ConfigurationFile_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ConfigurationFile");
		ConfigurationFile_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ConfigurationFile", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DesiredColorSpaces_PropertyAddress, unrealStruct, "DesiredColorSpaces");
		DesiredColorSpaces_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DesiredColorSpaces");
		DesiredColorSpaces_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DesiredColorSpaces", Classes.FArrayProperty);
	}
}
