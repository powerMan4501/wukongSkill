namespace ArchiveB1;

public enum ReadArchiveResult
{
	Success = 0,
	AppRevisionTooLow = 1,
	DeserializeArchiveFailed = 2,
	CheckMd5Failed = 3,
	RoleDataInvalid = 4,
	FileNotExist = 5,
	Unknown = 10
}
