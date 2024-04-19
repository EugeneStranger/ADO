USE PoliceDB_321
GO

CREATE TABLE ResponsibilitiyTypes
(
	[type_id]		TINYINT NOT NULL PRIMARY KEY,
	[type_name]	NVARCHAR(256) NOT NULL,
)


CREATE TABLE Responsibilities
(
	responsibility_id			SMALLINT NOT NULL PRIMARY KEY,
	responsibility_type			TINYINT NOT NULL FOREIGN KEY REFERENCES ResponsibilitiyTypes (type_id),
	responsibility_duration		DATE,
	penalty						SMALLMONEY
)


CREATE TABLE [dbo].[Violations]
(
	[violation_id]				SMALLINT		NOT NULL PRIMARY KEY,
	[violation_description]		NVARCHAR(1024)	NOT NULL,
	[violation_start_date]		DATE
)


CREATE TABLE ViolationsResponsibilitiesRelation
(
	violation		SMALLINT NOT NULL,
	responsibility	SMALLINT NOT NULL,
	CONSTRAINT PK_VRR PRIMARY KEY (violation, responsibility),
	CONSTRAINT FK_VRR_Violation FOREIGN KEY (violation) REFERENCES Violations (violation_id),
	CONSTRAINT FK_VRR_Responsibilities FOREIGN KEY (responsibility) REFERENCES Responsibilities (responsibility_id)	
)