DROP TABLE IF EXISTS address;
DROP TABLE IF EXISTS trnaction;
DROP TABLE IF EXISTS creditcard;
DROP TABLE IF EXISTS checking;
DROP TABLE IF EXISTS customer;
DROP TABLE IF EXISTS merchant;
DROP TABLE IF EXISTS user;

CREATE TABLE user (
	ID INT NOT NULL AUTO_INCREMENT,
    fName VARCHAR(50),
    lName VARCHAR(50),
	CONSTRAINT user_pk PRIMARY KEY (ID)
);

CREATE TABLE merchant (
	mID VARCHAR(50),
	ID INT,
    CONSTRAINT merchant_pk PRIMARY KEY (ID),
    CONSTRAINT merchant_fk FOREIGN KEY (ID) REFERENCES user (ID)
);

CREATE TABLE customer (
	cID VARCHAR(50),
    ID INT,
    CONSTRAINT customer_pk PRIMARY KEY (ID),
    CONSTRAINT customer_fk FOREIGN KEY (ID) REFERENCES user (ID)
);

CREATE TABLE checking (
	accountNum VARCHAR(50),
    routingNum VARCHAR (50),
    ID INT,
    CONSTRAINT checking_pk PRIMARY KEY (accountNum),
    CONSTRAINT checking_fk FOREIGN KEY (ID) REFERENCES merchant (ID)
);

CREATE TABLE creditcard (
	PAN VARCHAR(50),
    CVV VARCHAR(50),
    ccType VARCHAR(50),
    ID INT,
    CONSTRAINT creditcard_pk PRIMARY KEY (PAN),
    CONSTRAINT creditcard_fk FOREIGN KEY (ID) REFERENCES customer (ID)
);

CREATE TABLE trnaction (
	tID INT NOT NULL AUTO_INCREMENT,
    amount DOUBLE,
    dte DATE,
    token VARCHAR(50),
    ID INT,
    CONSTRAINT trnaction_pk PRIMARY KEY (tID),
    CONSTRAINT trnaction_fk FOREIGN KEY (ID) REFERENCES customer (ID)
);
    
CREATE TABLE address (
	city VARCHAR(50),
    street VARCHAR(50),
    zip VARCHAR(50),
    state VARCHAR(50),
    ID INT,
    CONSTRAINT address_pk PRIMARY KEY (city, street, zip, state),
    CONSTRAINT address_fk FOREIGN KEY (ID) REFERENCES user (ID)
);



INSERT INTO user (fName, lName) VALUES 
	('Homer', 'Simpson'),
    ('Peter', 'Griffin'),
    ('Stan', 'Smith'),
    ('Bart', 'Simpson'),
    ('Brian', 'Griffin'),
    ('Roger', 'Smith');
    
INSERT INTO merchant (mID, ID) VALUES
	('100', 1),
    ('200', 2),
    ('300', 3);
    
INSERT INTO customer (cID, ID) VALUES
	('400', 4),
    ('500', 5),
    ('600', 6);
    
INSERT INTO checking (accountNum, routingNum, ID) VALUES
	('11111111111', '22222222222', 1),
    ('33333333333', '44444444444', 1),
    ('55555555555', '66666666666', 2),
    ('77777777777', '88888888888', 3);
    
INSERT INTO creditcard (PAN, CVV, ccType, ID) VALUES
	('123456789', '1111', 'American Express', 4),
    ('234567891', '222', 'Visa', 5),
    ('345678912', '333', 'Visa', 6);
    
INSERT INTO trnaction (amount, dte, token, ID) VALUES
	(100.0, '2015-11-08', 'aaaaaaaaaaa', 4),
    (200.0, '2015-11-08', 'bbbbbbbbbbb', 4),
    (300.0, '2015-11-08', 'ccccccccccc', 5),
    (400.0, '2015-11-09', 'ddddddddddd', 6);
    
INSERT INTO address (city, street, zip, state, ID) VALUES 
	('Springfield', '742 Evergreen Terrace', '9700', 'OR', 1),
    ('Quahog', '31 Spooner Street', '9674', 'RI', 2),
    ('Langley Falls', '43 Cherry Street', '9123', 'VA', 3),
    ('Springfield', '743 Evergreen Terrace', '9700', 'OR', 4),
	('Quahog', '32 Spooner Street', '9674', 'RI', 5),
    ('Langley Falls', '44 Cherry Street', '9123', 'VA', 6);
    
    
    
SELECT fName, lName, mID
 FROM user AS u INNER JOIN merchant AS m ON u.ID = m.ID;
 
SELECT fName, lName, cID
 FROM user AS u INNER JOIN customer AS c ON u.ID = c.ID;
 
SELECT fName, lName, accountNum, routingNum
 FROM user AS u INNER JOIN merchant AS m ON u.ID = m.ID
  INNER JOIN checking AS c ON m.ID = c.ID;
  
SELECT fName, lName, PAN, CVV, ccType
 FROM user AS u INNER JOIN customer AS c ON u.ID = c.ID
  INNER JOIN creditcard AS cc ON c.ID = cc.ID;
  
SELECT fName, lName, amount, dte, token
 FROM user AS u INNER JOIN customer AS c ON u.ID = c.ID
  INNER JOIN trnaction AS t ON c.ID = t.ID;
  
SELECT fName, lName, city, street, zip, state
 FROM user AS u INNER JOIN address AS a ON u.ID = a.ID
