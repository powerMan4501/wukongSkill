using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/V8.JavascriptTestLibrary", "V8", UnrealModuleType.GamePlugin)]
public class UJavascriptTestLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetContinue_IsValid;

	private static IntPtr SetContinue_FunctionAddress;

	private static int SetContinue_ParamsSize;

	private static bool SetContinue_Test_IsValid;

	private static FFieldAddress SetContinue_Test_PropertyAddress;

	private static int SetContinue_Test_Offset;

	private static bool SetContinue_bInContinue_IsValid;

	private static FFieldAddress SetContinue_bInContinue_PropertyAddress;

	private static int SetContinue_bInContinue_Offset;

	private static bool PushFrameCounter_IsValid;

	private static IntPtr PushFrameCounter_FunctionAddress;

	private static int PushFrameCounter_ParamsSize;

	private static bool PopFrameCounter_IsValid;

	private static IntPtr PopFrameCounter_FunctionAddress;

	private static int PopFrameCounter_ParamsSize;

	private static bool NewWorld_IsValid;

	private static IntPtr NewWorld_FunctionAddress;

	private static int NewWorld_ParamsSize;

	private static bool NewWorld_ReturnValue_IsValid;

	private static FFieldAddress NewWorld_ReturnValue_PropertyAddress;

	private static int NewWorld_ReturnValue_Offset;

	private static bool DestroyWorld_IsValid;

	private static IntPtr DestroyWorld_FunctionAddress;

	private static int DestroyWorld_ParamsSize;

	private static bool DestroyWorld_World_IsValid;

	private static FFieldAddress DestroyWorld_World_PropertyAddress;

	private static int DestroyWorld_World_Offset;

	private static bool DestroyUObject_IsValid;

	private static IntPtr DestroyUObject_FunctionAddress;

	private static int DestroyUObject_ParamsSize;

	private static bool DestroyUObject_Object_IsValid;

	private static FFieldAddress DestroyUObject_Object_PropertyAddress;

	private static int DestroyUObject_Object_Offset;

	private static bool Destroy_IsValid;

	private static IntPtr Destroy_FunctionAddress;

	private static int Destroy_ParamsSize;

	private static bool Destroy_Test_IsValid;

	private static FFieldAddress Destroy_Test_PropertyAddress;

	private static int Destroy_Test_Offset;

	private static bool Create_IsValid;

	private static IntPtr Create_FunctionAddress;

	private static int Create_ParamsSize;

	private static bool Create_Test_IsValid;

	private static FFieldAddress Create_Test_PropertyAddress;

	private static int Create_Test_Offset;

	private static bool Create_ReturnValue_IsValid;

	private static FFieldAddress Create_ReturnValue_PropertyAddress;

	private static int Create_ReturnValue_Offset;

	private static bool ClearExecutionInfo_IsValid;

	private static IntPtr ClearExecutionInfo_FunctionAddress;

	private static int ClearExecutionInfo_ParamsSize;

	private static bool ClearExecutionInfo_Test_IsValid;

	private static FFieldAddress ClearExecutionInfo_Test_PropertyAddress;

	private static int ClearExecutionInfo_Test_Offset;

	private static bool BeginPlay_IsValid;

	private static IntPtr BeginPlay_FunctionAddress;

	private static int BeginPlay_ParamsSize;

	private static bool BeginPlay_World_IsValid;

	private static FFieldAddress BeginPlay_World_PropertyAddress;

	private static int BeginPlay_World_Offset;

	private static bool AddWarning_IsValid;

	private static IntPtr AddWarning_FunctionAddress;

	private static int AddWarning_ParamsSize;

	private static bool AddWarning_Test_IsValid;

	private static FFieldAddress AddWarning_Test_PropertyAddress;

	private static int AddWarning_Test_Offset;

	private static bool AddWarning_InWarning_IsValid;

	private static FFieldAddress AddWarning_InWarning_PropertyAddress;

	private static int AddWarning_InWarning_Offset;

	private static bool AddLogItem_IsValid;

	private static IntPtr AddLogItem_FunctionAddress;

	private static int AddLogItem_ParamsSize;

	private static bool AddLogItem_Test_IsValid;

	private static FFieldAddress AddLogItem_Test_PropertyAddress;

	private static int AddLogItem_Test_Offset;

	private static bool AddLogItem_InLogItem_IsValid;

	private static FFieldAddress AddLogItem_InLogItem_PropertyAddress;

	private static int AddLogItem_InLogItem_Offset;

	private static bool AddError_IsValid;

	private static IntPtr AddError_FunctionAddress;

	private static int AddError_ParamsSize;

	private static bool AddError_Test_IsValid;

	private static FFieldAddress AddError_Test_PropertyAddress;

	private static int AddError_Test_Offset;

	private static bool AddError_InError_IsValid;

	private static FFieldAddress AddError_InError_PropertyAddress;

	private static int AddError_InError_Offset;

	private static bool AddAnalyticsItem_IsValid;

	private static IntPtr AddAnalyticsItem_FunctionAddress;

	private static int AddAnalyticsItem_ParamsSize;

	private static bool AddAnalyticsItem_Test_IsValid;

	private static FFieldAddress AddAnalyticsItem_Test_PropertyAddress;

	private static int AddAnalyticsItem_Test_Offset;

	private static bool AddAnalyticsItem_InAnalyticsItem_IsValid;

	private static FFieldAddress AddAnalyticsItem_InAnalyticsItem_PropertyAddress;

	private static int AddAnalyticsItem_InAnalyticsItem_Offset;

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:SetContinue")]
	public unsafe static void SetContinue(FJavascriptAutomatedTestInstance Test, bool bInContinue)
	{
		if (!SetContinue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:SetContinue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetContinue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetContinue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetContinue_Test_PropertyAddress.Address, intPtr);
		FJavascriptAutomatedTestInstance.ToNative(IntPtr.Add(intPtr, SetContinue_Test_Offset), 0, SetContinue_Test_PropertyAddress.Address, Test);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetContinue_bInContinue_Offset), 0, SetContinue_bInContinue_PropertyAddress.Address, bInContinue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetContinue_FunctionAddress, intPtr, SetContinue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetContinue_Test_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:PushFrameCounter")]
	public unsafe static void PushFrameCounter()
	{
		if (!PushFrameCounter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:PushFrameCounter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PushFrameCounter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PushFrameCounter_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: PushFrameCounter_FunctionAddress, argsSize: PushFrameCounter_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:PopFrameCounter")]
	public unsafe static void PopFrameCounter()
	{
		if (!PopFrameCounter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:PopFrameCounter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PopFrameCounter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PopFrameCounter_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: PopFrameCounter_FunctionAddress, argsSize: PopFrameCounter_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:NewWorld")]
	public unsafe static UWorld NewWorld()
	{
		if (!NewWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:NewWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NewWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NewWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NewWorld_FunctionAddress, intPtr, NewWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, NewWorld_ReturnValue_Offset), 0, NewWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:DestroyWorld")]
	public unsafe static void DestroyWorld(UWorld World)
	{
		if (!DestroyWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:DestroyWorld");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DestroyWorld_World_Offset), 0, DestroyWorld_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DestroyWorld_FunctionAddress, intPtr, DestroyWorld_ParamsSize);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:DestroyUObject")]
	public unsafe static void DestroyUObject(UObject Object)
	{
		if (!DestroyUObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:DestroyUObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyUObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyUObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DestroyUObject_Object_Offset), 0, DestroyUObject_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DestroyUObject_FunctionAddress, intPtr, DestroyUObject_ParamsSize);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:Destroy")]
	public unsafe static void Destroy(out FJavascriptAutomatedTestInstance Test)
	{
		if (!Destroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:Destroy");
			Test = default(FJavascriptAutomatedTestInstance);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destroy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Destroy_Test_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Destroy_FunctionAddress, intPtr, Destroy_ParamsSize);
		Test = FJavascriptAutomatedTestInstance.FromNative(IntPtr.Add(intPtr, Destroy_Test_Offset), 0, Destroy_Test_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Destroy_Test_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:Create")]
	public unsafe static FJavascriptAutomatedTestInstance Create(FJavascriptAutomatedTest Test)
	{
		if (!Create_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:Create");
			return default(FJavascriptAutomatedTestInstance);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Create_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Create_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Create_Test_PropertyAddress.Address, intPtr);
		FJavascriptAutomatedTest.ToNative(IntPtr.Add(intPtr, Create_Test_Offset), 0, Create_Test_PropertyAddress.Address, Test);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Create_FunctionAddress, intPtr, Create_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Create_Test_PropertyAddress.Address, intPtr);
		FJavascriptAutomatedTestInstance result = FJavascriptAutomatedTestInstance.FromNative(IntPtr.Add(intPtr, Create_ReturnValue_Offset), 0, Create_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Create_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:ClearExecutionInfo")]
	public unsafe static void ClearExecutionInfo(FJavascriptAutomatedTestInstance Test)
	{
		if (!ClearExecutionInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:ClearExecutionInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearExecutionInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearExecutionInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ClearExecutionInfo_Test_PropertyAddress.Address, intPtr);
		FJavascriptAutomatedTestInstance.ToNative(IntPtr.Add(intPtr, ClearExecutionInfo_Test_Offset), 0, ClearExecutionInfo_Test_PropertyAddress.Address, Test);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearExecutionInfo_FunctionAddress, intPtr, ClearExecutionInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ClearExecutionInfo_Test_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:BeginPlay")]
	public unsafe static void BeginPlay(UWorld World)
	{
		if (!BeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:BeginPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BeginPlay_World_Offset), 0, BeginPlay_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BeginPlay_FunctionAddress, intPtr, BeginPlay_ParamsSize);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:AddWarning")]
	public unsafe static void AddWarning(FJavascriptAutomatedTestInstance Test, string InWarning)
	{
		if (!AddWarning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:AddWarning");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWarning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWarning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddWarning_Test_PropertyAddress.Address, intPtr);
		FJavascriptAutomatedTestInstance.ToNative(IntPtr.Add(intPtr, AddWarning_Test_Offset), 0, AddWarning_Test_PropertyAddress.Address, Test);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddWarning_InWarning_Offset), 0, AddWarning_InWarning_PropertyAddress.Address, InWarning);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddWarning_FunctionAddress, intPtr, AddWarning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddWarning_Test_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddWarning_InWarning_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:AddLogItem")]
	public unsafe static void AddLogItem(FJavascriptAutomatedTestInstance Test, string InLogItem)
	{
		if (!AddLogItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:AddLogItem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLogItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLogItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddLogItem_Test_PropertyAddress.Address, intPtr);
		FJavascriptAutomatedTestInstance.ToNative(IntPtr.Add(intPtr, AddLogItem_Test_Offset), 0, AddLogItem_Test_PropertyAddress.Address, Test);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLogItem_InLogItem_Offset), 0, AddLogItem_InLogItem_PropertyAddress.Address, InLogItem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddLogItem_FunctionAddress, intPtr, AddLogItem_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddLogItem_Test_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddLogItem_InLogItem_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:AddError")]
	public unsafe static void AddError(FJavascriptAutomatedTestInstance Test, string InError)
	{
		if (!AddError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:AddError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddError_Test_PropertyAddress.Address, intPtr);
		FJavascriptAutomatedTestInstance.ToNative(IntPtr.Add(intPtr, AddError_Test_Offset), 0, AddError_Test_PropertyAddress.Address, Test);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddError_InError_Offset), 0, AddError_InError_PropertyAddress.Address, InError);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddError_FunctionAddress, intPtr, AddError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddError_Test_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddError_InError_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71574529u)]
	[UMetaPath("/Script/V8.JavascriptTestLibrary:AddAnalyticsItem")]
	public unsafe static void AddAnalyticsItem(FJavascriptAutomatedTestInstance Test, string InAnalyticsItem)
	{
		if (!AddAnalyticsItem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptTestLibrary:AddAnalyticsItem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnalyticsItem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnalyticsItem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddAnalyticsItem_Test_PropertyAddress.Address, intPtr);
		FJavascriptAutomatedTestInstance.ToNative(IntPtr.Add(intPtr, AddAnalyticsItem_Test_Offset), 0, AddAnalyticsItem_Test_PropertyAddress.Address, Test);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddAnalyticsItem_InAnalyticsItem_Offset), 0, AddAnalyticsItem_InAnalyticsItem_PropertyAddress.Address, InAnalyticsItem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnalyticsItem_FunctionAddress, intPtr, AddAnalyticsItem_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddAnalyticsItem_Test_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddAnalyticsItem_InAnalyticsItem_PropertyAddress.Address, intPtr);
	}

	static UJavascriptTestLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptTestLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptTestLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/V8.JavascriptTestLibrary");
		SetContinue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetContinue");
		SetContinue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetContinue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetContinue_Test_PropertyAddress, SetContinue_FunctionAddress, "Test");
		SetContinue_Test_Offset = NativeReflectionCached.GetPropertyOffset(SetContinue_FunctionAddress, "Test");
		SetContinue_Test_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContinue_FunctionAddress, "Test", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetContinue_bInContinue_PropertyAddress, SetContinue_FunctionAddress, "bInContinue");
		SetContinue_bInContinue_Offset = NativeReflectionCached.GetPropertyOffset(SetContinue_FunctionAddress, "bInContinue");
		SetContinue_bInContinue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetContinue_FunctionAddress, "bInContinue", Classes.FBoolProperty);
		SetContinue_IsValid = SetContinue_FunctionAddress != IntPtr.Zero && SetContinue_Test_IsValid && SetContinue_bInContinue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:SetContinue", SetContinue_IsValid);
		PushFrameCounter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PushFrameCounter");
		PushFrameCounter_ParamsSize = NativeReflection.GetFunctionParamsSize(PushFrameCounter_FunctionAddress);
		PushFrameCounter_IsValid = PushFrameCounter_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:PushFrameCounter", PushFrameCounter_IsValid);
		PopFrameCounter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PopFrameCounter");
		PopFrameCounter_ParamsSize = NativeReflection.GetFunctionParamsSize(PopFrameCounter_FunctionAddress);
		PopFrameCounter_IsValid = PopFrameCounter_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:PopFrameCounter", PopFrameCounter_IsValid);
		NewWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NewWorld");
		NewWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(NewWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NewWorld_ReturnValue_PropertyAddress, NewWorld_FunctionAddress, "ReturnValue");
		NewWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NewWorld_FunctionAddress, "ReturnValue");
		NewWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NewWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		NewWorld_IsValid = NewWorld_FunctionAddress != IntPtr.Zero && NewWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:NewWorld", NewWorld_IsValid);
		DestroyWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DestroyWorld");
		DestroyWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyWorld_World_PropertyAddress, DestroyWorld_FunctionAddress, "World");
		DestroyWorld_World_Offset = NativeReflectionCached.GetPropertyOffset(DestroyWorld_FunctionAddress, "World");
		DestroyWorld_World_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyWorld_FunctionAddress, "World", Classes.FObjectProperty);
		DestroyWorld_IsValid = DestroyWorld_FunctionAddress != IntPtr.Zero && DestroyWorld_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:DestroyWorld", DestroyWorld_IsValid);
		DestroyUObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DestroyUObject");
		DestroyUObject_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyUObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyUObject_Object_PropertyAddress, DestroyUObject_FunctionAddress, "Object");
		DestroyUObject_Object_Offset = NativeReflectionCached.GetPropertyOffset(DestroyUObject_FunctionAddress, "Object");
		DestroyUObject_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyUObject_FunctionAddress, "Object", Classes.FObjectProperty);
		DestroyUObject_IsValid = DestroyUObject_FunctionAddress != IntPtr.Zero && DestroyUObject_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:DestroyUObject", DestroyUObject_IsValid);
		Destroy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Destroy");
		Destroy_ParamsSize = NativeReflection.GetFunctionParamsSize(Destroy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Destroy_Test_PropertyAddress, Destroy_FunctionAddress, "Test");
		Destroy_Test_Offset = NativeReflectionCached.GetPropertyOffset(Destroy_FunctionAddress, "Test");
		Destroy_Test_IsValid = NativeReflectionCached.ValidatePropertyClass(Destroy_FunctionAddress, "Test", Classes.FStructProperty);
		Destroy_IsValid = Destroy_FunctionAddress != IntPtr.Zero && Destroy_Test_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:Destroy", Destroy_IsValid);
		Create_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Create");
		Create_ParamsSize = NativeReflection.GetFunctionParamsSize(Create_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Create_Test_PropertyAddress, Create_FunctionAddress, "Test");
		Create_Test_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "Test");
		Create_Test_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "Test", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Create_ReturnValue_PropertyAddress, Create_FunctionAddress, "ReturnValue");
		Create_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Create_FunctionAddress, "ReturnValue");
		Create_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Create_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Create_IsValid = Create_FunctionAddress != IntPtr.Zero && Create_Test_IsValid && Create_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:Create", Create_IsValid);
		ClearExecutionInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearExecutionInfo");
		ClearExecutionInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearExecutionInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearExecutionInfo_Test_PropertyAddress, ClearExecutionInfo_FunctionAddress, "Test");
		ClearExecutionInfo_Test_Offset = NativeReflectionCached.GetPropertyOffset(ClearExecutionInfo_FunctionAddress, "Test");
		ClearExecutionInfo_Test_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearExecutionInfo_FunctionAddress, "Test", Classes.FStructProperty);
		ClearExecutionInfo_IsValid = ClearExecutionInfo_FunctionAddress != IntPtr.Zero && ClearExecutionInfo_Test_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:ClearExecutionInfo", ClearExecutionInfo_IsValid);
		BeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BeginPlay");
		BeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BeginPlay_World_PropertyAddress, BeginPlay_FunctionAddress, "World");
		BeginPlay_World_Offset = NativeReflectionCached.GetPropertyOffset(BeginPlay_FunctionAddress, "World");
		BeginPlay_World_IsValid = NativeReflectionCached.ValidatePropertyClass(BeginPlay_FunctionAddress, "World", Classes.FObjectProperty);
		BeginPlay_IsValid = BeginPlay_FunctionAddress != IntPtr.Zero && BeginPlay_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:BeginPlay", BeginPlay_IsValid);
		AddWarning_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddWarning");
		AddWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWarning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWarning_Test_PropertyAddress, AddWarning_FunctionAddress, "Test");
		AddWarning_Test_Offset = NativeReflectionCached.GetPropertyOffset(AddWarning_FunctionAddress, "Test");
		AddWarning_Test_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWarning_FunctionAddress, "Test", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddWarning_InWarning_PropertyAddress, AddWarning_FunctionAddress, "InWarning");
		AddWarning_InWarning_Offset = NativeReflectionCached.GetPropertyOffset(AddWarning_FunctionAddress, "InWarning");
		AddWarning_InWarning_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWarning_FunctionAddress, "InWarning", Classes.FStrProperty);
		AddWarning_IsValid = AddWarning_FunctionAddress != IntPtr.Zero && AddWarning_Test_IsValid && AddWarning_InWarning_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:AddWarning", AddWarning_IsValid);
		AddLogItem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddLogItem");
		AddLogItem_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLogItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLogItem_Test_PropertyAddress, AddLogItem_FunctionAddress, "Test");
		AddLogItem_Test_Offset = NativeReflectionCached.GetPropertyOffset(AddLogItem_FunctionAddress, "Test");
		AddLogItem_Test_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLogItem_FunctionAddress, "Test", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLogItem_InLogItem_PropertyAddress, AddLogItem_FunctionAddress, "InLogItem");
		AddLogItem_InLogItem_Offset = NativeReflectionCached.GetPropertyOffset(AddLogItem_FunctionAddress, "InLogItem");
		AddLogItem_InLogItem_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLogItem_FunctionAddress, "InLogItem", Classes.FStrProperty);
		AddLogItem_IsValid = AddLogItem_FunctionAddress != IntPtr.Zero && AddLogItem_Test_IsValid && AddLogItem_InLogItem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:AddLogItem", AddLogItem_IsValid);
		AddError_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddError");
		AddError_ParamsSize = NativeReflection.GetFunctionParamsSize(AddError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddError_Test_PropertyAddress, AddError_FunctionAddress, "Test");
		AddError_Test_Offset = NativeReflectionCached.GetPropertyOffset(AddError_FunctionAddress, "Test");
		AddError_Test_IsValid = NativeReflectionCached.ValidatePropertyClass(AddError_FunctionAddress, "Test", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddError_InError_PropertyAddress, AddError_FunctionAddress, "InError");
		AddError_InError_Offset = NativeReflectionCached.GetPropertyOffset(AddError_FunctionAddress, "InError");
		AddError_InError_IsValid = NativeReflectionCached.ValidatePropertyClass(AddError_FunctionAddress, "InError", Classes.FStrProperty);
		AddError_IsValid = AddError_FunctionAddress != IntPtr.Zero && AddError_Test_IsValid && AddError_InError_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:AddError", AddError_IsValid);
		AddAnalyticsItem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnalyticsItem");
		AddAnalyticsItem_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnalyticsItem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnalyticsItem_Test_PropertyAddress, AddAnalyticsItem_FunctionAddress, "Test");
		AddAnalyticsItem_Test_Offset = NativeReflectionCached.GetPropertyOffset(AddAnalyticsItem_FunctionAddress, "Test");
		AddAnalyticsItem_Test_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnalyticsItem_FunctionAddress, "Test", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnalyticsItem_InAnalyticsItem_PropertyAddress, AddAnalyticsItem_FunctionAddress, "InAnalyticsItem");
		AddAnalyticsItem_InAnalyticsItem_Offset = NativeReflectionCached.GetPropertyOffset(AddAnalyticsItem_FunctionAddress, "InAnalyticsItem");
		AddAnalyticsItem_InAnalyticsItem_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnalyticsItem_FunctionAddress, "InAnalyticsItem", Classes.FStrProperty);
		AddAnalyticsItem_IsValid = AddAnalyticsItem_FunctionAddress != IntPtr.Zero && AddAnalyticsItem_Test_IsValid && AddAnalyticsItem_InAnalyticsItem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptTestLibrary:AddAnalyticsItem", AddAnalyticsItem_IsValid);
	}
}
