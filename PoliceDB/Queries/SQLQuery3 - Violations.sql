USE PoliceDB_321

--DROP TABLE Violations

CREATE TABLE [dbo].[Violations]
(
	[violation_id]				SMALLINT		NOT NULL PRIMARY KEY,
	[violation_description]		NVARCHAR(1024)	NOT NULL,
	[violation_start_date]				DATE			NOT NULL,
	--[penalty]					SMALLMONEY
)

--DECLARE @violationsPK NVARCHAR(1024) = 
--(
--		SELECT [name]
--		FROM sys.key_constraints
--		WHERE	type = 'PK'
--		AND		OBJECT_NAME(parent_object_id) = N'Violations'
--)

--PRINT(@violationsPK)

--ALTER TABLE Violations  DROP CONSTRAINT PK__Violatio__8A989363D32C6F19
--ALTER TABLE Violations	ALTER COLUMN [violatin_id] SMALLINT NOT NULL
--ALTER TABLE Violations  ADD CONSTRAINT PK_ViolationID PRIMARY KEY CLUSTERED (violation_id)
--ALTER TABLE Violations ALTER COLUMN [violation_description] NVARCHAR(1024) NOT NULL
--ALTER TABLE Violations ADD penalty SMALLMONEY NULL
--ALTER TABLE Violations ADD [start_date] DATE 