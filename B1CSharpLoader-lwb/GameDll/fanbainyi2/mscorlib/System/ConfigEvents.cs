namespace System;

[Serializable]
internal enum ConfigEvents
{
	StartDocument = 0,
	StartDTD = 1,
	EndDTD = 2,
	StartDTDSubset = 3,
	EndDTDSubset = 4,
	EndProlog = 5,
	StartEntity = 6,
	EndEntity = 7,
	EndDocument = 8,
	DataAvailable = 9,
	LastEvent = 9
}
