using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSettingsInterface", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSettingsInterface : UPCGData
{
	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	private static bool Debug_IsValid;

	private static FFieldAddress Debug_PropertyAddress;

	private static int Debug_Offset;

	private static bool DebugSettings_IsValid;

	private static int DebugSettings_Offset;

	private static bool BreakDebugger_IsValid;

	private static FFieldAddress BreakDebugger_PropertyAddress;

	private static int BreakDebugger_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGSettingsInterface:bEnabled")]
	public bool Enabled
	{
		get
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInterface:bEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInterface:bEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/PCG.PCGSettingsInterface:bDebug")]
	public bool Debug
	{
		get
		{
			CheckDestroyed();
			if (!Debug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInterface:bDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Debug_Offset), 0, Debug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Debug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInterface:bDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Debug_Offset), 0, Debug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503633987108869uL)]
	[UMetaPath("/Script/PCG.PCGSettingsInterface:DebugSettings")]
	public FPCGDebugVisualizationSettings DebugSettings
	{
		get
		{
			CheckDestroyed();
			if (!DebugSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInterface:DebugSettings");
				return default(FPCGDebugVisualizationSettings);
			}
			return FPCGDebugVisualizationSettings.FromNative(IntPtr.Add(base.Address, DebugSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInterface:DebugSettings");
			}
			else
			{
				FPCGDebugVisualizationSettings.ToNative(IntPtr.Add(base.Address, DebugSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901642629637uL)]
	[UMetaPath("/Script/PCG.PCGSettingsInterface:bBreakDebugger")]
	public bool BreakDebugger
	{
		get
		{
			CheckDestroyed();
			if (!BreakDebugger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInterface:bBreakDebugger");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BreakDebugger_Offset), 0, BreakDebugger_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BreakDebugger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSettingsInterface:bBreakDebugger");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BreakDebugger_Offset), 0, BreakDebugger_PropertyAddress.Address, value);
			}
		}
	}

	static UPCGSettingsInterface()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSettingsInterface)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSettingsInterface));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGSettingsInterface");
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, unrealStruct, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Debug_PropertyAddress, unrealStruct, "bDebug");
		Debug_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDebug");
		Debug_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDebug", Classes.FBoolProperty);
		DebugSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DebugSettings");
		DebugSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DebugSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakDebugger_PropertyAddress, unrealStruct, "bBreakDebugger");
		BreakDebugger_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBreakDebugger");
		BreakDebugger_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBreakDebugger", Classes.FBoolProperty);
	}
}
