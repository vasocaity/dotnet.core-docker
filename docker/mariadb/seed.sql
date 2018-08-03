CREATE TABLE mydb.mytable (
	id int NULL AUTO_INCREMENT,
	name varchar(100) NULL,
	PRIMARY KEY (id)
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8
COLLATE=utf8_general_ci;

INSERT INTO mydb.mytable (name) VALUES ('test seed sql');
INSERT INTO mydb.mytable (name) VALUES ('test seed sql 2');
INSERT INTO mydb.mytable (name) VALUES ('test seed sql 3');
INSERT INTO mydb.mytable (name) VALUES ('test seed sql 4');
INSERT INTO mydb.mytable (name) VALUES ('test seed sql 5');