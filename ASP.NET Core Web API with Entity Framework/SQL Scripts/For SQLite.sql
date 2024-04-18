-- Example for a standard table schema in SQLite database
CREATE TABLE Person (
    Id TEXT PRIMARY KEY DEFAULT (lower(hex(randomblob(4))) || '-' || lower(hex(randomblob(2))) || '-4' || substr(lower(hex(randomblob(2))),2) || '-' || substr('89ab',abs(random()) % 4 + 1, 1) || substr(lower(hex(randomblob(2))),2) || '-' || lower(hex(randomblob(6)))), -- The value is set automatically by the database
    Name TEXT,
    Age INTEGER,
    Gender INTEGER, -- 1 stands for "Male", and 0 stands for "Female"
    Height REAL,
    LastModifiedTime DATETIME DEFAULT CURRENT_TIMESTAMP -- The value is set automatically by the database
);
