CREATE TABLE Employes (
    Code INT PRIMARY KEY IDENTITY,
    Full_name VARCHAR(30),
    Employ_id VARCHAR(10) UNIQUE
);

CREATE TABLE Passwords (
    Id INT PRIMARY KEY IDENTITY,
    User_password VARCHAR(30),
    Password_expiry_date DATE,
    Employe_Code INT FOREIGN KEY REFERENCES Employes(Code),
    Is_active BIT
);

CREATE TABLE Time_clock (
    Id INT PRIMARY KEY IDENTITY,
    entrance_time DATETIME,
    leaving_time DATETIME,
    Employe_Code INT FOREIGN KEY REFERENCES Employes(Code)
);