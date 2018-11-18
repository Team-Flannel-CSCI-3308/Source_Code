CREATE TABLE IF NOT EXISTS user (
    id INT NOT NULL PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL
);


CREATE TABLE IF NOT EXISTS character (
    id INT NOT NULL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    health INT NOT NULL,
    attack INT NOT NULL,
);

CREATE TABLE IF NOT EXISTS inventory (
    id INT NOT NULL PRIMARY KEY FOREIGN KEY,
    item_type_id INT NOT NULL,
    item_name VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS item (
    id INT NOT NULL PRIMARY KEY,
    item_category_id INT NOT NULL FOREIGN KEY,
    name VARCHAR(255) NOT NULL,
    value INT NOT NULL
);

CREATE TABLE IF NOT EXISTS item_category (
    id INT NOT NULL PRIMARY KEY,
    name VARCHAR(255)
);

/* Test Code */
/* Actual implementation in game scripts */

INSERT INTO user(1, billy, password);
INSERT INTO character(1, ipsum, 10, 1);
INSERT INTO inventory(1, 2, sword);
INSERT INTO inventory(2, 1, small_health_potion);
INSERT INTO item(1, 2, sword, 10);
INSERT INTO item_category(1, weapon);
INSERT INTO item_category(2, potion);

SELECT * FROM user;
SELECT * FROM character;
SELECT * FROM inventory;
SELECT * FROM item;
SELECT * FROM item_category;