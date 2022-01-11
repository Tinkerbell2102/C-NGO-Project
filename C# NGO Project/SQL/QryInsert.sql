INSERT INTO dbo.Users (Firstname, Lastname, Username, Password, Email, ContactNumber, OrgName, Profile)
VALUES 
('Laikin', 'Barnard', 'LaikinB', 'ctu@2021', 'LaikinB@gmail.com', '0793176158', '', 'Admin'),
('Lerato', 'Pholosi', 'LeratoP', 'ctu@2021', 'LeratoP@gmail.com', '0793835286', '', 'Admin'),
('Brent', 'Van Den Berg', 'Brentvdb', 'ctu@2021', 'Brentvdb@gmail.com', '0814089392', '', 'Donor'),
('Lisa', 'Mcgill', 'LisaMc', 'ctu@2021', 'LisaMc@gmail.com', '0832998888', '', 'Donor'),
('Janice', 'Barnard', 'JaviceB', 'ctu@2021', 'JaviceB@gmail.com', '0827718151', '', 'Donor'),
('Johan', 'Jonk', 'JohanJ', 'ctu@2021', 'JohanJ@gmail.com', '0795734351', '', 'Donor'),
('Leon', 'Viarra', 'LeonV', 'ctu@2021', 'LeonV@gmail.com', '0791080019', '', 'Donor'),
('World Wide Fund for Nature', '', 'WWF', 'ctu@2021', 'WWF@gmail.com', '0223649111', 'World Wide Fund for Nature', 'NGO'),
('Autism-Europe', '', 'AE', 'ctu@2021', 'AE@gmail.com', '0267575051', 'Autism-Europe', 'NGO'),
('Action Against Hunger', '', 'AAH', 'ctu@2021', 'AAH@gmail.com', '0267520551', 'Action Against Hunger', 'NGO'),
('World Food Programme', '', 'WFP', 'ctu@2021', 'WFP@gmail.com', '0267695051', 'World Food Programme', 'NGO'),
('Doctors Without Borders', '', 'DWB', 'ctu@2021', 'DWB@gmail.com', '0896051045', 'Doctors Without Borders', 'NGO'),
('Greenpeace', '', 'GREENP', 'ctu@2021', 'GREENP@gmail.com', '0114824696', 'Greenpeace', 'NGO');

INSERT INTO dbo.NGO (OrgName, NGOREqueset, Request_stat)
VALUES ('World Wide Fund for Nature','Funds', 'Accepted'),
('Autism-Europe' ,'Funds', 'Accepted'), 
('Action Against Hunger','Canned Foods', 'Pending'),
('World Food Programme','Canned Foods', 'Pending'),
('Doctors Without Borders', 'Surgical Equipment', 'Pending'),
('Greenpeace','Funds', 'Accepted');

INSERT INTO dbo.Donors (DonorID, FirstName, LastName,  DonationDet, DonationType, DonAmmount, DonReffrence, DonDate, ContactNumber )
VALUES ('1', 'Brent', 'Van Den Berg', 'RSA Rand', 'Funds', '300', 'World Wide Fund for Nature', '2019-04-05', '0795734351'),
('1', 'Brent', 'Van Den Berg', 'Canned vegetables', 'Canned Foods', '5', 'Action Against Hunger', '2020-02-09', '0814089392'),
('2', 'Lisa', 'Mcgill', 'RSA Rand', 'Funds', '500', 'Autism-Europe', '2019-11-02', '0832998888'),
('3', 'Janice', 'Barnard', 'Canned soups', 'Canned Foods', '9', 'World Food Programme', '2020-05-04', '0826065417'),
('4', 'Johan', 'Jonk', 'Canned tuna', 'Canned Foods', '4', 'Action Against Hunger', '2019-09-24', '0795734351'),
('5', 'Leon', 'Viarra', 'Us Dollar', 'Funds', '250', 'World Wide Fund for Nature', '2019-10-20', '0791080019'),
('5', 'Leon', 'Viarra', 'Gloves', 'Surgical Equipment', '5', 'Doctors Without Borders', '2018-11-30', '0791080019'),
('1', 'Brent', 'Van Den Berg', 'Masks', 'Surgical Equipment', '10', 'Doctors Without Borders', '2020-02-11', '0814089392');

SELECT * FROM dbo.Users
ORDER BY UserID;

SELECT * FROM dbo.NGO
ORDER BY Request_stat;

SELECT * FROM dbo.Donors
ORDER BY DonDate;