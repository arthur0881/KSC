CREATE TABLE [dbo].[Table]
(
	[GameSeq] INT NOT NULL PRIMARY KEY, 
    [PlayerName] NCHAR(32) NULL, 
    [UsedHero] NCHAR(32) NULL, 
    [Kill_Number] FLOAT NULL, 
    [Death_Number] FLOAT NULL, 
    [Assist_Number] FLOAT NULL, 
    [MinionKill] FLOAT NULL, 
    [Damage] FLOAT NULL, 
    [BeDamage] FLOAT NULL, 
    [KDA] FLOAT NULL, 
    [DamagePerKill] FLOAT NULL, 
    [BeDamagePerDeath] FLOAT NULL, 
    [KillParticipate] FLOAT NULL, 
    [BeKillParticipate] FLOAT NULL
)
