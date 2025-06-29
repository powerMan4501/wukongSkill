using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/PCG.PCGPin", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGPin : UObject
{
	private static bool Node_IsValid;

	private static int Node_Offset;

	private static bool Edges_IsValid;

	private static FFieldAddress Edges_PropertyAddress;

	private static int Edges_Offset;

	private TArrayReadOnlyMarshaler<UPCGEdge> Edges_MarshalerCached;

	private static bool Properties_IsValid;

	private static int Properties_Offset;

	private static bool SetTooltip_IsValid;

	private static IntPtr SetTooltip_FunctionAddress;

	private static int SetTooltip_ParamsSize;

	private static bool SetTooltip_InTooltip_IsValid;

	private static FFieldAddress SetTooltip_InTooltip_PropertyAddress;

	private static int SetTooltip_InTooltip_Offset;

	private static bool GetTooltip_IsValid;

	private static IntPtr GetTooltip_FunctionAddress;

	private static int GetTooltip_ParamsSize;

	private static bool GetTooltip_ReturnValue_IsValid;

	private static FFieldAddress GetTooltip_ReturnValue_PropertyAddress;

	private static int GetTooltip_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/PCG.PCGPin:Node")]
	public UPCGNode Node
	{
		get
		{
			CheckDestroyed();
			if (!Node_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPin:Node");
				return null;
			}
			return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(base.Address, Node_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Node_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPin:Node");
			}
			else
			{
				UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(base.Address, Node_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5699868278391316uL)]
	[UMetaPath("/Script/PCG.PCGPin:Edges")]
	public TArrayReadOnly<UPCGEdge> Edges
	{
		get
		{
			CheckDestroyed();
			if (!Edges_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPin:Edges");
				return null;
			}
			if (Edges_MarshalerCached == null)
			{
				Edges_MarshalerCached = new TArrayReadOnlyMarshaler<UPCGEdge>(1, Edges_PropertyAddress, CachedMarshalingDelegates<UPCGEdge, UObjectMarshaler<UPCGEdge>>.FromNative, CachedMarshalingDelegates<UPCGEdge, UObjectMarshaler<UPCGEdge>>.ToNative);
			}
			return Edges_MarshalerCached.FromNative(IntPtr.Add(base.Address, Edges_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/PCG.PCGPin:Properties")]
	public FPCGPinProperties Properties
	{
		get
		{
			CheckDestroyed();
			if (!Properties_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPin:Properties");
				return default(FPCGPinProperties);
			}
			return FPCGPinProperties.FromNative(IntPtr.Add(base.Address, Properties_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Properties_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPin:Properties");
			}
			else
			{
				FPCGPinProperties.ToNative(IntPtr.Add(base.Address, Properties_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGPin:SetTooltip")]
	public unsafe void SetTooltip(FText InTooltip)
	{
		CheckDestroyed();
		if (!SetTooltip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGPin:SetTooltip");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTooltip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTooltip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTooltip_InTooltip_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetTooltip_InTooltip_Offset), 0, SetTooltip_InTooltip_PropertyAddress.Address, InTooltip);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTooltip_FunctionAddress, intPtr, SetTooltip_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTooltip_InTooltip_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGPin:GetTooltip")]
	public unsafe string GetTooltip()
	{
		CheckDestroyed();
		if (!GetTooltip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGPin:GetTooltip");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTooltip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTooltip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTooltip_FunctionAddress, intPtr, GetTooltip_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTooltip_ReturnValue_Offset), 0, GetTooltip_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTooltip_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UPCGPin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGPin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGPin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGPin");
		Node_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Node");
		Node_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Edges_PropertyAddress, intPtr, "Edges");
		Edges_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Edges");
		Edges_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Edges", Classes.FArrayProperty);
		Properties_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Properties");
		Properties_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Properties", Classes.FStructProperty);
		SetTooltip_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTooltip");
		SetTooltip_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTooltip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTooltip_InTooltip_PropertyAddress, SetTooltip_FunctionAddress, "InTooltip");
		SetTooltip_InTooltip_Offset = NativeReflectionCached.GetPropertyOffset(SetTooltip_FunctionAddress, "InTooltip");
		SetTooltip_InTooltip_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTooltip_FunctionAddress, "InTooltip", Classes.FTextProperty);
		SetTooltip_IsValid = SetTooltip_FunctionAddress != IntPtr.Zero && SetTooltip_InTooltip_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGPin:SetTooltip", SetTooltip_IsValid);
		GetTooltip_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTooltip");
		GetTooltip_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTooltip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTooltip_ReturnValue_PropertyAddress, GetTooltip_FunctionAddress, "ReturnValue");
		GetTooltip_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTooltip_FunctionAddress, "ReturnValue");
		GetTooltip_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTooltip_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetTooltip_IsValid = GetTooltip_FunctionAddress != IntPtr.Zero && GetTooltip_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGPin:GetTooltip", GetTooltip_IsValid);
	}
}
