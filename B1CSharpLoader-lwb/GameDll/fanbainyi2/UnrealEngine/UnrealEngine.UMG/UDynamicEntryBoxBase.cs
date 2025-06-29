using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[Abstract]
[UClass(Flags = (ClassFlags)821035169uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.DynamicEntryBoxBase", "UMG", UnrealModuleType.Engine)]
public class UDynamicEntryBoxBase : UWidget
{
	private static bool EntrySpacing_IsValid;

	private static int EntrySpacing_Offset;

	private static bool SpacingPattern_IsValid;

	private static FFieldAddress SpacingPattern_PropertyAddress;

	private static int SpacingPattern_Offset;

	private TArrayReadOnlyMarshaler<FVector2D> SpacingPattern_MarshalerCached;

	private static bool EntrySizeRule_IsValid;

	private static int EntrySizeRule_Offset;

	private static bool EntryHorizontalAlignment_IsValid;

	private static FFieldAddress EntryHorizontalAlignment_PropertyAddress;

	private static int EntryHorizontalAlignment_Offset;

	private static bool EntryVerticalAlignment_IsValid;

	private static FFieldAddress EntryVerticalAlignment_PropertyAddress;

	private static int EntryVerticalAlignment_Offset;

	private static bool MaxElementSize_IsValid;

	private static int MaxElementSize_Offset;

	private static bool RadialBoxSettings_IsValid;

	private static int RadialBoxSettings_Offset;

	private static bool SetRadialSettings_IsValid;

	private static IntPtr SetRadialSettings_FunctionAddress;

	private static int SetRadialSettings_ParamsSize;

	private static bool SetRadialSettings_InSettings_IsValid;

	private static FFieldAddress SetRadialSettings_InSettings_PropertyAddress;

	private static int SetRadialSettings_InSettings_Offset;

	private static bool SetEntrySpacing_IsValid;

	private static IntPtr SetEntrySpacing_FunctionAddress;

	private static int SetEntrySpacing_ParamsSize;

	private static bool SetEntrySpacing_InEntrySpacing_IsValid;

	private static FFieldAddress SetEntrySpacing_InEntrySpacing_PropertyAddress;

	private static int SetEntrySpacing_InEntrySpacing_Offset;

	private static bool GetNumEntries_IsValid;

	private static IntPtr GetNumEntries_FunctionAddress;

	private static int GetNumEntries_ParamsSize;

	private static bool GetNumEntries_ReturnValue_IsValid;

	private static FFieldAddress GetNumEntries_ReturnValue_PropertyAddress;

	private static int GetNumEntries_ReturnValue_Offset;

	private static bool GetAllEntries_IsValid;

	private static IntPtr GetAllEntries_FunctionAddress;

	private static int GetAllEntries_ParamsSize;

	private static bool GetAllEntries_ReturnValue_IsValid;

	private static FFieldAddress GetAllEntries_ReturnValue_PropertyAddress;

	private static int GetAllEntries_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:EntrySpacing")]
	protected FVector2D EntrySpacing
	{
		get
		{
			CheckDestroyed();
			if (!EntrySpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:EntrySpacing");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, EntrySpacing_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EntrySpacing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:EntrySpacing");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, EntrySpacing_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9015995347763733uL)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:SpacingPattern")]
	protected TArrayReadOnly<FVector2D> SpacingPattern
	{
		get
		{
			CheckDestroyed();
			if (!SpacingPattern_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:SpacingPattern");
				return null;
			}
			if (SpacingPattern_MarshalerCached == null)
			{
				SpacingPattern_MarshalerCached = new TArrayReadOnlyMarshaler<FVector2D>(1, SpacingPattern_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative);
			}
			return SpacingPattern_MarshalerCached.FromNative(IntPtr.Add(base.Address, SpacingPattern_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)9016064067239957uL)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:EntrySizeRule")]
	protected FSlateChildSize EntrySizeRule
	{
		get
		{
			CheckDestroyed();
			if (!EntrySizeRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:EntrySizeRule");
				return default(FSlateChildSize);
			}
			return FSlateChildSize.FromNative(IntPtr.Add(base.Address, EntrySizeRule_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EntrySizeRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:EntrySizeRule");
			}
			else
			{
				FSlateChildSize.ToNative(IntPtr.Add(base.Address, EntrySizeRule_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:EntryHorizontalAlignment")]
	protected EHorizontalAlignment EntryHorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!EntryHorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:EntryHorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, EntryHorizontalAlignment_Offset), 0, EntryHorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EntryHorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:EntryHorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, EntryHorizontalAlignment_Offset), 0, EntryHorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:EntryVerticalAlignment")]
	protected EVerticalAlignment EntryVerticalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!EntryVerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:EntryVerticalAlignment");
				return EVerticalAlignment.VAlign_Fill;
			}
			return EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(base.Address, EntryVerticalAlignment_Offset), 0, EntryVerticalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EntryVerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:EntryVerticalAlignment");
			}
			else
			{
				EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(base.Address, EntryVerticalAlignment_Offset), 0, EntryVerticalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:MaxElementSize")]
	protected int MaxElementSize
	{
		get
		{
			CheckDestroyed();
			if (!MaxElementSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:MaxElementSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxElementSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxElementSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:MaxElementSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxElementSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9016064067239957uL)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:RadialBoxSettings")]
	protected FRadialBoxSettings RadialBoxSettings
	{
		get
		{
			CheckDestroyed();
			if (!RadialBoxSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:RadialBoxSettings");
				return default(FRadialBoxSettings);
			}
			return FRadialBoxSettings.FromNative(IntPtr.Add(base.Address, RadialBoxSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RadialBoxSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.DynamicEntryBoxBase:RadialBoxSettings");
			}
			else
			{
				FRadialBoxSettings.ToNative(IntPtr.Add(base.Address, RadialBoxSettings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:SetRadialSettings")]
	public unsafe void SetRadialSettings(FRadialBoxSettings InSettings)
	{
		CheckDestroyed();
		if (!SetRadialSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DynamicEntryBoxBase:SetRadialSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRadialSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRadialSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRadialSettings_InSettings_PropertyAddress.Address, intPtr);
		FRadialBoxSettings.ToNative(IntPtr.Add(intPtr, SetRadialSettings_InSettings_Offset), 0, SetRadialSettings_InSettings_PropertyAddress.Address, InSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRadialSettings_FunctionAddress, intPtr, SetRadialSettings_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:SetEntrySpacing")]
	public unsafe void SetEntrySpacing(FVector2D InEntrySpacing)
	{
		CheckDestroyed();
		if (!SetEntrySpacing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DynamicEntryBoxBase:SetEntrySpacing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEntrySpacing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEntrySpacing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetEntrySpacing_InEntrySpacing_Offset), 0, SetEntrySpacing_InEntrySpacing_PropertyAddress.Address, InEntrySpacing);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEntrySpacing_FunctionAddress, intPtr, SetEntrySpacing_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:GetNumEntries")]
	public unsafe int GetNumEntries()
	{
		CheckDestroyed();
		if (!GetNumEntries_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DynamicEntryBoxBase:GetNumEntries");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumEntries_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumEntries_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumEntries_FunctionAddress, intPtr, GetNumEntries_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumEntries_ReturnValue_Offset), 0, GetNumEntries_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.DynamicEntryBoxBase:GetAllEntries")]
	public unsafe List<UUserWidget> GetAllEntries()
	{
		CheckDestroyed();
		if (!GetAllEntries_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.DynamicEntryBoxBase:GetAllEntries");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllEntries_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllEntries_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllEntries_FunctionAddress, intPtr, GetAllEntries_ParamsSize);
		List<UUserWidget> result = new TArrayCopyMarshaler<UUserWidget>(1, GetAllEntries_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.FromNative, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllEntries_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllEntries_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UDynamicEntryBoxBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDynamicEntryBoxBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDynamicEntryBoxBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.DynamicEntryBoxBase");
		EntrySpacing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EntrySpacing");
		EntrySpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EntrySpacing", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpacingPattern_PropertyAddress, intPtr, "SpacingPattern");
		SpacingPattern_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpacingPattern");
		SpacingPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpacingPattern", Classes.FArrayProperty);
		EntrySizeRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EntrySizeRule");
		EntrySizeRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EntrySizeRule", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EntryHorizontalAlignment_PropertyAddress, intPtr, "EntryHorizontalAlignment");
		EntryHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EntryHorizontalAlignment");
		EntryHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EntryHorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref EntryVerticalAlignment_PropertyAddress, intPtr, "EntryVerticalAlignment");
		EntryVerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EntryVerticalAlignment");
		EntryVerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EntryVerticalAlignment", Classes.FByteProperty);
		MaxElementSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxElementSize");
		MaxElementSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxElementSize", Classes.FIntProperty);
		RadialBoxSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RadialBoxSettings");
		RadialBoxSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RadialBoxSettings", Classes.FStructProperty);
		SetRadialSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRadialSettings");
		SetRadialSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRadialSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRadialSettings_InSettings_PropertyAddress, SetRadialSettings_FunctionAddress, "InSettings");
		SetRadialSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetRadialSettings_FunctionAddress, "InSettings");
		SetRadialSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadialSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		SetRadialSettings_IsValid = SetRadialSettings_FunctionAddress != IntPtr.Zero && SetRadialSettings_InSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DynamicEntryBoxBase:SetRadialSettings", SetRadialSettings_IsValid);
		SetEntrySpacing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEntrySpacing");
		SetEntrySpacing_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEntrySpacing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEntrySpacing_InEntrySpacing_PropertyAddress, SetEntrySpacing_FunctionAddress, "InEntrySpacing");
		SetEntrySpacing_InEntrySpacing_Offset = NativeReflectionCached.GetPropertyOffset(SetEntrySpacing_FunctionAddress, "InEntrySpacing");
		SetEntrySpacing_InEntrySpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEntrySpacing_FunctionAddress, "InEntrySpacing", Classes.FStructProperty);
		SetEntrySpacing_IsValid = SetEntrySpacing_FunctionAddress != IntPtr.Zero && SetEntrySpacing_InEntrySpacing_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DynamicEntryBoxBase:SetEntrySpacing", SetEntrySpacing_IsValid);
		GetNumEntries_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumEntries");
		GetNumEntries_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumEntries_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumEntries_ReturnValue_PropertyAddress, GetNumEntries_FunctionAddress, "ReturnValue");
		GetNumEntries_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumEntries_FunctionAddress, "ReturnValue");
		GetNumEntries_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumEntries_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumEntries_IsValid = GetNumEntries_FunctionAddress != IntPtr.Zero && GetNumEntries_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DynamicEntryBoxBase:GetNumEntries", GetNumEntries_IsValid);
		GetAllEntries_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAllEntries");
		GetAllEntries_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllEntries_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllEntries_ReturnValue_PropertyAddress, GetAllEntries_FunctionAddress, "ReturnValue");
		GetAllEntries_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllEntries_FunctionAddress, "ReturnValue");
		GetAllEntries_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllEntries_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllEntries_IsValid = GetAllEntries_FunctionAddress != IntPtr.Zero && GetAllEntries_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.DynamicEntryBoxBase:GetAllEntries", GetAllEntries_IsValid);
	}
}
