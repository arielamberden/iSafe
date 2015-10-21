DROP TABLE login_sha2;
DROP TABLE ordrln;
DROP TABLE ordr;
DROP TABLE product;
DROP TABLE user;

CREATE TABLE user (
	ID INT NOT NULL AUTO_INCREMENT,
    email VARCHAR(50),
	CONSTRAINT user_pk PRIMARY KEY (ID),
    CONSTRAINT user_ck UNIQUE (email)
);

CREATE TABLE login_sha2 (
	ID INT,
	salt VARBINARY (10),
	pswrd VARBINARY(32),
	usrName VARCHAR(50),
    CONSTRAINT login_sha2_pk PRIMARY KEY (usrName),
	CONSTRAINT login_sha2_fk FOREIGN KEY (ID) REFERENCES user(ID)
);
	
CREATE TABLE ordr (
	ID INT,
    ordrDate DATE,
    soldBy VARCHAR(50),
    CONSTRAINT ordr_pk PRIMARY KEY (ID, ordrDate),
    CONSTRAINT ordr_fk FOREIGN KEY (ID) REFERENCES user(ID)
);

CREATE TABLE product (
	prodID VARCHAR(50),
    prodName VARCHAR(50),
    CONSTRAINT product_pk PRIMARY KEY (prodID)
);

CREATE TABLE ordrln (
	ID INT,
    ordrDate DATE,
    prodID VARCHAR(50),
    quantity INT,
    price DOUBLE,
    CONSTRAINT ordrln_pk PRIMARY KEY (ID, ordrDate, prodID),
    CONSTRAINT ordln_fk1 FOREIGN KEY (ID, ordrDate) REFERENCES ordr(ID, ordrDate),
    CONSTRAINT ordln_fk2 FOREIGN KEY (prodID) REFERENCES product(prodID)
);
    
