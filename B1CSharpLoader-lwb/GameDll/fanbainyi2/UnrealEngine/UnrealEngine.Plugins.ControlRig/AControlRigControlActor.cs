using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ControlRig.ControlRigControlActor", "ControlRig", UnrealModuleType.EnginePlugin)]
public class AControlRigControlActor : AActor
{
	private static bool ActorToTrack_IsValid;

	private static int ActorToTrack_Offset;

	private static bool ControlRigClass_IsValid;

	private static int ControlRigClass_Offset;

	private static bool RefreshOnTick_IsValid;

	private static FFieldAddress RefreshOnTick_PropertyAddress;

	private static int RefreshOnTick_Offset;

	private static bool IsSelectable_IsValid;

	private static FFieldAddress IsSelectable_PropertyAddress;

	private static int IsSelectable_Offset;

	private static bool MaterialOverride_IsValid;

	private static int MaterialOverride_Offset;

	private static bool ColorParameter_IsValid;

	private static int ColorParameter_Offset;

	private static bool CastShadows_IsValid;

	private static FFieldAddress CastShadows_PropertyAddress;

	private static int CastShadows_Offset;

	private static bool Refresh_IsValid;

	private static IntPtr Refresh_FunctionAddress;

	private static int Refresh_ParamsSize;

	private static bool Clear_IsValid;

	private static IntPtr Clear_FunctionAddress;

	private static int Clear_ParamsSize;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/ControlRig.ControlRigControlActor:ActorToTrack")]
	public AActor ActorToTrack
	{
		get
		{
			CheckDestroyed();
			if (!ActorToTrack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:ActorToTrack");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ActorToTrack_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorToTrack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:ActorToTrack");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ActorToTrack_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/ControlRig.ControlRigControlActor:ControlRigClass")]
	public TSubclassOf<UControlRig> ControlRigClass
	{
		get
		{
			CheckDestroyed();
			if (!ControlRigClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:ControlRigClass");
				return default(TSubclassOf<UControlRig>);
			}
			return TSubclassOfMarshaler<UControlRig>.FromNative(IntPtr.Add(base.Address, ControlRigClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ControlRigClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:ControlRigClass");
			}
			else
			{
				TSubclassOfMarshaler<UControlRig>.ToNative(IntPtr.Add(base.Address, ControlRigClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigControlActor:bRefreshOnTick")]
	public bool RefreshOnTick
	{
		get
		{
			CheckDestroyed();
			if (!RefreshOnTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:bRefreshOnTick");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RefreshOnTick_Offset), 0, RefreshOnTick_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RefreshOnTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:bRefreshOnTick");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RefreshOnTick_Offset), 0, RefreshOnTick_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigControlActor:bIsSelectable")]
	public new bool IsSelectable
	{
		get
		{
			CheckDestroyed();
			if (!IsSelectable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:bIsSelectable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSelectable_Offset), 0, IsSelectable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSelectable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:bIsSelectable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSelectable_Offset), 0, IsSelectable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/ControlRig.ControlRigControlActor:MaterialOverride")]
	public UMaterialInterface MaterialOverride
	{
		get
		{
			CheckDestroyed();
			if (!MaterialOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:MaterialOverride");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, MaterialOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaterialOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:MaterialOverride");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, MaterialOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/ControlRig.ControlRigControlActor:ColorParameter")]
	public string ColorParameter
	{
		get
		{
			CheckDestroyed();
			if (!ColorParameter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:ColorParameter");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ColorParameter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorParameter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:ColorParameter");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ColorParameter_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ControlRig.ControlRigControlActor:bCastShadows")]
	public bool CastShadows
	{
		get
		{
			CheckDestroyed();
			if (!CastShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:bCastShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadows_Offset), 0, CastShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigControlActor:bCastShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadows_Offset), 0, CastShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigControlActor:Refresh")]
	public unsafe void Refresh()
	{
		CheckDestroyed();
		if (!Refresh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigControlActor:Refresh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Refresh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Refresh_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Refresh_FunctionAddress, argsSize: Refresh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigControlActor:Clear")]
	public unsafe void Clear()
	{
		CheckDestroyed();
		if (!Clear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigControlActor:Clear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Clear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Clear_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Clear_FunctionAddress, argsSize: Clear_ParamsSize);
	}

	static AControlRigControlActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AControlRigControlActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AControlRigControlActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ControlRig.ControlRigControlActor");
		ActorToTrack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorToTrack");
		ActorToTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorToTrack", Classes.FObjectProperty);
		ControlRigClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlRigClass");
		ControlRigClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlRigClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref RefreshOnTick_PropertyAddress, intPtr, "bRefreshOnTick");
		RefreshOnTick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRefreshOnTick");
		RefreshOnTick_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRefreshOnTick", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSelectable_PropertyAddress, intPtr, "bIsSelectable");
		IsSelectable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSelectable");
		IsSelectable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSelectable", Classes.FBoolProperty);
		MaterialOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialOverride");
		MaterialOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialOverride", Classes.FObjectProperty);
		ColorParameter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorParameter");
		ColorParameter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorParameter", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadows_PropertyAddress, intPtr, "bCastShadows");
		CastShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastShadows");
		CastShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastShadows", Classes.FBoolProperty);
		Refresh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Refresh");
		Refresh_ParamsSize = NativeReflection.GetFunctionParamsSize(Refresh_FunctionAddress);
		Refresh_IsValid = Refresh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigControlActor:Refresh", Refresh_IsValid);
		Clear_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Clear");
		Clear_ParamsSize = NativeReflection.GetFunctionParamsSize(Clear_FunctionAddress);
		Clear_IsValid = Clear_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigControlActor:Clear", Clear_IsValid);
	}
}
