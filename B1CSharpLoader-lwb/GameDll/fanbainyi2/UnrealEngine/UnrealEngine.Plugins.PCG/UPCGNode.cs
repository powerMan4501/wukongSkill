using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/PCG.PCGNode", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGNode : UObject
{
	private static bool NodeTitle_IsValid;

	private static int NodeTitle_Offset;

	private static bool NodeTitleColor_IsValid;

	private static int NodeTitleColor_Offset;

	private static bool SettingsInterface_IsValid;

	private static int SettingsInterface_Offset;

	private static bool InputPins_IsValid;

	private static FFieldAddress InputPins_PropertyAddress;

	private static int InputPins_Offset;

	private TArrayReadOnlyMarshaler<UPCGPin> InputPins_MarshalerCached;

	private static bool OutputPins_IsValid;

	private static FFieldAddress OutputPins_PropertyAddress;

	private static int OutputPins_Offset;

	private TArrayReadOnlyMarshaler<UPCGPin> OutputPins_MarshalerCached;

	private static bool SetNodePosition_IsValid;

	private static IntPtr SetNodePosition_FunctionAddress;

	private static int SetNodePosition_ParamsSize;

	private static bool SetNodePosition_InPositionX_IsValid;

	private static FFieldAddress SetNodePosition_InPositionX_PropertyAddress;

	private static int SetNodePosition_InPositionX_Offset;

	private static bool SetNodePosition_InPositionY_IsValid;

	private static FFieldAddress SetNodePosition_InPositionY_PropertyAddress;

	private static int SetNodePosition_InPositionY_Offset;

	private static bool RemoveEdgeTo_IsValid;

	private static IntPtr RemoveEdgeTo_FunctionAddress;

	private static int RemoveEdgeTo_ParamsSize;

	private static bool RemoveEdgeTo_FromPinLable_IsValid;

	private static FFieldAddress RemoveEdgeTo_FromPinLable_PropertyAddress;

	private static int RemoveEdgeTo_FromPinLable_Offset;

	private static bool RemoveEdgeTo_To_IsValid;

	private static FFieldAddress RemoveEdgeTo_To_PropertyAddress;

	private static int RemoveEdgeTo_To_Offset;

	private static bool RemoveEdgeTo_ToPinLabel_IsValid;

	private static FFieldAddress RemoveEdgeTo_ToPinLabel_PropertyAddress;

	private static int RemoveEdgeTo_ToPinLabel_Offset;

	private static bool RemoveEdgeTo_ReturnValue_IsValid;

	private static FFieldAddress RemoveEdgeTo_ReturnValue_PropertyAddress;

	private static int RemoveEdgeTo_ReturnValue_Offset;

	private static bool GetSettings_IsValid;

	private static IntPtr GetSettings_FunctionAddress;

	private static int GetSettings_ParamsSize;

	private static bool GetSettings_ReturnValue_IsValid;

	private static FFieldAddress GetSettings_ReturnValue_PropertyAddress;

	private static int GetSettings_ReturnValue_Offset;

	private static bool GetNodePosition_IsValid;

	private static IntPtr GetNodePosition_FunctionAddress;

	private static int GetNodePosition_ParamsSize;

	private static bool GetNodePosition_OutPositionX_IsValid;

	private static FFieldAddress GetNodePosition_OutPositionX_PropertyAddress;

	private static int GetNodePosition_OutPositionX_Offset;

	private static bool GetNodePosition_OutPositionY_IsValid;

	private static FFieldAddress GetNodePosition_OutPositionY_PropertyAddress;

	private static int GetNodePosition_OutPositionY_Offset;

	private static bool GetGraph_IsValid;

	private static IntPtr GetGraph_FunctionAddress;

	private static int GetGraph_ParamsSize;

	private static bool GetGraph_ReturnValue_IsValid;

	private static FFieldAddress GetGraph_ReturnValue_PropertyAddress;

	private static int GetGraph_ReturnValue_Offset;

	private static bool AddEdgeTo_IsValid;

	private static IntPtr AddEdgeTo_FunctionAddress;

	private static int AddEdgeTo_ParamsSize;

	private static bool AddEdgeTo_FromPinLabel_IsValid;

	private static FFieldAddress AddEdgeTo_FromPinLabel_PropertyAddress;

	private static int AddEdgeTo_FromPinLabel_Offset;

	private static bool AddEdgeTo_To_IsValid;

	private static FFieldAddress AddEdgeTo_To_PropertyAddress;

	private static int AddEdgeTo_To_Offset;

	private static bool AddEdgeTo_ToPinLabel_IsValid;

	private static FFieldAddress AddEdgeTo_ToPinLabel_PropertyAddress;

	private static int AddEdgeTo_ToPinLabel_Offset;

	private static bool AddEdgeTo_ReturnValue_IsValid;

	private static FFieldAddress AddEdgeTo_ReturnValue_PropertyAddress;

	private static int AddEdgeTo_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGNode:NodeTitle")]
	public FName NodeTitle
	{
		get
		{
			CheckDestroyed();
			if (!NodeTitle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNode:NodeTitle");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NodeTitle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NodeTitle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNode:NodeTitle");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NodeTitle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/PCG.PCGNode:NodeTitleColor")]
	public FLinearColor NodeTitleColor
	{
		get
		{
			CheckDestroyed();
			if (!NodeTitleColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNode:NodeTitleColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, NodeTitleColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NodeTitleColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNode:NodeTitleColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, NodeTitleColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861641237uL)]
	[UMetaPath("/Script/PCG.PCGNode:SettingsInterface")]
	protected UPCGSettingsInterface SettingsInterface
	{
		get
		{
			CheckDestroyed();
			if (!SettingsInterface_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNode:SettingsInterface");
				return null;
			}
			return UObjectMarshaler<UPCGSettingsInterface>.FromNative(IntPtr.Add(base.Address, SettingsInterface_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SettingsInterface_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNode:SettingsInterface");
			}
			else
			{
				UObjectMarshaler<UPCGSettingsInterface>.ToNative(IntPtr.Add(base.Address, SettingsInterface_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)10141895254737429uL)]
	[UMetaPath("/Script/PCG.PCGNode:InputPins")]
	protected TArrayReadOnly<UPCGPin> InputPins
	{
		get
		{
			CheckDestroyed();
			if (!InputPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNode:InputPins");
				return null;
			}
			if (InputPins_MarshalerCached == null)
			{
				InputPins_MarshalerCached = new TArrayReadOnlyMarshaler<UPCGPin>(1, InputPins_PropertyAddress, CachedMarshalingDelegates<UPCGPin, UObjectMarshaler<UPCGPin>>.FromNative, CachedMarshalingDelegates<UPCGPin, UObjectMarshaler<UPCGPin>>.ToNative);
			}
			return InputPins_MarshalerCached.FromNative(IntPtr.Add(base.Address, InputPins_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)10141895254737429uL)]
	[UMetaPath("/Script/PCG.PCGNode:OutputPins")]
	protected TArrayReadOnly<UPCGPin> OutputPins
	{
		get
		{
			CheckDestroyed();
			if (!OutputPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGNode:OutputPins");
				return null;
			}
			if (OutputPins_MarshalerCached == null)
			{
				OutputPins_MarshalerCached = new TArrayReadOnlyMarshaler<UPCGPin>(1, OutputPins_PropertyAddress, CachedMarshalingDelegates<UPCGPin, UObjectMarshaler<UPCGPin>>.FromNative, CachedMarshalingDelegates<UPCGPin, UObjectMarshaler<UPCGPin>>.ToNative);
			}
			return OutputPins_MarshalerCached.FromNative(IntPtr.Add(base.Address, OutputPins_Offset));
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/PCG.PCGNode:SetNodePosition")]
	public unsafe void SetNodePosition(int InPositionX, int InPositionY)
	{
		CheckDestroyed();
		if (!SetNodePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGNode:SetNodePosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNodePosition_InPositionX_Offset), 0, SetNodePosition_InPositionX_PropertyAddress.Address, InPositionX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNodePosition_InPositionY_Offset), 0, SetNodePosition_InPositionY_PropertyAddress.Address, InPositionY);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodePosition_FunctionAddress, intPtr, SetNodePosition_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGNode:RemoveEdgeTo")]
	public unsafe bool RemoveEdgeTo(FName FromPinLable, UPCGNode To, FName ToPinLabel)
	{
		CheckDestroyed();
		if (!RemoveEdgeTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGNode:RemoveEdgeTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveEdgeTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveEdgeTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveEdgeTo_FromPinLable_Offset), 0, RemoveEdgeTo_FromPinLable_PropertyAddress.Address, FromPinLable);
		UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(intPtr, RemoveEdgeTo_To_Offset), 0, RemoveEdgeTo_To_PropertyAddress.Address, To);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveEdgeTo_ToPinLabel_Offset), 0, RemoveEdgeTo_ToPinLabel_PropertyAddress.Address, ToPinLabel);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveEdgeTo_FunctionAddress, intPtr, RemoveEdgeTo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveEdgeTo_ReturnValue_Offset), 0, RemoveEdgeTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGNode:GetSettings")]
	public unsafe UPCGSettings GetSettings()
	{
		CheckDestroyed();
		if (!GetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGNode:GetSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSettings_FunctionAddress, intPtr, GetSettings_ParamsSize);
		return UObjectMarshaler<UPCGSettings>.FromNative(IntPtr.Add(intPtr, GetSettings_ReturnValue_Offset), 0, GetSettings_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1950483457u)]
	[UMetaPath("/Script/PCG.PCGNode:GetNodePosition")]
	public unsafe void GetNodePosition(out int OutPositionX, out int OutPositionY)
	{
		CheckDestroyed();
		if (!GetNodePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGNode:GetNodePosition");
			OutPositionX = 0;
			OutPositionY = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodePosition_FunctionAddress, intPtr, GetNodePosition_ParamsSize);
		OutPositionX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNodePosition_OutPositionX_Offset), 0, GetNodePosition_OutPositionX_PropertyAddress.Address);
		OutPositionY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNodePosition_OutPositionY_Offset), 0, GetNodePosition_OutPositionY_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGNode:GetGraph")]
	public unsafe UPCGGraph GetGraph()
	{
		CheckDestroyed();
		if (!GetGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGNode:GetGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraph_FunctionAddress, intPtr, GetGraph_ParamsSize);
		return UObjectMarshaler<UPCGGraph>.FromNative(IntPtr.Add(intPtr, GetGraph_ReturnValue_Offset), 0, GetGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGNode:AddEdgeTo")]
	public unsafe UPCGNode AddEdgeTo(FName FromPinLabel, UPCGNode To, FName ToPinLabel)
	{
		CheckDestroyed();
		if (!AddEdgeTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGNode:AddEdgeTo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddEdgeTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddEdgeTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddEdgeTo_FromPinLabel_Offset), 0, AddEdgeTo_FromPinLabel_PropertyAddress.Address, FromPinLabel);
		UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(intPtr, AddEdgeTo_To_Offset), 0, AddEdgeTo_To_PropertyAddress.Address, To);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddEdgeTo_ToPinLabel_Offset), 0, AddEdgeTo_ToPinLabel_PropertyAddress.Address, ToPinLabel);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddEdgeTo_FunctionAddress, intPtr, AddEdgeTo_ParamsSize);
		return UObjectMarshaler<UPCGNode>.FromNative(IntPtr.Add(intPtr, AddEdgeTo_ReturnValue_Offset), 0, AddEdgeTo_ReturnValue_PropertyAddress.Address);
	}

	static UPCGNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGNode));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGNode");
		NodeTitle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NodeTitle");
		NodeTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NodeTitle", Classes.FNameProperty);
		NodeTitleColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NodeTitleColor");
		NodeTitleColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NodeTitleColor", Classes.FStructProperty);
		SettingsInterface_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SettingsInterface");
		SettingsInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SettingsInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InputPins_PropertyAddress, intPtr, "InputPins");
		InputPins_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputPins");
		InputPins_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputPins", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputPins_PropertyAddress, intPtr, "OutputPins");
		OutputPins_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputPins");
		OutputPins_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputPins", Classes.FArrayProperty);
		SetNodePosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodePosition");
		SetNodePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodePosition_InPositionX_PropertyAddress, SetNodePosition_FunctionAddress, "InPositionX");
		SetNodePosition_InPositionX_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePosition_FunctionAddress, "InPositionX");
		SetNodePosition_InPositionX_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePosition_FunctionAddress, "InPositionX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePosition_InPositionY_PropertyAddress, SetNodePosition_FunctionAddress, "InPositionY");
		SetNodePosition_InPositionY_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePosition_FunctionAddress, "InPositionY");
		SetNodePosition_InPositionY_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePosition_FunctionAddress, "InPositionY", Classes.FIntProperty);
		SetNodePosition_IsValid = SetNodePosition_FunctionAddress != IntPtr.Zero && SetNodePosition_InPositionX_IsValid && SetNodePosition_InPositionY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGNode:SetNodePosition", SetNodePosition_IsValid);
		RemoveEdgeTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveEdgeTo");
		RemoveEdgeTo_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveEdgeTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveEdgeTo_FromPinLable_PropertyAddress, RemoveEdgeTo_FunctionAddress, "FromPinLable");
		RemoveEdgeTo_FromPinLable_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEdgeTo_FunctionAddress, "FromPinLable");
		RemoveEdgeTo_FromPinLable_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEdgeTo_FunctionAddress, "FromPinLable", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveEdgeTo_To_PropertyAddress, RemoveEdgeTo_FunctionAddress, "To");
		RemoveEdgeTo_To_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEdgeTo_FunctionAddress, "To");
		RemoveEdgeTo_To_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEdgeTo_FunctionAddress, "To", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveEdgeTo_ToPinLabel_PropertyAddress, RemoveEdgeTo_FunctionAddress, "ToPinLabel");
		RemoveEdgeTo_ToPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEdgeTo_FunctionAddress, "ToPinLabel");
		RemoveEdgeTo_ToPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEdgeTo_FunctionAddress, "ToPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveEdgeTo_ReturnValue_PropertyAddress, RemoveEdgeTo_FunctionAddress, "ReturnValue");
		RemoveEdgeTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEdgeTo_FunctionAddress, "ReturnValue");
		RemoveEdgeTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEdgeTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveEdgeTo_IsValid = RemoveEdgeTo_FunctionAddress != IntPtr.Zero && RemoveEdgeTo_FromPinLable_IsValid && RemoveEdgeTo_To_IsValid && RemoveEdgeTo_ToPinLabel_IsValid && RemoveEdgeTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGNode:RemoveEdgeTo", RemoveEdgeTo_IsValid);
		GetSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSettings");
		GetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSettings_ReturnValue_PropertyAddress, GetSettings_FunctionAddress, "ReturnValue");
		GetSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSettings_FunctionAddress, "ReturnValue");
		GetSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSettings_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSettings_IsValid = GetSettings_FunctionAddress != IntPtr.Zero && GetSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGNode:GetSettings", GetSettings_IsValid);
		GetNodePosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodePosition");
		GetNodePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodePosition_OutPositionX_PropertyAddress, GetNodePosition_FunctionAddress, "OutPositionX");
		GetNodePosition_OutPositionX_Offset = NativeReflectionCached.GetPropertyOffset(GetNodePosition_FunctionAddress, "OutPositionX");
		GetNodePosition_OutPositionX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodePosition_FunctionAddress, "OutPositionX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodePosition_OutPositionY_PropertyAddress, GetNodePosition_FunctionAddress, "OutPositionY");
		GetNodePosition_OutPositionY_Offset = NativeReflectionCached.GetPropertyOffset(GetNodePosition_FunctionAddress, "OutPositionY");
		GetNodePosition_OutPositionY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodePosition_FunctionAddress, "OutPositionY", Classes.FIntProperty);
		GetNodePosition_IsValid = GetNodePosition_FunctionAddress != IntPtr.Zero && GetNodePosition_OutPositionX_IsValid && GetNodePosition_OutPositionY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGNode:GetNodePosition", GetNodePosition_IsValid);
		GetGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGraph");
		GetGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraph_ReturnValue_PropertyAddress, GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGraph_IsValid = GetGraph_FunctionAddress != IntPtr.Zero && GetGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGNode:GetGraph", GetGraph_IsValid);
		AddEdgeTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddEdgeTo");
		AddEdgeTo_ParamsSize = NativeReflection.GetFunctionParamsSize(AddEdgeTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddEdgeTo_FromPinLabel_PropertyAddress, AddEdgeTo_FunctionAddress, "FromPinLabel");
		AddEdgeTo_FromPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(AddEdgeTo_FunctionAddress, "FromPinLabel");
		AddEdgeTo_FromPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEdgeTo_FunctionAddress, "FromPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEdgeTo_To_PropertyAddress, AddEdgeTo_FunctionAddress, "To");
		AddEdgeTo_To_Offset = NativeReflectionCached.GetPropertyOffset(AddEdgeTo_FunctionAddress, "To");
		AddEdgeTo_To_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEdgeTo_FunctionAddress, "To", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEdgeTo_ToPinLabel_PropertyAddress, AddEdgeTo_FunctionAddress, "ToPinLabel");
		AddEdgeTo_ToPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(AddEdgeTo_FunctionAddress, "ToPinLabel");
		AddEdgeTo_ToPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEdgeTo_FunctionAddress, "ToPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEdgeTo_ReturnValue_PropertyAddress, AddEdgeTo_FunctionAddress, "ReturnValue");
		AddEdgeTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddEdgeTo_FunctionAddress, "ReturnValue");
		AddEdgeTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEdgeTo_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddEdgeTo_IsValid = AddEdgeTo_FunctionAddress != IntPtr.Zero && AddEdgeTo_FromPinLabel_IsValid && AddEdgeTo_To_IsValid && AddEdgeTo_ToPinLabel_IsValid && AddEdgeTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGNode:AddEdgeTo", AddEdgeTo_IsValid);
	}
}
