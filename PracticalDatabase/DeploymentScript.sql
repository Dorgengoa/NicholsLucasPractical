CREATE DATABASE PracticalDatabase;
GO

CREATE TABLE StudentFactTemplates (
	ID int IDENTITY(1,1),
	SubmittingAUN int,
	SchoolYearDate DateTime,
	PASecureID int,
	ReportingDate DateTime,
	Collection varchar(255),
	MeasureType varchar(255),
	ACT16FundCategory int,
);