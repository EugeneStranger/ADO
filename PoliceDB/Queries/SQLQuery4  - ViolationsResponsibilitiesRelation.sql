CREATE TABLE [dbo].[ViolationsResponsibilitiesRelation] (
    [violation]      SMALLINT NOT NULL,
    [responsibility] TINYINT  NOT NULL,
    CONSTRAINT [PK_VRR] PRIMARY KEY CLUSTERED ([violation] ASC, [responsibility] ASC),
    CONSTRAINT [FK_VRR_Violation] FOREIGN KEY ([violation]) REFERENCES [dbo].[Violations] ([violation_id]),
    CONSTRAINT [FK_VRR_Responsibilities] FOREIGN KEY ([responsibility]) REFERENCES [dbo].[ResponsibilitiyTypes] ([type_id])
);