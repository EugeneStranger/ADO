USE PoliceDB_321
GO
--DROP TABLE ResponsibilityTypes

CREATE TABLE ResponsibilitiyTypes
(
	type_id		TINYINT NOT NULL PRIMARY KEY,
	type_name		NVARCHAR(256) NOT NULL,
)