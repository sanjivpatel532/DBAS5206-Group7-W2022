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
--  Patient 100
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
--  Patient 101
	'Perkins, John M',
	'4315 James St.',
	'Mount Pleasant',
	'ON',
	'N0E-1K0',
	'519-484-8730',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
--	Patient 102
	'Smith, John W',
	'100 King St.',
	'Toronto',
	'ON',
	'M1K-7J1',
	'416-645-5655',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Assure')
),
(
-- Patient 103
	'Cook, Ashley L',
	'80 Queen St.',
	'Oshawa',
	'ON',
	'L1P-3T1',
	'416-557-8585',
	'Other',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Self-Pay')
),
(
-- Patient 104
	'Blaker, Laura K',
	'7 Scugog St.',
	'Oshawa',
	'ON',
	'L1R-4E6',
	'905-867-6442',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 105
	'Butler, Sandy J',
	'3010 Eglinton Ave.',
	'Toronto',
	'ON',
	'M4P-1A6',
	'416-569-4113',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Assure')
),
(
-- Patient 106
	'McKeon, Joseph B',
	'2252  Leduc St.',
	'Vankleek Hill',
	'ON',
	'K0B-1R0',
	'613-676-9927',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Self-Pay')
),
(
-- Patient 107
	'Potts, Donna J',
	'3174 Fallon Dr.',
	'Neustadt',
	'ON',
	'N0G-2M0',
	'519-799-4878',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 108
	'Fabian, Elizabeth R',
	'427 Central Pkwy',
	'Erin Mills',
	'ON',
	'L5L-3A1',
	'905-828-2202',
	'Other',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Assure')
),
(
-- Patient 109
	'Moore, Ethel D',
	'2934 40th St.',
	'Calgary',
	'AB',
	'T2A-1C8',
	'403-204-3709',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 110
	'Backster, Addi A',
	'2626 chemin Hudson',
	'Montreal',
	'QC',
	'H4J-1M9',
	'514-291-8633',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Assure')
),
(
-- Patient 111
	'Jordon, Eileen N',
	'987 Summerfield Blvd',
	'Camrose',
	'AB',
	'T4V-1V4',
	'780-678-9373',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Self-Pay')
),
(
-- Patient 112
	'Cartier, David H',
	'3985 2nd Street',
	'Lac Du Bonnet',
	'MB',
	'R0E-1A0',
	'204-345-1753',
	'Other',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 113
	'Hinkson, Aaron L',
	'2691 Ostrea Lake Rd',
	'Musquodoboit Harbour',
	'NS',
	'B0J-2L0',
	'902-878-1402',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 114
	'Pilon, Norma J',
	'2430 Albert Street',
	'Aylmer',
	'ON',
	'N5H-1L2',
	'519-779-4169',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 115
	'Snyder, James R',
	'332 Reserve St',
	'Coe Hill',
	'ON',
	'K0L-1P0',
	'613-337-4512',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 116
	'Omara, Greta J',
	'3531 Weston Rd',
	'Toronto',
	'ON',
	'M9N-1G4',
	'416-333-5038',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Assure')
),
(
-- Patient 117
	'Stiver, Alex C',
	'2575 Merivale Road',
	'Ottawa',
	'ON',
	'K2G-3K2',
	'613-225-0790',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 118
	'Jones, James B',
	'18 Garafraxa St',
	'Oshawa',
	'ON',
	'N0H 2R0',
	'519-596-0609',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 119
	'Weber, Bart D',
	'4769 Landon St.',
	'Verner',
	'ON',
	'P0H-2M0',
	'705-594-3243',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Self-Pay')
),
(
-- Patient 120
	'Whitby, Debra R',
	'4545 Pitt St',
	'Cornwall',
	'ON',
	'K6J 3R2',
	'613-933-0139',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 121
	'Servantes, Helen C',
	'807 Pitt St',
	'Oshawa',
	'ON',
	'K6J-3R2',
	'613-936-2494',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 122
	'Terry, Cora D',
	'3940 Lynden Road',
	'Wasaga Beach',
	'ON',
	'L0L-2P0',
	'705-422-2502',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Assure')
),
(
-- Patient 123
	'Bales, Natacha S',
	'2333 Dufferin St.',
	'Toronto',
	'ON',
	'M6H-4B6',
	'416-539-2319',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 124
	'Holderman, Anna R',
	'2619 102nd Ave.',
	'Trail',
	'BC',
	'V1R-3W5',
	'250-231-8630',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 125
	'Hou, Ai',
	'4279 Matheson St',
	'Kenora',
	'ON',
	'P9N-1T8',
	'807-468-9826',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 126
	'Yin, Manchu',
	'1615 Côte Joyeuse',
	'St Raymond',
	'QC',
	'H0H-0H0',
	'418-340-8860',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Self-Pay')
),
(
-- Patient 127
	'Santos, Luiz S',
	'1131 Eglinton Avenue',
	'Toronto',
	'ON',
	'M4P-1A6',
	'416-488-4892',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
),
(
-- Patient 128
	'Barros, Guilherme P',
	'1135 Davis Drive',
	'Welland',
	'ON',
	'L3B-3Z6',
	'905-714-6203',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Assure')
),
(
-- Patient 129
	'Kanaan, Husain K',
	'2985 St. John Street',
	'Weldon',
	'SK',
	'S4P-3Y2',
	'905-555-5555',
	'Female',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'Self-Pay')
),
(
-- Patient 130
	'Laker, Hans A',
	'3531 Weston Rd.',
	'Ajax',
	'ON',
	'M9N-1G4',
	'416-242-2987',
	'Male',
	(SELECT STATUS_ID FROM FINANCIAL_STATUS WHERE PROVIDER = 'ESI')
)
GO

-- Insert Appointment
INSERT INTO APPOINTMENT (PATIENT_NUMBER, TIME, DESCRIPTION )
VALUES (
	(SELECT PATIENT_NUMBER FROM PATIENT WHERE PATIENT_NAME = 'Baker, Mary A' ),
	GETDATE(),
	'Allergic reaction to peanuts'
), (
	(SELECT PATIENT_NUMBER FROM PATIENT WHERE PATIENT_NAME = 'Yin, Manchu' ),
	GETDATE(),
	'Cancer treatments'
),(
	(SELECT PATIENT_NUMBER FROM PATIENT WHERE PATIENT_NAME = 'Kanaan, Husain K' ),
	GETDATE(),
	'Abdominal Pain, Gastroscopy investigation'
),(
	(SELECT PATIENT_NUMBER FROM PATIENT WHERE PATIENT_NAME = 'Santos, Luiz S' ),
	GETDATE(),
	'General weakness, lab tests for cause'
),(
	(SELECT PATIENT_NUMBER FROM PATIENT WHERE PATIENT_NAME = 'Servantes, Helen C' ),
	GETDATE(),
	'3 months Pregnancy mark ultra-sound'
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
INSERT INTO PHYSICIAN_SPECIALTY (SPECIALTY_ID, SPECIALTY)
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
VALUES	
-- Physician 100
		( 100, 'M. D. Thayer', '250-555-4444', 'P' ),
-- Physician 101
		( 101, 'M. D. Green', '905-721-4964', 'VIR' ),
-- Physician 102
		( 102, 'M. D. Sooknanan', '905-697-3607', 'T' ),
-- Physician 103
		( 103, 'M. D. Shrives', '905-623-2570', 'GYN' ),
-- Physician 104
		( 104, 'M. D. Koziar', '905-732-0121', 'MT' ),
-- Physician 105
		( 105, 'M. D. Mahmud', '519-657-5434', 'M' ),
		( 106, 'M. D. Grant', '905-623-2783', 'P' ),
-- Physician 107
		( 107, 'M. D. Niro', '905-579-1212', 'R' )
GO

--Insert Diagnosis
INSERT INTO DIAGNOSIS (DIAGNOSIS)
VALUES 
-- 100
( 'HIV' ),
-- 101
('Cancer'), 
-- 102
('Chrones'),
-- 103
('Anemia'),
-- 104
('Pregnancy')
GO

--Insert Treatment
INSERT INTO TREATMENT (DIAGNOSIS_NUMBER, PHYSICIAN_NUMBER, PATIENT_NUMBER, DESCRIPTION )
VALUES (
	100,
	100,
	100000,
	'Ibprofen'
),
	(101,
	107,
	1000001,
	'Chemo Therapy Radiation')
GO

--Insert room type
INSERT INTO ROOM_TYPE (ROOM_TYPE_ID, DESCRIPTION)
VALUES ( 'SP', 'SemiPrivate' ),
( 'PR', 'Private' ),
( 'IC', 'Intensive Care' ),
( 'W3', 'Ward, 3 Beds' ),
( 'W4', 'Ward, 4 Beds' )GO

--Insert Room
INSERT INTO ROOM (ROOM_NUMBER, ROOM_TYPE_NUMBER)
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
INSERT INTO BED(ROOM_NUMBER, BED_CHAR, EXTENSION) 
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
VALUES 
--	1000000
( (SELECT PATIENT_NUMBER FROM PATIENT WHERE PATIENT_NAME = 'Baker, Mary A' ), 
	GETDATE(),
	NULL,  --Has not yet been discharged
	328,
	'B'
),
--	1000001
( (SELECT PATIENT_NUMBER FROM PATIENT WHERE PATIENT_NAME = 'Yin, Manchu' ), 
	GETDATE(),
	NULL,  --Has not yet been discharged
	303,
	'B'
)
GO

--Insert Cost Center
INSERT INTO COST_CENTER (DEPARTMENT_NAME) 
VALUES 
--	1
('Entertainment'),
--	2
('Room & Board'),
--	3
('Laboratory'),
--	4
('Pharmacy'),
--	5
('Radiology')
GO

--Insert Item
INSERT INTO ITEM (COST_CENTER_NUMBER, DESCRIPTION, CHARGE)
VALUES ( 2, 'Semiprivate Room', 200.00 ),
( 1, 'Television', 5.00 ),
( 4, 'Glucose', 25.00 ),
( 3, 'Culture', 20.00 ),
( 5, 'Chest X-ray', 30.00 ),
(5, 'Chemo Therapy', 10.00),
(2, 'Ward, 4 Beds', 50.00),
(2, 'Ward, 3 Beds', 75.00),
(2, 'Private' ,400.00)

GO

--Insert Charges
INSERT INTO CHARGE (ADMISSION_NUMBER, ITEM_CODE, QUANTITY, DATE_CHARGED )
VALUES 
--		'Baker, Mary A'  
( 1000000, (SELECT ITEM_CODE FROM ITEM WHERE DESCRIPTION = 'Semiprivate Room'), 3, GETDATE()),
( 1000000, (SELECT ITEM_CODE FROM ITEM WHERE DESCRIPTION = 'Television'), 1, GETDATE()),
( 1000000, (SELECT ITEM_CODE FROM ITEM WHERE DESCRIPTION = 'Culture'), 1, GETDATE())
--		'Yin, Manchu'
GO

--Insert Note 
INSERT INTO NOTE (ADMISSION_NUMBER, ENTRY)
VALUES (1000000, 'This note is to confirm that Baker, Mary A, she is suffering from allergies and I recommend you to allow her to discontinue classes for two months.'),
(1000001, 'Mr.Yin culture tests returned noting cancer cells, further testing points to prostate, Monthly radiation Treatment sessions have been booked for 4 treatments.')
GO

--Insert Admission line item
INSERT INTO ADMISSION_LINE_ITEM (ADMISSION_NUMBER, PATIENT_NUMBER)
VALUES 
(
	1000000,
	100
),
(
	1000001,
	126
)
GO

--Insert Transaction line item
INSERT INTO TRANSACTION_LINE_ITEM (TRANSACTION_NUMBER, CHARGE_NUMBER)
VALUES ( 1000 , 100000 )
GO