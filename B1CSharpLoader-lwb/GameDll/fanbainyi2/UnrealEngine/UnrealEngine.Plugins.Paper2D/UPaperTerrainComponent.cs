using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperTerrainComponent", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperTerrainComponent : UPrimitiveComponent
{
	private static bool TerrainMaterial_IsValid;

	private static int TerrainMaterial_Offset;

	private static bool ClosedSpline_IsValid;

	private static FFieldAddress ClosedSpline_PropertyAddress;

	private static int ClosedSpline_Offset;

	private static bool FilledSpline_IsValid;

	private static FFieldAddress FilledSpline_PropertyAddress;

	private static int FilledSpline_Offset;

	private static bool TerrainColor_IsValid;

	private static int TerrainColor_Offset;

	private static bool SetTerrainColor_IsValid;

	private static IntPtr SetTerrainColor_FunctionAddress;

	private static int SetTerrainColor_ParamsSize;

	private static bool SetTerrainColor_NewColor_IsValid;

	private static FFieldAddress SetTerrainColor_NewColor_PropertyAddress;

	private static int SetTerrainColor_NewColor_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Paper2D.PaperTerrainComponent:TerrainMaterial")]
	public UPaperTerrainMaterial TerrainMaterial
	{
		get
		{
			CheckDestroyed();
			if (!TerrainMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainComponent:TerrainMaterial");
				return null;
			}
			return UObjectMarshaler<UPaperTerrainMaterial>.FromNative(IntPtr.Add(base.Address, TerrainMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TerrainMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainComponent:TerrainMaterial");
			}
			else
			{
				UObjectMarshaler<UPaperTerrainMaterial>.ToNative(IntPtr.Add(base.Address, TerrainMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperTerrainComponent:bClosedSpline")]
	public bool ClosedSpline
	{
		get
		{
			CheckDestroyed();
			if (!ClosedSpline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainComponent:bClosedSpline");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClosedSpline_Offset), 0, ClosedSpline_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClosedSpline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainComponent:bClosedSpline");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClosedSpline_Offset), 0, ClosedSpline_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperTerrainComponent:bFilledSpline")]
	public bool FilledSpline
	{
		get
		{
			CheckDestroyed();
			if (!FilledSpline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainComponent:bFilledSpline");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FilledSpline_Offset), 0, FilledSpline_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FilledSpline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainComponent:bFilledSpline");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FilledSpline_Offset), 0, FilledSpline_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267873544602133uL)]
	[UMetaPath("/Script/Paper2D.PaperTerrainComponent:TerrainColor")]
	protected FLinearColor TerrainColor
	{
		get
		{
			CheckDestroyed();
			if (!TerrainColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainComponent:TerrainColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, TerrainColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TerrainColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperTerrainComponent:TerrainColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, TerrainColor_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Paper2D.PaperTerrainComponent:SetTerrainColor")]
	public unsafe void SetTerrainColor(FLinearColor NewColor)
	{
		CheckDestroyed();
		if (!SetTerrainColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperTerrainComponent:SetTerrainColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTerrainColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTerrainColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetTerrainColor_NewColor_Offset), 0, SetTerrainColor_NewColor_PropertyAddress.Address, NewColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTerrainColor_FunctionAddress, intPtr, SetTerrainColor_ParamsSize);
	}

	static UPaperTerrainComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperTerrainComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperTerrainComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Paper2D.PaperTerrainComponent");
		TerrainMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TerrainMaterial");
		TerrainMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TerrainMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClosedSpline_PropertyAddress, intPtr, "bClosedSpline");
		ClosedSpline_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClosedSpline");
		ClosedSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClosedSpline", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FilledSpline_PropertyAddress, intPtr, "bFilledSpline");
		FilledSpline_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFilledSpline");
		FilledSpline_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFilledSpline", Classes.FBoolProperty);
		TerrainColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TerrainColor");
		TerrainColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TerrainColor", Classes.FStructProperty);
		SetTerrainColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTerrainColor");
		SetTerrainColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTerrainColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTerrainColor_NewColor_PropertyAddress, SetTerrainColor_FunctionAddress, "NewColor");
		SetTerrainColor_NewColor_Offset = NativeReflectionCached.GetPropertyOffset(SetTerrainColor_FunctionAddress, "NewColor");
		SetTerrainColor_NewColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTerrainColor_FunctionAddress, "NewColor", Classes.FStructProperty);
		SetTerrainColor_IsValid = SetTerrainColor_FunctionAddress != IntPtr.Zero && SetTerrainColor_NewColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperTerrainComponent:SetTerrainColor", SetTerrainColor_IsValid);
	}
}
