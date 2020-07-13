CREATE DATABASE QuanLyKetQuaHocTap
GO

USE QuanLyKetQuaHocTap
GO

CREATE TABLE account
(
	id INT IDENTITY PRIMARY KEY,
	username NVARCHAR(100) NOT NULL,
	pass NVARCHAR(100) NOT NULL,
	display_name NVARCHAR(100) NOT NULL DEFAULT 'ANONYMOUS',
	grade NVARCHAR(100) NOT NULL DEFAULT 'NONE',
)
GO

CREATE TABLE subject
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	id_account INT,
	FOREIGN KEY(id_account) REFERENCES account(id)
)

CREATE TABLE marks
(
	id INT IDENTITY PRIMARY KEY,
	diem_mieng FLOAT NOT NULL DEFAULT '0',
	diem_15 FLOAT NOT NULL DEFAULT '0',
	diem_45 FLOAT NOT NULL DEFAULT '0',
	diem_hoc_ki FLOAT NOT NULL DEFAULT '0',
	diem_trung_binh FLOAT NOT NULL DEFAULT '0',
	id_subject INT,
	FOREIGN KEY(id_subject) REFERENCES subject(id)
)
GO

CREATE PROCEDURE insert_account
@username NVARCHAR(100),
@pass NVARCHAR(100),
@display_name NVARCHAR(100),
@grade NVARCHAR(100)
AS
BEGIN
	INSERT INTO account(username, pass, display_name, grade)
	VALUES(@username, @pass, @display_name, @grade)
END
GO



CREATE PROCEDURE insert_subject
@name NVARCHAR(100),
@id_account INT
AS
BEGIN
	INSERT INTO subject(name, id_account)
	VALUES(@name, @id_account)
END
GO

EXEC insert_account @username = 'admin', @pass = 'admin' , @display_name = 'test' , @grade = 't'
GO

SELECT name, diem_mieng, diem_15, diem_30, diem_45 FROM subject , marks 
WHERE subject.id = marks.id_subject AND	marks.id_subject = 3
GO

SELECT * FROM marks

SELECT id , name FROM subject WHERE id_account = 1 AND name='VatLy'

DROP DATABASE QuanLyKetQuaHocTap

SELECT account.display_name, subject.name AS 'Ten mon hoc', marks.diem_mieng , marks.diem_15 
FROM account, subject, marks
WHERE account.id = subject.id_account AND subject.id = marks.id_subject AND account.id = 1
GO

-- UPDATE MARKS
CREATE PROCEDURE update_marks
@diem_mieng FLOAT,
@diem_15 FLOAT,
@diem_45 FLOAT,
@diem_hoc_ki FLOAT,
@diem_trung_binh FLOAT,
@id_subject INT
AS
BEGIN
	UPDATE marks
	SET diem_mieng = @diem_mieng, diem_15 = @diem_15, diem_45 = @diem_45, diem_hoc_ki = @diem_hoc_ki
	WHERE id_subject = @id_subject
END
GO

CREATE PROCEDURE update_marks_average
@diem_trung_binh FLOAT,
@id_subject INT
AS
BEGIN
	UPDATE marks
	SET diem_trung_binh = @diem_trung_binh
	WHERE id_subject = @id_subject
END
GO

DROP PROCEDURE update_marks

EXEC update_marks @diem_mieng = 9 , @id_subject = 1

UPDATE marks
SET diem_mieng = 6
WHERE id_subject = 1

SELECT name, diem_mieng, diem_15, diem_45, diem_hoc_ki, diem_trung_binh FROM subject, marks WHERE subject.id = marks.id_subject  




