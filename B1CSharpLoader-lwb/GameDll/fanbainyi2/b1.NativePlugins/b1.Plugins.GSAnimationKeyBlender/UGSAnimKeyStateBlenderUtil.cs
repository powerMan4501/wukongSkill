using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public class UGSAnimKeyStateBlenderUtil : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UnRegAnimKeyStateBlenderObjForTick_IsValid;

	private static IntPtr UnRegAnimKeyStateBlenderObjForTick_FunctionAddress;

	private static int UnRegAnimKeyStateBlenderObjForTick_ParamsSize;

	private static bool UnRegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_IsValid;

	private static FFieldAddress UnRegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_PropertyAddress;

	private static int UnRegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_Offset;

	private static bool SetAKBRefWidgetDebugShow_IsValid;

	private static IntPtr SetAKBRefWidgetDebugShow_FunctionAddress;

	private static int SetAKBRefWidgetDebugShow_ParamsSize;

	private static bool SetAKBRefWidgetDebugShow_AKBObj_IsValid;

	private static FFieldAddress SetAKBRefWidgetDebugShow_AKBObj_PropertyAddress;

	private static int SetAKBRefWidgetDebugShow_AKBObj_Offset;

	private static bool SetAKBRefWidgetDebugShow_ShowColor_IsValid;

	private static FFieldAddress SetAKBRefWidgetDebugShow_ShowColor_PropertyAddress;

	private static int SetAKBRefWidgetDebugShow_ShowColor_Offset;

	private static bool SetAKBCtrlAllSubWidgetDebugShow_IsValid;

	private static IntPtr SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress;

	private static int SetAKBCtrlAllSubWidgetDebugShow_ParamsSize;

	private static bool SetAKBCtrlAllSubWidgetDebugShow_AKBObj_IsValid;

	private static FFieldAddress SetAKBCtrlAllSubWidgetDebugShow_AKBObj_PropertyAddress;

	private static int SetAKBCtrlAllSubWidgetDebugShow_AKBObj_Offset;

	private static bool SetAKBCtrlAllSubWidgetDebugShow_ShowColor_IsValid;

	private static FFieldAddress SetAKBCtrlAllSubWidgetDebugShow_ShowColor_PropertyAddress;

	private static int SetAKBCtrlAllSubWidgetDebugShow_ShowColor_Offset;

	private static bool RegAnimKeyStateBlenderObjForTick_IsValid;

	private static IntPtr RegAnimKeyStateBlenderObjForTick_FunctionAddress;

	private static int RegAnimKeyStateBlenderObjForTick_ParamsSize;

	private static bool RegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_IsValid;

	private static FFieldAddress RegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_PropertyAddress;

	private static int RegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_Offset;

	private static bool IterateAllAKBObjInfo_IsValid;

	private static IntPtr IterateAllAKBObjInfo_FunctionAddress;

	private static int IterateAllAKBObjInfo_ParamsSize;

	private static bool FindAllAKBObj_IsValid;

	private static IntPtr FindAllAKBObj_FunctionAddress;

	private static int FindAllAKBObj_ParamsSize;

	private static bool FindAllAKBObj_ReturnValue_IsValid;

	private static FFieldAddress FindAllAKBObj_ReturnValue_PropertyAddress;

	private static int FindAllAKBObj_ReturnValue_Offset;

	private static bool ClearAKBRefWidgetDebugShow_IsValid;

	private static IntPtr ClearAKBRefWidgetDebugShow_FunctionAddress;

	private static int ClearAKBRefWidgetDebugShow_ParamsSize;

	private static bool ClearAKBRefWidgetDebugShow_AKBObj_IsValid;

	private static FFieldAddress ClearAKBRefWidgetDebugShow_AKBObj_PropertyAddress;

	private static int ClearAKBRefWidgetDebugShow_AKBObj_Offset;

	private static bool ClearAKBCtrlAllSubWidgetDebugShow_IsValid;

	private static IntPtr ClearAKBCtrlAllSubWidgetDebugShow_FunctionAddress;

	private static int ClearAKBCtrlAllSubWidgetDebugShow_ParamsSize;

	private static bool ClearAKBCtrlAllSubWidgetDebugShow_AKBObj_IsValid;

	private static FFieldAddress ClearAKBCtrlAllSubWidgetDebugShow_AKBObj_PropertyAddress;

	private static int ClearAKBCtrlAllSubWidgetDebugShow_AKBObj_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:UnRegAnimKeyStateBlenderObjForTick")]
	public unsafe static void UnRegAnimKeyStateBlenderObjForTick(UGSAnimKeyStateBlender AnimKeyStateBlender)
	{
		if (!UnRegAnimKeyStateBlenderObjForTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:UnRegAnimKeyStateBlenderObjForTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnRegAnimKeyStateBlenderObjForTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnRegAnimKeyStateBlenderObjForTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSAnimKeyStateBlender>.ToNative(IntPtr.Add(intPtr, UnRegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_Offset), 0, UnRegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_PropertyAddress.Address, AnimKeyStateBlender);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnRegAnimKeyStateBlenderObjForTick_FunctionAddress, intPtr, UnRegAnimKeyStateBlenderObjForTick_ParamsSize);
	}

	[UFunction(Flags = 612508673u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:SetAKBRefWidgetDebugShow")]
	public unsafe static void SetAKBRefWidgetDebugShow(UGSAnimKeyStateBlender AKBObj, FColor ShowColor)
	{
		if (!SetAKBRefWidgetDebugShow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:SetAKBRefWidgetDebugShow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAKBRefWidgetDebugShow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAKBRefWidgetDebugShow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSAnimKeyStateBlender>.ToNative(IntPtr.Add(intPtr, SetAKBRefWidgetDebugShow_AKBObj_Offset), 0, SetAKBRefWidgetDebugShow_AKBObj_PropertyAddress.Address, AKBObj);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetAKBRefWidgetDebugShow_ShowColor_Offset), 0, SetAKBRefWidgetDebugShow_ShowColor_PropertyAddress.Address, ShowColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAKBRefWidgetDebugShow_FunctionAddress, intPtr, SetAKBRefWidgetDebugShow_ParamsSize);
	}

	[UFunction(Flags = 612508673u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:SetAKBCtrlAllSubWidgetDebugShow")]
	public unsafe static void SetAKBCtrlAllSubWidgetDebugShow(UGSAnimKeyStateBlender AKBObj, FColor ShowColor)
	{
		if (!SetAKBCtrlAllSubWidgetDebugShow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:SetAKBCtrlAllSubWidgetDebugShow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAKBCtrlAllSubWidgetDebugShow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAKBCtrlAllSubWidgetDebugShow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSAnimKeyStateBlender>.ToNative(IntPtr.Add(intPtr, SetAKBCtrlAllSubWidgetDebugShow_AKBObj_Offset), 0, SetAKBCtrlAllSubWidgetDebugShow_AKBObj_PropertyAddress.Address, AKBObj);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetAKBCtrlAllSubWidgetDebugShow_ShowColor_Offset), 0, SetAKBCtrlAllSubWidgetDebugShow_ShowColor_PropertyAddress.Address, ShowColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress, intPtr, SetAKBCtrlAllSubWidgetDebugShow_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:RegAnimKeyStateBlenderObjForTick")]
	public unsafe static void RegAnimKeyStateBlenderObjForTick(UGSAnimKeyStateBlender AnimKeyStateBlender)
	{
		if (!RegAnimKeyStateBlenderObjForTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:RegAnimKeyStateBlenderObjForTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegAnimKeyStateBlenderObjForTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegAnimKeyStateBlenderObjForTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSAnimKeyStateBlender>.ToNative(IntPtr.Add(intPtr, RegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_Offset), 0, RegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_PropertyAddress.Address, AnimKeyStateBlender);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegAnimKeyStateBlenderObjForTick_FunctionAddress, intPtr, RegAnimKeyStateBlenderObjForTick_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:IterateAllAKBObjInfo")]
	public unsafe static void IterateAllAKBObjInfo()
	{
		if (!IterateAllAKBObjInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:IterateAllAKBObjInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IterateAllAKBObjInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IterateAllAKBObjInfo_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: IterateAllAKBObjInfo_FunctionAddress, argsSize: IterateAllAKBObjInfo_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:FindAllAKBObj")]
	public unsafe static List<UGSAnimKeyStateBlender> FindAllAKBObj()
	{
		if (!FindAllAKBObj_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:FindAllAKBObj");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindAllAKBObj_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindAllAKBObj_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindAllAKBObj_FunctionAddress, intPtr, FindAllAKBObj_ParamsSize);
		List<UGSAnimKeyStateBlender> result = new TArrayCopyMarshaler<UGSAnimKeyStateBlender>(1, FindAllAKBObj_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UGSAnimKeyStateBlender, UObjectMarshaler<UGSAnimKeyStateBlender>>.FromNative, CachedMarshalingDelegates<UGSAnimKeyStateBlender, UObjectMarshaler<UGSAnimKeyStateBlender>>.ToNative).FromNative(IntPtr.Add(intPtr, FindAllAKBObj_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindAllAKBObj_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:ClearAKBRefWidgetDebugShow")]
	public unsafe static void ClearAKBRefWidgetDebugShow(UGSAnimKeyStateBlender AKBObj)
	{
		if (!ClearAKBRefWidgetDebugShow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:ClearAKBRefWidgetDebugShow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAKBRefWidgetDebugShow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAKBRefWidgetDebugShow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSAnimKeyStateBlender>.ToNative(IntPtr.Add(intPtr, ClearAKBRefWidgetDebugShow_AKBObj_Offset), 0, ClearAKBRefWidgetDebugShow_AKBObj_PropertyAddress.Address, AKBObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearAKBRefWidgetDebugShow_FunctionAddress, intPtr, ClearAKBRefWidgetDebugShow_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:ClearAKBCtrlAllSubWidgetDebugShow")]
	public unsafe static void ClearAKBCtrlAllSubWidgetDebugShow(UGSAnimKeyStateBlender AKBObj)
	{
		if (!ClearAKBCtrlAllSubWidgetDebugShow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:ClearAKBCtrlAllSubWidgetDebugShow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAKBCtrlAllSubWidgetDebugShow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAKBCtrlAllSubWidgetDebugShow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSAnimKeyStateBlender>.ToNative(IntPtr.Add(intPtr, ClearAKBCtrlAllSubWidgetDebugShow_AKBObj_Offset), 0, ClearAKBCtrlAllSubWidgetDebugShow_AKBObj_PropertyAddress.Address, AKBObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearAKBCtrlAllSubWidgetDebugShow_FunctionAddress, intPtr, ClearAKBCtrlAllSubWidgetDebugShow_ParamsSize);
	}

	static UGSAnimKeyStateBlenderUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSAnimKeyStateBlenderUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSAnimKeyStateBlenderUtil));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil");
		UnRegAnimKeyStateBlenderObjForTick_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnRegAnimKeyStateBlenderObjForTick");
		UnRegAnimKeyStateBlenderObjForTick_ParamsSize = NativeReflection.GetFunctionParamsSize(UnRegAnimKeyStateBlenderObjForTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnRegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_PropertyAddress, UnRegAnimKeyStateBlenderObjForTick_FunctionAddress, "AnimKeyStateBlender");
		UnRegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_Offset = NativeReflectionCached.GetPropertyOffset(UnRegAnimKeyStateBlenderObjForTick_FunctionAddress, "AnimKeyStateBlender");
		UnRegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_IsValid = NativeReflectionCached.ValidatePropertyClass(UnRegAnimKeyStateBlenderObjForTick_FunctionAddress, "AnimKeyStateBlender", Classes.FObjectProperty);
		UnRegAnimKeyStateBlenderObjForTick_IsValid = UnRegAnimKeyStateBlenderObjForTick_FunctionAddress != IntPtr.Zero && UnRegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:UnRegAnimKeyStateBlenderObjForTick", UnRegAnimKeyStateBlenderObjForTick_IsValid);
		SetAKBRefWidgetDebugShow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAKBRefWidgetDebugShow");
		SetAKBRefWidgetDebugShow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAKBRefWidgetDebugShow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAKBRefWidgetDebugShow_AKBObj_PropertyAddress, SetAKBRefWidgetDebugShow_FunctionAddress, "AKBObj");
		SetAKBRefWidgetDebugShow_AKBObj_Offset = NativeReflectionCached.GetPropertyOffset(SetAKBRefWidgetDebugShow_FunctionAddress, "AKBObj");
		SetAKBRefWidgetDebugShow_AKBObj_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAKBRefWidgetDebugShow_FunctionAddress, "AKBObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAKBRefWidgetDebugShow_ShowColor_PropertyAddress, SetAKBRefWidgetDebugShow_FunctionAddress, "ShowColor");
		SetAKBRefWidgetDebugShow_ShowColor_Offset = NativeReflectionCached.GetPropertyOffset(SetAKBRefWidgetDebugShow_FunctionAddress, "ShowColor");
		SetAKBRefWidgetDebugShow_ShowColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAKBRefWidgetDebugShow_FunctionAddress, "ShowColor", Classes.FStructProperty);
		SetAKBRefWidgetDebugShow_IsValid = SetAKBRefWidgetDebugShow_FunctionAddress != IntPtr.Zero && SetAKBRefWidgetDebugShow_AKBObj_IsValid && SetAKBRefWidgetDebugShow_ShowColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:SetAKBRefWidgetDebugShow", SetAKBRefWidgetDebugShow_IsValid);
		SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAKBCtrlAllSubWidgetDebugShow");
		SetAKBCtrlAllSubWidgetDebugShow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAKBCtrlAllSubWidgetDebugShow_AKBObj_PropertyAddress, SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress, "AKBObj");
		SetAKBCtrlAllSubWidgetDebugShow_AKBObj_Offset = NativeReflectionCached.GetPropertyOffset(SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress, "AKBObj");
		SetAKBCtrlAllSubWidgetDebugShow_AKBObj_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress, "AKBObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAKBCtrlAllSubWidgetDebugShow_ShowColor_PropertyAddress, SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress, "ShowColor");
		SetAKBCtrlAllSubWidgetDebugShow_ShowColor_Offset = NativeReflectionCached.GetPropertyOffset(SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress, "ShowColor");
		SetAKBCtrlAllSubWidgetDebugShow_ShowColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress, "ShowColor", Classes.FStructProperty);
		SetAKBCtrlAllSubWidgetDebugShow_IsValid = SetAKBCtrlAllSubWidgetDebugShow_FunctionAddress != IntPtr.Zero && SetAKBCtrlAllSubWidgetDebugShow_AKBObj_IsValid && SetAKBCtrlAllSubWidgetDebugShow_ShowColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:SetAKBCtrlAllSubWidgetDebugShow", SetAKBCtrlAllSubWidgetDebugShow_IsValid);
		RegAnimKeyStateBlenderObjForTick_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegAnimKeyStateBlenderObjForTick");
		RegAnimKeyStateBlenderObjForTick_ParamsSize = NativeReflection.GetFunctionParamsSize(RegAnimKeyStateBlenderObjForTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_PropertyAddress, RegAnimKeyStateBlenderObjForTick_FunctionAddress, "AnimKeyStateBlender");
		RegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_Offset = NativeReflectionCached.GetPropertyOffset(RegAnimKeyStateBlenderObjForTick_FunctionAddress, "AnimKeyStateBlender");
		RegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_IsValid = NativeReflectionCached.ValidatePropertyClass(RegAnimKeyStateBlenderObjForTick_FunctionAddress, "AnimKeyStateBlender", Classes.FObjectProperty);
		RegAnimKeyStateBlenderObjForTick_IsValid = RegAnimKeyStateBlenderObjForTick_FunctionAddress != IntPtr.Zero && RegAnimKeyStateBlenderObjForTick_AnimKeyStateBlender_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:RegAnimKeyStateBlenderObjForTick", RegAnimKeyStateBlenderObjForTick_IsValid);
		IterateAllAKBObjInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IterateAllAKBObjInfo");
		IterateAllAKBObjInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(IterateAllAKBObjInfo_FunctionAddress);
		IterateAllAKBObjInfo_IsValid = IterateAllAKBObjInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:IterateAllAKBObjInfo", IterateAllAKBObjInfo_IsValid);
		FindAllAKBObj_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindAllAKBObj");
		FindAllAKBObj_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAllAKBObj_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindAllAKBObj_ReturnValue_PropertyAddress, FindAllAKBObj_FunctionAddress, "ReturnValue");
		FindAllAKBObj_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindAllAKBObj_FunctionAddress, "ReturnValue");
		FindAllAKBObj_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAllAKBObj_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindAllAKBObj_IsValid = FindAllAKBObj_FunctionAddress != IntPtr.Zero && FindAllAKBObj_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:FindAllAKBObj", FindAllAKBObj_IsValid);
		ClearAKBRefWidgetDebugShow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearAKBRefWidgetDebugShow");
		ClearAKBRefWidgetDebugShow_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAKBRefWidgetDebugShow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearAKBRefWidgetDebugShow_AKBObj_PropertyAddress, ClearAKBRefWidgetDebugShow_FunctionAddress, "AKBObj");
		ClearAKBRefWidgetDebugShow_AKBObj_Offset = NativeReflectionCached.GetPropertyOffset(ClearAKBRefWidgetDebugShow_FunctionAddress, "AKBObj");
		ClearAKBRefWidgetDebugShow_AKBObj_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearAKBRefWidgetDebugShow_FunctionAddress, "AKBObj", Classes.FObjectProperty);
		ClearAKBRefWidgetDebugShow_IsValid = ClearAKBRefWidgetDebugShow_FunctionAddress != IntPtr.Zero && ClearAKBRefWidgetDebugShow_AKBObj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:ClearAKBRefWidgetDebugShow", ClearAKBRefWidgetDebugShow_IsValid);
		ClearAKBCtrlAllSubWidgetDebugShow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearAKBCtrlAllSubWidgetDebugShow");
		ClearAKBCtrlAllSubWidgetDebugShow_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAKBCtrlAllSubWidgetDebugShow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearAKBCtrlAllSubWidgetDebugShow_AKBObj_PropertyAddress, ClearAKBCtrlAllSubWidgetDebugShow_FunctionAddress, "AKBObj");
		ClearAKBCtrlAllSubWidgetDebugShow_AKBObj_Offset = NativeReflectionCached.GetPropertyOffset(ClearAKBCtrlAllSubWidgetDebugShow_FunctionAddress, "AKBObj");
		ClearAKBCtrlAllSubWidgetDebugShow_AKBObj_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearAKBCtrlAllSubWidgetDebugShow_FunctionAddress, "AKBObj", Classes.FObjectProperty);
		ClearAKBCtrlAllSubWidgetDebugShow_IsValid = ClearAKBCtrlAllSubWidgetDebugShow_FunctionAddress != IntPtr.Zero && ClearAKBCtrlAllSubWidgetDebugShow_AKBObj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateBlenderUtil:ClearAKBCtrlAllSubWidgetDebugShow", ClearAKBCtrlAllSubWidgetDebugShow_IsValid);
	}
}
