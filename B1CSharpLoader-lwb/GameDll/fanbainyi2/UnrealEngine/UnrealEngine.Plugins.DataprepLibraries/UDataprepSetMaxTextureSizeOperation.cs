using System;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepLibraries.DataprepSetMaxTextureSizeOperation", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public class UDataprepSetMaxTextureSizeOperation : UDataprepOperation
{
	private static bool MaxTextureSize_IsValid;

	private static int MaxTextureSize_Offset;

	private static bool AllowPadding_IsValid;

	private static FFieldAddress AllowPadding_PropertyAddress;

	private static int AllowPadding_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetMaxTextureSizeOperation:MaxTextureSize")]
	public int MaxTextureSize
	{
		get
		{
			CheckDestroyed();
			if (!MaxTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMaxTextureSizeOperation:MaxTextureSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxTextureSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxTextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMaxTextureSizeOperation:MaxTextureSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxTextureSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DataprepLibraries.DataprepSetMaxTextureSizeOperation:bAllowPadding")]
	public bool AllowPadding
	{
		get
		{
			CheckDestroyed();
			if (!AllowPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMaxTextureSizeOperation:bAllowPadding");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowPadding_Offset), 0, AllowPadding_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DataprepLibraries.DataprepSetMaxTextureSizeOperation:bAllowPadding");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowPadding_Offset), 0, AllowPadding_PropertyAddress.Address, value);
			}
		}
	}

	static UDataprepSetMaxTextureSizeOperation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDataprepSetMaxTextureSizeOperation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDataprepSetMaxTextureSizeOperation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DataprepLibraries.DataprepSetMaxTextureSizeOperation");
		MaxTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxTextureSize");
		MaxTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxTextureSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowPadding_PropertyAddress, unrealStruct, "bAllowPadding");
		AllowPadding_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAllowPadding");
		AllowPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAllowPadding", Classes.FBoolProperty);
	}
}
