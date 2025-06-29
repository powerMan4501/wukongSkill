using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MediaAssets;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ImgMedia;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ImgMedia.ImgMediaSource", "ImgMedia", UnrealModuleType.EnginePlugin)]
public class UImgMediaSource : UBaseMediaSource
{
	private static bool IsPathRelativeToProjectRoot_IsValid;

	private static FFieldAddress IsPathRelativeToProjectRoot_PropertyAddress;

	private static int IsPathRelativeToProjectRoot_Offset;

	private static bool FrameRateOverride_IsValid;

	private static int FrameRateOverride_Offset;

	private static bool ProxyOverride_IsValid;

	private static int ProxyOverride_Offset;

	private static bool FillGapsInSequence_IsValid;

	private static FFieldAddress FillGapsInSequence_PropertyAddress;

	private static int FillGapsInSequence_Offset;

	private static bool SequencePath_IsValid;

	private static int SequencePath_Offset;

	private static bool SetSequencePath_IsValid;

	private static IntPtr SetSequencePath_FunctionAddress;

	private static int SetSequencePath_ParamsSize;

	private static bool SetSequencePath_Path_IsValid;

	private static FFieldAddress SetSequencePath_Path_PropertyAddress;

	private static int SetSequencePath_Path_Offset;

	private static bool SetMipLevelDistance_IsValid;

	private static IntPtr SetMipLevelDistance_FunctionAddress;

	private static int SetMipLevelDistance_ParamsSize;

	private static bool SetMipLevelDistance_Distance_IsValid;

	private static FFieldAddress SetMipLevelDistance_Distance_PropertyAddress;

	private static int SetMipLevelDistance_Distance_Offset;

	private static bool RemoveTargetObject_IsValid;

	private static IntPtr RemoveTargetObject_FunctionAddress;

	private static int RemoveTargetObject_ParamsSize;

	private static bool RemoveTargetObject_InActor_IsValid;

	private static FFieldAddress RemoveTargetObject_InActor_PropertyAddress;

	private static int RemoveTargetObject_InActor_Offset;

	private static bool RemoveGlobalCamera_IsValid;

	private static IntPtr RemoveGlobalCamera_FunctionAddress;

	private static int RemoveGlobalCamera_ParamsSize;

	private static bool RemoveGlobalCamera_InActor_IsValid;

	private static FFieldAddress RemoveGlobalCamera_InActor_PropertyAddress;

	private static int RemoveGlobalCamera_InActor_Offset;

	private static bool GetSequencePath_IsValid;

	private static IntPtr GetSequencePath_FunctionAddress;

	private static int GetSequencePath_ParamsSize;

	private static bool GetSequencePath_ReturnValue_IsValid;

	private static FFieldAddress GetSequencePath_ReturnValue_PropertyAddress;

	private static int GetSequencePath_ReturnValue_Offset;

	private static bool GetProxies_IsValid;

	private static IntPtr GetProxies_FunctionAddress;

	private static int GetProxies_ParamsSize;

	private static bool GetProxies_OutProxies_IsValid;

	private static FFieldAddress GetProxies_OutProxies_PropertyAddress;

	private static int GetProxies_OutProxies_Offset;

	private static bool AddTargetObject_IsValid;

	private static IntPtr AddTargetObject_FunctionAddress;

	private static int AddTargetObject_ParamsSize;

	private static bool AddTargetObject_InActor_IsValid;

	private static FFieldAddress AddTargetObject_InActor_PropertyAddress;

	private static int AddTargetObject_InActor_Offset;

	private static bool AddTargetObject_Width_IsValid;

	private static FFieldAddress AddTargetObject_Width_PropertyAddress;

	private static int AddTargetObject_Width_Offset;

	private static bool AddGlobalCamera_IsValid;

	private static IntPtr AddGlobalCamera_FunctionAddress;

	private static int AddGlobalCamera_ParamsSize;

	private static bool AddGlobalCamera_InActor_IsValid;

	private static FFieldAddress AddGlobalCamera_InActor_PropertyAddress;

	private static int AddGlobalCamera_InActor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:IsPathRelativeToProjectRoot")]
	public bool IsPathRelativeToProjectRoot
	{
		get
		{
			CheckDestroyed();
			if (!IsPathRelativeToProjectRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:IsPathRelativeToProjectRoot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsPathRelativeToProjectRoot_Offset), 0, IsPathRelativeToProjectRoot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsPathRelativeToProjectRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:IsPathRelativeToProjectRoot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsPathRelativeToProjectRoot_Offset), 0, IsPathRelativeToProjectRoot_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:FrameRateOverride")]
	public FFrameRate FrameRateOverride
	{
		get
		{
			CheckDestroyed();
			if (!FrameRateOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:FrameRateOverride");
				return default(FFrameRate);
			}
			return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(base.Address, FrameRateOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrameRateOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:FrameRateOverride");
			}
			else
			{
				BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(base.Address, FrameRateOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759797487567365uL)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:ProxyOverride")]
	public string ProxyOverride
	{
		get
		{
			CheckDestroyed();
			if (!ProxyOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:ProxyOverride");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ProxyOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProxyOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:ProxyOverride");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ProxyOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:bFillGapsInSequence")]
	public bool FillGapsInSequence
	{
		get
		{
			CheckDestroyed();
			if (!FillGapsInSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:bFillGapsInSequence");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FillGapsInSequence_Offset), 0, FillGapsInSequence_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FillGapsInSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:bFillGapsInSequence");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FillGapsInSequence_Offset), 0, FillGapsInSequence_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267795161448981uL)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:SequencePath")]
	protected FDirectoryPath SequencePath
	{
		get
		{
			CheckDestroyed();
			if (!SequencePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:SequencePath");
				return default(FDirectoryPath);
			}
			return FDirectoryPath.FromNative(IntPtr.Add(base.Address, SequencePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequencePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ImgMedia.ImgMediaSource:SequencePath");
			}
			else
			{
				FDirectoryPath.ToNative(IntPtr.Add(base.Address, SequencePath_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:SetSequencePath")]
	public unsafe void SetSequencePath(string Path)
	{
		CheckDestroyed();
		if (!SetSequencePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImgMedia.ImgMediaSource:SetSequencePath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSequencePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSequencePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSequencePath_Path_Offset), 0, SetSequencePath_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSequencePath_FunctionAddress, intPtr, SetSequencePath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSequencePath_Path_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:SetMipLevelDistance")]
	public unsafe void SetMipLevelDistance(float Distance)
	{
		CheckDestroyed();
		if (!SetMipLevelDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImgMedia.ImgMediaSource:SetMipLevelDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMipLevelDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMipLevelDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMipLevelDistance_Distance_Offset), 0, SetMipLevelDistance_Distance_PropertyAddress.Address, Distance);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMipLevelDistance_FunctionAddress, intPtr, SetMipLevelDistance_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:RemoveTargetObject")]
	public unsafe void RemoveTargetObject(AActor InActor)
	{
		CheckDestroyed();
		if (!RemoveTargetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImgMedia.ImgMediaSource:RemoveTargetObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTargetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTargetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveTargetObject_InActor_Offset), 0, RemoveTargetObject_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTargetObject_FunctionAddress, intPtr, RemoveTargetObject_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:RemoveGlobalCamera")]
	public unsafe void RemoveGlobalCamera(AActor InActor)
	{
		CheckDestroyed();
		if (!RemoveGlobalCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImgMedia.ImgMediaSource:RemoveGlobalCamera");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveGlobalCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveGlobalCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveGlobalCamera_InActor_Offset), 0, RemoveGlobalCamera_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveGlobalCamera_FunctionAddress, intPtr, RemoveGlobalCamera_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:GetSequencePath")]
	public unsafe string GetSequencePath()
	{
		CheckDestroyed();
		if (!GetSequencePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImgMedia.ImgMediaSource:GetSequencePath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequencePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequencePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequencePath_FunctionAddress, intPtr, GetSequencePath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSequencePath_ReturnValue_Offset), 0, GetSequencePath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSequencePath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:GetProxies")]
	public unsafe void GetProxies(out List<string> OutProxies)
	{
		CheckDestroyed();
		if (!GetProxies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImgMedia.ImgMediaSource:GetProxies");
			OutProxies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProxies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProxies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetProxies_FunctionAddress, intPtr, GetProxies_ParamsSize);
		OutProxies = new TArrayCopyMarshaler<string>(1, GetProxies_OutProxies_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetProxies_OutProxies_Offset));
		NativeReflection.DestroyValue_InContainer(GetProxies_OutProxies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:AddTargetObject")]
	public unsafe void AddTargetObject(AActor InActor, float Width = -1f)
	{
		CheckDestroyed();
		if (!AddTargetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImgMedia.ImgMediaSource:AddTargetObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTargetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTargetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddTargetObject_InActor_Offset), 0, AddTargetObject_InActor_PropertyAddress.Address, InActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddTargetObject_Width_Offset), 0, AddTargetObject_Width_PropertyAddress.Address, Width);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTargetObject_FunctionAddress, intPtr, AddTargetObject_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ImgMedia.ImgMediaSource:AddGlobalCamera")]
	public unsafe void AddGlobalCamera(AActor InActor)
	{
		CheckDestroyed();
		if (!AddGlobalCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImgMedia.ImgMediaSource:AddGlobalCamera");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGlobalCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGlobalCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddGlobalCamera_InActor_Offset), 0, AddGlobalCamera_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddGlobalCamera_FunctionAddress, intPtr, AddGlobalCamera_ParamsSize);
	}

	static UImgMediaSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UImgMediaSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UImgMediaSource));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ImgMedia.ImgMediaSource");
		NativeReflectionCached.GetPropertyRef(ref IsPathRelativeToProjectRoot_PropertyAddress, intPtr, "IsPathRelativeToProjectRoot");
		IsPathRelativeToProjectRoot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsPathRelativeToProjectRoot");
		IsPathRelativeToProjectRoot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsPathRelativeToProjectRoot", Classes.FBoolProperty);
		FrameRateOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrameRateOverride");
		FrameRateOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrameRateOverride", Classes.FStructProperty);
		ProxyOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProxyOverride");
		ProxyOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProxyOverride", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FillGapsInSequence_PropertyAddress, intPtr, "bFillGapsInSequence");
		FillGapsInSequence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillGapsInSequence");
		FillGapsInSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillGapsInSequence", Classes.FBoolProperty);
		SequencePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SequencePath");
		SequencePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SequencePath", Classes.FStructProperty);
		SetSequencePath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSequencePath");
		SetSequencePath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSequencePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSequencePath_Path_PropertyAddress, SetSequencePath_FunctionAddress, "Path");
		SetSequencePath_Path_Offset = NativeReflectionCached.GetPropertyOffset(SetSequencePath_FunctionAddress, "Path");
		SetSequencePath_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequencePath_FunctionAddress, "Path", Classes.FStrProperty);
		SetSequencePath_IsValid = SetSequencePath_FunctionAddress != IntPtr.Zero && SetSequencePath_Path_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImgMedia.ImgMediaSource:SetSequencePath", SetSequencePath_IsValid);
		SetMipLevelDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMipLevelDistance");
		SetMipLevelDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMipLevelDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMipLevelDistance_Distance_PropertyAddress, SetMipLevelDistance_FunctionAddress, "Distance");
		SetMipLevelDistance_Distance_Offset = NativeReflectionCached.GetPropertyOffset(SetMipLevelDistance_FunctionAddress, "Distance");
		SetMipLevelDistance_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMipLevelDistance_FunctionAddress, "Distance", Classes.FFloatProperty);
		SetMipLevelDistance_IsValid = SetMipLevelDistance_FunctionAddress != IntPtr.Zero && SetMipLevelDistance_Distance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImgMedia.ImgMediaSource:SetMipLevelDistance", SetMipLevelDistance_IsValid);
		RemoveTargetObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveTargetObject");
		RemoveTargetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTargetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTargetObject_InActor_PropertyAddress, RemoveTargetObject_FunctionAddress, "InActor");
		RemoveTargetObject_InActor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTargetObject_FunctionAddress, "InActor");
		RemoveTargetObject_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTargetObject_FunctionAddress, "InActor", Classes.FObjectProperty);
		RemoveTargetObject_IsValid = RemoveTargetObject_FunctionAddress != IntPtr.Zero && RemoveTargetObject_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImgMedia.ImgMediaSource:RemoveTargetObject", RemoveTargetObject_IsValid);
		RemoveGlobalCamera_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveGlobalCamera");
		RemoveGlobalCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveGlobalCamera_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveGlobalCamera_InActor_PropertyAddress, RemoveGlobalCamera_FunctionAddress, "InActor");
		RemoveGlobalCamera_InActor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveGlobalCamera_FunctionAddress, "InActor");
		RemoveGlobalCamera_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveGlobalCamera_FunctionAddress, "InActor", Classes.FObjectProperty);
		RemoveGlobalCamera_IsValid = RemoveGlobalCamera_FunctionAddress != IntPtr.Zero && RemoveGlobalCamera_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImgMedia.ImgMediaSource:RemoveGlobalCamera", RemoveGlobalCamera_IsValid);
		GetSequencePath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequencePath");
		GetSequencePath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequencePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequencePath_ReturnValue_PropertyAddress, GetSequencePath_FunctionAddress, "ReturnValue");
		GetSequencePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequencePath_FunctionAddress, "ReturnValue");
		GetSequencePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequencePath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSequencePath_IsValid = GetSequencePath_FunctionAddress != IntPtr.Zero && GetSequencePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImgMedia.ImgMediaSource:GetSequencePath", GetSequencePath_IsValid);
		GetProxies_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetProxies");
		GetProxies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProxies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProxies_OutProxies_PropertyAddress, GetProxies_FunctionAddress, "OutProxies");
		GetProxies_OutProxies_Offset = NativeReflectionCached.GetPropertyOffset(GetProxies_FunctionAddress, "OutProxies");
		GetProxies_OutProxies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProxies_FunctionAddress, "OutProxies", Classes.FArrayProperty);
		GetProxies_IsValid = GetProxies_FunctionAddress != IntPtr.Zero && GetProxies_OutProxies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImgMedia.ImgMediaSource:GetProxies", GetProxies_IsValid);
		AddTargetObject_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddTargetObject");
		AddTargetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTargetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTargetObject_InActor_PropertyAddress, AddTargetObject_FunctionAddress, "InActor");
		AddTargetObject_InActor_Offset = NativeReflectionCached.GetPropertyOffset(AddTargetObject_FunctionAddress, "InActor");
		AddTargetObject_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTargetObject_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTargetObject_Width_PropertyAddress, AddTargetObject_FunctionAddress, "Width");
		AddTargetObject_Width_Offset = NativeReflectionCached.GetPropertyOffset(AddTargetObject_FunctionAddress, "Width");
		AddTargetObject_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTargetObject_FunctionAddress, "Width", Classes.FFloatProperty);
		AddTargetObject_IsValid = AddTargetObject_FunctionAddress != IntPtr.Zero && AddTargetObject_InActor_IsValid && AddTargetObject_Width_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImgMedia.ImgMediaSource:AddTargetObject", AddTargetObject_IsValid);
		AddGlobalCamera_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddGlobalCamera");
		AddGlobalCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGlobalCamera_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGlobalCamera_InActor_PropertyAddress, AddGlobalCamera_FunctionAddress, "InActor");
		AddGlobalCamera_InActor_Offset = NativeReflectionCached.GetPropertyOffset(AddGlobalCamera_FunctionAddress, "InActor");
		AddGlobalCamera_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGlobalCamera_FunctionAddress, "InActor", Classes.FObjectProperty);
		AddGlobalCamera_IsValid = AddGlobalCamera_FunctionAddress != IntPtr.Zero && AddGlobalCamera_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImgMedia.ImgMediaSource:AddGlobalCamera", AddGlobalCamera_IsValid);
	}
}
