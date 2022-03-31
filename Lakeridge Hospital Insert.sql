/**
	Project Name:	LakeRidge Hospital
	Course:			DBAS 5206-06
	Group:			7
	Members:		Samuel Jeremiah Kayongo-Mutumba Jr
					Katherine Bellman
					Sanjivkumar Patel
	Date:			March 29th 2022
	Title:			Insert Table Scripts
	Purpose:		Insert data into the tables nessessary to demo the hospital system
					Demonstrate all the dependencies, data types and relationships of tables
					Demonstrate table behaviour
**/


--USE 
USE LakeRidgeHospital
GO

--INSERT FINANCIAL_STATUS
INSERT INTO FINANCIAL_STATUS (Provider)
VALUES ( 'Assure' ),
 ( 'Self-Pay' ),
 ( 'ESI' )
GO


--Insert Transaction
INSERT INTO CHARGE_TRANSACTION (STATUS_ID, DATE, PAID)
VALUES (
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Self-Pay'),
	GETDATE(),
	12000
)
GO

-- Insert Patient
INSERT INTO PATIENT (PATIENT_NAME, PATIENT_ADDRESS,CITY,PROVINCE, POSTAL_CODE, TELEPHONE,SEX,STATUS_ID)
VALUES (
	'Baker, Mary A',
	'300 Oak St.',
	'Oshawa',
	'ON',
	'L1Y-1V1',
	'905-555-5555',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
	'Smith, John W',
	'100 King St.',
	'Toronto',
	'ON',
	'M1K-1J1',
	'416-645-5655',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Assure')
),
(
	'Cook, Ashley L',
	'80 Queen St.',
	'Oshawa',
	'ON',
	'L1Y-1V1',
	'905-555-5555',
	'Other',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Self-Pay')
),
(
	'Baker, Mary A',
	'300 Oak St.',
	'Oshawa',
	'ON',
	'L1Y-1V1',
	'905-555-5555',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
)
GO

-- Insert Appointment
INSERT INTO APPOINTMENT (PATIENT_NUMBER, TIME, DESCRIPTION )
VALUES (
	(SELECT PATIENT_NUMBER FROM PATIENT WHERE PATIENT_NAME = 'Baker, Mary A' ),
	GETDATE(),
	'Allergic reaction to peanuts'
)
GO

-- Insert User Type 
INSERT INTO USER_TYPE (USER_TYPE)
VALUES --Admin
( 'Admin' ),
--Physician
( 'Physician' ),
--Nurse
( 'Nurse' ),
--Dentist
( 'Dentist' ),
--Receptionist
( 'Reception' ),
--Accountant
( 'Accountant' ),
--Pharmicist
( 'Pharmicist' )
GO

-- Insert User
INSERT INTO DB_USER (USER_TYPE_NUMBER , PASSWORD) 
VALUES 
( (SELECT USER_TYPE_NUMBER FROM USER_TYPE WHERE USER_TYPE = 'Physician' ), '5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8'  )
GO

-- Insert table of different specialties
INSERT INTO PHYSICIAN_SPECIALTY 
VALUES 
( 'P', 'Paediatrics'),
( 'DT', 'Dentistry'),
( 'ORT', 'Orthopedics'),
( 'NRY', 'Neurology'),
( 'GYN', 'Gynecology'),
( 'END', 'Endocrinology'),
( 'DER', 'Dermatology'),
( 'OC', 'Oncology'),
( 'RD', 'Radiology'),
( 'VIR', 'Virology'),
( 'RS', 'Respiratory'),
( 'MT', 'Meternal-Fetal'),
( 'SER', 'Serology'),
( 'T', 'Trauma'),
( 'M', 'Mental')
GO

--Insert physcians
INSERT INTO PHYSICIAN (USER_ID, PHYSICIAN_NAME, TELEPHONE, SPECIALTY_ID)
VALUES	( 100, 'M. D. Thayer', '250-555-4444', 'P' ),
		( 101, 'M. D. Green', '905-721-4964', 'VIR' ),
		( 102, 'M. D. Sooknanan', '905-697-3607', 'T' ),
		( 103, 'M. D. Shrives', '905-623-2570', 'GYN' ),
		( 104, 'M. D. Koziar', '905-732-0121', 'MT' ),
		( 105, 'M. D. Mahmud', '519-657-5434', 'M' ),
		( 106, 'M. D. Grant', '905-623-2783', 'P' ),
		( 107, 'M. D. Niro', '905-579-1212', 'P' )
GO

--Insert Diagnosis
INSERT INTO DIAGNOSIS (DIAGNOSIS)
VALUES ( 'HIV' )
GO

--Insert Treatment
INSERT INTO TREATMENT (DIAGNOSIS_NUMBER, PHYSICIAN_NUMBER, PATIENT_NUMBER, DESCRIPTION )
VALUES (
	100,
	100,
	100000,
	'Ibprofen'
)GO

--Insert room type
INSERT INTO ROOM_TYPE 
VALUES ( 'SP', 'SemiPrivate' ),
( 'PR', 'Private' ),
( 'IC', 'Intensive Care' ),
( 'W3', 'Ward, 3 Beds' ),
( 'W4', 'Ward, 4 Beds' )GO

--Insert Room
INSERT INTO ROOM 
VALUES ( 100, 'SP' ),
 ( 101, 'SP' ),
 ( 102, 'SP' ),
 ( 103, 'SP' ),
 ( 104, 'SP' ),
 ( 200, 'PR' ),
 ( 210, 'PR' ),
 ( 328, 'W3' ),
 ( 328, 'W3' ),
 ( 329, 'W3' ),
 ( 330, 'W4' ),
 ( 500, 'IC' ),
 ( 300, 'SP' )
 GO

-- Insert Beds
INSERT INTO BED 
VALUES (328, 'B', 623 ),
(328, 'A', 622 ),
(100, 'A', 274 ),
(102, 'A', 876 ),
(103, 'A', 320 ),
(330, 'A', 720 ),
(330, 'B', 721 ),
(330, 'C', 722 ),
(330, 'D', 723 ),
(329, 'A', 345 ),
(329, 'C', 196 ),
(550, 'G', 264 ),
(210, 'A', 641 )
GO

--Insert Admission
INSERT INTO ADMISSION( PATIENT_NUMBER, DATE_ADMITTED, DATE_DISCHARGED, ROOM_NUMBER, BED_CHAR)
VALUES ( (SELECT PATIENT_NUMBER FROM PATIENT WHERE PATIENT_NAME = 'Baker, Mary A' ), 
	GETDATE(),
	NULL,  --Has not yet been discharged
	328,
	'B'
)
GO

--Insert Cost Center
INSERT INTO COST_CENTER (DEPARTMENT_NAME) 
VALUES ('Entertainment'),
('Room & Board'),
('Laboratory'),
('Pharmacy')
GO

--Insert Item
INSERT INTO ITEM (COST_CENTER_NUMBER, DESCRIPTION, CHARGE)
VALUES ( 2, 'Semiprivate Room', 200.00 ),
( 1, 'Television', 5.00 ),
( 4, 'Glucose', 25.00 ),
( 4, 'Culture', 20.00 ),
( 3, 'Chest X-ray', 30.00 )
GO

--Insert Charges
INSERT INTO CHARGE (ADMISSION_NUMBER, ITEM_CODE, QUANTITY, DATE_CHARGED )
VALUES ( 1000000, (SELECT ITEM_CODE FROM ITEM WHERE DESCRIPTION = 'Semiprivate Room'), 3, GETDATE()),
( 1000000, (SELECT ITEM_CODE FROM ITEM WHERE DESCRIPTION = 'Television'), 1, GETDATE()),
( 1000000, (SELECT ITEM_CODE FROM ITEM WHERE DESCRIPTION = 'Culture'), 1, GETDATE())
GO

--Insert Note 
INSERT INTO NOTE (ADMISSION_NUMBER, ENTRY)
VALUES (1000000, 'This note is to confirm that Baker, Mary A, she is suffering from allergies and I recommend you to allow her to discontinue classes for two months.')
GO

--Insert Admission line item
INSERT INTO ADMISSION_LINE_ITEM
VALUES (
	1000000,
	100
)
GO

--Insert Transaction line item
INSERT INTO TRANSACTION_LINE_ITEM 
VALUES ( 1000 , 100000 )
GO