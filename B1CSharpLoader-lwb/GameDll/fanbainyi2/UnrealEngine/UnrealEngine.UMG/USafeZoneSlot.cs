using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.SafeZoneSlot", "UMG", UnrealModuleType.Engine)]
public class USafeZoneSlot : UPanelSlot
{
	private static bool IsTitleSafe_IsValid;

	private static FFieldAddress IsTitleSafe_PropertyAddress;

	private static int IsTitleSafe_Offset;

	private static bool SafeAreaScale_IsValid;

	private static int SafeAreaScale_Offset;

	private static bool HAlign_IsValid;

	private static FFieldAddress HAlign_PropertyAddress;

	private static int HAlign_Offset;

	private static bool VAlign_IsValid;

	private static FFieldAddress VAlign_PropertyAddress;

	private static int VAlign_Offset;

	private static bool Padding_IsValid;

	private static int Padding_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SafeZoneSlot:bIsTitleSafe")]
	public bool IsTitleSafe
	{
		get
		{
			CheckDestroyed();
			if (!IsTitleSafe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:bIsTitleSafe");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsTitleSafe_Offset), 0, IsTitleSafe_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsTitleSafe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:bIsTitleSafe");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsTitleSafe_Offset), 0, IsTitleSafe_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.SafeZoneSlot:SafeAreaScale")]
	public FMargin SafeAreaScale
	{
		get
		{
			CheckDestroyed();
			if (!SafeAreaScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:SafeAreaScale");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, SafeAreaScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SafeAreaScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:SafeAreaScale");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, SafeAreaScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SafeZoneSlot:HAlign")]
	public EHorizontalAlignment HAlign
	{
		get
		{
			CheckDestroyed();
			if (!HAlign_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:HAlign");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HAlign_Offset), 0, HAlign_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HAlign_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:HAlign");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HAlign_Offset), 0, HAlign_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SafeZoneSlot:VAlign")]
	public EVerticalAlignment VAlign
	{
		get
		{
			CheckDestroyed();
			if (!VAlign_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:VAlign");
				return EVerticalAlignment.VAlign_Fill;
			}
			return EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(base.Address, VAlign_Offset), 0, VAlign_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VAlign_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:VAlign");
			}
			else
			{
				EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(base.Address, VAlign_Offset), 0, VAlign_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.SafeZoneSlot:Padding")]
	public FMargin Padding
	{
		get
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:Padding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, Padding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SafeZoneSlot:Padding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, Padding_Offset), value);
			}
		}
	}

	static USafeZoneSlot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USafeZoneSlot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USafeZoneSlot));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UMG.SafeZoneSlot");
		NativeReflectionCached.GetPropertyRef(ref IsTitleSafe_PropertyAddress, unrealStruct, "bIsTitleSafe");
		IsTitleSafe_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIsTitleSafe");
		IsTitleSafe_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIsTitleSafe", Classes.FBoolProperty);
		SafeAreaScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SafeAreaScale");
		SafeAreaScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SafeAreaScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HAlign_PropertyAddress, unrealStruct, "HAlign");
		HAlign_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HAlign");
		HAlign_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HAlign", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VAlign_PropertyAddress, unrealStruct, "VAlign");
		VAlign_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VAlign");
		VAlign_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VAlign", Classes.FByteProperty);
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Padding", Classes.FStructProperty);
	}
}
