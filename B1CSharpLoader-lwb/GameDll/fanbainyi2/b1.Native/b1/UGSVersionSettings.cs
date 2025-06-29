using System;
using UnrealEngine.DeveloperSettings;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549414uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/b1.GSVersionSettings", "b1", UnrealModuleType.Game)]
public class UGSVersionSettings : UDeveloperSettings
{
	private static bool AppVersion_IsValid;

	private static int AppVersion_Offset;

	private static bool PS5MasterVersion_IsValid;

	private static int PS5MasterVersion_Offset;

	private static bool XBoxMasterVersion_IsValid;

	private static int XBoxMasterVersion_Offset;

	private static bool Revision_IsValid;

	private static int Revision_Offset;

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/b1.GSVersionSettings:AppVersion")]
	public string AppVersion
	{
		get
		{
			CheckDestroyed();
			if (!AppVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSVersionSettings:AppVersion");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, AppVersion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AppVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSVersionSettings:AppVersion");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, AppVersion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/b1.GSVersionSettings:PS5MasterVersion")]
	public string PS5MasterVersion
	{
		get
		{
			CheckDestroyed();
			if (!PS5MasterVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSVersionSettings:PS5MasterVersion");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PS5MasterVersion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PS5MasterVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSVersionSettings:PS5MasterVersion");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PS5MasterVersion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/b1.GSVersionSettings:XBoxMasterVersion")]
	public string XBoxMasterVersion
	{
		get
		{
			CheckDestroyed();
			if (!XBoxMasterVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSVersionSettings:XBoxMasterVersion");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, XBoxMasterVersion_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XBoxMasterVersion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSVersionSettings:XBoxMasterVersion");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, XBoxMasterVersion_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/b1.GSVersionSettings:Revision")]
	public int Revision
	{
		get
		{
			CheckDestroyed();
			if (!Revision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSVersionSettings:Revision");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Revision_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Revision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSVersionSettings:Revision");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Revision_Offset), value);
			}
		}
	}

	static UGSVersionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSVersionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSVersionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.GSVersionSettings");
		AppVersion_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AppVersion");
		AppVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AppVersion", Classes.FStrProperty);
		PS5MasterVersion_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PS5MasterVersion");
		PS5MasterVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PS5MasterVersion", Classes.FStrProperty);
		XBoxMasterVersion_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "XBoxMasterVersion");
		XBoxMasterVersion_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "XBoxMasterVersion", Classes.FStrProperty);
		Revision_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Revision");
		Revision_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Revision", Classes.FIntProperty);
	}
}
