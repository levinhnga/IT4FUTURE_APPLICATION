CREATE DATABASE NoteTakingApplication
GO

USE NoteTakingApplication
GO

CREATE TABLE person
(	
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	sex NVARCHAR(100) NOT NULL,
	phone_number NVARCHAR(100) NOT NULL,
	role NVARCHAR(100) NOT NULL, -- Student || Teacher,
)
GO

CREATE TABLE note
(
	id INT IDENTITY PRIMARY KEY,
	tittle NVARCHAR(100) NOT NULL DEFAULT 'CHUA CO TIEU DE',
	content NVARCHAR(100) NOT NULL DEFAULT 'CHUA CO NOI DUNG',

	id_person INT, -- foreign key
	FOREIGN KEY(id_person) REFERENCES person(id)
)
GO




CREATE PROCEDURE NoteAdding
@tittle NVARCHAR(100),
@content NVARCHAR(100),
@id_person INT
AS
BEGIN
	INSERT INTO note(tittle, content, id_person)
	VALUES(@tittle, @content, @id_person)
END
GO

CREATE PROCEDURE NoteDeleting
@tittle NVARCHAR(100)
AS
BEGIN
	DELETE FROM note WHERE tittle = @tittle 
END
GO




CREATE PROCEDURE Person_Adding
@name NVARCHAR(100),
@sex NVARCHAR(100),
@phone_number NVARCHAR(100),
@role NVARCHAR(100)
AS
BEGIN
	INSERT INTO person(name, sex, phone_number, role)
	VALUES(@name, @sex, @phone_number, @role)
END
GO	

CREATE PROCEDURE SelectNote_From_PersonID
@id_person INT
AS
BEGIN	
	SELECT * FROM note WHERE id_person = @id_person
END
GO

CREATE PROCEDURE Person_Deleting
@id INT
AS
BEGIN
		DELETE FROM note WHERE id_person = @id;
		DELETE FROM person WHERE person.id = @id;
END
GO

CREATE PROCEDURE update_person
@name NVARCHAR(100),
@sex NVARCHAR(100),
@phone_number NVARCHAR(100),
@role NVARCHAR(100),
@id_person INT
AS
BEGIN
	UPDATE person
	SET name = @name, sex= @sex, phone_number= @phone_number, role= @role
	WHERE person.id = @id_person
END
GO

CREATE PROCEDURE update_note
@tittle NVARCHAR(100),
@content NVARCHAR(100),
@id INT
AS
BEGIN
	UPDATE note SET tittle = @tittle , content = @content WHERE id = @id
END
GO

DROP PROCEDURE update_note

-- TEST
SELECT * FROM NOTE
EXEC update_note @tittle = 't222', @content = 't', @id_person = 27

EXEC SelectNote_From_PersonID @id_person = 1
DROP PROCEDURE Person_Deleting

EXEC NoteAdding @tittle = 't' , @content = 'test' , @id_person = 1
EXEC Person_Adding @name = 't' , @sex = 'n', @phone_number='a', @role='a'
EXEC Person_Deleting @id = 8
EXEC NoteDeleting @tittle = 'test'

EXEC Person_Adding @name = 't' , @sex = 't', @phone_number = 't', @role= 't', @id_note = 1

SELECT * 
FROM person, note
 WHERE note.id = person.id_note

DROP DATABASE NoteTakingApplication

SELECT * FROM person
GO



EXEC update_person @name='t', @sex='t', @phone_number='t', @role='t', @id_person=27

SELECT tittle, content FROM note WHERE id_person = 26

