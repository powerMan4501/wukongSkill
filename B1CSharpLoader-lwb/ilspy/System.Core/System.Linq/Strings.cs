namespace System.Linq;

internal static class Strings
{
	internal static string OwningTeam => SR.GetString("OwningTeam");

	internal static string IncompatibleElementTypes => SR.GetString("IncompatibleElementTypes");

	internal static string MoreThanOneElement => SR.GetString("MoreThanOneElement");

	internal static string MoreThanOneMatch => SR.GetString("MoreThanOneMatch");

	internal static string NoElements => SR.GetString("NoElements");

	internal static string NoMatch => SR.GetString("NoMatch");

	internal static string EmptyEnumerable => SR.GetString("EmptyEnumerable");

	internal static string Argument_AdjustmentRulesNoNulls => SR.GetString("Argument_AdjustmentRulesNoNulls");

	internal static string Argument_AdjustmentRulesOutOfOrder => SR.GetString("Argument_AdjustmentRulesOutOfOrder");

	internal static string Argument_AdjustmentRulesAmbiguousOverlap => SR.GetString("Argument_AdjustmentRulesAmbiguousOverlap");

	internal static string Argument_AdjustmentRulesrDaylightSavingTimeOverlap => SR.GetString("Argument_AdjustmentRulesrDaylightSavingTimeOverlap");

	internal static string Argument_AdjustmentRulesrDaylightSavingTimeOverlapNonRuleRange => SR.GetString("Argument_AdjustmentRulesrDaylightSavingTimeOverlapNonRuleRange");

	internal static string Argument_AdjustmentRulesInvalidOverlap => SR.GetString("Argument_AdjustmentRulesInvalidOverlap");

	internal static string Argument_ConvertMismatch => SR.GetString("Argument_ConvertMismatch");

	internal static string Argument_DateTimeHasTimeOfDay => SR.GetString("Argument_DateTimeHasTimeOfDay");

	internal static string Argument_DateTimeIsInvalid => SR.GetString("Argument_DateTimeIsInvalid");

	internal static string Argument_DateTimeIsNotAmbiguous => SR.GetString("Argument_DateTimeIsNotAmbiguous");

	internal static string Argument_DateTimeOffsetIsNotAmbiguous => SR.GetString("Argument_DateTimeOffsetIsNotAmbiguous");

	internal static string Argument_DateTimeKindMustBeUnspecified => SR.GetString("Argument_DateTimeKindMustBeUnspecified");

	internal static string Argument_DateTimeHasTicks => SR.GetString("Argument_DateTimeHasTicks");

	internal static string Argument_InvalidREG_TZI_FORMAT => SR.GetString("Argument_InvalidREG_TZI_FORMAT");

	internal static string Argument_OutOfOrderDateTimes => SR.GetString("Argument_OutOfOrderDateTimes");

	internal static string Argument_TimeSpanHasSeconds => SR.GetString("Argument_TimeSpanHasSeconds");

	internal static string Argument_TimeZoneInfoBadTZif => SR.GetString("Argument_TimeZoneInfoBadTZif");

	internal static string Argument_TimeZoneInfoInvalidTZif => SR.GetString("Argument_TimeZoneInfoInvalidTZif");

	internal static string Argument_TransitionTimesAreIdentical => SR.GetString("Argument_TransitionTimesAreIdentical");

	internal static string ArgumentOutOfRange_DayParam => SR.GetString("ArgumentOutOfRange_DayParam");

	internal static string ArgumentOutOfRange_DayOfWeek => SR.GetString("ArgumentOutOfRange_DayOfWeek");

	internal static string ArgumentOutOfRange_MonthParam => SR.GetString("ArgumentOutOfRange_MonthParam");

	internal static string ArgumentOutOfRange_UtcOffset => SR.GetString("ArgumentOutOfRange_UtcOffset");

	internal static string ArgumentOutOfRange_UtcOffsetAndDaylightDelta => SR.GetString("ArgumentOutOfRange_UtcOffsetAndDaylightDelta");

	internal static string ArgumentOutOfRange_Week => SR.GetString("ArgumentOutOfRange_Week");

	internal static string InvalidTimeZone_InvalidWin32APIData => SR.GetString("InvalidTimeZone_InvalidWin32APIData");

	internal static string ArgumentOutOfRange_DateTimeBadTicks => SR.GetString("ArgumentOutOfRange_DateTimeBadTicks");

	internal static string PLINQ_CommonEnumerator_Current_NotStarted => SR.GetString("PLINQ_CommonEnumerator_Current_NotStarted");

	internal static string PLINQ_ExternalCancellationRequested => SR.GetString("PLINQ_ExternalCancellationRequested");

	internal static string PLINQ_DisposeRequested => SR.GetString("PLINQ_DisposeRequested");

	internal static string PLINQ_EnumerationPreviouslyFailed => SR.GetString("PLINQ_EnumerationPreviouslyFailed");

	internal static string ParallelPartitionable_NullReturn => SR.GetString("ParallelPartitionable_NullReturn");

	internal static string ParallelPartitionable_NullElement => SR.GetString("ParallelPartitionable_NullElement");

	internal static string ParallelPartitionable_IncorretElementCount => SR.GetString("ParallelPartitionable_IncorretElementCount");

	internal static string ParallelEnumerable_ToArray_DimensionRequired => SR.GetString("ParallelEnumerable_ToArray_DimensionRequired");

	internal static string ParallelEnumerable_WithQueryExecutionMode_InvalidMode => SR.GetString("ParallelEnumerable_WithQueryExecutionMode_InvalidMode");

	internal static string ParallelEnumerable_WithMergeOptions_InvalidOptions => SR.GetString("ParallelEnumerable_WithMergeOptions_InvalidOptions");

	internal static string ParallelEnumerable_BinaryOpMustUseAsParallel => SR.GetString("ParallelEnumerable_BinaryOpMustUseAsParallel");

	internal static string ParallelEnumerable_WithCancellation_TokenSourceDisposed => SR.GetString("ParallelEnumerable_WithCancellation_TokenSourceDisposed");

	internal static string ParallelQuery_InvalidAsOrderedCall => SR.GetString("ParallelQuery_InvalidAsOrderedCall");

	internal static string ParallelQuery_InvalidNonGenericAsOrderedCall => SR.GetString("ParallelQuery_InvalidNonGenericAsOrderedCall");

	internal static string ParallelQuery_PartitionerNotOrderable => SR.GetString("ParallelQuery_PartitionerNotOrderable");

	internal static string ParallelQuery_DuplicateTaskScheduler => SR.GetString("ParallelQuery_DuplicateTaskScheduler");

	internal static string ParallelQuery_DuplicateDOP => SR.GetString("ParallelQuery_DuplicateDOP");

	internal static string ParallelQuery_DuplicateWithCancellation => SR.GetString("ParallelQuery_DuplicateWithCancellation");

	internal static string ParallelQuery_DuplicateExecutionMode => SR.GetString("ParallelQuery_DuplicateExecutionMode");

	internal static string ParallelQuery_DuplicateMergeOptions => SR.GetString("ParallelQuery_DuplicateMergeOptions");

	internal static string PartitionerQueryOperator_NullPartitionList => SR.GetString("PartitionerQueryOperator_NullPartitionList");

	internal static string PartitionerQueryOperator_WrongNumberOfPartitions => SR.GetString("PartitionerQueryOperator_WrongNumberOfPartitions");

	internal static string PartitionerQueryOperator_NullPartition => SR.GetString("PartitionerQueryOperator_NullPartition");

	internal static string ArgumentArrayHasTooManyElements(object p0)
	{
		return SR.GetString("ArgumentArrayHasTooManyElements", p0);
	}

	internal static string ArgumentNotIEnumerableGeneric(object p0)
	{
		return SR.GetString("ArgumentNotIEnumerableGeneric", p0);
	}

	internal static string ArgumentNotSequence(object p0)
	{
		return SR.GetString("ArgumentNotSequence", p0);
	}

	internal static string ArgumentNotValid(object p0)
	{
		return SR.GetString("ArgumentNotValid", p0);
	}

	internal static string ArgumentNotLambda(object p0)
	{
		return SR.GetString("ArgumentNotLambda", p0);
	}

	internal static string NoArgumentMatchingMethodsInQueryable(object p0)
	{
		return SR.GetString("NoArgumentMatchingMethodsInQueryable", p0);
	}

	internal static string NoMethodOnType(object p0, object p1)
	{
		return SR.GetString("NoMethodOnType", p0, p1);
	}

	internal static string NoMethodOnTypeMatchingArguments(object p0, object p1)
	{
		return SR.GetString("NoMethodOnTypeMatchingArguments", p0, p1);
	}

	internal static string NoNameMatchingMethodsInQueryable(object p0)
	{
		return SR.GetString("NoNameMatchingMethodsInQueryable", p0);
	}

	internal static string Argument_InvalidId(object p0)
	{
		return SR.GetString("Argument_InvalidId", p0);
	}

	internal static string Argument_InvalidSerializedString(object p0)
	{
		return SR.GetString("Argument_InvalidSerializedString", p0);
	}

	internal static string InvalidTimeZone_InvalidRegistryData(object p0)
	{
		return SR.GetString("InvalidTimeZone_InvalidRegistryData", p0);
	}

	internal static string Security_CannotReadRegistryData(object p0)
	{
		return SR.GetString("Security_CannotReadRegistryData", p0);
	}

	internal static string Serialization_CorruptField(object p0)
	{
		return SR.GetString("Serialization_CorruptField", p0);
	}

	internal static string Serialization_InvalidEscapeSequence(object p0)
	{
		return SR.GetString("Serialization_InvalidEscapeSequence", p0);
	}

	internal static string TimeZoneNotFound_MissingRegistryData(object p0)
	{
		return SR.GetString("TimeZoneNotFound_MissingRegistryData", p0);
	}

	internal static string event_ParallelQueryBegin(object p0, object p1, object p2)
	{
		return SR.GetString("event_ParallelQueryBegin", p0, p1, p2);
	}

	internal static string event_ParallelQueryEnd(object p0, object p1, object p2)
	{
		return SR.GetString("event_ParallelQueryEnd", p0, p1, p2);
	}

	internal static string event_ParallelQueryFork(object p0, object p1, object p2)
	{
		return SR.GetString("event_ParallelQueryFork", p0, p1, p2);
	}

	internal static string event_ParallelQueryJoin(object p0, object p1, object p2)
	{
		return SR.GetString("event_ParallelQueryJoin", p0, p1, p2);
	}
}
