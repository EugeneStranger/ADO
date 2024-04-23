USE PoliceDB_321
GO
--DROP TABLE Responsibilities

CREATE TABLE Responsibilities
(
	responsibility_id			SMALLINT NOT NULL PRIMARY KEY,
	responsibility_type			TINYINT NOT NULL FOREIGN KEY REFERENCES ResponsibilitiyTypes (type_id),
	responsibility_duration		DATE,
	penalty						SMALLMONEY
)