CREATE TABLE Users (
    UserID int IDENTITY(1,1) PRIMARY KEY,
	Firstname varchar(255),
    Lastname varchar(255),
    Username varchar(255),
    Password text,
    Email text,
	ContactNumber text,
	OrgName text,
	Profile text
);

CREATE TABLE NGO (
    ID int IDENTITY(1,1) PRIMARY KEY,
    OrgName varchar(255),
    NGOREqueset varchar(255),
    Request_stat varchar(255)
);

CREATE TABLE Donors (
    DonorID int,
    LastName varchar(255),
    FirstName varchar(255),
    DonationDet varchar(255),
    DonationType varchar(255),
	DonAmmount float,
	DonReffrence text,
	DonDate Date,
	ContactNumber text

);