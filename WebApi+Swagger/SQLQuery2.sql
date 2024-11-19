SET IDENTITY_INSERT Otdels ON

INSERT INTO Otdels(Otdel_ID, Name, Telephone) VALUES (1, 'Первый', '+79234567890');
INSERT INTO Otdels(Otdel_ID, Name, Telephone) VALUES (2, 'Второй', '+7678901234');
INSERT INTO Otdels(Otdel_ID, Name, Telephone) VALUES (3, 'Третий', '+7567540123');
INSERT INTO Otdels(Otdel_ID, Name, Telephone) VALUES (4, 'Четвертый', '+7532890123');

SET IDENTITY_INSERT Otdels OFF

SET IDENTITY_INSERT Educations ON

INSERT INTO Educations(Education_ID, Name) VALUES (1, 'Высшее');
INSERT INTO Educations(Education_ID, Name) VALUES (2, 'Среднее');
INSERT INTO Educations(Education_ID, Name) VALUES (3, 'Неоконченное высшее');

SET IDENTITY_INSERT Educations OFF 

SET IDENTITY_INSERT Positions ON

INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (1, 1, 23000, 0);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (2, 1, 40000, 0);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (3, 2, 40000, 1);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (4, 3, 60000, 1);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (5, 4, 45000, 1);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (6, 5, 15000, 0);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (7, 3, 50000, 1);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (8, 2, 78000, 0);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (9, 4, 25000, 1);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (10, 6, 70000, 0);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (11, 1, 100000,1);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (12, 2, 10000, 0);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (13, 7, 60000, 1);
INSERT INTO Positions(Position_ID, PositionName_ID, Oklad, Status) VALUES (14, 8, 35000, 1);

SET IDENTITY_INSERT Positions OFF 

SET IDENTITY_INSERT Sotruds ON

INSERT INTO Sotruds(Sotrud_ID, Otdel_ID, Position_ID, Education_ID, F_Name,L_Name) VALUES (1, 1, 1, 1, 'Иван',' Иванов');
INSERT INTO Sotruds(Sotrud_ID, Otdel_ID, Position_ID, Education_ID, F_Name,L_Name) VALUES (2, 2, 2, 2, 'Иван',' Федоров');
INSERT INTO Sotruds(Sotrud_ID, Otdel_ID, Position_ID,  Education_ID, F_Name,L_Name) VALUES (3, 3, 3, 1, 'Дмитрий',' Иванов');
INSERT INTO Sotruds(Sotrud_ID, Otdel_ID, Position_ID,  Education_ID, F_Name,L_Name) VALUES (4, 4, 4, 2, 'Александр',' Фомов');
INSERT INTO Sotruds(Sotrud_ID, Otdel_ID, Position_ID,  Education_ID, F_Name,L_Name) VALUES (5, 1, 5, 2, 'Федор',' Булкин');
INSERT INTO Sotruds(Sotrud_ID, Otdel_ID, Position_ID, Education_ID, F_Name,L_Name) VALUES (6, 2, 6, 3, 'Владислав',' Гусь');
INSERT INTO Sotruds(Sotrud_ID, Otdel_ID, Position_ID,  Education_ID, F_Name,L_Name) VALUES (7, 3, 7, 3, 'Евгений',' Дулкин');
INSERT INTO Sotruds(Sotrud_ID, Otdel_ID, Position_ID, Education_ID, F_Name,L_Name) VALUES (8, 4, 8, 3,'Анастасия',' Уткина');
INSERT INTO Sotruds(Sotrud_ID, Otdel_ID, Position_ID,  Education_ID, F_Name,L_Name) VALUES (9, 1, 9, 1, 'Даниил',' Лебедев');

SET IDENTITY_INSERT Sotruds OFF 