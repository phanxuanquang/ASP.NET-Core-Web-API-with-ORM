-- Example for a standard table schema in PostgreSQL database
CREATE TABLE Person (
    Id UUID DEFAULT gen_random_uuid() PRIMARY KEY, -- The value is set automatically by the database
    Name TEXT,
    Age INT,
    Gender BOOLEAN, -- TRUE stands for "Male", and FALSE stands for "Female"
    Height FLOAT,
    LastModifiedTime TIMESTAMP DEFAULT CURRENT_TIMESTAMP, -- The value is set automatically by the database
);
