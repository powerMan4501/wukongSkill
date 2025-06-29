using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FunctionalTesting.FunctionalTest", "FunctionalTesting", UnrealModuleType.Engine)]
public class AFunctionalTest : AActor
{
	private static bool TestLabel_IsValid;

	private static int TestLabel_Offset;

	private static bool IsEnabledValue_IsValid;

	private static FFieldAddress IsEnabledValue_PropertyAddress;

	private static int IsEnabledValue_Offset;

	private static bool LogErrorHandling_IsValid;

	private static FFieldAddress LogErrorHandling_PropertyAddress;

	private static int LogErrorHandling_Offset;

	private static bool LogWarningHandling_IsValid;

	private static FFieldAddress LogWarningHandling_PropertyAddress;

	private static int LogWarningHandling_Offset;

	private static bool Author_IsValid;

	private static int Author_Offset;

	private static bool Description_IsValid;

	private static int Description_Offset;

	private static bool ObservationPoint_IsValid;

	private static int ObservationPoint_Offset;

	private static bool RandomNumbersStream_IsValid;

	private static int RandomNumbersStream_Offset;

	private static bool Result_IsValid;

	private static FFieldAddress Result_PropertyAddress;

	private static int Result_Offset;

	private static bool PreparationTimeLimit_IsValid;

	private static int PreparationTimeLimit_Offset;

	private static bool TimeLimit_IsValid;

	private static int TimeLimit_Offset;

	private static bool TimesUpMessage_IsValid;

	private static int TimesUpMessage_Offset;

	private FText TimesUpMessage_TextCached;

	private static bool OnTestPrepare_IsValid;

	private static int OnTestPrepare_Offset;

	private FFunctionalTestEventSignature OnTestPrepare_DelegateCached;

	private static bool OnTestStart_IsValid;

	private static int OnTestStart_Offset;

	private FFunctionalTestEventSignature OnTestStart_DelegateCached;

	private static bool OnTestFinished_IsValid;

	private static int OnTestFinished_Offset;

	private FFunctionalTestEventSignature OnTestFinished_DelegateCached;

	private static bool TotalTime_IsValid;

	private static int TotalTime_Offset;

	private static bool SetTimeLimit_IsValid;

	private static IntPtr SetTimeLimit_FunctionAddress;

	private static int SetTimeLimit_ParamsSize;

	private static bool SetTimeLimit_NewTimeLimit_IsValid;

	private static FFieldAddress SetTimeLimit_NewTimeLimit_PropertyAddress;

	private static int SetTimeLimit_NewTimeLimit_Offset;

	private static bool SetTimeLimit_ResultWhenTimeRunsOut_IsValid;

	private static FFieldAddress SetTimeLimit_ResultWhenTimeRunsOut_PropertyAddress;

	private static int SetTimeLimit_ResultWhenTimeRunsOut_Offset;

	private static bool RegisterAutoDestroyActor_IsValid;

	private static IntPtr RegisterAutoDestroyActor_FunctionAddress;

	private static int RegisterAutoDestroyActor_ParamsSize;

	private static bool RegisterAutoDestroyActor_ActorToAutoDestroy_IsValid;

	private static FFieldAddress RegisterAutoDestroyActor_ActorToAutoDestroy_PropertyAddress;

	private static int RegisterAutoDestroyActor_ActorToAutoDestroy_Offset;

	private static bool ReceiveStartTest_IsValid;

	private IntPtr ReceiveStartTest_InstanceFunctionAddress;

	private static IntPtr ReceiveStartTest_FunctionAddress;

	private static int ReceiveStartTest_ParamsSize;

	private static bool ReceivePrepareTest_IsValid;

	private IntPtr ReceivePrepareTest_InstanceFunctionAddress;

	private static IntPtr ReceivePrepareTest_FunctionAddress;

	private static int ReceivePrepareTest_ParamsSize;

	private static bool OnWantsReRunCheck_IsValid;

	private IntPtr OnWantsReRunCheck_InstanceFunctionAddress;

	private static IntPtr OnWantsReRunCheck_FunctionAddress;

	private static int OnWantsReRunCheck_ParamsSize;

	private static bool OnWantsReRunCheck_ReturnValue_IsValid;

	private static FFieldAddress OnWantsReRunCheck_ReturnValue_PropertyAddress;

	private static int OnWantsReRunCheck_ReturnValue_Offset;

	private static bool OnAdditionalTestFinishedMessageRequest_IsValid;

	private IntPtr OnAdditionalTestFinishedMessageRequest_InstanceFunctionAddress;

	private static IntPtr OnAdditionalTestFinishedMessageRequest_FunctionAddress;

	private static int OnAdditionalTestFinishedMessageRequest_ParamsSize;

	private static bool OnAdditionalTestFinishedMessageRequest_TestResult_IsValid;

	private static FFieldAddress OnAdditionalTestFinishedMessageRequest_TestResult_PropertyAddress;

	private static int OnAdditionalTestFinishedMessageRequest_TestResult_Offset;

	private static bool OnAdditionalTestFinishedMessageRequest_ReturnValue_IsValid;

	private static FFieldAddress OnAdditionalTestFinishedMessageRequest_ReturnValue_PropertyAddress;

	private static int OnAdditionalTestFinishedMessageRequest_ReturnValue_Offset;

	private static bool LogMessage_IsValid;

	private static IntPtr LogMessage_FunctionAddress;

	private static int LogMessage_ParamsSize;

	private static bool LogMessage_Message_IsValid;

	private static FFieldAddress LogMessage_Message_PropertyAddress;

	private static int LogMessage_Message_Offset;

	private static bool IsRunning_IsValid;

	private static IntPtr IsRunning_FunctionAddress;

	private static int IsRunning_ParamsSize;

	private static bool IsRunning_ReturnValue_IsValid;

	private static FFieldAddress IsRunning_ReturnValue_PropertyAddress;

	private static int IsRunning_ReturnValue_Offset;

	private static bool IsReady_IsValid;

	private IntPtr IsReady_InstanceFunctionAddress;

	private static IntPtr IsReady_FunctionAddress;

	private static int IsReady_ParamsSize;

	private static bool IsReady_ReturnValue_IsValid;

	private static FFieldAddress IsReady_ReturnValue_PropertyAddress;

	private static int IsReady_ReturnValue_Offset;

	private static bool IsEnabled_IsValid;

	private static IntPtr IsEnabled_FunctionAddress;

	private static int IsEnabled_ParamsSize;

	private static bool IsEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsEnabled_ReturnValue_PropertyAddress;

	private static int IsEnabled_ReturnValue_Offset;

	private static bool GetCurrentRerunReason_IsValid;

	private static IntPtr GetCurrentRerunReason_FunctionAddress;

	private static int GetCurrentRerunReason_ParamsSize;

	private static bool GetCurrentRerunReason_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentRerunReason_ReturnValue_PropertyAddress;

	private static int GetCurrentRerunReason_ReturnValue_Offset;

	private static bool FinishTest_IsValid;

	private static IntPtr FinishTest_FunctionAddress;

	private static int FinishTest_ParamsSize;

	private static bool FinishTest_TestResult_IsValid;

	private static FFieldAddress FinishTest_TestResult_PropertyAddress;

	private static int FinishTest_TestResult_Offset;

	private static bool FinishTest_Message_IsValid;

	private static FFieldAddress FinishTest_Message_PropertyAddress;

	private static int FinishTest_Message_Offset;

	private static bool DebugGatherRelevantActors_IsValid;

	private IntPtr DebugGatherRelevantActors_InstanceFunctionAddress;

	private static IntPtr DebugGatherRelevantActors_FunctionAddress;

	private static int DebugGatherRelevantActors_ParamsSize;

	private static bool DebugGatherRelevantActors_ReturnValue_IsValid;

	private static FFieldAddress DebugGatherRelevantActors_ReturnValue_PropertyAddress;

	private static int DebugGatherRelevantActors_ReturnValue_Offset;

	private static bool AssertValue_Int_IsValid;

	private static IntPtr AssertValue_Int_FunctionAddress;

	private static int AssertValue_Int_ParamsSize;

	private static bool AssertValue_Int_Actual_IsValid;

	private static FFieldAddress AssertValue_Int_Actual_PropertyAddress;

	private static int AssertValue_Int_Actual_Offset;

	private static bool AssertValue_Int_ShouldBe_IsValid;

	private static FFieldAddress AssertValue_Int_ShouldBe_PropertyAddress;

	private static int AssertValue_Int_ShouldBe_Offset;

	private static bool AssertValue_Int_Expected_IsValid;

	private static FFieldAddress AssertValue_Int_Expected_PropertyAddress;

	private static int AssertValue_Int_Expected_Offset;

	private static bool AssertValue_Int_What_IsValid;

	private static FFieldAddress AssertValue_Int_What_PropertyAddress;

	private static int AssertValue_Int_What_Offset;

	private static bool AssertValue_Int_ContextObject_IsValid;

	private static FFieldAddress AssertValue_Int_ContextObject_PropertyAddress;

	private static int AssertValue_Int_ContextObject_Offset;

	private static bool AssertValue_Int_ReturnValue_IsValid;

	private static FFieldAddress AssertValue_Int_ReturnValue_PropertyAddress;

	private static int AssertValue_Int_ReturnValue_Offset;

	private static bool AssertValue_Float_IsValid;

	private static IntPtr AssertValue_Float_FunctionAddress;

	private static int AssertValue_Float_ParamsSize;

	private static bool AssertValue_Float_Actual_IsValid;

	private static FFieldAddress AssertValue_Float_Actual_PropertyAddress;

	private static int AssertValue_Float_Actual_Offset;

	private static bool AssertValue_Float_ShouldBe_IsValid;

	private static FFieldAddress AssertValue_Float_ShouldBe_PropertyAddress;

	private static int AssertValue_Float_ShouldBe_Offset;

	private static bool AssertValue_Float_Expected_IsValid;

	private static FFieldAddress AssertValue_Float_Expected_PropertyAddress;

	private static int AssertValue_Float_Expected_Offset;

	private static bool AssertValue_Float_What_IsValid;

	private static FFieldAddress AssertValue_Float_What_PropertyAddress;

	private static int AssertValue_Float_What_Offset;

	private static bool AssertValue_Float_ContextObject_IsValid;

	private static FFieldAddress AssertValue_Float_ContextObject_PropertyAddress;

	private static int AssertValue_Float_ContextObject_Offset;

	private static bool AssertValue_Float_ReturnValue_IsValid;

	private static FFieldAddress AssertValue_Float_ReturnValue_PropertyAddress;

	private static int AssertValue_Float_ReturnValue_Offset;

	private static bool AssertValue_Double_IsValid;

	private static IntPtr AssertValue_Double_FunctionAddress;

	private static int AssertValue_Double_ParamsSize;

	private static bool AssertValue_Double_Actual_IsValid;

	private static FFieldAddress AssertValue_Double_Actual_PropertyAddress;

	private static int AssertValue_Double_Actual_Offset;

	private static bool AssertValue_Double_ShouldBe_IsValid;

	private static FFieldAddress AssertValue_Double_ShouldBe_PropertyAddress;

	private static int AssertValue_Double_ShouldBe_Offset;

	private static bool AssertValue_Double_Expected_IsValid;

	private static FFieldAddress AssertValue_Double_Expected_PropertyAddress;

	private static int AssertValue_Double_Expected_Offset;

	private static bool AssertValue_Double_What_IsValid;

	private static FFieldAddress AssertValue_Double_What_PropertyAddress;

	private static int AssertValue_Double_What_Offset;

	private static bool AssertValue_Double_ContextObject_IsValid;

	private static FFieldAddress AssertValue_Double_ContextObject_PropertyAddress;

	private static int AssertValue_Double_ContextObject_Offset;

	private static bool AssertValue_Double_ReturnValue_IsValid;

	private static FFieldAddress AssertValue_Double_ReturnValue_PropertyAddress;

	private static int AssertValue_Double_ReturnValue_Offset;

	private static bool AssertValue_DateTime_IsValid;

	private static IntPtr AssertValue_DateTime_FunctionAddress;

	private static int AssertValue_DateTime_ParamsSize;

	private static bool AssertValue_DateTime_Actual_IsValid;

	private static FFieldAddress AssertValue_DateTime_Actual_PropertyAddress;

	private static int AssertValue_DateTime_Actual_Offset;

	private static bool AssertValue_DateTime_ShouldBe_IsValid;

	private static FFieldAddress AssertValue_DateTime_ShouldBe_PropertyAddress;

	private static int AssertValue_DateTime_ShouldBe_Offset;

	private static bool AssertValue_DateTime_Expected_IsValid;

	private static FFieldAddress AssertValue_DateTime_Expected_PropertyAddress;

	private static int AssertValue_DateTime_Expected_Offset;

	private static bool AssertValue_DateTime_What_IsValid;

	private static FFieldAddress AssertValue_DateTime_What_PropertyAddress;

	private static int AssertValue_DateTime_What_Offset;

	private static bool AssertValue_DateTime_ContextObject_IsValid;

	private static FFieldAddress AssertValue_DateTime_ContextObject_PropertyAddress;

	private static int AssertValue_DateTime_ContextObject_Offset;

	private static bool AssertValue_DateTime_ReturnValue_IsValid;

	private static FFieldAddress AssertValue_DateTime_ReturnValue_PropertyAddress;

	private static int AssertValue_DateTime_ReturnValue_Offset;

	private static bool AssertTrue_IsValid;

	private static IntPtr AssertTrue_FunctionAddress;

	private static int AssertTrue_ParamsSize;

	private static bool AssertTrue_Condition_IsValid;

	private static FFieldAddress AssertTrue_Condition_PropertyAddress;

	private static int AssertTrue_Condition_Offset;

	private static bool AssertTrue_Message_IsValid;

	private static FFieldAddress AssertTrue_Message_PropertyAddress;

	private static int AssertTrue_Message_Offset;

	private static bool AssertTrue_ContextObject_IsValid;

	private static FFieldAddress AssertTrue_ContextObject_PropertyAddress;

	private static int AssertTrue_ContextObject_Offset;

	private static bool AssertTrue_ReturnValue_IsValid;

	private static FFieldAddress AssertTrue_ReturnValue_PropertyAddress;

	private static int AssertTrue_ReturnValue_Offset;

	private static bool AssertNotEqual_Vector_IsValid;

	private static IntPtr AssertNotEqual_Vector_FunctionAddress;

	private static int AssertNotEqual_Vector_ParamsSize;

	private static bool AssertNotEqual_Vector_Actual_IsValid;

	private static FFieldAddress AssertNotEqual_Vector_Actual_PropertyAddress;

	private static int AssertNotEqual_Vector_Actual_Offset;

	private static bool AssertNotEqual_Vector_NotExpected_IsValid;

	private static FFieldAddress AssertNotEqual_Vector_NotExpected_PropertyAddress;

	private static int AssertNotEqual_Vector_NotExpected_Offset;

	private static bool AssertNotEqual_Vector_What_IsValid;

	private static FFieldAddress AssertNotEqual_Vector_What_PropertyAddress;

	private static int AssertNotEqual_Vector_What_Offset;

	private static bool AssertNotEqual_Vector_ContextObject_IsValid;

	private static FFieldAddress AssertNotEqual_Vector_ContextObject_PropertyAddress;

	private static int AssertNotEqual_Vector_ContextObject_Offset;

	private static bool AssertNotEqual_Vector_ReturnValue_IsValid;

	private static FFieldAddress AssertNotEqual_Vector_ReturnValue_PropertyAddress;

	private static int AssertNotEqual_Vector_ReturnValue_Offset;

	private static bool AssertNotEqual_Transform_IsValid;

	private static IntPtr AssertNotEqual_Transform_FunctionAddress;

	private static int AssertNotEqual_Transform_ParamsSize;

	private static bool AssertNotEqual_Transform_Actual_IsValid;

	private static FFieldAddress AssertNotEqual_Transform_Actual_PropertyAddress;

	private static int AssertNotEqual_Transform_Actual_Offset;

	private static bool AssertNotEqual_Transform_NotExpected_IsValid;

	private static FFieldAddress AssertNotEqual_Transform_NotExpected_PropertyAddress;

	private static int AssertNotEqual_Transform_NotExpected_Offset;

	private static bool AssertNotEqual_Transform_What_IsValid;

	private static FFieldAddress AssertNotEqual_Transform_What_PropertyAddress;

	private static int AssertNotEqual_Transform_What_Offset;

	private static bool AssertNotEqual_Transform_ContextObject_IsValid;

	private static FFieldAddress AssertNotEqual_Transform_ContextObject_PropertyAddress;

	private static int AssertNotEqual_Transform_ContextObject_Offset;

	private static bool AssertNotEqual_Transform_ReturnValue_IsValid;

	private static FFieldAddress AssertNotEqual_Transform_ReturnValue_PropertyAddress;

	private static int AssertNotEqual_Transform_ReturnValue_Offset;

	private static bool AssertNotEqual_String_IsValid;

	private static IntPtr AssertNotEqual_String_FunctionAddress;

	private static int AssertNotEqual_String_ParamsSize;

	private static bool AssertNotEqual_String_Actual_IsValid;

	private static FFieldAddress AssertNotEqual_String_Actual_PropertyAddress;

	private static int AssertNotEqual_String_Actual_Offset;

	private static bool AssertNotEqual_String_NotExpected_IsValid;

	private static FFieldAddress AssertNotEqual_String_NotExpected_PropertyAddress;

	private static int AssertNotEqual_String_NotExpected_Offset;

	private static bool AssertNotEqual_String_What_IsValid;

	private static FFieldAddress AssertNotEqual_String_What_PropertyAddress;

	private static int AssertNotEqual_String_What_Offset;

	private static bool AssertNotEqual_String_ContextObject_IsValid;

	private static FFieldAddress AssertNotEqual_String_ContextObject_PropertyAddress;

	private static int AssertNotEqual_String_ContextObject_Offset;

	private static bool AssertNotEqual_String_ReturnValue_IsValid;

	private static FFieldAddress AssertNotEqual_String_ReturnValue_PropertyAddress;

	private static int AssertNotEqual_String_ReturnValue_Offset;

	private static bool AssertNotEqual_Rotator_IsValid;

	private static IntPtr AssertNotEqual_Rotator_FunctionAddress;

	private static int AssertNotEqual_Rotator_ParamsSize;

	private static bool AssertNotEqual_Rotator_Actual_IsValid;

	private static FFieldAddress AssertNotEqual_Rotator_Actual_PropertyAddress;

	private static int AssertNotEqual_Rotator_Actual_Offset;

	private static bool AssertNotEqual_Rotator_NotExpected_IsValid;

	private static FFieldAddress AssertNotEqual_Rotator_NotExpected_PropertyAddress;

	private static int AssertNotEqual_Rotator_NotExpected_Offset;

	private static bool AssertNotEqual_Rotator_What_IsValid;

	private static FFieldAddress AssertNotEqual_Rotator_What_PropertyAddress;

	private static int AssertNotEqual_Rotator_What_Offset;

	private static bool AssertNotEqual_Rotator_ContextObject_IsValid;

	private static FFieldAddress AssertNotEqual_Rotator_ContextObject_PropertyAddress;

	private static int AssertNotEqual_Rotator_ContextObject_Offset;

	private static bool AssertNotEqual_Rotator_ReturnValue_IsValid;

	private static FFieldAddress AssertNotEqual_Rotator_ReturnValue_PropertyAddress;

	private static int AssertNotEqual_Rotator_ReturnValue_Offset;

	private static bool AssertIsValid_IsValid;

	private static IntPtr AssertIsValid_FunctionAddress;

	private static int AssertIsValid_ParamsSize;

	private static bool AssertIsValid_Object_IsValid;

	private static FFieldAddress AssertIsValid_Object_PropertyAddress;

	private static int AssertIsValid_Object_Offset;

	private static bool AssertIsValid_Message_IsValid;

	private static FFieldAddress AssertIsValid_Message_PropertyAddress;

	private static int AssertIsValid_Message_Offset;

	private static bool AssertIsValid_ContextObject_IsValid;

	private static FFieldAddress AssertIsValid_ContextObject_PropertyAddress;

	private static int AssertIsValid_ContextObject_Offset;

	private static bool AssertIsValid_ReturnValue_IsValid;

	private static FFieldAddress AssertIsValid_ReturnValue_PropertyAddress;

	private static int AssertIsValid_ReturnValue_Offset;

	private static bool AssertFalse_IsValid;

	private static IntPtr AssertFalse_FunctionAddress;

	private static int AssertFalse_ParamsSize;

	private static bool AssertFalse_Condition_IsValid;

	private static FFieldAddress AssertFalse_Condition_PropertyAddress;

	private static int AssertFalse_Condition_Offset;

	private static bool AssertFalse_Message_IsValid;

	private static FFieldAddress AssertFalse_Message_PropertyAddress;

	private static int AssertFalse_Message_Offset;

	private static bool AssertFalse_ContextObject_IsValid;

	private static FFieldAddress AssertFalse_ContextObject_PropertyAddress;

	private static int AssertFalse_ContextObject_Offset;

	private static bool AssertFalse_ReturnValue_IsValid;

	private static FFieldAddress AssertFalse_ReturnValue_PropertyAddress;

	private static int AssertFalse_ReturnValue_Offset;

	private static bool AssertEqual_Vector_IsValid;

	private static IntPtr AssertEqual_Vector_FunctionAddress;

	private static int AssertEqual_Vector_ParamsSize;

	private static bool AssertEqual_Vector_Actual_IsValid;

	private static FFieldAddress AssertEqual_Vector_Actual_PropertyAddress;

	private static int AssertEqual_Vector_Actual_Offset;

	private static bool AssertEqual_Vector_Expected_IsValid;

	private static FFieldAddress AssertEqual_Vector_Expected_PropertyAddress;

	private static int AssertEqual_Vector_Expected_Offset;

	private static bool AssertEqual_Vector_What_IsValid;

	private static FFieldAddress AssertEqual_Vector_What_PropertyAddress;

	private static int AssertEqual_Vector_What_Offset;

	private static bool AssertEqual_Vector_Tolerance_IsValid;

	private static FFieldAddress AssertEqual_Vector_Tolerance_PropertyAddress;

	private static int AssertEqual_Vector_Tolerance_Offset;

	private static bool AssertEqual_Vector_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_Vector_ContextObject_PropertyAddress;

	private static int AssertEqual_Vector_ContextObject_Offset;

	private static bool AssertEqual_Vector_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_Vector_ReturnValue_PropertyAddress;

	private static int AssertEqual_Vector_ReturnValue_Offset;

	private static bool AssertEqual_Transform_IsValid;

	private static IntPtr AssertEqual_Transform_FunctionAddress;

	private static int AssertEqual_Transform_ParamsSize;

	private static bool AssertEqual_Transform_Actual_IsValid;

	private static FFieldAddress AssertEqual_Transform_Actual_PropertyAddress;

	private static int AssertEqual_Transform_Actual_Offset;

	private static bool AssertEqual_Transform_Expected_IsValid;

	private static FFieldAddress AssertEqual_Transform_Expected_PropertyAddress;

	private static int AssertEqual_Transform_Expected_Offset;

	private static bool AssertEqual_Transform_What_IsValid;

	private static FFieldAddress AssertEqual_Transform_What_PropertyAddress;

	private static int AssertEqual_Transform_What_Offset;

	private static bool AssertEqual_Transform_Tolerance_IsValid;

	private static FFieldAddress AssertEqual_Transform_Tolerance_PropertyAddress;

	private static int AssertEqual_Transform_Tolerance_Offset;

	private static bool AssertEqual_Transform_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_Transform_ContextObject_PropertyAddress;

	private static int AssertEqual_Transform_ContextObject_Offset;

	private static bool AssertEqual_Transform_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_Transform_ReturnValue_PropertyAddress;

	private static int AssertEqual_Transform_ReturnValue_Offset;

	private static bool AssertEqual_TraceQueryResults_IsValid;

	private static IntPtr AssertEqual_TraceQueryResults_FunctionAddress;

	private static int AssertEqual_TraceQueryResults_ParamsSize;

	private static bool AssertEqual_TraceQueryResults_Actual_IsValid;

	private static FFieldAddress AssertEqual_TraceQueryResults_Actual_PropertyAddress;

	private static int AssertEqual_TraceQueryResults_Actual_Offset;

	private static bool AssertEqual_TraceQueryResults_Expected_IsValid;

	private static FFieldAddress AssertEqual_TraceQueryResults_Expected_PropertyAddress;

	private static int AssertEqual_TraceQueryResults_Expected_Offset;

	private static bool AssertEqual_TraceQueryResults_What_IsValid;

	private static FFieldAddress AssertEqual_TraceQueryResults_What_PropertyAddress;

	private static int AssertEqual_TraceQueryResults_What_Offset;

	private static bool AssertEqual_TraceQueryResults_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_TraceQueryResults_ContextObject_PropertyAddress;

	private static int AssertEqual_TraceQueryResults_ContextObject_Offset;

	private static bool AssertEqual_TraceQueryResults_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_TraceQueryResults_ReturnValue_PropertyAddress;

	private static int AssertEqual_TraceQueryResults_ReturnValue_Offset;

	private static bool AssertEqual_String_IsValid;

	private static IntPtr AssertEqual_String_FunctionAddress;

	private static int AssertEqual_String_ParamsSize;

	private static bool AssertEqual_String_Actual_IsValid;

	private static FFieldAddress AssertEqual_String_Actual_PropertyAddress;

	private static int AssertEqual_String_Actual_Offset;

	private static bool AssertEqual_String_Expected_IsValid;

	private static FFieldAddress AssertEqual_String_Expected_PropertyAddress;

	private static int AssertEqual_String_Expected_Offset;

	private static bool AssertEqual_String_What_IsValid;

	private static FFieldAddress AssertEqual_String_What_PropertyAddress;

	private static int AssertEqual_String_What_Offset;

	private static bool AssertEqual_String_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_String_ContextObject_PropertyAddress;

	private static int AssertEqual_String_ContextObject_Offset;

	private static bool AssertEqual_String_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_String_ReturnValue_PropertyAddress;

	private static int AssertEqual_String_ReturnValue_Offset;

	private static bool AssertEqual_Rotator_IsValid;

	private static IntPtr AssertEqual_Rotator_FunctionAddress;

	private static int AssertEqual_Rotator_ParamsSize;

	private static bool AssertEqual_Rotator_Actual_IsValid;

	private static FFieldAddress AssertEqual_Rotator_Actual_PropertyAddress;

	private static int AssertEqual_Rotator_Actual_Offset;

	private static bool AssertEqual_Rotator_Expected_IsValid;

	private static FFieldAddress AssertEqual_Rotator_Expected_PropertyAddress;

	private static int AssertEqual_Rotator_Expected_Offset;

	private static bool AssertEqual_Rotator_What_IsValid;

	private static FFieldAddress AssertEqual_Rotator_What_PropertyAddress;

	private static int AssertEqual_Rotator_What_Offset;

	private static bool AssertEqual_Rotator_Tolerance_IsValid;

	private static FFieldAddress AssertEqual_Rotator_Tolerance_PropertyAddress;

	private static int AssertEqual_Rotator_Tolerance_Offset;

	private static bool AssertEqual_Rotator_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_Rotator_ContextObject_PropertyAddress;

	private static int AssertEqual_Rotator_ContextObject_Offset;

	private static bool AssertEqual_Rotator_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_Rotator_ReturnValue_PropertyAddress;

	private static int AssertEqual_Rotator_ReturnValue_Offset;

	private static bool AssertEqual_Object_IsValid;

	private static IntPtr AssertEqual_Object_FunctionAddress;

	private static int AssertEqual_Object_ParamsSize;

	private static bool AssertEqual_Object_Actual_IsValid;

	private static FFieldAddress AssertEqual_Object_Actual_PropertyAddress;

	private static int AssertEqual_Object_Actual_Offset;

	private static bool AssertEqual_Object_Expected_IsValid;

	private static FFieldAddress AssertEqual_Object_Expected_PropertyAddress;

	private static int AssertEqual_Object_Expected_Offset;

	private static bool AssertEqual_Object_What_IsValid;

	private static FFieldAddress AssertEqual_Object_What_PropertyAddress;

	private static int AssertEqual_Object_What_Offset;

	private static bool AssertEqual_Object_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_Object_ContextObject_PropertyAddress;

	private static int AssertEqual_Object_ContextObject_Offset;

	private static bool AssertEqual_Object_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_Object_ReturnValue_PropertyAddress;

	private static int AssertEqual_Object_ReturnValue_Offset;

	private static bool AssertEqual_Name_IsValid;

	private static IntPtr AssertEqual_Name_FunctionAddress;

	private static int AssertEqual_Name_ParamsSize;

	private static bool AssertEqual_Name_Actual_IsValid;

	private static FFieldAddress AssertEqual_Name_Actual_PropertyAddress;

	private static int AssertEqual_Name_Actual_Offset;

	private static bool AssertEqual_Name_Expected_IsValid;

	private static FFieldAddress AssertEqual_Name_Expected_PropertyAddress;

	private static int AssertEqual_Name_Expected_Offset;

	private static bool AssertEqual_Name_What_IsValid;

	private static FFieldAddress AssertEqual_Name_What_PropertyAddress;

	private static int AssertEqual_Name_What_Offset;

	private static bool AssertEqual_Name_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_Name_ContextObject_PropertyAddress;

	private static int AssertEqual_Name_ContextObject_Offset;

	private static bool AssertEqual_Name_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_Name_ReturnValue_PropertyAddress;

	private static int AssertEqual_Name_ReturnValue_Offset;

	private static bool AssertEqual_Int_IsValid;

	private static IntPtr AssertEqual_Int_FunctionAddress;

	private static int AssertEqual_Int_ParamsSize;

	private static bool AssertEqual_Int_Actual_IsValid;

	private static FFieldAddress AssertEqual_Int_Actual_PropertyAddress;

	private static int AssertEqual_Int_Actual_Offset;

	private static bool AssertEqual_Int_Expected_IsValid;

	private static FFieldAddress AssertEqual_Int_Expected_PropertyAddress;

	private static int AssertEqual_Int_Expected_Offset;

	private static bool AssertEqual_Int_What_IsValid;

	private static FFieldAddress AssertEqual_Int_What_PropertyAddress;

	private static int AssertEqual_Int_What_Offset;

	private static bool AssertEqual_Int_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_Int_ContextObject_PropertyAddress;

	private static int AssertEqual_Int_ContextObject_Offset;

	private static bool AssertEqual_Int_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_Int_ReturnValue_PropertyAddress;

	private static int AssertEqual_Int_ReturnValue_Offset;

	private static bool AssertEqual_Float_IsValid;

	private static IntPtr AssertEqual_Float_FunctionAddress;

	private static int AssertEqual_Float_ParamsSize;

	private static bool AssertEqual_Float_Actual_IsValid;

	private static FFieldAddress AssertEqual_Float_Actual_PropertyAddress;

	private static int AssertEqual_Float_Actual_Offset;

	private static bool AssertEqual_Float_Expected_IsValid;

	private static FFieldAddress AssertEqual_Float_Expected_PropertyAddress;

	private static int AssertEqual_Float_Expected_Offset;

	private static bool AssertEqual_Float_What_IsValid;

	private static FFieldAddress AssertEqual_Float_What_PropertyAddress;

	private static int AssertEqual_Float_What_Offset;

	private static bool AssertEqual_Float_Tolerance_IsValid;

	private static FFieldAddress AssertEqual_Float_Tolerance_PropertyAddress;

	private static int AssertEqual_Float_Tolerance_Offset;

	private static bool AssertEqual_Float_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_Float_ContextObject_PropertyAddress;

	private static int AssertEqual_Float_ContextObject_Offset;

	private static bool AssertEqual_Float_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_Float_ReturnValue_PropertyAddress;

	private static int AssertEqual_Float_ReturnValue_Offset;

	private static bool AssertEqual_Double_IsValid;

	private static IntPtr AssertEqual_Double_FunctionAddress;

	private static int AssertEqual_Double_ParamsSize;

	private static bool AssertEqual_Double_Actual_IsValid;

	private static FFieldAddress AssertEqual_Double_Actual_PropertyAddress;

	private static int AssertEqual_Double_Actual_Offset;

	private static bool AssertEqual_Double_Expected_IsValid;

	private static FFieldAddress AssertEqual_Double_Expected_PropertyAddress;

	private static int AssertEqual_Double_Expected_Offset;

	private static bool AssertEqual_Double_What_IsValid;

	private static FFieldAddress AssertEqual_Double_What_PropertyAddress;

	private static int AssertEqual_Double_What_Offset;

	private static bool AssertEqual_Double_Tolerance_IsValid;

	private static FFieldAddress AssertEqual_Double_Tolerance_PropertyAddress;

	private static int AssertEqual_Double_Tolerance_Offset;

	private static bool AssertEqual_Double_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_Double_ContextObject_PropertyAddress;

	private static int AssertEqual_Double_ContextObject_Offset;

	private static bool AssertEqual_Double_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_Double_ReturnValue_PropertyAddress;

	private static int AssertEqual_Double_ReturnValue_Offset;

	private static bool AssertEqual_Bool_IsValid;

	private static IntPtr AssertEqual_Bool_FunctionAddress;

	private static int AssertEqual_Bool_ParamsSize;

	private static bool AssertEqual_Bool_Actual_IsValid;

	private static FFieldAddress AssertEqual_Bool_Actual_PropertyAddress;

	private static int AssertEqual_Bool_Actual_Offset;

	private static bool AssertEqual_Bool_Expected_IsValid;

	private static FFieldAddress AssertEqual_Bool_Expected_PropertyAddress;

	private static int AssertEqual_Bool_Expected_Offset;

	private static bool AssertEqual_Bool_What_IsValid;

	private static FFieldAddress AssertEqual_Bool_What_PropertyAddress;

	private static int AssertEqual_Bool_What_Offset;

	private static bool AssertEqual_Bool_ContextObject_IsValid;

	private static FFieldAddress AssertEqual_Bool_ContextObject_PropertyAddress;

	private static int AssertEqual_Bool_ContextObject_Offset;

	private static bool AssertEqual_Bool_ReturnValue_IsValid;

	private static FFieldAddress AssertEqual_Bool_ReturnValue_PropertyAddress;

	private static int AssertEqual_Bool_ReturnValue_Offset;

	private static bool AddWarning_IsValid;

	private static IntPtr AddWarning_FunctionAddress;

	private static int AddWarning_ParamsSize;

	private static bool AddWarning_Message_IsValid;

	private static FFieldAddress AddWarning_Message_PropertyAddress;

	private static int AddWarning_Message_Offset;

	private static bool AddRerun_IsValid;

	private static IntPtr AddRerun_FunctionAddress;

	private static int AddRerun_ParamsSize;

	private static bool AddRerun_Reason_IsValid;

	private static FFieldAddress AddRerun_Reason_PropertyAddress;

	private static int AddRerun_Reason_Offset;

	private static bool AddError_IsValid;

	private static IntPtr AddError_FunctionAddress;

	private static int AddError_ParamsSize;

	private static bool AddError_Message_IsValid;

	private static FFieldAddress AddError_Message_PropertyAddress;

	private static int AddError_Message_Offset;

	[UProperty(Flags = (PropFlags)6755399441056276uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:TestLabel")]
	public string TestLabel
	{
		get
		{
			CheckDestroyed();
			if (!TestLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:TestLabel");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TestLabel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TestLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:TestLabel");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TestLabel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925205uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:bIsEnabled")]
	protected bool IsEnabledValue
	{
		get
		{
			CheckDestroyed();
			if (!IsEnabledValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:bIsEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsEnabledValue_Offset), 0, IsEnabledValue_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsEnabledValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:bIsEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsEnabledValue_Offset), 0, IsEnabledValue_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:LogErrorHandling")]
	protected EFunctionalTestLogHandling LogErrorHandling
	{
		get
		{
			CheckDestroyed();
			if (!LogErrorHandling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:LogErrorHandling");
				return EFunctionalTestLogHandling.ProjectDefault;
			}
			return EnumMarshaler<EFunctionalTestLogHandling>.FromNative(IntPtr.Add(base.Address, LogErrorHandling_Offset), 0, LogErrorHandling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LogErrorHandling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:LogErrorHandling");
			}
			else
			{
				EnumMarshaler<EFunctionalTestLogHandling>.ToNative(IntPtr.Add(base.Address, LogErrorHandling_Offset), 0, LogErrorHandling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:LogWarningHandling")]
	protected EFunctionalTestLogHandling LogWarningHandling
	{
		get
		{
			CheckDestroyed();
			if (!LogWarningHandling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:LogWarningHandling");
				return EFunctionalTestLogHandling.ProjectDefault;
			}
			return EnumMarshaler<EFunctionalTestLogHandling>.FromNative(IntPtr.Add(base.Address, LogWarningHandling_Offset), 0, LogWarningHandling_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LogWarningHandling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:LogWarningHandling");
			}
			else
			{
				EnumMarshaler<EFunctionalTestLogHandling>.ToNative(IntPtr.Add(base.Address, LogWarningHandling_Offset), 0, LogWarningHandling_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267795161448981uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:Author")]
	protected string Author
	{
		get
		{
			CheckDestroyed();
			if (!Author_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:Author");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Author_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Author_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:Author");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Author_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267795161448981uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:Description")]
	protected string Description
	{
		get
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:Description");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Description_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:Description");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Description_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510149uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:ObservationPoint")]
	protected AActor ObservationPoint
	{
		get
		{
			CheckDestroyed();
			if (!ObservationPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:ObservationPoint");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, ObservationPoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ObservationPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:ObservationPoint");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, ObservationPoint_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9020462113751557uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:RandomNumbersStream")]
	protected FRandomStream RandomNumbersStream
	{
		get
		{
			CheckDestroyed();
			if (!RandomNumbersStream_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:RandomNumbersStream");
				return default(FRandomStream);
			}
			return BlittableTypeMarshaler<FRandomStream>.FromNative(IntPtr.Add(base.Address, RandomNumbersStream_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomNumbersStream_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:RandomNumbersStream");
			}
			else
			{
				BlittableTypeMarshaler<FRandomStream>.ToNative(IntPtr.Add(base.Address, RandomNumbersStream_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:Result")]
	public EFunctionalTestResult Result
	{
		get
		{
			CheckDestroyed();
			if (!Result_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:Result");
				return EFunctionalTestResult.Default;
			}
			return EnumMarshaler<EFunctionalTestResult>.FromNative(IntPtr.Add(base.Address, Result_Offset), 0, Result_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Result_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:Result");
			}
			else
			{
				EnumMarshaler<EFunctionalTestResult>.ToNative(IntPtr.Add(base.Address, Result_Offset), 0, Result_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:PreparationTimeLimit")]
	public float PreparationTimeLimit
	{
		get
		{
			CheckDestroyed();
			if (!PreparationTimeLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:PreparationTimeLimit");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PreparationTimeLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreparationTimeLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:PreparationTimeLimit");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PreparationTimeLimit_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:TimeLimit")]
	public float TimeLimit
	{
		get
		{
			CheckDestroyed();
			if (!TimeLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:TimeLimit");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TimeLimit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeLimit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:TimeLimit");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TimeLimit_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:TimesUpMessage")]
	public FText TimesUpMessage
	{
		get
		{
			CheckDestroyed();
			if (!TimesUpMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:TimesUpMessage");
				return null;
			}
			if (TimesUpMessage_TextCached == null)
			{
				TimesUpMessage_TextCached = new FText(IntPtr.Add(base.Address, TimesUpMessage_Offset), createReference: false);
			}
			return TimesUpMessage_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!TimesUpMessage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:TimesUpMessage");
				return;
			}
			if (TimesUpMessage_TextCached == null)
			{
				TimesUpMessage_TextCached = new FText(IntPtr.Add(base.Address, TimesUpMessage_Offset), createReference: false);
			}
			TimesUpMessage_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:OnTestPrepare")]
	public FFunctionalTestEventSignature OnTestPrepare
	{
		get
		{
			CheckDestroyed();
			if (!OnTestPrepare_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:OnTestPrepare");
				return new FFunctionalTestEventSignature();
			}
			if (OnTestPrepare_DelegateCached == null)
			{
				OnTestPrepare_DelegateCached = new FFunctionalTestEventSignature();
				OnTestPrepare_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTestPrepare_Offset));
			}
			return OnTestPrepare_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:OnTestStart")]
	public FFunctionalTestEventSignature OnTestStart
	{
		get
		{
			CheckDestroyed();
			if (!OnTestStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:OnTestStart");
				return new FFunctionalTestEventSignature();
			}
			if (OnTestStart_DelegateCached == null)
			{
				OnTestStart_DelegateCached = new FFunctionalTestEventSignature();
				OnTestStart_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTestStart_Offset));
			}
			return OnTestStart_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:OnTestFinished")]
	public FFunctionalTestEventSignature OnTestFinished
	{
		get
		{
			CheckDestroyed();
			if (!OnTestFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:OnTestFinished");
				return new FFunctionalTestEventSignature();
			}
			if (OnTestFinished_DelegateCached == null)
			{
				OnTestFinished_DelegateCached = new FFunctionalTestEventSignature();
				OnTestFinished_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTestFinished_Offset));
			}
			return OnTestFinished_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:TotalTime")]
	public float TotalTime
	{
		get
		{
			CheckDestroyed();
			if (!TotalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:TotalTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TotalTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TotalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FunctionalTesting.FunctionalTest:TotalTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TotalTime_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:SetTimeLimit")]
	public unsafe void SetTimeLimit(float NewTimeLimit, EFunctionalTestResult ResultWhenTimeRunsOut)
	{
		CheckDestroyed();
		if (!SetTimeLimit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:SetTimeLimit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTimeLimit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTimeLimit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTimeLimit_NewTimeLimit_Offset), 0, SetTimeLimit_NewTimeLimit_PropertyAddress.Address, NewTimeLimit);
		EnumMarshaler<EFunctionalTestResult>.ToNative(IntPtr.Add(intPtr, SetTimeLimit_ResultWhenTimeRunsOut_Offset), 0, SetTimeLimit_ResultWhenTimeRunsOut_PropertyAddress.Address, ResultWhenTimeRunsOut);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTimeLimit_FunctionAddress, intPtr, SetTimeLimit_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:RegisterAutoDestroyActor")]
	public unsafe void RegisterAutoDestroyActor(AActor ActorToAutoDestroy)
	{
		CheckDestroyed();
		if (!RegisterAutoDestroyActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:RegisterAutoDestroyActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterAutoDestroyActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterAutoDestroyActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RegisterAutoDestroyActor_ActorToAutoDestroy_Offset), 0, RegisterAutoDestroyActor_ActorToAutoDestroy_PropertyAddress.Address, ActorToAutoDestroy);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterAutoDestroyActor_FunctionAddress, intPtr, RegisterAutoDestroyActor_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:ReceiveStartTest")]
	protected unsafe void ReceiveStartTest()
	{
		CheckDestroyed();
		if (!ReceiveStartTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:ReceiveStartTest");
			return;
		}
		if (ReceiveStartTest_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveStartTest_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveStartTest");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveStartTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveStartTest_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveStartTest_InstanceFunctionAddress, argsSize: ReceiveStartTest_ParamsSize);
	}

	protected unsafe virtual void ReceiveStartTest_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveStartTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:ReceiveStartTest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveStartTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveStartTest_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveStartTest_FunctionAddress, argsSize: ReceiveStartTest_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:ReceivePrepareTest")]
	protected unsafe void ReceivePrepareTest()
	{
		CheckDestroyed();
		if (!ReceivePrepareTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:ReceivePrepareTest");
			return;
		}
		if (ReceivePrepareTest_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceivePrepareTest_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceivePrepareTest");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePrepareTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePrepareTest_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceivePrepareTest_InstanceFunctionAddress, argsSize: ReceivePrepareTest_ParamsSize);
	}

	protected unsafe virtual void ReceivePrepareTest_Implementation()
	{
		CheckDestroyed();
		if (!ReceivePrepareTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:ReceivePrepareTest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePrepareTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePrepareTest_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceivePrepareTest_FunctionAddress, argsSize: ReceivePrepareTest_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:OnWantsReRunCheck")]
	public unsafe bool OnWantsReRunCheck()
	{
		CheckDestroyed();
		if (!OnWantsReRunCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:OnWantsReRunCheck");
			return false;
		}
		if (OnWantsReRunCheck_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWantsReRunCheck_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWantsReRunCheck");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWantsReRunCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWantsReRunCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWantsReRunCheck_InstanceFunctionAddress, intPtr, OnWantsReRunCheck_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnWantsReRunCheck_ReturnValue_Offset), 0, OnWantsReRunCheck_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool OnWantsReRunCheck_Implementation()
	{
		CheckDestroyed();
		if (!OnWantsReRunCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:OnWantsReRunCheck");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWantsReRunCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWantsReRunCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWantsReRunCheck_FunctionAddress, intPtr, OnWantsReRunCheck_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnWantsReRunCheck_ReturnValue_Offset), 0, OnWantsReRunCheck_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:OnAdditionalTestFinishedMessageRequest")]
	public unsafe string OnAdditionalTestFinishedMessageRequest(EFunctionalTestResult TestResult)
	{
		CheckDestroyed();
		if (!OnAdditionalTestFinishedMessageRequest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:OnAdditionalTestFinishedMessageRequest");
			return FStringMarshaler.DefaultString;
		}
		if (OnAdditionalTestFinishedMessageRequest_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnAdditionalTestFinishedMessageRequest_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnAdditionalTestFinishedMessageRequest");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAdditionalTestFinishedMessageRequest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAdditionalTestFinishedMessageRequest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EFunctionalTestResult>.ToNative(IntPtr.Add(intPtr, OnAdditionalTestFinishedMessageRequest_TestResult_Offset), 0, OnAdditionalTestFinishedMessageRequest_TestResult_PropertyAddress.Address, TestResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAdditionalTestFinishedMessageRequest_InstanceFunctionAddress, intPtr, OnAdditionalTestFinishedMessageRequest_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, OnAdditionalTestFinishedMessageRequest_ReturnValue_Offset), 0, OnAdditionalTestFinishedMessageRequest_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnAdditionalTestFinishedMessageRequest_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string OnAdditionalTestFinishedMessageRequest_Implementation(EFunctionalTestResult TestResult)
	{
		CheckDestroyed();
		if (!OnAdditionalTestFinishedMessageRequest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:OnAdditionalTestFinishedMessageRequest");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAdditionalTestFinishedMessageRequest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAdditionalTestFinishedMessageRequest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EFunctionalTestResult>.ToNative(IntPtr.Add(intPtr, OnAdditionalTestFinishedMessageRequest_TestResult_Offset), 0, OnAdditionalTestFinishedMessageRequest_TestResult_PropertyAddress.Address, TestResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAdditionalTestFinishedMessageRequest_FunctionAddress, intPtr, OnAdditionalTestFinishedMessageRequest_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, OnAdditionalTestFinishedMessageRequest_ReturnValue_Offset), 0, OnAdditionalTestFinishedMessageRequest_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnAdditionalTestFinishedMessageRequest_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:LogMessage")]
	public unsafe void LogMessage(string Message)
	{
		CheckDestroyed();
		if (!LogMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:LogMessage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogMessage_Message_Offset), 0, LogMessage_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeFunctionOptimized(base.Address, LogMessage_FunctionAddress, intPtr, LogMessage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogMessage_Message_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:IsRunning")]
	public unsafe bool IsRunning()
	{
		CheckDestroyed();
		if (!IsRunning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:IsRunning");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRunning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRunning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRunning_FunctionAddress, intPtr, IsRunning_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRunning_ReturnValue_Offset), 0, IsRunning_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134745088u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:IsReady")]
	protected unsafe bool IsReady()
	{
		CheckDestroyed();
		if (!IsReady_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:IsReady");
			return false;
		}
		if (IsReady_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsReady_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsReady");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReady_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReady_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsReady_InstanceFunctionAddress, intPtr, IsReady_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReady_ReturnValue_Offset), 0, IsReady_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsReady_Implementation()
	{
		CheckDestroyed();
		if (!IsReady_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:IsReady");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReady_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReady_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsReady_FunctionAddress, intPtr, IsReady_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReady_ReturnValue_Offset), 0, IsReady_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:IsEnabled")]
	public unsafe bool IsEnabled()
	{
		CheckDestroyed();
		if (!IsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:IsEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEnabled_FunctionAddress, intPtr, IsEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEnabled_ReturnValue_Offset), 0, IsEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:GetCurrentRerunReason")]
	public unsafe FName GetCurrentRerunReason()
	{
		CheckDestroyed();
		if (!GetCurrentRerunReason_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:GetCurrentRerunReason");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentRerunReason_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentRerunReason_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentRerunReason_FunctionAddress, intPtr, GetCurrentRerunReason_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetCurrentRerunReason_ReturnValue_Offset), 0, GetCurrentRerunReason_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:FinishTest")]
	public unsafe void FinishTest(EFunctionalTestResult TestResult, string Message)
	{
		CheckDestroyed();
		if (!FinishTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:FinishTest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EFunctionalTestResult>.ToNative(IntPtr.Add(intPtr, FinishTest_TestResult_Offset), 0, FinishTest_TestResult_PropertyAddress.Address, TestResult);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FinishTest_Message_Offset), 0, FinishTest_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeFunctionOptimized(base.Address, FinishTest_FunctionAddress, intPtr, FinishTest_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FinishTest_Message_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:DebugGatherRelevantActors")]
	public unsafe List<AActor> DebugGatherRelevantActors()
	{
		CheckDestroyed();
		if (!DebugGatherRelevantActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:DebugGatherRelevantActors");
			return null;
		}
		if (DebugGatherRelevantActors_InstanceFunctionAddress == IntPtr.Zero)
		{
			DebugGatherRelevantActors_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DebugGatherRelevantActors");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DebugGatherRelevantActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DebugGatherRelevantActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, DebugGatherRelevantActors_InstanceFunctionAddress, intPtr, DebugGatherRelevantActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, DebugGatherRelevantActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, DebugGatherRelevantActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(DebugGatherRelevantActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<AActor> DebugGatherRelevantActors_Implementation()
	{
		CheckDestroyed();
		if (!DebugGatherRelevantActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:DebugGatherRelevantActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DebugGatherRelevantActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DebugGatherRelevantActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, DebugGatherRelevantActors_FunctionAddress, intPtr, DebugGatherRelevantActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, DebugGatherRelevantActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, DebugGatherRelevantActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(DebugGatherRelevantActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertValue_Int")]
	public unsafe bool AssertValue_Int(int Actual, EComparisonMethod ShouldBe, int Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertValue_Int_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertValue_Int");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertValue_Int_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertValue_Int_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AssertValue_Int_Actual_Offset), 0, AssertValue_Int_Actual_PropertyAddress.Address, Actual);
		EnumMarshaler<EComparisonMethod>.ToNative(IntPtr.Add(intPtr, AssertValue_Int_ShouldBe_Offset), 0, AssertValue_Int_ShouldBe_PropertyAddress.Address, ShouldBe);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AssertValue_Int_Expected_Offset), 0, AssertValue_Int_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertValue_Int_What_Offset), 0, AssertValue_Int_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertValue_Int_ContextObject_Offset), 0, AssertValue_Int_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertValue_Int_FunctionAddress, intPtr, AssertValue_Int_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertValue_Int_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertValue_Int_ReturnValue_Offset), 0, AssertValue_Int_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertValue_Float")]
	public unsafe bool AssertValue_Float(float Actual, EComparisonMethod ShouldBe, float Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertValue_Float_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertValue_Float");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertValue_Float_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertValue_Float_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AssertValue_Float_Actual_Offset), 0, AssertValue_Float_Actual_PropertyAddress.Address, Actual);
		EnumMarshaler<EComparisonMethod>.ToNative(IntPtr.Add(intPtr, AssertValue_Float_ShouldBe_Offset), 0, AssertValue_Float_ShouldBe_PropertyAddress.Address, ShouldBe);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AssertValue_Float_Expected_Offset), 0, AssertValue_Float_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertValue_Float_What_Offset), 0, AssertValue_Float_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertValue_Float_ContextObject_Offset), 0, AssertValue_Float_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertValue_Float_FunctionAddress, intPtr, AssertValue_Float_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertValue_Float_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertValue_Float_ReturnValue_Offset), 0, AssertValue_Float_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertValue_Double")]
	public unsafe bool AssertValue_Double(double Actual, EComparisonMethod ShouldBe, double Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertValue_Double_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertValue_Double");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertValue_Double_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertValue_Double_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, AssertValue_Double_Actual_Offset), 0, AssertValue_Double_Actual_PropertyAddress.Address, Actual);
		EnumMarshaler<EComparisonMethod>.ToNative(IntPtr.Add(intPtr, AssertValue_Double_ShouldBe_Offset), 0, AssertValue_Double_ShouldBe_PropertyAddress.Address, ShouldBe);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, AssertValue_Double_Expected_Offset), 0, AssertValue_Double_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertValue_Double_What_Offset), 0, AssertValue_Double_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertValue_Double_ContextObject_Offset), 0, AssertValue_Double_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertValue_Double_FunctionAddress, intPtr, AssertValue_Double_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertValue_Double_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertValue_Double_ReturnValue_Offset), 0, AssertValue_Double_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertValue_DateTime")]
	public unsafe bool AssertValue_DateTime(FDateTime Actual, EComparisonMethod ShouldBe, FDateTime Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertValue_DateTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertValue_DateTime");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertValue_DateTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertValue_DateTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDateTime.ToNative(IntPtr.Add(intPtr, AssertValue_DateTime_Actual_Offset), 0, AssertValue_DateTime_Actual_PropertyAddress.Address, Actual);
		EnumMarshaler<EComparisonMethod>.ToNative(IntPtr.Add(intPtr, AssertValue_DateTime_ShouldBe_Offset), 0, AssertValue_DateTime_ShouldBe_PropertyAddress.Address, ShouldBe);
		FDateTime.ToNative(IntPtr.Add(intPtr, AssertValue_DateTime_Expected_Offset), 0, AssertValue_DateTime_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertValue_DateTime_What_Offset), 0, AssertValue_DateTime_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertValue_DateTime_ContextObject_Offset), 0, AssertValue_DateTime_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertValue_DateTime_FunctionAddress, intPtr, AssertValue_DateTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertValue_DateTime_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertValue_DateTime_ReturnValue_Offset), 0, AssertValue_DateTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertTrue")]
	public unsafe bool AssertTrue(bool Condition, string Message, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertTrue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertTrue");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertTrue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertTrue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AssertTrue_Condition_Offset), 0, AssertTrue_Condition_PropertyAddress.Address, Condition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertTrue_Message_Offset), 0, AssertTrue_Message_PropertyAddress.Address, Message);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertTrue_ContextObject_Offset), 0, AssertTrue_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertTrue_FunctionAddress, intPtr, AssertTrue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertTrue_Message_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertTrue_ReturnValue_Offset), 0, AssertTrue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_Vector")]
	public unsafe bool AssertNotEqual_Vector(FVector Actual, FVector NotExpected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertNotEqual_Vector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_Vector");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertNotEqual_Vector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertNotEqual_Vector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Vector_Actual_Offset), 0, AssertNotEqual_Vector_Actual_PropertyAddress.Address, Actual);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Vector_NotExpected_Offset), 0, AssertNotEqual_Vector_NotExpected_PropertyAddress.Address, NotExpected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Vector_What_Offset), 0, AssertNotEqual_Vector_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Vector_ContextObject_Offset), 0, AssertNotEqual_Vector_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertNotEqual_Vector_FunctionAddress, intPtr, AssertNotEqual_Vector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertNotEqual_Vector_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertNotEqual_Vector_ReturnValue_Offset), 0, AssertNotEqual_Vector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_Transform")]
	public unsafe bool AssertNotEqual_Transform(FTransform Actual, FTransform NotExpected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertNotEqual_Transform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_Transform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertNotEqual_Transform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertNotEqual_Transform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AssertNotEqual_Transform_Actual_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Transform_Actual_Offset), 0, AssertNotEqual_Transform_Actual_PropertyAddress.Address, Actual);
		NativeReflection.InitializeValue_InContainer(AssertNotEqual_Transform_NotExpected_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Transform_NotExpected_Offset), 0, AssertNotEqual_Transform_NotExpected_PropertyAddress.Address, NotExpected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Transform_What_Offset), 0, AssertNotEqual_Transform_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Transform_ContextObject_Offset), 0, AssertNotEqual_Transform_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertNotEqual_Transform_FunctionAddress, intPtr, AssertNotEqual_Transform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertNotEqual_Transform_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertNotEqual_Transform_ReturnValue_Offset), 0, AssertNotEqual_Transform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_String")]
	public unsafe bool AssertNotEqual_String(string Actual, string NotExpected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertNotEqual_String_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_String");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertNotEqual_String_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertNotEqual_String_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertNotEqual_String_Actual_Offset), 0, AssertNotEqual_String_Actual_PropertyAddress.Address, Actual);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertNotEqual_String_NotExpected_Offset), 0, AssertNotEqual_String_NotExpected_PropertyAddress.Address, NotExpected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertNotEqual_String_What_Offset), 0, AssertNotEqual_String_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_String_ContextObject_Offset), 0, AssertNotEqual_String_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertNotEqual_String_FunctionAddress, intPtr, AssertNotEqual_String_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertNotEqual_String_Actual_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AssertNotEqual_String_NotExpected_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AssertNotEqual_String_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertNotEqual_String_ReturnValue_Offset), 0, AssertNotEqual_String_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_Rotator")]
	public unsafe bool AssertNotEqual_Rotator(FRotator Actual, FRotator NotExpected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertNotEqual_Rotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_Rotator");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertNotEqual_Rotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertNotEqual_Rotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Rotator_Actual_Offset), 0, AssertNotEqual_Rotator_Actual_PropertyAddress.Address, Actual);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Rotator_NotExpected_Offset), 0, AssertNotEqual_Rotator_NotExpected_PropertyAddress.Address, NotExpected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Rotator_What_Offset), 0, AssertNotEqual_Rotator_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertNotEqual_Rotator_ContextObject_Offset), 0, AssertNotEqual_Rotator_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertNotEqual_Rotator_FunctionAddress, intPtr, AssertNotEqual_Rotator_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertNotEqual_Rotator_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertNotEqual_Rotator_ReturnValue_Offset), 0, AssertNotEqual_Rotator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertIsValid")]
	public unsafe bool AssertIsValid(UObject Object, string Message, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertIsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertIsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertIsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertIsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertIsValid_Object_Offset), 0, AssertIsValid_Object_PropertyAddress.Address, Object);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertIsValid_Message_Offset), 0, AssertIsValid_Message_PropertyAddress.Address, Message);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertIsValid_ContextObject_Offset), 0, AssertIsValid_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertIsValid_FunctionAddress, intPtr, AssertIsValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertIsValid_Message_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertIsValid_ReturnValue_Offset), 0, AssertIsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertFalse")]
	public unsafe bool AssertFalse(bool Condition, string Message, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertFalse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertFalse");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertFalse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertFalse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AssertFalse_Condition_Offset), 0, AssertFalse_Condition_PropertyAddress.Address, Condition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertFalse_Message_Offset), 0, AssertFalse_Message_PropertyAddress.Address, Message);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertFalse_ContextObject_Offset), 0, AssertFalse_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertFalse_FunctionAddress, intPtr, AssertFalse_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertFalse_Message_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertFalse_ReturnValue_Offset), 0, AssertFalse_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Vector")]
	public unsafe bool AssertEqual_Vector(FVector Actual, FVector Expected, string What, float Tolerance, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_Vector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Vector");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_Vector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_Vector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AssertEqual_Vector_Actual_Offset), 0, AssertEqual_Vector_Actual_PropertyAddress.Address, Actual);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AssertEqual_Vector_Expected_Offset), 0, AssertEqual_Vector_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Vector_What_Offset), 0, AssertEqual_Vector_What_PropertyAddress.Address, What);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AssertEqual_Vector_Tolerance_Offset), 0, AssertEqual_Vector_Tolerance_PropertyAddress.Address, Tolerance);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Vector_ContextObject_Offset), 0, AssertEqual_Vector_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_Vector_FunctionAddress, intPtr, AssertEqual_Vector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_Vector_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_Vector_ReturnValue_Offset), 0, AssertEqual_Vector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Transform")]
	public unsafe bool AssertEqual_Transform(FTransform Actual, FTransform Expected, string What, float Tolerance, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_Transform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Transform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_Transform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_Transform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AssertEqual_Transform_Actual_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AssertEqual_Transform_Actual_Offset), 0, AssertEqual_Transform_Actual_PropertyAddress.Address, Actual);
		NativeReflection.InitializeValue_InContainer(AssertEqual_Transform_Expected_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AssertEqual_Transform_Expected_Offset), 0, AssertEqual_Transform_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Transform_What_Offset), 0, AssertEqual_Transform_What_PropertyAddress.Address, What);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AssertEqual_Transform_Tolerance_Offset), 0, AssertEqual_Transform_Tolerance_PropertyAddress.Address, Tolerance);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Transform_ContextObject_Offset), 0, AssertEqual_Transform_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_Transform_FunctionAddress, intPtr, AssertEqual_Transform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_Transform_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_Transform_ReturnValue_Offset), 0, AssertEqual_Transform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_TraceQueryResults")]
	public unsafe bool AssertEqual_TraceQueryResults(UTraceQueryTestResults Actual, UTraceQueryTestResults Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_TraceQueryResults_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_TraceQueryResults");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_TraceQueryResults_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_TraceQueryResults_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTraceQueryTestResults>.ToNative(IntPtr.Add(intPtr, AssertEqual_TraceQueryResults_Actual_Offset), 0, AssertEqual_TraceQueryResults_Actual_PropertyAddress.Address, Actual);
		UObjectMarshaler<UTraceQueryTestResults>.ToNative(IntPtr.Add(intPtr, AssertEqual_TraceQueryResults_Expected_Offset), 0, AssertEqual_TraceQueryResults_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_TraceQueryResults_What_Offset), 0, AssertEqual_TraceQueryResults_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_TraceQueryResults_ContextObject_Offset), 0, AssertEqual_TraceQueryResults_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_TraceQueryResults_FunctionAddress, intPtr, AssertEqual_TraceQueryResults_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_TraceQueryResults_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_TraceQueryResults_ReturnValue_Offset), 0, AssertEqual_TraceQueryResults_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_String")]
	public unsafe bool AssertEqual_String(string Actual, string Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_String_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_String");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_String_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_String_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_String_Actual_Offset), 0, AssertEqual_String_Actual_PropertyAddress.Address, Actual);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_String_Expected_Offset), 0, AssertEqual_String_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_String_What_Offset), 0, AssertEqual_String_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_String_ContextObject_Offset), 0, AssertEqual_String_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_String_FunctionAddress, intPtr, AssertEqual_String_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_String_Actual_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AssertEqual_String_Expected_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AssertEqual_String_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_String_ReturnValue_Offset), 0, AssertEqual_String_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Rotator")]
	public unsafe bool AssertEqual_Rotator(FRotator Actual, FRotator Expected, string What, float Tolerance, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_Rotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Rotator");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_Rotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_Rotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AssertEqual_Rotator_Actual_Offset), 0, AssertEqual_Rotator_Actual_PropertyAddress.Address, Actual);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AssertEqual_Rotator_Expected_Offset), 0, AssertEqual_Rotator_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Rotator_What_Offset), 0, AssertEqual_Rotator_What_PropertyAddress.Address, What);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AssertEqual_Rotator_Tolerance_Offset), 0, AssertEqual_Rotator_Tolerance_PropertyAddress.Address, Tolerance);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Rotator_ContextObject_Offset), 0, AssertEqual_Rotator_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_Rotator_FunctionAddress, intPtr, AssertEqual_Rotator_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_Rotator_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_Rotator_ReturnValue_Offset), 0, AssertEqual_Rotator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Object")]
	public unsafe bool AssertEqual_Object(UObject Actual, UObject Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_Object_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Object");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_Object_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_Object_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Object_Actual_Offset), 0, AssertEqual_Object_Actual_PropertyAddress.Address, Actual);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Object_Expected_Offset), 0, AssertEqual_Object_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Object_What_Offset), 0, AssertEqual_Object_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Object_ContextObject_Offset), 0, AssertEqual_Object_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_Object_FunctionAddress, intPtr, AssertEqual_Object_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_Object_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_Object_ReturnValue_Offset), 0, AssertEqual_Object_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Name")]
	public unsafe bool AssertEqual_Name(FName Actual, FName Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_Name_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Name");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_Name_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_Name_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AssertEqual_Name_Actual_Offset), 0, AssertEqual_Name_Actual_PropertyAddress.Address, Actual);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AssertEqual_Name_Expected_Offset), 0, AssertEqual_Name_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Name_What_Offset), 0, AssertEqual_Name_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Name_ContextObject_Offset), 0, AssertEqual_Name_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_Name_FunctionAddress, intPtr, AssertEqual_Name_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_Name_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_Name_ReturnValue_Offset), 0, AssertEqual_Name_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Int")]
	public unsafe bool AssertEqual_Int(int Actual, int Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_Int_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Int");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_Int_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_Int_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AssertEqual_Int_Actual_Offset), 0, AssertEqual_Int_Actual_PropertyAddress.Address, Actual);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AssertEqual_Int_Expected_Offset), 0, AssertEqual_Int_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Int_What_Offset), 0, AssertEqual_Int_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Int_ContextObject_Offset), 0, AssertEqual_Int_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_Int_FunctionAddress, intPtr, AssertEqual_Int_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_Int_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_Int_ReturnValue_Offset), 0, AssertEqual_Int_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Float")]
	public unsafe bool AssertEqual_Float(float Actual, float Expected, string What, float Tolerance, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_Float_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Float");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_Float_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_Float_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AssertEqual_Float_Actual_Offset), 0, AssertEqual_Float_Actual_PropertyAddress.Address, Actual);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AssertEqual_Float_Expected_Offset), 0, AssertEqual_Float_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Float_What_Offset), 0, AssertEqual_Float_What_PropertyAddress.Address, What);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AssertEqual_Float_Tolerance_Offset), 0, AssertEqual_Float_Tolerance_PropertyAddress.Address, Tolerance);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Float_ContextObject_Offset), 0, AssertEqual_Float_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_Float_FunctionAddress, intPtr, AssertEqual_Float_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_Float_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_Float_ReturnValue_Offset), 0, AssertEqual_Float_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Double")]
	public unsafe bool AssertEqual_Double(double Actual, double Expected, string What, double Tolerance, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_Double_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Double");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_Double_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_Double_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, AssertEqual_Double_Actual_Offset), 0, AssertEqual_Double_Actual_PropertyAddress.Address, Actual);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, AssertEqual_Double_Expected_Offset), 0, AssertEqual_Double_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Double_What_Offset), 0, AssertEqual_Double_What_PropertyAddress.Address, What);
		BlittableTypeMarshaler<double>.ToNative(IntPtr.Add(intPtr, AssertEqual_Double_Tolerance_Offset), 0, AssertEqual_Double_Tolerance_PropertyAddress.Address, Tolerance);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Double_ContextObject_Offset), 0, AssertEqual_Double_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_Double_FunctionAddress, intPtr, AssertEqual_Double_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_Double_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_Double_ReturnValue_Offset), 0, AssertEqual_Double_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Bool")]
	public unsafe bool AssertEqual_Bool(bool Actual, bool Expected, string What, UObject ContextObject)
	{
		CheckDestroyed();
		if (!AssertEqual_Bool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Bool");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssertEqual_Bool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssertEqual_Bool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Bool_Actual_Offset), 0, AssertEqual_Bool_Actual_PropertyAddress.Address, Actual);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Bool_Expected_Offset), 0, AssertEqual_Bool_Expected_PropertyAddress.Address, Expected);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssertEqual_Bool_What_Offset), 0, AssertEqual_Bool_What_PropertyAddress.Address, What);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssertEqual_Bool_ContextObject_Offset), 0, AssertEqual_Bool_ContextObject_PropertyAddress.Address, ContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssertEqual_Bool_FunctionAddress, intPtr, AssertEqual_Bool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssertEqual_Bool_What_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AssertEqual_Bool_ReturnValue_Offset), 0, AssertEqual_Bool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AddWarning")]
	public unsafe void AddWarning(string Message)
	{
		CheckDestroyed();
		if (!AddWarning_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AddWarning");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWarning_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWarning_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddWarning_Message_Offset), 0, AddWarning_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddWarning_FunctionAddress, intPtr, AddWarning_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddWarning_Message_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AddRerun")]
	public unsafe void AddRerun(FName Reason)
	{
		CheckDestroyed();
		if (!AddRerun_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AddRerun");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRerun_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRerun_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddRerun_Reason_Offset), 0, AddRerun_Reason_PropertyAddress.Address, Reason);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRerun_FunctionAddress, intPtr, AddRerun_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/FunctionalTesting.FunctionalTest:AddError")]
	public unsafe void AddError(string Message)
	{
		CheckDestroyed();
		if (!AddError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.FunctionalTest:AddError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddError_Message_Offset), 0, AddError_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddError_FunctionAddress, intPtr, AddError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddError_Message_PropertyAddress.Address, intPtr);
	}

	static AFunctionalTest()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AFunctionalTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AFunctionalTest));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FunctionalTesting.FunctionalTest");
		TestLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TestLabel");
		TestLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TestLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEnabledValue_PropertyAddress, intPtr, "bIsEnabled");
		IsEnabledValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsEnabled");
		IsEnabledValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LogErrorHandling_PropertyAddress, intPtr, "LogErrorHandling");
		LogErrorHandling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LogErrorHandling");
		LogErrorHandling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LogErrorHandling", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LogWarningHandling_PropertyAddress, intPtr, "LogWarningHandling");
		LogWarningHandling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LogWarningHandling");
		LogWarningHandling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LogWarningHandling", Classes.FEnumProperty);
		Author_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Author");
		Author_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Author", Classes.FStrProperty);
		Description_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Description");
		Description_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Description", Classes.FStrProperty);
		ObservationPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObservationPoint");
		ObservationPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObservationPoint", Classes.FObjectProperty);
		RandomNumbersStream_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RandomNumbersStream");
		RandomNumbersStream_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RandomNumbersStream", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Result_PropertyAddress, intPtr, "Result");
		Result_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Result");
		Result_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Result", Classes.FEnumProperty);
		PreparationTimeLimit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreparationTimeLimit");
		PreparationTimeLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreparationTimeLimit", Classes.FFloatProperty);
		TimeLimit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeLimit");
		TimeLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeLimit", Classes.FFloatProperty);
		TimesUpMessage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimesUpMessage");
		TimesUpMessage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimesUpMessage", Classes.FTextProperty);
		OnTestPrepare_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTestPrepare");
		OnTestPrepare_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTestPrepare", Classes.FMulticastDelegateProperty);
		OnTestStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTestStart");
		OnTestStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTestStart", Classes.FMulticastDelegateProperty);
		OnTestFinished_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTestFinished");
		OnTestFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTestFinished", Classes.FMulticastDelegateProperty);
		TotalTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalTime");
		TotalTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalTime", Classes.FFloatProperty);
		SetTimeLimit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTimeLimit");
		SetTimeLimit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTimeLimit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTimeLimit_NewTimeLimit_PropertyAddress, SetTimeLimit_FunctionAddress, "NewTimeLimit");
		SetTimeLimit_NewTimeLimit_Offset = NativeReflectionCached.GetPropertyOffset(SetTimeLimit_FunctionAddress, "NewTimeLimit");
		SetTimeLimit_NewTimeLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTimeLimit_FunctionAddress, "NewTimeLimit", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTimeLimit_ResultWhenTimeRunsOut_PropertyAddress, SetTimeLimit_FunctionAddress, "ResultWhenTimeRunsOut");
		SetTimeLimit_ResultWhenTimeRunsOut_Offset = NativeReflectionCached.GetPropertyOffset(SetTimeLimit_FunctionAddress, "ResultWhenTimeRunsOut");
		SetTimeLimit_ResultWhenTimeRunsOut_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTimeLimit_FunctionAddress, "ResultWhenTimeRunsOut", Classes.FEnumProperty);
		SetTimeLimit_IsValid = SetTimeLimit_FunctionAddress != IntPtr.Zero && SetTimeLimit_NewTimeLimit_IsValid && SetTimeLimit_ResultWhenTimeRunsOut_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:SetTimeLimit", SetTimeLimit_IsValid);
		RegisterAutoDestroyActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterAutoDestroyActor");
		RegisterAutoDestroyActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterAutoDestroyActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterAutoDestroyActor_ActorToAutoDestroy_PropertyAddress, RegisterAutoDestroyActor_FunctionAddress, "ActorToAutoDestroy");
		RegisterAutoDestroyActor_ActorToAutoDestroy_Offset = NativeReflectionCached.GetPropertyOffset(RegisterAutoDestroyActor_FunctionAddress, "ActorToAutoDestroy");
		RegisterAutoDestroyActor_ActorToAutoDestroy_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterAutoDestroyActor_FunctionAddress, "ActorToAutoDestroy", Classes.FObjectProperty);
		RegisterAutoDestroyActor_IsValid = RegisterAutoDestroyActor_FunctionAddress != IntPtr.Zero && RegisterAutoDestroyActor_ActorToAutoDestroy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:RegisterAutoDestroyActor", RegisterAutoDestroyActor_IsValid);
		ReceiveStartTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveStartTest");
		ReceiveStartTest_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveStartTest_FunctionAddress);
		ReceiveStartTest_IsValid = ReceiveStartTest_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:ReceiveStartTest", ReceiveStartTest_IsValid);
		ReceivePrepareTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceivePrepareTest");
		ReceivePrepareTest_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceivePrepareTest_FunctionAddress);
		ReceivePrepareTest_IsValid = ReceivePrepareTest_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:ReceivePrepareTest", ReceivePrepareTest_IsValid);
		OnWantsReRunCheck_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnWantsReRunCheck");
		OnWantsReRunCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWantsReRunCheck_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWantsReRunCheck_ReturnValue_PropertyAddress, OnWantsReRunCheck_FunctionAddress, "ReturnValue");
		OnWantsReRunCheck_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnWantsReRunCheck_FunctionAddress, "ReturnValue");
		OnWantsReRunCheck_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWantsReRunCheck_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OnWantsReRunCheck_IsValid = OnWantsReRunCheck_FunctionAddress != IntPtr.Zero && OnWantsReRunCheck_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:OnWantsReRunCheck", OnWantsReRunCheck_IsValid);
		OnAdditionalTestFinishedMessageRequest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAdditionalTestFinishedMessageRequest");
		OnAdditionalTestFinishedMessageRequest_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAdditionalTestFinishedMessageRequest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAdditionalTestFinishedMessageRequest_TestResult_PropertyAddress, OnAdditionalTestFinishedMessageRequest_FunctionAddress, "TestResult");
		OnAdditionalTestFinishedMessageRequest_TestResult_Offset = NativeReflectionCached.GetPropertyOffset(OnAdditionalTestFinishedMessageRequest_FunctionAddress, "TestResult");
		OnAdditionalTestFinishedMessageRequest_TestResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAdditionalTestFinishedMessageRequest_FunctionAddress, "TestResult", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAdditionalTestFinishedMessageRequest_ReturnValue_PropertyAddress, OnAdditionalTestFinishedMessageRequest_FunctionAddress, "ReturnValue");
		OnAdditionalTestFinishedMessageRequest_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnAdditionalTestFinishedMessageRequest_FunctionAddress, "ReturnValue");
		OnAdditionalTestFinishedMessageRequest_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAdditionalTestFinishedMessageRequest_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		OnAdditionalTestFinishedMessageRequest_IsValid = OnAdditionalTestFinishedMessageRequest_FunctionAddress != IntPtr.Zero && OnAdditionalTestFinishedMessageRequest_TestResult_IsValid && OnAdditionalTestFinishedMessageRequest_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:OnAdditionalTestFinishedMessageRequest", OnAdditionalTestFinishedMessageRequest_IsValid);
		LogMessage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LogMessage");
		LogMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(LogMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogMessage_Message_PropertyAddress, LogMessage_FunctionAddress, "Message");
		LogMessage_Message_Offset = NativeReflectionCached.GetPropertyOffset(LogMessage_FunctionAddress, "Message");
		LogMessage_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(LogMessage_FunctionAddress, "Message", Classes.FStrProperty);
		LogMessage_IsValid = LogMessage_FunctionAddress != IntPtr.Zero && LogMessage_Message_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:LogMessage", LogMessage_IsValid);
		IsRunning_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsRunning");
		IsRunning_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRunning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRunning_ReturnValue_PropertyAddress, IsRunning_FunctionAddress, "ReturnValue");
		IsRunning_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRunning_FunctionAddress, "ReturnValue");
		IsRunning_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRunning_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRunning_IsValid = IsRunning_FunctionAddress != IntPtr.Zero && IsRunning_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:IsRunning", IsRunning_IsValid);
		IsReady_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsReady");
		IsReady_ParamsSize = NativeReflection.GetFunctionParamsSize(IsReady_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsReady_ReturnValue_PropertyAddress, IsReady_FunctionAddress, "ReturnValue");
		IsReady_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsReady_FunctionAddress, "ReturnValue");
		IsReady_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReady_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsReady_IsValid = IsReady_FunctionAddress != IntPtr.Zero && IsReady_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:IsReady", IsReady_IsValid);
		IsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsEnabled");
		IsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEnabled_ReturnValue_PropertyAddress, IsEnabled_FunctionAddress, "ReturnValue");
		IsEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEnabled_FunctionAddress, "ReturnValue");
		IsEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEnabled_IsValid = IsEnabled_FunctionAddress != IntPtr.Zero && IsEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:IsEnabled", IsEnabled_IsValid);
		GetCurrentRerunReason_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentRerunReason");
		GetCurrentRerunReason_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentRerunReason_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentRerunReason_ReturnValue_PropertyAddress, GetCurrentRerunReason_FunctionAddress, "ReturnValue");
		GetCurrentRerunReason_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentRerunReason_FunctionAddress, "ReturnValue");
		GetCurrentRerunReason_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentRerunReason_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetCurrentRerunReason_IsValid = GetCurrentRerunReason_FunctionAddress != IntPtr.Zero && GetCurrentRerunReason_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:GetCurrentRerunReason", GetCurrentRerunReason_IsValid);
		FinishTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FinishTest");
		FinishTest_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishTest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FinishTest_TestResult_PropertyAddress, FinishTest_FunctionAddress, "TestResult");
		FinishTest_TestResult_Offset = NativeReflectionCached.GetPropertyOffset(FinishTest_FunctionAddress, "TestResult");
		FinishTest_TestResult_IsValid = NativeReflectionCached.ValidatePropertyClass(FinishTest_FunctionAddress, "TestResult", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FinishTest_Message_PropertyAddress, FinishTest_FunctionAddress, "Message");
		FinishTest_Message_Offset = NativeReflectionCached.GetPropertyOffset(FinishTest_FunctionAddress, "Message");
		FinishTest_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(FinishTest_FunctionAddress, "Message", Classes.FStrProperty);
		FinishTest_IsValid = FinishTest_FunctionAddress != IntPtr.Zero && FinishTest_TestResult_IsValid && FinishTest_Message_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:FinishTest", FinishTest_IsValid);
		DebugGatherRelevantActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DebugGatherRelevantActors");
		DebugGatherRelevantActors_ParamsSize = NativeReflection.GetFunctionParamsSize(DebugGatherRelevantActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DebugGatherRelevantActors_ReturnValue_PropertyAddress, DebugGatherRelevantActors_FunctionAddress, "ReturnValue");
		DebugGatherRelevantActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DebugGatherRelevantActors_FunctionAddress, "ReturnValue");
		DebugGatherRelevantActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DebugGatherRelevantActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		DebugGatherRelevantActors_IsValid = DebugGatherRelevantActors_FunctionAddress != IntPtr.Zero && DebugGatherRelevantActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:DebugGatherRelevantActors", DebugGatherRelevantActors_IsValid);
		AssertValue_Int_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertValue_Int");
		AssertValue_Int_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertValue_Int_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Int_Actual_PropertyAddress, AssertValue_Int_FunctionAddress, "Actual");
		AssertValue_Int_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Int_FunctionAddress, "Actual");
		AssertValue_Int_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Int_FunctionAddress, "Actual", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Int_ShouldBe_PropertyAddress, AssertValue_Int_FunctionAddress, "ShouldBe");
		AssertValue_Int_ShouldBe_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Int_FunctionAddress, "ShouldBe");
		AssertValue_Int_ShouldBe_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Int_FunctionAddress, "ShouldBe", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Int_Expected_PropertyAddress, AssertValue_Int_FunctionAddress, "Expected");
		AssertValue_Int_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Int_FunctionAddress, "Expected");
		AssertValue_Int_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Int_FunctionAddress, "Expected", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Int_What_PropertyAddress, AssertValue_Int_FunctionAddress, "What");
		AssertValue_Int_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Int_FunctionAddress, "What");
		AssertValue_Int_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Int_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Int_ContextObject_PropertyAddress, AssertValue_Int_FunctionAddress, "ContextObject");
		AssertValue_Int_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Int_FunctionAddress, "ContextObject");
		AssertValue_Int_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Int_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Int_ReturnValue_PropertyAddress, AssertValue_Int_FunctionAddress, "ReturnValue");
		AssertValue_Int_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Int_FunctionAddress, "ReturnValue");
		AssertValue_Int_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Int_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertValue_Int_IsValid = AssertValue_Int_FunctionAddress != IntPtr.Zero && AssertValue_Int_Actual_IsValid && AssertValue_Int_ShouldBe_IsValid && AssertValue_Int_Expected_IsValid && AssertValue_Int_What_IsValid && AssertValue_Int_ContextObject_IsValid && AssertValue_Int_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertValue_Int", AssertValue_Int_IsValid);
		AssertValue_Float_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertValue_Float");
		AssertValue_Float_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertValue_Float_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Float_Actual_PropertyAddress, AssertValue_Float_FunctionAddress, "Actual");
		AssertValue_Float_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Float_FunctionAddress, "Actual");
		AssertValue_Float_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Float_FunctionAddress, "Actual", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Float_ShouldBe_PropertyAddress, AssertValue_Float_FunctionAddress, "ShouldBe");
		AssertValue_Float_ShouldBe_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Float_FunctionAddress, "ShouldBe");
		AssertValue_Float_ShouldBe_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Float_FunctionAddress, "ShouldBe", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Float_Expected_PropertyAddress, AssertValue_Float_FunctionAddress, "Expected");
		AssertValue_Float_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Float_FunctionAddress, "Expected");
		AssertValue_Float_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Float_FunctionAddress, "Expected", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Float_What_PropertyAddress, AssertValue_Float_FunctionAddress, "What");
		AssertValue_Float_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Float_FunctionAddress, "What");
		AssertValue_Float_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Float_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Float_ContextObject_PropertyAddress, AssertValue_Float_FunctionAddress, "ContextObject");
		AssertValue_Float_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Float_FunctionAddress, "ContextObject");
		AssertValue_Float_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Float_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Float_ReturnValue_PropertyAddress, AssertValue_Float_FunctionAddress, "ReturnValue");
		AssertValue_Float_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Float_FunctionAddress, "ReturnValue");
		AssertValue_Float_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Float_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertValue_Float_IsValid = AssertValue_Float_FunctionAddress != IntPtr.Zero && AssertValue_Float_Actual_IsValid && AssertValue_Float_ShouldBe_IsValid && AssertValue_Float_Expected_IsValid && AssertValue_Float_What_IsValid && AssertValue_Float_ContextObject_IsValid && AssertValue_Float_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertValue_Float", AssertValue_Float_IsValid);
		AssertValue_Double_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertValue_Double");
		AssertValue_Double_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertValue_Double_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Double_Actual_PropertyAddress, AssertValue_Double_FunctionAddress, "Actual");
		AssertValue_Double_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Double_FunctionAddress, "Actual");
		AssertValue_Double_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Double_FunctionAddress, "Actual", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Double_ShouldBe_PropertyAddress, AssertValue_Double_FunctionAddress, "ShouldBe");
		AssertValue_Double_ShouldBe_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Double_FunctionAddress, "ShouldBe");
		AssertValue_Double_ShouldBe_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Double_FunctionAddress, "ShouldBe", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Double_Expected_PropertyAddress, AssertValue_Double_FunctionAddress, "Expected");
		AssertValue_Double_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Double_FunctionAddress, "Expected");
		AssertValue_Double_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Double_FunctionAddress, "Expected", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Double_What_PropertyAddress, AssertValue_Double_FunctionAddress, "What");
		AssertValue_Double_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Double_FunctionAddress, "What");
		AssertValue_Double_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Double_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Double_ContextObject_PropertyAddress, AssertValue_Double_FunctionAddress, "ContextObject");
		AssertValue_Double_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Double_FunctionAddress, "ContextObject");
		AssertValue_Double_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Double_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_Double_ReturnValue_PropertyAddress, AssertValue_Double_FunctionAddress, "ReturnValue");
		AssertValue_Double_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_Double_FunctionAddress, "ReturnValue");
		AssertValue_Double_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_Double_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertValue_Double_IsValid = AssertValue_Double_FunctionAddress != IntPtr.Zero && AssertValue_Double_Actual_IsValid && AssertValue_Double_ShouldBe_IsValid && AssertValue_Double_Expected_IsValid && AssertValue_Double_What_IsValid && AssertValue_Double_ContextObject_IsValid && AssertValue_Double_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertValue_Double", AssertValue_Double_IsValid);
		AssertValue_DateTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertValue_DateTime");
		AssertValue_DateTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertValue_DateTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_DateTime_Actual_PropertyAddress, AssertValue_DateTime_FunctionAddress, "Actual");
		AssertValue_DateTime_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_DateTime_FunctionAddress, "Actual");
		AssertValue_DateTime_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_DateTime_FunctionAddress, "Actual", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_DateTime_ShouldBe_PropertyAddress, AssertValue_DateTime_FunctionAddress, "ShouldBe");
		AssertValue_DateTime_ShouldBe_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_DateTime_FunctionAddress, "ShouldBe");
		AssertValue_DateTime_ShouldBe_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_DateTime_FunctionAddress, "ShouldBe", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_DateTime_Expected_PropertyAddress, AssertValue_DateTime_FunctionAddress, "Expected");
		AssertValue_DateTime_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_DateTime_FunctionAddress, "Expected");
		AssertValue_DateTime_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_DateTime_FunctionAddress, "Expected", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_DateTime_What_PropertyAddress, AssertValue_DateTime_FunctionAddress, "What");
		AssertValue_DateTime_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_DateTime_FunctionAddress, "What");
		AssertValue_DateTime_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_DateTime_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_DateTime_ContextObject_PropertyAddress, AssertValue_DateTime_FunctionAddress, "ContextObject");
		AssertValue_DateTime_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_DateTime_FunctionAddress, "ContextObject");
		AssertValue_DateTime_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_DateTime_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertValue_DateTime_ReturnValue_PropertyAddress, AssertValue_DateTime_FunctionAddress, "ReturnValue");
		AssertValue_DateTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertValue_DateTime_FunctionAddress, "ReturnValue");
		AssertValue_DateTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertValue_DateTime_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertValue_DateTime_IsValid = AssertValue_DateTime_FunctionAddress != IntPtr.Zero && AssertValue_DateTime_Actual_IsValid && AssertValue_DateTime_ShouldBe_IsValid && AssertValue_DateTime_Expected_IsValid && AssertValue_DateTime_What_IsValid && AssertValue_DateTime_ContextObject_IsValid && AssertValue_DateTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertValue_DateTime", AssertValue_DateTime_IsValid);
		AssertTrue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertTrue");
		AssertTrue_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertTrue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertTrue_Condition_PropertyAddress, AssertTrue_FunctionAddress, "Condition");
		AssertTrue_Condition_Offset = NativeReflectionCached.GetPropertyOffset(AssertTrue_FunctionAddress, "Condition");
		AssertTrue_Condition_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertTrue_FunctionAddress, "Condition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertTrue_Message_PropertyAddress, AssertTrue_FunctionAddress, "Message");
		AssertTrue_Message_Offset = NativeReflectionCached.GetPropertyOffset(AssertTrue_FunctionAddress, "Message");
		AssertTrue_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertTrue_FunctionAddress, "Message", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertTrue_ContextObject_PropertyAddress, AssertTrue_FunctionAddress, "ContextObject");
		AssertTrue_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertTrue_FunctionAddress, "ContextObject");
		AssertTrue_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertTrue_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertTrue_ReturnValue_PropertyAddress, AssertTrue_FunctionAddress, "ReturnValue");
		AssertTrue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertTrue_FunctionAddress, "ReturnValue");
		AssertTrue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertTrue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertTrue_IsValid = AssertTrue_FunctionAddress != IntPtr.Zero && AssertTrue_Condition_IsValid && AssertTrue_Message_IsValid && AssertTrue_ContextObject_IsValid && AssertTrue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertTrue", AssertTrue_IsValid);
		AssertNotEqual_Vector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertNotEqual_Vector");
		AssertNotEqual_Vector_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertNotEqual_Vector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Vector_Actual_PropertyAddress, AssertNotEqual_Vector_FunctionAddress, "Actual");
		AssertNotEqual_Vector_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Vector_FunctionAddress, "Actual");
		AssertNotEqual_Vector_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Vector_FunctionAddress, "Actual", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Vector_NotExpected_PropertyAddress, AssertNotEqual_Vector_FunctionAddress, "NotExpected");
		AssertNotEqual_Vector_NotExpected_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Vector_FunctionAddress, "NotExpected");
		AssertNotEqual_Vector_NotExpected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Vector_FunctionAddress, "NotExpected", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Vector_What_PropertyAddress, AssertNotEqual_Vector_FunctionAddress, "What");
		AssertNotEqual_Vector_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Vector_FunctionAddress, "What");
		AssertNotEqual_Vector_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Vector_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Vector_ContextObject_PropertyAddress, AssertNotEqual_Vector_FunctionAddress, "ContextObject");
		AssertNotEqual_Vector_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Vector_FunctionAddress, "ContextObject");
		AssertNotEqual_Vector_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Vector_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Vector_ReturnValue_PropertyAddress, AssertNotEqual_Vector_FunctionAddress, "ReturnValue");
		AssertNotEqual_Vector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Vector_FunctionAddress, "ReturnValue");
		AssertNotEqual_Vector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Vector_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertNotEqual_Vector_IsValid = AssertNotEqual_Vector_FunctionAddress != IntPtr.Zero && AssertNotEqual_Vector_Actual_IsValid && AssertNotEqual_Vector_NotExpected_IsValid && AssertNotEqual_Vector_What_IsValid && AssertNotEqual_Vector_ContextObject_IsValid && AssertNotEqual_Vector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_Vector", AssertNotEqual_Vector_IsValid);
		AssertNotEqual_Transform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertNotEqual_Transform");
		AssertNotEqual_Transform_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertNotEqual_Transform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Transform_Actual_PropertyAddress, AssertNotEqual_Transform_FunctionAddress, "Actual");
		AssertNotEqual_Transform_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Transform_FunctionAddress, "Actual");
		AssertNotEqual_Transform_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Transform_FunctionAddress, "Actual", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Transform_NotExpected_PropertyAddress, AssertNotEqual_Transform_FunctionAddress, "NotExpected");
		AssertNotEqual_Transform_NotExpected_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Transform_FunctionAddress, "NotExpected");
		AssertNotEqual_Transform_NotExpected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Transform_FunctionAddress, "NotExpected", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Transform_What_PropertyAddress, AssertNotEqual_Transform_FunctionAddress, "What");
		AssertNotEqual_Transform_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Transform_FunctionAddress, "What");
		AssertNotEqual_Transform_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Transform_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Transform_ContextObject_PropertyAddress, AssertNotEqual_Transform_FunctionAddress, "ContextObject");
		AssertNotEqual_Transform_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Transform_FunctionAddress, "ContextObject");
		AssertNotEqual_Transform_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Transform_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Transform_ReturnValue_PropertyAddress, AssertNotEqual_Transform_FunctionAddress, "ReturnValue");
		AssertNotEqual_Transform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Transform_FunctionAddress, "ReturnValue");
		AssertNotEqual_Transform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Transform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertNotEqual_Transform_IsValid = AssertNotEqual_Transform_FunctionAddress != IntPtr.Zero && AssertNotEqual_Transform_Actual_IsValid && AssertNotEqual_Transform_NotExpected_IsValid && AssertNotEqual_Transform_What_IsValid && AssertNotEqual_Transform_ContextObject_IsValid && AssertNotEqual_Transform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_Transform", AssertNotEqual_Transform_IsValid);
		AssertNotEqual_String_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertNotEqual_String");
		AssertNotEqual_String_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertNotEqual_String_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_String_Actual_PropertyAddress, AssertNotEqual_String_FunctionAddress, "Actual");
		AssertNotEqual_String_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_String_FunctionAddress, "Actual");
		AssertNotEqual_String_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_String_FunctionAddress, "Actual", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_String_NotExpected_PropertyAddress, AssertNotEqual_String_FunctionAddress, "NotExpected");
		AssertNotEqual_String_NotExpected_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_String_FunctionAddress, "NotExpected");
		AssertNotEqual_String_NotExpected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_String_FunctionAddress, "NotExpected", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_String_What_PropertyAddress, AssertNotEqual_String_FunctionAddress, "What");
		AssertNotEqual_String_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_String_FunctionAddress, "What");
		AssertNotEqual_String_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_String_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_String_ContextObject_PropertyAddress, AssertNotEqual_String_FunctionAddress, "ContextObject");
		AssertNotEqual_String_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_String_FunctionAddress, "ContextObject");
		AssertNotEqual_String_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_String_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_String_ReturnValue_PropertyAddress, AssertNotEqual_String_FunctionAddress, "ReturnValue");
		AssertNotEqual_String_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_String_FunctionAddress, "ReturnValue");
		AssertNotEqual_String_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_String_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertNotEqual_String_IsValid = AssertNotEqual_String_FunctionAddress != IntPtr.Zero && AssertNotEqual_String_Actual_IsValid && AssertNotEqual_String_NotExpected_IsValid && AssertNotEqual_String_What_IsValid && AssertNotEqual_String_ContextObject_IsValid && AssertNotEqual_String_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_String", AssertNotEqual_String_IsValid);
		AssertNotEqual_Rotator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertNotEqual_Rotator");
		AssertNotEqual_Rotator_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertNotEqual_Rotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Rotator_Actual_PropertyAddress, AssertNotEqual_Rotator_FunctionAddress, "Actual");
		AssertNotEqual_Rotator_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Rotator_FunctionAddress, "Actual");
		AssertNotEqual_Rotator_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Rotator_FunctionAddress, "Actual", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Rotator_NotExpected_PropertyAddress, AssertNotEqual_Rotator_FunctionAddress, "NotExpected");
		AssertNotEqual_Rotator_NotExpected_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Rotator_FunctionAddress, "NotExpected");
		AssertNotEqual_Rotator_NotExpected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Rotator_FunctionAddress, "NotExpected", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Rotator_What_PropertyAddress, AssertNotEqual_Rotator_FunctionAddress, "What");
		AssertNotEqual_Rotator_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Rotator_FunctionAddress, "What");
		AssertNotEqual_Rotator_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Rotator_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Rotator_ContextObject_PropertyAddress, AssertNotEqual_Rotator_FunctionAddress, "ContextObject");
		AssertNotEqual_Rotator_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Rotator_FunctionAddress, "ContextObject");
		AssertNotEqual_Rotator_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Rotator_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertNotEqual_Rotator_ReturnValue_PropertyAddress, AssertNotEqual_Rotator_FunctionAddress, "ReturnValue");
		AssertNotEqual_Rotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertNotEqual_Rotator_FunctionAddress, "ReturnValue");
		AssertNotEqual_Rotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertNotEqual_Rotator_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertNotEqual_Rotator_IsValid = AssertNotEqual_Rotator_FunctionAddress != IntPtr.Zero && AssertNotEqual_Rotator_Actual_IsValid && AssertNotEqual_Rotator_NotExpected_IsValid && AssertNotEqual_Rotator_What_IsValid && AssertNotEqual_Rotator_ContextObject_IsValid && AssertNotEqual_Rotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertNotEqual_Rotator", AssertNotEqual_Rotator_IsValid);
		AssertIsValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertIsValid");
		AssertIsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertIsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertIsValid_Object_PropertyAddress, AssertIsValid_FunctionAddress, "Object");
		AssertIsValid_Object_Offset = NativeReflectionCached.GetPropertyOffset(AssertIsValid_FunctionAddress, "Object");
		AssertIsValid_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertIsValid_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertIsValid_Message_PropertyAddress, AssertIsValid_FunctionAddress, "Message");
		AssertIsValid_Message_Offset = NativeReflectionCached.GetPropertyOffset(AssertIsValid_FunctionAddress, "Message");
		AssertIsValid_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertIsValid_FunctionAddress, "Message", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertIsValid_ContextObject_PropertyAddress, AssertIsValid_FunctionAddress, "ContextObject");
		AssertIsValid_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertIsValid_FunctionAddress, "ContextObject");
		AssertIsValid_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertIsValid_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertIsValid_ReturnValue_PropertyAddress, AssertIsValid_FunctionAddress, "ReturnValue");
		AssertIsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertIsValid_FunctionAddress, "ReturnValue");
		AssertIsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertIsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertIsValid_IsValid = AssertIsValid_FunctionAddress != IntPtr.Zero && AssertIsValid_Object_IsValid && AssertIsValid_Message_IsValid && AssertIsValid_ContextObject_IsValid && AssertIsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertIsValid", AssertIsValid_IsValid);
		AssertFalse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertFalse");
		AssertFalse_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertFalse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertFalse_Condition_PropertyAddress, AssertFalse_FunctionAddress, "Condition");
		AssertFalse_Condition_Offset = NativeReflectionCached.GetPropertyOffset(AssertFalse_FunctionAddress, "Condition");
		AssertFalse_Condition_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertFalse_FunctionAddress, "Condition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertFalse_Message_PropertyAddress, AssertFalse_FunctionAddress, "Message");
		AssertFalse_Message_Offset = NativeReflectionCached.GetPropertyOffset(AssertFalse_FunctionAddress, "Message");
		AssertFalse_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertFalse_FunctionAddress, "Message", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertFalse_ContextObject_PropertyAddress, AssertFalse_FunctionAddress, "ContextObject");
		AssertFalse_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertFalse_FunctionAddress, "ContextObject");
		AssertFalse_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertFalse_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertFalse_ReturnValue_PropertyAddress, AssertFalse_FunctionAddress, "ReturnValue");
		AssertFalse_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertFalse_FunctionAddress, "ReturnValue");
		AssertFalse_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertFalse_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertFalse_IsValid = AssertFalse_FunctionAddress != IntPtr.Zero && AssertFalse_Condition_IsValid && AssertFalse_Message_IsValid && AssertFalse_ContextObject_IsValid && AssertFalse_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertFalse", AssertFalse_IsValid);
		AssertEqual_Vector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_Vector");
		AssertEqual_Vector_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_Vector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Vector_Actual_PropertyAddress, AssertEqual_Vector_FunctionAddress, "Actual");
		AssertEqual_Vector_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Vector_FunctionAddress, "Actual");
		AssertEqual_Vector_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Vector_FunctionAddress, "Actual", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Vector_Expected_PropertyAddress, AssertEqual_Vector_FunctionAddress, "Expected");
		AssertEqual_Vector_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Vector_FunctionAddress, "Expected");
		AssertEqual_Vector_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Vector_FunctionAddress, "Expected", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Vector_What_PropertyAddress, AssertEqual_Vector_FunctionAddress, "What");
		AssertEqual_Vector_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Vector_FunctionAddress, "What");
		AssertEqual_Vector_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Vector_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Vector_Tolerance_PropertyAddress, AssertEqual_Vector_FunctionAddress, "Tolerance");
		AssertEqual_Vector_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Vector_FunctionAddress, "Tolerance");
		AssertEqual_Vector_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Vector_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Vector_ContextObject_PropertyAddress, AssertEqual_Vector_FunctionAddress, "ContextObject");
		AssertEqual_Vector_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Vector_FunctionAddress, "ContextObject");
		AssertEqual_Vector_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Vector_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Vector_ReturnValue_PropertyAddress, AssertEqual_Vector_FunctionAddress, "ReturnValue");
		AssertEqual_Vector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Vector_FunctionAddress, "ReturnValue");
		AssertEqual_Vector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Vector_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_Vector_IsValid = AssertEqual_Vector_FunctionAddress != IntPtr.Zero && AssertEqual_Vector_Actual_IsValid && AssertEqual_Vector_Expected_IsValid && AssertEqual_Vector_What_IsValid && AssertEqual_Vector_Tolerance_IsValid && AssertEqual_Vector_ContextObject_IsValid && AssertEqual_Vector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Vector", AssertEqual_Vector_IsValid);
		AssertEqual_Transform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_Transform");
		AssertEqual_Transform_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_Transform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Transform_Actual_PropertyAddress, AssertEqual_Transform_FunctionAddress, "Actual");
		AssertEqual_Transform_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Transform_FunctionAddress, "Actual");
		AssertEqual_Transform_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Transform_FunctionAddress, "Actual", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Transform_Expected_PropertyAddress, AssertEqual_Transform_FunctionAddress, "Expected");
		AssertEqual_Transform_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Transform_FunctionAddress, "Expected");
		AssertEqual_Transform_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Transform_FunctionAddress, "Expected", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Transform_What_PropertyAddress, AssertEqual_Transform_FunctionAddress, "What");
		AssertEqual_Transform_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Transform_FunctionAddress, "What");
		AssertEqual_Transform_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Transform_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Transform_Tolerance_PropertyAddress, AssertEqual_Transform_FunctionAddress, "Tolerance");
		AssertEqual_Transform_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Transform_FunctionAddress, "Tolerance");
		AssertEqual_Transform_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Transform_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Transform_ContextObject_PropertyAddress, AssertEqual_Transform_FunctionAddress, "ContextObject");
		AssertEqual_Transform_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Transform_FunctionAddress, "ContextObject");
		AssertEqual_Transform_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Transform_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Transform_ReturnValue_PropertyAddress, AssertEqual_Transform_FunctionAddress, "ReturnValue");
		AssertEqual_Transform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Transform_FunctionAddress, "ReturnValue");
		AssertEqual_Transform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Transform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_Transform_IsValid = AssertEqual_Transform_FunctionAddress != IntPtr.Zero && AssertEqual_Transform_Actual_IsValid && AssertEqual_Transform_Expected_IsValid && AssertEqual_Transform_What_IsValid && AssertEqual_Transform_Tolerance_IsValid && AssertEqual_Transform_ContextObject_IsValid && AssertEqual_Transform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Transform", AssertEqual_Transform_IsValid);
		AssertEqual_TraceQueryResults_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_TraceQueryResults");
		AssertEqual_TraceQueryResults_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_TraceQueryResults_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_TraceQueryResults_Actual_PropertyAddress, AssertEqual_TraceQueryResults_FunctionAddress, "Actual");
		AssertEqual_TraceQueryResults_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_TraceQueryResults_FunctionAddress, "Actual");
		AssertEqual_TraceQueryResults_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_TraceQueryResults_FunctionAddress, "Actual", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_TraceQueryResults_Expected_PropertyAddress, AssertEqual_TraceQueryResults_FunctionAddress, "Expected");
		AssertEqual_TraceQueryResults_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_TraceQueryResults_FunctionAddress, "Expected");
		AssertEqual_TraceQueryResults_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_TraceQueryResults_FunctionAddress, "Expected", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_TraceQueryResults_What_PropertyAddress, AssertEqual_TraceQueryResults_FunctionAddress, "What");
		AssertEqual_TraceQueryResults_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_TraceQueryResults_FunctionAddress, "What");
		AssertEqual_TraceQueryResults_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_TraceQueryResults_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_TraceQueryResults_ContextObject_PropertyAddress, AssertEqual_TraceQueryResults_FunctionAddress, "ContextObject");
		AssertEqual_TraceQueryResults_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_TraceQueryResults_FunctionAddress, "ContextObject");
		AssertEqual_TraceQueryResults_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_TraceQueryResults_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_TraceQueryResults_ReturnValue_PropertyAddress, AssertEqual_TraceQueryResults_FunctionAddress, "ReturnValue");
		AssertEqual_TraceQueryResults_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_TraceQueryResults_FunctionAddress, "ReturnValue");
		AssertEqual_TraceQueryResults_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_TraceQueryResults_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_TraceQueryResults_IsValid = AssertEqual_TraceQueryResults_FunctionAddress != IntPtr.Zero && AssertEqual_TraceQueryResults_Actual_IsValid && AssertEqual_TraceQueryResults_Expected_IsValid && AssertEqual_TraceQueryResults_What_IsValid && AssertEqual_TraceQueryResults_ContextObject_IsValid && AssertEqual_TraceQueryResults_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_TraceQueryResults", AssertEqual_TraceQueryResults_IsValid);
		AssertEqual_String_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_String");
		AssertEqual_String_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_String_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_String_Actual_PropertyAddress, AssertEqual_String_FunctionAddress, "Actual");
		AssertEqual_String_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_String_FunctionAddress, "Actual");
		AssertEqual_String_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_String_FunctionAddress, "Actual", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_String_Expected_PropertyAddress, AssertEqual_String_FunctionAddress, "Expected");
		AssertEqual_String_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_String_FunctionAddress, "Expected");
		AssertEqual_String_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_String_FunctionAddress, "Expected", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_String_What_PropertyAddress, AssertEqual_String_FunctionAddress, "What");
		AssertEqual_String_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_String_FunctionAddress, "What");
		AssertEqual_String_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_String_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_String_ContextObject_PropertyAddress, AssertEqual_String_FunctionAddress, "ContextObject");
		AssertEqual_String_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_String_FunctionAddress, "ContextObject");
		AssertEqual_String_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_String_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_String_ReturnValue_PropertyAddress, AssertEqual_String_FunctionAddress, "ReturnValue");
		AssertEqual_String_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_String_FunctionAddress, "ReturnValue");
		AssertEqual_String_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_String_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_String_IsValid = AssertEqual_String_FunctionAddress != IntPtr.Zero && AssertEqual_String_Actual_IsValid && AssertEqual_String_Expected_IsValid && AssertEqual_String_What_IsValid && AssertEqual_String_ContextObject_IsValid && AssertEqual_String_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_String", AssertEqual_String_IsValid);
		AssertEqual_Rotator_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_Rotator");
		AssertEqual_Rotator_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_Rotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Rotator_Actual_PropertyAddress, AssertEqual_Rotator_FunctionAddress, "Actual");
		AssertEqual_Rotator_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Rotator_FunctionAddress, "Actual");
		AssertEqual_Rotator_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Rotator_FunctionAddress, "Actual", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Rotator_Expected_PropertyAddress, AssertEqual_Rotator_FunctionAddress, "Expected");
		AssertEqual_Rotator_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Rotator_FunctionAddress, "Expected");
		AssertEqual_Rotator_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Rotator_FunctionAddress, "Expected", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Rotator_What_PropertyAddress, AssertEqual_Rotator_FunctionAddress, "What");
		AssertEqual_Rotator_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Rotator_FunctionAddress, "What");
		AssertEqual_Rotator_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Rotator_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Rotator_Tolerance_PropertyAddress, AssertEqual_Rotator_FunctionAddress, "Tolerance");
		AssertEqual_Rotator_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Rotator_FunctionAddress, "Tolerance");
		AssertEqual_Rotator_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Rotator_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Rotator_ContextObject_PropertyAddress, AssertEqual_Rotator_FunctionAddress, "ContextObject");
		AssertEqual_Rotator_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Rotator_FunctionAddress, "ContextObject");
		AssertEqual_Rotator_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Rotator_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Rotator_ReturnValue_PropertyAddress, AssertEqual_Rotator_FunctionAddress, "ReturnValue");
		AssertEqual_Rotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Rotator_FunctionAddress, "ReturnValue");
		AssertEqual_Rotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Rotator_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_Rotator_IsValid = AssertEqual_Rotator_FunctionAddress != IntPtr.Zero && AssertEqual_Rotator_Actual_IsValid && AssertEqual_Rotator_Expected_IsValid && AssertEqual_Rotator_What_IsValid && AssertEqual_Rotator_Tolerance_IsValid && AssertEqual_Rotator_ContextObject_IsValid && AssertEqual_Rotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Rotator", AssertEqual_Rotator_IsValid);
		AssertEqual_Object_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_Object");
		AssertEqual_Object_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_Object_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Object_Actual_PropertyAddress, AssertEqual_Object_FunctionAddress, "Actual");
		AssertEqual_Object_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Object_FunctionAddress, "Actual");
		AssertEqual_Object_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Object_FunctionAddress, "Actual", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Object_Expected_PropertyAddress, AssertEqual_Object_FunctionAddress, "Expected");
		AssertEqual_Object_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Object_FunctionAddress, "Expected");
		AssertEqual_Object_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Object_FunctionAddress, "Expected", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Object_What_PropertyAddress, AssertEqual_Object_FunctionAddress, "What");
		AssertEqual_Object_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Object_FunctionAddress, "What");
		AssertEqual_Object_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Object_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Object_ContextObject_PropertyAddress, AssertEqual_Object_FunctionAddress, "ContextObject");
		AssertEqual_Object_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Object_FunctionAddress, "ContextObject");
		AssertEqual_Object_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Object_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Object_ReturnValue_PropertyAddress, AssertEqual_Object_FunctionAddress, "ReturnValue");
		AssertEqual_Object_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Object_FunctionAddress, "ReturnValue");
		AssertEqual_Object_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Object_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_Object_IsValid = AssertEqual_Object_FunctionAddress != IntPtr.Zero && AssertEqual_Object_Actual_IsValid && AssertEqual_Object_Expected_IsValid && AssertEqual_Object_What_IsValid && AssertEqual_Object_ContextObject_IsValid && AssertEqual_Object_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Object", AssertEqual_Object_IsValid);
		AssertEqual_Name_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_Name");
		AssertEqual_Name_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_Name_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Name_Actual_PropertyAddress, AssertEqual_Name_FunctionAddress, "Actual");
		AssertEqual_Name_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Name_FunctionAddress, "Actual");
		AssertEqual_Name_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Name_FunctionAddress, "Actual", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Name_Expected_PropertyAddress, AssertEqual_Name_FunctionAddress, "Expected");
		AssertEqual_Name_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Name_FunctionAddress, "Expected");
		AssertEqual_Name_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Name_FunctionAddress, "Expected", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Name_What_PropertyAddress, AssertEqual_Name_FunctionAddress, "What");
		AssertEqual_Name_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Name_FunctionAddress, "What");
		AssertEqual_Name_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Name_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Name_ContextObject_PropertyAddress, AssertEqual_Name_FunctionAddress, "ContextObject");
		AssertEqual_Name_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Name_FunctionAddress, "ContextObject");
		AssertEqual_Name_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Name_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Name_ReturnValue_PropertyAddress, AssertEqual_Name_FunctionAddress, "ReturnValue");
		AssertEqual_Name_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Name_FunctionAddress, "ReturnValue");
		AssertEqual_Name_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Name_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_Name_IsValid = AssertEqual_Name_FunctionAddress != IntPtr.Zero && AssertEqual_Name_Actual_IsValid && AssertEqual_Name_Expected_IsValid && AssertEqual_Name_What_IsValid && AssertEqual_Name_ContextObject_IsValid && AssertEqual_Name_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Name", AssertEqual_Name_IsValid);
		AssertEqual_Int_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_Int");
		AssertEqual_Int_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_Int_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Int_Actual_PropertyAddress, AssertEqual_Int_FunctionAddress, "Actual");
		AssertEqual_Int_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Int_FunctionAddress, "Actual");
		AssertEqual_Int_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Int_FunctionAddress, "Actual", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Int_Expected_PropertyAddress, AssertEqual_Int_FunctionAddress, "Expected");
		AssertEqual_Int_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Int_FunctionAddress, "Expected");
		AssertEqual_Int_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Int_FunctionAddress, "Expected", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Int_What_PropertyAddress, AssertEqual_Int_FunctionAddress, "What");
		AssertEqual_Int_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Int_FunctionAddress, "What");
		AssertEqual_Int_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Int_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Int_ContextObject_PropertyAddress, AssertEqual_Int_FunctionAddress, "ContextObject");
		AssertEqual_Int_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Int_FunctionAddress, "ContextObject");
		AssertEqual_Int_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Int_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Int_ReturnValue_PropertyAddress, AssertEqual_Int_FunctionAddress, "ReturnValue");
		AssertEqual_Int_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Int_FunctionAddress, "ReturnValue");
		AssertEqual_Int_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Int_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_Int_IsValid = AssertEqual_Int_FunctionAddress != IntPtr.Zero && AssertEqual_Int_Actual_IsValid && AssertEqual_Int_Expected_IsValid && AssertEqual_Int_What_IsValid && AssertEqual_Int_ContextObject_IsValid && AssertEqual_Int_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Int", AssertEqual_Int_IsValid);
		AssertEqual_Float_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_Float");
		AssertEqual_Float_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_Float_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Float_Actual_PropertyAddress, AssertEqual_Float_FunctionAddress, "Actual");
		AssertEqual_Float_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Float_FunctionAddress, "Actual");
		AssertEqual_Float_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Float_FunctionAddress, "Actual", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Float_Expected_PropertyAddress, AssertEqual_Float_FunctionAddress, "Expected");
		AssertEqual_Float_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Float_FunctionAddress, "Expected");
		AssertEqual_Float_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Float_FunctionAddress, "Expected", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Float_What_PropertyAddress, AssertEqual_Float_FunctionAddress, "What");
		AssertEqual_Float_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Float_FunctionAddress, "What");
		AssertEqual_Float_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Float_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Float_Tolerance_PropertyAddress, AssertEqual_Float_FunctionAddress, "Tolerance");
		AssertEqual_Float_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Float_FunctionAddress, "Tolerance");
		AssertEqual_Float_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Float_FunctionAddress, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Float_ContextObject_PropertyAddress, AssertEqual_Float_FunctionAddress, "ContextObject");
		AssertEqual_Float_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Float_FunctionAddress, "ContextObject");
		AssertEqual_Float_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Float_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Float_ReturnValue_PropertyAddress, AssertEqual_Float_FunctionAddress, "ReturnValue");
		AssertEqual_Float_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Float_FunctionAddress, "ReturnValue");
		AssertEqual_Float_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Float_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_Float_IsValid = AssertEqual_Float_FunctionAddress != IntPtr.Zero && AssertEqual_Float_Actual_IsValid && AssertEqual_Float_Expected_IsValid && AssertEqual_Float_What_IsValid && AssertEqual_Float_Tolerance_IsValid && AssertEqual_Float_ContextObject_IsValid && AssertEqual_Float_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Float", AssertEqual_Float_IsValid);
		AssertEqual_Double_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_Double");
		AssertEqual_Double_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_Double_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Double_Actual_PropertyAddress, AssertEqual_Double_FunctionAddress, "Actual");
		AssertEqual_Double_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Double_FunctionAddress, "Actual");
		AssertEqual_Double_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Double_FunctionAddress, "Actual", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Double_Expected_PropertyAddress, AssertEqual_Double_FunctionAddress, "Expected");
		AssertEqual_Double_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Double_FunctionAddress, "Expected");
		AssertEqual_Double_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Double_FunctionAddress, "Expected", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Double_What_PropertyAddress, AssertEqual_Double_FunctionAddress, "What");
		AssertEqual_Double_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Double_FunctionAddress, "What");
		AssertEqual_Double_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Double_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Double_Tolerance_PropertyAddress, AssertEqual_Double_FunctionAddress, "Tolerance");
		AssertEqual_Double_Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Double_FunctionAddress, "Tolerance");
		AssertEqual_Double_Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Double_FunctionAddress, "Tolerance", Classes.FDoubleProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Double_ContextObject_PropertyAddress, AssertEqual_Double_FunctionAddress, "ContextObject");
		AssertEqual_Double_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Double_FunctionAddress, "ContextObject");
		AssertEqual_Double_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Double_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Double_ReturnValue_PropertyAddress, AssertEqual_Double_FunctionAddress, "ReturnValue");
		AssertEqual_Double_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Double_FunctionAddress, "ReturnValue");
		AssertEqual_Double_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Double_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_Double_IsValid = AssertEqual_Double_FunctionAddress != IntPtr.Zero && AssertEqual_Double_Actual_IsValid && AssertEqual_Double_Expected_IsValid && AssertEqual_Double_What_IsValid && AssertEqual_Double_Tolerance_IsValid && AssertEqual_Double_ContextObject_IsValid && AssertEqual_Double_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Double", AssertEqual_Double_IsValid);
		AssertEqual_Bool_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssertEqual_Bool");
		AssertEqual_Bool_ParamsSize = NativeReflection.GetFunctionParamsSize(AssertEqual_Bool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Bool_Actual_PropertyAddress, AssertEqual_Bool_FunctionAddress, "Actual");
		AssertEqual_Bool_Actual_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Bool_FunctionAddress, "Actual");
		AssertEqual_Bool_Actual_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Bool_FunctionAddress, "Actual", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Bool_Expected_PropertyAddress, AssertEqual_Bool_FunctionAddress, "Expected");
		AssertEqual_Bool_Expected_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Bool_FunctionAddress, "Expected");
		AssertEqual_Bool_Expected_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Bool_FunctionAddress, "Expected", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Bool_What_PropertyAddress, AssertEqual_Bool_FunctionAddress, "What");
		AssertEqual_Bool_What_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Bool_FunctionAddress, "What");
		AssertEqual_Bool_What_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Bool_FunctionAddress, "What", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Bool_ContextObject_PropertyAddress, AssertEqual_Bool_FunctionAddress, "ContextObject");
		AssertEqual_Bool_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Bool_FunctionAddress, "ContextObject");
		AssertEqual_Bool_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Bool_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssertEqual_Bool_ReturnValue_PropertyAddress, AssertEqual_Bool_FunctionAddress, "ReturnValue");
		AssertEqual_Bool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssertEqual_Bool_FunctionAddress, "ReturnValue");
		AssertEqual_Bool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssertEqual_Bool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AssertEqual_Bool_IsValid = AssertEqual_Bool_FunctionAddress != IntPtr.Zero && AssertEqual_Bool_Actual_IsValid && AssertEqual_Bool_Expected_IsValid && AssertEqual_Bool_What_IsValid && AssertEqual_Bool_ContextObject_IsValid && AssertEqual_Bool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AssertEqual_Bool", AssertEqual_Bool_IsValid);
		AddWarning_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddWarning");
		AddWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWarning_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWarning_Message_PropertyAddress, AddWarning_FunctionAddress, "Message");
		AddWarning_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddWarning_FunctionAddress, "Message");
		AddWarning_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWarning_FunctionAddress, "Message", Classes.FStrProperty);
		AddWarning_IsValid = AddWarning_FunctionAddress != IntPtr.Zero && AddWarning_Message_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AddWarning", AddWarning_IsValid);
		AddRerun_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddRerun");
		AddRerun_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRerun_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRerun_Reason_PropertyAddress, AddRerun_FunctionAddress, "Reason");
		AddRerun_Reason_Offset = NativeReflectionCached.GetPropertyOffset(AddRerun_FunctionAddress, "Reason");
		AddRerun_Reason_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerun_FunctionAddress, "Reason", Classes.FNameProperty);
		AddRerun_IsValid = AddRerun_FunctionAddress != IntPtr.Zero && AddRerun_Reason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AddRerun", AddRerun_IsValid);
		AddError_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddError");
		AddError_ParamsSize = NativeReflection.GetFunctionParamsSize(AddError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddError_Message_PropertyAddress, AddError_FunctionAddress, "Message");
		AddError_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddError_FunctionAddress, "Message");
		AddError_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddError_FunctionAddress, "Message", Classes.FStrProperty);
		AddError_IsValid = AddError_FunctionAddress != IntPtr.Zero && AddError_Message_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.FunctionalTest:AddError", AddError_IsValid);
	}
}
