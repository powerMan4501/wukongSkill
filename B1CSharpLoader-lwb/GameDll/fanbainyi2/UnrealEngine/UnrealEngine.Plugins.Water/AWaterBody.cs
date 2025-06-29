using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[Abstract]
[UClass(Flags = (ClassFlags)818938021uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Water.WaterBody", "Water", UnrealModuleType.EnginePlugin)]
public class AWaterBody : AActor, IWaterBrushActorInterface, IInterface
{
	private static bool SplineComp_IsValid;

	private static int SplineComp_Offset;

	private static bool WaterBodyComponent_IsValid;

	private static int WaterBodyComponent_Offset;

	private static bool WaterBodyIndex_IsValid;

	private static int WaterBodyIndex_Offset;

	private static bool WaterWaves_IsValid;

	private static int WaterWaves_Offset;

	private static bool SetWaterWaves_IsValid;

	private static IntPtr SetWaterWaves_FunctionAddress;

	private static int SetWaterWaves_ParamsSize;

	private static bool SetWaterWaves_InWaterWaves_IsValid;

	private static FFieldAddress SetWaterWaves_InWaterWaves_PropertyAddress;

	private static int SetWaterWaves_InWaterWaves_Offset;

	private static bool GetWaterSpline_IsValid;

	private static IntPtr GetWaterSpline_FunctionAddress;

	private static int GetWaterSpline_ParamsSize;

	private static bool GetWaterSpline_ReturnValue_IsValid;

	private static FFieldAddress GetWaterSpline_ReturnValue_PropertyAddress;

	private static int GetWaterSpline_ReturnValue_Offset;

	private static bool GetWaterBodyType_IsValid;

	private static IntPtr GetWaterBodyType_FunctionAddress;

	private static int GetWaterBodyType_ParamsSize;

	private static bool GetWaterBodyType_ReturnValue_IsValid;

	private static FFieldAddress GetWaterBodyType_ReturnValue_PropertyAddress;

	private static int GetWaterBodyType_ReturnValue_Offset;

	private static bool GetWaterBodyComponent_IsValid;

	private static IntPtr GetWaterBodyComponent_FunctionAddress;

	private static int GetWaterBodyComponent_ParamsSize;

	private static bool GetWaterBodyComponent_ReturnValue_IsValid;

	private static FFieldAddress GetWaterBodyComponent_ReturnValue_PropertyAddress;

	private static int GetWaterBodyComponent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267864955322909uL)]
	[UMetaPath("/Script/Water.WaterBody:SplineComp")]
	protected UWaterSplineComponent SplineComp
	{
		get
		{
			CheckDestroyed();
			if (!SplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBody:SplineComp");
				return null;
			}
			return UObjectMarshaler<UWaterSplineComponent>.FromNative(IntPtr.Add(base.Address, SplineComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBody:SplineComp");
			}
			else
			{
				UObjectMarshaler<UWaterSplineComponent>.ToNative(IntPtr.Add(base.Address, SplineComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864955322909uL)]
	[UMetaPath("/Script/Water.WaterBody:WaterBodyComponent")]
	protected UWaterBodyComponent WaterBodyComponent
	{
		get
		{
			CheckDestroyed();
			if (!WaterBodyComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBody:WaterBodyComponent");
				return null;
			}
			return UObjectMarshaler<UWaterBodyComponent>.FromNative(IntPtr.Add(base.Address, WaterBodyComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterBodyComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBody:WaterBodyComponent");
			}
			else
			{
				UObjectMarshaler<UWaterBodyComponent>.ToNative(IntPtr.Add(base.Address, WaterBodyComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267882136642068uL)]
	[UMetaPath("/Script/Water.WaterBody:WaterBodyIndex")]
	protected int WaterBodyIndex
	{
		get
		{
			CheckDestroyed();
			if (!WaterBodyIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBody:WaterBodyIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WaterBodyIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterBodyIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBody:WaterBodyIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WaterBodyIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11830814908613149uL)]
	[UMetaPath("/Script/Water.WaterBody:WaterWaves")]
	protected UWaterWavesBase WaterWaves
	{
		get
		{
			CheckDestroyed();
			if (!WaterWaves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBody:WaterWaves");
				return null;
			}
			return UObjectMarshaler<UWaterWavesBase>.FromNative(IntPtr.Add(base.Address, WaterWaves_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterWaves_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Water.WaterBody:WaterWaves");
			}
			else
			{
				UObjectMarshaler<UWaterWavesBase>.ToNative(IntPtr.Add(base.Address, WaterWaves_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Water.WaterBody:SetWaterWaves")]
	public unsafe void SetWaterWaves(UWaterWavesBase InWaterWaves)
	{
		CheckDestroyed();
		if (!SetWaterWaves_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBody:SetWaterWaves");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWaterWaves_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWaterWaves_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWaterWavesBase>.ToNative(IntPtr.Add(intPtr, SetWaterWaves_InWaterWaves_Offset), 0, SetWaterWaves_InWaterWaves_PropertyAddress.Address, InWaterWaves);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWaterWaves_FunctionAddress, intPtr, SetWaterWaves_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBody:GetWaterSpline")]
	public unsafe UWaterSplineComponent GetWaterSpline()
	{
		CheckDestroyed();
		if (!GetWaterSpline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBody:GetWaterSpline");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterSpline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterSpline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterSpline_FunctionAddress, intPtr, GetWaterSpline_ParamsSize);
		return UObjectMarshaler<UWaterSplineComponent>.FromNative(IntPtr.Add(intPtr, GetWaterSpline_ReturnValue_Offset), 0, GetWaterSpline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Water.WaterBody:GetWaterBodyType")]
	public unsafe EWaterBodyType GetWaterBodyType()
	{
		CheckDestroyed();
		if (!GetWaterBodyType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBody:GetWaterBodyType");
			return EWaterBodyType.River;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterBodyType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterBodyType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterBodyType_FunctionAddress, intPtr, GetWaterBodyType_ParamsSize);
		return EnumMarshaler<EWaterBodyType>.FromNative(IntPtr.Add(intPtr, GetWaterBodyType_ReturnValue_Offset), 0, GetWaterBodyType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Water.WaterBody:GetWaterBodyComponent")]
	public unsafe UWaterBodyComponent GetWaterBodyComponent()
	{
		CheckDestroyed();
		if (!GetWaterBodyComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.WaterBody:GetWaterBodyComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWaterBodyComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWaterBodyComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWaterBodyComponent_FunctionAddress, intPtr, GetWaterBodyComponent_ParamsSize);
		return UObjectMarshaler<UWaterBodyComponent>.FromNative(IntPtr.Add(intPtr, GetWaterBodyComponent_ReturnValue_Offset), 0, GetWaterBodyComponent_ReturnValue_PropertyAddress.Address);
	}

	static AWaterBody()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AWaterBody)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AWaterBody));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Water.WaterBody");
		SplineComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SplineComp");
		SplineComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SplineComp", Classes.FObjectProperty);
		WaterBodyComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterBodyComponent");
		WaterBodyComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterBodyComponent", Classes.FObjectProperty);
		WaterBodyIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterBodyIndex");
		WaterBodyIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterBodyIndex", Classes.FIntProperty);
		WaterWaves_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterWaves");
		WaterWaves_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterWaves", Classes.FObjectProperty);
		SetWaterWaves_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWaterWaves");
		SetWaterWaves_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWaterWaves_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWaterWaves_InWaterWaves_PropertyAddress, SetWaterWaves_FunctionAddress, "InWaterWaves");
		SetWaterWaves_InWaterWaves_Offset = NativeReflectionCached.GetPropertyOffset(SetWaterWaves_FunctionAddress, "InWaterWaves");
		SetWaterWaves_InWaterWaves_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaterWaves_FunctionAddress, "InWaterWaves", Classes.FObjectProperty);
		SetWaterWaves_IsValid = SetWaterWaves_FunctionAddress != IntPtr.Zero && SetWaterWaves_InWaterWaves_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBody:SetWaterWaves", SetWaterWaves_IsValid);
		GetWaterSpline_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterSpline");
		GetWaterSpline_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterSpline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterSpline_ReturnValue_PropertyAddress, GetWaterSpline_FunctionAddress, "ReturnValue");
		GetWaterSpline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterSpline_FunctionAddress, "ReturnValue");
		GetWaterSpline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterSpline_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWaterSpline_IsValid = GetWaterSpline_FunctionAddress != IntPtr.Zero && GetWaterSpline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBody:GetWaterSpline", GetWaterSpline_IsValid);
		GetWaterBodyType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterBodyType");
		GetWaterBodyType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterBodyType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterBodyType_ReturnValue_PropertyAddress, GetWaterBodyType_FunctionAddress, "ReturnValue");
		GetWaterBodyType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterBodyType_FunctionAddress, "ReturnValue");
		GetWaterBodyType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterBodyType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetWaterBodyType_IsValid = GetWaterBodyType_FunctionAddress != IntPtr.Zero && GetWaterBodyType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBody:GetWaterBodyType", GetWaterBodyType_IsValid);
		GetWaterBodyComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWaterBodyComponent");
		GetWaterBodyComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWaterBodyComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWaterBodyComponent_ReturnValue_PropertyAddress, GetWaterBodyComponent_FunctionAddress, "ReturnValue");
		GetWaterBodyComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWaterBodyComponent_FunctionAddress, "ReturnValue");
		GetWaterBodyComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWaterBodyComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWaterBodyComponent_IsValid = GetWaterBodyComponent_FunctionAddress != IntPtr.Zero && GetWaterBodyComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.WaterBody:GetWaterBodyComponent", GetWaterBodyComponent_IsValid);
	}
}
