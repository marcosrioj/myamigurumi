IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'ma_identity_db')
    CREATE DATABASE ma_identity_db;
GO

PRINT 'All required databases are checked and created if necessary.';
